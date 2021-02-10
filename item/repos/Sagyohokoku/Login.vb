Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class Login

    ''' <summary>
    ''' データベースの接続
    ''' </summary>
    Public conn As SqlConnection

    ''' <summary>
    ''' データベースへの接続の初期化
    ''' </summary>
    Private Sub Init()
        Dim curDir = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath))
        Dim path = curDir & "\Config\Connection-config.xml"
        Dim xmlReader = New System.Xml.XmlDocument
        xmlReader.Load(path)
        Dim str = xmlReader.GetElementsByTagName("name")(0).InnerText
        conn = New SqlConnection With {
            .ConnectionString = str
        }
        conn.Open()
    End Sub

    'マウスポインターがボタンに乗った背景色を変える
    Private Sub CloseButton_MouseMove(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.MouseHover

        CloseButton.BackColor = Color.FromArgb(250, 81, 81)

    End Sub
    Private Sub CloseButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.MouseLeave

        CloseButton.BackColor = Color.WhiteSmoke

    End Sub
    'マウスポインターがボタンから外れた背景色を変える

    Private Const CS_DROPSHADOW As Integer = &H20000
    Private Const GCL_STYLE As Integer = (-26)
    Public Declare Function SetClassLong Lib "user32" Alias "SetClassLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Public Declare Function GetClassLong Lib "user32" Alias "GetClassLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer

    ''' <summary>
    ''' ログインのロード
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'shadow
        SetClassLong(Me.Handle, GCL_STYLE, GetClassLong(Me.Handle, GCL_STYLE) Or CS_DROPSHADOW)
        Init()
        MessageInit()
        Me.KeyPreview = True
    End Sub

    ''' <summary>
    ''' エンターキーをクリックした場合、ログイン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginButton_Click(sender, e)
        End If
    End Sub

    ''' <summary>
    ''' ログイン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'ログインメッセージの取得
        Dim pass = Password.Text
        Dim e_id = Employee.SelectedValue.ToString
        Dim sql = "select u_id,m_id,p_id,seal,create_time from employees where e_id = ? and e_password = ?"
        Dim table = Tools.GetData(conn, sql, e_id, pass)

        '社員情報を取り出す
        If table.Rows.Count > 0 Then
            Dim sql1 = "select u_name from users where u_id = ?"
            Dim table1 = Tools.GetData(conn, sql1, table.Rows(0).Field(Of Integer)("u_id"))
            Dim employee = New Employees
            With employee
                .d_id = Me.Department.SelectedValue.ToString
                .e_name = Me.Employee.Text
                .e_id = Me.Employee.SelectedValue.ToString
                .u_id = table.Rows(0).Field(Of Integer)("u_id")
                '.u_name = table1.Rows(0).Field(Of String)("u_name")
                .m_id = table.Rows(0).Field(Of Integer)("m_id")
                .p_id = table.Rows(0).Field(Of Integer)("p_id")
                .seal_local = table.Rows(0).Field(Of String)("seal")
                .create_time = table.Rows(0).Field(Of String)("create_time")
            End With
            Dim home = New Home(employee)
            'Dim home = New Home
            Me.Hide()
            home.Show()
        Else
            MessageBox.Show("アカウントかパスワードは間違いです！")
        End If
    End Sub

    ''' <summary>
    ''' フォームを閉じる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub


    ''' <summary>
    ''' インフォメーションの初期化
    ''' </summary>
    Private Sub MessageInit()
        Dim sql = "select c_name,c_id from companys"
        Dim table = Tools.GetData(conn, sql)
        Company.DisplayMember = "c_name"
        Company.ValueMember = "c_id"
        Company.DataSource = table
        Company.SelectedIndex = 1
        Department.SelectedIndex = 2
    End Sub

    ''' <summary>
    ''' 所属部署の取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Company_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Company.SelectedIndexChanged
        Dim sql = "select d_name,d_id from departments where c_id = ?"
        Dim table = Tools.GetData(conn, sql, Company.SelectedValue.ToString)
        Department.DisplayMember = "d_name"
        Department.ValueMember = "d_id"
        Department.DataSource = table
    End Sub

    ''' <summary>
    ''' 所属会社の取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Department.SelectedIndexChanged
        Dim sql = "select e_name,e_id from employees where d_id = ?"
        Dim table = Tools.GetData(conn, sql, Department.SelectedValue.ToString)
        Employee.DisplayMember = "e_name"
        Employee.ValueMember = "e_id"
        Employee.DataSource = table
    End Sub

#Region "フォームの移動について"
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Boolean
    Public Declare Function ReleaseCapture Lib "user32" Alias "ReleaseCapture" () As Boolean
    Public Const WM_SYSCOMMAND = &H112
    Public Const SC_MOVE = &HF010&
    Public Const HTCAPTION = 2
    Private Sub Drag_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles Me.MouseDown
        ReleaseCapture()

        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)

    End Sub

#End Region

End Class