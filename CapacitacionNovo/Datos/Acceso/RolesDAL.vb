Public Class RolesDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As Estructuras.DsRoles.TBLROLESDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef Roles As Estructuras.DsRoles.TBLROLESRow)
        Roles.CVE_ROL_INT = renglon.Item("CVE_ROL_INT")
        Roles.DESC_ROL_VAR = renglon.Item("DESC_ROL_VAR")
        Roles.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DATE")
        Roles.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")
        Roles.CVE_USUARIO_ALTA_VAR = renglon.Item("CVE_USUARIO_ALTA_VAR")
        Roles.CVE_USUARIO_MOD_VAR = renglon.Item("CVE_USUARIO_MOD_VAR")
        Roles.ACTIVO_BIT = renglon.Item("ACTIVO_BIT")
    End Sub

    Public Sub Cargar(ByVal tabla As DataTable, Optional ByVal CVE_ROL_INT As Int32 = 0)

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_ROL_INT", CVE_ROL_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLROLES"

        Try

            SQL.FillDt(tabla)

        Catch ex As Exception
            MsgBox("Error al cargar roles" & ex.Message)
        End Try
    End Sub

    Public Function Agregar(ByRef Roles As Estructuras.DsRoles.TBLROLESRow) As Boolean
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@DESC_ROL_VAR", Roles.DESC_ROL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA_DATE", Roles.FECHA_ALTA_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_USUARIO_VAR", Roles.CVE_USUARIO_ALTA_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", Roles.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLROLES"
        Try
            dt = New Estructuras.DsRoles.TBLROLESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), Roles)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar Role" & ex.Message)
        End Try

        Return False
    End Function

    Public Function Modificar(ByRef Roles As Estructuras.DsRoles.TBLROLESRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@CVE_ROL_INT", Roles.CVE_ROL_INT, SqlDbType.Int)
        SQL.AddParam("@DESC_ROL_VAR", Roles.DESC_ROL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_MOD_DATE", Roles.FECHA_MOD_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_USUARIO_MOD_VAR", Roles.CVE_USUARIO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", Roles.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLROLES"

        Try
            dt = New Estructuras.DsRoles.TBLROLESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), Roles)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar Roles" + ex.ToString)

        End Try

        Return False

    End Function

End Class
