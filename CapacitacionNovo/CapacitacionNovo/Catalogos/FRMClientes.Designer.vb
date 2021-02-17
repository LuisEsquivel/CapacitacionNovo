<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMClientes
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
        Me.LblClave = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtoNuevo = New System.Windows.Forms.Button()
        Me.BtoModificar = New System.Windows.Forms.Button()
        Me.BtoGuardar = New System.Windows.Forms.Button()
        Me.BtoCancelar = New System.Windows.Forms.Button()
        Me.BtoSalir = New System.Windows.Forms.Button()
        Me.DtpCliente = New System.Windows.Forms.DateTimePicker()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxClave = New System.Windows.Forms.TextBox()
        Me.ChbActivo = New System.Windows.Forms.CheckBox()
        Me.ClientesBL = New Negocios.ClientesBL()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblClave
        '
        Me.LblClave.AutoSize = True
        Me.LblClave.Location = New System.Drawing.Point(477, 149)
        Me.LblClave.Name = "LblClave"
        Me.LblClave.Size = New System.Drawing.Size(34, 13)
        Me.LblClave.TabIndex = 0
        Me.LblClave.Text = "Clave"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(685, 149)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'BtoNuevo
        '
        Me.BtoNuevo.Location = New System.Drawing.Point(55, 11)
        Me.BtoNuevo.Name = "BtoNuevo"
        Me.BtoNuevo.Size = New System.Drawing.Size(119, 89)
        Me.BtoNuevo.TabIndex = 2
        Me.BtoNuevo.Text = "Nuevo"
        Me.BtoNuevo.UseVisualStyleBackColor = True
        '
        'BtoModificar
        '
        Me.BtoModificar.Location = New System.Drawing.Point(180, 12)
        Me.BtoModificar.Name = "BtoModificar"
        Me.BtoModificar.Size = New System.Drawing.Size(119, 88)
        Me.BtoModificar.TabIndex = 3
        Me.BtoModificar.Text = "Modificar"
        Me.BtoModificar.UseVisualStyleBackColor = True
        '
        'BtoGuardar
        '
        Me.BtoGuardar.Location = New System.Drawing.Point(305, 12)
        Me.BtoGuardar.Name = "BtoGuardar"
        Me.BtoGuardar.Size = New System.Drawing.Size(119, 88)
        Me.BtoGuardar.TabIndex = 4
        Me.BtoGuardar.Text = "Guardar"
        Me.BtoGuardar.UseVisualStyleBackColor = True
        '
        'BtoCancelar
        '
        Me.BtoCancelar.Location = New System.Drawing.Point(548, 12)
        Me.BtoCancelar.Name = "BtoCancelar"
        Me.BtoCancelar.Size = New System.Drawing.Size(115, 88)
        Me.BtoCancelar.TabIndex = 5
        Me.BtoCancelar.Text = "Cancelar"
        Me.BtoCancelar.UseVisualStyleBackColor = True
        '
        'BtoSalir
        '
        Me.BtoSalir.Location = New System.Drawing.Point(669, 12)
        Me.BtoSalir.Name = "BtoSalir"
        Me.BtoSalir.Size = New System.Drawing.Size(119, 88)
        Me.BtoSalir.TabIndex = 6
        Me.BtoSalir.Text = "Salir"
        Me.BtoSalir.UseVisualStyleBackColor = True
        '
        'DtpCliente
        '
        Me.DtpCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpCliente.Location = New System.Drawing.Point(669, 106)
        Me.DtpCliente.Name = "DtpCliente"
        Me.DtpCliente.Size = New System.Drawing.Size(119, 20)
        Me.DtpCliente.TabIndex = 7
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(688, 165)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbxNombre.TabIndex = 9
        '
        'tbxClave
        '
        Me.tbxClave.Location = New System.Drawing.Point(480, 165)
        Me.tbxClave.Name = "tbxClave"
        Me.tbxClave.Size = New System.Drawing.Size(100, 20)
        Me.tbxClave.TabIndex = 10
        '
        'ChbActivo
        '
        Me.ChbActivo.AutoSize = True
        Me.ChbActivo.Location = New System.Drawing.Point(175, 111)
        Me.ChbActivo.Name = "ChbActivo"
        Me.ChbActivo.Size = New System.Drawing.Size(56, 17)
        Me.ChbActivo.TabIndex = 11
        Me.ChbActivo.Text = "Activo"
        Me.ChbActivo.UseVisualStyleBackColor = True
        '
        'ClientesBL
        '
        Me.ClientesBL.DataSetName = "DsClientes"
        Me.ClientesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(427, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(119, 88)
        Me.BtnBuscar.TabIndex = 13
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FRMClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 206)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.ChbActivo)
        Me.Controls.Add(Me.tbxClave)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.DtpCliente)
        Me.Controls.Add(Me.BtoSalir)
        Me.Controls.Add(Me.BtoCancelar)
        Me.Controls.Add(Me.BtoGuardar)
        Me.Controls.Add(Me.BtoModificar)
        Me.Controls.Add(Me.BtoNuevo)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblClave)
        Me.Name = "FRMClientes"
        Me.Text = "FRMClientes"
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblClave As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtoNuevo As Button
    Friend WithEvents BtoModificar As Button
    Friend WithEvents BtoGuardar As Button
    Friend WithEvents BtoCancelar As Button
    Friend WithEvents BtoSalir As Button
    Friend WithEvents DtpCliente As DateTimePicker
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents tbxClave As TextBox
    Friend WithEvents ChbActivo As CheckBox
    Friend WithEvents ClientesBL As Negocios.ClientesBL
    Friend WithEvents BtnBuscar As Button
End Class
