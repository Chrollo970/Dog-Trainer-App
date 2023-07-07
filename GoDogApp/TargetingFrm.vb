Public Class TargetingFrm
    Private Sub picVidTargeting_Click(sender As Object, e As EventArgs) Handles picVidTargeting.Click
        System.Diagnostics.Process.Start("https://youtu.be/RWSJVwZybwo")
    End Sub

    Private Sub picVidTargeting_MouseHover(sender As Object, e As EventArgs) Handles picVidTargeting.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picVidTargeting_MouseLeave(sender As Object, e As EventArgs) Handles picVidTargeting.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        TrustNTargeting.Show()
        Me.Hide()

    End Sub
End Class