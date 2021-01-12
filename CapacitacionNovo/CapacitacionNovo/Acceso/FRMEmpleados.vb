Public Class FRMEmpleados
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Nombre.Click

    End Sub

    Private Sub FRMEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpleadosBL.Cargar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class