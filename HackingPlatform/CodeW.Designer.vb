<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeW
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
        Me.Code = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Code
        '
        Me.Code.BackColor = System.Drawing.Color.Black
        Me.Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Code.Font = New System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(77, Byte))
        Me.Code.ForeColor = System.Drawing.Color.Lime
        Me.Code.Location = New System.Drawing.Point(12, 12)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(957, 597)
        Me.Code.TabIndex = 5
        Me.Code.Text = ""
        '
        'CodeW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(981, 620)
        Me.Controls.Add(Me.Code)
        Me.Name = "CodeW"
        Me.Text = "Code"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Code As System.Windows.Forms.RichTextBox
End Class
