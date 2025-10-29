Imports MySql.Data.MySqlClient

Public Class change_room
    Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")
    Dim selectedUserId As Integer = -1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CurrentBookedRoom.Items.Clear()
        AvailableRoomID.Items.Clear()
        selectedUserId = -1

        Dim ic As String = TextBox_IC.Text.Trim()
        If ic = "" Then
            MessageBox.Show("Please enter IC number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            con.Open()

            ' 1️⃣ Find user_id based on IC
            Dim getUserQuery As String = "SELECT users_id FROM users WHERE IC = @ic;"
            Dim cmdUser As New MySqlCommand(getUserQuery, con)
            cmdUser.Parameters.AddWithValue("@ic", ic)
            Dim userResult = cmdUser.ExecuteScalar()

            If userResult Is Nothing Then
                MessageBox.Show("User not found. Please check the IC number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                Return
            End If

            selectedUserId = Convert.ToInt32(userResult)

            ' 2️⃣ Display current booked room(s)
            Dim bookedQuery As String = "
                SELECT r.room_id 
                FROM bookings b 
                INNER JOIN rooms r ON b.room_id = r.room_id
                WHERE b.users_id = @uid;"
            Dim cmdBooked As New MySqlCommand(bookedQuery, con)
            cmdBooked.Parameters.AddWithValue("@uid", selectedUserId)
            Dim reader1 As MySqlDataReader = cmdBooked.ExecuteReader()

            While reader1.Read()
                CurrentBookedRoom.Items.Add(reader1("room_id").ToString())
            End While
            reader1.Close()

            ' 3️⃣ Display available rooms
            Dim availQuery As String = "SELECT room_id FROM rooms WHERE roomstatus = 'Available';"
            Dim cmdAvail As New MySqlCommand(availQuery, con)
            Dim reader2 As MySqlDataReader = cmdAvail.ExecuteReader()

            While reader2.Read()
                AvailableRoomID.Items.Add(reader2("room_id").ToString())
            End While
            reader2.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' ===== PROCEED BUTTON =====
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If selectedUserId = -1 Then
            MessageBox.Show("Please find a user first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If CurrentBookedRoom.SelectedItem Is Nothing Or AvailableRoomID.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a current booked room and a new available room.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim oldRoomId As Integer = Convert.ToInt32(CurrentBookedRoom.SelectedItem)
        Dim newRoomId As Integer = Convert.ToInt32(AvailableRoomID.SelectedItem)

        Try
            con.Open()

            ' 1️⃣ Get existing booking details for the selected old room
            Dim getBookingQuery As String = "SELECT * FROM bookings WHERE users_id=@uid AND room_id=@old;"
            Dim cmdGetBooking As New MySqlCommand(getBookingQuery, con)
            cmdGetBooking.Parameters.AddWithValue("@uid", selectedUserId)
            cmdGetBooking.Parameters.AddWithValue("@old", oldRoomId)
            Dim reader As MySqlDataReader = cmdGetBooking.ExecuteReader()

            Dim fromDate As Date = Date.Now
            Dim toDate As Date = Date.Now
            Dim checkinDate As Date = Date.Now
            Dim checkoutDate As Date = Date.Now
            Dim roomStatus As String = "Booked"

            If reader.Read() Then
                If Not IsDBNull(reader("from_date")) Then fromDate = reader("from_date")
                If Not IsDBNull(reader("to_date")) Then toDate = reader("to_date")
                If Not IsDBNull(reader("checkin_date")) Then checkinDate = reader("checkin_date")
                If Not IsDBNull(reader("checkout_date")) Then checkoutDate = reader("checkout_date")
            End If
            reader.Close()

            ' 2️⃣ Delete old booking
            Dim deleteQuery As String = "DELETE FROM bookings WHERE users_id=@uid AND room_id=@old;"
            Dim cmdDelete As New MySqlCommand(deleteQuery, con)
            cmdDelete.Parameters.AddWithValue("@uid", selectedUserId)
            cmdDelete.Parameters.AddWithValue("@old", oldRoomId)
            cmdDelete.ExecuteNonQuery()

            ' 3️⃣ Change old room to Available
            Dim updateOldRoom As String = "UPDATE rooms SET roomstatus='Available' WHERE room_id=@old;"
            Dim cmdUpdateOld As New MySqlCommand(updateOldRoom, con)
            cmdUpdateOld.Parameters.AddWithValue("@old", oldRoomId)
            cmdUpdateOld.ExecuteNonQuery()

            ' 4️⃣ Insert new booking (with same details)
            Dim insertQuery As String = "
                INSERT INTO bookings (room_id, users_id, checkin_date, checkout_date, roomstatus, from_date, to_date)
                VALUES (@newRoom, @uid, @checkin, @checkout, 'Booked', @from, @to);"
            Dim cmdInsert As New MySqlCommand(insertQuery, con)
            cmdInsert.Parameters.AddWithValue("@newRoom", newRoomId)
            cmdInsert.Parameters.AddWithValue("@uid", selectedUserId)
            cmdInsert.Parameters.AddWithValue("@checkin", checkinDate)
            cmdInsert.Parameters.AddWithValue("@checkout", checkoutDate)
            cmdInsert.Parameters.AddWithValue("@from", fromDate)
            cmdInsert.Parameters.AddWithValue("@to", toDate)
            cmdInsert.ExecuteNonQuery()

            ' 5️⃣ Update new room status to Booked
            Dim updateNewRoom As String = "UPDATE rooms SET roomstatus='Booked' WHERE room_id=@new;"
            Dim cmdUpdateNew As New MySqlCommand(updateNewRoom, con)
            cmdUpdateNew.Parameters.AddWithValue("@new", newRoomId)
            cmdUpdateNew.ExecuteNonQuery()

            MessageBox.Show("Room successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class

