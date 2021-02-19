Public Class FRMBuscarClientes

#Region "VARIABLES"
    Public p_cve_cliente As Int32 = 0
#End Region


#Region "MÉTODOS"

    Sub FilaSeleccionada()


        If DgvClientes.SelectedRows.Count > 0 Then

            'valor de la clave del cliente de la fila seleccionada
            p_cve_cliente = DgvClientes.CurrentRow.Cells("CVE_CLIENTE_INT").Value
            Me.Hide()

        End If

        'ningna fila seleccionada
        If p_cve_cliente = 0 Then

            Dim msg = MsgBox("Ninguna Fila Seleccionada" + vbNewLine + "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MENSAJE_MSGBOX)

            If msg = MsgBoxResult.Yes Then
                Me.Close()
            End If

        End If

    End Sub

    Sub Buscar()

        ClientesBL.TBLCLIENTES.Clear()
        ClientesBL.Cargar()

    End Sub

    Private Sub FRMBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buscar()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        FilaSeleccionada()
    End Sub

    Private Sub DgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellDoubleClick

        FilaSeleccionada()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Buscar()
    End Sub



#End Region




End Class