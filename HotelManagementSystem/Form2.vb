Imports MySql.Data.MySqlClient

Public Class Form2

    ' Connection string
    Private connString As String = "server=localhost;userid=root;password=;database=hoteldb"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRooms()
    End Sub

    ' Load all rooms data safely
    Private Sub LoadRooms()
        ListBox1.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT room_id, room_type, price, room_rules, roomstatus FROM rooms"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ListBox1.Items.Add(reader("room_type").ToString())
                            ListBox3.Items.Add(reader("room_id").ToString())
                            ListBox4.Items.Add(reader("price").ToString())
                            ListBox5.Items.Add(reader("room_rules").ToString())
                            ListBox6.Items.Add(reader("roomstatus").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading rooms: " & ex.Message)
        End Try
    End Sub

    ' Add new room
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "INSERT INTO rooms (room_id, room_type, room_rules, price, roomstatus) VALUES (@room_id, @room_type, @room_rules, @price, @roomstatus)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@room_id", ListBox3.Text)
                    cmd.Parameters.AddWithValue("@room_type", ListBox1.Text)
                    cmd.Parameters.AddWithValue("@room_rules", ListBox5.Text)
                    cmd.Parameters.AddWithValue("@price", ListBox4.Text)
                    cmd.Parameters.AddWithValue("@roomstatus", ListBox6.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Room added successfully.")
            LoadRooms()
        Catch ex As Exception
            MessageBox.Show("Error adding room: " & ex.Message)
        End Try
    End Sub

    ' Delete room
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "DELETE FROM rooms WHERE room_id=@room_id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@room_id", ListBox3.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Room deleted successfully.")
            LoadRooms()
        Catch ex As Exception
            MessageBox.Show("Error deleting room: " & ex.Message)
        End Try
    End Sub

    ' When selecting a room ID, update other ListBoxes to match
    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Dim index As Integer = ListBox3.SelectedIndex
        If index >= 0 AndAlso index < ListBox1.Items.Count Then
            ListBox1.SelectedIndex = index
            ListBox4.SelectedIndex = index
            ListBox5.SelectedIndex = index
            ListBox6.SelectedIndex = index
        End If
    End Sub

<<<<<<< Updated upstream
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
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

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
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
=======
>>>>>>> Stashed changes
End Class
