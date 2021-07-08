Public Class ProductosDAL
    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As Estructuras.DSProductos.TBLPRODUCTOSDataTable





    Private Sub Llenar(ByVal renglon As DataRow, ByRef Productos As Estructuras.DsProductos.TBLPRODUCTOSRow)
        Productos.CVE_PRODUCTOS_INT = renglon.Item("CVE_PRODUCTOS_INT")
        Productos.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        Productos.CVE_PRODUCTOS_ALTA_VAR = renglon.Item("CVE_PRODUCTOS_ALTA_VAR")
        Productos.CVE_PRODUCTOS_MOD_VAR = renglon.Item("CVE_PRODUCTOS_MOD_VAR")


        Productos.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")
        Productos.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DATE")
        Productos.ACTIVO_BIT = renglon.Item("ACTIVO_BIT")
    End Sub

    Public Sub cargar(ByVal tabla As DataTable, Optional ByVal CVE_PRODUCTOS_INT As Int32 = 0)
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PRODUCTOS_INT", CVE_PRODUCTOS_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLPRODUCTOS"

        Try


            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Erro al cargar productos" & ex.Message)
        End Try
    End Sub


    Public Function Agregar(ByRef Productos As Estructuras.DSProductos.TBLPRODUCTOSRow) As Boolean



        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@NOMBRE_VAR", Productos.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA_DATE", Productos.FECHA_ALTA_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_PRODUCTOS_ALTA_VAR", Productos.CVE_PRODUCTOS_ALTA_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", Productos.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLPRODUCTOS"

        Try
            dt = New Estructuras.DSProductos.TBLPRODUCTOSDataTable



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


    Public Function Modificar(ByRef Productos As Estructuras.DSProductos.TBLPRODUCTOSRow) As Boolean


        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@CVE_PRODUCTOS_INT", Productos.CVE_PRODUCTOS_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_VAR", Productos.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_MOD_DATE", Productos.FECHA_MOD_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_PRODUCTOS_MOD_VAR", Productos.CVE_PRODUCTOS_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", Productos.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLPRODUCTOS"

        Try
            dt = New Estructuras.DSProductos.TBLPRODUCTOSDataTable

            SQL.AddParam("@CVE_PRODUCTOS_MOD_VAR", Productos.CVE_PRODUCTOS_MOD_VAR, SqlDbType.VarChar)

            SQL.AddParam("@ACTIVO_BIT", Productos.ACTIVO_BIT, SqlDbType.Bit)
            SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

            SQL.cmdText = "PROC_TBLPRODUCTOS"

        Finally

        End Try

        Try
                dt = New Estructuras.DSProductos.TBLPRODUCTOSDataTable

                SQL.FillDt(dt)
                If dt.Rows.Count > 0 Then
                    Llenar(dt.Rows(0), Productos)
                    Return True
                End If
            Catch ex As Exception

                MsgBox("Error al modificar Productos" + ex.ToString)



            End Try


        Return False

    End Function

End Class



