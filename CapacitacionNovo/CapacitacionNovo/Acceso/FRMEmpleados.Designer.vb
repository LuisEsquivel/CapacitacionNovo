<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMEmpleados
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Clave = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbColores = New System.Windows.Forms.ComboBox()
        Me.ColoresBL = New Negocios.ColoresBL()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbRol = New System.Windows.Forms.ComboBox()
        Me.RolesBL1 = New Negocios.RolesBL()
        Me.DtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.EmpleadosBL = New Negocios.EmpleadosBL()
        Me.CVE_EMPLEADOS_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_COLOR_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_ROL_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO_BIT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_EMPLEADO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORD_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ColoresBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(520, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 83)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(445, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 83)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(370, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 83)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(219, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 83)
        Me.BtnNuevo.TabIndex = 5
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(294, 12)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 83)
        Me.BtnModificar.TabIndex = 4
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(176, 16)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(47, 13)
        Me.Nombre.TabIndex = 8
        Me.Nombre.Text = "Nombre "
        '
        'Clave
        '
        Me.Clave.AutoSize = True
        Me.Clave.Location = New System.Drawing.Point(16, 16)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(34, 13)
        Me.Clave.TabIndex = 9
        Me.Clave.Text = "Clave"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(402, 16)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(53, 13)
        Me.Password.TabIndex = 12
        Me.Password.Text = "Password"
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(179, 32)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(220, 20)
        Me.TxtNombre.TabIndex = 15
        '
        'TxtClave
        '
        Me.TxtClave.Enabled = False
        Me.TxtClave.Location = New System.Drawing.Point(19, 32)
        Me.TxtClave.MaxLength = 15
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(154, 20)
        Me.TxtClave.TabIndex = 14
        '
        'TxtPassword
        '
        Me.TxtPassword.Enabled = False
        Me.TxtPassword.Location = New System.Drawing.Point(405, 32)
        Me.TxtPassword.MaxLength = 10
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(152, 20)
        Me.TxtPassword.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CmbColores)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CmbRol)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.TxtClave)
        Me.GroupBox1.Controls.Add(Me.Clave)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 107)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Color"
        '
        'CmbColores
        '
        Me.CmbColores.DataSource = Me.ColoresBL
        Me.CmbColores.DisplayMember = "TBLCOLORES.NOMBRE_VAR"
        Me.CmbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbColores.FormattingEnabled = True
        Me.CmbColores.Location = New System.Drawing.Point(219, 80)
        Me.CmbColores.Name = "CmbColores"
        Me.CmbColores.Size = New System.Drawing.Size(134, 21)
        Me.CmbColores.TabIndex = 21
        Me.CmbColores.ValueMember = "TBLCOLORES.CVE_COLOR_INT"
        '
        'ColoresBL
        '
        Me.ColoresBL.DataSetName = "DsColores"
        Me.ColoresBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Rol"
        '
        'CmbRol
        '
        Me.CmbRol.DataSource = Me.RolesBL1
        Me.CmbRol.DisplayMember = "TBLROLES.DESC_ROL_VAR"
        Me.CmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRol.FormattingEnabled = True
        Me.CmbRol.Location = New System.Drawing.Point(19, 80)
        Me.CmbRol.Name = "CmbRol"
        Me.CmbRol.Size = New System.Drawing.Size(154, 21)
        Me.CmbRol.TabIndex = 19
        Me.CmbRol.ValueMember = "TBLROLES.CVE_ROL_INT"
        '
        'RolesBL1
        '
        Me.RolesBL1.DataSetName = "DsRoles"
        Me.RolesBL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtpFechaAlta
        '
        Me.DtpFechaAlta.Enabled = False
        Me.DtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaAlta.Location = New System.Drawing.Point(497, 110)
        Me.DtpFechaAlta.Name = "DtpFechaAlta"
        Me.DtpFechaAlta.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaAlta.TabIndex = 17
        '
        'ChkActivo
        '
        Me.ChkActivo.AutoSize = True
        Me.ChkActivo.Location = New System.Drawing.Point(219, 110)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(56, 17)
        Me.ChkActivo.TabIndex = 18
        Me.ChkActivo.Text = "Activo"
        Me.ChkActivo.UseVisualStyleBackColor = True
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.AllowUserToDeleteRows = False
        Me.DgvEmpleados.AutoGenerateColumns = False
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_EMPLEADOS_VAR, Me.CVE_COLOR_INT, Me.CVE_ROL_INT, Me.NOMBRE_VAR, Me.ACTIVO_BIT, Me.FECHA_ALTA_DATE, Me.CVE_EMPLEADO_VAR, Me.PASSWORD_VAR})
        Me.DgvEmpleados.DataSource = Me.EmpleadosBL.TBLEMPLEADOS
        Me.DgvEmpleados.Location = New System.Drawing.Point(24, 267)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        Me.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleados.Size = New System.Drawing.Size(571, 254)
        Me.DgvEmpleados.TabIndex = 6
        '
        'EmpleadosBL
        '
        Me.EmpleadosBL.DataSetName = "DsEmpleados"
        Me.EmpleadosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_EMPLEADOS_VAR
        '
        Me.CVE_EMPLEADOS_VAR.DataPropertyName = "CVE_EMPLEADOS_VAR"
        Me.CVE_EMPLEADOS_VAR.HeaderText = "CVE_EMPLEADOS_VAR"
        Me.CVE_EMPLEADOS_VAR.Name = "CVE_EMPLEADOS_VAR"
        Me.CVE_EMPLEADOS_VAR.ReadOnly = True
        '
        'CVE_COLOR_INT
        '
        Me.CVE_COLOR_INT.DataPropertyName = "CVE_COLOR_INT"
        Me.CVE_COLOR_INT.HeaderText = "CVE_COLOR_INT"
        Me.CVE_COLOR_INT.Name = "CVE_COLOR_INT"
        Me.CVE_COLOR_INT.ReadOnly = True
        '
        'CVE_ROL_INT
        '
        Me.CVE_ROL_INT.DataPropertyName = "CVE_ROL_INT"
        Me.CVE_ROL_INT.HeaderText = "CVE_ROL_INT"
        Me.CVE_ROL_INT.Name = "CVE_ROL_INT"
        Me.CVE_ROL_INT.ReadOnly = True
        '
        'NOMBRE_VAR
        '
        Me.NOMBRE_VAR.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBRE_VAR.HeaderText = "NOMBRE_VAR"
        Me.NOMBRE_VAR.Name = "NOMBRE_VAR"
        Me.NOMBRE_VAR.ReadOnly = True
        '
        'ACTIVO_BIT
        '
        Me.ACTIVO_BIT.DataPropertyName = "ACTIVO_BIT"
        Me.ACTIVO_BIT.HeaderText = "ACTIVO_BIT"
        Me.ACTIVO_BIT.Name = "ACTIVO_BIT"
        Me.ACTIVO_BIT.ReadOnly = True
        '
        'FECHA_ALTA_DATE
        '
        Me.FECHA_ALTA_DATE.DataPropertyName = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.HeaderText = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.Name = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.ReadOnly = True
        '
        'CVE_EMPLEADO_VAR
        '
        Me.CVE_EMPLEADO_VAR.DataPropertyName = "CVE_EMPLEADO_VAR"
        Me.CVE_EMPLEADO_VAR.HeaderText = "CVE_EMPLEADO_VAR"
        Me.CVE_EMPLEADO_VAR.Name = "CVE_EMPLEADO_VAR"
        Me.CVE_EMPLEADO_VAR.ReadOnly = True
        '
        'PASSWORD_VAR
        '
        Me.PASSWORD_VAR.DataPropertyName = "PASSWORD_VAR"
        Me.PASSWORD_VAR.HeaderText = "PASSWORD_VAR"
        Me.PASSWORD_VAR.Name = "PASSWORD_VAR"
        Me.PASSWORD_VAR.ReadOnly = True
        '
        'FRMEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 533)
        Me.Controls.Add(Me.ChkActivo)
        Me.Controls.Add(Me.DtpFechaAlta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvEmpleados)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FRMEmpleados"
        Me.Text = "Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ColoresBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents DgvEmpleados As DataGridView
    Friend WithEvents Nombre As Label
    Friend WithEvents Clave As Label
    Friend WithEvents Password As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents EmpleadosBL As Negocios.EmpleadosBL
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DtpFechaAlta As DateTimePicker
    Friend WithEvents ChkActivo As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbRol As ComboBox
    Friend WithEvents RolesBL1 As Negocios.RolesBL
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbColores As ComboBox
    Friend WithEvents ColoresBL As Negocios.ColoresBL
    Friend WithEvents CVE_EMPLEADOS_VAR As DataGridViewTextBoxColumn
    Friend WithEvents CVE_COLOR_INT As DataGridViewTextBoxColumn
    Friend WithEvents CVE_ROL_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO_BIT As DataGridViewCheckBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
    Friend WithEvents CVE_EMPLEADO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORD_VAR As DataGridViewTextBoxColumn
End Class
