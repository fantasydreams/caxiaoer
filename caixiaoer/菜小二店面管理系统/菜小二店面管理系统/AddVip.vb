Public Class AddVip

    Private Sub AddVip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MapLoad()
        VIPnotifyMap()
    End Sub

    '布局
    Private Sub MapLoad()
        Me.BackColor = Color.White
        '返回按钮绘制
        back.Top = 0
        back.Left = 0
        back.Width = 125 * index.zoomHeight
        back.Height = 100 * index.zoomHeight
        Try
            back.Image = Image.FromFile(Application.StartupPath & "\SystemImg\back.png")
        Catch ex As Exception
            Dim tempForm As New MsgOrNotify
            tempForm.caption.Text = "错误"
            tempForm.msg.Text = "程序部分文件缺失，请重新安装后重试！"
            tempForm.Show()
        End Try

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
        '会员信息显示模块背景
        backGround.Height = 500 * index.zoomHeight
        backGround.Width = 880 * index.zoomHeight
        backGround.Left = index.ScreenWidth / 2 - backGround.Width / 2
        backGround.Top = index.ScreenHeight / 2 + head.Height / 2 - backGround.Height / 2
        backGround.BackColor = Color.FromArgb(&HFF797979)
        index.SetLableWin(backGround, 16)
        '背景
        backColorD.Left = backGround.Left + 1
        backColorD.Width = backGround.Width - 2
        backColorD.Height = backGround.Height - 2
        backColorD.Top = backGround.Top + 1
        backColorD.BackColor = Color.FromArgb(&HFFFFFFCC)
        index.SetLableWin(backColorD, 16)
        '显示“会员基本信息”
        VipInfo.Width = 240 * index.zoomHeight
        VipInfo.Height = 50 * index.zoomHeight
        VipInfo.Top = backColorD.Top + 20 * index.zoomHeight
        VipInfo.Left = backColorD.Left + backColorD.Width / 2 - VipInfo.Width / 2
        VipInfo.Font = New System.Drawing.
            Font("微软雅黑", 24 * index.zoomHeight, System.Drawing.
                 FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        VipInfo.BackColor = backColorD.BackColor
        '定义各组件之间显示的高距
        Dim high As Double = 50 * index.zoomHeight
        
        '输出卡号
        VipCardIdP.Width = 200 * index.zoomHeight
        VipCardIdP.Height = 30 * index.zoomHeight
        VipCardIdP.Left = backColorD.Left + backColorD.Width / 2 - 50 * index.zoomHeight - VipCardIdP.Width
        VipCardIdP.Top = VipInfo.Top + VipInfo.Height + high
        VipCardIdP.Font = New System.Drawing.
            Font("宋体", 18 * index.zoomHeight, System.Drawing.
                 FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        VipCardIdP.BackColor = backColorD.BackColor
        '显示“卡号：”
        VipCardID.Width = 120 * index.zoomHeight
        VipCardID.Height = 40 * index.zoomHeight
        VipCardID.Left = VipCardIdP.Left - VipCardID.Width
        VipCardID.Top = VipCardIdP.Top + VipCardIdP.Height / 2 - VipCardID.Height / 2
        VipCardID.Font = New System.Drawing.
            Font("微软雅黑", 20 * index.zoomHeight, System.Drawing.
                 FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        VipCardID.BackColor = backColorD.BackColor
        '显示“姓名：”
        VipName.Left = VipCardID.Left
        VipName.Top = VipCardID.Top + VipCardID.Height + high
        VipName.Font = VipCardID.Font
        VipName.Height = VipCardID.Height
        VipName.Width = VipCardID.Width
        VipName.BackColor = backColorD.BackColor
        '姓名输入框
        NameInput.Left = VipCardIdP.Left
        NameInput.Width = VipCardIdP.Width
        NameInput.Top = VipName.Top + 5 * index.zoomHeight
        NameInput.Font = VipCardIdP.Font
        '显示“邮箱：”
        email.Left = VipName.Left
        email.Width = VipName.Width
        email.Height = VipName.Height
        email.Top = VipName.Top + VipName.Height + high
        email.Font = VipName.Font
        email.BackColor = backColorD.BackColor
        '邮箱输入框
        emailInput.Left = email.Left + email.Width
        emailInput.Width = NameInput.Width
        emailInput.Font = NameInput.Font
        emailInput.Top = email.Top + 5 * index.zoomHeight

        '显示“联系方式：”
        tellPhone.Height = email.Height
        tellPhone.Width = 160 * index.zoomHeight
        tellPhone.Left = email.Left + email.Width - tellPhone.Width
        tellPhone.Top = email.Top + email.Height + high
        tellPhone.Font = email.Font
        tellPhone.BackColor = backColorD.BackColor
        '联系方式输入框
        phoneInput.Left = tellPhone.Left + tellPhone.Width
        phoneInput.Width = emailInput.Width
        phoneInput.Font = emailInput.Font
        phoneInput.Top = tellPhone.Top + 5 * index.zoomHeight
        '显示“地址：”
        address.Width = VipName.Width
        address.Height = VipName.Height
        address.Top = VipCardID.Top
        address.Font = VipCardID.Font
        address.Left = backColorD.Left + backColorD.Width / 2 + 50 * index.zoomHeight
        address.BackColor = backColorD.BackColor
        '地址输入框
        addressInput.Left = address.Left + address.Width
        addressInput.Top = address.Top + 5 * index.zoomHeight
        addressInput.Width = emailInput.Width
        addressInput.Font = emailInput.Font
        '显示“充值金额：”
        ChargeMon.Width = tellPhone.Width
        ChargeMon.Height = tellPhone.Height
        ChargeMon.Left = address.Left + address.Width - ChargeMon.Width
        ChargeMon.Top = VipName.Top
        ChargeMon.Font = address.Font
        ChargeMon.BackColor = backColorD.BackColor
        '显示“￥”
        Mon.Left = ChargeMon.Left + ChargeMon.Width
        Mon.Top = ChargeMon.Top
        Mon.Width = 30 * index.zoomHeight
        Mon.Height = address.Height
        Mon.Font = address.Font
        Mon.BackColor = backColorD.BackColor
        '充值 金额输入框
        MonInput.Left = Mon.Left + Mon.Width
        MonInput.Width = addressInput.Width - MonInput.Left + addressInput.Left
        MonInput.Font = addressInput.Font
        MonInput.Top = Mon.Top + 5 * index.zoomHeight
        '显示“积分：”
        integral.Left = address.Left
        integral.Width = address.Width
        integral.Height = address.Height
        integral.Font = address.Font
        integral.Top = ChargeMon.Top + ChargeMon.Height + high
        integral.BackColor = backColorD.BackColor
        '显示积分背景线条
        integralL.Left = addressInput.Left
        integralL.Width = addressInput.Width
        integralL.Height = address.Height
        integralL.Top = integral.Top
        integralL.BackColor = backGround.BackColor
        '显示积分
        integralP.Left = integralL.Left + 1
        integralP.Width = integralL.Width - 2
        integralP.Height = integralL.Height - 2
        integralP.Top = integralL.Top + 1
        integralP.Font = VipCardIdP.Font
        '添加会员按钮背景线条
        addVipL.Left = address.Left + 10 * index.zoomHeight
        addVipL.Width = 250 * index.zoomHeight
        addVipL.Height = 60 * index.zoomHeight
        addVipL.Top = tellPhone.Top
        addVipL.BackColor = backGround.BackColor
        index.SetLableWin(addVipL, 16)
        '添加会员按钮
        addVipUser.Left = addVipL.Left + 1
        addVipUser.Width = addVipL.Width - 2
        addVipUser.Height = addVipL.Height - 2
        addVipUser.Top = addVipL.Top + 1
        addVipUser.Font = New System.Drawing.
            Font("宋体", 28 * index.zoomHeight,
                 System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))

        addVipUser.ForeColor = Color.White
        addVipUser.BackColor = head.BackColor
        index.SetLableWin(addVipUser, 16)

    End Sub

    '添加会员提示布局
    Private Sub VIPnotifyMap()
        msgBL.Width = 300 * index.zoomHeight
        msgBL.Height = 250 * index.zoomHeight
        msgBL.Left = index.ScreenWidth / 2 - msgBL.Width / 2
        msgBL.Top = index.ScreenHeight / 2 + head.Height / 2 - msgBL.Height / 2
        msgBL.BackColor = backGround.BackColor
        index.SetLableWin(msgBL, 16)
        '背景
        VipMsgback.Left = msgBL.Left + 1
        VipMsgback.Top = msgBL.Top + 1
        VipMsgback.Width = msgBL.Width - 2
        VipMsgback.Height = msgBL.Height - 2
        VipMsgback.BackColor = backColorD.BackColor
        index.SetLableWin(VipMsgback, 16)
        '关闭按钮
        shut.Width = 42
        shut.Height = 40
        shut.Left = VipMsgback.Left + VipMsgback.Width - 2 - shut.Width
        shut.Top = VipMsgback.Top + 2
        Try
            shut.Image = Image.FromFile(Application.StartupPath & "\SystemImg\close.png")
        Catch ex As Exception
            MsgBox("程序文件缺失，请尝试重新安装解决！")
            index.CloseAppForm()
        End Try
        '提示文字
        msgP.Left = 10 * index.zoomHeight + VipMsgback.Left
        msgP.Top = shut.Top + shut.Height
        msgP.Width = VipMsgback.Width - 20 * index.zoomHeight
        msgP.Height = VipMsgback.Height - 2 * shut.Height
        msgP.Font = New System.Drawing.
            Font("宋体", 16 * index.zoomHeight, System.Drawing.
                 FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        msgP.BackColor = VipMsgback.BackColor

    End Sub

    '隐藏提示窗口
    Private Sub HideMsg()
        msgBL.Hide()
        VipMsgback.Hide()
        shut.Hide()
        msgP.Hide()
    End Sub

    '显示提示窗口
    Private Sub ShowMsg()
        msgBL.Show()
        VipMsgback.Show()
        shut.Show()
        msgP.Show()
    End Sub

    '更新时间
    Private Sub NowtimeUpdater_Tick(sender As Object, e As EventArgs) Handles NowtimeUpdater.Tick
        Nowtime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
    End Sub
    'addvipuser控件鼠标点击事件
    Private Sub addVipuser_mouseDown(sender As Object, e As EventArgs) Handles addVipUser.MouseDown
        addVipUser.BackColor = Color.FromArgb(&HFF006699)
        ShowMsg()
    End Sub
    Private Sub addvipuser_mouseUp(sender As Object, e As EventArgs) Handles addVipUser.MouseUp
        addVipUser.BackColor = head.BackColor
    End Sub
    'back控件鼠标点击事件
    Private Sub bacl_click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        index.Show()
    End Sub
    '关闭按钮鼠标点击事件
    Private Sub shut_mouseDown(sender As Object, e As EventArgs) Handles shut.MouseDown
        Try
            shut.Image = Image.FromFile(Application.StartupPath & "\SystemImg\closeNotHover.png")
        Catch ex As Exception
            MsgBox("程序文件缺失，请尝试重新安装解决！")
            index.CloseAppForm()
        End Try
        HideMsg()
    End Sub
    Private Sub shut_mouseup(sender As Object, e As EventArgs) Handles shut.MouseUp
        Try
            shut.Image = Image.FromFile(Application.StartupPath & "\SystemImg\close.png")
        Catch ex As Exception
            MsgBox("程序文件缺失，请尝试重新安装解决！")
            index.CloseAppForm()
        End Try
    End Sub

End Class