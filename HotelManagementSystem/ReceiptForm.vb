Imports MySql.Data.MySqlClient

Public Class ReceiptForm
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Hide()
    End Sub

    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReceiptData()
    End Sub

    Private Sub LoadReceiptData()
        Try
            Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=hoteldb")
            conn.Open()

            Dim receiptSql As String = "SELECT * FROM receipts ORDER BY receipt_id DESC LIMIT 1"
            Dim command As New MySqlCommand(receiptSql, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                Dim receiptId As Integer = reader("receipt_id")
                Dim userId As Integer = reader("users_id")
                Dim standardQty As Integer = reader("standardQty")
                Dim deluxeQty As Integer = reader("deluxeQty")
                Dim singleQty As Integer = reader("singleQty")
                Dim twinQty As Integer = reader("twinQty")
                Dim subtotal As Decimal = reader("subtotal")
                Dim nights As Integer = reader("nights")
                Dim total As Decimal = reader("total")
                Dim paid As Decimal = reader("paid")
                Dim balance As Decimal = reader("balance")

                reader.Close()

                LabelId.Text = "12345" & receiptId.ToString()

                Dim today As DateTime = DateTime.Today
                LabelDate.Text = today.ToString("dddd, d MMMM yyyy")

                Dim userSql As String = "SELECT name, phone FROM users WHERE users_id = @user_id"
                command = New MySqlCommand(userSql, conn)
                command.Parameters.AddWithValue("@user_id", userId)
                reader = command.ExecuteReader()

                If reader.Read() Then
                    LabelName.Text = reader("name").ToString()
                    LabelPhone.Text = reader("phone").ToString()
                End If
                reader.Close()

                UpdateRoomPanels(standardQty, deluxeQty, singleQty, twinQty)

                LabelSubtotal.Text = $"RM{subtotal}"
                LabelNights.Text = nights.ToString()
                LabelTotal.Text = $"RM{total}"
                LabelPaid.Text = $"RM{paid}"
                LabelBalance.Text = $"RM{balance}"

            End If

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading receipt: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateRoomPanels(standardQty As Integer, deluxeQty As Integer, singleQty As Integer, twinQty As Integer)
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False

        Dim panelIndex As Integer = 1

        If standardQty > 0 Then
            UpdateReceiptPanel(panelIndex, "Standard", 200, standardQty)
            panelIndex += 1
        End If

        If deluxeQty > 0 Then
            UpdateReceiptPanel(panelIndex, "Deluxe", 250, deluxeQty)
            panelIndex += 1
        End If

        If singleQty > 0 Then
            UpdateReceiptPanel(panelIndex, "Single", 100, singleQty)
            panelIndex += 1
        End If

        If twinQty > 0 Then
            UpdateReceiptPanel(panelIndex, "Twin", 150, twinQty)
            panelIndex += 1
        End If
    End Sub

    Private Sub UpdateReceiptPanel(panelNumber As Integer, roomType As String, price As Integer, quantity As Integer)
        Dim total As Integer = price * quantity

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
End Class