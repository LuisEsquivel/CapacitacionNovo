Public Class CeldaPersonalizada
    Inherits DataGridViewTextBoxCell

    ' propiedades 
    Public Overrides ReadOnly Property EditType() As System.Type
        Get
            Return GetType(EditorValorCelda)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As System.Type
        Get
            Return GetType(Date)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            Return Date.Now
        End Get
    End Property

    ' métodos 
    Public Sub New()
        '.... 
    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, _
         ByVal initialFormattedValue As Object, _
         ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim ctlEditorValorCelda As EditorValorCelda = CType(DataGridView.EditingControl, EditorValorCelda)
        Dim colColumnaPersonalizada As ColumnaPersonalizada = CType(Me.OwningColumn, ColumnaPersonalizada)

        ctlEditorValorCelda.Mask = colColumnaPersonalizada.Mascara
        ctlEditorValorCelda.Text = initialFormattedValue
    End Sub
End Class
