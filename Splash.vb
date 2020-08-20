Public Class Splash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Text = "" Then
            Label1.Text = "S"
        ElseIf Label1.Text = "S" Then
            Label1.Text = "SK"
        ElseIf Label1.Text = "SK" Then
            Label1.Text = "SKY"
        ElseIf Label1.Text = "SKY" Then
            Label1.Text = "SKYD"
        ElseIf Label1.Text = "SKYD" Then
            Label1.Text = "SKYDI"
        ElseIf Label1.Text = "SKYDI" Then
            Label1.Text = "SKYDIV"
        Else
            Label1.Text = "SKYDIVE"
            Timer1.Stop()
            Button1.Show()
            Button2.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label2.Hide()
        Timer1.Start()
        Timer2.Stop()
    End Sub
End Class