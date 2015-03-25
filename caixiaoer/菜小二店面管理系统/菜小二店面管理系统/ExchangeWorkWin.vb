Public Class ExchangeWorkWin

    Private Sub ExchangeWorkWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '设置本窗口的属性
        Me.Top = 0
        Me.Left = 0
        Me.Width = index.ScreenWidth
        Me.Height = index.ScreenHeight
        Me.BackColor = Color.White
        '返回按钮显示
        back.Width = 125 * index.zoomHeight
        back.Height = 100 * index.zoomHeight
        index.LoadImage(back, "\SystemImg\", "back")
        '标题栏
        head.Top = 0
        head.Left = back.Width + 5
        head.Width = index.ScreenWidth - head.Left
        head.Height = back.Height
        head.BackColor = Color.FromArgb(&HFF0099CB)
        head.ForeColor = Color.White
        head.Font = New System.Drawing.Font("微软雅黑", 46 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '操作员
        Opera.Width = 266 * index.zoomHeight
        Opera.Left = index.ScreenWidth - Opera.Width
        Opera.Height = 25 * index.zoomHeight
        Opera.Top = 20 * index.zoomHeight
        Opera.ForeColor = Color.White
        Opera.BackColor = head.BackColor
        Opera.Font = New System.Drawing.Font("宋体", 16 * index.zoomHeight, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        NowTime.Left = Opera.Left
        NowTime.Width = Opera.Width
        NowTime.Height = Opera.Height
        NowTime.Font = Opera.Font
        NowTime.Top = Opera.Top + Opera.Height * 3 / 2
        NowTime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
        NowTime.BackColor = head.BackColor
        NowTime.ForeColor = Color.White
        '绘制背景边线
        DrawBackLine.Height = 600 * index.zoomHeight
        DrawBackLine.Top = head.Height + (index.ScreenHeight - DrawBackLine.Height - head.Height) / 2
        DrawBackLine.Width = 650 * index.zoomHeight
        DrawBackLine.BackColor = Color.FromArgb(&HFF757575)
        DrawBackLine.Left = (index.ScreenWidth - DrawBackLine.Width) / 2
        index.SetLableWin(DrawBackLine, 16)
        '绘制模块背景颜色
        DrawBackcolor.Top = DrawBackLine.Top + 1 * index.zoomHeight
        DrawBackcolor.Left = DrawBackLine.Left + 1 * index.zoomHeight
        DrawBackcolor.Width = DrawBackLine.Width - 2 * index.zoomHeight
        DrawBackcolor.Height = DrawBackLine.Height - 2 * index.zoomHeight
        DrawBackcolor.BackColor = Color.FromArgb(&HFFFFFFCB)
        index.SetLableWin(DrawBackcolor, 16)
        '定义间隔
        Dim EachHigh As Double = 20 * index.zoomHeight
        '绘制“收银员”边框颜色线条
        DrawJobLine.Top = 30 * index.zoomHeight + DrawBackLine.Top
        DrawJobLine.Width = 540 * index.zoomHeight
        DrawJobLine.Height = 50 * index.zoomHeight
        DrawJobLine.Left = DrawBackLine.Left + (DrawBackLine.Width - DrawJobLine.Width) / 2
        DrawJobLine.BackColor = DrawBackLine.BackColor
        index.SetLableWin(DrawJobLine, 16)
        '绘制“收银员”后的背景
        DrawOperaBackColor.Left = DrawJobLine.Left + 1 * index.zoomHeight
        DrawOperaBackColor.Top = DrawJobLine.Top + 1 * index.zoomHeight
        DrawOperaBackColor.Width = DrawJobLine.Width - 2 * index.zoomHeight
        DrawOperaBackColor.Height = DrawJobLine.Height - 2 * index.zoomHeight
        DrawOperaBackColor.BackColor = Color.FromArgb(&HFFFFFFFF)
        index.SetLableWin(DrawOperaBackColor, 16)
        '绘制“收银员：”
        OperaMan.Left = DrawOperaBackColor.Left + 15 * index.zoomHeight
        OperaMan.Top = DrawOperaBackColor.Top + 8 * index.zoomHeight
        OperaMan.Width = DrawOperaBackColor.Width / 2 - 15 * index.zoomHeight
        OperaMan.Height = DrawOperaBackColor.Height - 16 * index.zoomHeight
        OperaMan.Font = New System.Drawing.Font("微软雅黑", 18 * index.zoomHeight, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '打印收银员编号或者昵称
        OperaManPrint.Left = OperaMan.Left + OperaMan.Width
        OperaManPrint.Width = OperaMan.Width
        OperaManPrint.Height = OperaMan.Height
        OperaManPrint.Font = OperaMan.Font
        OperaManPrint.Top = OperaMan.Top
        '绘制“所有单数”的背景线条
        AllCountLine.Width = DrawJobLine.Width
        AllCountLine.Height = DrawJobLine.Height
        AllCountLine.Left = DrawJobLine.Left
        AllCountLine.Top = 20 * index.zoomHeight + DrawJobLine.Top + DrawJobLine.Height
        AllCountLine.BackColor = DrawJobLine.BackColor
        index.SetLableWin(AllCountLine, 16)
        '绘制“所有单数"背景
        DrawAllCountBack.Top = AllCountLine.Top + 1
        DrawAllCountBack.Left = DrawOperaBackColor.Left
        DrawAllCountBack.Width = DrawOperaBackColor.Width
        DrawAllCountBack.Height = DrawOperaBackColor.Height
        DrawAllCountBack.BackColor = DrawOperaBackColor.BackColor
        index.SetLableWin(DrawAllCountBack, 16)
        '绘制“总单数：”
        AllCount.Left = OperaMan.Left
        AllCount.Top = 8 * index.zoomHeight + DrawAllCountBack.Top
        AllCount.Width = OperaMan.Width
        AllCount.Height = OperaMan.Height
        AllCount.Font = OperaMan.Font
        '打印总单数数目
        AllCountPrint.Left = OperaManPrint.Left
        AllCountPrint.Top = AllCount.Top
        AllCountPrint.Width = AllCount.Width
        AllCountPrint.Height = AllCount.Height
        AllCountPrint.Font = AllCount.Font
        '绘制总现金的背景线条
        AllMoney.Left = AllCountLine.Left
        AllMoney.Top = AllCountLine.Top + AllCountLine.Height - 2
        AllMoney.Width = AllCountLine.Width
        AllMoney.Height = AllCountLine.Height
        AllMoney.BackColor = AllCountLine.BackColor
        index.SetLableWin(AllMoney, 16)
        '绘制总现金的背景颜色
        AllCountMoneyBack.Left = AllMoney.Left + 1
        AllCountMoneyBack.Top = AllMoney.Top + 1
        AllCountMoneyBack.Width = AllMoney.Width - 2
        AllCountMoneyBack.Height = AllMoney.Height - 2
        AllCountMoneyBack.BackColor = DrawAllCountBack.BackColor
        index.SetLableWin(AllCountMoneyBack, 16)
        '打印“总现金：”
        ALLcash.Left = AllCount.Left
        ALLcash.Top = 8 * index.zoomHeight + AllCountMoneyBack.Top
        ALLcash.Width = AllCount.Width
        ALLcash.Height = AllCount.Height
        ALLcash.Font = AllCount.Font
        '显示总现金数额
        AllCashPrint.Left = AllCountPrint.Left
        AllCashPrint.Top = ALLcash.Top
        AllCashPrint.Width = ALLcash.Width
        AllCashPrint.Height = ALLcash.Height
        AllCashPrint.Font = ALLcash.Font
        '绘制总销售额背景线条
        AllSoldMoneyLine.Top = EachHigh + AllMoney.Top + AllMoney.Height
        AllSoldMoneyLine.Left = AllMoney.Left
        AllSoldMoneyLine.Width = AllMoney.Width
        AllSoldMoneyLine.Height = AllMoney.Height
        AllSoldMoneyLine.BackColor = AllMoney.BackColor
        index.SetLableWin(AllSoldMoneyLine, 16)
        '绘制总销售额的背景色
        ALLMoneyBackColor.Left = AllSoldMoneyLine.Left + 1
        ALLMoneyBackColor.Top = AllSoldMoneyLine.Top + 1
        ALLMoneyBackColor.Width = AllCountMoneyBack.Width
        ALLMoneyBackColor.Height = AllCountMoneyBack.Height
        ALLMoneyBackColor.BackColor = AllCountMoneyBack.BackColor
        index.SetLableWin(ALLMoneyBackColor, 16)
        '显示“总销售额：”
        AllSoldMoney.Top = 8 * index.zoomHeight + ALLMoneyBackColor.Top
        AllSoldMoney.Left = ALLcash.Left
        AllSoldMoney.Width = ALLcash.Width
        AllSoldMoney.Height = ALLcash.Height
        AllSoldMoney.Font = ALLcash.Font
        '显示总销售额金额
        AllSoldMoneyPrint.Left = AllCashPrint.Left
        AllSoldMoneyPrint.Top = AllSoldMoney.Top
        AllSoldMoneyPrint.Width = AllCashPrint.Width
        AllSoldMoneyPrint.Height = AllCashPrint.Height
        AllSoldMoneyPrint.Font = AllCashPrint.Font
        '现金支付背景线条绘制
        CashPayLine.Top = AllSoldMoneyLine.Top + AllSoldMoneyLine.Height - 2
        CashPayLine.Left = AllSoldMoneyLine.Left
        CashPayLine.Width = AllSoldMoneyLine.Width
        CashPayLine.Height = AllSoldMoneyLine.Height
        CashPayLine.BackColor = AllSoldMoneyLine.BackColor
        index.SetLableWin(CashPayLine, 16)
        '绘制现金支付的背景
        CashPayBackcolor.Top = CashPayLine.Top + 1
        CashPayBackcolor.Left = ALLMoneyBackColor.Left
        CashPayBackcolor.Width = ALLMoneyBackColor.Width
        CashPayBackcolor.Height = ALLMoneyBackColor.Height
        CashPayBackcolor.BackColor = ALLMoneyBackColor.BackColor
        index.SetLableWin(CashPayBackcolor, 16)
        '绘制“现金支付:”
        cashPay.Left = AllSoldMoney.Left
        cashPay.Top = CashPayBackcolor.Top + 8 * index.zoomHeight
        cashPay.Width = AllSoldMoney.Width
        cashPay.Height = AllSoldMoney.Height
        cashPay.BackColor = AllSoldMoney.BackColor
        cashPay.Font = AllSoldMoney.Font
        '显示现金支付的金额
        cashPayPrint.Left = AllCashPrint.Left
        cashPayPrint.Top = cashPay.Top
        cashPayPrint.Width = cashPay.Width
        cashPayPrint.Height = cashPay.Height
        cashPayPrint.Font = cashPay.Font
        '绘制会员卡支付的背景线条
        VIP_Pay_Line.Left = CashPayLine.Left
        VIP_Pay_Line.Top = CashPayLine.Top + CashPayLine.Height - 2
        VIP_Pay_Line.Width = CashPayLine.Width
        VIP_Pay_Line.Height = CashPayLine.Height
        VIP_Pay_Line.BackColor = CashPayLine.BackColor
        index.SetLableWin(VIP_Pay_Line, 16)
        '绘制会员卡支付背景颜色
        DrawVIPPayBack.Left = VIP_Pay_Line.Left + 1
        DrawVIPPayBack.Top = VIP_Pay_Line.Top + 1
        DrawVIPPayBack.Width = CashPayBackcolor.Width
        DrawVIPPayBack.Height = CashPayBackcolor.Height
        DrawVIPPayBack.BackColor = CashPayBackcolor.BackColor
        index.SetLableWin(DrawVIPPayBack, 16)

        '绘制“会员卡支付：”
        VIP_Pay.Left = cashPay.Left
        VIP_Pay.Top = DrawVIPPayBack.Top + 8 * index.zoomHeight
        VIP_Pay.Width = cashPay.Width
        VIP_Pay.Height = cashPay.Height
        VIP_Pay.Font = cashPay.Font
        '绘制会员卡支付总金额
        VIP_PayPrint.Left = cashPayPrint.Left
        VIP_PayPrint.Top = VIP_Pay.Top
        VIP_PayPrint.Width = cashPayPrint.Width
        VIP_PayPrint.Height = cashPayPrint.Height
        VIP_PayPrint.Font = cashPayPrint.Font
        '绘制会员充值背景线条
        VIP_charge_line.Left = VIP_Pay_Line.Left
        VIP_charge_line.Top = EachHigh + VIP_Pay_Line.Top + VIP_Pay_Line.Height
        VIP_charge_line.Width = VIP_Pay_Line.Width
        VIP_charge_line.Height = VIP_Pay_Line.Height
        VIP_charge_line.BackColor = VIP_Pay_Line.BackColor
        index.SetLableWin(VIP_charge_line, 16)
        '绘制会员充值背景
        VIP_charge_back.Left = DrawVIPPayBack.Left
        VIP_charge_back.Top = VIP_charge_line.Top + 1
        VIP_charge_back.Width = DrawVIPPayBack.Width
        VIP_charge_back.Height = DrawVIPPayBack.Height
        VIP_charge_back.BackColor = DrawVIPPayBack.BackColor
        index.SetLableWin(VIP_charge_back, 16)
        '绘制“会员充值：”
        VIP_Charge.Left = VIP_Pay.Left
        VIP_Charge.Top = VIP_charge_back.Top + 8 * index.zoomHeight
        VIP_Charge.Width = VIP_Pay.Width
        VIP_Charge.Height = VIP_Pay.Height
        VIP_Charge.Font = VIP_Pay.Font
        '绘制会员支付金额
        VIP_charge_print.Left = VIP_PayPrint.Left
        VIP_charge_print.Top = VIP_Charge.Top
        VIP_charge_print.Width = VIP_Charge.Width
        VIP_charge_print.Height = VIP_Charge.Height
        VIP_charge_print.Font = VIP_Charge.Font
        '绘制打印结果按钮的线条
        sure_line.Left = VIP_charge_line.Left
        sure_line.Top = EachHigh + VIP_charge_line.Top + VIP_charge_line.Height
        sure_line.Width = 150 * index.zoomHeight
        sure_line.Height = VIP_charge_back.Height * 5 / 6
        sure_line.BackColor = VIP_charge_line.BackColor
        index.SetLableWin(sure_line, 8)
        '绘制打印结果按钮背景
        Sure_backcolor.Left = sure_line.Left + 1
        Sure_backcolor.Top = sure_line.Top + 1
        Sure_backcolor.Width = sure_line.Width - 2
        Sure_backcolor.Height = sure_line.Height - 2
        Sure_backcolor.BackColor = Color.FromArgb(&HFFFF9899)
        Sure_backcolor.Font = New System.Drawing.Font("宋体", 20 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Sure_backcolor.ForeColor = Color.White
        index.SetLableWin(Sure_backcolor, 8)
        '显示时间日期
        NowTimeAndDate.Left = Sure_backcolor.Left + Sure_backcolor.Width
        NowTimeAndDate.Width = VIP_charge_line.Width - Sure_backcolor.Width
        NowTimeAndDate.Height = Sure_backcolor.Height
        NowTimeAndDate.Top = Sure_backcolor.Top
        NowTimeAndDate.Font = Sure_backcolor.Font
        NowTimeAndDate.Text = Now()
        NowTimeAndDate.BackColor = DrawBackcolor.BackColor
        '绘制确定按钮边框线条
        Yes_Line.Top = sure_line.Top + sure_line.Height + EachHigh
        Yes_Line.Left = sure_line.Left
        Yes_Line.Width = VIP_charge_line.Width
        Yes_Line.Height = DrawBackcolor.Top + DrawBackcolor.Height - Yes_Line.Top - 30 * index.zoomHeight
        Yes_Line.BackColor = sure_line.BackColor
        index.SetLableWin(Yes_Line, 16)
        '绘制确定按钮背景
        Yes_color.Left = Yes_Line.Left + 1
        Yes_color.Top = Yes_Line.Top + 1
        Yes_color.Width = Yes_Line.Width - 2
        Yes_color.Height = Yes_Line.Height - 2
        Yes_color.BackColor = Color.FromArgb(&HFF0099CB)
        Yes_color.ForeColor = Color.White
        Yes_color.Font = New System.Drawing.Font("宋体", 28 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        index.SetLableWin(Yes_color, 16)








    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        NowTime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
    End Sub

    Private Sub back_click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        purchase.Show()
    End Sub


End Class