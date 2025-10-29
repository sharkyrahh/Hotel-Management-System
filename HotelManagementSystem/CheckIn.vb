Imports MySql.Data.MySqlClient

Public Class CheckIn
    Private connString As String = "server=localhost;userid=root;password=;database=hoteldb"

    ' Update room status
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim cmd1 As New MySqlCommand("UPDATE bookings SET roomstatus='Checked In', checkin_date=@cin WHERE users_id=@uid", conn)
                cmd1.Parameters.AddWithValue("@cin", DateTimePicker1.Value.Date)
                cmd1.Parameters.AddWithValue("@uid", LabelUserID.Text)
                cmd1.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("UPDATE rooms r JOIN bookings b ON r.room_id=b.room_id SET r.roomstatus='Booked' WHERE b.users_id=@uid", conn)
                cmd2.Parameters.AddWithValue("@uid", LabelUserID.Text)
                cmd2.ExecuteNonQuery()
            End Using
            MessageBox.Show("Check-in updated successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Clear everything
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.ClearSelected()
        TextBox1.Clear()
        LabelUserID.Text = ""
    End Sub

    ' Show room details for selected user
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem Is Nothing Then Exit Sub
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT r.room_id, r.room_type, r.price, r.roomstatus FROM bookings b JOIN rooms r ON b.room_id=r.room_id WHERE b.users_id=@uid", conn)
                cmd.Parameters.AddWithValue("@uid", LabelUserID.Text)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ListBox1.Items.Clear()
                While reader.Read()
                    ListBox1.Items.Add("Room ID: " & reader("room_id") & " | Type: " & reader("room_type") & " | Price: " & reader("price") & " | Status: " & reader("roomstatus"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        ViewForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Book2_Click(sender As Object, e As EventArgs) Handles Button_Book2.Click
        BookForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Check_Click(sender As Object, e As EventArgs) Handles Button_Check.Click
        CheckInOut.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub

    ' Find user by IC
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Enter IC first")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT users_id FROM users WHERE IC=@ic", conn)
                cmd.Parameters.AddWithValue("@ic", TextBox1.Text.Trim())
                Dim userId As Object = cmd.ExecuteScalar()
                If userId IsNot Nothing Then
                    LabelUserID.Text = userId.ToString()
                Else
                    LabelUserID.Text = "User not found"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Auto load check-in date
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT checkin_date FROM bookings WHERE users_id=@uid", conn)
                cmd.Parameters.AddWithValue("@uid", LabelUserID.Text)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    DateTimePicker1.Value = Convert.ToDateTime(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedItem Is Nothing Then Exit Sub
        Dim choice As String = ListBox2.SelectedItem.ToString()
        If choice = "Unavailable" Or choice = "Reserved" Then
            MessageBox.Show("You selected: " & choice)
        End If
    End Sub


    ' Save after filling details
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE bookings SET roomstatus='Checked In' WHERE users_id=@uid", conn)
                cmd.Parameters.AddWithValue("@uid", LabelUserID.Text)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Details updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
