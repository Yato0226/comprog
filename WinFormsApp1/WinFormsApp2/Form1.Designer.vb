<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel2 = New Panel()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(507, 224)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "DRAW"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(344, 213)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(371, 391)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(52, 376)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(690, 49)
        Panel1.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(308, 116)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(308, 157)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(190, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 20)
        Label3.TabIndex = 6
        Label3.Text = "NAME :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(190, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 20)
        Label4.TabIndex = 7
        Label4.Text = "AGE"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Pink
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(64, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(665, 65)
        Label5.TabIndex = 8
        Label5.Text = "PLEASE ENTER YOUR NAME AND AGE THEN DRAW YOUR LUCKY NUMBER"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(146, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(176, 20)
        Label6.TabIndex = 9
        Label6.Text = "YOUR LUCKY NUMBER IS:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(322, 334)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 20)
        Label7.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(328, 201)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(81, 43)
        Panel2.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Form1"
        Text = "`"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel

End Class
