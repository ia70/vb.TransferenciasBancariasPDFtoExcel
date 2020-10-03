Imports Capa_Negocio

Public Class GUI_BancoOrigen
    Private Sub GUI_BancoOrigen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim BancoOrigen As New N_Banco
        Dim dbTabla As DataTable

        dbTabla = BancoOrigen.ListaBancoOrigen

        Tabla.DataSource = dbTabla

    End Sub
End Class