Public Class LoginWindow
    Public SQL As New SQLControl

    Public FirstName As String

    Private Sub Clear()
        password_txtbx.Clear()
        username_txtbx.Focus()
        username_txtbx.SelectAll()
    End Sub

    Private Sub Login()
        SQL.ExecQuery("SELECT * FROM UserCredential WHERE Username='" & username_txtbx.Text &
                      "' AND Password = '" & password_txtbx.Text & "';")

        If SQL.RecordCount <> 0 Then
            Dim Username As String = SQL.DBDT.Rows(0)("Username").ToString
            Dim Password As String = SQL.DBDT.Rows(0)("Password").ToString

            If String.Equals(Username, username_txtbx.Text) And String.Equals(Password, password_txtbx.Text) Then
                FirstName = SQL.DBDT.Rows(0)("FirstName").ToString
                MainWindow.Show()
                Close()
            Else
                MsgBox("Invalid Username/Password!", MsgBoxStyle.Critical, "Error")
                Clear()

            End If

        Else
            MsgBox("Invalid Username/Password!", MsgBoxStyle.Critical, "Error")
            Clear()

        End If
    End Sub

    Private Sub LoginWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadGrid()
        'dgvData.RowHeadersVisible = False
        AcceptButton = login_btn
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Login()

    End Sub

    Private Sub signUp_btn_Click(sender As Object, e As EventArgs) Handles signUp_btn.Click
        SignupWindow.Show()
        Close()
    End Sub
End Class
