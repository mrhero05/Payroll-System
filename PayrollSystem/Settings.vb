Imports MySql.Data.MySqlClient

Public Class Settings
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vcode1.Click
        Dim admin As String
        admin = "admin"
        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")

        con.Open()

        Try
            cmd = New MySqlCommand("Update system set verification_code ='" & vcode.Text & "'  where id = 1", con)
            MsgBox("VERIFICATION CODE UPDATED")
            vcode.Clear()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(log, "Do you want to LOG-OUT?")
        If type.Text = "Admin" Then
            adminpic.Visible = True
            assistadminpic.Visible = False
            payrollmasterpic.Visible = False
        ElseIf type.Text = "Assistant Admin" Then
            adminpic.Visible = False
            assistadminpic.Visible = True
            payrollmasterpic.Visible = False

        ElseIf type.Text = "Payroll Creator" Then
            adminpic.Visible = False
            assistadminpic.Visible = False
            payrollmasterpic.Visible = True

        End If



    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log.Click
        Dim dialog As DialogResult
        dialog = MsgBox("Are you sure you want to logout? ", MsgBoxStyle.YesNo)
        If (dialog = DialogResult.Yes) Then
            Me.Hide()
            Main.Hide()
            con.Close()

            loginform.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f.Click
        Main.WindowState = FormWindowState.Maximized




    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles w.Click
        Main.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles light.Click
        Main.panelemployee.BackColor = Color.AntiqueWhite



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dark.Click
        Dim customColor As Color = Color.FromArgb(30, 37, 47)

        Main.panelemployee.BackColor = customColor


    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        Me.ToolTip1.SetToolTip(f, "Make System in FullScreen Mode")
        Me.ToolTip1.SetToolTip(w, "Make System in Windowed Mode")
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Me.ToolTip1.SetToolTip(light, "Make System in Light Theme Mode")
        Me.ToolTip1.SetToolTip(dark, "Make System in Dark Theme Mode")
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint
        Me.ToolTip1.SetToolTip(vcode1, "Update Verification Code?")
    End Sub
End Class