Public Class NewSchedule
    Public SQL As New SQLControl
    Public count As Integer

    Public Sub Clear()
        For Each cb As ComboBox In Panel1.Controls.OfType(Of ComboBox)()
            cb.Text = ""
        Next
    End Sub


    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM Schedule WHERE DepartureDate='" & Now.ToString("MM/dd/yyyy") & "';")
            count = SQL.RecordCount + 1
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

    End Sub
    Public Sub LoadTravelNum()
        travelNum_txtbx.Text = Now.ToString("yyyyddMM") & "-" & "00" & count.ToString()
    End Sub
    Private Sub NewSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()

        LoadTravelNum()

    End Sub

    Private Sub InsertInfo()
        ' ADD PARAMETERS & RUN THE COMMAND
        SQL.AddParam("@travelnum", travelNum_txtbx.Text)
        SQL.AddParam("@deptdate", depart_date_picker.Text)
        SQL.AddParam("@depttime", time_cb.Text)
        SQL.AddParam("@route", route_cb.Text)
        SQL.AddParam("@vehicletype", vehicleType_cb.Text)
        SQL.AddParam("@fare", fare_cb.Text)
        SQL.AddParam("@platenum", plateNum_cb.Text)
        SQL.AddParam("@driver", driver_cb.Text)

        SQL.ExecQuery("INSERT INTO Schedule (TravelNumber,DepartureDate,DepartureTime,Route,VehicleType,Fare,PlateNo,Driver) " &
                      "VALUES (@travelnum,@deptdate,@depttime,@route,@vehicletype,@fare,@platenum,@driver);")

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        MsgBox("New Schedule Added!", MsgBoxStyle.Information, "Congratulations!")
        Clear()

    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If String.IsNullOrWhiteSpace(time_cb.Text) Or
            String.IsNullOrWhiteSpace(route_cb.Text) Or
            String.IsNullOrWhiteSpace(vehicleType_cb.Text) Or
            String.IsNullOrWhiteSpace(fare_cb.Text) Or
            String.IsNullOrWhiteSpace(plateNum_cb.Text) Or
            String.IsNullOrWhiteSpace(driver_cb.Text) Then

            For Each cb As ComboBox In Panel1.Controls.OfType(Of ComboBox)()
                If String.IsNullOrWhiteSpace(cb.Text) Then
                    ErrorProvider1.SetError(cb, "Please fill up this field")
                Else
                    ErrorProvider1.SetError(cb, "")
                End If
            Next

            MsgBox("Please fill up ALL the fields.", MsgBoxStyle.Exclamation, "ERROR")
        Else
            InsertInfo()
            LoadGrid()
            LoadTravelNum()
        End If


    End Sub
End Class