<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.LoginPassword = New System.Windows.Forms.TextBox()
        Me.LoginEmail = New System.Windows.Forms.TextBox()
        Me.RegisterPassword = New System.Windows.Forms.TextBox()
        Me.RegisterEmail = New System.Windows.Forms.TextBox()
        Me.RegisterName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EmailErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.NameErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PasswordErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 98)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(684, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LoginBtn)
        Me.Panel2.Controls.Add(Me.RegisterBtn)
        Me.Panel2.Controls.Add(Me.LoginPassword)
        Me.Panel2.Controls.Add(Me.LoginEmail)
        Me.Panel2.Controls.Add(Me.RegisterPassword)
        Me.Panel2.Controls.Add(Me.RegisterEmail)
        Me.Panel2.Controls.Add(Me.RegisterName)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 563)
        Me.Panel2.TabIndex = 1
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.Black
        Me.LoginBtn.Location = New System.Drawing.Point(380, 430)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(200, 40)
        Me.LoginBtn.TabIndex = 11
        Me.LoginBtn.Text = "LOGIN"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'RegisterBtn
        '
        Me.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterBtn.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterBtn.ForeColor = System.Drawing.Color.Black
        Me.RegisterBtn.Location = New System.Drawing.Point(63, 430)
        Me.RegisterBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(200, 40)
        Me.RegisterBtn.TabIndex = 10
        Me.RegisterBtn.Text = "REGISTER"
        Me.RegisterBtn.UseVisualStyleBackColor = False
        '
        'LoginPassword
        '
        Me.LoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginPassword.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginPassword.Location = New System.Drawing.Point(380, 218)
        Me.LoginPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.LoginPassword.Multiline = True
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPassword.Size = New System.Drawing.Size(200, 40)
        Me.LoginPassword.TabIndex = 9
        '
        'LoginEmail
        '
        Me.LoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginEmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginEmail.Location = New System.Drawing.Point(380, 94)
        Me.LoginEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.LoginEmail.Multiline = True
        Me.LoginEmail.Name = "LoginEmail"
        Me.LoginEmail.Size = New System.Drawing.Size(200, 40)
        Me.LoginEmail.TabIndex = 8
        '
        'RegisterPassword
        '
        Me.RegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RegisterPassword.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterPassword.Location = New System.Drawing.Point(63, 350)
        Me.RegisterPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.RegisterPassword.Multiline = True
        Me.RegisterPassword.Name = "RegisterPassword"
        Me.RegisterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RegisterPassword.Size = New System.Drawing.Size(200, 40)
        Me.RegisterPassword.TabIndex = 7
        '
        'RegisterEmail
        '
        Me.RegisterEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RegisterEmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterEmail.Location = New System.Drawing.Point(63, 218)
        Me.RegisterEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.RegisterEmail.Multiline = True
        Me.RegisterEmail.Name = "RegisterEmail"
        Me.RegisterEmail.Size = New System.Drawing.Size(200, 40)
        Me.RegisterEmail.TabIndex = 6
        '
        'RegisterName
        '
        Me.RegisterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RegisterName.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterName.Location = New System.Drawing.Point(63, 94)
        Me.RegisterName.Margin = New System.Windows.Forms.Padding(5)
        Me.RegisterName.Multiline = True
        Me.RegisterName.Name = "RegisterName"
        Me.RegisterName.Size = New System.Drawing.Size(200, 40)
        Me.RegisterName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 24.0!)
        Me.Label5.Location = New System.Drawing.Point(373, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 39)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 24.0!)
        Me.Label4.Location = New System.Drawing.Point(373, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 39)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!)
        Me.Label3.Location = New System.Drawing.Point(56, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 39)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(56, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(56, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'PasswordErrorProvider
        '
        Me.PasswordErrorProvider.BlinkRate = 1
        Me.PasswordErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.PasswordErrorProvider.ContainerControl = Me
        '
        'EmailErrorProvider
        '
        Me.EmailErrorProvider.BlinkRate = 1
        Me.EmailErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EmailErrorProvider.ContainerControl = Me
        '
        'NameErrorProvider
        '
        Me.NameErrorProvider.BlinkRate = 1
        Me.NameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.NameErrorProvider.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buy&Sell - Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PasswordErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginPassword As TextBox
    Friend WithEvents LoginEmail As TextBox
    Friend WithEvents RegisterPassword As TextBox
    Friend WithEvents RegisterEmail As TextBox
    Friend WithEvents RegisterName As TextBox
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents LoginBtn As Button
    Friend WithEvents PasswordErrorProvider As ErrorProvider
    Friend WithEvents EmailErrorProvider As ErrorProvider
    Friend WithEvents NameErrorProvider As ErrorProvider
End Class
