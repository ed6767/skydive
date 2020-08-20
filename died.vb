Public Class died

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
        game.Close()
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Opacity += 0.01
     
     

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer1.Stop()
        game.Close()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        MsgBox("You died by loosing balance or forgetting to open your parashoot!")
    End Sub

    Private Sub died_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
        game.Close()
    End Sub

    Private Sub died_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

        Close()
    End Sub
End Class