Public Class DriverWindow

    Public SQL As New SQLControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM DriverInfo;")
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        dgv_driver.DataSource = SQL.DBDT
    End Sub

    Public Sub DisableFields()
        lastname_txtbx.Enabled = False
        firstname_txtbx.Enabled = False
        middlename_txtbx.Enabled = False
        bday_picker.Enabled = False
        address_txtbx.Enabled = False
        licenseNum_txtbx.Enabled = False
        save_btn.Enabled = False
        newDriver_btn.Enabled = True

    End Sub

    Private Sub newDriver_btn_Click(sender As Object, e As EventArgs) Handles newDriver_btn.Click
        lastname_txtbx.Enabled = True
        firstname_txtbx.Enabled = True
        middlename_txtbx.Enabled = True
        bday_picker.Enabled = True
        address_txtbx.Enabled = True
        licenseNum_txtbx.Enabled = True
        save_btn.Enabled = True
        newDriver_btn.Enabled = False
    End Sub

    Private Sub InsertInfo()
        ' ADD PARAMETERS & RUN THE COMMAND
        Sql.AddParam("@lastname", lastname_txtbx.Text)
        Sql.AddParam("@firstname", firstname_txtbx.Text)
        Sql.AddParam("@middlename", middlename_txtbx.Text)
        Sql.AddParam("@birthdate", bday_picker.Text)
        SQL.AddParam("@address", address_txtbx.Text)
        SQL.AddParam("@license", licenseNum_txtbx.Text)

        SQL.ExecQuery("INSERT INTO DriverInfo (LastName,FirstName,MiddleName,BirthDate,Address,LicenseNum) " &
                      "VALUES (@lastname,@firstname,@middlename,@birthdate,@address,@license);")

        ' REPORT & ABORT ON ERRORS
        If Sql.HasException(True) Then Exit Sub

        MsgBox("New Driver Added!", MsgBoxStyle.Information, "Successful!")
        LoadGrid()

    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If String.IsNullOrWhiteSpace(lastname_txtbx.Text) Or
            String.IsNullOrWhiteSpace(firstname_txtbx.Text) Or
            String.IsNullOrWhiteSpace(middlename_txtbx.Text) Or
            String.IsNullOrWhiteSpace(address_txtbx.Text) Or
            String.IsNullOrWhiteSpace(licenseNum_txtbx.Text) Then

            For Each tb As TextBox In Panel1.Controls.OfType(Of TextBox)()
                If String.IsNullOrWhiteSpace(tb.Text) Then
                    ErrorProvider1.SetError(tb, "Please fill up this field")
                Else
                    ErrorProvider1.SetError(tb, "")
                End If
            Next

            MsgBox("Please fill up ALL the fields.", MsgBoxStyle.Exclamation, "ERROR")
        Else
            InsertInfo()
            DisableFields()

        End If
    End Sub

    Private Sub FindDriver()
        SQL.AddParam("@driver", "%" & search_txtbx.Text & "%")

        LoadGrid("SELECT * FROM DriverInfo WHERE LastName LIKE @driver OR FirstName LIKE @driver OR LicenseNum LIKE @driver;")
    End Sub

    Private Sub DriverWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()

    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        FindDriver()
    End Sub
End Class