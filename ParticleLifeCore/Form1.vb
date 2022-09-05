Imports System.Numerics

Public Class Form1
    Private showModel As Boolean = True

    Private _xshift As Integer = 40
    Private _yshift As Integer = 50
    Private _anchor As Integer = 0
    Private _length As Integer = 100
    Private _p1x As Integer = _anchor + _xshift
    Private _p1y As Integer = _anchor + _yshift
    Private _p2x As Integer = _anchor + _length + _xshift
    Private _p2y As Integer = _anchor + _yshift
    Private _p3x As Integer = _anchor + _length + _xshift
    Private _p3y As Integer = _anchor + _length + _yshift
    Private _p4x As Integer = _anchor + _xshift
    Private _p4y As Integer = _anchor + _length + _yshift
    Private _rr As Integer = 15
    Private _countThresh As Integer = 0

    Private _red As Vector(Of Point)
    Private _green As Vector(Of Point)
    Private _blue As Vector(Of Point)
    Private _white As Vector(Of Point)

    Private Sub ShowModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowModelToolStripMenuItem.Click
        showModel = ShowModelToolStripMenuItem.Checked
        Draw()
    End Sub

    Private Sub Draw()
        Using g = canvas.CreateGraphics
            g.CompositingMode = Drawing2D.CompositingMode.SourceOver
            g.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
            g.InterpolationMode = Drawing2D.InterpolationMode.High
            g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
            g.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed

            g.Clear(canvas.BackColor)

            If showModel Then
                Dim p As New Pen(New SolidBrush(Color.Black), 5)

                g.DrawEllipse(p, New Rectangle(_xshift, _yshift, 150, 150))

                p.Color = Color.FromArgb(150 - pcGreen.txred.Value, 150 + pcGreen.txred.Value, 150)
                g.DrawLine(p, _p1x, _p1y - 10, _p2x, _p2y - 10)
                p.Color = Color.FromArgb(150 - pcRed.txgreen.Value, 150 + pcRed.txgreen.Value, 150)
                g.DrawLine(p, _p1x, _p1y + 10, _p2x, _p2y + 10)
                p.Color = Color.FromArgb(150 - pcGreen.txwhite.Value, 150 + pcGreen.txwhite.Value, 150)
                g.DrawLine(p, _p3x, _p3y - 10, _p1x, _p1y - 10)
                p.Color = Color.FromArgb(150 - pcWhite.txgreen.Value, 150 + pcWhite.txgreen.Value, 150)
                g.DrawLine(p, _p3x, _p3y + 10, _p1x, _p1y + 10)

                p.Color = Color.FromArgb(150 - pcGreen.txblue.Value, 150 + pcGreen.txblue.Value, 150)
                g.DrawLine(p, _p4x - 10, _p4y, _p1x - 10, _p1y)
                p.Color = Color.FromArgb(150 - pcBlue.txgreen.Value, 150 + pcBlue.txgreen.Value, 150)
                g.DrawLine(p, _p4x + 10, _p4y, _p1x + 10, _p1y)

                p.Color = Color.FromArgb(150 - pcRed.txwhite.Value, 150 + pcRed.txwhite.Value, 150)
                g.DrawLine(p, _p2x - 10, _p2y, _p3x - 10, _p3y)
                p.Color = Color.FromArgb(150 - pcWhite.txred.Value, 150 + pcWhite.txred.Value, 150)
                g.DrawLine(p, _p2x + 10, _p2y, _p3x + 10, _p3y)

                p.Color = Color.FromArgb(150 - pcRed.txblue.Value, 150 + pcRed.txblue.Value, 150)
                g.DrawLine(p, _p2x, _p2y - 10, _p4x, _p4y - 10)
                p.Color = Color.FromArgb(150 - pcBlue.txred.Value, 150 + pcBlue.txred.Value, 150)
                g.DrawLine(p, _p2x, _p2y + 10, _p4x, _p4y + 10)

                p.Color = Color.FromArgb(150 - pcWhite.txblue.Value, 150 + pcWhite.txblue.Value, 150)
                g.DrawLine(p, _p3x, _p3y - 10, _p4x, _p4y - 10)
                p.Color = Color.FromArgb(150 - pcBlue.txwhite.Value, 150 + pcBlue.txwhite.Value, 150)
                g.DrawLine(p, _p3x, _p3y + 10, _p4x, _p4y + 10)

                p.Color = Color.FromArgb(150 - pcGreen.txgreen.Value, 150 + pcGreen.txgreen.Value, 150)
                g.DrawEllipse(p, New RectangleF(CSng(_p1x - 2.5), CSng(_p1y - 2.5), _rr + 20, _rr + 20))
                p.Color = Color.FromArgb(150 - pcRed.txred.Value, 150 + pcRed.txred.Value, 150)
                g.DrawEllipse(p, New Rectangle(_p2x, _p2y, _rr + 20, _rr + 20))
                p.Color = Color.FromArgb(150 - pcWhite.txwhite.Value, 150 + pcWhite.txwhite.Value, 150)
                g.DrawEllipse(p, New Rectangle(_p3x, _p3y, _rr + 20, _rr + 20))
                p.Color = Color.FromArgb(150 - pcBlue.txblue.Value, 150 + pcBlue.txblue.Value, 150)
                g.DrawEllipse(p, New Rectangle(_p4x, _p4y, _rr + 20, _rr + 20))

                Dim b As New SolidBrush(Color.Black)

                b.Color = Color.FromArgb(100, 250, 10)
                g.FillEllipse(b, New Rectangle(_p1x, _p1y, _rr * 2, _rr * 2))
                b.Color = Color.FromArgb(250, 10, 100)
                g.FillEllipse(b, New Rectangle(_p2x, _p2y, _rr * 2, _rr * 2))
                b.Color = Color.FromArgb(250, 250, 250)
                g.FillEllipse(b, New Rectangle(_p3x, _p3y, _rr * 2, _rr * 2))
                b.Color = Color.FromArgb(100, 100, 250)
                g.FillEllipse(b, New Rectangle(_p4x, _p4y, _rr * 2, _rr * 2))
            End If

        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Draw()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Draw()
    End Sub
End Class
