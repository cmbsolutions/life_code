<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pcRed = New ParticleLifeCore.ParticleController()
        Me.pcGreen = New ParticleLifeCore.ParticleController()
        Me.pcBlue = New ParticleLifeCore.ParticleController()
        Me.pcWhite = New ParticleLifeCore.ParticleController()
        Me.canvas = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.canvas)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 737)
        Me.SplitContainer1.SplitterDistance = 175
        Me.SplitContainer1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.pcRed)
        Me.FlowLayoutPanel1.Controls.Add(Me.pcGreen)
        Me.FlowLayoutPanel1.Controls.Add(Me.pcBlue)
        Me.FlowLayoutPanel1.Controls.Add(Me.pcWhite)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(175, 737)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'pcRed
        '
        Me.pcRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pcRed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pcRed.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.pcRed.Location = New System.Drawing.Point(0, 0)
        Me.pcRed.Margin = New System.Windows.Forms.Padding(0)
        Me.pcRed.MaximumSize = New System.Drawing.Size(167, 169)
        Me.pcRed.MinimumSize = New System.Drawing.Size(167, 169)
        Me.pcRed.Name = "pcRed"
        Me.pcRed.ParticleColor = ParticleLifeCore.ParticleController.pColor.Red
        Me.pcRed.Size = New System.Drawing.Size(167, 169)
        Me.pcRed.TabIndex = 1
        Me.pcRed.Title = "Red"
        '
        'pcGreen
        '
        Me.pcGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pcGreen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pcGreen.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.pcGreen.Location = New System.Drawing.Point(0, 169)
        Me.pcGreen.Margin = New System.Windows.Forms.Padding(0)
        Me.pcGreen.MaximumSize = New System.Drawing.Size(167, 169)
        Me.pcGreen.MinimumSize = New System.Drawing.Size(167, 169)
        Me.pcGreen.Name = "pcGreen"
        Me.pcGreen.ParticleColor = ParticleLifeCore.ParticleController.pColor.Green
        Me.pcGreen.Size = New System.Drawing.Size(167, 169)
        Me.pcGreen.TabIndex = 0
        Me.pcGreen.Title = "Green"
        '
        'pcBlue
        '
        Me.pcBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pcBlue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pcBlue.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.pcBlue.Location = New System.Drawing.Point(0, 338)
        Me.pcBlue.Margin = New System.Windows.Forms.Padding(0)
        Me.pcBlue.MaximumSize = New System.Drawing.Size(167, 169)
        Me.pcBlue.MinimumSize = New System.Drawing.Size(167, 169)
        Me.pcBlue.Name = "pcBlue"
        Me.pcBlue.ParticleColor = ParticleLifeCore.ParticleController.pColor.Blue
        Me.pcBlue.Size = New System.Drawing.Size(167, 169)
        Me.pcBlue.TabIndex = 2
        Me.pcBlue.Title = "Blue"
        '
        'pcWhite
        '
        Me.pcWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pcWhite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pcWhite.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.pcWhite.Location = New System.Drawing.Point(0, 507)
        Me.pcWhite.Margin = New System.Windows.Forms.Padding(0)
        Me.pcWhite.MaximumSize = New System.Drawing.Size(167, 169)
        Me.pcWhite.MinimumSize = New System.Drawing.Size(167, 169)
        Me.pcWhite.Name = "pcWhite"
        Me.pcWhite.ParticleColor = ParticleLifeCore.ParticleController.pColor.White
        Me.pcWhite.Size = New System.Drawing.Size(167, 169)
        Me.pcWhite.TabIndex = 3
        Me.pcWhite.Title = "White"
        '
        'canvas
        '
        Me.canvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.canvas.Location = New System.Drawing.Point(0, 0)
        Me.canvas.Margin = New System.Windows.Forms.Padding(0)
        Me.canvas.Name = "canvas"
        Me.canvas.Size = New System.Drawing.Size(621, 737)
        Me.canvas.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem2, Me.ShowModelToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(137, 6)
        '
        'ShowModelToolStripMenuItem
        '
        Me.ShowModelToolStripMenuItem.Checked = True
        Me.ShowModelToolStripMenuItem.CheckOnClick = True
        Me.ShowModelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowModelToolStripMenuItem.Name = "ShowModelToolStripMenuItem"
        Me.ShowModelToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ShowModelToolStripMenuItem.Text = "Show Model"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 761)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(0, 800)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Particle Life"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pcGreen As ParticleController
    Friend WithEvents pcRed As ParticleController
    Friend WithEvents pcBlue As ParticleController
    Friend WithEvents pcWhite As ParticleController
    Friend WithEvents ShowModelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents canvas As Panel
End Class
