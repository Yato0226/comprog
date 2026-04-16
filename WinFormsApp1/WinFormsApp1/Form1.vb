Imports System.Linq.Expressions

Public Class Form1
    Private Sub Draw_Click() Handles Button1.Click
        Dim mynumber As Integer
        Dim name As String
        Dim age As Integer
        name = TextBox1.Text
        If Not Integer.TryParse(TextBox2.Text, age) Or String.IsNullOrWhiteSpace(name) Then
            Label2.Text = "Please enter your name and a valid age!"
            Exit Sub
        End If
        Dim bool As Boolean
        bool = (name = name) And (age = age)
        If bool = True Then
            mynumber = Int(Rnd() * 200) + 1
            Label1.Text = mynumber

            If (mynumber > 120) And (age > 50) Then
                Label2.Text = " Congratulations! You win a prize!"
            Else
                Label2.Text = " Sorry, you lose. Try again!"
            End If
        End If
    End Sub
End Class
