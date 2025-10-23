<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckIn
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
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        TextBox10 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox6 = New TextBox()
        Label10 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox2 = New GroupBox()
        DateTimePicker2 = New DateTimePicker()
        NumericUpDown1 = New NumericUpDown()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label1 = New Label()
        GroupBox3 = New GroupBox()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label7 = New Label()
        Label9 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(357, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 20)
        Label2.TabIndex = 2
        Label2.Text = "Hotel Checkin Information"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox10)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(26, 63)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(393, 414)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Guest Info"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(117, 253)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(251, 27)
        TextBox10.TabIndex = 21
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(117, 186)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(251, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(251, 27)
        TextBox1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 4
        Label3.Text = "Guest IC"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 40)
        Label4.TabIndex = 5
        Label4.Text = "Phone " & vbCrLf & "Number"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(117, 118)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(251, 27)
        TextBox6.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(21, 118)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 20)
        Label10.TabIndex = 11
        Label10.Text = "Guest Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 6
        Label5.Text = "Email"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(334, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 20)
        Label8.TabIndex = 9
        Label8.Text = "No of Days"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(37, 124)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 20)
        Label11.TabIndex = 12
        Label11.Text = "Check-Out Date"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(37, 37)
        Label12.Name = "Label12"
        Label12.Size = New Size(110, 20)
        Label12.TabIndex = 13
        Label12.Text = "Chheck-In Date"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DateTimePicker2)
        GroupBox2.Controls.Add(NumericUpDown1)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Location = New Point(478, 75)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(449, 211)
        GroupBox2.TabIndex = 19
        GroupBox2.TabStop = False
        GroupBox2.Text = "Checkin information"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(21, 167)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(250, 27)
        DateTimePicker2.TabIndex = 17
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(293, 73)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 27)
        NumericUpDown1.TabIndex = 15
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(21, 73)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(293, 379)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 22
        Button1.Text = "Check"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(117, 379)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(78, 24)
        RadioButton1.TabIndex = 23
        RadioButton1.TabStop = True
        RadioButton1.Text = "Female"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(117, 330)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(63, 24)
        RadioButton2.TabIndex = 24
        RadioButton2.TabStop = True
        RadioButton2.Text = "Male"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 334)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 25
        Label1.Text = "Gender"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(ComboBox2)
        GroupBox3.Controls.Add(ComboBox1)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Location = New Point(478, 310)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(449, 161)
        GroupBox3.TabIndex = 20
        GroupBox3.TabStop = False
        GroupBox3.Text = "Room Information"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(37, 52)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 20)
        Label6.TabIndex = 0
        Label6.Text = "Room Type"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Deluxe", "Twin", "Single"})
        ComboBox1.Location = New Point(184, 44)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(177, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21"})
        ComboBox2.Location = New Point(185, 105)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(176, 28)
        ComboBox2.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(37, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 20)
        Label7.TabIndex = 3
        Label7.Text = "Room Number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(354, 507)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 20)
        Label9.TabIndex = 21
        Label9.Text = "Amount:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(449, 507)
        Label13.Name = "Label13"
        Label13.Size = New Size(116, 20)
        Label13.TabIndex = 22
        Label13.Text = "delete yg ni nnti"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(354, 551)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 20)
        Label14.TabIndex = 23
        Label14.Text = "Total:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(449, 551)
        Label15.Name = "Label15"
        Label15.Size = New Size(116, 20)
        Label15.TabIndex = 24
        Label15.Text = "delete yg ni nnti"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(704, 551)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 25
        Button2.Text = "Check-In"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(812, 551)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 26
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(921, 551)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 27
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' CheckIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1040, 620)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label9)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Name = "CheckIn"
        Text = "CheckIn"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
