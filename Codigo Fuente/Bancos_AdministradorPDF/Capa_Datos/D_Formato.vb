Imports Capa_Identidad

Public Class D_Formato
#Region "Variables"
    Private Tabla As String = "formato"
    Private PrimaryKey As String = "idformato"

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
        Return DB.Query("SELECT * FROM " & Tabla & " ORDER BY '" & PrimaryKey & "' ASC")
    End Function

    ''' <summary>
    ''' Insertar
    ''' </summary>
    ''' <param name="Obj">Objeto Identidad</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Insertar(ByVal Obj As I_Formato) As Boolean
        Dim DB As New DataBase

        Return DB.Update("INSERT INTO " & Tabla & " VALUES('" & Obj.Idformato & "','" & Obj.Identificador & "','" & Obj.Nombre_transaccion & "','" & Obj.Moneda & "','" & Obj.Empleados & "','" & Obj.Banco_origen & "','" & Obj.Banco_destino & "')")

    End Function

    ''' <summary>
    ''' Consultar un registro
    ''' </summary>
    ''' <param name="Registro">Clave Primaria</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Consulta(ByVal Registro) As DataTable
        Dim DB As New DataBase
        Return DB.Query("SELECT * FROM " & Tabla & " WHERE " & PrimaryKey & "='" & Registro & "'")
    End Function

    ''' <summary>
    ''' Editar un registro
    ''' </summary>
    ''' <param name="Obj">Objeto Identidad</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Editar(ByVal Obj As I_Formato) As Boolean
        Dim DB As New DataBase

        Return DB.Update("UPDATE " & Tabla & " SET identificador='" & Obj.Identificador & "',nombre_transaccion='" & Obj.Nombre_transaccion & "',moneda='" & Obj.Moneda & "', empleados='" & Obj.Empleados & "', banco_origen='" & Obj.Banco_origen & "', banco_destino='" & Obj.Banco_destino & "' WHERE idformato='" & Obj.Idformato & "'")

    End Function

    ''' <summary>
    ''' Eliminar registro
    ''' </summary>
    ''' <param name="ID">Clave Primaria</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Eliminar(ByVal ID As String) As Boolean
        Dim DB As New DataBase

        Return DB.Update("DELETE FROM " & Tabla & " WHERE " & PrimaryKey & "='" & ID & "'")

    End Function

    ''' <summary>
    ''' Obtener Id del ultimo registro
    ''' </summary>
    ''' <returns></returns>
    Public Function Indice() As Integer
        Dim DB As New DataBase
        Return DB.Indice
    End Function

#End Region
End Class
