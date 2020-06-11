<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pbDie1 = New System.Windows.Forms.PictureBox()
        Me.pbDie2 = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pbDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDie1
        '
        Me.pbDie1.Location = New System.Drawing.Point(47, 54)
        Me.pbDie1.Name = "pbDie1"
        Me.pbDie1.Size = New System.Drawing.Size(189, 203)
        Me.pbDie1.TabIndex = 0
        Me.pbDie1.TabStop = False
        '
        'pbDie2
        '
        Me.pbDie2.Location = New System.Drawing.Point(275, 54)
        Me.pbDie2.Name = "pbDie2"
        Me.pbDie2.Size = New System.Drawing.Size(189, 203)
        Me.pbDie2.TabIndex = 1
        Me.pbDie2.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(64, 303)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(153, 62)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "Roll Dice"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(291, 303)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 62)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 399)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.pbDie2)
        Me.Controls.Add(Me.pbDie1)
        Me.Name = "Form1"
        Me.Text = "Dice Simulator"
        CType(Me.pbDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDie2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbDie1 As PictureBox
    Friend WithEvents pbDie2 As PictureBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents btnExit As Button
End Class
