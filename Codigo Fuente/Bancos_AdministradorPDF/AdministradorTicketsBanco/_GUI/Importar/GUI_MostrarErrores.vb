Public Class GUI_MostrarErrores
    Private Sub GUI_MostrarErrores_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer

        Try
            For i = 0 To _No_Errores - 1
                Tabla.Rows.Add()
                Tabla.Item(0, i).Value = i + 1
                Tabla.Item(1, i).Value = _Errores(i, 0)
                Tabla.Item(2, i).Value = _Errores(i, 1)
            Next
        Catch ex As Exception
            Tabla.Rows.Clear()
        End Try
    End Sub
End Class