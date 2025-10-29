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
        GroupBoxpayment = New GroupBox()
        Buttonpay = New Button()
        TextBoxpay = New TextBox()
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
        Panelsingle = New Panel()
        Label31 = New Label()
        LabelQtySingle = New Label()
        Label_singletotal = New Label()
        Label7 = New Label()
        Paneltwin = New Panel()
        Label30 = New Label()
        LabelQtyTwin = New Label()
        Label_twintotal = New Label()
        Label5 = New Label()
        Paneldeluxe = New Panel()
        Label20 = New Label()
        LabelQtyDeluxe = New Label()
        Label_deluxetotal = New Label()
        Label3 = New Label()
        Panelstandard = New Panel()
        Label19 = New Label()
        LabelQtyStandard = New Label()
        Label_standardtotal = New Label()
        Label36 = New Label()
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
        TextBoxphone = New TextBox()
        Label10 = New Label()
        TextBox_ic = New TextBox()
        TextBoxName = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Button_confirm = New Button()
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
        GroupBoxpayment.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panelsubtotal.SuspendLayout()
        Panelnumber.SuspendLayout()
        Panelsingle.SuspendLayout()
        Paneltwin.SuspendLayout()
        Paneldeluxe.SuspendLayout()
        Panelstandard.SuspendLayout()
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
        ' GroupBoxpayment
        ' 
        GroupBoxpayment.BackColor = Color.Transparent
        GroupBoxpayment.Controls.Add(Buttonpay)
        GroupBoxpayment.Controls.Add(TextBoxpay)
        GroupBoxpayment.Controls.Add(Label22)
        GroupBoxpayment.Controls.Add(Label21)
        GroupBoxpayment.Location = New Point(686, 327)
        GroupBoxpayment.Name = "GroupBoxpayment"
        GroupBoxpayment.Size = New Size(523, 358)
        GroupBoxpayment.TabIndex = 9
        GroupBoxpayment.TabStop = False
        GroupBoxpayment.Text = "Payment"
        GroupBoxpayment.Visible = False
        ' 
        ' Buttonpay
        ' 
        Buttonpay.Location = New Point(201, 207)
        Buttonpay.Name = "Buttonpay"
        Buttonpay.Size = New Size(94, 44)
        Buttonpay.TabIndex = 10
        Buttonpay.Text = "PAY"
        Buttonpay.UseVisualStyleBackColor = True
        ' 
        ' TextBoxpay
        ' 
        TextBoxpay.Location = New Point(142, 168)
        TextBoxpay.Name = "TextBoxpay"
        TextBoxpay.Size = New Size(260, 27)
        TextBoxpay.TabIndex = 8
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
        GroupBox2.Controls.Add(Panelsingle)
        GroupBox2.Controls.Add(Paneltwin)
        GroupBox2.Controls.Add(Paneldeluxe)
        GroupBox2.Controls.Add(Panelstandard)
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
        Panelsubtotal.Controls.Add(Label_subtotal)
        Panelsubtotal.Controls.Add(Label39)
        Panelsubtotal.Location = New Point(18, 198)
        Panelsubtotal.Name = "Panelsubtotal"
        Panelsubtotal.Size = New Size(413, 32)
        Panelsubtotal.TabIndex = 13
        Panelsubtotal.Visible = False
        ' 
        ' Label_subtotal
        ' 
        Label_subtotal.AutoSize = True
        Label_subtotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_subtotal.Location = New Point(337, 2)
        Label_subtotal.Name = "Label_subtotal"
        Label_subtotal.Size = New Size(56, 28)
        Label_subtotal.TabIndex = 5
        Label_subtotal.Text = "RM0"
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
        Panelnumber.Controls.Add(Label_numberofnights)
        Panelnumber.Controls.Add(Label37)
        Panelnumber.Location = New Point(18, 232)
        Panelnumber.Name = "Panelnumber"
        Panelnumber.Size = New Size(413, 32)
        Panelnumber.TabIndex = 13
        Panelnumber.Visible = False
        ' 
        ' Label_numberofnights
        ' 
        Label_numberofnights.AutoSize = True
        Label_numberofnights.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_numberofnights.Location = New Point(294, 2)
        Label_numberofnights.Name = "Label_numberofnights"
        Label_numberofnights.Size = New Size(24, 28)
        Label_numberofnights.TabIndex = 9
        Label_numberofnights.Text = "0"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label37.Location = New Point(11, 2)
        Label37.Name = "Label37"
        Label37.Size = New Size(180, 28)
        Label37.TabIndex = 5
        Label37.Text = "Number of nights"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(226, 23)
        Label18.Name = "Label18"
        Label18.Size = New Size(59, 28)
        Label18.TabIndex = 15
        Label18.Text = "Price"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(303, 23)
        Label13.Name = "Label13"
        Label13.Size = New Size(46, 28)
        Label13.TabIndex = 14
        Label13.Text = "Qty"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(355, 23)
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
        ' Panelsingle
        ' 
        Panelsingle.Controls.Add(Label31)
        Panelsingle.Controls.Add(LabelQtySingle)
        Panelsingle.Controls.Add(Label_singletotal)
        Panelsingle.Controls.Add(Label7)
        Panelsingle.Location = New Point(18, 163)
        Panelsingle.Name = "Panelsingle"
        Panelsingle.Size = New Size(413, 32)
        Panelsingle.TabIndex = 12
        Panelsingle.Visible = False
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(211, 2)
        Label31.Name = "Label31"
        Label31.Size = New Size(80, 28)
        Label31.TabIndex = 10
        Label31.Text = "RM250"
        ' 
        ' LabelQtySingle
        ' 
        LabelQtySingle.AutoSize = True
        LabelQtySingle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelQtySingle.Location = New Point(294, 2)
        LabelQtySingle.Name = "LabelQtySingle"
        LabelQtySingle.Size = New Size(24, 28)
        LabelQtySingle.TabIndex = 9
        LabelQtySingle.Text = "0"
        ' 
        ' Label_singletotal
        ' 
        Label_singletotal.AutoSize = True
        Label_singletotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_singletotal.Location = New Point(337, 2)
        Label_singletotal.Name = "Label_singletotal"
        Label_singletotal.Size = New Size(56, 28)
        Label_singletotal.TabIndex = 5
        Label_singletotal.Text = "RM0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(11, 2)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 28)
        Label7.TabIndex = 5
        Label7.Text = "Single"
        ' 
        ' Paneltwin
        ' 
        Paneltwin.Controls.Add(Label30)
        Paneltwin.Controls.Add(LabelQtyTwin)
        Paneltwin.Controls.Add(Label_twintotal)
        Paneltwin.Controls.Add(Label5)
        Paneltwin.Location = New Point(18, 128)
        Paneltwin.Name = "Paneltwin"
        Paneltwin.Size = New Size(413, 32)
        Paneltwin.TabIndex = 12
        Paneltwin.Visible = False
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(211, 1)
        Label30.Name = "Label30"
        Label30.Size = New Size(80, 28)
        Label30.TabIndex = 9
        Label30.Text = "RM200"
        ' 
        ' LabelQtyTwin
        ' 
        LabelQtyTwin.AutoSize = True
        LabelQtyTwin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelQtyTwin.Location = New Point(294, 1)
        LabelQtyTwin.Name = "LabelQtyTwin"
        LabelQtyTwin.Size = New Size(24, 28)
        LabelQtyTwin.TabIndex = 8
        LabelQtyTwin.Text = "0"
        ' 
        ' Label_twintotal
        ' 
        Label_twintotal.AutoSize = True
        Label_twintotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_twintotal.Location = New Point(337, 2)
        Label_twintotal.Name = "Label_twintotal"
        Label_twintotal.Size = New Size(56, 28)
        Label_twintotal.TabIndex = 5
        Label_twintotal.Text = "RM0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 2)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 28)
        Label5.TabIndex = 5
        Label5.Text = "Twin"
        ' 
        ' Paneldeluxe
        ' 
        Paneldeluxe.Controls.Add(Label20)
        Paneldeluxe.Controls.Add(LabelQtyDeluxe)
        Paneldeluxe.Controls.Add(Label_deluxetotal)
        Paneldeluxe.Controls.Add(Label3)
        Paneldeluxe.Location = New Point(18, 92)
        Paneldeluxe.Name = "Paneldeluxe"
        Paneldeluxe.Size = New Size(413, 32)
        Paneldeluxe.TabIndex = 12
        Paneldeluxe.Visible = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(211, 2)
        Label20.Name = "Label20"
        Label20.Size = New Size(80, 28)
        Label20.TabIndex = 8
        Label20.Text = "RM150"
        ' 
        ' LabelQtyDeluxe
        ' 
        LabelQtyDeluxe.AutoSize = True
        LabelQtyDeluxe.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelQtyDeluxe.Location = New Point(294, 2)
        LabelQtyDeluxe.Name = "LabelQtyDeluxe"
        LabelQtyDeluxe.Size = New Size(24, 28)
        LabelQtyDeluxe.TabIndex = 7
        LabelQtyDeluxe.Text = "0"
        ' 
        ' Label_deluxetotal
        ' 
        Label_deluxetotal.AutoSize = True
        Label_deluxetotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_deluxetotal.Location = New Point(337, 2)
        Label_deluxetotal.Name = "Label_deluxetotal"
        Label_deluxetotal.Size = New Size(56, 28)
        Label_deluxetotal.TabIndex = 5
        Label_deluxetotal.Text = "RM0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(11, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 28)
        Label3.TabIndex = 5
        Label3.Text = "Deluxe"
        ' 
        ' Panelstandard
        ' 
        Panelstandard.Controls.Add(Label19)
        Panelstandard.Controls.Add(LabelQtyStandard)
        Panelstandard.Controls.Add(Label_standardtotal)
        Panelstandard.Controls.Add(Label36)
        Panelstandard.Location = New Point(18, 54)
        Panelstandard.Name = "Panelstandard"
        Panelstandard.Size = New Size(413, 32)
        Panelstandard.TabIndex = 11
        Panelstandard.Visible = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(211, 2)
        Label19.Name = "Label19"
        Label19.Size = New Size(80, 28)
        Label19.TabIndex = 7
        Label19.Text = "RM100"
        ' 
        ' LabelQtyStandard
        ' 
        LabelQtyStandard.AutoSize = True
        LabelQtyStandard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelQtyStandard.Location = New Point(294, 2)
        LabelQtyStandard.Name = "LabelQtyStandard"
        LabelQtyStandard.Size = New Size(24, 28)
        LabelQtyStandard.TabIndex = 6
        LabelQtyStandard.Text = "0"
        ' 
        ' Label_standardtotal
        ' 
        Label_standardtotal.AutoSize = True
        Label_standardtotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_standardtotal.Location = New Point(337, 2)
        Label_standardtotal.Name = "Label_standardtotal"
        Label_standardtotal.Size = New Size(56, 28)
        Label_standardtotal.TabIndex = 5
        Label_standardtotal.Text = "RM0"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label36.Location = New Point(11, 2)
        Label36.Name = "Label36"
        Label36.Size = New Size(97, 28)
        Label36.TabIndex = 5
        Label36.Text = "Standard"
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
        Label_total.Location = New Point(337, 12)
        Label_total.Name = "Label_total"
        Label_total.Size = New Size(56, 28)
        Label_total.TabIndex = 5
        Label_total.Text = "RM0"
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
        Label_balance.Location = New Point(337, 12)
        Label_balance.Name = "Label_balance"
        Label_balance.Size = New Size(56, 28)
        Label_balance.TabIndex = 6
        Label_balance.Text = "RM0"
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
        Label_totalpaid.Location = New Point(337, 12)
        Label_totalpaid.Name = "Label_totalpaid"
        Label_totalpaid.Size = New Size(56, 28)
        Label_totalpaid.TabIndex = 5
        Label_totalpaid.Text = "RM0"
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
        GroupBox3.Controls.Add(TextBoxphone)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(TextBox_ic)
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
        ' TextBoxphone
        ' 
        TextBoxphone.Location = New Point(183, 122)
        TextBoxphone.Name = "TextBoxphone"
        TextBoxphone.Size = New Size(260, 27)
        TextBoxphone.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(21, 122)
        Label10.Name = "Label10"
        Label10.Size = New Size(154, 28)
        Label10.TabIndex = 12
        Label10.Text = "Phone Number"
        ' 
        ' TextBox_ic
        ' 
        TextBox_ic.Location = New Point(183, 79)
        TextBox_ic.Name = "TextBox_ic"
        TextBox_ic.Size = New Size(260, 27)
        TextBox_ic.TabIndex = 11
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(183, 39)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(260, 27)
        TextBoxName.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(21, 78)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 28)
        Label8.TabIndex = 7
        Label8.Text = "IC Number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(21, 39)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 28)
        Label9.TabIndex = 6
        Label9.Text = "Name"
        ' 
        ' Button_confirm
        ' 
        Button_confirm.Location = New Point(1152, 286)
        Button_confirm.Name = "Button_confirm"
        Button_confirm.Size = New Size(94, 44)
        Button_confirm.TabIndex = 10
        Button_confirm.Text = "CONFIRM"
        Button_confirm.UseVisualStyleBackColor = True
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
        Controls.Add(Button_confirm)
        Controls.Add(GroupBox3)
        Controls.Add(Label1)
        Controls.Add(Label29)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBoxpayment)
        Controls.Add(Button_Book2)
        Controls.Add(Button_Check)
        Name = "PaymentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        GroupBoxpayment.ResumeLayout(False)
        GroupBoxpayment.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panelsubtotal.ResumeLayout(False)
        Panelsubtotal.PerformLayout()
        Panelnumber.ResumeLayout(False)
        Panelnumber.PerformLayout()
        Panelsingle.ResumeLayout(False)
        Panelsingle.PerformLayout()
        Paneltwin.ResumeLayout(False)
        Paneltwin.PerformLayout()
        Paneldeluxe.ResumeLayout(False)
        Paneldeluxe.PerformLayout()
        Panelstandard.ResumeLayout(False)
        Panelstandard.PerformLayout()
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
    Friend WithEvents GroupBoxpayment As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Buttonpay As Button
    Friend WithEvents TextBoxpay As TextBox
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
    Friend WithEvents Paneltwin As Panel
    Friend WithEvents Label_twintotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Paneldeluxe As Panel
    Friend WithEvents Label_deluxetotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panelstandard As Panel
    Friend WithEvents Label_standardtotal As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Panelsingle As Panel
    Friend WithEvents Label_singletotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxphone As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox_ic As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button_confirm As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelQtySingle As Label
    Friend WithEvents LabelQtyTwin As Label
    Friend WithEvents LabelQtyDeluxe As Label
    Friend WithEvents LabelQtyStandard As Label
    Friend WithEvents Panelnumber As Panel
    Friend WithEvents Label_numberofnights As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
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
End Class
