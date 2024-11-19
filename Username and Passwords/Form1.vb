

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox_pass.Text = "0bnoxiousN0x!" Then
            ' Hide Form1 but keep it open
            Me.Hide()
            ' Show Form2 without making it a dialog
            Dim mainForm As New Form2()
            mainForm.Show()
        Else
            MessageBox.Show("Password is incorrect. Please try again.")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Perform cleanup tasks here
        ' Ensure the application exits completely
        Application.Exit()
    End Sub

    Private Sub TextBox_pass_TextChanged(sender As Object, e As EventArgs) Handles TextBox_pass.TextChanged

    End Sub
End Class
