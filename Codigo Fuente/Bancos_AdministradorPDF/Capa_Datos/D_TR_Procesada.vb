

Public Class D_TR_Procesada
#Region "Variables"
    Private Tabla As String = "tr_procesada"
    Private PrimaryKey As String = "clave_rastreo"

#End Region
#Region "Constructor"

#End Region
#Region "Funciones"

    ''' <summary>
    ''' Insertar
    ''' </summary>
    ''' <param name="Clave_Rastreo">Clave de rastreo</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Insertar(ByVal Clave_Rastreo As String) As Boolean
        Dim DB As New DataBase
        Dim res As Integer

        res = DB.Update("INSERT INTO " & Tabla & " VALUES('" & Clave_Rastreo & "')")

        If res > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' Consultar un registro
    ''' </summary>
    ''' <param name="Clave_Rastreo">Clave de rastreo</param>
    ''' <returns>True - Si exitoso</returns>
    Public Function Consulta(ByVal Clave_Rastreo As String) As Boolean
        Dim DB As New DataBase
        Dim res As Integer
        Dim TB As DataTable
        TB = DB.Query("SELECT * FROM " & Tabla & " WHERE " & PrimaryKey & "='" & Clave_Rastreo & "'")

        res = TB.Rows.Count

        If res > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region
End Class
