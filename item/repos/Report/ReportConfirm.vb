Public Class ReportConfirm
    Private Sub MasterMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Year.Text = Now.Year
        Mon.Text = Now.Month



        GetReports()

        Not_Finish.Checked = True
    End Sub

    Private Sub Init()

    End Sub

    Private Sub GetReports()
        Dim sql As String = ""
        If employee.d_id = 1 OrElse employee.d_id = 4 OrElse employee.d_id = 7 Then
            If Not_Finish.Checked Then
                sql = "select r_id,r_date,e_name from reports r left join employees e on r.e_id = e.e_id where sales_flag = 0 and com_flag = 0 and r_date = ?"
            Else
                sql = "select r_id,r_date,e_name from reports r left join employees e on r.e_id = e.e_id where (sales_flag = 1 or com_flag = 1) and r_date = ?"
            End If
        ElseIf employee.p_id <> 6 Then
            If Finish.Checked Then
                sql = "select r_id,r_date,e_name from reports r left join employees e on r.e_id = e.e_id where (sales_flag = 1 or com_flag = 1) and r_date = ? and e_id in (select e_id from employees where m_id = " & employee.e_id & ")"
            Else
                sql = "select r_id,r_date,e_name from reports r left join employees e on r.e_id = e.e_id where sales_flag = 0 and com_flag = 0 and r_date = ? and e_id in (select e_id from employees where m_id = " & employee.e_id & ")"
            End If
        End If
        Dim r_date = Year.Text & "/" & Mon.Text
            Dim table = Tools.GetData(sql, conn, r_date)
            For i = 0 To table.Rows.Count - 1
                ReportsView.Rows.Add()
                'Dim button = New DataGridViewButtonCell
                'button.Tag = table.Rows(i).Field(Of Integer)("r_id")
                'button.Value = table.Rows(i).Field(Of String)("r_date") & "_" & table.Rows(i).Field(Of String)("e_name")
                Dim button = ReportsView.Rows(i).Cells(1)
                button.Value = table.Rows(i).Field(Of String)("e_name")
                button.Tag = table.Rows(i).Field(Of Integer)("r_id")
            Next
    End Sub

    Private Sub Finish_CheckedChanged(sender As Object, e As EventArgs) Handles Finish.CheckedChanged

    End Sub

    Private Sub Not_Finish_CheckedChanged(sender As Object, e As EventArgs) Handles Not_Finish.CheckedChanged

    End Sub
End Class