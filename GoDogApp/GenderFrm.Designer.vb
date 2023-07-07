<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenderFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenderFrm))
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.btnArrow = New System.Windows.Forms.Button()
        Me.picFemaleGender = New System.Windows.Forms.PictureBox()
        Me.picMaleGender = New System.Windows.Forms.PictureBox()
        CType(Me.picFemaleGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMaleGender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblQuestion.Location = New System.Drawing.Point(75, 79)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQuestion.Size = New System.Drawing.Size(358, 32)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "What is the dog's gender?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(178, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Dog's gender"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.BackColor = System.Drawing.Color.Transparent
        Me.lblMale.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.ForeColor = System.Drawing.Color.Black
        Me.lblMale.Location = New System.Drawing.Point(132, 290)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMale.Size = New System.Drawing.Size(36, 16)
        Me.lblMale.TabIndex = 4
        Me.lblMale.Text = "Male"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.BackColor = System.Drawing.Color.Transparent
        Me.lblFemale.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.ForeColor = System.Drawing.Color.Black
        Me.lblFemale.Location = New System.Drawing.Point(288, 290)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFemale.Size = New System.Drawing.Size(51, 16)
        Me.lblFemale.TabIndex = 5
        Me.lblFemale.Text = "Female"
        '
        'btnArrow
        '
        Me.btnArrow.BackColor = System.Drawing.Color.Transparent
        Me.btnArrow.BackgroundImage = Global.GoDogApp.My.Resources.Resources.newArrow
        Me.btnArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnArrow.FlatAppearance.BorderSize = 0
        Me.btnArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArrow.Location = New System.Drawing.Point(395, 423)
        Me.btnArrow.Name = "btnArrow"
        Me.btnArrow.Size = New System.Drawing.Size(84, 42)
        Me.btnArrow.TabIndex = 7
        Me.btnArrow.UseVisualStyleBackColor = False
        '
        'picFemaleGender
        '
        Me.picFemaleGender.BackColor = System.Drawing.Color.Transparent
        Me.picFemaleGender.BackgroundImage = Global.GoDogApp.My.Resources.Resources.female
        Me.picFemaleGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picFemaleGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFemaleGender.Location = New System.Drawing.Point(265, 199)
        Me.picFemaleGender.Name = "picFemaleGender"
        Me.picFemaleGender.Size = New System.Drawing.Size(97, 84)
        Me.picFemaleGender.TabIndex = 3
        Me.picFemaleGender.TabStop = False
        '
        'picMaleGender
        '
        Me.picMaleGender.BackColor = System.Drawing.Color.Transparent
        Me.picMaleGender.BackgroundImage = Global.GoDogApp.My.Resources.Resources.male
        Me.picMaleGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMaleGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMaleGender.Location = New System.Drawing.Point(104, 199)
        Me.picMaleGender.Name = "picMaleGender"
        Me.picMaleGender.Size = New System.Drawing.Size(97, 84)
        Me.picMaleGender.TabIndex = 2
        Me.picMaleGender.TabStop = False
        '
        'GenderFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(491, 490)
        Me.Controls.Add(Me.btnArrow)
        Me.Controls.Add(Me.lblFemale)
        Me.Controls.Add(Me.lblMale)
        Me.Controls.Add(Me.picFemaleGender)
        Me.Controls.Add(Me.picMaleGender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GenderFrm"
        Me.Text = "PupTrainer"
        CType(Me.picFemaleGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMaleGender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picMaleGender As PictureBox
    Friend WithEvents picFemaleGender As PictureBox
    Friend WithEvents lblMale As Label
    Friend WithEvents lblFemale As Label
    Friend WithEvents btnArrow As Button
End Class
