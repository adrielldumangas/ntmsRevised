<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupWindow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.password_txtbx = New System.Windows.Forms.TextBox()
        Me.username_txtbx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.signUp_btn = New System.Windows.Forms.Button()
        Me.bday_picker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contactNum_txtbx = New System.Windows.Forms.TextBox()
        Me.middlename_txtbx = New System.Windows.Forms.TextBox()
        Me.firstname_txtbx = New System.Windows.Forms.TextBox()
        Me.lastname_txtbx = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.password_txtbx)
        Me.Panel1.Controls.Add(Me.username_txtbx)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.signUp_btn)
        Me.Panel1.Controls.Add(Me.bday_picker)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.contactNum_txtbx)
        Me.Panel1.Controls.Add(Me.middlename_txtbx)
        Me.Panel1.Controls.Add(Me.firstname_txtbx)
        Me.Panel1.Controls.Add(Me.lastname_txtbx)
        Me.Panel1.Location = New System.Drawing.Point(22, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 500)
        Me.Panel1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Username"
        '
        'password_txtbx
        '
        Me.password_txtbx.BackColor = System.Drawing.Color.White
        Me.password_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txtbx.Location = New System.Drawing.Point(21, 394)
        Me.password_txtbx.Name = "password_txtbx"
        Me.password_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.password_txtbx.TabIndex = 6
        '
        'username_txtbx
        '
        Me.username_txtbx.BackColor = System.Drawing.Color.White
        Me.username_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.username_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txtbx.Location = New System.Drawing.Point(21, 341)
        Me.username_txtbx.Name = "username_txtbx"
        Me.username_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.username_txtbx.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "New User"
        '
        'signUp_btn
        '
        Me.signUp_btn.BackColor = System.Drawing.Color.Transparent
        Me.signUp_btn.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.signUp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.signUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signUp_btn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signUp_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.signUp_btn.Location = New System.Drawing.Point(65, 438)
        Me.signUp_btn.Name = "signUp_btn"
        Me.signUp_btn.Size = New System.Drawing.Size(109, 48)
        Me.signUp_btn.TabIndex = 7
        Me.signUp_btn.Text = "Sign Up"
        Me.signUp_btn.UseVisualStyleBackColor = False
        '
        'bday_picker
        '
        Me.bday_picker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bday_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.bday_picker.Location = New System.Drawing.Point(21, 225)
        Me.bday_picker.Name = "bday_picker"
        Me.bday_picker.Size = New System.Drawing.Size(200, 23)
        Me.bday_picker.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Birth Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Contact Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Last Name"
        '
        'contactNum_txtbx
        '
        Me.contactNum_txtbx.BackColor = System.Drawing.Color.White
        Me.contactNum_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.contactNum_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNum_txtbx.Location = New System.Drawing.Point(21, 278)
        Me.contactNum_txtbx.Name = "contactNum_txtbx"
        Me.contactNum_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.contactNum_txtbx.TabIndex = 4
        '
        'middlename_txtbx
        '
        Me.middlename_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.middlename_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.middlename_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename_txtbx.Location = New System.Drawing.Point(21, 172)
        Me.middlename_txtbx.Name = "middlename_txtbx"
        Me.middlename_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.middlename_txtbx.TabIndex = 2
        '
        'firstname_txtbx
        '
        Me.firstname_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.firstname_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstname_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname_txtbx.Location = New System.Drawing.Point(21, 119)
        Me.firstname_txtbx.Name = "firstname_txtbx"
        Me.firstname_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.firstname_txtbx.TabIndex = 1
        '
        'lastname_txtbx
        '
        Me.lastname_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.lastname_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastname_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname_txtbx.Location = New System.Drawing.Point(21, 66)
        Me.lastname_txtbx.Name = "lastname_txtbx"
        Me.lastname_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.lastname_txtbx.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SignupWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 491)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SignupWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents password_txtbx As TextBox
    Friend WithEvents username_txtbx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents signUp_btn As Button
    Friend WithEvents bday_picker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents contactNum_txtbx As TextBox
    Friend WithEvents middlename_txtbx As TextBox
    Friend WithEvents firstname_txtbx As TextBox
    Friend WithEvents lastname_txtbx As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
