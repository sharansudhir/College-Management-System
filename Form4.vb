Public Class Form4

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "ADMIN" Or TextBox1.Text = "admin" Then
            If TextBox2.Text = "ADMIN" Or TextBox2.Text = "admin" Then
                Form5.Show()
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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class