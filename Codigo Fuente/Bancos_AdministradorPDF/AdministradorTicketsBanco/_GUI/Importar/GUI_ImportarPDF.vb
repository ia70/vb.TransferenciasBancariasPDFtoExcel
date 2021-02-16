Imports Capa_Negocio
Imports System.ComponentModel

Public Class GUI_ImportarPDF
    Private Sub btnImportarPDF_Click(sender As Object, e As EventArgs) Handles btnImportarPDF.Click
        Dim Ubicacion As String
        Dim Importar As New N_ImportarPDF

        _Errores.Clear()
        DialogoArchivo.ShowDialog()
        Ubicacion = DialogoArchivo.FileName

        Importar.ImportarArchivo(Ubicacion)
        If Importar.ListaTransacciones.Count > 0 Then
            msg("Archivos importados: " & Importar.ListaTransacciones.Count.ToString)
        Else
            msg("Error al importar archivo!", 2)
        End If

        '_Errores.Clear()
        _Errores = Importar.Errores
        _No_Errores = Importar.No_Errores

        VerificaErrores()
    End Sub

    Private Sub btnImportarCarpeta_Click(sender As Object, e As EventArgs) Handles btnImportarCarpeta.Click
        Dim Ubicacion As String
        Dim Importar As New N_ImportarPDF
        Dim Archivos As New ArrayList
        Dim Cadena As String = "Archivos importados:" & Chr(10)

        _Errores.Clear()
        DialogoCarpeta.ShowDialog()
        Ubicacion = DialogoCarpeta.SelectedPath

        Importar.ImportarCarpeta(Ubicacion)

        If Importar.ListaTransacciones.Count > 0 Then
            msg("Archivos importados: " & Importar.ListaTransacciones.Count.ToString)
        Else
            msg("Error al importar archivo!", 2)
        End If

        _Errores = Importar.Errores
        _No_Errores = Importar.No_Errores

        VerificaErrores()
    End Sub

    Private Sub GUI_ImportarPDF_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GUI_Inicio.CargarDatos()
    End Sub

    Private Sub VerificaErrores()
        If _No_Errores > 0 Then
            GUI_MostrarErrores.ShowDialog()
        End If
    End Sub
End Class