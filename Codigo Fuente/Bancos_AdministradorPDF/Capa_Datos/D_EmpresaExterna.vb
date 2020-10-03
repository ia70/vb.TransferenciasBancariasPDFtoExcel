Imports Capa_Identidad

Public Class D_EmpresaExterna
#Region "Variables"
    Private Tabla As String = "empresa_externa"
    Private PrimaryKey As String = "idempresa_externa"

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
    Public Function Insertar(ByVal Obj As I_EmpresaExterna) As Boolean
        Dim DB As New DataBase

        Return DB.Update("INSERT INTO " & Tabla & " VALUES(null,'" & Obj.Razon_social & "','" & Obj.Rfc & "','" & Obj.Descripcion & "')")

    End Function

    ''' <summary>
    ''' Consultar un registro
    ''' </summary>
    ''' <param name="Registro">Clave Primaria</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Consulta(ByVal Registro) As DataTable
        Dim DB As New DataBase
        Return DB.Query("SELECT * FROM " & Tabla & " WHERE " & PrimaryKey & "=" & Registro)
    End Function

    ''' <summary>
    ''' Editar un registro
    ''' </summary>
    ''' <param name="Obj">Objeto Identidad</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Editar(ByVal Obj As I_EmpresaExterna) As Boolean
        Dim DB As New DataBase

        Return DB.Update("UPDATE " & Tabla & " SET razon_social='" & Obj.Razon_social & "',rfc='" & Obj.Rfc & "',descripcion='" & Obj.Descripcion & "' WHERE " & PrimaryKey & "=" & Obj.Idempresa_externa)

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
