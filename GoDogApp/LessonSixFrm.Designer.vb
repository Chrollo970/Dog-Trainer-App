<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LessonSixFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LessonSixFrm))
        Me.picVidLesson6 = New System.Windows.Forms.PictureBox()
        Me.pnlToScroll = New System.Windows.Forms.Panel()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.picVidLesson6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToScroll.SuspendLayout()
        Me.SuspendLayout()
        '
        'picVidLesson6
        '
        Me.picVidLesson6.BackgroundImage = Global.GoDogApp.My.Resources.Resources.givePawDog2ForBasics
        Me.picVidLesson6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picVidLesson6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVidLesson6.Location = New System.Drawing.Point(143, 138)
        Me.picVidLesson6.Name = "picVidLesson6"
        Me.picVidLesson6.Size = New System.Drawing.Size(191, 128)
        Me.picVidLesson6.TabIndex = 4
        Me.picVidLesson6.TabStop = False
        '
        'pnlToScroll
        '
        Me.pnlToScroll.AutoScroll = True
        Me.pnlToScroll.BackColor = System.Drawing.Color.Transparent
        Me.pnlToScroll.Controls.Add(Me.btnNext)
        Me.pnlToScroll.Controls.Add(Me.Label4)
        Me.pnlToScroll.Controls.Add(Me.Label5)
        Me.pnlToScroll.Controls.Add(Me.Label2)
        Me.pnlToScroll.Controls.Add(Me.Label1)
        Me.pnlToScroll.Controls.Add(Me.Label6)
        Me.pnlToScroll.Controls.Add(Me.Label3)
        Me.pnlToScroll.Controls.Add(Me.picVidLesson6)
        Me.pnlToScroll.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToScroll.Location = New System.Drawing.Point(0, 0)
        Me.pnlToScroll.Name = "pnlToScroll"
        Me.pnlToScroll.Size = New System.Drawing.Size(491, 487)
        Me.pnlToScroll.TabIndex = 5
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.GoDogApp.My.Resources.Resources.ToRightArrow
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(378, 432)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 46)
        Me.btnNext.TabIndex = 31
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(68, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(364, 53)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Say the command ""Give paw"" and immediately bring your hand with a threat to the d" &
    "og. Praise the dog and let it eat the treat when it puts its paw on your hand. R" &
    "epeat several times."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(221, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Step2"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(68, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(364, 53)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(221, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Step1"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(68, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(364, 79)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(205, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Paw"
        '
        'LessonSixFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GoDogApp.My.Resources.Resources.MainBackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(491, 490)
        Me.Controls.Add(Me.pnlToScroll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LessonSixFrm"
        Me.Text = "PupTrainer"
        CType(Me.picVidLesson6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToScroll.ResumeLayout(False)
        Me.pnlToScroll.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picVidLesson6 As PictureBox
    Friend WithEvents pnlToScroll As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNext As Button
End Class
