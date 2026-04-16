Public Class Form1
    Private Sub Draw_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Check if the TextBoxes are empty first
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter both your Name and Age before drawing!")
            Exit Sub ' This stops the code from running further
        End If

        ' 2. Initialize variables
        Dim mynumber As Integer
        Dim name As String = TextBox1.Text
        Dim age As Integer

        ' 3. Use Integer.TryParse to prevent the program from crashing 
        ' if someone types letters into the Age box
        If Not Integer.TryParse(TextBox2.Text, age) Then
            MessageBox.Show("Please enter a valid number for Age.")
            Exit Sub
        End If

        ' 4. Generate the random number
        ' (Randomize ensures the number is different every time you open the app)
        Randomize()
        mynumber = Int(Rnd() * 200) + 1
        Label1.Text = mynumber.ToString()

        ' 5. Prize Logic
        If (mynumber > 120) And (age > 50) Then
            Label2.Text = "Congratulations! You win a prize!"
        Else
            ' This covers both (mynumber > 120 and age < 50) AND (mynumber <= 120)
            Label2.Text = "Sorry, you lose. Try again!"
        End If
    End Sub
End Class