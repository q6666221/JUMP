Imports System.Data.SqlClient
Public Class Tools

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="now"></param>
    ''' <returns></returns>
    Shared Function GetWeekOfDay(now As DateTime) As String
        Dim week As String = "(日)"
        Select Case now.DayOfWeek
            Case DayOfWeek.Monday
                week = "(月)"
            Case DayOfWeek.Tuesday
                week = "(火)"
            Case DayOfWeek.Wednesday
                week = "(水)"
            Case DayOfWeek.Thursday
                week = "(木)"
            Case DayOfWeek.Friday
                week = "(金)"
            Case DayOfWeek.Saturday
                week = "(土)"
        End Select
        Return week
    End Function


    Shared Function GetReports(conn As SqlConnection, employee As Employees, now As DateTime) As Integer
        Dim sql = "select r_id,total_worktime,overtime,important_content,sales_flag,com_flag from reports where e_id = ? and r_date = ?"
        Dim r_date = now.Year & "/" & now.Month
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
            If sales_flag = 1 Then
                Return sales_flag
            ElseIf com_flag = 1 Then
                Return com_flag
            Else
                Return 0
            End If
        Else
            With employee
                .r_id = Nothing
                .total_worktime = "0:00"
                .overtime = Nothing
                .important_content = Nothing
            End With
            Return 0
        End If

    End Function

    Shared Function DateToString(time As Date) As String
        Dim str As String = time.Hour & ":"
        If time.Minute = 0 Then
            str &= "00"
        Else
            str &= time.Minute
        End If
        Return str
    End Function

    Shared Function DateToString(time As TimeSpan) As String
        Dim str As String = time.Hours & ":"
        If time.Minutes = 0 Then
            str &= "00"
        Else
            str &= time.Minutes
        End If
        Return str
    End Function

    ''' <summary>
    ''' データベースからデータを取り出す
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="args"></param>
    ''' <returns></returns>
    Shared Function GetData(sql As String, conn As SqlConnection, ParamArray args As String()) As DataTable

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
    Shared Function SetData(sql As String, conn As SqlConnection, ParamArray args As String()) As Integer

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
End Class
