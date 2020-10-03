Imports Capa_Identidad

Public Class D_Banco
#Region "Variables"
    Private Tabla As String = "banco"
    Private PrimaryKey As String = "no_cuenta"

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
        Return DB.Query("SELECT no_cuenta 'Número de cuenta', nombre_banco 'Nombre del Banco', nombre_cuenta 'Cuenta', rfc 'RFC', moneda 'Moneda', tipo 'Tipo' FROM " & Tabla)
    End Function

    ''' <summary>
    ''' Obtiene Lista Banco Origen
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function ListaBancoOrigen() As DataTable
        Dim DB As New DataBase
        Return DB.Query("SELECT no_cuenta 'Número de cuenta', nombre_banco 'Nombre del Banco', nombre_cuenta 'Cuenta', rfc 'RFC', moneda 'Moneda' FROM " & Tabla & " WHERE tipo='Origen'")
    End Function

    ''' <summary>
    ''' Obtiene Lista Banco Destino
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function ListaBancoDestino() As DataTable
        Dim DB As New DataBase
        Return DB.Query("SELECT no_cuenta 'Número de cuenta', nombre_banco 'Nombre del Banco', nombre_cuenta 'Cuenta', rfc 'RFC', moneda 'Moneda' FROM " & Tabla & " WHERE tipo='Destino'")
    End Function

    ''' <summary>
    ''' Insertar
    ''' </summary>
    ''' <param name="Obj">Objeto Identidad</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Insertar(ByVal Obj As I_Banco) As Boolean
        Dim DB As New DataBase

        Return DB.Update("INSERT INTO " & Tabla & " VALUES('" & Obj.No_cuenta & "','" & Obj.Nombre_banco & "','" & Obj.Nombre_cuenta & "','" & Obj.Rfc & "','" & Obj.Moneda & "','" & Obj.Tipo & "')")

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
    Public Function Editar(ByVal Obj As I_Banco) As Boolean
        Dim DB As New DataBase

        Return DB.Update("UPDATE " & Tabla & " SET nombre_banco='" & Obj.Nombre_banco & "',nombre_cuenta='" & Obj.Nombre_cuenta & "',rfc='" & Obj.Rfc & "',moneda='" & Obj.Moneda & "', tipo='" & Obj.Tipo & "' WHERE no_cuenta='" & Obj.No_cuenta & "'")

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
