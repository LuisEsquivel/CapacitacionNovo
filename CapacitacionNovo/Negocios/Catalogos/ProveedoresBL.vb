Public Class ProveedoresBL

    Inherits Estructuras.DSProveedores

    Dim DAL As Datos.ProveedoresDAL

    Public Sub Cargar(Optional ByVal CVE_PROVEEDOR_INT As Int32 = 0)

        DAL = New Datos.ProveedoresDAL
        DAL.cargar(TBLPROVEEDORES, CVE_PROVEEDOR_INT)

    End Sub

    Public Function agregar(ByVal proveedor As TBLPROVEEDORESRow) As Boolean

        DAL = New Datos.ProveedoresDAL
        If DAL.agregar(proveedor) Then
            TBLPROVEEDORES.Rows.Add(proveedor)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar(ByVal proveedor As TBLPROVEEDORESRow) As Boolean

        DAL = New Datos.ProveedoresDAL
        If DAL.Modificar(proveedor) Then

            TBLPROVEEDORES.FindByCVE_PROVEEDOR_INT(proveedor.CVE_PROVEEDOR_INT).NOMBRE_VAR = proveedor.NOMBRE_VAR
            TBLPROVEEDORES.FindByCVE_PROVEEDOR_INT(proveedor.CVE_PROVEEDOR_INT).CVE_PROVEEDOR_INT = proveedor.CVE_PROVEEDOR_INT
            TBLPROVEEDORES.FindByCVE_PROVEEDOR_INT(proveedor.CVE_PROVEEDOR_INT).FECHA_ALTA_DATE = proveedor.FECHA_ALTA_DATE
            TBLPROVEEDORES.FindByCVE_PROVEEDOR_INT(proveedor.CVE_PROVEEDOR_INT).CVE_EMPLEADO_MOD_VAR = proveedor.CVE_EMPLEADO_MOD_VAR
            TBLPROVEEDORES.FindByCVE_PROVEEDOR_INT(proveedor.CVE_PROVEEDOR_INT).CVE_EMPLEADO_ALTA_VAR = proveedor.CVE_EMPLEADO_ALTA_VAR
            TBLPROVEEDORES.FindByCVE_PROVEEDOR_INT(proveedor.CVE_PROVEEDOR_INT).CORREO_ELECTRONICO_VAR = proveedor.CORREO_ELECTRONICO_VAR
            TBLPROVEEDORES.FindByCVE_PROVEEDOR_INT(proveedor.CVE_PROVEEDOR_INT).ACTIVO_BIT = proveedor.ACTIVO_BIT
            Return True
        Else
            Return False
        End If
    End Function

End Class
