<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SellBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.UserSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.ItemDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ItemCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ItemPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ItemRatingTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.CardNameTxtBox = New System.Windows.Forms.TextBox()
        Me.CardNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.UserRatingTxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BuyBtn = New System.Windows.Forms.Button()
        Me.CardExpiryDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.NameErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CardNumberErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RatingErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DateErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ItemSoldTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ItemIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListedByTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardNumberErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatingErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SellBtn)
        Me.Panel1.Controls.Add(Me.SearchBtn)
        Me.Panel1.Controls.Add(Me.UserSearch)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 98)
        Me.Panel1.TabIndex = 1
        '
        'SellBtn
        '
        Me.SellBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SellBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.SellBtn.Location = New System.Drawing.Point(570, 25)
        Me.SellBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.SellBtn.Name = "SellBtn"
        Me.SellBtn.Size = New System.Drawing.Size(100, 40)
        Me.SellBtn.TabIndex = 3
        Me.SellBtn.Text = "SELL"
        Me.SellBtn.UseVisualStyleBackColor = False
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBtn.BackgroundImage = CType(resources.GetObject("SearchBtn.BackgroundImage"), System.Drawing.Image)
        Me.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Location = New System.Drawing.Point(464, 25)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(40, 40)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'UserSearch
        '
        Me.UserSearch.BackColor = System.Drawing.Color.White
        Me.UserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserSearch.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.UserSearch.Location = New System.Drawing.Point(116, 25)
        Me.UserSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.UserSearch.Multiline = True
        Me.UserSearch.Name = "UserSearch"
        Me.UserSearch.Size = New System.Drawing.Size(350, 40)
        Me.UserSearch.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.BackColor = System.Drawing.Color.White
        Me.ItemNameTextBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.ItemNameTextBox.Location = New System.Drawing.Point(12, 184)
        Me.ItemNameTextBox.Multiline = True
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.ReadOnly = True
        Me.ItemNameTextBox.Size = New System.Drawing.Size(250, 41)
        Me.ItemNameTextBox.TabIndex = 2
        '
        'ItemDescriptionTextBox
        '
        Me.ItemDescriptionTextBox.BackColor = System.Drawing.Color.White
        Me.ItemDescriptionTextBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.ItemDescriptionTextBox.Location = New System.Drawing.Point(12, 297)
        Me.ItemDescriptionTextBox.Multiline = True
        Me.ItemDescriptionTextBox.Name = "ItemDescriptionTextBox"
        Me.ItemDescriptionTextBox.ReadOnly = True
        Me.ItemDescriptionTextBox.Size = New System.Drawing.Size(250, 40)
        Me.ItemDescriptionTextBox.TabIndex = 3
        '
        'ItemCategoryTextBox
        '
        Me.ItemCategoryTextBox.BackColor = System.Drawing.Color.White
        Me.ItemCategoryTextBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.ItemCategoryTextBox.Location = New System.Drawing.Point(12, 405)
        Me.ItemCategoryTextBox.Multiline = True
        Me.ItemCategoryTextBox.Name = "ItemCategoryTextBox"
        Me.ItemCategoryTextBox.ReadOnly = True
        Me.ItemCategoryTextBox.Size = New System.Drawing.Size(250, 40)
        Me.ItemCategoryTextBox.TabIndex = 4
        '
        'ItemPriceTextBox
        '
        Me.ItemPriceTextBox.BackColor = System.Drawing.Color.White
        Me.ItemPriceTextBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.ItemPriceTextBox.Location = New System.Drawing.Point(12, 518)
        Me.ItemPriceTextBox.Multiline = True
        Me.ItemPriceTextBox.Name = "ItemPriceTextBox"
        Me.ItemPriceTextBox.ReadOnly = True
        Me.ItemPriceTextBox.Size = New System.Drawing.Size(250, 40)
        Me.ItemPriceTextBox.TabIndex = 5
        '
        'ItemRatingTextBox
        '
        Me.ItemRatingTextBox.BackColor = System.Drawing.Color.White
        Me.ItemRatingTextBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.ItemRatingTextBox.Location = New System.Drawing.Point(12, 609)
        Me.ItemRatingTextBox.Multiline = True
        Me.ItemRatingTextBox.Name = "ItemRatingTextBox"
        Me.ItemRatingTextBox.ReadOnly = True
        Me.ItemRatingTextBox.Size = New System.Drawing.Size(125, 40)
        Me.ItemRatingTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Item Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Item Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Item Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Item Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 581)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Item Rating"
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.BackBtn.Location = New System.Drawing.Point(570, 106)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(100, 34)
        Me.BackBtn.TabIndex = 4
        Me.BackBtn.Text = "BACK"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'CardNameTxtBox
        '
        Me.CardNameTxtBox.BackColor = System.Drawing.Color.White
        Me.CardNameTxtBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.CardNameTxtBox.Location = New System.Drawing.Point(357, 184)
        Me.CardNameTxtBox.Multiline = True
        Me.CardNameTxtBox.Name = "CardNameTxtBox"
        Me.CardNameTxtBox.Size = New System.Drawing.Size(250, 41)
        Me.CardNameTxtBox.TabIndex = 12
        '
        'CardNumberTxtBox
        '
        Me.CardNumberTxtBox.BackColor = System.Drawing.Color.White
        Me.CardNumberTxtBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.CardNumberTxtBox.Location = New System.Drawing.Point(357, 296)
        Me.CardNumberTxtBox.Multiline = True
        Me.CardNumberTxtBox.Name = "CardNumberTxtBox"
        Me.CardNumberTxtBox.Size = New System.Drawing.Size(250, 41)
        Me.CardNumberTxtBox.TabIndex = 13
        '
        'UserRatingTxtBox
        '
        Me.UserRatingTxtBox.BackColor = System.Drawing.Color.White
        Me.UserRatingTxtBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.UserRatingTxtBox.Location = New System.Drawing.Point(357, 517)
        Me.UserRatingTxtBox.Multiline = True
        Me.UserRatingTxtBox.Name = "UserRatingTxtBox"
        Me.UserRatingTxtBox.Size = New System.Drawing.Size(250, 41)
        Me.UserRatingTxtBox.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(352, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Name on Card"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label7.Location = New System.Drawing.Point(352, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Card Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label8.Location = New System.Drawing.Point(352, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Card Expiry Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label9.Location = New System.Drawing.Point(352, 490)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(269, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Give a Rating (optional)"
        '
        'BuyBtn
        '
        Me.BuyBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuyBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.BuyBtn.Location = New System.Drawing.Point(507, 609)
        Me.BuyBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.BuyBtn.Name = "BuyBtn"
        Me.BuyBtn.Size = New System.Drawing.Size(100, 40)
        Me.BuyBtn.TabIndex = 4
        Me.BuyBtn.Text = "BUY"
        Me.BuyBtn.UseVisualStyleBackColor = False
        '
        'CardExpiryDatePicker
        '
        Me.CardExpiryDatePicker.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.CardExpiryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CardExpiryDatePicker.Location = New System.Drawing.Point(357, 415)
        Me.CardExpiryDatePicker.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.CardExpiryDatePicker.Name = "CardExpiryDatePicker"
        Me.CardExpiryDatePicker.Size = New System.Drawing.Size(250, 30)
        Me.CardExpiryDatePicker.TabIndex = 20
        Me.CardExpiryDatePicker.Value = New Date(2021, 2, 18, 0, 0, 0, 0)
        '
        'NameErrorProvider
        '
        Me.NameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.NameErrorProvider.ContainerControl = Me
        '
        'CardNumberErrorProvider
        '
        Me.CardNumberErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.CardNumberErrorProvider.ContainerControl = Me
        '
        'RatingErrorProvider
        '
        Me.RatingErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.RatingErrorProvider.ContainerControl = Me
        '
        'DateErrorProvider
        '
        Me.DateErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.DateErrorProvider.ContainerControl = Me
        '
        'ItemSoldTextBox
        '
        Me.ItemSoldTextBox.BackColor = System.Drawing.Color.White
        Me.ItemSoldTextBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.ItemSoldTextBox.Location = New System.Drawing.Point(143, 609)
        Me.ItemSoldTextBox.Multiline = True
        Me.ItemSoldTextBox.Name = "ItemSoldTextBox"
        Me.ItemSoldTextBox.ReadOnly = True
        Me.ItemSoldTextBox.Size = New System.Drawing.Size(125, 40)
        Me.ItemSoldTextBox.TabIndex = 21
        Me.ItemSoldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label10.Location = New System.Drawing.Point(162, 581)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Item Sold"
        '
        'ItemIDTextBox
        '
        Me.ItemIDTextBox.BackColor = System.Drawing.Color.White
        Me.ItemIDTextBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.ItemIDTextBox.Location = New System.Drawing.Point(212, 106)
        Me.ItemIDTextBox.Multiline = True
        Me.ItemIDTextBox.Name = "ItemIDTextBox"
        Me.ItemIDTextBox.ReadOnly = True
        Me.ItemIDTextBox.Size = New System.Drawing.Size(50, 34)
        Me.ItemIDTextBox.TabIndex = 23
        Me.ItemIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label11.Location = New System.Drawing.Point(172, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 25)
        Me.Label11.TabIndex = 24
        '
        'ListedByTextBox
        '
        Me.ListedByTextBox.BackColor = System.Drawing.Color.White
        Me.ListedByTextBox.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.ListedByTextBox.Location = New System.Drawing.Point(11, 106)
        Me.ListedByTextBox.Multiline = True
        Me.ListedByTextBox.Name = "ListedByTextBox"
        Me.ListedByTextBox.ReadOnly = True
        Me.ListedByTextBox.Size = New System.Drawing.Size(195, 34)
        Me.ListedByTextBox.TabIndex = 25
        '
        'Form6
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.ListedByTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ItemIDTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ItemSoldTextBox)
        Me.Controls.Add(Me.CardExpiryDatePicker)
        Me.Controls.Add(Me.BuyBtn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.UserRatingTxtBox)
        Me.Controls.Add(Me.CardNumberTxtBox)
        Me.Controls.Add(Me.CardNameTxtBox)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ItemRatingTextBox)
        Me.Controls.Add(Me.ItemPriceTextBox)
        Me.Controls.Add(Me.ItemCategoryTextBox)
        Me.Controls.Add(Me.ItemDescriptionTextBox)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buy&Sell - View and Buy Item"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardNumberErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatingErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SellBtn As Button
    Friend WithEvents SearchBtn As Button
    Friend WithEvents UserSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ItemNameTextBox As TextBox
    Friend WithEvents ItemDescriptionTextBox As TextBox
    Friend WithEvents ItemCategoryTextBox As TextBox
    Friend WithEvents ItemPriceTextBox As TextBox
    Friend WithEvents ItemRatingTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents CardNameTxtBox As TextBox
    Friend WithEvents CardNumberTxtBox As TextBox
    Friend WithEvents UserRatingTxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BuyBtn As Button
    Friend WithEvents CardExpiryDatePicker As DateTimePicker
    Friend WithEvents NameErrorProvider As ErrorProvider
    Friend WithEvents CardNumberErrorProvider As ErrorProvider
    Friend WithEvents RatingErrorProvider As ErrorProvider
    Friend WithEvents DateErrorProvider As ErrorProvider
    Friend WithEvents Label10 As Label
    Friend WithEvents ItemSoldTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ItemIDTextBox As TextBox
    Friend WithEvents ListedByTextBox As TextBox
End Class
