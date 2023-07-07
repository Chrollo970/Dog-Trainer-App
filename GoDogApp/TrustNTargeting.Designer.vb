<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrustNTargeting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrustNTargeting))
        Me.picAddedProfile = New System.Windows.Forms.PictureBox()
        Me.lblIFromTextBoxName = New System.Windows.Forms.Label()
        Me.lblEssential = New System.Windows.Forms.Label()
        Me.lblTrust = New System.Windows.Forms.Label()
        Me.picTrust = New System.Windows.Forms.PictureBox()
        Me.lblTargeting = New System.Windows.Forms.Label()
        Me.picTargeting = New System.Windows.Forms.PictureBox()
        Me.btnDone = New System.Windows.Forms.Button()
        CType(Me.picAddedProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTrust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTargeting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAddedProfile
        '
        Me.picAddedProfile.BackColor = System.Drawing.Color.DarkMagenta
        Me.picAddedProfile.BackgroundImage = Global.GoDogApp.My.Resources.Resources.cameraIcon
        Me.picAddedProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picAddedProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAddedProfile.Location = New System.Drawing.Point(12, 12)
        Me.picAddedProfile.Name = "picAddedProfile"
        Me.picAddedProfile.Size = New System.Drawing.Size(98, 88)
        Me.picAddedProfile.TabIndex = 1
        Me.picAddedProfile.TabStop = False
        '
        'lblIFromTextBoxName
        '
        Me.lblIFromTextBoxName.AutoSize = True
        Me.lblIFromTextBoxName.BackColor = System.Drawing.Color.Transparent
        Me.lblIFromTextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIFromTextBoxName.Location = New System.Drawing.Point(116, 24)
        Me.lblIFromTextBoxName.Name = "lblIFromTextBoxName"
        Me.lblIFromTextBoxName.Size = New System.Drawing.Size(61, 24)
        Me.lblIFromTextBoxName.TabIndex = 2
        Me.lblIFromTextBoxName.Text = "Name"
        '
        'lblEssential
        '
        Me.lblEssential.AutoSize = True
        Me.lblEssential.BackColor = System.Drawing.Color.Transparent
        Me.lblEssential.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEssential.Location = New System.Drawing.Point(204, 109)
        Me.lblEssential.Name = "lblEssential"
        Me.lblEssential.Size = New System.Drawing.Size(111, 29)
        Me.lblEssential.TabIndex = 3
        Me.lblEssential.Text = "Essential"
        '
        'lblTrust
        '
        Me.lblTrust.AutoSize = True
        Me.lblTrust.BackColor = System.Drawing.Color.Transparent
        Me.lblTrust.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrust.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTrust.Location = New System.Drawing.Point(230, 166)
        Me.lblTrust.Name = "lblTrust"
        Me.lblTrust.Size = New System.Drawing.Size(61, 25)
        Me.lblTrust.TabIndex = 4
        Me.lblTrust.Text = "Trust"
        '
        'picTrust
        '
        Me.picTrust.BackColor = System.Drawing.Color.Transparent
        Me.picTrust.BackgroundImage = Global.GoDogApp.My.Resources.Resources.pictrust
        Me.picTrust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTrust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTrust.Location = New System.Drawing.Point(177, 205)
        Me.picTrust.Name = "picTrust"
        Me.picTrust.Size = New System.Drawing.Size(161, 113)
        Me.picTrust.TabIndex = 5
        Me.picTrust.TabStop = False
        '
        'lblTargeting
        '
        Me.lblTargeting.AutoSize = True
        Me.lblTargeting.BackColor = System.Drawing.Color.Transparent
        Me.lblTargeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargeting.Location = New System.Drawing.Point(204, 333)
        Me.lblTargeting.Name = "lblTargeting"
        Me.lblTargeting.Size = New System.Drawing.Size(103, 25)
        Me.lblTargeting.TabIndex = 6
        Me.lblTargeting.Text = "Targeting"
        '
        'picTargeting
        '
        Me.picTargeting.BackColor = System.Drawing.Color.Transparent
        Me.picTargeting.BackgroundImage = Global.GoDogApp.My.Resources.Resources.picTargetinjpg
        Me.picTargeting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTargeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTargeting.Location = New System.Drawing.Point(177, 365)
        Me.picTargeting.Name = "picTargeting"
        Me.picTargeting.Size = New System.Drawing.Size(161, 113)
        Me.picTargeting.TabIndex = 7
        Me.picTargeting.TabStop = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.BackgroundImage = Global.GoDogApp.My.Resources.Resources.btnDone
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Location = New System.Drawing.Point(388, 426)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(101, 52)
        Me.btnDone.TabIndex = 8
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'TrustNTargeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GoDogApp.My.Resources.Resources.MainBackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(491, 490)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.picTargeting)
        Me.Controls.Add(Me.lblTargeting)
        Me.Controls.Add(Me.picTrust)
        Me.Controls.Add(Me.lblTrust)
        Me.Controls.Add(Me.lblEssential)
        Me.Controls.Add(Me.lblIFromTextBoxName)
        Me.Controls.Add(Me.picAddedProfile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TrustNTargeting"
        Me.Text = "PupTrainer"
        CType(Me.picAddedProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTrust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTargeting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAddedProfile As PictureBox
    Friend WithEvents lblIFromTextBoxName As Label
    Friend WithEvents lblEssential As Label
    Friend WithEvents lblTrust As Label
    Friend WithEvents picTrust As PictureBox
    Friend WithEvents lblTargeting As Label
    Friend WithEvents picTargeting As PictureBox
    Friend WithEvents btnDone As Button
End Class
