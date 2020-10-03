Imports Capa_Negocio

Public Class GUI_DetallesGeneral
    Private _Transaccion As New N_Transacciones
    Private _Campos As New N_CamposNombre
    Private _Empleados As New N_Empleados

    Private _Ttransaccion As DataTable
    Private _TCampos As DataTable
    Private _Templeados As DataTable


    Private Sub GUI_DetallesGeneral_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar()
    End Sub

    Public Sub Cargar()
        Dim i As Integer = 1
        _Ttransaccion = _Transaccion.Consulta(V_Transaccion)

        Inicio()

        If _Ttransaccion.Rows(0).Item(0).ToString.Length > 1 Then
            _TCampos = _Campos.Consultar(_Ttransaccion.Rows(0).Item(1).ToString)

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c0.Visible = True
                L_c0.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c0.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1
            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c1.Visible = True
                L_c1.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c1.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1
            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c2.Visible = True
                L_c2.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c2.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1
            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c3.Visible = True
                L_c3.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c3.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1
            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c4.Visible = True
                L_c4.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c4.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1
            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c5.Visible = True
                L_c5.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c5.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c6.Visible = True
                L_c6.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c6.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c7.Visible = True
                L_c7.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c7.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c8.Visible = True
                L_c8.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c8.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c9.Visible = True
                L_c9.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c9.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c10.Visible = True
                L_c10.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c10.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c11.Visible = True
                L_c11.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c11.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c12.Visible = True
                L_c12.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c12.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c13.Visible = True
                L_c13.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c13.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c14.Visible = True
                L_c14.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c14.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c15.Visible = True
                L_c15.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c15.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If
            i += 1

            If _TCampos.Rows(0).Item(i).ToString.Length > 0 Then
                P_c16.Visible = True
                L_c16.Text = _TCampos.Rows(0).Item(i).ToString
                txt_c16.Text = _Ttransaccion.Rows(0).Item(i + 1).ToString
            End If


            If V_Empleados Then
                _Templeados = _Empleados.Consultar(_Ttransaccion.Rows(0).Item(0).ToString)
                Tabla.DataSource = _Templeados
                P_Empleados.Visible = True
            End If
        End If
    End Sub

    Private Sub Inicio(Optional ByVal Valor As Boolean = False)

        P_c0.Visible = Valor
        P_c1.Visible = Valor
        P_c2.Visible = Valor
        P_c3.Visible = Valor
        P_c4.Visible = Valor
        P_c5.Visible = Valor
        P_c6.Visible = Valor
        P_c7.Visible = Valor
        P_c8.Visible = Valor
        P_c9.Visible = Valor
        P_c10.Visible = Valor
        P_c11.Visible = Valor
        P_c12.Visible = Valor
        P_c13.Visible = Valor
        P_c14.Visible = Valor
        P_c15.Visible = Valor
        P_c16.Visible = Valor
        P_Empleados.Visible = Valor

        txt_c0.Text = ""
        txt_c1.Text = ""
        txt_c2.Text = ""
        txt_c3.Text = ""
        txt_c4.Text = ""
        txt_c5.Text = ""
        txt_c6.Text = ""
        txt_c7.Text = ""
        txt_c8.Text = ""
        txt_c9.Text = ""
        txt_c10.Text = ""
        txt_c11.Text = ""
        txt_c12.Text = ""
        txt_c13.Text = ""
        txt_c14.Text = ""
        txt_c15.Text = ""
        txt_c16.Text = ""


    End Sub


End Class