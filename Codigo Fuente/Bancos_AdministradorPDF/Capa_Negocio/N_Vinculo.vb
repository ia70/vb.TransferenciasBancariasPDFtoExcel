Imports Capa_Datos
Imports Capa_Identidad

Public Class N_Vinculo

    Public Function ListaCuentas(ByVal ID_Empresa As Integer) As DataTable
        Dim db_Vinculo As New D_Vinculo
        Return db_Vinculo.Lista(ID_Empresa)
    End Function

    Public Function EliminarEmpresa(ByVal IDEmpresa As Integer) As Boolean
        Dim db_Empresa As New D_Vinculo

        Return db_Empresa.EliminarVinculo(IDEmpresa)
    End Function

    Public Function Insertar(ByVal Vinculo As I_Vinculo) As Boolean
        Dim dbVinculo As New D_Vinculo

        Return dbVinculo.Insertar(Vinculo)
    End Function
End Class
