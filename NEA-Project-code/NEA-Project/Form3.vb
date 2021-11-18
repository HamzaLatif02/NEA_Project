Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class Form3
    'When the user presses the Listings button, a messaege comes up, as the user is already on the Listings page
    Private Sub ListingsBtn_Click(sender As Object, e As EventArgs) Handles ListingsBtn.Click
        MsgBox("You are already on the listings section!")
    End Sub

    'When the user presses the Orders button, the Orders page comes up
    Private Sub OrdersBtn_Click(sender As Object, e As EventArgs) Handles OrdersBtn.Click
        Dim SellerOrders As New Form4

        Me.Hide()
        SellerOrders.Show()
    End Sub

    'When the user presses the Charts buttton, the Charts page comes up
    Private Sub ChartsBtn_Click(sender As Object, e As EventArgs) Handles ChartsBtn.Click
        Dim SellerCharts As New Form5

        Me.Hide()
        SellerCharts.Show()
    End Sub

    'When the user presses the Home button, the Homepage comes up
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim Homepage As New Form2

        Me.Hide()
        Homepage.Show()
    End Sub

    'When the user presses the Search button, an error comes up as it is not possible to search on this page
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        MsgBox("Can't search on this page!")
    End Sub

    'When the user presses the Show button, all the item listed alongside their info are shown on screen in the datagrid
    Private Sub ShowDataGridBtn_Click(sender As Object, e As EventArgs) Handles ShowDataGridBtn.Click

        Dim Table_ As String = "ItemListed"
        Dim query As String = "SELECT EmailAdress, ItemInfo.ItemID, ItemName, ItemPrice, ItemDescription, ItemCategory, ItemSold, ItemRating FROM ItemInfo INNER JOIN ItemListed ON ItemInfo.ItemID = ItemListed.ItemID WHERE EmailAdress = '" & Form1.LoginEmail.Text & "'" 'Replace the query with your one

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

    'Checks that the there is a value in the Description textbox and it is less than 100 characters, if that is not the case then an error comes up
    Private Sub ItemDescription_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ItemDescription.Validating
        If Len(ItemDescription.Text) = 0 Then
            Me.DescriptionErrorProvider.SetError(Me.ItemDescription, "Please enter a description! Must be less than 100 characters")
            Return
        ElseIf Len(ItemDescription.Text) > 100 Then
            Me.DescriptionErrorProvider.SetError(Me.ItemDescription, "Description is too long! Must be less than 100 characters")
            Return
        Else
            Me.DescriptionErrorProvider.SetError(Me.ItemDescription, "")
        End If
    End Sub

    'Allows the user to only enter numbers in the Price textbox
    Private Sub ItemPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ItemPrice.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    'Check that the input in the Price textbox is in the right format, for example, 1.11, the dot represent the decimal point 
    Public Function PriceFormatValidation() As Boolean
        Dim email As New Regex("^[$]?[0-9]*(\.)?[0-9]?[0-9]?$")
        If email.IsMatch(Me.ItemPrice.Text) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Checks that there is a value in the Price textbox and it is in the right format, if that is not the case then an error comes up
    Private Sub ItemPrice_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ItemPrice.Validating
        If Len(Me.ItemPrice.Text) = 0 Then
            Me.PriceErrorProvider.SetError(Me.ItemPrice, "Please enter a price, in the format 0.00")
            Return
        ElseIf PriceFormatValidation() = False Then
            Me.PriceErrorProvider.SetError(Me.ItemPrice, "Please enter a valid price, in the format 0.00.")
        Else
            Me.PriceErrorProvider.SetError(Me.ItemPrice, "")
        End If
    End Sub

    'Checks that there is a value in the Name textbox, if that is not the case then an error comes up
    Private Sub ItemName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ItemName.Validating
        If Len(Me.ItemName.Text) = 0 Then
            Me.NameErrorProvider.SetError(Me.ItemName, "Please enter a name!")
            Return
        Else
            Me.NameErrorProvider.SetError(Me.ItemName, "")
        End If
    End Sub

    'Checks that all the value entered are valid
    Public Function ItemInfoCheck() As Boolean
        If Me.NameErrorProvider.GetError(Me.ItemName) = "" And Me.DescriptionErrorProvider.GetError(Me.ItemDescription) = "" And Me.PriceErrorProvider.GetError(Me.ItemPrice) = "" And CategoryListBox.SelectedIndex <> -1 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Insert the values entered in the database
    Private Sub ListItemBtn_Click(sender As Object, e As EventArgs) Handles ListItemBtn.Click

        If ItemInfoCheck() = True Then
            Dim con As New OleDb.OleDbConnection

            Dim cmd As New OleDb.OleDbCommand

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"

            con.Open()
            Dim Sql As String = "INSERT INTO ItemInfo(ItemName,ItemPrice,ItemDescription,ItemCategory) VALUES('" & Me.ItemName.Text & "','" & Me.ItemPrice.Text & "', '" & Me.ItemDescription.Text & "', '" & Me.CategoryListBox.SelectedItem.ToString() & "' )"
            cmd = New OleDb.OleDbCommand(Sql, con)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            Dim Sql1 As String = "INSERT INTO ItemListed(EmailAdress,ItemID) VALUES('" & Form1.LoginEmail.Text & "', " & ItemListedID() & ")"
            cmd = New OleDb.OleDbCommand(Sql1, con)
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Your item has been listed!")

            ItemName.Text = ""
            ItemPrice.Text = ""
            ItemDescription.Text = ""
            CategoryListBox.SelectedIndex = -1
        Else
            MsgBox("Please enter valid details!")
        End If

    End Sub

    'Get the value of ItemID of the item just listed by the user
    Public Function ItemListedID() As Integer

        Dim Table_ As String = "ItemInfo"
        Dim query As String = "SELECT MAX(ItemID) FROM ItemInfo"

        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand(query, cnn)
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        Return ds.Tables(0).Rows(0)("Expr1000")
    End Function
End Class