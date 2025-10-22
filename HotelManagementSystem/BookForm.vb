Public Class BookForm
    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PaymentForm.Show()
        Me.Hide()
    End Sub
End Class