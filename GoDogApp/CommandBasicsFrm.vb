Public Class CommandBasicsFrm


    Private Sub CommandBasicsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picNameLesson_Click(sender As Object, e As EventArgs) Handles picNameLesson.Click
        LessonOneFrm.Show()
        Me.Hide()

    End Sub


    Private Sub picSitLesson_Click(sender As Object, e As EventArgs) Handles picSitLesson.Click
        LessonTwo.Show()
        Me.Hide()
    End Sub

    Private Sub picDownLesson_Click(sender As Object, e As EventArgs) Handles picDownLesson.Click
        LessonThreeFrm.Show()
        Me.Hide()
    End Sub

    Private Sub picStayLesson_Click(sender As Object, e As EventArgs) Handles picStayLesson.Click
        LessonFourFrm.Show()
        Me.Hide()
    End Sub

    Private Sub picNoLesson_Click(sender As Object, e As EventArgs) Handles picNoLesson.Click
        LessonFivefrm.Show()
        Me.Hide()
    End Sub

    Private Sub picPawLesson_Click(sender As Object, e As EventArgs) Handles picPawLesson.Click
        LessonSixFrm.Show()
        Me.Hide()
    End Sub

    Private Sub picNameLesson_MouseHover(sender As Object, e As EventArgs) Handles picNameLesson.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picNameLesson_MouseLeave(sender As Object, e As EventArgs) Handles picNameLesson.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub picSitLesson_MouseHover(sender As Object, e As EventArgs) Handles picSitLesson.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picSitLesson_MouseLeave(sender As Object, e As EventArgs) Handles picSitLesson.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub picNoLesson_MouseHover(sender As Object, e As EventArgs) Handles picNoLesson.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picNoLesson_MouseLeave(sender As Object, e As EventArgs) Handles picNoLesson.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub picStayLesson_MouseHover(sender As Object, e As EventArgs) Handles picStayLesson.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picStayLesson_MouseLeave(sender As Object, e As EventArgs) Handles picStayLesson.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub picDownLesson_MouseHover(sender As Object, e As EventArgs) Handles picDownLesson.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picDownLesson_MouseLeave(sender As Object, e As EventArgs) Handles picDownLesson.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub picPawLesson_MouseHover(sender As Object, e As EventArgs) Handles picPawLesson.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picPawLesson_MouseLeave(sender As Object, e As EventArgs) Handles picPawLesson.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        RatingFrmvb.Show()

        Me.Hide()
    End Sub
End Class