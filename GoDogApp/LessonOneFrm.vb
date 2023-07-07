Public Class LessonOneFrm
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub picVidLesson1_Click(sender As Object, e As EventArgs) Handles picVidLesson1.Click
        System.Diagnostics.Process.Start("https://youtu.be/TsVz8LbjwEA")
    End Sub

    Private Sub picVidLesson1_MouseHover(sender As Object, e As EventArgs) Handles picVidLesson1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picVidLesson1_MouseLeave(sender As Object, e As EventArgs) Handles picVidLesson1.MouseLeave
        Cursor = Cursors.Default

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        CommandBasicsFrm.Show()
        Me.Hide()
    End Sub
End Class