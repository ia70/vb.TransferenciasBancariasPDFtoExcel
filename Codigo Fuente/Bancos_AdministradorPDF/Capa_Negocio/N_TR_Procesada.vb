Imports Capa_Datos

Public Class N_TR_Procesada

    ''' <summary>
    ''' Insertar Transacción
    ''' </summary>
    ''' <param name="Clave_Rastreo"></param>
    ''' <returns></returns>
    Public Function Insertar(ByVal Clave_Rastreo As String) As Boolean
        Dim DB As New D_TR_Procesada
        Return DB.Insertar(Clave_Rastreo)
    End Function

    ''' <summary>
    ''' Consultar se existe transacción
    ''' </summary>
    ''' <param name="Clave_Rastreo"></param>
    ''' <returns></returns>
    Public Function Consultar(ByVal Clave_Rastreo As String) As Boolean
        Dim DB As New D_TR_Procesada
        Return DB.Consulta(Clave_Rastreo)
    End Function
End Class
