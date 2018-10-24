<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriverWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DriverWindow))
        Me.address_txtbx = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.bday_picker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.middlename_txtbx = New System.Windows.Forms.TextBox()
        Me.firstname_txtbx = New System.Windows.Forms.TextBox()
        Me.lastname_txtbx = New System.Windows.Forms.TextBox()
        Me.newDriver_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgv_driver = New System.Windows.Forms.DataGridView()
        Me.search_txtbx = New System.Windows.Forms.TextBox()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_driver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'address_txtbx
        '
        Me.address_txtbx.BackColor = System.Drawing.Color.White
        Me.address_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.address_txtbx.Enabled = False
        Me.address_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_txtbx.Location = New System.Drawing.Point(397, 25)
        Me.address_txtbx.Name = "address_txtbx"
        Me.address_txtbx.Size = New System.Drawing.Size(192, 78)
        Me.address_txtbx.TabIndex = 40
        Me.address_txtbx.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 24)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Driver's Information"
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.SystemColors.Window
        Me.save_btn.Enabled = False
        Me.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.Black
        Me.save_btn.Location = New System.Drawing.Point(16, 174)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(109, 32)
        Me.save_btn.TabIndex = 38
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = False
        '
        'bday_picker
        '
        Me.bday_picker.Enabled = False
        Me.bday_picker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bday_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.bday_picker.Location = New System.Drawing.Point(203, 80)
        Me.bday_picker.Name = "bday_picker"
        Me.bday_picker.Size = New System.Drawing.Size(130, 23)
        Me.bday_picker.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Birth Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(394, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Last Name"
        '
        'middlename_txtbx
        '
        Me.middlename_txtbx.BackColor = System.Drawing.SystemColors.Window
        Me.middlename_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.middlename_txtbx.Enabled = False
        Me.middlename_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename_txtbx.Location = New System.Drawing.Point(8, 80)
        Me.middlename_txtbx.Name = "middlename_txtbx"
        Me.middlename_txtbx.Size = New System.Drawing.Size(179, 23)
        Me.middlename_txtbx.TabIndex = 31
        '
        'firstname_txtbx
        '
        Me.firstname_txtbx.BackColor = System.Drawing.SystemColors.Window
        Me.firstname_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstname_txtbx.Enabled = False
        Me.firstname_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname_txtbx.Location = New System.Drawing.Point(203, 25)
        Me.firstname_txtbx.Name = "firstname_txtbx"
        Me.firstname_txtbx.Size = New System.Drawing.Size(177, 23)
        Me.firstname_txtbx.TabIndex = 30
        '
        'lastname_txtbx
        '
        Me.lastname_txtbx.BackColor = System.Drawing.SystemColors.Window
        Me.lastname_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastname_txtbx.Enabled = False
        Me.lastname_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname_txtbx.Location = New System.Drawing.Point(8, 25)
        Me.lastname_txtbx.Name = "lastname_txtbx"
        Me.lastname_txtbx.Size = New System.Drawing.Size(179, 23)
        Me.lastname_txtbx.TabIndex = 29
        '
        'newDriver_btn
        '
        Me.newDriver_btn.BackColor = System.Drawing.SystemColors.Window
        Me.newDriver_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.newDriver_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.newDriver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newDriver_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newDriver_btn.ForeColor = System.Drawing.Color.Black
        Me.newDriver_btn.Location = New System.Drawing.Point(300, 6)
        Me.newDriver_btn.Name = "newDriver_btn"
        Me.newDriver_btn.Size = New System.Drawing.Size(109, 32)
        Me.newDriver_btn.TabIndex = 38
        Me.newDriver_btn.Text = "New Driver"
        Me.newDriver_btn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.address_txtbx)
        Me.Panel1.Controls.Add(Me.bday_picker)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.middlename_txtbx)
        Me.Panel1.Controls.Add(Me.firstname_txtbx)
        Me.Panel1.Controls.Add(Me.lastname_txtbx)
        Me.Panel1.Location = New System.Drawing.Point(7, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 118)
        Me.Panel1.TabIndex = 41
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dgv_driver
        '
        Me.dgv_driver.AllowUserToAddRows = False
        Me.dgv_driver.AllowUserToDeleteRows = False
        Me.dgv_driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_driver.Location = New System.Drawing.Point(15, 261)
        Me.dgv_driver.Name = "dgv_driver"
        Me.dgv_driver.ReadOnly = True
        Me.dgv_driver.Size = New System.Drawing.Size(581, 206)
        Me.dgv_driver.TabIndex = 42
        '
        'search_txtbx
        '
        Me.search_txtbx.BackColor = System.Drawing.SystemColors.Window
        Me.search_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.search_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_txtbx.Location = New System.Drawing.Point(15, 228)
        Me.search_txtbx.Name = "search_txtbx"
        Me.search_txtbx.Size = New System.Drawing.Size(179, 23)
        Me.search_txtbx.TabIndex = 31
        '
        'search_btn
        '
        Me.search_btn.BackColor = System.Drawing.SystemColors.Window
        Me.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_btn.ForeColor = System.Drawing.Color.Black
        Me.search_btn.Location = New System.Drawing.Point(197, 223)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(109, 32)
        Me.search_btn.TabIndex = 38
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = False
        '
        'DriverWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(609, 479)
        Me.Controls.Add(Me.dgv_driver)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.newDriver_btn)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.search_txtbx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "DriverWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driver"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_driver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents address_txtbx As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents bday_picker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents middlename_txtbx As TextBox
    Friend WithEvents firstname_txtbx As TextBox
    Friend WithEvents lastname_txtbx As TextBox
    Friend WithEvents newDriver_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dgv_driver As DataGridView
    Friend WithEvents search_txtbx As TextBox
    Friend WithEvents search_btn As Button
End Class
