<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        ListBox4 = New ListBox()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(341, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 32)
        Label1.TabIndex = 0
        Label1.Text = "Username and Passwords"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 3
        Label2.Text = "Bill/Org"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(204, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 15)
        Label3.TabIndex = 4
        Label3.Text = "Username/Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(456, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 8
        Label5.Text = "Notes"
        ' 
        ' ListBox4
        ' 
        ListBox4.BorderStyle = BorderStyle.None
        ListBox4.FormattingEnabled = True
        ListBox4.ItemHeight = 15
        ListBox4.Items.AddRange(New Object() {"The website links in the Bill/Org column must be double-clicked to open the website.", "", "As of this writing, all usernames and passwords should auto fill. If they do not, then use", "this program.", "", "Patriot Mobile bill is autmatically deducted from bank account on the 1st of the month. As", "well as the mortgage ($2150) and the STUPID home equity loan from Shellpoint ($500).", "", "MyPay password must be changed every 150 days (It will notify you when to change it).", "Garbage bill is done through Doxo. And Lynden utilities goes through xPressPay.", "", "Patriot Mobile PIN is 42633290. This is needed for any sort of support. The safe is 62365# and", "all PC's are 62365.", "", "All other username/passwords can be accessed by opening MS Edge, then copy and paste", "", "edge://wallet/passwords in the URL."})
        ListBox4.Location = New Point(456, 113)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(502, 360)
        ListBox4.TabIndex = 9
        ' 
        ' ListView1
        ' 
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView1.Location = New Point(12, 113)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(186, 360)
        ListView1.TabIndex = 10
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Site Links"
        ColumnHeader1.Width = 200
        ' 
        ' ListBox1
        ' 
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 17
        ListBox1.Items.AddRange(New Object() {"", "obstinateone/0bnoxiousN0x!", "obnoxiousn0x/0bstinate0ne!"})
        ListBox1.Location = New Point(204, 113)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(220, 357)
        ListBox1.TabIndex = 11
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(969, 492)
        Controls.Add(ListBox1)
        Controls.Add(ListView1)
        Controls.Add(ListBox4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Username and Passwords"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ListBox1 As ListBox
End Class
