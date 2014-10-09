Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ComboBox1.Text = "1st" And ComboBox2.Text = "ECE") Then
            Form3.Visible = True
        ElseIf (ComboBox1.Text = "1st" And ComboBox2.Text = "EE") Then
            Form4.Visible = True
        ElseIf (ComboBox1.Text = "1st" And ComboBox2.Text = "EEE") Then
            Form5.Visible = True
        ElseIf (ComboBox1.Text = "1st" And ComboBox2.Text = "CS") Then
            Form6.Visible = True
        ElseIf (ComboBox1.Text = "1st" And ComboBox2.Text = "IT") Then
            Form7.Visible = True
        ElseIf (ComboBox1.Text = "2nd" And ComboBox2.Text = "ECE") Then
            Form8.Visible = True
        ElseIf (ComboBox1.Text = "2nd" And ComboBox2.Text = "EE") Then
            Form9.Visible = True
        ElseIf (ComboBox1.Text = "2nd" And ComboBox2.Text = "EEE") Then
            Form10.Visible = True
        ElseIf (ComboBox1.Text = "2nd" And ComboBox2.Text = "CS") Then
            Form11.Visible = True
        ElseIf (ComboBox1.Text = "2nd" And ComboBox2.Text = "IT") Then
            Form12.Visible = True
        ElseIf (ComboBox1.Text = "3rd" And ComboBox2.Text = "ECE") Then
            Form13.Visible = True
        ElseIf (ComboBox1.Text = "3rd" And ComboBox2.Text = "EE") Then
            Form14.Visible = True
        ElseIf (ComboBox1.Text = "3rd" And ComboBox2.Text = "CS") Then
            Form16.Visible = True
        ElseIf (ComboBox1.Text = "3rd" And ComboBox2.Text = "IT") Then
            Form17.Visible = True
        ElseIf (ComboBox1.Text = "4th" And ComboBox2.Text = "ECE") Then
            Form18.Visible = True
        ElseIf (ComboBox1.Text = "4th" And ComboBox2.Text = "EE") Then
            Form19.Visible = True
        ElseIf (ComboBox1.Text = "4th" And ComboBox2.Text = "CS") Then
            Form20.Visible = True
        ElseIf (ComboBox1.Text = "4th" And ComboBox2.Text = "IT") Then
            Form15.Visible = True
            Me.Hide()
        Else
            MsgBox("slection error")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class