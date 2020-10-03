Imports Capa_Datos

Public Class N_CamposNombre

    Public Function Consultar(ByVal IDTransaccion As String) As DataTable
        Dim dbCampos As New D_CamposNombre

        Return dbCampos.Consulta(IDTransaccion)
    End Function

End Class
