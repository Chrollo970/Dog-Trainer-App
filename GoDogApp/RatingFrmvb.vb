Public Class RatingFrmvb




    Private Sub picRatingNL_MouseHover(sender As Object, e As EventArgs) Handles picRatingNL.MouseHover
        Cursor = Cursors.Hand
    End Sub



    Private Sub picRatingNL_MouseLeave(sender As Object, e As EventArgs) Handles picRatingNL.MouseLeave
        Cursor = Cursors.Default
    End Sub





    Private Sub picRatingIP_MouseHover(sender As Object, e As EventArgs) Handles picRatingIP.MouseHover
        Cursor = Cursors.Hand
    End Sub



    Private Sub picRatingIP_MouseLeave(sender As Object, e As EventArgs) Handles picRatingIP.MouseLeave
        Cursor = Cursors.Default
    End Sub





    Private Sub picLrd_MouseHover(sender As Object, e As EventArgs) Handles picLrd.MouseHover
        Cursor = Cursors.Hand

    End Sub



    Private Sub picLrd_MouseLeave(sender As Object, e As EventArgs) Handles picLrd.MouseLeave
        Cursor = Cursors.Default

    End Sub





    Private Sub picSkilled_MouseHover(sender As Object, e As EventArgs) Handles picSkilled.MouseHover

        Cursor = Cursors.Hand
    End Sub



    Private Sub picSkilled_MouseLeave(sender As Object, e As EventArgs) Handles picSkilled.MouseLeave
        Cursor = Cursors.Default

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        CommandBasicsFrm.Show()
        Me.Hide()
    End Sub

    Private Sub picRatingNL_Click_1(sender As Object, e As EventArgs) Handles picRatingNL.Click
        Dim NewImage As Image = Image.FromFile("C:\Users\USER\source\repos\GoDogApp\GoDogApp\Resources\purplePaw.jpg")
        picRatingNL.Image = NewImage
        picRatingNL.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub picRatingIP_Click_1(sender As Object, e As EventArgs) Handles picRatingIP.Click
        Dim NewImage As Image = Image.FromFile("C:\Users\USER\source\repos\GoDogApp\GoDogApp\Resources\purplePaw.jpg")
        picRatingIP.Image = NewImage
        picRatingIP.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub picLrd_Click_1(sender As Object, e As EventArgs) Handles picLrd.Click
        Dim NewImage As Image = Image.FromFile("C:\Users\USER\source\repos\GoDogApp\GoDogApp\Resources\purplePaw.jpg")
        picLrd.Image = NewImage
        picLrd.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub picSkilled_Click_1(sender As Object, e As EventArgs) Handles picSkilled.Click
        Dim NewImage As Image = Image.FromFile("C:\Users\USER\source\repos\GoDogApp\GoDogApp\Resources\purplePaw.jpg")
        picSkilled.Image = NewImage
        picSkilled.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub RatingFrmvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class