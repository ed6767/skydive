Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loadx.show()
        Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        vid.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If worde.ForeColor = Color.Black Then

            worde.ForeColor = Color.LightGoldenrodYellow
        Else
            worde.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim read As New IO.StreamReader("C:\sdg.dat")
            Label3.Text = read.ReadLine
            read.Close()
        Catch ex As Exception
            MsgBox("Welcome to skydive! Please read the instruction manual for help")
        End Try
        Dim numb = InputBox("Type a number between 1 and 10")


        If numb = "1" Then
        ElseIf numb = "2" Then
            worde.Text = "Cool!"
            BackColor = Color.Black
            ForeColor = Color.Green
            PictureBox1.Image = My.Resources.sdcof
        ElseIf numb = "3" Then
            worde.Text = "BANNANA!!"
            BackColor = Color.YellowGreen
            PictureBox1.Image = My.Resources.sdb
        ElseIf numb = "4" Then
            worde.Text = "OMG!!"
        ElseIf numb = "5" Then
            worde.Text = "DISCO!!!!"
            BackColor = Color.IndianRed
            ForeColor = Color.LimeGreen
            PictureBox1.Image = My.Resources.sdd
        ElseIf numb = "6" Then
            worde.Text = "AHHHHHH!"
        ElseIf numb = "7" Then
            worde.Text = "?????!!!"
        ElseIf numb = "8" Then
            worde.Text = "$$$£££"
        ElseIf numb = "9" Then
            worde.Text = "HELLLLLLLLLOOOO!!!!"
        Else
            worde.Text = "@##~!"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Are you sure!?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Label3.Text = "0"
            Try
                Dim read As New IO.StreamReader("C:\sdg.dat")
                Label3.Text = read.ReadLine
                read.Close()
            Catch ex As Exception
                MsgBox("You have not played yet!")
            End Try
        End If

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        leab.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        MsgBox("Hacker opened!")
        hack.Show()
    End Sub

    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
End Class
