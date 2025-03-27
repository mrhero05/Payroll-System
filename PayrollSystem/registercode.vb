Imports MySql.Data.MySqlClient
Public Class registercode
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub registercode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        loginform.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As MySqlDataReader
        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()
        cmd = New MySqlCommand("select verification_code from system where id = 1", con)

        dr = cmd.ExecuteReader
        dr.Read()

        Dim code1 = dr.GetString("verification_code")

        If code.Text = code1 Then
            MsgBox("CODE VERIFIED!")
            Me.Hide()
            register.Show()

        Else
            MsgBox("INVALID CODE!")
        End If
        con.Close()
    End Sub


End Class