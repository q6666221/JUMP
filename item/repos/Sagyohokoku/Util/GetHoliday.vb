Public Class GetHoliday
    '一年中の祝日を格納するlist
    Public sortList As New SortedList
    ''' <summary>
    ''' 休憩開始時間を設定します
    ''' </summary>
    ''' <returns></returns>
    Public Function RestStartTime() As ArrayList
        Dim startTime As ArrayList = New ArrayList
        startTime.Add("00:00")
        For i = 11 To 14
            For k = 0 To 55 Step 5
                Dim times
                If k < 10 Then
                    times = i & ":0" & k
                Else
                    times = i & ":" & k
                End If
                startTime.Add(times)
            Next
        Next
        startTime.Add("15: 00")
        Return startTime
    End Function
    ''' <summary>
    ''' 休憩終了時間を設定します
    ''' </summary>
    ''' <returns></returns>
    Public Function RestEndTime() As ArrayList
        Dim endTime As ArrayList = New ArrayList
        endTime.Add("00:00")
        For i = 16 To 19
            For k = 0 To 55 Step 5
                Dim times
                If k < 10 Then
                    times = i & ":0" & k
                Else
                    times = i & ":" & k
                End If
                endTime.Add(times)
            Next
        Next
        endTime.Add("20:00")
        Return endTime
    End Function
    ''' <summary>
    ''' 現場のデータを取得します
    ''' </summary>
    ''' <returns></returns>
    Public Function GetSiteData() As DataTable
        Dim sql = "select u_id,u_name  from users where u_id > ?"
        Return Tools.GetData(Login.conn, sql, 0)
    End Function
    ''' <summary>
    ''' 現場によって休憩時間を取得します
    ''' </summary>
    ''' <param name="u_id"></param>
    ''' <returns></returns>
    Public Function GetSiteRestTime(ByVal u_id As Integer) As DataTable
        Dim sql = "select lunch_starttime,lunch_endtime,dinner_starttime,dinner_endtime  from users where u_id = ?"
        Return Tools.GetData(Login.conn, sql, u_id)
    End Function
    ''' <summary>
    ''' 休憩時間がデータベースに入力します
    ''' </summary>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Function SetSiteRestTime(ParamArray ByVal param As String()) As Integer
        Dim sql = "update users set lunch_starttime =?,lunch_endtime =?,dinner_starttime =?,dinner_endtime =? where u_id =?"
        Return Tools.SetData(Login.conn, sql, param)
    End Function
    ''' <summary>
    ''' 年間休日を取得します
    ''' </summary>
    ''' <param name="dates"></param>
    ''' <returns></returns>
    Public Function GetHoliday(ByVal dates As DateTime) As SortedList

        '祝日の判定
        Dim holiday = New HolidayTools
        For months = 1 To 12
            '一月の祝日
            If months = 1 And IsNothing(sortList(months)) Then

                Dim January As New SortedList
                '元旦
                Dim newYear = holiday.GetNewYearDay(dates)
                January.Add(newYear.Day, New Holidays(newYear, "元旦", newYear.ToString("dddd")))
                If Weekday(newYear) = 1 Then
                    January.Add(newYear.AddDays(1).Day, New Holidays(newYear.AddDays(1), "振替休日", newYear.AddDays(1).ToString("dddd")))
                End If
                '成人式
                Dim comingOfAgeDay = holiday.GetComingOfAgeDay(dates)
                January.Add(comingOfAgeDay.Day, New Holidays(comingOfAgeDay, "成人の日", comingOfAgeDay.ToString("dddd")))
                If Weekday(comingOfAgeDay) = 1 Then
                    January.Add(comingOfAgeDay.AddDays(1).Day, New Holidays(comingOfAgeDay.AddDays(0), "振替休日", comingOfAgeDay.AddDays(1).ToString("dddd")))
                End If
                '1月の祝日を格納しました
                sortList.Add(1, January)
            End If
            '二月の祝日
            If months = 2 And IsNothing(sortList(months)) Then
                Dim February As New SortedList
                '建国記念の日
                Dim nationalFoundationDay = holiday.GetNationalFoundationDay(dates)
                February.Add(nationalFoundationDay.Day, New Holidays(nationalFoundationDay, "建国記念の日", nationalFoundationDay.ToString("dddd")))
                If Weekday(nationalFoundationDay) = 1 Then
                    February.Add(nationalFoundationDay.AddDays(1).Day, New Holidays(nationalFoundationDay.AddDays(1), "振替休日", nationalFoundationDay.AddDays(1).ToString("dddd")))
                End If
                '天皇誕生日
                If dates.Year >= 2020 Then
                    Dim emperorBirthDay = New DateTime(dates.Year, 2, 23)
                    February.Add(emperorBirthDay.Day, New Holidays(emperorBirthDay, "天皇誕生日", emperorBirthDay.ToString("dddd")))

                    If Weekday(emperorBirthDay) = 1 Then
                        February.Add(emperorBirthDay.AddDays(1).Day, New Holidays(emperorBirthDay.AddDays(1), "振替休日", emperorBirthDay.AddDays(1).ToString("dddd")))
                    End If
                End If
                '2月の祝日を格納しました
                sortList.Add(2, February)
            End If
            '三月の祝日
            If months = 3 And IsNothing(sortList(months)) Then
                Dim March As New SortedList
                '春分の日
                Dim springEquinoxDay = holiday.GetSpringEquinoxDay(dates)
                March.Add(springEquinoxDay.Day, New Holidays(springEquinoxDay, "春分の日", springEquinoxDay.ToString("dddd")))
                If Weekday(springEquinoxDay) = 1 Then
                    March.Add(springEquinoxDay.AddDays(1).Day, New Holidays(springEquinoxDay.AddDays(1), "振替休日", springEquinoxDay.AddDays(1).ToString("dddd")))
                End If
                '3月の祝日を格納しました
                sortList.Add(3, March)
            End If
            '四月の祝日
            If months = 4 And IsNothing(sortList(months)) Then
                If dates.Year >= 2007 Then
                    Dim April As New SortedList
                    '昭和の日
                    Dim showaDay = holiday.GetShowaDay(dates)
                    April.Add(showaDay.Day, New Holidays(showaDay, "昭和の日", showaDay.ToString("dddd")))
                    If Weekday(showaDay) = 1 Then
                        April.Add(showaDay.AddDays(1).Day, New Holidays(showaDay.AddDays(1), "振替休日", showaDay.AddDays(1).ToString("dddd")))
                    End If
                    '4月の祝日を格納しました
                    sortList.Add(4, April)
                End If
            End If
            '五月の祝日
            If months = 5 And IsNothing(sortList(months)) Then
                Dim May As New SortedList
                '天皇の即位の日
                If dates.Year = 2019 Then
                    Dim sokuiDay = New Date(2019, 5, 1)
                    May.Add(sokuiDay.Day, New Holidays(sokuiDay, "天皇の即位の日", sokuiDay.ToString("dddd")))
                    If Weekday(sokuiDay) = 1 Then
                        May.Add(sokuiDay.AddDays(1).Day, New Holidays(sokuiDay.AddDays(1), "振替休日", sokuiDay.AddDays(1).ToString("dddd")))
                    End If
                End If
                '憲法記念日
                Dim constitutionDay = holiday.GetConstitutionDay(dates)
                May.Add(constitutionDay.Day, New Holidays(constitutionDay, "憲法記念日", constitutionDay.ToString("dddd")))
                'みどりの日
                Dim greeneryDay = holiday.GetGreeneryDay(dates)
                May.Add(greeneryDay.Day, New Holidays(greeneryDay, "みどりの日", greeneryDay.ToString("dddd")))
                'こどもの日
                Dim childrenDay = holiday.GetChildrenDay(dates)
                May.Add(childrenDay.Day, New Holidays(childrenDay, "こどもの日", childrenDay.ToString("dddd")))
                If Weekday(constitutionDay) = 1 Then
                    May.Add(constitutionDay.AddDays(3).Day, New Holidays(constitutionDay.AddDays(3), "振替休日", constitutionDay.AddDays(1).ToString("dddd")))
                End If
                If Weekday(greeneryDay) = 1 Then
                    May.Add(greeneryDay.AddDays(2).Day, New Holidays(greeneryDay.AddDays(2), "振替休日", greeneryDay.AddDays(1).ToString("dddd")))
                End If
                If Weekday(childrenDay) = 1 Then
                    May.Add(childrenDay.AddDays(1).Day, New Holidays(childrenDay.AddDays(1), "振替休日", childrenDay.AddDays(1).ToString("dddd")))
                End If
                '5月の祝日を格納しました
                sortList.Add(5, May)
            End If
            '六月の祝日
            If months = 6 And IsNothing(sortList(months)) Then
                'Dim June As New SortedList
                '6月の祝日を格納しました
                'sortList.Add(6, June)
            End If
            '七月の祝日
            If months = 7 And IsNothing(sortList(months)) Then
                Dim July As New SortedList
                '海の日
                Dim oceanDay = holiday.GetOceanDay(dates)
                July.Add(oceanDay.Day, New Holidays(oceanDay, "海の日", oceanDay.ToString("dddd")))
                If Weekday(oceanDay) = 1 Then
                    July.Add(oceanDay.AddDays(1).Day, New Holidays(oceanDay.AddDays(1), "振替休日", oceanDay.AddDays(1).ToString("dddd")))
                End If
                'スポーツの日
                If dates.Year = 2020 Then
                    Dim sportsDay = New DateTime(2020, 7, 24)
                    July.Add(sportsDay.Day, New Holidays(sportsDay, "スポーツの日", sportsDay.ToString("dddd")))
                End If
                '7月の祝日を格納しました
                sortList.Add(7, July)
            End If
            '八月の祝日
            If months = 8 And IsNothing(sortList(months)) Then
                Dim August As New SortedList
                '山の日
                Dim mountainDay = holiday.GetMountainDay(dates)
                August.Add(mountainDay.Day, New Holidays(mountainDay, "山の日", mountainDay.ToString("dddd")))
                If Weekday(mountainDay) = 1 Then
                    August.Add(mountainDay.AddDays(1).Day, New Holidays(mountainDay.AddDays(1), "振替休日", mountainDay.AddDays(1).ToString("dddd")))
                End If
                '8月の祝日を格納しました
                sortList.Add(8, August)
            End If
            '九月の祝日
            If months = 9 And IsNothing(sortList(months)) Then
                Dim September As New SortedList
                '敬老の日
                Dim respectForAgedDay = holiday.GetRespectForAgedDay(dates)
                September.Add(respectForAgedDay.Day, New Holidays(respectForAgedDay, "敬老の日", respectForAgedDay.ToString("dddd")))
                If Weekday(respectForAgedDay) = 1 Then
                    September.Add(respectForAgedDay.AddDays(1).Day, New Holidays(respectForAgedDay.AddDays(1), "振替休日", respectForAgedDay.AddDays(2).ToString("dddd")))
                End If
                '秋分の日
                Dim autumEquinoxDay = holiday.GetAutumEquinoxDay(dates)
                September.Add(autumEquinoxDay.Day, New Holidays(autumEquinoxDay, "秋分の日", autumEquinoxDay.ToString("dddd")))
                If Weekday(autumEquinoxDay) = 1 Then
                    September.Add(autumEquinoxDay.AddDays(1).Day, New Holidays(autumEquinoxDay.AddDays(1), "振替休日", autumEquinoxDay.AddDays(1).ToString("dddd")))
                End If
                '9月の祝日を格納しました
                sortList.Add(9, September)
            End If
            '十月
            If months = 10 And IsNothing(sortList(months)) Then
                Dim October As New SortedList
                'スポーツの日
                If dates.Year <> "2020" Then
                    Dim sportsDay = holiday.GetSportsDay(dates)
                    October.Add(sportsDay.Day, New Holidays(sportsDay, "スポーツの日", sportsDay.ToString("dddd")))
                    If Weekday(sportsDay) = 1 Then
                        October.Add(sportsDay.AddDays(1).Day, New Holidays(sportsDay.AddDays(1), "振替休日", sportsDay.AddDays(1).ToString("dddd")))
                    End If
                End If
                '即位礼正殿の儀
                If dates.Year = 2019 Then
                    Dim sokuiDay = New Date(2019, 10, 22)
                    October.Add(sokuiDay.Day, New Holidays(sokuiDay, "即位礼正殿の儀", sokuiDay.ToString("dddd")))
                    If Weekday(sokuiDay) = 1 Then
                        October.Add(sokuiDay.AddDays(1).Day, New Holidays(sokuiDay.AddDays(1), "振替休日", sokuiDay.AddDays(1).ToString("dddd")))
                    End If
                End If
                '10月の祝日を格納しました
                sortList.Add(10, October)
            End If
            '十一月の祝日
            If months = 11 And IsNothing(sortList(months)) Then
                Dim November As New SortedList
                '文化の日
                Dim cultureDay = holiday.GetCultureDay(dates)
                November.Add(cultureDay.Day, New Holidays(cultureDay, "文化の日", cultureDay.ToString("dddd")))
                If Weekday(cultureDay) = 1 Then
                    November.Add(cultureDay.AddDays(1).Day, New Holidays(cultureDay.AddDays(1), "振替休日", cultureDay.AddDays(1).ToString("dddd")))
                End If
                '勤労感謝の日
                Dim laborThanksgivingDay = holiday.GetLaborThanksgivingDay(dates)
                November.Add(laborThanksgivingDay.Day, New Holidays(laborThanksgivingDay, "勤労感謝の日", laborThanksgivingDay.ToString("dddd")))
                If Weekday(laborThanksgivingDay) = 1 Then
                    November.Add(laborThanksgivingDay.AddDays(1).Day, New Holidays(laborThanksgivingDay.AddDays(1), "振替休日", laborThanksgivingDay.AddDays(1).ToString("dddd")))
                End If
                '11月の祝日を格納しました
                sortList.Add(11, November)
            End If
            '十二月のの祝日
            If months = 12 And IsNothing(sortList(months)) Then
                'Dim December As New SortedList
                '12月の祝日を格納しました
                'sortList.Add(12, December)
            End If
        Next
        Return sortList
    End Function
    ''' <summary>
    ''' 祝日以外の休日を設定します
    ''' </summary>
    ''' <param name="dates"></param>
    Public Sub AddHoliday(ByVal dates As DateTime)
        Dim holiday = New HolidayTools
        '今月は休日がある場合、直接にデータベースに挿入します
        If Not IsNothing(sortList(dates.Month)) Then
            If holiday.IsHoliday(dates) = "" Then
                sortList(dates.Month).Add(dates.Day, New Holidays(dates, "休日", dates.ToString("dddd")))
            End If
        Else
            '今月は休日がない場合、新たなlistを作る
            Dim newHoliday = New SortedList From {
                    {dates.Day, New Holidays(dates, "休日", dates.ToString("dddd"))}
                }
            sortList.Add(dates.Month, newHoliday)
        End If
        '休日を作成してデータベースに入力します
        AddHolidays(dates, "休日")
    End Sub
    ''' <summary>
    ''' 休日をキャンセルします
    ''' </summary>
    ''' <param name="dates"></param>
    Public Sub DeleteHoliday(ByVal dates As DateTime)
        If Not IsNothing(sortList(dates.Month)) And Not IsNothing(sortList(dates.Month)(dates.Day)) Then
            sortList(dates.Month).Remove(dates.Day)
            Dim s = DeleteHolidays(dates)
            If s > 0 Then
                MsgBox("成功")
            End If
        End If
    End Sub
    ''' <summary>
    ''' 祝日以外の休日を削除します
    ''' </summary>
    ''' <returns></returns>
    Public Function DeleteHolidays(ByVal dates As String) As Integer
        Dim sql = "delete from holidays where h_dates = ?"
        Return Tools.SetData(Login.conn, sql, dates)
    End Function
    ''' <summary>
    ''' 祝日以外の休日を追加します
    ''' </summary>
    ''' <returns></returns>
    Public Function AddHolidays(ByVal dates As String, ByVal description As String) As Integer
        Dim sql = "insert into holidays(h_dates,h_name) values(?,?)"
        Dim params As String() = {dates, description}
        Return Tools.SetData(Login.conn, sql, params)
    End Function
    ''' <summary>
    ''' 年月によってデータベースから祝日と休日を取得します
    ''' </summary>
    ''' <returns></returns>
    Public Function GetOtherHolidays(ByVal dates As String) As DataTable
        Dim sql = "select h_dates,h_name from holidays where h_dates like ? order by h_dates"
        Return Tools.GetData(Login.conn, sql, "%" & dates.Substring(0, 7) & "%")
    End Function
    ''' <summary>
    ''' 年月によってデータベースから祝日を取得します
    ''' </summary>
    ''' <param name="dates"></param>
    ''' <returns></returns>
    Public Function GetAllHolidays(ByVal dates As String) As DataTable
        Dim sql = "select h_dates,h_name from holidays where h_name <> '休日' and h_dates like ? order by h_dates"
        Return Tools.GetData(Login.conn, sql, "%" & dates.Substring(0, 7) & "%")
    End Function

    Public Sub SetAllHolidaysByYear(ByVal dates As DateTime)
        '年間休日を検出します
        Dim allHolidays = GetHolidaysCount(dates)
        '年間休日が存在しない場合、データベースに保存します
        If allHolidays.Rows.Count < 1 Then
            Dim calendarData = GetHoliday(dates)
            For Each dt In calendarData.Keys
                Dim holidayList As SortedList = calendarData(dt)
                For Each key In holidayList.Keys
                    Dim hday As Holidays = holidayList(key)
                    Dim sql = "insert into holidays(h_dates,h_name) values(?,?)"
                    Dim params As String() = {hday.Dates1, hday.Description1}
                    Tools.SetData(Login.conn, sql, params)
                Next
            Next
        End If
    End Sub
    ''' <summary>
    ''' 年によってデータベースから一年中の祝日を取得します
    ''' </summary>
    ''' <param name="dates"></param>
    ''' <returns></returns>
    Public Function GetHolidaysCount(ByVal dates As String) As DataTable
        Dim sql = "select h_id from holidays where h_name <> '休日' and h_dates like ? order by h_dates"
        Return Tools.GetData(Login.conn, sql, "%" & dates.Substring(0, 4) & "%")
    End Function

End Class
