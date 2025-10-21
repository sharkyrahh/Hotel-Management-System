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
        GroupBox1 = New GroupBox()
        Button_Exit = New Button()
        Button_Login = New Button()
        Button_Book = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Times New Roman", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(148, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(803, 78)
        Label1.TabIndex = 0
        Label1.Text = "Hotel Management System"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.AliceBlue
        GroupBox1.Controls.Add(Button_Exit)
        GroupBox1.Controls.Add(Button_Login)
        GroupBox1.Controls.Add(Button_Book)
        GroupBox1.Location = New Point(148, 176)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(803, 393)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Button_Exit
        ' 
        Button_Exit.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button_Exit.FlatStyle = FlatStyle.Popup
        Button_Exit.Font = New Font("Sitka Small", 30F, FontStyle.Bold)
        Button_Exit.ForeColor = SystemColors.HotTrack
        Button_Exit.Location = New Point(42, 266)
        Button_Exit.Name = "Button_Exit"
        Button_Exit.Size = New Size(707, 83)
        Button_Exit.TabIndex = 4
        Button_Exit.Text = "Exit"
        Button_Exit.UseVisualStyleBackColor = True
        ' 
        ' Button_Login
        ' 
        Button_Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button_Login.FlatStyle = FlatStyle.Popup
        Button_Login.Font = New Font("Sitka Small", 30F, FontStyle.Bold)
        Button_Login.ForeColor = SystemColors.HotTrack
        Button_Login.Location = New Point(42, 148)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(707, 83)
        Button_Login.TabIndex = 3
        Button_Login.Text = "Staff Login"
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Button_Book
        ' 
        Button_Book.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button_Book.FlatStyle = FlatStyle.Popup
        Button_Book.Font = New Font("Sitka Small", 30F, FontStyle.Bold)
        Button_Book.ForeColor = SystemColors.HotTrack
        Button_Book.Location = New Point(42, 35)
        Button_Book.Name = "Button_Book"
        Button_Book.Size = New Size(707, 83)
        Button_Book.TabIndex = 2
        Button_Book.Text = "Book a Room"
        Button_Book.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(1134, 648)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hotel Management System"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Book As Button
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Button_Login As Button

End Class
