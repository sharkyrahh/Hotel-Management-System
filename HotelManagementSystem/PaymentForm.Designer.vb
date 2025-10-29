<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        GroupBoxPayment = New GroupBox()
        ButtonPay = New Button()
        TextBoxPay = New TextBox()
        Label22 = New Label()
        Label21 = New Label()
        GroupBox2 = New GroupBox()
        Panelsubtotal = New Panel()
        Label_subtotal = New Label()
        Label39 = New Label()
        Panelnumber = New Panel()
        Label_numberofnights = New Label()
        Label37 = New Label()
        Label18 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Panel4 = New Panel()
        LabelPrice4 = New Label()
        LabelQty4 = New Label()
        LabelTotal4 = New Label()
        LabelItem4 = New Label()
        Panel3 = New Panel()
        LabelPrice3 = New Label()
        LabelQty3 = New Label()
        LabelTotal3 = New Label()
        LabelItem3 = New Label()
        Panel2 = New Panel()
        LabelPrice2 = New Label()
        LabelQty2 = New Label()
        LabelTotal2 = New Label()
        LabelItem2 = New Label()
        Panel1 = New Panel()
        LabelPrice1 = New Label()
        LabelQty1 = New Label()
        LabelTotal1 = New Label()
        LabelItem1 = New Label()
        Button_Receipt = New Button()
        Paneltotal = New Panel()
        Label_total = New Label()
        Label28 = New Label()
        Panelbalance = New Panel()
        Label_balance = New Label()
        Label26 = New Label()
        Paneltotalpaid = New Panel()
        Label_totalpaid = New Label()
        Label24 = New Label()
        Label29 = New Label()
        GroupBox3 = New GroupBox()
        TextBoxEmail = New TextBox()
        Label2 = New Label()
        TextBoxPhone = New TextBox()
        Label10 = New Label()
        TextBoxIc = New TextBox()
        TextBoxName = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Button_Confirm = New Button()
        Label32 = New Label()
        Label34 = New Label()
        Label40 = New Label()
        Label41 = New Label()
        Button_Home = New Button()
        Label42 = New Label()
        Label43 = New Label()
        Button_Login = New Button()
        Button_About = New Button()
        Button_CheckIn = New Button()
        Button_Book = New Button()
        Button_View = New Button()
        Button_Back = New Button()
        Button_Check = New Button()
        Button_Book2 = New Button()
        GroupBoxPayment.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panelsubtotal.SuspendLayout()
        Panelnumber.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Paneltotal.SuspendLayout()
        Panelbalance.SuspendLayout()
        Paneltotalpaid.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 27F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(209, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(356, 52)
        Label1.TabIndex = 0
        Label1.Text = "Booking Payment"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' GroupBoxPayment
        ' 
        GroupBoxPayment.BackColor = Color.Transparent
        GroupBoxPayment.Controls.Add(ButtonPay)
        GroupBoxPayment.Controls.Add(TextBoxPay)
        GroupBoxPayment.Controls.Add(Label22)
        GroupBoxPayment.Controls.Add(Label21)
        GroupBoxPayment.Location = New Point(686, 327)
        GroupBoxPayment.Name = "GroupBoxPayment"
        GroupBoxPayment.Size = New Size(523, 358)
        GroupBoxPayment.TabIndex = 9
        GroupBoxPayment.TabStop = False
        GroupBoxPayment.Text = "Payment"
        GroupBoxPayment.Visible = False
        ' 
        ' ButtonPay
        ' 
        ButtonPay.Location = New Point(201, 207)
        ButtonPay.Name = "ButtonPay"
        ButtonPay.Size = New Size(94, 44)
        ButtonPay.TabIndex = 10
        ButtonPay.Text = "PAY"
        ButtonPay.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPay
        ' 
        TextBoxPay.Location = New Point(142, 168)
        TextBoxPay.Name = "TextBoxPay"
        TextBoxPay.Size = New Size(260, 27)
        TextBoxPay.TabIndex = 8
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(81, 168)
        Label22.Name = "Label22"
        Label22.Size = New Size(44, 28)
        Label22.TabIndex = 7
        Label22.Text = "RM"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(157, 119)
        Label21.Name = "Label21"
        Label21.Size = New Size(211, 28)
        Label21.TabIndex = 6
        Label21.Text = "Enter amount to pay."
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Panelsubtotal)
        GroupBox2.Controls.Add(Panelnumber)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Panel4)
        GroupBox2.Controls.Add(Panel3)
        GroupBox2.Controls.Add(Panel2)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(Button_Receipt)
        GroupBox2.Controls.Add(Paneltotal)
        GroupBox2.Controls.Add(Panelbalance)
        GroupBox2.Controls.Add(Paneltotalpaid)
        GroupBox2.Location = New Point(209, 135)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(457, 550)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Booking Details"
        ' 
        ' Panelsubtotal
        ' 
        Panelsubtotal.BorderStyle = BorderStyle.FixedSingle
        Panelsubtotal.Controls.Add(Label_subtotal)
        Panelsubtotal.Controls.Add(Label39)
        Panelsubtotal.Location = New Point(9, 198)
        Panelsubtotal.Name = "Panelsubtotal"
        Panelsubtotal.Size = New Size(413, 32)
        Panelsubtotal.TabIndex = 13
        Panelsubtotal.Visible = False
        ' 
        ' Label_subtotal
        ' 
        Label_subtotal.AutoSize = True
        Label_subtotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_subtotal.Location = New Point(321, 2)
        Label_subtotal.Name = "Label_subtotal"
        Label_subtotal.Size = New Size(92, 28)
        Label_subtotal.TabIndex = 5
        Label_subtotal.Text = "RM1000"
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label39.Location = New Point(11, 2)
        Label39.Name = "Label39"
        Label39.Size = New Size(92, 28)
        Label39.TabIndex = 5
        Label39.Text = "Subtotal"
        ' 
        ' Panelnumber
        ' 
        Panelnumber.BorderStyle = BorderStyle.FixedSingle
        Panelnumber.Controls.Add(Label_numberofnights)
        Panelnumber.Controls.Add(Label37)
        Panelnumber.Location = New Point(9, 232)
        Panelnumber.Name = "Panelnumber"
        Panelnumber.Size = New Size(413, 32)
        Panelnumber.TabIndex = 13
        Panelnumber.Visible = False
        ' 
        ' Label_numberofnights
        ' 
        Label_numberofnights.AutoSize = True
        Label_numberofnights.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_numberofnights.Location = New Point(288, 2)
        Label_numberofnights.Name = "Label_numberofnights"
        Label_numberofnights.Size = New Size(24, 28)
        Label_numberofnights.TabIndex = 9
        Label_numberofnights.Text = "0"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label37.Location = New Point(10, 2)
        Label37.Name = "Label37"
        Label37.Size = New Size(180, 28)
        Label37.TabIndex = 5
        Label37.Text = "Number of nights"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(211, 23)
        Label18.Name = "Label18"
        Label18.Size = New Size(59, 28)
        Label18.TabIndex = 15
        Label18.Text = "Price"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(288, 23)
        Label13.Name = "Label13"
        Label13.Size = New Size(46, 28)
        Label13.TabIndex = 14
        Label13.Text = "Qty"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(340, 23)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 28)
        Label12.TabIndex = 13
        Label12.Text = "Total"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(18, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(55, 28)
        Label11.TabIndex = 11
        Label11.Text = "Item"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(LabelPrice4)
        Panel4.Controls.Add(LabelQty4)
        Panel4.Controls.Add(LabelTotal4)
        Panel4.Controls.Add(LabelItem4)
        Panel4.Location = New Point(9, 163)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(413, 32)
        Panel4.TabIndex = 12
        Panel4.Visible = False
        ' 
        ' LabelPrice4
        ' 
        LabelPrice4.AutoSize = True
        LabelPrice4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPrice4.Location = New Point(205, 2)
        LabelPrice4.Name = "LabelPrice4"
        LabelPrice4.Size = New Size(80, 28)
        LabelPrice4.TabIndex = 10
        LabelPrice4.Text = "RM250"
        ' 
        ' LabelQty4
        ' 
        LabelQty4.AutoSize = True
        LabelQty4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelQty4.Location = New Point(288, 2)
        LabelQty4.Name = "LabelQty4"
        LabelQty4.Size = New Size(24, 28)
        LabelQty4.TabIndex = 9
        LabelQty4.Text = "0"
        ' 
        ' LabelTotal4
        ' 
        LabelTotal4.AutoSize = True
        LabelTotal4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotal4.Location = New Point(321, 2)
        LabelTotal4.Name = "LabelTotal4"
        LabelTotal4.Size = New Size(92, 28)
        LabelTotal4.TabIndex = 5
        LabelTotal4.Text = "RM1000"
        ' 
        ' LabelItem4
        ' 
        LabelItem4.AutoSize = True
        LabelItem4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelItem4.Location = New Point(11, 2)
        LabelItem4.Name = "LabelItem4"
        LabelItem4.Size = New Size(70, 28)
        LabelItem4.TabIndex = 5
        LabelItem4.Text = "Single"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(LabelPrice3)
        Panel3.Controls.Add(LabelQty3)
        Panel3.Controls.Add(LabelTotal3)
        Panel3.Controls.Add(LabelItem3)
        Panel3.Location = New Point(9, 128)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(413, 32)
        Panel3.TabIndex = 12
        Panel3.Visible = False
        ' 
        ' LabelPrice3
        ' 
        LabelPrice3.AutoSize = True
        LabelPrice3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPrice3.Location = New Point(205, 1)
        LabelPrice3.Name = "LabelPrice3"
        LabelPrice3.Size = New Size(80, 28)
        LabelPrice3.TabIndex = 9
        LabelPrice3.Text = "RM200"
        ' 
        ' LabelQty3
        ' 
        LabelQty3.AutoSize = True
        LabelQty3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelQty3.Location = New Point(288, 1)
        LabelQty3.Name = "LabelQty3"
        LabelQty3.Size = New Size(24, 28)
        LabelQty3.TabIndex = 8
        LabelQty3.Text = "0"
        ' 
        ' LabelTotal3
        ' 
        LabelTotal3.AutoSize = True
        LabelTotal3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotal3.Location = New Point(321, 2)
        LabelTotal3.Name = "LabelTotal3"
        LabelTotal3.Size = New Size(92, 28)
        LabelTotal3.TabIndex = 5
        LabelTotal3.Text = "RM1000"
        ' 
        ' LabelItem3
        ' 
        LabelItem3.AutoSize = True
        LabelItem3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelItem3.Location = New Point(11, 2)
        LabelItem3.Name = "LabelItem3"
        LabelItem3.Size = New Size(57, 28)
        LabelItem3.TabIndex = 5
        LabelItem3.Text = "Twin"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(LabelPrice2)
        Panel2.Controls.Add(LabelQty2)
        Panel2.Controls.Add(LabelTotal2)
        Panel2.Controls.Add(LabelItem2)
        Panel2.Location = New Point(9, 92)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(413, 32)
        Panel2.TabIndex = 12
        Panel2.Visible = False
        ' 
        ' LabelPrice2
        ' 
        LabelPrice2.AutoSize = True
        LabelPrice2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPrice2.Location = New Point(205, 2)
        LabelPrice2.Name = "LabelPrice2"
        LabelPrice2.Size = New Size(80, 28)
        LabelPrice2.TabIndex = 8
        LabelPrice2.Text = "RM150"
        ' 
        ' LabelQty2
        ' 
        LabelQty2.AutoSize = True
        LabelQty2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelQty2.Location = New Point(288, 2)
        LabelQty2.Name = "LabelQty2"
        LabelQty2.Size = New Size(24, 28)
        LabelQty2.TabIndex = 7
        LabelQty2.Text = "0"
        ' 
        ' LabelTotal2
        ' 
        LabelTotal2.AutoSize = True
        LabelTotal2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotal2.Location = New Point(321, 2)
        LabelTotal2.Name = "LabelTotal2"
        LabelTotal2.Size = New Size(92, 28)
        LabelTotal2.TabIndex = 5
        LabelTotal2.Text = "RM1000"
        ' 
        ' LabelItem2
        ' 
        LabelItem2.AutoSize = True
        LabelItem2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelItem2.Location = New Point(11, 2)
        LabelItem2.Name = "LabelItem2"
        LabelItem2.Size = New Size(78, 28)
        LabelItem2.TabIndex = 5
        LabelItem2.Text = "Deluxe"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(LabelPrice1)
        Panel1.Controls.Add(LabelQty1)
        Panel1.Controls.Add(LabelTotal1)
        Panel1.Controls.Add(LabelItem1)
        Panel1.Location = New Point(9, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(413, 32)
        Panel1.TabIndex = 11
        Panel1.Visible = False
        ' 
        ' LabelPrice1
        ' 
        LabelPrice1.AutoSize = True
        LabelPrice1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPrice1.Location = New Point(205, 2)
        LabelPrice1.Name = "LabelPrice1"
        LabelPrice1.Size = New Size(80, 28)
        LabelPrice1.TabIndex = 7
        LabelPrice1.Text = "RM100"
        ' 
        ' LabelQty1
        ' 
        LabelQty1.AutoSize = True
        LabelQty1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelQty1.Location = New Point(288, 2)
        LabelQty1.Name = "LabelQty1"
        LabelQty1.Size = New Size(24, 28)
        LabelQty1.TabIndex = 6
        LabelQty1.Text = "0"
        ' 
        ' LabelTotal1
        ' 
        LabelTotal1.AutoSize = True
        LabelTotal1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotal1.Location = New Point(321, 2)
        LabelTotal1.Name = "LabelTotal1"
        LabelTotal1.Size = New Size(92, 28)
        LabelTotal1.TabIndex = 5
        LabelTotal1.Text = "RM1000"
        ' 
        ' LabelItem1
        ' 
        LabelItem1.AutoSize = True
        LabelItem1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelItem1.Location = New Point(11, 2)
        LabelItem1.Name = "LabelItem1"
        LabelItem1.Size = New Size(97, 28)
        LabelItem1.TabIndex = 5
        LabelItem1.Text = "Standard"
        ' 
        ' Button_Receipt
        ' 
        Button_Receipt.Location = New Point(129, 496)
        Button_Receipt.Name = "Button_Receipt"
        Button_Receipt.Size = New Size(201, 45)
        Button_Receipt.TabIndex = 12
        Button_Receipt.Text = "GENERATE RECEIPT"
        Button_Receipt.UseVisualStyleBackColor = True
        Button_Receipt.Visible = False
        ' 
        ' Paneltotal
        ' 
        Paneltotal.BorderStyle = BorderStyle.FixedSingle
        Paneltotal.Controls.Add(Label_total)
        Paneltotal.Controls.Add(Label28)
        Paneltotal.Location = New Point(18, 311)
        Paneltotal.Name = "Paneltotal"
        Paneltotal.Size = New Size(413, 54)
        Paneltotal.TabIndex = 10
        Paneltotal.Visible = False
        ' 
        ' Label_total
        ' 
        Label_total.AutoSize = True
        Label_total.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_total.Location = New Point(318, 12)
        Label_total.Name = "Label_total"
        Label_total.Size = New Size(92, 28)
        Label_total.TabIndex = 5
        Label_total.Text = "RM1000"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(11, 12)
        Label28.Name = "Label28"
        Label28.Size = New Size(72, 28)
        Label28.TabIndex = 5
        Label28.Text = "TOTAL"
        ' 
        ' Panelbalance
        ' 
        Panelbalance.BorderStyle = BorderStyle.FixedSingle
        Panelbalance.Controls.Add(Label_balance)
        Panelbalance.Controls.Add(Label26)
        Panelbalance.Location = New Point(18, 431)
        Panelbalance.Name = "Panelbalance"
        Panelbalance.Size = New Size(413, 54)
        Panelbalance.TabIndex = 10
        Panelbalance.Visible = False
        ' 
        ' Label_balance
        ' 
        Label_balance.AutoSize = True
        Label_balance.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_balance.Location = New Point(318, 12)
        Label_balance.Name = "Label_balance"
        Label_balance.Size = New Size(92, 28)
        Label_balance.TabIndex = 6
        Label_balance.Text = "RM1000"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(11, 12)
        Label26.Name = "Label26"
        Label26.Size = New Size(102, 28)
        Label26.TabIndex = 5
        Label26.Text = "BALANCE"
        ' 
        ' Paneltotalpaid
        ' 
        Paneltotalpaid.BorderStyle = BorderStyle.FixedSingle
        Paneltotalpaid.Controls.Add(Label_totalpaid)
        Paneltotalpaid.Controls.Add(Label24)
        Paneltotalpaid.Location = New Point(18, 371)
        Paneltotalpaid.Name = "Paneltotalpaid"
        Paneltotalpaid.Size = New Size(413, 54)
        Paneltotalpaid.TabIndex = 9
        Paneltotalpaid.Visible = False
        ' 
        ' Label_totalpaid
        ' 
        Label_totalpaid.AutoSize = True
        Label_totalpaid.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_totalpaid.Location = New Point(318, 12)
        Label_totalpaid.Name = "Label_totalpaid"
        Label_totalpaid.Size = New Size(92, 28)
        Label_totalpaid.TabIndex = 5
        Label_totalpaid.Text = "RM1000"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(11, 12)
        Label24.Name = "Label24"
        Label24.Size = New Size(124, 28)
        Label24.TabIndex = 5
        Label24.Text = "TOTAL PAID"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(209, 91)
        Label29.Name = "Label29"
        Label29.Size = New Size(1076, 28)
        Label29.TabIndex = 13
        Label29.Text = "_____________________________________________________________________________________________________________________________________"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBoxEmail)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(TextBoxPhone)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(TextBoxIc)
        GroupBox3.Controls.Add(TextBoxName)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Location = New Point(686, 135)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(523, 186)
        GroupBox3.TabIndex = 11
        GroupBox3.TabStop = False
        GroupBox3.Text = "Customer Details"
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(183, 146)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(260, 27)
        TextBoxEmail.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 14
        Label2.Text = "Email"
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.Location = New Point(183, 109)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(260, 27)
        TextBoxPhone.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(21, 104)
        Label10.Name = "Label10"
        Label10.Size = New Size(154, 28)
        Label10.TabIndex = 12
        Label10.Text = "Phone Number"
        ' 
        ' TextBoxIc
        ' 
        TextBoxIc.Location = New Point(183, 66)
        TextBoxIc.Name = "TextBoxIc"
        TextBoxIc.Size = New Size(260, 27)
        TextBoxIc.TabIndex = 11
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(183, 26)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(260, 27)
        TextBoxName.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(21, 65)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 28)
        Label8.TabIndex = 7
        Label8.Text = "IC Number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(21, 26)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 28)
        Label9.TabIndex = 6
        Label9.Text = "Name"
        ' 
        ' Button_Confirm
        ' 
        Button_Confirm.Location = New Point(1152, 286)
        Button_Confirm.Name = "Button_Confirm"
        Button_Confirm.Size = New Size(94, 44)
        Button_Confirm.TabIndex = 10
        Button_Confirm.Text = "CONFIRM"
        Button_Confirm.UseVisualStyleBackColor = True
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.BackColor = Color.White
        Label32.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label32.Location = New Point(25, 770)
        Label32.Name = "Label32"
        Label32.Size = New Size(99, 20)
        Label32.TabIndex = 37
        Label32.Text = "Admin Login"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.BackColor = Color.White
        Label34.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label34.Location = New Point(48, 642)
        Label34.Name = "Label34"
        Label34.Size = New Size(53, 20)
        Label34.TabIndex = 36
        Label34.Text = "About"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.BackColor = Color.White
        Label40.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label40.Location = New Point(33, 100)
        Label40.Name = "Label40"
        Label40.Size = New Size(85, 20)
        Label40.TabIndex = 35
        Label40.Text = "Homepage"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.BackColor = Color.White
        Label41.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label41.Location = New Point(21, 511)
        Label41.Name = "Label41"
        Label41.Size = New Size(109, 20)
        Label41.TabIndex = 34
        Label41.Text = "Check In / Out"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(-1, 0)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 26
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.BackColor = Color.White
        Label42.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label42.Location = New Point(23, 368)
        Label42.Name = "Label42"
        Label42.Size = New Size(103, 20)
        Label42.TabIndex = 33
        Label42.Text = "Book a Room"
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.BackColor = Color.White
        Label43.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label43.Location = New Point(27, 244)
        Label43.Name = "Label43"
        Label43.Size = New Size(96, 20)
        Label43.TabIndex = 32
        Label43.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.BackgroundImage = My.Resources.Resources.loginicon
        Button_Login.Location = New Point(-1, 670)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(159, 137)
        Button_Login.TabIndex = 31
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Button_About
        ' 
        Button_About.BackgroundImage = My.Resources.Resources.abouticon
        Button_About.Location = New Point(-1, 539)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 30
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_CheckIn
        ' 
        Button_CheckIn.Location = New Point(0, 0)
        Button_CheckIn.Name = "Button_CheckIn"
        Button_CheckIn.Size = New Size(75, 23)
        Button_CheckIn.TabIndex = 39
        ' 
        ' Button_Book
        ' 
        Button_Book.Location = New Point(0, 0)
        Button_Book.Name = "Button_Book"
        Button_Book.Size = New Size(75, 23)
        Button_Book.TabIndex = 40
        ' 
        ' Button_View
        ' 
        Button_View.BackgroundImage = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(-1, 135)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 28
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Button_Back
        ' 
        Button_Back.Location = New Point(214, 725)
        Button_Back.Name = "Button_Back"
        Button_Back.Size = New Size(116, 44)
        Button_Back.TabIndex = 38
        Button_Back.Text = "BACK"
        Button_Back.UseVisualStyleBackColor = True
        ' 
        ' Button_Check
        ' 
        Button_Check.BackgroundImage = My.Resources.Resources.checkinicon
        Button_Check.Location = New Point(0, 403)
        Button_Check.Name = "Button_Check"
        Button_Check.Size = New Size(159, 137)
        Button_Check.TabIndex = 42
        Button_Check.UseVisualStyleBackColor = True
        ' 
        ' Button_Book2
        ' 
        Button_Book2.BackgroundImage = My.Resources.Resources.roomicon
        Button_Book2.Location = New Point(0, 268)
        Button_Book2.Name = "Button_Book2"
        Button_Book2.Size = New Size(159, 137)
        Button_Book2.TabIndex = 41
        Button_Book2.UseVisualStyleBackColor = True
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1303, 806)
        Controls.Add(Button_Back)
        Controls.Add(Label32)
        Controls.Add(Label34)
        Controls.Add(Label40)
        Controls.Add(Label41)
        Controls.Add(Button_Home)
        Controls.Add(Label42)
        Controls.Add(Label43)
        Controls.Add(Button_Login)
        Controls.Add(Button_About)
        Controls.Add(Button_CheckIn)
        Controls.Add(Button_Book)
        Controls.Add(Button_View)
        Controls.Add(Button_Confirm)
        Controls.Add(GroupBox3)
        Controls.Add(Label1)
        Controls.Add(Label29)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBoxPayment)
        Controls.Add(Button_Book2)
        Controls.Add(Button_Check)
        Name = "PaymentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        GroupBoxPayment.ResumeLayout(False)
        GroupBoxPayment.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panelsubtotal.ResumeLayout(False)
        Panelsubtotal.PerformLayout()
        Panelnumber.ResumeLayout(False)
        Panelnumber.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Paneltotal.ResumeLayout(False)
        Paneltotal.PerformLayout()
        Panelbalance.ResumeLayout(False)
        Panelbalance.PerformLayout()
        Paneltotalpaid.ResumeLayout(False)
        Paneltotalpaid.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents GroupBoxPayment As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents ButtonPay As Button
    Friend WithEvents TextBoxPay As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Paneltotalpaid As Panel
    Friend WithEvents Label_totalpaid As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Button_Receipt As Button
    Friend WithEvents Paneltotal As Panel
    Friend WithEvents Label_total As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panelbalance As Panel
    Friend WithEvents Label_balance As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelTotal3 As Label
    Friend WithEvents LabelItem3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelTotal2 As Label
    Friend WithEvents LabelItem2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTotal1 As Label
    Friend WithEvents LabelItem1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelTotal4 As Label
    Friend WithEvents LabelItem4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxIc As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button_Confirm As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelQty4 As Label
    Friend WithEvents LabelQty3 As Label
    Friend WithEvents LabelQty2 As Label
    Friend WithEvents LabelQty1 As Label
    Friend WithEvents Panelnumber As Panel
    Friend WithEvents Label_numberofnights As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LabelPrice4 As Label
    Friend WithEvents LabelPrice3 As Label
    Friend WithEvents LabelPrice2 As Label
    Friend WithEvents LabelPrice1 As Label
    Friend WithEvents Panelsubtotal As Panel
    Friend WithEvents Label_subtotal As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_CheckIn As Button
    Friend WithEvents Button_Book As Button
    Friend WithEvents Button_View As Button
    Friend WithEvents Button_Back As Button
    Friend WithEvents Button_Check As Button
    Friend WithEvents Button_Book2 As Button
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label2 As Label
End Class
