Public Class EmpleadosDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As Estructuras.DsEmpleados.TBLEMPLEADOSDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef empleados As Estructuras.DsEmpleados.TBLEMPLEADOSRow)
        empleados.CVE_EMPLEADOS_VAR = renglon.Item("CVE_EMPLEADOS_VAR")
        empleados.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        empleados.ACTIVO_BIT = renglon.Item("ACTIVO_BIT")
        empleados.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")
        empleados.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DATE")
        empleados.CVE_EMPLEADO_VAR = renglon.Item("CVE_EMPLEADO_VAR")
        empleados.CVE_EMPLEADO_MOD_VAR = renglon.Item("CVE_EMPLEADO_MOD_VAR")
        empleados.CVE_ROL_INT = renglon.Item("CVE_ROL_INT")
        empleados.PASSWORD_VAR = renglon.Item("PASSWORD_VAR")
    End Sub

    Public Sub Cargar(ByVal tabla As DataTable, Optional ByVal CVE_EMPLEADOS_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_EMPLEADOS_VAR", CVE_EMPLEADOS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLEMPLEADOS"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar empleados " & ex.Message)
        End Try

    End Sub

    Public Function Agregar(ByRef empleados As Estructuras.DsEmpleados.TBLEMPLEADOSRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_EMPLEADOS_VAR", empleados.CVE_EMPLEADOS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", empleados.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", empleados.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@FECHA_ALTA_DATE", empleados.FECHA_ALTA_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_EMPLEADO_VAR", empleados.CVE_EMPLEADO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_ROL_INT", empleados.CVE_ROL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_COLOR_INT", empleados.CVE_COLOR_INT, SqlDbType.Int)
        SQL.AddParam("@PASSWORD_VAR", empleados.PASSWORD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLEMPLEADOS"

        Try
            dt = New Estructuras.DsEmpleados.TBLEMPLEADOSDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), empleados)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar empleados " & ex.Message)
        End Try

        Return False

    End Function

    Public Function Modificar(ByRef empleados As Estructuras.DsEmpleados.TBLEMPLEADOSRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_EMPLEADOS_VAR", empleados.CVE_EMPLEADOS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", empleados.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", empleados.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@FECHA_MOD_DATE", empleados.FECHA_MOD_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_EMPLEADO_MOD_VAR", empleados.CVE_EMPLEADO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_ROL_INT", empleados.CVE_ROL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_COLOR_INT", empleados.CVE_COLOR_INT, SqlDbType.Int)
        SQL.AddParam("@PASSWORD_VAR", empleados.PASSWORD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLEMPLEADOS"

        Try
            dt = New Estructuras.DsEmpleados.TBLEMPLEADOSDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), empleados)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar empleados " & ex.Message)
        End Try

        Return False

    End Function



End Class
