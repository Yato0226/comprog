Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Variable Declarations
        Dim Name As String
        Dim YearSection As String
        Dim Address As String

        ' Variable Assignments
        Name = "Galang, Louize Christopher S."
        YearSection = "1A"
        Address = "Harmony Hills 1, Muzon. Bulacan"

        ' Output
        MsgBox(Name & vbCrLf & YearSection & vbCrLf & Address)
    End Sub
End Class