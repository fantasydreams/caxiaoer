Public Class Collection

    Private HideCashFlag As Boolean = False
    Private WinInCash As Boolean = True

    Private Sub Collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMap()
        VIP_hide()
    End Sub

    Private Sub LoadMap()
        Me.BackColor = Color.White
        '返回按钮
        back.Top = 0
        back.Left = 0
        back.Width = 125 * index.zoomHeight
        back.Height = 100 * index.zoomHeight
        index.LoadImage(back, "\SystemImg\", "back")
        '“收款”以及标题
        head.Top = 0
        head.Left = back.Width + 5
        head.Height = back.Height
        head.Width = index.ScreenWidth - back.Width - 5
        head.BackColor = Color.FromArgb(&HFF0099CB)
        head.Font = New System.Drawing.Font("微软雅黑", 46 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '操作员打印
        OperatorMan.Width = 266 * index.zoomHeight
        OperatorMan.Top = 20 * index.zoomHeight
        OperatorMan.Left = index.ScreenWidth - OperatorMan.Width
        OperatorMan.Height = 25 * index.zoomHeight
        OperatorMan.BackColor = head.BackColor
        OperatorMan.Font = New System.Drawing.Font("宋体", 16 * index.zoomHeight, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '打印现在的时间
        NowTime.Left = OperatorMan.Left
        NowTime.Top = OperatorMan.Top + OperatorMan.Height * 3 / 2
        NowTime.Height = OperatorMan.Height
        NowTime.Width = OperatorMan.Width
        NowTime.Font = OperatorMan.Font
        NowTime.BackColor = head.BackColor
        NowTime.Text = Format(Now(), "yyyy.MM.dd hh:mm")

        '中央框架的颜色绘制
        DrawColor.Height = 480 * index.zoomHeight
        DrawColor.Top = index.ScreenHeight / 2 - DrawColor.Height / 2 + head.Height / 2
        DrawColor.Width = 500 * index.zoomWidth
        DrawColor.Left = index.ScreenWidth / 2 - DrawColor.Width / 2 + +30 * index.zoomWidth
        Dim r_DrawColor_Button As Integer = login.CreateRoundRectRgn(0, 0, DrawColor.Width, DrawColor.Height, 20 * index.zoomWidth, 20 * index.zoomHeight)
        login.SetWindowRgn(DrawColor.Handle, r_DrawColor_Button, True)
        DrawColor.BackColor = Color.FromArgb(&HFF00649A)
        DrawColor2.Top = DrawColor.Top + 3
        DrawColor2.Left = DrawColor.Left + 3
        DrawColor2.Width = DrawColor.Width - 6
        DrawColor2.Height = DrawColor.Height - 6
        Dim r_DrawColor2_Button As Integer = login.CreateRoundRectRgn(0, 0, DrawColor2.Width, DrawColor2.Height, 20 * index.zoomWidth, 20 * index.zoomHeight)
        login.SetWindowRgn(DrawColor2.Handle, r_DrawColor2_Button, True)
        DrawColor2.BackColor = Color.FromArgb(&HFFFFFFCB)

        '打印“应收金额”
        shouldPay.Top = DrawColor2.Top + 38 * index.zoomHeight
        shouldPay.Left = DrawColor2.Left + 50 * index.zoomHeight
        shouldPay.BackColor = Color.White
        shouldPay.Width = DrawColor2.Width - 100 * index.zoomHeight
        shouldPay.Height = 80 * index.zoomHeight
        shouldPay.Font = New System.Drawing.Font("微软雅黑", 23 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '打印“实收金额”
        actuallyPay.Left = shouldPay.Left
        actuallyPay.Width = shouldPay.Width
        actuallyPay.Height = shouldPay.Height
        actuallyPay.BackColor = Color.White
        actuallyPay.Font = shouldPay.Font
        actuallyPay.Top = shouldPay.Top + shouldPay.Height + 30 * index.zoomHeight
        '打印“找零”
        exchangeBack.Top = actuallyPay.Top + actuallyPay.Height + 30 * index.zoomHeight
        exchangeBack.Width = actuallyPay.Width
        exchangeBack.Height = actuallyPay.Height
        exchangeBack.Left = actuallyPay.Left
        exchangeBack.BackColor = Color.White
        exchangeBack.Font = actuallyPay.Font


        DrawColor1.Top = DrawColor2.Top + 37 * index.zoomHeight
        DrawColor1.Left = DrawColor2.Left + 49 * index.zoomHeight
        DrawColor1.Width = DrawColor2.Width - 98 * index.zoomHeight
        DrawColor1.Height = 82 * index.zoomHeight
        DrawColor1.BackColor = Color.FromArgb(&HFF005F96)
        DrawColor3.Top = DrawColor1.Top + DrawColor1.Height + 28 * index.zoomHeight
        DrawColor3.Left = DrawColor1.Left
        DrawColor3.Width = DrawColor1.Width
        DrawColor3.Height = DrawColor1.Height
        DrawColor3.BackColor = DrawColor1.BackColor
        DrawColor4.Top = DrawColor3.Top + DrawColor3.Height + 28 * index.zoomHeight
        DrawColor4.Left = DrawColor3.Left
        DrawColor4.Width = DrawColor1.Width
        DrawColor4.Height = DrawColor1.Height
        DrawColor4.BackColor = DrawColor1.BackColor

        

        '确定按钮绘制
        YES.Height = 70 * index.zoomHeight
        YES.Top = DrawColor2.Height + DrawColor2.Top - YES.Height - 37 * index.zoomHeight
        YES.Width = DrawColor2.Width / 2
        YES.Left = DrawColor2.Left + YES.Width / 2
        YES.Font = New System.Drawing.Font("宋体", 30 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        YES.BackColor = Color.FromArgb(&HFF3398CC)
        Dim r_YES_Button As Integer = login.CreateRoundRectRgn(0, 0, YES.Width, YES.Height, 20 * index.zoomWidth, 20 * index.zoomHeight)
        login.SetWindowRgn(YES.Handle, r_YES_Button, True)

        drawColor5.Width = 60 * index.zoomWidth
        drawColor5.Top = DrawColor1.Top + 20 * index.zoomHeight
        drawColor5.Left = DrawColor1.Left + DrawColor1.Width - 80 * index.zoomWidth

        drawColor5.Height = shouldPay.Height / 2
        drawColor5.BackColor = Color.FromArgb(&HFF005F96)
        Dim R_DrawColor5_Button As Integer = login.CreateRoundRectRgn(0, 0, drawColor5.Width, drawColor5.Height, 6 * index.zoomWidth, 6 * index.zoomWidth)
        login.SetWindowRgn(drawColor5.Handle, R_DrawColor5_Button, True)

        '打折按钮绘制
        discount.Top = drawColor5.Top + 1
        discount.Left = drawColor5.Left + 1
        discount.Width = drawColor5.Width - 2
        discount.Height = drawColor5.Height - 2
        discount.BackColor = Color.FromArgb(&HFFCCFCFE)
        Dim r_discount_button As Integer = login.CreateRoundRectRgn(0, 0, discount.Width, discount.Height, 6 * index.zoomWidth, 6 * index.zoomHeight)
        login.SetWindowRgn(discount.Handle, r_discount_button, True)
        '打印需要支付的金额
        shouldpayPrint.Top = shouldPay.Top
        shouldpayPrint.Width = 115 * index.zoomWidth
        shouldpayPrint.Left = discount.Left - shouldpayPrint.Width
        shouldpayPrint.Height = shouldPay.Height
        shouldpayPrint.BackColor = shouldPay.BackColor
        shouldpayPrint.Font = New System.Drawing.Font("微软雅黑", 23 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        
        '打印实际支付的金额
        actuallPayPrint.Top = actuallyPay.Top
        actuallPayPrint.Left = shouldpayPrint.Left
        actuallPayPrint.Width = shouldpayPrint.Width
        actuallPayPrint.Height = shouldPay.Height
        actuallPayPrint.ForeColor = Color.Red
        actuallPayPrint.Font = shouldpayPrint.Font
        actuallPayPrint.BackColor = shouldpayPrint.BackColor

        '打印补付客户的金额
        exchangebackPrint.Top = exchangeBack.Top
        exchangebackPrint.Left = actuallPayPrint.Left
        exchangebackPrint.Width = actuallPayPrint.Width
        exchangebackPrint.Height = actuallPayPrint.Height
        exchangebackPrint.BackColor = actuallPayPrint.BackColor
        exchangebackPrint.Font = actuallPayPrint.Font
        exchangebackPrint.ForeColor = Color.Red
        '打印“￥”
        Mon1.Width = 30 * index.zoomWidth
        Mon1.Left = shouldpayPrint.Left - Mon1.Width
        Mon1.Top = shouldpayPrint.Top
        Mon1.Height = shouldpayPrint.Height
        Mon1.Font = shouldpayPrint.Font

        Mon2.Top = actuallPayPrint.Top
        Mon2.Left = Mon1.Left
        Mon2.Width = Mon1.Width
        Mon2.Height = Mon1.Height
        Mon2.Font = Mon1.Font

        Mon3.Left = Mon2.Left
        Mon3.Top = exchangebackPrint.Top
        Mon3.Width = Mon2.Width
        Mon3.Height = Mon2.Height
        Mon3.Font = Mon2.Font
        

        cash.Height = 80 * index.zoomHeight
        cash.Width = 150 * index.zoomHeight
        cash.Top = 300 * index.zoomHeight
        cash.Left = head.Left
        cash.BackColor = Color.White
        cash.Font = New System.Drawing.Font("宋体", 32 * index.zoomHeight, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Dim r_cash_button As Integer = login.CreateRoundRectRgn(0, 0, cash.Width, cash.Height, 20 * index.zoomWidth, 20 * index.zoomHeight)
        login.SetWindowRgn(cash.Handle, r_cash_button, True)
        cash.BackColor = Color.FromArgb(&HFF006599)
        cash.ForeColor = Color.White
        VIP.Top = cash.Top + cash.Height + 50 * index.zoomHeight
        VIP.Left = cash.Left
        VIP.Width = cash.Width
        VIP.Height = cash.Height
        VIP.BackColor = head.BackColor
        VIP.Font = cash.Font
        VIP.ForeColor = Color.White
        Dim r_VIP_button As Integer = login.CreateRoundRectRgn(0, 0, VIP.Width, VIP.Height, 20 * index.zoomWidth, 20 * index.zoomHeight)
        login.SetWindowRgn(VIP.Handle, r_VIP_button, True)
        MapDisCount()
        HideDisCount()
        VIP_cardMap()
    End Sub

    Private Sub VIP_cardMap()
        Draw_VIP_color.Top = DrawColor.Top
        Draw_VIP_color.Width = 250 * index.zoomWidth
        Draw_VIP_color.Left = DrawColor.Left / 2 - Draw_VIP_color.Width / 2
        Draw_VIP_color.Height = DrawColor.Height
        Draw_VIP_color.BackColor = Color.FromArgb(&HFF727272)
        Dim r_Draw_VIP_color As Integer = login.CreateRoundRectRgn(0, 0, Draw_VIP_color.Width, Draw_VIP_color.Height, 12 * index.zoomWidth, 12 * index.zoomHeight)
        login.SetWindowRgn(Draw_VIP_color.Handle, r_Draw_VIP_color, True)
        Draw_VIP_color1.Top = Draw_VIP_color.Top + 1
        Draw_VIP_color1.Left = Draw_VIP_color.Left + 1
        Draw_VIP_color1.Width = Draw_VIP_color.Width - 2
        Draw_VIP_color1.Height = Draw_VIP_color.Height - 2
        Draw_VIP_color1.BackColor = Color.FromArgb(&HFFEDEDED)
        Dim r_Draw_VIP_color1 As Integer = login.CreateRoundRectRgn(0, 0, Draw_VIP_color1.Width, Draw_VIP_color1.Height, 12 * index.zoomWidth, 12 * index.zoomHeight)
        login.SetWindowRgn(Draw_VIP_color1.Handle, r_Draw_VIP_color1, True)

        '绘制“会员卡”标题
        VIP_Card_P.Width = Draw_VIP_color1.Width / 2
        VIP_Card_P.Top = Draw_VIP_color1.Top + 20 * index.zoomHeight
        VIP_Card_P.Left = Draw_VIP_color1.Left + Draw_VIP_color1.Width / 2 - VIP_Card_P.Width / 2
        VIP_Card_P.Height = 42 * index.zoomHeight
        VIP_Card_P.BackColor = Draw_VIP_color1.BackColor
        VIP_Card_P.Font = New System.Drawing.Font("微软雅黑", 25 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))


        '绘制“卡号”标题

        Card_ID.Top = VIP_Card_P.Top + 20 * index.zoomHeight + VIP_Card_P.Height
        Card_ID.Left = Draw_VIP_color1.Left
        Card_ID.Width = Draw_VIP_color1.Width / 3
        Card_ID.Height = 35 * index.zoomHeight
        Card_ID.Font = New System.Drawing.Font("微软雅黑", 15 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Card_ID.BackColor = Draw_VIP_color1.BackColor

        '定义绘画各标题间的高度差
        Dim Hight As Integer = 16 * index.zoomHeight + Card_ID.Height

        '绘制“姓名”标题
        Card_Name.Top = Card_ID.Top + Hight
        Card_Name.Left = Card_ID.Left
        Card_Name.Width = Card_ID.Width
        Card_Name.Height = Card_ID.Height
        Card_Name.Font = Card_ID.Font
        Card_Name.BackColor = Card_ID.BackColor

        '绘制“电话”标题
        Card_phone.Top = Card_Name.Top + Hight
        Card_phone.Left = Card_Name.Left
        Card_phone.Width = Card_Name.Width
        Card_phone.Height = Card_Name.Height
        Card_phone.Font = Card_Name.Font
        Card_phone.BackColor = Card_ID.BackColor

        '绘制“金额”标题   
        Card_Money.Left = Card_ID.Left
        Card_Money.Top = Card_phone.Top + Hight
        Card_Money.Width = Card_ID.Width
        Card_Money.Height = Card_ID.Height
        Card_Money.Font = Card_ID.Font
        Card_Money.BackColor = Card_ID.BackColor

        '绘制“积分”标题
        Card_integral.Left = Card_Money.Left
        Card_integral.Top = Card_Money.Top + Hight
        Card_integral.Width = Card_Money.Width
        Card_integral.Height = Card_Money.Height
        Card_integral.Font = Card_Money.Font
        Card_integral.BackColor = Card_ID.BackColor

        '打印Card_ID
        Card_ID_Print.Left = Card_ID.Left + Card_ID.Width
        Card_ID_Print.Top = Card_ID.Top
        Card_ID_Print.Width = Draw_VIP_color1.Width * 2 / 3 - 2
        Card_ID_Print.Height = Card_ID.Height
        Card_ID_Print.Font = Card_ID.Font
        Card_ID_Print.BackColor = Card_ID.BackColor
        '打印Card_name
        Card_name_print.Left = Card_ID_Print.Left
        Card_name_print.Top = Card_Name.Top
        Card_name_print.Width = Card_ID_Print.Width
        Card_name_print.Height = Card_Name.Height
        Card_name_print.BackColor = Card_Name.BackColor
        Card_name_print.Font = Card_Name.Font
        '打印Card_phone
        Card_phone_print.Left = Card_name_print.Left
        Card_phone_print.Top = Card_phone.Top
        Card_phone_print.Width = Card_ID_Print.Width
        Card_phone_print.Height = Card_phone.Height
        Card_phone_print.BackColor = Card_phone.BackColor
        Card_phone_print.Font = Card_phone.Font
        '金额输入输出框

        Card_Money_IO.Top = Card_Money.Top
        Card_Money_IO.Width = Card_phone_print.Width * 2 / 3
        Card_Money_IO.Left = Card_phone_print.Left + 30 * index.zoomWidth
        Card_Money_IO.Height = Card_phone.Height
        Card_Money_IO.Font = Card_Money.Font
        '积分输入输出框
        Card_integral_IO.Top = Card_integral.Top
        Card_integral_IO.Left = Card_Money_IO.Left
        Card_integral_IO.Width = Card_Money_IO.Width
        Card_integral_IO.Height = Card_integral.Height
        Card_integral_IO.Font = Card_integral.Font
        '打印“￥”
        Mon.Width = 30 * index.zoomHeight
        Mon.Left = Card_integral_IO.Left - Mon.Width
        Mon.Height = Card_Money.Height
        Mon.Top = Card_Money.Top
        Mon.Font = Card_Money.Font
        Mon.BackColor = Card_Money.BackColor
        '提示信息打印
        Tip.Left = Draw_VIP_color1.Left + 1 * index.zoomWidth
        Tip.Width = Draw_VIP_color1.Width - 2 * index.zoomWidth
        Tip.Top = Card_integral_IO.Top + Card_integral_IO.Height + 20 * index.zoomHeight
        Tip.Height = 30 * index.zoomHeight
        Tip.Font = New System.Drawing.Font("微软雅黑", 11 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Tip.ForeColor = Color.Red
        Tip.BackColor = Card_name_print.BackColor
        '确定按钮
        charge.Top = Tip.Top + 20 * index.zoomHeight + Tip.Height
        charge.Width = Draw_VIP_color1.Width / 2
        charge.Height = 50 * index.zoomHeight
        charge.Left = Draw_VIP_color1.Width / 2 - charge.Width / 2 + Draw_VIP_color1.Left
        Dim R_sure_clor As Integer = login.CreateRoundRectRgn(0, 0, charge.Width, charge.Height, 8 * index.zoomWidth, 8 * index.zoomHeight)
        login.SetWindowRgn(charge.Handle, R_sure_clor, True)
        charge.BackColor = Color.FromArgb(&HFF7A7977)

        charge1.Top = charge.Top + 1
        charge1.Left = charge.Left + 1
        charge1.Width = charge.Width - 2
        charge1.Height = charge.Height - 2
        charge1.BackColor = Color.FromArgb(&HFF3398CC)
        charge1.ForeColor = Color.White
        charge1.Font = New System.Drawing.Font("微软雅黑", 20 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Dim R_Sure_color1 As Integer = login.CreateRoundRectRgn(0, 0, charge1.Width, charge1.Height, 8 * index.zoomWidth, 8 * index.zoomHeight)
        login.SetWindowRgn(charge1.Handle, R_Sure_color1, True)



    End Sub

    Private Sub VIP_hide()
        Draw_VIP_color.Hide()
        Draw_VIP_color1.Hide()
        VIP_Card_P.Hide()
        Card_ID.Hide()
        Card_Name.Hide()
        Card_name_print.Hide()
        Card_phone_print.Hide()
        Card_phone.Hide()
        Mon.Hide()
        Card_Money_IO.Hide()
        Card_Money.Hide()
        Card_integral_IO.Hide()
        Card_integral.Hide()
        Tip.Hide()
        charge.Hide()
        charge1.Hide()
        Card_ID_Print.Hide()

    End Sub

    Private Sub VIP_Show()
        Draw_VIP_color.Show()
        Draw_VIP_color1.Show()
        VIP_Card_P.Show()
        Card_ID.Show()
        Card_Name.Show()
        Card_name_print.Show()
        Card_phone_print.Show()
        Card_phone.Show()
        Mon.Show()
        Card_Money_IO.Show()
        Card_Money.Show()
        Card_integral_IO.Show()
        Card_integral.Show()
        Tip.Show()
        charge.Show()
        charge1.Show()
        Card_ID_Print.Show()
    End Sub

    Private Sub MapDisCount()
        DisCount_Draw.Width = 160 * index.zoomWidth
        DisCount_Draw.Top = DrawColor1.Top
        DisCount_Draw.Left = DrawColor.Left + DrawColor.Width + (index.ScreenWidth - DrawColor.Left - DrawColor.Width) / 2 - DisCount_Draw.Width / 2
        DisCount_Draw.Height = 3 * DrawColor1.Height + 56 * index.zoomHeight
        Dim r_DisCount_Draw As Integer = login.CreateRoundRectRgn(0, 0, DisCount_Draw.Width, DisCount_Draw.Height, 12 * index.zoomWidth, 12 * index.zoomHeight)
        login.SetWindowRgn(DisCount_Draw.Handle, r_DisCount_Draw, True)
        DisCount_Draw.BackColor = Color.FromArgb(&HFF2694C9)
        Discount_draw1.Width = DisCount_Draw.Width - 2
        Discount_draw1.Top = DisCount_Draw.Top + 1
        Discount_draw1.Left = DisCount_Draw.Left + 1

        Discount_draw1.Height = DisCount_Draw.Height - 2
        Discount_draw1.BackColor = Color.White
        Dim r_DisCount_Draw1 As Integer = login.CreateRoundRectRgn(0, 0, Discount_draw1.Width, Discount_draw1.Height, 12 * index.zoomWidth, 12 * index.zoomHeight)
        login.SetWindowRgn(Discount_draw1.Handle, r_DisCount_Draw1, True)
        disCount_I_O.Top = discount.Top
        disCount_I_O.Left = Discount_draw1.Left + 25 * index.zoomWidth
        disCount_I_O.Width = 70 * index.zoomWidth
        disCount_I_O.Font = New System.Drawing.Font("宋体", 20 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        percent.Top = disCount_I_O.Top
        percent.Left = disCount_I_O.Left + disCount_I_O.Width
        percent.Height = disCount_I_O.Height
        percent.Width = 40 * index.zoomWidth
        percent.Font = New System.Drawing.Font("宋体", 25 * index.zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        percent.BackColor = Color.White
        dis_95.Left = Discount_draw1.Left
        dis_95.Top = disCount_I_O.Top + 50 * index.zoomHeight
        dis_95.Height = 44 * index.zoomHeight
        dis_95.Width = Discount_draw1.Width / 2
        dis_95.Font = disCount_I_O.Font
        dis_95.BackColor = Color.White
        dis_90.Width = dis_95.Width - 2
        dis_90.Height = dis_95.Height
        dis_90.Left = dis_95.Left + dis_95.Width
        dis_90.Top = dis_95.Top
        dis_90.Font = dis_95.Font
        dis_90.BackColor = Color.White
        dis_85.Left = dis_95.Left
        dis_85.Top = dis_95.Top + dis_95.Height
        dis_85.Width = dis_95.Width
        dis_85.Height = dis_95.Height
        dis_85.Font = dis_95.Font
        dis_85.BackColor = Color.White
        dis_80.Left = dis_90.Left
        dis_80.Top = dis_85.Top
        dis_80.Width = dis_90.Width
        dis_80.Height = dis_90.Height
        dis_80.Font = dis_90.Font
        dis_80.BackColor = Color.White
        dis_75.Top = dis_85.Top + dis_85.Height
        dis_75.Left = dis_85.Left
        dis_75.Height = dis_85.Height
        dis_75.Width = dis_85.Width
        dis_75.Font = dis_85.Font
        dis_75.BackColor = Color.White
        dis_70.Top = dis_75.Top
        dis_70.Left = dis_80.Left
        dis_70.Width = dis_80.Width
        dis_70.Height = dis_80.Height
        dis_70.Font = dis_80.Font
        dis_70.BackColor = Color.White
        dis_65.Top = dis_75.Top + dis_75.Height
        dis_65.Left = dis_75.Left
        dis_65.Height = dis_75.Height
        dis_65.Width = dis_75.Width
        dis_65.Font = dis_75.Font
        dis_65.BackColor = Color.White
        dis_60.Left = dis_70.Left
        dis_60.Top = dis_65.Top
        dis_60.Width = dis_70.Width
        dis_60.Height = dis_70.Height
        dis_60.Font = dis_70.Font
        dis_60.BackColor = Color.White
        dis_55.Left = dis_65.Left
        dis_55.Width = dis_65.Width
        dis_55.Height = dis_65.Height
        dis_55.Top = dis_65.Top + dis_65.Height
        dis_55.Font = dis_65.Font
        dis_55.BackColor = Color.White
        dis_50.Left = dis_60.Left
        dis_50.Top = dis_55.Top
        dis_50.Width = dis_60.Width
        dis_50.Height = dis_55.Height
        dis_50.Font = dis_60.Font
        dis_50.BackColor = Color.White
    End Sub

    Private Sub HideCash()
        exchangeBack.Hide()
        exchangebackPrint.Hide()
        DrawColor4.Hide()
        Mon3.Hide()
        cash.Hide()
        VIP.Hide()
    End Sub

    Private Sub ShowCash()
        exchangeBack.Show()
        exchangebackPrint.Show()
        DrawColor4.Show()
        Mon3.Show()
        cash.Show()
        VIP.Show()
    End Sub

    Private Sub HideDisCount()
        DisCount_Draw.Hide()
        Discount_draw1.Hide()
        disCount_I_O.Hide()
        percent.Hide()
        dis_95.Hide()
        dis_90.Hide()
        dis_85.Hide()
        dis_80.Hide()
        dis_75.Hide()
        dis_70.Hide()
        dis_65.Hide()
        dis_60.Hide()
        dis_55.Hide()
        dis_50.Hide()
    End Sub

    Private Sub VIP_click(sender As Object, e As EventArgs) Handles VIP.Click
        If HideCashFlag = False Then
            HideCash()
            '移动应收金额显示
            HideCashFlag = True
            VIP_Show()
            MoveButton()
            WinInCash = False
        End If

    End Sub

    '此函数用来在点击"会员卡"和"现金"按钮来移动按钮坐标
    Private Sub MoveButton()
        If HideCashFlag = True Then
            DrawColor3.Top = DrawColor1.Top + DrawColor1.Height + 80 * index.zoomHeight
            actuallyPay.Top = DrawColor3.Top + 1 * index.zoomHeight
            actuallPayPrint.Top = actuallyPay.Top
            Mon2.Top = actuallyPay.Top
        Else
            DrawColor3.Top = DrawColor1.Top + DrawColor1.Height + 28 * index.zoomHeight
            actuallyPay.Top = DrawColor3.Top + 1 * index.zoomHeight
            actuallPayPrint.Top = actuallyPay.Top
            Mon2.Top = actuallyPay.Top
        End If
    End Sub

    Private Sub CollectNowTime_Tick(sender As Object, e As EventArgs) Handles CollectNowTime.Tick
        NowTime.Text = Format(Now(), "yyyy.mm.dd hh:mm")
    End Sub

    Private Sub YES_Click(sender As Object, e As EventArgs) Handles YES.Click

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If WinInCash = True Then
            Me.Hide()
            purchase.Show()
        Else
            HideCashFlag = False
            MoveButton()
            ShowCash()
            VIP_hide()
            WinInCash = True
        End If
    End Sub

    Private Sub disCount_I_O_KeyPress(sender As Object, e As KeyPressEventArgs) Handles disCount_I_O.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ShowDis()
        DisCount_Draw.Show()
        Discount_draw1.Show()
        disCount_I_O.Show()
        percent.Show()
        dis_95.Show()
        dis_90.Show()
        dis_85.Show()
        dis_80.Show()
        dis_75.Show()
        dis_70.Show()
        dis_65.Show()
        dis_60.Show()
        dis_55.Show()
        dis_50.Show()
    End Sub




    Private Sub discount_Click(sender As Object, e As EventArgs) Handles discount.Click
        ShowDis()
    End Sub

    Private Sub dis_95_Click(sender As Object, e As EventArgs) Handles dis_95.Click
        disCount_I_O.Text = Val(dis_95.Text) * 10
    End Sub

    Private Sub dis_90_Click(sender As Object, e As EventArgs) Handles dis_90.Click
        disCount_I_O.Text = Val(dis_90.Text) * 10
    End Sub

    Private Sub dis_85_Click(sender As Object, e As EventArgs) Handles dis_85.Click
        disCount_I_O.Text = Val(dis_85.Text) * 10
    End Sub

    Private Sub dis_80_Click(sender As Object, e As EventArgs) Handles dis_80.Click
        disCount_I_O.Text = Val(dis_80.Text) * 10
    End Sub

    Private Sub dis_75_Click(sender As Object, e As EventArgs) Handles dis_75.Click
        disCount_I_O.Text = Val(dis_75.Text) * 10
    End Sub

    Private Sub dis_70_Click(sender As Object, e As EventArgs) Handles dis_70.Click
        disCount_I_O.Text = Val(dis_70.Text) * 10
    End Sub

    Private Sub dis_65_Click(sender As Object, e As EventArgs) Handles dis_65.Click
        disCount_I_O.Text = Val(dis_65.Text) * 10
    End Sub

    Private Sub dis_60_Click(sender As Object, e As EventArgs) Handles dis_60.Click
        disCount_I_O.Text = Val(dis_60.Text) * 10
    End Sub

    Private Sub dis_55_Click(sender As Object, e As EventArgs) Handles dis_55.Click
        disCount_I_O.Text = Val(dis_55.Text) * 10
    End Sub

    Private Sub dis_50_Click(sender As Object, e As EventArgs) Handles dis_50.Click
        disCount_I_O.Text = Val(dis_60.Text) * 10
    End Sub

    Private Sub cash_Click(sender As Object, e As EventArgs) Handles cash.Click
        If HideCashFlag = True Then
            ShowCash()
            HideCashFlag = False
        End If
    End Sub


    Private Sub VIP_MouseDown(sender As Object, e As MouseEventArgs) Handles VIP.MouseDown
        VIP.BackColor = Color.FromArgb(&HFF006599)
        cash.BackColor = head.BackColor
    End Sub

    Private Sub VIP_MouseUp(sender As Object, e As MouseEventArgs) Handles VIP.MouseUp
        VIP.BackColor = head.BackColor
        cash.BackColor = Color.FromArgb(&HFF006599)
    End Sub

End Class