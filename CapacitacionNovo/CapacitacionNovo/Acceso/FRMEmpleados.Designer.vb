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
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.CVEEMPLEADOSVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVOBITDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FECHAALTADATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVEEMPLEADOVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBL = New Negocios.EmpleadosBL()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Clave = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxClave = New System.Windows.Forms.TextBox()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(650, 30)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 83)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(575, 30)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 83)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(500, 30)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 83)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(349, 30)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 83)
        Me.BtnNuevo.TabIndex = 5
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(424, 30)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 83)
        Me.BtnModificar.TabIndex = 4
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.AllowUserToDeleteRows = False
        Me.DgvEmpleados.AutoGenerateColumns = False
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVEEMPLEADOSVARDataGridViewTextBoxColumn, Me.NOMBREVARDataGridViewTextBoxColumn, Me.ACTIVOBITDataGridViewCheckBoxColumn, Me.FECHAALTADATEDataGridViewTextBoxColumn, Me.CVEEMPLEADOVARDataGridViewTextBoxColumn, Me.PASSWORDVARDataGridViewTextBoxColumn})
        Me.DgvEmpleados.DataSource = Me.EmpleadosBL.TBLEMPLEADOS
        Me.DgvEmpleados.Location = New System.Drawing.Point(24, 233)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        Me.DgvEmpleados.Size = New System.Drawing.Size(701, 331)
        Me.DgvEmpleados.TabIndex = 6
        '
        'CVEEMPLEADOSVARDataGridViewTextBoxColumn
        '
        Me.CVEEMPLEADOSVARDataGridViewTextBoxColumn.DataPropertyName = "CVE_EMPLEADOS_VAR"
        Me.CVEEMPLEADOSVARDataGridViewTextBoxColumn.HeaderText = "CVE_EMPLEADOS_VAR"
        Me.CVEEMPLEADOSVARDataGridViewTextBoxColumn.Name = "CVEEMPLEADOSVARDataGridViewTextBoxColumn"
        Me.CVEEMPLEADOSVARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREVARDataGridViewTextBoxColumn
        '
        Me.NOMBREVARDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBREVARDataGridViewTextBoxColumn.HeaderText = "NOMBRE_VAR"
        Me.NOMBREVARDataGridViewTextBoxColumn.Name = "NOMBREVARDataGridViewTextBoxColumn"
        Me.NOMBREVARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ACTIVOBITDataGridViewCheckBoxColumn
        '
        Me.ACTIVOBITDataGridViewCheckBoxColumn.DataPropertyName = "ACTIVO_BIT"
        Me.ACTIVOBITDataGridViewCheckBoxColumn.HeaderText = "ACTIVO_BIT"
        Me.ACTIVOBITDataGridViewCheckBoxColumn.Name = "ACTIVOBITDataGridViewCheckBoxColumn"
        Me.ACTIVOBITDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FECHAALTADATEDataGridViewTextBoxColumn
        '
        Me.FECHAALTADATEDataGridViewTextBoxColumn.DataPropertyName = "FECHA_ALTA_DATE"
        Me.FECHAALTADATEDataGridViewTextBoxColumn.HeaderText = "FECHA_ALTA_DATE"
        Me.FECHAALTADATEDataGridViewTextBoxColumn.Name = "FECHAALTADATEDataGridViewTextBoxColumn"
        Me.FECHAALTADATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CVEEMPLEADOVARDataGridViewTextBoxColumn
        '
        Me.CVEEMPLEADOVARDataGridViewTextBoxColumn.DataPropertyName = "CVE_EMPLEADO_VAR"
        Me.CVEEMPLEADOVARDataGridViewTextBoxColumn.HeaderText = "CVE_EMPLEADO_VAR"
        Me.CVEEMPLEADOVARDataGridViewTextBoxColumn.Name = "CVEEMPLEADOVARDataGridViewTextBoxColumn"
        Me.CVEEMPLEADOVARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PASSWORDVARDataGridViewTextBoxColumn
        '
        Me.PASSWORDVARDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD_VAR"
        Me.PASSWORDVARDataGridViewTextBoxColumn.HeaderText = "PASSWORD_VAR"
        Me.PASSWORDVARDataGridViewTextBoxColumn.Name = "PASSWORDVARDataGridViewTextBoxColumn"
        Me.PASSWORDVARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadosBL
        '
        Me.EmpleadosBL.DataSetName = "DsEmpleados"
        Me.EmpleadosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(15, 31)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(47, 13)
        Me.Nombre.TabIndex = 8
        Me.Nombre.Text = "Nombre "
        '
        'Clave
        '
        Me.Clave.AutoSize = True
        Me.Clave.Location = New System.Drawing.Point(15, 65)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(34, 13)
        Me.Clave.TabIndex = 9
        Me.Clave.Text = "Clave"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(15, 98)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(53, 13)
        Me.Password.TabIndex = 12
        Me.Password.Text = "Password"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(96, 23)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbxNombre.TabIndex = 13
        '
        'tbxClave
        '
        Me.tbxClave.Location = New System.Drawing.Point(96, 65)
        Me.tbxClave.Name = "tbxClave"
        Me.tbxClave.Size = New System.Drawing.Size(100, 20)
        Me.tbxClave.TabIndex = 14
        '
        'tbxPassword
        '
        Me.tbxPassword.Location = New System.Drawing.Point(96, 98)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.Size = New System.Drawing.Size(100, 20)
        Me.tbxPassword.TabIndex = 15
        '
        'FRMEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 576)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.tbxClave)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Clave)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.DgvEmpleados)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FRMEmpleados"
        Me.Text = "Empleados"
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
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents tbxClave As TextBox
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents EmpleadosBL As Negocios.EmpleadosBL
    Friend WithEvents CVEEMPLEADOSVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVOBITDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FECHAALTADATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CVEEMPLEADOVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
