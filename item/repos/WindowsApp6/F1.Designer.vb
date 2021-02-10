<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1
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
        Me.components = New System.ComponentModel.Container()
        Me.Company = New System.Windows.Forms.ComboBox()
        Me.Department = New System.Windows.Forms.ComboBox()
        Me.Emp = New System.Windows.Forms.ComboBox()
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.Mon = New System.Windows.Forms.ComboBox()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.NeweliteDataSet = New WindowsApp6.NeweliteDataSet()
        Me.CompanysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanysTableAdapter = New WindowsApp6.NeweliteDataSetTableAdapters.companysTableAdapter()
        CType(Me.NeweliteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Company
        '
        Me.Company.FormattingEnabled = True
        Me.Company.Location = New System.Drawing.Point(221, 106)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(121, 20)
        Me.Company.TabIndex = 0
        '
        'Department
        '
        Me.Department.FormattingEnabled = True
        Me.Department.Location = New System.Drawing.Point(221, 133)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(121, 20)
        Me.Department.TabIndex = 1
        '
        'Emp
        '
        Me.Emp.FormattingEnabled = True
        Me.Emp.Location = New System.Drawing.Point(221, 160)
        Me.Emp.Name = "Emp"
        Me.Emp.Size = New System.Drawing.Size(121, 20)
        Me.Emp.TabIndex = 2
        '
        'Year
        '
        Me.Year.FormattingEnabled = True
        Me.Year.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.Year.Location = New System.Drawing.Point(221, 80)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(57, 20)
        Me.Year.TabIndex = 3
        Me.Year.Text = "2020"
        '
        'Mon
        '
        Me.Mon.FormattingEnabled = True
        Me.Mon.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Mon.Location = New System.Drawing.Point(284, 80)
        Me.Mon.Name = "Mon"
        Me.Mon.Size = New System.Drawing.Size(58, 20)
        Me.Mon.TabIndex = 4
        Me.Mon.Text = "01"
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(221, 197)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(121, 23)
        Me.FindButton.TabIndex = 5
        Me.FindButton.Text = "探す"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'NeweliteDataSet
        '
        Me.NeweliteDataSet.DataSetName = "NeweliteDataSet"
        Me.NeweliteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanysBindingSource
        '
        Me.CompanysBindingSource.DataMember = "companys"
        Me.CompanysBindingSource.DataSource = Me.NeweliteDataSet
        '
        'CompanysTableAdapter
        '
        Me.CompanysTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 255)
        Me.Controls.Add(Me.FindButton)
        Me.Controls.Add(Me.Mon)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Emp)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.Company)
        Me.Name = "Form1"
        Me.Text = "GetReport"
        CType(Me.NeweliteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Company As ComboBox
    Friend WithEvents Department As ComboBox
    Friend WithEvents Emp As ComboBox
    Friend WithEvents Year As ComboBox
    Friend WithEvents Mon As ComboBox
    Friend WithEvents FindButton As Button
    Friend WithEvents NeweliteDataSet As NeweliteDataSet
    Friend WithEvents CompanysBindingSource As BindingSource
    Friend WithEvents CompanysTableAdapter As NeweliteDataSetTableAdapters.companysTableAdapter
End Class
