<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOut))
        Button5 = New Button()
        Label1 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label15 = New Label()
        Label14 = New Label()
        ComboBox3 = New ComboBox()
        Label7 = New Label()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        DateTimePicker2 = New DateTimePicker()
        GroupBox2 = New GroupBox()
        Label11 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Button6 = New Button()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(303, 249)
        Button5.Name = "Button5"
        Button5.Size = New Size(128, 29)
        Button5.TabIndex = 6
        Button5.Text = "Update Status"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 22)
        Label1.TabIndex = 4
        Label1.Text = "Change Room Status"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button4.Location = New Point(901, 518)
        Button4.Name = "Button4"
        Button4.Size = New Size(103, 29)
        Button4.TabIndex = 38
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button3.Location = New Point(782, 518)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 29)
        Button3.TabIndex = 37
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button2.Location = New Point(643, 518)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 29)
        Button2.TabIndex = 36
        Button2.Text = "Check-Out"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Label15.Location = New Point(284, 450)
        Label15.Name = "Label15"
        Label15.Size = New Size(146, 22)
        Label15.TabIndex = 35
        Label15.Text = "delete yg ni nnti"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Label14.Location = New Point(189, 450)
        Label14.Name = "Label14"
        Label14.Size = New Size(58, 22)
        Label14.TabIndex = 34
        Label14.Text = "Total:"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Reserved", "Unavailable", "Booked"})
        ComboBox3.Location = New Point(230, 197)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(176, 30)
        ComboBox3.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 136)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 22)
        Label7.TabIndex = 3
        Label7.Text = "Room Number"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21"})
        ComboBox2.Location = New Point(157, 128)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(176, 30)
        ComboBox2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Location = New Point(166, 107)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 22
        Button1.Text = "Check"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(21, 76)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(312, 29)
        DateTimePicker2.TabIndex = 17
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(DateTimePicker2)
        GroupBox2.Controls.Add(ComboBox3)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(ComboBox2)
        GroupBox2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(533, 109)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(449, 294)
        GroupBox2.TabIndex = 30
        GroupBox2.TabStop = False
        GroupBox2.Text = "Check-Out Information"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(21, 44)
        Label11.Name = "Label11"
        Label11.Size = New Size(144, 22)
        Label11.TabIndex = 12
        Label11.Text = "Check-Out Date"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(300, 29)
        TextBox1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 22)
        Label3.TabIndex = 4
        Label3.Text = "Guest IC"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.BackgroundImageLayout = ImageLayout.Center
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(23, 109)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(449, 156)
        GroupBox1.TabIndex = 29
        GroupBox1.TabStop = False
        GroupBox1.Text = "Guest Info"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 27F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(215, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(582, 52)
        Label2.TabIndex = 28
        Label2.Text = "Hotel Check-Out Information"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(245, 485)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 23
        Button6.Text = "Bill"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' CheckOut
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1013, 578)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Name = "CheckOut"
        Text = "CheckOut"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
End Class
