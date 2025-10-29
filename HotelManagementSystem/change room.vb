Public Class change_room
    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            Dim loginForm As New StaffLoginForm()
            loginForm.Show()
        End If
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        manageroom.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Manage_Click(sender As Object, e As EventArgs) Handles Button_Manage.Click
        Add_Staff.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Staff_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class