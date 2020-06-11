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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rockRadioButton = New System.Windows.Forms.RadioButton()
        Me.paperRadioButton = New System.Windows.Forms.RadioButton()
        Me.scissorsRadioButton = New System.Windows.Forms.RadioButton()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(309, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Shoot!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose"
        '
        'rockRadioButton
        '
        Me.rockRadioButton.AutoSize = True
        Me.rockRadioButton.Location = New System.Drawing.Point(48, 57)
        Me.rockRadioButton.Name = "rockRadioButton"
        Me.rockRadioButton.Size = New System.Drawing.Size(61, 21)
        Me.rockRadioButton.TabIndex = 3
        Me.rockRadioButton.TabStop = True
        Me.rockRadioButton.Text = "Rock"
        Me.rockRadioButton.UseVisualStyleBackColor = True
        '
        'paperRadioButton
        '
        Me.paperRadioButton.AutoSize = True
        Me.paperRadioButton.Location = New System.Drawing.Point(48, 84)
        Me.paperRadioButton.Name = "paperRadioButton"
        Me.paperRadioButton.Size = New System.Drawing.Size(67, 21)
        Me.paperRadioButton.TabIndex = 4
        Me.paperRadioButton.TabStop = True
        Me.paperRadioButton.Text = "Paper"
        Me.paperRadioButton.UseVisualStyleBackColor = True
        '
        'scissorsRadioButton
        '
        Me.scissorsRadioButton.AutoSize = True
        Me.scissorsRadioButton.Location = New System.Drawing.Point(48, 113)
        Me.scissorsRadioButton.Name = "scissorsRadioButton"
        Me.scissorsRadioButton.Size = New System.Drawing.Size(82, 21)
        Me.scissorsRadioButton.TabIndex = 5
        Me.scissorsRadioButton.TabStop = True
        Me.scissorsRadioButton.Text = "Scissors"
        Me.scissorsRadioButton.UseVisualStyleBackColor = True
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultLabel.Location = New System.Drawing.Point(145, 177)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(225, 28)
        Me.resultLabel.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 237)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.scissorsRadioButton)
        Me.Controls.Add(Me.paperRadioButton)
        Me.Controls.Add(Me.rockRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rockRadioButton As RadioButton
    Friend WithEvents paperRadioButton As RadioButton
    Friend WithEvents scissorsRadioButton As RadioButton
    Friend WithEvents resultLabel As Label
End Class
