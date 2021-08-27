<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBuscarRoles
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
        Me.BtoRegresar = New System.Windows.Forms.Button()
        Me.BtoBuscar = New System.Windows.Forms.Button()
        Me.DGVRoles = New System.Windows.Forms.DataGridView()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RolesBL = New Negocios.RolesBL()
        Me.DsRoles1 = New Estructuras.DsRoles()
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRoles1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtoRegresar
        '
        Me.BtoRegresar.Location = New System.Drawing.Point(672, 12)
        Me.BtoRegresar.Name = "BtoRegresar"
        Me.BtoRegresar.Size = New System.Drawing.Size(116, 97)
        Me.BtoRegresar.TabIndex = 0
        Me.BtoRegresar.Text = "Regresar"
        Me.BtoRegresar.UseVisualStyleBackColor = True
        '
        'BtoBuscar
        '
        Me.BtoBuscar.Location = New System.Drawing.Point(550, 12)
        Me.BtoBuscar.Name = "BtoBuscar"
        Me.BtoBuscar.Size = New System.Drawing.Size(116, 97)
        Me.BtoBuscar.TabIndex = 1
        Me.BtoBuscar.Text = "Buscar"
        Me.BtoBuscar.UseVisualStyleBackColor = True
        '
        'DGVRoles
        '
        Me.DGVRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRoles.Location = New System.Drawing.Point(12, 154)
        Me.DGVRoles.Name = "DGVRoles"
        Me.DGVRoles.Size = New System.Drawing.Size(776, 284)
        Me.DGVRoles.TabIndex = 2
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(687, 128)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(100, 20)
        Me.txbNombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(642, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(637, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'RolesBL
        '
        Me.RolesBL.DataSetName = "DsRoles"
        Me.RolesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsRoles1
        '
        Me.DsRoles1.DataSetName = "DsRoles"
        Me.DsRoles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMBuscarRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.DGVRoles)
        Me.Controls.Add(Me.BtoBuscar)
        Me.Controls.Add(Me.BtoRegresar)
        Me.Name = "FRMBuscarRoles"
        Me.Text = "FRMBuscarRoles"
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRoles1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtoRegresar As Button
    Friend WithEvents BtoBuscar As Button
    Friend WithEvents DGVRoles As DataGridView
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RolesBL As Negocios.RolesBL
    Friend WithEvents DsRoles1 As Estructuras.DsRoles
End Class
