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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(230, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open skribbl"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(28, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "skribbl.io "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ink Free", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(139, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "BOT"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(28, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Start Bot"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(28, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Stop Bot"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(256, 170)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.85R
        Me.Text = "Scribble"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
