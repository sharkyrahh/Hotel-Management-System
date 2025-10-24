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
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 20
        Label3.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.BackgroundImage = My.Resources.Resources.loginicon1
        Button_Login.Location = New Point(0, 668)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(159, 137)
        Button_Login.TabIndex = 19
        Button_Login.UseVisualStyleBackColor = True
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
        Label1.Font = New Font("Times New Roman", 25.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(196, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 47)
        Label1.TabIndex = 26
        Label1.Text = "View Rooms"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.standard1
        PictureBox1.Location = New Point(286, 98)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(858, 492)
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 30F)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(1154, 187)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 240)
        Button1.TabIndex = 28
        Button1.Text = ">"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Segoe UI", 30F)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(181, 187)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 240)
        Button2.TabIndex = 29
        Button2.Text = "<"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 25.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.HotTrack
        Label8.Location = New Point(220, 593)
        Label8.Name = "Label8"
        Label8.Size = New Size(292, 47)
        Label8.TabIndex = 30
        Label8.Text = "Standard Room"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlDarkDark
        Label9.Location = New Point(471, 642)
        Label9.Name = "Label9"
        Label9.Size = New Size(497, 46)
        Label9.TabIndex = 31
        Label9.Text = "Includes one queen sized bed."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlDarkDark
        Label10.Location = New Point(471, 688)
        Label10.Name = "Label10"
        Label10.Size = New Size(404, 46)
        Label10.TabIndex = 32
        Label10.Text = "Suitable for two people."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 25.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ActiveCaption
        Label11.Location = New Point(425, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(1049, 47)
        Label11.TabIndex = 33
        Label11.Text = "_________________________________________________"
        ' 
        ' ViewForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1303, 806)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
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
        Name = "ViewForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
