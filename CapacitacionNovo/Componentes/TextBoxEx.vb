Public Class TextBoxEx
    Inherits System.Windows.Forms.TextBox
    'Inherits System.ComponentModel.DescriptionAttribute
    Protected caracteres() As Char
    Private _TipoDato As Enumeraciones.TipoDatos
    Private _libre As Boolean = False
    Private _negacion As Boolean = False

    ''' <summary>
    ''' Especifica el tipo de dato que acepta el control correspondiente
    ''' </summary>
    ''' <remarks></remarks>
    <System.ComponentModel.Description("Especifica el tipo de dato que acepta el control correspondiente")> _
        Public Overridable Property TipoDato() As Enumeraciones.TipoDatos

        Get
            Return _TipoDato
        End Get
        Set(ByVal value As Enumeraciones.TipoDatos)

            Dim str As String = ""
            _TipoDato = value
            _libre = False
            _negacion = False

            Select Case _TipoDato

                Case Enumeraciones.TipoDatos.Entero
                    str = "0123456789"
                Case Enumeraciones.TipoDatos.Moneda
                    str = "0123456789.,"
                Case Enumeraciones.TipoDatos.MonedaNEGATIVOS
                    str = "0123456789.,-"
                Case Enumeraciones.TipoDatos.Moneda4decimales
                    str = "0123456789.,"
                Case Enumeraciones.TipoDatos.Libre
                    _libre = True
                Case Enumeraciones.TipoDatos.Texto
                    str = "0123456789"
                    _negacion = True
                Case Enumeraciones.TipoDatos.Entero_Formateado
                    str = "0123456789,"
            End Select
            If _negacion Then
                caracteres = (str).ToCharArray
            Else
                caracteres = (str & Chr(8)).ToCharArray
            End If

        End Set

    End Property

    Public Overrides Property Text() As String
        Get
            'If Me._TipoDato = Enumeraciones.TipoDatos.Moneda Then
            '    Return MyBase.Text.Replace(",", "").Replace(".", "")
            'Else
            Return MyBase.Text
            'End If
        End Get
        Set(ByVal value As String)

            If value Is Nothing Then
                MyBase.Text = value
                Exit Property
            End If

            Dim sb As New Text.StringBuilder

            For Each caracter As Char In value
                If ValidarTecla(caracter) Then
                    sb.Append(caracter)
                End If
            Next


            'If Me._TipoDato = Enumeraciones.TipoDatos.Entero Then
            '    MyBase.Text = FormatCurrency(Integer.Parse(IIf(Me.Text <> "", Me.Text, "0")), 0, , , ).Substring(1)
            'End If


            If _TipoDato = Enumeraciones.TipoDatos.Moneda Then
                MyBase.Text = FormatCurrency(Double.Parse(IIf(sb.ToString <> "", sb.ToString, "0")), 2, , , ).Substring(1)
                'MyBase.Text = String.Format("C:2", sb.ToString)
            ElseIf _TipoDato = Enumeraciones.TipoDatos.MonedaNEGATIVOS Then
                MyBase.Text = FormatCurrency(Double.Parse(IIf(sb.ToString <> "", sb.ToString, "0")), 2, , , ).Substring(1)
            ElseIf _TipoDato = Enumeraciones.TipoDatos.Moneda4decimales Then
                MyBase.Text = FormatCurrency(Double.Parse(IIf(sb.ToString <> "", sb.ToString, "0")), 4, , , ).Substring(1)
            Else
                MyBase.Text = sb.ToString
            End If
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        TipoDato = Enumeraciones.TipoDatos.Libre
        CharacterCasing = Windows.Forms.CharacterCasing.Upper
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If ValidarTecla(e.KeyChar) = False Then
            e.Handled = True
        Else
            If e.KeyChar = "." And TipoDato = Enumeraciones.TipoDatos.Moneda Then
                e.Handled = (InStr(Me.Text, ".") > 0)
            End If

            If e.KeyChar = "." And TipoDato = Enumeraciones.TipoDatos.Moneda4decimales Then
                e.Handled = (InStr(Me.Text, ".") > 0)
            End If
        End If

        MyBase.OnKeyPress(e)

    End Sub

    

    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        MyBase.SelectAll()
        MyBase.OnGotFocus(e)
    End Sub


    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)

        If Me._TipoDato = Enumeraciones.TipoDatos.Moneda Then
            If Me.Text.IndexOf(",") = 0 Then
                Me.Text = Me.Text.Substring(1)
            End If
        End If

        If Me._TipoDato = Enumeraciones.TipoDatos.Moneda4decimales Then
            If Me.Text.IndexOf(",") = 0 Then
                Me.Text = Me.Text.Substring(1)
            End If
        End If

        If Me._TipoDato = Enumeraciones.TipoDatos.MonedaNEGATIVOS Then
            If Me.Text.IndexOf(",") = 0 Then
                Me.Text = Me.Text.Substring(1)
            End If
        End If

        If Me._TipoDato = Enumeraciones.TipoDatos.Entero_Formateado Then
            If Me.Text.IndexOf(",") = 0 Then
                Me.Text = Me.Text.Substring(1)
            End If
            '    MyBase.Text = FormatCurrency(Double.Parse(IIf(Me.Text <> "", Me.Text, "0")), 0, , , ).Substring(1)
        End If

        If Me._TipoDato = Enumeraciones.TipoDatos.Entero Then
            If Me.Text.IndexOf(",") = 0 Then
                Me.Text = Me.Text.Substring(1)
            End If
            'MyBase.Text = FormatCurrency(Double.Parse(IIf(Me.Text <> "", Me.Text, "0")), 0, , , ).Substring(1)
        End If

        MyBase.OnTextChanged(e)
    End Sub

    Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)
        MyBase.OnLeave(e)
        If Me._TipoDato = Enumeraciones.TipoDatos.Entero Then
            If MyBase.Text = "" Then
                MyBase.Text = 0
            End If
        End If

        If Me._TipoDato = Enumeraciones.TipoDatos.Entero_Formateado Then
            MyBase.Text = FormatCurrency(Double.Parse(IIf(Me.Text <> "", Me.Text, "0")), 0, , , ).Substring(1)
            If MyBase.Text = "" Then
                MyBase.Text = 0
            End If
