Imports MySql.Data.MySqlClient

Public Class PaymentForm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPreviousBookings()
    End Sub

    Private Sub LoadPreviousBookings()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"
            conn.Open()

            ' Query to get room types from previous bookings for the current user
            ' Assuming you have a way to identify the current user (e.g., user ID 4 as guest)
            Dim sql As String = "SELECT DISTINCT r.room_type " &
                               "FROM bookings b " &
                               "INNER JOIN rooms r ON b.room_id = r.room_id " &
                               "WHERE b.users_id = 4 " &  ' Using guest user ID 4
                               "ORDER BY r.room_type"

            command = New MySqlCommand(sql, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Hide all panels first
            Panelstandard.Visible = False
            Paneldeluxe.Visible = False
            Panelsingle.Visible = False
            Paneltwin.Visible = False

            ' Show panels based on previous room types
            While reader.Read()
                Dim roomType As String = reader("room_type").ToString().ToLower()

                Select Case roomType
                    Case "standard"
                        Panelstandard.Visible = True
                    Case "deluxe"
                        Paneldeluxe.Visible = True
                    Case "single"
                        Panelsingle.Visible = True
                    Case "twin"
                        Paneltwin.Visible = True
                End Select
            End While

            reader.Close()
            conn.Close()

            ' If no previous bookings found, show all panels or a default message
            If Not (Panelstandard.Visible OrElse Paneldeluxe.Visible OrElse Panelsingle.Visible OrElse Paneltwin.Visible) Then
                ' Option 1: Show all panels if no previous bookings
                Panelstandard.Visible = True
                Paneldeluxe.Visible = True
                Panelsingle.Visible = True
                Paneltwin.Visible = True

                ' Option 2: Show a message
                ' MessageBox.Show("No previous bookings found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading previous bookings: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Show all panels as fallback
            Panelstandard.Visible = True
            Paneldeluxe.Visible = True
            Panelsingle.Visible = True
            Paneltwin.Visible = True
        End Try
    End Sub

    ' Method to update panels based on specific room types
    Public Sub UpdateRoomTypePanels(roomTypes As List(Of String))
        ' Hide all panels first
        Panelstandard.Visible = False
        Paneldeluxe.Visible = False
        Panelsingle.Visible = False
        Paneltwin.Visible = False

        ' Show panels based on the provided room types
        For Each roomType As String In roomTypes
            Select Case roomType.ToLower()
                Case "standard"
                    Panelstandard.Visible = True
                Case "deluxe"
                    Paneldeluxe.Visible = True
                Case "single"
                    Panelsingle.Visible = True
                Case "twin"
                    Paneltwin.Visible = True
            End Select
        Next

        ' If no specific types provided, show all
        If roomTypes.Count = 0 Then
            Panelstandard.Visible = True
            Paneldeluxe.Visible = True
            Panelsingle.Visible = True
            Paneltwin.Visible = True
        End If
    End Sub

    ' Method to get current booking room types (if you want to show current selection)
    Public Sub LoadCurrentBookingRoomTypes()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"
            conn.Open()

            ' Get room types from the most recent booking for the guest user
            Dim sql As String = "SELECT DISTINCT r.room_type " &
                               "FROM bookings b " &
                               "INNER JOIN rooms r ON b.room_id = r.room_id " &
                               "WHERE b.users_id = 4 " &
                               "AND b.booking_id = (SELECT MAX(booking_id) FROM bookings WHERE users_id = 4) " &
                               "ORDER BY r.room_type"

            command = New MySqlCommand(sql, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            Dim currentRoomTypes As New List(Of String)

            While reader.Read()
                currentRoomTypes.Add(reader("room_type").ToString())
            End While

            reader.Close()
            conn.Close()

            ' Update panels with current booking room types
            UpdateRoomTypePanels(currentRoomTypes)

        Catch ex As Exception
            MessageBox.Show("Error loading current booking: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_Receipt_Click(sender As Object, e As EventArgs) Handles Button_Receipt.Click
        ReceiptForm.Show()
    End Sub

    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        ViewForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Check_Click(sender As Object, e As EventArgs) Handles Button_Check.Click
        CheckIn.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        BookForm.Show()
        Me.Hide()
    End Sub
End Class