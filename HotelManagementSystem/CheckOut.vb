Imports System.Security.AccessControl
Imports MySql.Data.MySqlClient

Public Class CheckOut
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")

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
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM bookings WHERE booking_id=@bookingId", conn)
            cmd.Parameters.AddWithValue("@bookingId", TextBox1.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                Label12.Text = "Booking found"
                Label12.ForeColor = Color.Green
            Else
                Label12.Text = "Booking not found"
                Label12.ForeColor = Color.Red
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Update checkout date
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE bookings SET checkout_date=@date WHERE booking_id=@bookingId", conn)
            cmd.Parameters.AddWithValue("@date", DateTimePicker2.Value)
            cmd.Parameters.AddWithValue("@bookingId", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Checkout date updated.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Display room type for selected room_id
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT room_type FROM rooms WHERE room_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", ListBox1.SelectedItem.ToString())
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Label12.Text = "Room Type: " & reader("room_type").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Update room status
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE rooms SET roomstatus=@status WHERE room_id=@id", conn)
            cmd.Parameters.AddWithValue("@status", ListBox2.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@id", ListBox1.SelectedItem.ToString())
            cmd.ExecuteNonQuery()
            MessageBox.Show("Room status updated.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
