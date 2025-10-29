
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")
    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Staff_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Load room type from database (rooms.room_type)
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DISTINCT room_type FROM rooms", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While reader.Read()
                ComboBox1.Items.Add(reader("room_type").ToString())
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add new room to database
        Try
            conn.Open()
            Dim query As String = "INSERT INTO rooms (room_id, room_type, room_rules, price, roomstatus) VALUES (@room_id, @room_type, @room_rules, @price, @roomstatus)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@room_id", TextBox2.Text)
            cmd.Parameters.AddWithValue("@room_type", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@room_rules", TextBox5.Text)
            cmd.Parameters.AddWithValue("@price", TextBox4.Text)
            cmd.Parameters.AddWithValue("@roomstatus", TextBox6.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Room added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Delete room from database based on room_id
        Try
            conn.Open()
            Dim query As String = "DELETE FROM rooms WHERE room_id = @room_id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@room_id", TextBox2.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Room deleted successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class