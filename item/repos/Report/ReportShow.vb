''' <summary>
''' 
''' </summary>
Public Class ReportShow
    Public seal As Image = New Bitmap(80, 80)
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageView.Rows.Add(4)
        EmpInit()

        MessageViewInit()
        Not_Finish.Checked = True

        ''現在の時間を取り出す

        'Dim now = Date.Now
        'Year.Text = now.Year
        'Mon.Text = now.Month

        '印鑑欄のイニシャライズ
        SealView.Rows.Add(1)
        SealView.CurrentRow.Height = 80
        Dim column1 = CType(SealView.Columns(0), DataGridViewImageColumn)
        Dim column2 = CType(SealView.Columns(1), DataGridViewImageColumn)
        Dim column3 = CType(SealView.Columns(2), DataGridViewImageColumn)
        column1.Image = Me.seal
        column2.Image = Me.seal
        column3.Image = Me.seal
    End Sub

    Public Sub MessageViewInit()

        'メッセージ列のイニシャライズ
        Dim sql = "select u_name from users u left join employees e on u.u_id = e.u_id where e_id = ?"
        Dim table = Tools.GetData(sql, conn, Emp.SelectedValue.ToString)
        MessageView.Rows(0).SetValues("所属会社", employee.c_name)
        MessageView.Rows(1).SetValues("所属部署", employee.d_name)
        MessageView.Rows(2).SetValues("氏名", Emp.Text)
        MessageView.Rows(3).SetValues("ﾕｰｻﾞ名/ﾌﾟﾛｼﾞｪｸﾄ名", table.Rows(0).Field(Of String)("u_name"))
    End Sub


    Public Sub EmpInit()
        Dim sql = "select e_name,e_id from employees where m_id = ?"
        Emp.DisplayMember = "e_name"
        Emp.ValueMember = "e_id"
        Emp.DataSource = Tools.GetData(sql, conn, employee.e_id)
    End Sub



    Public Sub GetReports()

        ReportView.Rows.Clear()

        Dim boo As Boolean = False
        Dim sql = "select r_id,r_date,total_worktime,overtime,important_content from reports where e_id = ? and com_flag = 0"

        If Finish.Checked Then
            sql = "select r_id,r_date,total_worktime,overtime,important_content from reports where e_id = ? and com_flag = 1"
            boo = True
        End If

        Dim table = Tools.GetData(sql, conn, Emp.SelectedValue.ToString)

        If boo AndAlso table.Rows.Count > 0 Then
            Dim img = CType(SealView.Columns(1), DataGridViewImageColumn)
            img.Image = New Bitmap("..\..\Resources\Image\" & employee.seal_local)
        Else
            Dim img = CType(SealView.Columns(1), DataGridViewImageColumn)
            img.Image = seal
        End If


        Dim firstDay = Date.Now
        Dim days = Date.DaysInMonth(Now.Year, Now.Month)
        Dim total_worktime = "0:00"
        If table.Rows.Count > 0 Then
            Dim r_date = table.Rows(0).Field(Of String)("r_date")
            firstDay = CDate(r_date)
            days = Date.DaysInMonth(firstDay.Year, firstDay.Month)
            Dim r_id = table.Rows(0).Field(Of Integer)("r_id")
            total_worktime = table.Rows(0).Field(Of String)("total_worktime")
            WorkText.Text = table.Rows(0).Field(Of String)("important_content")
            sql = "select start_time,end_time,work_time,work_content from reports_detail where r_id = ?"
            table = Tools.GetData(sql, conn, r_id)
        End If
        Year.Text = firstDay.Year
        Mon.Text = firstDay.Month
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
        ReportView.Rows.Add("合計", Nothing, Nothing, Nothing, total_worktime, Nothing)
    End Sub



    Private Sub Emp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Emp.SelectedIndexChanged
        MessageViewInit()
        GetReports()
    End Sub

    Private Sub Finish_CheckedChanged(sender As Object, e As EventArgs) Handles Finish.CheckedChanged
        GetReports()
    End Sub

    Private Sub SealView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SealView.CellContentClick
        Dim sql = "select r_id from reports where e_id = ? and sales_flag = 0 and com_flag = 0 order by r_id asc"
        Dim boo As Boolean = False
        If Finish.Checked Then
            sql = "select r_id from reports where e_id = ? and (sales_flag = 1 or com_flag = 1) order by r_id desc"
            boo = True
        End If
        Dim table = Tools.GetData(sql, conn, Emp.SelectedValue)
        If table.Rows.Count > 0 Then

            Dim img = CType(SealView.Columns(1), DataGridViewImageColumn)
            If boo Then
                img.Image = New Bitmap("..\..\Resources\Image\" & employee.seal_local)
            Else
                img.Image = seal
            End If
            sql = "update reports set com_flag = 1 where r_id = ?"
            If Finish.Checked Then
                sql = "update reports set com_flag = 0 where r_id = ?"
            End If
            Dim sum = Tools.SetData(sql, conn, table.Rows(0).Field(Of Integer)("r_id"))
            GetReports()
            MessageBox.Show("Reports表の中の影響される行目：" & sum)
        Else
            MessageBox.Show("このユーザーは作業報告書を提出していません")
        End If
    End Sub

End Class