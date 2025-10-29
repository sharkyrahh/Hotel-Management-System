Public Class ViewForm

    Dim typeNumber As Integer = 1
    Dim strPic As String
    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Book_Click(sender As Object, e As EventArgs) Handles Button_Book.Click
        BookForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_CheckIn_Click(sender As Object, e As EventArgs) Handles Button_CheckIn.Click
        CheckIn.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button_Login2_Click(sender As Object, e As EventArgs) Handles Button_Login2.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        If typeNumber <> 4 Then
            typeNumber = typeNumber + 1
        Else
            typeNumber = 1
        End If


        If typeNumber = 1 Then
            PictureBox_View.Image = My.Resources.standard
            Label_RoomType.Text = "Standard Room"
            Label_Desc1.Text = "Includes one queen sized bed."
            Label_Desc2.Text = "Suitable for two people."
        ElseIf typeNumber = 2 Then
            PictureBox_View.Image = My.Resources.deluxe
            Label_RoomType.Text = "Deluxe Room"
            Label_Desc1.Text = "Includes two queen sized beds."
            Label_Desc2.Text = "Suitable for four people."
        ElseIf typeNumber = 3 Then
            PictureBox_View.Image = My.Resources._single
            Label_RoomType.Text = "Single Room"
            Label_Desc1.Text = "Includes one single sized bed."
            Label_Desc2.Text = "Suitable for one person."
        ElseIf typeNumber = 4 Then
            PictureBox_View.Image = My.Resources.twin
            Label_RoomType.Text = "Twin Room"
            Label_Desc1.Text = "Includes two single sized beds."
            Label_Desc2.Text = "Suitable for two people."
        End If
    End Sub

    Private Sub Button_Previous_Click(sender As Object, e As EventArgs) Handles Button_Previous.Click
        If typeNumber <> 1 Then
            typeNumber = typeNumber - 1
        Else
            typeNumber = 4
        End If


        If typeNumber = 1 Then
            PictureBox_View.Image = My.Resources.standard
            Label_RoomType.Text = "Standard Room"
            Label_Desc1.Text = "Includes one queen sized bed."
            Label_Desc2.Text = "Suitable for two people."
        ElseIf typeNumber = 2 Then
            PictureBox_View.Image = My.Resources.deluxe
            Label_RoomType.Text = "Deluxe Room"
            Label_Desc1.Text = "Includes two queen sized beds."
            Label_Desc2.Text = "Suitable for four people."
        ElseIf typeNumber = 3 Then
            PictureBox_View.Image = My.Resources._single
            Label_RoomType.Text = "Single Room"
            Label_Desc1.Text = "Includes one single sized bed."
            Label_Desc2.Text = "Suitable for one person."
        ElseIf typeNumber = 4 Then
            PictureBox_View.Image = My.Resources.twin
            Label_RoomType.Text = "Twin Room"
            Label_Desc1.Text = "Includes two single sized beds."
            Label_Desc2.Text = "Suitable for two people."
        End If
    End Sub
End Class