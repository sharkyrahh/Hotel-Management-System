Imports MySql.Data.MySqlClient

Public Class Form2
    ' Single shared connection
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate room types once when form loads
        LoadRoomTypes()
    End Sub

    Private Sub LoadRoomTypes()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DISTINCT room_type FROM rooms", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While reader.Read()
                ComboBox1.Items.Add(reader("room_type").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading room types: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Staff_Dashboard.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add new room
        Try
            conn.Open()
            Dim query As String = "INSERT INTO rooms (room_id, room_type, room_rules, price, roomstatus) VALUES (@room_id, @room_type, @room_rules, @price, @roomstatus)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@room_id", TextBox2.Text)
                cmd.Parameters.AddWithValue("@room_type", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@room_rules", TextBox5.Text)
                cmd.Parameters.AddWithValue("@price", TextBox4.Text)
                cmd.Parameters.AddWithValue("@roomstatus", TextBox6.Text)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Room added successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding room: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Delete room by room_id
        Try
            conn.Open()
            Dim query As String = "DELETE FROM rooms WHERE room_id = @room_id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@room_id", TextBox2.Text)
                Dim affected As Integer = cmd.ExecuteNonQuery()
                If affected > 0 Then
                    MessageBox.Show("Room deleted successfully.")
                Else
                    MessageBox.Show("Room ID not found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting room: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Optional: handle selection for other logic
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Only triggers when user changes selection
        ' Add code here if needed for filtering or display
    End Sub
End Class
