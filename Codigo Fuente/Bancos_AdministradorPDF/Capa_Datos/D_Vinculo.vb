Imports Capa_Identidad

Public Class D_Vinculo
#Region "Variables"
    Private Tabla As String = "vinculo"
    Private PrimaryKey As String = "idvinculo"

#End Region
#Region "Constructor"

#End Region
#Region "Funciones"
    ''' <summary>
    ''' Obtiene Lista completa de los registros
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function Lista(ByVal ID_Empresa As Integer) As DataTable
        Dim DB As New DataBase
        Return DB.Query("SELECT banco.no_cuenta 'Número de cuenta', banco.nombre_banco 'Banco', banco.nombre_cuenta 'Cuenta', banco.rfc 'RFC', banco.moneda 'Moneda' FROM banco JOIN vinculo ON banco.no_cuenta=vinculo.no_cuenta WHERE vinculo.idempresa_externa=" & ID_Empresa)
    End Function

    ''' <summary>
    ''' Insertar
    ''' </summary>
    ''' <param name="Obj">Objeto Identidad</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Insertar(ByVal Obj As I_Vinculo) As Boolean
        Dim DB As New DataBase

        Return DB.Update("INSERT INTO " & Tabla & " VALUES(null," & Obj.Idempresa_externa & ",'" & Obj.Numero_cuenta & "')")

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
    Public Function Editar(ByVal Obj As I_Vinculo) As Boolean
        Dim DB As New DataBase

        Return DB.Update("UPDATE " & Tabla & " SET idempresa_externa=" & Obj.Idempresa_externa & ",no_cuenta='" & Obj.Numero_cuenta & "' WHERE idvinculo=" & Obj.Idvinculo)

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

    ''' <summary>
    ''' Eliminar registro
    ''' </summary>
    ''' <param name="ID">ID Empresa</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function EliminarVinculo(ByVal ID As String) As Boolean
        Dim DB As New DataBase

        Return DB.Update("DELETE FROM " & Tabla & " WHERE idempresa_externa=" & ID)

    End Function

#End Region
End Class
