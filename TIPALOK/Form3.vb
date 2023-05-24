Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Form3

    Dim co As String = "server=localhost;port=3306;user=root;password=;database=sample_crud"
    Dim conn As New MySqlConnection(co)
    Dim cmd As MySqlCommand
    Dim i As Integer

    Sub Register()
        Try
            conn.Open()

            ' Check if user already exists
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM `user` WHERE `USERNAME` = @USERNAME", conn)
            checkCmd.Parameters.AddWithValue("@USERNAME", username.Text)
            Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If (username.Text = "" Or password.Text = "") Then
                MsgBox("Fields cannot be empty!")
            ElseIf (userCount > 0) Then
                MsgBox("User already exists")
            Else
                ' Insert new user
                Dim insertCmd As New MySqlCommand("INSERT INTO `user` (`USERNAME`, `PASSWORD`) VALUES (@USERNAME, @PASSWORD)", conn)
                insertCmd.Parameters.AddWithValue("@USERNAME", username.Text)
                insertCmd.Parameters.AddWithValue("@PASSWORD", password.Text)

                Dim i As Integer = insertCmd.ExecuteNonQuery()
                If (i > 0) Then
                    MessageBox.Show("Registered Successfully!", "ALERT")
                    username.Clear()
                    password.Clear()
                Else
                    MessageBox.Show("Unsuccessful", "ALERT")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Register()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()

    End Sub
End Class