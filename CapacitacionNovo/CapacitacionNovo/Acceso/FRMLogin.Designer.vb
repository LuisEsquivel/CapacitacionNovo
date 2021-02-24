<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMLogin
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
        Me.TxtUsuario = New Componentes.TextBoxEx()
        Me.TxtContraseña = New Componentes.TextBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.EmpleadosBL = New Negocios.EmpleadosBL()
        CType(Me.EmpleadosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUsuario
        '
        Me.TxtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUsuario.Location = New System.Drawing.Point(12, 63)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(235, 20)
        Me.TxtUsuario.TabIndex = 0
        Me.TxtUsuario.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'TxtContraseña
        '
        Me.TxtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtContraseña.Location = New System.Drawing.Point(12, 124)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(235, 20)
        Me.TxtContraseña.TabIndex = 1
        Me.TxtContraseña.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(368, 56)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(119, 88)
        Me.BtnSalir.TabIndex = 33
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnIniciar
        '
        Me.BtnIniciar.Location = New System.Drawing.Point(251, 56)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(115, 88)
        Me.BtnIniciar.TabIndex = 32
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = True
        '
        'EmpleadosBL
        '
        Me.EmpleadosBL.DataSetName = "DsEmpleados"
        Me.EmpleadosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 165)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Name = "FRMLogin"
        Me.Text = "Login"
        CType(Me.EmpleadosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsuario As Componentes.TextBoxEx
    Friend WithEvents TxtContraseña As Componentes.TextBoxEx
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents EmpleadosBL As Negocios.EmpleadosBL
End Class
