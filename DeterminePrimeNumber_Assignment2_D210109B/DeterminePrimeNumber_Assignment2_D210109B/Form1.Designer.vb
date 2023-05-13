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
        Me.number1 = New System.Windows.Forms.TextBox()
        Me.number2 = New System.Windows.Forms.TextBox()
        Me.CalButton = New System.Windows.Forms.Button()
        Me.answerBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(286, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To"
        '
        'number1
        '
        Me.number1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.number1.Location = New System.Drawing.Point(103, 168)
        Me.number1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.number1.Name = "number1"
        Me.number1.Size = New System.Drawing.Size(154, 23)
        Me.number1.TabIndex = 1
        '
        'number2
        '
        Me.number2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.number2.Location = New System.Drawing.Point(344, 168)
        Me.number2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.number2.Name = "number2"
        Me.number2.Size = New System.Drawing.Size(157, 23)
        Me.number2.TabIndex = 2
        '
        'CalButton
        '
        Me.CalButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CalButton.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CalButton.Location = New System.Drawing.Point(163, 256)
        Me.CalButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CalButton.Name = "CalButton"
        Me.CalButton.Size = New System.Drawing.Size(264, 40)
        Me.CalButton.TabIndex = 3
        Me.CalButton.Text = "Calculate Prime Number"
        Me.CalButton.UseVisualStyleBackColor = False
        '
        'answerBox
        '
        Me.answerBox.FormattingEnabled = True
        Me.answerBox.ItemHeight = 15
        Me.answerBox.Location = New System.Drawing.Point(564, 64)
        Me.answerBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.answerBox.Name = "answerBox"
        Me.answerBox.Size = New System.Drawing.Size(263, 304)
        Me.answerBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 25.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(163, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 46)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PRIME NUMBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(163, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BEGIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(394, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "END"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(850, 383)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.answerBox)
        Me.Controls.Add(Me.CalButton)
        Me.Controls.Add(Me.number2)
        Me.Controls.Add(Me.number1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents number1 As TextBox
    Friend WithEvents number2 As TextBox
    Friend WithEvents CalButton As Button
    Friend WithEvents answerBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
