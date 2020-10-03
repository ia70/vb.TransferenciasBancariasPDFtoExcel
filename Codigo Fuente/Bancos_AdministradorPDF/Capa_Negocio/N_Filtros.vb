Imports Capa_Datos

Public Class N_Filtros

    Public Function Consultar() As DataTable
        Dim DB As New D_Transaccion
        Return DB.Lista
    End Function

    ''' <summary>
    ''' Clave de rastreo
    ''' </summary>
    ''' <param name="ClaveRastreo"></param>
    ''' <returns></returns>
    Public Function Consultar(ByVal ClaveRastreo As String) As DataTable
        Dim DB As New D_Filtros

        Return DB.Consulta("SELECT idtransaccion 'ID', idformato 'Formato', c0 'Clave de Rastreo', c1 'Banco Ordenante', c2 'Cuenta Ordenante', c3 'RFC Ordenante', c4 'No. Cuenta Ordenante', c5 'Banco Destino', c6 'Cuenta Destino', c7 'RFC Destino', c8 'No. Cuenta Destino', c9 'RT', c10 'Concepto', c11 'Beneficiario', c12 'Referencia', c13 'Folio de Internet', c14 'Importe', c15 'Moneda', c16 'Fecha' FROM transaccion WHERE idtransaccion LIKE '" & ClaveRastreo & "%' LIMIT 10")
    End Function

    ''' <summary>
    ''' Empresa
    ''' </summary>
    ''' <param name="_Empresa"></param>
    ''' <param name="FI"></param>
    ''' <param name="FF"></param>
    ''' <returns></returns>
    Public Function Consultar(ByVal _Empresa As String, ByVal FI As String, ByVal FF As String) As DataTable
        Dim DB As New D_Filtros
        Dim SQL As String = "SELECT idtransaccion 'ID', idformato 'Formato', c0 'Clave de Rastreo', c1 'Banco Ordenante', c2 'Cuenta Ordenante', c3 'RFC Ordenante', c4 'No. Cuenta Ordenante', c5 'Banco Destino', c6 'Cuenta Destino', c7 'RFC Destino', c8 'No. Cuenta Destino', c9 'RT', c10 'Concepto', c11 'Beneficiario', c12 'Referencia', c13 'Folio de Internet', c14 'Importe', c15 'Moneda', c16 'Fecha'"
        Dim SQL_Ext As String = " FROM transaccion TR INNER JOIN vinculo VIN ON TR.c4 = VIN.no_cuenta OR TR.c8=VIN.no_cuenta WHERE VIN.idempresa_externa=" & _Empresa

        If FI.Length > 0 Then
            SQL_Ext += " AND c16 BETWEEN '" & FI & "' AND '" & FF & "'"
        End If

        SQL_Ext += " ORDER BY c16 ASC;"

        Return DB.Consulta(SQL & SQL_Ext)
    End Function

    ''' <summary>
    ''' Bancos
    ''' </summary>
    ''' <param name="BO"></param>
    ''' <param name="BD"></param>
    ''' <param name="FI"></param>
    ''' <param name="FF"></param>
    ''' <returns></returns>
    Public Function Consultar(ByVal BO As String, ByVal BD As String, ByVal FI As String, ByVal FF As String) As DataTable
        Dim DB As New D_Filtros
        Dim SQL As String = "SELECT idtransaccion 'ID', idformato 'Formato', c0 'Clave de Rastreo', c1 'Banco Ordenante', c2 'Cuenta Ordenante', c3 'RFC Ordenante', c4 'No. Cuenta Ordenante', c5 'Banco Destino', c6 'Cuenta Destino', c7 'RFC Destino', c8 'No. Cuenta Destino', c9 'RT', c10 'Concepto', c11 'Beneficiario', c12 'Referencia', c13 'Folio de Internet', c14 'Importe', c15 'Moneda', c16 'Fecha' FROM transaccion "
        Dim SQL_Ext As String = "WHERE"
        Dim Std As Boolean = False

        If BO.Length > 0 Then
            SQL_Ext += " c4='" & BO & "'"
            Std = True
        End If

        If BD.Length > 0 Then
            If Std Then
                SQL_Ext += " AND c8='" & BD & "'"
            Else
                SQL_Ext += " c8='" & BD & "'"
                Std = True
            End If
        End If

        If FI.Length > 0 Then
            If Std Then
                SQL_Ext += " AND c16 BETWEEN '" & FI & "' AND '" & FF & "'"
            Else
                SQL_Ext += " c16 BETWEEN '" & FI & "' AND '" & FF & "'"
                Std = True
            End If
        End If

        SQL_Ext += " ORDER BY c16 ASC;"

        Return DB.Consulta(SQL & SQL_Ext)
    End Function

End Class
