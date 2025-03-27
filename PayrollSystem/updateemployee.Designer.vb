<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateemployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updateemployee))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unumchild = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UDesignation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.UTelnum = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.UContactnum = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UMaritalstatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UDateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.UAge = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.UMiddlename = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UFirstname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ULastname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UEmployeecode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.UAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.find = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employee_id, Me.full_name})
        Me.DataGridView1.Location = New System.Drawing.Point(521, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(245, 305)
        Me.DataGridView1.TabIndex = 11
        '
        'employee_id
        '
        Me.employee_id.HeaderText = "ID"
        Me.employee_id.Name = "employee_id"
        Me.employee_id.ReadOnly = True
        Me.employee_id.Width = 50
        '
        'full_name
        '
        Me.full_name.HeaderText = "FULLNAME"
        Me.full_name.Name = "full_name"
        Me.full_name.ReadOnly = True
        Me.full_name.Width = 150
        '
        'Unumchild
        '
        Me.Unumchild.Enabled = False
        Me.Unumchild.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unumchild.Location = New System.Drawing.Point(342, 255)
        Me.Unumchild.Name = "Unumchild"
        Me.Unumchild.Size = New System.Drawing.Size(44, 25)
        Me.Unumchild.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(318, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "No. of children"
        '
        'UDesignation
        '
        Me.UDesignation.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UDesignation.Location = New System.Drawing.Point(126, 416)
        Me.UDesignation.Name = "UDesignation"
        Me.UDesignation.Size = New System.Drawing.Size(149, 25)
        Me.UDesignation.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(42, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Designation"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Firebrick
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button10.Location = New System.Drawing.Point(601, 326)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(102, 31)
        Me.Button10.TabIndex = 42
        Me.Button10.Text = "Show Table"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Firebrick
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button8.Location = New System.Drawing.Point(392, 404)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(101, 37)
        Me.Button8.TabIndex = 40
        Me.Button8.Text = "Save"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'UTelnum
        '
        Me.UTelnum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UTelnum.Location = New System.Drawing.Point(126, 385)
        Me.UTelnum.Name = "UTelnum"
        Me.UTelnum.Size = New System.Drawing.Size(149, 25)
        Me.UTelnum.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label18.Location = New System.Drawing.Point(84, 388)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 17)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Tel #"
        '
        'UContactnum
        '
        Me.UContactnum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UContactnum.Location = New System.Drawing.Point(126, 354)
        Me.UContactnum.Name = "UContactnum"
        Me.UContactnum.Size = New System.Drawing.Size(149, 25)
        Me.UContactnum.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label17.Location = New System.Drawing.Point(56, 357)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Contact #"
        '
        'UMaritalstatus
        '
        Me.UMaritalstatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UMaritalstatus.FormattingEnabled = True
        Me.UMaritalstatus.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        Me.UMaritalstatus.Location = New System.Drawing.Point(208, 255)
        Me.UMaritalstatus.Name = "UMaritalstatus"
        Me.UMaritalstatus.Size = New System.Drawing.Size(86, 25)
        Me.UMaritalstatus.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label12.Location = New System.Drawing.Point(202, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 17)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Marital Status"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button7.Location = New System.Drawing.Point(408, 137)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 28)
        Me.Button7.TabIndex = 33
        Me.Button7.Text = "Upload"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Location = New System.Drawing.Point(392, 16)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(115, 116)
        Me.Panel8.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 116)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UDateofbirth
        '
        Me.UDateofbirth.CustomFormat = "MM-dd-yyyy"
        Me.UDateofbirth.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UDateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.UDateofbirth.Location = New System.Drawing.Point(126, 189)
        Me.UDateofbirth.Name = "UDateofbirth"
        Me.UDateofbirth.Size = New System.Drawing.Size(229, 25)
        Me.UDateofbirth.TabIndex = 31
        '
        'UAge
        '
        Me.UAge.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UAge.Location = New System.Drawing.Point(342, 98)
        Me.UAge.Name = "UAge"
        Me.UAge.Size = New System.Drawing.Size(44, 25)
        Me.UAge.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label16.Location = New System.Drawing.Point(304, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 17)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Age"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label14.Location = New System.Drawing.Point(33, 192)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Date Of Birth"
        '
        'UMiddlename
        '
        Me.UMiddlename.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UMiddlename.Location = New System.Drawing.Point(126, 158)
        Me.UMiddlename.Name = "UMiddlename"
        Me.UMiddlename.Size = New System.Drawing.Size(168, 25)
        Me.UMiddlename.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label9.Location = New System.Drawing.Point(34, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Middle Name"
        '
        'UFirstname
        '
        Me.UFirstname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UFirstname.Location = New System.Drawing.Point(126, 127)
        Me.UFirstname.Name = "UFirstname"
        Me.UFirstname.Size = New System.Drawing.Size(168, 25)
        Me.UFirstname.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(49, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "First Name"
        '
        'ULastname
        '
        Me.ULastname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULastname.Location = New System.Drawing.Point(126, 96)
        Me.ULastname.Name = "ULastname"
        Me.ULastname.Size = New System.Drawing.Size(168, 25)
        Me.ULastname.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label8.Location = New System.Drawing.Point(51, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Last Name"
        '
        'UEmployeecode
        '
        Me.UEmployeecode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UEmployeecode.Location = New System.Drawing.Point(126, 65)
        Me.UEmployeecode.Name = "UEmployeecode"
        Me.UEmployeecode.Size = New System.Drawing.Size(71, 25)
        Me.UEmployeecode.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label15.Location = New System.Drawing.Point(21, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Employee Code"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RadioButton2.Location = New System.Drawing.Point(128, 263)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 21)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RadioButton1.Location = New System.Drawing.Point(71, 263)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 21)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'UAddress
        '
        Me.UAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UAddress.Location = New System.Drawing.Point(126, 323)
        Me.UAddress.Name = "UAddress"
        Me.UAddress.Size = New System.Drawing.Size(381, 25)
        Me.UAddress.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label11.Location = New System.Drawing.Point(65, 326)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Address"
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.Label29)
        Me.Panel6.Location = New System.Drawing.Point(12, 21)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(175, 27)
        Me.Panel6.TabIndex = 52
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label29.Location = New System.Drawing.Point(19, 2)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(140, 21)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "Update Employee"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(47, 228)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(69, 29)
        Me.Panel2.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label13.Location = New System.Drawing.Point(4, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Gender"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button1.Location = New System.Drawing.Point(772, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 22)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'find
        '
        Me.find.Location = New System.Drawing.Point(216, 65)
        Me.find.Name = "find"
        Me.find.Size = New System.Drawing.Size(78, 24)
        Me.find.TabIndex = 55
        Me.find.Text = "Find"
        Me.find.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'updateemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(809, 481)
        Me.Controls.Add(Me.find)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Unumchild)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.UDesignation)
        Me.Controls.Add(Me.UAddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.UEmployeecode)
        Me.Controls.Add(Me.UTelnum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ULastname)
        Me.Controls.Add(Me.UContactnum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.UFirstname)
        Me.Controls.Add(Me.UMaritalstatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.UMiddlename)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.UDateofbirth)
        Me.Controls.Add(Me.UAge)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "updateemployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "updateemployee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Unumchild As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents UTelnum As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents UContactnum As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents UMaritalstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UDateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents UAge As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents UMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ULastname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents UEmployeecode As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents UAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents employee_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents full_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents find As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
