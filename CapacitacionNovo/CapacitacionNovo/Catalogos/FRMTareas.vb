Public Class FRMTareas

#Region "VARIABLES"
    Dim v_error As String = ""
    Dim v_estadoBotones As String = "Inicial"
    Dim msj As Object
#End Region


#Region "MÉTODOS"


    Sub CargarTarea(ByVal row As Negocios.TareasBL.TBLTAREASRow)

        With row

            TxtClave.Text = .CVE_TAREA_BIGINT
            TxtDescripcion.Text = .DESCRIPCION_VAR
            TxtDudasPresentadas.Text = .DUDAS_PRESENTADAS_VAR
            TxtRespuestaADudas.Text = .RESPUESTA_A_DUDAS_VAR
            DtpFechaAlta.Value = .FECHA_ALTA_DATE

        End With


        If BtnModificar.Enabled = False Then
            BtnModificar.Enabled = True
        End If

        BtnCancelar.Enabled = True

    End Sub


    Sub Buscar()

        TareasBL.Clear()
        TareasBL.Cargar(Now.AddDays(-7), Now)

    End Sub


    Sub Habilitar()
        TxtDescripcion.Enabled = True
        TxtDudasPresentadas.Enabled = True
        TxtRespuestaADudas.Enabled = True
    End Sub

    Sub Deshabilitar()
        TxtDescripcion.Enabled = False
        TxtDudasPresentadas.Enabled = False
        TxtRespuestaADudas.Enabled = False
    End Sub

    Sub Limpiar()
        TxtClave.Clear()
        TxtDescripcion.Clear()
        TxtDudasPresentadas.Clear()
        TxtRespuestaADudas.Clear()
    End Sub

    Sub EstadoBotones(ByVal Estado As String)

        If Estado = "Inicial" Then
            BtnNuevo.Enabled = True
            BtnModificar.Enabled = False
            BtnCancelar.Enabled = False
            BtnSalir.Enabled = True
            BtnGuardar.Enabled = False
        End If

        If Estado = BtnNuevo.Name Or Estado = BtnModificar.Name Then
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
            BtnGuardar.Enabled = True
        End If

        If Estado = BtnModificar.Name Then
            BtnEliminar.Visible = False
        Else
            BtnEliminar.Visible = True
        End If


    End Sub

    Sub Guardar()



        If CamposVacios() Then
            MsgBox(v_error, MsgBoxStyle.Information, "Capacitación Novo")
            Exit Sub
        End If


        Dim row As Negocios.TareasBL.TBLTAREASRow
        row = TareasBL.TBLTAREAS.NewTBLTAREASRow


        With row

            .DESCRIPCION_VAR = TxtDescripcion.Text
            .DUDAS_PRESENTADAS_VAR = TxtDudasPresentadas.Text
            .RESPUESTA_A_DUDAS_VAR = TxtRespuestaADudas.Text

            If v_estadoBotones = BtnNuevo.Name Then

                .FECHA_ALTA_DATE = Now
                .CVE_EMPLEADO_ALTA_VAR = Generales.CVE_EMPLEADO_VAR

                If TareasBL.Agregar(row) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, "Capacitación Novo")
                    BtnCancelar_Click(Nothing, Nothing)

                Else
                    MsgBox("Algo Salió Mal Al Guardar La Tarea", MsgBoxStyle.Information, "Capacitación Novo")

                End If

            End If



            If v_estadoBotones = BtnModificar.Name Then

                .CVE_TAREA_BIGINT = TxtClave.Text
                .FECHA_MOD_DATE = Now
                .CVE_EMPLEADO_MOD_VAR = Generales.CVE_EMPLEADO_VAR

                If TareasBL.Modificar(row) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, "Capacitación Novo")
                    BtnCancelar_Click(Nothing, Nothing)
                Else
                    MsgBox("Algo Salió Mal Al Guardar La Tarea", MsgBoxStyle.Information, "Capacitación Novo")

                End If

            End If

        End With


    End Sub

#End Region

#Region "FUNCIONES"

    Function CamposVacios()

        v_error = ""

        If TxtDescripcion.Text.Trim.Length = 0 Or TxtDescripcion.Text = "" Then
            v_error = "Descripción"
        End If


        If v_error.Trim.Length > 0 Then

            v_error = "Los Campos: " + v_error + vbNewLine + "Son Obligatorios"
            Return True

        End If


        Return False

    End Function

#End Region





    Private Sub FRMTareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EstadoBotones(v_estadoBotones)
        Deshabilitar()
        Buscar()

    End Sub

    Private Sub DgvTareas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTareas.CellClick

        If DgvTareas.Columns(e.ColumnIndex).Name = "BtnEliminar" Then
            msj = MsgBox("¿Está Seguro De Eliminar La Tarea Seleccionada?", MsgBoxStyle.YesNo, "Capacitación Novo")
            If msj = MsgBoxResult.Yes Then
                If TareasBL.Eliminar(DgvTareas.CurrentRow.Cells("CVE_TAREA_BIGINT").Value) Then
                    MsgBox("Tarea Eliminada", MsgBoxStyle.Information, "Capacitación Novo")
                    Buscar()
                    BtnCancelar_Click(Nothing, Nothing)
                Else
                    MsgBox("Algo salió mal al eliminar la tarea", MsgBoxStyle.Information, "Capacitación Novo")
                End If

                Exit Sub

            End If
        End If


        If DgvTareas.SelectedRows.Count > 0 And v_estadoBotones <> BtnNuevo.Name Then

            With CType(DgvTareas.Rows(0).DataBoundItem.row, Negocios.TareasBL.TBLTAREASRow)
                TxtClave.Text = .CVE_TAREA_BIGINT
                TxtDescripcion.Text = .DESCRIPCION_VAR
                TxtDudasPresentadas.Text = .DUDAS_PRESENTADAS_VAR
                TxtRespuestaADudas.Text = .RESPUESTA_A_DUDAS_VAR
                DtpFechaAlta.Value = .FECHA_ALTA_DATE
            End With

            If BtnModificar.Enabled = False Then
                BtnModificar.Enabled = True
            End If

            BtnCancelar.Enabled = True

        End If

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        v_estadoBotones = BtnNuevo.Name
        EstadoBotones(v_estadoBotones)
        Habilitar()
        Limpiar()
        TxtDescripcion.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        v_estadoBotones = BtnModificar.Name
        EstadoBotones(v_estadoBotones)
        Habilitar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        v_estadoBotones = "Inicial"
        EstadoBotones(v_estadoBotones)
        Deshabilitar()
        Limpiar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim browse As New FRMBuscarTareas
        browse.ShowDialog()

        If browse.p_row IsNot Nothing Then
            CargarTarea(browse.p_row)
        Else
            Limpiar()
            Buscar()
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class