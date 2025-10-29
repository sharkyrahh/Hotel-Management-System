Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class change_room
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")
    ' Logout
    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        If MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Hide()
            StaffLoginForm.Show()
        End If
    End Sub

    ' View manage room
    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        manageroom.Show()
        Me.Hide()
    End Sub

    ' Add staff
    Private Sub Button_Manage_Click(sender As Object, e As EventArgs) Handles Button_Manage.Click
        Add_Staff.Show()
        Me.Hide()
    End Sub

    ' About
    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub

    ' Home
    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Staff_Dashboard.Show()
        Me.Hide()
    End Sub

    ' Find user based on IC (Button2)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox_IC.Text.Trim() = "" Then
            MessageBox.Show("Enter IC first")
            Return
        End If

        Try
            conn.Open()
            conn.Open()
                Dim cmd As New MySqlCommand("SELECT users_id FROM users WHERE IC=@ic", conn)
                cmd.Parameters.AddWithValue("@ic", TextBox_IC.Text.Trim())
                Dim userId As Object = cmd.ExecuteScalar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Show available rooms
    Private Sub AvailableRoomID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AvailableRoomID.SelectedIndexChanged
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT room_id FROM rooms WHERE roomstatus='Available'", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            AvailableRoomID.Items.Clear()
            While reader.Read()
                AvailableRoomID.Items.Add(reader("room_id").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Change booking to selected available room
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CurrentBookedRoom.SelectedIndex = -1 Or AvailableRoomID.SelectedIndex = -1 Then
            MessageBox.Show("Select current booked room and available room first")
            Return
        End If

        Try
            conn.Open()

            ' Update booking
            Dim cmd As New MySqlCommand("UPDATE bookings SET room_id=@newRoom WHERE room_id=@oldRoom", conn)
            cmd.Parameters.AddWithValue("@newRoom", AvailableRoomID.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@oldRoom", CurrentBookedRoom.SelectedItem.ToString())
            cmd.ExecuteNonQuery()

            ' Update room statuses
            Dim cmd1 As New MySqlCommand("UPDATE rooms SET roomstatus='Available' WHERE room_id=@oldRoom", conn)
            cmd1.Parameters.AddWithValue("@oldRoom", CurrentBookedRoom.SelectedItem.ToString())
            cmd1.ExecuteNonQuery()

            Dim cmd2 As New MySqlCommand("UPDATE rooms SET roomstatus='Booked' WHERE room_id=@newRoom", conn)
            cmd2.Parameters.AddWithValue("@newRoom", AvailableRoomID.SelectedItem.ToString())
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Room changed successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CurrentBookedRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CurrentBookedRoom.SelectedIndexChanged
        If CurrentBookedRoom.SelectedItem Is Nothing Then Exit Sub
        Try
            conn.Open()
            conn.Open()
                Dim cmd As New MySqlCommand("SELECT r.room_id, r.room_type, r.price, r.roomstatus FROM bookings b JOIN rooms r ON b.room_id=r.room_id WHERE b.users_id=@uid", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                CurrentBookedRoom.Items.Clear()
                While reader.Read()
                    CurrentBookedRoom.Items.Add("Room ID: " & reader("room_id") & " | Type: " & reader("room_type"))
                End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
