Public Class Display
    Public SQL As New SQLControl

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
            SQL.ExecQuery("SELECT Route AS Destination, VehicleType AS Vehicle,  DepartureTime AS Time, Fare, PlateNo AS 'Plate_No.', Driver, Status FROM Schedule;")
        Else
            Sql.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If Sql.HasException(True) Then Exit Sub

        dgv_display.DataSource = SQL.DBDT
    End Sub

    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        dgv_display.AutoResizeColumns()
        dgv_display.AutoResizeRows()

    End Sub
End Class