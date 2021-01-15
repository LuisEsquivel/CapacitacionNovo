

Public Class FRMRoles

#Region "Variables"
    Dim v_estadobotones As String = "Inicial"
    Dim v_error As String = ""

#End Region

#Region "PROCEDIMIENTOS O MÉTODOS"
    Sub Estadobotones(ByVal estado)

        If estado = "Inicial" Then
            nuevo.Enabled = True
            modificar.Enabled = False
            guardar.Enabled = False
            Cancelar.Enabled = False
            salir.Enabled = True
        End If

        If estado = nuevo.Name Or estado = modificar.Name Then
            nuevo.Enabled = False
            modificar.Enabled = False
            guardar.Enabled = True
            Cancelar.Enabled = True
            salir.Enabled = False
        End If


    End Sub



    Sub limpiar()
        tbxClave.Clear()
        tbxDescrip.Clear()
        ckbRoles.Checked = False

    End Sub


    Sub Habilitar()
        tbxDescrip.Enabled = True
        ckbRoles.Enabled = True
    End Sub


    Sub DesHabilitar()
        tbxClave.Enabled = False
        tbxDescrip.Enabled = False
        ckbRoles.Enabled = False
    End Sub


    Sub Guadar()

        If CamposVaciosoYaExiste() = True Then
            MsgBox(v_error, MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Exit Sub
        End If

        Dim fila As Negocios.RolesBL.TBLROLESRow
        fila = RolesBL.TBLROLES.NewTBLROLESRow

        With fila
            '.CVE_ROL_INT = tbxClave.Text
            .DESC_ROL_VAR = tbxDescrip.Text
            .ACTIVO_BIT = ckbRoles.Checked
            '.DESC_ROL_VAR = 1


            If v_estadobotones = nuevo.Name Then

                .FECHA_ALTA_DATE = DateTime.Now
                .CVE_USUARIO_ALTA_VAR = "Uriel"

                If RolesBL.agregar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    Cancelar_Click(Nothing, Nothing)

                End If

            End If

            If v_estadobotones = modificar.Name Then

                .CVE_ROL_INT = tbxClave.Text
                .FECHA_MOD_DATE = DateTime.Now
                .CVE_USUARIO_MOD_VAR = "Uriel"

                If RolesBL.Modificar(fila) Then
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

        If tbxDescrip.Text.Trim.Length = 0 Then
            v_error = "Descripción"

        Else
            Dim YaExiste As Int32 = 0
            If v_estadobotones = nuevo.Name Then
                YaExiste = (From e As Negocios.RolesBL.TBLROLESRow In Me.RolesBL.TBLROLES.Rows
                            Where e.DESC_ROL_VAR = tbxDescrip.Text
                            Select e).Count
            End If

            If v_estadobotones = modificar.Name Then
                YaExiste = (From e As Negocios.RolesBL.TBLROLESRow In Me.RolesBL.TBLROLES.Rows
                            Where e.DESC_ROL_VAR = tbxDescrip.Text And e.CVE_ROL_INT <> tbxClave.Text
                            Select e
                           ).Count
            End If

            If YaExiste > 0 Then
                v_error = "Ya existe la descripción : " & tbxDescrip.Text & vbNewLine & "Verifique"
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
    Private Sub FRMRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesBL.Cargar()
        Estadobotones(v_estadobotones)
        DesHabilitar()


    End Sub

    Private Sub tbxDescrip_TextChanged(sender As Object, e As EventArgs) Handles tbxDescrip.TextChanged

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        v_estadobotones = "Inicial"
        Estadobotones(v_estadobotones)
        limpiar()
        DesHabilitar()
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()

    End Sub


    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        v_estadobotones = modificar.Name
        Estadobotones(v_estadobotones)
        Habilitar()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Guadar()
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        v_estadobotones = nuevo.Name
        Estadobotones(v_estadobotones)
        limpiar()
        Habilitar()
        clave.Focus()
        ckbRoles.Checked = True
    End Sub


    Private Sub DGVRoles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRoles.CellClick

        If DGVRoles.SelectedRows.Count > 0 And v_estadobotones <> nuevo.Name Then

            With DGVRoles.SelectedRows(0)
                tbxClave.Text = .Cells("CVE_ROL_INT").Value
                tbxDescrip.Text = .Cells("DESC_ROL_VAR").Value
                ckbRoles.Checked = .Cells("ACTIVO_BIT").Value
            End With

            If v_estadobotones <> modificar.Name Then
                modificar.Enabled = True
            End If

        End If
    End Sub
End Class