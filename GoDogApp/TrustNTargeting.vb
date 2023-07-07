Public Class TrustNTargeting
    Private Sub lblIFromTextBoxName_Click(sender As Object, e As EventArgs) Handles lblIFromTextBoxName.Click

    End Sub

    Private Sub TrustNTargeting_Load(sender As Object, e As EventArgs) Handles Me.Load
        picAddedProfile.Image = DogNameProfile.picProfileDog.Image
        picAddedProfile.SizeMode = PictureBoxSizeMode.StretchImage
        lblIFromTextBoxName.Text = DogNameProfile.txtDogName.Text

        'Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        'Dim rect As Rectangle = picAddedProfile.ClientRectangle

        'Dim radius As Integer = 100
        'path.StartFigure()
        'path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        'path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y)
        'path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        'path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)
        'path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        'path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom)
        'path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        'path.CloseFigure()
        'picAddedProfile.Region = New Region(path)

        'Dim path2 As New System.Drawing.Drawing2D.GraphicsPath()
        'path2.AddEllipse(5, 5, picAddedProfile.Width, picAddedProfile.Height)
        'picAddedProfile.Region = New Region(path)
    End Sub

    Private Sub picTrust_MouseHover(sender As Object, e As EventArgs) Handles picTrust.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picTrust_MouseLeave(sender As Object, e As EventArgs) Handles picTrust.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub picTargeting_MouseHover(sender As Object, e As EventArgs) Handles picTargeting.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picTargeting_MouseLeave(sender As Object, e As EventArgs) Handles picTargeting.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub picTrust_Click(sender As Object, e As EventArgs) Handles picTrust.Click
        TrustFrm.Show()
        Me.Hide()
    End Sub

    Private Sub picTargeting_Click(sender As Object, e As EventArgs) Handles picTargeting.Click
        TargetingFrm.Show()
        Me.Hide()
    End Sub

    Private Sub btnTo2ndPanel_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        CommandBasicsFrm.Show()
        Me.Hide()

    End Sub
End Class