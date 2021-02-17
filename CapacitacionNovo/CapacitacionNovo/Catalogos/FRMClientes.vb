Public Class FRMClientes

#Region "Variavles"

    Dim v_estadobotones As String = "Inicial"
    Dim v_error As String = ""

#End Region

#Region "PROCEDIMIENTOS O MÉTODOS"

    Sub CargarCliente(ByVal cve_cliente)

        ClientesBL.TBLCLIENTES.Clear()
        ClientesBL.Cargar(cve_cliente)

        For Each row As Negocios.ClientesBL.TBLCLIENTESRow In ClientesBL.TBLCLIENTES.Rows

            tbxClave.Text = row.CVE_CLIENTE_INT
            tbxNombre.Text = row.NOMBRE_VAR
            ChbActivo.Checked = row.ACTIVO_BIT

        Next

        BtoModificar.Enabled = True
        BtoNuevo.Enabled = False
        BtoCancelar.Enabled = True

    End Sub

    Sub Estadobotones(ByVal estado)

        If estado = "Inicial" Then
            BtoNuevo.Enabled = True
            BtoModificar.Enabled = False
            BtoGuardar.Enabled = False
            BtoCancelar.Enabled = False
            BtoSalir.Enabled = True
        End If

        If estado = BtoNuevo.Name Or estado = BtoModificar.Name Then
            BtoNuevo.Enabled = False
            BtoModificar.Enabled = False
            BtoGuardar.Enabled = True
            BtoCancelar.Enabled = True
            BtoSalir.Enabled = False
        End If


    End Sub

    Sub limpiar()
        tbxClave.Clear()
        tbxNombre.Clear()
        ChbActivo.Checked = False

    End Sub

    Sub Habilitar()
        tbxNombre.Enabled = True
        ChbActivo.Enabled = True
    End Sub

    Sub DesHabilitar()
        tbxClave.Enabled = False
        tbxNombre.Enabled = False
        ChbActivo.Enabled = False
    End Sub

    Sub Guadar()

        If CamposVaciosoYaExiste() = True Then
            MsgBox(v_error, MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Exit Sub
        End If



        Dim fila As Negocios.ClientesBL.TBLCLIENTESRow
        fila = ClientesBL.TBLCLIENTES.NewTBLCLIENTESRow

        With fila

            .NOMBRE_VAR = tbxNombre.Text
            .ACTIVO_BIT = ChbActivo.Checked



            If v_estadobotones = BtoNuevo.Name Then


                .CVE_USUARIO_ALTA_VAR = "Uriel"

                If ClientesBL.agregar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    Cancelar_Click(Nothing, Nothing)


                End If

            End If

            If v_estadobotones = BtoModificar.Name Then

                .CVE_CLIENTE_INT = tbxClave.Text
                .NOMBRE_VAR = tbxNombre.Text
                .CVE_USUARIO_MOD_VAR = "Uriel"

                If ClientesBL.Modificar(fila) Then
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

        If tbxNombre.Text.Trim.Length = 0 Then
            v_error = "Nombre"

        Else
            Dim YaExiste As Int32 = 0
            If v_estadobotones = BtoNuevo.Name Then
                YaExiste = (From e As Negocios.ClientesBL.TBLCLIENTESRow In Me.ClientesBL.TBLCLIENTES.Rows
                            Where e.NOMBRE_VAR = tbxNombre.Text
                            Select e).Count
            End If

            If v_estadobotones = BtoModificar.Name Then
                YaExiste = (From e As Negocios.ClientesBL.TBLCLIENTESRow In Me.ClientesBL.TBLCLIENTES.Rows
                            Where e.NOMBRE_VAR = tbxClave.Text And e.CVE_USUARIO_ALTA_VAR <> tbxClave.Text
                            Select e
                           ).Count
            End If

            If YaExiste > 0 Then
                v_error = "Ya existe el Nombre : " & tbxNombre.Text & vbNewLine & "Verifique"
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



    Private Sub FRMClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientesBL.Cargar()
        Estadobotones(v_estadobotones)
        DesHabilitar()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles BtoCancelar.Click
        v_estadobotones = "Inicial"
        Estadobotones(v_estadobotones)
        limpiar()
        DesHabilitar()
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles BtoSalir.Click
        Me.Close()

    End Sub


    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles BtoModificar.Click
        v_estadobotones = BtoModificar.Name
        Estadobotones(v_estadobotones)
        Habilitar()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles BtoGuardar.Click
        Guadar()
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles BtoNuevo.Click
        v_estadobotones = BtoNuevo.Name
        Estadobotones(v_estadobotones)
        limpiar()
        Habilitar()
        tbxClave.Focus()
        ChbActivo.Checked = True
    End Sub



    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim buscar As New FRMBuscarClientes
        buscar.ShowDialog()

        If buscar.p_cve_cliente > 0 Then
            CargarCliente(buscar.p_cve_cliente)
        End If


    End Sub
End Class