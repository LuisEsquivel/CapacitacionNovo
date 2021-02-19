Public Class FRMBuscarEmpleados

#Region "VARIABLES"
    Public p_cve_Empleados As String = ""
#End Region


#Region "MÉTODOS"

    Sub FilaSeleccionada()


        If DGVEmpleados.SelectedRows.Count > 0 Then

            'valor de la clave del cliente de la fila seleccionada
            p_cve_Empleados = DGVEmpleados.CurrentRow.Cells("CVE_EMPLEADOS_VAR").Value
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

        Buscador()

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


    Private Sub DGVEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEmpleados.CellDoubleClick
        FilaSeleccionada()
    End Sub



#End Region


End Class