Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class Form1

    'When user presses the register button, values are stored in the database
    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click

        If RegistrationDetailsCheck() = True And ExistingEmailCheck() = False Then  'Check if values entered by users are valid
            Dim con As New OleDb.OleDbConnection

            Dim cmd As New OleDb.OleDbCommand

            'Open a connection with the database to insert the values in the right table
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"

            con.Open()

            Dim Sql As String = "INSERT INTO UserAccount(EmailAdress,UserPassword,UserName) VALUES('" & Me.RegisterEmail.Text & "','" & Me.RegisterPassword.Text & "', '" & Me.RegisterName.Text & "' )"
            cmd = New OleDb.OleDbCommand(Sql, con)
            cmd.ExecuteNonQuery()

            MsgBox("You have been registered! You can now login.")

            'Remove any values in the Email,Password,Name textbox
            RegisterEmail.Text = ""
            RegisterPassword.Text = ""
            RegisterName.Text = ""

            con.Close()  'Close connection
        ElseIf ExistingEmailCheck() = True Then  'If the email already exists in the databse, he has use another one
            MsgBox("Email already exists! Please use another one.")

            RegisterEmail.Text = ""
        Else
            MsgBox("Please enter valid details in order to register!")

            RegisterEmail.Text = ""
            RegisterPassword.Text = ""
            RegisterName.Text = ""
        End If

    End Sub

    'Check if the values entered in the Registration Name, Email and Password textbox are correct
    Public Function RegistrationDetailsCheck() As Boolean
        If Me.NameErrorProvider.GetError(Me.RegisterName) = "" And Me.EmailErrorProvider.GetError(Me.RegisterEmail) = "" And Me.PasswordErrorProvider.GetError(Me.RegisterPassword) = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Check if the Email entered by the user already exists in the database
    Public Function ExistingEmailCheck() As Boolean
        Dim Table_ As String = "UserAccount"
        Dim query As String = "SELECT EmailAdress FROM UserAccount WHERE EmailAdress = '" & Me.RegisterEmail.Text & "'"

        'Open a connection with the database, and create a table with the email equal to the user input, if it exists
        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        'If the table has 0 rows, it means that the email does not exists in the databse and can be used
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'The user can only input characters in the Name textbox, any other input is not accepted
    Private Sub RegisterName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RegisterName.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    'Check if there is a value in the Name textbox, if there is not an error comes up
    Private Sub RegisterName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RegisterName.Validating
        If Len(Me.RegisterName.Text) = 0 Then
            Me.NameErrorProvider.SetError(Me.RegisterName, "Please enter a name!")
            Return
        Else
            Me.NameErrorProvider.SetError(Me.RegisterName, "")
        End If
    End Sub

    'Check if the Email entered is in the right format, for example aa@aa.aa
    Public Function RegistrationValidateEmail(RegisterEmail) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(Me.RegisterEmail.Text) Then
            Return True
        Else
            Return False
        End If
    End Function

    'If the email is not in the right format an error comes up
    Private Sub RegisterEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RegisterEmail.Validating
        If RegistrationValidateEmail(Me.RegisterEmail.Text) = False Then
            Me.EmailErrorProvider.SetError(Me.RegisterEmail, "Enter a valid email!")
            Return
        Else
            Me.EmailErrorProvider.SetError(Me.RegisterEmail, "")
        End If
    End Sub

    'Check the password length, if it is not between 8-15 characters an error comes up
    Private Sub RegisterPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RegisterPassword.Validating
        If Len(Me.RegisterPassword.Text) = 0 Then
            Me.PasswordErrorProvider.SetError(Me.RegisterPassword, "Please enter a password! Must be 8-15 characters")
            Return
        ElseIf Len(Me.RegisterPassword.Text) < 8 Then
            Me.PasswordErrorProvider.SetError(Me.RegisterPassword, "Password is too short! Must be 8-15 characters")
            Return
        ElseIf Len(Me.RegisterPassword.Text) > 15 Then
            Me.PasswordErrorProvider.SetError(Me.RegisterPassword, "Password is too long! Must be 8-15 chracters")
            Return
        Else
            Me.PasswordErrorProvider.SetError(Me.RegisterPassword, "")
        End If
    End Sub

    'Check if the Email entered is in the right format, for example aa@aa.aa
    Public Function LoginValidateEmail(LoginEmail) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(Me.LoginEmail.Text) Then
            Return True
        Else
            Return False
        End If
    End Function

    'If the email is not in the right format an error comes up
    Private Sub LoginEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles LoginEmail.Validating
        If LoginValidateEmail(Me.LoginEmail.Text) = False Then
            Me.EmailErrorProvider.SetError(Me.LoginEmail, "Enter a valid email!")
            Return
        Else
            Me.EmailErrorProvider.SetError(Me.LoginEmail, "")
        End If
    End Sub

    'Check the password length, if it is not between 8-15 characters an error comes up
    Private Sub LoginPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles LoginPassword.Validating
        If Len(Me.LoginPassword.Text) = 0 Then
            Me.PasswordErrorProvider.SetError(Me.LoginPassword, "Please enter a password!")
            Return
        ElseIf Len(Me.LoginPassword.Text) < 8 Then
            Me.PasswordErrorProvider.SetError(Me.LoginPassword, "Password is too short!")
            Return
        ElseIf Len(Me.LoginPassword.Text) > 15 Then
            Me.PasswordErrorProvider.SetError(Me.LoginPassword, "Password is too long!")
            Return
        Else
            Me.PasswordErrorProvider.SetError(Me.LoginPassword, "")
        End If
    End Sub

    'Check if the values entered in the Login Email and Password textbox are correct
    Public Function LoginDetailsCheck() As Boolean
        If Me.EmailErrorProvider.GetError(Me.LoginEmail) = "" And Me.PasswordErrorProvider.GetError(Me.LoginPassword) = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'When the user presses the Login button, it is checked that the email and password pair correspond in the database
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        Dim LoginDone As Boolean = False
        Dim Homepage As New Form2

        Dim Table_ As String = "UserAccount"
        Dim query As String = "SELECT EmailAdress,UserPassword FROM UserAccount WHERE EmailAdress = '" & Me.LoginEmail.Text & "'"

        'Open a connection with the database, and create a table with the email and password equal to the user input, if it exists
        Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDatabase.accdb;Persist Security Info=True"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()

        If ds.Tables(0).Rows.Count = 0 Then  'If there are no rows in the table, that means the email does not exists in the database
            MsgBox("Invalid Email!")
        Else
            If Convert.ToString(ds.Tables(0).Rows(0)("UserPassword")) = Me.LoginPassword.Text Then 'If the password inserted by the user matches the one in the table, then the user can login
                MsgBox("Successful login!")
                LoginDone = True
            Else
                MsgBox("Wrong password!") 'If the password does not match, the the user has to login again
                LoginPassword.Text = ""
            End If
        End If

        'When the login is done, the next page is shown
        If LoginDone = True Then
            Me.Hide()
            Homepage.Show()
        End If
    End Sub
End Class