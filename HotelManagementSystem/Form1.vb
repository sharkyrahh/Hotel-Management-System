Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button_Book_Click(sender As Object, e As EventArgs) Handles Button_Book.Click
        BookForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_sql_Click(sender As Object, e As EventArgs) Handles Button_sql.Click
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
End Class
