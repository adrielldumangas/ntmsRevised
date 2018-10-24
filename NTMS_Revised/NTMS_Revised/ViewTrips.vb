Public Class ViewTrips
    Public SQL As New SQLControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM Schedule;")
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        dgv_schedule.DataSource = SQL.DBDT
    End Sub

    Private Sub ViewTrips_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()

    End Sub

    Private Sub FindTrip()
        SQL.AddParam("@trip", "%" & search_txtbx.Text & "%")

        LoadGrid("SELECT * FROM Schedule WHERE TravelNumber LIKE @trip OR Route LIKE @trip;")
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        FindTrip()
    End Sub
End Class