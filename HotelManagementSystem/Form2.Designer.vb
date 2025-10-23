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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        ComboBox6 = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        ComboBox5 = New ComboBox()
        Label6 = New Label()
        ComboBox4 = New ComboBox()
        Label5 = New Label()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Moccasin
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(190, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 46)
        Label1.TabIndex = 0
        Label1.Text = "Add Room"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Coral
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(10, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 28)
        Label2.TabIndex = 1
        Label2.Text = "No.of Bed"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Coral
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(488, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 28)
        Label3.TabIndex = 3
        Label3.Text = "Room ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Coral
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(6, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 28)
        Label4.TabIndex = 4
        Label4.Text = "Room Type"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(ComboBox6)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(ComboBox5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(ComboBox4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(237, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(582, 646)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.Location = New Point(347, 507)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 18
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(105, 507)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 17
        Button1.Text = "save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.SeaShell
        GroupBox2.Controls.Add(CheckBox4)
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Location = New Point(154, 308)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(252, 125)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        GroupBox2.Text = "Amenities & Features"
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.ForeColor = SystemColors.ActiveCaptionText
        CheckBox4.Location = New Point(128, 68)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(120, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Coffee Maker"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.ForeColor = SystemColors.ActiveCaptionText
        CheckBox3.Location = New Point(128, 38)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(95, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Smart TV "
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.ForeColor = SystemColors.ActiveCaptionText
        CheckBox2.Location = New Point(7, 65)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(91, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Sea View"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.ForeColor = SystemColors.ActiveCaptionText
        CheckBox1.Location = New Point(6, 35)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(87, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Balcony "
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox6
        ' 
        ComboBox6.AutoCompleteCustomSource.AddRange(New String() {"Standard Room", "Deluxe Room", "Twin Room", "Single Room"})
        ComboBox6.BackColor = Color.MistyRose
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(398, 159)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(184, 28)
        ComboBox6.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Coral
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(464, 128)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 28)
        Label8.TabIndex = 14
        Label8.Text = "Room price"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Coral
        Label7.Font = New Font("Segoe UI", 15F)
        Label7.Location = New Point(288, 243)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 35)
        Label7.TabIndex = 13
        ' 
        ' ComboBox5
        ' 
        ComboBox5.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6"})
        ComboBox5.BackColor = Color.MistyRose
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(6, 159)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(190, 28)
        ComboBox5.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Coral
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(6, 128)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 28)
        Label6.TabIndex = 11
        Label6.Text = "No.of People"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.AutoCompleteCustomSource.AddRange(New String() {"Non-Smoking Room ", "No Parties or Excessive Noise", "Registered Guests Only", "No Pets Allowed", "No Cooking or Incense Burning"})
        ComboBox4.BackColor = Color.MistyRose
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(417, 236)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(184, 28)
        ComboBox4.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Coral
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(467, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 28)
        Label5.TabIndex = 9
        Label5.Text = "Room Rules"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.MistyRose
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(398, 88)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(178, 28)
        ComboBox3.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4"})
        ComboBox2.BackColor = Color.MistyRose
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(6, 236)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(190, 28)
        ComboBox2.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Standard Room", "Deluxe Room", "Twin Room", "Single Room"})
        ComboBox1.BackColor = Color.MistyRose
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(6, 88)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(190, 28)
        ComboBox1.TabIndex = 6
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1035, 670)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.ButtonHighlight
        Name = "Form2"
        Text = "Add Room"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button2 As Button
End Class
