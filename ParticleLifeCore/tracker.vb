Imports System.ComponentModel

Public Class tracker

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            ' Turn on WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

    Private _Title As String
    <EditorBrowsable>
    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property

    Private _MinimumValue As Integer = 0
    <EditorBrowsable>
    Public Property MinimumValue As Integer
        Get
            Return _MinimumValue
        End Get
        Set(value As Integer)
            _MinimumValue = Math.Max(Math.Min(value, 10000), -10000)
        End Set
    End Property

    Private _MaximumValue As Integer = 100
    <EditorBrowsable>
    Public Property MaximumValue As Integer
        Get
            Return _MaximumValue
        End Get
        Set(value As Integer)
            _MaximumValue = Math.Max(Math.Min(value, 10000), -10000)
        End Set
    End Property

    Private _Value As Integer = 20
    <EditorBrowsable>
    Public Property Value As Integer
        Get
            Return _Value
        End Get
        Set(value As Integer)
            _Value = Math.Max(Math.Min(value, _MaximumValue), _MinimumValue)
        End Set
    End Property

    Private x As Integer
    Private dragging As Boolean = False

    Private Sub DrawBar()
        Using g = bar.CreateGraphics
            Dim actualValue As Integer = Math.Abs(MinimumValue) + Value
            Dim steps = bar.Width / (MaximumValue - MinimumValue)
            Dim maxX = CSng(steps * actualValue)
            g.Clear(Color.FromKnownColor(KnownColor.Transparent))
            g.FillRectangle(New SolidBrush(Color.SteelBlue), New RectangleF(0, 0, maxX, bar.Height))

            g.DrawString(Title, Me.Font, New SolidBrush(Color.FromKnownColor(KnownColor.WhiteSmoke)), New PointF(2, 0))
        End Using

        tValue.Text = Value.ToString
    End Sub

    Private Sub tracker_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawBar()
    End Sub

    Private Sub bar_MouseDown(sender As Object, e As MouseEventArgs) Handles bar.MouseDown
        If e.Button = MouseButtons.Left AndAlso Not dragging Then
            dragging = True
            x = e.X

            Value = map(x, 0, bar.Width, _MinimumValue, _MaximumValue)
            DrawBar()
        End If
    End Sub

    Private Sub bar_MouseMove(sender As Object, e As MouseEventArgs) Handles bar.MouseMove
        If e.Button = MouseButtons.Left AndAlso dragging Then
            If e.X >= 0 AndAlso e.X <= bar.Width Then
                Value = map(e.X, 0, bar.Width, _MinimumValue, _MaximumValue)
                DrawBar()
            End If
        End If
    End Sub

    Private Sub bar_MouseUp(sender As Object, e As MouseEventArgs) Handles bar.MouseUp
        If e.Button = MouseButtons.Left AndAlso dragging Then
            dragging = False
        End If
    End Sub

    Private Function map(p As Integer, in_min As Integer, in_max As Integer, out_min As Integer, out_max As Integer) As Integer
        Return CInt((p - in_min) * (out_max - out_min) / (in_max - in_min) + out_min)
    End Function

    Private Sub tValue_KeyDown(sender As Object, e As KeyEventArgs) Handles tValue.KeyDown
        Select Case e.KeyCode
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Delete, Keys.Back, Keys.OemMinus, Keys.Subtract, Keys.NumPad0, Keys.NumPad1,
                 Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.Left, Keys.Right, Keys.Tab, Keys.Enter, Keys.Return
                e.SuppressKeyPress = False
            Case Else
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub tValue_Validating(sender As Object, e As CancelEventArgs) Handles tValue.Validating
        Dim intvalue As Integer
        If Integer.TryParse(tValue.Text.ToString, intvalue) Then
            If intvalue >= MinimumValue AndAlso intvalue <= MaximumValue Then
                Value = intvalue
                tValue.ForeColor = Color.Black
                DrawBar()
            Else
                tValue.ForeColor = Color.Red
            End If
        End If
    End Sub
End Class
