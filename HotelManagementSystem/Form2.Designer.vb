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
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Moccasin
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(88, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 46)
        Label1.TabIndex = 0
        Label1.Text = "Add Room"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Coral
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(6, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 35)
        Label2.TabIndex = 1
        Label2.Text = "Room Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.MistyRose
        TextBox1.Location = New Point(6, 161)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(155, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Coral
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(201, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 35)
        Label3.TabIndex = 3
        Label3.Text = "Room ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Coral
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(6, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 35)
        Label4.TabIndex = 4
        Label4.Text = "Room Type"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.MistyRose
        TextBox2.Location = New Point(201, 217)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(113, 27)
        TextBox2.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(429, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(347, 384)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Standard Room", "Deluxe Room", "Twin Room", "Single Room"})
        ComboBox1.BackColor = Color.MistyRose
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(6, 302)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(140, 28)
        ComboBox1.TabIndex = 6
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.ButtonHighlight
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
