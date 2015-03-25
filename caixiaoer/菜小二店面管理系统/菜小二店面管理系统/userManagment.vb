Public Class userManagment

    '目前工作按钮标记
    Private BFlag(4) As Boolean
    Private Sub userManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MapLoad()
        Vipcharge(1)
    End Sub
    '布局
    Private Sub MapLoad()
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
        '绘制搜索按钮的背景
        searchback.Width = 450 * index.zoomHeight
        searchback.Height = 70 * index.zoomHeight
        searchback.Left = index.ScreenWidth - 30 * index.zoomHeight - searchback.Width
        searchback.Top = 50 * index.zoomHeight + head.Height
        searchback.BackColor = head.BackColor
        '搜索图片
        searchButton.Left = 10 * index.zoomHeight + searchback.Left
        searchButton.Width = 50 * index.zoomHeight
        searchButton.Height = 50 * index.zoomHeight
        index.LoadImage(searchButton, "\SystemImg\", "Search")
        searchButton.Top = searchback.Top + 10 * index.zoomHeight
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
        searchInput.Left = searchButton.Left + searchButton.Width + 1
        searchInput.Top = searchButton.Top
        searchInput.Width = search.Left - searchInput.Left
        searchInput.Font = New System.Drawing.
            Font("宋体", 28 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '黑名单按钮
        blackList.Width = 120 * index.zoomHeight
        blackList.Left = searchback.Left - blackList.Width - 20 * index.zoomHeight
        blackList.Height = search.Height
        blackList.Top = search.Top
        blackList.Font = New System.Drawing.
            Font("宋体", 22 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        blackList.BackColor = head.BackColor
        blackList.ForeColor = Color.White
        index.SetLableWin(blackList, 12)
        '白名单按钮
        whiteList.Width = blackList.Width
        whiteList.Left = blackList.Left - 10 * index.zoomHeight - whiteList.Width
        whiteList.Height = blackList.Height
        whiteList.Font = blackList.Font
        whiteList.Top = blackList.Top
        whiteList.ForeColor = Color.White
        whiteList.BackColor = head.BackColor
        index.SetLableWin(whiteList, 12)
        '会员按钮
        VIP.Width = 90 * index.zoomHeight
        VIP.Height = whiteList.Height
        VIP.Top = whiteList.Top
        VIP.Left = whiteList.Left - 10 * index.zoomHeight - VIP.Width
        VIP.ForeColor = Color.White
        VIP.BackColor = whiteList.BackColor
        VIP.Font = whiteList.Font
        index.SetLableWin(VIP, 12)
        '全部用户按钮
        allUser.Width = 150 * index.zoomHeight
        allUser.Left = VIP.Left - 10 * index.zoomHeight - allUser.Width
        allUser.Height = VIP.Height
        allUser.Font = VIP.Font
        allUser.BackColor = Color.FromArgb(&HFF006699)
        allUser.ForeColor = Color.White
        allUser.Top = VIP.Top
        index.SetLableWin(allUser, 12)
        BFlag(0) = True

    End Sub
    '会员余额充值页
    Private Sub Vipcharge(ByVal VipID As Integer)
        VipchargeBack.Width = 360 * index.zoomHeight
        VipchargeBack.Height = 250 * index.zoomHeight
        VipchargeBack.Left = index.ScreenWidth / 2 - VipchargeBack.Width / 2
        VipchargeBack.Top = (head.Height + index.ScreenHeight) / 2 - VipchargeBack.Height / 2
        VipchargeBack.BackColor = Color.FromArgb(&HFFFFFFCC)
        index.SetLableWin(VipchargeBack, 16)
        '退出按钮
        shut.Top = 2 + VipchargeBack.Top
        shut.Width = 42
        shut.Height = 40
        shut.Left = VipchargeBack.Left + VipchargeBack.Width - shut.Width - 2
        Try
            index.LoadImage(shut, "\SystemImg\", "close")
        Catch ex As Exception
            index.MsgOrNotifyForm("提示", ex.Message)
        End Try
        shut.BackColor = VipchargeBack.BackColor
        index.SetPictureBoxWin(shut, 20)
        '显示“会员卡余额：”
        VipSurplusM.Left = VipchargeBack.Left + 50 * index.zoomHeight
        VipSurplusM.Width = 200 * index.zoomHeight
        VipSurplusM.Height = 40 * index.zoomHeight
        VipSurplusM.Font = New System.Drawing.
            Font("微软雅黑", 20 * index.zoomHeight, System.Drawing.
                 FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        VipSurplusM.Top = 50 * index.zoomHeight + VipchargeBack.Top
        VipSurplusM.BackColor = VipchargeBack.BackColor
        '余额背景显示
        SurplusMB.Left = VipSurplusM.Left
        SurplusMB.Width = VipchargeBack.Width - 100 * index.zoomHeight
        SurplusMB.Height = 40 * index.zoomHeight
        SurplusMB.Top = VipSurplusM.Top + VipSurplusM.Height + 10 * index.zoomHeight
        SurplusMB.BackColor = Color.FromArgb(&HFF797979)
        '余额显示
        surplusMP.Left = SurplusMB.Left + 1
        surplusMP.Width = SurplusMB.Width - 2
        surplusMP.Height = SurplusMB.Height - 2
        surplusMP.Top = SurplusMB.Top + 1
        surplusMP.Font = VipSurplusM.Font
        surplusMP.ForeColor = Color.Red
        '确定按钮
        yes.Width = 120 * index.zoomHeight
        yes.Height = 50 * index.zoomHeight
        yes.Left = surplusMP.Left + surplusMP.Width - yes.Width
        yes.Top = 20 * index.zoomHeight + SurplusMB.Top + SurplusMB.Height
        yes.BackColor = head.BackColor
        yes.Font = New System.Drawing.
            Font("宋体", 22 * index.zoomHeight, System.Drawing.
                 FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        yes.ForeColor = Color.White
        index.SetLableWin(yes, 12)

    End Sub
    '会员充值控件隐藏
    Private Sub HideVipCharge()
        VipchargeBack.Hide()
        shut.Hide()
        VipSurplusM.Hide()
        SurplusMB.Hide()
        surplusMP.Hide()
        yes.Hide()
    End Sub
    '会员充值控件显示
    Private Sub ShowVipCharge()
        VipchargeBack.Show()
        shut.Show()
        VipSurplusM.Show()
        SurplusMB.Show()
        surplusMP.Show()
        yes.Show()
    End Sub

    Private Sub shut_MouseUp(sender As Object, e As EventArgs) Handles shut.MouseUp
        Try
            index.LoadImage(shut, "\SystemImg\", "close")
        Catch ex As Exception
            index.MsgOrNotifyForm("提示", ex.Message)
        End Try
    End Sub

    Private Sub shut_MouseDown(sender As Object, e As EventArgs) Handles shut.MouseDown
        Try
            index.LoadImage(shut, "\SystemImg\", "closeNotHover")
        Catch ex As Exception
            index.MsgOrNotifyForm("提示", ex.Message)
        End Try
    End Sub

    Private Sub shut_click(sender As Object, e As EventArgs) Handles shut.Click
        HideVipCharge()
    End Sub

    Private Sub yes_MouseDown(sender As Object, e As EventArgs) Handles yes.MouseDown
        yes.BackColor = Color.FromArgb(&HFF006699)
    End Sub

    Private Sub yes_MouseUp(sender As Object, e As EventArgs) Handles yes.MouseUp
        yes.BackColor = head.BackColor
    End Sub
    Private Sub Search_MouseDown(sender As Object, e As EventArgs) Handles search.MouseDown
        search.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub Search_MouseUp(sender As Object, e As EventArgs) Handles search.MouseUp
        search.BackColor = head.BackColor
    End Sub

    '用于按钮点击的回色和变色
    Private Sub ButtonChange(ByVal Flag As Integer)
        Dim Fg As Integer
        For I = 0 To 3
            If BFlag(I) = True Then
                Fg = I
                If Fg = Flag Then
                    Exit Sub
                End If
                Exit For
            End If
        Next
        Select Case Fg
            Case 0
                allUser.BackColor = head.BackColor
                BFlag(0) = False
            Case 1
                VIP.BackColor = head.BackColor
                BFlag(1) = False
            Case 2
                whiteList.BackColor = head.BackColor
                BFlag(2) = False
            Case 3
                blackList.BackColor = head.BackColor
                BFlag(3) = False
        End Select
        Select Case Flag
            Case 0
                allUser.BackColor = Color.FromArgb(&HFF006699)
                BFlag(0) = True
            Case 1
                VIP.BackColor = Color.FromArgb(&HFF006699)
                BFlag(1) = True
            Case 2
                whiteList.BackColor = Color.FromArgb(&HFF006699)
                BFlag(2) = True
            Case 3
                blackList.BackColor = Color.FromArgb(&HFF006699)
                BFlag(3) = True
        End Select
    End Sub
    Private Sub alluser_click(sender As Object, e As EventArgs) Handles allUser.Click
        ButtonChange(0)
    End Sub
    Private Sub VIp_click(sender As Object, e As EventArgs) Handles VIP.Click
        ButtonChange(1)
    End Sub

    Private Sub whitelist_click(sender As Object, e As EventArgs) Handles whiteList.Click
        ButtonChange(2)
    End Sub
    Private Sub black_click(sender As Object, e As EventArgs) Handles blackList.Click
        ButtonChange(3)
    End Sub
    Private Sub back_click() Handles back.Click
        index.Show()
        Me.Hide()
    End Sub
End Class