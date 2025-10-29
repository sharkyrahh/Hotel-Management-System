Imports System.ComponentModel.DataAnnotations
Imports MySql.Data.MySqlClient



Public Class Add_Staff
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")

    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            Dim loginForm As New StaffLoginForm()
            loginForm.Show()
        End If
    End Sub

    Private Sub Button_Change_Click(sender As Object, e As EventArgs) Handles Button_Change.Click
        change_room.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Staff_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        manageroom.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO staff(name, email, pass) VALUES(@name, @mail, @pass)", conn)
            cmd.Parameters.AddWithValue("@name", TextBox1.Text)
            cmd.Parameters.AddWithValue("@mail", TextBox4.Text)
            cmd.Parameters.AddWithValue("@pass", TextBox6.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Staff added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Check staff email existence
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM staff WHERE email=@mail", conn)
            cmd.Parameters.AddWithValue("@mail", TextBox4.Text)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Email exists in database.")
            Else
                MessageBox.Show("Email not found.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Delete staff by email
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM staff WHERE email=@mail", conn)
            cmd.Parameters.AddWithValue("@mail", TextBox4.Text)
            Dim rows As Integer = cmd.ExecuteNonQuery()
            If rows > 0 Then
                MessageBox.Show("Staff deleted successfully.")
            Else
                MessageBox.Show("Email not found.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class