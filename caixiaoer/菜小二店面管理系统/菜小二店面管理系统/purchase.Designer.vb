<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchase))
        Me.cx_name = New System.Windows.Forms.Label()
        Me.head = New System.Windows.Forms.Label()
        Me.MinBackColor = New System.Windows.Forms.Label()
        Me.updatetime = New System.Windows.Forms.Timer(Me.components)
        Me.Nowtime = New System.Windows.Forms.Label()
        Me.under_head = New System.Windows.Forms.Label()
        Me.line = New System.Windows.Forms.Label()
        Me.wordPrint = New System.Windows.Forms.Label()
        Me.Drawbackcolor = New System.Windows.Forms.Label()
        Me.PurchaseNum = New System.Windows.Forms.Label()
        Me.line2 = New System.Windows.Forms.Label()
        Me.AllProduct = New System.Windows.Forms.Label()
        Me.fruit = New System.Windows.Forms.Label()
        Me.fruit_juice = New System.Windows.Forms.Label()
        Me.Fresh_fruit_box = New System.Windows.Forms.Label()
        Me.DIY = New System.Windows.Forms.Label()
        Me.clearFruit = New System.Windows.Forms.PictureBox()
        Me.Drawunder = New System.Windows.Forms.Label()
        Me.drawcolor2 = New System.Windows.Forms.Label()
        Me.charge = New System.Windows.Forms.Label()
        Me.purchaseMoney = New System.Windows.Forms.Label()
        Me.Drawline3 = New System.Windows.Forms.Label()
        Me.ProductCount = New System.Windows.Forms.Label()
        Me.Min = New System.Windows.Forms.PictureBox()
        Me.MaxBackColor = New System.Windows.Forms.Label()
        Me.Close_P = New System.Windows.Forms.PictureBox()
        Me.OpenMoneyBox = New System.Windows.Forms.Label()
        Me.MoneyBox = New System.Windows.Forms.PictureBox()
        Me.ExchangeWork = New System.Windows.Forms.PictureBox()
        Me.AddVIP = New System.Windows.Forms.PictureBox()
        Me.VIPcharge = New System.Windows.Forms.PictureBox()
        Me.ReturnINdex = New System.Windows.Forms.PictureBox()
        Me.opera_Name = New System.Windows.Forms.Label()
        CType(Me.clearFruit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExchangeWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddVIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIPcharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnINdex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cx_name
        '
        Me.cx_name.BackColor = System.Drawing.Color.RoyalBlue
        Me.cx_name.Location = New System.Drawing.Point(0, 0)
        Me.cx_name.Margin = New System.Windows.Forms.Padding(0)
        Me.cx_name.Name = "cx_name"
        Me.cx_name.Size = New System.Drawing.Size(0, 0)
        Me.cx_name.TabIndex = 0
        Me.cx_name.Text = "菜小二收银系统"
        Me.cx_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'head
        '
        Me.head.Location = New System.Drawing.Point(0, 0)
        Me.head.Margin = New System.Windows.Forms.Padding(0)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(0, 0)
        Me.head.TabIndex = 2
        '
        'MinBackColor
        '
        Me.MinBackColor.Location = New System.Drawing.Point(217, 9)
        Me.MinBackColor.Name = "MinBackColor"
        Me.MinBackColor.Size = New System.Drawing.Size(100, 22)
        Me.MinBackColor.TabIndex = 3
        '
        'updatetime
        '
        Me.updatetime.Enabled = True
        Me.updatetime.Interval = 60000
        '
        'Nowtime
        '
        Me.Nowtime.Location = New System.Drawing.Point(194, 0)
        Me.Nowtime.Name = "Nowtime"
        Me.Nowtime.Size = New System.Drawing.Size(68, 23)
        Me.Nowtime.TabIndex = 6
        '
        'under_head
        '
        Me.under_head.Location = New System.Drawing.Point(0, 0)
        Me.under_head.Margin = New System.Windows.Forms.Padding(0)
        Me.under_head.Name = "under_head"
        Me.under_head.Size = New System.Drawing.Size(0, 0)
        Me.under_head.TabIndex = 9
        '
        'line
        '
        Me.line.Location = New System.Drawing.Point(0, 0)
        Me.line.Margin = New System.Windows.Forms.Padding(0)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(0, 0)
        Me.line.TabIndex = 10
        '
        'wordPrint
        '
        Me.wordPrint.Location = New System.Drawing.Point(0, 0)
        Me.wordPrint.Margin = New System.Windows.Forms.Padding(0)
        Me.wordPrint.Name = "wordPrint"
        Me.wordPrint.Size = New System.Drawing.Size(0, 0)
        Me.wordPrint.TabIndex = 11
        Me.wordPrint.Text = "总计：       件"
        '
        'Drawbackcolor
        '
        Me.Drawbackcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Drawbackcolor.Location = New System.Drawing.Point(0, 0)
        Me.Drawbackcolor.Margin = New System.Windows.Forms.Padding(0)
        Me.Drawbackcolor.Name = "Drawbackcolor"
        Me.Drawbackcolor.Size = New System.Drawing.Size(0, 0)
        Me.Drawbackcolor.TabIndex = 12
        '
        'PurchaseNum
        '
        Me.PurchaseNum.Location = New System.Drawing.Point(0, 0)
        Me.PurchaseNum.Margin = New System.Windows.Forms.Padding(0)
        Me.PurchaseNum.Name = "PurchaseNum"
        Me.PurchaseNum.Size = New System.Drawing.Size(0, 0)
        Me.PurchaseNum.TabIndex = 13
        Me.PurchaseNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'line2
        '
        Me.line2.Location = New System.Drawing.Point(0, 0)
        Me.line2.Margin = New System.Windows.Forms.Padding(0)
        Me.line2.Name = "line2"
        Me.line2.Size = New System.Drawing.Size(0, 0)
        Me.line2.TabIndex = 14
        '
        'AllProduct
        '
        Me.AllProduct.Location = New System.Drawing.Point(0, 0)
        Me.AllProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.AllProduct.Name = "AllProduct"
        Me.AllProduct.Size = New System.Drawing.Size(0, 0)
        Me.AllProduct.TabIndex = 15
        Me.AllProduct.Text = "全部商品"
        Me.AllProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fruit
        '
        Me.fruit.Location = New System.Drawing.Point(0, 0)
        Me.fruit.Margin = New System.Windows.Forms.Padding(0)
        Me.fruit.Name = "fruit"
        Me.fruit.Size = New System.Drawing.Size(0, 0)
        Me.fruit.TabIndex = 16
        Me.fruit.Text = "鲜果切"
        Me.fruit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fruit_juice
        '
        Me.fruit_juice.Location = New System.Drawing.Point(0, 0)
        Me.fruit_juice.Margin = New System.Windows.Forms.Padding(0)
        Me.fruit_juice.Name = "fruit_juice"
        Me.fruit_juice.Size = New System.Drawing.Size(0, 0)
        Me.fruit_juice.TabIndex = 17
        Me.fruit_juice.Text = "鲜果汁"
        Me.fruit_juice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fresh_fruit_box
        '
        Me.Fresh_fruit_box.Location = New System.Drawing.Point(0, 0)
        Me.Fresh_fruit_box.Margin = New System.Windows.Forms.Padding(0)
        Me.Fresh_fruit_box.Name = "Fresh_fruit_box"
        Me.Fresh_fruit_box.Size = New System.Drawing.Size(0, 0)
        Me.Fresh_fruit_box.TabIndex = 18
        Me.Fresh_fruit_box.Text = "鲜果盒"
        Me.Fresh_fruit_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DIY
        '
        Me.DIY.Location = New System.Drawing.Point(0, 0)
        Me.DIY.Margin = New System.Windows.Forms.Padding(0)
        Me.DIY.Name = "DIY"
        Me.DIY.Size = New System.Drawing.Size(0, 0)
        Me.DIY.TabIndex = 19
        Me.DIY.Text = "DIY水果"
        Me.DIY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clearFruit
        '
        Me.clearFruit.BackColor = System.Drawing.Color.White
        Me.clearFruit.Location = New System.Drawing.Point(0, 0)
        Me.clearFruit.Margin = New System.Windows.Forms.Padding(0)
        Me.clearFruit.Name = "clearFruit"
        Me.clearFruit.Size = New System.Drawing.Size(0, 0)
        Me.clearFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clearFruit.TabIndex = 20
        Me.clearFruit.TabStop = False
        '
        'Drawunder
        '
        Me.Drawunder.Location = New System.Drawing.Point(0, 0)
        Me.Drawunder.Margin = New System.Windows.Forms.Padding(0)
        Me.Drawunder.Name = "Drawunder"
        Me.Drawunder.Size = New System.Drawing.Size(0, 0)
        Me.Drawunder.TabIndex = 21
        '
        'drawcolor2
        '
        Me.drawcolor2.Location = New System.Drawing.Point(0, 0)
        Me.drawcolor2.Margin = New System.Windows.Forms.Padding(0)
        Me.drawcolor2.Name = "drawcolor2"
        Me.drawcolor2.Size = New System.Drawing.Size(0, 0)
        Me.drawcolor2.TabIndex = 22
        '
        'charge
        '
        Me.charge.ForeColor = System.Drawing.Color.White
        Me.charge.Location = New System.Drawing.Point(0, 0)
        Me.charge.Margin = New System.Windows.Forms.Padding(0)
        Me.charge.Name = "charge"
        Me.charge.Size = New System.Drawing.Size(0, 0)
        Me.charge.TabIndex = 23
        Me.charge.Text = "收款:￥"
        '
        'purchaseMoney
        '
        Me.purchaseMoney.ForeColor = System.Drawing.Color.White
        Me.purchaseMoney.Location = New System.Drawing.Point(0, 0)
        Me.purchaseMoney.Margin = New System.Windows.Forms.Padding(0)
        Me.purchaseMoney.Name = "purchaseMoney"
        Me.purchaseMoney.Size = New System.Drawing.Size(0, 0)
        Me.purchaseMoney.TabIndex = 24
        '
        'Drawline3
        '
        Me.Drawline3.Location = New System.Drawing.Point(0, 0)
        Me.Drawline3.Margin = New System.Windows.Forms.Padding(0)
        Me.Drawline3.Name = "Drawline3"
        Me.Drawline3.Size = New System.Drawing.Size(0, 0)
        Me.Drawline3.TabIndex = 25
        '
        'ProductCount
        '
        Me.ProductCount.Location = New System.Drawing.Point(0, 0)
        Me.ProductCount.Margin = New System.Windows.Forms.Padding(0)
        Me.ProductCount.Name = "ProductCount"
        Me.ProductCount.Size = New System.Drawing.Size(0, 0)
        Me.ProductCount.TabIndex = 26
        Me.ProductCount.Text = "共计        件商品"
        '
        'Min
        '
        Me.Min.Location = New System.Drawing.Point(0, 0)
        Me.Min.Margin = New System.Windows.Forms.Padding(0)
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(0, 0)
        Me.Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Min.TabIndex = 27
        Me.Min.TabStop = False
        '
        'MaxBackColor
        '
        Me.MaxBackColor.Location = New System.Drawing.Point(0, 0)
        Me.MaxBackColor.Margin = New System.Windows.Forms.Padding(0)
        Me.MaxBackColor.Name = "MaxBackColor"
        Me.MaxBackColor.Size = New System.Drawing.Size(0, 0)
        Me.MaxBackColor.TabIndex = 28
        '
        'Close_P
        '
        Me.Close_P.Location = New System.Drawing.Point(0, 0)
        Me.Close_P.Margin = New System.Windows.Forms.Padding(0)
        Me.Close_P.Name = "Close_P"
        Me.Close_P.Size = New System.Drawing.Size(0, 0)
        Me.Close_P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_P.TabIndex = 29
        Me.Close_P.TabStop = False
        '
        'OpenMoneyBox
        '
        Me.OpenMoneyBox.Location = New System.Drawing.Point(158, 15)
        Me.OpenMoneyBox.Name = "OpenMoneyBox"
        Me.OpenMoneyBox.Size = New System.Drawing.Size(77, 12)
        Me.OpenMoneyBox.TabIndex = 30
        Me.OpenMoneyBox.Text = "开启            钱箱"
        Me.OpenMoneyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MoneyBox
        '
        Me.MoneyBox.Location = New System.Drawing.Point(201, 13)
        Me.MoneyBox.Name = "MoneyBox"
        Me.MoneyBox.Size = New System.Drawing.Size(34, 18)
        Me.MoneyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MoneyBox.TabIndex = 31
        Me.MoneyBox.TabStop = False
        '
        'ExchangeWork
        '
        Me.ExchangeWork.Location = New System.Drawing.Point(0, 0)
        Me.ExchangeWork.Margin = New System.Windows.Forms.Padding(0)
        Me.ExchangeWork.Name = "ExchangeWork"
        Me.ExchangeWork.Size = New System.Drawing.Size(0, 0)
        Me.ExchangeWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ExchangeWork.TabIndex = 32
        Me.ExchangeWork.TabStop = False
        '
        'AddVIP
        '
        Me.AddVIP.Location = New System.Drawing.Point(0, 0)
        Me.AddVIP.Margin = New System.Windows.Forms.Padding(0)
        Me.AddVIP.Name = "AddVIP"
        Me.AddVIP.Size = New System.Drawing.Size(0, 0)
        Me.AddVIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AddVIP.TabIndex = 33
        Me.AddVIP.TabStop = False
        '
        'VIPcharge
        '
        Me.VIPcharge.Location = New System.Drawing.Point(0, 0)
        Me.VIPcharge.Margin = New System.Windows.Forms.Padding(0)
        Me.VIPcharge.Name = "VIPcharge"
        Me.VIPcharge.Size = New System.Drawing.Size(0, 0)
        Me.VIPcharge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.VIPcharge.TabIndex = 34
        Me.VIPcharge.TabStop = False
        '
        'ReturnINdex
        '
        Me.ReturnINdex.Location = New System.Drawing.Point(0, 0)
        Me.ReturnINdex.Margin = New System.Windows.Forms.Padding(0)
        Me.ReturnINdex.Name = "ReturnINdex"
        Me.ReturnINdex.Size = New System.Drawing.Size(0, 0)
        Me.ReturnINdex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ReturnINdex.TabIndex = 35
        Me.ReturnINdex.TabStop = False
        '
        'opera_Name
        '
        Me.opera_Name.Location = New System.Drawing.Point(0, 0)
        Me.opera_Name.Margin = New System.Windows.Forms.Padding(0)
        Me.opera_Name.Name = "opera_Name"
        Me.opera_Name.Size = New System.Drawing.Size(0, 0)
        Me.opera_Name.TabIndex = 8
        Me.opera_Name.Text = "Luoshengwen"
        '
        'purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 447)
        Me.Controls.Add(Me.ReturnINdex)
        Me.Controls.Add(Me.VIPcharge)
        Me.Controls.Add(Me.AddVIP)
        Me.Controls.Add(Me.ExchangeWork)
        Me.Controls.Add(Me.MoneyBox)
        Me.Controls.Add(Me.OpenMoneyBox)
        Me.Controls.Add(Me.Close_P)
        Me.Controls.Add(Me.MaxBackColor)
        Me.Controls.Add(Me.Min)
        Me.Controls.Add(Me.ProductCount)
        Me.Controls.Add(Me.Drawline3)
        Me.Controls.Add(Me.purchaseMoney)
        Me.Controls.Add(Me.charge)
        Me.Controls.Add(Me.drawcolor2)
        Me.Controls.Add(Me.Drawunder)
        Me.Controls.Add(Me.clearFruit)
        Me.Controls.Add(Me.DIY)
        Me.Controls.Add(Me.Fresh_fruit_box)
        Me.Controls.Add(Me.fruit_juice)
        Me.Controls.Add(Me.fruit)
        Me.Controls.Add(Me.AllProduct)
        Me.Controls.Add(Me.line2)
        Me.Controls.Add(Me.PurchaseNum)
        Me.Controls.Add(Me.Drawbackcolor)
        Me.Controls.Add(Me.wordPrint)
        Me.Controls.Add(Me.line)
        Me.Controls.Add(Me.under_head)
        Me.Controls.Add(Me.opera_Name)
        Me.Controls.Add(Me.Nowtime)
        Me.Controls.Add(Me.MinBackColor)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.cx_name)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "purchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.clearFruit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExchangeWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddVIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIPcharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnINdex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cx_name As System.Windows.Forms.Label
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents MinBackColor As System.Windows.Forms.Label
    Friend WithEvents updatetime As System.Windows.Forms.Timer
    Friend WithEvents Nowtime As System.Windows.Forms.Label
    Friend WithEvents under_head As System.Windows.Forms.Label
    Friend WithEvents line As System.Windows.Forms.Label
    Friend WithEvents wordPrint As System.Windows.Forms.Label
    Friend WithEvents Drawbackcolor As System.Windows.Forms.Label
    Friend WithEvents PurchaseNum As System.Windows.Forms.Label
    Friend WithEvents line2 As System.Windows.Forms.Label
    Friend WithEvents AllProduct As System.Windows.Forms.Label
    Friend WithEvents fruit As System.Windows.Forms.Label
    Friend WithEvents fruit_juice As System.Windows.Forms.Label
    Friend WithEvents Fresh_fruit_box As System.Windows.Forms.Label
    Friend WithEvents DIY As System.Windows.Forms.Label
    Friend WithEvents clearFruit As System.Windows.Forms.PictureBox
    Friend WithEvents Drawunder As System.Windows.Forms.Label
    Friend WithEvents drawcolor2 As System.Windows.Forms.Label
    Friend WithEvents charge As System.Windows.Forms.Label
    Friend WithEvents purchaseMoney As System.Windows.Forms.Label
    Friend WithEvents Drawline3 As System.Windows.Forms.Label
    Friend WithEvents ProductCount As System.Windows.Forms.Label
    Friend WithEvents Min As System.Windows.Forms.PictureBox
    Friend WithEvents MaxBackColor As System.Windows.Forms.Label
    Friend WithEvents Close_P As System.Windows.Forms.PictureBox
    Friend WithEvents OpenMoneyBox As System.Windows.Forms.Label
    Friend WithEvents MoneyBox As System.Windows.Forms.PictureBox
    Friend WithEvents ExchangeWork As System.Windows.Forms.PictureBox
    Friend WithEvents AddVIP As System.Windows.Forms.PictureBox
    Friend WithEvents VIPcharge As System.Windows.Forms.PictureBox
    Friend WithEvents ReturnINdex As System.Windows.Forms.PictureBox
    Friend WithEvents opera_Name As System.Windows.Forms.Label
End Class
