Imports MySql.Data.MySqlClient


Public Class loginform


    Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
    Dim cmd As New MySqlCommand


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click

        If con.State = ConnectionState.Closed Then

            con.Open()

        End If

        Dim logincmd As New MySqlCommand("select username,password from system where username=@username and password=@password", con)


        logincmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.Text
        logincmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text


        Dim adapter As New MySqlDataAdapter(logincmd)
        Dim table As New DataTable()

        adapter.Fill(table)

        If username.Text = Nothing Or password.Text = Nothing Then
            MsgBox("Please Input Credentials ", MsgBoxStyle.Exclamation)

        End If
        If table.Rows.Count > 0 Then
            MsgBox("LOGIN SUCCESS" & vbNewLine & "LOGIN USER: " & username.Text, MsgBoxStyle.Information)

            Dim dr As MySqlDataReader
            cmd = New MySqlCommand("Select username,type,verification_code from system where username = '" & username.Text & "'", con)
            dr = cmd.ExecuteReader

            While dr.Read
                Dim user = dr.GetString("username")
                Settings.username.Text = user
                Dim Type1 = dr.GetString("type")
                Main.atype.Text = Type1
                Main.wtype.Text = Type1
                Settings.type.Text = Type1
                Dim vcode = dr.GetString("verification_code")
                Settings.vercode.Text = vcode




            End While
            Me.Hide()
            Main.Show()
            adapter.Dispose()
            dr.Close()

        Else
            MsgBox("INCORRECT USERNAME OR PASSWORD", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registerb.Click



        Me.Hide()
        registercode.Show()



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.TextChanged

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub
End Class