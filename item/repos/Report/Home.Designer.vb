<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form
    Public employee As Employees
    Public conn As SqlClient.SqlConnection
    Public Sub New(employee As Employees, conn As SqlClient.SqlConnection)
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
        Me.MessageView = New System.Windows.Forms.DataGridView()
        Me.MessageHeader = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessageText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermissionView = New System.Windows.Forms.DataGridView()
        Me.Func = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.MessageView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermissionView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MessageView
        '
        Me.MessageView.AllowUserToAddRows = False
        Me.MessageView.AllowUserToResizeColumns = False
        Me.MessageView.AllowUserToResizeRows = False
        Me.MessageView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.MessageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MessageView.ColumnHeadersVisible = False
        Me.MessageView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MessageHeader, Me.MessageText})
        Me.MessageView.Location = New System.Drawing.Point(26, 25)
        Me.MessageView.Name = "MessageView"
        Me.MessageView.RowHeadersVisible = False
        Me.MessageView.RowTemplate.Height = 21
        Me.MessageView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MessageView.Size = New System.Drawing.Size(230, 106)
        Me.MessageView.TabIndex = 0
        '
        'MessageHeader
        '
        Me.MessageHeader.HeaderText = "項目名"
        Me.MessageHeader.Name = "MessageHeader"
        Me.MessageHeader.Width = 80
        '
        'MessageText
        '
        Me.MessageText.HeaderText = "項目内容"
        Me.MessageText.Name = "MessageText"
        '
        'PermissionView
        '
        Me.PermissionView.AllowUserToAddRows = False
        Me.PermissionView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.PermissionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermissionView.ColumnHeadersVisible = False
        Me.PermissionView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Func})
        Me.PermissionView.Location = New System.Drawing.Point(26, 137)
        Me.PermissionView.Name = "PermissionView"
        Me.PermissionView.RowHeadersVisible = False
        Me.PermissionView.RowTemplate.Height = 21
        Me.PermissionView.Size = New System.Drawing.Size(466, 219)
        Me.PermissionView.TabIndex = 1
        '
        'Func
        '
        Me.Func.HeaderText = "機能"
        Me.Func.Name = "Func"
        Me.Func.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Func.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Func.Width = 200
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(533, 371)
        Me.Controls.Add(Me.PermissionView)
        Me.Controls.Add(Me.MessageView)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Home"
        Me.Text = "Form"
        CType(Me.MessageView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermissionView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MessageView As DataGridView
    Friend WithEvents MessageHeader As DataGridViewTextBoxColumn
    Friend WithEvents MessageText As DataGridViewTextBoxColumn
    Friend WithEvents PermissionView As DataGridView
    Friend WithEvents Func As DataGridViewButtonColumn
End Class
