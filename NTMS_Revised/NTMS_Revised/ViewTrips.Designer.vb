<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTrips
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTrips))
        Me.search_txtbx = New System.Windows.Forms.TextBox()
        Me.travelNum_txtbx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.vehicleType_cb = New System.Windows.Forms.ComboBox()
        Me.time_cb = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.plateNum_txtbx = New System.Windows.Forms.TextBox()
        Me.route_txtbx = New System.Windows.Forms.TextBox()
        Me.driver_txtbx = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fare_txtbx = New System.Windows.Forms.TextBox()
        Me.status_cb = New System.Windows.Forms.ComboBox()
        Me.trip_lb = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'search_txtbx
        '
        Me.search_txtbx.BackColor = System.Drawing.SystemColors.Window
        Me.search_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.search_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_txtbx.Location = New System.Drawing.Point(47, 42)
        Me.search_txtbx.Name = "search_txtbx"
        Me.search_txtbx.Size = New System.Drawing.Size(179, 23)
        Me.search_txtbx.TabIndex = 43
        '
        'travelNum_txtbx
        '
        Me.travelNum_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.travelNum_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.travelNum_txtbx.Enabled = False
        Me.travelNum_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.travelNum_txtbx.Location = New System.Drawing.Point(21, 52)
        Me.travelNum_txtbx.Name = "travelNum_txtbx"
        Me.travelNum_txtbx.Size = New System.Drawing.Size(106, 23)
        Me.travelNum_txtbx.TabIndex = 31
        Me.travelNum_txtbx.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Travel Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(153, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Time"
        '
        'update_btn
        '
        Me.update_btn.BackColor = System.Drawing.Color.Transparent
        Me.update_btn.Enabled = False
        Me.update_btn.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.update_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_btn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.update_btn.Location = New System.Drawing.Point(79, 387)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(109, 48)
        Me.update_btn.TabIndex = 8
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = False
        '
        'vehicleType_cb
        '
        Me.vehicleType_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.vehicleType_cb.Enabled = False
        Me.vehicleType_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleType_cb.FormattingEnabled = True
        Me.vehicleType_cb.Location = New System.Drawing.Point(21, 110)
        Me.vehicleType_cb.Name = "vehicleType_cb"
        Me.vehicleType_cb.Size = New System.Drawing.Size(106, 25)
        Me.vehicleType_cb.TabIndex = 3
        '
        'time_cb
        '
        Me.time_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.time_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_cb.FormattingEnabled = True
        Me.time_cb.Location = New System.Drawing.Point(156, 50)
        Me.time_cb.Name = "time_cb"
        Me.time_cb.Size = New System.Drawing.Size(80, 25)
        Me.time_cb.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Vehicle Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Plate Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Fare"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Route"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Driver"
        '
        'plateNum_txtbx
        '
        Me.plateNum_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.plateNum_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plateNum_txtbx.Enabled = False
        Me.plateNum_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plateNum_txtbx.Location = New System.Drawing.Point(21, 173)
        Me.plateNum_txtbx.Name = "plateNum_txtbx"
        Me.plateNum_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.plateNum_txtbx.TabIndex = 31
        Me.plateNum_txtbx.TabStop = False
        '
        'route_txtbx
        '
        Me.route_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.route_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.route_txtbx.Enabled = False
        Me.route_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.route_txtbx.Location = New System.Drawing.Point(21, 231)
        Me.route_txtbx.Name = "route_txtbx"
        Me.route_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.route_txtbx.TabIndex = 31
        Me.route_txtbx.TabStop = False
        '
        'driver_txtbx
        '
        Me.driver_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.driver_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.driver_txtbx.Enabled = False
        Me.driver_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.driver_txtbx.Location = New System.Drawing.Point(21, 288)
        Me.driver_txtbx.Name = "driver_txtbx"
        Me.driver_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.driver_txtbx.TabIndex = 31
        Me.driver_txtbx.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.travelNum_txtbx)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.driver_txtbx)
        Me.GroupBox1.Controls.Add(Me.update_btn)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.route_txtbx)
        Me.GroupBox1.Controls.Add(Me.time_cb)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.fare_txtbx)
        Me.GroupBox1.Controls.Add(Me.plateNum_txtbx)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.status_cb)
        Me.GroupBox1.Controls.Add(Me.vehicleType_cb)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(299, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 451)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trip Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Status"
        '
        'fare_txtbx
        '
        Me.fare_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.fare_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fare_txtbx.Enabled = False
        Me.fare_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fare_txtbx.Location = New System.Drawing.Point(156, 110)
        Me.fare_txtbx.Name = "fare_txtbx"
        Me.fare_txtbx.Size = New System.Drawing.Size(80, 23)
        Me.fare_txtbx.TabIndex = 31
        Me.fare_txtbx.TabStop = False
        '
        'status_cb
        '
        Me.status_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.status_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_cb.FormattingEnabled = True
        Me.status_cb.Items.AddRange(New Object() {"Boarding", "Canceled", "Departed", "Delayed"})
        Me.status_cb.Location = New System.Drawing.Point(21, 342)
        Me.status_cb.Name = "status_cb"
        Me.status_cb.Size = New System.Drawing.Size(200, 25)
        Me.status_cb.TabIndex = 3
        '
        'trip_lb
        '
        Me.trip_lb.FormattingEnabled = True
        Me.trip_lb.Location = New System.Drawing.Point(47, 77)
        Me.trip_lb.Name = "trip_lb"
        Me.trip_lb.Size = New System.Drawing.Size(179, 355)
        Me.trip_lb.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Search Trip"
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.Color.Transparent
        Me.cancel_btn.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.cancel_btn.FlatAppearance.BorderSize = 0
        Me.cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.cancel_btn.Location = New System.Drawing.Point(85, 438)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(101, 31)
        Me.cancel_btn.TabIndex = 53
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'ViewTrips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(609, 479)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.trip_lb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.search_txtbx)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ViewTrips"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View / Manage Trips"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents search_txtbx As TextBox
    Friend WithEvents travelNum_txtbx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents update_btn As Button
    Friend WithEvents vehicleType_cb As ComboBox
    Friend WithEvents time_cb As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents plateNum_txtbx As TextBox
    Friend WithEvents route_txtbx As TextBox
    Friend WithEvents driver_txtbx As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents status_cb As ComboBox
    Friend WithEvents fare_txtbx As TextBox
    Friend WithEvents trip_lb As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cancel_btn As Button
End Class
