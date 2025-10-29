Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class CheckIn

    ' Sidebar navigation
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


    ' Search user IC
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=hoteldb")
        Dim cmd As New MySqlCommand("SELECT * FROM users WHERE IC=@ic", conn)
        cmd.Parameters.AddWithValue("@ic", TextBox1.Text)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                labelstatus.Text = "User found"
                labelstatus.ForeColor = Color.Green
            Else
                labelstatus.Text = "User not found"
                labelstatus.ForeColor = Color.Red
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' Save data to database
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Placeholder: will insert Check In details once table ready
        MessageBox.Show("Data stored successfully.")
    End Sub

    ' Update data
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Placeholder: will run UPDATE query later
        MessageBox.Show("Data updated successfully.")
    End Sub

    ' Clear form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        NumericUpDown1.Value = 0
        labelstatus.Text = ""
    End Sub

    ' Go home
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New Form1
        f.Show()
        Me.Hide()
    End Sub
