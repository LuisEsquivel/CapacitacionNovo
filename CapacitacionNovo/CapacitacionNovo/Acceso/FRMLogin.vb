Public Class FRMLogin

#Region "VARIABLES"
    Dim Cancel As Boolean = True
#End Region


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Dim msj = MsgBox("¿Está seguro de salir?", MsgBoxStyle.YesNo, "Capacitación Novo")
        If msj = MsgBoxResult.Yes Then
            Cancel = False
            Application.Exit()
        End If
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        If TxtUsuario.Text = "" Or TxtUsuario.Text.Trim.Length = 0 Then
            MsgBox("Ingrese su usuario", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Exit Sub
        End If

        If TxtContraseña.Text = "" Or TxtContraseña.Text.Trim.Length = 0 Then
            MsgBox("Ingrese su contraseña", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Exit Sub
        End If

        EmpleadosBL.Cargar()

        If (From emp As Negocios.EmpleadosBL.TBLEMPLEADOSRow In Me.EmpleadosBL.TBLEMPLEADOS.Rows
            Where emp.CVE_EMPLEADOS_VAR = TxtUsuario.Text And emp.PASSWORD_VAR = TxtContraseña.Text
            Select emp).Count = 1 Then

            Generales.CVE_EMPLEADO_VAR = (From emp As Negocios.EmpleadosBL.TBLEMPLEADOSRow In Me.EmpleadosBL.TBLEMPLEADOS.Rows
                                          Where emp.CVE_EMPLEADOS_VAR = TxtUsuario.Text And emp.PASSWORD_VAR = TxtContraseña.Text
                                          Select emp.CVE_EMPLEADOS_VAR).FirstOrDefault

            Dim nombre = (From emp As Negocios.EmpleadosBL.TBLEMPLEADOSRow In Me.EmpleadosBL.TBLEMPLEADOS.Rows
                          Where emp.CVE_EMPLEADOS_VAR = TxtUsuario.Text And emp.PASSWORD_VAR = TxtContraseña.Text
                          Select emp.NOMBRE_VAR).FirstOrDefault

            MsgBox("Bienvenido " + nombre, MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Cancel = False
            Me.Close()

        Else

            MsgBox("Usuario o Contraseña Incorrectos", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)

        End If


    End Sub



    Private Sub TxtUsuario_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtUsuario.KeyUp
        If e.KeyCode = Keys.Enter Then
            BtnIniciar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TxtContraseña_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtContraseña.KeyUp
        If e.KeyCode = Keys.Enter Then
            BtnIniciar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub FRMLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Cancel = False Then
            e.Cancel = Cancel
        Else
            e.Cancel = True
        End If

    End Sub

End Class