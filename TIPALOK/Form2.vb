Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form2

    Dim co As String = "server=localhost;port=3306;user=root;password=;database=sample_crud"
    Dim conn As New MySqlConnection(co)
    Dim cmd As MySqlCommand
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.Show()
        Me.Hide()

    End Sub
    Sub LogIn()
        cmd = New MySqlCommand("SELECT `USERNAME`, `PASSWORD` FROM `user` WHERE `USERNAME` = @USERNAME AND `PASSWORD` = @PASSWORD", conn)

        cmd.Parameters.Add("@USERNAME", MySqlDbType.VarChar).Value = user.Text
        cmd.Parameters.Add("@PASSWORD", MySqlDbType.VarChar).Value = pass.Text

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")

        Else

            MessageBox.Show("Logged In")

            Form1.Show()
            Me.Hide()

        End If
        user.Clear()
        pass.Clear()




    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LogIn()


    End Sub
End Class
