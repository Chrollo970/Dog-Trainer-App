Public Class GenderFrm
    Private Sub GenderFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As Rectangle = picFemaleGender.ClientRectangle

        Dim radius As Integer = 18
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()
        picFemaleGender.Region = New Region(path)

        Dim path2 As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect2 As Rectangle = picMaleGender.ClientRectangle
        Dim radius2 As Integer = 18
        path2.StartFigure()
        path2.AddArc(rect2.X, rect2.Y, radius2, radius2, 180, 90)
        path2.AddLine(rect2.X + radius2, rect2.Y, rect2.Right - radius2, rect2.Y)
        path2.AddArc(rect2.Right - radius2, rect2.Y, radius2, radius2, 270, 90)
        path2.AddLine(rect2.Right, rect2.Y + radius2, rect2.Right, rect2.Bottom - radius2)
        path2.AddArc(rect2.Right - radius2, rect2.Bottom - radius2, radius2, radius2, 0, 90)
        path2.AddLine(rect2.Right - radius2, rect2.Bottom, rect2.X + radius2, rect2.Bottom)
        path2.AddArc(rect2.X, rect2.Bottom - radius2, radius2, radius2, 90, 90)
        path2.CloseFigure()
        picMaleGender.Region = New Region(path2)
    End Sub

    Private Sub picMaleGender_MouseHover(sender As Object, e As EventArgs) Handles picMaleGender.MouseHover
        Cursor = Cursors.Hand

        picMaleGender.BackColor = Color.MediumOrchid

    End Sub

    Private Sub picMaleGender_MouseLeave(sender As Object, e As EventArgs) Handles picMaleGender.MouseLeave
        Cursor = Cursors.Default
        picMaleGender.BackColor = Color.Transparent
    End Sub

    Private Sub picFemaleGender_MouseHover(sender As Object, e As EventArgs) Handles picFemaleGender.MouseHover
        Cursor = Cursors.Hand
        picFemaleGender.BackColor = Color.Violet
    End Sub

    Private Sub picFemaleGender_MouseLeave(sender As Object, e As EventArgs) Handles picFemaleGender.MouseLeave
        Cursor = Cursors.Hand
        picFemaleGender.BackColor = Color.Transparent
    End Sub

    Private Sub picMaleGender_Click(sender As Object, e As EventArgs) Handles picMaleGender.Click
        Me.BackColor = Color.MediumOrchid
        lblQuestion.ForeColor = Color.FloralWhite
        lblMale.ForeColor = Color.FloralWhite
        lblFemale.ForeColor = Color.FloralWhite
        Label1.ForeColor = Color.FloralWhite
    End Sub

    Private Sub picFemaleGender_Click(sender As Object, e As EventArgs) Handles picFemaleGender.Click

        Me.BackColor = Color.Violet
        lblQuestion.ForeColor = Color.FloralWhite
        lblMale.ForeColor = Color.FloralWhite
        lblFemale.ForeColor = Color.FloralWhite
        Label1.ForeColor = Color.FloralWhite
    End Sub

    Private Sub btnArrow_Click(sender As Object, e As EventArgs) Handles btnArrow.Click
        TrustNTargeting.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class