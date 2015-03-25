<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Collection
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Collection))
        Me.head = New System.Windows.Forms.Label()
        Me.OperatorMan = New System.Windows.Forms.Label()
        Me.NowTime = New System.Windows.Forms.Label()
        Me.CollectNowTime = New System.Windows.Forms.Timer(Me.components)
        Me.cash = New System.Windows.Forms.Label()
        Me.VIP = New System.Windows.Forms.Label()
        Me.DrawColor = New System.Windows.Forms.Label()
        Me.DrawColor2 = New System.Windows.Forms.Label()
        Me.shouldPay = New System.Windows.Forms.Label()
        Me.actuallyPay = New System.Windows.Forms.Label()
        Me.exchangeBack = New System.Windows.Forms.Label()
        Me.YES = New System.Windows.Forms.Label()
        Me.shouldpayPrint = New System.Windows.Forms.Label()
        Me.actuallPayPrint = New System.Windows.Forms.Label()
        Me.exchangebackPrint = New System.Windows.Forms.Label()
        Me.DrawColor1 = New System.Windows.Forms.Label()
        Me.DrawColor3 = New System.Windows.Forms.Label()
        Me.DrawColor4 = New System.Windows.Forms.Label()
        Me.drawColor5 = New System.Windows.Forms.Label()
        Me.discount = New System.Windows.Forms.Label()
        Me.DisCount_Draw = New System.Windows.Forms.Label()
        Me.Discount_draw1 = New System.Windows.Forms.Label()
        Me.disCount_I_O = New System.Windows.Forms.TextBox()
        Me.percent = New System.Windows.Forms.Label()
        Me.dis_95 = New System.Windows.Forms.Label()
        Me.dis_90 = New System.Windows.Forms.Label()
        Me.dis_85 = New System.Windows.Forms.Label()
        Me.dis_80 = New System.Windows.Forms.Label()
        Me.dis_75 = New System.Windows.Forms.Label()
        Me.dis_70 = New System.Windows.Forms.Label()
        Me.dis_65 = New System.Windows.Forms.Label()
        Me.dis_60 = New System.Windows.Forms.Label()
        Me.dis_55 = New System.Windows.Forms.Label()
        Me.dis_50 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.PictureBox()
        Me.Draw_VIP_color = New System.Windows.Forms.Label()
        Me.Draw_VIP_color1 = New System.Windows.Forms.Label()
        Me.VIP_Card_P = New System.Windows.Forms.Label()
        Me.Card_Name = New System.Windows.Forms.Label()
        Me.Card_phone = New System.Windows.Forms.Label()
        Me.Card_Money = New System.Windows.Forms.Label()
        Me.Card_integral = New System.Windows.Forms.Label()
        Me.Card_ID = New System.Windows.Forms.Label()
        Me.Card_ID_Print = New System.Windows.Forms.Label()
        Me.Card_name_print = New System.Windows.Forms.Label()
        Me.Card_phone_print = New System.Windows.Forms.Label()
        Me.Card_Money_IO = New System.Windows.Forms.TextBox()
        Me.Card_integral_IO = New System.Windows.Forms.TextBox()
        Me.Tip = New System.Windows.Forms.Label()
        Me.charge = New System.Windows.Forms.Label()
        Me.charge1 = New System.Windows.Forms.Label()
        Me.Mon1 = New System.Windows.Forms.Label()
        Me.Mon2 = New System.Windows.Forms.Label()
        Me.Mon3 = New System.Windows.Forms.Label()
        Me.Mon = New System.Windows.Forms.Label()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'head
        '
        Me.head.Location = New System.Drawing.Point(0, 0)
        Me.head.Margin = New System.Windows.Forms.Padding(0)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(0, 0)
        Me.head.TabIndex = 1
        Me.head.Text = "收  款"
        Me.head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OperatorMan
        '
        Me.OperatorMan.Location = New System.Drawing.Point(0, 0)
        Me.OperatorMan.Name = "OperatorMan"
        Me.OperatorMan.Size = New System.Drawing.Size(0, 0)
        Me.OperatorMan.TabIndex = 2
        Me.OperatorMan.Text = "收银员：Luoshengwen"
        '
        'NowTime
        '
        Me.NowTime.Location = New System.Drawing.Point(0, 0)
        Me.NowTime.Margin = New System.Windows.Forms.Padding(0)
        Me.NowTime.Name = "NowTime"
        Me.NowTime.Size = New System.Drawing.Size(0, 0)
        Me.NowTime.TabIndex = 3
        '
        'CollectNowTime
        '
        Me.CollectNowTime.Enabled = True
        Me.CollectNowTime.Interval = 10000
        '
        'cash
        '
        Me.cash.Location = New System.Drawing.Point(0, 0)
        Me.cash.Margin = New System.Windows.Forms.Padding(0)
        Me.cash.Name = "cash"
        Me.cash.Size = New System.Drawing.Size(0, 0)
        Me.cash.TabIndex = 4
        Me.cash.Text = "现金"
        Me.cash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VIP
        '
        Me.VIP.Location = New System.Drawing.Point(0, 0)
        Me.VIP.Margin = New System.Windows.Forms.Padding(0)
        Me.VIP.Name = "VIP"
        Me.VIP.Size = New System.Drawing.Size(0, 0)
        Me.VIP.TabIndex = 5
        Me.VIP.Text = "会员卡"
        Me.VIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DrawColor
        '
        Me.DrawColor.Location = New System.Drawing.Point(0, 0)
        Me.DrawColor.Margin = New System.Windows.Forms.Padding(0)
        Me.DrawColor.Name = "DrawColor"
        Me.DrawColor.Size = New System.Drawing.Size(0, 0)
        Me.DrawColor.TabIndex = 6
        '
        'DrawColor2
        '
        Me.DrawColor2.Location = New System.Drawing.Point(0, 0)
        Me.DrawColor2.Margin = New System.Windows.Forms.Padding(0)
        Me.DrawColor2.Name = "DrawColor2"
        Me.DrawColor2.Size = New System.Drawing.Size(0, 0)
        Me.DrawColor2.TabIndex = 8
        '
        'shouldPay
        '
        Me.shouldPay.Location = New System.Drawing.Point(0, 0)
        Me.shouldPay.Margin = New System.Windows.Forms.Padding(0)
        Me.shouldPay.Name = "shouldPay"
        Me.shouldPay.Size = New System.Drawing.Size(0, 0)
        Me.shouldPay.TabIndex = 9
        Me.shouldPay.Text = "应收金额："
        Me.shouldPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'actuallyPay
        '
        Me.actuallyPay.Location = New System.Drawing.Point(0, 0)
        Me.actuallyPay.Margin = New System.Windows.Forms.Padding(0)
        Me.actuallyPay.Name = "actuallyPay"
        Me.actuallyPay.Size = New System.Drawing.Size(0, 0)
        Me.actuallyPay.TabIndex = 10
        Me.actuallyPay.Text = "实收金额："
        Me.actuallyPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'exchangeBack
        '
        Me.exchangeBack.Location = New System.Drawing.Point(0, 0)
        Me.exchangeBack.Margin = New System.Windows.Forms.Padding(0)
        Me.exchangeBack.Name = "exchangeBack"
        Me.exchangeBack.Size = New System.Drawing.Size(0, 0)
        Me.exchangeBack.TabIndex = 11
        Me.exchangeBack.Text = "找       零： "
        Me.exchangeBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'YES
        '
        Me.YES.Location = New System.Drawing.Point(0, 0)
        Me.YES.Margin = New System.Windows.Forms.Padding(0)
        Me.YES.Name = "YES"
        Me.YES.Size = New System.Drawing.Size(0, 0)
        Me.YES.TabIndex = 12
        Me.YES.Text = "确      定"
        Me.YES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shouldpayPrint
        '
        Me.shouldpayPrint.Location = New System.Drawing.Point(0, 0)
        Me.shouldpayPrint.Margin = New System.Windows.Forms.Padding(0)
        Me.shouldpayPrint.Name = "shouldpayPrint"
        Me.shouldpayPrint.Size = New System.Drawing.Size(0, 0)
        Me.shouldpayPrint.TabIndex = 13
        Me.shouldpayPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'actuallPayPrint
        '
        Me.actuallPayPrint.Location = New System.Drawing.Point(0, 0)
        Me.actuallPayPrint.Margin = New System.Windows.Forms.Padding(0)
        Me.actuallPayPrint.Name = "actuallPayPrint"
        Me.actuallPayPrint.Size = New System.Drawing.Size(0, 0)
        Me.actuallPayPrint.TabIndex = 14
        Me.actuallPayPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exchangebackPrint
        '
        Me.exchangebackPrint.Location = New System.Drawing.Point(0, 0)
        Me.exchangebackPrint.Margin = New System.Windows.Forms.Padding(0)
        Me.exchangebackPrint.Name = "exchangebackPrint"
        Me.exchangebackPrint.Size = New System.Drawing.Size(0, 0)
        Me.exchangebackPrint.TabIndex = 15
        Me.exchangebackPrint.Text = "0.0"
        Me.exchangebackPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DrawColor1
        '
        Me.DrawColor1.Location = New System.Drawing.Point(0, 0)
        Me.DrawColor1.Margin = New System.Windows.Forms.Padding(0)
        Me.DrawColor1.Name = "DrawColor1"
        Me.DrawColor1.Size = New System.Drawing.Size(0, 0)
        Me.DrawColor1.TabIndex = 16
        '
        'DrawColor3
        '
        Me.DrawColor3.Location = New System.Drawing.Point(0, 0)
        Me.DrawColor3.Margin = New System.Windows.Forms.Padding(0)
        Me.DrawColor3.Name = "DrawColor3"
        Me.DrawColor3.Size = New System.Drawing.Size(0, 0)
        Me.DrawColor3.TabIndex = 17
        '
        'DrawColor4
        '
        Me.DrawColor4.Location = New System.Drawing.Point(0, 0)
        Me.DrawColor4.Margin = New System.Windows.Forms.Padding(0)
        Me.DrawColor4.Name = "DrawColor4"
        Me.DrawColor4.Size = New System.Drawing.Size(0, 0)
        Me.DrawColor4.TabIndex = 18
        '
        'drawColor5
        '
        Me.drawColor5.Location = New System.Drawing.Point(0, 0)
        Me.drawColor5.Margin = New System.Windows.Forms.Padding(0)
        Me.drawColor5.Name = "drawColor5"
        Me.drawColor5.Size = New System.Drawing.Size(0, 0)
        Me.drawColor5.TabIndex = 19
        '
        'discount
        '
        Me.discount.Location = New System.Drawing.Point(0, 0)
        Me.discount.Margin = New System.Windows.Forms.Padding(0)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(0, 0)
        Me.discount.TabIndex = 20
        Me.discount.Text = "折扣"
        Me.discount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisCount_Draw
        '
        Me.DisCount_Draw.Location = New System.Drawing.Point(0, 0)
        Me.DisCount_Draw.Margin = New System.Windows.Forms.Padding(0)
        Me.DisCount_Draw.Name = "DisCount_Draw"
        Me.DisCount_Draw.Size = New System.Drawing.Size(0, 0)
        Me.DisCount_Draw.TabIndex = 21
        '
        'Discount_draw1
        '
        Me.Discount_draw1.Location = New System.Drawing.Point(0, 0)
        Me.Discount_draw1.Margin = New System.Windows.Forms.Padding(0)
        Me.Discount_draw1.Name = "Discount_draw1"
        Me.Discount_draw1.Size = New System.Drawing.Size(0, 0)
        Me.Discount_draw1.TabIndex = 22
        '
        'disCount_I_O
        '
        Me.disCount_I_O.Location = New System.Drawing.Point(0, 0)
        Me.disCount_I_O.Margin = New System.Windows.Forms.Padding(0)
        Me.disCount_I_O.Name = "disCount_I_O"
        Me.disCount_I_O.Size = New System.Drawing.Size(0, 21)
        Me.disCount_I_O.TabIndex = 23
        Me.disCount_I_O.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'percent
        '
        Me.percent.Location = New System.Drawing.Point(0, 0)
        Me.percent.Margin = New System.Windows.Forms.Padding(0)
        Me.percent.Name = "percent"
        Me.percent.Size = New System.Drawing.Size(0, 0)
        Me.percent.TabIndex = 24
        Me.percent.Text = "%"
        Me.percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_95
        '
        Me.dis_95.Location = New System.Drawing.Point(0, 0)
        Me.dis_95.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_95.Name = "dis_95"
        Me.dis_95.Size = New System.Drawing.Size(0, 0)
        Me.dis_95.TabIndex = 25
        Me.dis_95.Text = "9.5"
        Me.dis_95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_90
        '
        Me.dis_90.Location = New System.Drawing.Point(0, 0)
        Me.dis_90.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_90.Name = "dis_90"
        Me.dis_90.Size = New System.Drawing.Size(0, 0)
        Me.dis_90.TabIndex = 26
        Me.dis_90.Text = "9.0"
        Me.dis_90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_85
        '
        Me.dis_85.Location = New System.Drawing.Point(0, 0)
        Me.dis_85.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_85.Name = "dis_85"
        Me.dis_85.Size = New System.Drawing.Size(0, 0)
        Me.dis_85.TabIndex = 27
        Me.dis_85.Text = "8.5"
        Me.dis_85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_80
        '
        Me.dis_80.Location = New System.Drawing.Point(0, 0)
        Me.dis_80.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_80.Name = "dis_80"
        Me.dis_80.Size = New System.Drawing.Size(0, 0)
        Me.dis_80.TabIndex = 28
        Me.dis_80.Text = "8.0"
        Me.dis_80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_75
        '
        Me.dis_75.Location = New System.Drawing.Point(0, 0)
        Me.dis_75.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_75.Name = "dis_75"
        Me.dis_75.Size = New System.Drawing.Size(0, 0)
        Me.dis_75.TabIndex = 29
        Me.dis_75.Text = "7.5"
        Me.dis_75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_70
        '
        Me.dis_70.Location = New System.Drawing.Point(0, 0)
        Me.dis_70.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_70.Name = "dis_70"
        Me.dis_70.Size = New System.Drawing.Size(0, 0)
        Me.dis_70.TabIndex = 30
        Me.dis_70.Text = "7.0"
        Me.dis_70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_65
        '
        Me.dis_65.Location = New System.Drawing.Point(0, 0)
        Me.dis_65.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_65.Name = "dis_65"
        Me.dis_65.Size = New System.Drawing.Size(0, 0)
        Me.dis_65.TabIndex = 31
        Me.dis_65.Text = "6.5"
        Me.dis_65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_60
        '
        Me.dis_60.Location = New System.Drawing.Point(0, 0)
        Me.dis_60.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_60.Name = "dis_60"
        Me.dis_60.Size = New System.Drawing.Size(0, 0)
        Me.dis_60.TabIndex = 32
        Me.dis_60.Text = "6.0"
        Me.dis_60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_55
        '
        Me.dis_55.Location = New System.Drawing.Point(0, 0)
        Me.dis_55.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_55.Name = "dis_55"
        Me.dis_55.Size = New System.Drawing.Size(0, 0)
        Me.dis_55.TabIndex = 33
        Me.dis_55.Text = "5.5"
        Me.dis_55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dis_50
        '
        Me.dis_50.Location = New System.Drawing.Point(0, 0)
        Me.dis_50.Margin = New System.Windows.Forms.Padding(0)
        Me.dis_50.Name = "dis_50"
        Me.dis_50.Size = New System.Drawing.Size(0, 0)
        Me.dis_50.TabIndex = 34
        Me.dis_50.Text = "5.0"
        Me.dis_50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(0, 0)
        Me.back.Margin = New System.Windows.Forms.Padding(0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(0, 0)
        Me.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back.TabIndex = 0
        Me.back.TabStop = False
        '
        'Draw_VIP_color
        '
        Me.Draw_VIP_color.Location = New System.Drawing.Point(0, 0)
        Me.Draw_VIP_color.Margin = New System.Windows.Forms.Padding(0)
        Me.Draw_VIP_color.Name = "Draw_VIP_color"
        Me.Draw_VIP_color.Size = New System.Drawing.Size(0, 0)
        Me.Draw_VIP_color.TabIndex = 35
        '
        'Draw_VIP_color1
        '
        Me.Draw_VIP_color1.Location = New System.Drawing.Point(0, 0)
        Me.Draw_VIP_color1.Margin = New System.Windows.Forms.Padding(0)
        Me.Draw_VIP_color1.Name = "Draw_VIP_color1"
        Me.Draw_VIP_color1.Size = New System.Drawing.Size(0, 0)
        Me.Draw_VIP_color1.TabIndex = 36
        '
        'VIP_Card_P
        '
        Me.VIP_Card_P.Location = New System.Drawing.Point(0, 0)
        Me.VIP_Card_P.Margin = New System.Windows.Forms.Padding(0)
        Me.VIP_Card_P.Name = "VIP_Card_P"
        Me.VIP_Card_P.Size = New System.Drawing.Size(0, 0)
        Me.VIP_Card_P.TabIndex = 37
        Me.VIP_Card_P.Text = "会员卡"
        Me.VIP_Card_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Card_Name
        '
        Me.Card_Name.Location = New System.Drawing.Point(0, 0)
        Me.Card_Name.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_Name.Name = "Card_Name"
        Me.Card_Name.Size = New System.Drawing.Size(0, 0)
        Me.Card_Name.TabIndex = 38
        Me.Card_Name.Text = "姓名："
        Me.Card_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Card_phone
        '
        Me.Card_phone.Location = New System.Drawing.Point(0, 0)
        Me.Card_phone.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_phone.Name = "Card_phone"
        Me.Card_phone.Size = New System.Drawing.Size(0, 0)
        Me.Card_phone.TabIndex = 39
        Me.Card_phone.Text = "电话："
        Me.Card_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Card_Money
        '
        Me.Card_Money.Location = New System.Drawing.Point(0, 0)
        Me.Card_Money.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_Money.Name = "Card_Money"
        Me.Card_Money.Size = New System.Drawing.Size(0, 0)
        Me.Card_Money.TabIndex = 40
        Me.Card_Money.Text = "金额："
        Me.Card_Money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Card_integral
        '
        Me.Card_integral.Location = New System.Drawing.Point(0, 0)
        Me.Card_integral.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_integral.Name = "Card_integral"
        Me.Card_integral.Size = New System.Drawing.Size(0, 0)
        Me.Card_integral.TabIndex = 41
        Me.Card_integral.Text = "积分："
        Me.Card_integral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Card_ID
        '
        Me.Card_ID.Location = New System.Drawing.Point(0, 0)
        Me.Card_ID.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_ID.Name = "Card_ID"
        Me.Card_ID.Size = New System.Drawing.Size(0, 0)
        Me.Card_ID.TabIndex = 42
        Me.Card_ID.Text = "卡号："
        Me.Card_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Card_ID_Print
        '
        Me.Card_ID_Print.Location = New System.Drawing.Point(0, 0)
        Me.Card_ID_Print.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_ID_Print.Name = "Card_ID_Print"
        Me.Card_ID_Print.Size = New System.Drawing.Size(0, 0)
        Me.Card_ID_Print.TabIndex = 43
        Me.Card_ID_Print.Text = "0000000001"
        Me.Card_ID_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Card_name_print
        '
        Me.Card_name_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Card_name_print.Location = New System.Drawing.Point(0, 0)
        Me.Card_name_print.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_name_print.Name = "Card_name_print"
        Me.Card_name_print.Size = New System.Drawing.Size(0, 0)
        Me.Card_name_print.TabIndex = 44
        Me.Card_name_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Card_phone_print
        '
        Me.Card_phone_print.Location = New System.Drawing.Point(0, 0)
        Me.Card_phone_print.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_phone_print.Name = "Card_phone_print"
        Me.Card_phone_print.Size = New System.Drawing.Size(0, 0)
        Me.Card_phone_print.TabIndex = 45
        Me.Card_phone_print.Text = "18883287841"
        Me.Card_phone_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Card_Money_IO
        '
        Me.Card_Money_IO.Location = New System.Drawing.Point(0, 0)
        Me.Card_Money_IO.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_Money_IO.Name = "Card_Money_IO"
        Me.Card_Money_IO.Size = New System.Drawing.Size(0, 21)
        Me.Card_Money_IO.TabIndex = 46
        Me.Card_Money_IO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Card_integral_IO
        '
        Me.Card_integral_IO.Location = New System.Drawing.Point(0, 0)
        Me.Card_integral_IO.Margin = New System.Windows.Forms.Padding(0)
        Me.Card_integral_IO.Name = "Card_integral_IO"
        Me.Card_integral_IO.Size = New System.Drawing.Size(0, 21)
        Me.Card_integral_IO.TabIndex = 47
        Me.Card_integral_IO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tip
        '
        Me.Tip.Location = New System.Drawing.Point(0, 0)
        Me.Tip.Name = "Tip"
        Me.Tip.Size = New System.Drawing.Size(0, 0)
        Me.Tip.TabIndex = 48
        Me.Tip.Text = "提示：会员卡余额不足，请先充值"
        Me.Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'charge
        '
        Me.charge.Location = New System.Drawing.Point(0, 0)
        Me.charge.Margin = New System.Windows.Forms.Padding(0)
        Me.charge.Name = "charge"
        Me.charge.Size = New System.Drawing.Size(0, 0)
        Me.charge.TabIndex = 49
        '
        'charge1
        '
        Me.charge1.Location = New System.Drawing.Point(0, 0)
        Me.charge1.Margin = New System.Windows.Forms.Padding(0)
        Me.charge1.Name = "charge1"
        Me.charge1.Size = New System.Drawing.Size(0, 0)
        Me.charge1.TabIndex = 50
        Me.charge1.Text = "充  值"
        Me.charge1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mon1
        '
        Me.Mon1.Location = New System.Drawing.Point(0, 0)
        Me.Mon1.Margin = New System.Windows.Forms.Padding(0)
        Me.Mon1.Name = "Mon1"
        Me.Mon1.Size = New System.Drawing.Size(0, 0)
        Me.Mon1.TabIndex = 51
        Me.Mon1.Text = "￥"
        Me.Mon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mon2
        '
        Me.Mon2.Location = New System.Drawing.Point(0, 0)
        Me.Mon2.Margin = New System.Windows.Forms.Padding(0)
        Me.Mon2.Name = "Mon2"
        Me.Mon2.Size = New System.Drawing.Size(0, 0)
        Me.Mon2.TabIndex = 52
        Me.Mon2.Text = "￥"
        Me.Mon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mon3
        '
        Me.Mon3.Location = New System.Drawing.Point(0, 0)
        Me.Mon3.Margin = New System.Windows.Forms.Padding(0)
        Me.Mon3.Name = "Mon3"
        Me.Mon3.Size = New System.Drawing.Size(0, 0)
        Me.Mon3.TabIndex = 53
        Me.Mon3.Text = "￥"
        Me.Mon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mon
        '
        Me.Mon.Location = New System.Drawing.Point(0, 0)
        Me.Mon.Margin = New System.Windows.Forms.Padding(0)
        Me.Mon.Name = "Mon"
        Me.Mon.Size = New System.Drawing.Size(0, 0)
        Me.Mon.TabIndex = 54
        Me.Mon.Text = "￥"
        Me.Mon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Collection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(135, 118)
        Me.Controls.Add(Me.Mon)
        Me.Controls.Add(Me.Mon3)
        Me.Controls.Add(Me.Mon2)
        Me.Controls.Add(Me.Mon1)
        Me.Controls.Add(Me.charge1)
        Me.Controls.Add(Me.charge)
        Me.Controls.Add(Me.Tip)
        Me.Controls.Add(Me.Card_integral_IO)
        Me.Controls.Add(Me.Card_Money_IO)
        Me.Controls.Add(Me.Card_phone_print)
        Me.Controls.Add(Me.Card_name_print)
        Me.Controls.Add(Me.Card_ID_Print)
        Me.Controls.Add(Me.Card_ID)
        Me.Controls.Add(Me.Card_integral)
        Me.Controls.Add(Me.Card_Money)
        Me.Controls.Add(Me.Card_phone)
        Me.Controls.Add(Me.Card_Name)
        Me.Controls.Add(Me.VIP_Card_P)
        Me.Controls.Add(Me.Draw_VIP_color1)
        Me.Controls.Add(Me.Draw_VIP_color)
        Me.Controls.Add(Me.dis_50)
        Me.Controls.Add(Me.dis_55)
        Me.Controls.Add(Me.dis_60)
        Me.Controls.Add(Me.dis_65)
        Me.Controls.Add(Me.dis_70)
        Me.Controls.Add(Me.dis_75)
        Me.Controls.Add(Me.dis_80)
        Me.Controls.Add(Me.dis_85)
        Me.Controls.Add(Me.dis_90)
        Me.Controls.Add(Me.dis_95)
        Me.Controls.Add(Me.percent)
        Me.Controls.Add(Me.disCount_I_O)
        Me.Controls.Add(Me.Discount_draw1)
        Me.Controls.Add(Me.DisCount_Draw)
        Me.Controls.Add(Me.discount)
        Me.Controls.Add(Me.drawColor5)
        Me.Controls.Add(Me.exchangebackPrint)
        Me.Controls.Add(Me.actuallPayPrint)
        Me.Controls.Add(Me.shouldpayPrint)
        Me.Controls.Add(Me.YES)
        Me.Controls.Add(Me.exchangeBack)
        Me.Controls.Add(Me.actuallyPay)
        Me.Controls.Add(Me.shouldPay)
        Me.Controls.Add(Me.DrawColor4)
        Me.Controls.Add(Me.DrawColor3)
        Me.Controls.Add(Me.DrawColor1)
        Me.Controls.Add(Me.DrawColor2)
        Me.Controls.Add(Me.DrawColor)
        Me.Controls.Add(Me.VIP)
        Me.Controls.Add(Me.cash)
        Me.Controls.Add(Me.NowTime)
        Me.Controls.Add(Me.OperatorMan)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Collection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents OperatorMan As System.Windows.Forms.Label
    Friend WithEvents NowTime As System.Windows.Forms.Label
    Friend WithEvents CollectNowTime As System.Windows.Forms.Timer
    Friend WithEvents cash As System.Windows.Forms.Label
    Friend WithEvents VIP As System.Windows.Forms.Label
    Friend WithEvents DrawColor As System.Windows.Forms.Label
    Friend WithEvents DrawColor1 As System.Windows.Forms.Label
    Friend WithEvents DrawColor2 As System.Windows.Forms.Label
    Friend WithEvents shouldPay As System.Windows.Forms.Label
    Friend WithEvents actuallyPay As System.Windows.Forms.Label
    Friend WithEvents exchangeBack As System.Windows.Forms.Label
    Friend WithEvents YES As System.Windows.Forms.Label
    Friend WithEvents shouldpayPrint As System.Windows.Forms.Label
    Friend WithEvents actuallPayPrint As System.Windows.Forms.Label
    Friend WithEvents exchangebackPrint As System.Windows.Forms.Label
    Friend WithEvents DrawColor3 As System.Windows.Forms.Label
    Friend WithEvents DrawColor4 As System.Windows.Forms.Label
    Friend WithEvents drawColor5 As System.Windows.Forms.Label
    Friend WithEvents discount As System.Windows.Forms.Label
    Friend WithEvents DisCount_Draw As System.Windows.Forms.Label
    Friend WithEvents Discount_draw1 As System.Windows.Forms.Label
    Friend WithEvents disCount_I_O As System.Windows.Forms.TextBox
    Friend WithEvents percent As System.Windows.Forms.Label
    Friend WithEvents dis_95 As System.Windows.Forms.Label
    Friend WithEvents dis_90 As System.Windows.Forms.Label
    Friend WithEvents dis_85 As System.Windows.Forms.Label
    Friend WithEvents dis_80 As System.Windows.Forms.Label
    Friend WithEvents dis_75 As System.Windows.Forms.Label
    Friend WithEvents dis_70 As System.Windows.Forms.Label
    Friend WithEvents dis_65 As System.Windows.Forms.Label
    Friend WithEvents dis_60 As System.Windows.Forms.Label
    Friend WithEvents dis_55 As System.Windows.Forms.Label
    Friend WithEvents dis_50 As System.Windows.Forms.Label
    Friend WithEvents Draw_VIP_color As System.Windows.Forms.Label
    Friend WithEvents Draw_VIP_color1 As System.Windows.Forms.Label
    Friend WithEvents VIP_Card_P As System.Windows.Forms.Label
    Friend WithEvents Card_Name As System.Windows.Forms.Label
    Friend WithEvents Card_phone As System.Windows.Forms.Label
    Friend WithEvents Card_Money As System.Windows.Forms.Label
    Friend WithEvents Card_integral As System.Windows.Forms.Label
    Friend WithEvents Card_ID As System.Windows.Forms.Label
    Friend WithEvents Card_ID_Print As System.Windows.Forms.Label
    Friend WithEvents Card_name_print As System.Windows.Forms.Label
    Friend WithEvents Card_phone_print As System.Windows.Forms.Label
    Friend WithEvents Card_Money_IO As System.Windows.Forms.TextBox
    Friend WithEvents Card_integral_IO As System.Windows.Forms.TextBox
    Friend WithEvents Tip As System.Windows.Forms.Label
    Friend WithEvents charge As System.Windows.Forms.Label
    Friend WithEvents charge1 As System.Windows.Forms.Label
    Friend WithEvents Mon1 As System.Windows.Forms.Label
    Friend WithEvents Mon2 As System.Windows.Forms.Label
    Friend WithEvents Mon3 As System.Windows.Forms.Label
    Friend WithEvents Mon As System.Windows.Forms.Label

End Class
