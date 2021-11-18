Imports System.Data.OleDb
Public Class Form4
    'When the user presses the Listings button, the Listings page comes up
    Private Sub ListingsBtn_Click(sender As Object, e As EventArgs) Handles ListingsBtn.Click
        Dim SellerListings As New Form3

        Me.Hide()
        SellerListings.Show()
    End Sub

    'When the user presses the Orders button, a message comes up, as the user is already on the Orders page
    Private Sub OrdersBtn_Click(sender As Object, e As EventArgs) Handles OrdersBtn.Click
        MsgBox("You are already on the orders section!")

    End Sub

    'When the user presses the Charts button, the Charts page comes up
    Private Sub ChartsBtn_Click(sender As Object, e As EventArgs) Handles ChartsBtn.Click
        Dim SellerCharts As New Form5

        Me.Hide()
        SellerCharts.Show()
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

    'When the user presses the Show button, all the item listed that have been delivered are shown on screen in the datagrid
    Private Sub ShowDataGrid1Btn_Click(sender As Object, e As EventArgs) Handles ShowDataGrid1Btn.Click

        Dim Table_ As String = "UserOrder"
        Dim query As String = "SELECT EmailAdress, OrderInfo.OrderID, ItemID, ItemDelivered FROM OrderInfo INNER JOIN UserOrder ON OrderInfo.OrderID = UserOrder.OrderID WHERE ItemDelivered = True AND EmailAdress = '" & Form1.LoginEmail.Text & "'"

        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        DataGridView1.Rows.Clear()
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Email"
        DataGridView1.Columns(1).Name = "OrderID"
        DataGridView1.Columns(2).Name = "ItemID"
        DataGridView1.Columns(3).Name = "Delivered"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3)}
            DataGridView1.Rows.Add(rowText)
        Next

        For Each DataGridView1Columns In DataGridView1.Columns
            DataGridView1Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'When the user presses the Show button, all the item listed that have not been delivered are shown on screen in the datagrid
    Private Sub ShowDataGrid2Btn_Click(sender As Object, e As EventArgs) Handles ShowDataGrid2Btn.Click

        Dim Table_ As String = "UserOrder"
        Dim query As String = "SELECT EmailAdress, OrderInfo.OrderID, ItemID, ItemDelivered FROM OrderInfo INNER JOIN UserOrder ON OrderInfo.OrderID = UserOrder.OrderID WHERE ItemDelivered = False AND EmailAdress = '" & Form1.LoginEmail.Text & "'"

        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        DataGridView2.Rows.Clear()
        DataGridView2.ColumnCount = 4
        DataGridView2.Columns(0).Name = "Email"
        DataGridView2.Columns(1).Name = "OrderID"
        DataGridView2.Columns(2).Name = "ItemID"
        DataGridView2.Columns(3).Name = "Delivered"

        Dim rowText As String()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        For Each row In t1.Rows
            rowText = New String() {row(0), row(1), row(2), row(3)}
            DataGridView2.Rows.Add(rowText)
        Next

        For Each DataGridView2Columns In DataGridView2.Columns
            DataGridView2Columns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

End Class