Imports iTextSharp.text.pdf
Imports System.IO
Imports Capa_Identidad
Imports Capa_Datos

Public Class N_ImportarPDF
#Region "Variables"
    Private Formato As DataTable
    Private CamposNombre As DataTable
    Private CamposInicio As DataTable
    Private CamposFin As New DataTable
    Private _ListaTransacciones As New List(Of I_Transaccion)
    Public Errores As Hashtable
    Public No_Errores As Integer = 0

#End Region
#Region "Constructor"
    Public Sub New()
        Errores = New Hashtable
        CargarDatos()
    End Sub

#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Obtiene / establece lista de transacciones
    ''' </summary>
    ''' <returns></returns>
    Public Property ListaTransacciones As List(Of I_Transaccion)
        Get
            Return _ListaTransacciones
        End Get
        Set(value As List(Of I_Transaccion))
            _ListaTransacciones = value
        End Set
    End Property

#End Region
#Region "Funciones"
#Region "Públicas"
    ''' <summary>
    ''' Importar archivo de reporte bancario
    ''' </summary>
    ''' <param name="_Path">Archivo</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function ImportarArchivo(ByVal _Path As String) As Boolean
        If Importar("\\?\" & _Path) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Importa todos los archivos de una carpeta
    ''' </summary>
    ''' <param name="_Path">Carpeta</param>
    Public Sub ImportarCarpeta(ByVal _Path As String)
        AnalizarCarpeta("\\?\" & _Path, "\\?\" & _Path)
    End Sub

    Private Sub AnalizarCarpeta(ByVal sDir As String, ByVal CarpetaRaiz As String)
        Dim d As String
        Dim f As String

        Try
            For Each f In Directory.GetFiles(sDir, "*.pdf")
                Try
                    Importar(f)
                Catch ex As Exception
                End Try
            Next
            Try
                For Each d In Directory.GetDirectories(sDir)
                    AnalizarCarpeta(d, CarpetaRaiz)
                Next
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
    End Sub

#End Region
#Region "Privadas"
    ''' <summary>
    ''' Importa un archivo de reporte bancario
    ''' </summary>
    ''' <param name="_Path">Path del archivo</param>
    Private Function Importar(ByVal _Path As String) As Boolean
        Dim Archivo As String
        Dim Transaccion As New I_Transaccion
        Dim db_Transaccion As New D_Transaccion

        Dim i As Integer

        Try
            Archivo = Leer(_Path)
            If Archivo.Length > 100 Then
                i = 0
                For Each Linea As DataRow In Formato.Rows
                    If InStr(Archivo, Linea.Item(1)) > 0 Then
                        If InStr(Archivo, Linea.Item(2)) > 0 Then
                            Transaccion = Buscar(i, Archivo, _Path)

                            If Val(Linea.Item(4)) = 1 Then '------------------------------------------EMPLEADOS -------EMPLEADOS ------EMPLEADOS --
                                Transaccion = ImportarEmpleados(Archivo, Transaccion)
                            End If

                            If db_Transaccion.Insertar(Transaccion) Then
                                _ListaTransacciones.Add(Transaccion)
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                    i += 1
                Next
            End If
            VerificarError(_Path, Archivo)
            Return False
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub VerificarError(ByVal Ubicacion As String, ByVal Cadena As String)
        Dim v1 As Boolean = False
        Dim v2 As Boolean = False
        Dim v3 As Boolean = False
        Dim v4 As Boolean = False

        No_Errores += 1

        If InStr(Cadena, "Importe") > 0 Then
            v1 = True
        End If

        If InStr(Cadena, "Cuenta") > 0 Or InStr(Cadena, "cuenta") > 0 Then
            v2 = True
        End If

        If InStr(Cadena, "Fecha") > 0 Then
            v3 = True
        End If

        If InStr(Cadena, "$") > 0 Then
            v4 = True
        End If

        If v1 And v2 And v3 And v4 Then
            Errores.Add(Ubicacion, "Formato no registrado!.")
        Else
            Errores.Add(Ubicacion, "No es reporte bancario!.")
        End If

    End Sub

#Region "EMPLEADOS ---"
    ''' <summary>
    ''' Devuelve transaccion con lista de empleados
    ''' </summary>
    ''' <param name="Cadena">PDF convertido a texto</param>
    ''' <param name="TR">Identidad de la transacción</param>
    ''' <returns></returns>
    Private Function ImportarEmpleados(ByVal Cadena As String, ByVal TR As I_Transaccion) As I_Transaccion
        Dim sCadena As String
        Dim Inicio As Integer
        Dim Fin As Integer

        Inicio = InStr(Cadena, "Código Descripción" & Chr(10)) + 18
        Fin = InStr(Cadena, " Fecha de  Impresión")

        sCadena = Cadena.Substring(Inicio, (Fin - Inicio) - 2)
        TR.Empleados = getAllEmpleados(sCadena)
        TR = getInfoTransaccion(TR)

        Return TR
    End Function
    Private Function getInfoTransaccion(ByVal Transaccion As I_Transaccion) As I_Transaccion
        Dim RT As Integer = 0
        Dim Importe As Decimal = 0.0
        Dim ImporteAux As Decimal

        For Each Empleado As I_Empleado In Transaccion.Empleados
            ImporteAux = Convert.ToDecimal(Empleado.Importe)
            Empleado.Idtransaccion = Transaccion.Idtransaccion
            If ImporteAux > 0 Then
                Importe += ImporteAux
                RT += 1
            End If
        Next

        Transaccion.C14 = Importe
        Transaccion.C9 = RT

        Return Transaccion
    End Function
    ''' <summary>
    ''' Devuelve lista de empleados
    ''' </summary>
    ''' <param name="Cadena">Cadena filtrada con solo lista de empleados a procesar</param>
    ''' <returns></returns>
    Private Function getAllEmpleados(ByVal Cadena As String) As List(Of I_Empleado)
        Dim Empleados As New List(Of I_Empleado)
        Dim Empleado As New I_Empleado
        Dim Fin As Integer
        Dim sCadena As String

        'Fin = InStr(Cadena, Chr(10))

        Do
            Fin = InStr(Cadena, Chr(10))
            If Fin = 0 Then
                Fin = Cadena.Length + 1
            End If

            sCadena = Cadena.Substring(0, Fin - 1)

            If Fin < Cadena.Length Then
                Cadena = Cadena.Substring(Fin, Cadena.Length - Fin)
            Else
                Cadena = ""
            End If

            Empleado = getEmpleado(sCadena)

            If Not Empleado Is Nothing Then
                Empleados.Add(Empleado)
            End If

        Loop While Cadena.Length > 50

        Return Empleados
    End Function
    ''' <summary>
    ''' Devuelve un empleado
    ''' </summary>
    ''' <param name="Cadena">Linea de empleado</param>
    ''' <returns></returns>
    Private Function getEmpleado(ByVal Cadena As String) As I_Empleado
        Dim Empleado As New I_Empleado
        Dim Inicio As Integer
        Dim Fin As Integer
        Dim Aux As Integer
        Dim Aux2 As Decimal
        Dim sCadena As String

        '-> NUMERO DE EMPLEADO -----------------------------------
        Empleado.No_empleado = Cadena.Substring(0, 10)
        '---------------------------------------------------------

        '-> NOMBRE --------------------------------------------------
        Inicio = 11
        Aux = Inicio
        While True
            Fin = InStr(Aux, Cadena, " ")
            sCadena = Cadena.Substring(Fin, 1)

            If Char.IsNumber(sCadena) Then
                Exit While
            End If
            Aux = Fin + 1
        End While

        Empleado.Nombre = Cadena.Substring(Inicio, Fin - Inicio - 1)
        '---------------------------------------------------------

        '-> TIPO CUENTA ------------------------------------------
        Inicio = Fin
        Fin = InStr(Inicio + 1, Cadena, " ")

        Empleado.Tipo_cuenta = Cadena.Substring(Inicio, Fin - Inicio - 1)
        '---------------------------------------------------------

        '-> NUMERO DE CUENTA -------------------------------------
        Inicio = Fin
        Empleado.No_cuenta = Cadena.Substring(Inicio, 18)
        '---------------------------------------------------------

        '-> IMPORTE ----------------------------------------------
        Inicio = InStr(Inicio, Cadena, "$")

        Fin = InStr(Inicio, Cadena, "APLICADO")
        If Fin = 0 Then
            Fin = InStr(Inicio, Cadena, "RECHAZADO")
        End If
        Fin -= 1

        Aux2 = Cadena.Substring(Inicio, Fin - Inicio)
        Empleado.Importe = Convert.ToDecimal(Aux2)
        '---------------------------------------------------------

        '-> DESCRIPCION ------------------------------------------
        Inicio = Fin + 1

        For I As Integer = 1 To 2
            Inicio += 1
            Inicio = InStr(Inicio, Cadena, " ")
        Next

        Fin = Cadena.Length

        Empleado.Descripcion = Cadena.Substring(Inicio, Fin - Inicio)
        '---------------------------------------------------------

        Return Empleado
    End Function
#End Region
    ''' <summary>
    ''' Lee archivo de reporte bancario
    ''' </summary>
    ''' <param name="Ubicacion">Path del archivo</param>
    ''' <returns></returns>
    Private Function Leer(ByVal Ubicacion As String) As String
        Dim ArchivoPDF As New PdfReader(Ubicacion)
        Dim Texto = ""

        For i = 1 To ArchivoPDF.NumberOfPages
            Dim its As New parser.SimpleTextExtractionStrategy
            Texto &= parser.PdfTextExtractor.GetTextFromPage(ArchivoPDF, i, its)
        Next
        ArchivoPDF.Close()
        Return Texto
    End Function

    Public Function Buscar(ByVal Indice As Integer, ByVal Cadena As String, ByVal Ubicacion As String) As I_Transaccion
        Dim CampoInicio As String
        Dim CampoFin As String
        Dim Inicio As Integer
        Dim Fin As Integer
        Dim Auxiliar As String
        Dim Respuesta As New I_Transaccion
        Dim DB As New N_TR_Procesada

        Respuesta.Idformato = Formato.Rows(Indice).Item(0).ToString
        Respuesta.Banco_origen.Moneda = Formato.Rows(Indice).Item(3).ToString
        Respuesta.Banco_destino.Moneda = Formato.Rows(Indice).Item(3).ToString
        Respuesta.C15 = Formato.Rows(Indice).Item(3).ToString

        Try
            For i = 1 To 17
                Inicio = 0
                Fin = 0
                CampoInicio = CamposInicio.Rows(Indice).Item(i).ToString
                CampoFin = CamposFin.Rows(Indice).Item(i).ToString

                'Se reemplaza caracteres especiales para coincidencia con documento
                CampoInicio = CampoInicio.Replace("\n", Chr(10))
                CampoInicio = CampoInicio.Replace("\0", "")
                CampoFin = CampoFin.Replace("\n", Chr(10))
                CampoFin = CampoFin.Replace("\0", "")


                If CampoInicio.Length > 0 Then
                    If CampoFin = "" Then
                        CampoFin = Chr(10)
                    End If

                    Inicio = InStr(Cadena, CampoInicio)
                    Inicio = Inicio + CampoInicio.Length - 1
                    Fin = InStr(Inicio, Cadena, CampoFin)

                    If (Fin - Inicio) < 1 Then
                        Dim y As Integer = 1
                        While Fin - Inicio < 1 And y < Cadena.Length
                            Try
                                Fin = InStr(Inicio + y, Cadena, CampoFin)
                            Catch ex As Exception
                                Exit While
                            End Try
                            y += 1
                        End While
                        Fin += 1
                    End If

                    Try
                        Auxiliar = Cadena.Substring(Inicio, Fin - (Inicio + 1))
                    Catch ex As Exception
                        If Inicio > 1 Then
                            Auxiliar = Cadena.Substring(Inicio)
                        End If
                        Auxiliar = ""
                        Console.WriteLine(ex.Message + vbCrLf + vbCrLf + ex.StackTrace)
                    End Try
                    Auxiliar = Auxiliar.Replace(Chr(10), " ")
                    Auxiliar = Auxiliar.Trim

                    Respuesta.setValor(i - 1, Auxiliar)
                End If
            Next

            'Validación de la clave de rastreo que sea diferente a 0 o null
            If Respuesta.C0 = "" Then
                If Respuesta.C13.Length > 2 Then
                    Respuesta.C0 = Respuesta.C13
                Else
                    If Respuesta.C12.Length > 2 Then
                        Respuesta.C0 = Respuesta.C12
                    End If
                End If
            End If
            ' FIN VALIDACION CLAVE RASTREO

            'Verifica Si existe clave de rastreo

            If DB.Consultar(Respuesta.C0) Then
                No_Errores += 1
                Errores.Add(Ubicacion, "Formato duplicado!.")
                Return Nothing
            End If

            ' Continua ejecución normal ---------------------------------------------------------

            If Len(Formato.Rows(Indice).Item(5).ToString) > 0 Then
                Respuesta.C1 = Formato.Rows(Indice).Item(5).ToString
            End If

            If Len(Formato.Rows(Indice).Item(6).ToString) > 0 Then
                Respuesta.C5 = Formato.Rows(Indice).Item(6).ToString
            End If

            If Respuesta.C8.Length < 2 Then
                With Respuesta
                    .C5 = ""
                    .C6 = ""
                    .C7 = ""
                    .C8 = ""
                End With
            End If

            'ESTABLECIENDO UBICACION DE ARCHIVO
            Try
                Respuesta.C17 = Path.GetFileName(Ubicacion)
                If Respuesta.C17.Length = 0 Then
                    Respuesta.C17 = ""
                End If
            Catch ex As Exception
                Respuesta.C17 = ""
            End Try
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return Respuesta
    End Function

    Private Sub CargarDatos()
        Dim _Formato As New D_Formato
        Dim _CN As New D_CamposNombre
        Dim _CI As New D_CamposInicio
        Dim _CF As New D_CamposFin

        Formato = _Formato.Lista
        CamposNombre = _CN.Lista
        CamposInicio = _CI.Lista
        CamposFin = _CF.Lista

    End Sub
#End Region
#End Region
End Class
