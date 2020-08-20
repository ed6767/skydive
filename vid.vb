Imports Skydive.My.Resources
Public Class vid

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If ListBox1.SelectedItem = "Jumpout" Then
            PictureBox1.Image = sdep
        ElseIf ListBox1.SelectedItem = "Old Fall" Then
            PictureBox1.Image = sdgid
        ElseIf ListBox1.SelectedItem = "Win" Then
            PictureBox1.Image = sdla
        ElseIf ListBox1.SelectedItem = "Fall" Then
            PictureBox1.Image = fall
        ElseIf ListBox1.SelectedItem = "I'm strong!" Then
            PictureBox1.Image = sdint
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            PictureBox1.Dock = DockStyle.None
            WindowState = FormWindowState.Normal
        Else
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            PictureBox1.Dock = DockStyle.Fill
            WindowState = FormWindowState.Maximized
        End If

    End Sub
End Class