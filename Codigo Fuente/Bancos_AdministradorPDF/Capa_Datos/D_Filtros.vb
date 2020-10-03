Public Class D_Filtros

    ''' <summary>
    ''' Obtiene Lista completa de los registros
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function Lista() As DataTable
        Dim DB As New DataBase
        Return DB.Query("SELECT * FROM transacciones ORDER BY idtransaccion ASC")
    End Function

    ''' <summary>
    ''' Consultar
    ''' </summary>
    ''' <param name="SQL">SQL</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Consulta(ByVal SQL As String) As DataTable
        Dim DB As New DataBase
        Return DB.Query(SQL)
    End Function
End Class
