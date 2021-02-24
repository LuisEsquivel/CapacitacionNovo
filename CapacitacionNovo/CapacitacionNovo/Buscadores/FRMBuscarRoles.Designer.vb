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
        Me.RolesBL = New Negocios.RolesBL()
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RolesBL
        '
        Me.RolesBL.DataSetName = "DsRoles"
        Me.RolesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMBuscarRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGVRoles)
        Me.Controls.Add(Me.BtoBuscar)
        Me.Controls.Add(Me.BtoRegresar)
        Me.Name = "FRMBuscarRoles"
        Me.Text = "FRMBuscarRoles"
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtoRegresar As Button
    Friend WithEvents BtoBuscar As Button
    Friend WithEvents DGVRoles As DataGridView
    Friend WithEvents RolesBL As Negocios.RolesBL
End Class
