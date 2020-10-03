Imports Capa_Datos

Public Class N_Transacciones
    Public Function Lista() As DataTable
        Dim db_Transacciones As New D_Transaccion

        Return db_Transacciones.Lista
    End Function

    Public Function Consulta(ByVal IDTrasaccion As String) As DataTable
        Dim dbTransaccion As New D_Transaccion

        Return dbTransaccion.Consulta(IDTrasaccion)
    End Function
End Class
