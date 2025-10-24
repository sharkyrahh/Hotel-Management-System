Public Class BookForm

    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        ViewForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_CheckIn_Click(sender As Object, e As EventArgs) Handles Button_CheckIn.Click
        CheckIn.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub
End Class