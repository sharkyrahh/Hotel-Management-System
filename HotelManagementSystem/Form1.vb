Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button_Book2_Click(sender As Object, e As EventArgs) Handles Button_Book2.Click
        BookForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        ViewForm.Show
        Hide
    End Sub

    Private Sub Button_sql_Click(sender As Object, e As EventArgs)
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=hoteldb"

        Try
            conn.Open()
            MessageBox.Show("Connection good")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try


    End Sub

    Private Sub Button_About_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button_Check_Click(sender As Object, e As EventArgs) Handles Button_Check.Click
        CheckInOut.Show()
        Me.Hide()
    End Sub

End Class
