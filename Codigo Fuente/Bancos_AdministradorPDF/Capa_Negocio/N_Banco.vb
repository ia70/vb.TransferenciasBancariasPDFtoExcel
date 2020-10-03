Imports Capa_Datos

Public Class N_Banco

    Public Function Lista() As DataTable
        Dim Bancos As New D_Banco

        Return Bancos.Lista
    End Function

    Public Function ListaBancoOrigen() As DataTable
        Dim Bancos As New D_Banco

        Return Bancos.ListaBancoOrigen
    End Function

    Public Function ListaBancoDestino() As DataTable
        Dim Bancos As New D_Banco

        Return Bancos.ListaBancoDestino
    End Function
End Class
