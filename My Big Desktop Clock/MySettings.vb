Public Class MySettings

    Private Sub MySettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        With My.Settings
            txtX_Coords.Text = .X_Coords
            txtY_Coords.Text = .Y_Coords

            txtTimeColor.Text = .TimeColor
            txtDayColor.Text = .DayColor
            txtMonthColor.Text = .MonthColor
            txtWeekdayColor.Text = .WeekdayColor

            txtTickInterval.Text = .TickInterval
        End With
    End Sub

    Private Sub txtX_Coords_TextChanged(sender As Object, e As EventArgs) Handles txtX_Coords.TextChanged
        If IsNumeric(txtX_Coords.Text) Then
            My.Settings.X_Coords = Integer.Parse(txtX_Coords.Text)
        End If
    End Sub

    Private Sub txtY_Coords_TextChanged(sender As Object, e As EventArgs) Handles txtY_Coords.TextChanged
        If IsNumeric(txtY_Coords.Text) Then
            My.Settings.Y_Coords = Integer.Parse(txtY_Coords.Text)
        End If
    End Sub

    Private Sub txtTimeColor_GotFocus(sender As TextBox, e As EventArgs) Handles txtTimeColor.GotFocus, txtDayColor.GotFocus, txtMonthColor.GotFocus, txtWeekdayColor.GotFocus, txtTickInterval.GotFocus
        sender.BackColor = Color.FromKnownColor(KnownColor.Window)
        sender.ForeColor = Color.FromKnownColor(KnownColor.WindowText)
    End Sub
    Private Sub txt_LostFocus(sender As TextBox, e As EventArgs) Handles txtTimeColor.LostFocus, txtDayColor.LostFocus, txtMonthColor.LostFocus, txtWeekdayColor.LostFocus
        ParseAndSaveColor(sender, sender.Tag)
    End Sub

    Private Sub txtTickInterval_LostFocus(sender As TextBox, e As EventArgs) Handles txtTickInterval.LostFocus
        If String.IsNullOrEmpty(txtTickInterval.Text) Then
            txtTickInterval.Text = My.Settings.TickInterval
            Exit Sub
        End If

        If IsNumeric(txtTickInterval.Text) Then
            My.Settings.TickInterval = Integer.Parse(txtTickInterval.Text)
        Else
            txtTickInterval.BackColor = Color.Red
            txtTickInterval.ForeColor = Color.White
        End If
    End Sub
    ''' <summary>
    ''' One stop shop for parsing and setting colors into the user.config
    ''' </summary>
    ''' <param name="tbx">Textbox having the new color name from</param>
    ''' <param name="settingName">The setting name that corresponds to the textbox</param>
    ''' <remarks></remarks>
    Private Sub ParseAndSaveColor(ByRef tbx As TextBox, ByVal settingName As String)
        If String.IsNullOrEmpty(tbx.Text) Then
            tbx.Text = My.Settings(settingName)
            Exit Sub
        End If

        Dim newColor = Color.FromName(tbx.Text)

        If newColor.A = 0 _
            And newColor.R = 0 _
            And newColor.G = 0 _
            And newColor.B = 0 Then
            '' Color parsing failed, indicate this to the user
            tbx.BackColor = Color.Red
            tbx.ForeColor = Color.White
        Else
            My.Settings(settingName) = newColor.Name
        End If
    End Sub
End Class