Public Class SignupWindow
    Public SQL As New SQLControl

    Private Sub InsertInfo()
        ' ADD PARAMETERS & RUN THE COMMAND
        SQL.AddParam("@lastname", lastname_txtbx.Text)
        SQL.AddParam("@firstname", firstname_txtbx.Text)
        SQL.AddParam("@middlename", middlename_txtbx.Text)
        SQL.AddParam("@birthdate", bday_picker.Text)
        SQL.AddParam("@contact", contactNum_txtbx.Text)
        SQL.AddParam("@username", username_txtbx.Text)
        SQL.AddParam("@password", password_txtbx.Text)

        SQL.ExecQuery("INSERT INTO UserCredential (Username,Password,LastName,FirstName,MiddleName,ContactNo,BirthDate) " &
                      "VALUES (@username,@password,@lastname,@firstname,@middlename,@contact,@birthdate);")

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        MsgBox("You are now registered!", MsgBoxStyle.Information, "Congratulations!")

    End Sub

    Private Sub signUp_btn_Click(sender As Object, e As EventArgs) Handles signUp_btn.Click
        If String.IsNullOrWhiteSpace(lastname_txtbx.Text) Or
            String.IsNullOrWhiteSpace(firstname_txtbx.Text) Or
            String.IsNullOrWhiteSpace(middlename_txtbx.Text) Or
            String.IsNullOrWhiteSpace(contactNum_txtbx.Text) Or
            String.IsNullOrWhiteSpace(username_txtbx.Text) Or
            String.IsNullOrWhiteSpace(password_txtbx.Text) Then

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
            LoginWindow.Show()
            Close()
        End If



    End Sub
End Class