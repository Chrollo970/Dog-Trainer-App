Public Class Form1
    Dim panelwidth As Integer
    Dim panelwidthForPanel2 As Integer
    Dim panelwidthForPanel3 As Integer
    Dim hidden As Boolean
    Dim hiddenPanel2 As Boolean
    Dim hiddenPanel3 As Boolean


    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.MediumPurple
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand


        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btnNext.Width, 20, btn.Width, btn.Height - 10)

        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btnNext.Region = New Region(Raduis)

    End Sub
    Private Sub RoundButton2(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.MediumPurple
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand


        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btnTo3rdPanel.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btnTo3rdPanel.Region = New Region(Raduis)
    End Sub
    Private Sub RoundButton3(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.MediumPurple
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand


        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btnTo2ndPanel.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btnTo2ndPanel.Region = New Region(Raduis)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelwidth = Panel2.Width
        panelwidthForPanel2 = PnSecondPg.Width
        hidden = False
        hiddenPanel2 = False

        RoundButton(btnNext)
        RoundButton2(btnTo3rdPanel)
        RoundButton3(btnTo2ndPanel)


    End Sub





    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        DogNameProfile.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If hidden Then
            Panel2.Width = Panel2.Width + 20
            If (Panel2.Width >= panelwidth) Then
                Timer1.Stop()
                hidden = False
                Me.Refresh()

            End If
        Else
            Panel2.Width = Panel2.Width - 20
            If (Panel2.Width <= 0) Then
                Timer1.Stop()
                hidden = True
                Me.Refresh()
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub


    Private Sub btnTo3rdPanel_Click(sender As Object, e As EventArgs) Handles btnTo3rdPanel.Click
        TmrToPanel3.Start()
    End Sub

    Private Sub TmrToPanel3_Tick(sender As Object, e As EventArgs) Handles TmrToPanel3.Tick
        If hiddenPanel2 Then
            PnSecondPg.Width = PnSecondPg.Width + 20
            If (PnSecondPg.Width >= panelwidthForPanel2) Then
                TmrToPanel3.Stop()
                hiddenPanel2 = False
                Me.Refresh()

            End If
        Else
            PnSecondPg.Width = PnSecondPg.Width - 20
            If (PnSecondPg.Width <= 0) Then
                TmrToPanel3.Stop()
                hiddenPanel2 = True
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub btnTo2ndPanel_Click(sender As Object, e As EventArgs) Handles btnTo2ndPanel.Click
        TmrToPanel2.Start()
    End Sub

    Private Sub TmrToPanel2_Tick(sender As Object, e As EventArgs) Handles TmrToPanel2.Tick
        If hiddenPanel3 Then
            PnThirdBg.Width = PnThirdBg.Width + 20
            If (PnThirdBg.Width >= panelwidthForPanel3) Then
                TmrToPanel2.Stop()
                hiddenPanel3 = False
                Me.Refresh()

            End If
        Else
            PnThirdBg.Width = PnThirdBg.Width - 20
            If (PnThirdBg.Width <= 0) Then
                TmrToPanel2.Stop()
                hiddenPanel3 = True
                Me.Refresh()
            End If
        End If
    End Sub




    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    '    Panel1.VerticalScroll.Value = vsScrollbar.Value
    'End Sub



    'Private Sub btnGetStarted_Click(sender As Object, e As EventArgs) Handles btnGetStarted.Click

    '    Dim OpenFileDialog1 As New OpenFileDialog

    '    OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
    '    If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    '    End If
    'End Sub



    'Private Sub vsScrollbar_Scroll(sender As Object, e As ScrollEventArgs)

    'End Sub
End Class
