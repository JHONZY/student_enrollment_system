Imports MySql.Data.MySqlClient
Public Class Form1
    Dim co As String = "server=localhost;port=3306;user=root;password=;database=sample_crud"
    Dim conn As New MySqlConnection(co)
    Dim cmd As MySqlCommand
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()

        Try
            conn.Open()
            MsgBox("GUMANA")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_info", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("STUDENT_ID"), dr.Item("FIRSTNAME"), dr.Item("MIDDLENAME"), dr.Item("LASTNAME"), dr.Item("ADDRESS"), dr.Item("GENDER"), dr.Item("COURSE"), dr.Item("YEAR"), dr.Item("SECTION"), dr.Item("STATUS"), dr.Item("BDATE"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub subject()
        DataGridView2.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM subject WHERE Course Like '" & Track.Text & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("ClassNo"), dr.Item("Code"), dr.Item("Title"), dr.Item("Time"), dr.Item("Day"), dr.Item("Teacher"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Public Sub Save()
        Try
            conn.Open()
            Dim generator As System.Random = New System.Random()


            Dim randomDigits As String = generator.Next(100, 1000).ToString()
            Dim studentNumber As String = year.Text & randomDigits

            Dim cmd As New MySqlCommand("INSERT INTO `tbl_info` (`STUDENT_ID`, `FIRSTNAME`, `MIDDLENAME`, `LASTNAME`, `ADDRESS`, `GENDER`, `COURSE`, `YEAR`, `SECTION`, `STATUS`, `BDATE`) VALUES (@STUDENT_ID, @FIRSTNAME, @MIDDLENAME, @LASTNAME, @ADDRESS, @GENDER, @COURSE, @YEAR, @SECTION, @STATUS, @BDATE)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@STUDENT_ID", studentNumber)
            cmd.Parameters.AddWithValue("@FIRSTNAME", fname.Text)
            cmd.Parameters.AddWithValue("@MIDDLENAME", mname.Text)
            cmd.Parameters.AddWithValue("@LASTNAME", lname.Text)
            cmd.Parameters.AddWithValue("@ADDRESS", address.Text)
            cmd.Parameters.AddWithValue("@GENDER", gend.Text)
            cmd.Parameters.AddWithValue("@COURSE", course.Text)
            cmd.Parameters.AddWithValue("@YEAR", year.Text)
            cmd.Parameters.AddWithValue("@SECTION", section.Text)
            cmd.Parameters.AddWithValue("@STATUS", status.Text)
            cmd.Parameters.AddWithValue("@BDATE", datetime.Value)

            If (fname.Text = "" Or lname.Text = "" Or mname.Text = "" Or gend.Text = "" Or address.Text = "" Or course.Text = "" Or year.Text = "" Or section.Text = "" Or status.Text = "") Then
                MsgBox("Field can't be empty!")
            Else
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If (rowsAffected > 0) Then
                    MessageBox.Show("Successfully Enrolled!" & " Your Student ID is " & studentNumber, "ALERT")
                Else
                    MessageBox.Show("Unsuccessful", "ALERT")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        DGV_load()
    End Sub

    Sub Clear()
        id.Text = ""
        fname.Text = ""
        mname.Text = ""
        lname.Text = ""
        gend.Text = ""
        course.Text = ""
        address.Text = ""
        section.Text = ""
        status.Text = ""
        year.Text = ""
    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_info` SET `FIRSTNAME`=@FIRSTNAME,`MIDDLENAME`=@MIDDLENAME,`LASTNAME`=@LASTNAME,`ADDRESS`=@ADDRESS,`GENDER`=@GENDER,`COURSE`=@COURSE,`YEAR`=@YEAR,`SECTION`=@SECTION,`STATUS`=@STATUS,`BDATE`=@BDATE WHERE `STUDENT_ID`=@STUDENT_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@STUDENT_ID", id.Text)
            cmd.Parameters.AddWithValue("@FIRSTNAME", fname.Text)
            cmd.Parameters.AddWithValue("@MIDDLENAME", mname.Text)
            cmd.Parameters.AddWithValue("@LASTNAME", lname.Text)
            cmd.Parameters.AddWithValue("@ADDRESS", lname.Text)
            cmd.Parameters.AddWithValue("@GENDER", gend.Text)
            cmd.Parameters.AddWithValue("@COURSE", course.Text)
            cmd.Parameters.AddWithValue("@YEAR", year.Text)
            cmd.Parameters.AddWithValue("@SECTION", section.Text)
            cmd.Parameters.AddWithValue("@STATUS", status.Text)
            cmd.Parameters.AddWithValue("@BDATE", datetime.Value)

            i = cmd.ExecuteNonQuery
            If (i > 0) Then
                MessageBox.Show("Updated successfully!", "ALERT")
            Else
                MessageBox.Show("Please!, Select a record to update details.", "ALERT")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        DGV_load()
        Clear()


    End Sub

    Sub Delete()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM `tbl_info` WHERE  `STUDENT_ID`=@STUDENT_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@STUDENT_ID", id.Text)

            i = cmd.ExecuteNonQuery
            If (i > 0) Then
                MessageBox.Show("Deleted successfully!", "ALERT")
            Else
                MessageBox.Show("Please!, Select a record to delete.", "ALERT")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        DGV_load()
        Clear()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Edit()
        DGV_load()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Delete()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel7.Visible = True
        Panel3.Visible = False
        Panel9.Visible = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel7.Visible = False
        Panel3.Visible = True
        Panel9.Visible = False

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles searchID.TextChanged

        If searchID.Text = searchID.Text Then
            conn = New MySqlConnection(co)
            conn.Open()
            cmd = New MySqlCommand("SELECT FIRSTNAME, MIDDLENAME, LASTNAME, ADDRESS, GENDER, COURSE, YEAR, SECTION, STATUS, BDATE FROM tbl_info WHERE STUDENT_ID Like '" & searchID.Text & "'", conn)
            dr = cmd.ExecuteReader()
            dr.Read()


            If dr.HasRows Then
                First.Text = dr.Item("FIRSTNAME").ToString
                Middle.Text = dr.Item("MIDDLENAME").ToString
                Last.Text = dr.Item("LASTNAME").ToString
                Add.Text = dr.Item("ADDRESS").ToString
                Gen.Text = dr.Item("GENDER").ToString
                Track.Text = dr.Item("COURSE").ToString
                Yr.Text = dr.Item("YEAR").ToString
                Sec.Text = dr.Item("SECTION").ToString
                Stat.Text = dr.Item("STATUS").ToString
                Birth.Text = dr.Item("BDATE").ToString

                conn.Close()
                dr.Close()

            Else
                First.Clear()
                Middle.Clear()
                Last.Clear()
                Add.Clear()
                Gen.Clear()
                Track.Clear()
                Yr.Clear()
                Sec.Clear()
                Stat.Clear()
                Birth.Clear()


            End If

            If Track.Text = "" Then
                DataGridView2.Rows.Clear()
            Else
                subject()
            End If

        End If


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim AnswerYes As String
        AnswerYes = MsgBox("Are you sure you want to log out?", vbQuestion + vbYesNo, "User Repsonse")

        If AnswerYes = vbYes Then
            Form2.Show()
            Me.Hide()
        End If

    End Sub


    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        id.Text = DataGridView1.CurrentRow.Cells(0).Value
        fname.Text = DataGridView1.CurrentRow.Cells(1).Value
        mname.Text = DataGridView1.CurrentRow.Cells(2).Value
        lname.Text = DataGridView1.CurrentRow.Cells(3).Value
        address.Text = DataGridView1.CurrentRow.Cells(4).Value
        gend.Text = DataGridView1.CurrentRow.Cells(5).Value
        course.Text = DataGridView1.CurrentRow.Cells(6).Value
        year.Text = DataGridView1.CurrentRow.Cells(7).Value
        section.Text = DataGridView1.CurrentRow.Cells(8).Value
        status.Text = DataGridView1.CurrentRow.Cells(9).Value
        datetime.Text = DataGridView1.CurrentRow.Cells(10).Value




    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel9.Show()
        Panel7.Hide()
        Panel3.Hide()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles count.Click
        conn.Open()
        cmd = New MySqlCommand("SELECT count(*) FROM `tbl_info` ", conn)

        Dim count1 = Convert.ToString(cmd.ExecuteScalar)

        count.Text = count1
        conn.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Panel6.Show()
        Panel7.Hide()
        Panel9.Hide()
        Panel3.Hide()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Panel6.Show()
        Panel7.Hide()
        Panel9.Hide()
        Panel3.Hide()
    End Sub

<<<<<<< HEAD
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_info WHERE FIRSTNAME LIKE '%" & search.Text & "%' OR MIDDLENAME LIKE '%" & search.Text & "%' OR LASTNAME LIKE '%" & search.Text & "%' OR ADDRESS LIKE '%" & search.Text & "%' OR GENDER LIKE '%" & search.Text & "%' OR COURSE LIKE '%" & search.Text & "%' OR YEAR LIKE '%" & search.Text & "%' OR SECTION LIKE '%" & search.Text & "%' OR STATUS LIKE '%" & search.Text & "%' OR BDATE LIKE '%" & search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("STUDENT_ID"), dr.Item("FIRSTNAME"), dr.Item("MIDDLENAME"), dr.Item("LASTNAME"), dr.Item("ADDRESS"), dr.Item("GENDER"), dr.Item("COURSE"), dr.Item("YEAR"), dr.Item("SECTION"), dr.Item("STATUS"), dr.Item("BDATE"))
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

=======
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
>>>>>>> 85587a0fb1db1c9130bd7322d552955d37f4379a
End Class
