Public Class ColoresBL
    Inherits Estructuras.DsColores

    Dim DAL As Datos.ColoresDAL

    Public Sub Cargar(Optional ByVal CVE_COLOR_INT As Int32 = 0)

        DAL = New Datos.ColoresDAL
        DAL.cargar(TBLCOLORES, CVE_COLOR_INT)

    End Sub

    Public Function agregar(ByVal fila As TBLCOLORESRow) As Boolean

        DAL = New Datos.ColoresDAL
        If DAL.Agregar(fila) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar(ByVal Colores As TBLCOLORESRow) As Boolean

        DAL = New Datos.ColoresDAL
        If DAL.Modificar(Colores) Then

            TBLCOLORES.FindByCVE_COLOR_INT(Colores.CVE_COLOR_INT).NOMBRE_VAR = Colores.NOMBRE_VAR
            TBLCOLORES.FindByCVE_COLOR_INT(Colores.CVE_COLOR_INT).FECHA_MOD_DATE = Colores.FECHA_MOD_DATE
            TBLCOLORES.FindByCVE_COLOR_INT(Colores.CVE_COLOR_INT).FECHA_ALTA_DATE = Colores.FECHA_ALTA_DATE
            TBLCOLORES.FindByCVE_COLOR_INT(Colores.CVE_COLOR_INT).CVE_USUARIO_MOD_VAR = Colores.CVE_USUARIO_MOD_VAR
            TBLCOLORES.FindByCVE_COLOR_INT(Colores.CVE_COLOR_INT).CVE_USUARIO_ALTA_VAR = Colores.CVE_USUARIO_ALTA_VAR
            TBLCOLORES.FindByCVE_COLOR_INT(Colores.CVE_COLOR_INT).ACTIVO_BIT = Colores.ACTIVO_BIT
            Return True
        Else
            Return False
        End If
    End Function
End Class
