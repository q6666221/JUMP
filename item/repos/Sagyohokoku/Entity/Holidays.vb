Public Class Holidays
    '祝日の時間
    Private Dates As DateTime
    '祝日の名前
    Private Description As String
    '祝日の曜日
    Private Weeks As String
    Public Sub New(dates As DateTime, description As String, weeks As String)
        Me.Dates1 = dates
        Me.Description1 = description
        Me.Weeks1 = weeks
    End Sub

    Public Property Dates1 As DateTime
        Get
            Return Dates
        End Get
        Set(value As DateTime)
            Dates = value
        End Set
    End Property

    Public Property Description1 As String
        Get
            Return Description
        End Get
        Set(value As String)
            Description = value
        End Set
    End Property

    Public Property Weeks1 As String
        Get
            Return Weeks
        End Get
        Set(value As String)
            Weeks = value
        End Set
    End Property
End Class
