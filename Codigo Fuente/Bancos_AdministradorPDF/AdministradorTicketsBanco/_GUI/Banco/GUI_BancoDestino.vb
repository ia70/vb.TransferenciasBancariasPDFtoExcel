Imports Capa_Negocio

Public Class GUI_BancoDestino
    Private Sub GUI_BancoDestino_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim BancoDestino As New N_Banco
        Dim dbTabla As DataTable

        dbTabla = BancoDestino.ListaBancoDestino

        Tabla.DataSource = dbTabla
    End Sub
End Class