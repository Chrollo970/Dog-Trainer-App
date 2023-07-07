Public Class TrustFrm
    Private Sub picVidTrust_Click(sender As Object, e As EventArgs) Handles picVidTrust.Click
        System.Diagnostics.Process.Start("https://youtu.be/cXN8Obr1yss")
    End Sub

    Private Sub picVidTrust_MouseHover(sender As Object, e As EventArgs) Handles picVidTrust.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picVidTrust_MouseLeave(sender As Object, e As EventArgs) Handles picVidTrust.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        TrustNTargeting.Show()
        Me.Hide()

    End Sub
End Class