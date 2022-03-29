Public Class Form1
    Dim n1, n2, ans, temp, count As Decimal
    Dim sign As Char
    Sub New()
        InitializeComponent()
        count = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.AppendText("1")
        'If (count = 0) Then
        'TempBox1.AppendText("1")
        'ElseIf (count = 1) Then
        'TempBox2.AppendText("1")
        'End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.AppendText("2")
        'If (count = 0) Then
        'TempBox1.AppendText("2")
        'ElseIf (count = 1) Then
        'TempBox2.AppendText("2")
        'End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.AppendText("3")
        'If (count = 0) Then
        'TempBox1.AppendText("3")
        'ElseIf (count = 1) Then
        ' TempBox2.AppendText("3")
        ' End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.AppendText("4")
        ' If (count = 0) Then
        'TempBox1.AppendText("4")
        'ElseIf (count = 1) Then
        ' TempBox2.AppendText("4")
        'End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.AppendText("5")
        '  If (count = 0) Then
        ' TempBox1.AppendText("5")
        'ElseIf (count = 1) Then
        'TempBox2.AppendText("5")
        ' End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.AppendText("6")
        'If (count = 0) Then
        'TempBox1.AppendText("6")
        'ElseIf (count = 1) Then
        'TempBox2.AppendText("6")
        'End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.AppendText("7")
        'If (count = 0) Then
        'TempBox1.AppendText("7")
        'ElseIf (count = 1) Then
        'TempBox2.AppendText("7")
        ' End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.AppendText("8")
        'If (count = 0) Then
        ' TempBox1.AppendText("8")
        ' ElseIf (count = 1) Then
        ' TempBox2.AppendText("8")
        ' End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.AppendText("9")
        ' If (count = 0) Then
        ' TempBox1.AppendText("9")
        ' ElseIf (count = 1) Then
        ' TempBox2.AppendText("9")
        ' End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.AppendText("0")
        'If (count = 0) Then
        'TempBox1.AppendText("0")
        'ElseIf (count = 1) Then
        'TempBox2.AppendText("0")
        'End If
    End Sub
    Private Sub ButtonDot_Click(sender As Object, e As EventArgs) Handles ButtonDot.Click
        TextBox1.AppendText(".")
        'If (count = 0) Then
        'TempBox1.AppendText(".")
        'ElseIf (count = 1) Then
        ' TempBox2.AppendText(".")
        'End If
    End Sub
    Private Sub ButtonCle_Click(sender As Object, e As EventArgs) Handles ButtonCle.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
    Private Sub ButtonBac_Click(sender As Object, e As EventArgs) Handles ButtonBac.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
    End Sub
    Private Sub ButtonMul_Click(sender As Object, e As EventArgs) Handles ButtonMul.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("/") Or TextBox1.Text.EndsWith("x") Or TextBox1.Text.EndsWith("-")) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
        TextBox1.AppendText("x")
    End Sub
    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("/") Or TextBox1.Text.EndsWith("x") Or TextBox1.Text.EndsWith("-")) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
        TextBox1.AppendText("/")
        'OpBox1.Text = "/"
        'If (count = 0) Then
        'count += 1
        'Else
        '   n1 = TempBox1.Text
        '   n2 = TempBox2.Text
        '   sign = OpBox1.Text
        '   Select Case sign
        '  Case "+"
        ' ans = n1 + n2
        'Case "-"
        'ans = n1 - n2
        'Case "*"
        'ans = n1 * n2
        'Case "/"
        'ans = n1 / n2
        'End Select
        '   TempBox1.Text = ans
        'count += 1
        'End If
    End Sub
    Private Sub ButtonPlu_Click(sender As Object, e As EventArgs) Handles ButtonPlu.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("/") Or TextBox1.Text.EndsWith("x") Or TextBox1.Text.EndsWith("-")) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
        TextBox1.AppendText("+")
        'OpBox1.Text = "+"
        'If (count = 0) Then
        'count += 1
        'Else
        '   n1 = TempBox1.Text
        '   n2 = TempBox2.Text
        '   sign = OpBox1.Text
        'Select Case sign
        'Case "+"
        'ans = n1 + n2
        'Case "-"
        'ans = n1 - n2
        'Case "*"
        'ans = n1 * n2
        'Case "/"
        'ans = n1 / n2
        'End Select
        '   TempBox1.Text = ans
        'count += 1
        'End If
    End Sub
    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("/") Or TextBox1.Text.EndsWith("x") Or TextBox1.Text.EndsWith("-")) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
        TextBox1.AppendText("-")
        'OpBox1.Text = "-"
        'If (count = 0) Then
        ' count += 1
        'Else
        '   n1 = TempBox1.Text
        '  n2 = TempBox2.Text
        ' sign = OpBox1.Text
        'Select Case sign
        'Case "+"
        'ans = n1 + n2
        'Case "-"
        'ans = n1 - n2
        'Case "*"
        'ans = n1 * n2
        'Case "/"
        'ans = n1 / n2
        'End Select
        'TempBox1.Text = ans
        'count += 1
        'End If
    End Sub
    Private Sub ButtonEqu_Click(sender As Object, e As EventArgs) Handles ButtonEqu.Click
        'n1 = TempBox1.Text
        'n2 = TempBox2.Text
        'sign = OpBox1.Text
        'Select Case sign
        ' Case "+"
        'ans = n1 + n2
        'Case "-"
        'ans = n1 - n2
        'Case "*"
        'ans = n1 * n2
        'Case "/"
        'ans = n1 / n2
        'End Select
        'TextBox3.Text = TextBox2.Text
        'TextBox2.Text = TextBox1.Text
        'TextBox1.Text = ans
    End Sub
End Class