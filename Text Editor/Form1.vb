Imports System.Drawing.Printing
Imports System.IO

Public Class Form1
    Dim ind As Byte = 0
    Dim url As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim NextForm As New Form1
        NextForm.ShowDialog()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim MyStream As Stream = Nothing
        OpenFileDialog1.Filter = "Text File (*.txt)|*.txt| AllFiles(*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True

        If (OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (OpenFileDialog1.FileName.Length > 0) Then
            Try
                MyStream = OpenFileDialog1.OpenFile
                If (MyStream IsNot Nothing) Then
                    RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                    url = OpenFileDialog1.FileName
                End If
            Catch ex As Exception
                MessageBox.Show("Cannot read file from disk" & ex.Message)
            Finally
                If (MyStream IsNot Nothing) Then
                    ind = 1
                    MyStream.Close()

                End If
            End Try
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Title = "Save"
        SaveFileDialog1.CheckFileExists = False
        SaveFileDialog1.CheckPathExists = False
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text File (*.txt)|*.txt| AllFiles(*.*)|*.*"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True

        If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Title = "Save"
        SaveFileDialog1.CheckFileExists = True
        SaveFileDialog1.CheckPathExists = True
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text File (*.txt)|*.txt| AllFiles(*.*)|*.*"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True

        Try
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)

        Catch ex As Exception
            Call SaveAsToolStripMenuItem_Click(Me, e)
        End Try
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        If RichTextBox1.SelectionLength > 0 Then
            RichTextBox1.Copy()
        End If

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        If RichTextBox1.SelectionLength > 0 Then
            RichTextBox1.Cut()
        End If

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If RichTextBox1.SelectionLength > 0 Then
            RichTextBox1.Text = ""
        End If

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()

    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        RichTextBox1.SelectedText = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.Font = RichTextBox1.Font
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font

    End Sub


    ' Handles the Print menu item click event
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Me.TopMost = True ' Temporarily keep the form on top
        Me.WindowState = FormWindowState.Normal ' Ensure form is in normal state before printing
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If

        ' Bring the form back to foreground
        Me.TopMost = False ' Reset the TopMost property
        Me.Show()
        Me.Activate()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Pull text from RichTextBox1 and set it to be printed
        Dim textToPrint As String = RichTextBox1.Text
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        ' Draw the text on the print page
        e.Graphics.DrawString(textToPrint, font, brush, 100, 100)

        ' Make sure this is the only page to print
        e.HasMorePages = False


    End Sub
End Class
