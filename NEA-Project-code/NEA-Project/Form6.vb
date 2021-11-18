
Public Class Form6
    'When the user clicks the Back button, it goes to the Homepage
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Homepage As New Form2

        Me.Hide()
        Homepage.Show()
    End Sub

    'When the user clicks the Sell button, it goes to the seller section
    Private Sub SellBtn_Click(sender As Object, e As EventArgs) Handles SellBtn.Click
        Dim SellerListings As New Form3

        Me.Hide()
        SellerListings.Show()
    End Sub

    'When the user clicks the Search button, an error comes up as there is nothing to search in this page
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        MsgBox("Can't search on this page!")
    End Sub

    'Allows the user to only enter characters in the Name textbox
    Private Sub CardNameTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CardNameTxtBox.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    'Allows the user to only enter numbers in the Card Number textbox
    Private Sub CardNumberTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CardNumberTxtBox.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    'Allows the user to only enter numbers in the Rating textbox
    Private Sub UserRatingTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UserRatingTxtBox.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    'Checks if there is a value in the Name textbox, if there is not then an error comes up
    Private Sub CardNameTxtBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CardNameTxtBox.Validating
        If Len(Me.CardNameTxtBox.Text) = 0 Then
            Me.NameErrorProvider.SetError(Me.CardNameTxtBox, "Please enter a name!")
            Return
        Else
            Me.NameErrorProvider.SetError(Me.CardNameTxtBox, "")
        End If
    End Sub

    'Checks if there is a value in the Card Number textbox and it is 16 digits long, if it is not then an error comes up
    Private Sub CardNumberTxtBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CardNumberTxtBox.Validating
        If Len(Me.CardNumberTxtBox.Text) = 0 Then
            Me.CardNumberErrorProvider.SetError(Me.CardNumberTxtBox, "Please enter a valid number!")
            Return
        ElseIf Len(Me.CardNumberTxtBox.Text) <> 16 Then
            Me.CardNumberErrorProvider.SetError(Me.CardNumberTxtBox, "Number must be 16 digits long!")
            Return
        Else
            Me.CardNumberErrorProvider.SetError(Me.CardNumberTxtBox, "")
        End If
    End Sub

    'Checks if the rating input by the user is between 0 and 5, if it is not then an error comes up
    Private Sub UserRatingTxtBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UserRatingTxtBox.Validating
        If Len(Me.UserRatingTxtBox.Text) = 0 Then  'As the rating is optional, not having a value in the rating textbox is not considered an error
            Me.RatingErrorProvider.SetError(Me.UserRatingTxtBox, "")
            Return
        ElseIf Me.UserRatingTxtBox.Text > 5 Or Me.UserRatingTxtBox.Text < 0 Then
            Me.RatingErrorProvider.SetError(Me.UserRatingTxtBox, "Value must be between 0 and 5!")
            Return
        Else
            Me.RatingErrorProvider.SetError(Me.UserRatingTxtBox, "")
        End If
    End Sub

    'Checks if the date input by the user is after or equal to the current date, if it is not then an error comes up
    Private Sub CardExpiryDatePicker_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CardExpiryDatePicker.Validating
        If Me.CardExpiryDatePicker.Value < Date.Today Then
            Me.DateErrorProvider.SetError(Me.CardExpiryDatePicker, "Please enter a valid date!")
            Return
        Else
            Me.DateErrorProvider.SetError(Me.CardExpiryDatePicker, "")
        End If
    End Sub

    'Checks if all the values entered by the user are valid
    Public Function CardDetailsCheck() As Boolean
        If Me.NameErrorProvider.GetError(Me.CardNameTxtBox) = "" And Me.CardNumberErrorProvider.GetError(Me.CardNumberTxtBox) = "" And Me.DateErrorProvider.GetError(Me.CardExpiryDatePicker) = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Random number generator that decides whether an item is delivered or not
    Public Function ItemDeliveryRandom() As Boolean
        Dim randint As Integer = Int(Rnd())

        If randint = 1 Then  'If the value equals 1 the the item is delivered, otherwise it is not
            Return True
        Else
            Return False
        End If
    End Function

    'When the user clicks the Buy button, all the details are stored in the database and the seller receives a new order
    Private Sub BuyBtn_Click(sender As Object, e As EventArgs) Handles BuyBtn.Click
        If CardDetailsCheck() = True Then  'Check if all details are valid

            Dim itemsoldupdated As Integer = Int(ItemSoldTextBox.Text) + 1  'Increment the number of item sold by 1
            Dim itemratingupdated As Integer
            Dim itemsum As Integer

            If UserRatingTxtBox.Text <> "" Then
                itemsum = Int(ItemRatingTextBox.Text) + Int(UserRatingTxtBox.Text)  'If the user has given a rating then the updated rating is equal to the mean of the old and new rating
                itemratingupdated = itemsum \ 2
            Else
                itemratingupdated = ItemRatingTextBox.Text  'If the user has not given a rating, then it remains the same
            End If

            Dim con As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"

            'Insert the details entered by the user into the UserPaymentInfo table in the database
            con.Open()
            Dim Sql As String = "INSERT INTO UserPaymentInfo(CardName,CardNumber,CardExpiry) VALUES('" & Me.CardNameTxtBox.Text & "', '" & Me.CardNumberTxtBox.Text & "', '" & Me.CardExpiryDatePicker.Text & "' )"
            cmd = New OleDb.OleDbCommand(Sql, con)
            cmd.ExecuteNonQuery()
            con.Close()

            'Insert the EmailAdress of the buyer and the PaymentID of the payment details just entered in the UserPayments table, to create a many-to-many relationship
            con.Open()
            Dim Sql1 As String = "INSERT INTO UserPayments(EmailAdress, PaymentID) VALUES('" & Form1.LoginEmail.Text & "', " & UserPaymentID() & ")"
            cmd = New OleDb.OleDbCommand(Sql1, con)
            cmd.ExecuteNonQuery()
            con.Close()

            'Update the ItemSold and ItemRating fields in the database of the item just bought
            con.Open()
            Dim Sql2 As String = "UPDATE ItemInfo SET ItemSold = " & itemsoldupdated & ", ItemRating = " & itemratingupdated & " WHERE (ItemID = " & Me.ItemIDTextBox.Text & ")"
            cmd = New OleDb.OleDbCommand(Sql2, con)
            cmd.ExecuteNonQuery()
            con.Close()

            'Create an order in the database by storing the ItemID of the item just bought and whethter it has been delivered or not
            con.Open()
            Dim Sql3 As String = "INSERT INTO OrderInfo(ItemID,ItemDelivered) VALUES(" & Me.ItemIDTextBox.Text & "," & ItemDeliveryRandom() & ")"
            cmd = New OleDb.OleDbCommand(Sql3, con)
            cmd.ExecuteNonQuery()
            con.Close()

            'Store the order in the "UserOrder table so the seller can see that he has a new order
            con.Open()
            Dim Sql4 As String = "INSERT INTO UserOrder(EmailAdress,OrderID) VALUES('" & Me.ListedByTextBox.Text & "', " & UserOrderID() & ")"
            cmd = New OleDb.OleDbCommand(Sql4, con)
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Succesful Payment!")

            'Reset the value of all the textboxes and date picker
            CardNameTxtBox.Text = ""
            CardNumberTxtBox.Text = ""
            CardExpiryDatePicker.Value = Date.Today
            UserRatingTxtBox.Text = ""
        Else
            MsgBox("Enter valid details!")
        End If
    End Sub

    'Returns the value of the PaymentID of the payment that just happened
    Public Function UserPaymentID() As Integer

        Dim Table_ As String = "UserPaymentInfo"
        Dim query As String = "SELECT MAX(PaymentID) FROM UserPaymentInfo"

        'Open a connection with the database and create a table with the maximum value of the PaymentID, which equals the ID of the values just entered by the user that are stored in the database
        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand(query, cnn)
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        Return ds.Tables(0).Rows(0)("Expr1000")  'Return the value
    End Function

    'Returns the OrderID of the order that just happened
    Public Function UserOrderID() As Integer

        Dim Table_ As String = "OrderInfo"
        Dim query As String = "SELECT MAX(OrderID) FROM OrderInfo"

        'Open a connection with the database and create a table with the value of the maximum OrderID, which equals the ID of the order has just happened
        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand(query, cnn)
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        Return ds.Tables(0).Rows(0)("Expr1000")  'Return the value
    End Function
End Class