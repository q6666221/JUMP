Imports System.Data.SqlClient

''' <summary>
''' 時間計算とデータの処理
''' </summary>
Public Class Tools

    ''' <summary>
    ''' 日付の曜日の判断
    ''' </summary>
    ''' <param name="now">判断される日付</param>
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

    ''' <summary>
    ''' データベースからデータを取り出す
    ''' </summary>
    ''' <param name="Sql"></param>
    ''' <param name="args"></param>
    ''' <returns></returns>
    Shared Function GetData(Conn As SqlConnection, Sql As String, ParamArray args As String()) As DataTable

        'Sql句の構成
        Dim Sql1 = ""
        If args.Length = 0 Then
            Sql1 &= Sql
        Else
            Dim arr = Split(Sql, "?")
            For i As Integer = 0 To arr.Length - 1

                Sql1 &= arr(i)
                If i < args.Length Then
                    Sql1 &= " '" & args(i) & "' "
                End If
            Next i
        End If

        'Sql句の実行
        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter(Sql1, Conn)
        Dim dateSet As DataSet = New DataSet()
        dataAdapter.Fill(dateSet)
        Return dateSet.Tables(0)
    End Function

    ''' <summary>
    ''' データベースにデータを書き入れ
    ''' </summary>
    ''' <param name="Sql"></param>
    ''' <param name="args"></param>
    ''' <returns></returns>
    Shared Function SetData(Conn As SqlConnection, Sql As String, ParamArray args As String()) As Integer

        'Sql句の構成
        Dim Sql1 = ""
        If args.Length = 0 Then
            Sql1 &= Sql
        Else
            Dim arr = Split(Sql, "?")
            For i As Integer = 0 To arr.Length - 1

                Sql1 &= arr(i)
                If i < args.Length Then
                    Sql1 &= " '" & args(i) & "' "
                End If
            Next i
        End If

        'Sql句の実行
        Dim dataCommand As SqlCommand = New SqlCommand(Sql1, Conn)
        Return dataCommand.ExecuteNonQuery()
    End Function
End Class
