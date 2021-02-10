Imports System.Data.SqlClient
Public Class ReportInput
    Public seal As Image = New Bitmap(80, 80)

    ''' <summary>
    ''' 作業報告書のデータの初期化
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Reprot_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Init()
        'MessageViewの初期化
        MessageViewInit()

        'SealViewの初期化
        SealView.Rows.Add(1)
        SealView.CurrentRow.Height = 80
        Dim column1 = CType(SealView.Columns(0), DataGridViewImageColumn)
        Dim column2 = CType(SealView.Columns(1), DataGridViewImageColumn)
        Dim column3 = CType(SealView.Columns(2), DataGridViewImageColumn)
        column1.Image = seal
        column2.Image = seal
        column3.Image = seal

        GetReports_Detail()
    End Sub

    Private Sub Init()
        Dim now As DateTime = DateTime.Now
        Year.Text = now.Year
        Mon.Text = now.Month
    End Sub

    ''' <summary>
    ''' MessageViewの初期化
    ''' </summary>
    Private Sub MessageViewInit()
        'メッセージ列のイニシャライズ
        MessageView.Rows.Add("所属会社", employee.c_name)
        MessageView.Rows.Add("所属部署", employee.d_name)
        MessageView.Rows.Add("氏名", employee.e_name)
        MessageView.Rows.Add("ﾕｰｻﾞ名/ﾌﾟﾛｼﾞｪｸﾄ名", employee.u_name)

    End Sub

    Private Sub Mon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Mon.SelectedIndexChanged
        GetReports_Detail()
    End Sub

    Private Function GetReports() As Boolean
        Dim sql = "select r_id,total_worktime,overtime,important_content,sales_flag,com_flag from reports where e_id = ? and r_date = ?"
        Dim r_date = Year.Text & "/" & Mon.Text
        Dim rep_msg = Tools.GetData(sql, conn, employee.e_id, r_date)
        If rep_msg.Rows.Count > 0 Then

            With employee
                .r_id = rep_msg.Rows(0).Field(Of Integer)("r_id")
                .total_worktime = rep_msg.Rows(0).Field(Of String)("total_worktime")
                .overtime = rep_msg.Rows(0).Field(Of Single)("overtime")
                .important_content = rep_msg.Rows(0).Field(Of String)("important_content")
            End With
            Dim sales_flag = rep_msg.Rows(0).Field(Of Boolean)("sales_flag")
            Dim com_flag = rep_msg.Rows(0).Field(Of Boolean)("com_flag")
            If sales_flag Then
                Dim table = Tools.GetData("select seal from employees where e_id = ?", conn, employee.m_id)
                Dim img = CType(SealView.Columns(0), DataGridViewImageColumn)
                img.Image = New Bitmap("..\..\Resources\Image\" & table.Rows(0).Field(Of String)("seal"))
                Return sales_flag
            ElseIf com_flag Then
                Dim table = Tools.GetData("select seal from employees where e_id = ?", conn, employee.m_id)
                Dim img = CType(SealView.Columns(1), DataGridViewImageColumn)
                img.Image = New Bitmap("..\..\Resources\Image\" & table.Rows(0).Field(Of String)("seal"))
                Return com_flag
            Else
                Return False
            End If
        Else
            Dim img = CType(SealView.Columns(0), DataGridViewImageColumn)
            img.Image = seal
            img = CType(SealView.Columns(1), DataGridViewImageColumn)
            img.Image = seal
            With employee
                .r_id = Nothing
                .total_worktime = "0:00"
                .overtime = Nothing
                .important_content = Nothing
            End With
            Return False
        End If
    End Function

    Private Sub GetReports_Detail()
        ReportView.Rows.Clear()
        Dim firstDay = New DateTime(Year.Text, Mon.Text, 1)
        Dim flag = GetReports()
        If flag Then
            ReportView.ReadOnly = True
            WorkTimeList.Enabled = False
            SaveButton.Enabled = False
        Else
            ReportView.ReadOnly = False
            WorkTimeList.Enabled = True
            SaveButton.Enabled = True
        End If
        Dim sql = "select start_time,end_time,work_time,work_content from reports_detail where r_id = ?"
        Dim table = Tools.GetData(sql, conn, employee.r_id)

        Dim days = Date.DaysInMonth(Year.Text, Mon.Text)
        For i = 0 To days - 1
            Dim week = Tools.GetWeekOfDay(firstDay.AddDays(i))
            ReportView.Rows.Add((i + 1), week)
            Select Case week
                Case "(土)"
                    ReportView.Rows(i).Cells(0).Style.ForeColor = Color.Blue
                    ReportView.Rows(i).Cells(1).Style.ForeColor = Color.Blue
                Case "(日)"
                    ReportView.Rows(i).Cells(0).Style.ForeColor = Color.Red
                    ReportView.Rows(i).Cells(1).Style.ForeColor = Color.Red
            End Select
            If table.Rows.Count > 0 Then

                Dim start_time = table.Rows(i).Field(Of String)("start_time")
                Dim end_time = table.Rows(i).Field(Of String)("end_time")
                Dim work_time = table.Rows(i).Field(Of String)("work_time")
                Dim work_content = table.Rows(i).Field(Of String)("work_content")
                If start_time <> "" AndAlso end_time <> "" Then

                    ReportView.Rows(i).SetValues((i + 1), week, CDate(start_time).ToShortTimeString, CDate(end_time).ToShortTimeString,
                                             work_time, work_content)
                Else
                    ReportView.Rows(i).SetValues((i + 1), week, start_time, end_time,
                                             work_time, work_content)
                End If
            End If

        Next i
        ReportView.Rows.Add(32 - days)
        ReportView.Rows.Add("合計", Nothing, Nothing, Nothing, employee.total_worktime, Nothing)
    End Sub





    ''' <summary>
    ''' ReportView中のworktimeを設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReportViewWorkTime(sender As Object, e As EventArgs)
        '重要な情報を取り出す
        Dim startTime = ReportView.CurrentRow.Cells(2).Value
        Dim endTime = ReportView.CurrentRow.Cells(3).Value

        'starttimeとendtimeはnothingじゃないと、以下のstatementを実行する
        If startTime <> "" And endTime <> "" Then
            startTime = Split(startTime, ":")
            endTime = Split(endTime, ":")
            Dim workTime = ""

            startTime = New TimeSpan(startTime(0), startTime(1), 0)
            endTime = New TimeSpan(endTime(0), endTime(1), 0)
            If endTime > startTime Then
                Dim arr = Split((endTime - startTime).ToString, ":")
                Dim num = arr(0) / 6
                If num > 1 Or (num = 1 And arr(1) > 0) Then
                    workTime = (CType(arr(0), Integer) - Int(num) * 1) & ":" & arr(1)
                Else
                    workTime = CType(arr(0), Integer) & ":" & arr(1)
                End If

            Else
                workTime = "エラー"
                ReportView.CurrentRow.Cells(4).Style.ForeColor = Color.Red
            End If
            ReportView.CurrentRow.Cells(4).Value = workTime


            GetSumTime()
        ElseIf startTime = "" And endTime = "" Then
            ReportView.CurrentRow.Cells(4).Value = ""
        End If
    End Sub

    ''' <summary>
    ''' 通勤時間の初期化
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub WorkTimeListChanged(sender As Object, e As EventArgs) Handles WorkTimeList.SelectedIndexChanged
        Dim workTime = WorkTimeList.Text

        Dim Year = CType(Me.Year.Text, Integer)
        Dim Mon = CType(Me.Mon.Text, Integer)

        Dim arr = workTime.Split(":")
        For i = 0 To Date.DaysInMonth(Year, Mon) - 1
            Dim color = ReportView.Rows(i).Cells(0).Style.ForeColor
            If color <> Color.Red And color <> Color.Blue Then
                Dim endTime As Integer = CType(arr(0), Integer) + 9
                ReportView.Rows(i).Cells(2).Value = workTime
                ReportView.Rows(i).Cells(3).Value = endTime.ToString() & ":" & arr(1)
                ReportView.Rows(i).Cells(4).Value = "8:00"
            End If
        Next i
        GetSumTime()

    End Sub

    ''' <summary>
    ''' 総時間を取り出す
    ''' </summary>
    Private Sub GetSumTime()
        Dim sumHour = 0
        Dim sumMin = 0
        For i = 0 To 30
            Dim time = Split(ReportView.Rows(i).Cells(4).Value, ":")
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

        ReportView.Rows(32).Cells(4).Value = sumTime
    End Sub


    ''' <summary>
    ''' メッセージを登録する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim c_id = employee.c_id
        Dim d_id = employee.d_id
        Dim e_id = employee.e_id

        If c_id <> Nothing AndAlso d_id <> Nothing AndAlso e_id <> Nothing Then
            Dim r_date As String = Year.Text & "/" & Mon.Text
            Dim sql = "select r_id from reports where e_id = ? and r_date = ?"
            Dim table = Tools.GetData(sql, conn, e_id, r_date)
            Dim num = UpdateReports(table, e_id, r_date)
            Dim r_id = Tools.GetData(sql, conn, e_id, r_date).Rows(0).ItemArray(0).ToString()
            Dim num1 = UpdateReportsDetail(r_id)
            MessageBox.Show("Reports表の中の影響される行目：" & num & vbLf &
                            "ReportsDetail表の中の影響される行目：" & num1)
        Else
            MessageBox.Show("入力したデータは間違いですから、も一度ご入力ください")
        End If

    End Sub

    ''' <summary>
    ''' Reports表に対して更新する
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="e_id"></param>
    ''' <param name="r_date"></param>
    Private Function UpdateReports(table As DataTable, e_id As Integer, r_date As String) As Integer
        Dim sql = "insert into reports values (next value for reports_sequence,?,?,?,?,?,?,?,0,0)"
        If table.Rows.Count > 0 Then
            sql = "update reports set u_id = ?,e_id = ?,r_date = ?,total_worktime = ?,overtime = ?,important_content = ?,create_time = ? where r_id = " & table.Rows(0).ItemArray(0)
        End If
        Dim u_id As Integer = employee.u_id
        Dim total_worktime = ReportView.Rows(32).Cells(4).Value.ToString
        Dim total_time As TimeSpan
        TimeSpan.TryParse(total_worktime, total_time)
        Dim important_content = WorkText.Text
        Dim now = Date.Now()
        Return Tools.SetData(sql, conn, u_id, e_id, r_date, total_worktime,
                             Math.Round(total_time.TotalHours, 1, MidpointRounding.AwayFromZero),
                             important_content, now)
    End Function

    ''' <summary>
    ''' ReportsDetail表に対して更新する
    ''' </summary>
    ''' <param name="r_id"></param>
    Private Function UpdateReportsDetail(r_id As String) As Integer
        'Dim days = Getdays(year, mon)
        Dim sql = "insert into reports_detail values (?,?,?,?,?)"
        Dim table = Tools.GetData("select r_d_id from reports_detail where r_id = ?", conn, r_id)
        Dim sum = 0
        For i = 0 To Date.DaysInMonth(Year.Text, Mon.Text) - 1
            If table.Rows.Count > 0 Then
                sql = "update reports_detail set r_id = ?,start_time = ?,end_time = ?,work_time = ?,work_content = ? where r_d_id = " _
                        & table.Rows(i).Field(Of Integer)("r_d_id")
            End If

            Dim curRow = ReportView.Rows(i)
            Dim startTime = curRow.Cells(2).Value
            Dim endTime = curRow.Cells(3).Value
            Dim workTime = curRow.Cells(4).Value
            Dim workContent = curRow.Cells(5).Value

            '工数があるのときは、開始時間と終了時間を再設置する
            If workTime <> "" Then
                Dim startTimeArr = startTime.ToString.Split(":")
                startTime = New DateTime(Year.Text, Mon.Text, curRow.Cells(0).Value, startTimeArr(0), startTimeArr(1), 0).ToString
                Dim endTimeArr = endTime.ToString.Split(":")
                endTime = New DateTime(Year.Text, Mon.Text, curRow.Cells(0).Value, endTimeArr(0), endTimeArr(1), 0).ToString
            End If

            sum += Tools.SetData(sql, conn, r_id, startTime, endTime, workTime, workContent)
        Next i
        Console.WriteLine("実行行目：" & sum)
        Return sum
    End Function

End Class
