Public Class Form1
    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub

    Private Sub Button_Book_Click(sender As Object, e As EventArgs) Handles Button_Book.Click
        BookForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub
End Class
