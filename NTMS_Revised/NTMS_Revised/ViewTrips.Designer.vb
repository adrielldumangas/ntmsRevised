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
        Me.dgv_schedule = New System.Windows.Forms.DataGridView()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.search_txtbx = New System.Windows.Forms.TextBox()
        CType(Me.dgv_schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_schedule
        '
        Me.dgv_schedule.AllowUserToAddRows = False
        Me.dgv_schedule.AllowUserToDeleteRows = False
        Me.dgv_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_schedule.Location = New System.Drawing.Point(12, 63)
        Me.dgv_schedule.Name = "dgv_schedule"
        Me.dgv_schedule.ReadOnly = True
        Me.dgv_schedule.Size = New System.Drawing.Size(581, 404)
        Me.dgv_schedule.TabIndex = 45
        '
        'search_btn
        '
        Me.search_btn.BackColor = System.Drawing.SystemColors.Window
        Me.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_btn.ForeColor = System.Drawing.Color.Black
        Me.search_btn.Location = New System.Drawing.Point(194, 16)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(109, 32)
        Me.search_btn.TabIndex = 44
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = False
        '
        'search_txtbx
        '
        Me.search_txtbx.BackColor = System.Drawing.SystemColors.Window
        Me.search_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.search_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_txtbx.Location = New System.Drawing.Point(12, 21)
        Me.search_txtbx.Name = "search_txtbx"
        Me.search_txtbx.Size = New System.Drawing.Size(179, 23)
        Me.search_txtbx.TabIndex = 43
        '
        'ViewTrips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(609, 479)
        Me.Controls.Add(Me.dgv_schedule)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.search_txtbx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ViewTrips"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View / Manage Trips"
        CType(Me.dgv_schedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_schedule As DataGridView
    Friend WithEvents search_btn As Button
    Friend WithEvents search_txtbx As TextBox
End Class
