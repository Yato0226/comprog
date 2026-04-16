Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "+"
        Label3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "*"
        Label3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "-"
        Label3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "/"
        If Val(TextBox2.Text) <> 0 Then
            Label3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        Else
            Label3.Text = "Error: Div by 0"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "?"
        Label3.Text = "Waiting..."
    End Sub

End Class
