<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Display
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Display))
        Me.dgv_display = New System.Windows.Forms.DataGridView()
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.day_lbl = New System.Windows.Forms.Label()
        Me.date_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_display
        '
        Me.dgv_display.AllowUserToAddRows = False
        Me.dgv_display.AllowUserToDeleteRows = False
        Me.dgv_display.AllowUserToResizeColumns = False
        Me.dgv_display.AllowUserToResizeRows = False
        Me.dgv_display.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgv_display.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.dgv_display.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_display.CausesValidation = False
        Me.dgv_display.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_display.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_display.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_display.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_display.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_display.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgv_display.Location = New System.Drawing.Point(42, 118)
        Me.dgv_display.Margin = New System.Windows.Forms.Padding(10, 10, 10, 50)
        Me.dgv_display.Name = "dgv_display"
        Me.dgv_display.ReadOnly = True
        Me.dgv_display.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_display.RowHeadersVisible = False
        Me.dgv_display.Size = New System.Drawing.Size(1179, 534)
        Me.dgv_display.TabIndex = 0
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.BackColor = System.Drawing.Color.Transparent
        Me.time_lbl.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_lbl.Location = New System.Drawing.Point(957, 19)
        Me.time_lbl.Margin = New System.Windows.Forms.Padding(3, 10, 10, 0)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(304, 56)
        Me.time_lbl.TabIndex = 1
        Me.time_lbl.Text = "00:00:00 AM"
        '
        'day_lbl
        '
        Me.day_lbl.AutoSize = True
        Me.day_lbl.BackColor = System.Drawing.Color.Transparent
        Me.day_lbl.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day_lbl.Location = New System.Drawing.Point(345, 19)
        Me.day_lbl.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.day_lbl.Name = "day_lbl"
        Me.day_lbl.Size = New System.Drawing.Size(303, 56)
        Me.day_lbl.TabIndex = 2
        Me.day_lbl.Text = "Wednesday"
        '
        'date_lbl
        '
        Me.date_lbl.AutoSize = True
        Me.date_lbl.BackColor = System.Drawing.Color.Transparent
        Me.date_lbl.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_lbl.Location = New System.Drawing.Point(648, 19)
        Me.date_lbl.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.Size = New System.Drawing.Size(296, 56)
        Me.date_lbl.TabIndex = 3
        Me.date_lbl.Text = "01 Jan 2018"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 56)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Departures"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(956, 659)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 59)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1264, 721)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.time_lbl)
        Me.Controls.Add(Me.day_lbl)
        Me.Controls.Add(Me.date_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_display)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Display"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display"
        CType(Me.dgv_display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_display As DataGridView
    Friend WithEvents time_lbl As Label
    Friend WithEvents day_lbl As Label
    Friend WithEvents date_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
