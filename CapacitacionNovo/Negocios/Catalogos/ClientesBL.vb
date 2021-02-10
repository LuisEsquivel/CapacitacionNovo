Public Class ClientesBL
    Inherits Estructuras.DsClientes

    Dim DAL As Datos.ClientesDAL

    Public Sub Cargar(Optional ByVal CVE_CLIENTE_INT As Int32 = 0)

        DAL = New Datos.ClientesDAL
        DAL.cargar(TBLCLIENTES, CVE_CLIENTE_INT)

    End Sub

    Public Function agregar(ByVal Cliente As TBLCLIENTESRow) As Boolean

        DAL = New Datos.ClientesDAL
        If DAL.Agregar(Cliente) Then
            TBLCLIENTES.Rows.Add(Cliente)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar(ByVal Cliente As TBLCLIENTESRow) As Boolean

        DAL = New Datos.ClientesDAL
        If DAL.Modificar(Cliente) Then

            TBLCLIENTES.FindByCVE_CLIENTE_INT(Cliente.CVE_CLIENTE_INT).NOMBRE_VAR = Cliente.NOMBRE_VAR
            TBLCLIENTES.FindByCVE_CLIENTE_INT(Cliente.CVE_CLIENTE_INT).CVE_USUARIO_MOD_VAR = Cliente.CVE_USUARIO_MOD_VAR
            TBLCLIENTES.FindByCVE_CLIENTE_INT(Cliente.CVE_CLIENTE_INT).CVE_USUARIO_ALTA_VAR = Cliente.CVE_USUARIO_ALTA_VAR
            TBLCLIENTES.FindByCVE_CLIENTE_INT(Cliente.CVE_CLIENTE_INT).ACTIVO_BIT = Cliente.ACTIVO_BIT
            Return True
        Else
            Return False
        End If
    End Function

End Class
