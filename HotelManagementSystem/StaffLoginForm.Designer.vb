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
        Button_Back = New Button()
        Label1 = New Label()
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
        GroupBox1.Controls.Add(Button_Back)
        GroupBox1.Location = New Point(205, 181)
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
        Button2.Location = New Point(356, 294)
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
        ' Button_Back
        ' 
        Button_Back.Location = New Point(168, 294)
        Button_Back.Name = "Button_Back"
        Button_Back.Size = New Size(182, 67)
        Button_Back.TabIndex = 5
        Button_Back.Text = "Back"
        Button_Back.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 50F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(333, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(432, 94)
        Label1.TabIndex = 0
        Label1.Text = "Staff Login"
        ' 
        ' StaffLoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Desktop
        ClientSize = New Size(1134, 648)
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
    Friend WithEvents Button_Back As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
End Class
