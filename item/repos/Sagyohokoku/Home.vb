Imports Excel = Microsoft.Office.Interop.Excel
Imports IO = System.IO
''' <summary>
''' 作業報告システムのホームページ
''' </summary>
Public Class Home

    ''' <summary>
    ''' ログインしたユーザー
    ''' </summary>
    Private employee As Employees
    ''' <summary>
    ''' デフォルト印鑑イメージ
    ''' </summary>
    Private seal As Image = New Bitmap(80, 80)
    ''' <summary>
    ''' 修正可能フラグ
    ''' </summary>
    Private enableFlag = True
    'Private r_id As Integer

    Private ReportMap As New Hashtable

    ''' <summary>
    ''' 引数あるコンストラクタ
    ''' </summary>
    ''' <param name="employee"></param>
    Public Sub New(employee As Employees)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.employee = employee


    End Sub

    ''' <summary>
    ''' 作業報告ホームページのイニシャライズ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '氏名を取得する
        With NameText
            .Text = employee.e_name
        End With

        'メニューの権限判断
        If employee.p_id = 6 Then
            Confirm.Hide()
            Panel1.Hide()
        End If
        Select Case employee.d_id
            Case 3, 6, 9
                Manage.Hide()
                Panel2.Hide()
        End Select

        '作業報告書の初期化
        ReportsBoxInit(Product, e)

        '印鑑の初期化
        Seal_Init()

        '一時的な非表示
        Label5.Hide()
        Commute.Hide()
    End Sub

    ''' <summary>
    ''' 印鑑の初期化
    ''' </summary>
    Private Sub Seal_Init()
        Seal_Datagridview.Rows.Clear()
        '印鑑欄のイニシャライズ
        Seal_Datagridview.Rows.Add(1)
        Seal_Datagridview.CurrentRow.Height = 80
        Dim column1 = CType(Seal_Datagridview.Columns(0), DataGridViewImageColumn)
        Dim column2 = CType(Seal_Datagridview.Columns(1), DataGridViewImageColumn)
        Dim column3 = CType(Seal_Datagridview.Columns(2), DataGridViewImageColumn)
        column1.Image = Me.seal
        column2.Image = Me.seal
        column3.Image = Me.seal
    End Sub

    ''' <summary>
    ''' 作業報告書の初期化
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReportsBoxInit(sender As Object, e As EventArgs) _
        Handles Product.Click, Confirm.Click, Manage.Click
        Select Case CType(sender, Button).Name
            Case Product.Name
                enableFlag = True
                RepBox.Controls.Clear()
                ReportDetailBox.Tag = Nothing
                Reports_Detail.ReadOnly = False
                Submit_Button.Text = "保　存"
                '作業報告作成の表示
                ShowProductCtl()
                Dim count = ProRepBox_Init()
                If count <> 0 Then
                    '初期化した時、一個目作業報告を表示
                    Submit_Button.Enabled = True
                    Dim firstBox = RepBox.Controls(RepBox.Controls.Count - 1)
                    Update_Click(firstBox, e)
                Else
                    '初期化した時、作業報告はない場合は、作業報告を表示しない
                    Submit_Button.Enabled = False
                    Seal_Init()
                    Company_Info.Rows.Clear()
                    Reports_Detail.Rows.Clear()
                    Report_Date.Text = Nothing
                End If
            Case Confirm.Name
                enableFlag = False
                RepBox.Controls.Clear()
                ReportDetailBox.Tag = Nothing
                Reports_Detail.ReadOnly = True
                Submit_Button.Text = "承　認"
                '作業報告承認の表示
                ShowConfirmCtl()
                Dim count = ConRepBox_Init()
                If count <> 0 Then
                    '初期化した時、一個目作業報告を表示
                    Excel_Button.Enabled = True
                    Submit_Button.Enabled = True
                    Dim firstBox = RepBox.Controls(RepBox.Controls.Count - 1)
                    Update_Click(firstBox, e)
                Else
                    '初期化した時、作業報告はない場合は、作業報告を表示しない
                    Excel_Button.Enabled = False
                    Submit_Button.Enabled = False
                    Seal_Init()
                    Company_Info.Rows.Clear()
                    Reports_Detail.Rows.Clear()
                    Report_Date.Text = Nothing
                End If
            Case Manage.Name
                RepBox.Controls.Clear()
                ReportDetailBox.Tag = Nothing
                ShowManageCtl()
                ManageBox_Init()
                Dim firstBox = RepBox.Controls(RepBox.Controls.Count - 1)
                Update_Click(firstBox, e)
        End Select

    End Sub

    ''' <summary>
    ''' 作業報告作成の表示
    ''' </summary>
    Private Sub ShowProductCtl()
        TableLayoutPanel1.Show()
        RestTime_Panel.Hide()
        Calendar_Panel.Hide()
        ProTittleBox.BringToFront()
        ConTittleBox.SendToBack()
        ManageTittle.SendToBack()
        Insert.Show()
    End Sub


    ''' <summary>
    ''' 作業報告承認の表示
    ''' </summary>
    Private Sub ShowConfirmCtl()
        TableLayoutPanel1.Show()
        RestTime_Panel.Hide()
        Calendar_Panel.Hide()
        ConTittleBox.BringToFront()
        ProTittleBox.SendToBack()
        ManageTittle.SendToBack()
        Insert.Hide()
    End Sub

    ''' <summary>
    ''' マスタメンテナンスの表示
    ''' </summary>
    Private Sub ShowManageCtl()
        RestTime_Panel.Show()
        Calendar_Panel.Show()
        TableLayoutPanel1.Hide()
        ManageTittle.BringToFront()
        ConTittleBox.SendToBack()
        ProTittleBox.SendToBack()
        Insert.Hide()
    End Sub

    ''' <summary>
    ''' フォームの最小化
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MinButton_Click(sender As Object, e As EventArgs) Handles MinButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ''' <summary>
    ''' フォームの最大化・元に戻す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MaxButton_Click(sender As Object, e As EventArgs) Handles MaxButton.Click
        If Me.WindowState <> FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    ''' <summary>
    ''' フォームを閉じる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        Login.Close()
    End Sub

