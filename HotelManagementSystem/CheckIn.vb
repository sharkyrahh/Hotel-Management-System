Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class CheckIn
    Private connString As String = "server=localhost;userid=root;password=;database=hoteldb"

    ' Form Load
    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoomStatusOptions()
    End Sub

    ' Load room status options
    Private Sub LoadRoomStatusOptions()
        ListBox2.Items.Clear()
        ListBox2.Items.Add("Unavailable")
        ListBox2.Items.Add("Reserved")
        ListBox1.SelectionMode = SelectionMode.One
        ListBox2.SelectionMode = SelectionMode.One
    End Sub

    ' When click Check IC
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ic As String = TextBox1.Text.Trim()
        If ic = "" Then
            MessageBox.Show("Enter IC first")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Get user ID by IC
                Dim cmd As New MySqlCommand("SELECT users_id FROM users WHERE IC=@ic", conn)
                cmd.Parameters.AddWithValue("@ic", ic)
                Dim userId As Object = cmd.ExecuteScalar()

                If userId Is Nothing Then
                    LabelUserID.Text = "User not found"
                    ListBox1.Items.Clear()
                    Return
                End If

                LabelUserID.Text = "User ID: " & userId.ToString()

                ' Now show all room IDs booked by that user
                Dim cmd2 As New MySqlCommand("SELECT room_id FROM bookings WHERE users_id=@uid", conn)
                cmd2.Parameters.AddWithValue("@uid", userId)
                Dim reader As MySqlDataReader = cmd2.ExecuteReader()

                ListBox1.Items.Clear()
                While reader.Read()
                    ListBox1.Items.Add(reader("room_id").ToString())
                End While

                If ListBox1.Items.Count = 0 Then
                    ListBox1.Items.Add("No room booked")
                End If

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    ' Clear everything
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.ClearSelected()
        TextBox1.Clear()
        LabelUserID.Text = ""
    End Sub

    ' Navigation: Home
    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Dim f As New Form1
        f.Show()
        Me.Hide()
    End Sub
End Class
