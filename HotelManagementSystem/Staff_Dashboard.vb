Imports MySql.Data.MySqlClient

Public Class Staff_Dashboard

    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")

    Private Sub Staff_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        Try
            conn.Open()

            ' Total Check-Ins
            Dim cmdCheckIn As New MySqlCommand("SELECT COUNT(checkin_date) FROM bookings WHERE checkin_date IS NOT NULL", conn)
            Label7.Text = cmdCheckIn.ExecuteScalar().ToString()

            ' Total Check-Outs
            Dim cmdCheckOut As New MySqlCommand("SELECT COUNT(checkout_date) FROM bookings WHERE checkout_date IS NOT NULL", conn)
            Label14.Text = cmdCheckOut.ExecuteScalar().ToString()

            ' Total Bookings
            Dim cmdBooking As New MySqlCommand("SELECT COUNT(booking_id) FROM bookings", conn)
            Label16.Text = cmdBooking.ExecuteScalar().ToString()

            ' Total Users
            Dim cmdUsers As New MySqlCommand("SELECT COUNT(users_id) FROM users", conn)
            Label15.Text = cmdUsers.ExecuteScalar().ToString()

            ' Total Payments
            Dim cmdPayments As New MySqlCommand("SELECT COUNT(receipt_id) FROM receipts", conn)
            Label17.Text = cmdPayments.ExecuteScalar().ToString()

            ' Available Rooms
            Dim cmdRooms As New MySqlCommand("SELECT COUNT(room_id) FROM rooms WHERE roomstatus='Available'", conn)
            Label18.Text = cmdRooms.ExecuteScalar().ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    ' Logout
    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Dim loginForm As New StaffLoginForm()
            loginForm.Show()
        End If
    End Sub

    ' Sidebar Navigation
    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        manageroom.Show()
        Me.Hide()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
