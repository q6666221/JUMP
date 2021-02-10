Imports System.Data.SqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportConfirm
    Inherits System.Windows.Forms.Form

    Public employee As Employees
    Public conn As SqlConnection

    Public Sub New(employee As Employees, conn As SqlConnection)
        Me.employee = employee
        Me.conn = conn
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

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
        Me.ReportsView = New System.Windows.Forms.DataGridView()
        Me.Check_Flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Report_Button = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Check = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mon = New System.Windows.Forms.ComboBox()
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.Status_Label = New System.Windows.Forms.Label()
        Me.Not_Finish = New System.Windows.Forms.RadioButton()
        Me.Finish = New System.Windows.Forms.RadioButton()
        CType(Me.ReportsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportsView
        '
        Me.ReportsView.AllowUserToAddRows = False
        Me.ReportsView.AllowUserToDeleteRows = False
        Me.ReportsView.AllowUserToResizeColumns = False
        Me.ReportsView.AllowUserToResizeRows = False
        Me.ReportsView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.ReportsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportsView.ColumnHeadersVisible = False
        Me.ReportsView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check_Flag, Me.Report_Button, Me.Check})
        Me.ReportsView.Location = New System.Drawing.Point(35, 169)
        Me.ReportsView.Name = "ReportsView"
        Me.ReportsView.RowHeadersVisible = False
        Me.ReportsView.RowTemplate.Height = 21
        Me.ReportsView.Size = New System.Drawing.Size(624, 737)
        Me.ReportsView.TabIndex = 0
        '
        'Check_Flag
        '
        Me.Check_Flag.HeaderText = "表記"
        Me.Check_Flag.Name = "Check_Flag"
        Me.Check_Flag.Width = 20
        '
        'Report_Button
        '
        Me.Report_Button.HeaderText = "作業報告詳細"
        Me.Report_Button.Name = "Report_Button"
        Me.Report_Button.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Report_Button.Width = 300
        '
        'Check
        '
        Me.Check.HeaderText = "承認"
        Me.Check.Name = "Check"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "作業報告書一覧"
        '
        'Mon
        '
        Me.Mon.FormattingEnabled = True
        Me.Mon.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.Mon.Location = New System.Drawing.Point(343, 88)
        Me.Mon.Name = "Mon"
        Me.Mon.Size = New System.Drawing.Size(76, 20)
        Me.Mon.TabIndex = 21
        '
        'Year
        '
        Me.Year.FormattingEnabled = True
        Me.Year.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.Year.Location = New System.Drawing.Point(257, 88)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(80, 20)
        Me.Year.TabIndex = 20
        '
        'Status_Label
        '
        Me.Status_Label.AutoSize = True
        Me.Status_Label.Location = New System.Drawing.Point(255, 136)
        Me.Status_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Status_Label.Name = "Status_Label"
        Me.Status_Label.Size = New System.Drawing.Size(59, 12)
        Me.Status_Label.TabIndex = 35
        Me.Status_Label.Text = "承認状態："
        '
        'Not_Finish
        '
        Me.Not_Finish.AutoSize = True
        Me.Not_Finish.Location = New System.Drawing.Point(343, 134)
        Me.Not_Finish.Margin = New System.Windows.Forms.Padding(2)
        Me.Not_Finish.Name = "Not_Finish"
        Me.Not_Finish.Size = New System.Drawing.Size(35, 16)
        Me.Not_Finish.TabIndex = 34
        Me.Not_Finish.TabStop = True
        Me.Not_Finish.Text = "未"
        Me.Not_Finish.UseVisualStyleBackColor = True
        '
        'Finish
        '
        Me.Finish.AutoSize = True
        Me.Finish.Location = New System.Drawing.Point(384, 134)
        Me.Finish.Margin = New System.Windows.Forms.Padding(2)
        Me.Finish.Name = "Finish"
        Me.Finish.Size = New System.Drawing.Size(35, 16)
        Me.Finish.TabIndex = 33
        Me.Finish.TabStop = True
        Me.Finish.Text = "済"
        Me.Finish.UseVisualStyleBackColor = True
        '
        'ReportConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(739, 450)
        Me.Controls.Add(Me.Status_Label)
        Me.Controls.Add(Me.Not_Finish)
        Me.Controls.Add(Me.Finish)
        Me.Controls.Add(Me.Mon)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportsView)
        Me.Name = "ReportConfirm"
        Me.Text = "ReportConfirm"
        CType(Me.ReportsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportsView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Check_Flag As DataGridViewCheckBoxColumn
    Friend WithEvents Report_Button As DataGridViewButtonColumn
    Friend WithEvents Check As DataGridViewTextBoxColumn
    Friend WithEvents Mon As ComboBox
    Friend WithEvents Year As ComboBox
    Friend WithEvents Status_Label As Label
    Friend WithEvents Not_Finish As RadioButton
    Friend WithEvents Finish As RadioButton
End Class
