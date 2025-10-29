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
        CheckInOut.Show()
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

        includeStandard = CheckBox_Standard.Checked
        includeDeluxe = CheckBox_Deluxe.Checked
        includeSingle = CheckBox_Single.Checked
        includeTwin = CheckBox_Twin.Checked

        Dim roomTypes As New List(Of String)
        If includeStandard Then roomTypes.Add("'Standard'")
        If includeDeluxe Then roomTypes.Add("'Deluxe'")
        If includeSingle Then roomTypes.Add("'Single'")
        If includeTwin Then roomTypes.Add("'Twin'")

        Dim roomTypeCondition As String = ""
        If roomTypes.Count > 0 Then
            roomTypeCondition = "AND room_type IN (" & String.Join(",", roomTypes) & ")"
        End If

        fromDate = $"{fromYear}-{GetMonthNumber(fromMonth)}-{fromDay.PadLeft(2, "0"c)}"
        toDate = $"{toYear}-{GetMonthNumber(toMonth)}-{toDay.PadLeft(2, "0"c)}"

        If Date.Parse(fromDate) > Date.Parse(toDate) Then
            MessageBox.Show("Please enter a proper date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Date.Parse(fromDate) < Date.Today Then
            MessageBox.Show("Date cannot be in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ListBoxAvailable.Items.Clear()

        Try
            Dim sql As String = "SELECT room_id, room_type, price FROM rooms " &
               "WHERE room_id NOT IN (" &
               "    SELECT room_id FROM bookings " &
               "    WHERE (checkin_date <= @ToDate AND checkout_date >= @FromDate)" &
               ") " & roomTypeCondition & " AND roomstatus = 'Available'"

            conn.Open()
            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@FromDate", fromDate)
            command.Parameters.AddWithValue("@ToDate", toDate)

            Dim READER As MySqlDataReader = command.ExecuteReader()

            ListBoxAvailable.Items.Clear()

            While READER.Read()
                Dim roomInfo As String = $"Room {READER("room_id")} - {READER("room_type")} - ${READER("price")}"
                ListBoxAvailable.Items.Add(roomInfo)
            End While

            READER.Close()
            conn.Close()

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
        If ListBoxAvailable.SelectedIndex <> -1 Then
            Dim selectedItem As String = ListBoxAvailable.SelectedItem.ToString()

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
        If ListBoxSelected.Items.Count = 0 Then
            MessageBox.Show("Please select at least one room before proceeding.", "No Rooms Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"
            conn.Open()

            Dim nights As Integer = (Date.Parse(toDate) - Date.Parse(fromDate)).Days
            nights = If(nights > 0, nights, 1)

            Dim guestName As String = "Guest"
            Dim newUserId As Integer = CreateGuestUser(guestName)

            If newUserId = 0 Then
                MessageBox.Show("Failed to create guest user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
                Return
            End If


            For Each roomItem As String In ListBoxSelected.Items
                Dim roomId As Integer = ExtractRoomId(roomItem)

                If roomId > 0 Then
                    Dim sql As String = "INSERT INTO bookings (room_id, users_id, from_date, tot_date, roomstatus) " &
                               "VALUES (@room_id, @user_id, @from, @to, 'Processing')"

                    command = New MySqlCommand(sql, conn)
                    command.Parameters.AddWithValue("@room_id", roomId)
                    command.Parameters.AddWithValue("@user_id", newUserId)
                    command.Parameters.AddWithValue("@from", fromDate)
                    command.Parameters.AddWithValue("@to", toDate)

                    command.ExecuteNonQuery()
                End If
            Next

            conn.Close()

            MessageBox.Show($"Successfully booked {ListBoxSelected.Items.Count} room(s) for {guestName} (User ID: {newUserId})!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Function GetMonthNumber(monthName As String) As String
        Select Case monthName.ToLower()
            Case "january" : Return "01"
            Case "february" : Return "02"
            Case "march" : Return "03"
            Case "april" : Return "04"
            Case "may" : Return "05"
            Case "june" : Return "06"
            Case "july" : Return "07"
            Case "august" : Return "08"
            Case "september" : Return "09"
            Case "october" : Return "10"
            Case "november" : Return "11"
            Case "december" : Return "12"
            Case Else : Return "01"
        End Select
    End Function
    Private Function CreateGuestUser(guestName As String) As Integer
        Try
            Dim insertUserSql As String = "INSERT INTO users (name) VALUES (@name); SELECT LAST_INSERT_ID();"

            command = New MySqlCommand(insertUserSql, conn)
            command.Parameters.AddWithValue("@name", guestName)

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

    Private Function ExtractRoomId(roomItem As String) As Integer
        Try
            Dim parts() As String = roomItem.Split(" "c)
            If parts.Length >= 2 AndAlso parts(0).ToLower() = "room" Then
                Return Integer.Parse(parts(1))
            End If
        Catch ex As Exception
        End Try
        Return 0
    End Function
End Class