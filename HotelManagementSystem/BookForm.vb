Imports MySql.Data.MySqlClient
Public Class BookForm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Dim fromDate As String
    Dim toDate As String
    Dim includeStandard As Boolean
    Dim includeDeluxe As Boolean
    Dim includeSingle As Boolean
    Dim includeTwin As Boolean
    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        ViewForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_CheckIn_Click(sender As Object, e As EventArgs) Handles Button_CheckIn.Click
        CheckIn.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button_Find_Click(sender As Object, e As EventArgs) Handles Button_Find.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"

        Dim fromDay As String = ComboBoxDayFrom.Text
        Dim toDay As String = ComboBoxDayTo.Text
        Dim fromMonth As String = ComboBoxMonthFrom.Text
        Dim toMonth As String = ComboBoxMonthTo.Text
        Dim fromYear As String = ComboBoxYearFrom.Text
        Dim toYear As String = ComboBoxYearTo.Text

        ' Reset room type flags
        includeStandard = CheckBox_Standard.Checked
        includeDeluxe = CheckBox_Deluxe.Checked
        includeSingle = CheckBox_Single.Checked
        includeTwin = CheckBox_Twin.Checked

        ' Build room type conditions
        Dim roomTypes As New List(Of String)
        If includeStandard Then roomTypes.Add("'Standard'")
        If includeDeluxe Then roomTypes.Add("'Deluxe'")
        If includeSingle Then roomTypes.Add("'Single'")
        If includeTwin Then roomTypes.Add("'Twin'")

        Dim roomTypeCondition As String = ""
        If roomTypes.Count > 0 Then
            roomTypeCondition = "AND room_type IN (" & String.Join(",", roomTypes) & ")"
        End If

        ' Build date strings (assuming you want to format them as YYYY-MM-DD)
        fromDate = $"{fromYear}-{fromMonth.PadLeft(2, "0"c)}-{fromDay.PadLeft(2, "0"c)}"
        toDate = $"{toYear}-{toMonth.PadLeft(2, "0"c)}-{toDay.PadLeft(2, "0"c)}"

        ListBoxAvailable.Items.Clear()

        Try
            ' SQL query to find available rooms
            Dim sql As String = "SELECT room_id, room_type, price FROM rooms " &
                           "WHERE room_id NOT IN (" &
                           "    SELECT room_id FROM bookings " &
                           "    WHERE (checkin_date <= @ToDate AND checkout_date >= @FromDate)" &
                           ") " & roomTypeCondition

            conn.Open()
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@FromDate", fromDate)
            command.Parameters.AddWithValue("@ToDate", toDate)

            Dim READER As MySqlDataReader = command.ExecuteReader()

            ' Clear ListBox before adding new items
            ListBoxAvailable.Items.Clear()

            ' Read data and add to ListBox
            While READER.Read()
                ' Format the display string as you prefer
                Dim roomInfo As String = $"Room {READER("room_id")} - {READER("room_type")} - ${READER("price")}"
                ListBoxAvailable.Items.Add(roomInfo)
            End While

            READER.Close()
            conn.Close()

            ' Show success message
            If ListBoxAvailable.Items.Count > 0 Then
                MessageBox.Show($"Found {ListBoxAvailable.Items.Count} available rooms!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No available rooms found for the selected criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub

    Private Sub Button_Select_Click(sender As Object, e As EventArgs) Handles Button_Select.Click
        ' Take from listboxavailable and put in listboxselected
        If ListBoxAvailable.SelectedIndex <> -1 Then
            Dim selectedItem As String = ListBoxAvailable.SelectedItem.ToString()

            ' Check if item already exists in ListBoxSelected to avoid duplicates
            If Not ListBoxSelected.Items.Contains(selectedItem) Then
                ListBoxSelected.Items.Add(selectedItem)
            Else
                MessageBox.Show("This room is already selected.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select a room from available rooms first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        ' Clear listboxselected
        If ListBoxSelected.Items.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all selected rooms?", "Clear Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ListBoxSelected.Items.Clear()
            End If
        Else
            MessageBox.Show("No rooms to clear.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button_Proceed_Click(sender As Object, e As EventArgs) Handles Button_Proceed.Click
        ' Send to booking table
        If ListBoxSelected.Items.Count = 0 Then
            MessageBox.Show("Please select at least one room before proceeding.", "No Rooms Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"
            conn.Open()

            ' Get dates from your form controls
            Dim fromDay As String = ComboBoxDayFrom.Text
            Dim fromMonth As String = ComboBoxMonthFrom.Text
            Dim fromYear As String = ComboBoxYearFrom.Text
            Dim checkinDate As String = $"{fromYear}-{fromMonth.PadLeft(2, "0"c)}-{fromDay.PadLeft(2, "0"c)}"

            Dim toDay As String = ComboBoxDayTo.Text
            Dim toMonth As String = ComboBoxMonthTo.Text
            Dim toYear As String = ComboBoxYearTo.Text
            Dim checkoutDate As String = $"{toYear}-{toMonth.PadLeft(2, "0"c)}-{toDay.PadLeft(2, "0"c)}"

            ' Step 1: Create a new guest user
            Dim guestName As String = "Guest" ' You can modify this or get from input
            Dim newUserId As Integer = CreateGuestUser(guestName)

            If newUserId = 0 Then
                MessageBox.Show("Failed to create guest user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
                Return
            End If

            ' Step 2: Insert each selected room into bookings table using the new user ID
            For Each roomItem As String In ListBoxSelected.Items
                ' Extract room ID from the string (assuming format: "Room XXX - Type - $Price")
                Dim roomId As Integer = ExtractRoomId(roomItem)

                If roomId > 0 Then
                    Dim sql As String = "INSERT INTO bookings (room_id, users_id, checkin_date, checkout_date, roomstatus) " &
                               "VALUES (@room_id, @user_id, @checkin, @checkout, 'Confirmed')"

                    command = New MySqlCommand(sql, conn)
                    command.Parameters.AddWithValue("@room_id", roomId)
                    command.Parameters.AddWithValue("@user_id", newUserId)
                    command.Parameters.AddWithValue("@checkin", checkinDate)
                    command.Parameters.AddWithValue("@checkout", checkoutDate)

                    command.ExecuteNonQuery()
                End If
            Next

            conn.Close()

            MessageBox.Show($"Successfully booked {ListBoxSelected.Items.Count} room(s) for {guestName} (User ID: {newUserId})!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear selections after successful booking
            ListBoxSelected.Items.Clear()
            PaymentForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error creating booking: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Function to create a new guest user and return the user ID
    Private Function CreateGuestUser(guestName As String) As Integer
        Try
            ' First, insert the new guest user
            Dim insertUserSql As String = "INSERT INTO users (name) VALUES (@name); SELECT LAST_INSERT_ID();"

            command = New MySqlCommand(insertUserSql, conn)
            command.Parameters.AddWithValue("@name", guestName)

            ' Execute and get the new user ID
            Dim newUserId As Object = command.ExecuteScalar()

            If newUserId IsNot Nothing AndAlso IsNumeric(newUserId) Then
                Return Convert.ToInt32(newUserId)
            Else
                Return 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error creating guest user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    ' Alternative function if you want to use a fixed user ID (like 4)
    Private Function GetOrCreateGuestUser() As Integer
        Try
            ' First, try to get user ID 4
            Dim checkUserSql As String = "SELECT users_id FROM users WHERE users_id = 4"
            command = New MySqlCommand(checkUserSql, conn)
            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing Then
                ' User ID 4 exists, use it
                Return 4
            Else
                ' User ID 4 doesn't exist, create a new guest user with ID 4
                Dim insertUserSql As String = "INSERT INTO users (users_id, username, password, role, name) VALUES (4, 'guest', 'guest123', 'guest', 'Guest')"
                command = New MySqlCommand(insertUserSql, conn)
                command.ExecuteNonQuery()
                Return 4
            End If

        Catch ex As Exception
            MessageBox.Show("Error accessing user database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    ' Helper function to extract room ID from the display string
    Private Function ExtractRoomId(roomItem As String) As Integer
        Try
            ' Assuming format: "Room 101 - Standard - $100"
            Dim parts() As String = roomItem.Split(" "c)
            If parts.Length >= 2 AndAlso parts(0).ToLower() = "room" Then
                Return Integer.Parse(parts(1))
            End If
        Catch ex As Exception
            ' Handle parsing error
        End Try
        Return 0
    End Function
End Class