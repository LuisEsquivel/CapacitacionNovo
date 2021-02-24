<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMTareas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRespuestaADudas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDudasPresentadas = New System.Windows.Forms.TextBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Clave = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DgvTareas = New System.Windows.Forms.DataGridView()
        Me.TareasBL = New Negocios.TareasBL()
        Me.CVE_TAREA_BIGINT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUDAS_PRESENTADAS_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESPUESTA_A_DUDAS_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TareasBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpFechaAlta
        '
        Me.DtpFechaAlta.Enabled = False
        Me.DtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaAlta.Location = New System.Drawing.Point(786, 118)
        Me.DtpFechaAlta.Name = "DtpFechaAlta"
        Me.DtpFechaAlta.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaAlta.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtRespuestaADudas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtDudasPresentadas)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 236)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Descripción (obligatorio)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, -16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nombre "
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(6, 19)
        Me.TxtDescripcion.MaxLength = 150
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(858, 51)
        Me.TxtDescripcion.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Respuesta a dudas (opcional)"
        '
        'TxtRespuestaADudas
        '
        Me.TxtRespuestaADudas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRespuestaADudas.Enabled = False
        Me.TxtRespuestaADudas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRespuestaADudas.Location = New System.Drawing.Point(6, 177)
        Me.TxtRespuestaADudas.MaxLength = 150
        Me.TxtRespuestaADudas.Multiline = True
        Me.TxtRespuestaADudas.Name = "TxtRespuestaADudas"
        Me.TxtRespuestaADudas.Size = New System.Drawing.Size(858, 51)
        Me.TxtRespuestaADudas.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Dudas que se presentaron al llevar a cabo la tarea (opcional)"
        '
        'TxtDudasPresentadas
        '
        Me.TxtDudasPresentadas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDudasPresentadas.Enabled = False
        Me.TxtDudasPresentadas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDudasPresentadas.Location = New System.Drawing.Point(6, 97)
        Me.TxtDudasPresentadas.MaxLength = 150
        Me.TxtDudasPresentadas.Multiline = True
        Me.TxtDudasPresentadas.Name = "TxtDudasPresentadas"
        Me.TxtDudasPresentadas.Size = New System.Drawing.Size(858, 51)
        Me.TxtDudasPresentadas.TabIndex = 22
        '
        'TxtClave
        '
        Me.TxtClave.Enabled = False
        Me.TxtClave.Location = New System.Drawing.Point(63, 113)
        Me.TxtClave.MaxLength = 15
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(154, 20)
        Me.TxtClave.TabIndex = 14
        '
        'Clave
        '
        Me.Clave.AutoSize = True
        Me.Clave.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clave.Location = New System.Drawing.Point(20, 114)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(43, 20)
        Me.Clave.TabIndex = 9
        Me.Clave.Text = "Clave"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(436, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 83)
        Me.BtnNuevo.TabIndex = 24
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(511, 12)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 83)
        Me.BtnModificar.TabIndex = 23
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(587, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 83)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(734, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 83)
        Me.BtnCancelar.TabIndex = 21
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(809, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 83)
        Me.BtnSalir.TabIndex = 20
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(661, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 83)
        Me.BtnBuscar.TabIndex = 29
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DgvTareas
        '
        Me.DgvTareas.AllowUserToAddRows = False
        Me.DgvTareas.AllowUserToDeleteRows = False
        Me.DgvTareas.AutoGenerateColumns = False
        Me.DgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTareas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_TAREA_BIGINT, Me.DESCRIPCION_VAR, Me.DUDAS_PRESENTADAS_VAR, Me.RESPUESTA_A_DUDAS_VAR, Me.FECHA_ALTA_DATE, Me.BtnEliminar})
        Me.DgvTareas.DataSource = Me.TareasBL.TBLTAREAS
        Me.DgvTareas.Location = New System.Drawing.Point(14, 387)
        Me.DgvTareas.Name = "DgvTareas"
        Me.DgvTareas.ReadOnly = True
        Me.DgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTareas.Size = New System.Drawing.Size(870, 324)
        Me.DgvTareas.TabIndex = 28
        '
        'TareasBL
        '
        Me.TareasBL.DataSetName = "DSTareas"
        Me.TareasBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_TAREA_BIGINT
        '
        Me.CVE_TAREA_BIGINT.DataPropertyName = "CVE_TAREA_BIGINT"
        Me.CVE_TAREA_BIGINT.HeaderText = "CVE"
        Me.CVE_TAREA_BIGINT.Name = "CVE_TAREA_BIGINT"
        Me.CVE_TAREA_BIGINT.ReadOnly = True
        Me.CVE_TAREA_BIGINT.Width = 50
        '
        'DESCRIPCION_VAR
        '
        Me.DESCRIPCION_VAR.DataPropertyName = "DESCRIPCION_VAR"
        Me.DESCRIPCION_VAR.HeaderText = "DESCRIPCIÓN"
        Me.DESCRIPCION_VAR.Name = "DESCRIPCION_VAR"
        Me.DESCRIPCION_VAR.ReadOnly = True
        Me.DESCRIPCION_VAR.Width = 200
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
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FECHA_ALTA_DATE.DefaultCellStyle = DataGridViewCellStyle3
        Me.FECHA_ALTA_DATE.HeaderText = "FECHA ALTA"
        Me.FECHA_ALTA_DATE.Name = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.ReadOnly = True
        Me.FECHA_ALTA_DATE.Width = 70
        '
        'BtnEliminar
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.DefaultCellStyle = DataGridViewCellStyle4
        Me.BtnEliminar.HeaderText = "Eliminar"
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.ReadOnly = True
        Me.BtnEliminar.Text = "Eliminar"
        '
        'FRMTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(897, 720)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DgvTareas)
        Me.Controls.Add(Me.DtpFechaAlta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.Clave)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FRMTareas"
        Me.Text = "Tareas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvTareas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TareasBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtpFechaAlta As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Clave As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DgvTareas As DataGridView
    Friend WithEvents TareasBL As Negocios.TareasBL
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDudasPresentadas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRespuestaADudas As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents CVE_TAREA_BIGINT As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION_VAR As DataGridViewTextBoxColumn
    Friend WithEvents DUDAS_PRESENTADAS_VAR As DataGridViewTextBoxColumn
    Friend WithEvents RESPUESTA_A_DUDAS_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
    Friend WithEvents BtnEliminar As DataGridViewButtonColumn
End Class
