

Public Class RolesBL
    Inherits Estructuras.DsRoles

    Dim DAL As Datos.RolesDAL

    Public Sub Cargar(Optional ByVal CVE_ROL_INT As Int32 = 0)

        DAL = New Datos.RolesDAL
        DAL.Cargar(TBLROLES, CVE_ROL_INT)

    End Sub

    Public Function agregar(ByVal fila As TBLROLESRow) As Boolean

        DAL = New Datos.RolesDAL
        If DAL.Agregar(fila) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar(ByVal Roles As TBLROLESRow) As Boolean

        DAL = New Datos.RolesDAL
        If DAL.Modificar(Roles) Then
            'TBLROLES.FindByCVE_ROL_INT(Roles.CVE_ROL_INT).CVE_ROL_INT = Roles.CVE_ROL_INT
            TBLROLES.FindByCVE_ROL_INT(Roles.CVE_ROL_INT).DESC_ROL_VAR = Roles.DESC_ROL_VAR
            TBLROLES.FindByCVE_ROL_INT(Roles.CVE_ROL_INT).FECHA_MOD_DATE = Roles.FECHA_MOD_DATE
            TBLROLES.FindByCVE_ROL_INT(Roles.CVE_ROL_INT).FECHA_ALTA_DATE = Roles.FECHA_ALTA_DATE
            TBLROLES.FindByCVE_ROL_INT(Roles.CVE_ROL_INT).CVE_USUARIO_MOD_VAR = Roles.CVE_USUARIO_MOD_VAR
            TBLROLES.FindByCVE_ROL_INT(Roles.CVE_ROL_INT).CVE_USUARIO_ALTA_VAR = Roles.CVE_USUARIO_ALTA_VAR
            TBLROLES.FindByCVE_ROL_INT(Roles.CVE_ROL_INT).ACTIVO_BIT = Roles.ACTIVO_BIT
            Return True
        Else
            Return False
        End If

    End Function

End Class
