<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBuscarClientes
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
        Me.DgvClientes = New System.Windows.Forms.DataGridView()
        Me.ClientesBL = New Negocios.ClientesBL()
        Me.CVE_CLIENTE_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO_BIT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvClientes
        '
        Me.DgvClientes.AllowUserToAddRows = False
        Me.DgvClientes.AllowUserToDeleteRows = False
        Me.DgvClientes.AutoGenerateColumns = False
        Me.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_CLIENTE_INT, Me.NOMBRE_VAR, Me.ACTIVO_BIT})
        Me.DgvClientes.DataSource = Me.ClientesBL.TBLCLIENTES
        Me.DgvClientes.Location = New System.Drawing.Point(12, 140)
        Me.DgvClientes.Name = "DgvClientes"
        Me.DgvClientes.ReadOnly = True
        Me.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvClientes.Size = New System.Drawing.Size(552, 406)
        Me.DgvClientes.TabIndex = 0
        '
        'ClientesBL
        '
        Me.ClientesBL.DataSetName = "DsClientes"
        Me.ClientesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_CLIENTE_INT
        '
        Me.CVE_CLIENTE_INT.DataPropertyName = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.HeaderText = "CVE CLEINTE"
        Me.CVE_CLIENTE_INT.Name = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.ReadOnly = True
        '
        'NOMBRE_VAR
        '
        Me.NOMBRE_VAR.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBRE_VAR.HeaderText = "NOMBRE"
        Me.NOMBRE_VAR.Name = "NOMBRE_VAR"
        Me.NOMBRE_VAR.ReadOnly = True
        Me.NOMBRE_VAR.Width = 300
        '
        'ACTIVO_BIT
        '
        Me.ACTIVO_BIT.DataPropertyName = "ACTIVO_BIT"
        Me.ACTIVO_BIT.HeaderText = "ACTIVO"
        Me.ACTIVO_BIT.Name = "ACTIVO_BIT"
        Me.ACTIVO_BIT.ReadOnly = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(445, 21)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(119, 88)
        Me.BtnRegresar.TabIndex = 8
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(324, 21)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(115, 88)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FRMBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 558)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DgvClientes)
        Me.Name = "FRMBuscarClientes"
        Me.Text = "Búsqueda De Clientes"
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvClientes As DataGridView
    Friend WithEvents ClientesBL As Negocios.ClientesBL
    Friend WithEvents CVE_CLIENTE_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO_BIT As DataGridViewCheckBoxColumn
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnBuscar As Button
End Class
