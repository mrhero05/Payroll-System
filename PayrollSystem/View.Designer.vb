<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Upanel = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.EmployeeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Designation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dayswork = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegularRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.OtRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sss_deduction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.philheatlh_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagibig_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cashadvance_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Upanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Upanel
        '
        Me.Upanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Upanel.Controls.Add(Me.DataGridView2)
        Me.Upanel.Controls.Add(Me.DataGridView1)
        Me.Upanel.Location = New System.Drawing.Point(12, 66)
        Me.Upanel.Name = "Upanel"
        Me.Upanel.Size = New System.Drawing.Size(735, 419)
        Me.Upanel.TabIndex = 47
        '
        'DataGridView1
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Location = New System.Drawing.Point(12, 14)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Size = New System.Drawing.Size(712, 390)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(488, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View All"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button9.Location = New System.Drawing.Point(395, 15)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(87, 34)
        Me.Button9.TabIndex = 42
        Me.Button9.Text = "Delete"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(85, 21)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(118, 25)
        Me.Search.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Search ID"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(209, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 34)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button3.Location = New System.Drawing.Point(302, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 34)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Upanel)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Search)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 497)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeCode, Me.LastName, Me.FirstName, Me.MiddleName, Me.Designation, Me.WorkStatus, Me.salary_code, Me.Dayswork, Me.RegularRate, Me.OtRate, Me.HolRate, Me.sss_deduction, Me.philheatlh_d, Me.pagibig_d, Me.tax_d, Me.cashadvance_d})
        Me.DataGridView2.Location = New System.Drawing.Point(12, 14)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Size = New System.Drawing.Size(712, 390)
        Me.DataGridView2.TabIndex = 3
        '
        'EmployeeCode
        '
        Me.EmployeeCode.HeaderText = "EmployeeCode"
        Me.EmployeeCode.Name = "EmployeeCode"
        Me.EmployeeCode.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'MiddleName
        '
        Me.MiddleName.HeaderText = "MiddleName"
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.ReadOnly = True
        '
        'Designation
        '
        Me.Designation.HeaderText = "Designation"
        Me.Designation.Name = "Designation"
        Me.Designation.ReadOnly = True
        '
        'WorkStatus
        '
        Me.WorkStatus.HeaderText = "WorkStatus"
        Me.WorkStatus.Name = "WorkStatus"
        Me.WorkStatus.ReadOnly = True
        '
        'salary_code
        '
        Me.salary_code.HeaderText = "salary_code"
        Me.salary_code.Name = "salary_code"
        Me.salary_code.ReadOnly = True
        '
        'Dayswork
        '
        Me.Dayswork.HeaderText = "Dayswork"
        Me.Dayswork.Name = "Dayswork"
        Me.Dayswork.ReadOnly = True
        '
        'RegularRate
        '
        Me.RegularRate.HeaderText = "RegularRate"
        Me.RegularRate.Name = "RegularRate"
        Me.RegularRate.ReadOnly = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(582, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 34)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Show Salary"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'OtRate
        '
        Me.OtRate.HeaderText = "OtRate"
        Me.OtRate.Name = "OtRate"
        Me.OtRate.ReadOnly = True
        '
        'HolRate
        '
        Me.HolRate.HeaderText = "HolRate"
        Me.HolRate.Name = "HolRate"
        Me.HolRate.ReadOnly = True
        '
        'sss_deduction
        '
        Me.sss_deduction.HeaderText = "sss deduction"
        Me.sss_deduction.Name = "sss_deduction"
        Me.sss_deduction.ReadOnly = True
        '
        'philheatlh_d
        '
        Me.philheatlh_d.HeaderText = "philheatlh deduction"
        Me.philheatlh_d.Name = "philheatlh_d"
        Me.philheatlh_d.ReadOnly = True
        '
        'pagibig_d
        '
        Me.pagibig_d.HeaderText = "pagibig deduction"
        Me.pagibig_d.Name = "pagibig_d"
        Me.pagibig_d.ReadOnly = True
        '
        'tax_d
        '
        Me.tax_d.HeaderText = "tax deduction"
        Me.tax_d.Name = "tax_d"
        Me.tax_d.ReadOnly = True
        '
        'cashadvance_d
        '
        Me.cashadvance_d.HeaderText = "cash advance"
        Me.cashadvance_d.Name = "cashadvance_d"
        Me.cashadvance_d.ReadOnly = True
        '
        'View
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(759, 497)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "te"
        Me.Upanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Upanel As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeeCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Designation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salary_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dayswork As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegularRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OtRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HolRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sss_deduction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents philheatlh_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pagibig_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tax_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cashadvance_d As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
