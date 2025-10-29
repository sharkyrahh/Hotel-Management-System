<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label10 = New Label()
        Button2 = New Button()
        GroupBox2 = New GroupBox()
        ComboBox3 = New ComboBox()
        TextBox6 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Button3 = New Button()
        Label19 = New Label()
        Button_Manage = New Button()
        Label8 = New Label()
        Button_Logout = New Button()
        Label9 = New Label()
        Label11 = New Label()
        Button_Home = New Button()
        Label12 = New Label()
        Label13 = New Label()
        Button_About = New Button()
        Button_Change = New Button()
        Button_View = New Button()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(27, 56)
        Label10.Name = "Label10"
        Label10.Size = New Size(86, 22)
        Label10.TabIndex = 23
        Label10.Text = "Room ID"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(140, 150)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 22
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(ComboBox3)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.ControlText
        GroupBox2.Location = New Point(730, 201)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(428, 207)
        GroupBox2.TabIndex = 33
        GroupBox2.TabStop = False
        GroupBox2.Text = "Remove Room"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox3.Location = New Point(140, 53)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(176, 30)
        ComboBox3.TabIndex = 39
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(181, 260)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(176, 29)
        TextBox6.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 260)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 22)
        Label7.TabIndex = 29
        Label7.Text = "Status"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(181, 203)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(176, 29)
        TextBox5.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 206)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 22)
        Label6.TabIndex = 27
        Label6.Text = "Rules"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(181, 157)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(177, 29)
        TextBox4.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(181, 333)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 22
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(251, 201)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(428, 379)
        GroupBox1.TabIndex = 32
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Rooms"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(181, 101)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(177, 29)
        TextBox2.TabIndex = 40
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 22)
        Label1.TabIndex = 39
        Label1.Text = "Room ID"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Deluxe", "Twin", "Single", "Standard"})
        ComboBox1.Location = New Point(181, 55)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(177, 30)
        ComboBox1.TabIndex = 37
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 22)
        Label3.TabIndex = 36
        Label3.Text = "Room Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 22)
        Label5.TabIndex = 25
        Label5.Text = "Room Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 27F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(542, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(316, 52)
        Label2.TabIndex = 31
        Label2.Text = "Manage Rooms"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(1109, 697)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 35
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.White
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ActiveCaptionText
        Label19.Location = New Point(27, 502)
        Label19.Name = "Label19"
        Label19.Size = New Size(103, 20)
        Label19.TabIndex = 82
        Label19.Text = "Manage Staff"
        ' 
        ' Button_Manage
        ' 
        Button_Manage.BackgroundImage = CType(resources.GetObject("Button_Manage.BackgroundImage"), Image)
        Button_Manage.BackgroundImageLayout = ImageLayout.Zoom
        Button_Manage.Location = New Point(-1, 398)
        Button_Manage.Name = "Button_Manage"
        Button_Manage.Size = New Size(159, 137)
        Button_Manage.TabIndex = 81
        Button_Manage.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(43, 778)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 20)
        Label8.TabIndex = 80
        Label8.Text = "Log Out"
        ' 
        ' Button_Logout
        ' 
        Button_Logout.BackgroundImage = CType(resources.GetObject("Button_Logout.BackgroundImage"), Image)
        Button_Logout.BackgroundImageLayout = ImageLayout.Zoom
        Button_Logout.Location = New Point(-1, 667)
        Button_Logout.Name = "Button_Logout"
        Button_Logout.Size = New Size(159, 137)
        Button_Logout.TabIndex = 79
        Button_Logout.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(52, 642)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 20)
        Label9.TabIndex = 78
        Label9.Text = "About"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(33, 97)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 20)
        Label11.TabIndex = 77
        Label11.Text = "Dashboard"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(-1, -3)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 71
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ActiveCaptionText
        Label12.Location = New Point(22, 378)
        Label12.Name = "Label12"
        Label12.Size = New Size(114, 20)
        Label12.TabIndex = 76
        Label12.Text = "Change Rooms"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.White
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(27, 241)
        Label13.Name = "Label13"
        Label13.Size = New Size(118, 20)
        Label13.TabIndex = 75
        Label13.Text = "Manage Rooms"
        ' 
        ' Button_About
        ' 
        Button_About.ForeColor = SystemColors.ActiveCaptionText
        Button_About.Image = My.Resources.Resources.abouticon
        Button_About.Location = New Point(-1, 532)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 74
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_Change
        ' 
        Button_Change.BackgroundImage = My.Resources.Resources.changeicon
        Button_Change.BackgroundImageLayout = ImageLayout.Zoom
        Button_Change.Location = New Point(-1, 267)
        Button_Change.Name = "Button_Change"
        Button_Change.Size = New Size(159, 137)
        Button_Change.TabIndex = 72
        Button_Change.UseVisualStyleBackColor = True
        ' 
        ' Button_View
        ' 
        Button_View.Image = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(-1, 132)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 73
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1306, 805)
        Controls.Add(Label19)
        Controls.Add(Button_Manage)
        Controls.Add(Label8)
        Controls.Add(Button_Logout)
        Controls.Add(Label9)
        Controls.Add(Label11)
        Controls.Add(Button_Home)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Button_About)
        Controls.Add(Button_Change)
        Controls.Add(Button_View)
        Controls.Add(Button3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Enabled = False
        ForeColor = SystemColors.ButtonHighlight
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Room"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Button_Manage As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_Logout As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_Change As Button
    Friend WithEvents Button_View As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox2 As TextBox
End Class
