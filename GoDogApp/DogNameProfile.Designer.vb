<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DogNameProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DogNameProfile))
        Me.lblDogPhoto = New System.Windows.Forms.Label()
        Me.lblOptional = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDogName = New System.Windows.Forms.TextBox()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.picProfileDog = New System.Windows.Forms.PictureBox()
        CType(Me.picProfileDog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDogPhoto
        '
        Me.lblDogPhoto.AutoSize = True
        Me.lblDogPhoto.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDogPhoto.Location = New System.Drawing.Point(178, 31)
        Me.lblDogPhoto.Name = "lblDogPhoto"
        Me.lblDogPhoto.Size = New System.Drawing.Size(237, 32)
        Me.lblDogPhoto.TabIndex = 1
        Me.lblDogPhoto.Text = "Add Dog's Photo"
        '
        'lblOptional
        '
        Me.lblOptional.AutoSize = True
        Me.lblOptional.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptional.Location = New System.Drawing.Point(260, 63)
        Me.lblOptional.Name = "lblOptional"
        Me.lblOptional.Size = New System.Drawing.Size(73, 19)
        Me.lblOptional.TabIndex = 2
        Me.lblOptional.Text = "Optional"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "What is the Dog's Name?"
        '
        'txtDogName
        '
        Me.txtDogName.Location = New System.Drawing.Point(151, 259)
        Me.txtDogName.Name = "txtDogName"
        Me.txtDogName.Size = New System.Drawing.Size(164, 20)
        Me.txtDogName.TabIndex = 4
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Transparent
        Me.btnProceed.BackgroundImage = Global.GoDogApp.My.Resources.Resources.btnDone
        Me.btnProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProceed.FlatAppearance.BorderSize = 0
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Location = New System.Drawing.Point(165, 308)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(132, 70)
        Me.btnProceed.TabIndex = 31
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'picProfileDog
        '
        Me.picProfileDog.BackColor = System.Drawing.Color.MediumOrchid
        Me.picProfileDog.BackgroundImage = Global.GoDogApp.My.Resources.Resources.cameraIcon
        Me.picProfileDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picProfileDog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picProfileDog.Location = New System.Drawing.Point(12, 52)
        Me.picProfileDog.Name = "picProfileDog"
        Me.picProfileDog.Size = New System.Drawing.Size(144, 113)
        Me.picProfileDog.TabIndex = 0
        Me.picProfileDog.TabStop = False
        '
        'DogNameProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(491, 490)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.txtDogName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOptional)
        Me.Controls.Add(Me.lblDogPhoto)
        Me.Controls.Add(Me.picProfileDog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DogNameProfile"
        Me.Text = "PupTrainer"
        CType(Me.picProfileDog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProfileDog As PictureBox
    Friend WithEvents lblDogPhoto As Label
    Friend WithEvents lblOptional As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDogName As TextBox
    Friend WithEvents btnProceed As Button
End Class
