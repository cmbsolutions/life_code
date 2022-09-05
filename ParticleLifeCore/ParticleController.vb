Imports System.ComponentModel

Public Class ParticleController
    <EditorBrowsable>
    Public Property Title As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
        End Set
    End Property

    Private _ParticleColor As pColor
    <EditorBrowsable>
    Public Property ParticleColor As pColor
        Get
            Return _ParticleColor
        End Get
        Set(value As pColor)
            _ParticleColor = value
            For Each ctrl In Controls
                Dim t As tracker = TryCast(ctrl, tracker)

                If t IsNot Nothing Then
                    t.Title = t.Tag.ToString.Replace("{color}", value.ToString)
                    t.Title = t.Tag.ToString.Replace("{c}", value.ToString.ToLower.Substring(0, 1))
                End If
            Next
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            ' Turn on WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

    Public Enum pColor
        Red
        Green
        Blue
        White
    End Enum
End Class

