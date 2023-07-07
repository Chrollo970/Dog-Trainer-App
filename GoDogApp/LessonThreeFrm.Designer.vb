<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LessonThreeFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LessonThreeFrm))
        Me.picVidLesson3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlToScroll = New System.Windows.Forms.Panel()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picVidLesson3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToScroll.SuspendLayout()
        Me.SuspendLayout()
        '
        'picVidLesson3
        '
        Me.picVidLesson3.BackgroundImage = Global.GoDogApp.My.Resources.Resources.DownDog2jpg
        Me.picVidLesson3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picVidLesson3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVidLesson3.Location = New System.Drawing.Point(135, 101)
        Me.picVidLesson3.Name = "picVidLesson3"
        Me.picVidLesson3.Size = New System.Drawing.Size(191, 128)
        Me.picVidLesson3.TabIndex = 1
        Me.picVidLesson3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(213, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Down"
        '
        'pnlToScroll
        '
        Me.pnlToScroll.AutoScroll = True
        Me.pnlToScroll.BackColor = System.Drawing.Color.Transparent
        Me.pnlToScroll.Controls.Add(Me.btnDone)
        Me.pnlToScroll.Controls.Add(Me.Label3)
        Me.pnlToScroll.Controls.Add(Me.Label1)
        Me.pnlToScroll.Controls.Add(Me.Label4)
        Me.pnlToScroll.Controls.Add(Me.Label2)
        Me.pnlToScroll.Controls.Add(Me.picVidLesson3)
        Me.pnlToScroll.Controls.Add(Me.Label5)
        Me.pnlToScroll.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToScroll.Location = New System.Drawing.Point(0, 0)
        Me.pnlToScroll.Name = "pnlToScroll"
        Me.pnlToScroll.Size = New System.Drawing.Size(491, 492)
        Me.pnlToScroll.TabIndex = 9
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.BackgroundImage = Global.GoDogApp.My.Resources.Resources.btnDone
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Location = New System.Drawing.Point(370, 466)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(101, 46)
        Me.btnDone.TabIndex = 30
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(34, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(437, 44)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "You can start pronouncing the command when the dog has mastered the previous step" &
    ". Say ""lie down"" or ""down"". As soon as the dog lies down, say ""good dog"" and giv" &
    "e it the treat. Repeat several times."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(214, 392)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Step2"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(21, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(437, 81)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(62, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(364, 44)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "It is not an easy command, as the dog must take a passive posture. But if you are" &
    " patient and work it out properly, you will see how useful it is in many situati" &
    "ons." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LessonThreeFrm
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
        Me.Name = "LessonThreeFrm"
        Me.Text = "PupTrainer"
        CType(Me.picVidLesson3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToScroll.ResumeLayout(False)
        Me.pnlToScroll.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picVidLesson3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlToScroll As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDone As Button
End Class
