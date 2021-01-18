

Public Class FRMColores

#Region "Variavles"

    Dim v_estadobotones As String = "Inicial"
    Dim v_error As String = ""

#End Region

#Region "PROCEDIMIENTOS O MÉTODOS"
    Sub Estadobotones(ByVal estado)

        If estado = "Inicial" Then
            BttoNuevo.Enabled = True
            BttoModificar.Enabled = False
            BttoGuardar.Enabled = False
            BttoCancel.Enabled = False
            BttoSalir.Enabled = True
        End If

        If estado = BttoNuevo.Name Or estado = BttoModificar.Name Then
            BttoNuevo.Enabled = False
            BttoModificar.Enabled = False
            BttoGuardar.Enabled = True
            BttoCancel.Enabled = True
            BttoSalir.Enabled = False
        End If


    End Sub



    Sub limpiar()
        tbxClave.Clear()
        tbxColor.Clear()
        ChbActivo.Checked = False

    End Sub


    Sub Habilitar()
        tbxColor.Enabled = True
        ChbActivo.Enabled = True
    End Sub


    Sub DesHabilitar()
        tbxClave.Enabled = False
        tbxColor.Enabled = False
        ChbActivo.Enabled = False
    End Sub


    Sub Guadar()

        If CamposVaciosoYaExiste() = True Then
            MsgBox(v_error, MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Exit Sub
        End If

        Dim fila As Negocios.ColoresBL.TBLCOLORESRow
        fila = ColoresBL.TBLCOLORES.NewTBLCOLORESRow

        With fila

            .NOMBRE_VAR = tbxColor.Text
            .ACTIVO_BIT = ChbActivo.Checked



            If v_estadobotones = BttoNuevo.Name Then

                .FECHA_ALTA_DATE = DateTime.Now
                .CVE_USUARIO_ALTA_VAR = "Uriel"

                If ColoresBL.agregar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    Cancelar_Click(Nothing, Nothing)

                End If

            End If

            If v_estadobotones = BttoModificar.Name Then

                .CVE_COLOR_INT = tbxClave.Text
                .FECHA_MOD_DATE = DateTime.Now
                .CVE_USUARIO_MOD_VAR = "Uriel"

                If ColoresBL.Modificar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    Cancelar_Click(Nothing, Nothing)
                End If
            End If


        End With


    End Sub
#End Region
#Region "FUNCIONES"
    Function CamposVaciosoYaExiste()
        v_error = ""

        If tbxColor.Text.Trim.Length = 0 Then
            v_error = "Colore"

        Else
            Dim YaExiste As Int32 = 0
            If v_estadobotones = BttoNuevo.Name Then
                YaExiste = (From e As Negocios.ColoresBL.TBLCOLORESRow In Me.ColoresBL.TBLCOLORES.Rows
                            Where e.NOMBRE_VAR = tbxColor.Text
                            Select e).Count
            End If

            If v_estadobotones = BttoModificar.Name Then
                YaExiste = (From e As Negocios.ColoresBL.TBLCOLORESRow In Me.ColoresBL.TBLCOLORES.Rows
                            Where e.NOMBRE_VAR = tbxColor.Text And e.CVE_COLOR_INT <> tbxClave.Text
                            Select e
                           ).Count
            End If

            If YaExiste > 0 Then
                v_error = "Ya existe el Color : " & tbxColor.Text & vbNewLine & "Verifique"
                Return True
            End If

        End If

        If v_error <> "" Then
            v_error = "Campo Oboligatorio:" & vbNewLine & v_error
            Return True
        Else
            Return False
        End If

    End Function
#End Region
    Private Sub FRMColores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColoresBL.Cargar()
        Estadobotones(v_estadobotones)
        DesHabilitar()
    End Sub
    Private Sub tbxDescrip_TextChanged(sender As Object, e As EventArgs) Handles tbxClave.TextChanged

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles BttoCancel.Click
        v_estadobotones = "Inicial"
        Estadobotones(v_estadobotones)
        limpiar()
        DesHabilitar()
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles BttoSalir.Click
        Me.Close()

    End Sub


    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles BttoModificar.Click
        v_estadobotones = BttoModificar.Name
        Estadobotones(v_estadobotones)
        Habilitar()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles BttoGuardar.Click
        Guadar()
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles BttoNuevo.Click
        v_estadobotones = BttoNuevo.Name
        Estadobotones(v_estadobotones)
        limpiar()
        Habilitar()
        tbxClave.Focus()
        ChbActivo.Checked = True
    End Sub


    Private Sub DGVCOLORES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVColores.CellClick

        If DGVColores.SelectedRows.Count > 0 And v_estadobotones <> BttoNuevo.Name Then

            With DGVColores.SelectedRows(0)
                tbxClave.Text = .Cells("CVE_COLOR_INT").Value
                tbxColor.Text = .Cells("NOMBRE_VAR").Value
                ChbActivo.Checked = .Cells("ACTIVO_BIT").Value
            End With

            If v_estadobotones <> BttoModificar.Name Then
                BttoModificar.Enabled = True
            End If

        End If
    End Sub

End Class