Public Class Form1
    Private Sub OS() Handles Button1.Click
        'declaration
        Dim StrBrand As String
        Dim StrModel As String
        Dim IntBattery As Integer
        Dim DoubScreenSize As Double
        Dim DecPrice As Decimal
        Dim BoolAvailability As Boolean
        'defining
        StrBrand = "Apple"
        StrModel = "Iphone"
        IntBattery = 3692
        DoubScreenSize = 6.3
        DecPrice = 54990
        BoolAvailability = 1 'It can be True or 1
        'Show msgBox
        MsgBox($"{StrBrand}  {StrModel}  {IntBattery}  {DoubScreenSize}  {DecPrice}  {BoolAvailability}") 'Optimized
        'MsgBox($"{StrBrand} {StrModel} - Battery: {IntBattery}, Screen Size: {DoubScreenSize:#0.##'} Price:
        '${DecPrice}, Available? {BoolAvailability}") 'Better for eyes
        MsgBox($"{StrBrand}{vbCr}{StrModel}{vbCr}{IntBattery}{vbCr}{DoubScreenSize}{vbCr}{DecPrice}{vbCr}{BoolAvailability}")
    End Sub
End Class
