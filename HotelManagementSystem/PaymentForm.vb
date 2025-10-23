Public Class PaymentForm
    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        BookForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Receipt_Click(sender As Object, e As EventArgs) Handles Button_Receipt.Click
        ReceiptForm.Show()
    End Sub
End Class