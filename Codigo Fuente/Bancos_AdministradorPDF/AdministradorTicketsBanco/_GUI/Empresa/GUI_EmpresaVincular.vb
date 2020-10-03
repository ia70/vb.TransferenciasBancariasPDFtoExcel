Imports Capa_Negocio
Imports Capa_Identidad

Public Class GUI_EmpresaVincular
    Private db_ListaEmpresas As DataTable
    Private db_ListaVinculo As DataTable
    Private db_ListaBancos As DataTable

    Private vEmpresa As Integer
    Private vCuenta As String

    Private Sub CargarBancoOrigen()
        Dim BO As New N_Banco

        db_ListaBancos = BO.Lista

        ListaBancos.DataSource = db_ListaBancos

        If ListaBancos.Rows.Count = 0 Then
            btnAgregarCuenta.Enabled = False
        End If
    End Sub

    Private Sub CargarVinculo()
        Dim db_Vinculo As New N_Vinculo
        Dim ID As Integer

        On Error Resume Next
        ID = Val(db_ListaEmpresas.Rows(txtListaEmpresas.SelectedIndex).Item(0))

        On Error Resume Next
        db_ListaVinculo = db_Vinculo.ListaCuentas(ID)

        ListaVinculo.DataSource = db_ListaVinculo

    End Sub

    Public Sub CargarDatosComboBox()

        Dim db_Empresa As New N_EmpresaExterna

        db_ListaEmpresas = db_Empresa.Lista

        txtListaEmpresas.Items.Clear()

        For Each Linea As DataRow In db_ListaEmpresas.Rows
            txtListaEmpresas.Items.Add(Linea.Item(1).ToString)
        Next

        On Error Resume Next
        txtListaEmpresas.SelectedIndex = 0

        ActualizarCampos()

    End Sub

    Private Sub ActualizarCampos()
        On Error Resume Next
        txtEmpresa.Text = txtListaEmpresas.SelectedItem
        On Error Resume Next
        vEmpresa = Val(db_ListaEmpresas.Rows(txtListaEmpresas.SelectedIndex).Item(0))
        txtRFC.Text = db_ListaEmpresas.Rows(txtListaEmpresas.SelectedIndex).Item(2).ToString
    End Sub

    Private Sub GUI_EmpresaVincular_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarDatosComboBox()
        CargarVinculo()
        CargarBancoOrigen()

        If txtEmpresa.Text = "" Then
            btnAgregarCuenta.Enabled = False
        End If
    End Sub

    Private Sub txtListaEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtListaEmpresas.SelectedIndexChanged
        ActualizarCampos()
        CargarVinculo()
    End Sub

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        Dim dbVinculo As New N_Vinculo
        Dim iVinculo As New I_Vinculo
        Dim Cuenta As String = ""

        On Error Resume Next
        Cuenta = ListaBancos.Item(0, ListaBancos.CurrentRow.Index).Value
        If Cuenta.Length = 0 Then
            Exit Sub
        End If

        For Each Linea As DataGridViewRow In ListaVinculo.Rows
            If Linea.Cells(0).Value = Cuenta Then
                msg("La cuenta ya está vinculada!", 1)
                Exit Sub
            End If
        Next


        iVinculo.Idempresa_externa = vEmpresa
        iVinculo.Numero_cuenta = Cuenta

        If dbVinculo.Insertar(iVinculo) Then
            CargarVinculo()
            msg("Cuenta agregada!")

        Else
            msg("Cuenta no agregada!", 2)
        End If
    End Sub

    Private Sub txtEmpresa_Click(sender As Object, e As EventArgs) Handles txtEmpresa.Click

    End Sub

    Private Sub txtEmpresa_TextChanged(sender As Object, e As EventArgs) Handles txtEmpresa.TextChanged
        If txtEmpresa.Text = "" Then
            btnAgregarCuenta.Enabled = False
        Else
            btnAgregarCuenta.Enabled = True
        End If
    End Sub
End Class