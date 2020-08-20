Public Class hack

    Private Sub hack_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Hide()
    End Sub

    Private Sub hack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = Form1.worde.Text
        TextBox4.Text = Form1.Label3.Text
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Form1.Label1.Text = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Form1.worde.Text = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Form1.Button1.Text = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Form1.Label3.Text = TextBox4.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim read As New IO.StreamReader("C:\sdg.dat")
            Form1.Label3.Text = read.ReadLine
            read.Close()
            Dim read2 As New IO.StreamReader("C:\sdg.dat")
            TextBox4.Text = read2.ReadLine
            read2.Close()
        Catch ex As Exception
            MsgBox("Oops! You haven't played yet")
        End Try
   
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim score = InputBox("New score!")
        If score = "" Then
            Exit Sub
        End If
        Try
            If MsgBox("Are you sure?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                Dim write As New IO.StreamWriter("C:\sdg.dat")
                write.WriteLine(score)
                write.Close()
                MsgBox("Hack complete! Press load last score to apply")
            End If
        Catch ex As Exception
            MsgBox("Oops! You haven't played yet")
        End Try
    End Sub

    Private Sub EventLog1_EntryWritten(ByVal sender As System.Object, ByVal e As System.Diagnostics.EntryWrittenEventArgs) Handles EventLog1.EntryWritten
        MsgBox(EventLog1.LogDisplayName)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        game.Show()
        game.Timer4.Interval = 100
        game.Hide()
    End Sub
End Class