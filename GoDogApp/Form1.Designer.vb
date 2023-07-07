<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TmrToPanel3 = New System.Windows.Forms.Timer(Me.components)
        Me.TmrToPanel2 = New System.Windows.Forms.Timer(Me.components)
        Me.PnThirdBg = New System.Windows.Forms.Panel()
        Me.btnTo2ndPanel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnSecondPg = New System.Windows.Forms.Panel()
        Me.btnTo3rdPanel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.PnThirdBg.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnSecondPg.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'TmrToPanel3
        '
        '
        'TmrToPanel2
        '
        '
        'PnThirdBg
        '
        Me.PnThirdBg.BackgroundImage = Global.GoDogApp.My.Resources.Resources._341308864_907896260429947_7039218549781121746_n
        Me.PnThirdBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnThirdBg.Controls.Add(Me.btnTo2ndPanel)
        Me.PnThirdBg.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnThirdBg.Location = New System.Drawing.Point(2, 0)
        Me.PnThirdBg.Name = "PnThirdBg"
        Me.PnThirdBg.Size = New System.Drawing.Size(489, 490)
        Me.PnThirdBg.TabIndex = 12
        '
        'btnTo2ndPanel
        '
        Me.btnTo2ndPanel.BackColor = System.Drawing.Color.Transparent
        Me.btnTo2ndPanel.BackgroundImage = Global.GoDogApp.My.Resources.Resources.ToRightArrow
        Me.btnTo2ndPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTo2ndPanel.FlatAppearance.BorderSize = 0
        Me.btnTo2ndPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTo2ndPanel.Location = New System.Drawing.Point(335, 428)
        Me.btnTo2ndPanel.Name = "btnTo2ndPanel"
        Me.btnTo2ndPanel.Size = New System.Drawing.Size(101, 42)
        Me.btnTo2ndPanel.TabIndex = 0
        Me.btnTo2ndPanel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.GoDogApp.My.Resources.Resources.panelBG3
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PnSecondPg)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(490, 490)
        Me.Panel2.TabIndex = 11
        '
        'PnSecondPg
        '
        Me.PnSecondPg.BackgroundImage = Global.GoDogApp.My.Resources.Resources.panelBG2
        Me.PnSecondPg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnSecondPg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnSecondPg.Controls.Add(Me.btnTo3rdPanel)
        Me.PnSecondPg.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnSecondPg.Location = New System.Drawing.Point(-2, 0)
        Me.PnSecondPg.Name = "PnSecondPg"
        Me.PnSecondPg.Size = New System.Drawing.Size(490, 488)
        Me.PnSecondPg.TabIndex = 10
        '
        'btnTo3rdPanel
        '
        Me.btnTo3rdPanel.BackColor = System.Drawing.Color.Transparent
        Me.btnTo3rdPanel.BackgroundImage = Global.GoDogApp.My.Resources.Resources.ToRightArrow
        Me.btnTo3rdPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTo3rdPanel.FlatAppearance.BorderSize = 0
        Me.btnTo3rdPanel.Location = New System.Drawing.Point(335, 428)
        Me.btnTo3rdPanel.Name = "btnTo3rdPanel"
        Me.btnTo3rdPanel.Size = New System.Drawing.Size(101, 42)
        Me.btnTo3rdPanel.TabIndex = 0
        Me.btnTo3rdPanel.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = Global.GoDogApp.My.Resources.Resources.ToRightArrow
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.Location = New System.Drawing.Point(335, 428)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 42)
        Me.btnNext.TabIndex = 9
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(491, 490)
        Me.Controls.Add(Me.PnThirdBg)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "PupTrainer"
        Me.PnThirdBg.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PnSecondPg.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnNext As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnSecondPg As Panel
    Friend WithEvents btnTo3rdPanel As Button
    Friend WithEvents TmrToPanel3 As Timer
    Friend WithEvents PnThirdBg As Panel
    Friend WithEvents btnTo2ndPanel As Button
    Friend WithEvents TmrToPanel2 As Timer
End Class
