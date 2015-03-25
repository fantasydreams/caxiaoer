<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExchangeWorkWin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExchangeWorkWin))
        Me.back = New System.Windows.Forms.PictureBox()
        Me.head = New System.Windows.Forms.Label()
        Me.Opera = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NowTime = New System.Windows.Forms.Label()
        Me.DrawBackLine = New System.Windows.Forms.Label()
        Me.DrawBackcolor = New System.Windows.Forms.Label()
        Me.DrawJobLine = New System.Windows.Forms.Label()
        Me.OperaMan = New System.Windows.Forms.Label()
        Me.DrawOperaBackColor = New System.Windows.Forms.Label()
        Me.OperaManPrint = New System.Windows.Forms.Label()
        Me.AllCountLine = New System.Windows.Forms.Label()
        Me.DrawAllCountBack = New System.Windows.Forms.Label()
        Me.AllCount = New System.Windows.Forms.Label()
        Me.AllCountPrint = New System.Windows.Forms.Label()
        Me.AllMoney = New System.Windows.Forms.Label()
        Me.AllCountMoneyBack = New System.Windows.Forms.Label()
        Me.ALLcash = New System.Windows.Forms.Label()
        Me.AllCashPrint = New System.Windows.Forms.Label()
        Me.AllSoldMoneyLine = New System.Windows.Forms.Label()
        Me.ALLMoneyBackColor = New System.Windows.Forms.Label()
        Me.AllSoldMoney = New System.Windows.Forms.Label()
        Me.AllSoldMoneyPrint = New System.Windows.Forms.Label()
        Me.CashPayLine = New System.Windows.Forms.Label()
        Me.CashPayBackcolor = New System.Windows.Forms.Label()
        Me.cashPay = New System.Windows.Forms.Label()
        Me.cashPayPrint = New System.Windows.Forms.Label()
        Me.VIP_Pay_Line = New System.Windows.Forms.Label()
        Me.VIP_Pay = New System.Windows.Forms.Label()
        Me.DrawVIPPayBack = New System.Windows.Forms.Label()
        Me.VIP_PayPrint = New System.Windows.Forms.Label()
        Me.VIP_charge_line = New System.Windows.Forms.Label()
        Me.VIP_charge_back = New System.Windows.Forms.Label()
        Me.VIP_Charge = New System.Windows.Forms.Label()
        Me.VIP_charge_print = New System.Windows.Forms.Label()
        Me.Sure_backcolor = New System.Windows.Forms.Label()
        Me.sure_line = New System.Windows.Forms.Label()
        Me.NowTimeAndDate = New System.Windows.Forms.Label()
        Me.Yes_Line = New System.Windows.Forms.Label()
        Me.Yes_color = New System.Windows.Forms.Label()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(0, 0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(0, 0)
        Me.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back.TabIndex = 0
        Me.back.TabStop = False
        '
        'head
        '
        Me.head.Location = New System.Drawing.Point(0, 0)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(0, 0)
        Me.head.TabIndex = 1
        Me.head.Text = "交接班"
        Me.head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Opera
        '
        Me.Opera.Location = New System.Drawing.Point(0, 0)
        Me.Opera.Name = "Opera"
        Me.Opera.Size = New System.Drawing.Size(0, 0)
        Me.Opera.TabIndex = 2
        Me.Opera.Text = "操作员：luoshengwen"
        Me.Opera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer
        '
        Me.Timer.Interval = 10000
        '
        'NowTime
        '
        Me.NowTime.Location = New System.Drawing.Point(0, 0)
        Me.NowTime.Name = "NowTime"
        Me.NowTime.Size = New System.Drawing.Size(0, 0)
        Me.NowTime.TabIndex = 3
        Me.NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DrawBackLine
        '
        Me.DrawBackLine.Location = New System.Drawing.Point(0, 0)
        Me.DrawBackLine.Name = "DrawBackLine"
        Me.DrawBackLine.Size = New System.Drawing.Size(0, 0)
        Me.DrawBackLine.TabIndex = 4
        '
        'DrawBackcolor
        '
        Me.DrawBackcolor.Location = New System.Drawing.Point(0, 0)
        Me.DrawBackcolor.Name = "DrawBackcolor"
        Me.DrawBackcolor.Size = New System.Drawing.Size(0, 0)
        Me.DrawBackcolor.TabIndex = 5
        '
        'DrawJobLine
        '
        Me.DrawJobLine.Location = New System.Drawing.Point(0, 0)
        Me.DrawJobLine.Name = "DrawJobLine"
        Me.DrawJobLine.Size = New System.Drawing.Size(0, 0)
        Me.DrawJobLine.TabIndex = 6
        '
        'OperaMan
        '
        Me.OperaMan.Location = New System.Drawing.Point(0, 0)
        Me.OperaMan.Name = "OperaMan"
        Me.OperaMan.Size = New System.Drawing.Size(0, 0)
        Me.OperaMan.TabIndex = 7
        Me.OperaMan.Text = "收银员："
        Me.OperaMan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DrawOperaBackColor
        '
        Me.DrawOperaBackColor.Location = New System.Drawing.Point(0, 0)
        Me.DrawOperaBackColor.Name = "DrawOperaBackColor"
        Me.DrawOperaBackColor.Size = New System.Drawing.Size(0, 0)
        Me.DrawOperaBackColor.TabIndex = 8
        '
        'OperaManPrint
        '
        Me.OperaManPrint.Location = New System.Drawing.Point(0, 0)
        Me.OperaManPrint.Name = "OperaManPrint"
        Me.OperaManPrint.Size = New System.Drawing.Size(0, 0)
        Me.OperaManPrint.TabIndex = 9
        Me.OperaManPrint.Text = "Luoshengwen"
        Me.OperaManPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AllCountLine
        '
        Me.AllCountLine.Location = New System.Drawing.Point(0, 0)
        Me.AllCountLine.Name = "AllCountLine"
        Me.AllCountLine.Size = New System.Drawing.Size(0, 0)
        Me.AllCountLine.TabIndex = 10
        '
        'DrawAllCountBack
        '
        Me.DrawAllCountBack.Location = New System.Drawing.Point(0, 0)
        Me.DrawAllCountBack.Name = "DrawAllCountBack"
        Me.DrawAllCountBack.Size = New System.Drawing.Size(0, 0)
        Me.DrawAllCountBack.TabIndex = 11
        '
        'AllCount
        '
        Me.AllCount.Location = New System.Drawing.Point(0, 0)
        Me.AllCount.Name = "AllCount"
        Me.AllCount.Size = New System.Drawing.Size(0, 0)
        Me.AllCount.TabIndex = 12
        Me.AllCount.Text = "总单数："
        Me.AllCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AllCountPrint
        '
        Me.AllCountPrint.Location = New System.Drawing.Point(0, 0)
        Me.AllCountPrint.Name = "AllCountPrint"
        Me.AllCountPrint.Size = New System.Drawing.Size(0, 0)
        Me.AllCountPrint.TabIndex = 13
        Me.AllCountPrint.Text = "88"
        Me.AllCountPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AllMoney
        '
        Me.AllMoney.Location = New System.Drawing.Point(0, 0)
        Me.AllMoney.Name = "AllMoney"
        Me.AllMoney.Size = New System.Drawing.Size(0, 0)
        Me.AllMoney.TabIndex = 14
        '
        'AllCountMoneyBack
        '
        Me.AllCountMoneyBack.Location = New System.Drawing.Point(0, 0)
        Me.AllCountMoneyBack.Name = "AllCountMoneyBack"
        Me.AllCountMoneyBack.Size = New System.Drawing.Size(0, 0)
        Me.AllCountMoneyBack.TabIndex = 15
        '
        'ALLcash
        '
        Me.ALLcash.Location = New System.Drawing.Point(0, 0)
        Me.ALLcash.Name = "ALLcash"
        Me.ALLcash.Size = New System.Drawing.Size(0, 0)
        Me.ALLcash.TabIndex = 16
        Me.ALLcash.Text = "总现金："
        Me.ALLcash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AllCashPrint
        '
        Me.AllCashPrint.Location = New System.Drawing.Point(0, 0)
        Me.AllCashPrint.Name = "AllCashPrint"
        Me.AllCashPrint.Size = New System.Drawing.Size(0, 0)
        Me.AllCashPrint.TabIndex = 17
        Me.AllCashPrint.Text = "888.8"
        Me.AllCashPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AllSoldMoneyLine
        '
        Me.AllSoldMoneyLine.Location = New System.Drawing.Point(0, 0)
        Me.AllSoldMoneyLine.Name = "AllSoldMoneyLine"
        Me.AllSoldMoneyLine.Size = New System.Drawing.Size(0, 0)
        Me.AllSoldMoneyLine.TabIndex = 18
        '
        'ALLMoneyBackColor
        '
        Me.ALLMoneyBackColor.Location = New System.Drawing.Point(0, 0)
        Me.ALLMoneyBackColor.Name = "ALLMoneyBackColor"
        Me.ALLMoneyBackColor.Size = New System.Drawing.Size(0, 0)
        Me.ALLMoneyBackColor.TabIndex = 19
        '
        'AllSoldMoney
        '
        Me.AllSoldMoney.Location = New System.Drawing.Point(0, 0)
        Me.AllSoldMoney.Name = "AllSoldMoney"
        Me.AllSoldMoney.Size = New System.Drawing.Size(0, 0)
        Me.AllSoldMoney.TabIndex = 20
        Me.AllSoldMoney.Text = "总销售额："
        Me.AllSoldMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AllSoldMoneyPrint
        '
        Me.AllSoldMoneyPrint.Location = New System.Drawing.Point(0, 0)
        Me.AllSoldMoneyPrint.Name = "AllSoldMoneyPrint"
        Me.AllSoldMoneyPrint.Size = New System.Drawing.Size(0, 0)
        Me.AllSoldMoneyPrint.TabIndex = 21
        Me.AllSoldMoneyPrint.Text = "88888.8"
        Me.AllSoldMoneyPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CashPayLine
        '
        Me.CashPayLine.Location = New System.Drawing.Point(0, 0)
        Me.CashPayLine.Name = "CashPayLine"
        Me.CashPayLine.Size = New System.Drawing.Size(0, 0)
        Me.CashPayLine.TabIndex = 22
        '
        'CashPayBackcolor
        '
        Me.CashPayBackcolor.Location = New System.Drawing.Point(0, 0)
        Me.CashPayBackcolor.Name = "CashPayBackcolor"
        Me.CashPayBackcolor.Size = New System.Drawing.Size(0, 0)
        Me.CashPayBackcolor.TabIndex = 23
        '
        'cashPay
        '
        Me.cashPay.Location = New System.Drawing.Point(0, 0)
        Me.cashPay.Name = "cashPay"
        Me.cashPay.Size = New System.Drawing.Size(0, 0)
        Me.cashPay.TabIndex = 24
        Me.cashPay.Text = "现金支付："
        Me.cashPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cashPayPrint
        '
        Me.cashPayPrint.Location = New System.Drawing.Point(0, 0)
        Me.cashPayPrint.Name = "cashPayPrint"
        Me.cashPayPrint.Size = New System.Drawing.Size(0, 0)
        Me.cashPayPrint.TabIndex = 25
        Me.cashPayPrint.Text = "8888.8"
        Me.cashPayPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VIP_Pay_Line
        '
        Me.VIP_Pay_Line.Location = New System.Drawing.Point(0, 0)
        Me.VIP_Pay_Line.Name = "VIP_Pay_Line"
        Me.VIP_Pay_Line.Size = New System.Drawing.Size(0, 0)
        Me.VIP_Pay_Line.TabIndex = 26
        '
        'VIP_Pay
        '
        Me.VIP_Pay.Location = New System.Drawing.Point(0, 0)
        Me.VIP_Pay.Name = "VIP_Pay"
        Me.VIP_Pay.Size = New System.Drawing.Size(0, 0)
        Me.VIP_Pay.TabIndex = 27
        Me.VIP_Pay.Text = "会员卡支付："
        Me.VIP_Pay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DrawVIPPayBack
        '
        Me.DrawVIPPayBack.Location = New System.Drawing.Point(0, 0)
        Me.DrawVIPPayBack.Name = "DrawVIPPayBack"
        Me.DrawVIPPayBack.Size = New System.Drawing.Size(0, 0)
        Me.DrawVIPPayBack.TabIndex = 28
        '
        'VIP_PayPrint
        '
        Me.VIP_PayPrint.Location = New System.Drawing.Point(0, 0)
        Me.VIP_PayPrint.Name = "VIP_PayPrint"
        Me.VIP_PayPrint.Size = New System.Drawing.Size(0, 0)
        Me.VIP_PayPrint.TabIndex = 29
        Me.VIP_PayPrint.Text = "8888.8"
        Me.VIP_PayPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VIP_charge_line
        '
        Me.VIP_charge_line.Location = New System.Drawing.Point(0, 0)
        Me.VIP_charge_line.Name = "VIP_charge_line"
        Me.VIP_charge_line.Size = New System.Drawing.Size(0, 0)
        Me.VIP_charge_line.TabIndex = 30
        '
        'VIP_charge_back
        '
        Me.VIP_charge_back.Location = New System.Drawing.Point(0, 0)
        Me.VIP_charge_back.Name = "VIP_charge_back"
        Me.VIP_charge_back.Size = New System.Drawing.Size(0, 0)
        Me.VIP_charge_back.TabIndex = 31
        '
        'VIP_Charge
        '
        Me.VIP_Charge.Location = New System.Drawing.Point(0, 0)
        Me.VIP_Charge.Name = "VIP_Charge"
        Me.VIP_Charge.Size = New System.Drawing.Size(0, 0)
        Me.VIP_Charge.TabIndex = 32
        Me.VIP_Charge.Text = "会员充值："
        Me.VIP_Charge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VIP_charge_print
        '
        Me.VIP_charge_print.Location = New System.Drawing.Point(0, 0)
        Me.VIP_charge_print.Name = "VIP_charge_print"
        Me.VIP_charge_print.Size = New System.Drawing.Size(0, 0)
        Me.VIP_charge_print.TabIndex = 33
        Me.VIP_charge_print.Text = "88888.8"
        Me.VIP_charge_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Sure_backcolor
        '
        Me.Sure_backcolor.Location = New System.Drawing.Point(0, 0)
        Me.Sure_backcolor.Name = "Sure_backcolor"
        Me.Sure_backcolor.Size = New System.Drawing.Size(0, 0)
        Me.Sure_backcolor.TabIndex = 34
        Me.Sure_backcolor.Text = "打印结果"
        Me.Sure_backcolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sure_line
        '
        Me.sure_line.Location = New System.Drawing.Point(0, 0)
        Me.sure_line.Name = "sure_line"
        Me.sure_line.Size = New System.Drawing.Size(0, 0)
        Me.sure_line.TabIndex = 35
        '
        'NowTimeAndDate
        '
        Me.NowTimeAndDate.Location = New System.Drawing.Point(0, 0)
        Me.NowTimeAndDate.Name = "NowTimeAndDate"
        Me.NowTimeAndDate.Size = New System.Drawing.Size(0, 0)
        Me.NowTimeAndDate.TabIndex = 36
        Me.NowTimeAndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Yes_Line
        '
        Me.Yes_Line.Location = New System.Drawing.Point(0, 0)
        Me.Yes_Line.Name = "Yes_Line"
        Me.Yes_Line.Size = New System.Drawing.Size(0, 0)
        Me.Yes_Line.TabIndex = 37
        '
        'Yes_color
        '
        Me.Yes_color.Location = New System.Drawing.Point(0, 0)
        Me.Yes_color.Name = "Yes_color"
        Me.Yes_color.Size = New System.Drawing.Size(0, 0)
        Me.Yes_color.TabIndex = 38
        Me.Yes_color.Text = "交接班并登出"
        Me.Yes_color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExchangeWorkWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(91, 71)
        Me.Controls.Add(Me.Yes_color)
        Me.Controls.Add(Me.Yes_Line)
        Me.Controls.Add(Me.NowTimeAndDate)
        Me.Controls.Add(Me.Sure_backcolor)
        Me.Controls.Add(Me.sure_line)
        Me.Controls.Add(Me.VIP_charge_print)
        Me.Controls.Add(Me.VIP_Charge)
        Me.Controls.Add(Me.VIP_charge_back)
        Me.Controls.Add(Me.VIP_charge_line)
        Me.Controls.Add(Me.VIP_PayPrint)
        Me.Controls.Add(Me.VIP_Pay)
        Me.Controls.Add(Me.DrawVIPPayBack)
        Me.Controls.Add(Me.VIP_Pay_Line)
        Me.Controls.Add(Me.cashPayPrint)
        Me.Controls.Add(Me.cashPay)
        Me.Controls.Add(Me.CashPayBackcolor)
        Me.Controls.Add(Me.CashPayLine)
        Me.Controls.Add(Me.AllSoldMoneyPrint)
        Me.Controls.Add(Me.AllSoldMoney)
        Me.Controls.Add(Me.ALLMoneyBackColor)
        Me.Controls.Add(Me.AllSoldMoneyLine)
        Me.Controls.Add(Me.AllCashPrint)
        Me.Controls.Add(Me.ALLcash)
        Me.Controls.Add(Me.AllCountMoneyBack)
        Me.Controls.Add(Me.AllMoney)
        Me.Controls.Add(Me.AllCountPrint)
        Me.Controls.Add(Me.AllCount)
        Me.Controls.Add(Me.DrawAllCountBack)
        Me.Controls.Add(Me.AllCountLine)
        Me.Controls.Add(Me.OperaManPrint)
        Me.Controls.Add(Me.OperaMan)
        Me.Controls.Add(Me.DrawOperaBackColor)
        Me.Controls.Add(Me.DrawJobLine)
        Me.Controls.Add(Me.DrawBackcolor)
        Me.Controls.Add(Me.DrawBackLine)
        Me.Controls.Add(Me.NowTime)
        Me.Controls.Add(Me.Opera)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExchangeWorkWin"
        Me.Text = "ExchangeWorkWin"
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents Opera As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents NowTime As System.Windows.Forms.Label
    Friend WithEvents DrawBackLine As System.Windows.Forms.Label
    Friend WithEvents DrawBackcolor As System.Windows.Forms.Label
    Friend WithEvents DrawJobLine As System.Windows.Forms.Label
    Friend WithEvents OperaMan As System.Windows.Forms.Label
    Friend WithEvents DrawOperaBackColor As System.Windows.Forms.Label
    Friend WithEvents OperaManPrint As System.Windows.Forms.Label
    Friend WithEvents AllCountLine As System.Windows.Forms.Label
    Friend WithEvents DrawAllCountBack As System.Windows.Forms.Label
    Friend WithEvents AllCount As System.Windows.Forms.Label
    Friend WithEvents AllCountPrint As System.Windows.Forms.Label
    Friend WithEvents AllMoney As System.Windows.Forms.Label
    Friend WithEvents AllCountMoneyBack As System.Windows.Forms.Label
    Friend WithEvents ALLcash As System.Windows.Forms.Label
    Friend WithEvents AllCashPrint As System.Windows.Forms.Label
    Friend WithEvents AllSoldMoneyLine As System.Windows.Forms.Label
    Friend WithEvents ALLMoneyBackColor As System.Windows.Forms.Label
    Friend WithEvents AllSoldMoney As System.Windows.Forms.Label
    Friend WithEvents AllSoldMoneyPrint As System.Windows.Forms.Label
    Friend WithEvents CashPayLine As System.Windows.Forms.Label
    Friend WithEvents CashPayBackcolor As System.Windows.Forms.Label
    Friend WithEvents cashPay As System.Windows.Forms.Label
    Friend WithEvents cashPayPrint As System.Windows.Forms.Label
    Friend WithEvents VIP_Pay_Line As System.Windows.Forms.Label
    Friend WithEvents VIP_Pay As System.Windows.Forms.Label
    Friend WithEvents DrawVIPPayBack As System.Windows.Forms.Label
    Friend WithEvents VIP_PayPrint As System.Windows.Forms.Label
    Friend WithEvents VIP_charge_line As System.Windows.Forms.Label
    Friend WithEvents VIP_charge_back As System.Windows.Forms.Label
    Friend WithEvents VIP_Charge As System.Windows.Forms.Label
    Friend WithEvents VIP_charge_print As System.Windows.Forms.Label
    Friend WithEvents Sure_backcolor As System.Windows.Forms.Label
    Friend WithEvents sure_line As System.Windows.Forms.Label
    Friend WithEvents NowTimeAndDate As System.Windows.Forms.Label
    Friend WithEvents Yes_Line As System.Windows.Forms.Label
    Friend WithEvents Yes_color As System.Windows.Forms.Label
End Class
