﻿Public Class LessonSixSecondPgFrmvb
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        LessonSixFrm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        CommandBasicsFrm.Show()
        Me.Hide()

    End Sub
End Class