Public Class SeconddPgLesson5
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        CommandBasicsFrm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        LessonFivefrm.Show()
        Me.Hide()

    End Sub
End Class