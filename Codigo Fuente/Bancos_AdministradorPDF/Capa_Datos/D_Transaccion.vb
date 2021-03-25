Imports Capa_Identidad

Public Class D_Transaccion
#Region "Variables"
    Private Tabla As String = "transaccion"
    Private PrimaryKey As String = "idtransaccion"

#End Region
#Region "Constructor"

#End Region
#Region "Funciones"
    ''' <summary>
    ''' Obtiene Lista completa de los registros
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function Lista() As DataTable
        Dim DB As New DataBase
        Return DB.Query("SELECT idtransaccion 'ID', idformato 'Formato', c0 'Clave de Rastreo', c1 'Banco Ordenante', c2 'Cuenta Ordenante', c3 'RFC Ordenante', c4 'No. Cuenta Ordenante', c5 'Banco Destino', c6 'Cuenta Destino', c7 'RFC Destino', c8 'No. Cuenta Destino', c9 'RT', c10 'Concepto', c11 'Beneficiario', c12 'Referencia', c13 'Folio de Internet', c14 'Importe', c15 'Moneda', c16 'Fecha', c17 'Archivo' FROM " & Tabla)
    End Function

    ''' <summary>
    ''' Insertar
    ''' </summary>
    ''' <param name="Obj">Objeto Identidad</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Insertar(ByVal Obj As I_Transaccion) As Boolean
        Dim DB As New DataBase
        Dim Banco As New D_Banco
        Dim Empleado As New D_Empleado
        Dim _I_Empleado As New I_Empleado
        Dim DB_TR As New D_TR_Procesada

        Dim Respuesta As Boolean
        Try
            Respuesta = DB.Update("INSERT INTO " & Tabla & " VALUES('" & Obj.Idtransaccion & "','" & Obj.Idformato & "','" & Obj.C0 & "','" & Obj.C1 & "','" & Obj.C2 & "','" & Obj.C3 & "','" & Obj.C4 & "','" & Obj.C5 & "','" & Obj.C6 & "','" & Obj.C7 & "','" & Obj.C8 & "','" & Obj.C9 & "','" & Obj.C10 & "','" & Obj.C11 & "','" & Obj.C12 & "','" & Obj.C13 & "','" & Format(Convert.ToDecimal(Obj.C14), "#,###,##0.00").ToString & "','" & Obj.C15 & "','" & Obj.C16 & "','" & Obj.C17 & "')")
        Catch ex As Exception
            Return False
        End Try

        If Not Respuesta Then
            Return False
        End If

        If Obj.Banco_origen.No_cuenta.Length > 2 Then
            Banco.Insertar(Obj.Banco_origen)
        End If

        If Obj.Banco_destino.No_cuenta.Length > 2 Then
            Banco.Insertar(Obj.Banco_destino)
        End If

        If Val(Obj.C9) > 0 And Not DB_TR.Consulta(Obj.C0) Then
            For Each _I_Empleado In Obj.Empleados
                Empleado.Insertar(_I_Empleado)
            Next
        End If

        DB_TR.Insertar(Obj.C0)

        Return True
    End Function

    ''' <summary>
    ''' Consultar un registro
    ''' </summary>
    ''' <param name="Registro">Clave Primaria</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Consulta(ByVal Registro) As DataTable
        Dim DB As New DataBase
        Return DB.Query("SELECT idtransaccion 'ID', idformato 'Formato', c0 'Clave de Rastreo', c1 'Banco Ordenante', c2 'Cuenta Ordenante', c3 'RFC Ordenante', c4 'No. Cuenta Ordenante', c5 'Banco Destino', c6 'Cuenta Destino', c7 'RFC Destino', c8 'No. Cuenta Destino', c9 'RT', c10 'Concepto', c11 'Beneficiario', c12 'Referencia', c13 'Folio de Internet', c14 'Importe', c15 'Moneda', c16 'Fecha', c17 'Archivo' FROM " & Tabla & " WHERE " & PrimaryKey & "='" & Registro & "'")
    End Function

    ''' <summary>
    ''' Editar un registro
    ''' </summary>
    ''' <param name="Obj">Objeto Identidad</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Editar(ByVal Obj As I_Transaccion) As Boolean
        Dim DB As New DataBase

        Return DB.Update("UPDATE " & Tabla & " SET '" & Obj.Idformato & "',c0='" & Obj.C0 & "',c1='" & Obj.C1 & "',c2='" & Obj.C2 & "',c3='" & Obj.C3 & "',c4='" & Obj.C4 & "',c5='" & Obj.C5 & "',c6='" & Obj.C6 & "',c7='" & Obj.C7 & "',c8='" & Obj.C8 & "',c9='" & Obj.C9 & "',c10='" & Obj.C10 & "',c11='" & Obj.C11 & "',c12='" & Obj.C12 & "',c13='" & Obj.C13 & "',c14=" & Obj.C14 & ",c15='" & Obj.C15 & "',c16='" & Obj.C16 & "',c17='" & Obj.C17 & "' WHERE " & PrimaryKey & "='" & Obj.Idtransaccion & "'")

    End Function

    ''' <summary>
    ''' Eliminar registro
    ''' </summary>
    ''' <param name="ID">Clave Primaria</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Eliminar(ByVal ID As String) As Boolean
        Dim DB As New DataBase
        Dim DB_Empleados As New D_Empleado

        On Error Resume Next
        DB.Update("DELETE FROM empleados WHERE idtransaccion='" & ID & "'")

        Return DB.Update("DELETE FROM " & Tabla & " WHERE " & PrimaryKey & "='" & ID & "'")

    End Function

#End Region
End Class
