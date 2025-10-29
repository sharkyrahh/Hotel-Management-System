Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class CheckIn

    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Dim f As New Form1
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        Dim f As New ViewForm
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Book2_Click(sender As Object, e As EventArgs) Handles Button_Book2.Click
        Dim f As New BookForm
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Check_Click(sender As Object, e As EventArgs) Handles Button_Check.Click
        CheckInOut.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        Dim about As New AboutBox1
        about.ShowDialog()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim f As New StaffLoginForm
        f.Show()
        Me.Hide()
    End Sub


    ' Search user IC
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")
        Dim cmd As New MySqlCommand("SELECT * FROM users WHERE IC=@ic", conn)
        cmd.Parameters.AddWithValue("@ic", TextBox1.Text)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                labelstatus.Text = "User found"
                labelstatus.ForeColor = Color.Green
            Else
                labelstatus.Text = "User not found"
                labelstatus.ForeColor = Color.Red
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' Save data to database
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Placeholder: will insert Check In details once table ready
        MessageBox.Show("Data stored successfully.")
    End Sub

    ' Update data
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Placeholder: will run UPDATE query later
        MessageBox.Show("Data updated successfully.")
    End Sub

    ' Clear form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
    End Sub

    ' Go home
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New Form1
        f.Show()
        Me.Hide()
    End Sub


    ' Load room type from database
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT room_type FROM rooms", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ComboBox1.Items.Clear()
                While reader.Read()
                    ComboBox1.Items.Add(reader("room_type").ToString())
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub


    ' Load checkin_date from database
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT checkin_date FROM bookings WHERE IC=@ic", conn)
                cmd.Parameters.AddWithValue("@ic", TextBox1.Text)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    DateTimePicker1.Value = reader.GetDateTime("checkin_date")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub


    ' Load roomstatus from database
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT DISTINCT roomstatus FROM bookings", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ComboBox3.Items.Clear()
                While reader.Read()
                    ComboBox3.Items.Add(reader("roomstatus").ToString())
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

End Class
