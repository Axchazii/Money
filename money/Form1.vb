Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("กรุณากรอกจำนวน", MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        Else
            Dim a, b As Integer
            Dim c As Double

            a = Integer.Parse(TextBox1.Text)

            Select Case a
                Case 1 To 10000
                    b = 0
                Case 10001 To 14999
                    b = 7
                Case 15000 To 29999
                    b = 12
                Case Is >= 30000
                    b = 15
            End Select

            c = (a * b) / 100
            TextBox2.Text = c.ToString()

            c = a - c
            TextBox3.Text = c.ToString()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("กรุณากรอกเฉพาะตัวเลข", MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

End Class
