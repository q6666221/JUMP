Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageViewInit()
        PermissionViewInit()
    End Sub
    Private Sub MessageViewInit()
        'Dim sql = "select u_name from users u left join employees e on u.u_id = e.u_id where e.e_id = ?"
        'Dim table = Tools.GetData(sql, conn, employee.e_id)
        MessageView.Rows.Add("所属会社", Me.employee.c_name)
        MessageView.Rows.Add("所属部署", Me.employee.d_name)
        MessageView.Rows.Add("氏名", Me.employee.e_name)
        MessageView.Rows.Add("ﾕｰｻﾞ名/ﾌﾟﾛｼﾞｪｸﾄ名", employee.u_name)
    End Sub

    Private Sub PermissionViewInit()
        PermissionView.Rows.Add("作業報告の登録")
        If (employee.d_id = 3 OrElse employee.d_id = 6 OrElse employee.d_id = 9) AndAlso employee.p_id <> 6 Then
            PermissionView.Rows.Add("作業報告の確認")
        End If
        If employee.p_id = 1 OrElse employee.p_id = 4 OrElse employee.p_id = 7 Then
            PermissionView.Rows.Add("マスタメンテナンス")
        End If
    End Sub

    Private Sub PermissionView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PermissionView.CellContentClick
        Select Case PermissionView.CurrentRow.Cells(0).Value
            Case "作業報告の登録"
                ToReportInput()
            Case "作業報告の確認"
                ToReportConfirm()
            Case "マスタメンテナンス"
                ToMasterMaintenance()
        End Select

    End Sub

    Private Sub ToReportInput()
        Dim ri As New ReportInput(Me.employee, conn)
        ri.Show()
    End Sub

    Private Sub ToReportConfirm()
        Dim rc As New ReportConfirm(Me.employee, conn)
        rc.Show()
    End Sub

    Private Sub ToMasterMaintenance()
        Dim mm As New ReportConfirm(Me.employee, conn)
        mm.Show()
    End Sub

End Class