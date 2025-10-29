Imports System.Security.AccessControl
Imports MySql.Data.MySqlClient

Public Class CheckOut
    Private connString As String = "server=localhost;userid=root;password=;database=hoteldb"

    ' Sidebar navigation
    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Dim f As New Form1
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        Dim f As New ViewForm
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Book2_Click(sender As Object, e As EventArgs) Handles Button_Book2.Click
        Dim f As New BookForm
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Check_Click(sender As Object, e As EventArgs) Handles Button_Check.Click
        CheckInOut.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        Dim about As New AboutBox1
        about.ShowDialog()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim f As New StaffLoginForm
        f.Show()
        Me.Hide()
    End Sub

    ' Search booking by booking_id
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
                    Label12.Text = userId.ToString()
                Else
                    Label12.Text = "User not found"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' Update checkout date
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT checkout_date FROM bookings WHERE users_id=@uid", conn)
                cmd.Parameters.AddWithValue("@uid", Label12.Text)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    DateTimePicker2.Value = Convert.ToDateTime(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Display room type for selected room_id
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem Is Nothing Then Exit Sub
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT r.room_id, r.room_type, r.price, r.roomstatus FROM bookings b JOIN rooms r ON b.room_id=r.room_id WHERE b.users_id=@uid", conn)
                cmd.Parameters.AddWithValue("@uid", Label12.Text)
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

    ' Update room status
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedItem Is Nothing Then Exit Sub
        Dim choice As String = ListBox2.SelectedItem.ToString()
        If choice = "Available" Then
            MessageBox.Show("You selected: " & choice)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE bookings SET roomstatus='Checked In' WHERE users_id=@uid", conn)
                cmd.Parameters.AddWithValue("@uid", Label12.Text)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Details updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.ClearSelected()
        TextBox1.Clear()
        Label12.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd1 As New MySqlCommand("UPDATE bookings SET roomstatus='Checked Out', checkout_date=@cout WHERE users_id=@uid", conn)
                cmd1.Parameters.AddWithValue("@cout", DateTimePicker2.Value.Date)
                cmd1.Parameters.AddWithValue("@uid", Label12.Text)
                cmd1.ExecuteNonQuery()
                Dim cmd2 As New MySqlCommand("UPDATE rooms r JOIN bookings b ON r.room_id=b.room_id SET r.roomstatus='Available' WHERE b.users_id=@uid", conn)
                cmd2.Parameters.AddWithValue("@uid", Label12.Text)
                cmd2.ExecuteNonQuery()
            End Using
            MessageBox.Show("Check-out updated successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
