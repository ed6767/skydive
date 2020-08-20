Public Class jumpout

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        game.show()
        Close()
    End Sub
End Class