Imports Capa_Identidad

Public Class D_CamposInicio
#Region "Variables"
    Private Tabla As String = "campos_inicio"
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
    Public Function Insertar(ByVal Obj As I_CamposInicio) As Boolean
        Dim DB As New DataBase

        Return DB.Update("INSERT INTO " & Tabla & " VALUES('" & Obj.Idformato & "','" & Obj.C0 & "','" & Obj.C1 & "','" & Obj.C2 & "','" & Obj.C3 & "','" & Obj.C4 & "','" & Obj.C5 & "','" & Obj.C6 & "','" & Obj.C7 & "','" & Obj.C8 & "','" & Obj.C9 & "','" & Obj.C10 & "','" & Obj.C11 & "','" & Obj.C12 & "','" & Obj.C13 & "','" & Obj.C14 & "','" & Obj.C15 & "','" & Obj.C16 & "')")

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
    Public Function Editar(ByVal Obj As I_CamposInicio) As Boolean
        Dim DB As New DataBase

        Return DB.Update("UPDATE " & Tabla & " SET c0='" & Obj.C0 & "',c1='" & Obj.C1 & "',c2='" & Obj.C2 & "',c3='" & Obj.C3 & "',c4='" & Obj.C4 & "',c5='" & Obj.C5 & "',c6='" & Obj.C6 & "',c7='" & Obj.C7 & "',c8='" & Obj.C8 & "',c9='" & Obj.C9 & "',c10='" & Obj.C10 & "',c11='" & Obj.C11 & "',c12='" & Obj.C12 & "',c13='" & Obj.C13 & "',c14='" & Obj.C14 & "',c15='" & Obj.C15 & "',c16='" & Obj.C16 & "' WHERE " & PrimaryKey & "='" & Obj.Idformato & "'")

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

#End Region
End Class
