<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBuscarProductos
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
        Me.BttoBuscar = New System.Windows.Forms.Button()
        Me.BttoRegresar = New System.Windows.Forms.Button()
        Me.DGVProductos = New System.Windows.Forms.DataGridView()
        Me.ProductosBL = New Negocios.ProductosBL()
        Me.Lbel2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.CVE_PRODUCTOS_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_PRODUCTOS_ALTA_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_PRODUCTOS_MOD_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_MOD_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO_BIT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BttoBuscar
        '
        Me.BttoBuscar.Location = New System.Drawing.Point(568, 12)
        Me.BttoBuscar.Name = "BttoBuscar"
        Me.BttoBuscar.Size = New System.Drawing.Size(107, 93)
        Me.BttoBuscar.TabIndex = 0
        Me.BttoBuscar.Text = "Buscar"
        Me.BttoBuscar.UseVisualStyleBackColor = True
        '
        'BttoRegresar
        '
        Me.BttoRegresar.Location = New System.Drawing.Point(681, 12)
        Me.BttoRegresar.Name = "BttoRegresar"
        Me.BttoRegresar.Size = New System.Drawing.Size(107, 93)
        Me.BttoRegresar.TabIndex = 1
        Me.BttoRegresar.Text = "Regresar"
        Me.BttoRegresar.UseVisualStyleBackColor = True
        '
        'DGVProductos
        '
        Me.DGVProductos.AutoGenerateColumns = False
        Me.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_PRODUCTOS_INT, Me.NOMBRE_VAR, Me.CVE_PRODUCTOS_ALTA_VAR, Me.CVE_PRODUCTOS_MOD_VAR, Me.FECHA_ALTA_DATE, Me.FECHA_MOD_DATE, Me.ACTIVO_BIT})
        Me.DGVProductos.DataSource = Me.ProductosBL.TBLPRODUCTOS
        Me.DGVProductos.Location = New System.Drawing.Point(12, 188)
        Me.DGVProductos.Name = "DGVProductos"
        Me.DGVProductos.Size = New System.Drawing.Size(776, 250)
        Me.DGVProductos.TabIndex = 2
        '
        'ProductosBL
        '
        Me.ProductosBL.DataSetName = "DSProductos"
        Me.ProductosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbel2
        '
        Me.Lbel2.AutoSize = True
        Me.Lbel2.Location = New System.Drawing.Point(425, 163)
        Me.Lbel2.Name = "Lbel2"
        Me.Lbel2.Size = New System.Drawing.Size(106, 13)
        Me.Lbel2.TabIndex = 3
        Me.Lbel2.Text = "Nombre del producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(648, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clave"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(537, 160)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(688, 160)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(100, 20)
        Me.TxtClave.TabIndex = 6
        '
        'CVE_PRODUCTOS_INT
        '
        Me.CVE_PRODUCTOS_INT.DataPropertyName = "CVE_PRODUCTOS_INT"
        Me.CVE_PRODUCTOS_INT.HeaderText = "CVE_PRODUCTOS_INT"
        Me.CVE_PRODUCTOS_INT.Name = "CVE_PRODUCTOS_INT"
        '
        'NOMBRE_VAR
        '
        Me.NOMBRE_VAR.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBRE_VAR.HeaderText = "NOMBRE_VAR"
        Me.NOMBRE_VAR.Name = "NOMBRE_VAR"
        '
        'CVE_PRODUCTOS_ALTA_VAR
        '
        Me.CVE_PRODUCTOS_ALTA_VAR.DataPropertyName = "CVE_PRODUCTOS_ALTA_VAR"
        Me.CVE_PRODUCTOS_ALTA_VAR.HeaderText = "CVE_PRODUCTOS_ALTA_VAR"
        Me.CVE_PRODUCTOS_ALTA_VAR.Name = "CVE_PRODUCTOS_ALTA_VAR"
        '
        'CVE_PRODUCTOS_MOD_VAR
        '
        Me.CVE_PRODUCTOS_MOD_VAR.DataPropertyName = "CVE_PRODUCTOS_MOD_VAR"
        Me.CVE_PRODUCTOS_MOD_VAR.HeaderText = "CVE_PRODUCTOS_MOD_VAR"
        Me.CVE_PRODUCTOS_MOD_VAR.Name = "CVE_PRODUCTOS_MOD_VAR"
        '
        'FECHA_ALTA_DATE
        '
        Me.FECHA_ALTA_DATE.DataPropertyName = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.HeaderText = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.Name = "FECHA_ALTA_DATE"
        '
        'FECHA_MOD_DATE
        '
        Me.FECHA_MOD_DATE.DataPropertyName = "FECHA_MOD_DATE"
        Me.FECHA_MOD_DATE.HeaderText = "FECHA_MOD_DATE"
        Me.FECHA_MOD_DATE.Name = "FECHA_MOD_DATE"
        '
        'ACTIVO_BIT
        '
        Me.ACTIVO_BIT.DataPropertyName = "ACTIVO_BIT"
        Me.ACTIVO_BIT.HeaderText = "ACTIVO_BIT"
        Me.ACTIVO_BIT.Name = "ACTIVO_BIT"
        '
        'FRMBuscarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbel2)
        Me.Controls.Add(Me.DGVProductos)
        Me.Controls.Add(Me.BttoRegresar)
        Me.Controls.Add(Me.BttoBuscar)
        Me.Name = "FRMBuscarProductos"
        Me.Text = "FRMBuscarProductos"
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BttoBuscar As Button
    Friend WithEvents BttoRegresar As Button
    Friend WithEvents DGVProductos As DataGridView
    Friend WithEvents ProductosBL As Negocios.ProductosBL
    Friend WithEvents Lbel2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents CVE_PRODUCTOS_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents CVE_PRODUCTOS_ALTA_VAR As DataGridViewTextBoxColumn
    Friend WithEvents CVE_PRODUCTOS_MOD_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_MOD_DATE As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO_BIT As DataGridViewCheckBoxColumn
End Class
