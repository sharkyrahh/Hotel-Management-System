Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form2

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



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoomTypes()
    End Sub

    Private Sub LoadRoomTypes()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DISTINCT room_type FROM rooms", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()

            While reader.Read()
                ComboBox1.Items.Add(reader("room_type").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading room types: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        If String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(ComboBox1.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO rooms (room_id, room_type, room_rules, price, num_beds, roomstatus) 
                                   VALUES (@room_id, @room_type, @room_rules, @price, @num_beds, @roomstatus)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@room_id", TextBox2.Text)
            cmd.Parameters.AddWithValue("@room_type", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@room_rules", TextBox5.Text)
            cmd.Parameters.AddWithValue("@price", TextBox4.Text)
            cmd.Parameters.AddWithValue("@num_beds", TextBox3.Text)
            cmd.Parameters.AddWithValue("@roomstatus", "Available")

            cmd.ExecuteNonQuery()
            MessageBox.Show("✅ Room added successfully.")
            ClearAddFields()
        Catch ex As Exception
            MessageBox.Show("Error adding room: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ClearAddFields()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox4.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
    End Sub



    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If String.IsNullOrWhiteSpace(TextBox7.Text) Then
            MessageBox.Show("Please enter the Room ID to delete.")
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Return

        Try
            conn.Open()
            Dim query As String = "DELETE FROM rooms WHERE room_id = @room_id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@room_id", TextBox7.Text)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("🗑️ Room deleted successfully.")
            Else
                MessageBox.Show("Room ID not found.")
            End If

            TextBox7.Clear()
            ComboBox3.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error deleting room: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        ClearAddFields()
        TextBox7.Clear()
        ComboBox3.SelectedIndex = -1
    End Sub


    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        Staff_Dashboard.Show()
        Me.Hide()
    End Sub

End Class
