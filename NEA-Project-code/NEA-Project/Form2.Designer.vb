<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SellBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.UserSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PhonesBtn = New System.Windows.Forms.Button()
        Me.LaptopsBtn = New System.Windows.Forms.Button()
        Me.TvBtn = New System.Windows.Forms.Button()
        Me.RatingBtn = New System.Windows.Forms.Button()
        Me.NameBtn = New System.Windows.Forms.Button()
        Me.PriceBtn = New System.Windows.Forms.Button()
        Me.CategoryTxt = New System.Windows.Forms.TextBox()
        Me.FilterTxt = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ShowAllBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PhonesBtn)
        Me.Panel2.Controls.Add(Me.LaptopsBtn)
        Me.Panel2.Controls.Add(Me.TvBtn)
        Me.Panel2.Controls.Add(Me.RatingBtn)
        Me.Panel2.Controls.Add(Me.NameBtn)
        Me.Panel2.Controls.Add(Me.PriceBtn)
        Me.Panel2.Controls.Add(Me.CategoryTxt)
        Me.Panel2.Controls.Add(Me.FilterTxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 98)
        Me.Panel2.TabIndex = 1
        '
        'PhonesBtn
        '
        Me.PhonesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhonesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PhonesBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.PhonesBtn.Location = New System.Drawing.Point(181, 55)
        Me.PhonesBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.PhonesBtn.Name = "PhonesBtn"
        Me.PhonesBtn.Size = New System.Drawing.Size(150, 40)
        Me.PhonesBtn.TabIndex = 10
        Me.PhonesBtn.Text = "PHONES"
        Me.PhonesBtn.UseVisualStyleBackColor = False
        '
        'LaptopsBtn
        '
        Me.LaptopsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LaptopsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaptopsBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.LaptopsBtn.Location = New System.Drawing.Point(351, 55)
        Me.LaptopsBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.LaptopsBtn.Name = "LaptopsBtn"
        Me.LaptopsBtn.Size = New System.Drawing.Size(150, 40)
        Me.LaptopsBtn.TabIndex = 9
        Me.LaptopsBtn.Text = "LAPTOPS"
        Me.LaptopsBtn.UseVisualStyleBackColor = False
        '
        'TvBtn
        '
        Me.TvBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TvBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.TvBtn.Location = New System.Drawing.Point(520, 55)
        Me.TvBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.TvBtn.Name = "TvBtn"
        Me.TvBtn.Size = New System.Drawing.Size(150, 40)
        Me.TvBtn.TabIndex = 8
        Me.TvBtn.Text = "TVs"
        Me.TvBtn.UseVisualStyleBackColor = False
        '
        'RatingBtn
        '
        Me.RatingBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RatingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RatingBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.RatingBtn.Location = New System.Drawing.Point(520, 7)
        Me.RatingBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.RatingBtn.Name = "RatingBtn"
        Me.RatingBtn.Size = New System.Drawing.Size(150, 40)
        Me.RatingBtn.TabIndex = 3
        Me.RatingBtn.Text = "RATING"
        Me.RatingBtn.UseVisualStyleBackColor = False
        '
        'NameBtn
        '
        Me.NameBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NameBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.NameBtn.Location = New System.Drawing.Point(351, 7)
        Me.NameBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.NameBtn.Name = "NameBtn"
        Me.NameBtn.Size = New System.Drawing.Size(150, 40)
        Me.NameBtn.TabIndex = 7
        Me.NameBtn.Text = "NAME"
        Me.NameBtn.UseVisualStyleBackColor = False
        '
        'PriceBtn
        '
        Me.PriceBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PriceBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.PriceBtn.Location = New System.Drawing.Point(181, 7)
        Me.PriceBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.PriceBtn.Name = "PriceBtn"
        Me.PriceBtn.Size = New System.Drawing.Size(150, 40)
        Me.PriceBtn.TabIndex = 6
        Me.PriceBtn.Text = "PRICE"
        Me.PriceBtn.UseVisualStyleBackColor = False
        '
        'CategoryTxt
        '
        Me.CategoryTxt.BackColor = System.Drawing.Color.White
        Me.CategoryTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CategoryTxt.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.CategoryTxt.Location = New System.Drawing.Point(12, 55)
        Me.CategoryTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.CategoryTxt.Multiline = True
        Me.CategoryTxt.Name = "CategoryTxt"
        Me.CategoryTxt.ReadOnly = True
        Me.CategoryTxt.Size = New System.Drawing.Size(150, 40)
        Me.CategoryTxt.TabIndex = 5
        Me.CategoryTxt.Text = "CATEGORY"
        Me.CategoryTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FilterTxt
        '
        Me.FilterTxt.BackColor = System.Drawing.Color.White
        Me.FilterTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilterTxt.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.FilterTxt.Location = New System.Drawing.Point(12, 7)
        Me.FilterTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.FilterTxt.Multiline = True
        Me.FilterTxt.Name = "FilterTxt"
        Me.FilterTxt.ReadOnly = True
        Me.FilterTxt.Size = New System.Drawing.Size(150, 40)
        Me.FilterTxt.TabIndex = 4
        Me.FilterTxt.Text = "FILTER"
        Me.FilterTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(359, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(0, 0)
        Me.Panel3.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 202)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.Size = New System.Drawing.Size(658, 391)
        Me.DataGridView2.TabIndex = 3
        '
        'ShowAllBtn
        '
        Me.ShowAllBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowAllBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.ShowAllBtn.Location = New System.Drawing.Point(520, 607)
        Me.ShowAllBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.ShowAllBtn.Name = "ShowAllBtn"
        Me.ShowAllBtn.Size = New System.Drawing.Size(150, 40)
        Me.ShowAllBtn.TabIndex = 4
        Me.ShowAllBtn.Text = "SHOW ALL"
        Me.ShowAllBtn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.ShowAllBtn)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Buy&Sell - Homepage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UserSearch As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents SellBtn As Button
    Friend WithEvents CategoryTxt As TextBox
    Friend WithEvents FilterTxt As TextBox
    Friend WithEvents RatingBtn As Button
    Friend WithEvents NameBtn As Button
    Friend WithEvents PriceBtn As Button
    Friend WithEvents PhonesBtn As Button
    Friend WithEvents LaptopsBtn As Button
    Friend WithEvents TvBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ShowAllBtn As Button
End Class
