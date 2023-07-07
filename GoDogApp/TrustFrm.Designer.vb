<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrustFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrustFrm))
        Me.lblTrust = New System.Windows.Forms.Label()
        Me.lblJustText = New System.Windows.Forms.Label()
        Me.pnlToScroll = New System.Windows.Forms.Panel()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picVidTrust = New System.Windows.Forms.PictureBox()
        Me.pnlToScroll.SuspendLayout()
        CType(Me.picVidTrust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTrust
        '
        Me.lblTrust.AutoSize = True
        Me.lblTrust.BackColor = System.Drawing.Color.Transparent
        Me.lblTrust.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrust.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTrust.Location = New System.Drawing.Point(27, 20)
        Me.lblTrust.Name = "lblTrust"
        Me.lblTrust.Size = New System.Drawing.Size(61, 25)
        Me.lblTrust.TabIndex = 5
        Me.lblTrust.Text = "Trust"
        '
        'lblJustText
        '
        Me.lblJustText.BackColor = System.Drawing.Color.Transparent
        Me.lblJustText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJustText.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJustText.Location = New System.Drawing.Point(80, 79)
        Me.lblJustText.Name = "lblJustText"
        Me.lblJustText.Size = New System.Drawing.Size(330, 111)
        Me.lblJustText.TabIndex = 6
        Me.lblJustText.Text = "A dog should trust its owner. It should be afraid of being touched and allow vari" &
    "ous manipulations, including health during learning off commands, years cleaning" &
    ", paws washing, nail trimming, etc."
        '
        'pnlToScroll
        '
        Me.pnlToScroll.AutoScroll = True
        Me.pnlToScroll.BackColor = System.Drawing.Color.Transparent
        Me.pnlToScroll.Controls.Add(Me.btnDone)
        Me.pnlToScroll.Controls.Add(Me.Label4)
        Me.pnlToScroll.Controls.Add(Me.Label3)
        Me.pnlToScroll.Controls.Add(Me.label2)
        Me.pnlToScroll.Controls.Add(Me.Label1)
        Me.pnlToScroll.Controls.Add(Me.picVidTrust)
        Me.pnlToScroll.Controls.Add(Me.lblTrust)
        Me.pnlToScroll.Controls.Add(Me.lblJustText)
        Me.pnlToScroll.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToScroll.Location = New System.Drawing.Point(0, 0)
        Me.pnlToScroll.Name = "pnlToScroll"
        Me.pnlToScroll.Size = New System.Drawing.Size(491, 490)
        Me.pnlToScroll.TabIndex = 7
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.BackgroundImage = Global.GoDogApp.My.Resources.Resources.btnDone
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Location = New System.Drawing.Point(370, 478)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(101, 52)
        Me.btnDone.TabIndex = 12
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(66, 442)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Wean your pet from biting and uncontrolled pampering."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(139, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Do not allow overstimulation"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label2.Location = New System.Drawing.Point(66, 364)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(357, 18)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Teach your pet to trust you and be receptive to touch."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(214, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Goal:"
        '
        'picVidTrust
        '
        Me.picVidTrust.BackColor = System.Drawing.Color.Transparent
        Me.picVidTrust.BackgroundImage = Global.GoDogApp.My.Resources.Resources.pictrust
        Me.picVidTrust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picVidTrust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVidTrust.Location = New System.Drawing.Point(157, 205)
        Me.picVidTrust.Name = "picVidTrust"
        Me.picVidTrust.Size = New System.Drawing.Size(161, 113)
        Me.picVidTrust.TabIndex = 7
        Me.picVidTrust.TabStop = False
        '
        'TrustFrm
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
        Me.Name = "TrustFrm"
        Me.Text = "PupTrainer"
        Me.pnlToScroll.ResumeLayout(False)
        Me.pnlToScroll.PerformLayout()
        CType(Me.picVidTrust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTrust As Label
    Friend WithEvents lblJustText As Label
    Friend WithEvents pnlToScroll As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picVidTrust As PictureBox
    Friend WithEvents btnDone As Button
End Class
