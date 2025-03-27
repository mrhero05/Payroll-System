Imports MySql.Data.MySqlClient
Public Class salary
    Dim basicpay1, rot1, hol1, totalern1, totald1, netpay1, dayswork1 As Double

    Dim tax, cashd, salaryd, sssl, pagibigl, otherl As Double

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
        If sid.Text = Nothing Then
            MsgBox("Please Input Employee Code")
        Else


            If holothrs.Text = Nothing Or regothrs.Text = Nothing Then
                MsgBox("Please Input value in OTHOURS if none put 0")
            Else
                Dim dwork, dabs, reg As Double
                dwork = dayswork.Text
                dabs = dayabsent.Text
                dayswork1 = dwork - dabs
                reg = regrate.Text

                basicpay1 = dayswork1 * reg
                basicpay.Text = basicpay1

                If regothrs.Text = 0 Then
                    rot1 = 0
                Else
                    rot1 = otrate.Text * regothrs.Text
                End If

                If holothrs.Text = 0 Then
                    hol1 = 0
                Else
                    hol1 = holrate.Text * holothrs.Text
                End If


                ot.Text = rot1 + hol1
                totalern1 = basicpay1 + ot.Text
                totalern.Text = totalern1

                tax = tax_d.Text
                cashd = cash_d.Text
                salaryd = salary_l.Text
                sssl = sss_l.Text
                pagibigl = pagibig_l.Text
                otherl = other_l.Text

                totald1 = tax + cashd + salaryd + sssl + pagibigl + otherl
                totald.Text = totald1

                netpay1 = totalern1 - totald1
                netpay.Text = netpay1
            End If
        End If
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Me.ToolTip1.SetToolTip(save, "This button will let you save your computed salary to database.")
        Me.ToolTip1.SetToolTip(Print, "This button will let you PRINT your computed salary to payslip.")
        If sid.Text = Nothing Then
            MsgBox("Please Input Employee Code")
        Else

            Dim con As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim dr As MySqlDataReader

            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            Try


                cmd = New MySqlCommand("SELECT * from employee natural join salary where EmployeeCode='" & sid.Text & "' ", con)
                dr = cmd.ExecuteReader

                While dr.Read
                    Dim fname = dr.GetString("FirstName")
                    Dim mname = dr.GetString("MiddleName")
                    Dim lname = dr.GetString("LastName")
                    Dim fullname = fname + " " + mname + " " + lname
                    sname.Text = fullname

                    Dim presentday = dr.GetString("days_work")
                    dayswork.Text = presentday
                    Dim rrate = dr.GetString("RegularRate")
                    regrate.Text = rrate
                    Dim otrate1 = dr.GetString("OtRate")
                    otrate.Text = otrate1
                    Dim holrate1 = dr.GetString("HolRate")
                    holrate.Text = holrate1
                    Dim sss = dr.GetString("sss_d")
                    sss_d.Text = sss
                    Dim phil = dr.GetString("philheatlh_d")
                    phil_d.Text = phil
                    Dim pagibig = dr.GetString("pagibig_d")
                    pagibig_d.Text = pagibig
                    Dim tax = dr.GetString("tax_d")
                    tax_d.Text = tax
                    Dim cash = dr.GetString("cashadvance_d")
                    cash_d.Text = cash

                    salary_l.Text = 0
                    sss_l.Text = 0
                    pagibig_l.Text = 0
                    other_l.Text = 0
                    regothrs.Text = 0
                    holothrs.Text = 0
                    dayabsent.Text = 0

                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()

        End If
    End Sub


    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If basicpay.Text = Nothing Or ot.Text = Nothing Or totalern.Text = Nothing Or totald.Text = Nothing Or netpay.Text = Nothing Then
            MsgBox("Please Click Compute First")
        Else

            Dim con As New MySqlConnection
            Dim dr As MySqlDataReader
            Dim command As String
            Dim cmd As MySqlCommand

            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")





            con.Open()
            cmd = New MySqlCommand("SELECT salary_code FROM salary where EmployeeCode=('" & sid.Text & "')", con)

            dr = cmd.ExecuteReader
            dr.Read()

            Dim scode = dr.GetString("salary_code")

            command = "insert into payslip (salary_code,basicpay,overtime,total_earnings,total_deduction,netpay,reg_ot_hrs,hol_ot_hrs,salary_loan,sss_loan,pagibig_loan,other_loan,days_absent) values ('" & scode & "','" & basicpay.Text & "','" & ot.Text & "','" & totalern.Text & "','" & totald.Text & "','" & netpay.Text & "','" & regothrs.Text & "','" & holothrs.Text & "','" & salary_l.Text & "','" & sss_l.Text & "','" & pagibig_l.Text & "','" & other_l.Text & "','" & dayabsent.Text & "')"
            Dim cmd1 As MySqlCommand = New MySqlCommand(command, con)


            cmd1.Parameters.Add(New MySqlParameter("salary_code", CType(scode, String)))
            cmd1.Parameters.Add(New MySqlParameter("basicpay", CType(basicpay.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("overtime", CType(ot.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("total_earnings", CType(totalern.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("total_deduction", CType(totald.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("netpay", CType(netpay.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("reg_ot_hrs", CType(regothrs.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("hol_ot_hrs", CType(holothrs.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("salary_loan", CType(salary_l.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("sss_loan", CType(sss_l.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("pagibig_loan", CType(pagibig_l.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("other_loan", CType(other_l.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("days_absent", CType(dayabsent.Text, String)))
            dr.Close()

            MsgBox("SAVED TO DATABASE")
            Try
                cmd1.ExecuteNonQuery()
                cmd1.Dispose()
                sid.Clear()
                basicpay.Clear()
                ot.Clear()
                totalern.Clear()
                totald.Clear()
                netpay.Clear()
                regothrs.Clear()
                holothrs.Clear()
                otrate.Clear()
                holrate.Clear()
                salary_l.Clear()
                sss_l.Clear()
                pagibig_l.Clear()
                other_l.Clear()
                dayabsent.Clear()
                dayswork.Clear()
                regrate.Clear()
                sss_d.Clear()
                phil_d.Clear()
                pagibig_d.Clear()
                tax_d.Clear()
                cash_d.Clear()
                sname.Clear()





            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()


        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Me.ToolTip1.SetToolTip(Button2, "Press to Compute Salary.")
        Me.ToolTip1.SetToolTip(Button1, "Find Employee ID")
        Me.ToolTip1.SetToolTip(save, "This button will let you SAVE your computed salary to database.")
        Me.ToolTip1.SetToolTip(Print, "This button will let you PRINT your computed salary to payslip.")
    End Sub
End Class