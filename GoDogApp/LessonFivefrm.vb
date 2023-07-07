Public Class LessonFivefrm
    Private Sub LessonFivefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picVidLesson5_Click(sender As Object, e As EventArgs) Handles picVidLesson5.Click
        System.Diagnostics.Process.Start("https://youtu.be/df-uE9PB8rU")
    End Sub

    Private Sub picVidLesson5_MouseHover(sender As Object, e As EventArgs) Handles picVidLesson5.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picVidLesson5_MouseLeave(sender As Object, e As EventArgs) Handles picVidLesson5.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SeconddPgLesson5.Show()
        Me.Hide()
    End Sub
End Class