Imports System.Data.SqlClient
Public Class Form10
    Dim connection As New SqlConnection("server=LAPTOP-65CFKQN7;database=college;integrated security=true")

    Private Sub Form10_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("select * from CST", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        Filterdata("")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Filterdata(TextBox1.Text)
        Dim connection As New SqlConnection("server=LAPTOP-65CFKQN7;database=college;integrated security=true")

    End Sub

    Public Sub Filterdata(valueToSearch As String)


        Dim searchQuery As String = "select * from CST where CONCAT(USN,Name,Sports,Cultural,Technical,[Sports Attendance(%)],[Cultural Attendance(%)],[Technical Attendance(%)]) like '%" & valueToSearch & "%'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Filterdata(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class