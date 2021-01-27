Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String = Nothing
        Dim password As String = Nothing
        username = TextBox1.Text
        password = TextBox2.Text
        If username = "admin" And password = "admin123" Then
            Form2.Show()
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()
            MessageBox.Show("You are now accessing the system as Admin.", "Access Granted!")
        Else
            MessageBox.Show("You may use the 'Login As Guest' to access the system", "Access Denied!")
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
