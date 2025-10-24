<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOut))
        Button5 = New Button()
        Label1 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label15 = New Label()
        Label14 = New Label()
        ComboBox3 = New ComboBox()
        Label7 = New Label()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        DateTimePicker2 = New DateTimePicker()
        GroupBox2 = New GroupBox()
        Label11 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Button6 = New Button()
        Label4 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Button_Home = New Button()
        Label9 = New Label()
        Label10 = New Label()
        Button_Login = New Button()
        Button_About = New Button()
        Button_View = New Button()
        Button_Check = New Button()
        Button_Book2 = New Button()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(303, 249)
        Button5.Name = "Button5"
        Button5.Size = New Size(128, 29)
        Button5.TabIndex = 6
        Button5.Text = "Update Status"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 22)
        Label1.TabIndex = 4
        Label1.Text = "Change Room Status"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button4.Location = New Point(1118, 736)
        Button4.Name = "Button4"
        Button4.Size = New Size(103, 29)
        Button4.TabIndex = 38
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button3.Location = New Point(999, 736)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 29)
        Button3.TabIndex = 37
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button2.Location = New Point(860, 736)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 29)
        Button2.TabIndex = 36
        Button2.Text = "Check-Out"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Label15.Location = New Point(485, 549)
        Label15.Name = "Label15"
        Label15.Size = New Size(91, 22)
        Label15.TabIndex = 35
        Label15.Text = "RM100.00"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Label14.Location = New Point(390, 549)
        Label14.Name = "Label14"
        Label14.Size = New Size(58, 22)
        Label14.TabIndex = 34
        Label14.Text = "Total:"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Reserved", "Unavailable", "Booked"})
        ComboBox3.Location = New Point(230, 197)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(176, 30)
        ComboBox3.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 136)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 22)
        Label7.TabIndex = 3
        Label7.Text = "Room Number"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox2.Location = New Point(157, 128)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(176, 30)
        ComboBox2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Location = New Point(166, 107)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 22
        Button1.Text = "Check"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(21, 76)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(312, 29)
        DateTimePicker2.TabIndex = 17
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(DateTimePicker2)
        GroupBox2.Controls.Add(ComboBox3)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(ComboBox2)
        GroupBox2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(734, 208)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(449, 294)
        GroupBox2.TabIndex = 30
        GroupBox2.TabStop = False
        GroupBox2.Text = "Check-Out Information"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(21, 44)
        Label11.Name = "Label11"
        Label11.Size = New Size(144, 22)
        Label11.TabIndex = 12
        Label11.Text = "Check-Out Date"
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
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.BackgroundImageLayout = ImageLayout.Center
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(224, 208)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(449, 156)
        GroupBox1.TabIndex = 29
        GroupBox1.TabStop = False
        GroupBox1.Text = "Guest Info"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 27F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(416, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(582, 52)
        Label2.TabIndex = 28
        Label2.Text = "Hotel Check-Out Information"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(446, 584)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 23
        Button6.Text = "Bill"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(26, 767)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 48
        Label4.Text = "Admin Login"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(50, 643)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 47
        Label6.Text = "About"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(34, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 46
        Label5.Text = "Homepage"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(22, 508)
        Label8.Name = "Label8"
        Label8.Size = New Size(109, 20)
        Label8.TabIndex = 45
        Label8.Text = "Check In / Out"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(0, -3)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 39
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(24, 365)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 20)
        Label9.TabIndex = 44
        Label9.Text = "Book a Room"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(28, 241)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 20)
        Label10.TabIndex = 43
        Label10.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.BackgroundImage = My.Resources.Resources.loginicon
        Button_Login.Location = New Point(0, 667)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(159, 137)
        Button_Login.TabIndex = 42
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Button_About
        ' 
        Button_About.Image = My.Resources.Resources.abouticon
        Button_About.Location = New Point(0, 536)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 41
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_View
        ' 
        Button_View.Image = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(0, 132)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 40
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Button_Check
        ' 
        Button_Check.BackgroundImage = My.Resources.Resources.checkinicon
        Button_Check.Location = New Point(0, 402)
        Button_Check.Name = "Button_Check"
        Button_Check.Size = New Size(159, 137)
        Button_Check.TabIndex = 50
        Button_Check.UseVisualStyleBackColor = True
        ' 
        ' Button_Book2
        ' 
        Button_Book2.BackgroundImage = My.Resources.Resources.roomicon
        Button_Book2.Location = New Point(0, 267)
        Button_Book2.Name = "Button_Book2"
        Button_Book2.Size = New Size(159, 137)
        Button_Book2.TabIndex = 49
        Button_Book2.UseVisualStyleBackColor = True
        ' 
        ' CheckOut
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1303, 806)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label8)
        Controls.Add(Button_Home)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Button_Login)
        Controls.Add(Button_About)
        Controls.Add(Button_View)
        Controls.Add(Button_Check)
        Controls.Add(Button_Book2)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Name = "CheckOut"
        Text = "CheckOut"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_View As Button
    Friend WithEvents Button_Check As Button
    Friend WithEvents Button_Book2 As Button
End Class
