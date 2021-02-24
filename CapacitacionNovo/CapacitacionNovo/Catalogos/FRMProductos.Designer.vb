<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMProductos
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
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Clave = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(300, 183)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombre"
        '
        'Clave
        '
        Me.Clave.AutoSize = True
        Me.Clave.Location = New System.Drawing.Point(300, 207)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(34, 13)
        Me.Clave.TabIndex = 1
        Me.Clave.Text = "Clave"
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(358, 202)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(100, 20)
        Me.TxtClave.TabIndex = 2
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(358, 176)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'FRMProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.Clave)
        Me.Controls.Add(Me.Nombre)
        Me.Name = "FRMProductos"
        Me.Text = "FRMProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nombre As Label
    Friend WithEvents Clave As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents TxtNombre As TextBox
End Class
