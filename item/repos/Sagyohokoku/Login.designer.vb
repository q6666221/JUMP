<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.blueColor = New System.Windows.Forms.ColorDialog()
        Me.RedColor = New System.Windows.Forms.ColorDialog()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Employee = New System.Windows.Forms.ComboBox()
        Me.Department = New System.Windows.Forms.ComboBox()
        Me.Company = New System.Windows.Forms.ComboBox()
        Me.personalNameLabel = New System.Windows.Forms.Label()
        Me.departmentLabel = New System.Windows.Forms.Label()
        Me.companyLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'blueColor
        '
        Me.blueColor.Color = System.Drawing.Color.Blue
        '
        'RedColor
        '
        Me.RedColor.Color = System.Drawing.Color.Red
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(108, 229)
        Me.Password.MaxLength = 15
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(124, 19)
        Me.Password.TabIndex = 45
        Me.Password.UseSystemPasswordChar = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(47, 229)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(55, 20)
        Me.PasswordLabel.TabIndex = 44
        Me.PasswordLabel.Text = "パスワード:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LoginButton.Location = New System.Drawing.Point(49, 281)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(183, 47)
        Me.LoginButton.TabIndex = 43
        Me.LoginButton.Text = "ログイン"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Employee
        '
        Me.Employee.FormattingEnabled = True
        Me.Employee.Location = New System.Drawing.Point(108, 197)
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(124, 20)
        Me.Employee.TabIndex = 42
        '
        'Department
        '
        Me.Department.FormattingEnabled = True
        Me.Department.Location = New System.Drawing.Point(108, 165)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(124, 20)
        Me.Department.TabIndex = 41
        '
        'Company
        '
        Me.Company.FormattingEnabled = True
        Me.Company.Location = New System.Drawing.Point(108, 134)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(124, 20)
        Me.Company.TabIndex = 40
        '
        'personalNameLabel
        '
        Me.personalNameLabel.Location = New System.Drawing.Point(47, 197)
        Me.personalNameLabel.Name = "personalNameLabel"
        Me.personalNameLabel.Size = New System.Drawing.Size(55, 20)
        Me.personalNameLabel.TabIndex = 39
        Me.personalNameLabel.Text = "氏名:"
        Me.personalNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'departmentLabel
        '
        Me.departmentLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.departmentLabel.Location = New System.Drawing.Point(47, 165)
        Me.departmentLabel.Name = "departmentLabel"
        Me.departmentLabel.Size = New System.Drawing.Size(55, 20)
        Me.departmentLabel.TabIndex = 38
        Me.departmentLabel.Text = "所属部署:"
        Me.departmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'companyLabel
        '
        Me.companyLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.companyLabel.Location = New System.Drawing.Point(47, 134)
        Me.companyLabel.Name = "companyLabel"
        Me.companyLabel.Size = New System.Drawing.Size(55, 20)
        Me.companyLabel.TabIndex = 37
        Me.companyLabel.Text = "所属会社:"
        Me.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "WorkReport"
        '
        'CloseButton
        '
        Me.CloseButton.BackgroundImage = CType(resources.GetObject("CloseButton.BackgroundImage"), System.Drawing.Image)
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(256, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(30, 30)
        Me.CloseButton.TabIndex = 48
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(281, 400)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Employee)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.Company)
        Me.Controls.Add(Me.personalNameLabel)
        Me.Controls.Add(Me.departmentLabel)
        Me.Controls.Add(Me.companyLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents blueColor As ColorDialog
    Friend WithEvents RedColor As ColorDialog
    Friend WithEvents Password As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents Employee As ComboBox
    Friend WithEvents Department As ComboBox
    Friend WithEvents Company As ComboBox
    Friend WithEvents personalNameLabel As Label
    Friend WithEvents departmentLabel As Label
    Friend WithEvents companyLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