End If

        If Me._TipoDato = Enumeraciones.TipoDatos.Moneda Then
            MyBase.Text = FormatCurrency(Double.Parse(IIf(Me.Text <> "", Me.Text.Replace(",", ""), "0")), 2, , , ).Substring(1)
        End If

        If Me._TipoDato = Enumeraciones.TipoDatos.MonedaNEGATIVOS Then
            MyBase.Text = FormatCurrency(Double.Parse(IIf(Me.Text <> "", Me.Text.Replace(",", ""), "0")), 2, , , ).Substring(1)
        End If

        If Me._TipoDato = Enumeraciones.TipoDatos.Moneda4decimales Then
            MyBase.Text = FormatCurrency(Double.Parse(IIf(Me.Text <> "", Me.Text.Replace(",", ""), "0")), 4, , , ).Substring(1)
        End If
    End Sub

    Public ReadOnly Property TextCurrencyWithoutFormat() As String
        Get
            If Me._TipoDato = Enumeraciones.TipoDatos.Moneda Or Me._TipoDato = Enumeraciones.TipoDatos.Moneda4decimales Then
                Return Me.Text.Replace(",", "").Replace(".", "")
            Else
                Return Me.Text
            End If
        End Get
    End Property

    Private Function ValidarTecla(ByVal caracter As Char) As Boolean

        If _libre Then
            Return True
        End If

        If Array.IndexOf(caracteres, caracter) > -1 Then
            Return Not _negacion
        Else
            Return _negacion
        End If

    End Function

End Class

    Public Class Enumeraciones

    Public Enum TipoDatos
        ''' <summary>
        ''' Tipo de dato que solo permite ingresar caracteres nuemericos
        ''' </summary>
        Entero = 1
        ''' <summary>
        ''' Tipo de dato que solo permite ingresar caracteres nuemericos 
        ''' y es decimal de 2 espacios
        ''' </summary>
        Moneda = 2
        ''' <summary>
        ''' Tipo de dato que permite ingresar calquier tipo de caracteres
        ''' </summary>
        Libre = 3
        ''' <summary>
        ''' Tipo de dato que solo permite ingresar caracteres alfabeticos
        ''' </summary>
        Texto = 4
        ''' <summary>
        ''' Tipo de dato que solo permite ingresar caracteres numericos y les proporciona 
        ''' formato separado por comas cada 3 digitos
        ''' </summary>
        Entero_Formateado = 5
        ''' <summary>
        ''' Tipo de dato que solo permite ingresar caracteres nuemericos 
        ''' y es decimal de 4 espacios
        ''' </summary>
        Moneda4decimales = 6
        MonedaNEGATIVOS = 7
    End Enum

    End Class

