<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.OutputTextBox = New System.Windows.Forms.RichTextBox()
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.CodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Code = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearWindowToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HashBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearHashBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.HashBox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.dnt = New System.Windows.Forms.Label()
        Me.ipv4 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputTextBox
        '
        Me.InputTextBox.BackColor = System.Drawing.Color.Black
        Me.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputTextBox.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.InputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.InputTextBox.Location = New System.Drawing.Point(355, 309)
        Me.InputTextBox.Multiline = True
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(529, 30)
        Me.InputTextBox.TabIndex = 1
        '
        'OutputTextBox
        '
        Me.OutputTextBox.BackColor = System.Drawing.Color.Black
        Me.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutputTextBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.OutputTextBox.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.OutputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.OutputTextBox.Location = New System.Drawing.Point(355, 345)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(617, 236)
        Me.OutputTextBox.TabIndex = 2
        Me.OutputTextBox.Text = ""
        '
        'ExecuteButton
        '
        Me.ExecuteButton.BackColor = System.Drawing.Color.Black
        Me.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExecuteButton.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.ExecuteButton.ForeColor = System.Drawing.Color.Lime
        Me.ExecuteButton.Location = New System.Drawing.Point(890, 309)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(82, 30)
        Me.ExecuteButton.TabIndex = 0
        Me.ExecuteButton.Text = "Execute"
        Me.ExecuteButton.UseVisualStyleBackColor = False
        '
        'CodeToolStripMenuItem
        '
        Me.CodeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ClearToolStripMenuItem1, Me.ShowToolStripMenuItem1, Me.ToolStripMenuItem1})
        Me.CodeToolStripMenuItem.Name = "CodeToolStripMenuItem"
        Me.CodeToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.CodeToolStripMenuItem.Text = "Code"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ResetToolStripMenuItem.Text = "Reset Code"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear Editor"
        '
        'ShowToolStripMenuItem1
        '
        Me.ShowToolStripMenuItem1.Name = "ShowToolStripMenuItem1"
        Me.ShowToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ShowToolStripMenuItem1.Text = "Show Editor"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        '
        'Code
        '
        Me.Code.BackColor = System.Drawing.Color.Black
        Me.Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Code.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.Code.ForeColor = System.Drawing.Color.Lime
        Me.Code.Location = New System.Drawing.Point(12, 27)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(617, 276)
        Me.Code.TabIndex = 4
        Me.Code.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsoleToolStripMenuItem, Me.CodeToolStripMenuItem1, Me.HashBoxToolStripMenuItem, Me.SessionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsoleToolStripMenuItem
        '
        Me.ConsoleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearWindowToolStripMenuItem, Me.ShowWindowToolStripMenuItem, Me.HideWindowToolStripMenuItem})
        Me.ConsoleToolStripMenuItem.Name = "ConsoleToolStripMenuItem"
        Me.ConsoleToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ConsoleToolStripMenuItem.Text = "Console"
        '
        'ClearWindowToolStripMenuItem
        '
        Me.ClearWindowToolStripMenuItem.Name = "ClearWindowToolStripMenuItem"
        Me.ClearWindowToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ClearWindowToolStripMenuItem.Text = "Clear Window"
        '
        'ShowWindowToolStripMenuItem
        '
        Me.ShowWindowToolStripMenuItem.Name = "ShowWindowToolStripMenuItem"
        Me.ShowWindowToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ShowWindowToolStripMenuItem.Text = "Show Window"
        '
        'HideWindowToolStripMenuItem
        '
        Me.HideWindowToolStripMenuItem.Name = "HideWindowToolStripMenuItem"
        Me.HideWindowToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.HideWindowToolStripMenuItem.Text = "Hide Window"
        '
        'CodeToolStripMenuItem1
        '
        Me.CodeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadCodeToolStripMenuItem, Me.ClearWindowToolStripMenuItem1, Me.SaveAsNewToolStripMenuItem, Me.DetachToolStripMenuItem, Me.AttachToolStripMenuItem})
        Me.CodeToolStripMenuItem1.Name = "CodeToolStripMenuItem1"
        Me.CodeToolStripMenuItem1.Size = New System.Drawing.Size(47, 20)
        Me.CodeToolStripMenuItem1.Text = "Code"
        '
        'ReloadCodeToolStripMenuItem
        '
        Me.ReloadCodeToolStripMenuItem.Name = "ReloadCodeToolStripMenuItem"
        Me.ReloadCodeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ReloadCodeToolStripMenuItem.Text = "Reload Code"
        '
        'ClearWindowToolStripMenuItem1
        '
        Me.ClearWindowToolStripMenuItem1.Name = "ClearWindowToolStripMenuItem1"
        Me.ClearWindowToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ClearWindowToolStripMenuItem1.Text = "Clear Window"
        '
        'SaveAsNewToolStripMenuItem
        '
        Me.SaveAsNewToolStripMenuItem.Name = "SaveAsNewToolStripMenuItem"
        Me.SaveAsNewToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SaveAsNewToolStripMenuItem.Text = "Save As New File"
        '
        'DetachToolStripMenuItem
        '
        Me.DetachToolStripMenuItem.Name = "DetachToolStripMenuItem"
        Me.DetachToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DetachToolStripMenuItem.Text = "Detach"
        '
        'AttachToolStripMenuItem
        '
        Me.AttachToolStripMenuItem.Name = "AttachToolStripMenuItem"
        Me.AttachToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AttachToolStripMenuItem.Text = "Attach"
        '
        'HashBoxToolStripMenuItem
        '
        Me.HashBoxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ClearHashBoxToolStripMenuItem})
        Me.HashBoxToolStripMenuItem.Name = "HashBoxToolStripMenuItem"
        Me.HashBoxToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.HashBoxToolStripMenuItem.Text = "HashBox"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.StartToolStripMenuItem.Text = "Start External Hash"
        '
        'ClearHashBoxToolStripMenuItem
        '
        Me.ClearHashBoxToolStripMenuItem.Name = "ClearHashBoxToolStripMenuItem"
        Me.ClearHashBoxToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ClearHashBoxToolStripMenuItem.Text = "Clear HashBox"
        '
        'SessionToolStripMenuItem
        '
        Me.SessionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartSessionToolStripMenuItem, Me.EndSessionToolStripMenuItem})
        Me.SessionToolStripMenuItem.Name = "SessionToolStripMenuItem"
        Me.SessionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SessionToolStripMenuItem.Text = "Session"
        '
        'StartSessionToolStripMenuItem
        '
        Me.StartSessionToolStripMenuItem.Name = "StartSessionToolStripMenuItem"
        Me.StartSessionToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.StartSessionToolStripMenuItem.Text = "Start Session"
        '
        'EndSessionToolStripMenuItem
        '
        Me.EndSessionToolStripMenuItem.Name = "EndSessionToolStripMenuItem"
        Me.EndSessionToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EndSessionToolStripMenuItem.Text = "End Session"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HashBox
        '
        Me.HashBox.BackColor = System.Drawing.Color.Black
        Me.HashBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HashBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HashBox.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.HashBox.ForeColor = System.Drawing.Color.Lime
        Me.HashBox.Location = New System.Drawing.Point(12, 345)
        Me.HashBox.Name = "HashBox"
        Me.HashBox.ReadOnly = True
        Me.HashBox.Size = New System.Drawing.Size(337, 236)
        Me.HashBox.TabIndex = 7
        Me.HashBox.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(12, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Generate Hash"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 284)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(960, 55)
        Me.ProgressBar1.TabIndex = 9
        '
        'dnt
        '
        Me.dnt.AutoSize = True
        Me.dnt.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dnt.ForeColor = System.Drawing.Color.Lime
        Me.dnt.Location = New System.Drawing.Point(831, 29)
        Me.dnt.Name = "dnt"
        Me.dnt.Size = New System.Drawing.Size(0, 19)
        Me.dnt.TabIndex = 10
        '
        'ipv4
        '
        Me.ipv4.AutoSize = True
        Me.ipv4.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ipv4.ForeColor = System.Drawing.Color.Lime
        Me.ipv4.Location = New System.Drawing.Point(635, 29)
        Me.ipv4.Name = "ipv4"
        Me.ipv4.Size = New System.Drawing.Size(0, 19)
        Me.ipv4.TabIndex = 11
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 592)
        Me.Controls.Add(Me.ipv4)
        Me.Controls.Add(Me.dnt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HashBox)
        Me.Controls.Add(Me.Code)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.ExecuteButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Main"
        Me.Text = "Platform"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OutputTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ExecuteButton As System.Windows.Forms.Button
    Friend WithEvents CodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Code As System.Windows.Forms.RichTextBox
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearWindowToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DetachToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HashBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HashBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearHashBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents dnt As System.Windows.Forms.Label
    Friend WithEvents ipv4 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
