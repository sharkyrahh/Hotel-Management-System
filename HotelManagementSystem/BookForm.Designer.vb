<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookForm
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
        GroupBox1 = New GroupBox()
        Label_RoomDesc = New Label()
        Label_RoomType = New Label()
        GroupBox2 = New GroupBox()
        Label_NumOfNights = New Label()
        TextBox_Phone = New TextBox()
        TextBox_Name = New TextBox()
        Label8 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox3 = New GroupBox()
        Button_Calc = New Button()
        Label_Total = New Label()
        Button1 = New Button()
        GroupBox_Rooms = New GroupBox()
        Panel_SingleAvail = New Panel()
        Label12 = New Label()
        CheckBox_Single = New CheckBox()
        Panel_TwinAvail = New Panel()
        Label11 = New Label()
        CheckBox_Twin = New CheckBox()
        Panel_DeluxeAvail = New Panel()
        Label10 = New Label()
        CheckBox_Deluxe = New CheckBox()
        Panel_StandardAvail = New Panel()
        Label7 = New Label()
        CheckBox_Standard = New CheckBox()
        Button_Next = New Button()
        Button_Prev = New Button()
        GroupBox_RoomNumber = New GroupBox()
        Panel_Single = New Panel()
        Label_Single = New Label()
        TextBox_Single = New TextBox()
        Panel_Twin = New Panel()
        Label_Twin = New Label()
        TextBox_Twin = New TextBox()
        Panel_Deluxe = New Panel()
        Label_Deluxe = New Label()
        TextBox_Deluxe = New TextBox()
        Panel_Standard = New Panel()
        Label_Standard = New Label()
        TextBox_Standard = New TextBox()
        GroupBox6 = New GroupBox()
        Button_Find = New Button()
        ComboBox6 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        Label20 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label13 = New Label()
        Button_Home = New Button()
        Label14 = New Label()
        Label15 = New Label()
        Button_Login = New Button()
        Button_About = New Button()
        Button_CheckIn = New Button()
        Button_Book = New Button()
        Button_View = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox_Rooms.SuspendLayout()
        Panel_SingleAvail.SuspendLayout()
        Panel_TwinAvail.SuspendLayout()
        Panel_DeluxeAvail.SuspendLayout()
        Panel_StandardAvail.SuspendLayout()
        GroupBox_RoomNumber.SuspendLayout()
        Panel_Single.SuspendLayout()
        Panel_Twin.SuspendLayout()
        Panel_Deluxe.SuspendLayout()
        Panel_Standard.SuspendLayout()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 40.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(222, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(414, 75)
        Label1.TabIndex = 0
        Label1.Text = "Book a Room"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.GradientInactiveCaption
        GroupBox1.Controls.Add(Label_RoomDesc)
        GroupBox1.Controls.Add(Label_RoomType)
        GroupBox1.Location = New Point(1030, 106)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 215)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' Label_RoomDesc
        ' 
        Label_RoomDesc.AutoSize = True
        Label_RoomDesc.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_RoomDesc.ForeColor = SystemColors.HotTrack
        Label_RoomDesc.Location = New Point(20, 112)
        Label_RoomDesc.Name = "Label_RoomDesc"
        Label_RoomDesc.Size = New Size(212, 28)
        Label_RoomDesc.TabIndex = 1
        Label_RoomDesc.Text = "Includes 1 queen bed."
        ' 
        ' Label_RoomType
        ' 
        Label_RoomType.AutoSize = True
        Label_RoomType.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label_RoomType.ForeColor = SystemColors.Highlight
        Label_RoomType.Location = New Point(24, 67)
        Label_RoomType.Name = "Label_RoomType"
        Label_RoomType.Size = New Size(196, 35)
        Label_RoomType.TabIndex = 0
        Label_RoomType.Text = "Standard Room"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.GradientInactiveCaption
        GroupBox2.Controls.Add(Label_NumOfNights)
        GroupBox2.Controls.Add(TextBox_Phone)
        GroupBox2.Controls.Add(TextBox_Name)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.HotTrack
        GroupBox2.Location = New Point(614, 338)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(366, 206)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Customer Details"
        ' 
        ' Label_NumOfNights
        ' 
        Label_NumOfNights.AutoSize = True
        Label_NumOfNights.Location = New Point(170, 140)
        Label_NumOfNights.Name = "Label_NumOfNights"
        Label_NumOfNights.Size = New Size(27, 20)
        Label_NumOfNights.TabIndex = 6
        Label_NumOfNights.Text = "00"
        ' 
        ' TextBox_Phone
        ' 
        TextBox_Phone.Location = New Point(170, 93)
        TextBox_Phone.Name = "TextBox_Phone"
        TextBox_Phone.Size = New Size(162, 27)
        TextBox_Phone.TabIndex = 5
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Location = New Point(170, 53)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.Size = New Size(162, 27)
        TextBox_Name.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 95)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 20)
        Label8.TabIndex = 2
        Label8.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 20)
        Label4.TabIndex = 1
        Label4.Text = "Number of Nights"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 20)
        Label5.TabIndex = 0
        Label5.Text = "Name"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.GradientInactiveCaption
        GroupBox3.Controls.Add(Button_Calc)
        GroupBox3.Controls.Add(Label_Total)
        GroupBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = SystemColors.MenuHighlight
        GroupBox3.Location = New Point(614, 567)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(666, 107)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Total Price"
        ' 
        ' Button_Calc
        ' 
        Button_Calc.BackColor = SystemColors.GradientInactiveCaption
        Button_Calc.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Calc.ForeColor = SystemColors.HotTrack
        Button_Calc.Location = New Point(547, 65)
        Button_Calc.Name = "Button_Calc"
        Button_Calc.Size = New Size(113, 37)
        Button_Calc.TabIndex = 9
        Button_Calc.Text = "CALCULATE"
        Button_Calc.UseVisualStyleBackColor = False
        ' 
        ' Label_Total
        ' 
        Label_Total.AutoSize = True
        Label_Total.Font = New Font("Segoe UI", 30F)
        Label_Total.Location = New Point(241, 26)
        Label_Total.Name = "Label_Total"
        Label_Total.Size = New Size(131, 67)
        Label_Total.TabIndex = 1
        Label_Total.Text = "RM0"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.GradientInactiveCaption
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.HotTrack
        Button1.Location = New Point(1030, 702)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 55)
        Button1.TabIndex = 5
        Button1.Text = "BOOK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' GroupBox_Rooms
        ' 
        GroupBox_Rooms.Controls.Add(Panel_SingleAvail)
        GroupBox_Rooms.Controls.Add(Panel_TwinAvail)
        GroupBox_Rooms.Controls.Add(Panel_DeluxeAvail)
        GroupBox_Rooms.Controls.Add(Panel_StandardAvail)
        GroupBox_Rooms.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox_Rooms.ForeColor = SystemColors.HotTrack
        GroupBox_Rooms.Location = New Point(254, 492)
        GroupBox_Rooms.Name = "GroupBox_Rooms"
        GroupBox_Rooms.Size = New Size(341, 265)
        GroupBox_Rooms.TabIndex = 3
        GroupBox_Rooms.TabStop = False
        GroupBox_Rooms.Text = "Available Rooms"
        GroupBox_Rooms.Visible = False
        ' 
        ' Panel_SingleAvail
        ' 
        Panel_SingleAvail.BackColor = SystemColors.Desktop
        Panel_SingleAvail.Controls.Add(Label12)
        Panel_SingleAvail.Controls.Add(CheckBox_Single)
        Panel_SingleAvail.Location = New Point(15, 198)
        Panel_SingleAvail.Name = "Panel_SingleAvail"
        Panel_SingleAvail.Size = New Size(310, 47)
        Panel_SingleAvail.TabIndex = 2
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(14, 14)
        Label12.Name = "Label12"
        Label12.Size = New Size(97, 20)
        Label12.TabIndex = 5
        Label12.Text = "Single Room"
        ' 
        ' CheckBox_Single
        ' 
        CheckBox_Single.AutoSize = True
        CheckBox_Single.Location = New Point(278, 15)
        CheckBox_Single.Name = "CheckBox_Single"
        CheckBox_Single.Size = New Size(18, 17)
        CheckBox_Single.TabIndex = 3
        CheckBox_Single.UseVisualStyleBackColor = True
        ' 
        ' Panel_TwinAvail
        ' 
        Panel_TwinAvail.BackColor = SystemColors.ActiveCaption
        Panel_TwinAvail.Controls.Add(Label11)
        Panel_TwinAvail.Controls.Add(CheckBox_Twin)
        Panel_TwinAvail.Location = New Point(15, 140)
        Panel_TwinAvail.Name = "Panel_TwinAvail"
        Panel_TwinAvail.Size = New Size(310, 47)
        Panel_TwinAvail.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(14, 17)
        Label11.Name = "Label11"
        Label11.Size = New Size(88, 20)
        Label11.TabIndex = 4
        Label11.Text = "Twin Room"
        ' 
        ' CheckBox_Twin
        ' 
        CheckBox_Twin.AutoSize = True
        CheckBox_Twin.Location = New Point(278, 14)
        CheckBox_Twin.Name = "CheckBox_Twin"
        CheckBox_Twin.Size = New Size(18, 17)
        CheckBox_Twin.TabIndex = 2
        CheckBox_Twin.UseVisualStyleBackColor = True
        ' 
        ' Panel_DeluxeAvail
        ' 
        Panel_DeluxeAvail.BackColor = SystemColors.GradientActiveCaption
        Panel_DeluxeAvail.Controls.Add(Label10)
        Panel_DeluxeAvail.Controls.Add(CheckBox_Deluxe)
        Panel_DeluxeAvail.Location = New Point(15, 83)
        Panel_DeluxeAvail.Name = "Panel_DeluxeAvail"
        Panel_DeluxeAvail.Size = New Size(310, 47)
        Panel_DeluxeAvail.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(14, 15)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 20)
        Label10.TabIndex = 3
        Label10.Text = "Deluxe Room"
        ' 
        ' CheckBox_Deluxe
        ' 
        CheckBox_Deluxe.AutoSize = True
        CheckBox_Deluxe.Location = New Point(278, 18)
        CheckBox_Deluxe.Name = "CheckBox_Deluxe"
        CheckBox_Deluxe.Size = New Size(18, 17)
        CheckBox_Deluxe.TabIndex = 1
        CheckBox_Deluxe.UseVisualStyleBackColor = True
        ' 
        ' Panel_StandardAvail
        ' 
        Panel_StandardAvail.BackColor = SystemColors.GradientInactiveCaption
        Panel_StandardAvail.Controls.Add(Label7)
        Panel_StandardAvail.Controls.Add(CheckBox_Standard)
        Panel_StandardAvail.Location = New Point(15, 26)
        Panel_StandardAvail.Name = "Panel_StandardAvail"
        Panel_StandardAvail.Size = New Size(310, 47)
        Panel_StandardAvail.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 20)
        Label7.TabIndex = 2
        Label7.Text = "Standard Room"
        ' 
        ' CheckBox_Standard
        ' 
        CheckBox_Standard.AutoSize = True
        CheckBox_Standard.Location = New Point(278, 18)
        CheckBox_Standard.Name = "CheckBox_Standard"
        CheckBox_Standard.Size = New Size(18, 17)
        CheckBox_Standard.TabIndex = 0
        CheckBox_Standard.UseVisualStyleBackColor = True
        ' 
        ' Button_Next
        ' 
        Button_Next.BackColor = SystemColors.GradientInactiveCaption
        Button_Next.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Next.ForeColor = SystemColors.HotTrack
        Button_Next.Location = New Point(952, 191)
        Button_Next.Name = "Button_Next"
        Button_Next.Size = New Size(50, 55)
        Button_Next.TabIndex = 7
        Button_Next.Text = "->"
        Button_Next.UseVisualStyleBackColor = False
        ' 
        ' Button_Prev
        ' 
        Button_Prev.BackColor = SystemColors.GradientInactiveCaption
        Button_Prev.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Prev.ForeColor = SystemColors.HotTrack
        Button_Prev.Location = New Point(212, 191)
        Button_Prev.Name = "Button_Prev"
        Button_Prev.Size = New Size(50, 55)
        Button_Prev.TabIndex = 8
        Button_Prev.Text = "<-"
        Button_Prev.UseVisualStyleBackColor = False
        ' 
        ' GroupBox_RoomNumber
        ' 
        GroupBox_RoomNumber.BackColor = SystemColors.GradientInactiveCaption
        GroupBox_RoomNumber.Controls.Add(Panel_Single)
        GroupBox_RoomNumber.Controls.Add(Panel_Twin)
        GroupBox_RoomNumber.Controls.Add(Panel_Deluxe)
        GroupBox_RoomNumber.Controls.Add(Panel_Standard)
        GroupBox_RoomNumber.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox_RoomNumber.ForeColor = SystemColors.HotTrack
        GroupBox_RoomNumber.Location = New Point(998, 338)
        GroupBox_RoomNumber.Name = "GroupBox_RoomNumber"
        GroupBox_RoomNumber.Size = New Size(282, 206)
        GroupBox_RoomNumber.TabIndex = 8
        GroupBox_RoomNumber.TabStop = False
        GroupBox_RoomNumber.Text = "Number of Rooms"
        GroupBox_RoomNumber.Visible = False
        ' 
        ' Panel_Single
        ' 
        Panel_Single.Controls.Add(Label_Single)
        Panel_Single.Controls.Add(TextBox_Single)
        Panel_Single.Location = New Point(13, 156)
        Panel_Single.Name = "Panel_Single"
        Panel_Single.Size = New Size(250, 35)
        Panel_Single.TabIndex = 5
        Panel_Single.Visible = False
        ' 
        ' Label_Single
        ' 
        Label_Single.AutoSize = True
        Label_Single.Location = New Point(3, 8)
        Label_Single.Name = "Label_Single"
        Label_Single.Size = New Size(51, 20)
        Label_Single.TabIndex = 0
        Label_Single.Text = "Single"
        ' 
        ' TextBox_Single
        ' 
        TextBox_Single.Location = New Point(210, 5)
        TextBox_Single.Name = "TextBox_Single"
        TextBox_Single.Size = New Size(36, 27)
        TextBox_Single.TabIndex = 4
        ' 
        ' Panel_Twin
        ' 
        Panel_Twin.Controls.Add(Label_Twin)
        Panel_Twin.Controls.Add(TextBox_Twin)
        Panel_Twin.Location = New Point(13, 115)
        Panel_Twin.Name = "Panel_Twin"
        Panel_Twin.Size = New Size(250, 35)
        Panel_Twin.TabIndex = 5
        Panel_Twin.Visible = False
        ' 
        ' Label_Twin
        ' 
        Label_Twin.AutoSize = True
        Label_Twin.Location = New Point(3, 8)
        Label_Twin.Name = "Label_Twin"
        Label_Twin.Size = New Size(42, 20)
        Label_Twin.TabIndex = 0
        Label_Twin.Text = "Twin"
        ' 
        ' TextBox_Twin
        ' 
        TextBox_Twin.Location = New Point(210, 5)
        TextBox_Twin.Name = "TextBox_Twin"
        TextBox_Twin.Size = New Size(36, 27)
        TextBox_Twin.TabIndex = 4
        ' 
        ' Panel_Deluxe
        ' 
        Panel_Deluxe.Controls.Add(Label_Deluxe)
        Panel_Deluxe.Controls.Add(TextBox_Deluxe)
        Panel_Deluxe.Location = New Point(13, 74)
        Panel_Deluxe.Name = "Panel_Deluxe"
        Panel_Deluxe.Size = New Size(250, 35)
        Panel_Deluxe.TabIndex = 5
        Panel_Deluxe.Visible = False
        ' 
        ' Label_Deluxe
        ' 
        Label_Deluxe.AutoSize = True
        Label_Deluxe.Location = New Point(3, 8)
        Label_Deluxe.Name = "Label_Deluxe"
        Label_Deluxe.Size = New Size(57, 20)
        Label_Deluxe.TabIndex = 0
        Label_Deluxe.Text = "Deluxe"
        ' 
        ' TextBox_Deluxe
        ' 
        TextBox_Deluxe.Location = New Point(210, 5)
        TextBox_Deluxe.Name = "TextBox_Deluxe"
        TextBox_Deluxe.Size = New Size(36, 27)
        TextBox_Deluxe.TabIndex = 4
        ' 
        ' Panel_Standard
        ' 
        Panel_Standard.Controls.Add(Label_Standard)
        Panel_Standard.Controls.Add(TextBox_Standard)
        Panel_Standard.Location = New Point(13, 33)
        Panel_Standard.Name = "Panel_Standard"
        Panel_Standard.Size = New Size(250, 35)
        Panel_Standard.TabIndex = 2
        Panel_Standard.Visible = False
        ' 
        ' Label_Standard
        ' 
        Label_Standard.AutoSize = True
        Label_Standard.Location = New Point(3, 8)
        Label_Standard.Name = "Label_Standard"
        Label_Standard.Size = New Size(72, 20)
        Label_Standard.TabIndex = 0
        Label_Standard.Text = "Standard"
        ' 
        ' TextBox_Standard
        ' 
        TextBox_Standard.Location = New Point(210, 5)
        TextBox_Standard.Name = "TextBox_Standard"
        TextBox_Standard.Size = New Size(36, 27)
        TextBox_Standard.TabIndex = 4
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = SystemColors.GradientInactiveCaption
        GroupBox6.Controls.Add(Button_Find)
        GroupBox6.Controls.Add(ComboBox6)
        GroupBox6.Controls.Add(ComboBox5)
        GroupBox6.Controls.Add(ComboBox4)
        GroupBox6.Controls.Add(ComboBox3)
        GroupBox6.Controls.Add(ComboBox2)
        GroupBox6.Controls.Add(ComboBox1)
        GroupBox6.Controls.Add(Label9)
        GroupBox6.Controls.Add(Label20)
        GroupBox6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox6.ForeColor = SystemColors.HotTrack
        GroupBox6.Location = New Point(254, 338)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(341, 147)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        GroupBox6.Text = "Date"
        ' 
        ' Button_Find
        ' 
        Button_Find.BackColor = SystemColors.GradientInactiveCaption
        Button_Find.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Find.ForeColor = SystemColors.HotTrack
        Button_Find.Location = New Point(226, 109)
        Button_Find.Name = "Button_Find"
        Button_Find.Size = New Size(99, 32)
        Button_Find.TabIndex = 9
        Button_Find.Text = "Find Room"
        Button_Find.UseVisualStyleBackColor = False
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"2025", "2026"})
        ComboBox6.Location = New Point(253, 70)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(64, 28)
        ComboBox6.TabIndex = 7
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"2025", "2026"})
        ComboBox5.Location = New Point(253, 26)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(64, 28)
        ComboBox5.TabIndex = 6
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        ComboBox4.Location = New Point(130, 70)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(117, 28)
        ComboBox4.TabIndex = 5
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        ComboBox3.Location = New Point(130, 26)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(117, 28)
        ComboBox3.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        ComboBox2.Location = New Point(69, 70)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(55, 28)
        ComboBox2.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        ComboBox1.Location = New Point(69, 26)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(55, 28)
        ComboBox1.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(21, 73)
        Label9.Name = "Label9"
        Label9.Size = New Size(26, 20)
        Label9.TabIndex = 1
        Label9.Text = "To"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(17, 33)
        Label20.Name = "Label20"
        Label20.Size = New Size(46, 20)
        Label20.TabIndex = 0
        Label20.Text = "From"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 769)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 37
        Label2.Text = "Admin Login"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(49, 641)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 36
        Label6.Text = "About"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(34, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 35
        Label3.Text = "Homepage"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.White
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(22, 510)
        Label13.Name = "Label13"
        Label13.Size = New Size(109, 20)
        Label13.TabIndex = 34
        Label13.Text = "Check In / Out"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(0, -1)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 26
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.White
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(24, 367)
        Label14.Name = "Label14"
        Label14.Size = New Size(103, 20)
        Label14.TabIndex = 33
        Label14.Text = "Book a Room"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.White
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(28, 243)
        Label15.Name = "Label15"
        Label15.Size = New Size(96, 20)
        Label15.TabIndex = 32
        Label15.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.BackgroundImage = My.Resources.Resources.loginicon__1_
        Button_Login.Location = New Point(0, 669)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(159, 137)
        Button_Login.TabIndex = 31
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Button_About
        ' 
        Button_About.BackgroundImage = My.Resources.Resources.abouticon
        Button_About.Location = New Point(0, 538)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 30
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_CheckIn
        ' 
        Button_CheckIn.BackgroundImage = My.Resources.Resources.checkinicon
        Button_CheckIn.Location = New Point(0, 404)
        Button_CheckIn.Name = "Button_CheckIn"
        Button_CheckIn.Size = New Size(159, 137)
        Button_CheckIn.TabIndex = 29
        Button_CheckIn.UseVisualStyleBackColor = True
        ' 
        ' Button_Book
        ' 
        Button_Book.BackgroundImage = My.Resources.Resources.roomicon
        Button_Book.Location = New Point(0, 269)
        Button_Book.Name = "Button_Book"
        Button_Book.Size = New Size(159, 137)
        Button_Book.TabIndex = 27
        Button_Book.UseVisualStyleBackColor = True
        ' 
        ' Button_View
        ' 
        Button_View.BackgroundImage = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(0, 134)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 28
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' BookForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1303, 806)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label13)
        Controls.Add(Button_Home)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Button_Login)
        Controls.Add(Button_About)
        Controls.Add(Button_CheckIn)
        Controls.Add(Button_Book)
        Controls.Add(Button_View)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox_RoomNumber)
        Controls.Add(Button_Prev)
        Controls.Add(Button_Next)
        Controls.Add(GroupBox_Rooms)
        Controls.Add(Button1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "BookForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Book a Room"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox_Rooms.ResumeLayout(False)
        Panel_SingleAvail.ResumeLayout(False)
        Panel_SingleAvail.PerformLayout()
        Panel_TwinAvail.ResumeLayout(False)
        Panel_TwinAvail.PerformLayout()
        Panel_DeluxeAvail.ResumeLayout(False)
        Panel_DeluxeAvail.PerformLayout()
        Panel_StandardAvail.ResumeLayout(False)
        Panel_StandardAvail.PerformLayout()
        GroupBox_RoomNumber.ResumeLayout(False)
        Panel_Single.ResumeLayout(False)
        Panel_Single.PerformLayout()
        Panel_Twin.ResumeLayout(False)
        Panel_Twin.PerformLayout()
        Panel_Deluxe.ResumeLayout(False)
        Panel_Deluxe.PerformLayout()
        Panel_Standard.ResumeLayout(False)
        Panel_Standard.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label_RoomDesc As Label
    Friend WithEvents Label_RoomType As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label_Total As Label
    Friend WithEvents TextBox_Phone As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox_Rooms As GroupBox
    Friend WithEvents Button_Next As Button
    Friend WithEvents Button_Prev As Button
    Friend WithEvents Panel_DeluxeAvail As Panel
    Friend WithEvents Panel_StandardAvail As Panel
    Friend WithEvents Panel_SingleAvail As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckBox_Single As CheckBox
    Friend WithEvents Panel_TwinAvail As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBox_Twin As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox_Deluxe As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox_Standard As CheckBox
    Friend WithEvents GroupBox_RoomNumber As GroupBox
    Friend WithEvents TextBox_Standard As TextBox
    Friend WithEvents Label_Standard As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button_Find As Button
    Friend WithEvents Label_NumOfNights As Label
    Friend WithEvents Button_Calc As Button
    Friend WithEvents Panel_Standard As Panel
    Friend WithEvents Panel_Single As Panel
    Friend WithEvents Label_Single As Label
    Friend WithEvents TextBox_Single As TextBox
    Friend WithEvents Panel_Twin As Panel
    Friend WithEvents Label_Twin As Label
    Friend WithEvents TextBox_Twin As TextBox
    Friend WithEvents Panel_Deluxe As Panel
    Friend WithEvents Label_Deluxe As Label
    Friend WithEvents TextBox_Deluxe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_CheckIn As Button
    Friend WithEvents Button_Book As Button
    Friend WithEvents Button_View As Button
End Class
