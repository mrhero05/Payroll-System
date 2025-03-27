Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim sss, phil, pagibig, tax As Double
    Dim daysworkf, otf, regratef, holratef As Double





    Dim restday As String
    Dim gender As String
    Dim workstatus As String


    Dim myconnection As MySqlConnection = New MySqlConnection
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tab As Integer
        tab = 1
        sss = 560
        phil = 192.5
        pagibig = 60
        tax = sss + phil + pagibig

        sss_d.Text = sss
        phil_d.Text = phil
        pagibig_d.Text = pagibig
        tax_d.Text = tax

        'Formula to compute the total rate per hour
        Dim rateperhr As Double
        rateperhr = 67.125
        regratef = 537
        daysworkf = 13
        otf = Math.Round(rateperhr * 1.25 * 1, 2)
        holratef = rateperhr * 1.3 * 8

        cash_ad.Text = 0
        holrate.Text = holratef
        regrate.Text = regratef
        otrate.Text = otf
        presentday.Text = daysworkf

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Maritalstatus.SelectedIndexChanged
        If Maritalstatus.SelectedItem <> "Single" Then
            numchild.Enabled = True

        Else
            numchild.Enabled = False
            numchild.Text = "0"
        End If
    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim currenttab As Int16

        currenttab = TabControl1.SelectedIndex
        currenttab = currenttab + 1
        If (currenttab < TabControl1.TabCount) Then

            TabControl1.SelectedIndex = currenttab

        End If







    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ans As DialogResult
        ans = MsgBox("Do you want to save info?", MsgBoxStyle.YesNo)

        If ans = DialogResult.No Then

        ElseIf ans = DialogResult.Yes Then

            If PictureBox1.Image Is Nothing Then
                MsgBox("Please Insert A Photo")
            Else

                If (rb_active.Checked = False) And (rb_resign.Checked = False) And (rb_retire.Checked = False) And (rb_terminate.Checked = False) Then
                    MessageBox.Show("Please Select Work Status")
                ElseIf (mon.Checked = False) And (tue.Checked = False) And (wed.Checked = False) And (thu.Checked = False) And (fri.Checked = False) And (sat.Checked = False) And (sun.Checked = False) Then
                    MessageBox.Show("Please Select Restday")

                Else

                    gender = "Male"
                    pro = "Server=127.0.0.1;Username=root;Password=;database=system"
                    connstring = pro
                    myconnection.ConnectionString = connstring
                    myconnection.Open()
                    If (RadioButton1.Checked = True) Then
                        gender = "Male"
                    ElseIf (RadioButton2.Checked = True) Then
                        gender = "FeMale"
                    End If


                    If (rb_active.Checked = True) Then
                        workstatus = "Active"
                    ElseIf (rb_resign.Checked = True) Then
                        workstatus = "Resigned"
                    ElseIf (rb_terminate.Checked = True) Then
                        workstatus = "Terminated"
                    ElseIf (rb_retire.Checked = True) Then
                        workstatus = "Retired"
                    End If


                    If (mon.Checked = True) Then
                        restday = "Monday"
                    ElseIf (tue.Checked = True) Then
                        restday = "Tuesday"
                    ElseIf (wed.Checked = True) Then
                        restday = "Wednesday"
                    ElseIf (thu.Checked = True) Then
                        restday = "Thursday"
                    ElseIf (fri.Checked = True) Then
                        restday = "Friday"
                    ElseIf (sat.Checked = True) Then
                        restday = "Saturday"
                    ElseIf (sun.Checked = True) Then
                        restday = "Sunday"
                    End If



                    command = "insert into employee (LastName,FirstName,MiddleName,DateOfBirth,Age,Gender,MaritalStatus,NoOfChildren,Address,ContactNumber,TelNumber,Designation,image,DateHired,WorkStatus,RestDay,SSS_ID,Tin_ID,Philhealth_ID,Pagibig_ID) values ('" & Lastname.Text & "','" & Firstname.Text & "','" & Middlename.Text & "','" & Dateofbirth.Value.Date & "','" & Age.Text & "','" & gender & "','" & Maritalstatus.Text & "','" & numchild.Text & "','" & Address.Text & "','" & Contactnum.Text & "','" & Telnum.Text & "','" & Designation.Text & "',@image,'" & datehired.Value.Date & "','" & workstatus & "','" & restday & "','" & sss_id.Text & "','" & tin_id.Text & "','" & phil_id.Text & "','" & pagibig_id.Text & "')"
                    Dim cmd As MySqlCommand = New MySqlCommand(command, myconnection)







                    cmd.Parameters.Add(New MySqlParameter("Last Name", CType(Lastname.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("First Name", CType(Firstname.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Middle Name", CType(Middlename.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Date Of Birth", CType(Dateofbirth.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Age", CType(Age.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Gender", CType(gender, String)))
                    cmd.Parameters.Add(New MySqlParameter("MaritalStatus", CType(Maritalstatus.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Number Of Children", CType(numchild.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Address", CType(Address.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Contact Number", CType(Contactnum.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Telephone Number", CType(Telnum.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Designation", CType(Designation.Text, String)))



                    Dim ms As New MemoryStream()
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    cmd.Parameters.AddWithValue("@image", ms.ToArray())

                    MsgBox("Picture Saved")



                    cmd.Parameters.Add(New MySqlParameter("DateHired", CType(datehired.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("WorkStatus", CType(workstatus, String)))
                    cmd.Parameters.Add(New MySqlParameter("RestDay", CType(restday, String)))
                    cmd.Parameters.Add(New MySqlParameter("SSS_ID", CType(sss_id.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Tin_ID", CType(tin_id.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Philhealth_ID", CType(phil_id.Text, String)))
                    cmd.Parameters.Add(New MySqlParameter("Pagibig_ID", CType(pagibig_id.Text, String)))

                    MsgBox("Employee Info Save")
                    MsgBox("Now Fillup Employee Salary Rate")


                    Dim createhis As String
                    createhis = "New Employee data added"

                    Dim time1, date1 As String
                    date1 = Date.Now.ToString("dddd-MMMM-dd-yyyy")
                    time1 = Date.Now.ToString("hh:mm tt")

                    command = "insert into report (report_history,report_date,report_time) values ('" & createhis & "','" & date1 & "','" & time1 & "')"
                    Dim cmd1 As MySqlCommand = New MySqlCommand(command, myconnection)
                    cmd1.ExecuteNonQuery()


                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        myconnection.Close()

                        Lastname.Clear()
                        Firstname.Clear()
                        Middlename.Clear()
                        Age.Clear()
                        numchild.Clear()
                        Address.Clear()
                        Contactnum.Clear()
                        Telnum.Clear()
                        Designation.Clear()
                        PictureBox1.Image = Nothing


                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Dim currenttab As Int16

                    currenttab = TabControl1.SelectedIndex
                    currenttab = currenttab + 1
                    If (currenttab < TabControl1.TabCount) Then

                        TabControl1.SelectedIndex = currenttab

                    End If


                End If

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ans As DialogResult
        ans = MsgBox("Do you want to save info?", MsgBoxStyle.YesNo)

        If ans = DialogResult.No Then

        ElseIf ans = DialogResult.Yes Then

            Dim con As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim command As String

            Dim dr1 As MySqlDataReader
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            cmd = New MySqlCommand("SELECT EmployeeCode FROM employee ORDER BY EmployeeCode DESC LIMIT 1", con)

            dr1 = cmd.ExecuteReader
            dr1.Read()

            Dim empcode = dr1.GetString("EmployeeCode")



            command = "insert into salary (days_work,EmployeeCode,RegularRate,OtRate,HolRate,sss_d,philheatlh_d,pagibig_d,tax_d,cashadvance_d) values ('" & presentday.Text & "','" & empcode & "','" & regrate.Text & "','" & otrate.Text & "','" & holrate.Text & "','" & sss_d.Text & "','" & phil_d.Text & "','" & pagibig_d.Text & "','" & tax_d.Text & "','" & cash_ad.Text & "')"
            Dim cmd1 As MySqlCommand = New MySqlCommand(command, con)


            cmd1.Parameters.Add(New MySqlParameter("days_work", CType(presentday.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("EmployeeCode", CType(empcode, String)))
            dr1.Close()

            cmd1.Parameters.Add(New MySqlParameter("RegularRate", CType(regrate.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("OtRate", CType(otrate.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("HolRate", CType(holrate.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("sss_d", CType(sss_d.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("philheatlh_d", CType(phil_d.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("pagibig_d", CType(pagibig_d.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("tax_d", CType(tax_d.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("cashadvance_d", CType(cash_ad.Text, String)))

            MsgBox("Salary Info Save")


            Try
                cmd1.ExecuteNonQuery()
                cmd1.Dispose()
                presentday.Clear()
                regrate.Clear()
                otrate.Clear()
                holrate.Clear()
                sss_d.Clear()
                phil_d.Clear()
                pagibig_d.Clear()
                tax_d.Clear()
                cash_ad.Clear()
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub rb_resign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_resign.CheckedChanged

    End Sub


    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint
       
    End Sub





    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.JPEG;*.GIF)|*.JPG;*.PNG;*.JPEG;*.GIF"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

        If PictureBox1.Image IsNot Nothing Then

        End If
    End Sub
End Class