Public Class DriverWindow

    Public SQL As New SQLControl

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

    Public Sub EnableFields()
        firstname_txtbx.Enabled = True
        middlename_txtbx.Enabled = True
        bday_picker.Enabled = True
        address_txtbx.Enabled = True
        licenseNum_txtbx.Enabled = True
    End Sub

    Private Sub newDriver_btn_Click(sender As Object, e As EventArgs) Handles newDriver_btn.Click
        EnableFields()
        lastname_txtbx.Enabled = True
        save_btn.Enabled = True
        newDriver_btn.Enabled = False
        edit_btn.Enabled = False
    End Sub

    Private Sub InsertInfo()
        ' ADD PARAMETERS & RUN THE COMMAND
        Sql.AddParam("@lastname", lastname_txtbx.Text)
        Sql.AddParam("@firstname", firstname_txtbx.Text)
        Sql.AddParam("@middlename", middlename_txtbx.Text)
        Sql.AddParam("@birthdate", bday_picker.Text)
        SQL.AddParam("@address", address_txtbx.Text)
        SQL.AddParam("@license", licenseNum_txtbx.Text)

        SQL.ExecQuery("INSERT INTO DriverInfo (LastName,FirstName,MiddleName,BirthDate,Address,LicenseNumber) " &
                      "VALUES (@lastname,@firstname,@middlename,@birthdate,@address,@license);")

        ' REPORT & ABORT ON ERRORS
        If Sql.HasException(True) Then Exit Sub

        MsgBox("New Driver Added!", MsgBoxStyle.Information, "Successful!")

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
            ClearFields()
        End If
    End Sub

    Private Sub FindDriver()
        ' REFRESH USER LIST
        driver_lb.Items.Clear()

        ' ADD PARAMS & RUN QUERY
        SQL.AddParam("@driver", "%" & search_txtbx.Text & "%")
        SQL.ExecQuery("SELECT LastName FROM DriverInfo WHERE LastName LIKE @driver " &
                      "ORDER BY LastName ASC;")

        ' REPORT & ABORT ERRORS
        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROWS & RETURN USERS TO LIST
        For Each t As DataRow In SQL.DBDT.Rows
            driver_lb.Items.Add(t("LastName"))
        Next
    End Sub

    Private Sub GetDriverDetails(LastName As String)
        SQL.AddParam("@lastname", LastName)
        SQL.ExecQuery("SELECT TOP 1 * FROM DriverInfo WHERE LastName = @lastname;")

        If SQL.RecordCount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            lastname_txtbx.Text = r("LastName")
            bday_picker.Text = r("BirthDate")
            firstname_txtbx.Text = r("FirstName")
            middlename_txtbx.Text = r("MiddleName")
            address_txtbx.Text = r("Address")
            licenseNum_txtbx.Text = r("LicenseNumber")
        Next
    End Sub

    Private Sub UpdateDriver()
        ' UPDATE PARAMETERS & RUN THE COMMAND
        SQL.AddParam("@lastname", lastname_txtbx.Text)
        SQL.AddParam("@firstname", firstname_txtbx.Text)
        SQL.AddParam("@middlename", middlename_txtbx.Text)
        SQL.AddParam("@birthdate", bday_picker.Text)
        SQL.AddParam("@address", address_txtbx.Text)
        SQL.AddParam("@license", licenseNum_txtbx.Text)

        SQL.ExecQuery("UPDATE DriverInfo SET FirstName=@firstname, MiddleName=@middlename, BirthDate=@birthdate, " &
                      "Address=@address, LicenseNumber=@license WHERE LastName=@lastname;")

        If SQL.HasException(True) Then Exit Sub

        MsgBox("Driver Details Updated!", MsgBoxStyle.Information, "Successful!")
        update_btn.Enabled = False
        edit_btn.Enabled = True
    End Sub

    Private Sub DeleteUser()
        SQL.AddParam("@lastname", lastname_txtbx.Text)
        SQL.AddParam("@license", licenseNum_txtbx.Text)

        SQL.ExecQuery("DELETE FROM DriverInfo WHERE LastName=@lastname AND LicenseNumber=@license")

        If SQL.HasException(True) Then Exit Sub

        MsgBox("Driver has been DELETED!", MsgBoxStyle.Information, "Successful!")
        delete_btn.Enabled = False
    End Sub

    Public Sub ClearFields()
        lastname_txtbx.Clear()
        firstname_txtbx.Clear()
        middlename_txtbx.Clear()
        address_txtbx.Clear()
        licenseNum_txtbx.Clear()
    End Sub

    Private Sub DriverWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindDriver()
    End Sub

    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        GetDriverDetails(driver_lb.Text)
        EnableFields()
        update_btn.Enabled = True
        delete_btn.Enabled = True
        edit_btn.Enabled = False
        newDriver_btn.Enabled = False
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Close()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        UpdateDriver()
        DisableFields()
        ClearFields()
    End Sub

    Private Sub driver_lb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles driver_lb.SelectedIndexChanged
        edit_btn.Enabled = True
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        DeleteUser()
        DisableFields()
        ClearFields()
    End Sub

    Private Sub search_txtbx_KeyDown(sender As Object, e As KeyEventArgs) Handles search_txtbx.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindDriver()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        DisableFields()
        ClearFields()
        update_btn.Enabled = False
        delete_btn.Enabled = False
    End Sub
End Class