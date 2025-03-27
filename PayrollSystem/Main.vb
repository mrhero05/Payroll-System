Imports System.Data.OleDb
Public Class Main
    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim time, date1 As String
        date1 = Date.Now.ToString("MMM-dd-yyyy")
        Datetoday.Text = date1

        time = Date.Now.ToString("hh:mm:ss tt")
        timetoday.Text = time

    End Sub

  

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        switchPanel(Form2)


    End Sub
    Sub switchPanel(ByVal panel As Form)
        Mainpanel.Controls.Clear()
        panel.TopLevel = False
        Mainpanel.Controls.Add(panel)
        panel.Show()


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        switchPanel(salary)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        switchPanel(View)
        
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        switchPanel(Settings)
    End Sub

  

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        switchPanel(report)

    End Sub

 
    Private Sub panelemployee_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelemployee.Paint
        If atype.Text = "Admin" Then
            madmin.Visible = True
            aamainp.Visible = False
            pmmainp.Visible = False
        ElseIf atype.Text = "Assistant Admin" Then
            madmin.Visible = False
            aamainp.Visible = True
            pmmainp.Visible = False

        ElseIf atype.Text = "Payroll Creator" Then
            madmin.Visible = False
            aamainp.Visible = False
            pmmainp.Visible = True

        End If
    End Sub
End Class
