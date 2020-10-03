''' <summary>
''' Clase - Empleados
''' </summary>
Public Class I_Empleado
#Region "Variables"
    Private _idempleado As Integer      '-> ID del empleado
    Private _idtransaccion As String    '-> Identificador de la transacción
    Private _no_empleado As String      '-> Número de empleado
    Private _nombre As String           '-> Nombre del empleado
    Private _tipo_cuenta As String      '-> Tipo de cuenta
    Private _no_cuenta As String        '-> Número de cuenta
    Private _importe As Decimal          '-> Importe
    Private _descripcion As String      '-> Descripción

#End Region
#Region "Constructor"
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Constructor de clase
    ''' </summary>
    ''' <param name="idempleado">Identificador del empleado</param>
    ''' <param name="idtransaccion">Identificador de la transacción</param>
    ''' <param name="no_empleado">Número de empleado</param>
    ''' <param name="nombre">Nombre del empleado</param>
    ''' <param name="tipo_cuenta">Tipo de cuenta</param>
    ''' <param name="no_cuenta">Número de cuenta</param>
    ''' <param name="importe">Importe</param>
    ''' <param name="descripcion">Descripción</param>
    Public Sub New(idempleado As Integer, idtransaccion As String, no_empleado As String, nombre As String, tipo_cuenta As String, no_cuenta As String, importe As Decimal, descripcion As String)
        Me.Idempleado = idempleado
        _idtransaccion = idtransaccion
        _no_empleado = no_empleado
        _nombre = nombre
        _tipo_cuenta = tipo_cuenta
        _no_cuenta = no_cuenta
        _importe = importe
        _descripcion = descripcion
    End Sub
#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Identificador de la transacción
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
    ''' Número de empleado
    ''' </summary>
    ''' <returns></returns>
    Public Property No_empleado As String
        Get
            Return _no_empleado
        End Get
        Set(value As String)
            _no_empleado = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre del empleado
    ''' </summary>
    ''' <returns></returns>
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    ''' <summary>
    ''' Tipo de cuenta
    ''' </summary>
    ''' <returns></returns>
    Public Property Tipo_cuenta As String
        Get
            Return _tipo_cuenta
        End Get
        Set(value As String)
            _tipo_cuenta = value
        End Set
    End Property
    ''' <summary>
    ''' Número de cuenta
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
    ''' Importe
    ''' </summary>
    ''' <returns></returns>
    Public Property Importe As Decimal
        Get
            Return _importe
        End Get
        Set(value As Decimal)
            _importe = value
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
    Public Property Idempleado As Integer
        Get
            Return _idempleado
        End Get
        Set(value As Integer)
            _idempleado = value
        End Set
    End Property

#End Region
End Class
