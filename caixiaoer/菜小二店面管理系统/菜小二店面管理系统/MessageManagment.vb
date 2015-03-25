Public Class MessageManagment

    '标记目前工作的按钮
    Private BFlag(3) As Boolean

    Private Sub MessageManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mapload()
        MainMap()
    End Sub

    '

    '布局
    Private Sub Mapload()
        Me.BackColor = Color.White
        '返回按钮绘制
        back.Top = 0
        back.Left = 0
        back.Width = 125 * index.zoomHeight
        back.Height = 100 * index.zoomHeight
        index.LoadImage(back, "\SystemImg\", "back")
        '标题栏绘制
        head.Top = 0
        head.Left = back.Width + 5
        head.Width = index.ScreenWidth - 5 - back.Width
        head.Height = back.Height
        head.BackColor = Color.FromArgb(&HFF0099CB)
        head.Font = New System.Drawing.
            Font("微软雅黑", 46 * index.zoomHeight, System.Drawing.
                 FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        head.ForeColor = Color.White
        '管理员打印
        admin.Width = 266 * index.zoomHeight
        admin.Top = 20 * index.zoomHeight
        admin.Left = index.ScreenWidth - admin.Width
        admin.Height = 25 * index.zoomHeight
        admin.BackColor = head.BackColor
        admin.Font = New System.Drawing.
            Font("宋体", 16 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '现在时间显示
        NowTime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
        NowTime.Left = admin.Left
        NowTime.Top = admin.Top + admin.Height * 3 / 2
        NowTime.Height = admin.Height
        NowTime.Width = admin.Width
        NowTime.Font = admin.Font
        Nowtime.BackColor = head.BackColor
       
    End Sub

    '消息显示主页
    Private Sub MainMap()
        '绘制搜索按钮的背景
        searchback.Width = 450 * index.zoomHeight
        searchback.Height = 70 * index.zoomHeight
        searchback.Left = index.ScreenWidth - 30 * index.zoomHeight - searchback.Width
        searchback.Top = 50 * index.zoomHeight + head.Height
        searchback.BackColor = head.BackColor
        '搜索图片
        searchbutton.Left = 10 * index.zoomHeight + searchback.Left
        searchbutton.Width = 50 * index.zoomHeight
        searchbutton.Height = 50 * index.zoomHeight
        index.LoadImage(searchbutton, "\SystemImg\", "Search")
        searchbutton.Top = searchback.Top + 10 * index.zoomHeight
        '绘制“搜索”
        search.Height = 50 * index.zoomHeight
        search.Width = 100 * index.zoomHeight
        search.Top = 10 * index.zoomHeight + searchback.Top
        search.Left = searchback.Left + searchback.Width - search.Width
        search.Font = New System.Drawing.
            Font("宋体", 26 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        search.BackColor = searchback.BackColor
        search.ForeColor = Color.White
        '绘制输入框
        searchinput.Left = searchbutton.Left + searchbutton.Width + 1
        searchinput.Top = searchbutton.Top
        searchinput.Width = search.Left - searchinput.Left
        searchinput.Font = New System.Drawing.
            Font("宋体", 28 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '显示“新增”按钮
        AddMsg.Width = 80 * index.zoomHeight
        AddMsg.Height = search.Height
        AddMsg.Left = searchback.Left - AddMsg.Width - 40 * index.zoomHeight
        AddMsg.Top = search.Top
        AddMsg.BackColor = head.BackColor
        AddMsg.Font = New System.Drawing.
            Font("宋体", 20 * index.zoomHeight, System.Drawing.
                 FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                 CType(134, Byte))
        AddMsg.ForeColor = Color.White
        index.SetLableWin(AddMsg, 12)
        '关闭按钮
        MsgShut.Width = AddMsg.Width
        MsgShut.Height = AddMsg.Height
        MsgShut.Left = AddMsg.Left - 10 * index.zoomHeight - MsgShut.Width
        MsgShut.ForeColor = Color.White
        MsgShut.BackColor = AddMsg.BackColor
        MsgShut.Top = AddMsg.Top
        MsgShut.Font = AddMsg.Font
        index.SetLableWin(MsgShut, 12)
        '启用按钮
        startMsg.Width = MsgShut.Width
        startMsg.Height = MsgShut.Height
        startMsg.Top = MsgShut.Top
        startMsg.Left = MsgShut.Left - 10 * index.zoomHeight - MsgShut.Width
        startMsg.Font = MsgShut.Font
        startMsg.ForeColor = Color.White
        startMsg.BackColor = head.BackColor
        index.SetLableWin(startMsg, 12)
        '全部消息按钮
        allMsg.Width = 160 * index.zoomHeight
        allMsg.Height = startMsg.Height
        allMsg.Top = startMsg.Top
        allMsg.Left = startMsg.Left - 10 * index.zoomHeight - allMsg.Width
        allMsg.ForeColor = Color.White
        allMsg.BackColor = Color.FromArgb(&HFF006699)
        index.SetLableWin(allMsg, 12)
        allMsg.Font = MsgShut.Font
        BFlag(0) = True
    End Sub

    '隐藏主页显示的控件
    Private Sub HideMain()
        searchback.Hide()
        searchbutton.Hide()
        search.Hide()
        searchinput.Hide()
        AddMsg.Hide()
        MsgShut.Hide()
        startMsg.Hide()
        allMsg.Hide()
    End Sub

    '显示主页隐藏的控件
    Private Sub ShowMain()
        searchback.Show()
        searchbutton.Show()
        search.Show()
        searchinput.Show()
        AddMsg.Show()
        MsgShut.Show()
        startMsg.Show()
        allMsg.Show()
    End Sub

    '消息编辑布局



    '切换按钮的颜色
    Private Sub ChangeButtonColor(ByVal Flag As Integer)
        Dim Fg As Integer
        For i = 0 To 2
            If BFlag(i) = True Then
                If i = Flag Then
                    Exit Sub
                End If
                Fg = i
                BFlag(i) = False
            End If
        Next
        Select Case Fg
            Case 0
                allMsg.BackColor = head.BackColor
            Case 1
                startMsg.BackColor = head.BackColor
            Case 2
                MsgShut.BackColor = head.BackColor
        End Select
        Select Case Flag
            Case 0
                allMsg.BackColor = Color.FromArgb(&HFF006699)
                BFlag(0) = True
            Case 1
                startMsg.BackColor = Color.FromArgb(&HFF006699)
                BFlag(1) = True
            Case 2
                MsgShut.BackColor = Color.FromArgb(&HFF006699)
                BFlag(2) = True
        End Select
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles nowtimeupdater.Tick
        nowtime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
    End Sub


    Private Sub Search_MouseDown(sender As Object, e As EventArgs) Handles search.MouseDown
        search.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub Search_MouseUp(sender As Object, e As EventArgs) Handles search.MouseUp
        search.BackColor = head.BackColor
    End Sub

    Private Sub Addmsg_MouseDown(sender As Object, e As EventArgs) Handles AddMsg.MouseDown
        AddMsg.BackColor = Color.FromArgb(&HFF006699)
        HideMain()
    End Sub

    Private Sub Addmsg_MouseUp(sender As Object, e As EventArgs) Handles AddMsg.MouseUp
        AddMsg.BackColor = head.BackColor
    End Sub

    Private Sub allMsg_click(sender As Object, e As EventArgs) Handles allMsg.Click
        ChangeButtonColor(0)
    End Sub
    Private Sub startmsg_click(sender As Object, e As EventArgs) Handles startMsg.Click
        ChangeButtonColor(1)
    End Sub

    Private Sub msgshut_click(sender As Object, e As EventArgs) Handles MsgShut.Click
        ChangeButtonColor(2)
    End Sub
    '
    Private Sub back_click() Handles back.Click
        index.Show()
        Me.Hide()
    End Sub
End Class