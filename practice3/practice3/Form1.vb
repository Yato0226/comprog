Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim num1 As Integer = Val(TextBox1.Text)
        'Dim num2 As Integer = Val(TextBox2.Text)
        'Dim sum As Integer = num1 + num2
        'MsgBox($"The sum is {sum}")
        MsgBox("the sum is " & Val(TextBox1.Text) + Val(TextBox2.Text))
    End Sub
End Class