Public Class DogNameProfile
    Private Sub picProfileDog_Click(sender As Object, e As EventArgs) Handles picProfileDog.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picProfileDog.Image = Image.FromFile(OpenFileDialog1.FileName)
            picProfileDog.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub



    Private Sub picProfileDog_MouseHover(sender As Object, e As EventArgs) Handles picProfileDog.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub picProfileDog_MouseLeave(sender As Object, e As EventArgs) Handles picProfileDog.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub DogNameProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If txtDogName.Text = String.Empty Then
            Me.Show()
        Else
            GenderFrm.Show()
            Me.Hide()

        End If
    End Sub
End Class