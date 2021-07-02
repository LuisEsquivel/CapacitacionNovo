Public Class FRMBuscarProductos
#Region "VARIABLES"
    Public p_cve_Productos As String = ""
#End Region


#Region "MÉTODOS"

    Sub FilaSeleccionada()


        If DGVProductos.SelectedRows.Count > 0 Then

            'valor de la clave del cliente de la fila seleccionada
            p_cve_Productos = DGVProductos.CurrentRow.Cells("Nombre_VAR").Value
            Me.Hide()

        End If

        'ningna fila seleccionada
        If p_cve_Productos = "" Then

            Dim msg = MsgBox("Ninguna Fila Seleccionada" + vbNewLine + "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MENSAJE_MSGBOX)

            If msg = MsgBoxResult.Yes Then
                Me.Close()
            End If

        End If

    End Sub
    Private Sub FRMBuscarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BuscarProductos()

    End Sub

    Private Sub BttoBuscar_Click(sender As Object, e As EventArgs) Handles BttoBuscar.Click

        BuscarProductos()

    End Sub

    Sub BuscarProductos()

        ProductosBL.TBLPRODUCTOS.Clear()
        ProductosBL.Cargar()

    End Sub

    Private Sub BttoRegresar_Click(sender As Object, e As EventArgs) Handles BttoRegresar.Click
        FilaSeleccionada()
    End Sub

    Private Sub DGVProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProductos.CellContentClick
        FilaSeleccionada()
    End Sub

#End Region
End Class