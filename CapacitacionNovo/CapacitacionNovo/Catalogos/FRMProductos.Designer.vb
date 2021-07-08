<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Clave = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.ACTProductos = New System.Windows.Forms.CheckBox()
        Me.BttoBuscar = New System.Windows.Forms.Button()
        Me.BttoNuevo = New System.Windows.Forms.Button()
        Me.BttoModificar = New System.Windows.Forms.Button()
        Me.BttoGuardar = New System.Windows.Forms.Button()
        Me.BttoCancelar = New System.Windows.Forms.Button()
        Me.BttoSalir = New System.Windows.Forms.Button()
        Me.DTPProductos = New System.Windows.Forms.DateTimePicker()
        Me.DGVProducto = New System.Windows.Forms.DataGridView()
        Me.ProductosBL = New Negocios.ProductosBL()
        CType(Me.DGVProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(228, 165)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombre"
        '
        'Clave
        '
        Me.Clave.AutoSize = True
        Me.Clave.Location = New System.Drawing.Point(448, 165)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(34, 13)
        Me.Clave.TabIndex = 1
        Me.Clave.Text = "Clave"
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(488, 162)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(99, 20)
        Me.TxtClave.TabIndex = 2
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(278, 162)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(99, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'ACTProductos
        '
        Me.ACTProductos.AutoSize = True
        Me.ACTProductos.Location = New System.Drawing.Point(173, 100)
        Me.ACTProductos.Name = "ACTProductos"
        Me.ACTProductos.Size = New System.Drawing.Size(56, 17)
        Me.ACTProductos.TabIndex = 4
        Me.ACTProductos.Text = "Activo"
        Me.ACTProductos.UseVisualStyleBackColor = True
        '
        'BttoBuscar
        '
        Me.BttoBuscar.Location = New System.Drawing.Point(173, 12)
        Me.BttoBuscar.Name = "BttoBuscar"
        Me.BttoBuscar.Size = New System.Drawing.Size(99, 82)
        Me.BttoBuscar.TabIndex = 5
        Me.BttoBuscar.Text = "Buascar"
        Me.BttoBuscar.UseVisualStyleBackColor = True
        '
        'BttoNuevo
        '
        Me.BttoNuevo.Location = New System.Drawing.Point(278, 12)
        Me.BttoNuevo.Name = "BttoNuevo"
        Me.BttoNuevo.Size = New System.Drawing.Size(99, 82)
        Me.BttoNuevo.TabIndex = 6
        Me.BttoNuevo.Text = "Nuevo"
        Me.BttoNuevo.UseVisualStyleBackColor = True
        '
        'BttoModificar
        '
        Me.BttoModificar.Location = New System.Drawing.Point(383, 12)
        Me.BttoModificar.Name = "BttoModificar"
        Me.BttoModificar.Size = New System.Drawing.Size(99, 82)
        Me.BttoModificar.TabIndex = 7
        Me.BttoModificar.Text = "Modificar"
        Me.BttoModificar.UseVisualStyleBackColor = True
        '
        'BttoGuardar
        '
        Me.BttoGuardar.Location = New System.Drawing.Point(488, 12)
        Me.BttoGuardar.Name = "BttoGuardar"
        Me.BttoGuardar.Size = New System.Drawing.Size(99, 82)
        Me.BttoGuardar.TabIndex = 8
        Me.BttoGuardar.Text = "Guardar"
        Me.BttoGuardar.UseVisualStyleBackColor = True
        '
        'BttoCancelar
        '
        Me.BttoCancelar.Location = New System.Drawing.Point(593, 12)
        Me.BttoCancelar.Name = "BttoCancelar"
        Me.BttoCancelar.Size = New System.Drawing.Size(99, 82)
        Me.BttoCancelar.TabIndex = 9
        Me.BttoCancelar.Text = "Cancelar"
        Me.BttoCancelar.UseVisualStyleBackColor = True
        '
        'BttoSalir
        '
        Me.BttoSalir.Location = New System.Drawing.Point(698, 12)
        Me.BttoSalir.Name = "BttoSalir"
        Me.BttoSalir.Size = New System.Drawing.Size(99, 82)
        Me.BttoSalir.TabIndex = 10
        Me.BttoSalir.Text = "Salir"
        Me.BttoSalir.UseVisualStyleBackColor = True
        '
        'DTPProductos
        '
        Me.DTPProductos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPProductos.Location = New System.Drawing.Point(698, 118)
        Me.DTPProductos.Name = "DTPProductos"
        Me.DTPProductos.Size = New System.Drawing.Size(95, 20)
        Me.DTPProductos.TabIndex = 11
        '
        'DGVProducto
        '
        Me.DGVProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProducto.Location = New System.Drawing.Point(12, 188)
        Me.DGVProducto.Name = "DGVProducto"
        Me.DGVProducto.Size = New System.Drawing.Size(776, 249)
        Me.DGVProducto.TabIndex = 12
        '
        'ProductosBL
        '
        Me.ProductosBL.DataSetName = "DSProductos"
        Me.ProductosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.DGVProducto)
        Me.Controls.Add(Me.DTPProductos)
        Me.Controls.Add(Me.BttoSalir)
        Me.Controls.Add(Me.BttoCancelar)
        Me.Controls.Add(Me.BttoGuardar)
        Me.Controls.Add(Me.BttoModificar)
        Me.Controls.Add(Me.BttoNuevo)
        Me.Controls.Add(Me.BttoBuscar)
        Me.Controls.Add(Me.ACTProductos)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.Clave)
        Me.Controls.Add(Me.Nombre)
        Me.Name = "FRMProductos"
        Me.Text = "FRMProductos"
        CType(Me.DGVProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nombre As Label
    Friend WithEvents Clave As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents ACTProductos As CheckBox
    Friend WithEvents BttoBuscar As Button
    Friend WithEvents BttoNuevo As Button
    Friend WithEvents BttoModificar As Button
    Friend WithEvents BttoGuardar As Button
    Friend WithEvents BttoCancelar As Button
    Friend WithEvents BttoSalir As Button
    Friend WithEvents DTPProductos As DateTimePicker

#Region "Variavles"

    Dim v_estadobotones As String = "Inicial"
    Dim v_error As String = ""

#End Region

#Region "PROCEDIMIENTOS O MÉTODOS"

    Sub CargarProductos(ByVal p_cve_Productos)

        ProductosBL.TBLPRODUCTOS.Clear()
        ProductosBL.Cargar(p_cve_Productos)

        For Each row As Negocios.ProductosBL.TBLPRODUCTOSRow In ProductosBL.TBLPRODUCTOS.Rows

            TxtClave.Text = row.CVE_PRODUCTOS_INT
            TxtNombre.Text = row.NOMBRE_VAR
            ACTProductos.Checked = row.ACTIVO_BIT

        Next

        BttoModificar.Enabled = True
        BttoNuevo.Enabled = False
        BttoCancelar.Enabled = True
    End Sub

    Sub Estadobotones(ByVal estado)

        If estado = "Inicial" Then
            BttoNuevo.Enabled = True
            BttoModificar.Enabled = True
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
        ACTProductos.Checked = False

    End Sub

    Sub Habilitar()
        TxtNombre.Enabled = True
        TxtClave.Enabled = True
        ACTProductos.Enabled = True
    End Sub

    Sub DesHabilitar()
        TxtClave.Enabled = False
        TxtClave.Enabled = False
        ACTProductos.Enabled = False
    End Sub


    Sub Guadar()

        If CamposVaciosoYaExiste() = True Then
            MsgBox(v_error, MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
            Exit Sub
        End If



        Dim fila As Negocios.ProductosBL.TBLPRODUCTOSRow
        fila = ProductosBL.TBLPRODUCTOS.NewTBLPRODUCTOSRow

        With fila

            .NOMBRE_VAR = TxtNombre.Text

            .FECHA_ALTA_DATE = Now

            .ACTIVO_BIT = ACTProductos.Checked



            If v_estadobotones = BttoNuevo.Name Then


                .CVE_PRODUCTOS_ALTA_VAR = "Uriel"

                If ProductosBL.agregar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    BttoCancelar_Click(Nothing, Nothing)


                End If

            End If

            If v_estadobotones = BttoModificar.Name Then

                .CVE_PRODUCTOS_INT = TxtClave.Text
                .NOMBRE_VAR = TxtNombre.Text = .NOMBRE_VAR
                .CVE_PRODUCTOS_MOD_VAR = "Uriel"

                If ProductosBL.Modificar(fila) Then
                    MsgBox("Información Almacenada", MsgBoxStyle.Information, Generales.MENSAJE_MSGBOX)
                    BttoCancelar_Click(Nothing, Nothing)
                End If
            End If


        End With


    End Sub
#End Region

#Region "FUNCIONES"
    Function CamposVaciosoYaExiste()
        v_error = ""

        If TxtNombre.Text.Trim.Length = 0 Then
            v_error = "Nombre"

        Else
            Dim YaExiste As Int32 = 0
            If v_estadobotones = BttoNuevo.Name Then
                YaExiste = (From e As Negocios.ProductosBL.TBLPRODUCTOSRow In Me.ProductosBL.TBLPRODUCTOS.Rows
                            Where e.NOMBRE_VAR = TxtNombre.Text
                            Select e).Count
            End If

            If v_estadobotones = BttoModificar.Name Then
                YaExiste = (From e As Negocios.ProductosBL.TBLPRODUCTOSRow In Me.ProductosBL.TBLPRODUCTOS.Rows
                            Where e.NOMBRE_VAR = TxtClave.Text And e.CVE_PRODUCTOS_MOD_VAR <> TxtClave.Text
                            Select e
                           ).Count
            End If

            If YaExiste > 0 Then
                v_error = "Ya existe el Nombre : " & TxtClave.Text & vbNewLine & "Verifique"
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
        ProductosBL.Cargar()
        Estadobotones(v_estadobotones)
        DesHabilitar()
    End Sub
    Private Sub BttoBuscar_Click(sender As Object, e As EventArgs) Handles BttoBuscar.Click

        Dim buscar As New FRMBuscarProductos
        buscar.ShowDialog()

        If buscar.p_cve_Productos <> "" Then
            CargarProductos(buscar.p_cve_Productos)
        End If

    End Sub

    Private Sub BttoGuardar_Click(sender As Object, e As EventArgs) Handles BttoGuardar.Click

        Guadar()

    End Sub

    Private Sub BttoModificar_Click(sender As Object, e As EventArgs) Handles BttoModificar.Click

        v_estadobotones = BttoModificar.Name
        Estadobotones(v_estadobotones)
        Habilitar()

    End Sub

    Private Sub BttoCancelar_Click(sender As Object, e As EventArgs) Handles BttoCancelar.Click
        v_estadobotones = "Inicial"
        Estadobotones(v_estadobotones)
        limpiar()
        DesHabilitar()
    End Sub

    Private Sub BttoNuevo_Click(sender As Object, e As EventArgs) Handles BttoNuevo.Click

        v_estadobotones = BttoNuevo.Name
        Estadobotones(v_estadobotones)
        limpiar()
        Habilitar()
        TxtClave.Focus()
        ACTProductos.Checked = True

    End Sub

    Private Sub BttoSalir_Click(sender As Object, e As EventArgs) Handles BttoSalir.Click
        Me.Close()
    End Sub

    Friend WithEvents DGVProducto As DataGridView
    Friend WithEvents ProductosBL As Negocios.ProductosBL


End Class
