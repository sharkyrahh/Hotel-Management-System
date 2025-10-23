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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Label31 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel6 = New Panel()
        Label18 = New Label()
        Label20 = New Label()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label22 = New Label()
        Label21 = New Label()
        GroupBox2 = New GroupBox()
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
        Button_Back = New Button()
        Button_Exit = New Button()
        Label29 = New Label()
        Label30 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label32 = New Label()
        Panel3 = New Panel()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label33 = New Label()
        Panel4 = New Panel()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label34 = New Label()
        Panel10 = New Panel()
        Label19 = New Label()
        Label38 = New Label()
        Panel11 = New Panel()
        Label39 = New Label()
        Label40 = New Label()
        Label17 = New Label()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 27F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(33, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(356, 52)
        Label1.TabIndex = 0
        Label1.Text = "Booking Payment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(44, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 28)
        Label2.TabIndex = 1
        Label2.Text = "ITEM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(380, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 28)
        Label3.TabIndex = 2
        Label3.Text = "PRICE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(468, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 28)
        Label4.TabIndex = 3
        Label4.Text = "QTY"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Label31)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(33, 162)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(589, 54)
        Panel1.TabIndex = 4
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(502, 12)
        Label31.Name = "Label31"
        Label31.Size = New Size(80, 28)
        Label31.TabIndex = 6
        Label31.Text = "RM100"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(449, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(24, 28)
        Label7.TabIndex = 5
        Label7.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(342, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 28)
        Label6.TabIndex = 5
        Label6.Text = "RM100"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 28)
        Label5.TabIndex = 5
        Label5.Text = "STANDARD"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Transparent
        Panel6.Controls.Add(Label18)
        Panel6.Controls.Add(Label20)
        Panel6.Location = New Point(33, 543)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(589, 78)
        Panel6.TabIndex = 8
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(489, 12)
        Label18.Name = "Label18"
        Label18.Size = New Size(92, 28)
        Label18.TabIndex = 5
        Label18.Text = "RM1000"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(11, 12)
        Label20.Name = "Label20"
        Label20.Size = New Size(72, 28)
        Label20.TabIndex = 5
        Label20.Text = "TOTAL"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label22)
        GroupBox1.Controls.Add(Label21)
        GroupBox1.Location = New Point(654, 131)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(457, 193)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Payment"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(176, 121)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 44)
        Button1.TabIndex = 10
        Button1.Text = "PAY"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 82)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 27)
        TextBox1.TabIndex = 8
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(56, 82)
        Label22.Name = "Label22"
        Label22.Size = New Size(44, 28)
        Label22.TabIndex = 7
        Label22.Text = "RM"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(117, 31)
        Label21.Name = "Label21"
        Label21.Size = New Size(211, 28)
        Label21.TabIndex = 6
        Label21.Text = "Enter amount to pay."
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Button_Receipt)
        GroupBox2.Controls.Add(Panel9)
        GroupBox2.Controls.Add(Panel8)
        GroupBox2.Controls.Add(Panel7)
        GroupBox2.Location = New Point(654, 342)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(457, 280)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Payment"
        ' 
        ' Button_Receipt
        ' 
        Button_Receipt.Location = New Point(127, 221)
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
        Panel9.Location = New Point(16, 36)
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
        Panel8.Location = New Point(16, 156)
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
        Panel7.Location = New Point(16, 96)
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
        ' Button_Back
        ' 
        Button_Back.Location = New Point(830, 641)
        Button_Back.Name = "Button_Back"
        Button_Back.Size = New Size(130, 55)
        Button_Back.TabIndex = 10
        Button_Back.Text = "BACK"
        Button_Back.UseVisualStyleBackColor = True
        ' 
        ' Button_Exit
        ' 
        Button_Exit.Location = New Point(966, 641)
        Button_Exit.Name = "Button_Exit"
        Button_Exit.Size = New Size(135, 55)
        Button_Exit.TabIndex = 12
        Button_Exit.Text = "EXIT"
        Button_Exit.UseVisualStyleBackColor = True
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.BackColor = Color.Transparent
        Label29.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(33, 84)
        Label29.Name = "Label29"
        Label29.Size = New Size(1613, 38)
        Label29.TabIndex = 13
        Label29.Text = "_____________________________________________________________________________________________________________________________________"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.BackColor = Color.Transparent
        Label30.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(541, 131)
        Label30.Name = "Label30"
        Label30.Size = New Size(72, 28)
        Label30.TabIndex = 14
        Label30.Text = "TOTAL"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label32)
        Panel2.Location = New Point(33, 222)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(589, 54)
        Panel2.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(502, 12)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 28)
        Label8.TabIndex = 6
        Label8.Text = "RM100"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(449, 12)
        Label9.Name = "Label9"
        Label9.Size = New Size(24, 28)
        Label9.TabIndex = 5
        Label9.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(342, 12)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 28)
        Label10.TabIndex = 5
        Label10.Text = "RM100"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label32.Location = New Point(11, 12)
        Label32.Name = "Label32"
        Label32.Size = New Size(86, 28)
        Label32.TabIndex = 5
        Label32.Text = "DELUXE"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label33)
        Panel3.Location = New Point(33, 282)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(589, 54)
        Panel3.TabIndex = 7
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(502, 12)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 28)
        Label11.TabIndex = 6
        Label11.Text = "RM100"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(449, 12)
        Label12.Name = "Label12"
        Label12.Size = New Size(24, 28)
        Label12.TabIndex = 5
        Label12.Text = "0"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(342, 12)
        Label13.Name = "Label13"
        Label13.Size = New Size(80, 28)
        Label13.TabIndex = 5
        Label13.Text = "RM100"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.Location = New Point(11, 12)
        Label33.Name = "Label33"
        Label33.Size = New Size(66, 28)
        Label33.TabIndex = 5
        Label33.Text = "TWIN"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(Label16)
        Panel4.Controls.Add(Label34)
        Panel4.Location = New Point(33, 342)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(589, 54)
        Panel4.TabIndex = 8
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(502, 12)
        Label14.Name = "Label14"
        Label14.Size = New Size(80, 28)
        Label14.TabIndex = 6
        Label14.Text = "RM100"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(449, 12)
        Label15.Name = "Label15"
        Label15.Size = New Size(24, 28)
        Label15.TabIndex = 5
        Label15.Text = "0"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(342, 12)
        Label16.Name = "Label16"
        Label16.Size = New Size(80, 28)
        Label16.TabIndex = 5
        Label16.Text = "RM100"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label34.Location = New Point(11, 12)
        Label34.Name = "Label34"
        Label34.Size = New Size(80, 28)
        Label34.TabIndex = 5
        Label34.Text = "SINGLE"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Transparent
        Panel10.Controls.Add(Label19)
        Panel10.Controls.Add(Label38)
        Panel10.Location = New Point(33, 424)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(589, 54)
        Panel10.TabIndex = 9
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(488, 14)
        Label19.Name = "Label19"
        Label19.Size = New Size(92, 28)
        Label19.TabIndex = 6
        Label19.Text = "RM1000"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label38.Location = New Point(11, 12)
        Label38.Name = "Label38"
        Label38.Size = New Size(110, 28)
        Label38.TabIndex = 5
        Label38.Text = "SUBTOTAL"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.Transparent
        Panel11.Controls.Add(Label39)
        Panel11.Controls.Add(Label40)
        Panel11.Location = New Point(33, 483)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(589, 54)
        Panel11.TabIndex = 10
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label39.Location = New Point(449, 12)
        Label39.Name = "Label39"
        Label39.Size = New Size(24, 28)
        Label39.TabIndex = 5
        Label39.Text = "0"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label40.Location = New Point(11, 12)
        Label40.Name = "Label40"
        Label40.Size = New Size(152, 28)
        Label40.TabIndex = 5
        Label40.Text = "TOTAL NIGHTS"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(24, 375)
        Label17.Name = "Label17"
        Label17.Size = New Size(905, 38)
        Label17.TabIndex = 15
        Label17.Text = "__________________________________________________________________________"
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1134, 723)
        Controls.Add(Panel11)
        Controls.Add(Panel10)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label30)
        Controls.Add(Label1)
        Controls.Add(Label29)
        Controls.Add(Button_Exit)
        Controls.Add(Button_Back)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel6)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label17)
        Name = "PaymentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button_Back As Button
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
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label17 As Label
End Class
