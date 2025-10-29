<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Staff))
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        TextBox6 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        TextBox9 = New TextBox()
        Label10 = New Label()
        Button2 = New Button()
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
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 27F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(550, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(277, 52)
        Label2.TabIndex = 3
        Label2.Text = "Manage Staff"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(259, 204)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(428, 379)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Staff"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(131, 260)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(240, 29)
        TextBox6.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 260)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 22)
        Label7.TabIndex = 29
        Label7.Text = "Password"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(131, 206)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(240, 29)
        TextBox5.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 206)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 22)
        Label6.TabIndex = 27
        Label6.Text = "Username"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(131, 157)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(240, 29)
        TextBox4.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 22)
        Label5.TabIndex = 25
        Label5.Text = "Email"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(131, 107)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(240, 29)
        TextBox3.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 22)
        Label4.TabIndex = 23
        Label4.Text = "Staff IC"
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(131, 49)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(240, 29)
        TextBox1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 22)
        Label3.TabIndex = 4
        Label3.Text = "Staff Name"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(TextBox9)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.ControlText
        GroupBox2.Location = New Point(738, 204)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(428, 207)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Remove Staff"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(140, 56)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(240, 29)
        TextBox9.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(27, 56)
        Label10.Name = "Label10"
        Label10.Size = New Size(75, 22)
        Label10.TabIndex = 23
        Label10.Text = "Staff IC"
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
        ' Button3
        ' 
        Button3.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button3.Location = New Point(1102, 656)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 29
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.White
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ActiveCaptionText
        Label19.Location = New Point(26, 505)
        Label19.Name = "Label19"
        Label19.Size = New Size(103, 20)
        Label19.TabIndex = 94
        Label19.Text = "Manage Staff"
        ' 
        ' Button_Manage
        ' 
        Button_Manage.BackgroundImage = CType(resources.GetObject("Button_Manage.BackgroundImage"), Image)
        Button_Manage.BackgroundImageLayout = ImageLayout.Zoom
        Button_Manage.Location = New Point(-2, 401)
        Button_Manage.Name = "Button_Manage"
        Button_Manage.Size = New Size(159, 137)
        Button_Manage.TabIndex = 93
        Button_Manage.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(42, 781)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 20)
        Label8.TabIndex = 92
        Label8.Text = "Log Out"
        ' 
        ' Button_Logout
        ' 
        Button_Logout.BackgroundImage = CType(resources.GetObject("Button_Logout.BackgroundImage"), Image)
        Button_Logout.BackgroundImageLayout = ImageLayout.Zoom
        Button_Logout.Location = New Point(-2, 670)
        Button_Logout.Name = "Button_Logout"
        Button_Logout.Size = New Size(159, 137)
        Button_Logout.TabIndex = 91
        Button_Logout.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(51, 645)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 20)
        Label9.TabIndex = 90
        Label9.Text = "About"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(32, 100)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 20)
        Label11.TabIndex = 89
        Label11.Text = "Dashboard"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(-2, 0)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 83
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ActiveCaptionText
        Label12.Location = New Point(21, 381)
        Label12.Name = "Label12"
        Label12.Size = New Size(114, 20)
        Label12.TabIndex = 88
        Label12.Text = "Change Rooms"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.White
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(26, 244)
        Label13.Name = "Label13"
        Label13.Size = New Size(118, 20)
        Label13.TabIndex = 87
        Label13.Text = "Manage Rooms"
        ' 
        ' Button_About
        ' 
        Button_About.ForeColor = SystemColors.ActiveCaptionText
        Button_About.Image = My.Resources.Resources.abouticon
        Button_About.Location = New Point(-2, 535)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 86
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_Change
        ' 
        Button_Change.BackgroundImage = My.Resources.Resources.changeicon
        Button_Change.BackgroundImageLayout = ImageLayout.Zoom
        Button_Change.Location = New Point(-2, 270)
        Button_Change.Name = "Button_Change"
        Button_Change.Size = New Size(159, 137)
        Button_Change.TabIndex = 84
        Button_Change.UseVisualStyleBackColor = True
        ' 
        ' Button_View
        ' 
        Button_View.Image = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(-2, 135)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 85
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Add_Staff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1303, 806)
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
        Name = "Add_Staff"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add_Staff"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
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
End Class
