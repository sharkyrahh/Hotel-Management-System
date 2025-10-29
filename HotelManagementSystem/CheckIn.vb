Imports MySql.Data.MySqlClient

Public Class CheckIn
    Private connString As String = "server=localhost;userid=root;password=;database=hoteldb"

    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all room IDs once
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT room_id FROM rooms", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ListBox1.Items.Clear()
                While reader.Read()
                    ListBox1.Items.Add(reader("room_id").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' Load room status options
        ListBox2.Items.Clear()
        ListBox2.Items.Add("Unavailable")
        ListBox2.Items.Add("Reserved")

        ' Ensure single selection
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
                Dim cmd As New MySqlCommand("UPDATE rooms SET roomstatus=@status WHERE room_id=@id", conn)
                cmd.Parameters.AddWithValue("@status", roomStatus)
                cmd.Parameters.AddWithValue("@id", roomID)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Room status updated successfully.")
                Else
                    MessageBox.Show("No matching room found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Clear form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.ClearSelected()
        ListBox2.ClearSelected()
    End Sub

    ' Sidebar navigation examples
    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        Dim f As New Form1
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        Dim f As New ViewForm
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Book2_Click(sender As Object, e As EventArgs) Handles Button_Book2.Click
        Dim f As New BookForm
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Check_Click(sender As Object, e As EventArgs) Handles Button_Check.Click
        CheckInOut.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        Dim about As New AboutBox1
        about.ShowDialog()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim f As New StaffLoginForm
        f.Show()
        Me.Hide()
    End Sub
End Class
