Public Class ColoresDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As Estructuras.DsColores.TBLCOLORESDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef Roles As Estructuras.DsColores.TBLCOLORESRow)
        Roles.CVE_COLOR_INT = renglon.Item("CVE_COLOR_INT")
        Roles.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        Roles.CVE_USUARIO_ALTA_VAR = renglon.Item("CVE_USUARIO_ALTA_VAR")
        Roles.CVE_USUARIO_MOD_VAR = renglon.Item("CVE_USUARIO_MOD_VAR")
        Roles.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")
        Roles.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DATE")
        Roles.ACTIVO_BIT = renglon.Item("ACTIVO_BIT")
    End Sub

    Public Sub cargar(ByVal tabla As DataTable, Optional ByVal CVE_COLOR_INT As Int32 = 0)
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_COLOR_INT", CVE_COLOR_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLCOLORES"

        Try


            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Erro al cargar roles" & ex.Message)
        End Try
    End Sub

    Public Function Agregar(ByRef COLORES As Estructuras.DsColores.TBLCOLORESRow) As Boolean
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@NOMBRE_VAR", COLORES.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA_DATE", COLORES.FECHA_ALTA_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_USUARIO_ALTA_VAR", COLORES.CVE_USUARIO_ALTA_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", COLORES.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLCOLORES"

        Try
            dt = New Estructuras.DsColores.TBLCOLORESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), COLORES)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error en agregar colores" & ex.Message)
        End Try

        Return False
    End Function

    Public Function Modificar(ByRef COLORES As Estructuras.DsColores.TBLCOLORESRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@CVE_COLOR_INT", COLORES.CVE_COLOR_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_VAR", COLORES.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_MOD_DATE", COLORES.FECHA_MOD_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_USUARIO_MOD_VAR", COLORES.CVE_USUARIO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", COLORES.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLCOLORES"

        Try
            dt = New Estructuras.DsColores.TBLCOLORESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), COLORES)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar COLORES" + ex.ToString)

        End Try

        Return False

    End Function

End Class
