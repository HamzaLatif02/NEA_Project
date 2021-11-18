<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChartsBtn = New System.Windows.Forms.Button()
        Me.OrdersBtn = New System.Windows.Forms.Button()
        Me.ListingsBtn = New System.Windows.Forms.Button()
        Me.ViewTxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.UserSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ShowDataGrid2Btn = New System.Windows.Forms.Button()
        Me.ShowDataGrid1Btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel2.TabIndex = 4
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
        Me.Panel1.TabIndex = 3
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.Size = New System.Drawing.Size(319, 436)
        Me.DataGridView1.TabIndex = 5
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(353, 159)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.Size = New System.Drawing.Size(319, 436)
        Me.DataGridView2.TabIndex = 6
        '
        'ShowDataGrid2Btn
        '
        Me.ShowDataGrid2Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowDataGrid2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowDataGrid2Btn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.ShowDataGrid2Btn.Location = New System.Drawing.Point(522, 607)
        Me.ShowDataGrid2Btn.Margin = New System.Windows.Forms.Padding(5)
        Me.ShowDataGrid2Btn.Name = "ShowDataGrid2Btn"
        Me.ShowDataGrid2Btn.Size = New System.Drawing.Size(150, 40)
        Me.ShowDataGrid2Btn.TabIndex = 15
        Me.ShowDataGrid2Btn.Text = "SHOW"
        Me.ShowDataGrid2Btn.UseVisualStyleBackColor = False
        '
        'ShowDataGrid1Btn
        '
        Me.ShowDataGrid1Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowDataGrid1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowDataGrid1Btn.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.ShowDataGrid1Btn.Location = New System.Drawing.Point(181, 607)
        Me.ShowDataGrid1Btn.Margin = New System.Windows.Forms.Padding(5)
        Me.ShowDataGrid1Btn.Name = "ShowDataGrid1Btn"
        Me.ShowDataGrid1Btn.Size = New System.Drawing.Size(150, 40)
        Me.ShowDataGrid1Btn.TabIndex = 16
        Me.ShowDataGrid1Btn.Text = "SHOW"
        Me.ShowDataGrid1Btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 607)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Orders Delivered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 607)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Orders Not Delivered"
        '
        'Form4
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShowDataGrid1Btn)
        Me.Controls.Add(Me.ShowDataGrid2Btn)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buy&Sell - Seller Section - Orders"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents ChartsBtn As Button
    Friend WithEvents OrdersBtn As Button
    Friend WithEvents ListingsBtn As Button
    Friend WithEvents ViewTxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents HomeBtn As Button
    Friend WithEvents SearchBtn As Button
    Friend WithEvents UserSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ShowDataGrid2Btn As Button
    Friend WithEvents ShowDataGrid1Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
