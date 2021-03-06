﻿Public Class NewSchedule
    Public SQL As New SQLControl
    Public count As Integer

    Public Sub Clear()
        For Each cb As ComboBox In Panel1.Controls.OfType(Of ComboBox)()
            cb.Text = ""
        Next
        time_cb.Clear()
        plateNum_cb.Clear()
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
        LoadDriverCBx()
        LoadRouteCBx()
        LoadFareCBx()
        LoadVehicleCBx()
    End Sub

    Private Sub LoadDriverCBx()
        ' REFRESH COMBOBOX
        driver_cb.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT LastName FROM DriverInfo;")

        If SQL.HasException(True) Then Exit Sub
        ' LOOP ROW & ADD TO COMBOBOX
        For Each row As DataRow In SQL.DBDT.Rows
            driver_cb.Items.Add(row("LastName").ToString)
        Next
    End Sub

    Private Sub LoadRouteCBx()
        ' REFRESH COMBOBOX
        route_cb.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT DISTINCT Route FROM Schedule;")

        If SQL.HasException(True) Then Exit Sub
        ' LOOP ROW & ADD TO COMBOBOX
        For Each row As DataRow In SQL.DBDT.Rows
            route_cb.Items.Add(row("Route").ToString)
        Next
    End Sub

    Private Sub LoadFareCBx()
        ' REFRESH COMBOBOX
        fare_cb.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT DISTINCT Fare FROM Schedule;")

        If SQL.HasException(True) Then Exit Sub
        ' LOOP ROW & ADD TO COMBOBOX
        For Each row As DataRow In SQL.DBDT.Rows
            fare_cb.Items.Add(row("Fare").ToString)
        Next
    End Sub

    Private Sub LoadVehicleCBx()
        ' REFRESH COMBOBOX
        vehicleType_cb.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT DISTINCT VehicleType FROM Schedule;")

        If SQL.HasException(True) Then Exit Sub
        ' LOOP ROW & ADD TO COMBOBOX
        For Each row As DataRow In SQL.DBDT.Rows
            vehicleType_cb.Items.Add(row("VehicleType").ToString)
        Next
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

        SQL.ExecQuery("INSERT INTO Schedule (TravelNumber,DepartureDate,DepartureTime,Route,VehicleType,Fare,PlateNumber,Driver) " &
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

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Close()
    End Sub
End Class