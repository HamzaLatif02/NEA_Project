<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.UserSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChartsBtn = New System.Windows.Forms.Button()
        Me.OrdersBtn = New System.Windows.Forms.Button()
        Me.ListingsBtn = New System.Windows.Forms.Button()
        Me.ViewTxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemName = New System.Windows.Forms.TextBox()
        Me.ItemDescription = New System.Windows.Forms.TextBox()
        Me.ItemPrice = New System.Windows.Forms.TextBox()
        Me.ItemCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListItemBtn = New System.Windows.Forms.Button()
        Me.ShowDataGridBtn = New System.Windows.Forms.Button()
        Me.DescriptionErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PriceErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CategoryListBox = New System.Windows.Forms.ListBox()
        Me.NameErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Panel1.Controls.Add(Me.HomeBtn)
        Me.Panel1.Controls.Add(Me.SearchBtn)
        Me.Panel1.Controls.Add(Me.UserSearch)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 98)
        Me.Panel1.TabIndex = 1
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.HomeBtn.Location = New System.Drawing.Point(570, 25)
        Me.HomeBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(100, 40)
        Me.HomeBtn.TabIndex = 3
        Me.HomeBtn.Text = "HOME"
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBtn.BackgroundImage = CType(resources.GetObject("SearchBtn.BackgroundImage"), System.Drawing.Image)
        Me.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ChartsBtn)
        Me.Panel2.Controls.Add(Me.OrdersBtn)
        Me.Panel2.Controls.Add(Me.ListingsBtn)
        Me.Panel2.Controls.Add(Me.ViewTxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 55)
        Me.Panel2.TabIndex = 2
        '
        'ChartsBtn
        '
        Me.ChartsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChartsBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.ChartsBtn.Location = New System.Drawing.Point(520, 7)
        Me.ChartsBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.ChartsBtn.Name = "ChartsBtn"
        Me.ChartsBtn.Size = New System.Drawing.Size(150, 40)
        Me.ChartsBtn.TabIndex = 3
        Me.ChartsBtn.Text = "CHARTS"
        Me.ChartsBtn.UseVisualStyleBackColor = False
        '
        'OrdersBtn
        '
        Me.OrdersBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrdersBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.OrdersBtn.Location = New System.Drawing.Point(351, 7)
        Me.OrdersBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.OrdersBtn.Name = "OrdersBtn"
        Me.OrdersBtn.Size = New System.Drawing.Size(150, 40)
        Me.OrdersBtn.TabIndex = 7
        Me.OrdersBtn.Text = "ORDERS"
        Me.OrdersBtn.UseVisualStyleBackColor = False
        '
        'ListingsBtn
        '
        Me.ListingsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListingsBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.ListingsBtn.Location = New System.Drawing.Point(181, 7)
        Me.ListingsBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.ListingsBtn.Name = "ListingsBtn"
        Me.ListingsBtn.Size = New System.Drawing.Size(150, 40)
        Me.ListingsBtn.TabIndex = 6
        Me.ListingsBtn.Text = "LISTINGS"
        Me.ListingsBtn.UseVisualStyleBackColor = False
        '
        'ViewTxt
        '
        Me.ViewTxt.BackColor = System.Drawing.Color.White
        Me.ViewTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ViewTxt.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.ViewTxt.Location = New System.Drawing.Point(12, 7)
        Me.ViewTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.ViewTxt.Multiline = True
        Me.ViewTxt.Name = "ViewTxt"
        Me.ViewTxt.ReadOnly = True
        Me.ViewTxt.Size = New System.Drawing.Size(150, 40)
        Me.ViewTxt.TabIndex = 4
        Me.ViewTxt.Text = "VIEW"
        Me.ViewTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.Size = New System.Drawing.Size(319, 490)
        Me.DataGridView1.TabIndex = 3
        '
        'ItemName
        '
        Me.ItemName.Location = New System.Drawing.Point(335, 204)
        Me.ItemName.Multiline = True
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(330, 40)
        Me.ItemName.TabIndex = 4
        '
        'ItemDescription
        '
        Me.ItemDescription.Location = New System.Drawing.Point(335, 293)
        Me.ItemDescription.Multiline = True
        Me.ItemDescription.Name = "ItemDescription"
        Me.ItemDescription.Size = New System.Drawing.Size(330, 40)
        Me.ItemDescription.TabIndex = 5
        '
        'ItemPrice
        '
        Me.ItemPrice.Location = New System.Drawing.Point(335, 384)
        Me.ItemPrice.Multiline = True
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.Size = New System.Drawing.Size(330, 40)
        Me.ItemPrice.TabIndex = 6
        '
        'ItemCategory
        '
        Me.ItemCategory.Location = New System.Drawing.Point(335, 485)
        Me.ItemCategory.Multiline = True
        Me.ItemCategory.Name = "ItemCategory"
        Me.ItemCategory.Size = New System.Drawing.Size(330, 40)
        Me.ItemCategory.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(337, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 30)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(337, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 30)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(337, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 30)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(337, 452)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 30)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Category"
        '
        'ListItemBtn
        '
        Me.ListItemBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListItemBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.ListItemBtn.Location = New System.Drawing.Point(515, 609)
        Me.ListItemBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.ListItemBtn.Name = "ListItemBtn"
        Me.ListItemBtn.Size = New System.Drawing.Size(150, 40)
        Me.ListItemBtn.TabIndex = 8
        Me.ListItemBtn.Text = "LIST ITEM"
        Me.ListItemBtn.UseVisualStyleBackColor = False
        '
        'ShowDataGridBtn
        '
        Me.ShowDataGridBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowDataGridBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowDataGridBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.ShowDataGridBtn.Location = New System.Drawing.Point(335, 609)
        Me.ShowDataGridBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.ShowDataGridBtn.Name = "ShowDataGridBtn"
        Me.ShowDataGridBtn.Size = New System.Drawing.Size(150, 40)
        Me.ShowDataGridBtn.TabIndex = 14
        Me.ShowDataGridBtn.Text = "SHOW"
        Me.ShowDataGridBtn.UseVisualStyleBackColor = False
        '
        'DescriptionErrorProvider
        '
        Me.DescriptionErrorProvider.BlinkRate = 1
        Me.DescriptionErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.DescriptionErrorProvider.ContainerControl = Me
        '
        'PriceErrorProvider
        '
        Me.PriceErrorProvider.BlinkRate = 1
        Me.PriceErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.PriceErrorProvider.ContainerControl = Me
        '
        'CategoryListBox
        '
        Me.CategoryListBox.FormattingEnabled = True
        Me.CategoryListBox.ItemHeight = 21
        Me.CategoryListBox.Items.AddRange(New Object() {"Phones", "Laptops", "TVs"})
        Me.CategoryListBox.Location = New System.Drawing.Point(335, 485)
        Me.CategoryListBox.Name = "CategoryListBox"
        Me.CategoryListBox.Size = New System.Drawing.Size(330, 67)
        Me.CategoryListBox.TabIndex = 15
        '
        'NameErrorProvider
        '
        Me.NameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.NameErrorProvider.ContainerControl = Me
        '
        'Form3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.CategoryListBox)
        Me.Controls.Add(Me.ShowDataGridBtn)
        Me.Controls.Add(Me.ListItemBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ItemCategory)
        Me.Controls.Add(Me.ItemPrice)
        Me.Controls.Add(Me.ItemDescription)
        Me.Controls.Add(Me.ItemName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buy&Sell - Seller Section - Listings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents HomeBtn As Button
    Friend WithEvents SearchBtn As Button
    Friend WithEvents UserSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ChartsBtn As Button
    Friend WithEvents OrdersBtn As Button
    Friend WithEvents ListingsBtn As Button
    Friend WithEvents ViewTxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ItemName As TextBox
    Friend WithEvents ItemDescription As TextBox
    Friend WithEvents ItemPrice As TextBox
    Friend WithEvents ItemCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListItemBtn As Button
    Friend WithEvents ShowDataGridBtn As Button
    Friend WithEvents DescriptionErrorProvider As ErrorProvider
    Friend WithEvents PriceErrorProvider As ErrorProvider
    Friend WithEvents CategoryListBox As ListBox
    Friend WithEvents NameErrorProvider As ErrorProvider
End Class
