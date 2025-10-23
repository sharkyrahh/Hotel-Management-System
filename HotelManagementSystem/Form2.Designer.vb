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
        TextBox6 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        ComboBox3 = New ComboBox()
        Button4 = New Button()
        Button3 = New Button()
        Label4 = New Label()
        ComboBox4 = New ComboBox()
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
        GroupBox2.Controls.Add(ComboBox4)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(ComboBox3)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.ControlText
        GroupBox2.Location = New Point(534, 141)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(428, 207)
        GroupBox2.TabIndex = 33
        GroupBox2.TabStop = False
        GroupBox2.Text = "Remove Room"
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
        Label7.Size = New Size(57, 22)
        Label7.TabIndex = 29
        Label7.Text = "Rules"
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
        Label6.Size = New Size(119, 22)
        Label6.TabIndex = 27
        Label6.Text = "Num of Beds"
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
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(ComboBox2)
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
        GroupBox1.Location = New Point(55, 141)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(428, 379)
        GroupBox1.TabIndex = 32
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Rooms"
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
        Label2.Location = New Point(346, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(316, 52)
        Label2.TabIndex = 31
        Label2.Text = "Manage Rooms"
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
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox2.Location = New Point(181, 108)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(176, 30)
        ComboBox2.TabIndex = 38
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
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox3.Location = New Point(140, 53)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(176, 30)
        ComboBox3.TabIndex = 39
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.ActiveCaptionText
        Button4.Location = New Point(911, 613)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 36
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(802, 613)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 35
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 22)
        Label4.TabIndex = 40
        Label4.Text = "Reason"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Clean Up Progress", "Renovating"})
        ComboBox4.Location = New Point(140, 105)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(176, 30)
        ComboBox4.TabIndex = 41
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1035, 670)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        ForeColor = SystemColors.ButtonHighlight
        Name = "Form2"
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
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label4 As Label
End Class
