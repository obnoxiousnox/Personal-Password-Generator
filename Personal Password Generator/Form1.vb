Imports System.Text

Public Class Form1
#Region "Variables"

    Private TimeHours As Integer = 0
    Private TimeMinutes As Integer = 0
    Private TimeSeconds2 As Integer = 0

    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
#End Region
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If txtNumbers.Text < 8 Then
            MsgBox("Invalid length", MsgBoxStyle.Information, "Error!")
            'MsgBox("Length must be at least 8")
            txtNumbers.Text = 8
            Exit Sub
        Else
        End If

        TimeHours = 0
        TimeMinutes = 0
        TimeSeconds2 = 0
        txtTime.Text = "Elapsed time to generate password: " & TimeHours & " h, " & TimeMinutes & "m, " & TimeSeconds2 & " s"

        TimerCreatePass.Enabled = True
        TimerTime.Enabled = True
        TimerColor.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Personal Password Generator - " &
            My.Application.Info.Version.ToString


    End Sub

    Private Sub TimerCreatePass_Tick(sender As Object, e As EventArgs) Handles TimerCreatePass.Tick
        Dim numUpperV, numLowerV, numNumbersV, numSpecialV As Integer
        numUpperV = 3
        numLowerV = 2
        numNumbersV = 2
        numSpecialV = 1

        Dim s As String = txtCharacters.Text
        Dim r As New Random
        Dim sb As New StringBuilder
        Dim NumberOfCharacters As Integer = Len(txtCharacters.Text)
        For i As Integer = 1 To txtNumbers.Text
            Dim idx As Integer = r.Next(0, NumberOfCharacters)
            sb.Append(s.Substring(idx, 1))
        Next
        txtShowPassword.Text = sb.ToString

        If ValidatePassword(txtShowPassword.Text, txtNumbers.Text, numUpperV, numLowerV, numNumbersV, numSpecialV) = True Then
            txtValidatePass.Text = "Generated password has been validated."
            txtTime.Text = "Elapsed time to generate password: " & TimeHours & " h " & TimeMinutes & " m, " & TimeSeconds2 & " s"

            TimerCreatePass.Enabled = False
            TimerTime.Enabled = False
            TimerColor.Enabled = False
        Else
            txtValidatePass.Text = "Entry length not acceptable. Please enter a new length."
        End If
    End Sub

    Function ValidatePassword(ByVal pwd As String, ByVal minLength As Integer, ByVal numUpper As Integer, ByVal numLower As Integer, ByVal numNumbers As Integer, ByVal numSpecial As Integer) As Boolean

        'Declare upper and lower letters, numbers and special characters

        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        'Check the length. If it's not 8, then return the match as false
        If Len(pwd) < minLength Then Return False

        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        'If the length is 8 or more, then return True
        Return True

    End Function

    Private Sub txtValidatePass_TextChanged(sender As Object, e As EventArgs) Handles txtValidatePass.TextChanged

    End Sub

    Private Sub txtNumbers_TextChanged(sender As Object, e As EventArgs) Handles txtNumbers.TextChanged


        If txtNumbers.Text = "" Then
            txtNumbers.Text = 8
        End If

    End Sub

    Private Sub TimerTime_Tick(sender As Object, e As EventArgs) Handles TimerTime.Tick
        txtValidatePass.ForeColor = Color.Green
        txtTime.Text = "Approximate time for password generation: " & TimeHours & "h, " & TimeMinutes & "m, " & TimeSeconds2 & " s"
        If TimeSeconds2 = 60 Then
            TimeMinutes = TimeMinutes + 1
            If TimeMinutes = 60 Then
                TimeHours = TimeHours + 1
                TimeMinutes = 0
            End If
            TimeSeconds2 = 0
        End If
        TimeSeconds2 += 1
    End Sub

    Private Sub TimerColor_Tick(sender As Object, e As EventArgs) Handles TimerColor.Tick
        txtValidatePass.ForeColor = Color.Black
    End Sub
    Public Class Form1


    End Class
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(txtShowPassword.Text)
        'MessageBox.Show("Password copied to clipboard!")
        MsgBox("Password has been copied to clipboard. Note that some websites might not allow copying and pasting of passwords.", MsgBoxStyle.Information, "Copied")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox("Created by Steve LeMaster 11/17/2024")

        MsgBox("Created by Steve LeMaster 11/17/2024", MsgBoxStyle.Information, "About")
    End Sub

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged

    End Sub
End Class
