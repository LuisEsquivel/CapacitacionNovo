<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMColores
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BttoNuevo = New System.Windows.Forms.Button()
        Me.BttoModificar = New System.Windows.Forms.Button()
        Me.BttoGuardar = New System.Windows.Forms.Button()
        Me.BttoCancel = New System.Windows.Forms.Button()
        Me.BttoSalir = New System.Windows.Forms.Button()
        Me.tbxClave = New System.Windows.Forms.TextBox()
        Me.tbxColor = New System.Windows.Forms.TextBox()
        Me.DGVColores = New System.Windows.Forms.DataGridView()
        Me.CVE_COLOR_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_MOD_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_USUARIO_ALTA_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_USUARIO_MOD_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO_BIT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColoresBL = New Negocios.ColoresBL()
        Me.DTPColores = New System.Windows.Forms.DateTimePicker()
        Me.ChbActivo = New System.Windows.Forms.CheckBox()
        CType(Me.DGVColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(520, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clave"
        '
        'BttoNuevo
        '
        Me.BttoNuevo.Location = New System.Drawing.Point(266, 12)
        Me.BttoNuevo.Name = "BttoNuevo"
        Me.BttoNuevo.Size = New System.Drawing.Size(99, 77)
        Me.BttoNuevo.TabIndex = 2
        Me.BttoNuevo.Text = "Nuevo"
        Me.BttoNuevo.UseVisualStyleBackColor = True
        '
        'BttoModificar
        '
        Me.BttoModificar.Location = New System.Drawing.Point(371, 12)
        Me.BttoModificar.Name = "BttoModificar"
        Me.BttoModificar.Size = New System.Drawing.Size(99, 77)
        Me.BttoModificar.TabIndex = 3
        Me.BttoModificar.Text = "Modificar"
        Me.BttoModificar.UseVisualStyleBackColor = True
        '
        'BttoGuardar
        '
        Me.BttoGuardar.Location = New System.Drawing.Point(476, 12)
        Me.BttoGuardar.Name = "BttoGuardar"
        Me.BttoGuardar.Size = New System.Drawing.Size(100, 77)
        Me.BttoGuardar.TabIndex = 4
        Me.BttoGuardar.Text = "Guardar"
        Me.BttoGuardar.UseVisualStyleBackColor = True
        '
        'BttoCancel
        '
        Me.BttoCancel.Location = New System.Drawing.Point(582, 12)
        Me.BttoCancel.Name = "BttoCancel"
        Me.BttoCancel.Size = New System.Drawing.Size(100, 77)
        Me.BttoCancel.TabIndex = 5
        Me.BttoCancel.Text = "Cancelar"
        Me.BttoCancel.UseVisualStyleBackColor = True
        '
        'BttoSalir
        '
        Me.BttoSalir.Location = New System.Drawing.Point(688, 12)
        Me.BttoSalir.Name = "BttoSalir"
        Me.BttoSalir.Size = New System.Drawing.Size(100, 77)
        Me.BttoSalir.TabIndex = 6
        Me.BttoSalir.Text = "Salir"
        Me.BttoSalir.UseVisualStyleBackColor = True
        '
        'tbxClave
        '
        Me.tbxClave.Location = New System.Drawing.Point(320, 164)
        Me.tbxClave.Name = "tbxClave"
        Me.tbxClave.Size = New System.Drawing.Size(100, 20)
        Me.tbxClave.TabIndex = 7
        '
        'tbxColor
        '
        Me.tbxColor.Location = New System.Drawing.Point(523, 164)
        Me.tbxColor.Name = "tbxColor"
        Me.tbxColor.Size = New System.Drawing.Size(100, 20)
        Me.tbxColor.TabIndex = 8
        '
        'DGVColores
        '
        Me.DGVColores.AllowUserToAddRows = False
        Me.DGVColores.AllowUserToDeleteRows = False
        Me.DGVColores.AutoGenerateColumns = False
        Me.DGVColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVColores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_COLOR_INT, Me.NOMBRE_VAR, Me.FECHA_ALTA_DATE, Me.FECHA_MOD_DATE, Me.CVE_USUARIO_ALTA_VAR, Me.CVE_USUARIO_MOD_VAR, Me.ACTIVO_BIT})
        Me.DGVColores.DataSource = Me.ColoresBL.TBLCOLORES
        Me.DGVColores.Location = New System.Drawing.Point(245, 213)
        Me.DGVColores.Name = "DGVColores"
        Me.DGVColores.ReadOnly = True
        Me.DGVColores.Size = New System.Drawing.Size(543, 225)
        Me.DGVColores.TabIndex = 9
        '
        'CVE_COLOR_INT
        '
        Me.CVE_COLOR_INT.DataPropertyName = "CVE_COLOR_INT"
        Me.CVE_COLOR_INT.HeaderText = "CVE_COLOR_INT"
        Me.CVE_COLOR_INT.Name = "CVE_COLOR_INT"
        Me.CVE_COLOR_INT.ReadOnly = True
        '
        'NOMBRE_VAR
        '
        Me.NOMBRE_VAR.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBRE_VAR.HeaderText = "NOMBRE_VAR"
        Me.NOMBRE_VAR.Name = "NOMBRE_VAR"
        Me.NOMBRE_VAR.ReadOnly = True
        '
        'FECHA_ALTA_DATE
        '
        Me.FECHA_ALTA_DATE.DataPropertyName = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.HeaderText = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.Name = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.ReadOnly = True
        '
        'FECHA_MOD_DATE
        '
        Me.FECHA_MOD_DATE.DataPropertyName = "FECHA_MOD_DATE"
        Me.FECHA_MOD_DATE.HeaderText = "FECHA_MOD_DATE"
        Me.FECHA_MOD_DATE.Name = "FECHA_MOD_DATE"
        Me.FECHA_MOD_DATE.ReadOnly = True
        '
        'CVE_USUARIO_ALTA_VAR
        '
        Me.CVE_USUARIO_ALTA_VAR.DataPropertyName = "CVE_USUARIO_ALTA_VAR"
        Me.CVE_USUARIO_ALTA_VAR.HeaderText = "CVE_USUARIO_ALTA_VAR"
        Me.CVE_USUARIO_ALTA_VAR.Name = "CVE_USUARIO_ALTA_VAR"
        Me.CVE_USUARIO_ALTA_VAR.ReadOnly = True
        '
        'CVE_USUARIO_MOD_VAR
        '
        Me.CVE_USUARIO_MOD_VAR.DataPropertyName = "CVE_USUARIO_MOD_VAR"
        Me.CVE_USUARIO_MOD_VAR.HeaderText = "CVE_USUARIO_MOD_VAR"
        Me.CVE_USUARIO_MOD_VAR.Name = "CVE_USUARIO_MOD_VAR"
        Me.CVE_USUARIO_MOD_VAR.ReadOnly = True
        '
        'ACTIVO_BIT
        '
        Me.ACTIVO_BIT.DataPropertyName = "ACTIVO_BIT"
        Me.ACTIVO_BIT.HeaderText = "ACTIVO_BIT"
        Me.ACTIVO_BIT.Name = "ACTIVO_BIT"
        Me.ACTIVO_BIT.ReadOnly = True
        '
        'ColoresBL
        '
        Me.ColoresBL.DataSetName = "DsColores"
        Me.ColoresBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTPColores
        '
        Me.DTPColores.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPColores.Location = New System.Drawing.Point(688, 95)
        Me.DTPColores.Name = "DTPColores"
        Me.DTPColores.Size = New System.Drawing.Size(100, 20)
        Me.DTPColores.TabIndex = 10
        '
        'ChbActivo
        '
        Me.ChbActivo.AutoSize = True
        Me.ChbActivo.Location = New System.Drawing.Point(179, 95)
        Me.ChbActivo.Name = "ChbActivo"
        Me.ChbActivo.Size = New System.Drawing.Size(56, 17)
        Me.ChbActivo.TabIndex = 11
        Me.ChbActivo.Text = "Activo"
        Me.ChbActivo.UseVisualStyleBackColor = True
        '
        'FRMColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ChbActivo)
        Me.Controls.Add(Me.DTPColores)
        Me.Controls.Add(Me.DGVColores)
        Me.Controls.Add(Me.tbxColor)
        Me.Controls.Add(Me.tbxClave)
        Me.Controls.Add(Me.BttoSalir)
        Me.Controls.Add(Me.BttoCancel)
        Me.Controls.Add(Me.BttoGuardar)
        Me.Controls.Add(Me.BttoModificar)
        Me.Controls.Add(Me.BttoNuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMColores"
        Me.Text = "FRMColores"
        CType(Me.DGVColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BttoNuevo As Button
    Friend WithEvents BttoModificar As Button
    Friend WithEvents BttoGuardar As Button
    Friend WithEvents BttoCancel As Button
    Friend WithEvents BttoSalir As Button
    Friend WithEvents tbxClave As TextBox
    Friend WithEvents tbxColor As TextBox
    Friend WithEvents DGVColores As DataGridView
    Friend WithEvents DTPColores As DateTimePicker
    Friend WithEvents ChbActivo As CheckBox
    Friend WithEvents ColoresBL As Negocios.ColoresBL
    Friend WithEvents CVE_COLOR_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_MOD_DATE As DataGridViewTextBoxColumn
    Friend WithEvents CVE_USUARIO_ALTA_VAR As DataGridViewTextBoxColumn
    Friend WithEvents CVE_USUARIO_MOD_VAR As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO_BIT As DataGridViewCheckBoxColumn
End Class
