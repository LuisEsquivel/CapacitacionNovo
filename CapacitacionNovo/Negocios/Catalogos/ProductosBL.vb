Public Class ProductosBL : Inherits Estructuras.DsProductos


    Dim DAL As Datos.ProductosDAL

    Public Sub Cargar(Optional ByVal CVE_PRODUCTOS_INT As Int32 = 0)

        DAL = New Datos.ProductosDAL
        'DAL.cargar(TBLProductos, CVE_PRODUCTOS_INT)

    End Sub

    Public Function agregar(ByVal Productos As TBLPRODUCTOSRow) As Boolean

        'DAL = New Datos.ProductosDAL
        'If DAL.Agregar(Productos) Then
        '    TBLProductos.Rows.Add(Productos)
        '    Return True
        'Else
        Return False
        'End If
    End Function

    Public Function Modificar(ByVal Productos As TBLPRODUCTOSRow) As Boolean

        'DAL = New Datos.ColoresDAL
        'If DAL.Modificar(Productos) Then

        TBLPRODUCTOS.FindByCVE_PRODUCTOS_INT(Productos.CVE_PRODUCTOS_INT).NOMBRE_VAR = Productos.NOMBRE_VAR
        'TBLPRODUCTOS.FindByCVE_COLOR_INT(Productos.CVE_COLOR_INT).FECHA_MOD_DATE = Productos.FECHA_MOD_DATE
        'TBLPRODUCTOS.FindByCVE_COLOR_INT(Productos.CVE_COLOR_INT).FECHA_ALTA_DATE = Productos.FECHA_ALTA_DATE
        'TBLPRODUCTOS.FindByCVE_COLOR_INT(Productos.CVE_COLOR_INT).CVE_USUARIO_MOD_VAR = Productos.CVE_USUARIO_MOD_VAR
        'TBLPRODUCTOS.FindByCVE_COLOR_INT(Productos.CVE_COLOR_INT).CVE_USUARIO_ALTA_VAR = Productos.CVE_USUARIO_ALTA_VAR
        'TBLPRODUCTOS.FindByCVE_COLOR_INT(Productos.CVE_COLOR_INT).CODIGO_COLOR_VAR = Productos.CODIGO_COLOR_VAR
        'TBLPRODUCTOS.FindByCVE_COLOR_INT(Productos.CVE_COLOR_INT).ACTIVO_BIT = Productos.ACTIVO_BIT
        '    Return True
        'Else
        Return False
        'End If
    End Function

End Class
