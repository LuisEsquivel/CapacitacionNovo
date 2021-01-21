Public Class EmpleadosBL

    Inherits Estructuras.DsEmpleados

    Dim DAL As Datos.EmpleadosDAL

    Public Sub Cargar(Optional ByVal CVE_EMPLEADOS_VAR As String = "")

        DAL = New Datos.EmpleadosDAL
        DAL.Cargar(TBLEMPLEADOS, CVE_EMPLEADOS_VAR)

    End Sub

    Public Function Agregar(ByVal empleados As TBLEMPLEADOSRow) As Boolean

        DAL = New Datos.EmpleadosDAL
        If DAL.Agregar(empleados) Then
            TBLEMPLEADOS.Rows.Add(empleados)
            Return True
        Else
            Return False
        End If

    End Function

    Public Function Modificar(ByVal empleados As TBLEMPLEADOSRow) As Boolean

        DAL = New Datos.EmpleadosDAL
        If DAL.Modificar(empleados) Then
            TBLEMPLEADOS.FindByCVE_EMPLEADOS_VAR(empleados.CVE_EMPLEADOS_VAR).NOMBRE_VAR = empleados.NOMBRE_VAR
            TBLEMPLEADOS.FindByCVE_EMPLEADOS_VAR(empleados.CVE_EMPLEADOS_VAR).ACTIVO_BIT = empleados.ACTIVO_BIT
            TBLEMPLEADOS.FindByCVE_EMPLEADOS_VAR(empleados.CVE_EMPLEADOS_VAR).FECHA_ALTA_DATE = empleados.FECHA_ALTA_DATE
            TBLEMPLEADOS.FindByCVE_EMPLEADOS_VAR(empleados.CVE_EMPLEADOS_VAR).FECHA_MOD_DATE = empleados.FECHA_MOD_DATE
            TBLEMPLEADOS.FindByCVE_EMPLEADOS_VAR(empleados.CVE_EMPLEADOS_VAR).CVE_EMPLEADO_VAR = empleados.CVE_EMPLEADO_VAR
            TBLEMPLEADOS.FindByCVE_EMPLEADOS_VAR(empleados.CVE_EMPLEADOS_VAR).CVE_EMPLEADO_MOD_VAR = empleados.CVE_EMPLEADO_MOD_VAR
            TBLEMPLEADOS.FindByCVE_EMPLEADOS_VAR(empleados.CVE_EMPLEADOS_VAR).CVE_ROL_INT = empleados.CVE_ROL_INT
            TBLEMPLEADOS.FindByCVE_EMPLEADOS_VAR(empleados.CVE_EMPLEADOS_VAR).PASSWORD_VAR = empleados.PASSWORD_VAR
            TBLEMPLEADOS.FindByCVE_EMPLEADOS_VAR(empleados.CVE_EMPLEADOS_VAR).CVE_COLOR_INT = empleados.CVE_COLOR_INT


            Return True
        Else
            Return False
        End If

    End Function



End Class
