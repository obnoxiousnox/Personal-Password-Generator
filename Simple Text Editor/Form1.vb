Imports System.Drawing.Printing
Public Class Form1

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
        MsgBox("This is a simple text editor", MsgBoxStyle.Information)
    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        With PrintDialog1
            .PrinterSettings = PrintDocument1.PrinterSettings
            .Document = PrintDocument1

            .AllowSomePages = True
            .PrinterSettings.MinimumPage = 1
            .PrinterSettings.MaximumPage = 9999
            .PrinterSettings.FromPage = 1
            .PrinterSettings.ToPage = 9999

            If DialogResult.OK = .ShowDialog() Then
                PrintDocument1.PrinterSettings = .PrinterSettings
                Try
                    PrintDocument1.Print()
                Catch ex As InvalidPrinterException
                    MessageBox.Show(ex.Message, "Invalid Printer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("There was a problem printing the file." & ControlChars.NewLine & ex.Message, "Printing file error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End With


    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)

    End Sub




    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        With PrintDialog1
            .PrinterSettings = PrintDocument1.PrinterSettings
            .Document = PrintDocument1

            .AllowSomePages = True
            .PrinterSettings.MinimumPage = 1
            .PrinterSettings.MaximumPage = 9999
            .PrinterSettings.FromPage = 1
            .PrinterSettings.ToPage = 9999

            If DialogResult.OK = .ShowDialog() Then
                PrintDocument1.PrinterSettings = .PrinterSettings
                Try
                    PrintDocument1.Print()
                Catch ex As InvalidPrinterException
                    MessageBox.Show(ex.Message, "Invalid Printer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("There was a problem printing the file." & ControlChars.NewLine & ex.Message, "Printing file error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End With


    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
