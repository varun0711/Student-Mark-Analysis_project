Public Class Form1

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "varun" And TextBox2.Text = "123456") Then
            Form2.Visible = True
            Me.Hide()
        Else
            MsgBox("check ur admin name or password")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
