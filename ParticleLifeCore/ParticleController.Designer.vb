<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParticleController
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tNumber = New ParticleLifeCore.tracker()
        Me.txgreen = New ParticleLifeCore.tracker()
        Me.txred = New ParticleLifeCore.tracker()
        Me.txblue = New ParticleLifeCore.tracker()
        Me.txwhite = New ParticleLifeCore.tracker()
        Me.trred = New ParticleLifeCore.tracker()
        Me.trg = New ParticleLifeCore.tracker()
        Me.trb = New ParticleLifeCore.tracker()
        Me.trw = New ParticleLifeCore.tracker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        '
        'tNumber
        '
        Me.tNumber.BackColor = System.Drawing.Color.Transparent
        Me.tNumber.Location = New System.Drawing.Point(3, 16)
        Me.tNumber.MaximumValue = 3000
        Me.tNumber.MinimumSize = New System.Drawing.Size(25, 16)
        Me.tNumber.MinimumValue = 0
        Me.tNumber.Name = "tNumber"
        Me.tNumber.Size = New System.Drawing.Size(160, 16)
        Me.tNumber.TabIndex = 12
        Me.tNumber.Tag = "Number"
        Me.tNumber.Title = "Number"
        Me.tNumber.Value = 1000
        '
        'txgreen
        '
        Me.txgreen.BackColor = System.Drawing.Color.Transparent
        Me.txgreen.Location = New System.Drawing.Point(3, 50)
        Me.txgreen.MaximumValue = 100
        Me.txgreen.MinimumSize = New System.Drawing.Size(25, 16)
        Me.txgreen.MinimumValue = -100
        Me.txgreen.Name = "txgreen"
        Me.txgreen.Size = New System.Drawing.Size(160, 16)
        Me.txgreen.TabIndex = 13
        Me.txgreen.Tag = "{color} x green"
        Me.txgreen.Title = "{color} x green"
        Me.txgreen.Value = 0
        '
        'txred
        '
        Me.txred.BackColor = System.Drawing.Color.Transparent
        Me.txred.Location = New System.Drawing.Point(3, 33)
        Me.txred.MaximumValue = 100
        Me.txred.MinimumSize = New System.Drawing.Size(25, 16)
        Me.txred.MinimumValue = -100
        Me.txred.Name = "txred"
        Me.txred.Size = New System.Drawing.Size(160, 16)
        Me.txred.TabIndex = 14
        Me.txred.Tag = "{color} x red"
        Me.txred.Title = "{color} x red"
        Me.txred.Value = 0
        '
        'txblue
        '
        Me.txblue.BackColor = System.Drawing.Color.Transparent
        Me.txblue.Location = New System.Drawing.Point(3, 67)
        Me.txblue.MaximumValue = 100
        Me.txblue.MinimumSize = New System.Drawing.Size(25, 16)
        Me.txblue.MinimumValue = -100
        Me.txblue.Name = "txblue"
        Me.txblue.Size = New System.Drawing.Size(160, 16)
        Me.txblue.TabIndex = 15
        Me.txblue.Tag = "{color} x blue"
        Me.txblue.Title = "{color} x blue"
        Me.txblue.Value = 0
        '
        'txwhite
        '
        Me.txwhite.BackColor = System.Drawing.Color.Transparent
        Me.txwhite.Location = New System.Drawing.Point(3, 84)
        Me.txwhite.MaximumValue = 100
        Me.txwhite.MinimumSize = New System.Drawing.Size(25, 16)
        Me.txwhite.MinimumValue = -100
        Me.txwhite.Name = "txwhite"
        Me.txwhite.Size = New System.Drawing.Size(160, 16)
        Me.txwhite.TabIndex = 16
        Me.txwhite.Tag = "{color} x white"
        Me.txwhite.Title = "{color} x white"
        Me.txwhite.Value = 0
        '
        'trred
        '
        Me.trred.BackColor = System.Drawing.Color.Transparent
        Me.trred.Location = New System.Drawing.Point(3, 101)
        Me.trred.MaximumValue = 500
        Me.trred.MinimumSize = New System.Drawing.Size(25, 16)
        Me.trred.MinimumValue = 10
        Me.trred.Name = "trred"
        Me.trred.Size = New System.Drawing.Size(160, 16)
        Me.trred.TabIndex = 17
        Me.trred.Tag = "Radius {c} x r"
        Me.trred.Title = "Radius {c} x r"
        Me.trred.Value = 180
        '
        'trg
        '
        Me.trg.BackColor = System.Drawing.Color.Transparent
        Me.trg.Location = New System.Drawing.Point(3, 118)
        Me.trg.MaximumValue = 500
        Me.trg.MinimumSize = New System.Drawing.Size(25, 16)
        Me.trg.MinimumValue = 10
        Me.trg.Name = "trg"
        Me.trg.Size = New System.Drawing.Size(160, 16)
        Me.trg.TabIndex = 18
        Me.trg.Tag = "Radius {c} x g"
        Me.trg.Title = "Radius {c} x g"
        Me.trg.Value = 180
        '
        'trb
        '
        Me.trb.BackColor = System.Drawing.Color.Transparent
        Me.trb.Location = New System.Drawing.Point(3, 135)
        Me.trb.MaximumValue = 500
        Me.trb.MinimumSize = New System.Drawing.Size(25, 16)
        Me.trb.MinimumValue = 10
        Me.trb.Name = "trb"
        Me.trb.Size = New System.Drawing.Size(160, 16)
        Me.trb.TabIndex = 19
        Me.trb.Tag = "Radius {c} x b"
        Me.trb.Title = "Radius {c} x b"
        Me.trb.Value = 180
        '
        'trw
        '
        Me.trw.BackColor = System.Drawing.Color.Transparent
        Me.trw.Location = New System.Drawing.Point(3, 152)
        Me.trw.MaximumValue = 500
        Me.trw.MinimumSize = New System.Drawing.Size(25, 16)
        Me.trw.MinimumValue = 10
        Me.trw.Name = "trw"
        Me.trw.Size = New System.Drawing.Size(160, 16)
        Me.trw.TabIndex = 20
        Me.trw.Tag = "Radius {c} x w"
        Me.trw.Title = "Radius {c} x w"
        Me.trw.Value = 180
        '
        'ParticleController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Controls.Add(Me.trw)
        Me.Controls.Add(Me.trb)
        Me.Controls.Add(Me.trg)
        Me.Controls.Add(Me.trred)
        Me.Controls.Add(Me.txwhite)
        Me.Controls.Add(Me.txblue)
        Me.Controls.Add(Me.txred)
        Me.Controls.Add(Me.txgreen)
        Me.Controls.Add(Me.tNumber)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximumSize = New System.Drawing.Size(167, 169)
        Me.MinimumSize = New System.Drawing.Size(167, 169)
        Me.Name = "ParticleController"
        Me.Size = New System.Drawing.Size(167, 169)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tNumber As tracker
    Friend WithEvents txgreen As tracker
    Friend WithEvents txred As tracker
    Friend WithEvents txblue As tracker
    Friend WithEvents txwhite As tracker
    Friend WithEvents trred As tracker
    Friend WithEvents trg As tracker
    Friend WithEvents trb As tracker
    Friend WithEvents trw As tracker
End Class
