''' <summary>
''' Clase - Empresa Externa
''' </summary>
Public Class I_EmpresaExterna
#Region "Variables"
    Private _idempresa_externa As Integer   '-> Identificador de empresa
    Private _razon_social As String         '-> Razón social
    Private _rfc As String                  '-> RFC de la empresa
    Private _descripcion As String          '-> Descripción

#End Region
#Region "Constructor"
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Constructor de clase
    ''' </summary>
    ''' <param name="razon_social">Razón social</param>
    ''' <param name="rfc">RFC de la empresa</param>
    ''' <param name="descripcion">Descripción</param>
    Public Sub New(idempresa_externa As Integer, razon_social As String, rfc As String, descripcion As String)
        Me.Idempresa_externa = idempresa_externa
        _razon_social = razon_social
        _rfc = rfc
        _descripcion = descripcion
    End Sub
#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Razón social
    ''' </summary>
    ''' <returns></returns>
    Public Property Razon_social As String
        Get
            Return _razon_social
        End Get
        Set(value As String)
            _razon_social = value
        End Set
    End Property
    ''' <summary>
    ''' RFC de la empresa
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
    ''' Descripción
    ''' </summary>
    ''' <returns></returns>
    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
    Public Property Idempresa_externa As Integer
        Get
            Return _idempresa_externa
        End Get
        Set(value As Integer)
            _idempresa_externa = value
        End Set
    End Property

#End Region
End Class
