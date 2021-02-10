Imports System.IO
Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportInput))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tittle = New System.Windows.Forms.Label()
        Me.MessageView = New System.Windows.Forms.DataGridView()
        Me.Message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessageValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkTable = New System.Windows.Forms.Label()
        Me.WorkText = New System.Windows.Forms.TextBox()
        Me.WorkTittle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WorkTimeList = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SealView = New System.Windows.Forms.DataGridView()
        Me.dep_manager = New System.Windows.Forms.DataGridViewImageColumn()
        Me.off_manager = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pro_manager = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.Mon = New System.Windows.Forms.ComboBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ReportView = New System.Windows.Forms.DataGridView()
        Me.day_week = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.week = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Start_Time = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.End_Time = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.content = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MessageView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SealView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tittle
        '
        Me.Tittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Tittle, "Tittle")
        Me.Tittle.Name = "Tittle"
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
        resources.ApplyResources(Me.MessageView, "MessageView")
        Me.MessageView.Name = "MessageView"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MessageView.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.MessageView.RowHeadersVisible = False
        Me.MessageView.RowTemplate.Height = 27
        '
        'Message
        '
        resources.ApplyResources(Me.Message, "Message")
        Me.Message.Name = "Message"
        Me.Message.ReadOnly = True
        '
        'MessageValue
        '
        resources.ApplyResources(Me.MessageValue, "MessageValue")
        Me.MessageValue.Name = "MessageValue"
        Me.MessageValue.ReadOnly = True
        Me.MessageValue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MessageValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'WorkTable
        '
        Me.WorkTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.WorkTable, "WorkTable")
        Me.WorkTable.Name = "WorkTable"
        '
        'WorkText
        '
        resources.ApplyResources(Me.WorkText, "WorkText")
        Me.WorkText.Name = "WorkText"
        '
        'WorkTittle
        '
        resources.ApplyResources(Me.WorkTittle, "WorkTittle")
        Me.WorkTittle.Name = "WorkTittle"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'WorkTimeList
        '
        resources.ApplyResources(Me.WorkTimeList, "WorkTimeList")
        Me.WorkTimeList.FormattingEnabled = True
        Me.WorkTimeList.Items.AddRange(New Object() {resources.GetString("WorkTimeList.Items"), resources.GetString("WorkTimeList.Items1"), resources.GetString("WorkTimeList.Items2"), resources.GetString("WorkTimeList.Items3"), resources.GetString("WorkTimeList.Items4"), resources.GetString("WorkTimeList.Items5"), resources.GetString("WorkTimeList.Items6"), resources.GetString("WorkTimeList.Items7"), resources.GetString("WorkTimeList.Items8"), resources.GetString("WorkTimeList.Items9"), resources.GetString("WorkTimeList.Items10"), resources.GetString("WorkTimeList.Items11"), resources.GetString("WorkTimeList.Items12"), resources.GetString("WorkTimeList.Items13"), resources.GetString("WorkTimeList.Items14"), resources.GetString("WorkTimeList.Items15"), resources.GetString("WorkTimeList.Items16"), resources.GetString("WorkTimeList.Items17"), resources.GetString("WorkTimeList.Items18"), resources.GetString("WorkTimeList.Items19"), resources.GetString("WorkTimeList.Items20"), resources.GetString("WorkTimeList.Items21"), resources.GetString("WorkTimeList.Items22"), resources.GetString("WorkTimeList.Items23"), resources.GetString("WorkTimeList.Items24"), resources.GetString("WorkTimeList.Items25"), resources.GetString("WorkTimeList.Items26"), resources.GetString("WorkTimeList.Items27"), resources.GetString("WorkTimeList.Items28"), resources.GetString("WorkTimeList.Items29"), resources.GetString("WorkTimeList.Items30"), resources.GetString("WorkTimeList.Items31"), resources.GetString("WorkTimeList.Items32"), resources.GetString("WorkTimeList.Items33"), resources.GetString("WorkTimeList.Items34"), resources.GetString("WorkTimeList.Items35"), resources.GetString("WorkTimeList.Items36"), resources.GetString("WorkTimeList.Items37"), resources.GetString("WorkTimeList.Items38"), resources.GetString("WorkTimeList.Items39"), resources.GetString("WorkTimeList.Items40"), resources.GetString("WorkTimeList.Items41"), resources.GetString("WorkTimeList.Items42"), resources.GetString("WorkTimeList.Items43"), resources.GetString("WorkTimeList.Items44"), resources.GetString("WorkTimeList.Items45"), resources.GetString("WorkTimeList.Items46"), resources.GetString("WorkTimeList.Items47"), resources.GetString("WorkTimeList.Items48"), resources.GetString("WorkTimeList.Items49"), resources.GetString("WorkTimeList.Items50"), resources.GetString("WorkTimeList.Items51"), resources.GetString("WorkTimeList.Items52"), resources.GetString("WorkTimeList.Items53"), resources.GetString("WorkTimeList.Items54"), resources.GetString("WorkTimeList.Items55"), resources.GetString("WorkTimeList.Items56"), resources.GetString("WorkTimeList.Items57"), resources.GetString("WorkTimeList.Items58"), resources.GetString("WorkTimeList.Items59"), resources.GetString("WorkTimeList.Items60"), resources.GetString("WorkTimeList.Items61"), resources.GetString("WorkTimeList.Items62"), resources.GetString("WorkTimeList.Items63"), resources.GetString("WorkTimeList.Items64"), resources.GetString("WorkTimeList.Items65"), resources.GetString("WorkTimeList.Items66"), resources.GetString("WorkTimeList.Items67"), resources.GetString("WorkTimeList.Items68"), resources.GetString("WorkTimeList.Items69"), resources.GetString("WorkTimeList.Items70"), resources.GetString("WorkTimeList.Items71"), resources.GetString("WorkTimeList.Items72"), resources.GetString("WorkTimeList.Items73"), resources.GetString("WorkTimeList.Items74"), resources.GetString("WorkTimeList.Items75"), resources.GetString("WorkTimeList.Items76"), resources.GetString("WorkTimeList.Items77"), resources.GetString("WorkTimeList.Items78"), resources.GetString("WorkTimeList.Items79"), resources.GetString("WorkTimeList.Items80"), resources.GetString("WorkTimeList.Items81"), resources.GetString("WorkTimeList.Items82"), resources.GetString("WorkTimeList.Items83"), resources.GetString("WorkTimeList.Items84"), resources.GetString("WorkTimeList.Items85"), resources.GetString("WorkTimeList.Items86"), resources.GetString("WorkTimeList.Items87"), resources.GetString("WorkTimeList.Items88"), resources.GetString("WorkTimeList.Items89"), resources.GetString("WorkTimeList.Items90"), resources.GetString("WorkTimeList.Items91"), resources.GetString("WorkTimeList.Items92"), resources.GetString("WorkTimeList.Items93"), resources.GetString("WorkTimeList.Items94"), resources.GetString("WorkTimeList.Items95"), resources.GetString("WorkTimeList.Items96")})
        Me.WorkTimeList.Name = "WorkTimeList"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.White
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.SaveButton, "SaveButton")
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'SealView
        '
        Me.SealView.AllowUserToAddRows = False
        Me.SealView.AllowUserToOrderColumns = True
        Me.SealView.AllowUserToResizeColumns = False
        Me.SealView.AllowUserToResizeRows = False
        Me.SealView.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 7.8!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SealView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.SealView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SealView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dep_manager, Me.off_manager, Me.pro_manager})
        resources.ApplyResources(Me.SealView, "SealView")
        Me.SealView.Name = "SealView"
        Me.SealView.ReadOnly = True
        Me.SealView.RowHeadersVisible = False
        Me.SealView.RowTemplate.Height = 21
        '
        'dep_manager
        '
        resources.ApplyResources(Me.dep_manager, "dep_manager")
        Me.dep_manager.Image = Global.Report.My.Resources.Resources.tyou
        Me.dep_manager.Name = "dep_manager"
        Me.dep_manager.ReadOnly = True
        Me.dep_manager.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dep_manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'off_manager
        '
        resources.ApplyResources(Me.off_manager, "off_manager")
        Me.off_manager.Image = Global.Report.My.Resources.Resources.tyou
        Me.off_manager.Name = "off_manager"
        Me.off_manager.ReadOnly = True
        Me.off_manager.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.off_manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'pro_manager
        '
        resources.ApplyResources(Me.pro_manager, "pro_manager")
        Me.pro_manager.Image = Global.Report.My.Resources.Resources.tyou
        Me.pro_manager.Name = "pro_manager"
        Me.pro_manager.ReadOnly = True
        Me.pro_manager.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pro_manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Year
        '
        Me.Year.FormattingEnabled = True
        Me.Year.Items.AddRange(New Object() {resources.GetString("Year.Items"), resources.GetString("Year.Items1"), resources.GetString("Year.Items2"), resources.GetString("Year.Items3"), resources.GetString("Year.Items4"), resources.GetString("Year.Items5"), resources.GetString("Year.Items6"), resources.GetString("Year.Items7"), resources.GetString("Year.Items8"), resources.GetString("Year.Items9"), resources.GetString("Year.Items10")})
        resources.ApplyResources(Me.Year, "Year")
        Me.Year.Name = "Year"
        '
        'Mon
        '
        Me.Mon.FormattingEnabled = True
        Me.Mon.Items.AddRange(New Object() {resources.GetString("Mon.Items"), resources.GetString("Mon.Items1"), resources.GetString("Mon.Items2"), resources.GetString("Mon.Items3"), resources.GetString("Mon.Items4"), resources.GetString("Mon.Items5"), resources.GetString("Mon.Items6"), resources.GetString("Mon.Items7"), resources.GetString("Mon.Items8"), resources.GetString("Mon.Items9"), resources.GetString("Mon.Items10"), resources.GetString("Mon.Items11")})
        resources.ApplyResources(Me.Mon, "Mon")
        Me.Mon.Name = "Mon"
        '
        'DataGridViewImageColumn1
        '
        resources.ApplyResources(Me.DataGridViewImageColumn1, "DataGridViewImageColumn1")
        Me.DataGridViewImageColumn1.Image = Global.Report.My.Resources.Resources.tyou
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewImageColumn2
        '
        resources.ApplyResources(Me.DataGridViewImageColumn2, "DataGridViewImageColumn2")
        Me.DataGridViewImageColumn2.Image = Global.Report.My.Resources.Resources.tyou
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewImageColumn3
        '
        resources.ApplyResources(Me.DataGridViewImageColumn3, "DataGridViewImageColumn3")
        Me.DataGridViewImageColumn3.Image = Global.Report.My.Resources.Resources.tyou
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        resources.ApplyResources(Me.ReportView, "ReportView")
        Me.ReportView.Name = "ReportView"
        Me.ReportView.RowHeadersVisible = False
        Me.ReportView.RowTemplate.Height = 20
        '
        'day_week
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        DataGridViewCellStyle12.NullValue = Nothing
        Me.day_week.DefaultCellStyle = DataGridViewCellStyle12
        resources.ApplyResources(Me.day_week, "day_week")
        Me.day_week.Name = "day_week"
        Me.day_week.ReadOnly = True
        '
        'week
        '
        resources.ApplyResources(Me.week, "week")
        Me.week.Name = "week"
        Me.week.ReadOnly = True
        '
        'Start_Time
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Time.DefaultCellStyle = DataGridViewCellStyle13
        Me.Start_Time.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        resources.ApplyResources(Me.Start_Time, "Start_Time")
        Me.Start_Time.Items.AddRange(New Object() {"", "0:00", "0:15", "0:30", "0:45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00", "19:15", "19:30", "19:45", "20:00", "20:15", "20:30", "20:45", "21:00", "21:15", "21:30", "21:45", "22:00", "22:15", "22:30", "22:45", "23:00", "23:15", "23:30", "23:45"})
        Me.Start_Time.Name = "Start_Time"
        Me.Start_Time.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Start_Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'End_Time
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Time.DefaultCellStyle = DataGridViewCellStyle14
        Me.End_Time.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        resources.ApplyResources(Me.End_Time, "End_Time")
        Me.End_Time.Items.AddRange(New Object() {"", "0:00", "0:15", "0:30", "0:45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00", "19:15", "19:30", "19:45", "20:00", "20:15", "20:30", "20:45", "21:00", "21:15", "21:30", "21:45", "22:00", "22:15", "22:30", "22:45", "23:00", "23:15", "23:30", "23:45", "24:00", "24:15", "24:30", "24:45", "25:00", "25:15", "25:30", "25:45", "26:00", "26:15", "26:30", "26:45", "27:00", "27:15", "27:30", "27:45", "28:00", "28:15", "28:30", "28:45", "29:00", "29:15", "29:30", "29:45", "30:00", "30:15", "30:30", "30:45", "31:00", "31:15", "31:30", "31:45", "32:00", "32:15", "32:30", "32:45", "33:00"})
        Me.End_Time.Name = "End_Time"
        Me.End_Time.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.End_Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'time
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.DefaultCellStyle = DataGridViewCellStyle15
        resources.ApplyResources(Me.time, "time")
        Me.time.Name = "time"
        Me.time.ReadOnly = True
        '
        'content
        '
        DataGridViewCellStyle16.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.content.DefaultCellStyle = DataGridViewCellStyle16
        resources.ApplyResources(Me.content, "content")
        Me.content.Name = "content"
        '
        'ReportInput
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.ReportView)
        Me.Controls.Add(Me.Mon)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.SealView)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.WorkTimeList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WorkTittle)
        Me.Controls.Add(Me.WorkText)
        Me.Controls.Add(Me.WorkTable)
        Me.Controls.Add(Me.MessageView)
        Me.Controls.Add(Me.Tittle)
        Me.Name = "ReportInput"
        CType(Me.MessageView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SealView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tittle As Label
    Friend WithEvents MessageView As DataGridView
    Friend WithEvents WorkTable As Label
    Friend WithEvents WorkText As TextBox
    Friend WithEvents WorkTittle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WorkTimeList As ComboBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents SealView As DataGridView
    Friend WithEvents Message As DataGridViewTextBoxColumn
    Friend WithEvents MessageValue As DataGridViewTextBoxColumn
    Friend WithEvents Mon As ComboBox
    Friend WithEvents Year As ComboBox
    Friend WithEvents dep_manager As DataGridViewImageColumn
    Friend WithEvents off_manager As DataGridViewImageColumn
    Friend WithEvents pro_manager As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents ReportView As DataGridView
    Friend WithEvents day_week As DataGridViewTextBoxColumn
    Friend WithEvents week As DataGridViewTextBoxColumn
    Friend WithEvents Start_Time As DataGridViewComboBoxColumn
    Friend WithEvents End_Time As DataGridViewComboBoxColumn
    Friend WithEvents time As DataGridViewTextBoxColumn
    Friend WithEvents content As DataGridViewTextBoxColumn
End Class
