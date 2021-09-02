Public Class ProveedoresDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As Estructuras.DSProveedores.TBLPROVEEDORESDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef proveedor As Estructuras.DSProveedores.TBLPROVEEDORESRow)
        proveedor.CVE_PROVEEDOR_INT = renglon.Item("CVE_PROVEEDOR_INT")
        proveedor.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        proveedor.CVE_EMPLEADO_ALTA_VAR = renglon.Item("CVE_EMPLEADO_ALTA_VAR")
        proveedor.CORREO_ELECTRONICO_VAR = renglon.Item("CORREO_ELECTRONICO_VAR")
        proveedor.CVE_EMPLEADO_MOD_VAR = renglon.Item("CVE_EMPLEADO_MOD_VAR")
        proveedor.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")
        proveedor.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DATE")
        proveedor.ACTIVO_BIT = renglon.Item("ACTIVO_BIT")
    End Sub

    Public Sub cargar(ByVal tabla As DataTable, Optional ByVal CVE_PROVEEDOR_INT As Int32 = 0)
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PROVEEDOR_INT", CVE_PROVEEDOR_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLPROVEEDORES"

        Try


            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Erro al cargar Provedor" & ex.Message)
        End Try
    End Sub

    Public Function Agregar(ByRef proveedor As Estructuras.DSProveedores.TBLPROVEEDORESRow) As Boolean
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@NOMBRE_VAR", proveedor.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA_DATE", proveedor.FECHA_ALTA_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_EMPLEADO_ALTA_VAR", proveedor.CVE_EMPLEADO_ALTA_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RFC_VAR", proveedor.RFC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@DIRECCION_VAR", proveedor.DIRECCION_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RAZON_SOCIAL_VAR", proveedor.RAZON_SOCIAL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_PROVEEDOR_VAR", proveedor.NOMBRE_PROVEEDOR_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CORREO_ELECTRONICO_VAR", proveedor.CORREO_ELECTRONICO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", proveedor.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLPROVEEDOR"

        Try
            dt = New Estructuras.DSProveedores.TBLPROVEEDORESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), proveedor)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error en agregar Provedor" & ex.Message)
        End Try

        Return False
    End Function

    Public Function Modificar(ByRef proveedor As Estructuras.DSProveedores.TBLPROVEEDORESRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@CVE_COLOR_INT", proveedor.CVE_PROVEEDOR_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_VAR", proveedor.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_MOD_DATE", proveedor.FECHA_MOD_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_EMPLEADO_MOD_VAR", proveedor.CVE_EMPLEADO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CORREO_ELECTRONICO_VAR", proveedor.CORREO_ELECTRONICO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_PROVEEDOR_VAR", proveedor.NOMBRE_PROVEEDOR_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RAZON_SOCIAL_VAR", proveedor.RAZON_SOCIAL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RFC_VAR", proveedor.RFC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@DIRECCION_VAR", proveedor.DIRECCION_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", proveedor.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLPROVEEDOR"

        Try
            dt = New Estructuras.DSProveedores.TBLPROVEEDORESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), proveedor)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar Provedor" + ex.ToString)

        End Try

        Return False

    End Function

End Class
