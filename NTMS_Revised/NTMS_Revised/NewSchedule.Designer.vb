<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewSchedule))
        Me.driver_cb = New System.Windows.Forms.ComboBox()
        Me.route_cb = New System.Windows.Forms.ComboBox()
        Me.time_cb = New System.Windows.Forms.ComboBox()
        Me.fare_cb = New System.Windows.Forms.ComboBox()
        Me.vehicleType_cb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.depart_date_picker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.travelNum_txtbx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.plateNum_cb = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'driver_cb
        '
        Me.driver_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.driver_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.driver_cb.FormattingEnabled = True
        Me.driver_cb.Location = New System.Drawing.Point(17, 300)
        Me.driver_cb.Name = "driver_cb"
        Me.driver_cb.Size = New System.Drawing.Size(200, 25)
        Me.driver_cb.TabIndex = 7
        '
        'route_cb
        '
        Me.route_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.route_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.route_cb.FormattingEnabled = True
        Me.route_cb.Location = New System.Drawing.Point(17, 243)
        Me.route_cb.Name = "route_cb"
        Me.route_cb.Size = New System.Drawing.Size(200, 25)
        Me.route_cb.TabIndex = 6
        '
        'time_cb
        '
        Me.time_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.time_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_cb.FormattingEnabled = True
        Me.time_cb.Location = New System.Drawing.Point(138, 75)
        Me.time_cb.Name = "time_cb"
        Me.time_cb.Size = New System.Drawing.Size(80, 25)
        Me.time_cb.TabIndex = 2
        '
        'fare_cb
        '
        Me.fare_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.fare_cb.DisplayMember = "Fae"
        Me.fare_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fare_cb.FormattingEnabled = True
        Me.fare_cb.Location = New System.Drawing.Point(138, 130)
        Me.fare_cb.Name = "fare_cb"
        Me.fare_cb.Size = New System.Drawing.Size(80, 25)
        Me.fare_cb.TabIndex = 4
        '
        'vehicleType_cb
        '
        Me.vehicleType_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.vehicleType_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleType_cb.FormattingEnabled = True
        Me.vehicleType_cb.Location = New System.Drawing.Point(17, 130)
        Me.vehicleType_cb.Name = "vehicleType_cb"
        Me.vehicleType_cb.Size = New System.Drawing.Size(106, 25)
        Me.vehicleType_cb.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 24)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "New Schedule"
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.Color.Transparent
        Me.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_btn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.save_btn.Location = New System.Drawing.Point(55, 371)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(109, 48)
        Me.save_btn.TabIndex = 8
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = False
        '
        'depart_date_picker
        '
        Me.depart_date_picker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depart_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.depart_date_picker.Location = New System.Drawing.Point(17, 77)
        Me.depart_date_picker.Name = "depart_date_picker"
        Me.depart_date_picker.Size = New System.Drawing.Size(106, 23)
        Me.depart_date_picker.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Departure Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Travel Number"
        '
        'travelNum_txtbx
        '
        Me.travelNum_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.travelNum_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.travelNum_txtbx.Enabled = False
        Me.travelNum_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.travelNum_txtbx.Location = New System.Drawing.Point(17, 22)
        Me.travelNum_txtbx.Name = "travelNum_txtbx"
        Me.travelNum_txtbx.Size = New System.Drawing.Size(106, 23)
        Me.travelNum_txtbx.TabIndex = 31
        Me.travelNum_txtbx.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Driver"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Route"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Fare"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Plate No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Vehicle Type"
        '
        'plateNum_cb
        '
        Me.plateNum_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.plateNum_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plateNum_cb.FormattingEnabled = True
        Me.plateNum_cb.Location = New System.Drawing.Point(17, 188)
        Me.plateNum_cb.Name = "plateNum_cb"
        Me.plateNum_cb.Size = New System.Drawing.Size(200, 25)
        Me.plateNum_cb.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.driver_cb)
        Me.Panel1.Controls.Add(Me.plateNum_cb)
        Me.Panel1.Controls.Add(Me.route_cb)
        Me.Panel1.Controls.Add(Me.time_cb)
        Me.Panel1.Controls.Add(Me.fare_cb)
        Me.Panel1.Controls.Add(Me.vehicleType_cb)
        Me.Panel1.Controls.Add(Me.save_btn)
        Me.Panel1.Controls.Add(Me.depart_date_picker)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.travelNum_txtbx)
        Me.Panel1.Location = New System.Drawing.Point(31, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 434)
        Me.Panel1.TabIndex = 51
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'NewSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 491)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NewSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents driver_cb As ComboBox
    Friend WithEvents route_cb As ComboBox
    Friend WithEvents time_cb As ComboBox
    Friend WithEvents fare_cb As ComboBox
    Friend WithEvents vehicleType_cb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents depart_date_picker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents travelNum_txtbx As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents plateNum_cb As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
