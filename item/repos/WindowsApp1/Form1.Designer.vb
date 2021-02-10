<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ReportConfirm = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MainMenu = New System.Windows.Forms.TabControl()
        Me.n2 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ReportConfirm.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportConfirm
        '
        Me.ReportConfirm.Controls.Add(Me.TabPage1)
        Me.ReportConfirm.Controls.Add(Me.TabPage2)
        Me.ReportConfirm.Controls.Add(Me.TabPage3)
        Me.ReportConfirm.Location = New System.Drawing.Point(0, -4)
        Me.ReportConfirm.Name = "ReportConfirm"
        Me.ReportConfirm.SelectedIndex = 0
        Me.ReportConfirm.Size = New System.Drawing.Size(160, 461)
        Me.ReportConfirm.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(152, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "未"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(175, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "済"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(175, 435)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "差戻し"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.MainMenu.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.MainMenu.Controls.Add(Me.n2)
        Me.MainMenu.Controls.Add(Me.TabPage4)
        Me.MainMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MainMenu.ItemSize = New System.Drawing.Size(30, 100)
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.MainMenu.Multiline = True
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Padding = New System.Drawing.Point(0, 0)
        Me.MainMenu.SelectedIndex = 0
        Me.MainMenu.Size = New System.Drawing.Size(264, 461)
        Me.MainMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MainMenu.TabIndex = 1
        '
        'n2
        '
        Me.n2.Location = New System.Drawing.Point(104, 4)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(179, 453)
        Me.n2.TabIndex = 1
        Me.n2.Text = "123"
        Me.n2.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportConfirm)
        Me.TabPage4.Location = New System.Drawing.Point(104, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(156, 453)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.MainMenu)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ReportConfirm.ResumeLayout(False)
        Me.MainMenu.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportConfirm As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents MainMenu As TabControl
    Friend WithEvents n2 As TabPage
    Friend WithEvents TabPage4 As TabPage
End Class
