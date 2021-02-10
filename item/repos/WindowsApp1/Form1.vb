Public Class Form1

    '最初の高さ
    Private metaH As Integer = Me.Height
    '最初の広さ
    Private metaW As Integer = Me.Width

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim mm As New MenuStrip
        'MainMenuStrip = mm
        'Dim it = MainMenuStrip.Items
        'it.Add("132")
        'MainMenuStrip.Items.Add("文件").Name = "mnuFile"
        'MainMenuStrip.Items.Add("编辑").Name = "mnuEdit"
        'MainMenu.DrawMode = DrawMode.OwnerDrawVariable

    End Sub

    Private Sub CtlResize(sender As Object, e As EventArgs) Handles MyBase.Resize
        '高さの比率
        Dim propH As Double = Me.Height / metaH
        '広さの比率
        Dim propW As Double = Me.Width / metaW

        For Each ctl As Control In Me.Controls

            '位置の変換
            ctl.Top *= propH
            ctl.Left *= propW
            'サイズの変換
            ctl.Height *= propH
            ctl.Width *= propW
        Next

        'MainMenu_Init()
    End Sub

    'Private tabArea As Rectangle
    'Private tabTextArea As RectangleF

    'Private Sub MainMenu_Init()
    '    For i = 0 To MainMenu.TabCount - 1
    '        '主要是做个转换来获得TAB项的RECTANGELF
    '        Dim tabArea As Rectangle = MainMenu.GetTabRect(i)
    '        Dim tabTextArea As RectangleF = RectangleF.op_Implicit(MainMenu.GetTabRect(i))

    '        g.

    '        '封装文本布局信息
    '        Dim sf = New StringFormat() With {
    '            .LineAlignment = StringAlignment.Center,
    '            .Alignment = StringAlignment.Center
    '        }

    '        '绘制边框的画笔
    '        Dim p As New Pen(Color.FromArgb(0, 0, 0, 0))
    '        Dim font As New Font("Arial", 10.0F)
    '        Dim brush As New SolidBrush(Color.Red)


    '        '绘制边框
    '        g.DrawRectangle(p, tabArea)

    '        '绘制文字
    '        'g.DrawString(CType(sender, TabControl).TabPages(e.Index).Text, Font, Brush, tabTextArea, sf)
    '        g.DrawString(MainMenu.TabPages(i).Text, font, brush, tabTextArea, sf)
    '    Next
    'End Sub

    Private Sub MainMenu_Init(sender As Object, e As DrawItemEventArgs) Handles MainMenu.DrawItem

        '主要是做个转换来获得TAB项的RECTANGELF
        Dim tabArea As Rectangle = MainMenu.GetTabRect(e.Index)
        Dim tabTextArea As RectangleF = RectangleF.op_Implicit(MainMenu.GetTabRect(e.Index))
        Dim g As Graphics = e.Graphics
        'Dim g As Graphics = MainMenu.CreateGraphics
        '封装文本布局信息
        Dim sf = New StringFormat() With {
                .LineAlignment = StringAlignment.Center,
                .Alignment = StringAlignment.Near
            }

        '绘制边框的画笔
        Dim p As New Pen(Color.FromArgb(0, 0, 0, 0))
        Dim font As New Font("Arial", 10.0F)
        Dim brush As New SolidBrush(Color.Black)
        'g.FillRectangle(New SolidBrush(Color.Black), tabTextArea)

        g.SmoothingMode = SmoothingMode

        '绘制边框
        g.DrawRectangle(p, tabArea)

        '绘制文字
        'g.DrawString(CType(sender, TabControl).TabPages(e.Index).Text, Font, Brush, tabTextArea, sf)
        g.DrawString(MainMenu.TabPages(e.Index).Text, font, brush, tabTextArea, sf)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
