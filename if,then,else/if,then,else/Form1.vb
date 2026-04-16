Public Class Form1
    Private Sub BUtton(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mynumber As Integer
        mynumber = TextBox1.Text
        If mynumber > 100 Then
            Label1.Text = "You win"
        End If
    End Sub

End Class
