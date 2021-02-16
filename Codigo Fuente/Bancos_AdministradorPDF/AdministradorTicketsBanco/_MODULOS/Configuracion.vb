Module Configuracion
    'DETALLES DE OPERACION ---------------------------
    Public V_Transaccion As String = ""
    Public V_Empleados As Boolean = False
    '-------------------------------------------------
    Public db_Transaccion As DataTable

    'ERRORES -----------------------------------------
    Public _Errores As New Hashtable
    Public _No_Errores As Integer
    Public G_MostrarErrores As Boolean = True
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

    ''' <summary>
    ''' Evalua Errores
    ''' </summary>
    ''' <param name="ex"></param>
    Public Sub X(Optional ByVal ex As Exception = Nothing)
        Const fic As String = "log.txt"

        If Not ex Is Nothing Then
            If G_MostrarErrores Then
                msg(ex.StackTrace.ToString, 2)
            Else
                Try
                    Dim sw As New IO.StreamWriter(fic, True)
                    sw.WriteLine(vbCrLf + "------------------------------------------------------------------------------------------------------")
                    sw.WriteLine("/// ----> " + Now.ToString)
                    sw.WriteLine(ex.Source.ToString)
                    sw.WriteLine(ex.Message.ToString)
                    sw.WriteLine(ex.StackTrace.ToString)
                    sw.Close()
                    Console.WriteLine(ex.StackTrace.ToString)
                Catch exp As Exception
                End Try
            End If
        End If
    End Sub
End Module
