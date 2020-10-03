Imports System.Data.SQLite

''' <summary>
''' Clase - Motor Base de datos
''' </summary>
Public Class DataBase
    '----- BASE DE DATOS --> SQLite -----
#Region "Variables"
    Private BaseDeDatos As String = "DBLite.db"     '-> Nombre de la Base de datos
    Private Password As String = ""                 '-> Password de la Base de datos
    Private Conexion As SQLiteConnection            '-> Variable de conexión a la Base de datos

#End Region
#Region "Constructor"
    Public Sub New()
        Conectar()
    End Sub

#End Region
#Region "Funciones"
    ''' <summary>
    ''' Establecer conexión con la Base de datos
    ''' </summary>
    ''' <returns>True - Si conexión exitosa</returns>
    Private Function Conectar() As Boolean
        Try
            Conexion = New SQLiteConnection
            Conexion.ConnectionString = "Data Source=" & BaseDeDatos & ";Password=" & Password & ";Version=3;New=False;Compress=True;"
            Conexion.Open()
            Return True
        Catch ex As SQLiteException
            MsgBox("Error de conexión a la base de datos!.  Error: " + ex.ToString, vbCritical, "Administrador de Bancos")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Obtener indice AI del ultimo registro insertado
    ''' </summary>
    ''' <returns></returns>
    Public Function Indice() As Integer
        Dim sql As String = "select last_insert_id()"

        Dim cmd As New SQLiteCommand(sql, Conexion)
        Dim dt As New DataTable
        Dim da As New SQLiteDataAdapter(cmd)

        Try
            da.Fill(dt)
            Return Val(dt.Rows(0).Item(0))
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' Actualizar registros de la Base de datos
    ''' </summary>
    ''' <param name="sql">Sentencia SQL</param>
    ''' <returns>True - Si se modifico algun registro</returns>
    Public Function Update(ByVal sql As String) As Boolean
        Dim cmd As New SQLiteCommand
        Dim Res As Integer

        Try
            cmd.CommandText = sql
            cmd.Connection = Conexion
            Res = cmd.ExecuteNonQuery()

            Res = Math.Abs(Res)

            If Res > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Consulta de registros de la Base de datos
    ''' </summary>
    ''' <param name="sql">Sentencia SQL</param>
    ''' <returns>DataTable de resultados</returns>
    Public Function Query(ByVal sql As String) As DataTable
        Dim cmd As New SQLiteCommand(sql, Conexion)
        Dim dt As New DataTable
        Dim da As New SQLiteDataAdapter(cmd)

        Try
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

#End Region
End Class