#Region "フォームの移動について"

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Boolean
    Public Declare Function ReleaseCapture Lib "user32" Alias "ReleaseCapture" () As Boolean
    Public Const WM_SYSCOMMAND = &H112
    Public Const SC_MOVE = &HF010&
    Public Const HTCAPTION = 2
    Private Sub Drag_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles TittleBox.MouseDown, CtlBox.MouseDown, FucBox.MouseDown
        ReleaseCapture()

        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)

    End Sub
#End Region

    ''' <summary>
    ''' 作業報告の追加
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Dim sql = "select max(r_date) r_date from reports where e_id = ?"
        Dim table = Tools.GetData(Login.conn, sql, employee.e_id)

        '社員の入社時間
        Dim createTime = CDate(employee.create_time)

        '最近の作業報告作成の時間
        Dim max_date = table.Rows(0).Field(Of String)("r_date")

        '挿入操作についてのフラグ、trueの場合は操作する、逆は操作しない
        Dim exeFlag = True

        '作業報告存在の場合は、次の時間を取得する
        If max_date IsNot Nothing Then
            createTime = CDate(table.Rows(0).Field(Of String)("r_date")).AddMonths(1)

            '次の時間は大なり今の時間の場合、falseにフラゲを変換する
            If createTime > Date.Now Then
                exeFlag = False
            End If
        End If

        'フラグはtrueの場合、以下のコードを実行する、逆は実行しない
        If exeFlag Then
            '時間の年月日
            Dim r_date = createTime.ToShortDateString.Substring(0, 7)
            sql = "insert into reports (r_id,e_id,r_date,u_id) values (next value for reports_sequence,?,?,?)"
            Console.WriteLine("Reports表の中の影響される行目:" & Tools.SetData(Login.conn, sql, employee.e_id, r_date, employee.u_id))
            sql = "select max(r_id) r_id from reports where e_id = ?"
            Dim r_id = Tools.GetData(Login.conn, sql, employee.e_id).Rows(0).Field(Of Integer)("r_id")

            'データベースに複数のデータを入力する
            Dim days = Date.DaysInMonth(createTime.Year, createTime.Month)
            Dim value = ""
            For i = 0 To days - 1
                value &= "(" & r_id & ")"
                If i <> days - 1 Then
                    value &= ","
                End If
            Next
            sql = "insert into reports_detail (r_id) values " & value
            Console.WriteLine("ReportsDetail表の中の影響される行目：" & Tools.SetData(Login.conn, sql))
            ReportsBoxInit(Product, e)
        Else
            MessageBox.Show("来月の作業報告作成できない!")
        End If
    End Sub

    ''' <summary>
    ''' 作業報告の詳細内容の表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Update_Click(sender As Object, e As EventArgs)
        Dim senderType = sender.GetType.Name

        '今のコントロール
        Dim ctl = CType(sender, Control)
        If senderType = "Label" Then
            ctl = CType(sender, Control).Parent
        End If

        '作業報告のr_idはない場合は、以下のコード実行しない
        If ReportDetailBox.Tag IsNot Nothing Then

            CType(ReportMap(ReportDetailBox.Tag), Control).BackColor = Color.FromArgb(189, 190, 191)
        End If
        ctl.BackColor = Color.WhiteSmoke
        ReportDetailBox.Tag = ctl.Tag
        ReportTittle.Text = ctl.Controls(0).Text
        Select Case ctl.Controls(0).Text
            Case "休憩時間の設定"
                RestTime_Panel.BringToFront()
                Calendar_Panel.SendToBack()
            Case "年間休日の設定"
                Calendar_Panel.BringToFront()
                RestTime_Panel.SendToBack()
                Dim gh = New GetHoliday
                '年間休日を設定します。
                If gh.GetHolidaysCount(Now).Rows.Count <= 0 Then
                    gh.SetAllHolidaysByYear(Now)
                End If
            Case Else
                ShowReport(ctl)
        End Select
    End Sub

    ''' <summary>
    ''' 作業報告のリストのカラー変換
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Color_MouseHover(sender As Object, e As EventArgs)
        Dim ctl = CType(sender, Control)
        If sender.GetType.Name = "Label" Then
            ctl = ctl.Parent
        End If
        If ctl IsNot ReportMap(ReportDetailBox.Tag) Then
            ctl.BackColor = Color.WhiteSmoke
        End If
    End Sub

    ''' <summary>
    ''' 作業報告のリストのカラーを戻る
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Color_MouseLeave(sender As Object, e As EventArgs)
        Dim ctl = CType(sender, Control)
        If sender.GetType.Name = "Label" Then
            ctl = ctl.Parent
        End If
        If ctl IsNot ReportMap(ReportDetailBox.Tag) Then
            ctl.BackColor = Color.FromArgb(189, 190, 191)
        End If
    End Sub

    ''' <summary>
    ''' 作業報告作成リストの初期化
    ''' </summary>
    ''' <returns>リストの行数</returns>
    Private Function ProRepBox_Init() As Integer
        '作業報告を全て削除する
        RepBox.Controls.Clear()
        ReportMap.Clear()
        '作業報告の取得
        Dim Sql = "select r_id,r_date,sales_flag,com_flag from reports where e_id = ? order by r_date asc"
        Dim reports = Tools.GetData(Login.conn, Sql, employee.e_id)
        For i = 0 To reports.Rows.Count - 1
            Dim row = reports.Rows(i)
            '時間の取得
            Dim r_date = CDate(row.Field(Of String)("r_date")).ToShortDateString
            '表示用のラベルを作成する
            Dim report = New Label With {
                .Text = r_date.Substring(0, 7),
                .Font = New Font("ＭＳ ゴシック", 9),
                .TextAlign = ContentAlignment.MiddleRight,
                .Location = New Point(0, 5),
                .Tag = row.Field(Of Integer)("r_id")
            }
            'ラベルの格納のパネルを作成する
            Dim panel As New Panel With {
                .Dock = DockStyle.Top,
                .Height = 30,
                .Tag = row.Field(Of Integer)("r_id")
            }
            panel.Controls.Add(report)
            Dim sales_flag = reports.Rows(i).Field(Of Boolean)("sales_flag")
            Dim com_flag = reports.Rows(i).Field(Of Boolean)("com_flag")
            '承認済の判断
            If sales_flag OrElse com_flag Then
                Dim flag = New Label With {
                    .Text = "済",
                    .Font = New Font("ＭＳ ゴシック", 7),
                    .Location = New Point(40, 5),
                    .TextAlign = ContentAlignment.MiddleRight,
                    .Tag = row.Field(Of Integer)("r_id")
                }
                AddHandler flag.Click, AddressOf Update_Click
                AddHandler flag.MouseHover, AddressOf Color_MouseHover
                AddHandler flag.MouseLeave, AddressOf Color_MouseLeave
                panel.Controls.Add(flag)
            End If
            AddHandler report.Click, AddressOf Update_Click
            AddHandler report.MouseHover, AddressOf Color_MouseHover
            AddHandler report.MouseLeave, AddressOf Color_MouseLeave
            AddHandler panel.Click, AddressOf Update_Click
            AddHandler panel.MouseHover, AddressOf Color_MouseHover
            AddHandler panel.MouseLeave, AddressOf Color_MouseLeave
            RepBox.Controls.Add(panel)
            ReportMap.Add(row.Field(Of Integer)("r_id"), panel)
        Next
        Return reports.Rows.Count
    End Function

    ''' <summary>
    ''' 作業報告承認リストの初期化
    ''' </summary>
    ''' <returns>リストの行数</returns>
    Private Function ConRepBox_Init() As Integer
        '作業報告を全て削除する
        RepBox.Controls.Clear()
        ReportMap.Clear()
        '作業報告の取得
        Dim reports As DataTable
        'ログインしたユーザーの所属部署の判断
        Select Case employee.d_id
            Case 1, 2, 4, 5, 7, 8
                Dim sql = "select r_id,r_date,sales_flag,com_flag,e.e_name from reports r left join employees e on r.e_id = e.e_id order by r_date asc"
                reports = Tools.GetData(Login.conn, sql)
            Case Else
                Dim sql = "select r_id,r_date,sales_flag,com_flag,e.e_name from reports r left join employees e on r.e_id = e.e_id where e.m_id = ? order by r_date asc"
                reports = Tools.GetData(Login.conn, sql, employee.e_id)
        End Select
        For i = 0 To reports.Rows.Count - 1
            Dim row = reports.Rows(i)
            Dim r_id = row.Field(Of Integer)("r_id")
            Dim e_name = row.Field(Of String)("e_name")
            Dim r_date = CDate(row.Field(Of String)("r_date")).ToShortDateString
            Dim msg = e_name & r_date.Substring(0, 7)
            '表示用のラベルを作成する
            Dim report = New Label With {
                .Text = msg,
                .Font = New Font("ＭＳ ゴシック", 8),
                .Location = New Point(0, 5),
                .TextAlign = ContentAlignment.MiddleRight,
                .Tag = r_id
            }
            'ラベルの格納のパネルを作成する
            Dim panel As New Panel With {
                .Dock = DockStyle.Top,
                .Height = 30,
                .Tag = r_id
            }
            panel.Controls.Add(report)
            Dim sales_flag = reports.Rows(i).Field(Of Boolean)("sales_flag")
            Dim com_flag = reports.Rows(i).Field(Of Boolean)("com_flag")
            '承認済の判断
            If sales_flag OrElse com_flag Then
                Dim flag = New Label With {
                    .Text = "済",
                    .Font = New Font("ＭＳ ゴシック", 7),
                    .TextAlign = ContentAlignment.MiddleRight,
                    .Location = New Point(40, 5),
                    .Tag = row.Field(Of Integer)("r_id")
                }
                AddHandler flag.Click, AddressOf Update_Click
                AddHandler flag.MouseHover, AddressOf Color_MouseHover
                AddHandler flag.MouseLeave, AddressOf Color_MouseLeave
                panel.Controls.Add(flag)
            End If
            AddHandler report.Click, AddressOf Update_Click
            AddHandler report.MouseHover, AddressOf Color_MouseHover
            AddHandler report.MouseLeave, AddressOf Color_MouseLeave
            AddHandler panel.Click, AddressOf Update_Click
            AddHandler panel.MouseHover, AddressOf Color_MouseHover
            AddHandler panel.MouseLeave, AddressOf Color_MouseLeave
            RepBox.Controls.Add(panel)
            ReportMap.Add(row.Field(Of Integer)("r_id"), panel)
        Next
        Return reports.Rows.Count
    End Function

    ''' <summary>
    ''' 作業報告の表示
    ''' </summary>
    ''' <param name="ctl">選択された作業報告</param>
    Private Sub ShowReport(ctl As Control)
        '印鑑の初期化
        Seal_Init()

        'r_idの取得
        Dim r_id = ctl.Tag
        Company_Info.Rows.Clear()
        'インフォメーションを取り出す
        Dim sql = "select c_name,d_name,e_name,u_name from reports r, employees e, users u, departments d, companys c where r.e_id = e.e_id and r.u_id = u.u_id and e.d_id = d.d_id and d.c_id = c.c_id and r.r_id = ?"
        Dim table = Tools.GetData(Login.conn, sql, r_id)

        'インフォメーションの表示
        Company_Info.Rows.Add("所属会社", table.Rows(0).Field(Of String)("c_name"))
        Company_Info.Rows.Add("所属部署", table.Rows(0).Field(Of String)("d_name"))
        Company_Info.Rows.Add("氏名", table.Rows(0).Field(Of String)("e_name"))
        Company_Info.Rows.Add("ユーザ名/プロジェクト名", table.Rows(0).Field(Of String)("u_name"))

        '承認されるかどうか判断
        Reports_Detail.Rows.Clear()
        sql = "select r_id,r_date,total_worktime,overtime,important_content,sales_flag,com_flag from reports where r_id = ?"
        table = Tools.GetData(Login.conn, sql, r_id)
        '作成機能
        If enableFlag Then
            '承認した場合は修正不可、ない場合は修正可能
            If ctl.Controls.Count = 2 Then
                Reports_Detail.ReadOnly = True
                Commute.Enabled = False
                Submit_Button.Enabled = False
            Else
                Reports_Detail.ReadOnly = False
                Commute.Enabled = True
                Submit_Button.Enabled = True
            End If
        Else
            '承認した場合はキャンセルに変換する、ない場合は承認に変換する
            If ctl.Controls.Count = 2 Then
                Submit_Button.Text = "キャンセル"
            Else
                Submit_Button.Text = "承　認"
            End If
        End If

        '印鑑を表示するかどうか判断
        Dim sales_flag = table.Rows(0).Field(Of Boolean)("sales_flag")
        Dim com_flag = table.Rows(0).Field(Of Boolean)("com_flag")
        If sales_flag Then
            Dim img = CType(Seal_Datagridview.Columns(1), DataGridViewImageColumn)
            img.Image = New Bitmap("..\..\Resources\" & employee.seal_local)
        ElseIf com_flag Then
            Dim img = CType(Seal_Datagridview.Columns(0), DataGridViewImageColumn)
            img.Image = New Bitmap("..\..\Resources\" & employee.seal_local)
        Else
            Dim img = CType(Seal_Datagridview.Columns(0), DataGridViewImageColumn)
            img.Image = seal
            img = CType(Seal_Datagridview.Columns(1), DataGridViewImageColumn)
            img.Image = seal
        End If

        '年月と重要なメッセージの表示
        Report_Date.Text = table.Rows(0).Field(Of String)("r_date")
        Report_Content.Text = table.Rows(0).Field(Of String)("important_content")

        '作業報告の詳細内容の取得
        Dim firstDay = CDate(table.Rows(0).Field(Of String)("r_date"))
        Dim days = Date.DaysInMonth(firstDay.Year, firstDay.Month)
        '毎日の勤務開始時間、終了時間、勤務時間を取り出す
        sql = "select start_time,end_time,work_time,work_content from reports_detail where r_id = ?"
        Dim table1 = Tools.GetData(Login.conn, sql, r_id)
        '祝日を取り出す
        sql = "select h_dates from holidays"
        Dim table2 = Tools.GetData(Login.conn, sql)
        For i = 0 To days - 1
            Dim week = Tools.GetWeekOfDay(firstDay.AddDays(i))
            Reports_Detail.Rows.Add((i + 1), week)
            '土日祝日の判断
            Select Case week
                Case "(土)"
                    Reports_Detail.Rows(i).Cells(0).Style.ForeColor = Color.Blue
                    Reports_Detail.Rows(i).Cells(1).Style.ForeColor = Color.Blue
                Case "(日)"
                    Reports_Detail.Rows(i).Cells(0).Style.ForeColor = Color.Red
                    Reports_Detail.Rows(i).Cells(1).Style.ForeColor = Color.Red
            End Select
            For j = 0 To table2.Rows.Count - 1
                Dim h_dates = table2.Rows(j).Field(Of String)("h_dates")
                If h_dates = firstDay.AddDays(i).ToShortDateString Then
                    Reports_Detail.Rows(i).Cells(0).Style.ForeColor = Color.Red
                    Reports_Detail.Rows(i).Cells(1).Style.ForeColor = Color.Red
                End If
            Next

            '勤務内容の表示
            Dim row = table1.Rows(i)
            Dim start_time = row.Field(Of String)("start_time")
            Dim end_time = row.Field(Of String)("end_time")
            Dim work_time = row.Field(Of String)("work_time")
            Dim work_content = row.Field(Of String)("work_content")
            If start_time <> "" AndAlso end_time <> "" Then
                Reports_Detail.Rows(i).SetValues((i + 1), week, CDate(start_time).ToShortTimeString, CDate(end_time).ToShortTimeString,
                                                 work_time, work_content)
            Else
                Reports_Detail.Rows(i).SetValues((i + 1), week, start_time, end_time,
                                                 work_time, work_content)
            End If
        Next i

        '勤務表下側の初期化
        Reports_Detail.Rows.Add(32 - days)
        Reports_Detail.Rows.Add("合計", Nothing, Nothing, Nothing, table.Rows(0).Field(Of String)("total_worktime"), Nothing)
    End Sub

    ''' <summary>
    ''' 入力内容変換
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Time_TextChange(sender As Object, e As EventArgs) Handles Reports_Detail.CellEndEdit
        Dim curRow = Reports_Detail.CurrentRow
        Try
            Dim value As String = Reports_Detail.CurrentCell.Value
            If value Is Nothing Then
                Throw New Exception
            End If
            '「000」は「0:00」に変換する
            If value.Length = 3 Then
                Dim hour As String = CInt(value.Substring(0, 1))
                Dim min As String = CInt(value.Substring(1, 2))
                min = Min_Change(min)
                '60分の場合、アワーは一ポイントにアップする
                If min = 60 Then
                    hour += min / 60
                    min = min Mod 60
                End If
                If min = "0" Then
                    min = "00"
                End If

                '時間を表す
                Reports_Detail.CurrentCell.Value = hour & ":" & min
                '「0000」は「00:00」に変換する
            ElseIf value.Length = 4 Then
                Dim hour As String = CInt(value.Substring(0, 2))
                Dim min As String = CInt(value.Substring(2, 2))
                min = Min_Change(min)

                '60分の場合、アワーは一ポイントにアップする
                If min = 60 Then
                    hour += min / 60
                    min = min Mod 60
                End If
                If min = "0" Then
                    min = "00"
                End If

                'アワーは24時に超える
                If hour > 24 Or (hour = 24 AndAlso min > 0) Then
                    Throw New Exception
                End If

                '時間を表す
                Reports_Detail.CurrentCell.Value = hour & ":" & min
            Else
                Throw New Exception
            End If
            If curRow.Cells(2).Value <> "" AndAlso curRow.Cells(3).Value <> "" Then
                '勤務時間の計算
                WorkTime_Change()
            End If
            '総時間の計算
            GetSumTime()
        Catch ex As Exception
            '例外の場合
            Reports_Detail.CurrentCell.Value = Nothing
            MessageBox.Show("「000」か「0000」に参照して入力してください")
        End Try

    End Sub

    ''' <summary>
    ''' 毎日の勤務時間の計算
    ''' </summary>
    Private Sub WorkTime_Change()
        Dim curRow = Reports_Detail.CurrentRow
        Dim startTime As Date = CDate(curRow.Cells(2).Value)
        Dim endTime As Date = CDate(curRow.Cells(3).Value)
        If startTime > endTime Then
            endTime = endTime.AddDays(1)
        End If
        Dim sql = "select lunch_starttime,lunch_endtime,dinner_starttime,dinner_endtime from users where u_id = ?"
        Dim timeTab = Tools.GetData(Login.conn, sql, employee.u_id)
        Dim lunch_starttime = CDate(timeTab.Rows(0).Field(Of String)("lunch_starttime"))
        Dim lunch_endtime = CDate(timeTab.Rows(0).Field(Of String)("lunch_endtime"))
        Dim dinner_starttime = CDate(timeTab.Rows(0).Field(Of String)("dinner_starttime"))
        Dim dinner_endtime = CDate(timeTab.Rows(0).Field(Of String)("dinner_endtime"))
        Dim time As TimeSpan = endTime - startTime
        If startTime < lunch_starttime AndAlso endTime > lunch_endtime Then
            time -= lunch_endtime - lunch_starttime
        End If
        If startTime < dinner_starttime AndAlso endTime > dinner_endtime Then
            time -= dinner_endtime - dinner_starttime
        End If

        Dim workTime As String = time.ToString.Substring(0, 5)
        If workTime.Substring(0, 1) = "0" Then
            workTime = workTime.Substring(1, 4)
        Else

        End If
        curRow.Cells(4).Value = workTime
    End Sub

    ''' <summary>
    ''' 総時間を取り出す
    ''' </summary>
    Private Sub GetSumTime()
        Dim sumHour = 0
        Dim sumMin = 0
        For i = 0 To 30
            Dim time = Split(Reports_Detail.Rows(i).Cells(4).Value, ":")
            If time.Length = 2 Then
                sumHour += CType(time(0), Integer)
                sumMin += CType(time(1), Integer)
            End If
        Next i
        sumHour += Int(sumMin / 60)
        sumMin = sumMin Mod 60
        Dim min = sumMin.ToString()
        If sumMin = 0 Then
            min = "00"
        End If
        Dim sumTime = sumHour & ":" & min
        '総時間を表す
        Reports_Detail.Rows(32).Cells(4).Value = sumTime
    End Sub

    ''' <summary>
    ''' 分の自動的な変換
    ''' </summary>
    ''' <param name="min">分</param>
    ''' <returns></returns>
    Private Function Min_Change(min As Integer) As String
        If min > 52 Then
            Return "60"
        ElseIf min <= 52 AndAlso min > 37 Then
            Return "45"
        ElseIf min <= 37 AndAlso min > 22 Then
            Return "30"
        ElseIf min <= 22 AndAlso min > 7 Then
            Return "15"
        Else
            Return "00"
        End If
    End Function

    '''<summary>
    ''' Reports表に対して更新する
    ''' </summary>
    ''' <param name="r_id"></param>
    Private Function UpdateReports(r_id As Integer) As Integer
        Dim sql = "update reports set total_worktime = ?,overtime = ?,important_content = ?,create_time = ? where r_id = ?"
        Dim total_worktime = Reports_Detail.Rows(32).Cells(4).Value
        Dim important_content = Report_Content.Text
        Dim now = Date.Now()
        Return Tools.SetData(Login.conn, sql, total_worktime, total_worktime, important_content, now, r_id)
    End Function

    ''' <summary>
    ''' ReportsDetail表に対して更新する
    ''' </summary>
    ''' <param name="r_id"></param>
    Private Function UpdateReportsDetail(r_id As String) As Integer
        'Dim days = Getdays(year, mon)
        Dim sql = "select r_d_id from reports_detail where r_id = ?"
        Dim r_d_id = Tools.GetData(Login.conn, sql, r_id)
        sql = "update reports_detail set start_time = ?,end_time = ?,work_time = ?,work_content = ? where r_d_id = ?"
        Dim sum = 0
        For i = 0 To r_d_id.Rows.Count - 1
            Dim startTime = Reports_Detail.Rows(i).Cells(2).Value
            Dim endTime = Reports_Detail.Rows(i).Cells(3).Value
            Dim workTime = Reports_Detail.Rows(i).Cells(4).Value
            Dim workContent = Reports_Detail.Rows(i).Cells(5).Value
            Dim rdId = r_d_id.Rows(i).Field(Of Integer)("r_d_id")
            sum += Tools.SetData(Login.conn, sql, startTime, endTime, workTime, workContent, rdId)
        Next
        Console.WriteLine("実行行目：" & sum)
        Return sum
    End Function

    ''' <summary>
    ''' メッセージを登録する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click, Excel_Button.Click
        Dim r_id = TableLayoutPanel1.Tag
        Select Case CType(sender, Control).Text
            Case "保　存"
                Dim num = UpdateReports(r_id)
                Dim num1 = UpdateReportsDetail(r_id)
                MessageBox.Show("Reports表の中の影響される行目：" & num & vbLf &
                            "ReportsDetail表の中の影響される行目：" & num1)
            Case "承　認"
                Select Case employee.d_id
                    Case 1, 2, 4, 5, 7, 8
                        Dim sql = "update reports set com_flag = 1 where r_id = ?"
                        Console.WriteLine(Tools.SetData(Login.conn, sql, r_id))
                    Case 3, 6, 9
                        Dim sql = "update reports set sales_flag = 1 where r_id = ?"
                        Console.WriteLine(Tools.SetData(Login.conn, sql, r_id))
                End Select
                ConRepBox_Init()
                Update_Click(ReportMap(TableLayoutPanel1.Tag), e)
            Case "キャンセル"
                Dim sql = "update reports set com_flag = 0,sales_flag = 0 where r_id = ?"
                Console.WriteLine(Tools.SetData(Login.conn, sql, r_id))
                ConRepBox_Init()

                Update_Click(ReportMap(TableLayoutPanel1.Tag), e)


        End Select
    End Sub

#Region "エクセルの出力"
    Private appXL As Excel.Application
    Private wbXl As Excel.Workbook
    Private shXL As Excel.Worksheet

    ''' <summary>
    ''' EXCEL作成ボタンを押すと作成報告書をexcelに出力します
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Excel_Button_Click(sender As Object, e As EventArgs) Handles Excel_Button.Click
        Dim r_date = Report_Date.Text
        appXL = New Excel.Application With {
            .DisplayAlerts = True,
            .ScreenUpdating = False,
            .EnableEvents = False
            }

        'File.Copy("..\..\Excel\Sample.xls", saveFile, True)
        'If File.Exists(saveFile) Then
        '    File.Create(saveFile)
        'End If
        'File.Copy("..\..\Excel\Sample.xlsx", "C:\Users\zzq\Desktop\Sample.xlsx")
        Dim path = IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(IO.Directory.GetCurrentDirectory())) & "\Excel\Sample.xls"
        wbXl = appXL.Workbooks.Open(path)
        shXL = wbXl.Sheets(1)   '第Ｎのtable sheetを取り出す
        '報告書の年月日
        shXL.Cells(4, 8) = r_date
        '会社情報
        shXL.Cells(6, 6) = Company_Info(1, 0).Value
        '部門情報
        shXL.Cells(7, 6) = Company_Info(1, 1).Value
        '個人情報
        shXL.Cells(8, 6) = Company_Info(1, 2).Value
        'ユーザー情報
        shXL.Cells(9, 6) = Company_Info(1, 3).Value

        'shXL.Range("C17:D47").Font.Color = Color.Black
        'Dim dates = GetDates.GetDate(Date_ComboBox.Text)
        'shXL.Range("C17:D47").Value = dates
        Insert_Reports_Detail_Excel()
        appXL.ScreenUpdating = True
        appXL.EnableEvents = True
        appXL.Visible = True
        '報告書を保存します
        Dim dateArr = Report_Date.Text.Split("/")
        Dim saveFile = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & dateArr(0) & dateArr(1) & "_" & Company_Info(1, 2).Value & ".xls"
        wbXl.SaveAs(saveFile)
        'EXCELが閉じる
        wbXl.Close(False, Type.Missing, Type.Missing)
        appXL.Workbooks.Close()
        appXL.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(appXL)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(shXL)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(wbXl)
        wbXl = Nothing
        appXL = Nothing
        shXL = Nothing
        GC.Collect()
        GC.WaitForPendingFinalizers()

    End Sub

    ''' <summary>
    ''' 報告詳細がEXCELに入力します
    ''' </summary>
    Private Sub Insert_Reports_Detail_Excel()
        Dim rows As Integer = 17
        For i = 0 To 30
            '日付
            shXL.Cells(rows, 3) = Reports_Detail(0, i).Value
            '曜日
            Dim week = Reports_Detail(1, i).Value
            shXL.Cells(rows, 4) = week
            '文字列のカラーを設定する
            Select Case week
                Case "(日)"
                    CType(shXL.Cells(rows, 3), Excel.Range).Font.Color = Color.Red
                    CType(shXL.Cells(rows, 4), Excel.Range).Font.Color = Color.Red
                Case "(土)"
                    CType(shXL.Cells(rows, 3), Excel.Range).Font.Color = Color.Blue
                    CType(shXL.Cells(rows, 4), Excel.Range).Font.Color = Color.Blue

            End Select
            '開始時間
            shXL.Cells(rows, 5) = Reports_Detail(2, i).Value
            '終了時間
            shXL.Cells(rows, 6) = Reports_Detail(3, i).Value
            '工数
            shXL.Cells(rows, 7) = Reports_Detail(4, i).Value
            '作業内容
            shXL.Cells(rows, 8) = Reports_Detail(5, i).Value
            rows += 1
        Next
        '勤務時間の合計
        shXL.Cells(49, 7) = Reports_Detail(4, 32).Value
        '重要事項
        shXL.Cells(51, 3) = Report_Content.Text

    End Sub
#End Region

    Private Function ManageBox_Init() As Integer
        '作業報告を全て削除する
        RepBox.Controls.Clear()
        ReportMap.Clear()

        Dim timeSetLabel = New Label With {
               .Text = "休憩時間の設定",
               .Font = New Font("ＭＳ ゴシック", 9),
               .TextAlign = ContentAlignment.MiddleRight,
               .Location = New Point(20, 5)
           }
        AddHandler timeSetLabel.Click, AddressOf Update_Click
        AddHandler timeSetLabel.MouseHover, AddressOf Color_MouseHover
        AddHandler timeSetLabel.MouseLeave, AddressOf Color_MouseLeave
        Dim timeSet As New Panel With {
            .Dock = DockStyle.Top,
            .Height = 30,
            .Tag = 0
        }
        AddHandler timeSet.Click, AddressOf Update_Click
        AddHandler timeSet.MouseHover, AddressOf Color_MouseHover
        AddHandler timeSet.MouseLeave, AddressOf Color_MouseLeave
        timeSet.Controls.Add(timeSetLabel)
        Dim holiSetLabel = New Label With {
               .Text = "年間休日の設定",
               .Font = New Font("ＭＳ ゴシック", 9),
               .TextAlign = ContentAlignment.MiddleRight,
               .Location = New Point(20, 5)
           }
        AddHandler holiSetLabel.Click, AddressOf Update_Click
        AddHandler holiSetLabel.MouseHover, AddressOf Color_MouseHover
        AddHandler holiSetLabel.MouseLeave, AddressOf Color_MouseLeave
        Dim holiSet As New Panel With {
            .Dock = DockStyle.Top,
            .Height = 30,
            .Tag = 1
        }
        AddHandler holiSet.Click, AddressOf Update_Click
        AddHandler holiSet.MouseHover, AddressOf Color_MouseHover
        AddHandler holiSet.MouseLeave, AddressOf Color_MouseLeave
        holiSet.Controls.Add(holiSetLabel)

        RepBox.Controls.Add(holiSet)
        ReportMap.Add(1, holiSet)
        RepBox.Controls.Add(timeSet)
        ReportMap.Add(0, timeSet)

        Return RepBox.Controls.Count
    End Function

#Region "マスタメンテナンス機能"
    ''' <summary>
    ''' 現場の休憩時間を初期化します
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RestTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim days = New GetHoliday

        '現場の名前を表示します
        Site_ComboBox.DisplayMember = "u_name"
        Site_ComboBox.ValueMember = "u_id"
        Site_ComboBox.DataSource = days.GetSiteData()
        Site_ComboBox.SelectedIndex = 0
        '午後の休憩開始時間
        Lunch_StartTime.DataSource = days.RestStartTime()
        Lunch_StartTime.Text = "12:00"
        '午後の休憩終了時間
        Lunch_EndTime.DataSource = days.RestStartTime()
        Lunch_EndTime.Text = "13:00"
        '夜の休憩開始時間
        Dinner_StartTime.DataSource = days.RestEndTime()
        Dinner_StartTime.Text = "15:30"
        '夜の休憩終了時間
        Dinner_EndTime.DataSource = days.RestEndTime()
        Dinner_EndTime.Text = "16:00"

        Rest_Time_Load(0)
    End Sub

    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'カレンダーの初期化　7行を追加します
        Calendar_View.Rows.Add(7)
        'カレンダーが読むだけ
        Calendar_View.ReadOnly = True
        '
        Calendar_View(0, 0).Value = "<"
        Calendar_View(6, 0).Value = ">"
        '現在の日付を設定します
        Calendar_View(3, 0).Value = Now.ToString("yyyy年MM月")
        Calendar_View.Rows(1).SetValues("日", "月", "火", "水", "木", "金", "土")
        '第1と2行の高さを設定します
        Calendar_View.Rows(0).Height = 30
        Calendar_View.Rows(1).Height = 30
        '日付を設定します
        Date_View()
    End Sub
    Private Sub Rest_Button_Click(sender As Object, e As EventArgs) Handles Rest_Button.Click
        'ユーザID
        Dim u_id = Site_ComboBox.SelectedValue
        '午後の休憩開始時間
        Dim lStartTime = Lunch_StartTime.SelectedValue
        '午後の休憩終了時間
        Dim lEndTime = Lunch_EndTime.SelectedValue
        '夜の休憩開始時間
        Dim dStartTime = Dinner_StartTime.SelectedValue
        '夜の休憩終了時間
        Dim dEndTime = Dinner_EndTime.SelectedValue
        '休憩時間がデータベースに保存します
        Dim days = New GetHoliday
        Dim param As String() = {lStartTime, lEndTime, dStartTime, dEndTime, u_id}
        Dim getrow = days.SetSiteRestTime(param)
        If getrow > 0 Then
            MsgBox("保存完了")
        End If
    End Sub

    ''' <summary>
    ''' 年間休日のカレンダーを取得します
    ''' </summary>
    Private Sub Date_View()

        '画面で表示した年月日
        Dim dates As DateTime = Calendar_View(3, 0).Value
        '画面で表示した年月の日数
        Dim thisMonthDays = DateTime.DaysInMonth(Year(dates), Month(dates))
        '画面で表示した年月の先月の日数
        Dim lastMonthDays = DateTime.DaysInMonth(Year(dates.AddMonths(-1)), Month(dates.AddMonths(-1)))
        '画面で表示した年月日の曜日が整数に転換します
        Dim weekDays As Integer = Convert.ToInt16(dates.DayOfWeek)
        '年間休日を取得します
        Dim days = New GetHoliday
        '今月の休日を取得します
        Dim sortList As SortedList = days.GetHoliday(dates)(dates.Month)
        '祝日以外の休日を取り出します
        Dim dt = days.GetOtherHolidays(dates)
        '
        Dim index = 0
        For rows = 2 To Calendar_View.Rows.Count - 1
            If rows > 2 Then
                weekDays = 0
            End If
            For columns = weekDays To Calendar_View.DisplayedColumnCount(False) - 1
                index += 1
                If index <= thisMonthDays Then
                    Calendar_View(columns, rows).Value = index.ToString("00")

                    'データベースから今月の祝日を取得して表示します
                    For Each dr As DataRow In dt.Rows
                        Dim otherHoliday As Date = dr(0)
                        If otherHoliday.Day = index Then
                            Calendar_View(columns, rows).Style.ForeColor = Color.Red
                            Calendar_View(columns, rows).Value = vbCrLf & vbCrLf & index.ToString("00") & vbCrLf & vbCrLf & dr(1)
                            If dr(1) <> "休日" Then
#Disable Warning BC42328 ' AddressOf' へのメソッド引数には、イベントのデリゲート型への厳密でない変換が必要です。したがって、'AddressOf' 式はこのコンテキストでは効果がありません
                                RemoveHandler Calendar_View.DoubleClick, AddressOf Calendar_View_CellDoubleClick
#Enable Warning BC42328 ' AddressOf' へのメソッド引数には、イベントのデリゲート型への厳密でない変換が必要です。したがって、'AddressOf' 式はこのコンテキストでは効果がありません
                            End If
                        End If
                    Next

                End If
            Next
        Next

        '来月の最初日
        Dim NextMonthDay = 1
        '来月の日付はDateViewの行列がnullの場合に埋め込みます
        For columns = 0 To Calendar_View.DisplayedColumnCount(False) - 1
            If Calendar_View(columns, 6).Value = "" Then
                Calendar_View(columns, 6).Value = NextMonthDay.ToString("00")
                Calendar_View(columns, 6).Style.ForeColor = Color.Gray
                Calendar_View(columns, 6).ReadOnly = True
                NextMonthDay += 1
            Else
                If Calendar_View(columns, 6).Style.ForeColor <> Color.Red Then
                    Calendar_View(columns, 6).Style.ForeColor = Color.Black
                End If

            End If
        Next
        '先月の日付はDateViewの行列がnullの場合に埋め込みます
        For columns = Calendar_View.DisplayedColumnCount(False) - 1 To 0 Step -1
            If Calendar_View(columns, 2).Value = "" Then
                Calendar_View(columns, 2).Value = lastMonthDays.ToString("00")
                Calendar_View(columns, 2).Style.ForeColor = Color.Gray
                Calendar_View(columns, 2).ReadOnly = True
                lastMonthDays -= 1
            Else
                If Calendar_View(columns, 2).Style.ForeColor <> Color.Red Then
                    Calendar_View(columns, 2).Style.ForeColor = Color.Black
                End If
            End If
        Next
        '今月以外の日付の場合にグレーの色を設定します
        For rows = 1 To 6
            If Calendar_View(0, rows).Style.ForeColor <> Color.Gray Then
                Calendar_View(0, rows).Style.ForeColor = Color.Red
            End If
            If Calendar_View(6, rows).Style.ForeColor <> Color.Gray Then
                Calendar_View(6, rows).Style.ForeColor = Color.Blue
            End If
        Next

    End Sub
    ''' <summary>
    ''' （＜）ボタンが押すと先月の日付を表示します
    ''' （＞）ボタンが押すと来月の日付を表示します
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Calendar_View_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Calendar_View.CellClick

        '＜ボタンを押すと先月を表示します
        If e.ColumnIndex = 0 And e.RowIndex = 0 Then
            Dim days = New GetHoliday
            For rows = 2 To 6
                For columns = 1 To 5
                    Calendar_View(columns, rows).Style.ForeColor = Color.Black
                Next
            Next
            'カレンダーの年月日を表示します
            Dim dates As DateTime = Calendar_View(3, 0).Value

            Calendar_View(3, 0).Value = dates.AddMonths(-1).ToString("yyyy年MM月")
            'カレンダーの内容を初期化します。
            Calendar_View.Rows(2).SetValues(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Calendar_View.Rows(6).SetValues(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            '年月よって年間休日を設定します
            If dates.AddMonths(-1).Year <> dates.Year Then
                If days.GetHolidaysCount(dates.AddMonths(-1)).Rows.Count <= 0 Then
                    days.SetAllHolidaysByYear(dates.AddMonths(-1))
                End If

            End If
            '年月日によって日付を取得して
            Date_View()
        End If
        '＞ボタンを押すと来月を表示します
        If e.ColumnIndex = 6 And e.RowIndex = 0 Then
            Dim days = New GetHoliday
            For rows = 2 To 6
                For columns = 1 To 5
                    Calendar_View(columns, rows).Style.ForeColor = Color.Black
                Next
            Next
            'カレンダーの年月日を表示します
            Dim dates As DateTime = Calendar_View(3, 0).Value
            Calendar_View(3, 0).Value = dates.AddMonths(1).ToString("yyyy年MM月")
            'カレンダーの内容を初期化します。
            Calendar_View.Rows(2).SetValues(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Calendar_View.Rows(6).SetValues(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            '年月よって年間休日を設定します
            If dates.AddMonths(1).Year <> dates.Year Then
                If days.GetHolidaysCount(dates.AddMonths(1)).Rows.Count <= 0 Then
                    days.SetAllHolidaysByYear(dates.AddMonths(1))
                End If
            End If
            '年月日によって日付を取得します
            Date_View()
        End If
    End Sub
    ''' <summary>
    ''' 日付がダブルクリックしたあと休日となります
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Calendar_View_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Calendar_View.CellDoubleClick
        Dim holiday As New GetHoliday
        '今月の日付がダブルクリック場合　
        If e.RowIndex >= 2 And e.RowIndex <= 6 And e.ColumnIndex > 0 And e.ColumnIndex < 6 And Calendar_View(e.ColumnIndex, e.RowIndex).Style.ForeColor <> Color.Gray Then
            '選択した日付
            Dim dates As Date = Calendar_View(3, 0).Value
            '日付が休日の場合にダブルクリックすると平日となります
            If Calendar_View(e.ColumnIndex, e.RowIndex).Style.ForeColor = Color.Red Then

                '選択した日数
                Dim days = Replace(Calendar_View(e.ColumnIndex, e.RowIndex).Value.ToString, Chr(13) + Chr(10), "").Substring(0, 2)
                'ダブルクリックした
                Dim getrow = holiday.DeleteHolidays(New Date(dates.Year, dates.Month, days))
                '休日が削除した場合にカレンダーの内容が変更します
                If getrow > 0 Then
                    Calendar_View(e.ColumnIndex, e.RowIndex).Style.ForeColor = Color.Black
                    Calendar_View(e.ColumnIndex, e.RowIndex).Value = days
                End If
            Else
                Dim days = Calendar_View(e.ColumnIndex, e.RowIndex).Value
                '日付が平日の場合にダブルクリックすると休日となります
                Calendar_View(e.ColumnIndex, e.RowIndex).Style.ForeColor = Color.Red
                Calendar_View(e.ColumnIndex, e.RowIndex).Value = vbCrLf & vbCrLf & days & vbCrLf & vbCrLf & "休日"
                holiday.AddHoliday(New Date(dates.Year, dates.Month, days))
            End If
        End If

    End Sub
    ''' <summary>
    ''' 現場によって休憩時間設定します
    ''' </summary>
    ''' <param name="index"></param>
    Private Sub Rest_Time_Load(ByVal index As Integer)
        Dim gh = New GetHoliday
        If index > 0 Then
            '現場によって休憩時間を取得します
            Dim restTime = gh.GetSiteRestTime(index)
            '休憩時間がNULL以外の場合に四つの休憩時間comboboxに入力します
            If Not IsDBNull(restTime.Rows(0).Item("lunch_starttime")) Then
                Lunch_StartTime.Text = restTime.Rows(0).Item("lunch_starttime")
            End If
            If Not IsDBNull(restTime.Rows(0).Item("lunch_endtime")) Then
                Lunch_EndTime.Text = restTime.Rows(0).Item("lunch_endtime")
            End If
            If Not IsDBNull(restTime.Rows(0).Item("dinner_starttime")) Then
                Dinner_StartTime.Text = restTime.Rows(0).Item("dinner_starttime")
            End If
            If Not IsDBNull(restTime.Rows(0).Item("dinner_endtime")) Then
                Dinner_EndTime.Text = restTime.Rows(0).Item("dinner_endtime")
            End If
        End If
    End Sub
    Private Sub Site_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Site_ComboBox.SelectedIndexChanged
        Rest_Time_Load(Site_ComboBox.SelectedValue.ToString)
    End Sub
#End Region

End Class
