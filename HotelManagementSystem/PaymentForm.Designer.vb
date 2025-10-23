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
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label22 = New Label()
        Label21 = New Label()
        GroupBox2 = New GroupBox()
        Panel6 = New Panel()
        Label38 = New Label()
        Label39 = New Label()
        Panel4 = New Panel()
        Label33 = New Label()
        Label37 = New Label()
        Label18 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Panel3 = New Panel()
        Label31 = New Label()
        Label17 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel2 = New Panel()
        Label30 = New Label()
        Label16 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Label20 = New Label()
        Label15 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel5 = New Panel()
        Label19 = New Label()
        Label14 = New Label()
        Label35 = New Label()
        Label36 = New Label()
        Button_Receipt = New Button()
        Panel9 = New Panel()
        Label25 = New Label()
        Label28 = New Label()
        Panel8 = New Panel()
        Label27 = New Label()
        Label26 = New Label()
        Panel7 = New Panel()
        Label23 = New Label()
        Label24 = New Label()
        Label29 = New Label()
        GroupBox3 = New GroupBox()
        TextBox4 = New TextBox()
        Label10 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Button2 = New Button()
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
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 25.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(209, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(346, 51)
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label22)
        GroupBox1.Controls.Add(Label21)
        GroupBox1.Location = New Point(686, 327)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(523, 358)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Payment"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(201, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 44)
        Button1.TabIndex = 10
        Button1.Text = "PAY"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(142, 168)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 27)
        TextBox1.TabIndex = 8
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
        GroupBox2.Controls.Add(Panel6)
        GroupBox2.Controls.Add(Panel4)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Panel3)
        GroupBox2.Controls.Add(Panel2)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(Panel5)
        GroupBox2.Controls.Add(Button_Receipt)
        GroupBox2.Controls.Add(Panel9)
        GroupBox2.Controls.Add(Panel8)
        GroupBox2.Controls.Add(Panel7)
        GroupBox2.Location = New Point(209, 135)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(457, 550)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Booking Details"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label38)
        Panel6.Controls.Add(Label39)
        Panel6.Location = New Point(18, 198)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(413, 32)
        Panel6.TabIndex = 13
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label38.Location = New Point(337, 2)
        Label38.Name = "Label38"
        Label38.Size = New Size(56, 28)
        Label38.TabIndex = 5
        Label38.Text = "RM0"
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
        ' Panel4
        ' 
        Panel4.Controls.Add(Label33)
        Panel4.Controls.Add(Label37)
        Panel4.Location = New Point(18, 232)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(413, 32)
        Panel4.TabIndex = 13
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.Location = New Point(294, 2)
        Label33.Name = "Label33"
        Label33.Size = New Size(24, 28)
        Label33.TabIndex = 9
        Label33.Text = "0"
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
        ' Panel3
        ' 
        Panel3.Controls.Add(Label31)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(18, 163)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(413, 32)
        Panel3.TabIndex = 12
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(211, 2)
        Label31.Name = "Label31"
        Label31.Size = New Size(56, 28)
        Label31.TabIndex = 10
        Label31.Text = "RM0"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(294, 2)
        Label17.Name = "Label17"
        Label17.Size = New Size(24, 28)
        Label17.TabIndex = 9
        Label17.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(337, 2)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 28)
        Label6.TabIndex = 5
        Label6.Text = "RM0"
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
        ' Panel2
        ' 
        Panel2.Controls.Add(Label30)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(18, 128)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(413, 32)
        Panel2.TabIndex = 12
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(211, 1)
        Label30.Name = "Label30"
        Label30.Size = New Size(56, 28)
        Label30.TabIndex = 9
        Label30.Text = "RM0"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(294, 1)
        Label16.Name = "Label16"
        Label16.Size = New Size(24, 28)
        Label16.TabIndex = 8
        Label16.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(337, 2)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 28)
        Label4.TabIndex = 5
        Label4.Text = "RM0"
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
        ' Panel1
        ' 
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(18, 92)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(413, 32)
        Panel1.TabIndex = 12
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(211, 2)
        Label20.Name = "Label20"
        Label20.Size = New Size(56, 28)
        Label20.TabIndex = 8
        Label20.Text = "RM0"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(294, 2)
        Label15.Name = "Label15"
        Label15.Size = New Size(24, 28)
        Label15.TabIndex = 7
        Label15.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(337, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 28)
        Label2.TabIndex = 5
        Label2.Text = "RM0"
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
        ' Panel5
        ' 
        Panel5.Controls.Add(Label19)
        Panel5.Controls.Add(Label14)
        Panel5.Controls.Add(Label35)
        Panel5.Controls.Add(Label36)
        Panel5.Location = New Point(18, 54)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(413, 32)
        Panel5.TabIndex = 11
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(211, 2)
        Label19.Name = "Label19"
        Label19.Size = New Size(56, 28)
        Label19.TabIndex = 7
        Label19.Text = "RM0"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(294, 2)
        Label14.Name = "Label14"
        Label14.Size = New Size(24, 28)
        Label14.TabIndex = 6
        Label14.Text = "0"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label35.Location = New Point(337, 2)
        Label35.Name = "Label35"
        Label35.Size = New Size(56, 28)
        Label35.TabIndex = 5
        Label35.Text = "RM0"
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
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(Label25)
        Panel9.Controls.Add(Label28)
        Panel9.Location = New Point(18, 311)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(413, 54)
        Panel9.TabIndex = 10
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(337, 12)
        Label25.Name = "Label25"
        Label25.Size = New Size(56, 28)
        Label25.TabIndex = 5
        Label25.Text = "RM0"
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
        ' Panel8
        ' 
        Panel8.Controls.Add(Label27)
        Panel8.Controls.Add(Label26)
        Panel8.Location = New Point(18, 431)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(413, 54)
        Panel8.TabIndex = 10
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(337, 12)
        Label27.Name = "Label27"
        Label27.Size = New Size(56, 28)
        Label27.TabIndex = 6
        Label27.Text = "RM0"
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
        ' Panel7
        ' 
        Panel7.Controls.Add(Label23)
        Panel7.Controls.Add(Label24)
        Panel7.Location = New Point(18, 371)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(413, 54)
        Panel7.TabIndex = 9
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(337, 12)
        Label23.Name = "Label23"
        Label23.Size = New Size(56, 28)
        Label23.TabIndex = 5
        Label23.Text = "RM0"
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
        GroupBox3.Controls.Add(TextBox4)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(TextBox3)
        GroupBox3.Controls.Add(TextBox2)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Location = New Point(686, 135)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(523, 186)
        GroupBox3.TabIndex = 11
        GroupBox3.TabStop = False
        GroupBox3.Text = "Customer Details"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(183, 122)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(260, 27)
        TextBox4.TabIndex = 13
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
        ' TextBox3
        ' 
        TextBox3.Location = New Point(183, 79)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(260, 27)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(183, 39)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(260, 27)
        TextBox2.TabIndex = 8
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
        ' Button2
        ' 
        Button2.Location = New Point(1152, 286)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 44)
        Button2.TabIndex = 10
        Button2.Text = "CONFIRM"
        Button2.UseVisualStyleBackColor = True
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
        Button_CheckIn.BackgroundImage = My.Resources.Resources.checkinicon
        Button_CheckIn.Location = New Point(-1, 405)
        Button_CheckIn.Name = "Button_CheckIn"
        Button_CheckIn.Size = New Size(159, 137)
        Button_CheckIn.TabIndex = 29
        Button_CheckIn.UseVisualStyleBackColor = True
        ' 
        ' Button_Book
        ' 
        Button_Book.BackgroundImage = My.Resources.Resources.roomicon
        Button_Book.Location = New Point(-1, 270)
        Button_Book.Name = "Button_Book"
        Button_Book.Size = New Size(159, 137)
        Button_Book.TabIndex = 27
        Button_Book.UseVisualStyleBackColor = True
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
        Controls.Add(Button2)
        Controls.Add(GroupBox3)
        Controls.Add(Label1)
        Controls.Add(Label29)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "PaymentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Button_Receipt As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label38 As Label
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
End Class
