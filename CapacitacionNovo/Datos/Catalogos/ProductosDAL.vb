Public Class ProductosDAL
    Dim SQL As SQLconn.ADONet.SQLConn
<<<<<<< Updated upstream
    Dim dt As Estructuras.DSProductos.TBLPRODUCTOSDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef Productos As Estructuras.DSProductos.TBLPRODUCTOSRow)
        Productos.CVE_PRODUCTOS_INT = renglon.Item("CVE_PRODUCTOS_INT")
        Productos.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        Productos.CVE_PRODUCTOS_ALTA_VAR = renglon.Item("CVE_PRODUCTOS_ALTA_VAR")
        Productos.CVE_PRODUCTOS_MOD_VAR = renglon.Item("CVE_PRODUCTOS_MOD_VAR")
=======
    Dim dt As Estructuras.DsProductos.TBLCOLORESDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef Productos As Estructuras.DsProductos.TBLPRODUCTOSRow)
        Productos.CVE_PRODUCTOS_INT = renglon.Item("CVE_PRODUCTOS_INT")
        Productos.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        Productos.CVE_USUARIO_ALTA_VAR = renglon.Item("CVE_USUARIO_ALTA_VAR")
        Productos.CVE_USUARIO_MOD_VAR = renglon.Item("CVE_USUARIO_MOD_VAR")
        Productos.CODIGO_COLOR_VAR = renglon.Item("CODIGO_COLOR_VAR")
>>>>>>> Stashed changes
        Productos.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")
        Productos.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DATE")
        Productos.ACTIVO_BIT = renglon.Item("ACTIVO_BIT")
    End Sub

    Public Sub cargar(ByVal tabla As DataTable, Optional ByVal CVE_PRODUCTOS_INT As Int32 = 0)
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PRODUCTOS_INT", CVE_PRODUCTOS_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLCOLORES"

        Try


            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Erro al cargar roles" & ex.Message)
        End Try
    End Sub

<<<<<<< Updated upstream
    Public Function Agregar(ByRef Productos As Estructuras.DSProductos.TBLPRODUCTOSRow) As Boolean
=======
    Public Function Agregar(ByRef Productos As Estructuras.DsProductos.TBLPRODUCTOSRow) As Boolean
>>>>>>> Stashed changes
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@NOMBRE_VAR", Productos.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA_DATE", Productos.FECHA_ALTA_DATE, SqlDbType.DateTime)
<<<<<<< Updated upstream
        SQL.AddParam("@CVE_USUARIO_ALTA_VAR", Productos.CVE_PRODUCTOS_ALTA_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CODIGO_COLOR_VAR", Productos.CVE_PRODUCTOS_INT, SqlDbType.VarChar)
=======
        SQL.AddParam("@CVE_USUARIO_ALTA_VAR", Productos.CVE_USUARIO_ALTA_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CODIGO_COLOR_VAR", Productos.CODIGO_COLOR_VAR, SqlDbType.VarChar)
>>>>>>> Stashed changes
        SQL.AddParam("@ACTIVO_BIT", Productos.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLCOLORES"

        Try
<<<<<<< Updated upstream
            dt = New Estructuras.DSProductos.TBLPRODUCTOSDataTable
=======
            dt = New Estructuras.DsProductos.TBLCOLORESDataTable
>>>>>>> Stashed changes
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), Productos)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error en agregar Productos" & ex.Message)
        End Try

        Return False
    End Function

<<<<<<< Updated upstream
    Public Function Modificar(ByRef Productos As Estructuras.DSProductos.TBLPRODUCTOSRow) As Boolean
=======
    Public Function Modificar(ByRef Productos As Estructuras.DsProductos.TBLPRODUCTOSRow) As Boolean
>>>>>>> Stashed changes

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@CVE_PRODUCTOS_INT", Productos.CVE_PRODUCTOS_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_VAR", Productos.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_MOD_DATE", Productos.FECHA_MOD_DATE, SqlDbType.DateTime)
<<<<<<< Updated upstream
        SQL.AddParam("@CVE_USUARIO_MOD_VAR", Productos.CVE_PRODUCTOS_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", Productos.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLCOLORES"

        Try
            dt = New Estructuras.DSProductos.TBLPRODUCTOSDataTable
=======
        SQL.AddParam("@CVE_USUARIO_MOD_VAR", Productos.CVE_USUARIO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CODIGO_COLOR_VAR", Productos.CODIGO_COLOR_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", Productos.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLProductos"

        Try
            dt = New Estructuras.DsProductos.TBLCOLORESDataTable
>>>>>>> Stashed changes
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), Productos)
                Return True
            End If
        Catch ex As Exception
<<<<<<< Updated upstream
            MsgBox("Error al modificar Productos" + ex.ToString)
=======
            MsgBox("Error al modificar PRODUCTOS" + ex.ToString)
>>>>>>> Stashed changes

        End Try

        Return False

    End Function

End Class


<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
