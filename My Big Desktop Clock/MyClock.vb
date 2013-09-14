Public Class MyClock
    Inherits DraggableForm.FormBase

    Private Sub MyClock_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrClockTick.Interval = My.Settings.TickInterval
        tmrClockTick_Tick(New Object(), New System.EventArgs())
        tmrClockTick.Start()
    End Sub

    Private Sub tmrClockTick_Tick(sender As Object, e As EventArgs) Handles tmrClockTick.Tick

        lblTime.Text = Now.ToString("HH|mm")
        lblTime.ForeColor = Color.FromName(My.Settings.TimeColor)

        lblDay.Text = Now.ToString("dd")
        lblDay.ForeColor = Color.FromName(My.Settings.DayColor)

        lblMonth.Text = Now.ToString("MMMM")
        lblMonth.ForeColor = Color.FromName(My.Settings.MonthColor)

        lblWeekday.Text = Now.DayOfWeek.ToString()
        lblWeekday.ForeColor = Color.FromName(My.Settings.WeekdayColor)

        Me.Top = My.Settings.Y_Coords
        Me.Left = My.Settings.X_Coords

        tmrClockTick.Interval = My.Settings.TickInterval
    End Sub

    Private Sub tsmiOptions_Click(sender As Object, e As EventArgs) Handles tsmiOptions.Click
        Dim frm As New MySettings()
        frm.ShowDialog()
    End Sub
End Class
