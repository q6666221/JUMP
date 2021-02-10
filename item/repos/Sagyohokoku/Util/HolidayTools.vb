Public Class HolidayTools

    Public Function IsNewYearDay(ByVal wrk_day As Date) As Boolean

        '【元日】か否かを判定する（1949～

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        If wrk_day.Year >= 1949 _
            And wrk_day.Month = 1 And wrk_day.Day = 1 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function IsComingOfAgeDay(ByVal wrk_day As Date) As Boolean

        '【成人の日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '1月15日（1949～1999）

        If (wrk_day.Year >= 1949 _
            And wrk_day.Year <= 1999 _
            And wrk_day.Month = 1 And wrk_day.Day = 15) Then
            Return True
        End If

        '1月の第2月曜日（2000～）

        If wrk_day.Year >= 2000 _
            And wrk_day.Month = 1 Then

            Dim dt As Date
            dt = DateSerial(wrk_day.Year, wrk_day.Month, 1)
            If wrk_day = DateSerial(wrk_day.Year, wrk_day.Month, ((9 - (CInt(dt.DayOfWeek) + 1)) Mod 7) + 8) Then
                Return True
            Else
                Return False
            End If
        End If

        Return False

    End Function
    Public Function IsNationalFoundationDay(ByVal wrk_day As Date) As Boolean

        '【建国記念の日】か否かを判定する　(1967～)

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        If (wrk_day.Year >= 1967 _
            And wrk_day.Month = 2 And wrk_day.Day = 11) Then
            Return True
        End If

        Return False

    End Function
    Public Function IsSpringEquinoxDay(ByVal wrk_day As Date) As Boolean

        '【春分の日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '祝日法、昭和23年7月20日法律第178号

        If wrk_day.Year < 1949 Then
            Return False
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「0」の場合

        '西暦年数の4での剰余が「0」の場合で西暦年が1900年～1956年の時　3月21日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 1900 _
            And wrk_day.Year <= 1956 _
            And wrk_day.Month = 3 And wrk_day.Day = 21 Then
            Return True
        End If

        '西暦年数の4での剰余が「0」の場合で西暦年が1960年～2088年の時　3月20日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 1960 _
            And wrk_day.Year <= 2088 _
            And wrk_day.Month = 3 And wrk_day.Day = 20 Then
            Return True
        End If

        '西暦年数の4での剰余が「0」の場合で西暦年が2092年～2096年の時　3月19日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 2092 _
            And wrk_day.Year <= 2096 _
            And wrk_day.Month = 3 And wrk_day.Day = 20 Then
            Return True
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「1」の場合

        '西暦年数の4での剰余が「1」の場合で西暦年が1901年～1989年の時　3月21日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 1901 _
            And wrk_day.Year <= 1989 _
            And wrk_day.Month = 3 And wrk_day.Day = 21 Then
            Return True
        End If

        '西暦年数の4での剰余が「1」の場合で西暦年が1993年～2097年の時　3月20日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 1993 _
            And wrk_day.Year <= 2097 _
            And wrk_day.Month = 3 And wrk_day.Day = 20 Then
            Return True
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「2」の場合

        '西暦年数の4での剰余が「2」の場合で西暦年が1902年～2022年の時　3月21日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 1902 _
            And wrk_day.Year <= 2022 _
            And wrk_day.Month = 3 And wrk_day.Day = 21 Then
            Return True
        End If

        '西暦年数の4での剰余が「2」の場合で西暦年が2026年～2098年の時　3月20日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 2026 _
            And wrk_day.Year <= 2098 _
            And wrk_day.Month = 3 And wrk_day.Day = 20 Then
            Return True
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「3」の場合

        '西暦年数の4での剰余が「3」の場合で西暦年が1903年～1923年の時　3月22日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 1903 _
            And wrk_day.Year <= 1923 _
            And wrk_day.Month = 3 And wrk_day.Day = 22 Then
            Return True
        End If

        '西暦年数の4での剰余が「3」の場合で西暦年が1927年～2055年の時　3月21日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 1927 _
            And wrk_day.Year <= 2055 _
            And wrk_day.Month = 3 And wrk_day.Day = 21 Then
            Return True
        End If

        '西暦年数の4での剰余が「3」の場合で西暦年が2059年～2099年の時　3月20日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 2059 _
            And wrk_day.Year <= 2099 _
            And wrk_day.Month = 3 And wrk_day.Day = 20 Then
            Return True
        End If

        '---------------------------------------------------------------------------------------------

        Return False

    End Function
    Public Function IsShowaDay(ByVal wrk_day As Date) As Boolean

        '【昭和の日】か否かを判定する　(2007～)

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        If wrk_day.Year >= 2007 _
            And wrk_day.Month = 4 And wrk_day.Day = 29 Then
            Return True
        End If

        Return False

    End Function
    Public Function IsConstitutionDay(ByVal wrk_day As Date) As Boolean

        '【憲法記念日】か否かを判定する　(1949～)

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        If wrk_day.Year >= 1949 _
            And wrk_day.Month = 5 And wrk_day.Day = 3 Then
            Return True
        End If

        Return False

    End Function
    Public Function IsGreeneryDay(ByVal wrk_day As Date) As Boolean

        '【みどりの日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '4月29日　(1989～2006)

        If wrk_day.Year >= 1989 _
            And wrk_day.Year <= 2006 _
            And wrk_day.Month = 4 And wrk_day.Day = 29 Then
            Return True
        End If

        '5月4日　(2007～)

        If wrk_day.Year >= 2007 _
            And wrk_day.Month = 5 And wrk_day.Day = 4 Then
            Return True
        End If

        Return False

    End Function
    Public Function IsChildrenDay(ByVal wrk_day As Date) As Boolean

        '【こどもの日】か否かを判定する　(1949～)

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        If wrk_day.Year >= 1949 _
            And wrk_day.Month = 5 And wrk_day.Day = 5 Then
            Return True
        End If

        Return False

    End Function
    Public Function IsOceanDay(ByVal wrk_day As Date) As Boolean

        '【海の日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '2020年 の【海の日】は7月23日である

        If wrk_day.Year = 2020 _
            And wrk_day.Month = 7 And wrk_day.Day = 23 Then
            Return True
        End If

        '2020年 の【海の日】は7月20日（第３月曜日）ではない

        If wrk_day.Year = 2020 _
            And wrk_day.Month = 7 And wrk_day.Day = 20 Then
            Return False
        End If

        '2021年 の【海の日】は7月22日である

        If wrk_day.Year = 2021 _
            And wrk_day.Month = 7 And wrk_day.Day = 22 Then
            Return True
        End If

        '2021年 の【海の日】は7月19日（第３月曜日）ではない

        If wrk_day.Year = 2021 _
            And wrk_day.Month = 7 And wrk_day.Day = 19 Then
            Return False
        End If

        '7月20日（1996～2002）

        If wrk_day.Year >= 1996 _
            And wrk_day.Year <= 2002 _
            And wrk_day.Month = 7 And wrk_day.Day = 20 Then
            Return True
        End If

        '7月の第3月曜日（2003～）

        If (wrk_day.Year >= 2003 And wrk_day.Month = 7) Then
            Dim dt As Date
            dt = DateSerial(wrk_day.Year, wrk_day.Month, 1)
            If wrk_day = DateSerial(wrk_day.Year, wrk_day.Month, ((9 - (CInt(dt.DayOfWeek) + 1)) Mod 7) + 15) Then
                Return True
            End If
        End If

        Return False

    End Function
    Public Function IsMountainDay(ByVal wrk_day As Date) As Boolean

        '【山の日】か否かを判定する　(2016～)

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '2020年 の【山の日】は8月10日である

        If wrk_day.Year = 2020 _
            And wrk_day.Month = 8 And wrk_day.Day = 10 Then
            Return True
        End If

        '2020年 の【山の日】は8月11日ではない

        If wrk_day.Year = 2020 _
            And wrk_day.Month = 8 And wrk_day.Day = 11 Then
            Return False
        End If

        '2021年 の【山の日】は8月8日である

        If wrk_day.Year = 2021 _
            And wrk_day.Month = 8 And wrk_day.Day = 8 Then
            Return True
        End If

        '2021年 の【山の日】は8月11日ではない

        If wrk_day.Year = 2021 _
            And wrk_day.Month = 8 And wrk_day.Day = 11 Then
            Return False
        End If

        If wrk_day.Year >= 2016 _
            And wrk_day.Month = 8 And wrk_day.Day = 11 Then
            Return True
        End If

        Return False

    End Function
    Public Function IsRespectForAgedDay(ByVal wrk_day As Date) As Boolean

        '【敬老の日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '9月15日（1966～2002）

        If wrk_day.Year >= 1966 _
            And wrk_day.Year <= 2002 _
            And wrk_day.Month = 9 And wrk_day.Day = 15 Then
            Return True
        End If

        '9月の第3月曜日（2003～）

        If wrk_day.Year >= 2003 _
            And wrk_day.Month = 9 Then

            Dim dt As Date
            dt = DateSerial(wrk_day.Year, wrk_day.Month, 1)
            If wrk_day = DateSerial(wrk_day.Year, wrk_day.Month, ((9 - (CInt(dt.DayOfWeek) + 1)) Mod 7) + 15) Then
                Return True
            End If
        End If

        Return False

    End Function
    Public Function IsAutumEquinoxDay(ByVal wrk_day As Date) As Boolean

        '【秋分の日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '祝日法、昭和23年7月20日法律第178号

        If wrk_day.Year < 1948 Then
            Return False
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「0」の場合

        '西暦年数の4での剰余が「0」の場合で西暦年が1900年～2008年の時　9月23日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 1900 _
            And wrk_day.Year <= 2008 _
            And wrk_day.Month = 9 And wrk_day.Day = 23 Then
            Return True
        End If

        '西暦年数の4での剰余が「0」の場合で西暦年が2012年～2096年の時　9月22日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 2012 _
            And wrk_day.Year <= 2096 _
            And wrk_day.Month = 9 And wrk_day.Day = 22 Then
            Return True
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「1」の場合

        '西暦年数の4での剰余が「1」の場合で西暦年が1901年～1917年の時　9月24日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 1901 _
            And wrk_day.Year <= 1917 _
            And wrk_day.Month = 9 And wrk_day.Day = 24 Then
            Return True
        End If

        '西暦年数の4での剰余が「1」の場合で西暦年が1921年～2041年の時　9月23日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 1921 _
            And wrk_day.Year <= 2041 _
            And wrk_day.Month = 9 And wrk_day.Day = 23 Then
            Return True
        End If

        '西暦年数の4での剰余が「1」の場合で西暦年が2045年～2097年の時　9月22日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 2045 _
            And wrk_day.Year <= 2097 _
            And wrk_day.Month = 9 And wrk_day.Day = 22 Then
            Return True
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「2」の場合

        '西暦年数の4での剰余が「2」の場合で西暦年が1902年～1946年の時　9月24日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 1902 _
            And wrk_day.Year <= 1946 _
            And wrk_day.Month = 9 And wrk_day.Day = 24 Then
            Return True
        End If

        '西暦年数の4での剰余が「2」の場合で西暦年が1950年～2074年の時　9月23日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 1950 _
            And wrk_day.Year <= 2074 _
            And wrk_day.Month = 9 And wrk_day.Day = 23 Then
            Return True
        End If

        '西暦年数の4での剰余が「2」の場合で西暦年が2078年～2098年の時　9月22日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 2078 _
            And wrk_day.Year <= 2098 _
            And wrk_day.Month = 9 And wrk_day.Day = 22 Then
            Return True
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「3」の場合

        '西暦年数の4での剰余が「3」の場合で西暦年が1903年～1979年の時　9月24日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 1903 _
            And wrk_day.Year <= 1979 _
            And wrk_day.Month = 9 And wrk_day.Day = 24 Then
            Return True
        End If

        '西暦年数の4での剰余が「3」の場合で西暦年が1983年～2099年の時　9月23日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 1983 _
            And wrk_day.Year <= 2099 _
            And wrk_day.Month = 9 And wrk_day.Day = 23 Then
            Return True
        End If

        '---------------------------------------------------------------------------------------------

        Return False

    End Function
    Public Function IsSportsDay(ByVal wrk_day As Date) As Boolean

        '【スポーツの日（体育の日）】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '10月10日（1966～1999）

        If wrk_day.Year >= 1966 _
            And wrk_day.Year <= 1999 _
            And wrk_day.Month = 10 And wrk_day.Day = 10 Then
            Return True
        End If

        '2020年 の【スポーツの日】は7月24日である

        If wrk_day.Year = 2020 _
            And wrk_day.Month = 7 And wrk_day.Day = 24 Then
            Return True
        End If

        '2020年 の【スポーツの日】は10月12日でない

        If wrk_day.Year = 2020 _
            And wrk_day.Month = 10 And wrk_day.Day = 12 Then
            Return False
        End If

        '2021年 の【スポーツの日】は7月23日である

        If wrk_day.Year = 2021 _
            And wrk_day.Month = 7 And wrk_day.Day = 23 Then
            Return True
        End If

        '2021年 の【スポーツの日】は10月11日でない

        If wrk_day.Year = 2021 _
            And wrk_day.Month = 10 And wrk_day.Day = 11 Then
            Return False
        End If

        '10月の第2月曜日（2000～）

        If wrk_day.Year >= 2000 _
            And wrk_day.Month = 10 Then

            Dim dt As Date
            dt = DateSerial(wrk_day.Year, wrk_day.Month, 1)
            If wrk_day = DateSerial(wrk_day.Year, wrk_day.Month, ((9 - (CInt(dt.DayOfWeek) + 1)) Mod 7) + 8) Then
                Return True
            End If
        End If

        Return False

    End Function
    Public Function IsCultureDay(ByVal wrk_day As Date) As Boolean

        '【文化の日】か否かを判定する　(1948～)

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        If wrk_day.Year >= 1948 _
            And wrk_day.Month = 11 And wrk_day.Day = 3 Then
            Return True
        End If

        Return False

    End Function
    Public Function IsLaborThanksgivingDay(ByVal wrk_day As Date) As Boolean

        '【勤労感謝の日】か否かを判定する　(1948～)

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        If (wrk_day.Year >= 1948 _
            And wrk_day.Month = 11 And wrk_day.Day = 23) Then
            Return True
        End If

        Return False

    End Function
    Public Function IsEmperorBirthDay(ByVal wrk_day As Date) As Boolean

        '【天皇誕生日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '【昭和天皇誕生日】か否かを判定する　(1949～1989)

        If wrk_day.Year >= 1949 _
            And wrk_day.Year <= 1989 _
            And wrk_day.Month = 4 And wrk_day.Day = 29 Then
            Return True
        End If

        '【平成天皇誕生日】か否かを判定する　(1989～2018)

        If (wrk_day.Year >= 1989 _
            And wrk_day.Year <= 2018 _
            And wrk_day.Month = 12 And wrk_day.Day = 23) Then
            Return True
        End If

        '※　2019年は、天皇誕生日がない

        '【新天皇誕生日】か否かを判定する　(2020～)

        If (wrk_day.Year >= 2020 _
            And wrk_day.Month = 2 And wrk_day.Day = 23) Then
            Return True
        End If

        Return False

    End Function
    Public Function IsNationalHoliday(ByVal wrk_day As Date) As Boolean

        '【国民の休日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '【国民の休日】か否かを判定する　(1988～2008)
        '　5月4日

        If wrk_day.Year >= 1988 _
            And wrk_day.Year <= 2008 _
            And wrk_day.Month = 5 And wrk_day.Day = 4 Then
            Return True
        End If

        '【国民の休日】か否かを判定する　(2009～)

        '　9月21日が第3月曜日で　且つ　9月23日が秋分の日の時　(2009～）

        Dim dt21 As Date
        Dim dt23 As Date

        dt21 = DateSerial(wrk_day.Year, 9, 21)  '9月21日
        dt23 = DateSerial(wrk_day.Year, 9, 23)  '9月23日

        If wrk_day.Year >= 2009 _
            And wrk_day.Month = 9 And wrk_day.Day = 22 _
            And IsRespectForAgedDay(dt21) = True _
            And IsAutumEquinoxDay(dt23) = True Then
            Return True
        End If

        '【国民の休日】か否かを判定する　(2019)
        '　4月30日

        If wrk_day.Year = 2019 _
            And wrk_day.Month = 4 And wrk_day.Day = 30 Then
            Return True
        End If

        '【国民の休日】か否かを判定する　(2019)
        '　5月2日

        If wrk_day.Year = 2019 _
            And wrk_day.Month = 5 And wrk_day.Day = 2 Then
            Return True
        End If

        Return False

    End Function
    Public Function IsOtherHoliDay(ByVal wrk_day As Date) As Boolean

        '【その他の休日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '皇太子明仁親王の結婚の儀　1959/04/10

        If wrk_day = #1959/04/10# Then
            Return True
        End If

        '昭和天皇の大喪の礼　1989/02/24

        If wrk_day = #1989/02/24# Then
            Return True
        End If

        '即位礼正殿の儀　1990/11/12

        If wrk_day = #1990/11/12# Then
            Return True
        End If

        '皇太子徳仁親王の結婚の儀　1993/06/09

        If wrk_day = #1993/06/09# Then
            Return True
        End If

        '即位礼正殿の儀　2019/10/22

        If wrk_day = #2019/10/22# Then
            Return True
        End If

        Return False

    End Function

    Public Function IsAccessionDay(ByVal wrk_day As Date) As Boolean

        '【即位の日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return False
        End If

        '即位の日　2019/05/01

        If wrk_day = #2019/05/01# Then
            Return True
        End If

        Return False

    End Function

    Public Function GetSubstituteHoliday(ByVal wrk_day As Date) As Date

        '【振替休日】か否かを判定する

        '【国民の休日】か否かを判定する　(1973～)

        '元日で日曜日

        If wrk_day.Year >= 1973 And Weekday(wrk_day) = 1 And IsNewYearDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '成人の日(1/15)で日曜日　(1973～1999)

        If wrk_day.Year >= 1973 _
            And wrk_day.Year <= 1999 _
            And Weekday(wrk_day) = 1 _
            And IsComingOfAgeDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '建国記念の日で日曜日

        If wrk_day.Year >= 1973 _
            And Weekday(wrk_day) = 1 _
            And IsNationalFoundationDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '春分の日で日曜日

        If wrk_day.Year >= 1973 _
            And Weekday(wrk_day) = 1 _
            And IsSpringEquinoxDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '昭和の日で日曜日　'(2007～)

        If wrk_day.Year >= 2007 _
            And Weekday(wrk_day) = 1 _
            And IsShowaDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        'みどりの日(4/29)で日曜日　(1989～2006)

        If wrk_day.Year >= 1989 _
            And wrk_day.Year <= 2006 _
            And Weekday(wrk_day) = 1 _
            And IsGreeneryDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If
        'みどりの日(5/4)で日曜日　(2007～)

        If wrk_day.Year >= 2007 _
            And Weekday(wrk_day) = 1 _
            And IsGreeneryDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(2).Day)
        End If
        'こどもの日で日曜日　(2007～)

        If wrk_day.Year >= 2007 _
            And Weekday(wrk_day) = 1 _
            And IsChildrenDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '（※憲法記念日で日曜日）　(2007～)

        If wrk_day.Year >= 2007 _
            And Weekday(wrk_day) = 1 _
            And IsConstitutionDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(3).Day)
        End If

        '海の日(7/20)で日曜日　(1996～2002)

        If wrk_day.Year >= 1996 _
            And wrk_day.Year <= 2002 _
            And Weekday(wrk_day) = 1 _
            And IsOceanDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '山の日で日曜日　(2016～)

        If wrk_day.Year >= 2016 _
            And Weekday(wrk_day) = 1 _
            And IsMountainDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '敬老の日(9/15)で日曜日　(1973～2002)

        If wrk_day.Year >= 1973 _
            And wrk_day.Year <= 2002 _
            And Weekday(wrk_day) = 1 _
            And IsRespectForAgedDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '秋分の日で日曜日

        If wrk_day.Year >= 1973 _
            And Weekday(wrk_day) = 1 _
            And IsAutumEquinoxDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '体育の日で日曜日

        If wrk_day.Year >= 1973 _
            And wrk_day.Year <= 1999 _
            And Weekday(wrk_day) = 1 _
            And IsSportsDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '文化の日で日曜日

        If wrk_day.Year >= 1973 _
            And Weekday(wrk_day) = 1 _
            And IsCultureDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '勤労感謝の日で日曜日

        If wrk_day.Year >= 1973 _
            And Weekday(wrk_day) = 1 _
            And IsLaborThanksgivingDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If

        '天皇誕生日で日曜日

        If wrk_day.Year >= 1973 _
            And Weekday(wrk_day) = 1 _
            And IsEmperorBirthDay(wrk_day) = True Then
            Return DateSerial(wrk_day.Year, wrk_day.Month, wrk_day.AddDays(1).Day)
        End If


    End Function
    Public Function IsHoliday(ByVal wrk_day As Date) As String

        '【祝日・休日】か否かを判定する

        '日付?

        If IsDate(wrk_day) = False Then
            Return ""
        End If

        '祝日法、昭和23年7月20日法律第178号

        If wrk_day.Year < 1948 Then
            Return ""
        End If

        '元日

        If IsNewYearDay(wrk_day) = True Then
            Return "元日"
        End If

        '成人の日

        If IsComingOfAgeDay(wrk_day) = True Then
            Return "成人の日"
        End If

        '建国記念日

        If IsNationalFoundationDay(wrk_day) = True Then
            Return "建国記念日"
        End If

        '春分の日

        If IsSpringEquinoxDay(wrk_day) = True Then
            Return "春分の日"
        End If

        '昭和の日

        If IsShowaDay(wrk_day) = True Then
            Return "昭和の日"
        End If

        '憲法記念日

        If IsConstitutionDay(wrk_day) = True Then
            Return "憲法記念日"
        End If

        'みどりの日

        If IsGreeneryDay(wrk_day) = True Then
            Return "みどりの日"
        End If

        'こどもの日

        If IsChildrenDay(wrk_day) = True Then
            Return "こどもの日"
        End If

        '海の日

        If IsOceanDay(wrk_day) = True Then
            Return "海の日"
        End If

        '山の日

        If IsMountainDay(wrk_day) = True Then
            Return "山の日"
        End If

        '敬老の日

        If IsRespectForAgedDay(wrk_day) = True Then
            Return "敬老の日"
        End If

        '秋分の日

        If IsAutumEquinoxDay(wrk_day) = True Then
            Return "秋分の日"
        End If

        'スポーツの日（体育の日）

        If IsSportsDay(wrk_day) = True And wrk_day.Year < 2020 Then
            Return "体育の日"
        End If

        If IsSportsDay(wrk_day) = True And wrk_day.Year >= 2020 Then
            Return "スポーツの日"
        End If

        '文化の日

        If IsCultureDay(wrk_day) = True Then
            Return "文化の日"
        End If

        '勤労感謝の日

        If IsLaborThanksgivingDay(wrk_day) = True Then
            Return "勤労感謝の日"
        End If

        '天皇誕生日

        If IsEmperorBirthDay(wrk_day) = True Then
            Return "天皇誕生日"
        End If

        '即位の日

        If IsAccessionDay(wrk_day) = True Then
            Return "即位の日"
        End If

        '国民の休日

        If IsNationalHoliday(wrk_day) = True Then
            Return "国民の休日"
        End If

        'その他の休日

        If IsOtherHoliDay(wrk_day) = True Then
            Return "その他の休日"
        End If

        '振替休日

        Return ""

    End Function
    Public Function GetNewYearDay(ByVal wrk_day As Date) As Date

        '【元日】を取得する（1949～
        Return DateSerial(wrk_day.Year, 1, 1)
    End Function
    Public Function GetSpringEquinoxDay(ByVal wrk_day As Date) As Date

        '【春分の日】を取得する

        '日付 1949年以降

        If wrk_day.Year < 1949 Then
            Return wrk_day
        End If
        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「0」の場合

        '西暦年数の4での剰余が「0」の場合で西暦年が1900年～1956年の時　3月21日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 1900 _
            And wrk_day.Year <= 1956 Then
            Return DateSerial(wrk_day.Year, 3, 21)
        End If

        '西暦年数の4での剰余が「0」の場合で西暦年が1960年～2088年の時　3月20日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 1960 _
            And wrk_day.Year <= 2088 Then
            Return DateSerial(wrk_day.Year, 3, 20)
        End If

        '西暦年数の4での剰余が「0」の場合で西暦年が2092年～2096年の時　3月19日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 2092 _
            And wrk_day.Year <= 2096 Then
            Return DateSerial(wrk_day.Year, 3, 19)
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「1」の場合

        '西暦年数の4での剰余が「1」の場合で西暦年が1901年～1989年の時　3月21日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 1901 _
            And wrk_day.Year <= 1989 Then
            Return DateSerial(wrk_day.Year, 3, 21)
        End If

        '西暦年数の4での剰余が「1」の場合で西暦年が1993年～2097年の時　3月20日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 1993 _
            And wrk_day.Year <= 2097 Then
            Return DateSerial(wrk_day.Year, 3, 20)
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「2」の場合

        '西暦年数の4での剰余が「2」の場合で西暦年が1902年～2022年の時　3月21日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 1902 _
            And wrk_day.Year <= 2022 Then
            Return DateSerial(wrk_day.Year, 3, 21)
        End If

        '西暦年数の4での剰余が「2」の場合で西暦年が2026年～2098年の時　3月20日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 2026 And wrk_day.Year <= 2098 Then
            Return DateSerial(wrk_day.Year, 3, 20)
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「3」の場合

        '西暦年数の4での剰余が「3」の場合で西暦年が1903年～1923年の時　3月22日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 1903 _
            And wrk_day.Year <= 1923 Then
            Return DateSerial(wrk_day.Year, 3, 221)
        End If

        '西暦年数の4での剰余が「3」の場合で西暦年が1927年～2055年の時　3月21日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 1927 _
            And wrk_day.Year <= 2055 Then
            Return DateSerial(wrk_day.Year, 3, 21)
        End If

        '西暦年数の4での剰余が「3」の場合で西暦年が2059年～2099年の時　3月20日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 2059 _
            And wrk_day.Year <= 2099 Then
            Return DateSerial(wrk_day.Year, 3, 20)
        End If

        '---------------------------------------------------------------------------------------------

        Return wrk_day

    End Function
    Public Function GetAutumEquinoxDay(ByVal wrk_day As Date) As Date

        '【秋分の日】を取得する

        '日付 1948年以降

        If wrk_day.Year < 1948 Then
            Return wrk_day
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「0」の場合

        '西暦年数の4での剰余が「0」の場合で西暦年が1900年～2008年の時　9月23日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 1900 _
            And wrk_day.Year <= 2008 Then
            Return DateSerial(wrk_day.Year, 9, 23)
        End If

        '西暦年数の4での剰余が「0」の場合で西暦年が2012年～2096年の時　9月22日

        If wrk_day.Year Mod 4 = 0 _
            And wrk_day.Year >= 2012 _
            And wrk_day.Year <= 2096 Then
            Return DateSerial(wrk_day.Year, 9, 22)
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「1」の場合

        '西暦年数の4での剰余が「1」の場合で西暦年が1901年～1917年の時　9月24日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 1901 _
            And wrk_day.Year <= 1917 Then
            Return DateSerial(wrk_day.Year, 9, 24)
        End If

        '西暦年数の4での剰余が「1」の場合で西暦年が1921年～2041年の時　9月23日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 1921 _
            And wrk_day.Year <= 2041 Then
            Return DateSerial(wrk_day.Year, 9, 23)
        End If

        '西暦年数の4での剰余が「1」の場合で西暦年が2045年～2097年の時　9月22日

        If wrk_day.Year Mod 4 = 1 _
            And wrk_day.Year >= 2045 _
            And wrk_day.Year <= 2097 Then
            Return DateSerial(wrk_day.Year, 9, 22)
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「2」の場合

        '西暦年数の4での剰余が「2」の場合で西暦年が1902年～1946年の時　9月24日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 1902 _
            And wrk_day.Year <= 1946 Then
            Return DateSerial(wrk_day.Year, 9, 24)
        End If

        '西暦年数の4での剰余が「2」の場合で西暦年が1950年～2074年の時　9月23日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 1950 _
            And wrk_day.Year <= 2074 Then
            Return DateSerial(wrk_day.Year, 9, 23)
        End If

        '西暦年数の4での剰余が「2」の場合で西暦年が2078年～2098年の時　9月22日

        If wrk_day.Year Mod 4 = 2 _
            And wrk_day.Year >= 2078 _
            And wrk_day.Year <= 2098 Then
            Return DateSerial(wrk_day.Year, 9, 22)
        End If

        '---------------------------------------------------------------------------------------------

        '西暦年数の4での剰余が「3」の場合

        '西暦年数の4での剰余が「3」の場合で西暦年が1903年～1979年の時　9月24日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 1903 _
            And wrk_day.Year <= 1979 Then
            Return DateSerial(wrk_day.Year, 9, 24)
        End If

        '西暦年数の4での剰余が「3」の場合で西暦年が1983年～2099年の時　9月23日

        If wrk_day.Year Mod 4 = 3 _
            And wrk_day.Year >= 1983 _
            And wrk_day.Year <= 2099 Then
            Return DateSerial(wrk_day.Year, 9, 23)
        End If

        '---------------------------------------------------------------------------------------------

        Return wrk_day

    End Function
    Public Function GetComingOfAgeDay(ByVal wrk_day As Date) As Date

        '【成人の日】を取得する

        '日付?

        If IsDate(wrk_day) = False Then
            Return wrk_day
        End If

        '1月15日（1949～1999）

        If wrk_day.Year >= 1949 _
            And wrk_day.Year <= 1999 Then
            Return DateSerial(wrk_day.Year, 1, 15)
        End If

        '1月の第2月曜日（2000～）

        If wrk_day.Year >= 2000 Then

            Dim dt As Date

            dt = DateSerial(wrk_day.Year, 1, 1)
            Return DateSerial(wrk_day.Year, 1, ((9 - (CInt(dt.DayOfWeek) + 1)) Mod 7) + 8)

        End If

        Return wrk_day

    End Function
    Public Function GetNationalFoundationDay(ByVal wrk_day As Date) As Date

        '【建国記念の日】を取得する　(1967～)
        Return DateSerial(wrk_day.Year, 2, 11)
    End Function
    Public Function GetShowaDay(ByVal wrk_day As Date) As Date

        '【昭和の日】を取得する　(2007～)

        If wrk_day.Year >= 2007 Then
            Return DateSerial(wrk_day.Year, 4, 29)
        End If
        Return wrk_day
    End Function
    Public Function GetConstitutionDay(ByVal wrk_day As Date) As Date

        '【憲法記念日】を取得する　(1949～)
        Return DateSerial(wrk_day.Year, 5, 3)
    End Function
    Public Function GetGreeneryDay(ByVal wrk_day As Date) As Date

        '【みどりの日】を取得する

        '4月29日　(1989～2006)

        If wrk_day.Year >= 1989 And wrk_day.Year <= 2006 Then
            Return DateSerial(wrk_day.Year, 4, 29)
        End If

        '5月4日　(2007～)

        If wrk_day.Year >= 2007 Then
            Return DateSerial(wrk_day.Year, 5, 4)
        End If
        Return DateSerial(wrk_day.Year, 5, 4)

    End Function
    Public Function GetChildrenDay(ByVal wrk_day As Date) As Date

        '【こどもの日】を取得する　(1949～)
        Return DateSerial(wrk_day.Year, 5, 5)
    End Function
    Public Function GetOceanDay(ByVal wrk_day As Date) As Date

        '【海の日】を取得する

        '日付?

        If IsDate(wrk_day) = False Then
            Return wrk_day
        End If

        '2020年 の【海の日】は7月23日である

        If wrk_day.Year = 2020 Then
            Return DateSerial(wrk_day.Year, 7, 23)
        End If

        '2021年 の【海の日】は7月22日である

        If wrk_day.Year = 2021 Then
            Return DateSerial(wrk_day.Year, 7, 22)
        End If

        '7月20日（1996～2002）

        If wrk_day.Year >= 1996 _
            And wrk_day.Year <= 2002 Then
            Return DateSerial(wrk_day.Year, 7, 20)
        End If

        '7月の第3月曜日（2003～）

        If wrk_day.Year >= 2003 Then

            Dim dt As Date

            dt = DateSerial(wrk_day.Year, 7, 1)
            Return DateSerial(wrk_day.Year, 7, ((9 - (CInt(dt.DayOfWeek) + 1)) Mod 7) + 15)

        End If

        Return wrk_day

    End Function
    Public Function GetMountainDay(ByVal wrk_day As Date) As Date

        '【山の日】を取得する

        '日付?

        If IsDate(wrk_day) = False Then
            Return wrk_day
        End If

        '2020年 の【山の日】は8月10日である

        If wrk_day.Year = 2020 Then
            Return DateSerial(wrk_day.Year, 8, 10)
        End If

        '2021年 の【山の日】は8月8日である

        If wrk_day.Year = 2021 Then
            Return DateSerial(wrk_day.Year, 8, 8)
        End If

        '8月11日（2016～）

        If wrk_day.Year >= 2016 Then
            Return DateSerial(wrk_day.Year, 8, 11)
        End If

        Return wrk_day

    End Function

    Public Function GetRespectForAgedDay(ByVal wrk_day As Date) As Date

        '【敬老の日】を取得する

        '日付?

        If IsDate(wrk_day) = False Then
            Return wrk_day
        End If

        '9月15日（1966～2002）

        If wrk_day.Year >= 1966 _
            And wrk_day.Year <= 2002 Then
            Return DateSerial(wrk_day.Year, 9, 15)
        End If

        '9月の第3月曜日（2003～）

        If wrk_day.Year >= 2003 Then

            Dim dt As Date

            dt = DateSerial(wrk_day.Year, 9, 1)

            Return DateSerial(wrk_day.Year, 9, ((9 - (CInt(dt.DayOfWeek) + 1)) Mod 7) + 15)

        End If

        Return wrk_day

    End Function
    Public Function GetCultureDay(ByVal wrk_day As Date) As Date

        '【文化の日】か否かを判定する　(1948～)
        Return DateSerial(wrk_day.Year, 11, 3)
    End Function
    Public Function GetLaborThanksgivingDay(ByVal wrk_day As Date) As Date

        '【勤労感謝の日】か否かを判定する　(1948～)
        Return DateSerial(wrk_day.Year, 11, 23)
    End Function
    Public Function GetSportsDay(ByVal wrk_day As Date) As Date

        '【スポーツの日（体育の日）】を取得する

        '日付?

        If IsDate(wrk_day) = False Then
            Return wrk_day
        End If

        '10月10日（1966～1999）

        If wrk_day.Year >= 1966 _
            And wrk_day.Year <= 1999 Then
            Return DateSerial(wrk_day.Year, 10, 10)
        End If

        '2020年 の【スポーツの日】は7月24日である

        If wrk_day.Year = 2020 Then
            Return DateSerial(wrk_day.Year, 7, 24)
        End If

        '2021年 の【スポーツの日】は7月23日である

        If wrk_day.Year = 2021 Then
            Return DateSerial(wrk_day.Year, 7, 23)
        End If

        '10月の第2月曜日（2000～）

        If wrk_day.Year >= 2000 Then

            Dim dt As Date

            dt = DateSerial(wrk_day.Year, 10, 1)

            Return DateSerial(wrk_day.Year, 10, ((9 - (CInt(dt.DayOfWeek) + 1)) Mod 7) + 8)

        End If

        Return wrk_day

    End Function
End Class