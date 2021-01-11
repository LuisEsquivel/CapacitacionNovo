Public Class ColumnaPersonalizada
    Inherits DataGridViewColumn

    Private msMascara As String

    ' propiedades 
    Public Overrides Property CellTemplate() As System.Windows.Forms.DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As System.Windows.Forms.DataGridViewCell)
            MyBase.CellTemplate = value
        End Set
    End Property

    Public Property Mascara() As String
        Get
            Return msMascara
        End Get
        Set(ByVal value As String)
            msMascara = value
        End Set
    End Property

    'métodos 
    Public Sub New()
        MyBase.New(New CeldaPersonalizada())
    End Sub
End Class
