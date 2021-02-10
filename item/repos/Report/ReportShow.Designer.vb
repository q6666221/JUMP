Imports System.Data.SqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportShow
    Inherits System.Windows.Forms.Form

    Public employee As Employees
    Public conn As SqlConnection
    Public Sub New(employee As Employees, conn As SqlConnection)
        Me.employee = employee
        Me.conn = conn
        InitializeComponent()

    End Sub

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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SealView = New System.Windows.Forms.DataGridView()
        Me.dep_manager = New System.Windows.Forms.DataGridViewImageColumn()
        Me.off_manager = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pro_manager = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WorkTable = New System.Windows.Forms.Label()
        Me.Tittle = New System.Windows.Forms.Label()
        Me.WorkTittle = New System.Windows.Forms.Label()
        Me.WorkText = New System.Windows.Forms.TextBox()
        Me.Finish = New System.Windows.Forms.RadioButton()
        Me.Not_Finish = New System.Windows.Forms.RadioButton()
        Me.Status_Label = New System.Windows.Forms.Label()
        Me.Emp = New System.Windows.Forms.ComboBox()
        Me.MessageView = New System.Windows.Forms.DataGridView()
        Me.Message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessageValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Year = New System.Windows.Forms.TextBox()
        Me.Mon = New System.Windows.Forms.TextBox()
        Me.ReportView = New System.Windows.Forms.DataGridView()
        Me.day_week = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.week = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Start_Time = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.End_Time = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.content = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.SealView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessageView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SealView
        '
        Me.SealView.AllowUserToAddRows = False
        Me.SealView.AllowUserToOrderColumns = True
        Me.SealView.AllowUserToResizeColumns = False
        Me.SealView.AllowUserToResizeRows = False
        Me.SealView.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 7.8!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SealView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.SealView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SealView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dep_manager, Me.off_manager, Me.pro_manager})
        Me.SealView.Location = New System.Drawing.Point(393, 139)
        Me.SealView.Name = "SealView"
        Me.SealView.ReadOnly = True
        Me.SealView.RowHeadersVisible = False
        Me.SealView.RowHeadersWidth = 51
        Me.SealView.RowTemplate.Height = 21
        Me.SealView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SealView.Size = New System.Drawing.Size(243, 113)
        Me.SealView.TabIndex = 24
        '
        'dep_manager
        '
        Me.dep_manager.HeaderText = "部長"
        Me.dep_manager.Image = Global.Report.My.Resources.Resources.tyou
        Me.dep_manager.MinimumWidth = 6
        Me.dep_manager.Name = "dep_manager"
        Me.dep_manager.ReadOnly = True
        Me.dep_manager.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dep_manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dep_manager.Width = 80
        '
        'off_manager
        '
        Me.off_manager.HeaderText = "課長"
        Me.off_manager.Image = Global.Report.My.Resources.Resources.tyou
        Me.off_manager.MinimumWidth = 6
        Me.off_manager.Name = "off_manager"
        Me.off_manager.ReadOnly = True
        Me.off_manager.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.off_manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.off_manager.Width = 80
        '
        'pro_manager
        '
        Me.pro_manager.HeaderText = "プロジェクト管理者"
        Me.pro_manager.Image = Global.Report.My.Resources.Resources.tyou
        Me.pro_manager.MinimumWidth = 6
        Me.pro_manager.Name = "pro_manager"
        Me.pro_manager.ReadOnly = True
        Me.pro_manager.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pro_manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.pro_manager.Width = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(53, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "（標準版）"
        '
        'WorkTable
        '
        Me.WorkTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WorkTable.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!)
        Me.WorkTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WorkTable.Location = New System.Drawing.Point(112, 263)
        Me.WorkTable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.WorkTable.Name = "WorkTable"
        Me.WorkTable.Size = New System.Drawing.Size(80, 18)
        Me.WorkTable.TabIndex = 22
        Me.WorkTable.Text = "作業報告欄"
        Me.WorkTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tittle
        '
        Me.Tittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tittle.Font = New System.Drawing.Font("SimSun-ExtB", 20.0!)
        Me.Tittle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Tittle.Location = New System.Drawing.Point(271, 39)
        Me.Tittle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Tittle.Name = "Tittle"
        Me.Tittle.Size = New System.Drawing.Size(162, 32)
        Me.Tittle.TabIndex = 20
        Me.Tittle.Text = "作業報告書"
        Me.Tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WorkTittle
        '
        Me.WorkTittle.AutoSize = True
        Me.WorkTittle.Font = New System.Drawing.Font("SimSun-ExtB", 12.0!)
        Me.WorkTittle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WorkTittle.Location = New System.Drawing.Point(52, 999)
        Me.WorkTittle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.WorkTittle.Name = "WorkTittle"
        Me.WorkTittle.Size = New System.Drawing.Size(96, 16)
        Me.WorkTittle.TabIndex = 29
        Me.WorkTittle.Text = "[特記事項］"
        '
        'WorkText
        '
        Me.WorkText.Location = New System.Drawing.Point(55, 1018)
        Me.WorkText.Margin = New System.Windows.Forms.Padding(2)
        Me.WorkText.Multiline = True
        Me.WorkText.Name = "WorkText"
        Me.WorkText.Size = New System.Drawing.Size(581, 106)
        Me.WorkText.TabIndex = 28
        '
        'Finish
        '
        Me.Finish.AutoSize = True
        Me.Finish.Location = New System.Drawing.Point(460, 263)
        Me.Finish.Margin = New System.Windows.Forms.Padding(2)
        Me.Finish.Name = "Finish"
        Me.Finish.Size = New System.Drawing.Size(35, 16)
        Me.Finish.TabIndex = 30
        Me.Finish.TabStop = True
        Me.Finish.Text = "済"
        Me.Finish.UseVisualStyleBackColor = True
        '
        'Not_Finish
        '
        Me.Not_Finish.AutoSize = True
        Me.Not_Finish.Location = New System.Drawing.Point(505, 263)
        Me.Not_Finish.Margin = New System.Windows.Forms.Padding(2)
        Me.Not_Finish.Name = "Not_Finish"
        Me.Not_Finish.Size = New System.Drawing.Size(35, 16)
        Me.Not_Finish.TabIndex = 31
        Me.Not_Finish.TabStop = True
        Me.Not_Finish.Text = "未"
        Me.Not_Finish.UseVisualStyleBackColor = True
        '
        'Status_Label
        '
        Me.Status_Label.AutoSize = True
        Me.Status_Label.Location = New System.Drawing.Point(394, 265)
        Me.Status_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Status_Label.Name = "Status_Label"
        Me.Status_Label.Size = New System.Drawing.Size(59, 12)
        Me.Status_Label.TabIndex = 32
        Me.Status_Label.Text = "確認状態："
        '
        'Emp
        '
        Me.Emp.FormattingEnabled = True
        Me.Emp.Location = New System.Drawing.Point(242, 261)
        Me.Emp.Margin = New System.Windows.Forms.Padding(2)
        Me.Emp.Name = "Emp"
        Me.Emp.Size = New System.Drawing.Size(92, 20)
        Me.Emp.TabIndex = 33
        '
        'MessageView
        '
        Me.MessageView.AllowUserToAddRows = False
        Me.MessageView.AllowUserToResizeColumns = False
        Me.MessageView.AllowUserToResizeRows = False
        Me.MessageView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.MessageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MessageView.ColumnHeadersVisible = False
        Me.MessageView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Message, Me.MessageValue})
        Me.MessageView.Location = New System.Drawing.Point(55, 144)
        Me.MessageView.Margin = New System.Windows.Forms.Padding(2)
        Me.MessageView.Name = "MessageView"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MessageView.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.MessageView.RowHeadersVisible = False
        Me.MessageView.RowHeadersWidth = 51
        Me.MessageView.RowTemplate.Height = 27
        Me.MessageView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MessageView.Size = New System.Drawing.Size(278, 108)
        Me.MessageView.TabIndex = 36
        '
        'Message
        '
        Me.Message.HeaderText = "Message"
        Me.Message.MinimumWidth = 6
        Me.Message.Name = "Message"
        Me.Message.ReadOnly = True
        Me.Message.Width = 138
        '
        'MessageValue
        '
        Me.MessageValue.HeaderText = "MessageList"
        Me.MessageValue.MinimumWidth = 6
        Me.MessageValue.Name = "MessageValue"
        Me.MessageValue.ReadOnly = True
        Me.MessageValue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MessageValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MessageValue.Width = 137
        '
        'Year
        '
        Me.Year.Location = New System.Drawing.Point(271, 95)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(73, 19)
        Me.Year.TabIndex = 37
        '
        'Mon
        '
        Me.Mon.Location = New System.Drawing.Point(353, 95)
        Me.Mon.Name = "Mon"
        Me.Mon.Size = New System.Drawing.Size(80, 19)
        Me.Mon.TabIndex = 38
        '
        'ReportView
        '
        Me.ReportView.AllowUserToAddRows = False
        Me.ReportView.AllowUserToResizeColumns = False
        Me.ReportView.AllowUserToResizeRows = False
        Me.ReportView.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.ReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.day_week, Me.week, Me.Start_Time, Me.End_Time, Me.time, Me.content})
        Me.ReportView.Location = New System.Drawing.Point(55, 285)
        Me.ReportView.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportView.Name = "ReportView"
        Me.ReportView.RowHeadersVisible = False
        Me.ReportView.RowHeadersWidth = 51
        Me.ReportView.RowTemplate.Height = 20
        Me.ReportView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ReportView.Size = New System.Drawing.Size(581, 710)
        Me.ReportView.TabIndex = 39
        '
        'day_week
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        DataGridViewCellStyle12.NullValue = Nothing
        Me.day_week.DefaultCellStyle = DataGridViewCellStyle12
        Me.day_week.HeaderText = "日付"
        Me.day_week.MinimumWidth = 6
        Me.day_week.Name = "day_week"
        Me.day_week.ReadOnly = True
        Me.day_week.Width = 36
        '
        'week
        '
        Me.week.HeaderText = "曜日"
        Me.week.MinimumWidth = 6
        Me.week.Name = "week"
        Me.week.ReadOnly = True
        Me.week.Width = 35
        '
        'Start_Time
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Time.DefaultCellStyle = DataGridViewCellStyle13
        Me.Start_Time.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Start_Time.HeaderText = "開始"
        Me.Start_Time.Items.AddRange(New Object() {"", "0:00", "0:15", "0:30", "0:45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00", "19:15", "19:30", "19:45", "20:00", "20:15", "20:30", "20:45", "21:00", "21:15", "21:30", "21:45", "22:00", "22:15", "22:30", "22:45", "23:00", "23:15", "23:30", "23:45"})
        Me.Start_Time.MinimumWidth = 6
        Me.Start_Time.Name = "Start_Time"
        Me.Start_Time.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Start_Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Start_Time.Width = 65
        '
        'End_Time
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Time.DefaultCellStyle = DataGridViewCellStyle14
        Me.End_Time.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.End_Time.HeaderText = "終了"
        Me.End_Time.Items.AddRange(New Object() {"", "0:00", "0:15", "0:30", "0:45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00", "19:15", "19:30", "19:45", "20:00", "20:15", "20:30", "20:45", "21:00", "21:15", "21:30", "21:45", "22:00", "22:15", "22:30", "22:45", "23:00", "23:15", "23:30", "23:45", "24:00", "24:15", "24:30", "24:45", "25:00", "25:15", "25:30", "25:45", "26:00", "26:15", "26:30", "26:45", "27:00", "27:15", "27:30", "27:45", "28:00", "28:15", "28:30", "28:45", "29:00", "29:15", "29:30", "29:45", "30:00", "30:15", "30:30", "30:45", "31:00", "31:15", "31:30", "31:45", "32:00", "32:15", "32:30", "32:45", "33:00"})
        Me.End_Time.MinimumWidth = 6
        Me.End_Time.Name = "End_Time"
        Me.End_Time.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.End_Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.End_Time.Width = 65
        '
        'time
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.DefaultCellStyle = DataGridViewCellStyle15
        Me.time.HeaderText = "工数"
        Me.time.MinimumWidth = 6
        Me.time.Name = "time"
        Me.time.ReadOnly = True
        Me.time.Width = 65
        '
        'content
        '
        DataGridViewCellStyle16.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.content.DefaultCellStyle = DataGridViewCellStyle16
        Me.content.HeaderText = "作業内容"
        Me.content.MinimumWidth = 6
        Me.content.Name = "content"
        Me.content.Width = 300
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "部長"
        Me.DataGridViewImageColumn1.Image = Global.Report.My.Resources.Resources.tyou
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 80
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "課長"
        Me.DataGridViewImageColumn2.Image = Global.Report.My.Resources.Resources.tyou
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 80
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "プロジェクト管理者"
        Me.DataGridViewImageColumn3.Image = Global.Report.My.Resources.Resources.tyou
        Me.DataGridViewImageColumn3.MinimumWidth = 6
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn3.Width = 80
        '
        'ReportShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(757, 705)
        Me.Controls.Add(Me.ReportView)
        Me.Controls.Add(Me.Mon)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.MessageView)
        Me.Controls.Add(Me.Emp)
        Me.Controls.Add(Me.Status_Label)
        Me.Controls.Add(Me.Not_Finish)
        Me.Controls.Add(Me.Finish)
        Me.Controls.Add(Me.WorkTittle)
        Me.Controls.Add(Me.WorkText)
        Me.Controls.Add(Me.SealView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WorkTable)
        Me.Controls.Add(Me.Tittle)
        Me.Name = "ReportShow"
        Me.Text = "ReportShow"
        CType(Me.SealView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessageView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SealView As DataGridView
    Friend WithEvents dep_manager As DataGridViewImageColumn
    Friend WithEvents off_manager As DataGridViewImageColumn
    Friend WithEvents pro_manager As DataGridViewImageColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents WorkTable As Label
    Friend WithEvents Tittle As Label
    Friend WithEvents WorkTittle As Label
    Friend WithEvents WorkText As TextBox
    Friend WithEvents Finish As RadioButton
    Friend WithEvents Not_Finish As RadioButton
    Friend WithEvents Status_Label As Label
    Friend WithEvents Emp As ComboBox
    Friend WithEvents MessageView As DataGridView
    Friend WithEvents Message As DataGridViewTextBoxColumn
    Friend WithEvents MessageValue As DataGridViewTextBoxColumn
    Friend WithEvents Year As TextBox
    Friend WithEvents Mon As TextBox
    Friend WithEvents ReportView As DataGridView
    Friend WithEvents day_week As DataGridViewTextBoxColumn
    Friend WithEvents week As DataGridViewTextBoxColumn
    Friend WithEvents Start_Time As DataGridViewComboBoxColumn
    Friend WithEvents End_Time As DataGridViewComboBoxColumn
    Friend WithEvents time As DataGridViewTextBoxColumn
    Friend WithEvents content As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
End Class
