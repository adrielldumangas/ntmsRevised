<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.firstName_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.dateTime_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.display_btn = New System.Windows.Forms.Button()
        Me.viewTrips_btn = New System.Windows.Forms.Button()
        Me.newSched_btn = New System.Windows.Forms.Button()
        Me.addDriver_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 29)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Monitoring"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 29)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Terminal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(30, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Naval"
        '
        'firstName_label
        '
        Me.firstName_label.AutoSize = True
        Me.firstName_label.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName_label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.firstName_label.Location = New System.Drawing.Point(31, 72)
        Me.firstName_label.Name = "firstName_label"
        Me.firstName_label.Size = New System.Drawing.Size(77, 24)
        Me.firstName_label.TabIndex = 1
        Me.firstName_label.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(31, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hello,"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cancel_btn)
        Me.Panel1.Controls.Add(Me.dateTime_lbl)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.firstName_label)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 480)
        Me.Panel1.TabIndex = 1
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
        Me.cancel_btn.Location = New System.Drawing.Point(12, 404)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(101, 31)
        Me.cancel_btn.TabIndex = 53
        Me.cancel_btn.Text = "Logout"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'dateTime_lbl
        '
        Me.dateTime_lbl.AutoSize = True
        Me.dateTime_lbl.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTime_lbl.Location = New System.Drawing.Point(10, 452)
        Me.dateTime_lbl.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.dateTime_lbl.Name = "dateTime_lbl"
        Me.dateTime_lbl.Size = New System.Drawing.Size(77, 18)
        Me.dateTime_lbl.TabIndex = 7
        Me.dateTime_lbl.Text = "DateTime"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(35, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Terminal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(35, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Naval"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'display_btn
        '
        Me.display_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.display_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.display_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.display_btn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display_btn.Image = CType(resources.GetObject("display_btn.Image"), System.Drawing.Image)
        Me.display_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.display_btn.Location = New System.Drawing.Point(434, 263)
        Me.display_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.display_btn.Name = "display_btn"
        Me.display_btn.Size = New System.Drawing.Size(123, 132)
        Me.display_btn.TabIndex = 8
        Me.display_btn.Text = "Display Trips"
        Me.display_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.display_btn.UseVisualStyleBackColor = False
        '
        'viewTrips_btn
        '
        Me.viewTrips_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.viewTrips_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.viewTrips_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewTrips_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewTrips_btn.Image = CType(resources.GetObject("viewTrips_btn.Image"), System.Drawing.Image)
        Me.viewTrips_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.viewTrips_btn.Location = New System.Drawing.Point(252, 263)
        Me.viewTrips_btn.Margin = New System.Windows.Forms.Padding(10)
        Me.viewTrips_btn.Name = "viewTrips_btn"
        Me.viewTrips_btn.Size = New System.Drawing.Size(123, 132)
        Me.viewTrips_btn.TabIndex = 9
        Me.viewTrips_btn.Text = "View/ Manage Trips"
        Me.viewTrips_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.viewTrips_btn.UseVisualStyleBackColor = False
        '
        'newSched_btn
        '
        Me.newSched_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.newSched_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.newSched_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newSched_btn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newSched_btn.Image = CType(resources.GetObject("newSched_btn.Image"), System.Drawing.Image)
        Me.newSched_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.newSched_btn.Location = New System.Drawing.Point(434, 76)
        Me.newSched_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.newSched_btn.Name = "newSched_btn"
        Me.newSched_btn.Size = New System.Drawing.Size(123, 132)
        Me.newSched_btn.TabIndex = 10
        Me.newSched_btn.Text = "New Schedule"
        Me.newSched_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.newSched_btn.UseVisualStyleBackColor = False
        '
        'addDriver_btn
        '
        Me.addDriver_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.addDriver_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.addDriver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addDriver_btn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addDriver_btn.Image = CType(resources.GetObject("addDriver_btn.Image"), System.Drawing.Image)
        Me.addDriver_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.addDriver_btn.Location = New System.Drawing.Point(252, 76)
        Me.addDriver_btn.Margin = New System.Windows.Forms.Padding(10)
        Me.addDriver_btn.Name = "addDriver_btn"
        Me.addDriver_btn.Size = New System.Drawing.Size(123, 132)
        Me.addDriver_btn.TabIndex = 11
        Me.addDriver_btn.Text = "Driver"
        Me.addDriver_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.addDriver_btn.UseVisualStyleBackColor = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(609, 479)
        Me.Controls.Add(Me.display_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.viewTrips_btn)
        Me.Controls.Add(Me.newSched_btn)
        Me.Controls.Add(Me.addDriver_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NTMS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents firstName_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dateTime_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents display_btn As Button
    Friend WithEvents viewTrips_btn As Button
    Friend WithEvents newSched_btn As Button
    Friend WithEvents addDriver_btn As Button
    Friend WithEvents cancel_btn As Button
End Class
