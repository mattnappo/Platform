Imports System.IO
Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Public Class Main
    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OutputTextBox.Visible = False
        InputTextBox.Visible = False
        ExecuteButton.Visible = False
        Code.Visible = False
        HashBox.Visible = False
        Button1.Visible = False
        MenuStrip1.Visible = False

        Timer2.Start()

        Me.AcceptButton = ExecuteButton
        MyProcess = New Process
        With MyProcess.StartInfo
            .FileName = "CMD.EXE"
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        MyProcess.Start()
        MyProcess.BeginErrorReadLine()      'start async read on stderr
        MyProcess.BeginOutputReadLine()     'start async read on stdout
        AppendOutputText("Process Started at: " & MyProcess.StartTime.ToString)
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MyProcess.StandardInput.WriteLine("EXIT") 'send an EXIT command to the Command Prompt
        MyProcess.StandardInput.Flush()
        MyProcess.Close()
    End Sub
    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived
        AppendOutputText(vbCrLf & "Error: " & e.Data)
    End Sub
    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub
    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteButton.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub
    Private Sub AppendOutputText(ByVal text As String)
        If OutputTextBox.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            OutputTextBox.AppendText(text)
        End If
    End Sub
    Private Sub OutputTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles OutputTextBox.TextChanged
        OutputTextBox.SelectionStart = OutputTextBox.Text.Length
        OutputTextBox.ScrollToCaret()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub ClearToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem1.Click
        Code.Clear()
    End Sub
    Private Sub ReloadCodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReloadCodeToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim text As String = File.ReadAllText(OpenFileDialog1.FileName)
            Code.Text = text
        End If
    End Sub

    Private Sub ClearWindowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearWindowToolStripMenuItem.Click
        OutputTextBox.Clear()
    End Sub
    Private Sub ShowWindowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowWindowToolStripMenuItem.Click
        OutputTextBox.Visible = True
        InputTextBox.Visible = True
        ExecuteButton.Visible = True
    End Sub
    Private Sub HideWindowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HideWindowToolStripMenuItem.Click
        OutputTextBox.Visible = False
        InputTextBox.Visible = False
        ExecuteButton.Visible = False
    End Sub

    Private Sub ClearWindowToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ClearWindowToolStripMenuItem1.Click
        Code.Clear()
    End Sub

    Private Sub DetachToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DetachToolStripMenuItem.Click
        Code.Visible = False
        CodeW.Code.Text = Code.Text
        CodeW.Show()
    End Sub
    Function MD5(ByRef strText As String) As String
        Dim Service As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim Bytes() As Byte = Service.ComputeHash(System.Text.Encoding.ASCII.GetBytes(strText))
        Dim str As String
        For Each By As Byte In Bytes
            str += By.ToString("x2")
        Next
        Return str
    End Function
    Private Sub AttachToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AttachToolStripMenuItem.Click
        Code.Visible = True
        Code.Text = CodeW.Code.Text
        CodeW.Hide()
    End Sub
    Private Sub hash_TextChanged(sender As System.Object, e As System.EventArgs) Handles HashBox.TextChanged
        HashBox.SelectionStart = HashBox.Text.Length
        HashBox.ScrollToCaret()
    End Sub
    Function randomString()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Sub StartToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Shell("python hash.py")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        HashBox.AppendText(MD5(randomString()) + "\n")
    End Sub

    Private Sub ClearHashBoxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearHashBoxToolStripMenuItem.Click
        HashBox.Clear()
    End Sub

    Private Sub StartSessionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StartSessionToolStripMenuItem.Click
        SessionW.Show()
    End Sub

    Private Sub EndSessionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EndSessionToolStripMenuItem.Click
        SessionW.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            ProgressBar1.Visible = False
            OutputTextBox.Visible = True
            InputTextBox.Visible = True
            ExecuteButton.Visible = True
            Code.Visible = True
            HashBox.Visible = True
            Button1.Visible = True
            MenuStrip1.Visible = True
        End If
    End Sub
    Private Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)
        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                ipv4.Text = GetIPv4Address = ipheal.ToString()
            End If
        Next
    End Function

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs)

    End Sub
End Class