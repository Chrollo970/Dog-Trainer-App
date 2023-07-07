<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LessonFivefrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LessonFivefrm))
        Me.picVidLesson5 = New System.Windows.Forms.PictureBox()
        Me.pnlToScroll = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.picVidLesson5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToScroll.SuspendLayout()
        Me.SuspendLayout()
        '
        'picVidLesson5
        '
        Me.picVidLesson5.BackgroundImage = Global.GoDogApp.My.Resources.Resources.NO2Forbasics
        Me.picVidLesson5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picVidLesson5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVidLesson5.Location = New System.Drawing.Point(141, 105)
        Me.picVidLesson5.Name = "picVidLesson5"
        Me.picVidLesson5.Size = New System.Drawing.Size(191, 128)
        Me.picVidLesson5.TabIndex = 3
        Me.picVidLesson5.TabStop = False
        '
        'pnlToScroll
        '
        Me.pnlToScroll.AutoScroll = True
        Me.pnlToScroll.BackColor = System.Drawing.Color.Transparent
        Me.pnlToScroll.Controls.Add(Me.btnBack)
        Me.pnlToScroll.Controls.Add(Me.Label7)
        Me.pnlToScroll.Controls.Add(Me.Label8)
        Me.pnlToScroll.Controls.Add(Me.Label3)
        Me.pnlToScroll.Controls.Add(Me.Label6)
        Me.pnlToScroll.Controls.Add(Me.Label1)
        Me.pnlToScroll.Controls.Add(Me.Label4)
        Me.pnlToScroll.Controls.Add(Me.Label2)
        Me.pnlToScroll.Controls.Add(Me.Label5)
        Me.pnlToScroll.Controls.Add(Me.picVidLesson5)
        Me.pnlToScroll.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToScroll.Location = New System.Drawing.Point(0, 0)
        Me.pnlToScroll.Name = "pnlToScroll"
        Me.pnlToScroll.Size = New System.Drawing.Size(491, 490)
        Me.pnlToScroll.TabIndex = 4
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.GoDogApp.My.Resources.Resources.ToRightArrow
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(378, 441)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(101, 46)
        Me.btnBack.TabIndex = 31
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(219, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Step3"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(66, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(364, 42)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(219, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Step2"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(66, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(364, 42)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Now enter the command. Give your dog a fist that contains some treats and say ""no" &
    """ loudly and clearly. If the pet is not trying to get the treat, say ""yes"" and t" &
    "reat it from the other hand."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(219, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Step1"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(66, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(364, 40)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "First, teach your dog to refuse fisted treat. Silently give your pet a feast in w" &
    "hich a treat is hidden. "
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(59, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 44)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "For many dogs, the ""no"" command, which is used to stop various unwanted actions o" &
    "f the dog, can be challenging. It is so because some of the undesirable actions " &
    ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(219, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "No"
        '
        'LessonFivefrm
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
        Me.Name = "LessonFivefrm"
        Me.Text = "PupTrainer"
        CType(Me.picVidLesson5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToScroll.ResumeLayout(False)
        Me.pnlToScroll.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picVidLesson5 As PictureBox
    Friend WithEvents pnlToScroll As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
End Class
