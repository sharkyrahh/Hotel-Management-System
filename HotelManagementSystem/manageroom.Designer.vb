<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageroom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageroom))
        GroupBox1 = New GroupBox()
        ListBox2 = New ListBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Label8 = New Label()
        Label1 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(ListBox2)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(ListBox1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(57, 83)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(424, 461)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Room"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Items.AddRange(New Object() {"Available", "Reserved", "Unavailable"})
        ListBox2.Location = New Point(152, 298)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(249, 64)
        ListBox2.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(150, 245)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(249, 27)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(150, 181)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(249, 27)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(150, 138)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 27)
        TextBox2.TabIndex = 9
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"Single", "Twin", "Deluxe", "Standard"})
        ListBox1.Location = New Point(150, 53)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(249, 64)
        ListBox1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(305, 405)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(14, 298)
        Label7.Name = "Label7"
        Label7.Size = New Size(132, 28)
        Label7.TabIndex = 5
        Label7.Text = "Room Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(14, 245)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 28)
        Label6.TabIndex = 4
        Label6.Text = "Room  Rules"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(24, 177)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 28)
        Label5.TabIndex = 3
        Label5.Text = "Room Id"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(22, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 28)
        Label4.TabIndex = 2
        Label4.Text = "Room Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 28)
        Label3.TabIndex = 1
        Label3.Text = "Room Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(-51, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 0
        Label2.Text = "Label2"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(546, 83)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(390, 461)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Delete Room"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(134, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(238, 27)
        TextBox1.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(278, 405)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(20, 65)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 28)
        Label8.TabIndex = 2
        Label8.Text = "Room ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(373, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 45)
        Label1.TabIndex = 2
        Label1.Text = "Manage Rooms"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button4.Location = New Point(842, 572)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 29
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Book Antiqua", 10.8F, FontStyle.Bold)
        Button3.Location = New Point(733, 572)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 28
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' manageroom
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1053, 642)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.ControlText
        Name = "manageroom"
        Text = "manageroom"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
