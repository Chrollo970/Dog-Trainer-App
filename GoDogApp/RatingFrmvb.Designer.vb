<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RatingFrmvb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RatingFrmvb))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlToScroll = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblSkilled = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblLearned = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.lblInProgress = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblNotLearned = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.picSkilled = New System.Windows.Forms.PictureBox()
        Me.picLrd = New System.Windows.Forms.PictureBox()
        Me.picRatingIP = New System.Windows.Forms.PictureBox()
        Me.picRatingNL = New System.Windows.Forms.PictureBox()
        Me.pnlToScroll.SuspendLayout()
        CType(Me.picSkilled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRatingIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRatingNL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label1.Location = New System.Drawing.Point(156, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lesson status"
        '
        'pnlToScroll
        '
        Me.pnlToScroll.AutoScroll = True
        Me.pnlToScroll.Controls.Add(Me.btnSend)
        Me.pnlToScroll.Controls.Add(Me.TextBox1)
        Me.pnlToScroll.Controls.Add(Me.lblSkilled)
        Me.pnlToScroll.Controls.Add(Me.picSkilled)
        Me.pnlToScroll.Controls.Add(Me.Label4)
        Me.pnlToScroll.Controls.Add(Me.lblLearned)
        Me.pnlToScroll.Controls.Add(Me.picLrd)
        Me.pnlToScroll.Controls.Add(Me.Label)
        Me.pnlToScroll.Controls.Add(Me.lblInProgress)
        Me.pnlToScroll.Controls.Add(Me.picRatingIP)
        Me.pnlToScroll.Controls.Add(Me.lblText)
        Me.pnlToScroll.Controls.Add(Me.lblNotLearned)
        Me.pnlToScroll.Controls.Add(Me.picRatingNL)
        Me.pnlToScroll.Controls.Add(Me.Label1)
        Me.pnlToScroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlToScroll.Location = New System.Drawing.Point(0, 0)
        Me.pnlToScroll.Name = "pnlToScroll"
        Me.pnlToScroll.Size = New System.Drawing.Size(491, 533)
        Me.pnlToScroll.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 743)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 20)
        Me.TextBox1.TabIndex = 22
        '
        'lblSkilled
        '
        Me.lblSkilled.AutoSize = True
        Me.lblSkilled.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkilled.ForeColor = System.Drawing.Color.MediumOrchid
        Me.lblSkilled.Location = New System.Drawing.Point(168, 626)
        Me.lblSkilled.Name = "lblSkilled"
        Me.lblSkilled.Size = New System.Drawing.Size(91, 29)
        Me.lblSkilled.TabIndex = 14
        Me.lblSkilled.Text = "Skilled"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(178, 541)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 42)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Dog always performs the command with a treat at home"
        '
        'lblLearned
        '
        Me.lblLearned.AutoSize = True
        Me.lblLearned.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLearned.ForeColor = System.Drawing.Color.MediumOrchid
        Me.lblLearned.Location = New System.Drawing.Point(168, 498)
        Me.lblLearned.Name = "lblLearned"
        Me.lblLearned.Size = New System.Drawing.Size(106, 29)
        Me.lblLearned.TabIndex = 19
        Me.lblLearned.Text = "Learned"
        '
        'Label
        '
        Me.Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label.Location = New System.Drawing.Point(178, 429)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(246, 44)
        Me.Label.TabIndex = 17
        Me.Label.Text = "Dog performs the command, but not at first try"
        '
        'lblInProgress
        '
        Me.lblInProgress.AutoSize = True
        Me.lblInProgress.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInProgress.ForeColor = System.Drawing.Color.MediumOrchid
        Me.lblInProgress.Location = New System.Drawing.Point(168, 381)
        Me.lblInProgress.Name = "lblInProgress"
        Me.lblInProgress.Size = New System.Drawing.Size(145, 29)
        Me.lblInProgress.TabIndex = 16
        Me.lblInProgress.Text = "In Progress"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblText.Location = New System.Drawing.Point(178, 296)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(227, 18)
        Me.lblText.TabIndex = 14
        Me.lblText.Text = "Default status of all new lessons"
        '
        'lblNotLearned
        '
        Me.lblNotLearned.AutoSize = True
        Me.lblNotLearned.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotLearned.ForeColor = System.Drawing.Color.MediumOrchid
        Me.lblNotLearned.Location = New System.Drawing.Point(168, 267)
        Me.lblNotLearned.Name = "lblNotLearned"
        Me.lblNotLearned.Size = New System.Drawing.Size(153, 29)
        Me.lblNotLearned.TabIndex = 13
        Me.lblNotLearned.Text = "Not Learned"
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.BackgroundImage = Global.GoDogApp.My.Resources.Resources.SendReview
        Me.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Location = New System.Drawing.Point(181, 769)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(132, 70)
        Me.btnSend.TabIndex = 30
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'picSkilled
        '
        Me.picSkilled.BackColor = System.Drawing.Color.Transparent
        Me.picSkilled.BackgroundImage = Global.GoDogApp.My.Resources.Resources.yellowPaw
        Me.picSkilled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSkilled.Location = New System.Drawing.Point(66, 626)
        Me.picSkilled.Name = "picSkilled"
        Me.picSkilled.Size = New System.Drawing.Size(83, 77)
        Me.picSkilled.TabIndex = 21
        Me.picSkilled.TabStop = False
        '
        'picLrd
        '
        Me.picLrd.BackColor = System.Drawing.Color.Transparent
        Me.picLrd.BackgroundImage = Global.GoDogApp.My.Resources.Resources.yellowPaw
        Me.picLrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLrd.Location = New System.Drawing.Point(66, 512)
        Me.picLrd.Name = "picLrd"
        Me.picLrd.Size = New System.Drawing.Size(83, 84)
        Me.picLrd.TabIndex = 18
        Me.picLrd.TabStop = False
        '
        'picRatingIP
        '
        Me.picRatingIP.BackColor = System.Drawing.Color.Transparent
        Me.picRatingIP.BackgroundImage = Global.GoDogApp.My.Resources.Resources.yellowPaw
        Me.picRatingIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picRatingIP.Location = New System.Drawing.Point(66, 397)
        Me.picRatingIP.Name = "picRatingIP"
        Me.picRatingIP.Size = New System.Drawing.Size(83, 77)
        Me.picRatingIP.TabIndex = 15
        Me.picRatingIP.TabStop = False
        '
        'picRatingNL
        '
        Me.picRatingNL.BackColor = System.Drawing.Color.Transparent
        Me.picRatingNL.BackgroundImage = Global.GoDogApp.My.Resources.Resources.yellowPaw
        Me.picRatingNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picRatingNL.Location = New System.Drawing.Point(66, 267)
        Me.picRatingNL.Name = "picRatingNL"
        Me.picRatingNL.Size = New System.Drawing.Size(83, 84)
        Me.picRatingNL.TabIndex = 12
        Me.picRatingNL.TabStop = False
        '
        'RatingFrmvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(491, 533)
        Me.Controls.Add(Me.pnlToScroll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RatingFrmvb"
        Me.Text = "PupTrainer"
        Me.pnlToScroll.ResumeLayout(False)
        Me.pnlToScroll.PerformLayout()
        CType(Me.picSkilled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRatingIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRatingNL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlToScroll As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblSkilled As Label
    Friend WithEvents picSkilled As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblLearned As Label
    Friend WithEvents picLrd As PictureBox
    Friend WithEvents Label As Label
    Friend WithEvents lblInProgress As Label
    Friend WithEvents picRatingIP As PictureBox
    Friend WithEvents lblText As Label
    Friend WithEvents lblNotLearned As Label
    Friend WithEvents picRatingNL As PictureBox
    Friend WithEvents btnSend As Button
End Class
