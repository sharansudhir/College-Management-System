Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "ADMIN" Or TextBox1.Text = "admin" Then
            If TextBox2.Text = "ADMIN" Or TextBox2.Text = "admin" Then
                Form3.Show()
                Me.Hide()
            Else
                MessageBox.Show("ENTER VALID PASSWORD")
            End If
        Else
            MessageBox.Show("ENTER VALID USERNAME")
        End If
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("FILL LOGIN ID AND PASSWORD FIELD")
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class