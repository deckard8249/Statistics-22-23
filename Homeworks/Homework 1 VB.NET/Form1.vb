Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ProgressBar1.Value += 10

        If ProgressBar1.Value = 100 Then
            Me.Button4.Text = "DONE"
            Me.Button4.BackColor = Color.Green
            Button4.Enabled = False
        Else
            Me.Button4.Text = "KEEP GOING"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = "Hello, this is a button"
        RichTextBox1.BackColor = Color.Yellow
    End Sub


    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
        RichTextBox1.BackColor = Color.Red
    End Sub
End Class
