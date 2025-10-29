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
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Enter user IC first")
            Return
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT users_id FROM users WHERE IC=@ic", conn)
            cmd.Parameters.AddWithValue("@ic", TextBox1.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim userId As Integer = -1
            If reader.Read() Then
                userId = Convert.ToInt32(reader("users_id"))
            Else
                MessageBox.Show("User not found")
            End If
            reader.Close()

            ' Display current booked rooms for user
            If userId <> -1 Then
                Dim cmdRooms As New MySqlCommand("SELECT room_id FROM bookings WHERE users_id=@uid AND roomstatus='Booked'", conn)
                cmdRooms.Parameters.AddWithValue("@uid", userId)
                Dim roomReader As MySqlDataReader = cmdRooms.ExecuteReader()
                CurrentBookedRoom.Items.Clear()
                While roomReader.Read()
                    CurrentBookedRoom.Items.Add(roomReader("room_id").ToString())
                End While
                roomReader.Close()

                If CurrentBookedRoom.Items.Count = 0 Then
                    CurrentBookedRoom.Items.Add("No bookings made")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
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
End Class
