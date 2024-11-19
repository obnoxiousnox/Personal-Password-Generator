Public Class Form2
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up ListView
        ListView1.View = View.Details
        ListView1.Columns.Add("Hyperlinks", 200)

        ' Add items with hyperlinks
        Dim item1 As New ListViewItem("CNG")
        item1.Tag = "https://customer.cngc.com/login"
        ListView1.Items.Add(item1)

        Dim item2 As New ListViewItem("PSE")
        item2.Tag = "https://www.pse.com"
        ListView1.Items.Add(item2)

        Dim item3 As New ListViewItem("Comcast")
        item3.Tag = "https://business.comcast.com/myaccount"
        ListView1.Items.Add(item3)

        Dim item4 As New ListViewItem("Garbage/Recycle")
        item4.Tag = "https://www.nvd-inc.com"
        ListView1.Items.Add(item4)

        Dim item5 As New ListViewItem("Patriot Mobile")
        item5.Tag = "https://myaccount.patriotmobile.com/home"
        ListView1.Items.Add(item5)

        Dim item6 As New ListViewItem("Lowes/Synchrony")
        item6.Tag = "https://www.synchrony.com/accounts/?client=lowes"
        ListView1.Items.Add(item6)

        Dim item7 As New ListViewItem("Wells Fargo")
        item7.Tag = "https://www.wellsfargo.com"
        ListView1.Items.Add(item7)

        Dim item8 As New ListViewItem("GMail/Youtube")
        item8.Tag = "https://www.gmail.com"
        ListView1.Items.Add(item8)

        Dim item9 As New ListViewItem("Lynden Utilities")
        item9.Tag = "https://www.xpressbillpay.com/"
        ListView1.Items.Add(item9)
    End Sub
    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        ' Open the hyperlink when an item is activated (double-clicked)
        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        Dim url As String = selectedItem.Tag.ToString()
        Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
    End Sub



End Class