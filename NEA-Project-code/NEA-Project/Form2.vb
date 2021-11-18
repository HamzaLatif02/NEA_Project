Imports System.Data.OleDb
Public Class Form2

    'When the user clicks the SELL button, it goes to the seller section
    Private Sub SellBtn_Click(sender As Object, e As EventArgs) Handles SellBtn.Click
        Dim SellerListings As New Form3

        Me.Hide()
        SellerListings.Show()

    End Sub

    'Reads all the item listed in the database and shows them in a datagridview or "table"
    Private Sub ShowAllBtn_Click(sender As Object, e As EventArgs) Handles ShowAllBtn.Click

        Dim columnButton As New DataGridViewButtonColumn

        'add VIEW button at the end of each row
        columnButton.Text = "VIEW"
        columnButton.UseColumnTextForButtonValue = True
        columnButton.FlatStyle = FlatStyle.Flat
        columnButton.DefaultCellStyle.BackColor = Color.FromArgb(99, 193, 255)


        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating, ItemListed.EmailAdress FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID;"

        'Open connection with database and fill in a table with all the item listed
        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        'Assign header name for each column in the table
        DataGridView2.Rows.Clear()
        DataGridView2.ColumnCount = 8
        DataGridView2.Columns(0).Name = "ID"
        DataGridView2.Columns(1).Name = "Name"
        DataGridView2.Columns(2).Name = "Price"
        DataGridView2.Columns(3).Name = "Description"
        DataGridView2.Columns(4).Name = "Category"
        DataGridView2.Columns(5).Name = "Sold"
        DataGridView2.Columns(6).Name = "Rating"
        DataGridView2.Columns(7).Name = "Listed By"

        'Fill values in the datagridview with the values in the table
        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView2.Rows.Add(rowText)
        Next

        DataGridView2.Columns.Add(columnButton)

        'Make the table not sortable from the column headers
        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user presses the Price button, all the item listed are filtered by price lower to higher
    Private Sub PriceBtn_Click(sender As Object, e As EventArgs) Handles PriceBtn.Click

        Dim columnButton As New DataGridViewButtonColumn

        columnButton.Text = "VIEW"
        columnButton.UseColumnTextForButtonValue = True
        columnButton.FlatStyle = FlatStyle.Flat
        columnButton.DefaultCellStyle.BackColor = Color.FromArgb(99, 193, 255)

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating, ItemListed.EmailAdress FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID ORDER BY ItemPrice ASC;"

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
        DataGridView2.Columns(0).Name = "ID"
        DataGridView2.Columns(1).Name = "Name"
        DataGridView2.Columns(2).Name = "Price"
        DataGridView2.Columns(3).Name = "Description"
        DataGridView2.Columns(4).Name = "Category"
        DataGridView2.Columns(5).Name = "Sold"
        DataGridView2.Columns(6).Name = "Rating"
        DataGridView2.Columns(7).Name = "Listed By"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView2.Rows.Add(rowText)
        Next

        DataGridView2.Columns.Add(columnButton)

        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user presses the Name button, all the item listed are filtered by name alphabetically
    Private Sub NameBtn_Click(sender As Object, e As EventArgs) Handles NameBtn.Click

        Dim columnButton As New DataGridViewButtonColumn

        columnButton.Text = "VIEW"
        columnButton.UseColumnTextForButtonValue = True
        columnButton.FlatStyle = FlatStyle.Flat
        columnButton.DefaultCellStyle.BackColor = Color.FromArgb(99, 193, 255)

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating, ItemListed.EmailAdress FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID ORDER BY ItemName;"

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
        DataGridView2.Columns(0).Name = "ID"
        DataGridView2.Columns(1).Name = "Name"
        DataGridView2.Columns(2).Name = "Price"
        DataGridView2.Columns(3).Name = "Description"
        DataGridView2.Columns(4).Name = "Category"
        DataGridView2.Columns(5).Name = "Sold"
        DataGridView2.Columns(6).Name = "Rating"
        DataGridView2.Columns(7).Name = "Listed By"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView2.Rows.Add(rowText)
        Next

        DataGridView2.Columns.Add(columnButton)

        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user presses the Rating button, all the item listed are filtered by rating higher to lower
    Private Sub RatingBtn_Click(sender As Object, e As EventArgs) Handles RatingBtn.Click

        Dim columnButton As New DataGridViewButtonColumn

        columnButton.Text = "VIEW"
        columnButton.UseColumnTextForButtonValue = True
        columnButton.FlatStyle = FlatStyle.Flat
        columnButton.DefaultCellStyle.BackColor = Color.FromArgb(99, 193, 255)

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating, ItemListed.EmailAdress FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID ORDER BY ItemRating DESC;"

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
        DataGridView2.Columns(0).Name = "ID"
        DataGridView2.Columns(1).Name = "Name"
        DataGridView2.Columns(2).Name = "Price"
        DataGridView2.Columns(3).Name = "Description"
        DataGridView2.Columns(4).Name = "Category"
        DataGridView2.Columns(5).Name = "Sold"
        DataGridView2.Columns(6).Name = "Rating"
        DataGridView2.Columns(7).Name = "Listed By"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView2.Rows.Add(rowText)
        Next

        DataGridView2.Columns.Add(columnButton)

        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user presses the Phones button, only the items in the Phones category are shown
    Private Sub PhonesBtn_Click(sender As Object, e As EventArgs) Handles PhonesBtn.Click

        Dim columnButton As New DataGridViewButtonColumn

        columnButton.Text = "VIEW"
        columnButton.UseColumnTextForButtonValue = True
        columnButton.FlatStyle = FlatStyle.Flat
        columnButton.DefaultCellStyle.BackColor = Color.FromArgb(99, 193, 255)

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating, ItemListed.EmailAdress FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID WHERE ItemCategory = '" & "Phones" & "'"

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
        DataGridView2.Columns(0).Name = "ID"
        DataGridView2.Columns(1).Name = "Name"
        DataGridView2.Columns(2).Name = "Price"
        DataGridView2.Columns(3).Name = "Description"
        DataGridView2.Columns(4).Name = "Category"
        DataGridView2.Columns(5).Name = "Sold"
        DataGridView2.Columns(6).Name = "Rating"
        DataGridView2.Columns(7).Name = "Listed By"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView2.Rows.Add(rowText)
        Next

        DataGridView2.Columns.Add(columnButton)

        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user presses the Laptops button, only the items in the Laptops category are shown
    Private Sub LaptopsBtn_Click(sender As Object, e As EventArgs) Handles LaptopsBtn.Click

        Dim columnButton As New DataGridViewButtonColumn

        columnButton.Text = "VIEW"
        columnButton.UseColumnTextForButtonValue = True
        columnButton.FlatStyle = FlatStyle.Flat
        columnButton.DefaultCellStyle.BackColor = Color.FromArgb(99, 193, 255)

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating, ItemListed.EmailAdress FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID WHERE ItemCategory = '" & "Laptops" & "'"

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
        DataGridView2.Columns(0).Name = "ID"
        DataGridView2.Columns(1).Name = "Name"
        DataGridView2.Columns(2).Name = "Price"
        DataGridView2.Columns(3).Name = "Description"
        DataGridView2.Columns(4).Name = "Category"
        DataGridView2.Columns(5).Name = "Sold"
        DataGridView2.Columns(6).Name = "Rating"
        DataGridView2.Columns(7).Name = "Listed By"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView2.Rows.Add(rowText)
        Next

        DataGridView2.Columns.Add(columnButton)

        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user presses the TVs button, only the items in the TVs category are shown
    Private Sub TvBtn_Click(sender As Object, e As EventArgs) Handles TvBtn.Click

        Dim columnButton As New DataGridViewButtonColumn

        columnButton.Text = "VIEW"
        columnButton.UseColumnTextForButtonValue = True
        columnButton.FlatStyle = FlatStyle.Flat
        columnButton.DefaultCellStyle.BackColor = Color.FromArgb(99, 193, 255)

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating, ItemListed.EmailAdress FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID WHERE ItemCategory = '" & "TVs" & "'"

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
        DataGridView2.Columns(0).Name = "ID"
        DataGridView2.Columns(1).Name = "Name"
        DataGridView2.Columns(2).Name = "Price"
        DataGridView2.Columns(3).Name = "Description"
        DataGridView2.Columns(4).Name = "Category"
        DataGridView2.Columns(5).Name = "Sold"
        DataGridView2.Columns(6).Name = "Rating"
        DataGridView2.Columns(7).Name = "Listed By"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView2.Rows.Add(rowText)
        Next

        DataGridView2.Columns.Add(columnButton)

        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user presses the Search button, the items that have the 'user search' in their name in any position are shown
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click

        Dim columnButton As New DataGridViewButtonColumn

        columnButton.Text = "VIEW"
        columnButton.UseColumnTextForButtonValue = True
        columnButton.FlatStyle = FlatStyle.Flat
        columnButton.DefaultCellStyle.BackColor = Color.FromArgb(99, 193, 255)

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating, ItemListed.EmailAdress FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID WHERE ItemName LIKE '%" & UserSearch.Text & "%'"

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
        DataGridView2.Columns(0).Name = "ID"
        DataGridView2.Columns(1).Name = "Name"
        DataGridView2.Columns(2).Name = "Price"
        DataGridView2.Columns(3).Name = "Description"
        DataGridView2.Columns(4).Name = "Category"
        DataGridView2.Columns(5).Name = "Sold"
        DataGridView2.Columns(6).Name = "Rating"
        DataGridView2.Columns(7).Name = "Listed By"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
            DataGridView2.Rows.Add(rowText)
        Next

        DataGridView2.Columns.Add(columnButton)

        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user clicks the VIEW button at the end of a row, it shows another form
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If DataGridView2.Columns(e.ColumnIndex).Index = 8 Then  'Check that the user has clicked the VIEW button
            Dim ItemView As New Form6

            Dim index As Integer
            index = e.RowIndex
            Dim SelectedRow As New DataGridViewRow
            SelectedRow = DataGridView2.Rows(index)

            'Pass the values of the item to the next form and assign them to a textbox not editable, and shows them on screens
            ItemView.ItemIDTextBox.Text = SelectedRow.Cells(0).Value.ToString
            ItemView.ItemNameTextBox.Text = SelectedRow.Cells(1).Value.ToString
            ItemView.ItemPriceTextBox.Text = SelectedRow.Cells(2).Value.ToString
            ItemView.ItemDescriptionTextBox.Text = SelectedRow.Cells(3).Value.ToString
            ItemView.ItemCategoryTextBox.Text = SelectedRow.Cells(4).Value.ToString
            ItemView.ItemSoldTextBox.Text = SelectedRow.Cells(5).Value.ToString
            ItemView.ItemRatingTextBox.Text = SelectedRow.Cells(6).Value.ToString
            ItemView.ListedByTextBox.Text = SelectedRow.Cells(7).Value.ToString

            ItemView.CardExpiryDatePicker.Value = Date.Today  'Assign date as the date today

            Me.Hide()
            ItemView.Show()

        End If
    End Sub
End Class