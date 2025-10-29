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
        Button_Proceed = New Button()
        CheckBox_Single = New CheckBox()
        CheckBox_Twin = New CheckBox()
        CheckBox_Deluxe = New CheckBox()
        CheckBox_Standard = New CheckBox()
        Button_Find = New Button()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label21 = New Label()
        Button_Home = New Button()
        Label22 = New Label()
        Label23 = New Label()
        Button_Login = New Button()
        Button_About = New Button()
        Button_CheckIn = New Button()
        Button_Book = New Button()
        Button_View = New Button()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Button_Select = New Button()
        Button_Clear = New Button()
        GroupBox6 = New GroupBox()
        ComboBoxYearTo = New ComboBox()
        ComboBoxMonthTo = New ComboBox()
        ComboBoxDayTo = New ComboBox()
        ComboBoxYearFrom = New ComboBox()
        ComboBoxMonthFrom = New ComboBox()
        ComboBoxDayFrom = New ComboBox()
        Label9 = New Label()
        Label20 = New Label()
        GroupBox4 = New GroupBox()
        ListBoxAvailable = New ListBox()
        ListBoxSelected = New ListBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label12 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox4.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 30F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(39, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(307, 57)
        Label1.TabIndex = 0
        Label1.Text = "Book a Room"
        ' 
        ' Button_Proceed
        ' 
        Button_Proceed.BackColor = SystemColors.Highlight
        Button_Proceed.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Button_Proceed.ForeColor = SystemColors.ControlLightLight
        Button_Proceed.Location = New Point(1165, 735)
        Button_Proceed.Name = "Button_Proceed"
        Button_Proceed.Size = New Size(126, 55)
        Button_Proceed.TabIndex = 5
        Button_Proceed.Text = "Proceed"
        Button_Proceed.UseVisualStyleBackColor = False
        ' 
        ' CheckBox_Single
        ' 
        CheckBox_Single.AutoSize = True
        CheckBox_Single.Location = New Point(591, 23)
        CheckBox_Single.Name = "CheckBox_Single"
        CheckBox_Single.Size = New Size(18, 17)
        CheckBox_Single.TabIndex = 3
        CheckBox_Single.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Twin
        ' 
        CheckBox_Twin.AutoSize = True
        CheckBox_Twin.Location = New Point(436, 23)
        CheckBox_Twin.Name = "CheckBox_Twin"
        CheckBox_Twin.Size = New Size(18, 17)
        CheckBox_Twin.TabIndex = 2
        CheckBox_Twin.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Deluxe
        ' 
        CheckBox_Deluxe.AutoSize = True
        CheckBox_Deluxe.Location = New Point(299, 23)
        CheckBox_Deluxe.Name = "CheckBox_Deluxe"
        CheckBox_Deluxe.Size = New Size(18, 17)
        CheckBox_Deluxe.TabIndex = 1
        CheckBox_Deluxe.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Standard
        ' 
        CheckBox_Standard.AutoSize = True
        CheckBox_Standard.Location = New Point(132, 22)
        CheckBox_Standard.Name = "CheckBox_Standard"
        CheckBox_Standard.Size = New Size(18, 17)
        CheckBox_Standard.TabIndex = 0
        CheckBox_Standard.UseVisualStyleBackColor = True
        ' 
        ' Button_Find
        ' 
        Button_Find.BackColor = SystemColors.Highlight
        Button_Find.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Button_Find.ForeColor = Color.GhostWhite
        Button_Find.Location = New Point(1041, 292)
        Button_Find.Name = "Button_Find"
        Button_Find.Size = New Size(161, 51)
        Button_Find.TabIndex = 9
        Button_Find.Text = "Find Room!"
        Button_Find.UseVisualStyleBackColor = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.White
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(25, 770)
        Label17.Name = "Label17"
        Label17.Size = New Size(99, 20)
        Label17.TabIndex = 25
        Label17.Text = "Admin Login"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.White
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(48, 642)
        Label18.Name = "Label18"
        Label18.Size = New Size(53, 20)
        Label18.TabIndex = 24
        Label18.Text = "About"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.White
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(33, 100)
        Label19.Name = "Label19"
        Label19.Size = New Size(85, 20)
        Label19.TabIndex = 23
        Label19.Text = "Homepage"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.White
        Label21.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(21, 511)
        Label21.Name = "Label21"
        Label21.Size = New Size(109, 20)
        Label21.TabIndex = 22
        Label21.Text = "Check In / Out"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(-1, 0)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 14
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.BackColor = Color.White
        Label22.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(23, 368)
        Label22.Name = "Label22"
        Label22.Size = New Size(103, 20)
        Label22.TabIndex = 21
        Label22.Text = "Book a Room"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.BackColor = Color.White
        Label23.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(27, 244)
        Label23.Name = "Label23"
        Label23.Size = New Size(96, 20)
        Label23.TabIndex = 20
        Label23.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.BackgroundImage = My.Resources.Resources.loginicon
        Button_Login.Location = New Point(-1, 670)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(159, 137)
        Button_Login.TabIndex = 19
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Button_About
        ' 
        Button_About.BackgroundImage = My.Resources.Resources.abouticon
        Button_About.Location = New Point(-1, 539)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 18
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_CheckIn
        ' 
        Button_CheckIn.BackgroundImage = My.Resources.Resources.checkinicon
        Button_CheckIn.Location = New Point(-1, 405)
        Button_CheckIn.Name = "Button_CheckIn"
        Button_CheckIn.Size = New Size(159, 137)
        Button_CheckIn.TabIndex = 17
        Button_CheckIn.UseVisualStyleBackColor = True
        ' 
        ' Button_Book
        ' 
        Button_Book.BackgroundImage = My.Resources.Resources.roomicon
        Button_Book.Location = New Point(-1, 270)
        Button_Book.Name = "Button_Book"
        Button_Book.Size = New Size(159, 137)
        Button_Book.TabIndex = 15
        Button_Book.UseVisualStyleBackColor = True
        ' 
        ' Button_View
        ' 
        Button_View.BackgroundImage = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(-1, 135)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 16
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(362, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 35)
        Label2.TabIndex = 13
        Label2.Text = "Date"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.GradientInactiveCaption
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(CheckBox_Single)
        GroupBox1.Controls.Add(CheckBox_Twin)
        GroupBox1.Controls.Add(CheckBox_Deluxe)
        GroupBox1.Controls.Add(CheckBox_Standard)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBox1.ForeColor = SystemColors.HotTrack
        GroupBox1.Location = New Point(419, 251)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(649, 55)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.HotTrack
        Label8.Location = New Point(521, 13)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 28)
        Label8.TabIndex = 4
        Label8.Text = "Single"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.HotTrack
        Label6.Location = New Point(382, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 28)
        Label6.TabIndex = 3
        Label6.Text = "Twin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(218, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 28)
        Label5.TabIndex = 2
        Label5.Text = "Deluxe"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(34, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 28)
        Label3.TabIndex = 1
        Label3.Text = "Standard"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(362, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 28)
        Label4.TabIndex = 26
        Label4.Text = "Room Type"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.HotTrack
        Label7.Location = New Point(225, 359)
        Label7.Name = "Label7"
        Label7.Size = New Size(209, 35)
        Label7.TabIndex = 29
        Label7.Text = "Available Rooms"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.HotTrack
        Label10.Location = New Point(738, 359)
        Label10.Name = "Label10"
        Label10.Size = New Size(201, 35)
        Label10.TabIndex = 30
        Label10.Text = "Selected Rooms"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.Control
        Label11.Location = New Point(197, 311)
        Label11.Name = "Label11"
        Label11.Size = New Size(1055, 35)
        Label11.TabIndex = 31
        Label11.Text = "________________________________________________________________________________________________________"
        ' 
        ' Button_Select
        ' 
        Button_Select.BackColor = SystemColors.Highlight
        Button_Select.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Button_Select.ForeColor = SystemColors.Window
        Button_Select.Location = New Point(260, 737)
        Button_Select.Name = "Button_Select"
        Button_Select.Size = New Size(126, 55)
        Button_Select.TabIndex = 32
        Button_Select.Text = "Select"
        Button_Select.UseVisualStyleBackColor = False
        ' 
        ' Button_Clear
        ' 
        Button_Clear.BackColor = SystemColors.Highlight
        Button_Clear.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Button_Clear.ForeColor = SystemColors.Control
        Button_Clear.Location = New Point(763, 735)
        Button_Clear.Name = "Button_Clear"
        Button_Clear.Size = New Size(126, 55)
        Button_Clear.TabIndex = 33
        Button_Clear.Text = "Clear"
        Button_Clear.UseVisualStyleBackColor = False
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = SystemColors.GradientInactiveCaption
        GroupBox6.Controls.Add(ComboBoxYearTo)
        GroupBox6.Controls.Add(ComboBoxMonthTo)
        GroupBox6.Controls.Add(ComboBoxDayTo)
        GroupBox6.Controls.Add(ComboBoxYearFrom)
        GroupBox6.Controls.Add(ComboBoxMonthFrom)
        GroupBox6.Controls.Add(ComboBoxDayFrom)
        GroupBox6.Controls.Add(Label9)
        GroupBox6.Controls.Add(Label20)
        GroupBox6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBox6.ForeColor = SystemColors.HotTrack
        GroupBox6.Location = New Point(38, 20)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(680, 121)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        ' 
        ' ComboBoxYearTo
        ' 
        ComboBoxYearTo.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ComboBoxYearTo.FormattingEnabled = True
        ComboBoxYearTo.Items.AddRange(New Object() {"2025", "2026"})
        ComboBoxYearTo.Location = New Point(508, 73)
        ComboBoxYearTo.Name = "ComboBoxYearTo"
        ComboBoxYearTo.Size = New Size(165, 36)
        ComboBoxYearTo.TabIndex = 12
        ' 
        ' ComboBoxMonthTo
        ' 
        ComboBoxMonthTo.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ComboBoxMonthTo.FormattingEnabled = True
        ComboBoxMonthTo.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        ComboBoxMonthTo.Location = New Point(249, 73)
        ComboBoxMonthTo.Name = "ComboBoxMonthTo"
        ComboBoxMonthTo.Size = New Size(240, 36)
        ComboBoxMonthTo.TabIndex = 11
        ' 
        ' ComboBoxDayTo
        ' 
        ComboBoxDayTo.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ComboBoxDayTo.FormattingEnabled = True
        ComboBoxDayTo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        ComboBoxDayTo.Location = New Point(98, 73)
        ComboBoxDayTo.Name = "ComboBoxDayTo"
        ComboBoxDayTo.Size = New Size(126, 36)
        ComboBoxDayTo.TabIndex = 10
        ' 
        ' ComboBoxYearFrom
        ' 
        ComboBoxYearFrom.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ComboBoxYearFrom.FormattingEnabled = True
        ComboBoxYearFrom.Items.AddRange(New Object() {"2025", "2026"})
        ComboBoxYearFrom.Location = New Point(509, 14)
        ComboBoxYearFrom.Name = "ComboBoxYearFrom"
        ComboBoxYearFrom.Size = New Size(165, 36)
        ComboBoxYearFrom.TabIndex = 6
        ' 
        ' ComboBoxMonthFrom
        ' 
        ComboBoxMonthFrom.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ComboBoxMonthFrom.FormattingEnabled = True
        ComboBoxMonthFrom.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        ComboBoxMonthFrom.Location = New Point(249, 14)
        ComboBoxMonthFrom.Name = "ComboBoxMonthFrom"
        ComboBoxMonthFrom.Size = New Size(240, 36)
        ComboBoxMonthFrom.TabIndex = 4
        ' 
        ' ComboBoxDayFrom
        ' 
        ComboBoxDayFrom.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ComboBoxDayFrom.FormattingEnabled = True
        ComboBoxDayFrom.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        ComboBoxDayFrom.Location = New Point(98, 14)
        ComboBoxDayFrom.Name = "ComboBoxDayFrom"
        ComboBoxDayFrom.Size = New Size(126, 36)
        ComboBoxDayFrom.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.HotTrack
        Label9.Location = New Point(22, 76)
        Label9.Name = "Label9"
        Label9.Size = New Size(34, 28)
        Label9.TabIndex = 1
        Label9.Text = "To"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label20.ForeColor = SystemColors.HotTrack
        Label20.Location = New Point(22, 19)
        Label20.Name = "Label20"
        Label20.Size = New Size(60, 28)
        Label20.TabIndex = 0
        Label20.Text = "From"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Transparent
        GroupBox4.Controls.Add(GroupBox6)
        GroupBox4.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(350, 91)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(765, 233)
        GroupBox4.TabIndex = 28
        GroupBox4.TabStop = False
        ' 
        ' ListBoxAvailable
        ' 
        ListBoxAvailable.Font = New Font("Segoe UI", 12F)
        ListBoxAvailable.FormattingEnabled = True
        ListBoxAvailable.ItemHeight = 28
        ListBoxAvailable.Location = New Point(272, 406)
        ListBoxAvailable.Name = "ListBoxAvailable"
        ListBoxAvailable.Size = New Size(360, 312)
        ListBoxAvailable.TabIndex = 0
        ' 
        ' ListBoxSelected
        ' 
        ListBoxSelected.Font = New Font("Segoe UI", 12F)
        ListBoxSelected.FormattingEnabled = True
        ListBoxSelected.ItemHeight = 28
        ListBoxSelected.Location = New Point(774, 406)
        ListBoxSelected.Name = "ListBoxSelected"
        ListBoxSelected.Size = New Size(360, 312)
        ListBoxSelected.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(158, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1159, 105)
        Panel1.TabIndex = 34
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientInactiveCaption
        Panel2.Location = New Point(260, 398)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(384, 333)
        Panel2.TabIndex = 35
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientInactiveCaption
        Panel3.Location = New Point(763, 398)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(384, 333)
        Panel3.TabIndex = 36
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label12.ForeColor = SystemColors.HotTrack
        Label12.Location = New Point(156, 316)
        Label12.Name = "Label12"
        Label12.Size = New Size(1195, 35)
        Label12.TabIndex = 37
        Label12.Text = "______________________________________________________________________________________________________________________"
        ' 
        ' BookForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1303, 806)
        Controls.Add(ListBoxSelected)
        Controls.Add(ListBoxAvailable)
        Controls.Add(Button_Clear)
        Controls.Add(Button_Select)
        Controls.Add(Label10)
        Controls.Add(Label7)
        Controls.Add(Button_Find)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(Label21)
        Controls.Add(Button_Home)
        Controls.Add(Label22)
        Controls.Add(Label23)
        Controls.Add(Button_Login)
        Controls.Add(Button_About)
        Controls.Add(Button_CheckIn)
        Controls.Add(Button_Book)
        Controls.Add(Button_View)
        Controls.Add(Button_Proceed)
        Controls.Add(Label11)
        Controls.Add(GroupBox4)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Label12)
        Name = "BookForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Book a Room"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Proceed As Button
    Friend WithEvents CheckBox_Single As CheckBox
    Friend WithEvents CheckBox_Twin As CheckBox
    Friend WithEvents CheckBox_Deluxe As CheckBox
    Friend WithEvents CheckBox_Standard As CheckBox
    Friend WithEvents Button_Find As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_CheckIn As Button
    Friend WithEvents Button_Book As Button
    Friend WithEvents Button_View As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button_Select As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ComboBoxYearTo As ComboBox
    Friend WithEvents ComboBoxMonthTo As ComboBox
    Friend WithEvents ComboBoxDayTo As ComboBox
    Friend WithEvents ComboBoxYearFrom As ComboBox
    Friend WithEvents ComboBoxMonthFrom As ComboBox
    Friend WithEvents ComboBoxDayFrom As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ListBoxAvailable As ListBox
    Friend WithEvents ListBoxSelected As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
End Class
