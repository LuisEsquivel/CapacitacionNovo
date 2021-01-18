Public Class FRMMenu


#Region "Procedimientos y Funciones"


    Private Function FormularioActivo(ByVal formulario As Form) As Boolean
        If formulario Is Nothing Then
            Return False
        Else
            If formulario.IsDisposed Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Function FormularioActivo2(ByVal formulario As Form) As Boolean
        If formulario Is Nothing Then
            Return False
        Else
            If formulario.IsDisposed Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub ActivarFormulario(ByVal formulario As Form, Optional ByVal ValidarTamanioMaximo As Boolean = True)
        Generales.ConfiguracionBotones(formulario, Generales.ColorBtn)
        formulario.MdiParent = Me
        formulario.MaximizeBox = False
        If ValidarTamanioMaximo Then
            formulario.MaximumSize = formulario.Size
        End If
        formulario.StartPosition = FormStartPosition.CenterScreen
        formulario.ShowInTaskbar = False
        formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        formulario.Show()
        Generales.RemoveXButton(formulario.Handle.ToInt32)
        formulario.Activate()
    End Sub

#End Region

#Region "VariabesPantallas"

    Private FRMEmpleados As FRMEmpleados
    Private FRMRoles As FRMRoles

#End Region

#Region "Permisos"
    Private Sub Permisos()
        'With Empleados_SistemaBL.TBLEMPLEADOS_SISTEMA.FindByCVE_EMPLEADOS_VAR(Generales.CVE_EMPLEADO_VAR)
        '    PermisosBL.Clear()
        '    PermisosBL.Cargar()
        'With CType(PermisosBL.TBLPERMISOS.Rows(0), NEGOCIOS.PermisosBL.TBLPERMISOSRow)
        '    If .ACCESO_CAT_PROD_FORMA_ADQUISICION_BIT Then
        '        MenuFormaDeAdquisición.Visible = True
        '    Else
        '        MenuFormaDeAdquisición.Visible = False
        '    End If
        '    If .ACCESO_CAT_PROD_ESTADO_ACTIVO_BIT Then
        '        MenuEstadoDelActivo.Visible = True
        '    Else
        '        MenuEstadoDelActivo.Visible = False
        '    End If
        '    If .ACCESO_CAT_PROD_TIPO_PRODUCTO_BIT Then
        '        MenuTipoProducto.Visible = True
        '    Else
        '        MenuTipoProducto.Visible = False
        '    End If
        '    If .ACCESO_CAT_PROD_UBICACIONES_BIT Then
        '        MenuUbicaciones.Visible = True
        '    Else
        '        MenuUbicaciones.Visible = False
        '    End If
        '    If .ACCESO_CAT_LOC_PAIS_BIT Then
        '        MenuPais.Visible = True
        '    Else
        '        MenuPais.Visible = False
        '    End If
        '    If .ACCESO_CAT_LOC_ESTADO_BIT Then
        '        MenuEstados.Visible = True
        '    Else
        '        MenuEstados.Visible = False
        '    End If
        '    If .ACCESO_CAT_LOC_MUNICIPIOS_BIT Then
        '        MenuMunicipios.Visible = True
        '    Else
        '        MenuMunicipios.Visible = False
        '    End If
        '    If .ACCESO_CAT_PROVEEDORES_BIT Then
        '        MenuProveedores.Visible = True
        '    Else
        '        MenuProveedores.Visible = False
        '    End If

        '    If .ACCESO_CAT_SUCURSALES_BIT Then
        '        MenuSucursales.Visible = True
        '    Else
        '        MenuSucursales.Visible = False
        '    End If
        '    If .ACCESO_CONT_PRODUCTO_BIT Then
        '        MenuProducto.Visible = True
        '    Else
        '        MenuProducto.Visible = False
        '    End If
        '    If .ACCESO_CONT_ACTIVOS_BIT Then
        '        MenuActivos.Visible = True
        '    Else
        '        MenuActivos.Visible = False
        '    End If

        '    If .ACCESO_CAT_CENTROCONTABLE_BIT Then
        '        MenuCentroContable.Visible = True
        '    Else
        '        MenuCentroContable.Visible = False
        '    End If
        'End With
        'End With
    End Sub
#End Region
    'Private Sub FRMMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim Login As New FRMLogin
    '    Login.ShowDialog()

    '    If Login.Ingresar Then
    '        Login.Close()
    '        Permisos()
    '    Else
    '        Me.Close()

    '    End If


    'End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub




    Private Sub EmpleadosDelSistemaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EmpleadosDelSistemaToolStripMenuItem.Click
        If Not FormularioActivo(FRMEmpleados) Then
            FRMEmpleados = New FRMEmpleados
        End If
        ActivarFormulario(FRMEmpleados)
    End Sub

    Private Sub RolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolesToolStripMenuItem.Click
        If Not FormularioActivo(FRMRoles) Then
            FRMRoles = New FRMRoles
        End If
        ActivarFormulario(FRMRoles)
    End Sub

    Private Sub ColoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoresToolStripMenuItem.Click
        If Not FormularioActivo(FRMColores) Then
            FRMColores = New FRMColores
        End If
        ActivarFormulario(FRMColores)
    End Sub


    'Private Sub CambioDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioDeUsuarioToolStripMenuItem.Click
    '    If Not Generales.Buscar_Formularios_Activos(Me) Then
    '        Dim Login As New FRMLogin
    '        Login.ShowDialog()

    '        If Login.Ingresar Then
    '            Login.Close()
    '            Permisos()
    '        Else
    '            Me.Close()

    '        End If
    '    End If
    'End Sub






End Class