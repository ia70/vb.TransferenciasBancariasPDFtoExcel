Imports Capa_Negocio
Imports System.IO

Public Class GUI_ImportarFormato
    Private Sub btnImportarPDF_Click(sender As Object, e As EventArgs) Handles btnImportarPDF.Click
        Dim Ubicacion As String
        Dim Importar As New N_ImportarFormato

        DialogoArchivo.ShowDialog()
        Ubicacion = DialogoArchivo.FileName

        If Importar.ImportarArchivo(Ubicacion) Then
            msg("Archivo importado: " & Chr(10) & Path.GetFileName(Ubicacion))
        Else
            msg("Error al importar archivo!", 2)
        End If
    End Sub

    Private Sub btnImportarCarpeta_Click(sender As Object, e As EventArgs) Handles btnImportarCarpeta.Click
        Dim Ubicacion As String
        Dim Importar As New N_ImportarFormato
        Dim Archivos As New ArrayList
        Dim Cadena As String = "Archivos importados:" & Chr(10)

        DialogoCarpeta.ShowDialog()
        Ubicacion = DialogoCarpeta.SelectedPath
        Archivos = Importar.ImportarCarpeta(Ubicacion)

        If Archivos.Count > 0 Then
            For Each _s As String In Archivos
                Cadena = Cadena & "-> " & Path.GetFileName(_s) & Chr(10)
            Next
            msg(Cadena)
        Else
            msg("Error al importar archivos!", 2)
        End If
    End Sub
End Class