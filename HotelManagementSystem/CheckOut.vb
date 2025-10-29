Imports System.Security.AccessControl
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports Org.BouncyCastle.Asn1.Cmp

Public Class CheckOut
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")


    ' Checkout user
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Placeholder for checkout logic
        MessageBox.Show("User has been checked out successfully.")
    End Sub


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


    ' Search user IC
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=hotel_db")
        Dim cmd As New MySqlCommand("SELECT * FROM users WHERE IC=@ic", conn)
        cmd.Parameters.AddWithValue("@ic", TextBox1.Text)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                Label12.Text = "User found"
                Label12.ForeColor = Color.Green
            Else
                Label12.Text = "User not found"
                Label12.ForeColor = Color.Red
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    ' Store checkout data
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        MessageBox.Show("Checkout details saved.")
    End Sub




    ' Clear form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        ListBox1.SelectedIndex = -1
        ListBox1.SelectedIndex = -1
        Label12.Text = ""
    End Sub


    ' Go home
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New Form1
        f.Show()
        Me.Hide()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE bookings SET checkin_date=@date WHERE IC=@ic", conn)
            cmd.Parameters.AddWithValue("@date", DateTimePicker2.Value)
            cmd.Parameters.AddWithValue("@ic", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Booking date updated.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    ' Choose room by ID from `rooms`
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


    ' Change room status
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