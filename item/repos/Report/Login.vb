Imports System.Data.SqlClient

Public Class Login
    Private Sub Init()
        'Dim date1 As New DateTime
        'MessageBox.Show(date1)
        'Dim date2 As Date = CDate(date1.ToString)
        'Dim str1 = "1:12"
        'Dim ts As TimeSpan
        'TimeSpan.TryParse(str1, ts)
        'Dim str2 = ""
        'TimeSpan.TryParse(str2, ts)
        'MessageBox.Show(ts.ToString)
        'MessageBox.Show(ts.ToString)
        'MessageBox.Show(date2.ToString)
        'Dim type1 As String = "123"
        'MessageBox.Show(type1.GetType.Name)
        'Dim num As Double = 0
        'MessageBox.Show(num)
        'Dim times As New TimeSpan(3000, 12, 13)
        'MessageBox.Show(times.TotalHours)
        'Dim [long] As Long = times.Ticks
        'MessageBox.Show([long])
        'MessageBox.Show(New TimeSpan(123455L).ToString)
        Dim curDir = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath))
        Dim path = curDir & "\Resources\Config\Connection-config.xml"
        Dim xmlReader = New System.Xml.XmlDocument
        xmlReader.Load(path)
        Dim str = xmlReader.GetElementsByTagName("name")(0).InnerText
        conn = New SqlConnection With {
            .ConnectionString = str
        }
        conn.Open()
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim pass = Password.Text
        Dim e_id = Employee.SelectedValue.ToString
        Dim sql = "select u_id,m_id,p_id,seal from employees where e_id = ? and e_password = ?"
        Dim table = Tools.GetData(sql, conn, e_id, pass)

        If table.Rows.Count > 0 Then
            Dim sql1 = "select u_name from users where u_id = ?"
            Dim table1 = Tools.GetData(sql1, conn, table.Rows(0).Field(Of Integer)("u_id"))
            Dim employee = New Employees
            With employee
                .c_name = Me.Company.Text
                .c_id = Me.Company.SelectedValue.ToString
                .d_name = Me.Department.Text
                .d_id = Me.Department.SelectedValue.ToString
                .e_name = Me.Employee.Text
                .e_id = Me.Employee.SelectedValue.ToString
                .u_id = table.Rows(0).Field(Of Integer)("u_id")
                .u_name = table1.Rows(0).Field(Of String)("u_name")
                .m_id = table.Rows(0).Field(Of Integer)("m_id")
                .p_id = table.Rows(0).Field(Of Integer)("p_id")
                .seal_local = table.Rows(0).Field(Of String)("seal")
            End With
            Dim home = New Home(employee, conn)
            home.Show()

        End If
    End Sub

    'Private Sub GetReports(employee As Employees)
    '    Dim sql = "select r_id,total_worktime,overtime,important_content
    '                from reports_detail where e_id = ? and r_date = ?"
    '    Dim table = Tools.GetData(sql, conn, Me.Employee.SelectedValue.ToString
    '                              ,)
    'End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        MessageInit()
    End Sub


    Private Sub MessageInit()
        Dim sql = "select c_name,c_id from companys"
        Dim table = Tools.GetData(sql, conn)
        Company.DisplayMember = "c_name"
        Company.ValueMember = "c_id"
        Company.DataSource = table
        Company.SelectedIndex = 1
        Department.SelectedIndex = 2
    End Sub

    Private Sub Company_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Company.SelectedIndexChanged
        Dim sql = "select d_name,d_id from departments where c_id = ?"
        Dim table = Tools.GetData(sql, conn, Company.SelectedValue.ToString)
        Department.DisplayMember = "d_name"
        Department.ValueMember = "d_id"
        Department.DataSource = table
    End Sub

    Private Sub Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Department.SelectedIndexChanged
        Dim sql = "select e_name,e_id from employees where d_id = ?"
        Dim table = Tools.GetData(sql, conn, Department.SelectedValue.ToString)
        Employee.DisplayMember = "e_name"
        Employee.ValueMember = "e_id"
        Employee.DataSource = table
    End Sub

    Friend WithEvents conn As SqlConnection
End Class