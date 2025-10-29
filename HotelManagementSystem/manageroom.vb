Imports MySql.Data.MySqlClient

Public Class manageroom
    Private connString As String = "server=localhost;userid=root;password=;database=hoteldb"

    ' Add room
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ListBox1.SelectedIndex = -1 Or ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields except Room ID.")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO rooms (room_id, room_type, room_rules, price, roomstatus) VALUES (@id, @type, @rules, @price, @status)", conn)
                If TextBox1.Text = "" Then
                    cmd.Parameters.AddWithValue("@id", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@id", CInt(TextBox1.Text))
                End If
                cmd.Parameters.AddWithValue("@type", ListBox1.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@rules", TextBox4.Text)
                cmd.Parameters.AddWithValue("@price", Decimal.Parse(TextBox2.Text))
                cmd.Parameters.AddWithValue("@status", ListBox2.SelectedItem.ToString())
                cmd.ExecuteNonQuery()
                MessageBox.Show("Room added successfully.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    ' Update room
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter Room ID to update.")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE rooms SET room_type=@type, room_rules=@rules, price=@price, roomstatus=@status WHERE room_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", CInt(TextBox1.Text))
                cmd.Parameters.AddWithValue("@type", ListBox1.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@rules", TextBox4.Text)
                cmd.Parameters.AddWithValue("@price", Decimal.Parse(TextBox2.Text))
                cmd.Parameters.AddWithValue("@status", ListBox2.SelectedItem.ToString())
                Dim rows As Integer = cmd.ExecuteNonQuery()
                If rows > 0 Then
                    MessageBox.Show("Room updated successfully.")
                Else
                    MessageBox.Show("No room found with that ID.")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    ' Delete room
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter Room ID to delete.")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM rooms WHERE room_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", CInt(TextBox1.Text))
                Dim rows As Integer = cmd.ExecuteNonQuery()
                If rows > 0 Then
                    MessageBox.Show("Room deleted successfully.")
                Else
                    MessageBox.Show("No room found with that ID.")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    ' Clear all fields
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ListBox1.ClearSelected()
        ListBox2.ClearSelected()
    End Sub

    ' Back / Dashboard
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New Form1
        f.Show()
        Me.Hide()
    End Sub

    ' Populate ListBox1 with room types (example)
    Private Sub manageroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Single")
        ListBox1.Items.Add("Twin")
        ListBox1.Items.Add("Standard")
        ListBox1.Items.Add("Deluxe")

        ListBox2.Items.Clear()
        ListBox2.Items.Add("Available")
        ListBox2.Items.Add("Reserved")
        ListBox2.Items.Add("Unavailable")
    End Sub

    ' Optional: Fill TextBox1 when selecting from a list of room IDs (if you have a ListBox3)
    Private Sub ListBoxRoomIDs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        If ListBox3.SelectedIndex <> -1 Then
            TextBox1.Text = ListBox3.SelectedItem.ToString()
        End If
    End Sub
End Class
