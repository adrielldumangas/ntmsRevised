Public Class ViewTrips
    Public SQL As New SQLControl

    Private Sub FindTrip()
        ' REFRESH USER LIST
        trip_lb.Items.Clear()

        ' ADD PARAMS & RUN QUERY
        SQL.AddParam("@trip", "%" & search_txtbx.Text & "%")
        SQL.ExecQuery("SELECT TravelNumber FROM Schedule WHERE TravelNumber LIKE @trip " &
                      "ORDER BY TravelNumber ASC;")

        ' REPORT & ABORT ERRORS
        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROWS & RETURN USERS TO LIST
        For Each t As DataRow In SQL.DBDT.Rows
            trip_lb.Items.Add(t("TravelNumber"))
        Next
    End Sub

    Private Sub GetTripDetails(TravelNum As String)
        SQL.AddParam("@tripNum", TravelNum)
        SQL.ExecQuery("SELECT TOP 1 *, FORMAT(DepartureTime,'hh:mm tt') AS Time, " &
                      "FORMAT(Fare,'C', 'en-ph') AS NFare FROM Schedule WHERE TravelNumber = @tripNum;")

        If SQL.RecordCount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            travelNum_txtbx.Text = r("TravelNumber")
            time_cb.Text = r("Time").ToString
            vehicleType_cb.Text = r("VehicleType")
            fare_txtbx.Text = r("NFare")
            plateNum_txtbx.Text = r("PlateNumber")
            route_txtbx.Text = r("Route")
            driver_txtbx.Text = r("Driver")
            If Not IsDBNull(r("Status")) Then
                status_cb.Text = r("Status")
            End If
        Next

    End Sub

    Private Sub ViewTrips_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindTrip()

    End Sub

    Private Sub UpdateTrip()
        SQL.AddParam("@time", time_cb.Text)
        SQL.AddParam("@status", status_cb.Text)
        SQL.AddParam("@travelNum", travelNum_txtbx.Text)

        SQL.ExecQuery("UPDATE Schedule SET DepartureTime=@time, Status=@status WHERE TravelNumber=@travelNum;")

        If SQL.HasException(True) Then Exit Sub

        MsgBox("Trip Details Updated!", MsgBoxStyle.Information, "Successful!")
        update_btn.Enabled = False
    End Sub

    Private Sub search_txtbx_KeyDown(sender As Object, e As KeyEventArgs) Handles search_txtbx.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindTrip()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub trip_lb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles trip_lb.SelectedIndexChanged
        GetTripDetails(trip_lb.Text)
        update_btn.Enabled = True
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        UpdateTrip()

    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Close()
    End Sub
End Class