''' <summary>
''' Clase - Formato
''' </summary>
Public Class I_Formato
#Region "Variables"
    Private _idformato As String            '-> Identificador de formato
    Private _identificador As String        '-> Identificador - pedazo de texto del formato
    Private _nombre_transaccion As String   '-> Nombre del tipo de transacción
    Private _moneda As String               '-> Moneda
    Private _empleados As String            '-> Tiene empleados?
    Private _banco_origen As String         '-> Nombre del Banco origen
    Private _banco_destino As String        '-> Nombre del Banco destino


#End Region
#Region "Constructor"
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Constructor de clase
    ''' </summary>
    ''' <param name="idformato">Identificador de formato</param>
    ''' <param name="identificador">Nombre del banco</param>
    ''' <param name="nombre_transaccion">Nombre del tipo de transacción</param>
    ''' <param name="empleados">Tiene empleados?</param>
    ''' <param name="moneda">Moneda</param>
    Public Sub New(idformato As String, identificador As String, nombre_transaccion As String, moneda As String, empleados As String, ByVal banco_origen As String, ByVal banco_destino As String)
        Me.Idformato = idformato
        Me.Identificador = identificador
        Me.Nombre_transaccion = nombre_transaccion
        Me.Empleados = empleados
        Me.Moneda = moneda

        Me.Banco_origen = banco_origen
        Me.Banco_destino = banco_destino
    End Sub

#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Identificador del formato
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
    ''' Nombre del banco
    ''' </summary>
    ''' <returns></returns>
    Public Property Identificador As String
        Get
            Return _identificador
        End Get
        Set(value As String)
            _identificador = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre de la Transacción
    ''' </summary>
    ''' <returns></returns>
    Public Property Nombre_transaccion As String
        Get
            Return _nombre_transaccion
        End Get
        Set(value As String)
            _nombre_transaccion = value
        End Set
    End Property

    ''' <summary>
    ''' 0 -> Si tiene empleados
    ''' 1 -> Si no tiene empleados
    ''' </summary>
    ''' <returns></returns>
    Public Property Empleados As String
        Get
            Return _empleados
        End Get
        Set(value As String)
            _empleados = value
        End Set
    End Property

    ''' <summary>
    ''' Moneda
    ''' </summary>
    ''' <returns></returns>
    Public Property Moneda As String
        Get
            Return _moneda
        End Get
        Set(value As String)
            _moneda = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre del Banco origen
    ''' </summary>
    ''' <returns></returns>
    Public Property Banco_origen As String
        Get
            Return _banco_origen
        End Get
        Set(value As String)
            _banco_origen = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre del Banco destino
    ''' </summary>
    ''' <returns></returns>
    Public Property Banco_destino As String
        Get
            Return _banco_destino
        End Get
        Set(value As String)
            _banco_destino = value
        End Set
    End Property

#End Region
#Region "Funciones"
    ''' <summary>
    ''' Obtener valos de un campo
    ''' </summary>
    ''' <param name="Campo">No. de campo</param>
    ''' <returns></returns>
    Public Function getInicio(ByVal Campo As Integer) As String
        If Campo > 16 Or Campo < 0 Then
            Return ""
        End If

        Select Case Campo
            Case 0
                Return _idformato
            Case 1
                Return _identificador
            Case 2
                Return _nombre_transaccion
            Case 3
                Return _moneda
            Case 4
                Return _empleados
            Case 5
                Return _banco_origen
            Case 7
                Return _banco_destino
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
        If Campo > 16 Or Campo < 0 Then
            Exit Sub
        End If
        Try
            Select Case Campo
                Case 0
                    _idformato = Valor
                Case 1
                    _identificador = Valor
                Case 2
                    _nombre_transaccion = Valor
                Case 3
                    _moneda = Valor
                Case 4
                    _empleados = Valor
                Case 5
                    _banco_origen = Valor
                Case 6
                    _banco_destino = Valor
                Case Else
                    _moneda = Valor
            End Select
        Catch ex As Exception
        End Try
    End Sub
#End Region

End Class
