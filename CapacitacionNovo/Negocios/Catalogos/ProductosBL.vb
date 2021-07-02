Public Class ProductosBL
    Inherits Estructuras.DSProductos


    Dim DAL As Datos.ProductosDAL

    Public Sub Cargar(Optional ByVal CVE_PRODUCTOS_INT As Int32 = 0)

        DAL = New Datos.ProductosDAL
        DAL.cargar(TBLPRODUCTOS, CVE_PRODUCTOS_INT)

    End Sub

    Public Function agregar(ByVal Productos As TBLPRODUCTOSRow) As Boolean

        DAL = New Datos.ProductosDAL
        If DAL.Agregar(Productos) Then
            TBLPRODUCTOS.Rows.Add(Productos)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar(ByVal Productos As TBLPRODUCTOSRow) As Boolean

        DAL = New Datos.ProductosDAL
        If DAL.Modificar(Productos) Then

            TBLPRODUCTOS.FindByCVE_PRODUCTOS_INT(Productos.CVE_PRODUCTOS_INT).NOMBRE_VAR = Productos.NOMBRE_VAR
            TBLPRODUCTOS.FindByCVE_PRODUCTOS_INT(Productos.CVE_PRODUCTOS_INT).FECHA_MOD_DATE = Productos.FECHA_MOD_DATE
            TBLPRODUCTOS.FindByCVE_PRODUCTOS_INT(Productos.CVE_PRODUCTOS_INT).FECHA_ALTA_DATE = Productos.FECHA_ALTA_DATE
            TBLPRODUCTOS.FindByCVE_PRODUCTOS_INT(Productos.CVE_PRODUCTOS_INT).CVE_PRODUCTOS_MOD_VAR = Productos.CVE_PRODUCTOS_MOD_VAR
            TBLPRODUCTOS.FindByCVE_PRODUCTOS_INT(Productos.CVE_PRODUCTOS_INT).CVE_PRODUCTOS_ALTA_VAR = Productos.CVE_PRODUCTOS_ALTA_VAR
            TBLPRODUCTOS.FindByCVE_PRODUCTOS_INT(Productos.CVE_PRODUCTOS_INT).ACTIVO_BIT = Productos.ACTIVO_BIT
            Return True
        Else
            Return False
        End If
    End Function

End Class
