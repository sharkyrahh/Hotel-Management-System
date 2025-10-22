Public Class BookForm
    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PaymentForm.Show()
        Hide()
    End Sub

    Private Sub Button_Find_Click(sender As Object, e As EventArgs) Handles Button_Find.Click
        GroupBox_Rooms.Visible = True
    End Sub

    Private Sub CheckBox_Standard_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Standard.CheckedChanged
        If CheckBox_Standard.Checked = True Then
            GroupBox_RoomNumber.Visible = True
            Panel_Standard.Visible = True
        Else
            Panel_Standard.Visible = False
        End If
    End Sub

    Private Sub CheckBox_Deluxe_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Deluxe.CheckedChanged
        If CheckBox_Deluxe.Checked = True Then
            GroupBox_RoomNumber.Visible = True
            Panel_Deluxe.Visible = True
        Else
            Panel_Deluxe.Visible = False
        End If
    End Sub

    Private Sub CheckBox_Twin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Twin.CheckedChanged
        If CheckBox_Twin.Checked = True Then
            GroupBox_RoomNumber.Visible = True
            Panel_Twin.Visible = True
        Else
            Panel_Twin.Visible = False
        End If
    End Sub

    Private Sub CheckBox_Single_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Single.CheckedChanged
        If CheckBox_Single.Checked = True Then
            GroupBox_RoomNumber.Visible = True
            Panel_Single.Visible = True
        Else
            Panel_Single.Visible = False
        End If
    End Sub
End Class