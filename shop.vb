Public Class shop

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If game.score.Text > 39999 Then
            game.Button5.Show()
            game.score.Text -= 40000
            Button9.Hide()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If game.score.Text > 1999 Then
            game.score.Text -= 2000
            game.Button4.Show()
            Button8.Hide()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If game.score.Text > 1022 Then
            game.score.Text -= 1023
            game.Timer4.Interval = 50
            Button7.Hide()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If game.score.Text > 166 Then
            game.score.Text -= 167
            game.Timer2.Interval = 1000
            Button1.Hide()
        End If
    End Sub
End Class