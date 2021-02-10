''' <summary>
''' 社員情報
''' </summary>
Public Class Employees
    ''' <summary>
    ''' 氏名
    ''' </summary>
    Public e_name As String
    ''' <summary>
    ''' 社員主キー
    ''' </summary>
    Public e_id As String
    ''' <summary>
    ''' 現場主キー
    ''' </summary>
    Public u_id As String
    ''' <summary>
    ''' 所属部署主キー
    ''' </summary>
    Public d_id As String
    ''' <summary>
    ''' リーダー主キー
    ''' </summary>
    Public m_id As String
    ''' <summary>
    ''' 職位主キー
    ''' </summary>
    Public p_id As String
    ''' <summary>
    ''' 印鑑イメージのパス
    ''' </summary>
    Public seal_local As String
    ''' <summary>
    ''' 入社時間
    ''' </summary>
    Public create_time As String
End Class
