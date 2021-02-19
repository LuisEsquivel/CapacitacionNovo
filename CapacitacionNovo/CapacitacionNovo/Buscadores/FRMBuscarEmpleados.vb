Public Class FRMBuscarEmpleados

#Region "VARIABLES"
    Public p_cve_Empleados As Int32 = 0
#End Region


#Region "MÉTODOS"

    Sub FilaSeleccionada()


        If DGVEmpleados.SelectedRows.Count > 0 Then

            'valor de la clave del cliente de la fila seleccionada
            NOMBRE_VAR = DGVEmpleados.CurrentRow.Cells("NOMBRE_VAR").Value
            Me.Hide()

        End If

        'ningna fila seleccionada
        If p_cve_Empleados = "" Then

            Dim msg = MsgBox("Ninguna Fila Seleccionada" + vbNewLine + "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MENSAJE_MSGBOX)

            If msg = MsgBoxResult.Yes Then
                Me.Close()
            End If

        End If

    End Sub
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

        Dim buscar As New FRMBuscarEmpleados
        buscar.ShowDialog()

        If buscar.p_cve_Empleados > 0 Then
            CargarEmpleado(buscar.p_cve_Empleados)

        End If

    End Sub

    Sub Buscador()

        EmpleadosBL.TBLEMPLEADOS.Clear()
        EmpleadosBL.Cargar()

    End Sub

    Private Sub FRMBuscarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Buscador()

    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        FilaSeleccionada()
    End Sub

    Private Sub DGVEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEmpleados.CellContentClick
        FilaSeleccionada()

    End Sub


#End Region


End Class