Imports MySql.Data.MySqlClient

Public Class report
    Dim dataset As New DataSet
    Dim da As New MySqlDataAdapter
    Dim dtable As New DataTable

    Sub history()

        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand

        dtable.Clear()

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()

        cmd = New MySqlCommand("Select * from report", con)
        da.SelectCommand = cmd

        da.Fill(dtable)
        da.Update(dtable)

        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            DataGridView2.AutoGenerateColumns = False
            DataGridView2.DataSource = dtable
            DataGridView2.Columns(0).DataPropertyName = "report_code"
            DataGridView2.Columns(1).DataPropertyName = "report_history"
            DataGridView2.Columns(2).DataPropertyName = "report_date"
            DataGridView2.Columns(3).DataPropertyName = "report_time"

        End If
        con.Close()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        history()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class