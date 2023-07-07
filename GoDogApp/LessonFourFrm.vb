Public Class LessonFourFrm
    Private Sub picVidLesson4_Click(sender As Object, e As EventArgs) Handles picVidLesson4.Click
        System.Diagnostics.Process.Start("https://youtu.be/awPkk7NjUjc")
    End Sub

    Private Sub LessonFourFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picVidLesson4_MouseHover(sender As Object, e As EventArgs) Handles picVidLesson4.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picVidLesson4_MouseLeave(sender As Object, e As EventArgs) Handles picVidLesson4.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        CommandBasicsFrm.Show()
        Me.Hide()
    End Sub
End Class