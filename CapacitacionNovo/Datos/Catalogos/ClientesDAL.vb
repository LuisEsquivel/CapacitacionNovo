Public Class ClientesDAL
    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As Estructuras.DsClientes.TBLCLIENTESDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef Clientes As Estructuras.DsClientes.TBLCLIENTESRow)
        Clientes.CVE_CLIENTE_INT = renglon.Item("CVE_CLIENTE_INT")
        Clientes.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        Clientes.CVE_USUARIO_ALTA_VAR = renglon.Item("CVE_USUARIO_ALTA_VAR")
        Clientes.CVE_USUARIO_MOD_VAR = renglon.Item("CVE_USUARIO_MOD_VAR")
        Clientes.ACTIVO_BIT = renglon.Item("ACTIVO_BIT")
    End Sub


    Public Sub cargar(ByVal tabla As DataTable, Optional ByVal CVE_CLIENTE_INT As Int32 = 0)
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_CLIENTE_INT", CVE_CLIENTE_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLCLIENTES"

        Try


            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Erro al cargar Clientes" & ex.Message)
        End Try
    End Sub

    Public Function Agregar(ByRef CLIENTE As Estructuras.DsClientes.TBLCLIENTESRow) As Boolean
        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@NOMBRE_VAR", CLIENTE.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_USUARIO_ALTA_VAR", CLIENTE.CVE_USUARIO_ALTA_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", CLIENTE.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLCLIENTES"

        Try
            dt = New Estructuras.DsClientes.TBLCLIENTESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), CLIENTE)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error en agregar Cliente" & ex.Message)
        End Try

        Return False
    End Function

    Public Function Modificar(ByRef CLIENTE As Estructuras.DsClientes.TBLCLIENTESRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Globales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@CVE_CLIENTE_INT", CLIENTE.CVE_CLIENTE_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_VAR", CLIENTE.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_USUARIO_MOD_VAR", CLIENTE.CVE_USUARIO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@ACTIVO_BIT", CLIENTE.ACTIVO_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLClientes"

        Try
            dt = New Estructuras.DsClientes.TBLCLIENTESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), CLIENTE)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar CLIENTE" + ex.ToString)

        End Try

        Return False

    End Function

End Class


