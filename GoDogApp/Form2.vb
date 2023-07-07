Public Class Form2


    Private Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick

        tmrLoad.Enabled = False
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub picDogLoading_Click(sender As Object, e As EventArgs) Handles picDogLoading.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Interval = 5000
        tmrLoad.Enabled = True
    End Sub
End Class