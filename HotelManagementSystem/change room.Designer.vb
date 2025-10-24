<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(change_room))
        Label1 = New Label()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        AvailableRoomID = New ListBox()
        CurrentBookedRoom = New ListBox()
        Label19 = New Label()
        Button_Manage = New Button()
        Label5 = New Label()
        Button_Logout = New Button()
        Label6 = New Label()
        Label4 = New Label()
        Button_Home = New Button()
        Label8 = New Label()
        Label9 = New Label()
        Button_About = New Button()
        Button_Change = New Button()
        Button_View = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Lavender
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(243, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 28)
        Label1.TabIndex = 0
        Label1.Text = "Enter IC :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        TextBox1.Location = New Point(350, 41)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(317, 41)
        TextBox1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = My.Resources.Resources.Blur_Gradient_Vectors___Download_Free_High_Quality_Vectors_from_Freepik___Freepik
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(AvailableRoomID)
        GroupBox1.Controls.Add(CurrentBookedRoom)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(267, 79)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(929, 634)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Change Room"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lavender
        Button1.Font = New Font("Segoe UI", 15.8000011F, FontStyle.Bold)
        Button1.Location = New Point(370, 562)
        Button1.Name = "Button1"
        Button1.Size = New Size(191, 63)
        Button1.TabIndex = 4
        Button1.Text = "Proceed"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AvailableRoomID
        ' 
        AvailableRoomID.Font = New Font("Segoe UI", 12.8000011F, FontStyle.Bold)
        AvailableRoomID.FormattingEnabled = True
        AvailableRoomID.ItemHeight = 30
        AvailableRoomID.Location = New Point(573, 147)
        AvailableRoomID.Name = "AvailableRoomID"
        AvailableRoomID.Size = New Size(335, 394)
        AvailableRoomID.TabIndex = 3
        ' 
        ' CurrentBookedRoom
        ' 
        CurrentBookedRoom.Font = New Font("Segoe UI", 12.8000011F, FontStyle.Bold)
        CurrentBookedRoom.FormattingEnabled = True
        CurrentBookedRoom.ItemHeight = 30
        CurrentBookedRoom.Location = New Point(23, 147)
        CurrentBookedRoom.Name = "CurrentBookedRoom"
        CurrentBookedRoom.Size = New Size(338, 394)
        CurrentBookedRoom.TabIndex = 2
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.White
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(31, 504)
        Label19.Name = "Label19"
        Label19.Size = New Size(103, 20)
        Label19.TabIndex = 82
        Label19.Text = "Manage Staff"
        ' 
        ' Button_Manage
        ' 
        Button_Manage.BackgroundImage = CType(resources.GetObject("Button_Manage.BackgroundImage"), Image)
        Button_Manage.BackgroundImageLayout = ImageLayout.Zoom
        Button_Manage.Location = New Point(3, 400)
        Button_Manage.Name = "Button_Manage"
        Button_Manage.Size = New Size(159, 137)
        Button_Manage.TabIndex = 81
        Button_Manage.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(47, 780)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 80
        Label5.Text = "Log Out"
        ' 
        ' Button_Logout
        ' 
        Button_Logout.BackgroundImage = CType(resources.GetObject("Button_Logout.BackgroundImage"), Image)
        Button_Logout.BackgroundImageLayout = ImageLayout.Zoom
        Button_Logout.Location = New Point(3, 669)
        Button_Logout.Name = "Button_Logout"
        Button_Logout.Size = New Size(159, 137)
        Button_Logout.TabIndex = 79
        Button_Logout.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(56, 644)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 78
        Label6.Text = "About"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(37, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 77
        Label4.Text = "Dashboard"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(3, -1)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 71
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(26, 380)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 20)
        Label8.TabIndex = 76
        Label8.Text = "Change Rooms"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(31, 243)
        Label9.Name = "Label9"
        Label9.Size = New Size(118, 20)
        Label9.TabIndex = 75
        Label9.Text = "Manage Rooms"
        ' 
        ' Button_About
        ' 
        Button_About.Image = My.Resources.Resources.abouticon
        Button_About.Location = New Point(3, 534)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 74
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_Change
        ' 
        Button_Change.BackgroundImage = My.Resources.Resources.changeicon
        Button_Change.BackgroundImageLayout = ImageLayout.Zoom
        Button_Change.Location = New Point(3, 269)
        Button_Change.Name = "Button_Change"
        Button_Change.Size = New Size(159, 137)
        Button_Change.TabIndex = 72
        Button_Change.UseVisualStyleBackColor = True
        ' 
        ' Button_View
        ' 
        Button_View.Image = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(3, 134)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 73
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(56, 641)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 84
        Label2.Text = "About"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(26, 377)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 83
        Label3.Text = "Change Rooms"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(26, 246)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 20)
        Label7.TabIndex = 85
        Label7.Text = "Manage Rooms"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Lavender
        Button2.Font = New Font("Segoe UI", 10.8000011F, FontStyle.Bold)
        Button2.Location = New Point(673, 43)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 41)
        Button2.TabIndex = 5
        Button2.Text = "Find"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' change_room
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1303, 806)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label19)
        Controls.Add(GroupBox1)
        Controls.Add(Button_Manage)
        Controls.Add(Button_View)
        Controls.Add(Label5)
        Controls.Add(Button_Change)
        Controls.Add(Button_Logout)
        Controls.Add(Button_About)
        Controls.Add(Label6)
        Controls.Add(Label9)
        Controls.Add(Label4)
        Controls.Add(Label8)
        Controls.Add(Button_Home)
        DoubleBuffered = True
        Name = "change_room"
        Text = "change_room"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CurrentBookedRoom As ListBox
    Friend WithEvents AvailableRoomID As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Button_Manage As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_Logout As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_Change As Button
    Friend WithEvents Button_View As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
End Class
