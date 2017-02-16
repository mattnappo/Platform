<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InputTextBox
        '
        Me.InputTextBox.BackColor = System.Drawing.Color.Black
        Me.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputTextBox.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.InputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.InputTextBox.Location = New System.Drawing.Point(344, 251)
        Me.InputTextBox.Multiline = True
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(285, 30)
        Me.InputTextBox.TabIndex = 3
        '
        'ExecuteButton
        '
        Me.ExecuteButton.BackColor = System.Drawing.Color.Black
        Me.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExecuteButton.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.ExecuteButton.ForeColor = System.Drawing.Color.Lime
        Me.ExecuteButton.Location = New System.Drawing.Point(448, 337)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(82, 30)
        Me.ExecuteButton.TabIndex = 2
        Me.ExecuteButton.Text = "Login"
        Me.ExecuteButton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(344, 287)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(285, 30)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(434, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Platform Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 592)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.ExecuteButton)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExecuteButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
