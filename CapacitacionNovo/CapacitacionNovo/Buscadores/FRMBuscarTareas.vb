Public Class FRMBuscarTareas


#Region "VARIABLES"
    Public p_row As Negocios.TareasBL.TBLTAREASRow
#End Region


#Region "MÉTODOS"

    Sub Buscar()

        Me.TareasBL.Clear()
        Me.TareasBL.Cargar(DtpFechaInicial.Value, DtpFechaFinal.Value)

    End Sub


    Sub FilaSeleccionada()

        If DgvTareas.SelectedRows.Count > 0 Then

            With CType(DgvTareas.Rows(0).DataBoundItem.row, Negocios.TareasBL.TBLTAREASRow)

                p_row = Me.TareasBL.TBLTAREAS.FindByCVE_TAREA_BIGINT(.CVE_TAREA_BIGINT)
                Me.Hide()

            End With


        Else

            Dim msg = MsgBox("Ninguna Fila Seleccionada" + vbNewLine + "¿Desea Salir?", MsgBoxStyle.YesNo, "Capacitación Novo")
            If msg = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If


    End Sub

#End Region


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Buscar()

    End Sub

    Private Sub FRMBuscarTareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DtpFechaInicial.Value = Now.AddDays(-7)
        Buscar()

    End Sub

    Private Sub DgvTareas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTareas.CellDoubleClick
        FilaSeleccionada()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        FilaSeleccionada()
    End Sub

    Private Sub DgvTareas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTareas.CellClick

        If DgvTareas.Columns(e.ColumnIndex).Name = "BtnEliminar" Then
            Dim msj = MsgBox("¿Está Seguro De Eliminar La Tarea Seleccionada?", MsgBoxStyle.YesNo, "Capacitación Novo")
            If msj = MsgBoxResult.Yes Then
                If TareasBL.Eliminar(DgvTareas.CurrentRow.Cells("CVE_TAREA_BIGINT").Value) Then
                    MsgBox("Tarea Eliminada", MsgBoxStyle.Information, "Capacitación Novo")
                    Buscar()
                Else
                    MsgBox("Algo salió mal al eliminar la tarea", MsgBoxStyle.Information, "Capacitación Novo")
                End If
            End If

        End If

    End Sub
End Class