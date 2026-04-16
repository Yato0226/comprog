Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Name As String
        Dim yearnsection As String
        Dim cnd As String

        Name = "Galang, Louize Christopher S."
        yearnsection = "1A"
        cnd = "College of Engineering, Department of Mechatronics Engineering"

        MsgBox("My name is " & Name)
        MsgBox("I'm " & yearnsection)
        MsgBox("From " & cnd)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Name As String
        Dim yns As String
        Dim cnd As String

        Name = "Nikkolas Daniell C. Bravo"
        yns = "1A"
        cnd = "College of Engineering, Mechatronics Department"

        MsgBox("My name is " & Name)
        MsgBox("I'm " & yns)
        MsgBox("From " & cnd)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String
        Dim YearandSection As String
        Dim Collegeanddepartment As String

        Name = "Bayumbon, Rich Gabriel DC. "
        YearandSection = "1A"
        Collegeanddepartment = "College of Engineering, Mechatronics Engineering"

        MsgBox("My Name is " & Name)
        MsgBox("I'm " & YearandSection)
        MsgBox("From " & Collegeanddepartment)

    End Sub
End Class

