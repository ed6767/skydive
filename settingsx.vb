Public Class settingsx

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "Normal" Then
            game.Timer2.Interval = 100
        ElseIf ListBox1.SelectedItem = "Hard" Then
            game.Timer2.Interval = 60
        ElseIf ListBox1.SelectedItem = "HARDCORE" Then
            game.Timer2.Interval = 25
        End If
        MsgBox("Settings apply to this fall only!")
        Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Dim color As New ColorDialog
        color.Color = game.ForeColor
        color.ShowDialog()
        game.ForeColor = color.Color

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dim color As New ColorDialog
        color.Color = game.BackColor
        color.ShowDialog()
        game.BackColor = color.Color
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class