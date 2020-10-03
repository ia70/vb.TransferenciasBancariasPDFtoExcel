Imports Capa_Identidad

Public Class D_Empleado
#Region "Variables"
    Private Tabla As String = "empleados"
    Private PrimaryKey As String = "idempleados"

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
        Return DB.Query("SELECT * FROM " & Tabla)
    End Function

    ''' <summary>
    ''' Insertar
    ''' </summary>
    ''' <param name="Obj">Objeto Identidad</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Insertar(ByVal Obj As I_Empleado) As Boolean
        Dim DB As New DataBase

        Return DB.Update("INSERT INTO " & Tabla & " VALUES(null,'" & Obj.Idtransaccion & "','" & Obj.No_empleado & "','" & Obj.Nombre & "','" & Obj.Tipo_cuenta & "','" & Obj.No_cuenta & "','" & Format(Obj.Importe, "#.00").ToString & "','" & Obj.Descripcion & "')")

    End Function

    ''' <summary>
    ''' Consultar un registro
    ''' </summary>
    ''' <param name="Registro">ID transacción</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Consulta(ByVal Registro) As DataTable
        Dim DB As New DataBase
        Return DB.Query("SELECT no_empleado 'No. Empleado', nombre 'Nombre', tipo_cuenta 'Tipo Cuenta', no_cuenta 'No. de Cuenta', importe 'Importe', descripcion 'Descripción' FROM " & Tabla & " WHERE idtransaccion='" & Registro & "'")
    End Function

    ''' <summary>
    ''' Editar un registro
    ''' </summary>
    ''' <param name="Obj">Objeto Identidad</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Editar(ByVal Obj As I_Empleado) As Boolean
        Dim DB As New DataBase

        Return DB.Update("UPDATE " & Tabla & " SET idtransaccion='" & Obj.Idtransaccion & "',no_empleado='" & Obj.No_empleado & "',nombre='" & Obj.Nombre & "',tipo_cuenta='" & Obj.Tipo_cuenta & "',no_cuenta='" & Obj.No_cuenta & "',importe=" & Obj.Importe & ",descripcion='" & Obj.Descripcion & "' WHERE " & PrimaryKey & "=" & Obj.Idempleado)

    End Function

    ''' <summary>
    ''' Eliminar registro
    ''' </summary>
    ''' <param name="ID">Clave Primaria</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Eliminar(ByVal ID As String) As Boolean
        Dim DB As New DataBase

        Return DB.Update("DELETE FROM " & Tabla & " WHERE " & PrimaryKey & "=" & ID)

    End Function

#End Region
End Class
