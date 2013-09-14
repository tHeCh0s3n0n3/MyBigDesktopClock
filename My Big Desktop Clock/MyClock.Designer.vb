<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyClock
    Inherits My_Big_Desktop_Clock.DraggableForm.FormBase

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.RightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblWeekday = New System.Windows.Forms.Label()
        Me.tmrClockTick = New System.Windows.Forms.Timer(Me.components)
        Me.RightClickMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.ContextMenuStrip = Me.RightClickMenu
        Me.lblTime.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(12, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(430, 166)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "99|99"
        '
        'RightClickMenu
        '
        Me.RightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOptions, Me.ToolStripSeparator1, Me.tsmiAbout})
        Me.RightClickMenu.Name = "RightClickMenu"
        Me.RightClickMenu.Size = New System.Drawing.Size(149, 70)
        '
        'tsmiOptions
        '
        Me.tsmiOptions.Name = "tsmiOptions"
        Me.tsmiOptions.Size = New System.Drawing.Size(148, 30)
        Me.tsmiOptions.Text = "Options"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'tsmiAbout
        '
        Me.tsmiAbout.Name = "tsmiAbout"
        Me.tsmiAbout.Size = New System.Drawing.Size(148, 30)
        Me.tsmiAbout.Text = "About"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.ContextMenuStrip = Me.RightClickMenu
        Me.lblDay.Font = New System.Drawing.Font("Arial", 55.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.Blue
        Me.lblDay.Location = New System.Drawing.Point(12, 183)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(175, 126)
        Me.lblDay.TabIndex = 1
        Me.lblDay.Text = "99"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ContextMenuStrip = Me.RightClickMenu
        Me.lblMonth.Font = New System.Drawing.Font("Arial", 55.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.Yellow
        Me.lblMonth.Location = New System.Drawing.Point(169, 186)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(456, 123)
        Me.lblMonth.TabIndex = 2
        Me.lblMonth.Text = "MONTH"
        '
        'lblWeekday
        '
        Me.lblWeekday.AutoSize = True
        Me.lblWeekday.ContextMenuStrip = Me.RightClickMenu
        Me.lblWeekday.Font = New System.Drawing.Font("Arial", 55.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeekday.ForeColor = System.Drawing.Color.Green
        Me.lblWeekday.Location = New System.Drawing.Point(12, 314)
        Me.lblWeekday.Name = "lblWeekday"
        Me.lblWeekday.Size = New System.Drawing.Size(525, 126)
        Me.lblWeekday.TabIndex = 3
        Me.lblWeekday.Text = "Weekday"
        '
        'tmrClockTick
        '
        Me.tmrClockTick.Interval = 30000
        '
        'MyClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(903, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblWeekday)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MyClock"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "My Big Clock"
        Me.TransparencyKey = System.Drawing.SystemColors.Desktop
        Me.RightClickMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblWeekday As System.Windows.Forms.Label
    Friend WithEvents tmrClockTick As System.Windows.Forms.Timer
    Friend WithEvents RightClickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiAbout As System.Windows.Forms.ToolStripMenuItem

End Class
