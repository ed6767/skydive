<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game
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
        Me.alta = New System.Windows.Forms.Label()
        Me.altat = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.opbut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Walkytalky = New System.Windows.Forms.Label()
        Me.exitbu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.balanceb = New System.Windows.Forms.ProgressBar()
        Me.stablibu = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MPH = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.score = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Scoep = New System.Windows.Forms.Label()
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'alta
        '
        Me.alta.AutoSize = True
        Me.alta.Location = New System.Drawing.Point(354, 36)
        Me.alta.Name = "alta"
        Me.alta.Size = New System.Drawing.Size(27, 13)
        Me.alta.TabIndex = 1
        Me.alta.Text = "ALT"
        '
        'altat
        '
        Me.altat.AutoSize = True
        Me.altat.Location = New System.Drawing.Point(354, 71)
        Me.altat.Name = "altat"
        Me.altat.Size = New System.Drawing.Size(31, 13)
        Me.altat.TabIndex = 2
        Me.altat.Text = "1000"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'opbut
        '
        Me.opbut.Location = New System.Drawing.Point(357, 131)
        Me.opbut.Name = "opbut"
        Me.opbut.Size = New System.Drawing.Size(75, 56)
        Me.opbut.TabIndex = 3
        Me.opbut.Text = "Open Parashoot"
        Me.opbut.UseVisualStyleBackColor = True
        Me.opbut.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(366, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Walky-Talky"
        '
        'Walkytalky
        '
        Me.Walkytalky.AutoSize = True
        Me.Walkytalky.Location = New System.Drawing.Point(366, 255)
        Me.Walkytalky.Name = "Walkytalky"
        Me.Walkytalky.Size = New System.Drawing.Size(45, 13)
        Me.Walkytalky.TabIndex = 5
        Me.Walkytalky.Text = "Lets go!"
        '
        'exitbu
        '
        Me.exitbu.Location = New System.Drawing.Point(444, 131)
        Me.exitbu.Name = "exitbu"
        Me.exitbu.Size = New System.Drawing.Size(62, 56)
        Me.exitbu.TabIndex = 6
        Me.exitbu.Text = "EXIT"
        Me.exitbu.UseVisualStyleBackColor = True
        Me.exitbu.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Balance"
        '
        'balanceb
        '
        Me.balanceb.BackColor = System.Drawing.Color.Red
        Me.balanceb.ForeColor = System.Drawing.Color.Lime
        Me.balanceb.Location = New System.Drawing.Point(332, 364)
        Me.balanceb.Name = "balanceb"
        Me.balanceb.Size = New System.Drawing.Size(135, 23)
        Me.balanceb.TabIndex = 8
        Me.balanceb.Value = 100
        '
        'stablibu
        '
        Me.stablibu.Location = New System.Drawing.Point(344, 411)
        Me.stablibu.Name = "stablibu"
        Me.stablibu.Size = New System.Drawing.Size(100, 29)
        Me.stablibu.TabIndex = 9
        Me.stablibu.Text = "Stabelize"
        Me.stablibu.UseVisualStyleBackColor = True
        Me.stablibu.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(444, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Pause"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(596, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Secs to go 1m"
        '
        'MPH
        '
        Me.MPH.AutoSize = True
        Me.MPH.Location = New System.Drawing.Point(596, 71)
        Me.MPH.Name = "MPH"
        Me.MPH.Size = New System.Drawing.Size(70, 13)
        Me.MPH.TabIndex = 12
        Me.MPH.Text = "ANALIZING.."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(632, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Boost"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Maroon
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Yellow
        Me.ProgressBar1.Location = New System.Drawing.Point(599, 255)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(608, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Use boost"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(560, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Score:"
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Location = New System.Drawing.Point(605, 147)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(13, 13)
        Me.score.TabIndex = 17
        Me.score.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(617, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Score x2"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BackColor = System.Drawing.Color.Black
        Me.ProgressBar2.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar2.Location = New System.Drawing.Point(599, 393)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar2.TabIndex = 19
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 300
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(620, 422)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "USE"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(492, 483)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 40)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "SCORE X10!"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(318, 483)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(149, 66)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "SCORE X500"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Timer6
        '
        Me.Timer6.Enabled = True
        '
        'Timer7
        '
        '
        'Timer8
        '
        '
        'Scoep
        '
        Me.Scoep.AutoSize = True
        Me.Scoep.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scoep.Location = New System.Drawing.Point(443, 96)
        Me.Scoep.Name = "Scoep"
        Me.Scoep.Size = New System.Drawing.Size(156, 108)
        Me.Scoep.TabIndex = 23
        Me.Scoep.Text = "+0"
        Me.Scoep.Visible = False
        '
        'Timer9
        '
        Me.Timer9.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Skydive.My.Resources.Resources.fall
        Me.PictureBox1.Location = New System.Drawing.Point(32, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Scoep)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MPH)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.stablibu)
        Me.Controls.Add(Me.balanceb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitbu)
        Me.Controls.Add(Me.Walkytalky)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.opbut)
        Me.Controls.Add(Me.altat)
        Me.Controls.Add(Me.alta)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "game"
        Me.Text = "game"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents alta As System.Windows.Forms.Label
    Friend WithEvents altat As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents opbut As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Walkytalky As System.Windows.Forms.Label
    Friend WithEvents exitbu As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents balanceb As System.Windows.Forms.ProgressBar
    Friend WithEvents stablibu As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MPH As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents score As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents Timer7 As System.Windows.Forms.Timer
    Friend WithEvents Timer8 As System.Windows.Forms.Timer
    Friend WithEvents Scoep As System.Windows.Forms.Label
    Friend WithEvents Timer9 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
