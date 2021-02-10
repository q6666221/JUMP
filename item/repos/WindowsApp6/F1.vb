Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
'Imports Microsoft.Office.Interop.Excel
Public Class F1

    Private Sub Init()
        employee = New Employees
        Dim curDir = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath))
        Dim strFileName As String = curDir & "\Resource\Connection-config.xml"
        Dim xmlReader = New System.Xml.XmlDocument
        xmlReader.Load(strFileName)
        Dim nameNode = xmlReader.GetElementsByTagName("name")
        conn = New SqlConnection With {
            .ConnectionString = nameNode(0).InnerText.ToString
        }
        conn.Open()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        CompanyInit()
        Company.SelectedIndex = 1
        Department.SelectedIndex = 2
    End Sub

    Private Sub CompanyInit()
        Dim sql = "select c_name,c_id from companys"
        Company.DisplayMember = "c_name"
        Company.ValueMember = "c_id"
        Company.DataSource = GetData(sql)
    End Sub

    Private Sub Company_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Company.SelectedIndexChanged
        Dim sql = "select d_name,d_id from departments where c_id = ?"
        Department.DisplayMember = "d_name"
        Department.ValueMember = "d_id"
        Department.DataSource = GetData(sql, Company.SelectedValue.ToString)
    End Sub

    Private Sub Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Department.SelectedIndexChanged
        Dim sql = "select e_name,e_id from employees where d_id = ?"
        Emp.DisplayMember = "e_name"
        Emp.ValueMember = "e_id"
        Emp.DataSource = GetData(sql, Department.SelectedValue.ToString)
    End Sub

    ''' <summary>
    ''' データベースからデータを取り出す
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="args"></param>
    ''' <returns></returns>
    Private Function GetData(sql As String, ParamArray args As String()) As DataTable

        'sql句の構成
        Dim sql1 = ""
        If args.Length = 0 Then
            sql1 &= sql
        Else
            Dim arr = Split(sql, "?")
            For i As Integer = 0 To arr.Length - 1

                sql1 &= arr(i)
                If i < args.Length Then
                    sql1 &= " '" & args(i) & "' "
                End If
            Next i
        End If

        'sql句の実行
        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter(sql1, conn)
        Dim dateSet As DataSet = New DataSet()
        dataAdapter.Fill(dateSet)
        Return dateSet.Tables(0)
    End Function

    ''' <summary>
    ''' データベースにデータを書き入れ
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="args"></param>
    ''' <returns></returns>
    Private Function SetData(sql As String, ParamArray args As String()) As Integer

        'sql句の構成
        Dim sql1 = ""
        If args.Length = 0 Then
            sql1 &= sql
        Else
            Dim arr = Split(sql, "?")
            For i As Integer = 0 To arr.Length - 1

                sql1 &= arr(i)
                If i < args.Length Then
                    sql1 &= " '" & args(i) & "' "
                End If
            Next i
        End If

        'sql句の実行
        Dim dataCommand As SqlCommand = New SqlCommand(sql1, conn)
        Return dataCommand.ExecuteNonQuery()
    End Function

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        If GetReport() Then
            Dim report As New Report(employee, conn)
            report.Show()
        Else
            MessageBox.Show("入力した値は間違いです")
        End If
    End Sub

    Private Function GetReport() As Boolean
        Dim sql = "select r_id,u_id,total_worktime,important_content from reports where e_id = ? and r_date = ?"
        Dim table = GetData(sql, Emp.SelectedValue.ToString, Year.Text & "/" & Mon.Text)
        If table.Rows.Count <> 0 Then
            Dim total_worktime = table.Rows(0).Field(Of String)("total_worktime")
            Dim important_content = table.Rows(0).Field(Of String)("important_content")
            Dim r_id As String = table.Rows(0).Field(Of Integer)("r_id")
            Dim u_id As String = table.Rows(0).Field(Of Integer)("u_id")
            sql = "select u_name from users where u_id = ?"
            table = GetData(sql, u_id)
            Dim u_name = table.Rows(0).Field(Of String)("u_name")
            With employee
                .e_name = Emp.Text
                .c_name = Company.Text
                .d_name = Department.Text
                .u_name = u_name
                .total_worktime = total_worktime
                .important_content = important_content
                .reportList = Reports(r_id)
            End With
        Else
            Return False
        End If
        Return True
    End Function

    Private Function Reports(r_id As String) As List(Of Reports)
        Dim list As New List(Of Reports)
        Dim sql = "select start_time,end_time,work_time,work_content from reports_detail where r_id = ?"
        Dim table = GetData(sql, r_id)
        Dim nextmon = CType(Mon.Text, Integer) + 1
        Dim days = (New DateTime(Year.Text, nextmon, 1) _
            - New DateTime(Year.Text, Mon.Text, 1)).Days
        Dim num As Integer = 0
        For i = 1 To days
            Dim time As New DateTime(Year.Text, Mon.Text, i)
            Dim temp As New Reports
            If table.Rows(num).Field(Of DateTime)("start_time").Day = i Then
                With temp
                    .start_time = table.Rows(num).Field(Of DateTime)("start_time")
                    .end_time = table.Rows(num).Field(Of DateTime)("end_time")
                    .work_time = table.Rows(num).Field(Of String)("work_time")
                    .work_content = table.Rows(num).Field(Of String)("work_content")
                End With
                num += 1
            End If
            With temp
                .day = i
                Select Case time.DayOfWeek
                    Case 0
                        .week = "(日)"
                    Case 1
                        .week = "(月)"
                    Case 2
                        .week = "(火)"
                    Case 3
                        .week = "(水)"
                    Case 4
                        .week = "(木)"
                    Case 5
                        .week = "(金)"
                    Case 6
                        .week = "(土)"
                End Select
            End With
            list.Add(temp)
        Next i
        Return list
    End Function

    Friend WithEvents conn As SqlConnection
    Friend WithEvents employee As Employees
End Class
