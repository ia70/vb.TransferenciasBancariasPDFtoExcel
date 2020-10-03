Imports System.ComponentModel
Imports Capa_Negocio

Public Class GUI_EmpresaAgregar
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim _N_Empresa As New N_EmpresaExterna

        If _N_Empresa.Insertar(txtRazonsocial.Text, txtRFC.Text, txtDescripcion.Text) Then
            msg("Empresa Guardada!")
            Limpiar()
        Else
            msg("Error al intentar guardar datos!", 2)
        End If
    End Sub

    Private Sub Limpiar()
        txtRazonsocial.Text = ""
        txtRFC.Text = ""
        txtDescripcion.Text = ""

        txtRazonsocial.Select()
    End Sub

    Private Sub GUI_EmpresaAgregar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GUI_Inicio.CargarDatos()
    End Sub
End Class