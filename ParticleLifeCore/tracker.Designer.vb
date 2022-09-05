<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tracker
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bar = New System.Windows.Forms.Panel()
        Me.tValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bar
        '
        Me.bar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bar.BackColor = System.Drawing.Color.Transparent
        Me.bar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bar.Location = New System.Drawing.Point(0, 0)
        Me.bar.Margin = New System.Windows.Forms.Padding(0)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(128, 16)
        Me.bar.TabIndex = 0
        '
        'tValue
        '
        Me.tValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tValue.Dock = System.Windows.Forms.DockStyle.Right
        Me.tValue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tValue.Location = New System.Drawing.Point(128, 0)
        Me.tValue.Margin = New System.Windows.Forms.Padding(0)
        Me.tValue.MaxLength = 6
        Me.tValue.Name = "tValue"
        Me.tValue.Size = New System.Drawing.Size(50, 15)
        Me.tValue.TabIndex = 1
        Me.tValue.Text = "1000"
        Me.tValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tracker
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.bar)
        Me.Controls.Add(Me.tValue)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(25, 16)
        Me.Name = "tracker"
        Me.Size = New System.Drawing.Size(178, 16)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bar As Panel
    Friend WithEvents tValue As TextBox
End Class
