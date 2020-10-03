Imports System.IO
Imports Capa_Identidad
Imports Capa_Datos

Public Class N_ImportarFormato
#Region "Variables"
    Private _Ubicacion As String

#End Region
#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(Ubicacion As String)
        Me.Ubicacion = Ubicacion
    End Sub

#End Region
#Region "Propiedades"
    Public Property Ubicacion As String
        Get
            Return _Ubicacion
        End Get
        Set(value As String)
            _Ubicacion = value
        End Set
    End Property

#End Region
#Region "Funciones"
#Region "Públicas"
    ''' <summary>
    ''' Importar archivo de formato
    ''' </summary>
    ''' <param name="_Path">Archivo</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function ImportarArchivo(ByVal _Path As String) As Boolean
        If Importar(_Path) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Importa todos los formatos de una carpeta
    ''' </summary>
    ''' <param name="_Path">Carpeta</param>
    ''' <returns>Lista de archivos insertados</returns>
    Public Function ImportarCarpeta(ByVal _Path As String) As ArrayList
        Dim Archivos As New ArrayList
        Dim fileNames = My.Computer.FileSystem.GetFiles(_Path, FileIO.SearchOption.SearchAllSubDirectories, "*.nfo")

        For Each fileName As String In fileNames
            If ImportarArchivo(fileName) Then
                Archivos.Add(Path.GetFileName(fileName))
            End If
        Next

        Return Archivos
    End Function

#End Region
#Region "Privadas"
    ''' <summary>
    ''' Importa un archivo de formato
    ''' </summary>
    ''' <param name="_Path">Path del archivo</param>
    Private Function Importar(ByVal _Path As String) As Boolean
        Dim _I_Formato As New I_Formato
        Dim _I_CamposNombre As New I_CamposNombre
        Dim _I_CamposInicio As New I_CamposInicio
        Dim _I_CamposFin As New I_CamposFin

        Dim Formato As New D_Formato
        Dim CamposNombre As New D_CamposNombre
        Dim CamposInicio As New D_CamposInicio
        Dim CamposFin As New D_CamposFin

        Dim i As Integer = 0

        Dim Archivo As New ArrayList

        Try
            Archivo = Leer(_Path)

            If Archivo.Count = 58 Then
                _I_Formato.setValor(0, Archivo.Item(i))
                i += 1
                _I_Formato.setValor(1, Archivo.Item(i))
                i += 1
                _I_Formato.setValor(2, Archivo.Item(i))
                i += 1
                _I_Formato.setValor(3, Archivo.Item(i))
                i += 1
                _I_Formato.setValor(4, Archivo.Item(i))
                i += 1
                _I_Formato.setValor(5, Archivo.Item(i))
                i += 1
                _I_Formato.setValor(6, Archivo.Item(i))
                i += 1

                _I_CamposNombre.Idformato = _I_Formato.Idformato
                _I_CamposNombre.setValor(0, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(1, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(2, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(3, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(4, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(5, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(6, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(7, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(8, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(9, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(10, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(11, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(12, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(13, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(14, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(15, Archivo.Item(i))
                i += 1
                _I_CamposNombre.setValor(16, Archivo.Item(i))
                i += 1

                _I_CamposInicio.Idformato = _I_Formato.Idformato
                _I_CamposInicio.setValor(0, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(1, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(2, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(3, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(4, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(5, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(6, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(7, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(8, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(9, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(10, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(11, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(12, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(13, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(14, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(15, Archivo.Item(i))
                i += 1
                _I_CamposInicio.setValor(16, Archivo.Item(i))
                i += 1

                _I_CamposFin.Idformato = _I_Formato.Idformato
                _I_CamposFin.setValor(0, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(1, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(2, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(3, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(4, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(5, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(6, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(7, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(8, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(9, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(10, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(11, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(12, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(13, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(14, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(15, Archivo.Item(i))
                i += 1
                _I_CamposFin.setValor(16, Archivo.Item(i))

                Formato.Insertar(_I_Formato)
                CamposNombre.Insertar(_I_CamposNombre)
                CamposInicio.Insertar(_I_CamposInicio)
                If CamposFin.Insertar(_I_CamposFin) Then
                    Return True
                End If
                Return False
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Lee archivo de formato y lo convierte en un Array
    ''' </summary>
    ''' <param name="Ubicacion">Path del archivo</param>
    ''' <returns></returns>
    Private Function Leer(ByVal Ubicacion As String) As ArrayList
        Dim objReader As New StreamReader(Ubicacion, Text.Encoding.UTF8)
        Dim sLine As String = ""
        Dim arrText As New ArrayList()

        Try
            sLine = objReader.ReadLine()

            If sLine Is Nothing Then
                Return Nothing
            ElseIf Not sLine.Substring(0, 1) = "F" Then
                Return Nothing
            Else
                arrText.Add(sLine)
            End If

            Do
                sLine = objReader.ReadLine()

                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                ElseIf sLine Is Nothing And arrText.Count = 57 Then
                    sLine = ""
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
        Catch ex As Exception
            Return Nothing
        End Try
        Return arrText
    End Function

#End Region
#End Region



End Class
