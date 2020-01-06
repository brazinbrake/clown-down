<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formGame))
        Me.countdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblClowns = New System.Windows.Forms.Label()
        Me.txtClowns = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtClownValue = New System.Windows.Forms.TextBox()
        Me.lblClownValue = New System.Windows.Forms.Label()
        Me.mnuFormGame = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.growTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.mnuFormGame.SuspendLayout()
        Me.SuspendLayout()
        '
        'countdownTimer
        '
        Me.countdownTimer.Interval = 1000
        '
        'txtTimer
        '
        Me.txtTimer.Location = New System.Drawing.Point(672, 12)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(50, 20)
        Me.txtTimer.TabIndex = 1
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(636, 12)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(30, 13)
        Me.lblTimer.TabIndex = 2
        Me.lblTimer.Text = "Time"
        '
        'lblClowns
        '
        Me.lblClowns.AutoSize = True
        Me.lblClowns.Location = New System.Drawing.Point(572, 38)
        Me.lblClowns.Name = "lblClowns"
        Me.lblClowns.Size = New System.Drawing.Size(94, 13)
        Me.lblClowns.TabIndex = 4
        Me.lblClowns.Text = "Clowns Remaining"
        '
        'txtClowns
        '
        Me.txtClowns.Location = New System.Drawing.Point(672, 38)
        Me.txtClowns.Name = "txtClowns"
        Me.txtClowns.ReadOnly = True
        Me.txtClowns.Size = New System.Drawing.Size(20, 20)
        Me.txtClowns.TabIndex = 3
        '
        'btnStart
        '
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Location = New System.Drawing.Point(12, 31)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtClownValue
        '
        Me.txtClownValue.Location = New System.Drawing.Point(111, 5)
        Me.txtClownValue.Name = "txtClownValue"
        Me.txtClownValue.Size = New System.Drawing.Size(20, 20)
        Me.txtClownValue.TabIndex = 6
        '
        'lblClownValue
        '
        Me.lblClownValue.AutoSize = True
        Me.lblClownValue.Location = New System.Drawing.Point(12, 9)
        Me.lblClownValue.Name = "lblClownValue"
        Me.lblClownValue.Size = New System.Drawing.Size(93, 13)
        Me.lblClownValue.TabIndex = 7
        Me.lblClownValue.Text = "Number of Clowns"
        '
        'mnuFormGame
        '
        Me.mnuFormGame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.mnuFormGame.Name = "mnuFormGame"
        Me.mnuFormGame.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'growTimer
        '
        Me.growTimer.Interval = 1000
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.Location = New System.Drawing.Point(131, 162)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(523, 66)
        Me.lblInstruct.TabIndex = 8
        Me.lblInstruct.Text = "Enter Number of Clowns." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press Start or Click Enter Key to Begin."
        Me.lblInstruct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.ContextMenuStrip = Me.mnuFormGame
        Me.ControlBox = False
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.lblClownValue)
        Me.Controls.Add(Me.txtClownValue)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblClowns)
        Me.Controls.Add(Me.txtClowns)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.txtTimer)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Name = "formGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clown Down"
        Me.mnuFormGame.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents countdownTimer As Timer
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblClowns As Label
    Friend WithEvents txtClowns As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents txtClownValue As TextBox
    Friend WithEvents lblClownValue As Label
    Friend WithEvents mnuFormGame As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents growTimer As Timer
    Friend WithEvents lblInstruct As Label
End Class
