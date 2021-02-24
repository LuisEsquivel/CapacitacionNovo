<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMRoles
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
        Me.guardar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.Label()
        Me.clave = New System.Windows.Forms.Label()
        Me.tbxClave = New System.Windows.Forms.TextBox()
        Me.tbxDescrip = New System.Windows.Forms.TextBox()
        Me.dtpRoles = New System.Windows.Forms.DateTimePicker()
        Me.ckbRoles = New System.Windows.Forms.CheckBox()
        Me.DGVRoles = New System.Windows.Forms.DataGridView()
        Me.CVE_ROL_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_ROL_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAALTADATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVEUSUARIOALTAVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO_BIT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RolesBL = New Negocios.RolesBL()
        Me.BtoBuscar = New System.Windows.Forms.Button()
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(487, 12)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(101, 92)
        Me.guardar.TabIndex = 0
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(594, 12)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(99, 92)
        Me.Cancelar.TabIndex = 1
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(699, 12)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(89, 92)
        Me.salir.TabIndex = 2
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(381, 12)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(100, 92)
        Me.modificar.TabIndex = 3
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(283, 12)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(92, 92)
        Me.nuevo.TabIndex = 4
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(297, 120)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(62, 13)
        Me.nombre.TabIndex = 6
        Me.nombre.Text = "Descripsion"
        '
        'clave
        '
        Me.clave.AutoSize = True
        Me.clave.Location = New System.Drawing.Point(133, 120)
        Me.clave.Name = "clave"
        Me.clave.Size = New System.Drawing.Size(34, 13)
        Me.clave.TabIndex = 7
        Me.clave.Text = "Clave"
        '
        'tbxClave
        '
        Me.tbxClave.Location = New System.Drawing.Point(78, 136)
        Me.tbxClave.Name = "tbxClave"
        Me.tbxClave.Size = New System.Drawing.Size(148, 20)
        Me.tbxClave.TabIndex = 8
        '
        'tbxDescrip
        '
        Me.tbxDescrip.Location = New System.Drawing.Point(249, 136)
        Me.tbxDescrip.MaxLength = 9999
        Me.tbxDescrip.Name = "tbxDescrip"
        Me.tbxDescrip.Size = New System.Drawing.Size(151, 20)
        Me.tbxDescrip.TabIndex = 10
        '
        'dtpRoles
        '
        Me.dtpRoles.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRoles.Location = New System.Drawing.Point(699, 110)
        Me.dtpRoles.Name = "dtpRoles"
        Me.dtpRoles.Size = New System.Drawing.Size(89, 20)
        Me.dtpRoles.TabIndex = 12
        '
        'ckbRoles
        '
        Me.ckbRoles.AutoSize = True
        Me.ckbRoles.Location = New System.Drawing.Point(532, 110)
        Me.ckbRoles.Name = "ckbRoles"
        Me.ckbRoles.Size = New System.Drawing.Size(56, 17)
        Me.ckbRoles.TabIndex = 13
        Me.ckbRoles.Text = "Activo"
        Me.ckbRoles.UseVisualStyleBackColor = True
        '
        'DGVRoles
        '
        Me.DGVRoles.AllowUserToAddRows = False
        Me.DGVRoles.AllowUserToDeleteRows = False
        Me.DGVRoles.AutoGenerateColumns = False
        Me.DGVRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_ROL_INT, Me.DESC_ROL_VAR, Me.FECHAALTADATEDataGridViewTextBoxColumn, Me.CVEUSUARIOALTAVARDataGridViewTextBoxColumn, Me.ACTIVO_BIT})
        Me.DGVRoles.DataSource = Me.RolesBL.TBLROLES
        Me.DGVRoles.Location = New System.Drawing.Point(78, 172)
        Me.DGVRoles.Name = "DGVRoles"
        Me.DGVRoles.ReadOnly = True
        Me.DGVRoles.Size = New System.Drawing.Size(710, 266)
        Me.DGVRoles.TabIndex = 11
        '
        'CVE_ROL_INT
        '
        Me.CVE_ROL_INT.DataPropertyName = "CVE_ROL_INT"
        Me.CVE_ROL_INT.HeaderText = "CVE_ROL_INT"
        Me.CVE_ROL_INT.Name = "CVE_ROL_INT"
        Me.CVE_ROL_INT.ReadOnly = True
        '
        'DESC_ROL_VAR
        '
        Me.DESC_ROL_VAR.DataPropertyName = "DESC_ROL_VAR"
        Me.DESC_ROL_VAR.HeaderText = "DESC_ROL_VAR"
        Me.DESC_ROL_VAR.Name = "DESC_ROL_VAR"
        Me.DESC_ROL_VAR.ReadOnly = True
        '
        'FECHAALTADATEDataGridViewTextBoxColumn
        '
        Me.FECHAALTADATEDataGridViewTextBoxColumn.DataPropertyName = "FECHA_ALTA_DATE"
        Me.FECHAALTADATEDataGridViewTextBoxColumn.HeaderText = "FECHA_ALTA_DATE"
        Me.FECHAALTADATEDataGridViewTextBoxColumn.Name = "FECHAALTADATEDataGridViewTextBoxColumn"
        Me.FECHAALTADATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CVEUSUARIOALTAVARDataGridViewTextBoxColumn
        '
        Me.CVEUSUARIOALTAVARDataGridViewTextBoxColumn.DataPropertyName = "CVE_USUARIO_ALTA_VAR"
        Me.CVEUSUARIOALTAVARDataGridViewTextBoxColumn.HeaderText = "CVE_USUARIO_ALTA_VAR"
        Me.CVEUSUARIOALTAVARDataGridViewTextBoxColumn.Name = "CVEUSUARIOALTAVARDataGridViewTextBoxColumn"
        Me.CVEUSUARIOALTAVARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ACTIVO_BIT
        '
        Me.ACTIVO_BIT.DataPropertyName = "ACTIVO_BIT"
        Me.ACTIVO_BIT.HeaderText = "ACTIVO_BIT"
        Me.ACTIVO_BIT.Name = "ACTIVO_BIT"
        Me.ACTIVO_BIT.ReadOnly = True
        '
        'RolesBL
        '
        Me.RolesBL.DataSetName = "DsRoles"
        Me.RolesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtoBuscar
        '
        Me.BtoBuscar.Location = New System.Drawing.Point(177, 12)
        Me.BtoBuscar.Name = "BtoBuscar"
        Me.BtoBuscar.Size = New System.Drawing.Size(100, 92)
        Me.BtoBuscar.TabIndex = 14
        Me.BtoBuscar.Text = "Buscar"
        Me.BtoBuscar.UseVisualStyleBackColor = True
        '
        'FRMRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 166)
        Me.Controls.Add(Me.BtoBuscar)
        Me.Controls.Add(Me.ckbRoles)
        Me.Controls.Add(Me.dtpRoles)
        Me.Controls.Add(Me.DGVRoles)
        Me.Controls.Add(Me.tbxDescrip)
        Me.Controls.Add(Me.tbxClave)
        Me.Controls.Add(Me.clave)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.guardar)
        Me.Name = "FRMRoles"
        Me.Text = "FRMRoles"
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents guardar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents salir As Button
    Friend WithEvents modificar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents nombre As Label
    Friend WithEvents clave As Label
    Friend WithEvents tbxClave As TextBox
    Friend WithEvents tbxDescrip As TextBox
    Friend WithEvents DGVRoles As DataGridView
    Friend WithEvents dtpRoles As DateTimePicker
    Friend WithEvents ckbRoles As CheckBox
    Friend WithEvents RolesBL As Negocios.RolesBL
    Friend WithEvents CVE_ROL_INT As DataGridViewTextBoxColumn
    Friend WithEvents DESC_ROL_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHAALTADATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CVEUSUARIOALTAVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO_BIT As DataGridViewCheckBoxColumn
    Friend WithEvents BtoBuscar As Button
End Class
