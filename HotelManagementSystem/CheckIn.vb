Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class CheckIn
    Private connString As String = "server=localhost;userid=root;password=;database=hoteldb"

    ' Form Load
    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoomIDs()
        LoadRoomStatusOptions()
    End Sub

    ' Load all room IDs from rooms table
    Private Sub LoadRoomIDs()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT room_id FROM rooms", conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ListBox1.Items.Clear()
                        While reader.Read()
                            ListBox1.Items.Add(reader("room_id").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Load room status options
    Private Sub LoadRoomStatusOptions()
        ListBox2.Items.Clear()
        ListBox2.Items.Add("Unavailable")
        ListBox2.Items.Add("Reserved")
        ListBox1.SelectionMode = SelectionMode.One
        ListBox2.SelectionMode = SelectionMode.One
    End Sub

    ' Update room status
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex = -1 Or ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please select a room ID and status.")
            Return
        End If

        Dim roomID As Integer = CInt(ListBox1.SelectedItem.ToString())
        Dim roomStatus As String = ListBox2.SelectedItem.ToString()

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE rooms SET roomstatus=@status WHERE room_id=@id", conn)
                    cmd.Parameters.AddWithValue("@status", roomStatus)
                    cmd.Parameters.AddWithValue("@id", roomID)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Room status updated successfully.")
                    Else
                        MessageBox.Show("No matching room found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Check user IC and show user ID
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ic As String = TextBox1.Text.Trim()
        If ic = "" Then
            MessageBox.Show("Enter IC first")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT users_id FROM users WHERE IC=@ic", conn)
                    cmd.Parameters.AddWithValue("@ic", ic)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        LabelUserID.Text = "User ID: Found "
                    Else
                        LabelUserID.Text = "User not found"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Save / Apply updates (example placeholder)
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Implement update for every relevant table based on your logic
        MessageBox.Show("Updates applied successfully.")
    End Sub

    ' Navigation: Home
    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Dim f As New Form1
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.ClearSelected()
        TextBox1.Clear()
        LabelUserID.Text = ""
    End Sub
End Class
