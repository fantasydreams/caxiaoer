Public Class purchase

    Private ProductButton(4) As Integer

    '所有商品控件显示数组
    Private productCOM As ArrayList

    Private Sub purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMap()

    End Sub

    Private Sub selcetValfromProductButton()
        For i = 0 To 4
            If ProductButton(i) = 1 Then
                setButtonColor(i)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub setButtonColor(ByVal Button As Integer)
        Select Case Button
            Case 0
                AllProduct.BackColor = Color.FromArgb(&HFF3398CC)
                ProductButton(0) = 0
            Case 1
                fruit.BackColor = Color.FromArgb(&HFF3398CC)
                ProductButton(1) = 0
            Case 2
                fruit_juice.BackColor = Color.FromArgb(&HFF3398CC)
                ProductButton(2) = 0
            Case 3
                Fresh_fruit_box.BackColor = Color.FromArgb(&HFF3398CC)
                ProductButton(3) = 0
            Case 4
                DIY.BackColor = Color.FromArgb(&HFF3398CC)
                ProductButton(4) = 0
        End Select


    End Sub
    '布局
    Private Sub LoadMap()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.BackColor = Color.White
        cx_name.Top = 0
        cx_name.Left = 0
        cx_name.Width = 150 * index.zoomWidth
        cx_name.Height = 40 * index.zoomHeight
        cx_name.BackColor = Color.FromArgb(&HFF0084C5)
        cx_name.Font = New System.Drawing.Font("楷体", 11 * cx_name.Height / 32, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        cx_name.ForeColor = Color.White
        head.Top = 0
        head.Left = cx_name.Width + 5 * index.zoomWidth
        head.BackColor = Color.FromArgb(&HFF0084C5)
        head.Height = cx_name.Height
        head.Width = 722 * index.zoomWidth
        '显示“开启钱箱”
        OpenMoneyBox.Left = head.Left
        OpenMoneyBox.Top = 0
        OpenMoneyBox.ForeColor = Color.White
        OpenMoneyBox.Width = cx_name.Width
        OpenMoneyBox.Height = head.Height
        OpenMoneyBox.BackColor = head.BackColor
        OpenMoneyBox.Font = New System.Drawing.Font("微软雅黑", 10.5! * cx_name.Height / 32, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))

        '钱箱图标显示
        MoneyBox.Top = 10
        MoneyBox.Width = 30
        MoneyBox.Left = cx_name.Width * 3 / 2 + 5 - MoneyBox.Width / 2
        index.LoadImage(MoneyBox, "\SystemImg\", "Moneybox")
        '最小化和关闭
        MinBackColor.Top = 0
        MinBackColor.Left = head.Left + head.Width + 5 * index.zoomWidth
        MinBackColor.Height = head.Height
        MinBackColor.Width = 75 * index.zoomWidth
        MinBackColor.BackColor = Color.FromArgb(&HFF0084C5)
        Min.Height = 40
        Min.Top = 0
        Min.Left = 40 * index.zoomWidth + MinBackColor.Left
        Min.Width = 25
        Min.BackColor = MinBackColor.BackColor
        index.LoadImage(Min, "\SystemImg\", "Min")
        MaxBackColor.Top = 0
        MaxBackColor.Left = MinBackColor.Left + MinBackColor.Width
        MaxBackColor.Width = MinBackColor.Width
        MaxBackColor.Height = MinBackColor.Height
        MaxBackColor.BackColor = Min.BackColor
        MaxBackColor.Font = Min.Font
        Close_P.Top = 0
        Close_P.Left = Min.Left + 50 * index.zoomHeight + Min.Width * index.zoomHeight - Min.Width
        Close_P.Width = Min.Width
        Close_P.Height = Min.Height
        index.LoadImage(Close_P, "\SystemImg\", "PClose")
        '操作人员打印
        opera_Name.Height = head.Height / 2
        opera_Name.Top = head.Height / 2 - opera_Name.Height / 2
        opera_Name.Width = 200 * index.zoomHeight
        opera_Name.Left = head.Left + head.Width - opera_Name.Width - 1
        opera_Name.BackColor = head.BackColor
        opera_Name.Font = New System.Drawing.Font("宋体", 10.5! * cx_name.Height / 32, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        opera_Name.Text = index.nickname
        '时间显示
        Nowtime.Top = opera_Name.Top
        Nowtime.Width = 160 * index.zoomHeight
        Nowtime.Left = opera_Name.Left - 20 - Nowtime.Width
        Nowtime.Height = opera_Name.Height
        Nowtime.BackColor = head.BackColor
        Nowtime.Font = New System.Drawing.Font("宋体", 10.5! * cx_name.Height / 32, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Nowtime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
        '标题栏显示
        under_head.Top = head.Height
        under_head.Left = 0
        under_head.Height = 60 * index.zoomHeight
        under_head.Width = index.ScreenWidth
        under_head.BackColor = Color.FromArgb(&HFFD6E8EC)
        line.Left = cx_name.Width
        line.Top = under_head.Height / 5 + head.Height
        line.Width = 5 * index.zoomWidth
        line.Height = under_head.Height * 3 / 5
        line.BackColor = head.BackColor
        wordPrint.Top = line.Top + 8 * index.zoomWidth
        wordPrint.Left = line.Left + 12 * index.zoomWidth
        wordPrint.Height = line.Height
        wordPrint.Width = cx_name.Width
        wordPrint.BackColor = under_head.BackColor
        wordPrint.Font = New System.Drawing.Font("宋体", 10.5! * cx_name.Height / 32, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '显示购买的数量
        PurchaseNum.Top = wordPrint.Top - 3 * index.zoomHeight
        PurchaseNum.Left = wordPrint.Left + 55 * index.zoomWidth
        PurchaseNum.Height = wordPrint.Height / 2 + 6 * index.zoomHeight
        PurchaseNum.Width = 60 * index.zoomWidth
        PurchaseNum.BackColor = Color.White
        PurchaseNum.ForeColor = Color.Red
        PurchaseNum.Font = New System.Drawing.Font("宋体", 13.5! * cx_name.Height / 32, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Drawbackcolor.Top = under_head.Top + under_head.Height
        Drawbackcolor.Left = 300 * index.zoomWidth
        Drawbackcolor.Width = index.ScreenWidth - Drawbackcolor.Left
        Drawbackcolor.Height = index.ScreenHeight - Drawbackcolor.Top - 85 * index.zoomHeight
        Drawbackcolor.BackColor = Color.FromArgb(&HFFFFFFCB)
        line2.Top = Drawbackcolor.Top - 10 * index.zoomHeight
        line2.Left = Drawbackcolor.Left
        line2.Width = Drawbackcolor.Width
        line2.Height = 10 * index.zoomHeight
        line2.BackColor = Color.FromArgb(&HFF006599)
        AllProduct.Top = 3 * index.zoomHeight + under_head.Top
        AllProduct.Left = line2.Left
        AllProduct.Height = under_head.Height - 3 * index.zoomHeight - line2.Height
        AllProduct.Width = (line2.Width - 3 * 4 * index.zoomWidth) / 5
        AllProduct.BackColor = Color.FromArgb(&HFF006599)
        AllProduct.Font = New System.Drawing.Font("宋体", 13.5! * cx_name.Height / 32, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        fruit.Top = AllProduct.Top
        fruit.Left = AllProduct.Left + AllProduct.Width + 3 * index.zoomWidth
        fruit.Width = AllProduct.Width
        fruit.Height = AllProduct.Height
        fruit.BackColor = Color.FromArgb(&HFF3398CC)
        fruit.Font = AllProduct.Font
        fruit_juice.Top = fruit.Top
        fruit_juice.Left = fruit.Left + fruit.Width + 3 * index.zoomWidth
        fruit_juice.Width = fruit.Width
        fruit_juice.Height = fruit.Height
        fruit_juice.BackColor = fruit.BackColor
        fruit_juice.Font = fruit.Font
        Fresh_fruit_box.Top = fruit.Top
        Fresh_fruit_box.Left = fruit_juice.Left + fruit_juice.Width + 3 * index.zoomWidth
        Fresh_fruit_box.Width = fruit.Width
        Fresh_fruit_box.Height = fruit.Height
        Fresh_fruit_box.BackColor = fruit_juice.BackColor
        Fresh_fruit_box.Font = fruit_juice.Font
        DIY.Top = fruit.Top
        DIY.Left = Fresh_fruit_box.Left + Fresh_fruit_box.Width + 3 * index.zoomWidth
        DIY.Width = fruit.Width
        DIY.Height = fruit.Height
        DIY.BackColor = fruit.BackColor
        DIY.Font = fruit.Font
        '显示清理选中商品的图片
        clearFruit.BackColor = under_head.BackColor
        clearFruit.Top = 12 * index.zoomHeight + under_head.Top
        clearFruit.Left = 25 * index.zoomWidth
        clearFruit.Width = 100 * index.zoomWidth
        clearFruit.Height = 36 * index.zoomHeight
        index.LoadImage(clearFruit, "\SystemImg\", "clearProduct1")
        Dim r_logoin_button As Integer = login.CreateRoundRectRgn(0, 0, clearFruit.Width, clearFruit.Height, 20 * index.zoomWidth, 20 * index.zoomHeight)
        login.SetWindowRgn(clearFruit.Handle, r_logoin_button, True)
        Drawunder.Top = Drawbackcolor.Top + Drawbackcolor.Height
        Drawunder.Left = Drawbackcolor.Left
        Drawunder.Width = Drawbackcolor.Width
        Drawunder.Height = 85 * index.zoomHeight
        Drawunder.BackColor = Color.FromArgb(&HFF3398CC)
        drawcolor2.Top = Drawunder.Top
        drawcolor2.Left = 0
        drawcolor2.Width = index.ScreenWidth - Drawunder.Width - 5 * index.zoomWidth
        drawcolor2.Height = Drawunder.Height
        drawcolor2.BackColor = Drawunder.BackColor
        charge.Width = 175 * index.zoomWidth
        charge.Height = drawcolor2.Height / 2
        charge.Top = drawcolor2.Top + charge.Height / 2
        charge.Left = 0
        charge.BackColor = drawcolor2.BackColor
        charge.Font = New System.Drawing.Font("宋体", 26 * cx_name.Height / 32, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        purchaseMoney.Top = charge.Top
        purchaseMoney.Left = charge.Width - 20 * index.zoomWidth
        purchaseMoney.Width = drawcolor2.Width - purchaseMoney.Left - 1 * index.zoomWidth
        purchaseMoney.Height = charge.Height
        purchaseMoney.Font = charge.Font
        purchaseMoney.BackColor = charge.BackColor
        Drawline3.Top = Drawunder.Top - 50 * index.zoomHeight
        Drawline3.Left = Drawunder.Left + 5 * index.zoomWidth
        Drawline3.Width = Drawunder.Width - 10 * index.zoomWidth
        Drawline3.Height = 2 * index.zoomHeight
        Drawline3.BackColor = Color.FromArgb(&HFFDBE8E1)
        ProductCount.Top = Drawline3.Top + 10 * index.zoomHeight
        ProductCount.Left = Drawunder.Left + 20 * index.zoomWidth
        ProductCount.Width = 300 * index.zoomHeight
        ProductCount.Height = 40 * index.zoomHeight
        ProductCount.BackColor = Drawbackcolor.BackColor
        ProductCount.Font = New System.Drawing.Font("宋体", 18 * cx_name.Height / 32, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        ProductCount.ForeColor = Color.FromArgb(&HFF066176)
        clearFruit.Hide()
        ProductButton(0) = 1
        '加载交接班图片
        ExchangeWork.Height = 64
        ExchangeWork.Left = Drawunder.Left + 20 * index.zoomWidth
        ExchangeWork.Top = Drawunder.Height / 2 - ExchangeWork.Height / 2 + Drawunder.Top
        ExchangeWork.Width = ExchangeWork.Height
        index.LoadImage(ExchangeWork, "\SystemImg\", "exchangeWork")
        Dim r_ExchangeWork As Integer = login.CreateRoundRectRgn(0, 0, ExchangeWork.Width, ExchangeWork.Height, 6 * index.zoomWidth, 6 * index.zoomHeight)
        login.SetWindowRgn(ExchangeWork.Handle, r_ExchangeWork, True)
        '加载添加会员图片
        AddVIP.Left = 20 * index.zoomWidth + ExchangeWork.Left + ExchangeWork.Width
        AddVIP.Top = ExchangeWork.Top
        AddVIP.Width = ExchangeWork.Width
        AddVIP.Height = AddVIP.Width
        index.LoadImage(AddVIP, "\SystemImg\", "addVip")
        Dim r_AddVIP As Integer = login.CreateRoundRectRgn(0, 0, AddVIP.Width, AddVIP.Height, 8 * index.zoomWidth, 8 * index.zoomHeight)
        login.SetWindowRgn(AddVIP.Handle, r_AddVIP, True)
        '加载会员充值图片
        VIPcharge.Left = 20 * index.zoomWidth + AddVIP.Left + AddVIP.Width
        VIPcharge.Top = AddVIP.Top
        VIPcharge.Width = AddVIP.Width
        VIPcharge.Height = AddVIP.Height
        index.LoadImage(VIPcharge, "\SystemImg\", "VIPCharge")
        Dim r_VIPcharge As Integer = login.CreateRoundRectRgn(0, 0, VIPcharge.Width, VIPcharge.Height, 8 * index.zoomWidth, 8 * index.zoomHeight)
        login.SetWindowRgn(VIPcharge.Handle, r_VIPcharge, True)
        '加载返回index图片按钮
        ReturnINdex.Width = AddVIP.Width
        ReturnINdex.Left = index.ScreenWidth - 20 * index.zoomWidth - ReturnINdex.Width
        ReturnINdex.Top = AddVIP.Top
        ReturnINdex.Height = AddVIP.Height
        index.LoadImage(ReturnINdex, "\SystemImg\", "ReturnIndex")
        Dim r_ReturnINdex As Integer = login.CreateRoundRectRgn(0, 0, ReturnINdex.Width, ReturnINdex.Height, 8 * index.zoomWidth, 8 * index.zoomHeight)
        login.SetWindowRgn(ReturnINdex.Handle, r_ReturnINdex, True)

    End Sub

    Private Sub charge_Clik(sender As Object, e As EventArgs) Handles charge.Click
        Me.Hide()
        Collection.Show()
    End Sub

    Private Sub purchaseMoney_Clik(sender As Object, e As EventArgs) Handles purchaseMoney.Click
        Me.Hide()
        Collection.Show()
    End Sub

    Private Sub drawcolor2_click(sender As Object, a As EventArgs) Handles drawcolor2.Click
        Me.Hide()
        Collection.Show()
    End Sub


    Private Sub updatetime_Tick(sender As Object, e As EventArgs) Handles updatetime.Tick
        Nowtime.Text = Format(Now(), "yyyy.mm.dd hh:mm")
    End Sub

    Private Sub AllProduct_Click(sender As Object, e As EventArgs) Handles AllProduct.Click
        selcetValfromProductButton()
        AllProduct.BackColor = Color.FromArgb(&HFF006599)
        ProductButton(0) = 1
    End Sub

    Private Sub fruit_Click(sender As Object, e As EventArgs) Handles fruit.Click
        selcetValfromProductButton()
        fruit.BackColor = Color.FromArgb(&HFF006599)
        ProductButton(1) = 1
    End Sub

    Private Sub DIY_Click(sender As Object, e As EventArgs) Handles DIY.Click
        selcetValfromProductButton()
        DIY.BackColor = Color.FromArgb(&HFF006599)
        ProductButton(4) = 1
    End Sub

    Private Sub fruit_juice_Click(sender As Object, e As EventArgs) Handles fruit_juice.Click
        selcetValfromProductButton()
        fruit_juice.BackColor = Color.FromArgb(&HFF006599)
        ProductButton(2) = 1
    End Sub

    Private Sub Fresh_fruit_box_Click(sender As Object, e As EventArgs) Handles Fresh_fruit_box.Click
        selcetValfromProductButton()
        Fresh_fruit_box.BackColor = Color.FromArgb(&HFF006599)
        ProductButton(3) = 1
    End Sub

    Private Sub clearFruit_MouseDown(sender As Object, e As MouseEventArgs) Handles clearFruit.MouseDown
        clearFruit.Image = Image.FromFile(Application.StartupPath & "\SystemImg\clearProduct2.png")
    End Sub

    Private Sub Min_Click(sender As Object, e As EventArgs) Handles Min.Click
        Me.WindowState = 1
    End Sub

    Private Sub Close_P_Click(sender As Object, e As EventArgs) Handles Close_P.Click
        Me.Hide()
        index.Show()
    End Sub

    Private Sub ReturnINdex_Click(sender As Object, e As EventArgs) Handles ReturnINdex.Click
        Me.Hide()
        index.Show()
    End Sub

    Private Sub ExchangeWork_click(sender As Object, e As EventArgs) Handles ExchangeWork.Click
        Me.Hide()
        ExchangeWorkWin.Show()
    End Sub
    '从数据库中读取数据
    Private Sub LoadDadaFromDB(ByVal Sort As Integer)
        productCOM.Clear()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        If Sort = 0 Then
            sqlcmd.CommandText = "select productid,name,picture,price from cx_product"
        Else
            sqlcmd.CommandText = "select productid,name,picture,price from cx_product where product_sort_id = '" & Sort & "'"
        End If
    End Sub
    '清空数组列表中的控件
    Private Sub CloseProductCOM()
        
    End Sub
End Class