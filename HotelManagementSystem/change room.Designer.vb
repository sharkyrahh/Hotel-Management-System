<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(change_room))
        Label1 = New Label()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        CurrentBookedRoom = New ListBox()
        AvailableRoomID = New ListBox()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Lavender
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(112, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 28)
        Label1.TabIndex = 0
        Label1.Text = "Enter IC :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(197, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = My.Resources.Resources.Blur_Gradient_Vectors___Download_Free_High_Quality_Vectors_from_Freepik___Freepik
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(AvailableRoomID)
        GroupBox1.Controls.Add(CurrentBookedRoom)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(140, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(491, 397)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Change Room"
        ' 
        ' CurrentBookedRoom
        ' 
        CurrentBookedRoom.FormattingEnabled = True
        CurrentBookedRoom.Location = New Point(25, 114)
        CurrentBookedRoom.Name = "CurrentBookedRoom"
        CurrentBookedRoom.Size = New Size(209, 224)
        CurrentBookedRoom.TabIndex = 2
        ' 
        ' AvailableRoomID
        ' 
        AvailableRoomID.FormattingEnabled = True
        AvailableRoomID.Location = New Point(263, 115)
        AvailableRoomID.Name = "AvailableRoomID"
        AvailableRoomID.Size = New Size(209, 224)
        AvailableRoomID.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lavender
        Button1.Location = New Point(197, 345)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Proceed"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' change_room
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "change_room"
        Text = "change_room"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CurrentBookedRoom As ListBox
    Friend WithEvents AvailableRoomID As ListBox
    Friend WithEvents Button1 As Button
End Class
