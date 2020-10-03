''' <summary>
''' Clase - Vinculo Empresas - Cuentas
''' </summary>
Public Class I_Vinculo

#Region "Variables"
    Private _idvinculo As Integer           '-> Identificador del vinculo
    Private _idempresa_externa As Integer   '-> Identificador de empresa
    Private _no_cuenta As String        '-> Número de cuenta

#End Region
#Region "Constructor"
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Constructor de clase
    ''' </summary>
    ''' <param name="idvinculo">Identificador del vinculo</param>
    ''' <param name="idempresa_externa">Identificador de empresa</param>
    ''' <param name="numero_cuenta">Número de cuenta</param>
    Public Sub New(idvinculo As Integer, idempresa_externa As Integer, numero_cuenta As String)
        _idvinculo = idvinculo
        _idempresa_externa = idempresa_externa
        _no_cuenta = numero_cuenta
    End Sub
#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Identificador de empresa
    ''' </summary>
    ''' <returns></returns>
    Public Property Idempresa_externa As Integer
        Get
            Return _idempresa_externa
        End Get
        Set(value As Integer)
            _idempresa_externa = value
        End Set
    End Property
    ''' <summary>
    ''' Número de cuenta
    ''' </summary>
    ''' <returns></returns>
    Public Property Numero_cuenta As String
        Get
            Return _no_cuenta
        End Get
        Set(value As String)
            _no_cuenta = value
        End Set
    End Property

    Public Property Idvinculo As Integer
        Get
            Return _idvinculo
        End Get
        Set(value As Integer)
            _idvinculo = value
        End Set
    End Property

#End Region
End Class
