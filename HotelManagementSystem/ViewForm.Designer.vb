<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewForm
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
        Label1 = New Label()
        Button_Next = New Button()
        Button_Previous = New Button()
        Label_RoomType = New Label()
        Label_Desc1 = New Label()
        Label_Desc2 = New Label()
        Label11 = New Label()
        Button_Login2 = New Button()
        PictureBox_View = New PictureBox()
        CType(PictureBox_View, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label7.Location = New Point(26, 768)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 20)
        Label7.TabIndex = 25
        Label7.Text = "Admin Login"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label6.Location = New Point(49, 640)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 24
        Label6.Text = "About"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label2.Location = New Point(34, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 23
        Label2.Text = "Homepage"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label5.Location = New Point(22, 509)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 20)
        Label5.TabIndex = 22
        Label5.Text = "Check In / Out"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(0, -2)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 14
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label4.Location = New Point(24, 366)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 20)
        Label4.TabIndex = 21
        Label4.Text = "Book a Room"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label3.Location = New Point(28, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 20
        Label3.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.Location = New Point(0, 0)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(75, 23)
        Button_Login.TabIndex = 35
        ' 
        ' Button_About
        ' 
        Button_About.BackgroundImage = My.Resources.Resources.abouticon
        Button_About.Location = New Point(0, 537)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 18
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_CheckIn
        ' 
        Button_CheckIn.BackgroundImage = My.Resources.Resources.checkinicon
        Button_CheckIn.Location = New Point(0, 403)
        Button_CheckIn.Name = "Button_CheckIn"
        Button_CheckIn.Size = New Size(159, 137)
        Button_CheckIn.TabIndex = 17
        Button_CheckIn.UseVisualStyleBackColor = True
        ' 
        ' Button_Book
        ' 
        Button_Book.BackgroundImage = My.Resources.Resources.roomicon
        Button_Book.Location = New Point(0, 268)
        Button_Book.Name = "Button_Book"
        Button_Book.Size = New Size(159, 137)
        Button_Book.TabIndex = 15
        Button_Book.UseVisualStyleBackColor = True
        ' 
        ' Button_View
        ' 
        Button_View.BackgroundImage = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(0, 133)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 16
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 25.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(196, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 47)
        Label1.TabIndex = 26
        Label1.Text = "View Rooms"
        ' 
        ' Button_Next
        ' 
        Button_Next.BackColor = SystemColors.ActiveCaption
        Button_Next.Font = New Font("Segoe UI", 30F)
        Button_Next.ForeColor = Color.Azure
        Button_Next.Location = New Point(1154, 187)
        Button_Next.Name = "Button_Next"
        Button_Next.Size = New Size(94, 240)
        Button_Next.TabIndex = 28
        Button_Next.Text = ">"
        Button_Next.UseVisualStyleBackColor = False
        ' 
        ' Button_Previous
        ' 
        Button_Previous.BackColor = SystemColors.ActiveCaption
        Button_Previous.Font = New Font("Segoe UI", 30F)
        Button_Previous.ForeColor = SystemColors.ButtonHighlight
        Button_Previous.Location = New Point(181, 187)
        Button_Previous.Name = "Button_Previous"
        Button_Previous.Size = New Size(94, 240)
        Button_Previous.TabIndex = 29
        Button_Previous.Text = "<"
        Button_Previous.UseVisualStyleBackColor = False
        ' 
        ' Label_RoomType
        ' 
        Label_RoomType.AutoSize = True
        Label_RoomType.Font = New Font("Times New Roman", 25.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
        Label_RoomType.ForeColor = SystemColors.HotTrack
        Label_RoomType.Location = New Point(220, 593)
        Label_RoomType.Name = "Label_RoomType"
        Label_RoomType.Size = New Size(292, 47)
        Label_RoomType.TabIndex = 30
        Label_RoomType.Text = "Standard Room"
        ' 
        ' Label_Desc1
        ' 
        Label_Desc1.AutoSize = True
        Label_Desc1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label_Desc1.ForeColor = SystemColors.ControlDarkDark
        Label_Desc1.Location = New Point(471, 642)
        Label_Desc1.Name = "Label_Desc1"
        Label_Desc1.Size = New Size(497, 46)
        Label_Desc1.TabIndex = 31
        Label_Desc1.Text = "Includes one queen sized bed."
        ' 
        ' Label_Desc2
        ' 
        Label_Desc2.AutoSize = True
        Label_Desc2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label_Desc2.ForeColor = SystemColors.ControlDarkDark
        Label_Desc2.Location = New Point(471, 688)
        Label_Desc2.Name = "Label_Desc2"
        Label_Desc2.Size = New Size(404, 46)
        Label_Desc2.TabIndex = 32
        Label_Desc2.Text = "Suitable for two people."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 25.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
        Label11.ForeColor = SystemColors.ActiveCaption
        Label11.Location = New Point(425, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(1049, 47)
        Label11.TabIndex = 33
        Label11.Text = "_________________________________________________"
        ' 
        ' Button_Login2
        ' 
        Button_Login2.BackgroundImage = My.Resources.Resources.loginicon
        Button_Login2.Location = New Point(0, 669)
        Button_Login2.Name = "Button_Login2"
        Button_Login2.Size = New Size(159, 137)
        Button_Login2.TabIndex = 36
        Button_Login2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox_View
        ' 
        PictureBox_View.BackgroundImage = My.Resources.Resources.standard
        PictureBox_View.Location = New Point(285, 98)
        PictureBox_View.Name = "PictureBox_View"
        PictureBox_View.Size = New Size(861, 475)
        PictureBox_View.TabIndex = 37
        PictureBox_View.TabStop = False
        ' 
        ' ViewForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1303, 806)
        Controls.Add(PictureBox_View)
        Controls.Add(Label11)
        Controls.Add(Label_Desc2)
        Controls.Add(Label_Desc1)
        Controls.Add(Label_RoomType)
        Controls.Add(Button_Previous)
        Controls.Add(Button_Next)
        Controls.Add(Label1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Button_Home)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button_Login)
        Controls.Add(Button_About)
        Controls.Add(Button_CheckIn)
        Controls.Add(Button_Book)
        Controls.Add(Button_View)
        Controls.Add(Button_Login2)
        Name = "ViewForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewForm"
        CType(PictureBox_View, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_CheckIn As Button
    Friend WithEvents Button_Book As Button
    Friend WithEvents Button_View As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Next As Button
    Friend WithEvents Button_Previous As Button
    Friend WithEvents Label_RoomType As Label
    Friend WithEvents Label_Desc1 As Label
    Friend WithEvents Label_Desc2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button_Login2 As Button
    Friend WithEvents PictureBox_View As PictureBox
End Class
