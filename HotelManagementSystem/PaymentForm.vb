Imports MySql.Data.MySqlClient

Public Class PaymentForm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrentBookingRoomTypes()
    End Sub

    Public Sub LoadCurrentBookingRoomTypes()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"
            conn.Open()

            Dim userSql As String = "SELECT users_id FROM bookings ORDER BY booking_id DESC LIMIT 1"
            command = New MySqlCommand(userSql, conn)
            Dim userIdObj As Object = command.ExecuteScalar()
            Dim userId As Integer = If(userIdObj IsNot Nothing AndAlso IsNumeric(userIdObj), Convert.ToInt32(userIdObj), 0)

            Dim sql As String = "SELECT r.room_type, COUNT(*) as qty " &
               "FROM bookings b " &
               "INNER JOIN rooms r ON b.room_id = r.room_id " &
               "WHERE b.users_id = @user_id " &
               "AND b.booking_id >= (SELECT MAX(booking_id) FROM bookings) - 10 " &
               "GROUP BY r.room_type " &
               "ORDER BY r.room_type"

            command = New MySqlCommand(sql, conn)
            command.Parameters.AddWithValue("@user_id", userId)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False

            Dim panelIndex As Integer = 1

            While reader.Read()
                Dim roomType As String = reader("room_type").ToString()
                Dim quantity As Integer = Convert.ToInt32(reader("qty"))
                Dim price As Integer = 0
                Dim totalPrice As Integer = 0


                Select Case roomType.ToLower()
                    Case "standard"
                        price = 200
                    Case "deluxe"
                        price = 250
                    Case "single"
                        price = 100
                    Case "twin"
                        price = 150
                End Select

                totalPrice = price * quantity


                UpdatePanel(panelIndex, roomType, price, quantity, totalPrice)
                panelIndex += 1
            End While

            reader.Close()

            Dim subtotal As Integer = 0
            Dim nights As Integer = 0

            For i As Integer = 1 To 4
                subtotal += GetPanelTotal(i)
            Next

            Dim nightsSql As String = "SELECT DATEDIFF(checkout_date, checkin_date) as nights FROM bookings WHERE booking_id = (SELECT MAX(booking_id) FROM bookings)"
            command = New MySqlCommand(nightsSql, conn)
            Dim nightsResult As Object = command.ExecuteScalar()
            nights = If(nightsResult IsNot Nothing AndAlso IsNumeric(nightsResult), Convert.ToInt32(nightsResult), 1)

            Dim total As Integer = subtotal * nights

            Label_subtotal.Text = $"RM{subtotal}"
            Label_numberofnights.Text = nights.ToString()
            Label_total.Text = $"RM{total}"

            Panelsubtotal.Visible = True
            Panelnumber.Visible = True
            Paneltotal.Visible = True

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading current booking: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdatePanel(panelNumber As Integer, roomType As String, price As Integer, quantity As Integer, total As Integer)
        Select Case panelNumber
            Case 1
                Panel1.Visible = True
                LabelItem1.Text = roomType & " Room"
                LabelPrice1.Text = $"RM{price}"
                LabelQty1.Text = quantity.ToString()
                LabelTotal1.Text = $"RM{total}"
            Case 2
                Panel2.Visible = True
                LabelItem2.Text = roomType & " Room"
                LabelPrice2.Text = $"RM{price}"
                LabelQty2.Text = quantity.ToString()
                LabelTotal2.Text = $"RM{total}"
            Case 3
                Panel3.Visible = True
                LabelItem3.Text = roomType & " Room"
                LabelPrice3.Text = $"RM{price}"
                LabelQty3.Text = quantity.ToString()
                LabelTotal3.Text = $"RM{total}"
            Case 4
                Panel4.Visible = True
                LabelItem4.Text = roomType & " Room"
                LabelPrice4.Text = $"RM{price}"
                LabelQty4.Text = quantity.ToString()
                LabelTotal4.Text = $"RM{total}"
        End Select
    End Sub

    Private Function GetPanelTotal(panelNumber As Integer) As Integer
        Select Case panelNumber
            Case 1
                Return If(Panel1.Visible, Integer.Parse(LabelTotal1.Text.Replace("RM", "")), 0)
            Case 2
                Return If(Panel2.Visible, Integer.Parse(LabelTotal2.Text.Replace("RM", "")), 0)
            Case 3
                Return If(Panel3.Visible, Integer.Parse(LabelTotal3.Text.Replace("RM", "")), 0)
            Case 4
                Return If(Panel4.Visible, Integer.Parse(LabelTotal4.Text.Replace("RM", "")), 0)
            Case Else
                Return 0
        End Select
    End Function

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
        CheckInOut.Show()
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

    Private Sub Button_Confirm_Click(sender As Object, e As EventArgs) Handles Button_Confirm.Click
        If String.IsNullOrWhiteSpace(TextBoxName.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxIc.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxPhone.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxEmail.Text) Then
            MessageBox.Show("Please fill in all details.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If TextBoxIc.Text.Length <> 12 OrElse Not TextBoxIc.Text.All(AddressOf Char.IsDigit) Then
            MessageBox.Show("Please enter a valid IC number.", "Invalid IC", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxIc.Focus()
            Return
        End If

        If (TextBoxPhone.Text.Length <> 10 AndAlso TextBoxPhone.Text.Length <> 11) OrElse Not TextBoxPhone.Text.All(AddressOf Char.IsDigit) Then
            MessageBox.Show("Please enter a valid phone number.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxPhone.Focus()
            Return
        End If

        If Not TextBoxEmail.Text.Contains("@") OrElse Not TextBoxEmail.Text.Contains(".com") Then
            MessageBox.Show("Email must contain '@' and '.com'", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxEmail.Focus()
            Return
        End If

        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"
            conn.Open()

            Dim updateSql As String = "UPDATE users SET name = @name, email = @email, IC = @ic, phone = @phone WHERE users_id = (SELECT users_id FROM bookings ORDER BY booking_id DESC LIMIT 1)"

            command = New MySqlCommand(updateSql, conn)
            command.Parameters.AddWithValue("@name", TextBoxName.Text)
            command.Parameters.AddWithValue("@email", TextBoxEmail.Text)
            command.Parameters.AddWithValue("@ic", TextBoxIc.Text)
            command.Parameters.AddWithValue("@phone", TextBoxPhone.Text)

            command.ExecuteNonQuery()
            conn.Close()

            GroupBoxPayment.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error updating customer details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ButtonPay_Click(sender As Object, e As EventArgs) Handles ButtonPay.Click
        If String.IsNullOrWhiteSpace(TextBoxPay.Text) Then
            MessageBox.Show("Please enter payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim paymentAmount As Decimal
        If Not Decimal.TryParse(TextBoxPay.Text, paymentAmount) Then
            MessageBox.Show("Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim totalAmount As Decimal = Decimal.Parse(Label_total.Text.Replace("RM", ""))

        If paymentAmount < totalAmount Then
            MessageBox.Show("Please enter sufficient amount.", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show($"Payment successful! Amount paid: RM{paymentAmount}", "Payment Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Paneltotalpaid.Visible = True
        Panelbalance.Visible = True
        Button_Receipt.Visible = True
        Label_totalpaid.Text = $"RM{paymentAmount}"

        If paymentAmount > totalAmount Then
            Dim change As Decimal = paymentAmount - totalAmount
            Label_balance.Text = $"RM{change}"
        Else
            Label_balance.Text = "RM0"
        End If

        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"
            conn.Open()

            Dim userSql As String = "SELECT users_id FROM bookings ORDER BY booking_id DESC LIMIT 1"
            command = New MySqlCommand(userSql, conn)
            Dim userIdObj As Object = command.ExecuteScalar()
            Dim userId As Integer = If(userIdObj IsNot Nothing AndAlso IsNumeric(userIdObj), Convert.ToInt32(userIdObj), 0)

            Dim standardQty As Integer = 0
            Dim deluxeQty As Integer = 0
            Dim singleQty As Integer = 0
            Dim twinQty As Integer = 0

            Dim roomSql As String = "SELECT r.room_type, COUNT(*) as qty " &
   "FROM bookings b " &
   "INNER JOIN rooms r ON b.room_id = r.room_id " &
   "WHERE b.users_id = @user_id " &
   "AND b.booking_id >= (SELECT MAX(booking_id) FROM bookings) - 10 " &
   "GROUP BY r.room_type"

            Dim roomCommand As New MySqlCommand(roomSql, conn)
            roomCommand.Parameters.AddWithValue("@user_id", userId)
            Dim roomReader As MySqlDataReader = roomCommand.ExecuteReader()

            While roomReader.Read()
                Dim roomType As String = roomReader("room_type").ToString().ToLower()
                Dim quantity As Integer = Convert.ToInt32(roomReader("qty"))

                Select Case roomType
                    Case "standard" : standardQty = quantity
                    Case "deluxe" : deluxeQty = quantity
                    Case "single" : singleQty = quantity
                    Case "twin" : twinQty = quantity
                End Select
            End While

            roomReader.Close()

            Dim subtotal As Decimal = Decimal.Parse(Label_subtotal.Text.Replace("RM", ""))
            Dim nights As Integer = Integer.Parse(Label_numberofnights.Text)
            Dim total As Decimal = Decimal.Parse(Label_total.Text.Replace("RM", ""))
            Dim paid As Decimal = paymentAmount
            Dim balance As Decimal = 0
            If Label_balance.Text.Replace("RM", "") <> "0" Then
                Decimal.TryParse(Label_balance.Text.Replace("RM", ""), balance)
            End If

            Dim insertSql As String = "INSERT INTO receipts (users_id, standardQty, deluxeQty, singleQty, twinQty, subtotal, nights, total, paid, balance) " &
                         "VALUES (@users_id, @standardQty, @deluxeQty, @singleQty, @twinQty, @subtotal, @nights, @total, @paid, @balance)"

            command = New MySqlCommand(insertSql, conn)
            command.Parameters.AddWithValue("@users_id", userId)
            command.Parameters.AddWithValue("@standardQty", standardQty)
            command.Parameters.AddWithValue("@deluxeQty", deluxeQty)
            command.Parameters.AddWithValue("@singleQty", singleQty)
            command.Parameters.AddWithValue("@twinQty", twinQty)
            command.Parameters.AddWithValue("@subtotal", subtotal)
            command.Parameters.AddWithValue("@nights", nights)
            command.Parameters.AddWithValue("@total", total)
            command.Parameters.AddWithValue("@paid", paid)
            command.Parameters.AddWithValue("@balance", balance)

            command.ExecuteNonQuery()

            Dim updateRoomSql As String = "UPDATE bookings 
                   SET roomstatus = 'Booked' 
                   WHERE users_id = @users_id 
                   AND roomstatus = 'Processing'"
            command = New MySqlCommand(updateRoomSql, conn)
            command.Parameters.AddWithValue("@users_id", userId)

            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            MessageBox.Show($"Updated {rowsAffected} bookings to 'Booked' status", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving receipt: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub
End Class