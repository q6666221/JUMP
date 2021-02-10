<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer
    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.user_name = New System.Windows.Forms.Label()
        Me.Department = New System.Windows.Forms.ComboBox()
        Me.Employee = New System.Windows.Forms.ComboBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Company = New System.Windows.Forms.ComboBox()
        Me.department_name = New System.Windows.Forms.Label()
        Me.company_name = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(139, 182)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(164, 23)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "ログイン"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'user_name
        '
        Me.user_name.AutoSize = True
        Me.user_name.Cursor = System.Windows.Forms.Cursors.Default
        Me.user_name.Location = New System.Drawing.Point(71, 113)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(57, 12)
        Me.user_name.TabIndex = 3
        Me.user_name.Text = "ユーザー名"
        '
        'Department
        '
        Me.Department.FormattingEnabled = True
        Me.Department.Location = New System.Drawing.Point(139, 84)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(164, 20)
        Me.Department.TabIndex = 4
        '
        'Employee
        '
        Me.Employee.FormattingEnabled = True
        Me.Employee.Location = New System.Drawing.Point(139, 110)
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(164, 20)
        Me.Employee.TabIndex = 5
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(139, 136)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(164, 19)
        Me.Password.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "パスワード"
        '
        'Company
        '
        Me.Company.FormattingEnabled = True
        Me.Company.Location = New System.Drawing.Point(139, 58)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(164, 20)
        Me.Company.TabIndex = 8
        '
        'department_name
        '
        Me.department_name.AutoSize = True
        Me.department_name.Location = New System.Drawing.Point(94, 90)
        Me.department_name.Name = "department_name"
        Me.department_name.Size = New System.Drawing.Size(41, 12)
        Me.department_name.TabIndex = 9
        Me.department_name.Text = "部署名"
        '
        'company_name
        '
        Me.company_name.AutoSize = True
        Me.company_name.Location = New System.Drawing.Point(94, 64)
        Me.company_name.Name = "company_name"
        Me.company_name.Size = New System.Drawing.Size(41, 12)
        Me.company_name.TabIndex = 10
        Me.company_name.Text = "会社名"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(454, 271)
        Me.Controls.Add(Me.company_name)
        Me.Controls.Add(Me.department_name)
        Me.Controls.Add(Me.Company)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Employee)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.user_name)
        Me.Controls.Add(Me.LoginButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginButton As Button
    Friend WithEvents user_name As Label
    Friend WithEvents Department As ComboBox
    Friend WithEvents Employee As ComboBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Company As ComboBox
    Friend WithEvents department_name As Label
    Friend WithEvents company_name As Label
End Class
