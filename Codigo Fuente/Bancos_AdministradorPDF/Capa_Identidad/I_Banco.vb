''' <summary>
''' Clase - Banco origen 
''' </summary>
Public Class I_Banco
#Region "Variables"
    Private _no_cuenta As String = ""           '-> Número de cuenta Banco origen
    Private _nombre_banco As String = ""        '-> Nombre del Banco origen
    Private _nombre_cuenta As String = ""       '-> Nombre de la cuenta origen
    Private _rfc As String = ""                 '-> RFC origen
    Private _moneda As String = ""              '-> Moneda origen
    Private _tipo As String                     '-> Tipo de cuenta: Origen-Destino(Origen,Destino)

#End Region
#Region "Constructor"
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Constructor de clase
    ''' </summary>
    ''' <param name="no_cuenta">Número de cuenta Banco origen</param>
    ''' <param name="nombre_banco">Nombre del Banco origen</param>
    ''' <param name="nombre_cuenta">Nombre de la cuenta origen</param>
    ''' <param name="rfc">RFC origen</param>
    ''' <param name="moneda">Moneda origen</param>
    ''' <param name="tipo">Tipo de cuenta: Origen-Destino(Origen,Destino)</param>
    Public Sub New(no_cuenta As String, nombre_banco As String, nombre_cuenta As String, rfc As String, moneda As String, ByVal tipo As String)
        _no_cuenta = no_cuenta
        _nombre_banco = nombre_banco
        _nombre_cuenta = nombre_cuenta
        _rfc = rfc
        _moneda = moneda
        Me.Tipo = tipo
    End Sub
#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Número de cuenta Banco
    ''' </summary>
    ''' <returns></returns>
    Public Property No_cuenta As String
        Get
            Return _no_cuenta
        End Get
        Set(value As String)
            _no_cuenta = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre del Banco
    ''' </summary>
    ''' <returns></returns>
    Public Property Nombre_banco As String
        Get
            Return _nombre_banco
        End Get
        Set(value As String)
            _nombre_banco = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de la cuenta
    ''' </summary>
    ''' <returns></returns>
    Public Property Nombre_cuenta As String
        Get
            Return _nombre_cuenta
        End Get
        Set(value As String)
            _nombre_cuenta = value
        End Set
    End Property
    ''' <summary>
    ''' RFC
    ''' </summary>
    ''' <returns></returns>
    Public Property Rfc As String
        Get
            Return _rfc
        End Get
        Set(value As String)
            _rfc = value
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
    ''' Tipo de cuenta: Origen-Destino(Origen,Destino)
    ''' </summary>
    ''' <returns></returns>
    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

#End Region
End Class
