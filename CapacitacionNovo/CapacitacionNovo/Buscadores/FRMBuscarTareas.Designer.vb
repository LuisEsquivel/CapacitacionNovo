<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBuscarTareas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvTareas = New System.Windows.Forms.DataGridView()
        Me.TareasBL = New Negocios.TareasBL()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CVE_TAREA_BIGINT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCIONVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUDAS_PRESENTADAS_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESPUESTA_A_DUDAS_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DgvTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TareasBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvTareas
        '
        Me.DgvTareas.AllowUserToAddRows = False
        Me.DgvTareas.AllowUserToDeleteRows = False
        Me.DgvTareas.AutoGenerateColumns = False
        Me.DgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTareas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_TAREA_BIGINT, Me.DESCRIPCIONVARDataGridViewTextBoxColumn, Me.DUDAS_PRESENTADAS_VAR, Me.RESPUESTA_A_DUDAS_VAR, Me.FECHA_ALTA_DATE, Me.BtnEliminar})
        Me.DgvTareas.DataSource = Me.TareasBL.TBLTAREAS
        Me.DgvTareas.Location = New System.Drawing.Point(12, 158)
        Me.DgvTareas.Name = "DgvTareas"
        Me.DgvTareas.ReadOnly = True
        Me.DgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTareas.Size = New System.Drawing.Size(870, 459)
        Me.DgvTareas.TabIndex = 29
        '
        'TareasBL
        '
        Me.TareasBL.DataSetName = "DSTareas"
        Me.TareasBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(762, 24)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(119, 88)
        Me.BtnRegresar.TabIndex = 31
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(641, 24)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(115, 88)
        Me.BtnBuscar.TabIndex = 30
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DtpFechaInicial
        '
        Me.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicial.Location = New System.Drawing.Point(12, 110)
        Me.DtpFechaInicial.Name = "DtpFechaInicial"
        Me.DtpFechaInicial.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaInicial.TabIndex = 32
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(117, 110)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaFinal.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha Final"
        '
        'CVE_TAREA_BIGINT
        '
        Me.CVE_TAREA_BIGINT.DataPropertyName = "CVE_TAREA_BIGINT"
        Me.CVE_TAREA_BIGINT.HeaderText = "CVE"
        Me.CVE_TAREA_BIGINT.Name = "CVE_TAREA_BIGINT"
        Me.CVE_TAREA_BIGINT.ReadOnly = True
        Me.CVE_TAREA_BIGINT.Width = 50
        '
        'DESCRIPCIONVARDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONVARDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION_VAR"
        Me.DESCRIPCIONVARDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN"
        Me.DESCRIPCIONVARDataGridViewTextBoxColumn.Name = "DESCRIPCIONVARDataGridViewTextBoxColumn"
        Me.DESCRIPCIONVARDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRIPCIONVARDataGridViewTextBoxColumn.Width = 200
        '
        'DUDAS_PRESENTADAS_VAR
        '
        Me.DUDAS_PRESENTADAS_VAR.DataPropertyName = "DUDAS_PRESENTADAS_VAR"
        Me.DUDAS_PRESENTADAS_VAR.HeaderText = "DUDAS PRESENTADAS"
        Me.DUDAS_PRESENTADAS_VAR.Name = "DUDAS_PRESENTADAS_VAR"
        Me.DUDAS_PRESENTADAS_VAR.ReadOnly = True
        Me.DUDAS_PRESENTADAS_VAR.Width = 200
        '
        'RESPUESTA_A_DUDAS_VAR
        '
        Me.RESPUESTA_A_DUDAS_VAR.DataPropertyName = "RESPUESTA_A_DUDAS_VAR"
        Me.RESPUESTA_A_DUDAS_VAR.HeaderText = "RESPUESTA A DUDAS"
        Me.RESPUESTA_A_DUDAS_VAR.Name = "RESPUESTA_A_DUDAS_VAR"
        Me.RESPUESTA_A_DUDAS_VAR.ReadOnly = True
        Me.RESPUESTA_A_DUDAS_VAR.Width = 200
        '
        'FECHA_ALTA_DATE
        '
        Me.FECHA_ALTA_DATE.DataPropertyName = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.HeaderText = "FECHA ALTA"
        Me.FECHA_ALTA_DATE.Name = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.ReadOnly = True
        Me.FECHA_ALTA_DATE.Width = 70
        '
        'BtnEliminar
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.DefaultCellStyle = DataGridViewCellStyle1
        Me.BtnEliminar.HeaderText = "Eliminar"
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.ReadOnly = True
        '
        'FRMBuscarTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(893, 629)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpFechaFinal)
        Me.Controls.Add(Me.DtpFechaInicial)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DgvTareas)
        Me.Name = "FRMBuscarTareas"
        Me.Text = "Buscar Tareas"
        CType(Me.DgvTareas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TareasBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvTareas As DataGridView
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DtpFechaInicial As DateTimePicker
    Friend WithEvents DtpFechaFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TareasBL As Negocios.TareasBL
    Friend WithEvents CVE_TAREA_BIGINT As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DUDAS_PRESENTADAS_VAR As DataGridViewTextBoxColumn
    Friend WithEvents RESPUESTA_A_DUDAS_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
    Friend WithEvents BtnEliminar As DataGridViewButtonColumn
End Class
