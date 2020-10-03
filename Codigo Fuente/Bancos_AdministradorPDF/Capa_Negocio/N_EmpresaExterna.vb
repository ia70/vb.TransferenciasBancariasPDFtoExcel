Imports Capa_Datos
Imports Capa_Identidad
Public Class N_EmpresaExterna

    Public Function Lista() As DataTable
        Dim db_Empresa As New D_EmpresaExterna

        Return db_Empresa.Lista
    End Function

    Public Function Eliminar(ByVal ID As String) As Boolean
        Dim Empresa As New D_EmpresaExterna

        Return Empresa.Eliminar(ID)
    End Function

    Public Function Insertar(ByVal Razon As String, ByVal RFC As String, ByVal Descripcion As String) As Boolean
        Dim db_Empresa As New D_EmpresaExterna
        Dim _I_Empresa As New I_EmpresaExterna

        _I_Empresa.Razon_social = Razon
        _I_Empresa.Rfc = RFC
        _I_Empresa.Descripcion = Descripcion

        Return db_Empresa.Insertar(_I_Empresa)
    End Function
End Class
