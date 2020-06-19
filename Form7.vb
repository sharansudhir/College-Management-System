Imports System.Data.SqlClient
Public Class Form7
    Dim connection As New SqlConnection("server=LAPTOP-65CFKQN7;database=college;integrated security=true")

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("select * from OS", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        Filterdata("")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim connection As New SqlConnection("server=LAPTOP-65CFKQN7;database=college;integrated security=true")

        Dim Command As New SqlCommand("insert into OS(USN,Name,[Practical Marks(out of 50)],[Theory Marks(out of 50)],[Task(out of 10)],[Attendance(%)])values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", connection)
        connection.Open()
        If Command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Student Added")
        Else
            MessageBox.Show("Student Not Added")

            connection.Close()

        End If
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim connection As New SqlConnection("server=LAPTOP-65CFKQN7;database=college;integrated security=true")

        Dim command As New SqlCommand("delete from OS where USN = @USN", connection)

        command.Parameters.Add("@USN", SqlDbType.NVarChar).Value = TextBox7.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Student Deleted")
        Else
            MessageBox.Show("Student Not Deleted")

        End If

        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Filterdata(TextBox8.Text)
        Dim connection As New SqlConnection("server=LAPTOP-65CFKQN7;database=college;integrated security=true")
    End Sub
    Public Sub Filterdata(valueToSearch As String)


        Dim searchQuery As String = "select * from OS where CONCAT(USN,Name,[Practical Marks(out of 50)],[Theory Marks(out of 50)],[Task(out of 10)],[Attendance(%)]) like '%" & valueToSearch & "%'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged
        Filterdata(TextBox8.Text)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class