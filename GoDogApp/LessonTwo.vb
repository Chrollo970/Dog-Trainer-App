Public Class LessonTwo
    Private Sub picVidLesson2_Click(sender As Object, e As EventArgs) Handles picVidLesson2.Click
        System.Diagnostics.Process.Start("https://youtu.be/WwhHINN_XZk")
    End Sub

    Private Sub picVidLesson2_MouseHover(sender As Object, e As EventArgs) Handles picVidLesson2.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picVidLesson2_MouseLeave(sender As Object, e As EventArgs) Handles picVidLesson2.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        CommandBasicsFrm.Show()
        Me.Hide()
    End Sub

    Private Sub LessonTwo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class