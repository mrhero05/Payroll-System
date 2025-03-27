Imports MySql.Data.MySqlClient
Imports System.IO

Public Class updateemployee
    Dim da As New MySqlDataAdapter
    Dim con As New MySqlConnection
    Dim dtable As New DataTable
    Dim dataset As New DataSet
    Dim cmd As New MySqlCommand
    Dim gender As String
    Private Sub status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles find.Click
        If UEmployeecode.Text = Nothing Then

            MsgBox("Please Input Employee Code")
        Else
            Dim dr As MySqlDataReader
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            Try
                con.Open()

                cmd = New MySqlCommand("select * from Employee where Employeecode = " & UEmployeecode.Text & " ", con)
                dr = cmd.ExecuteReader

                While dr.Read
                    Dim ln = dr.GetString("LastName")
                    ULastname.Text = ln
                    Dim fn = dr.GetString("FirstName")
                    UFirstname.Text = fn
                    Dim mn = dr.GetString("MiddleName")
                    UMiddlename.Text = mn
                    Dim udob = dr.GetString("DateOfBirth")
                    UDateofbirth.Text = udob
                    Dim age = dr.GetString("Age")
                    UAge.Text = age
                    Dim gender = dr.GetString("Gender")
                    If gender = "Male" Then
                        RadioButton1.Checked = True
                        RadioButton2.Checked = False
                    ElseIf gender = "FeMale" Then
                        RadioButton1.Checked = False
                        RadioButton2.Checked = True
                    End If

                    Dim mstatus = dr.GetString("MaritalStatus")
                    UMaritalstatus.Text = mstatus

                    Dim numc = dr.GetString("NoOfChildren")
                    Unumchild.Text = numc
                    Dim add = dr.GetString("Address")
                    UAddress.Text = add
                    Dim cont = dr.GetString("ContactNumber")
                    UContactnum.Text = cont
                    Dim tel = dr.GetString("TelNumber")
                    UTelnum.Text = tel
                    Dim des = dr.GetString("Designation")
                    UDesignation.Text = des


                    Dim imagebytes As Byte() = CType(dr("image"), Byte())
                    Using ms As New IO.MemoryStream(imagebytes)
                        PictureBox1.Image = Image.FromStream(ms)
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    End Using


                End While

            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
            con.Close()
        End If

    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub updateemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub UMaritalstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UMaritalstatus.SelectedIndexChanged
        If UMaritalstatus.SelectedItem <> "Single" Then
            Unumchild.Enabled = True

        Else
            Unumchild.Enabled = False
            Unumchild.Text = "0"
        End If
    End Sub
    Sub refres()
        dataset.Clear()
        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()
        Try


            cmd = New MySqlCommand("Select EmployeeCode, concat(FirstName,' ',MiddleName,' ',LastName) as fullname  from Employee", con)
            da.SelectCommand = cmd
            da.Fill(dtable)
            da.Update(dtable)

            If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = dtable
                DataGridView1.Columns(0).DataPropertyName = "EmployeeCode"
                DataGridView1.Columns(1).DataPropertyName = "fullname"



            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        refres()



    End Sub
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim ans As DialogResult
        ans = MsgBox("Are you Sure Update Employee Info? ", MsgBoxStyle.YesNo)
        If ans = DialogResult.No Then

        ElseIf ans = DialogResult.Yes Then


            If UEmployeecode.Text = Nothing Then
                MsgBox("Please Select EmployeeCode")
            Else

                If PictureBox1.Image Is Nothing Then
                    MsgBox("Please Insert A Photo")
                Else

                    con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")

                    con.Open()
                    If (RadioButton1.Checked = True) Then
                        gender = "Male"
                    ElseIf (RadioButton2.Checked = True) Then
                        gender = "FeMale"
                    End If

                    Using ms As MemoryStream = New MemoryStream()

                        Dim bm As Bitmap = New Bitmap(PictureBox1.Image)
                        bm.Save(ms, PictureBox1.Image.RawFormat)

                        Dim arrPic() As Byte = ms.GetBuffer()

                        cmd = New MySqlCommand("Update Employee set LastName ='" & ULastname.Text & "', FirstName ='" & UFirstname.Text & "', MiddleName ='" & UMiddlename.Text & "', DateOfBirth ='" & UDateofbirth.Value.Date & "', Age ='" & UAge.Text & "', Gender ='" & gender & "', MaritalStatus ='" & UMaritalstatus.Text & "', NoOfChildren ='" & Unumchild.Text & "', Address ='" & UAddress.Text & "', ContactNumber ='" & UContactnum.Text & "', TelNumber ='" & UTelnum.Text & "', Designation ='" & UDesignation.Text & "', image = @image where EmployeeCode = " & UEmployeecode.Text & "", con)


                        With cmd
                            .Parameters.AddWithValue("@image", arrPic)
                            .ExecuteNonQuery()
                            MsgBox("Picture Updated")
                        End With

                    End Using



                    MsgBox("Update Success")
                    Dim command As String
                    Dim createhis As String
                    createhis = "Employee Record Updated with EmployeeCode =" + UEmployeecode.Text

                    Dim time1, date1 As String
                    date1 = Date.Now.ToString("dddd-MMMM-dd-yyyy")
                    time1 = Date.Now.ToString("hh:mm tt")

                    command = "insert into report (report_history,report_date,report_time) values ('" & createhis & "','" & date1 & "','" & time1 & "')"
                    Dim cmd1 As MySqlCommand = New MySqlCommand(command, con)
                    cmd1.ExecuteNonQuery()


                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        ULastname.Clear()
                        UFirstname.Clear()
                        UMiddlename.Clear()
                        UAge.Clear()
                        Unumchild.Clear()
                        UAddress.Clear()
                        UContactnum.Clear()
                        UTelnum.Clear()
                        UDesignation.Clear()


                        con.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try

                End If
                Me.Hide()
                View.Show()
            End If
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()


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