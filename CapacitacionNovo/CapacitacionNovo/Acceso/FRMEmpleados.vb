Public Class FRMEmpleados

#Region "VARIABLES"
    Dim v_estadoBotones As String = "Inicial"
    Dim v_error As String = ""
#End Region

#Region "PROCEDIMIENTOS o MÉTODOS"

    Sub LlenarCeldas()

        For Each row As DataGridViewRow In DgvEmpleados.Rows

            With row
                .Cells("NOMBRE_COLOR_VAR").Value = ColoresBL.TBLCOLORES.FindByCVE_COLOR_INT(.Cells("CVE_COLOR_INT").Value).NOMBRE_VAR
                .Cells("DESC_ROL_VAR").Value = RolesBL1.TBLROLES.FindByCVE_ROL_INT(.Cells("CVE_ROL_INT").Value).DESC_ROL_VAR
                .Cells("COLOR_REAL").Style.BackColor = Color.Green
            End With

        Next


    End Sub

    Sub LlenarCombos()

        RolesBL1.Cargar()
        ColoresBL.Cargar()

        Dim row As Negocios.RolesBL.TBLROLESRow
        row = RolesBL1.TBLROLES.NewTBLROLESRow

        With row

            .CVE_ROL_INT = 0
            .DESC_ROL_VAR = "--SELECCIONE--"
            .FECHA_ALTA_DATE = Now
            .FECHA_MOD_DATE = Now
            .CVE_USUARIO_ALTA_VAR = ""
            .CVE_USUARIO_MOD_VAR = ""
            .ACTIVO_BIT = True

        End With
        RolesBL1.TBLROLES.Rows.Add(row)
        CmbRol.SelectedValue = 0





        Dim filaColor As Negocios.ColoresBL.TBLCOLORESRow
        filaColor = ColoresBL.TBLCOLORES.NewTBLCOLORESRow

        With filaColor

            .CVE_COLOR_INT = 0
            .NOMBRE_VAR = "--SELECCIONE--"
            .FECHA_ALTA_DATE = Now
            .FECHA_MOD_DATE = Now
            .CVE_USUARIO_ALTA_VAR = ""
            .CVE_USUARIO_MOD_VAR = ""
            .ACTIVO_BIT = True

        End With
        ColoresBL.TBLCOLORES.Rows.Add(filaColor)
        CmbColores.SelectedValue = 0




    End Sub


    Sub EstadoBotones(ByVal estado)

        If estado = "Inicial" Then
            BtnNuevo.Enabled = True
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = False
            BtnCancelar.Enabled = False
            BtnSalir.Enabled = True
        End If

        If estado = BtnNuevo.Name Or estado = BtnModificar.Name Then
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
        End If

    End Sub


    Sub Limpiar()
        TxtClave.Clear()
        TxtNombre.Clear()
        TxtPassword.Clear()
        CmbRol.SelectedValue = 0
        CmbColores.SelectedValue = 0
        ChkActivo.Checked = False
    End Sub

    Sub Habilitar()
        TxtClave.Enabled = True
        TxtNombre.Enabled = True
        TxtPassword.Enabled = True
        ChkActivo.Enabled = True
        CmbColores.Enabled = True
        CmbRol.Enabled = True
    End Sub


    Sub DesHabilitar()
        TxtClave.Enabled = False
        TxtNombre.Enabled = False
        TxtPassword.Enabled = False
        ChkActivo.Enabled = False
        CmbColores.Enabled = False
        CmbRol.Enabled = False
    End Sub


    Sub Guardar()


        If CamposVacios() Then
            MsgBox(v_error, MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Exit Sub
        End If

        Dim fila As Negocios.EmpleadosBL.TBLEMPLEADOSRow
        fila = EmpleadosBL.TBLEMPLEADOS.NewTBLEMPLEADOSRow

        With fila

            .CVE_EMPLEADOS_VAR = TxtClave.Text
            .NOMBRE_VAR = TxtNombre.Text
            .PASSWORD_VAR = TxtPassword.Text
            .ACTIVO_BIT = ChkActivo.Checked
            .CVE_ROL_INT = CmbRol.SelectedValue
            .CVE_COLOR_INT = CmbColores.SelectedValue


            If v_estadoBotones = BtnNuevo.Name Then

                .FECHA_ALTA_DATE = DateTime.Now
                .CVE_EMPLEADO_VAR = "Uriel"

                If EmpleadosBL.Agregar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    BtnCancelar_Click(Nothing, Nothing)
                End If

            End If


            If v_estadoBotones = BtnModificar.Name Then

                .FECHA_MOD_DATE = DateTime.Now
                .CVE_EMPLEADO_MOD_VAR = "Uriel"

                If EmpleadosBL.Modificar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If

        End With

        LlenarCeldas()

    End Sub

#End Region

#Region "FUNCIONES"

    Function CamposVacios()
        v_error = ""

        If TxtClave.Text.Trim.Length = 0 Then
            v_error = "Clave"

        Else
            Dim YaExiste As Int32 = 0
            If v_estadoBotones = BtnNuevo.Name Then
                YaExiste = (From e As Negocios.EmpleadosBL.TBLEMPLEADOSRow In Me.EmpleadosBL.TBLEMPLEADOS.Rows
                            Where e.CVE_EMPLEADOS_VAR = TxtClave.Text
                            Select e).Count
            End If


            If YaExiste > 0 Then
                v_error = "Ya existe la clave :" & TxtClave.Text & vbNewLine & "Verifique"
                Return True
            End If

        End If

        If TxtNombre.Text.Trim.Length = 0 Then
            v_error += vbNewLine & "Nombre"
        End If

        If TxtPassword.Text.Trim.Length = 0 Then
            v_error += vbNewLine & "Password"
        End If

        If CmbRol.SelectedValue = 0 Then
            v_error = v_error + vbNewLine + "Rol"
        End If

        If CmbColores.SelectedValue = 0 Then
            v_error = v_error + vbNewLine + "color"
        End If

        If v_error <> "" Then
            v_error = "Campos Obligatorios:" & vbNewLine & v_error
            Return True
        Else
            Return False
        End If

    End Function

#End Region



    Private Sub FRMEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpleadosBL.Cargar()
        LlenarCombos()
        EstadoBotones(v_estadoBotones)
        DesHabilitar()
        LlenarCeldas()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        v_estadoBotones = BtnNuevo.Name
        EstadoBotones(v_estadoBotones)
        Limpiar()
        Habilitar()
        TxtClave.Focus()
        ChkActivo.Checked = True
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        v_estadoBotones = BtnModificar.Name
        EstadoBotones(v_estadoBotones)
        Habilitar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        v_estadoBotones = "Inicial"
        EstadoBotones(v_estadoBotones)
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub DgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleados.CellClick

        If DgvEmpleados.SelectedRows.Count > 0 And v_estadoBotones <> BtnNuevo.Name Then

            With DgvEmpleados.SelectedRows(0)
                TxtClave.Text = .Cells("CVE_EMPLEADOS_VAR").Value
                TxtNombre.Text = .Cells("NOMBRE_VAR").Value
                TxtPassword.Text = .Cells("PASSWORD_VAR").Value
                DtpFechaAlta.Value = .Cells("FECHA_ALTA_DATE").Value
                ChkActivo.Checked = .Cells("ACTIVO_BIT").Value
                CmbColores.SelectedValue = .Cells("CVE_COLOR_INT").Value
                CmbRol.SelectedValue = .Cells("CVE_ROL_INT").Value
            End With

            If v_estadoBotones <> BtnModificar.Name Then
                BtnModificar.Enabled = True
            End If

        End If


    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbColores.SelectedIndexChanged
        Dim value = CmbColores.SelectedValue
    End Sub

    Private Sub DgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleados.CellContentClick

    End Sub
End Class