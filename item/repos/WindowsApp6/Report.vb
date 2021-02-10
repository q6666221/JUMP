Imports System.Data.SqlClient
Public Class Report
    Public conn As SqlClient.SqlConnection
    Public employee As Employees
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageInit()
    End Sub

    Private Sub MessageInit()
        TextBox1.Text = employee.reportList(0).start_time.Year & "/" & employee.reportList(0).start_time.Month
        DataGridView1.Rows.Add("所属会社", employee.c_name)
        DataGridView1.Rows.Add("所属部署", employee.d_name)
        DataGridView1.Rows.Add("氏名", employee.e_name)
        DataGridView1.Rows.Add("ﾕｰｻﾞ名/ﾌﾟﾛｼﾞｪｸﾄ名", employee.u_name)
        Dim reports = employee.reportList
        For i = 0 To reports.Count - 1
            Dim report = CType(reports(i), Reports)

            DataGridView2.Rows.Add(report.day & " " & report.week,
                                   report.start_time.Hour & ":" & report.start_time.Minute,
                                   report.end_time.Hour & ":" & report.end_time.Minute,
                                   report.work_time, report.work_content)
            Select Case report.week
                Case "(土)"
                    DataGridView2.Rows(i).Cells(0).Style.ForeColor = Color.Blue
                Case "(日)"
                    DataGridView2.Rows(i).Cells(0).Style.ForeColor = Color.Red
            End Select
        Next i
    End Sub
End Class