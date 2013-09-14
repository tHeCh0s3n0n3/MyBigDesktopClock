<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MySettings
    Inherits System.Windows.Forms.Form

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
        Me.lblX_Coords = New System.Windows.Forms.Label()
        Me.lblY_Coords = New System.Windows.Forms.Label()
        Me.txtY_Coords = New System.Windows.Forms.TextBox()
        Me.txtX_Coords = New System.Windows.Forms.TextBox()
        Me.gbxCoordinates = New System.Windows.Forms.GroupBox()
        Me.gbxColors = New System.Windows.Forms.GroupBox()
        Me.txtWeekdayColor = New System.Windows.Forms.TextBox()
        Me.txtMonthColor = New System.Windows.Forms.TextBox()
        Me.txtDayColor = New System.Windows.Forms.TextBox()
        Me.txtTimeColor = New System.Windows.Forms.TextBox()
        Me.lblWeekdayColor = New System.Windows.Forms.Label()
        Me.lblMonthColor = New System.Windows.Forms.Label()
        Me.lblDayColor = New System.Windows.Forms.Label()
        Me.lblTimeColor = New System.Windows.Forms.Label()
        Me.gbxTicks = New System.Windows.Forms.GroupBox()
        Me.txtTickInterval = New System.Windows.Forms.TextBox()
        Me.lblTickInterval = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxCoordinates.SuspendLayout()
        Me.gbxColors.SuspendLayout()
        Me.gbxTicks.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblX_Coords
        '
        Me.lblX_Coords.Location = New System.Drawing.Point(6, 22)
        Me.lblX_Coords.Name = "lblX_Coords"
        Me.lblX_Coords.Size = New System.Drawing.Size(80, 20)
        Me.lblX_Coords.TabIndex = 100
        Me.lblX_Coords.Text = "X-Coords:"
        Me.lblX_Coords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblY_Coords
        '
        Me.lblY_Coords.Location = New System.Drawing.Point(6, 54)
        Me.lblY_Coords.Name = "lblY_Coords"
        Me.lblY_Coords.Size = New System.Drawing.Size(80, 20)
        Me.lblY_Coords.TabIndex = 101
        Me.lblY_Coords.Text = "Y-Coords:"
        Me.lblY_Coords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtY_Coords
        '
        Me.txtY_Coords.Location = New System.Drawing.Point(92, 51)
        Me.txtY_Coords.Name = "txtY_Coords"
        Me.txtY_Coords.Size = New System.Drawing.Size(119, 26)
        Me.txtY_Coords.TabIndex = 2
        '
        'txtX_Coords
        '
        Me.txtX_Coords.Location = New System.Drawing.Point(92, 19)
        Me.txtX_Coords.Name = "txtX_Coords"
        Me.txtX_Coords.Size = New System.Drawing.Size(119, 26)
        Me.txtX_Coords.TabIndex = 1
        '
        'gbxCoordinates
        '
        Me.gbxCoordinates.Controls.Add(Me.lblX_Coords)
        Me.gbxCoordinates.Controls.Add(Me.txtY_Coords)
        Me.gbxCoordinates.Controls.Add(Me.txtX_Coords)
        Me.gbxCoordinates.Controls.Add(Me.lblY_Coords)
        Me.gbxCoordinates.Location = New System.Drawing.Point(12, 12)
        Me.gbxCoordinates.Name = "gbxCoordinates"
        Me.gbxCoordinates.Size = New System.Drawing.Size(222, 88)
        Me.gbxCoordinates.TabIndex = 200
        Me.gbxCoordinates.TabStop = False
        Me.gbxCoordinates.Text = "Window Coordinates"
        '
        'gbxColors
        '
        Me.gbxColors.Controls.Add(Me.txtWeekdayColor)
        Me.gbxColors.Controls.Add(Me.txtMonthColor)
        Me.gbxColors.Controls.Add(Me.txtDayColor)
        Me.gbxColors.Controls.Add(Me.txtTimeColor)
        Me.gbxColors.Controls.Add(Me.lblWeekdayColor)
        Me.gbxColors.Controls.Add(Me.lblMonthColor)
        Me.gbxColors.Controls.Add(Me.lblDayColor)
        Me.gbxColors.Controls.Add(Me.lblTimeColor)
        Me.gbxColors.Location = New System.Drawing.Point(12, 106)
        Me.gbxColors.Name = "gbxColors"
        Me.gbxColors.Size = New System.Drawing.Size(222, 152)
        Me.gbxColors.TabIndex = 201
        Me.gbxColors.TabStop = False
        Me.gbxColors.Text = "Colors"
        '
        'txtWeekdayColor
        '
        Me.txtWeekdayColor.Location = New System.Drawing.Point(92, 115)
        Me.txtWeekdayColor.Name = "txtWeekdayColor"
        Me.txtWeekdayColor.Size = New System.Drawing.Size(119, 26)
        Me.txtWeekdayColor.TabIndex = 6
        Me.txtWeekdayColor.Tag = "WeekdayColor"
        '
        'txtMonthColor
        '
        Me.txtMonthColor.Location = New System.Drawing.Point(92, 83)
        Me.txtMonthColor.Name = "txtMonthColor"
        Me.txtMonthColor.Size = New System.Drawing.Size(119, 26)
        Me.txtMonthColor.TabIndex = 5
        Me.txtMonthColor.Tag = "MonthColor"
        '
        'txtDayColor
        '
        Me.txtDayColor.Location = New System.Drawing.Point(92, 51)
        Me.txtDayColor.Name = "txtDayColor"
        Me.txtDayColor.Size = New System.Drawing.Size(119, 26)
        Me.txtDayColor.TabIndex = 4
        Me.txtDayColor.Tag = "DayColor"
        '
        'txtTimeColor
        '
        Me.txtTimeColor.Location = New System.Drawing.Point(92, 19)
        Me.txtTimeColor.Name = "txtTimeColor"
        Me.txtTimeColor.Size = New System.Drawing.Size(119, 26)
        Me.txtTimeColor.TabIndex = 3
        Me.txtTimeColor.Tag = "TimeColor"
        '
        'lblWeekdayColor
        '
        Me.lblWeekdayColor.Location = New System.Drawing.Point(6, 118)
        Me.lblWeekdayColor.Name = "lblWeekdayColor"
        Me.lblWeekdayColor.Size = New System.Drawing.Size(80, 23)
        Me.lblWeekdayColor.TabIndex = 105
        Me.lblWeekdayColor.Text = "Weekday:"
        Me.lblWeekdayColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMonthColor
        '
        Me.lblMonthColor.Location = New System.Drawing.Point(6, 86)
        Me.lblMonthColor.Name = "lblMonthColor"
        Me.lblMonthColor.Size = New System.Drawing.Size(80, 20)
        Me.lblMonthColor.TabIndex = 104
        Me.lblMonthColor.Text = "Month:"
        Me.lblMonthColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDayColor
        '
        Me.lblDayColor.Location = New System.Drawing.Point(6, 54)
        Me.lblDayColor.Name = "lblDayColor"
        Me.lblDayColor.Size = New System.Drawing.Size(80, 20)
        Me.lblDayColor.TabIndex = 103
        Me.lblDayColor.Text = "Day:"
        Me.lblDayColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTimeColor
        '
        Me.lblTimeColor.Location = New System.Drawing.Point(6, 22)
        Me.lblTimeColor.Name = "lblTimeColor"
        Me.lblTimeColor.Size = New System.Drawing.Size(80, 20)
        Me.lblTimeColor.TabIndex = 102
        Me.lblTimeColor.Text = "Time:"
        Me.lblTimeColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbxTicks
        '
        Me.gbxTicks.Controls.Add(Me.txtTickInterval)
        Me.gbxTicks.Controls.Add(Me.lblTickInterval)
        Me.gbxTicks.Location = New System.Drawing.Point(12, 264)
        Me.gbxTicks.Name = "gbxTicks"
        Me.gbxTicks.Size = New System.Drawing.Size(222, 64)
        Me.gbxTicks.TabIndex = 202
        Me.gbxTicks.TabStop = False
        Me.gbxTicks.Text = "Time"
        '
        'txtTickInterval
        '
        Me.txtTickInterval.Location = New System.Drawing.Point(92, 25)
        Me.txtTickInterval.Name = "txtTickInterval"
        Me.txtTickInterval.Size = New System.Drawing.Size(119, 26)
        Me.txtTickInterval.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtTickInterval, "Note: Time interval should be in milliseconds (1 sec = 1000 ms)")
        '
        'lblTickInterval
        '
        Me.lblTickInterval.Location = New System.Drawing.Point(6, 27)
        Me.lblTickInterval.Name = "lblTickInterval"
        Me.lblTickInterval.Size = New System.Drawing.Size(80, 23)
        Me.lblTickInterval.TabIndex = 106
        Me.lblTickInterval.Text = "Interval:"
        Me.lblTickInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblTickInterval, "Note: Time interval should be in milliseconds (1 sec = 1000 ms)")
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'MySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 335)
        Me.Controls.Add(Me.gbxTicks)
        Me.Controls.Add(Me.gbxColors)
        Me.Controls.Add(Me.gbxCoordinates)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MySettings"
        Me.Text = "Settings"
        Me.gbxCoordinates.ResumeLayout(False)
        Me.gbxCoordinates.PerformLayout()
        Me.gbxColors.ResumeLayout(False)
        Me.gbxColors.PerformLayout()
        Me.gbxTicks.ResumeLayout(False)
        Me.gbxTicks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblX_Coords As System.Windows.Forms.Label
    Friend WithEvents lblY_Coords As System.Windows.Forms.Label
    Friend WithEvents txtY_Coords As System.Windows.Forms.TextBox
    Friend WithEvents txtX_Coords As System.Windows.Forms.TextBox
    Friend WithEvents gbxCoordinates As System.Windows.Forms.GroupBox
    Friend WithEvents gbxColors As System.Windows.Forms.GroupBox
    Friend WithEvents txtWeekdayColor As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthColor As System.Windows.Forms.TextBox
    Friend WithEvents txtDayColor As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeColor As System.Windows.Forms.TextBox
    Friend WithEvents lblWeekdayColor As System.Windows.Forms.Label
    Friend WithEvents lblMonthColor As System.Windows.Forms.Label
    Friend WithEvents lblDayColor As System.Windows.Forms.Label
    Friend WithEvents lblTimeColor As System.Windows.Forms.Label
    Friend WithEvents gbxTicks As System.Windows.Forms.GroupBox
    Friend WithEvents txtTickInterval As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblTickInterval As System.Windows.Forms.Label
End Class
