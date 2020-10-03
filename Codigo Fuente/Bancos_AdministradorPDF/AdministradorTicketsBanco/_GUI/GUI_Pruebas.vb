Imports iTextSharp.text.pdf

Public Class GUI_Pruebas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ArchivoPDF As New PdfReader("docs/" & txtInicio.Text & ".pdf")
        Dim Texto = ""

        For i = 1 To ArchivoPDF.NumberOfPages
            Dim its As New parser.SimpleTextExtractionStrategy
            Texto &= parser.PdfTextExtractor.GetTextFromPage(ArchivoPDF, i, its)
        Next

        txtPDF.Text = Texto
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Cadena As String
        'Dim Inicio As String
        Dim Informacion As New List(Of String())
        Dim Formato(17) As String
        Dim Respuesta(17) As String

        Formato(0) = "Clave de Rastreo"
        Formato(1) = "Cuenta/ CLABE Ordenante"
        Formato(2) = "Transferencias a Cuentas de Terceros"
        Formato(3) = "Nombre del Ordenante"
        Formato(4) = "RFC Ordenante"
        Formato(5) = "Cuenta/ CLABE Beneficiario"
        Formato(6) = "Transferencias a Cuentas de Terceros"
        Formato(7) = "Nombre del Beneficiario"
        Formato(8) = "RFC Beneficiario"
        Formato(9) = "Propósito de la Transferencia"
        Formato(10) = "."
        Formato(11) = "."
        Formato(12) = "."
        Formato(13) = "Número de Referencia"
        Formato(14) = "."
        Formato(15) = "Importe a Transferir"
        Formato(16) = "Fecha de Ejecución"
        Formato(17) = "."

        Informacion.Add(Formato)


        Cadena = txtPDF.Text


        Respuesta = Buscar(Cadena, Informacion(0))

        MsgBox(Respuesta.ToString)

    End Sub

    Public Function Buscar(ByVal Cadena As String, ByVal Informacion() As String) As String()
        Dim Inicio As Integer
        Dim Fin As Integer
        Dim Respuesta(17) As String

        For i = 0 To 17
            Inicio = 0
            Fin = 0

            If Not Informacion(i) = "." Then

                Inicio = InStr(Cadena, Informacion(i))
                Inicio = Inicio + Informacion(i).Length

                Fin = InStr(Inicio, Cadena, Chr(10))

                If Fin - Inicio < 3 Then
                    Fin = InStr(Inicio + 1, Cadena, Chr(10))
                End If

                Respuesta(i) = Cadena.Substring(Inicio, Fin - (Inicio + 1))


            Else
                Respuesta(i) = "."
            End If
        Next



        Return Respuesta
    End Function

    Private Sub Conexion()

    End Sub

    'Private DB As New D_Transaccion
    'Private Obj As New I_Transaccion

    Private Sub Cargar()
        'Tabla.DataSource = DB.Lista
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click

        Cargar()

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        'With Obj
        '.idtransaccion = txtInsertar.Text
        '.C0 = "dfs"
        '.C4 = "ghjkgh"
        '.C8 = "."
        '.C9 = 10
        '.C10 = "."
        '.C11 = "."
        '.C12 = "."
        '.C13 = "."
        '.C14 = 2580.56
        '.C15 = "."
        '.C16 = "sdfsdf"
        'End With

        'DB.Insertar(Obj)

        Cargar()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        'Tabla.DataSource = DB.Consulta(txtConsulta.Text)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        'With Obj
        '.idtransaccion = txtEditar.Text
        '.C0 = "EEEEE"
        '.C4 = "ghjkgh"
        '.C8 = "."
        '.C9 = 10
        '.C10 = "SDFGDSFG456"
        '.C11 = "."
        '.C12 = "."
        '.C13 = "."
        '.C14 = 5520.14
        '.C15 = "."
        '.C16 = "sdfsdf"
        'End With

        'DB.Editar(Obj)

        Cargar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'Tabla.DataSource = DB.Eliminar(txtEliminar.Text)

        Cargar()
    End Sub
End Class
