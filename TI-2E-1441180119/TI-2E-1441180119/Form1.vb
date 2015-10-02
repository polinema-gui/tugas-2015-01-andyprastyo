Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.Yellow
        ElseIf Me.BackColor = Color.Yellow Then
            Me.BackColor = Color.Blue
        End If
    End Sub
End Class
