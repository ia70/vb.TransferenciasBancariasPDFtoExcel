Imports Capa_Datos

Public Class N_Empleados
    Public Function Consultar(ByVal IDTransaccion As String) As DataTable
        Dim dbEmpleados As New D_Empleado

        Return dbEmpleados.Consulta(IDTransaccion)
    End Function
End Class
