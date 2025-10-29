<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckInOut
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
        Label4 = New Label()
        Label5 = New Label()
        Button_Home = New Button()
        Label8 = New Label()
        Label9 = New Label()
        Button_Login = New Button()
        Button_About = New Button()
        Button_View = New Button()
        Button_Check = New Button()
        Button_Book2 = New Button()
        Label2 = New Label()
        Button_in = New Button()
        Button_out = New Button()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(27, 768)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 20)
        Label7.TabIndex = 39
        Label7.Text = "Admin Login"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(51, 644)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 38
        Label6.Text = "About"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(35, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 37
        Label4.Text = "Homepage"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(23, 509)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 20)
        Label5.TabIndex = 36
        Label5.Text = "Check In / Out"
        ' 
        ' Button_Home
        ' 
        Button_Home.BackgroundImage = My.Resources.Resources.homeicon
        Button_Home.Location = New Point(1, -2)
        Button_Home.Name = "Button_Home"
        Button_Home.Size = New Size(159, 137)
        Button_Home.TabIndex = 30
        Button_Home.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(25, 366)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 20)
        Label8.TabIndex = 35
        Label8.Text = "Book a Room"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(29, 242)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 20)
        Label9.TabIndex = 34
        Label9.Text = "View Rooms"
        ' 
        ' Button_Login
        ' 
        Button_Login.BackgroundImage = My.Resources.Resources.loginicon
        Button_Login.Location = New Point(1, 668)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(159, 137)
        Button_Login.TabIndex = 33
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Button_About
        ' 
        Button_About.Image = My.Resources.Resources.abouticon
        Button_About.Location = New Point(1, 537)
        Button_About.Name = "Button_About"
        Button_About.Size = New Size(159, 137)
        Button_About.TabIndex = 32
        Button_About.UseVisualStyleBackColor = True
        ' 
        ' Button_View
        ' 
        Button_View.Image = My.Resources.Resources.viewroomicon
        Button_View.Location = New Point(1, 133)
        Button_View.Name = "Button_View"
        Button_View.Size = New Size(159, 137)
        Button_View.TabIndex = 31
        Button_View.UseVisualStyleBackColor = True
        ' 
        ' Button_Check
        ' 
        Button_Check.BackgroundImage = My.Resources.Resources.checkinicon
        Button_Check.Location = New Point(1, 403)
        Button_Check.Name = "Button_Check"
        Button_Check.Size = New Size(159, 137)
        Button_Check.TabIndex = 41
        Button_Check.UseVisualStyleBackColor = True
        ' 
        ' Button_Book2
        ' 
        Button_Book2.BackgroundImage = My.Resources.Resources.roomicon
        Button_Book2.Location = New Point(1, 268)
        Button_Book2.Name = "Button_Book2"
        Button_Book2.Size = New Size(159, 137)
        Button_Book2.TabIndex = 40
        Button_Book2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 27F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(216, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(352, 52)
        Label2.TabIndex = 42
        Label2.Text = "Check in and Out"
        ' 
        ' Button_in
        ' 
        Button_in.Font = New Font("Times New Roman", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button_in.Location = New Point(426, 152)
        Button_in.Name = "Button_in"
        Button_in.Size = New Size(561, 200)
        Button_in.TabIndex = 43
        Button_in.Text = "Check-In"
        Button_in.UseVisualStyleBackColor = True
        ' 
        ' Button_out
        ' 
        Button_out.Font = New Font("Times New Roman", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button_out.Location = New Point(426, 403)
        Button_out.Name = "Button_out"
        Button_out.Size = New Size(561, 200)
        Button_out.TabIndex = 44
        Button_out.Text = "Check-Out"
        Button_out.UseVisualStyleBackColor = True
        ' 
        ' CheckInOut
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.atas
        ClientSize = New Size(1303, 806)
        Controls.Add(Button_out)
        Controls.Add(Button_in)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Button_Home)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Button_Login)
        Controls.Add(Button_About)
        Controls.Add(Button_View)
        Controls.Add(Button_Check)
        Controls.Add(Button_Book2)
        Name = "CheckInOut"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CheckInOut"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_Home As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_View As Button
    Friend WithEvents Button_Check As Button
    Friend WithEvents Button_Book2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_in As Button
    Friend WithEvents Button_out As Button
End Class
