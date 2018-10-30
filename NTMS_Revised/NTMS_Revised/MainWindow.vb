Public Class MainWindow
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dateTime_lbl.Text = Now
    End Sub

    Private Sub addDriver_btn_Click(sender As Object, e As EventArgs) Handles addDriver_btn.Click
        DriverWindow.Show()
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstName_label.Text = LoginWindow.FirstName
    End Sub

    Private Sub viewTrips_btn_Click(sender As Object, e As EventArgs) Handles viewTrips_btn.Click
        ViewTrips.Show()
    End Sub

    Private Sub newSched_btn_Click(sender As Object, e As EventArgs) Handles newSched_btn.Click
        NewSchedule.Show()
    End Sub

    Private Sub display_btn_Click(sender As Object, e As EventArgs) Handles display_btn.Click
        Display.Show()
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        LoginWindow.Show()
        Close()
    End Sub
End Class