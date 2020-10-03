Imports Capa_Datos

Public Class N_VaciarBaseDeDatos
    Public Sub VaciarTodo()
        VaciarBancos()
        VaciarCamposFin()
        VaciarCamposInicio()
        VaciarCamposNombre()
        VaciarEmpleados()
        VaciarEmpresas()
        VaciarFormatos()
        VaciarTransacciones()
        VaciarTR_Procesadas()
        VaciarVinculos()
    End Sub

    Public Sub VaciarTR_Procesadas()
        Dim DB As New DataBase
        DB.Update("DELETE FROM tr_procesada")
    End Sub

    Public Sub VaciarTransacciones()
        Dim DB As New DataBase
        DB.Update("DELETE FROM transaccion")
    End Sub

    Public Sub VaciarEmpresas()
        Dim DB As New DataBase
        DB.Update("DELETE FROM empresa_externa")
    End Sub

    Public Sub VaciarVinculos()
        Dim DB As New DataBase
        DB.Update("DELETE FROM vinculo")
    End Sub

    Public Sub VaciarBancos()
        Dim DB As New DataBase
        DB.Update("DELETE FROM banco")
    End Sub

    Public Sub VaciarFormatos()
        Dim DB As New DataBase
        DB.Update("DELETE FROM formato")
    End Sub

    Public Sub VaciarEmpleados()
        Dim DB As New DataBase
        DB.Update("DELETE FROM empleados")
    End Sub

    Public Sub VaciarCamposInicio()
        Dim DB As New DataBase
        DB.Update("DELETE FROM campos_inicio")
    End Sub

    Public Sub VaciarCamposFin()
        Dim DB As New DataBase
        DB.Update("DELETE FROM campos_fin")
    End Sub

    Public Sub VaciarCamposNombre()
        Dim DB As New DataBase
        DB.Update("DELETE FROM campos_nombre")
    End Sub
End Class
