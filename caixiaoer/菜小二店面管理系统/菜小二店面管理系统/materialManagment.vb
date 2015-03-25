Public Class materialManagment
    '标记工作区间
    Private WinFlag(2) As Boolean
    '标记点击的按钮
    Private BFLag(2) As Boolean
    '标记是否第一次布局
    Private MapB(3) As Boolean
    Private record As Integer '记录原料的ID
    Private rePrice As Double = 0 '记录原料原来的价格

    Private Sub materialManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mapload()
    End Sub
    Private Sub Mapload()
        Me.Width = index.ScreenWidth
        Me.Height = index.ScreenHeight
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
        admin.Text = index.nickname
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
        '背景颜色框
        backLine.Width = 900 * index.zoomHeight
        backLine.Left = index.ScreenWidth / 2 - backLine.Width / 2
        backLine.Top = head.Height + 110 * index.zoomHeight
        backLine.Height = index.ScreenHeight - backLine.Top - 50 * index.zoomHeight
        backLine.BackColor = Color.FromArgb(&HFF99FFCC)
        '填充背景
        chargeBack.Left = backLine.Left + 1
        chargeBack.Top = backLine.Top + 1
        chargeBack.Width = backLine.Width - 2
        chargeBack.Height = backLine.Height - 2
        '横杠
        head1.Left = backLine.Left
        head1.Width = backLine.Width
        head1.Height = 20 * index.zoomHeight
        head1.Top = backLine.Top - 6
        head1.BackColor = Color.FromArgb(&HFF006699)
        '原材料进出按钮背景线条
        materialIAO.Left = head1.Left
        materialIAO.Width = 190 * index.zoomHeight
        materialIAO.Height = 70 * index.zoomHeight
        materialIAO.Top = head1.Top - materialIAO.Height + 8
        materialIAO.BackColor = Color.FromArgb(&HFF797979)
        index.SetLableWin(materialIAO, 12)
        '原材料进出按钮
        materialB.Font = New System.Drawing.
            Font("微软雅黑", 20 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        materialB.ForeColor = Color.White
        materialB.Width = materialIAO.Width - 2
        materialB.Height = materialIAO.Height - 2
        materialB.BackColor = Color.FromArgb(&HFF006699)
        materialB.Left = materialIAO.Left + 1
        materialB.Top = materialIAO.Top + 1
        index.SetLableWin(materialB, 12)
        '绘制生成产品背景线条
        createPL.Left = materialIAO.Left + 10 + materialIAO.Width
        createPL.Width = materialIAO.Width
        createPL.Height = materialIAO.Height
        createPL.Top = materialIAO.Top
        createPL.BackColor = materialIAO.BackColor
        index.SetLableWin(createPL, 12)
        '绘制生成产品按钮
        createP.Left = createPL.Left + 1
        createP.Top = createPL.Top + 1
        createP.Width = createPL.Width - 2
        createP.Height = createPL.Height - 2
        createP.BackColor = head.BackColor
        createP.Font = materialB.Font
        createP.ForeColor = Color.White
        index.SetLableWin(createP, 12)
        '原材料查询的背景线条绘制
        materialscanL.Left = createPL.Left + 10 + createPL.Width
        materialscanL.Top = createPL.Top
        materialscanL.Width = createPL.Width
        materialscanL.Height = createPL.Height
        materialscanL.BackColor = createPL.BackColor
        index.SetLableWin(materialscanL, 12)
        '原材料查询按钮
        materialSB.Left = materialscanL.Left + 1
        materialSB.Top = materialscanL.Top + 1
        materialSB.Width = materialscanL.Width - 2
        materialSB.Height = materialscanL.Height - 2
        materialSB.BackColor = head.BackColor
        materialSB.ForeColor = Color.White
        materialSB.Font = materialB.Font
        index.SetLableWin(materialSB, 12)
        
        MaterialMMap()
        MapB(0) = True
        'createPMap()
        'MaterialSearchMap()

    End Sub
    '原材料查询布局
    Private Sub MaterialSearchMap()
        '绘制搜索按钮的背景
        searchBack.Width = 350 * index.zoomHeight
        searchBack.Height = 60 * index.zoomHeight
        searchBack.Left = backLine.Left + backLine.Width - 50 * index.zoomHeight - searchBack.Width
        searchBack.Top = 50 * index.zoomHeight + backLine.Top
        searchBack.BackColor = head.BackColor
        '搜索图片
        searchButton.Left = 5 * index.zoomHeight + searchBack.Left
        searchButton.Width = 50 * index.zoomHeight
        searchButton.Height = 50 * index.zoomHeight
        index.LoadImage(searchButton, "\SystemImg\", "Search")
        searchButton.Top = searchBack.Top + 5 * index.zoomHeight
        '绘制“搜索”
        search.Height = 50 * index.zoomHeight
        search.Width = 100 * index.zoomHeight
        search.Top = 5 * index.zoomHeight + searchBack.Top
        search.Left = searchBack.Left + searchBack.Width - search.Width
        search.Font = New System.Drawing.
        Font("宋体", 24 * index.zoomHeight, System.Drawing.FontStyle.Bold,
             System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        search.BackColor = searchBack.BackColor
        search.ForeColor = Color.White
        '绘制输入框
        searchInput.Left = searchButton.Left + searchButton.Width + 1
        searchInput.Top = searchButton.Top
        searchInput.Width = search.Left - searchInput.Left
        searchInput.Font = New System.Drawing.
            Font("宋体", 27 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '“添加原材料”按钮绘制
        addMaterial1.Width = 160 * index.zoomHeight
        addMaterial1.Height = 50 * index.zoomHeight
        addMaterial1.Left = searchBack.Left - 50 * index.zoomWidth - addMaterial1.Width
        addMaterial1.Top = searchBack.Top + searchBack.Height / 2 - addMaterial1.Height / 2
        addMaterial1.BackColor = head.BackColor
        addMaterial1.Font = New System.Drawing.
            Font("宋体", 18 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        addMaterial1.ForeColor = Color.White
        index.SetLableWin(addMaterial1, 12)
        '“全部原材料”
        allMaterial.Width = addMaterial1.Width
        allMaterial.Height = addMaterial1.Height
        allMaterial.Font = addMaterial1.Font
        allMaterial.BackColor = addMaterial1.BackColor
        allMaterial.Top = addMaterial1.Top
        allMaterial.Left = addMaterial1.Left - 30 * index.zoomHeight - allMaterial.Width
        allMaterial.ForeColor = Color.White
        index.SetLableWin(allMaterial, 12)

    End Sub
    '隐藏“原材料查询”所显示的控件
    Private Sub HideMaterialSearch()
        searchBack.Hide()
        searchButton.Hide()
        search.Hide()
        searchInput.Hide()
        addMaterial1.Hide()
        allMaterial.Hide()
    End Sub
    '显示“原材料查询”所隐藏的控件
    Private Sub ShowMaterialSearch()
        searchBack.Show()
        searchButton.Show()
        search.Show()
        searchInput.Show()
        addMaterial1.Show()
        allMaterial.Show()
    End Sub
    '原材料进出MAP
    Private Sub MaterialMMap()
        WinFlag(0) = True
        '定义各空间之间显示的高度差
        Dim high As Double = 70 * index.zoomHeight
        '显示"原材料名称："
        materialName.Left = 15 * index.zoomHeight + backLine.Left
        materialName.Top = high + head1.Top + head1.Height
        materialName.Width = 160 * index.zoomHeight
        materialName.Height = 35 * index.zoomHeight
        materialName.Font = New System.Drawing.
            Font("微软雅黑", 18 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '原材料名称输入框
        materialNameI.Left = materialName.Left + materialName.Width
        materialNameI.Width = 160 * index.zoomHeight
        materialNameI.Font = New System.Drawing.
            Font("宋体", 17 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        materialNameI.Top = materialName.Top
        '"单价："显示
        MaterialPrice.Left = 15 * index.zoomHeight + materialNameI.Left + materialNameI.Width
        MaterialPrice.Top = materialName.Top
        MaterialPrice.Height = materialName.Height
        MaterialPrice.Font = materialName.Font
        MaterialPrice.Width = 90 * index.zoomHeight
        '单价输入框
        priceI.Left = MaterialPrice.Left + MaterialPrice.Width
        priceI.Width = materialNameI.Width
        priceI.Font = materialNameI.Font
        priceI.Top = materialNameI.Top
        '显示“元/kg”
        price_P.Left = priceI.Left + priceI.Width
        price_P.Width = 80 * index.zoomHeight
        price_P.Height = MaterialPrice.Height
        price_P.Font = MaterialPrice.Font
        price_P.Top = MaterialPrice.Top
        '显示“编号:”
        Num.Left = price_P.Left + price_P.Width
        Num.Width = MaterialPrice.Width
        Num.Height = MaterialPrice.Height
        Num.Top = MaterialPrice.Top
        Num.Font = MaterialPrice.Font
        '编号显示的背景线条
        NumL.Left = Num.Left + Num.Width
        NumL.Top = Num.Top
        NumL.Width = backLine.Left + backLine.Width - 15 * index.zoomHeight - NumL.Left
        NumL.Height = Num.Height
        NumL.BackColor = backLine.BackColor
        '编号显示
        numP.Left = NumL.Left + 1
        numP.Width = NumL.Width - 2
        numP.Height = NumL.Height - 2
        numP.Font = Num.Font
        numP.Top = NumL.Top + 1
        '显示“本次操作说明”
        workingOperat.Left = materialName.Left
        workingOperat.Height = materialName.Height
        workingOperat.Font = materialName.Font
        workingOperat.Top = materialName.Top + high + materialName.Height
        workingOperat.Width = 185 * index.zoomHeight
        '绘制添加新原料背景线条
        NewMaterialL.Left = workingOperat.Left + workingOperat.Width
        NewMaterialL.Width = 160 * index.zoomHeight
        NewMaterialL.Height = 55 * index.zoomHeight
        NewMaterialL.Top = workingOperat.Top - (NewMaterialL.Height / 2 - workingOperat.Height / 2)
        NewMaterialL.BackColor = Color.FromArgb(&HFF797979)
        index.SetLableWin(NewMaterialL, 12)
        '添加新原料按钮
        Newmaterialb.Left = NewMaterialL.Left + 1
        Newmaterialb.Top = NewMaterialL.Top + 1
        Newmaterialb.Width = NewMaterialL.Width - 2
        Newmaterialb.Height = NewMaterialL.Height - 2
        Newmaterialb.BackColor = head.BackColor
        Newmaterialb.Font = New System.Drawing.
            Font("宋体", 18 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Newmaterialb.ForeColor = Color.White
        index.SetLableWin(Newmaterialb, 12)
        '原材料增加背景线条
        addMaterial.Left = 10 * index.zoomHeight + NewMaterialL.Left + NewMaterialL.Width
        addMaterial.Width = NewMaterialL.Width
        addMaterial.Height = NewMaterialL.Height
        addMaterial.Top = NewMaterialL.Top
        addMaterial.BackColor = NewMaterialL.BackColor
        index.SetLableWin(addMaterial, 12)
        '原材料增加按钮
        addMaterialb.Left = addMaterial.Left + 1
        addMaterialb.Top = addMaterial.Top + 1
        addMaterialb.Width = addMaterial.Width - 2
        addMaterialb.Height = addMaterial.Height - 2
        addMaterialb.BackColor = head.BackColor
        addMaterialb.ForeColor = Color.White
        addMaterialb.Font = Newmaterialb.Font
        index.SetLableWin(addMaterialb, 12)
        '原材料损耗背景线条
        materialLose.Left = addMaterial.Left + addMaterial.Width + 10 * index.zoomHeight
        materialLose.Top = addMaterial.Top
        materialLose.Width = addMaterial.Width
        materialLose.Height = addMaterial.Height
        materialLose.BackColor = addMaterial.BackColor
        index.SetLableWin(materialLose, 12)
        '原材料损耗按钮
        materialloseB.Left = materialLose.Left + 1
        materialloseB.Top = materialLose.Top + 1
        materialloseB.Width = materialLose.Width - 2
        materialloseB.Height = materialLose.Height - 2
        materialloseB.Font = addMaterialb.Font
        materialloseB.BackColor = head.BackColor
        index.SetLableWin(materialloseB, 12)
        materialloseB.ForeColor = Color.White
        '其他说明输入框
        otherexplain.Left = materialLose.Left + materialLose.Width + 10 * index.zoomHeight
        otherexplain.Top = materialLose.Top
        otherexplain.Width = NumL.Left + NumL.Width - otherexplain.Left
        otherexplain.Font = New System.Drawing.
            Font("宋体", 30 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        otherexplain.ForeColor = Color.Gray
        '“操作数量：”显示
        operateNum.Left = workingOperat.Left
        operateNum.Width = workingOperat.Width
        operateNum.Height = workingOperat.Height
        operateNum.Top = workingOperat.Top + workingOperat.Height + high
        operateNum.Font = workingOperat.Font
        '操作数量输入框
        operateNumI.Left = NewMaterialL.Left
        operateNumI.Font = priceI.Font
        operateNumI.Width = NewMaterialL.Width
        operateNumI.Top = operateNum.Top
        '显示“kg”
        kg.Left = operateNumI.Left + operateNumI.Width
        kg.Width = 50 * index.zoomHeight
        kg.Height = operateNum.Height
        kg.Top = operateNum.Top
        kg.Font = operateNum.Font
        '确定按钮的背景线条
        Yes_backL.Left = priceI.Left
        Yes_backL.Height = addMaterial.Height
        Yes_backL.Top = operateNum.Top - (Yes_backL.Height / 2 - operateNum.Height / 2)
        Yes_backL.Width = materialLose.Left + materialLose.Width - priceI.Left
        Yes_backL.BackColor = addMaterial.BackColor
        index.SetLableWin(Yes_backL, 12)
        '确定按钮
        yes.Left = Yes_backL.Left + 1
        yes.Width = Yes_backL.Width - 2
        yes.Height = Yes_backL.Height - 2
        yes.Top = Yes_backL.Top + 1
        yes.BackColor = head.BackColor
        yes.ForeColor = Color.White
        index.SetLableWin(yes, 12)
        yes.Font = New System.Drawing.
            Font("宋体", 28 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '"操作涉及金额："
        operateMoney.Left = operateNum.Left
        operateMoney.Width = workingOperat.Width
        operateMoney.Height = materialName.Height
        operateMoney.Font = materialName.Font
        operateMoney.Top = operateNum.Top + operateNum.Height + high
        '显示下划线1
        underLine0.Left = operateMoney.Left + operateMoney.Width
        underLine0.Width = operateNumI.Width
        underLine0.Height = 1
        underLine0.BackColor = Color.Black
        underLine0.Top = operateMoney.Top + operateMoney.Height - 1
        '显示“元”
        yuan.Left = underLine0.Left + underLine0.Width
        yuan.Width = kg.Width
        yuan.Height = operateMoney.Height
        yuan.Top = operateMoney.Top
        yuan.Font = operateMoney.Font
        '金额显示
        Money_P.Left = underLine0.Left
        Money_P.Width = underLine0.Width
        Money_P.Height = operateMoney.Height - 1
        Money_P.Font = operateMoney.Font
        Money_P.Top = operateMoney.Top
        Money_P.ForeColor = Color.Red
        '"原材料剩余:"显示
        materialsurplus.Left = Yes_backL.Left
        materialsurplus.Top = operateMoney.Top
        materialsurplus.Width = materialName.Width
        materialsurplus.Height = operateMoney.Height
        materialsurplus.Font = operateMoney.Font
        '下划线2
        underline1.Left = materialsurplus.Left + materialsurplus.Width
        underline1.Width = underLine0.Width
        underline1.Height = 1
        underline1.Top = underLine0.Top
        underline1.BackColor = Color.Black
        '原材料剩余显示
        materialsP.Left = underline1.Left
        materialsP.Width = underline1.Width
        materialsP.Height = operateMoney.Height - 1
        materialsP.Top = operateMoney.Top
        materialsP.Font = materialsurplus.Font
        '显示“kg”
        kg1.Left = materialsP.Left + materialsP.Width
        kg1.Width = kg.Width
        kg1.Height = kg.Height
        kg1.Top = operateMoney.Top
        kg1.Font = kg.Font
        

    End Sub
    '显示“原材料进出”隐藏的控件
    Private Sub ShowMaterialM()
        materialName.Show()
        materialNameI.Show()
        MaterialPrice.Show()
        priceI.Show()
        price_P.Show()
        Num.Show()
        NumL.Show()
        numP.Show()
        workingOperat.Show()
        addMaterial.Show()
        addMaterialb.Show()
        NewMaterialL.Show()
        Newmaterialb.Show()
        materialLose.Show()
        materialloseB.Show()
        otherexplain.Show()
        operateNum.Show()
        operateNumI.Show()
        kg.Show()
        Yes_backL.Show()
        yes.Show()
        operateMoney.Show()
        underLine0.Show()
        yuan.Show()
        Money_P.Show()
        materialsurplus.Show()
        underline1.Show()
        materialsP.Show()
        kg1.Show()

    End Sub
    '隐藏“原材料进出”显示的控件
    Private Sub HideMaterialM()
        materialName.Hide()
        materialNameI.Hide()
        MaterialPrice.Hide()
        priceI.Hide()
        price_P.Hide()
        Num.Hide()
        NumL.Hide()
        numP.Hide()
        workingOperat.Hide()
        addMaterial.Hide()
        addMaterialb.Hide()
        NewMaterialL.Hide()
        Newmaterialb.Hide()
        materialLose.Hide()
        materialloseB.Hide()
        otherexplain.Hide()
        operateNum.Hide()
        operateNumI.Hide()
        kg.Hide()
        Yes_backL.Hide()
        yes.Hide()
        operateMoney.Hide()
        underLine0.Hide()
        yuan.Hide()
        Money_P.Hide()
        materialsurplus.Hide()
        underline1.Hide()
        materialsP.Hide()
        kg1.Hide()

    End Sub
    '“生成产品”布局
    Private Sub createPMap()
        '定义各组件高距
        Dim high As Double = 40 * index.zoomHeight
        '“产品名称：”
        productName1.Top = backLine.Top + 70 * index.zoomHeight
        productName1.Left = 15 * index.zoomHeight + backLine.Left
        productName1.Width = 160 * index.zoomHeight
        productName1.Height = 35 * index.zoomHeight
        productName1.Font = New System.Drawing.
            Font("微软雅黑", 18 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '原材料名称输入框
        productNameI1.Left = productName1.Left + productName1.Width
        productNameI1.Width = 160 * index.zoomHeight
        productNameI1.Font = New System.Drawing.
            Font("宋体", 17 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        productNameI1.Top = productName1.Top
        '显示“产品编号：”
        productNum.Left = productNameI1.Left + productNameI1.Width + 50 * index.zoomHeight
        productNum.Width = productName1.Width
        productNum.Height = productName1.Height
        productNum.Top = productName1.Top
        productNum.Font = productName1.Font
        '产品编号背景线条显示
        productNumPL.Left = productNum.Left + productNum.Width
        productNumPL.Width = productNameI1.Width
        productNumPL.Height = productName1.Height
        productNumPL.Top = productName1.Top
        productNumPL.BackColor = backLine.BackColor
        '"产品编号"显示
        productNumP.Left = productNumPL.Left + 1
        productNumP.Width = productNumPL.Width - 2
        productNumP.Height = productNumPL.Height - 2
        productNumP.Top = productNumPL.Top + 1
        productNumP.Font = productNameI1.Font
        '显示“产品规格：”
        productType.Left = productName1.Left
        productType.Width = productName1.Width
        productType.Height = productName1.Height
        productType.Top = productName1.Top + productName1.Height + high
        productType.Font = productName1.Font
        '产品规格输入框
        producttypeI.Left = productType.Left + productType.Width
        producttypeI.Width = productType.Width
        producttypeI.Height = productType.Height
        producttypeI.Top = productType.Top
        producttypeI.Font = productNameI1.Font
        '显示“g”
        g.Left = producttypeI.Left + producttypeI.Width
        g.Width = 50 * index.zoomHeight
        g.Height = productNum.Height
        g.Font = productNum.Font
        g.Top = productType.Top
        '显示“生成数量：”
        createNum.Left = productNum.Left
        createNum.Width = productType.Width
        createNum.Height = productType.Height
        createNum.Top = productType.Top
        createNum.Font = productType.Font
        '“生成数量”输入框
        createNumI.Left = createNum.Left + createNum.Width
        createNumI.Width = producttypeI.Width
        createNumI.Font = producttypeI.Font
        createNumI.Top = createNum.Top
        '“消耗原料：”显示
        materialDeplete.Left = productName1.Left
        materialDeplete.Width = createNum.Width
        materialDeplete.Height = createNum.Height
        materialDeplete.Top = createNum.Top + createNum.Height + high
        materialDeplete.Font = createNum.Font
        '"加"图片显示
        addImage.Width = 40
        addImage.Left = materialDeplete.Left + materialDeplete.Width / 2 - 35 * index.zoomHeight
        addImage.Height = 40
        addImage.Top = materialDeplete.Top + materialDeplete.Height + high
        index.LoadImage(addImage, "\SystemImg\", "add1")
        '确定按钮的背景线条
        sure_L.Width = 200 * index.zoomHeight
        sure_L.Height = 50 * index.zoomHeight
        sure_L.Top = backLine.Top + backLine.Height - 80 * index.zoomHeight
        sure_L.Left = backLine.Left + backLine.Width - 300 * index.zoomHeight
        sure_L.BackColor = Color.FromArgb(&HFFCCEBF5)
        '确定按钮
        sureb.Left = sure_L.Left + 1
        sureb.Height = sure_L.Height - 2
        sureb.Width = sure_L.Width - 2
        sureb.Top = sure_L.Top + 1
        sureb.BackColor = head.BackColor
        sureb.Font = New System.Drawing.
            Font("宋体", 20 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        sureb.ForeColor = Color.White
        '警告显示
        warning.Left = materialDeplete.Left
        warning.Top = sureb.Top
        warning.Height = sureb.Height
        warning.Width = sureb.Left - warning.Left
        warning.ForeColor = Color.Red
        warning.Font = New System.Drawing.
            Font("微软雅黑", 16 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    End Sub
    '隐藏“生成产品”显示的控件
    Private Sub HideCreateP()
        productName1.Hide()
        productNameI1.Hide()
        productNum.Hide()
        productNumPL.Hide()
        productNumP.Hide()
        productType.Hide()
        producttypeI.Hide()
        g.Hide()
        createNum.Hide()
        createNumI.Hide()
        materialDeplete.Hide()
        addImage.Hide()
        sure_L.Hide()
        sureb.Hide()
        warning.Hide()

    End Sub
    '显示“生成产品”隐藏的控件
    Private Sub ShowCreateP()
        productName1.Show()
        productNameI1.Show()
        productNum.Show()
        productNumPL.Show()
        productNumP.Show()
        productType.Show()
        producttypeI.Show()
        g.Show()
        createNum.Show()
        createNumI.Show()
        materialDeplete.Show()
        addImage.Show()
        sure_L.Show()
        sureb.Show()
        warning.Show()

    End Sub
    '点击时改变按钮的颜色
    Private Sub changeButtonColor(ByVal Flag As Integer)
        Dim Num As Integer
        For I = 0 To 2
            If WinFlag(I) = True Then
                Num = I
                WinFlag(I) = False
                Exit For
            End If
        Next
        Select Case Num
            Case 0
                materialB.BackColor = head.BackColor
                HideMaterialM()
            Case 1
                createP.BackColor = head.BackColor
                HideCreateP()
            Case 2
                materialSB.BackColor = head.BackColor
                HideMaterialSearch()
        End Select
        Select Case Flag
            Case 0
                materialB.BackColor = head1.BackColor
                WinFlag(0) = True
                If (MapB(0) = False) Then
                    MaterialMMap()
                    MapB(0) = True
                Else
                    ShowMaterialM()
                End If
            Case 1
                createP.BackColor = head1.BackColor
                WinFlag(1) = True
                If (MapB(1) = False) Then
                    createPMap()
                    MapB(1) = True
                Else
                    ShowCreateP()
                End If
            Case 2
                materialSB.BackColor = head1.BackColor
                WinFlag(2) = True
                If (MapB(2) = False) Then
                    MaterialSearchMap()
                    MapB(2) = True
                Else
                    ShowMaterialSearch()
                End If
        End Select
    End Sub
    '现在时间更新
    Private Sub Nowtimeupdater_Tick(sender As Object, e As EventArgs) Handles Nowtimeupdater.Tick
        Nowtime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
    End Sub

    Private Sub back_click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        index.Show()
    End Sub
    '添加新原料按钮点击事件
    Private Sub materialB_click(sender As Object, e As EventArgs) Handles materialB.Click
        changeButtonColor(0)
    End Sub

    Private Sub createP_click(sender As Object, e As EventArgs) Handles createP.Click
        changeButtonColor(1)
    End Sub

    Private Sub materialSB_click(sender As Object, e As EventArgs) Handles materialSB.Click
        changeButtonColor(2)
    End Sub
    '其他操作的鼠标点击的变化
    Private Sub otherexplain_mousedown(sender As Object, e As EventArgs) Handles otherexplain.MouseDown
        RecoverColor(3)
        If otherexplain.Text = "（其他）" Then
            otherexplain.Text = ""
            otherexplain.ForeColor = Color.Black
        End If
    End Sub
    Private Sub otherexplain_mouseleave() Handles otherexplain.MouseLeave
        If otherexplain.Text = "" Then
            otherexplain.ForeColor = Color.Gray
            otherexplain.Text = "（其他）"
        End If
    End Sub
    Private Sub otherexplain_focuschange() Handles otherexplain.LostFocus
        If otherexplain.Text = "" Then
            otherexplain.Text = "（其他）"
        End If
    End Sub
    Private Sub otherexplain_keypress(sender As Object, e As EventArgs) Handles otherexplain.KeyPress
        If otherexplain.Text = "（其他）" Then
            otherexplain.Text = ""
        End If
    End Sub
    '确定按钮颜色变化（鼠标down  up）
    Private Sub yes_MouseDown(sender As Object, e As EventArgs) Handles yes.MouseDown
        yes.BackColor = head1.BackColor
    End Sub
    Private Sub yes_MouseUp(sender As Object, e As EventArgs) Handles yes.MouseUp
        yes.BackColor = head.BackColor
    End Sub
    '将变色的按钮恢复原来的颜色
    Private Sub RecoverColor(ByVal Flag As Integer)
        Dim Num As Integer
        For I = 0 To 2
            If BFLag(I) = True Then
                If (I = Flag) Then
                    Exit Sub
                End If
                Num = I
                BFLag(I) = False
            End If
        Next
        Select Case Num
            Case 0
                Newmaterialb.BackColor = head.BackColor
            Case 1
                addMaterialb.BackColor = head.BackColor
            Case 2
                materialloseB.BackColor = head.BackColor
        End Select
        Select Case Flag
            Case 0
                Newmaterialb.BackColor = head1.BackColor
                BFLag(0) = True
            Case 1
                addMaterialb.BackColor = head1.BackColor
                BFLag(1) = True
            Case 2
                materialloseB.BackColor = head1.BackColor
                BFLag(2) = True
        End Select
    End Sub
    '"添加原材料"按钮点击
    Private Sub NewMaterialB_click(sender As Object, e As EventArgs) Handles Newmaterialb.Click
        If materialNameI.Text.ToString <> "" Then
            If JudgeAddMaterial() = True Then
                RecoverColor(0)
            End If
        Else
            RecoverColor(0)
        End If
    End Sub
    '“添加原材料”按钮点击
    Private Sub AddmaterialB_click(sender As Object, e As EventArgs) Handles addMaterialb.Click
        If materialNameI.Text.ToString <> "" Then
            If Judgematerial() = True Then
                RecoverColor(1)
            End If
        Else
            RecoverColor(1)
        End If
    End Sub
    '"原材料损耗"按钮点击
    Private Sub materialLose_click(sender As Object, e As EventArgs) Handles materialloseB.Click
        If materialNameI.Text.ToString <> "" Then
            If Judgematerial() = True Then
                RecoverColor(2)
            End If
        Else
            RecoverColor(2)
        End If
    End Sub
    Private Sub materialNameI_KeyUp() Handles materialNameI.KeyUp
        LoadDataAfterInputName()
    End Sub
    '输入原料名后从数据库中载入原料信息
    Private Sub LoadDataAfterInputName()
        If materialNameI.Text.ToString <> "" Then
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = "select material_id,material_price,material_surplus from cx_material where material_name = '" & materialNameI.Text.ToString & "'"
            Dim data As New DataTable
            Dim sqlda As SQLite.SQLiteDataAdapter
            Try
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                sqlda.Fill(data)
                If data.Rows.Count = 0 Then
                    RecoverColor(0)
                    priceI.Text = ""
                    rePrice = 0
                    numP.Text = LoadProductID()
                    materialsP.Text = 0
                Else
                    RecoverColor(1)
                    numP.Text = data.Rows.Item(0).Item(0)
                    priceI.Text = data.Rows.Item(0).Item(1)
                    rePrice = Val(priceI.Text)
                    materialsP.Text = data.Rows.Item(0).Item(2)
                End If
            Catch ex As Exception
                index.MsgOrNotifyForm("提示", ex.Message)
            End Try
        Else
            RecoverColor(-1)  '将强调的按钮恢复
            numP.Text = ""
            priceI.Text = ""
            materialsP.Text = ""
        End If
    End Sub
    '加载原料新添加的Id
    Private Function LoadProductID()
        Dim returnId As Integer
        Try
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = "select min(id) from cx_material_id_record"
            Dim sqlda As SQLite.SQLiteDataAdapter
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            Dim tempDataTable As New DataTable
            sqlda.Fill(tempDataTable)
            If tempDataTable.Rows.Item(0).Item(0).ToString = "" Then
                tempDataTable.Reset()
                sqlcmd.CommandText = "select max(material_id) from cx_material"
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                sqlda.Fill(tempDataTable)
                If tempDataTable.Rows.Item(0).Item(0).ToString = "" Then
                    returnId = 1
                Else
                    returnId = tempDataTable.Rows.Item(0).Item(0) + 1
                End If
            Else
                returnId = tempDataTable.Rows.Item(0).Item(0)
            End If
        Catch ex As Exception
            index.MsgOrNotifyForm("错误", ex.Message)
        End Try
        LoadProductID = returnId
    End Function
    '判断数据库里边时候已经有了此类原料
    Private Function JudgeAddMaterial()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandText = "select material_id from cx_material where material_name = '" & materialNameI.Text.ToString & "'"
        Dim sqlda As SQLite.SQLiteDataAdapter
        Dim data As New DataTable
        Try
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(data)
            If data.Rows.Count <> 0 Then
                index.MsgOrNotifyForm("提示", "存在此类原料，不能点击新原料添加")
                JudgeAddMaterial = False
                Exit Function
            End If
        Catch ex As Exception
            index.MsgOrNotifyForm("提示", ex.Message)
        End Try
        JudgeAddMaterial = True
    End Function
    Private Function Judgematerial()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandText = "select material_id from cx_material where material_name = '" & materialNameI.Text.ToString & "'"
        Dim sqlda As SQLite.SQLiteDataAdapter
        Dim data As New DataTable
        Try
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(data)
            If data.Rows.Count = 0 Then
                index.MsgOrNotifyForm("提示", "不存在此类原料，不能点击添加产品或者产品损耗")
                Judgematerial = False
                Exit Function
            End If
        Catch ex As Exception
            index.MsgOrNotifyForm("提示", ex.Message)
        End Try
        Judgematerial = True
    End Function
    '对点击确定时对输入框进行判断其合理性
    Private Function JudgeInputBox()
        If materialNameI.Text.ToString = "" Then
            index.MsgOrNotifyForm("提示", "未输入原料名前不能进行操作！")
            JudgeInputBox = False
            Exit Function
        End If
        If priceI.Text.ToString = "" Then
            index.MsgOrNotifyForm("提示", "未输入原料单价前不能进行操作！")
            JudgeInputBox = False
            Exit Function
        End If
        If operateNumI.Text.ToString = "" Then
            index.MsgOrNotifyForm("提示", "未输入操作原料设计数量前不能进行操作！")
            JudgeInputBox = False
            Exit Function
        End If
        JudgeInputBox = True
    End Function
    '确定按钮点击事件
    Private Sub yes_click() Handles yes.Click
        If JudgeInputBox() = True Then
            operatorDb()
            rePrice = Val(priceI.Text)
        End If
    End Sub
    '点击确定后执行的代码(写入数据库)
    Private Sub operatorDb()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandText = GetItem()
        If sqlcmd.CommandText <> "" Then
            Try
                sqlcmd.ExecuteNonQuery()
            Catch ex As Exception
                index.MsgOrNotifyForm("提示", ex.Message)
            End Try
        End If
    End Sub
    '获取现在需要进行的操作选项并制定相应的查询代码
    Private Function GetItem()
        Dim flag As Integer = -1
        Dim InvolvedMoney As Double
        For i = 0 To 2
            If BFLag(i) = True Then
                flag = i
                Exit For
            End If
        Next
        If flag = -1 Then
            If index.identify = True Then
                If rePrice <> 0 Then
                    InvolvedMoney = rePrice * Val(operateNumI.Text)
                    operateMoney.Text = InvolvedMoney
                    If rePrice <> Val(priceI.Text) Then
                        GetItem = "insert into cx_material_log (material_id,operator_id,operator_type,old_price,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & 1 & "," & Val(rePrice) & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '" & otherexplain.Text.ToString & "')"
                    Else
                        GetItem = "insert into cx_material_log (material_id,operator_id,operator_type,old_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & 1 & "," & Val(rePrice) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '" & otherexplain.Text.ToString & "')"
                    End If
                Else
                    InvolvedMoney = Val(priceI.Text) * Val(operateNumI.Text)
                    GetItem = "insert into cx_material_log (material_id,operator_id,operator_type,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & 1 & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '" & otherexplain.Text.ToString & "')"
                    operateMoney.Text = InvolvedMoney
                End If
            Else
                If rePrice <> 0 Then
                    InvolvedMoney = rePrice * Val(operateNumI.Text)
                    operateMoney.Text = InvolvedMoney
                    If rePrice <> Val(priceI.Text) Then
                        GetItem = "insert into cx_material_log (material_id,operator_id,old_price,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & Val(rePrice) & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '" & otherexplain.Text.ToString & "')"
                    Else
                        GetItem = "insert into cx_material_log (material_id,operator_id,old_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & Val(rePrice) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '" & otherexplain.Text.ToString & "')"
                    End If
                Else
                    InvolvedMoney = Val(priceI.Text) * Val(operateNumI.Text)
                    GetItem = "insert into cx_material_log (material_id,operator_id,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '" & otherexplain.Text.ToString & "')"
                End If
            End If
        ElseIf flag = 0 Then
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandText = "insert into cx_material(material_id,material_name,material_price,material_brought_count,material_surplus)values( " & Val(numP.Text) & ",'" & materialNameI.Text.ToString & "'," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & Val(operateNumI.Text) & ")"
            Try
                sqlcmd.ExecuteNonQuery()
                materialsP.Text = Val(materialsP.Text) + Val(operateNumI.Text)
            Catch ex As Exception
                index.MsgOrNotifyForm("提示", ex.Message)
            End Try
            InvolvedMoney = Val(priceI.Text) * Val(operateNumI.Text)
            If index.identify = True Then
                GetItem = "insert into cx_material_log (material_id,operator_id,operator_type,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & 1 & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '新增原料')"
            Else
                GetItem = "insert into cx_material_log (material_id,operator_id,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '新增原料')"
            End If
        ElseIf flag = 1 Then
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.Connection = index.Conn
            If rePrice <> Val(priceI.Text) Then
                sqlcmd.CommandText = "update cx_material set material_price = " & Val(priceI.Text) & " , material_brought_count = material_brought_count + " & Val(operateNumI.Text) & " , material_surplus = material_surplus + " & Val(operateNumI.Text) & " where material_id = " & Val(numP.Text)
                InvolvedMoney = rePrice * Val(operateNumI.Text)
                If index.identify = True Then
                    GetItem = "insert into cx_material_log (material_id,operator_id,operator_type,old_price,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & 1 & "," & rePrice & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '原料补充')"
                Else
                    GetItem = "insert into cx_material_log (material_id,operator_id,old_price,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & rePrice & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '原料补充')"
                End If
            Else
                sqlcmd.CommandText = "update cx_material set material_brought_count = material_brought_count + " & Val(operateNumI.Text) & " , material_surplus = material_surplus + " & Val(operateNumI.Text) & " where material_id = " & Val(numP.Text)
                InvolvedMoney = Val(operateNumI.Text) * Val(priceI.Text)
                If index.identify = True Then
                    GetItem = "insert into cx_material_log (material_id,operator_id,operator_type,old_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & 1 & "," & rePrice & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '原料补充')"
                Else
                    GetItem = "insert into cx_material_log (material_id,operator_id,old_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & rePrice & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '原料补充')"
                End If
            End If
            Try
                sqlcmd.ExecuteNonQuery()
                materialsP.Text = Val(materialsP.Text) + Val(operateNumI.Text)
            Catch ex As Exception
                index.MsgOrNotifyForm("提示", ex.Message)
            End Try
        ElseIf flag = 2 Then
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.Connection = index.Conn
            If checkMaterial() = True Then
                If rePrice <> Val(priceI.Text) Then
                    sqlcmd.CommandText = "update cx_material set material_price = " & Val(priceI.Text) & " , material_surplus = material_surplus - " & Val(operateNumI.Text) & " where material_id = " & Val(numP.Text)
                    InvolvedMoney = rePrice * Val(operateNumI.Text)
                    If index.identify = True Then
                        GetItem = "insert into cx_material_log (material_id,operator_id,operator_type,old_price,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & 1 & "," & rePrice & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '原料消耗')"
                    Else
                        GetItem = "insert into cx_material_log (material_id,operator_id,old_price,new_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & rePrice & "," & Val(priceI.Text) & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '原料消耗')"
                    End If
                Else
                    sqlcmd.CommandText = "update cx_material set material_surplus = material_surplus - " & Val(operateNumI.Text) & " where material_id = " & Val(numP.Text)
                    InvolvedMoney = Val(priceI.Text) * Val(operateNumI.Text)
                    If index.identify = True Then
                        GetItem = "insert into cx_material_log (material_id,operator_id,operator_type,old_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & 1 & "," & rePrice & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '原料消耗')"
                    Else
                        GetItem = "insert into cx_material_log (material_id,operator_id,old_price,dosage,InvolvedMoney,introduction)values(" & Val(numP.Text) & "," & Val(index.id) & "," & rePrice & "," & Val(operateNumI.Text) & "," & InvolvedMoney & ", '原料消耗')"
                    End If
                End If
                Try
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    index.MsgOrNotifyForm("提示", ex.Message)
                End Try
            Else
                GetItem = ""
            End If
        End If
    End Function
    '用来检测原料消耗是否合理
    Private Function checkMaterial()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = "select material_surplus from cx_material where material_id = " & Val(numP.Text)
        Dim sqlda As SQLite.SQLiteDataAdapter
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
        Dim data As New DataTable
        sqlda.Fill(data)
        If Val(data.Rows.Item(0).Item(0)) - Val(operateNumI.Text) >= 0 Then
            checkMaterial = True
        Else
            checkMaterial = False
            index.MsgOrNotifyForm("提示", "剩余原料不满足此次操作的最低要求！")
        End If
    End Function
    '计算出涉及的资金
    Private Sub calculateMoeny()
        If rePrice <> 0 Then
            If operateNumI.Text <> "" Then
                Money_P.Text = rePrice * Val(operateNumI.Text)
            Else
                Money_P.Text = 0
            End If
        Else
            If priceI.Text <> "" Then
                If operateNumI.Text <> "" Then
                    Money_P.Text = Val(priceI.Text) * Val(operateNumI.Text)
                Else
                    Money_P.Text = 0
                End If
            End If
        End If
    End Sub
    '操作涉及重量输入框keyup事件
    Private Sub operaNumI_keyUp() Handles operateNumI.KeyUp
        calculateMoeny()
    End Sub
    '产品输入框输入时从数据库中选取对应的ID
    Private Sub productNameI1_keypress(o As Object, e As KeyPressEventArgs) Handles productNameI1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If productNameI1.Text <> "" Then
                LoadProId()
            End If
        End If
    End Sub
    '从数据库中选取生成产品的Id
    Private Sub LoadProId()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandText = "select product_id,specification from cx_product where name = '" & productNameI1.Text.ToString & "'"
        Dim sqlda As SQLite.SQLiteDataAdapter
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
        Dim temp As New DataTable
        sqlda.Fill(temp)
        If temp.Rows.Count <> 0 Then
            productNumP.Text = temp.Rows.Item(0).Item(0)
            producttypeI.Text = Val(temp.Rows.Item(0).Item(1)) * 1000
        Else
            index.MsgOrNotifyForm("提示", "没有名为 <" & productNameI1.Text & "> 的产品！")
        End If
    End Sub
    '对产品规格的
End Class