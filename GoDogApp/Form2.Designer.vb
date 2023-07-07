<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.picDogLoading = New System.Windows.Forms.PictureBox()
        CType(Me.picDogLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 2000
        '
        'picDogLoading
        '
        Me.picDogLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDogLoading.Image = Global.GoDogApp.My.Resources.Resources.loading_dog_final
        Me.picDogLoading.Location = New System.Drawing.Point(65, 0)
        Me.picDogLoading.Name = "picDogLoading"
        Me.picDogLoading.Size = New System.Drawing.Size(394, 264)
        Me.picDogLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDogLoading.TabIndex = 0
        Me.picDogLoading.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(535, 262)
        Me.Controls.Add(Me.picDogLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.picDogLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents picDogLoading As PictureBox
End Class
