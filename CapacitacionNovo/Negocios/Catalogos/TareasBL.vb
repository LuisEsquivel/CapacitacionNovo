Public Class TareasBL

    Inherits Estructuras.DSTareas

    Dim DAL As Datos.TareasDAL

    Public Sub Cargar(ByVal FECHA_INICIAL_DATE As DateTime,
                      ByVal FECHA_FINAL_DATE As DateTime,
                      Optional ByVal CVE_TAREA_BIGINT As Int64 = 0)

        DAL = New Datos.TareasDAL
        DAL.Cargar(TBLTAREAS, FECHA_INICIAL_DATE, FECHA_FINAL_DATE)

    End Sub

    Public Function Agregar(ByVal tareas As TBLTAREASRow) As Boolean

        DAL = New Datos.TareasDAL
        If DAL.Agregar(tareas) Then
            TBLTAREAS.Rows.Add(tareas)
            Return True
        Else
            Return False
        End If

    End Function

    Public Function Modificar(ByVal tareas As TBLTAREASRow) As Boolean

        DAL = New Datos.TareasDAL
        If DAL.Modificar(tareas) Then
            TBLTAREAS.FindByCVE_TAREA_BIGINT(tareas.CVE_TAREA_BIGINT).DESCRIPCION_VAR = tareas.DESCRIPCION_VAR
            TBLTAREAS.FindByCVE_TAREA_BIGINT(tareas.CVE_TAREA_BIGINT).DUDAS_PRESENTADAS_VAR = tareas.DUDAS_PRESENTADAS_VAR
            TBLTAREAS.FindByCVE_TAREA_BIGINT(tareas.CVE_TAREA_BIGINT).RESPUESTA_A_DUDAS_VAR = tareas.RESPUESTA_A_DUDAS_VAR
            TBLTAREAS.FindByCVE_TAREA_BIGINT(tareas.CVE_TAREA_BIGINT).FECHA_ALTA_DATE = tareas.FECHA_ALTA_DATE
            TBLTAREAS.FindByCVE_TAREA_BIGINT(tareas.CVE_TAREA_BIGINT).FECHA_MOD_DATE = tareas.FECHA_MOD_DATE
            TBLTAREAS.FindByCVE_TAREA_BIGINT(tareas.CVE_TAREA_BIGINT).CVE_EMPLEADO_ALTA_VAR = tareas.CVE_EMPLEADO_ALTA_VAR
            TBLTAREAS.FindByCVE_TAREA_BIGINT(tareas.CVE_TAREA_BIGINT).CVE_EMPLEADO_MOD_VAR = tareas.CVE_EMPLEADO_MOD_VAR
            Return True
        Else
            Return False
        End If

    End Function



    Public Function Eliminar(ByVal cve As Int64) As Boolean

        DAL = New Datos.TareasDAL
        If DAL.Eliminar(cve) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
