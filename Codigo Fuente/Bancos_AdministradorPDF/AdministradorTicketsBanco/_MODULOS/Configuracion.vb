Module Configuracion
    'DETALLES DE OPERACION ---------------------------
    Public V_Transaccion As String = ""
    Public V_Empleados As Boolean = False
    '-------------------------------------------------
    Public db_Transaccion As DataTable

    'ERRORES -----------------------------------------
    Public _Errores(200, 2) As String
    Public _No_Errores As Integer
    '-------------------------------------------------

    ''' <summary>
    ''' Muestra un mensaje
    ''' </summary>
    ''' <param name="Mensaje">Mensaje a mostrar</param>
    ''' <param name="Tipo">Tipo de mensaje</param>
    Public Sub msg(ByVal Mensaje As String, ByVal Optional Tipo As Integer = 0)
        Dim NombreEmpresa As String = "Administrador de bancos"

        Select Case Tipo
            Case 0
                MsgBox(Mensaje, vbInformation, NombreEmpresa)
            Case 1
                MsgBox(Mensaje, vbExclamation, NombreEmpresa)
            Case 2
                MsgBox(Mensaje, vbCritical, NombreEmpresa)
            Case 3
                MsgBox(Mensaje, vbQuestion, NombreEmpresa)
            Case Else
                MsgBox(Mensaje, vbInformation, NombreEmpresa)
        End Select
    End Sub
End Module
