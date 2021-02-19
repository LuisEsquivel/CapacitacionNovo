<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBuscarEmpleados
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
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.DGVEmpleados = New System.Windows.Forms.DataGridView()
        Me.EmpleadosBL = New Negocios.EmpleadosBL()
        Me.CVE_EMPLEADOS_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO_BIT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_ROL_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORD_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Regresar
        '
        Me.Regresar.Location = New System.Drawing.Point(671, 12)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(117, 87)
        Me.Regresar.TabIndex = 0
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(536, 12)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(129, 87)
        Me.Buscar.TabIndex = 1
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'DGVEmpleados
        '
        Me.DGVEmpleados.AllowUserToAddRows = False
        Me.DGVEmpleados.AllowUserToDeleteRows = False
        Me.DGVEmpleados.AutoGenerateColumns = False
        Me.DGVEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_EMPLEADOS_VAR, Me.NOMBRE_VAR, Me.ACTIVO_BIT, Me.FECHA_ALTA_DATE, Me.CVE_ROL_INT, Me.PASSWORD_VAR})
        Me.DGVEmpleados.DataSource = Me.EmpleadosBL.TBLEMPLEADOS
        Me.DGVEmpleados.Location = New System.Drawing.Point(12, 138)
        Me.DGVEmpleados.Name = "DGVEmpleados"
        Me.DGVEmpleados.ReadOnly = True
        Me.DGVEmpleados.Size = New System.Drawing.Size(776, 300)
        Me.DGVEmpleados.TabIndex = 2
        '
        'EmpleadosBL
        '
        Me.EmpleadosBL.DataSetName = "DsEmpleados"
        Me.EmpleadosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_EMPLEADOS_VAR
        '
        Me.CVE_EMPLEADOS_VAR.DataPropertyName = "CVE_EMPLEADOS_VAR"
        Me.CVE_EMPLEADOS_VAR.HeaderText = "CVE EMPLEADO"
        Me.CVE_EMPLEADOS_VAR.Name = "CVE_EMPLEADOS_VAR"
        Me.CVE_EMPLEADOS_VAR.ReadOnly = True
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
        'CVE_ROL_INT
        '
        Me.CVE_ROL_INT.DataPropertyName = "CVE_ROL_INT"
        Me.CVE_ROL_INT.HeaderText = "CVE_ROL_INT"
        Me.CVE_ROL_INT.Name = "CVE_ROL_INT"
        Me.CVE_ROL_INT.ReadOnly = True
        '
        'PASSWORD_VAR
        '
        Me.PASSWORD_VAR.DataPropertyName = "PASSWORD_VAR"
        Me.PASSWORD_VAR.HeaderText = "PASSWORD_VAR"
        Me.PASSWORD_VAR.Name = "PASSWORD_VAR"
        Me.PASSWORD_VAR.ReadOnly = True
        '
        'FRMBuscarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGVEmpleados)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Regresar)
        Me.Name = "FRMBuscarEmpleados"
        Me.Text = "FRMBuscarEmpleados"
        CType(Me.DGVEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Regresar As Button
    Friend WithEvents Buscar As Button
    Friend WithEvents DGVEmpleados As DataGridView
    Friend WithEvents EmpleadosBL As Negocios.EmpleadosBL
    Friend WithEvents CVE_EMPLEADOS_VAR As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO_BIT As DataGridViewCheckBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
    Friend WithEvents CVE_ROL_INT As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORD_VAR As DataGridViewTextBoxColumn
End Class
