Public Class FRMProductos

#Region "Variante"
    Dim v_estadobotones As String = "Inicial"
    Dim v_error As String = ""

#End Region

#Region "PROCEDIMIENTOS O MÉTODOS"
    Sub Estadobotones(ByVal estado)

        If estado = "Inicial" Then
            BttoNuevo.Enabled = True
            BttoModificar.Enabled = False
            BttoGuardar.Enabled = False
            BttoCancelar.Enabled = False
            BttoSalir.Enabled = True
        End If

        If estado = BttoNuevo.Name Or estado = BttoModificar.Name Then
            BttoNuevo.Enabled = False
            BttoModificar.Enabled = False
            BttoGuardar.Enabled = True
            BttoCancelar.Enabled = True
            BttoSalir.Enabled = False
        End If


    End Sub



    Sub limpiar()
        TxtClave.Clear()
        TxtNombre.Clear()
        CKBActivo.Checked = False

    End Sub


    Sub Habilitar()
        TxtNombre.Enabled = True
        CKBActivo.Enabled = True
    End Sub


    Sub DesHabilitar()
        TxtClave.Enabled = False
        TxtNombre.Enabled = False
        CKBActivo.Enabled = False
    End Sub


    Sub Guadar()

        If CamposVaciosoYaExiste() = True Then
            MsgBox(v_error, MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Exit Sub
        End If

        Dim fila As Negocios.RolesBL.TBLROLESRow
        fila = ProductosBL.TBLROLES.NewTBLROLESRow

        With fila
            '.CVE_ROL_INT = tbxClave.Text
            .DESC_ROL_VAR = TxtNombre.Text
            .ACTIVO_BIT = CKBActivo.Checked
            '.DESC_ROL_VAR = 1


            If v_estadobotones = BttoNuevo.Name Then

                .FECHA_ALTA_DATE = DateTime.Now
                .CVE_USUARIO_ALTA_VAR = "Uriel"

                If ProductosBL.agregar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    Cancelar_Click(Nothing, Nothing)

                End If

            End If

            If v_estadobotones = BttoModificar.Name Then

                .CVE_ROL_INT = TxtClave.Text
                .FECHA_MOD_DATE = DateTime.Now
                .CVE_USUARIO_MOD_VAR = "Uriel"

                If ProductosBL.Modificar(fila) Then
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

        If TxtNombre.Text.Trim.Length = 0 Then
            v_error = "Descripción"

        Else
            Dim YaExiste As Int32 = 0
            If v_estadobotones = BttoNuevo.Name Then
                YaExiste = (From e As Negocios.RolesBL.TBLROLESRow In Me.ProductosBL.TBLROLES.Rows
                            Where e.DESC_ROL_VAR = TxtNombre.Text
                            Select e).Count
            End If

            If v_estadobotones = BttoModificar.Name Then
                YaExiste = (From e As Negocios.RolesBL.TBLROLESRow In Me.ProductosBL.TBLROLES.Rows
                            Where e.DESC_ROL_VAR = TxtNombre.Text And e.CVE_ROL_INT <> TxtClave.Text
                            Select e
                           ).Count
            End If

            If YaExiste > 0 Then
                v_error = "Ya existe la descripción : " & TxtNombre.Text & vbNewLine & "Verifique"
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
    Private Sub FRMProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class