Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class manageroom
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")

    ' Add room
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO rooms (room_id, room_type, room_rules, price, roomstatus) VALUES (@id, @type, @rules, @price, @status)", conn)
            cmd.Parameters.AddWithValue("@id", TextBox3.Text)
            cmd.Parameters.AddWithValue("@type", ListBox1.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@rules", TextBox4.Text)
            cmd.Parameters.AddWithValue("@price", TextBox2.Text)
            cmd.Parameters.AddWithValue("@status", ListBox2.SelectedItem.ToString())
            cmd.ExecuteNonQuery()
            MessageBox.Show("Added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Delete room (only room ID needed)
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM rooms WHERE room_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Deleted successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Clear everything
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ListBox1.ClearSelected()
        ListBox2.ClearSelected()
    End Sub

    ' Back to dashboard
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim dashboard As New Staff_Dashboard
        dashboard.Show()
    End Sub
End Class
