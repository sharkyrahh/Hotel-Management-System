<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Staff))
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        ComboBox3 = New ComboBox()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(63, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(284, 372)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Staff"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackgroundImage = My.Resources.Resources.Pin_by_Esmeralda_on_TRABAJOS_DEPORTE_Y_SALUD___Love_background_images__Wrinkled_paper_background__Paper_background
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(467, 29)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(290, 372)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Delete Staff"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ActiveBorder
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(55, 54)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(95, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 28)
        Label1.TabIndex = 1
        Label1.Text = "Staff ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(95, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 28)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.AppWorkspace
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(55, 134)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(95, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 28)
        Label3.TabIndex = 4
        Label3.Text = "Email"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = SystemColors.ActiveBorder
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(55, 207)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 28)
        ComboBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(79, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 28)
        Label4.TabIndex = 6
        Label4.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveBorder
        TextBox1.Location = New Point(55, 279)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(70, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(167, 28)
        Label5.TabIndex = 2
        Label5.Text = "Remove Staff ID"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveBorder
        TextBox2.Location = New Point(70, 176)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(167, 27)
        TextBox2.TabIndex = 8
        ' 
        ' Add_Staff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Add_Staff"
        Text = "Add_Staff"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
End Class
