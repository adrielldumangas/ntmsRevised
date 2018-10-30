Public Class Display
    Public SQL As New SQLControl

    Public NextDisplay As Boolean

    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
    Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
    ' dayOfWeek.ToString() would return "Sunday" but it's an enum value,
    ' the correct dayname can be retrieved via DateTimeFormat.
    ' Following returns "Sonntag" for me since i'm in germany '
    Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time_lbl.Text = Now.ToString("hh:mm:ss tt")
        date_lbl.Text = Now.ToString("dd MMM yyyy")
        day_lbl.Text = dayName

    End Sub

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT TOP 12 Route AS Destination, " &
                          "VehicleType AS Vehicle,  PlateNumber AS 'Plate Number',  Driver, " &
                          "FORMAT(Fare,'C', 'en-ph') AS 'Fare (PHP)', FORMAT(DepartureTime,'hh:mm tt') AS Time, " &
                          "Status FROM Schedule ORDER BY DepartureTime ASC;")
        Else
            Sql.ExecQuery(Query)
        End If

        If SQL.RecordCount > 12 Then
            NextDisplay = True
        End If
        ' ERROR HANDLING
        If Sql.HasException(True) Then Exit Sub

        dgv_display.DataSource = SQL.DBDT
    End Sub

    Public Sub LoadGrid2(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT Route AS Destination, " &
                          "VehicleType AS Vehicle,  PlateNumber AS 'Plate Number',  Driver, " &
                          "FORMAT(Fare,'C', 'en-ph') AS 'Fare (PHP)', FORMAT(DepartureTime,'hh:mm tt') AS Time, " &
                          "Status FROM Schedule ORDER BY DepartureTime ASC OFFSET 12 ROWS;")
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        dgv_display2.DataSource = SQL.DBDT
    End Sub

    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        dgv_display2.Visible = False
        dgv_display.AutoResizeColumns()
        dgv_display.AutoResizeRows()
        showDisplay_timer.Start()

    End Sub

    Private Sub showDisplay_timer_Tick(sender As Object, e As EventArgs) Handles showDisplay_timer.Tick
        If NextDisplay Then
            LoadGrid2()
            dgv_display.Visible = False
            dgv_display2.Visible = True
            dgv_display2.AutoResizeColumns()
            dgv_display2.AutoResizeRows()
        End If
    End Sub
End Class