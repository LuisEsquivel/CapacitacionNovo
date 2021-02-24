Public Class TareasDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As Estructuras.DSTareas.TBLTAREASDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef tareas As Estructuras.DSTareas.TBLTAREASRow)
        tareas.CVE_TAREA_BIGINT = renglon.Item("CVE_TAREA_BIGINT")
        tareas.DESCRIPCION_VAR = renglon.Item("DESCRIPCION_VAR")
        tareas.DUDAS_PRESENTADAS_VAR = renglon.Item("DUDAS_PRESENTADAS_VAR")
        tareas.RESPUESTA_A_DUDAS_VAR = renglon.Item("RESPUESTA_A_DUDAS_VAR")
        tareas.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")
        tareas.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DATE")
        tareas.CVE_EMPLEADO_ALTA_VAR = renglon.Item("CVE_EMPLEADO_ALTA_VAR")
        tareas.CVE_EMPLEADO_MOD_VAR = renglon.Item("CVE_EMPLEADO_MOD_VAR")
    End Sub

    Public Sub Cargar(ByVal tabla As DataTable,
                      ByVal FECHA_INICIAL_DATE As DateTime,
                      ByVal FECHA_FINAL_DATE As DateTime,
                      Optional ByVal CVE_TAREA_BIGINT As Int64 = 0
                      )

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_TAREA_BIGINT", CVE_TAREA_BIGINT, SqlDbType.BigInt)
        SQL.AddParam("@FECHA_INICIAL_DATE", FECHA_INICIAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@FECHA_FINAL_DATE", FECHA_FINAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLTAREAS"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar tareas " & ex.Message)
        End Try

    End Sub

    Public Function Agregar(ByRef tareas As Estructuras.DSTareas.TBLTAREASRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_TAREA_BIGINT", tareas.CVE_TAREA_BIGINT, SqlDbType.BigInt)
        SQL.AddParam("@DESCRIPCION_VAR", tareas.DESCRIPCION_VAR, SqlDbType.VarChar)
        SQL.AddParam("@DUDAS_PRESENTADAS_VAR", tareas.DUDAS_PRESENTADAS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RESPUESTA_A_DUDAS_VAR", tareas.RESPUESTA_A_DUDAS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA_DATE", tareas.FECHA_ALTA_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_EMPLEADO_ALTA_VAR", tareas.CVE_EMPLEADO_ALTA_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLTAREAS"

        Try
            dt = New Estructuras.DSTareas.TBLTAREASDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), tareas)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar tareas " & ex.Message)
        End Try

        Return False

    End Function

    Public Function Modificar(ByRef tareas As Estructuras.DSTareas.TBLTAREASRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_TAREA_BIGINT", tareas.CVE_TAREA_BIGINT, SqlDbType.BigInt)
        SQL.AddParam("@DESCRIPCION_VAR", tareas.DESCRIPCION_VAR, SqlDbType.VarChar)
        SQL.AddParam("@DUDAS_PRESENTADAS_VAR", tareas.DUDAS_PRESENTADAS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RESPUESTA_A_DUDAS_VAR", tareas.RESPUESTA_A_DUDAS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_MOD_DATE", tareas.FECHA_MOD_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_EMPLEADO_MOD_VAR", tareas.CVE_EMPLEADO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLTAREAS"

        Try
            dt = New Estructuras.DSTareas.TBLTAREASDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), tareas)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar tareas " & ex.Message)
        End Try

        Return False

    End Function



    Public Function Eliminar(ByRef cve As Int64) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_TAREA_BIGINT", cve, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Eliminar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLTAREAS"

        Try

            If SQL.ExecuteScalar() = 0 Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar tareas " & ex.Message)
        End Try

        Return False

    End Function


End Class
