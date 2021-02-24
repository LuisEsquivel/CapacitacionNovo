Public Class FRMBuscarRoles

#Region "VARIABLES"
    Public p_cve_Roles As String = ""
#End Region


#Region "MÉTODOS"

    Sub FilaSeleccionada()


        If DGVRoles.SelectedRows.Count > 0 Then

            'valor de la clave del cliente de la fila seleccionada
            p_cve_Roles = DGVRoles.CurrentRow.Cells("DESC_ROL_VAR").Value
            Me.Hide()

        End If

        'ningna fila seleccionada
        If p_cve_Roles = "" Then

            Dim msg = MsgBox("Ninguna Fila Seleccionada" + vbNewLine + "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MENSAJE_MSGBOX)

            If msg = MsgBoxResult.Yes Then
                Me.Close()
            End If

        End If

    End Sub
    Private Sub FRMBuscarRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BuscarRoles()

    End Sub

    Private Sub BtoBuscar_Click(sender As Object, e As EventArgs) Handles BtoBuscar.Click

        BuscarRoles()

    End Sub

    Sub BuscarRoles()

        RolesBL.TBLRoles.Clear()
        RolesBL.Cargar()

    End Sub

    Private Sub BtoRegresar_Click(sender As Object, e As EventArgs) Handles BtoRegresar.Click
        FilaSeleccionada()
    End Sub

    Private Sub DGVRoles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRoles.CellContentClick
        FilaSeleccionada()
    End Sub

#End Region
End Class