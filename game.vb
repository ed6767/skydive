Public Class game
    Dim count = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        score.Text += 1
        MPH.Text = Timer1.Interval / 1000
        altat.Text -= 1
        count += 1
        If count = 5 Then
            Timer1.Interval = 1750
        ElseIf count = 10 Then
            Timer1.Interval = 1500
        ElseIf count = 15 Then
            Timer1.Interval = 1250
        ElseIf count = 20 Then
            Timer1.Interval = 1000
        ElseIf count = 25 Then
            Timer1.Interval = 750
        ElseIf count = 30 Then
            Timer1.Interval = 500
        ElseIf count = 35 Then
            Timer1.Interval = 250
        ElseIf count = 40 Then
            Timer1.Interval = 125
        ElseIf count = 100 Then
            Timer1.Interval = 10
        ElseIf count = 200 Then
            Timer1.Interval = 1
            Walkytalky.Text = "Be ready to open the parashoot!"
        ElseIf count = 700 Then
            opbut.Show()
            Walkytalky.Text = "NOW!"
        ElseIf count = 900 Then
            opbut.Hide()
            Walkytalky.Text = "To late!"
        ElseIf count = 1000 Then

            died.Show()
            Timer1.Stop()

            ForeColor = Color.Green
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer7.Stop()
            Timer6.Stop()
            Timer8.Stop()
            Enabled = False
        End If
    End Sub

    Private Sub opbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opbut.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

      
        Button1.Text = "Don't save!"
        pause.Button1.Enabled = False
        pause.Button2.Enabled = False
        Button3.Hide()
        ProgressBar2.Hide()
        Label6.Text = ""
        score.Text += 500
        ProgressBar1.Hide()
        Button2.Hide()
        Label2.Text = ""
        MPH.Text = ""
        Label3.Text = ""
        balanceb.Hide()
        stablibu.Hide()
        exitbu.show()
        opbut.Hide()
        PictureBox1.Image = My.Resources.sdla
        alta.Text = ""
        altat.Text = ""
        Walkytalky.Text = "Great! Well done"
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub exitbu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbu.Click
        Dim write As New IO.StreamWriter("C:\sdg.dat")
        write.WriteLine(score.Text)
        write.Close()
       

        Dim read As New IO.StreamReader("C:\sdg.dat")
        Form1.Label3.Text = read.ReadLine
        read.Close()
        Close()
        Form1.Show()
    End Sub

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            balanceb.Value -= 1

        Catch ex As Exception
            count = 990
            Walkytalky.Text = "You have lost balance!!"
            score.Text -= 50
            stablibu.Hide()
            Timer2.Stop()
            Exit Sub
        End Try
        If balanceb.Value < 40 Then
            stablibu.Show()
            Walkytalky.Text = "You need to stablize"

        Else
            stablibu.Hide()
        End If

    End Sub

    Private Sub stablibu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stablibu.Click
        score.Text += 10
        Scoreadd(10)
        balanceb.Value = 100
        Walkytalky.Text = "Good!"
        stablibu.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Enabled = False
        Timer1.Stop()
        Timer3.Stop()
        Timer2.Stop()
        Timer4.Stop()
        Timer5.Stop()
        pause.showdialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Timer1.Interval /= 2
        Catch ex As Exception

            score.Text += 200
        End Try

        score.Text += 100
        Scoreadd(100)
        ProgressBar1.Value = 0
        Timer3.Start()
        Button2.Hide()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Try
            ProgressBar1.Value += 1
        Catch ex As Exception
            Timer3.Stop()
            Button2.Show()
        End Try
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        ProgressBar2.Value += 1
        If ProgressBar2.Value = 100 Then
            Timer4.Stop()
            Button3.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ProgressBar2.Value = 0
        score.Text *= 2
        Button3.Hide()
        Timer4.Start()
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If score.Text > 1999 Then
            Button4.Show()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Hide()
        score.Text *= 10
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If score.Text > 40000 Then
            Timer6.Stop()
            Button5.Show()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Hide()
        score.Text *= 500
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      

    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        Button4.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        Button5.Show()
    End Sub

    

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Interval = 10

    End Sub

    Private Sub game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub Scoreadd(ByVal score As Integer)
        Scoep.Text = "+" & score
        Timer9.Start()
        Scoep.Show()
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        Scoep.Hide()
        Timer9.Stop()
    End Sub
End Class