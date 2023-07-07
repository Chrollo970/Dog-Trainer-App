Public Class LessonSixFrm
    Private Sub picVidLesson6_Click(sender As Object, e As EventArgs) Handles picVidLesson6.Click
        System.Diagnostics.Process.Start("https://youtu.be/G3-hec29wII")
    End Sub

    Private Sub LessonSixFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picVidLesson6_MouseHover(sender As Object, e As EventArgs) Handles picVidLesson6.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picVidLesson6_MouseLeave(sender As Object, e As EventArgs) Handles picVidLesson6.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        SecondPageLesson6Frm.Show()
        Me.Hide()

    End Sub
End Class