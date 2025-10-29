Imports MySql.Data.MySqlClient

Public Class manageroom
    Private connString As String = "server=localhost;userid=root;password=;database=hoteldb"

    ' Populate room type list once
    Private Sub manageroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Single")
        ListBox1.Items.Add("Twin")
        ListBox1.Items.Add("Standard")
        ListBox1.Items.Add("Deluxe")

        ListBox2.Items.Clear()
        ListBox2.Items.Add("Available")
        ListBox2.Items.Add("Unavailable")
        ListBox2.Items.Add("Reserved")

        ListBox1.SelectionMode = SelectionMode.One
        ListBox2.SelectionMode = SelectionMode.One
    End Sub

    ' When staff enters room ID, load room info
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then Exit Sub
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM rooms WHERE room_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", TextBox1.Text)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    TextBox2.Text = reader("price").ToString()
                    TextBox3.Text = reader("room_id").ToString()
                    TextBox4.Text = reader("room_rules").ToString()
                    ' Select type in ListBox1
                    ListBox1.SelectedItem = reader("room_type").ToString()
                    ' Select status in ListBox2
                    ListBox2.SelectedItem = reader("roomstatus").ToString()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Update room in database
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or ListBox1.SelectedIndex = -1 Or ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields and select type/status.")
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE rooms SET room_type=@type, price=@price, room_rules=@rules, roomstatus=@status WHERE room_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", TextBox1.Text)
                cmd.Parameters.AddWithValue("@type", ListBox1.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@price", CDec(TextBox2.Text))
                cmd.Parameters.AddWithValue("@rules", TextBox4.Text)
                cmd.Parameters.AddWithValue("@status", ListBox2.SelectedItem.ToString())
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Room updated successfully.")
                Else
                    MessageBox.Show("Room ID not found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
