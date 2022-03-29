Public Class Form1
    Dim n1, n2, ans As Decimal
    Dim sign As Char
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "1")
        Else
            TextBox1.AppendText("1")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "2")
        Else
            TextBox1.AppendText("2")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "3")
        Else
            TextBox1.AppendText("3")
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "4")
        Else
            TextBox1.AppendText("4")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "5")
        Else
            TextBox1.AppendText("5")
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "6")
        Else
            TextBox1.AppendText("6")
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "7")
        Else
            TextBox1.AppendText("7")
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "8")
        Else
            TextBox1.AppendText("8")
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "9")
        Else
            TextBox1.AppendText("9")
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & "0")
        Else
            TextBox1.AppendText("0")
        End If
    End Sub
    Private Sub ButtonDot_Click(sender As Object, e As EventArgs) Handles ButtonDot.Click
        If (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("x") Or TextBox1.Text.EndsWith("/")) Then
            sign = TextBox1.Text(TextBox1.Text.Length - 1)
            TextBox1.AppendText(vbCrLf & ".")
        ElseIf (TextBox1.Text.EndsWith("0") Or TextBox1.Text.EndsWith("1") Or TextBox1.Text.EndsWith("2") Or TextBox1.Text.EndsWith("3") Or TextBox1.Text.EndsWith("4") Or TextBox1.Text.EndsWith("5") Or TextBox1.Text.EndsWith("6") Or TextBox1.Text.EndsWith("7") Or TextBox1.Text.EndsWith("8") Or TextBox1.Text.EndsWith("9") Or TextBox1.Text.EndsWith("0")) Then
            TextBox1.AppendText(".")
        Else
            TextBox1.AppendText("0.")
        End If
    End Sub
    Private Sub ButtonCle_Click(sender As Object, e As EventArgs) Handles ButtonCle.Click
        TextBox1.Clear()
        TempBox2.Clear()
        TempBox1.Clear()
    End Sub
    Private Sub ButtonMul_Click(sender As Object, e As EventArgs) Handles ButtonMul.Click
        TempBox1.Text = TextBox1.Lines.First
        If (TextBox1.Text.EndsWith("0") Or TextBox1.Text.EndsWith("1") Or TextBox1.Text.EndsWith("2") Or TextBox1.Text.EndsWith("3") Or TextBox1.Text.EndsWith("4") Or TextBox1.Text.EndsWith("5") Or TextBox1.Text.EndsWith("6") Or TextBox1.Text.EndsWith("7") Or TextBox1.Text.EndsWith("8") Or TextBox1.Text.EndsWith("9") Or TextBox1.Text.EndsWith("0")) Then
            TextBox1.AppendText(vbCrLf & "*")
            OpBox.Text = "*"
        ElseIf (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
            TextBox1.AppendText("*")
            OpBox.Text = "*"
        End If
    End Sub
    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        TempBox1.Text = TextBox1.Lines.First
        If (TextBox1.Text.EndsWith("0") Or TextBox1.Text.EndsWith("1") Or TextBox1.Text.EndsWith("2") Or TextBox1.Text.EndsWith("3") Or TextBox1.Text.EndsWith("4") Or TextBox1.Text.EndsWith("5") Or TextBox1.Text.EndsWith("6") Or TextBox1.Text.EndsWith("7") Or TextBox1.Text.EndsWith("8") Or TextBox1.Text.EndsWith("9") Or TextBox1.Text.EndsWith("0")) Then
            TextBox1.AppendText(vbCrLf & "/")
            OpBox.Text = "/"
        ElseIf (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
            TextBox1.AppendText("/")
            OpBox.Text = "/"
        End If
    End Sub
    Private Sub ButtonPlu_Click(sender As Object, e As EventArgs) Handles ButtonPlu.Click
        TempBox1.Text = TextBox1.Lines.First
        If (TextBox1.Text.EndsWith("0") Or TextBox1.Text.EndsWith("1") Or TextBox1.Text.EndsWith("2") Or TextBox1.Text.EndsWith("3") Or TextBox1.Text.EndsWith("4") Or TextBox1.Text.EndsWith("5") Or TextBox1.Text.EndsWith("6") Or TextBox1.Text.EndsWith("7") Or TextBox1.Text.EndsWith("8") Or TextBox1.Text.EndsWith("9") Or TextBox1.Text.EndsWith("0")) Then
            TextBox1.AppendText(vbCrLf & "+")
            OpBox.Text = "+"
        ElseIf (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
            TextBox1.AppendText("+")
            OpBox.Text = "+"
        End If
    End Sub
    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        TempBox1.Text = TextBox1.Lines.First
        If (TextBox1.Text.EndsWith("0") Or TextBox1.Text.EndsWith("1") Or TextBox1.Text.EndsWith("2") Or TextBox1.Text.EndsWith("3") Or TextBox1.Text.EndsWith("4") Or TextBox1.Text.EndsWith("5") Or TextBox1.Text.EndsWith("6") Or TextBox1.Text.EndsWith("7") Or TextBox1.Text.EndsWith("8") Or TextBox1.Text.EndsWith("9") Or TextBox1.Text.EndsWith("0")) Then
            TextBox1.AppendText(vbCrLf & "-")
            OpBox.Text = "-"
        ElseIf (TextBox1.Text.EndsWith("+") Or TextBox1.Text.EndsWith("-") Or TextBox1.Text.EndsWith("*") Or TextBox1.Text.EndsWith("/")) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
            TextBox1.AppendText("-")
            OpBox.Text = "-"
        End If
    End Sub
    Private Sub ButtonEqu_Click(sender As Object, e As EventArgs) Handles ButtonEqu.Click
        TempBox2.Text = TextBox1.Lines.Last
        sign = OpBox.Text
        n1 = TempBox1.Text
        n2 = TempBox2.Text
        Select Case sign
            Case "+"
                ans = n1 + n2
            Case "-"
                ans = n1 - n2
            Case "*"
                ans = n1 * n2
            Case "/"
                ans = n1 / n2
        End Select
        TextBox1.Text = ans
    End Sub
End Class