<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMMantenimiento_de_provedrores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGVProvedor = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttoBuscar = New System.Windows.Forms.Button()
        Me.bttoCancelar = New System.Windows.Forms.Button()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.CbxProvedor = New System.Windows.Forms.CheckBox()
        Me.BttoModificar = New System.Windows.Forms.Button()
        Me.BttoSalir = New System.Windows.Forms.Button()
        Me.BttoGuardar = New System.Windows.Forms.Button()
        Me.BttoNuevo = New System.Windows.Forms.Button()
        Me.ProveedoresBL = New Negocios.ProveedoresBL()
        Me.DsProveedores = New Estructuras.DSProveedores()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGVProvedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVProvedor
        '
        Me.DGVProvedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProvedor.Location = New System.Drawing.Point(154, 137)
        Me.DGVProvedor.Name = "DGVProvedor"
        Me.DGVProvedor.Size = New System.Drawing.Size(577, 259)
        Me.DGVProvedor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(590, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave"
        '
        'bttoBuscar
        '
        Me.bttoBuscar.Location = New System.Drawing.Point(138, 8)
        Me.bttoBuscar.Name = "bttoBuscar"
        Me.bttoBuscar.Size = New System.Drawing.Size(114, 93)
        Me.bttoBuscar.TabIndex = 3
        Me.bttoBuscar.Text = "Buscar"
        Me.bttoBuscar.UseVisualStyleBackColor = True
        '
        'bttoCancelar
        '
        Me.bttoCancelar.Location = New System.Drawing.Point(617, 9)
        Me.bttoCancelar.Name = "bttoCancelar"
        Me.bttoCancelar.Size = New System.Drawing.Size(114, 93)
        Me.bttoCancelar.TabIndex = 4
        Me.bttoCancelar.Text = "Cancelar"
        Me.bttoCancelar.UseVisualStyleBackColor = True
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(484, 111)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(100, 20)
        Me.txtClave.TabIndex = 5
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(640, 111)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(100, 20)
        Me.txbNombre.TabIndex = 6
        '
        'CbxProvedor
        '
        Me.CbxProvedor.AutoSize = True
        Me.CbxProvedor.Location = New System.Drawing.Point(138, 107)
        Me.CbxProvedor.Name = "CbxProvedor"
        Me.CbxProvedor.Size = New System.Drawing.Size(56, 17)
        Me.CbxProvedor.TabIndex = 7
        Me.CbxProvedor.Text = "Activo"
        Me.CbxProvedor.UseVisualStyleBackColor = True
        '
        'BttoModificar
        '
        Me.BttoModificar.Location = New System.Drawing.Point(258, 9)
        Me.BttoModificar.Name = "BttoModificar"
        Me.BttoModificar.Size = New System.Drawing.Size(114, 92)
        Me.BttoModificar.TabIndex = 8
        Me.BttoModificar.Text = "Modificar"
        Me.BttoModificar.UseVisualStyleBackColor = True
        '
        'BttoSalir
        '
        Me.BttoSalir.Location = New System.Drawing.Point(497, 9)
        Me.BttoSalir.Name = "BttoSalir"
        Me.BttoSalir.Size = New System.Drawing.Size(114, 92)
        Me.BttoSalir.TabIndex = 9
        Me.BttoSalir.Text = "Salir"
        Me.BttoSalir.UseVisualStyleBackColor = True
        '
        'BttoGuardar
        '
        Me.BttoGuardar.Location = New System.Drawing.Point(378, 10)
        Me.BttoGuardar.Name = "BttoGuardar"
        Me.BttoGuardar.Size = New System.Drawing.Size(113, 91)
        Me.BttoGuardar.TabIndex = 10
        Me.BttoGuardar.Text = "Guardar"
        Me.BttoGuardar.UseVisualStyleBackColor = True
        '
        'BttoNuevo
        '
        Me.BttoNuevo.Location = New System.Drawing.Point(18, 11)
        Me.BttoNuevo.Name = "BttoNuevo"
        Me.BttoNuevo.Size = New System.Drawing.Size(114, 91)
        Me.BttoNuevo.TabIndex = 11
        Me.BttoNuevo.Text = "Nuevo"
        Me.BttoNuevo.UseVisualStyleBackColor = True
        '
        'ProveedoresBL
        '
        Me.ProveedoresBL.DataSetName = "DSProveedores"
        Me.ProveedoresBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsProveedores
        '
        Me.DsProveedores.DataSetName = "DSProveedores"
        Me.DsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(342, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Label3"
        '
        'FRMMantenimiento_de_provedrores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 408)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BttoNuevo)
        Me.Controls.Add(Me.BttoGuardar)
        Me.Controls.Add(Me.BttoSalir)
        Me.Controls.Add(Me.BttoModificar)
        Me.Controls.Add(Me.CbxProvedor)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.bttoCancelar)
        Me.Controls.Add(Me.bttoBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVProvedor)
        Me.Name = "FRMMantenimiento_de_provedrores"
        Me.Text = "FRMMantenimiento_de_provedrores"
        CType(Me.DGVProvedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVProvedor As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bttoBuscar As Button
    Friend WithEvents bttoCancelar As Button
    Friend WithEvents txtClave As TextBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents ProveedoresBL As Negocios.ProveedoresBL
    Friend WithEvents DsProveedores As Estructuras.DSProveedores
    Friend WithEvents CbxProvedor As CheckBox
    Friend WithEvents BttoModificar As Button
    Friend WithEvents BttoSalir As Button
    Friend WithEvents BttoGuardar As Button
    Friend WithEvents BttoNuevo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
