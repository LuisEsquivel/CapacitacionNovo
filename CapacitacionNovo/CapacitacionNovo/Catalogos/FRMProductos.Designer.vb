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
        Me.CKBActivo = New System.Windows.Forms.CheckBox()
        Me.BttoBuscar = New System.Windows.Forms.Button()
        Me.BttoNuevo = New System.Windows.Forms.Button()
        Me.BttoModificar = New System.Windows.Forms.Button()
        Me.BttoGuardar = New System.Windows.Forms.Button()
        Me.BttoCancelar = New System.Windows.Forms.Button()
        Me.BttoSalir = New System.Windows.Forms.Button()
        Me.DTPProductos = New System.Windows.Forms.DateTimePicker()
        Me.ProductosBL = New Negocios.ProductosBL()
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
        'CKBActivo
        '
        Me.CKBActivo.AutoSize = True
        Me.CKBActivo.Location = New System.Drawing.Point(173, 100)
        Me.CKBActivo.Name = "CKBActivo"
        Me.CKBActivo.Size = New System.Drawing.Size(56, 17)
        Me.CKBActivo.TabIndex = 4
        Me.CKBActivo.Text = "Activo"
        Me.CKBActivo.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.DTPProductos)
        Me.Controls.Add(Me.BttoSalir)
        Me.Controls.Add(Me.BttoCancelar)
        Me.Controls.Add(Me.BttoGuardar)
        Me.Controls.Add(Me.BttoModificar)
        Me.Controls.Add(Me.BttoNuevo)
        Me.Controls.Add(Me.BttoBuscar)
        Me.Controls.Add(Me.CKBActivo)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.Clave)
        Me.Controls.Add(Me.Nombre)
        Me.Name = "FRMProductos"
        Me.Text = "FRMProductos"
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nombre As Label
    Friend WithEvents Clave As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents CKBActivo As CheckBox
    Friend WithEvents BttoBuscar As Button
    Friend WithEvents BttoNuevo As Button
    Friend WithEvents BttoModificar As Button
    Friend WithEvents BttoGuardar As Button
    Friend WithEvents BttoCancelar As Button
    Friend WithEvents BttoSalir As Button
    Friend WithEvents DTPProductos As DateTimePicker
    Friend WithEvents ProductosBL As Negocios.ProductosBL

    Private Sub BttoBuscar_Click(sender As Object, e As EventArgs) Handles BttoBuscar.Click

    End Sub

    Private Sub BttoGuardar_Click(sender As Object, e As EventArgs) Handles BttoGuardar.Click

    End Sub

    Private Sub FRMProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
