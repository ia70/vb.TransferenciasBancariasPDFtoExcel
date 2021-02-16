Imports System.ComponentModel
Imports System.IO

Public Class GUI_MostrarErrores
    Private Sub GUI_MostrarErrores_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer = 1
        Try
            Tabla.Rows.Clear()
        Catch ex As Exception
        End Try

        Try
            For Each fila As DictionaryEntry In _Errores
                Tabla.Rows.Add(i, fila.Key, fila.Value)
                i += 1
            Next
        Catch ex As Exception
            Tabla.Rows.Clear()
        End Try
    End Sub

    Private Sub btnMoveraCarpeta_Click(sender As Object, e As EventArgs) Handles btnMoveraCarpeta.Click
        Dim carpeta As String
        carpeta = selectFolder()

        'Si no se seleccionó una carpeta sale de ejecución
        If carpeta = "" Then
            Exit Sub
        Else
            carpeta = "\\?\" & carpeta
        End If

        'Se recorre el datagridview TABLA
        For Each linea As DataGridViewRow In Tabla.Rows
            MoverArchivo(linea.Cells(1).Value, carpeta)
        Next

        msg("¡Archivos movidos!")

    End Sub

    'Función para mover archivo
    Private Sub MoverArchivo(ByVal url As String, ByVal carpeta As String)
        Dim ubicacion As String = carpeta & "\" & Path.GetFileName(url)

        Try
            File.Move(url, ubicacion)
        Catch ex As Exception
            msg(ex.ToString)
        End Try
    End Sub

    Private Function selectFolder() As String
        Dim cp As String
        Try
            diaCarpeta.ShowDialog()
            cp = diaCarpeta.SelectedPath
            Return cp
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class