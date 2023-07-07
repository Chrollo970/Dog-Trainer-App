Public Class LessonThreeFrm
    Private Sub picVidLesson3_Click(sender As Object, e As EventArgs) Handles picVidLesson3.Click
        System.Diagnostics.Process.Start("https://youtu.be/U5-TAG8PEW0")
    End Sub

    Private Sub picVidLesson3_MouseHover(sender As Object, e As EventArgs) Handles picVidLesson3.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picVidLesson3_MouseLeave(sender As Object, e As EventArgs) Handles picVidLesson3.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        CommandBasicsFrm.Show()
        Me.Hide()
    End Sub
End Class