Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox11.Text
        Dim gns As String = TextBox12.Text
        Dim FinalGrade As Integer = Label21.Text


        Label11.Text = (((Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)) / 90) * 100)
        Label13.Text = (Val(TextBox4.Text) + Val(TextBox5.Text))
        Label17.Text = (((Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)) / 90) * 100)
        Label21.Text = (Val(Label11.Text) * 0.3) + (Val(Label13.Text) * 0.3) + (Val(Label17.Text) * 0.3) + Val(TextBox9.Text) + Val(TextBox10.Text)

        FinalGrade = Label21.Text
        If (FinalGrade >= 96.5) Then
            Label23.Text = "1"
            Label25.Text = "Passed"
        ElseIf (FinalGrade >= 93.5) Then
            Label23.Text = "1.25"
            Label25.Text = "Passed"
        ElseIf (FinalGrade >= 90.5) Then
            Label23.Text = "1.5"
            Label25.Text = "Passed"
        ElseIf (FinalGrade >= 87.5) Then
            Label23.Text = "1.75"
            Label25.Text = "Passed"
        ElseIf (FinalGrade >= 84.5) Then
            Label23.Text = "2"
            Label25.Text = "Passed"
        ElseIf (FinalGrade >= 81.5) Then
            Label23.Text = "2.25"
            Label25.Text = "Passed"
        ElseIf (FinalGrade >= 78.5) Then
            Label23.Text = "2.5"
            Label25.Text = "Passed"
        ElseIf (FinalGrade >= 75.5) Then
            Label23.Text = "2.75"
            Label25.Text = "Passed"
        ElseIf (FinalGrade >= 75) Then
            Label23.Text = "3"
            Label25.Text = "Passed"
        Else
            Label23.Text = "0"
            Label25.Text = "Failed"
        End If

        MsgBox($"Name:{name}{vbCr}Grade and Section: {gns}{vbCr} Your Grade is {FinalGrade}{vbCr} Equivalent of {Label23.Text} or {Label25.Text}")


    End Sub
End Class
