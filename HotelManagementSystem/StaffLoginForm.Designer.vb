<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffLoginForm
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
        Dim GroupBox1 As GroupBox
        TextBox2 = New TextBox()
        Label2 = New Label()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button_Home = New Button()
        Label8 = New Label()
        Label9 = New Label()
        Button_Login = New Button()
        Button_About = New Button()
        Button_CheckIn = New Button()
        Button_Book = New Button()
        Button_View = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(395, 254)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(731, 377)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 20F)
        TextBox2.Location = New Point(255, 212)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(350, 52)
        TextBox2.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label2.Location = New Point(34, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 46)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(518, 295)
        Button2.Name = "Button2"
        Button2.Size = New Size(182, 67)
        Button2.TabIndex = 6
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 20F)
        TextBox1.Location = New Point(255, 88)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(350, 52)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label3.Location = New Point(34, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 46)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 50F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(280, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(432, 94)
        Label1.TabIndex = 0
        Label1.Text = "Staff Login"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(25, 770)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 20)
        Label7.TabIndex = 25
        Label7.Text = "Admin Login"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(48, 642)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 24
        Label6.Text = "About"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(33, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 23
        Label4.Text = "Homepage"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(21, 511)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 20)
        Label5.TabIndex = 22
        Label5.Text = "Check In / Out"
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
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(23, 368)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 20)
        Label8.TabIndex = 21
        Label8.Text = "Book a Room"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(27, 244)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 20)
        Label9.TabIndex = 20
        Label9.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.BackgroundImage = My.Resources.Resources.loginicon__1_
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
        ' StaffLoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Desktop
        ClientSize = New Size(1303, 806)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Button_Home)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Button_Login)
        Controls.Add(Button_About)
        Controls.Add(Button_CheckIn)
        Controls.Add(Button_Book)
        Controls.Add(Button_View)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "StaffLoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Staff Login"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_CheckIn As Button
    Friend WithEvents Button_Book As Button
    Friend WithEvents Button_View As Button
End Class
