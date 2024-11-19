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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtShowPassword = New TextBox()
        btnGenerate = New Button()
        Label2 = New Label()
        txtCharacters = New TextBox()
        Label3 = New Label()
        txtNumbers = New TextBox()
        txtValidatePass = New TextBox()
        Label1 = New Label()
        txtTime = New TextBox()
        TimerCreatePass = New Timer(components)
        TimerTime = New Timer(components)
        TimerColor = New Timer(components)
        btnCopy = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtShowPassword
        ' 
        txtShowPassword.Location = New Point(12, 214)
        txtShowPassword.Name = "txtShowPassword"
        txtShowPassword.Size = New Size(776, 23)
        txtShowPassword.TabIndex = 2
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.Maroon
        btnGenerate.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerate.ForeColor = Color.White
        btnGenerate.Location = New Point(277, 136)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(218, 68)
        btnGenerate.TabIndex = 2
        btnGenerate.Text = "Generate Password"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(507, 20)
        Label2.TabIndex = 3
        Label2.Text = "The alphanumeric string below will be used to generate your password:"
        ' 
        ' txtCharacters
        ' 
        txtCharacters.Location = New Point(12, 42)
        txtCharacters.Name = "txtCharacters"
        txtCharacters.Size = New Size(471, 23)
        txtCharacters.TabIndex = 4
        txtCharacters.Text = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz01!2@3#4$5%6&7*89"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(554, 20)
        Label3.TabIndex = 5
        Label3.Text = "Enter the length you want for your new password (Minimum of 8 is required):"
        ' 
        ' txtNumbers
        ' 
        txtNumbers.Location = New Point(586, 80)
        txtNumbers.Name = "txtNumbers"
        txtNumbers.Size = New Size(67, 23)
        txtNumbers.TabIndex = 1
        txtNumbers.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtValidatePass
        ' 
        txtValidatePass.Location = New Point(12, 290)
        txtValidatePass.Name = "txtValidatePass"
        txtValidatePass.Size = New Size(338, 23)
        txtValidatePass.TabIndex = 3
        txtValidatePass.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 266)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 21)
        Label1.TabIndex = 8
        Label1.Text = "Password validation:"
        ' 
        ' txtTime
        ' 
        txtTime.Location = New Point(12, 342)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(776, 23)
        txtTime.TabIndex = 9
        txtTime.Text = "Elapsed time to generate password:"
        txtTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' TimerCreatePass
        ' 
        ' 
        ' TimerTime
        ' 
        ' 
        ' TimerColor
        ' 
        ' 
        ' btnCopy
        ' 
        btnCopy.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCopy.Location = New Point(713, 243)
        btnCopy.Name = "btnCopy"
        btnCopy.Size = New Size(75, 49)
        btnCopy.TabIndex = 10
        btnCopy.Text = "Copy"
        btnCopy.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(713, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 32)
        Button1.TabIndex = 11
        Button1.Text = "About"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 385)
        Controls.Add(Button1)
        Controls.Add(btnCopy)
        Controls.Add(txtTime)
        Controls.Add(Label1)
        Controls.Add(txtValidatePass)
        Controls.Add(txtNumbers)
        Controls.Add(Label3)
        Controls.Add(txtCharacters)
        Controls.Add(Label2)
        Controls.Add(btnGenerate)
        Controls.Add(txtShowPassword)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Personal Password Generator"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtShowPassword As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCharacters As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumbers As TextBox
    Friend WithEvents txtValidatePass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents TimerCreatePass As Timer
    Friend WithEvents TimerTime As Timer
    Friend WithEvents TimerColor As Timer
    Friend WithEvents btnCopy As Button
    Friend WithEvents Button1 As Button

End Class
