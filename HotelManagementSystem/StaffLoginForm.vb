Imports MySql.Data.MySqlClient

Public Class StaffLoginForm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        ViewForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Book2_Click(sender As Object, e As EventArgs) Handles Button_Book2.Click
        BookForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Check_Click(sender As Object, e As EventArgs) Handles Button_Check.Click
        CheckInOut.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub
    Private Sub Button_login2_Click(sender As Object, e As EventArgs) Handles Button_login2.Click
        If String.IsNullOrWhiteSpace(TextBoxUser.Text) OrElse String.IsNullOrWhiteSpace(TextBoxPass.Text) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"
            conn.Open()

            Dim sql As String = "SELECT * FROM staff WHERE email = @username AND pass = @password"
            command = New MySqlCommand(sql, conn)
            Command.Parameters.AddWithValue("@username", TextBoxUser.Text)
            Command.Parameters.AddWithValue("@password", TextBoxPass.Text)

            Dim reader As MySqlDataReader = Command.ExecuteReader()

            If reader.Read() Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Staff_Dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try


    End Sub
End Class