Imports System.Data.OleDb
Public Class Form5
    'When the user presses the Listings button, the Listings page comes up
    Private Sub ListingsBtn_Click(sender As Object, e As EventArgs) Handles ListingsBtn.Click
        Dim SellerListings As New Form3

        Me.Hide()
        SellerListings.Show()
    End Sub

    'When the user presses the Orders button, the Orders page comes up
    Private Sub OrdersBtn_Click(sender As Object, e As EventArgs) Handles OrdersBtn.Click
        Dim SellerOrders As New Form4

        Me.Hide()
        SellerOrders.Show()
    End Sub

    'When the user presses the Orders button, a message comes up, as the user is already on the Orders page
    Private Sub ChartsBtn_Click(sender As Object, e As EventArgs) Handles ChartsBtn.Click
        MsgBox("You are already on the charts section!")

    End Sub

    'When the user presses the Home button, the Homepage page comes up
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim Homepage As New Form2

        Me.Hide()
        Homepage.Show()
    End Sub

    'When the user presses the Search button, an error comes up as it is not possible to search on this page
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        MsgBox("Can't search on this page!")
    End Sub

    'When the user presses the Show button, all the item listed ordered by most sold are shown on screen in the datagrid
    Private Sub ShowDataGrid1Btn_Click(sender As Object, e As EventArgs) Handles ShowDataGrid1Btn.Click

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT EmailAdress, ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID WHERE EmailAdress = '" & Form1.LoginEmail.Text & "' ORDER BY ItemSold DESC;"

        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        DataGridView1.Rows.Clear()
        DataGridView1.ColumnCount = 8
        DataGridView1.Columns(0).Name = "Email"
        DataGridView1.Columns(1).Name = "ID"
        DataGridView1.Columns(2).Name = "Name"
        DataGridView1.Columns(3).Name = "Price"
        DataGridView1.Columns(4).Name = "Description"
        DataGridView1.Columns(5).Name = "Category"
        DataGridView1.Columns(6).Name = "Sold"
        DataGridView1.Columns(7).Name = "Rating"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView1.Rows.Add(rowText)
        Next

        For Each DataGridView1Columns In DataGridView1.Columns
            DataGridView1Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user presses the Show button, all the item listed ordered by most rated are shown on screen in the datagrid
    Private Sub ShowDataGrid2Btn_Click(sender As Object, e As EventArgs) Handles ShowDataGrid2Btn.Click

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT EmailAdress, ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID WHERE EmailAdress = '" & Form1.LoginEmail.Text & "' ORDER BY ItemRating DESC"

        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        DataGridView2.Rows.Clear()
        DataGridView2.ColumnCount = 8
        DataGridView2.Columns(0).Name = "Email"
        DataGridView2.Columns(1).Name = "ID"
        DataGridView2.Columns(2).Name = "Name"
        DataGridView2.Columns(3).Name = "Price"
        DataGridView2.Columns(4).Name = "Description"
        DataGridView2.Columns(5).Name = "Category"
        DataGridView2.Columns(6).Name = "Sold"
        DataGridView2.Columns(7).Name = "Rating"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView2.Rows.Add(rowText)
        Next

        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
End Class