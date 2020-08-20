<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shop
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
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Yellow
        Me.Button9.Location = New System.Drawing.Point(16, 38)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 91)
        Me.Button9.TabIndex = 38
        Me.Button9.Text = "Buy x500 for only 40000 score"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Yellow
        Me.Button8.Location = New System.Drawing.Point(97, 38)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 91)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "Buy x10 score for only 2000 score"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Yellow
        Me.Button7.Location = New System.Drawing.Point(193, 38)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 91)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "Buy quick score X2 for only 1023 score"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 91)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Buy realy stable for only 167 score"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(397, 302)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "shop"
        Me.Text = "shop"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
