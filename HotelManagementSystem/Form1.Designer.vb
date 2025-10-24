<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Button_Home = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Button_Login = New Button()
        Button_About = New Button()
        Button_CheckIn = New Button()
        Button_Book = New Button()
        Button_View = New Button()
        Button_Check = New Button()
        Button_Book2 = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label8 = New Label()
        Button_sql = New Button()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 40.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(328, 368)
        Label1.Name = "Label1"
        Label1.Size = New Size(785, 75)
        Label1.TabIndex = 0
        Label1.Text = "Hotel Management System"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AliceBlue
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button_Home)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button_Login)
        Panel1.Controls.Add(Button_About)
        Panel1.Controls.Add(Button_CheckIn)
        Panel1.Controls.Add(Button_Book)
        Panel1.Controls.Add(Button_View)
        Panel1.Controls.Add(Button_Check)
        Panel1.Controls.Add(Button_Book2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(159, 807)
        Panel1.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(26, 770)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 20)
        Label7.TabIndex = 13
        Label7.Text = "Admin Login"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(49, 642)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 12
        Label6.Text = "About"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 11
        Label2.Text = "Homepage"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(22, 511)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 20)
        Label5.TabIndex = 10
        Label5.Text = "Check In / Out"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(0, 0)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 3
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(24, 368)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 20)
        Label4.TabIndex = 9
        Label4.Text = "Book a Room"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 8
        Label3.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.BackgroundImage = My.Resources.Resources.loginicon
        Button_Login.Location = New Point(0, 670)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(159, 137)
        Button_Login.TabIndex = 7
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Button_About
        ' 
        Button_About.BackgroundImage = My.Resources.Resources.abouticon
        Button_About.Location = New Point(0, 539)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 6
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_CheckIn
        ' 
        Button_CheckIn.Location = New Point(0, 0)
        Button_CheckIn.Name = "Button_CheckIn"
        Button_CheckIn.Size = New Size(75, 23)
        Button_CheckIn.TabIndex = 14
        ' 
        ' Button_Book
        ' 
        Button_Book.Location = New Point(0, 0)
        Button_Book.Name = "Button_Book"
        Button_Book.Size = New Size(75, 23)
        Button_Book.TabIndex = 15
        ' 
        ' Button_View
        ' 
        Button_View.BackgroundImage = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(0, 135)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 4
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Button_Check
        ' 
        Button_Check.BackgroundImage = My.Resources.Resources.checkinicon
        Button_Check.Location = New Point(0, 404)
        Button_Check.Name = "Button_Check"
        Button_Check.Size = New Size(159, 137)
        Button_Check.TabIndex = 19
        Button_Check.UseVisualStyleBackColor = True
        ' 
        ' Button_Book2
        ' 
        Button_Book2.BackgroundImage = My.Resources.Resources.roomicon
        Button_Book2.Location = New Point(0, 269)
        Button_Book2.Name = "Button_Book2"
        Button_Book2.Size = New Size(159, 137)
        Button_Book2.TabIndex = 18
        Button_Book2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Abstract_blur_luxury_hotel_lobby_for_background___Premium_Photo_2_
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(160, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1145, 506)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(159, 423)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1145, 301)
        Panel2.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(265, 33)
        Label8.Name = "Label8"
        Label8.Size = New Size(600, 38)
        Label8.TabIndex = 5
        Label8.Text = "Explore hotels and book your dream vacation."
        ' 
        ' Button_sql
        ' 
        Button_sql.Location = New Point(1211, 778)
        Button_sql.Name = "Button_sql"
        Button_sql.Size = New Size(94, 29)
        Button_sql.TabIndex = 6
        Button_sql.Text = "lets test sql connection"
        Button_sql.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(258, 330)
        Label9.Name = "Label9"
        Label9.Size = New Size(168, 38)
        Label9.TabIndex = 6
        Label9.Text = "Welcome to"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(1303, 806)
        Controls.Add(Button_sql)
        Controls.Add(Label9)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hotel Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_CheckIn As Button
    Friend WithEvents Button_Book As Button
    Friend WithEvents Button_View As Button
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button_sql As Button
    Friend WithEvents Button_Check As Button
    Friend WithEvents Button_Book2 As Button

End Class
