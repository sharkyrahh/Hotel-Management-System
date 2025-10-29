<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckIn))
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label8 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox2 = New GroupBox()
        DateTimePicker2 = New DateTimePicker()
        NumericUpDown1 = New NumericUpDown()
        DateTimePicker1 = New DateTimePicker()
        GroupBox3 = New GroupBox()
        Button5 = New Button()
        ComboBox3 = New ComboBox()
        Label1 = New Label()
        Label7 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        Label9 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label10 = New Label()
        Label16 = New Label()
        Button_Home = New Button()
        Label17 = New Label()
        Label18 = New Label()
        Button_Login = New Button()
        Button_About = New Button()
        Button_View = New Button()
        Button_Check = New Button()
        Button_Book2 = New Button()
        labelstatus = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 27F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(427, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(555, 52)
        Label2.TabIndex = 2
        Label2.Text = "Hotel Check-In Information"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(labelstatus)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(220, 192)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(489, 156)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Guest Info"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(166, 107)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 22
        Button1.Text = "Check"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(300, 29)
        TextBox1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 22)
        Label3.TabIndex = 4
        Label3.Text = "Guest IC"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(334, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 22)
        Label8.TabIndex = 9
        Label8.Text = "No of Days"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(37, 130)
        Label11.Name = "Label11"
        Label11.Size = New Size(137, 22)
        Label11.TabIndex = 12
        Label11.Text = "Check-Out Date"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(37, 37)
        Label12.Name = "Label12"
        Label12.Size = New Size(124, 22)
        Label12.TabIndex = 13
        Label12.Text = "Check-In Date"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(DateTimePicker2)
        GroupBox2.Controls.Add(NumericUpDown1)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Font = New Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(220, 398)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(489, 210)
        GroupBox2.TabIndex = 19
        GroupBox2.TabStop = False
        GroupBox2.Text = "Check-In information"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(21, 167)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(274, 28)
        DateTimePicker2.TabIndex = 17
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(333, 73)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 28)
        NumericUpDown1.TabIndex = 15
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(21, 73)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(274, 28)
        DateTimePicker1.TabIndex = 14
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(Button5)
        GroupBox3.Controls.Add(ComboBox3)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(ComboBox2)
        GroupBox3.Controls.Add(ComboBox1)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(742, 209)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(457, 248)
        GroupBox3.TabIndex = 20
        GroupBox3.TabStop = False
        GroupBox3.Text = "Room Information"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(315, 204)
        Button5.Name = "Button5"
        Button5.Size = New Size(128, 29)
        Button5.TabIndex = 6
        Button5.Text = "Update Status"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Reserved", "Unavailable", "Booked"})
        ComboBox3.Location = New Point(226, 153)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(176, 30)
        ComboBox3.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 22)
        Label1.TabIndex = 4
        Label1.Text = "Change Room Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(37, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 22)
        Label7.TabIndex = 3
        Label7.Text = "Room Number"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox2.Location = New Point(185, 105)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(176, 30)
        ComboBox2.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Deluxe", "Twin", "Single", "Standard"})
        ComboBox1.Location = New Point(184, 44)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(177, 30)
        ComboBox1.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(37, 52)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 22)
        Label6.TabIndex = 0
        Label6.Text = "Room Type"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(742, 530)
        Label9.Name = "Label9"
        Label9.Size = New Size(159, 22)
        Label9.TabIndex = 21
        Label9.Text = "Amount of Room:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(907, 530)
        Label13.Name = "Label13"
        Label13.Size = New Size(28, 22)
        Label13.TabIndex = 22
        Label13.Text = "10"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(742, 574)
        Label14.Name = "Label14"
        Label14.Size = New Size(58, 22)
        Label14.TabIndex = 23
        Label14.Text = "Total:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(907, 574)
        Label15.Name = "Label15"
        Label15.Size = New Size(28, 22)
        Label15.TabIndex = 24
        Label15.Text = "10"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button2.Location = New Point(915, 736)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 25
        Button2.Text = "Check-In"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button3.Location = New Point(1023, 736)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 26
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button4.Location = New Point(1132, 736)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 27
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 769)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 39
        Label4.Text = "Admin Login"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(47, 645)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 38
        Label5.Text = "About"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(31, 99)
        Label10.Name = "Label10"
        Label10.Size = New Size(85, 20)
        Label10.TabIndex = 37
        Label10.Text = "Homepage"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.White
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(19, 510)
        Label16.Name = "Label16"
        Label16.Size = New Size(109, 20)
        Label16.TabIndex = 36
        Label16.Text = "Check In / Out"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(-3, -1)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 30
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.White
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(21, 367)
        Label17.Name = "Label17"
        Label17.Size = New Size(103, 20)
        Label17.TabIndex = 35
        Label17.Text = "Book a Room"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.White
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(25, 243)
        Label18.Name = "Label18"
        Label18.Size = New Size(96, 20)
        Label18.TabIndex = 34
        Label18.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.BackgroundImage = My.Resources.Resources.loginicon
        Button_Login.Location = New Point(-3, 669)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(159, 137)
        Button_Login.TabIndex = 33
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Button_About
        ' 
        Button_About.Image = My.Resources.Resources.abouticon
        Button_About.Location = New Point(-3, 538)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 32
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_View
        ' 
        Button_View.Image = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(-3, 134)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 31
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Button_Check
        ' 
        Button_Check.BackgroundImage = My.Resources.Resources.checkinicon
        Button_Check.Location = New Point(-3, 404)
        Button_Check.Name = "Button_Check"
        Button_Check.Size = New Size(159, 137)
        Button_Check.TabIndex = 41
        Button_Check.UseVisualStyleBackColor = True
        ' 
        ' Button_Book2
        ' 
        Button_Book2.BackgroundImage = My.Resources.Resources.roomicon
        Button_Book2.Location = New Point(-3, 269)
        Button_Book2.Name = "Button_Book2"
        Button_Book2.Size = New Size(159, 137)
        Button_Book2.TabIndex = 40
        Button_Book2.UseVisualStyleBackColor = True
        ' 
        ' labelstatus
        ' 
        labelstatus.AutoSize = True
        labelstatus.Location = New Point(343, 110)
        labelstatus.Name = "labelstatus"
        labelstatus.Size = New Size(0, 22)
        labelstatus.TabIndex = 23
        ' 
        ' CheckIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1303, 806)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label10)
        Controls.Add(Label16)
        Controls.Add(Button_Home)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(Button_Login)
        Controls.Add(Button_About)
        Controls.Add(Button_View)
        Controls.Add(Button_Check)
        Controls.Add(Button_Book2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label9)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Name = "CheckIn"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_View As Button
    Friend WithEvents Button_Check As Button
    Friend WithEvents Button_Book2 As Button
    Friend WithEvents labelstatus As Label
End Class
