''' <summary>
''' Clase - Campos Inicio
''' </summary>
Public Class I_CamposInicio
#Region "Variables"
    Private _idformato As String    '-> Número de cuenta Bnaco origen

    Private _c0 As String = "."     '-> Clave de rastreo
    Private _c1 As String = "."     '-> Nombre de Banco origen
    Private _c2 As String = "."     '-> Nombre de la cuenta origen
    Private _c3 As String = "."     '-> RFC origen
    Private _c4 As String = "."     '-> Número de cuenta origen
    Private _c5 As String = "."     '-> Nombre de Banco destino
    Private _c6 As String = "."     '-> Nombre de la cuenta destino
    Private _c7 As String = "."     '-> RFC destino
    Private _c8 As String = "."     '-> Número de cuenta destino
    Private _c9 As String = "."     '-> No. Registros transmitidos
    Private _c10 As String = "."    '-> Concepto de pago
    Private _c11 As String = "."    '-> Beneficiario
    Private _c12 As String = "."    '-> Referencia
    Private _c13 As String = "."    '-> Folio de Internet
    Private _c14 As String = "."    '-> Importe
    Private _c15 As String = "."    '-> Moneda
    Private _c16 As String = "."    '-> Fecha de aplicación 

#End Region
#Region "Constructor"
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Constructor de clase
    ''' </summary>
    ''' <param name="idformato">Identificador de formato</param>
    ''' <param name="c0">Calve de rastreo</param>
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
    Public Sub New(idformato As String, c0 As String, c1 As String, c2 As String, c3 As String, c4 As String, c5 As String, c6 As String, c7 As String, c8 As String, c9 As String, c10 As String, c11 As String, c12 As String, c13 As String, c14 As String, c15 As String, c16 As String)
        _idformato = idformato
        Me.C0 = c0
        Me.C1 = c1
        Me.C2 = c2
        Me.C3 = c3
        Me.C4 = c4
        Me.C5 = c5
        Me.C6 = c6
        Me.C7 = c7
        Me.C8 = c8
        Me.C9 = c9
        Me.C10 = c10
        Me.C11 = c11
        Me.C12 = c12
        Me.C13 = c13
        Me.C14 = c14
        Me.C15 = c15
        Me.C16 = c16
    End Sub
#End Region
#Region "Propiedades"
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
    ''' Calve de rastreo
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
            Return _c1
        End Get
        Set(value As String)
            _c1 = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de la cuenta origen
    ''' </summary>
    ''' <returns></returns>
    Public Property C2 As String
        Get
            Return _c2
        End Get
        Set(value As String)
            _c2 = value
        End Set
    End Property
    ''' <summary>
    ''' RFC origen
    ''' </summary>
    ''' <returns></returns>
    Public Property C3 As String
        Get
            Return _c3
        End Get
        Set(value As String)
            _c3 = value
        End Set
    End Property
    ''' <summary>
    ''' Número de cuenta origen
    ''' </summary>
    ''' <returns></returns>
    Public Property C4 As String
        Get
            Return _c4
        End Get
        Set(value As String)
            _c4 = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de Banco destino
    ''' </summary>
    ''' <returns></returns>
    Public Property C5 As String
        Get
            Return _c5
        End Get
        Set(value As String)
            _c5 = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de la cuenta destino
    ''' </summary>
    ''' <returns></returns>
    Public Property C6 As String
        Get
            Return _c6
        End Get
        Set(value As String)
            _c6 = value
        End Set
    End Property
    ''' <summary>
    ''' RFC destino
    ''' </summary>
    ''' <returns></returns>
    Public Property C7 As String
        Get
            Return _c7
        End Get
        Set(value As String)
            _c7 = value
        End Set
    End Property
    ''' <summary>
    ''' Número de cuenta destino
    ''' </summary>
    ''' <returns></returns>
    Public Property C8 As String
        Get
            Return _c8
        End Get
        Set(value As String)
            _c8 = value
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
        End Set
    End Property
    ''' <summary>
    ''' Importe
    ''' </summary>
    ''' <returns></returns>
    Public Property C14 As String
        Get
            Return _c14
        End Get
        Set(value As String)
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
                Return C14
            Case 15
                Return C15
            Case 16
                Return C16
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
                    C0 = Valor
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
                    C9 = Valor
                Case 10
                    C10 = Valor
                Case 11
                    C11 = Valor
                Case 12
                    C12 = Valor
                Case 13
                    C13 = Valor
                Case 14
                    C14 = Valor
                Case 15
                    C15 = Valor
                Case 16
                    C16 = Valor
            End Select
        Catch ex As Exception
        End Try
    End Sub

#End Region
End Class
