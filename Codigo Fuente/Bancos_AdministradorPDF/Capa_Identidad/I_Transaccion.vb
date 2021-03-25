''' <summary>
''' Clase - Transacción
''' </summary>
Public Class I_Transaccion
#Region "Variables"
    Private _BO As New I_Banco                      '-> Objeto Banco origen
    Private _BD As New I_Banco                      '-> Objeto Banco destino
    Private _Empleados As New List(Of I_Empleado)   '-> Objeto Empleados

    Private _idtransaccion As String                '-> Identificador de transacción
    Private _idformato As String                    '-> Identificador de formato

    Private _c0 As String = ""      '-> Clave de rastreo
    'Private _c1 As String = "."    '-> Nombre de Banco origen
    'Private _c2 As String = "."    '-> Nombre de la cuenta origen
    'Private _c3 As String = "."    '-> RFC origen
    'Private _c4 As String = "."    '-> Número de cuenta origen
    'Private _c5 As String = "."    '-> Nombre de Banco destino
    'Private _c6 As String = "."    '-> Nombre de la cuenta destino
    'Private _c7 As String = "."    '-> RFC destino
    'Private _c8 As String = "."    '-> Número de cuenta destino
    Private _c9 As String = ""      '-> No. Registros transmitidos
    Private _c10 As String = ""     '-> Concepto de pago
    Private _c11 As String = ""     '-> Beneficiario
    Private _c12 As String = ""     '-> Referencia
    Private _c13 As String = ""     '-> Folio de Internet
    Private _c14 As Decimal = 0.0    '-> Importe
    Private _c15 As String = ""     '-> Moneda
    Private _c16 As String = ""     '-> Fecha de aplicación 
    Private _c17 As String = ""     '-> Nombre archivo

#End Region
#Region "Constructor"
    Public Sub New()
        _BO.Tipo = "Origen"
        _BD.Tipo = "Destino"
    End Sub

    ''' <summary>
    ''' Constructor de clase
    ''' </summary>
    ''' <param name="idtransaccion">Identificador de transacción</param>
    ''' <param name="c0">Clave de rastreo</param>
    ''' <param name="c1">Nombre de Banco origen</param>
    ''' <param name="c2">Nombre de la cuenta origen</param>
    ''' <param name="c3">RFC origen</param>
    ''' <param name="c4">Número de cuenta origen</param>
    ''' <param name="c5">Nombre de Banco destino</param>
    ''' <param name="c6">Nombre de la cuenta destino</param>
    ''' <param name="c7">RFC destino</param>
    ''' <param name="c8">Número de cuenta destino</param>
    ''' <param name="c9">No. Registros transmitidos</param>
    ''' <param name="c10">Concepto de pago</param>
    ''' <param name="c11">Beneficiario</param>
    ''' <param name="c12">Referencia</param>
    ''' <param name="c13">Folio de Internet</param>
    ''' <param name="c14">Importe</param>
    ''' <param name="c15">Moneda</param>
    ''' <param name="c16">Fecha de aplicación</param>
    ''' <param name="c17">Nombre de archivo</param>
    Public Sub New(idtransaccion As String, idformato As String, c0 As String, c1 As String, c2 As String, c3 As String, c4 As String, c5 As String, c6 As String, c7 As String, c8 As String, c9 As String, c10 As String, c11 As String, c12 As String, c13 As String, c14 As Double, c15 As String, c16 As String, c17 As String)
        Me.Idtransaccion = idtransaccion
        Me.Idformato = idformato
        _c0 = c0
        _BO.Nombre_banco = c1
        _BO.Nombre_cuenta = c2
        _BO.Rfc = c3
        _BO.No_cuenta = c4
        _BD.Nombre_banco = c5
        _BD.Nombre_cuenta = c6
        _BD.Rfc = c7
        _BD.No_cuenta = c8
        _c9 = c9
        _c10 = c10
        _c11 = c11
        _c12 = c12
        _c13 = c13
        _c14 = c14
        _c15 = c15
        _c16 = c16
        _c17 = c17

        _BO.Tipo = "Origen"
        _BD.Tipo = "Destino"

        generarID()
    End Sub

#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Lista de Objeto Empleados
    ''' </summary>
    ''' <returns></returns>
    Public Property Empleados As List(Of I_Empleado)
        Get
            Return _Empleados
        End Get
        Set(value As List(Of I_Empleado))
            _Empleados = value
        End Set
    End Property
    ''' <summary>
    ''' Objeto - Banco origen
    ''' </summary>
    ''' <returns></returns>
    Public Property Banco_origen As I_Banco
        Get
            Return _BO
        End Get
        Set(value As I_Banco)
            _BO = value
        End Set
    End Property
    ''' <summary>
    ''' Objeto - Banco destino
    ''' </summary>
    ''' <returns></returns>
    Public Property Banco_destino As I_Banco
        Get
            Return _BD
        End Get
        Set(value As I_Banco)
            _BD = value
        End Set
    End Property
    ''' <summary>
    ''' Identificador de transacción
    ''' </summary>
    ''' <returns></returns>
    Public Property Idtransaccion As String
        Get
            Return _idtransaccion
        End Get
        Set(value As String)
            _idtransaccion = value
        End Set
    End Property
    ''' <summary>
    ''' Clave de rastreo
    ''' </summary>
    ''' <returns></returns>
    Public Property C0 As String
        Get
            Return _c0
        End Get
        Set(value As String)
            _c0 = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de Banco origen
    ''' </summary>
    ''' <returns></returns>
    Public Property C1 As String
        Get
            Return _BO.Nombre_banco
        End Get
        Set(value As String)
            _BO.Nombre_banco = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de la cuenta origen
    ''' </summary>
    ''' <returns></returns>
    Public Property C2 As String
        Get
            Return _BO.Nombre_cuenta
        End Get
        Set(value As String)
            _BO.Nombre_cuenta = value
        End Set
    End Property
    ''' <summary>
    ''' RFC origen
    ''' </summary>
    ''' <returns></returns>
    Public Property C3 As String
        Get
            Return _BO.Rfc
        End Get
        Set(value As String)
            _BO.Rfc = value
        End Set
    End Property
    ''' <summary>
    ''' Número de cuenta origen
    ''' </summary>
    ''' <returns></returns>
    Public Property C4 As String
        Get
            Return _BO.No_cuenta
        End Get
        Set(value As String)
            _BO.No_cuenta = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de Banco destino
    ''' </summary>
    ''' <returns></returns>
    Public Property C5 As String
        Get
            Return _BD.Nombre_banco
        End Get
        Set(value As String)
            _BD.Nombre_banco = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de la cuenta destino
    ''' </summary>
    ''' <returns></returns>
    Public Property C6 As String
        Get
            Return _BD.Nombre_cuenta
        End Get
        Set(value As String)
            _BD.Nombre_cuenta = value
        End Set
    End Property
    ''' <summary>
    ''' RFC destino
    ''' </summary>
    ''' <returns></returns>
    Public Property C7 As String
        Get
            Return _BD.Rfc
        End Get
        Set(value As String)
            _BD.Rfc = value
        End Set
    End Property
    ''' <summary>
    ''' Número de cuenta destino
    ''' </summary>
    ''' <returns></returns>
    Public Property C8 As String
        Get
            Return _BD.No_cuenta
        End Get
        Set(value As String)
            _BD.No_cuenta = value
        End Set
    End Property
    ''' <summary>
    ''' No. Registros transmitidos
    ''' </summary>
    ''' <returns></returns>
    Public Property C9 As String
        Get
            Return _c9
        End Get
        Set(value As String)
            _c9 = value
        End Set
    End Property
    ''' <summary>
    ''' Concepto de pago
    ''' </summary>
    ''' <returns></returns>
    Public Property C10 As String
        Get
            Return _c10
        End Get
        Set(value As String)
            _c10 = value
        End Set
    End Property
    ''' <summary>
    ''' Beneficiario
    ''' </summary>
    ''' <returns></returns>
    Public Property C11 As String
        Get
            Return _c11
        End Get
        Set(value As String)
            _c11 = value
        End Set
    End Property
    ''' <summary>
    ''' Referencia
    ''' </summary>
    ''' <returns></returns>
    Public Property C12 As String
        Get
            Return _c12
        End Get
        Set(value As String)
            _c12 = value
        End Set
    End Property
    ''' <summary>
    ''' Folio de Internet
    ''' </summary>
    ''' <returns></returns>
    Public Property C13 As String
        Get
            Return _c13
        End Get
        Set(value As String)
            _c13 = value
            generarID()
        End Set
    End Property
    ''' <summary>
    ''' Importe
    ''' </summary>
    ''' <returns></returns>
    Public Property C14 As Decimal
        Get
            Return _c14
        End Get
        Set(value As Decimal)
            _c14 = value
        End Set
    End Property
    ''' <summary>
    ''' Moneda
    ''' </summary>
    ''' <returns></returns>
    Public Property C15 As String
        Get
            Return _c15
        End Get
        Set(value As String)
            _c15 = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha de aplicación 
    ''' </summary>
    ''' <returns></returns>
    Public Property C16 As String
        Get
            Return _c16
        End Get
        Set(value As String)
            _c16 = value
        End Set
    End Property
    ''' <summary>
    ''' Identificador de formato
    ''' </summary>
    ''' <returns></returns>
    Public Property Idformato As String
        Get
            Return _idformato
        End Get
        Set(value As String)
            _idformato = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre archivo
    ''' </summary>
    ''' <returns></returns>
    Public Property C17 As String
        Get
            Return _c17
        End Get
        Set(value As String)
            _c17 = value
        End Set
    End Property
#End Region
#Region "Funciones"
    ''' <summary>
    ''' Obtener valor
    ''' </summary>
    ''' <param name="Campo">Número del campo a obtener 0 - 16</param>
    ''' <returns></returns>
    Public Function getValor(ByVal Campo As Integer) As String
        If Campo > 17 Or Campo < 0 Then
            Return ""
        End If

        Select Case Campo
            Case 0
                Return C0
            Case 1
                Return C1
            Case 2
                Return C2
            Case 3
                Return C3
            Case 4
                Return C4
            Case 5
                Return C5
            Case 6
                Return C6
            Case 7
                Return C7
            Case 8
                Return C8
            Case 9
                Return C9
            Case 10
                Return C10
            Case 11
                Return C11
            Case 12
                Return C12
            Case 13
                Return C13
            Case 14
                Return C14.ToString
            Case 15
                Return C15
            Case 16
                Return C16
            Case 17
                Return C17
            Case Else
                Return ""
        End Select
    End Function

    ''' <summary>
    ''' Establecer valor
    ''' </summary>
    ''' <param name="Campo">Número del campo</param>
    ''' <param name="Valor">Valor a establecer</param>
    Public Sub setValor(ByVal Campo As Integer, ByVal Valor As String)
        If Campo > 17 Or Campo < 0 Then
            Exit Sub
        End If
        Try
            Select Case Campo
                Case 0
                    C0 = Valor
                    generarID()
                Case 1
                    C1 = Valor
                Case 2
                    C2 = Valor
                Case 3
                    C3 = Valor
                Case 4
                    C4 = Valor
                Case 5
                    C5 = Valor
                Case 6
                    C6 = Valor
                Case 7
                    C7 = Valor
                Case 8
                    C8 = Valor
                Case 9
                    C9 = Val(Valor)
                Case 10
                    C10 = Valor
                Case 11
                    C11 = Valor
                Case 12
                    C12 = Valor
                Case 13
                    C13 = Valor
                    generarID()
                Case 14
                    C14 = getDecimal(Valor)
                Case 15
                    C15 = Valor
                Case 16
                    If Char.IsLetter(Valor.Substring(3, 1)) Then
                        Dim Dia As String
                        Dim Mes As String
                        Dim Ano As String
                        Dim Aux As String

                        Dim inicio As Integer
                        Dim fin As Integer

                        inicio = Valor.Length - 4
                        fin = 4

                        Dia = Valor.Substring(0, 2)
                        Ano = Valor.Substring(inicio, fin)
                        Aux = Valor.Substring(3, 3)

                        Select Case Aux
                            Case "Ene"
                                Mes = "01"
                            Case "Fbr"
                                Mes = "02"
                            Case "Mar"
                                Mes = "03"
                            Case "Abr"
                                Mes = "04"
                            Case "May"
                                Mes = "05"
                            Case "Jun"
                                Mes = "06"
                            Case "Jul"
                                Mes = "07"
                            Case "Ago"
                                Mes = "08"
                            Case "Sep"
                                Mes = "09"
                            Case "Oct"
                                Mes = "10"
                            Case "Nov"
                                Mes = "11"
                            Case "Dic"
                                Mes = "12"
                            Case Else
                                Mes = "01"
                        End Select

                        C16 = Format(Convert.ToDateTime(Dia & "/" & Mes & "/" & Ano).Date, "dd/MM/yyyy")
                    Else
                        C16 = Format(Convert.ToDateTime(Valor).Date, "dd/MM/yyyy")
                    End If
                Case 17
                    C17 = Valor
            End Select
        Catch ex As Exception
            'MsgBox("Linea 243 Error: " + ex.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Convierte cadena en decimal
    ''' </summary>
    ''' <param name="cadena"></param>
    ''' <returns></returns>
    Private Function getDecimal(ByVal cadena As String) As Decimal
        Dim aux As String
        Dim num As Decimal

        aux = cadena.Replace(",", "")
        cadena = aux
        aux = cadena.Replace(" ", "")

        Try
            num = Convert.ToDecimal(aux)
        Catch ex As Exception
            num = 0.0
        End Try

        Return num
    End Function

    ''' <summary>
    ''' Genera ID de transacción
    ''' </summary>
    Public Sub generarID()
        If Len(_idtransaccion) < 1 Then
            If Not C0 = "" Then
                Idtransaccion = C0
            Else
                If Not C13 = "" Then
                    Idtransaccion = C13
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Agrega un Empleado a la transacción
    ''' </summary>
    ''' <param name="_no_empleado">Número de empleado</param>
    ''' <param name="_nombre">Nombre del empleado</param>
    ''' <param name="_tipo_cuenta">Tipo de cuenta</param>
    ''' <param name="_no_cuenta">Número de cuenta</param>
    ''' <param name="_importe_e">Importe</param>
    ''' <param name="_descripcion">Descripción</param>
    Public Sub newEmpleado(ByVal _no_empleado As String, ByVal _nombre As String, ByVal _tipo_cuenta As String, ByVal _no_cuenta As String, ByVal _importe_e As Double, ByVal _descripcion As String)
        Dim _Empleado As New I_Empleado
        With _Empleado
            .Idtransaccion = Idtransaccion
            .No_empleado = _no_empleado
            .Nombre = _nombre
            .Tipo_cuenta = _tipo_cuenta
            .No_cuenta = _no_cuenta
            .Importe = _importe_e
            .Descripcion = _descripcion
        End With

        Empleados.Add(_Empleado)

    End Sub
#End Region
End Class
