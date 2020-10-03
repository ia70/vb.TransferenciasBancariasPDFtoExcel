Imports System.ComponentModel
Imports Capa_Negocio

Public Class GUI_EmpresaEliminar
    Private Tabla As DataTable

    Private Sub GUI_EmpresaEliminar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar()

    End Sub

    Private Sub Cargar()
        Dim db_Empresa As New N_EmpresaExterna
        Dim Linea As DataRow

        Tabla = db_Empresa.Lista

        Lista.Items.Clear()

        For Each Linea In Tabla.Rows
            Lista.Items.Add(Linea.Item(1))
        Next

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim db_Empresa As New N_EmpresaExterna
        Dim db_Vinculo As New N_Vinculo
        Dim ID As Integer

        ID = Val(Tabla.Rows(Lista.SelectedIndex).Item(0))
        If db_Empresa.Eliminar(ID) Then
            db_Vinculo.EliminarEmpresa(ID)
            msg("Empresa eliminada con exito")
            Cargar()
        Else
            msg("Error al intentar eliminar!", 2)
        End If


    End Sub

    Private Sub GUI_EmpresaEliminar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GUI_Inicio.CargarDatos()
    End Sub
End Class