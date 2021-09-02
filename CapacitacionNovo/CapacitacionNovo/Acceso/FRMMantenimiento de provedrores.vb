Public Class FRMMantenimiento_de_provedrores
#Region "VARIABLES"
    Public p_cve_provedor As String = ""
#End Region

#Region "MÉTODOS"

    Sub FilaSeleccionada()


        If DGVProvedor.SelectedRows.Count > 0 Then

            'valor de la clave del cliente de la fila seleccionada
            p_cve_provedor = DGVProvedor.CurrentRow.Cells("NOMBRE_VAR").Value
            Me.Hide()

        End If

        'ningna fila seleccionada
        If p_cve_provedor = "" Then

            Dim msg = MsgBox("Ninguna Fila Seleccionada" + vbNewLine + "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MENSAJE_MSGBOX)

            If msg = MsgBoxResult.Yes Then
                Me.Close()
            End If

        End If

    End Sub
#End Region
#Region "Variables"
    Dim v_estadobotones As String = "Inicial"
    Dim v_error As String = ""

#End Region

#Region "PROCEDIMIENTOS O MÉTODOS"

    Sub CargarRoles(ByVal p_cve_provedor)

        ProveedoresBL.TBLPROVEEDORES.Clear()
        ProveedoresBL.Cargar(p_cve_provedor)

        For Each row As Negocios.ProveedoresBL.TBLPROVEEDORESRow In ProveedoresBL.TBLPROVEEDORES.Rows

            txtClave.Text = row.CVE_PROVEEDOR_INT
            txbNombre.Text = row.NOMBRE_VAR
            CbxProvedor.Checked = row.ACTIVO_BIT

        Next

        bttoBuscar.Enabled = True
        bttoCancelar.Enabled = False
        BttoModificar.Enabled = True
    End Sub



    Sub Estadobotones(ByVal estado)

        If estado = "Inicial" Then
            BttoNuevo.Enabled = True
            BttoModificar.Enabled = False
            BttoGuardar.Enabled = False
            bttoCancelar.Enabled = False
            BttoSalir.Enabled = True
        End If

        If estado = BttoNuevo.Name Or estado = BttoModificar.Name Then
            BttoNuevo.Enabled = False
            BttoModificar.Enabled = False
            BttoGuardar.Enabled = True
            bttoCancelar.Enabled = True
            BttoSalir.Enabled = False
        End If


    End Sub



    Sub limpiar()
        txtClave.Clear()
        txbNombre.Clear()
        CbxProvedor.Checked = False

    End Sub


    Sub Habilitar()
        txbNombre.Enabled = True
        CbxProvedor.Enabled = True
    End Sub


    Sub DesHabilitar()
        txtClave.Enabled = False
        txbNombre.Enabled = False
        CbxProvedor.Enabled = False
    End Sub


    Sub Guadar()

        If CamposVaciosoYaExiste() = True Then
            MsgBox(v_error, MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Exit Sub
        End If

        Dim fila As Negocios.ProveedoresBL.TBLPROVEEDORESRow
        fila = ProveedoresBL.TBLPROVEEDORES.NewTBLPROVEEDORESRow

        With fila
            '.CVE_PROVEEDOR_INT = tbxClave.Text
            .NOMBRE_VAR = txbNombre.Text
            .ACTIVO_BIT = CbxProvedor.Checked
            '.NOMBRE_VAR = 1


            If v_estadobotones = BttoNuevo.Name Then

                .FECHA_ALTA_DATE = DateTime.Now
                .CVE_EMPLEADO_ALTA_VAR = "Uriel"

                If ProveedoresBL.agregar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    bttoCancelar_Click(Nothing, Nothing)

                End If

            End If

            If v_estadobotones = BttoModificar.Name Then

                .CVE_PROVEEDOR_INT = txtClave.Text
                .FECHA_MOD_DATE = DateTime.Now
                .CVE_EMPLEADO_MOD_VAR = "Uriel"

                If ProveedoresBL.Modificar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    bttoCancelar_Click(Nothing, Nothing)
                End If
            End If


        End With


    End Sub
#End Region
#Region "FUNCIONES"
    Function CamposVaciosoYaExiste()
        v_error = ""

        If txbNombre.Text.Trim.Length = 0 Then
            v_error = "Descripción"

        Else
            Dim YaExiste As Int32 = 0
            If v_estadobotones = BttoNuevo.Name Then
                YaExiste = (From e As Negocios.ProveedoresBL.TBLPROVEEDORESRow In Me.ProveedoresBL.TBLPROVEEDORES.Rows
                            Where e.NOMBRE_VAR = txbNombre.Text
                            Select e).Count
            End If

            If v_estadobotones = BttoModificar.Name Then
                YaExiste = (From e As Negocios.ProveedoresBL.TBLPROVEEDORESRow In Me.ProveedoresBL.TBLPROVEEDORES.Rows
                            Where e.NOMBRE_VAR = txbNombre.Text And e.CVE_PROVEEDOR_INT <> txtClave.Text
                            Select e
                           ).Count
            End If

            If YaExiste > 0 Then
                v_error = "Ya existe la descripción : " & txbNombre.Text & vbNewLine & "Verifique"
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
    Private Sub FRMMantenimiento_de_provedrores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProveedoresBL.Cargar()
        Estadobotones(v_estadobotones)
        DesHabilitar()
    End Sub



    Private Sub bttoBuscar_Click(sender As Object, e As EventArgs) Handles bttoBuscar.Click
        Dim PROVEDOR As New FRMMantenimiento_de_provedrores
        PROVEDOR.ShowDialog()

        If PROVEDOR.p_cve_provedor <> "" Then
            CargarRoles(PROVEDOR.p_cve_provedor)
        End If
    End Sub

    Private Sub DGVProvedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProvedor.CellClick
        If DGVProvedor.SelectedRows.Count > 0 And v_estadobotones <> BttoNuevo.Name Then

            With DGVProvedor.SelectedRows(0)
                txtClave.Text = .Cells("CVE_PROVEEDOR_INT").Value
                txbNombre.Text = .Cells("NOMBRE_VAR").Value
                CbxProvedor.Checked = .Cells("ACTIVO_BIT").Value
            End With

            If v_estadobotones <> BttoModificar.Name Then
                BttoModificar.Enabled = True
            End If

        End If
    End Sub

    Private Sub bttoCancelar_Click(sender As Object, e As EventArgs) Handles bttoCancelar.Click
        v_estadobotones = "Inicial"
        Estadobotones(v_estadobotones)
        limpiar()
        DesHabilitar()
    End Sub

    Private Sub BttoModificar_Click(sender As Object, e As EventArgs) Handles BttoModificar.Click
        v_estadobotones = BttoModificar.Name
        Estadobotones(v_estadobotones)
        Habilitar()
    End Sub

    Private Sub BttoSalir_Click(sender As Object, e As EventArgs) Handles BttoSalir.Click
        Me.Close()
    End Sub

    Private Sub BttoGuardar_Click(sender As Object, e As EventArgs) Handles BttoGuardar.Click
        Guadar()
    End Sub

    Private Sub BttoNuevo_Click(sender As Object, e As EventArgs) Handles BttoNuevo.Click
        v_estadobotones = BttoNuevo.Name
        Estadobotones(v_estadobotones)
        limpiar()
        Habilitar()
        txtClave.Focus()
        CbxProvedor.Checked = True
    End Sub
End Class