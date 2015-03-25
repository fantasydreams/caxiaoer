Imports System.Diagnostics
Public Class productManage

    Dim AddPMapFlag As Boolean = False
    '定义一个公用的数据表Table
    Private TableData As New DataTable
    '定义显示器上一张表能够显示的数据总栏数
    Private ColunmNum As Integer
    Private PageDown As Boolean '标记是否能进行向下翻页
    Private PageUp As Boolean '标记是否能进行向上翻页
    Private PageNum As Integer = 0 '标记目前所在页
    Private AllproductButton As Boolean '标记alleproduct按钮是否为正在工作的按钮
    Private TypeList As New DataTable '定义一个记录产品类型的表
    Private MaterialAndId As New DataTable '定义函数公用类型记录原料的种类和ID
    Private MaterialAdd As New DataGridView  '定义用来记录原料的选择和ID以及用量
    Private ImagePathName As String '定义字符串记录图片所在的位置
    Private TempDataTable As New DataTable '用来记录当前产品的产品类型名
    Private PName As String = "" '记录产品存储名称
    Private ProName As String = "" '记录产品名称
    Private UploadPicture As Boolean '标记产品图片是否已经上传
    Private SearchB As Boolean '标记是否是通过搜索而得到的数据
    Private ColorFlag(7) As Integer '标记颜色的范围
    Private CheckKeywords(7) As String '存储查询关键字
    Private WriteKey As Boolean '标记是否初始化了关键字
    Private FlagError As Boolean = True  '标记是否已经显示了错误提示
    Private id_record As Boolean = False '标记是否用的之前用过的id


    Private Sub productManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mapLoad()
        LoadDataFromDB(0)
    End Sub
    Private Sub mapLoad()
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
        admin.Font = New System.Drawing.
            Font("宋体", 16 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        admin.Text = index.nickname
        '现在时间显示
        NowTime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
        NowTime.Left = admin.Left
        NowTime.Top = admin.Top + admin.Height * 3 / 2
        NowTime.Height = admin.Height
        NowTime.Width = admin.Width
        NowTime.Font = admin.Font
        NowTime.BackColor = head.BackColor
        '绘制搜索按钮的背景
        searchback.Width = 450 * index.zoomHeight
        searchback.Height = 70 * index.zoomHeight
        searchback.Left = index.ScreenWidth - 50 * index.zoomHeight - searchback.Width
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
        '添加商品按钮
        AddProduct.Width = 180 * index.zoomHeight
        AddProduct.Height = 60 * index.zoomHeight
        AddProduct.Left = searchback.Left - 30 * index.zoomHeight - AddProduct.Width
        AddProduct.Top = searchback.Top + searchback.Height / 2 - AddProduct.Height / 2
        AddProduct.Font = search.Font
        AddProduct.ForeColor = Color.White
        AddProduct.BackColor = head.BackColor
        index.SetLableWin(AddProduct, 12)
        '“全部商品”按钮绘制
        allProduct.Left = AddProduct.Left - 10 * index.zoomHeight - AddProduct.Width
        allProduct.Width = AddProduct.Width
        allProduct.Height = AddProduct.Height
        allProduct.Top = AddProduct.Top
        allProduct.BackColor = Color.FromArgb(&HFF006699)
        allProduct.Font = New System.Drawing.
            Font("宋体", 26 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        allProduct.ForeColor = Color.White
        index.SetLableWin(allProduct, 12)

        '数据显示表
        Data.Top = searchback.Top + searchback.Height + 50 * index.zoomHeight
        Data.Width = index.ScreenWidth - 80 * index.zoomWidth
        Data.Left = index.ScreenWidth / 2 - Data.Width / 2
        Data.ColumnHeadersHeight = 30 * index.zoomHeight
        ColunmNum = (index.ScreenHeight - (searchback.Top + searchback.Height + 100 * index.zoomHeight) - 30 * index.zoomHeight) / (23 * index.zoomHeight)
        Data.Height = ColunmNum * 23 * index.zoomHeight + 30 * index.zoomHeight + 1 * index.zoomHeight
        Data.RowTemplate.Height = 23 * index.zoomHeight
        Data.Font = New System.Drawing.
            Font("宋体", 13 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        index.SetWidth(Data)
        '下一页按钮
        pageDown1.Width = 150 * index.zoomHeight
        pageDown1.Height = 40 * index.zoomHeight
        pageDown1.Top = ((index.ScreenHeight - (Data.Top + Data.Height)) / 2 - pageDown1.Height / 2) + (Data.Top + Data.Height)
        pageDown1.Left = Data.Left + Data.Width - pageDown1.Width
        pageDown1.Font = New System.Drawing.
            Font("宋体", 20 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        pageDown1.ForeColor = Color.White
        pageDown1.BackColor = Color.FromArgb(&HFF797979)
        index.SetLableWin(pageDown1, 12)
        '上一页按钮
        PageUP1.Width = pageDown1.Width
        PageUP1.Height = pageDown1.Height
        PageUP1.ForeColor = Color.White
        PageUP1.Font = pageDown1.Font
        PageUP1.Left = pageDown1.Left - PageUP1.Width - 10 * index.zoomHeight
        PageUP1.BackColor = pageDown1.BackColor
        PageUP1.Top = pageDown1.Top
        index.SetLableWin(PageUP1, 12)
    End Sub

    '隐藏“全部商品”、“添加商品”、“搜索”等按钮
    Private Sub hideButton()
        searchback.Hide()
        allProduct.Hide()
        AddProduct.Hide()
        searchButton.Hide()
        search.Hide()
        searchInput.Hide()
        PageUP1.Hide()
        pageDown1.Hide()
        Data.Hide()
    End Sub
    '显示“全部商品”、“添加商品”、“搜索”等按钮
    Private Sub showButton()
        searchback.Show()
        allProduct.Show()
        AddProduct.Show()
        searchButton.Show()
        search.Show()
        searchInput.Show()
        PageUP1.Show()
        pageDown1.Show()
        Data.Show()
    End Sub

    Private Sub AddProductMap()
        AddPMapFlag = True
        '绘制背景线条
        AddProduct_line.Width = 850 * index.zoomHeight
        AddProduct_line.Top = head.Height + 50 * index.zoomHeight
        AddProduct_line.Height = index.ScreenHeight - AddProduct_line.Top - 50 * index.zoomHeight
        AddProduct_line.Left = index.ScreenWidth / 2 - AddProduct_line.Width / 2
        AddProduct_line.BackColor = Color.FromArgb(&HFF797979)
        '绘制背景面板
        backGround.Left = AddProduct_line.Left + 1
        backGround.Width = AddProduct_line.Width - 2
        backGround.Height = AddProduct_line.Height - 2
        backGround.Top = AddProduct_line.Top + 1
        backGround.BackColor = Color.FromArgb(&HFFFFFFCC)
        '关闭按钮
        AddClose.Width = 42
        AddClose.Height = 40
        AddClose.Left = backGround.Left + backGround.Width - AddClose.Width
        AddClose.Top = backGround.Top
        index.LoadImage(AddClose, "\SystemImg\", "close")
        AddClose.BackColor = backGround.BackColor
        '“新增产品”打印
        AddPP.Width = 120 * index.zoomHeight
        AddPP.Height = 30 * index.zoomHeight
        AddPP.Left = backGround.Left + backGround.Width / 2 - AddPP.Width / 2
        AddPP.Top = backGround.Top + 15 * index.zoomHeight
        AddPP.Font = New System.Drawing.
            Font("宋体", 16 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        AddPP.BackColor = backGround.BackColor
        '"产品名称："打印
        ProductNames.Top = AddPP.Top + AddPP.Height + 20 * index.zoomHeight
        ProductNames.Width = 120 * index.zoomHeight
        ProductNames.Height = 30 * index.zoomHeight
        ProductNames.Left = 60 * index.zoomHeight + backGround.Left
        ProductNames.Font = New System.Drawing.
            Font("宋体", 16 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        ProductNames.BackColor = backGround.BackColor
        '产品名称输入框
        ProductNameInput.Left = ProductNames.Left + ProductNames.Width
        ProductNameInput.Width = index.ScreenWidth / 2 - ProductNameInput.Left - 20 * index.zoomHeight
        ProductNameInput.Top = ProductNames.Top
        ProductNameInput.Height = ProductNames.Height
        ProductNameInput.Font = ProductNames.Font
        '定义各组件间的高距
        Dim high As Double = 18 * index.zoomHeight
        '"产品类型："打印
        ProductType.Left = ProductNames.Left
        ProductType.Width = ProductNames.Width
        ProductType.Height = ProductNames.Height
        ProductType.Font = ProductNames.Font
        ProductType.Top = ProductNames.Top + ProductNames.Height + high
        ProductType.BackColor = backGround.BackColor
        '“商品选项”框打印
        ProductTypelist.Left = ProductNameInput.Left
        ProductTypelist.Top = ProductType.Top
        ProductTypelist.Width = ProductNameInput.Width
        ProductTypelist.Height = ProductNameInput.Height
        ProductTypelist.Font = ProductNameInput.Font
        '“产品编号”打印
        productID.Left = ProductNames.Left
        productID.Width = ProductNames.Width
        productID.Height = ProductNames.Height
        productID.Top = ProductType.Top + high + ProductNames.Height
        productID.Font = ProductNames.Font
        productID.BackColor = ProductNames.BackColor
        '产品ID显示
        ProductIDP.Left = ProductTypelist.Left
        ProductIDP.Top = productID.Top
        ProductIDP.Width = ProductTypelist.Width
        ProductIDP.Height = ProductTypelist.Height
        ProductIDP.Font = ProductTypelist.Font
        '产品规格输入框
        productS_IO.Width = ProductIDP.Width
        productS_IO.Height = ProductIDP.Height
        productS_IO.Left = ProductIDP.Left
        productS_IO.Font = ProductIDP.Font
        productS_IO.Top = ProductIDP.Top + ProductIDP.Height + high
        '“产品规格：”
        productStandard.Top = productS_IO.Top
        productStandard.Width = productID.Width
        productStandard.Height = productID.Height
        Top = productID.Top + productID.Height + high
        productStandard.Left = productID.Left
        productStandard.Font = productID.Font
        productStandard.BackColor = productID.BackColor
        '“产品单价：”
        product_price.Width = productStandard.Width
        product_price.Height = productStandard.Height
        product_price.Top = productStandard.Top + productStandard.Height + high
        product_price.Left = productStandard.Left
        product_price.Font = productStandard.Font
        product_price.BackColor = productStandard.BackColor
        '产品单价输入框
        price_Input.Width = productS_IO.Width
        price_Input.Height = productS_IO.Height
        price_Input.Top = product_price.Top
        price_Input.Left = productS_IO.Left
        price_Input.Font = productS_IO.Font
        '“产品数量：”打印
        productNum.Width = product_price.Width
        productNum.Height = product_price.Height
        productNum.Top = product_price.Top + product_price.Height + high
        productNum.Left = product_price.Left
        productNum.Font = product_price.Font
        productNum.BackColor = product_price.BackColor
        '产品数量输入框
        productNum_i.Left = price_Input.Left
        productNum_i.Width = price_Input.Width
        productNum_i.Height = price_Input.Height
        productNum_i.Top = productNum.Top
        productNum_i.Font = price_Input.Font
        '打印“产品原料：”
        productMaterial.Left = productNum.Left
        productMaterial.Width = productNum.Width
        productMaterial.Height = productNum.Height
        productMaterial.Top = productNum.Top + productNum.Height + high
        productMaterial.Font = productNum.Font
        productMaterial.BackColor = productNum.BackColor
        '添加原料选择栏
        Addmaterial.Left = productMaterial.Left + productMaterial.Width
        Addmaterial.Width = productNum_i.Width * 5 / 6
        Addmaterial.Top = productMaterial.Top
        Addmaterial.Font = productMaterial.Font
        '"添加号"
        Add.Height = 25
        Add.Width = 25
        Add.Left = productNum_i.Left + productNum_i.Width - Add.Width
        Add.Top = productMaterial.Top + productMaterial.Height / 2 - Add.Height / 2
        index.LoadImage(Add, "\SystemImg\", "add")
        '已选商品选项栏
        AddedM.Width = Addmaterial.Width / 2
        AddedM.Font = Addmaterial.Font
        AddedM.Top = Add.Top + Add.Height + high
        AddedM.Left = Addmaterial.Left
        '重量输入框
        heft_I.Left = AddedM.Left + AddedM.Width
        heft_I.Top = AddedM.Top
        heft_I.Width = AddedM.Width * 3 / 4
        heft_I.Font = New System.Drawing.
            Font("宋体", 14 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '显示“g”
        g_p.Left = heft_I.Left + heft_I.Width
        g_p.Width = AddedM.Width / 3
        g_p.Top = heft_I.Top
        g_p.Height = ProductIDP.Height
        g_p.Font = ProductIDP.Font
        g_p.BackColor = backGround.BackColor
        '删除原料号
        cutMaterial.Left = Add.Left
        cutMaterial.Width = Add.Width
        cutMaterial.Height = Add.Height
        cutMaterial.Top = heft_I.Top
        index.LoadImage(cutMaterial, "\SystemImg\", "Cut")
        '显示“上传图片：”
        uploadPic.Left = index.ScreenWidth / 2 + 20 * index.zoomHeight
        uploadPic.Width = productMaterial.Width
        uploadPic.Height = productMaterial.Height
        uploadPic.Top = ProductNames.Top
        uploadPic.Font = ProductNames.Font
        uploadPic.BackColor = ProductNames.BackColor
        '产品图片位
        productPic.Left = uploadPic.Left + uploadPic.Width
        productPic.Width = backGround.Left + backGround.Width - productPic.Left - 60 * index.zoomHeight
        productPic.Height = productPic.Width * 4 / 5
        productPic.Top = uploadPic.Top
        productPic.BackColor = backGround.BackColor
        index.LoadImage(productPic, "\SystemImg\", "unUpload")
        '浏览按钮绘制
        scanPic.Left = productPic.Left
        scanPic.Width = 90 * index.zoomHeight
        scanPic.Height = productMaterial.Height
        scanPic.BackColor = head.BackColor
        scanPic.Top = product_price.Top
        scanPic.Font = New System.Drawing.
            Font("宋体", 14 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        scanPic.ForeColor = Color.White
        index.SetLableWin(scanPic, 8)
        '上传按钮绘制
        upload.Width = scanPic.Width
        upload.Height = scanPic.Height
        upload.Font = scanPic.Font
        upload.Top = scanPic.Top
        upload.Left = productPic.Left + productPic.Width - upload.Width
        upload.ForeColor = Color.White
        index.SetLableWin(upload, 8)
        upload.BackColor = head.BackColor
        '绘制“二维码”字样
        productCode.Width = uploadPic.Width
        productCode.Height = uploadPic.Height
        productCode.Top = productNum.Top
        productCode.Left = uploadPic.Left
        productCode.Font = uploadPic.Font
        productCode.BackColor = backGround.BackColor
        '二维码图片显示线条绘制
        Code_line.Left = productPic.Left
        Code_line.Width = productPic.Width
        Code_line.Height = Code_line.Width
        Code_line.Top = productCode.Top
        Code_line.BackColor = Color.FromArgb(&HFFCCFFFF)
        '二维码图片显示
        productCodeP.Left = Code_line.Left + 1
        productCodeP.Width = Code_line.Width - 2
        productCodeP.Height = productCodeP.Width
        productCodeP.Top = Code_line.Top + 1
        '绘制点击生成二维码背景线条
        code_line1.Width = productCodeP.Width * 3 / 4
        code_line1.Height = 60 * index.zoomHeight
        code_line1.Left = productCodeP.Left + productCodeP.Width / 2 - code_line1.Width / 2
        code_line1.Top = productCodeP.Top + productCodeP.Height / 2 - code_line1.Height / 2
        code_line1.BackColor = Color.FromArgb(&HFF797979)
        index.SetLableWin(code_line1, 12)
        '绘制点击生成二维码按钮
        createCode.Left = code_line1.Left + 1
        createCode.Top = code_line1.Top + 1
        createCode.Width = code_line1.Width - 2
        createCode.Height = code_line1.Height - 2
        createCode.BackColor = head.BackColor
        index.SetLableWin(createCode, 8)
        createCode.ForeColor = Color.White
        createCode.Font = upload.Font
        '绘制“添加产品按钮”
        product.Width = 400 * index.zoomHeight
        product.Left = 2 * backGround.Left + (backGround.Width - productCodeP.Left) / 2 - product.Width / 2
        product.Height = 50 * index.zoomHeight
        product.Top = productCodeP.Top + productCodeP.Height - product.Height
        product.BackColor = head.BackColor
        product.Font = New System.Drawing.
            Font("宋体", 24 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        product.ForeColor = Color.White
        index.SetLableWin(product, 16)
    End Sub
    '隐藏添加商品窗口
    Private Sub hideAddMap()
        AddProduct_line.Hide()
        backGround.Hide()
        AddClose.Hide()
        AddPP.Hide()
        ProductNames.Hide()
        ProductNameInput.Hide()
        ProductType.Hide()
        ProductTypelist.Hide()
        productID.Hide()
        ProductIDP.Hide()
        productStandard.Hide()
        productS_IO.Hide()
        product_price.Hide()
        price_Input.Hide()
        productNum.Hide()
        productNum_i.Hide()
        productMaterial.Hide()
        Addmaterial.Hide()
        Add.Hide()
        AddedM.Hide()
        heft_I.Hide()
        g_p.Hide()
        cutMaterial.Hide()
        scanPic.Hide()
        upload.Hide()
        uploadPic.Hide()
        productPic.Hide()
        Code_line.Hide()
        productCode.Hide()
        productCodeP.Hide()
        code_line1.Hide()
        createCode.Hide()
        product.Hide()
    End Sub
    '显示添加商品窗口
    Private Sub showAddMap()
        AddProduct_line.Show()
        backGround.Show()
        AddClose.Show()
        AddPP.Show()
        ProductNames.Show()
        ProductNameInput.Show()
        ProductType.Show()
        ProductTypelist.Show()
        productID.Show()
        ProductIDP.Show()
        productStandard.Show()
        productS_IO.Show()
        product_price.Show()
        price_Input.Show()
        productNum.Show()
        productNum_i.Show()
        productMaterial.Show()
        Addmaterial.Show()
        Add.Show()
        AddedM.Show()
        heft_I.Show()
        g_p.Show()
        cutMaterial.Show()
        scanPic.Show()
        upload.Show()
        uploadPic.Show()
        productPic.Show()
        Code_line.Show()
        productCode.Show()
        productCodeP.Show()
        code_line1.Show()
        createCode.Show()
        product.Show()
    End Sub

    Private Sub NowTimeUpdate_Tick(sender As Object, e As EventArgs) Handles NowTimeUpdater.Tick
        NowTime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
    End Sub

    Private Sub back_click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        index.Show()
    End Sub

    Private Sub Addproduct_click(sender As Object, e As EventArgs) Handles AddProduct.Click
        hideButton()
        If AddPMapFlag = False Then
            AddPMapFlag = True
            AddProductMap()
            LoadDataTypeList()
            LoadMaterial()
            MaterialAdd.ColumnCount = 3
            MaterialAdd.AllowUserToAddRows = False
        Else
            showAddMap()
        End If
    End Sub
    '加载数据库中的数据到表中
    Private Sub LoadDataFromDB(ByVal Sort As Integer)
        TableData.Clear()
        Data.Rows.Clear()
        If SearchB = True Then
            SearchB = False
        End If
        Try
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            If Sort = 0 Then
                sqlcmd.CommandText = "select product_id,name,price,specification,surplus_count,sold_count,product_sort_id,picture from cx_product"
            Else
                sqlcmd.CommandText = "select product_id,name,price,specification,surplus_count,sold_count,product_sort_id,picture from cx_product where product_sort_id = '" & Sort & "'"
            End If
            Dim sqlda As SQLite.SQLiteDataAdapter
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            Dim Flag, MaterialNameAndUse As String
            Dim Num As Integer
            If ColunmNum >= TableData.Rows.Count() - PageNum * ColunmNum Then
                Num = TableData.Rows.Count() - PageNum * ColunmNum - 1
            Else
                Num = ColunmNum - 1
            End If
            For i = 0 To Num
                sqlcmd.CommandText = "select product_sort_name from cx_product_sort where product_sort_id = '" & TableData.Rows.Item(i).Item(6) & "'"
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                TempDataTable.Reset()
                sqlda.Fill(TempDataTable)
                MaterialNameAndUse = LoadMaterialConstitute(TableData.Rows.Item(i).Item(0))
                Flag = TempDataTable.Rows.Item(0).Item(0)
                Data.Rows.Add(TableData.Rows.Item(i).Item(0), TableData.Rows.Item(i).Item(1), TableData.Rows.Item(i).Item(2),
                              TableData.Rows.Item(i).Item(3) * 1000, TableData.Rows.Item(i).Item(4),
                              TableData.Rows.Item(i).Item(5), Flag, "查看图片", MaterialNameAndUse, "查看详情", "删除")
                'SetFormerDataStyle(i, i)
                If i = ColunmNum - 1 Then
                    PageDown = True
                    pageDown1.BackColor = head.BackColor
                End If
            Next
        Catch ex As Exception
            index.MsgOrNotifyForm("错误", ex.Message)
        End Try

    End Sub
    '读取产品所需的原料
    Private Function LoadMaterialConstitute(ByVal ID As Integer)
        Dim MaterialNameAndUse As String = ""
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = "select material_id,material_use from cx_material_use where product_id = " & ID
        Dim sqlda As SQLite.SQLiteDataAdapter
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
        Dim temp As New DataTable
        sqlda.Fill(temp)
        Dim temp1 As New DataTable
        For i = 0 To temp.Rows.Count() - 1
            temp1.Reset()
            sqlcmd.CommandText = "select material_name from cx_material where material_id = " & temp.Rows.Item(i).Item(0)
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(temp1)
            MaterialNameAndUse += temp1.Rows.Item(0).Item(0).ToString + "：" + temp.Rows.Item(i).Item(1).ToString + "g；"
        Next
        LoadMaterialConstitute = MaterialNameAndUse
    End Function
    Private Sub DataLink_click(sender As Object, e As EventArgs) Handles Data.CellClick
        If Data.CurrentCellAddress.X = 7 Then
            Dim pic As New productPicdetail
            Dim f As Integer = PageNum * ColunmNum + Data.CurrentCellAddress.Y '标记存储所在cell的row数值
            index.LoadImageP(pic.picP, "\ProductImage\", TableData.Rows.Item(Data.CurrentCellAddress.Y + PageNum * ColunmNum).Item(7).ToString)
            pic.Top = 200
            pic.Left = 400
            pic.Show()
        End If
        If Data.CurrentCellAddress.X = 9 Then
            Dim Num As Integer = Data.CurrentCellAddress.Y
            Dim tempFrom As New productDetail
            tempFrom.proName.Text = "产品名称：" + Data.Rows(Num).Cells(1).Value
            tempFrom.ProNum.Text = Data.Rows(Num).Cells(0).Value
            tempFrom.proMaterialDetail.Text = "产品原料：" & Chr(13) & Data.Rows(Num).Cells(8).Value & Chr(13) & Chr(13) & "此产品原料组成由最新生成产品时原料为准"
            tempFrom.ProNameP.Text = Data.Rows(Num).Cells(6).Value
            tempFrom.priceIO.Text = Data.Rows(Num).Cells(2).Value
            tempFrom.prosP.Text = Data.Rows(Num).Cells(3).Value
            tempFrom.prosurpluesP.Text = Data.Rows(Num).Cells(4).Value
            tempFrom.soldCountP.Text = Data.Rows(Num).Cells(5).Value
            index.LoadImageP(tempFrom.PictureDetail, "\ProductImage\", TableData.Rows.Item(Data.CurrentCellAddress.Y + PageNum * ColunmNum).Item(7).ToString)
            tempFrom.ShowDialog()
            Dim Price As String = tempFrom.returnPrice
            tempFrom.Close()
            If Price <> "" Then
                SavePrice(Data.Rows(Num).Cells(0).Value, Price)
                Data.Rows(Num).Cells(2).Value = Val(Price)
            End If
        End If
        If Data.CurrentCellAddress.X = 10 Then
            Dim TempF As New SureAndCancel
            TempF.caption.Text = "警告"
            TempF.msg.Text = "你点击了删除<" & Data.Rows(Data.CurrentCellAddress.Y).Cells(1).Value & ">,确定要执行吗？"
            TempF.ShowDialog()
            Dim FLag As Boolean = TempF.SureOrCancel
            If FLag = True Then
                DeletePro(Data.Rows(Data.CurrentCellAddress.Y).Cells(0).Value)
                Data.Rows.RemoveAt(Data.CurrentCellAddress.Y)

                If index.CheckApplicationIsRun("dbsynchap.exe") = False Then
                    Process.Start(Application.StartupPath & "\dbsynchap.exe")
                End If
            End If
        End If
    End Sub
    '将产品从数据库中删除
    Private Sub DeletePro(ByVal Id As Integer)
        Dim sqlcmd As New SQLite.SQLiteCommand
        Dim sqlcmd1 As New SQLite.SQLiteCommand
        sqlcmd.Connection = index.Conn
        sqlcmd1.Connection = index.conn1
        sqlcmd.CommandType = CommandType.Text
        sqlcmd1.CommandType = CommandType.Text
        sqlcmd.CommandText = "delete from cx_product where product_id = " & Id
        sqlcmd1.CommandText = "insert into cx_product (product_id,operate) values ('" & Id & "'," & 0 & ")"
        sqlcmd1.ExecuteNonQuery()
        Try
            sqlcmd.ExecuteNonQuery()
            sqlcmd.CommandText = "delete from cx_material_use where product_id = " & Id
            sqlcmd.ExecuteNonQuery()
            sqlcmd.CommandText = "insert into cx_product_id_record values (" & Id & ")"
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dataTextC() Handles Data.CellValueChanged
        If Data.CurrentCellAddress.X = 9 Then
            'If Data.Rows(Data.CurrentCellAddress.Y).Cells(9).Value = "查看详情" Then
            MsgBox("...")
            'End If
        End If
    End Sub
    '将修改的价格保存至DB
    Private Sub SavePrice(ByVal ID As Integer, ByVal Price As Double)
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = "update cx_product set price = " & Price & " where product_id = " & ID
        Try
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            index.MsgOrNotifyForm("提示", ex.Message)
        End Try
    End Sub
    '继续加载数据函数
    Private Sub LoadDataWhenClick(ByVal PageTo As Integer)
        Data.Rows.Clear()
        Dim Num As Integer '循环次数
        Dim flag, MaterialNameAndUse As String
        If PageTo = 0 Then
            PageNum -= 1
        Else
            PageNum += 1
        End If
        If ColunmNum >= TableData.Rows.Count() - PageNum * ColunmNum Then
            Num = TableData.Rows.Count() - PageNum * ColunmNum - 1
        Else
            Num = ColunmNum - 1
        End If
        For i = 0 To Num
            Dim j As Integer = i + ColunmNum * PageNum
            Dim sqlcmd1 As New SQLite.SQLiteCommand
            sqlcmd1.Connection = index.Conn
            sqlcmd1.CommandType = CommandType.Text
            sqlcmd1.CommandText = "select product_sort_name from cx_product_sort where product_sort_id = " & TableData.Rows.Item(j).Item(6)
            Dim sqlda1 As New SQLite.SQLiteDataAdapter(sqlcmd1.CommandText, index.Conn)
            TempDataTable.Reset()
            sqlda1.Fill(TempDataTable)
            MaterialNameAndUse = LoadMaterialConstitute(TableData.Rows.Item(j).Item(0))
            flag = TempDataTable.Rows.Item(0).Item(0)
            Data.Rows.Add(TableData.Rows.Item(j).Item(0), TableData.Rows.Item(j).Item(1),
                          TableData.Rows.Item(j).Item(2), TableData.Rows.Item(j).Item(3) * 1000,
                          TableData.Rows.Item(j).Item(4), TableData.Rows.Item(j).Item(5),
                          flag, "查看图片", MaterialNameAndUse, "查看详情", "删除")
            If SearchB = True Then
                SetDataStyle(j, i)
            End If
        Next

        If Num = ColunmNum - 1 Then
            PageDown = True
            If pageDown1.BackColor <> head.BackColor Then
                pageDown1.BackColor = head.BackColor
            End If
        Else
            PageDown = False
            pageDown1.BackColor = Color.FromArgb(&HFF797979)
        End If
        If PageNum <> 0 Then
            PageUp = True
            If PageUP1.BackColor <> head.BackColor Then
                PageUP1.BackColor = head.BackColor
            End If
        Else
            PageUp = False
            PageUP1.BackColor = Color.FromArgb(&HFF797979)
        End If
    End Sub
    '向上翻页按钮鼠标点击事件
    Private Sub PageUp1_MouseDown(sender As Object, e As EventArgs) Handles PageUP1.MouseDown
        If PageUp = True Then
            PageUP1.BackColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    Private Sub PageUp1_MouseUp(sender As Object, e As EventArgs) Handles PageUP1.MouseUp
        If PageUp = True Then
            PageUP1.BackColor = head.BackColor
        End If
    End Sub
    Private Sub pageUp1_mouseClick() Handles PageUP1.Click
        If PageUp = True Then
            LoadDataWhenClick(0)
        End If
    End Sub
    '向下翻页鼠标点击事件
    Private Sub PageDown1_MouseDown() Handles pageDown1.MouseDown
        If PageDown = True Then
            pageDown1.BackColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    Private Sub PageDown1_MouseUp() Handles pageDown1.MouseUp
        If PageDown = True Then
            pageDown1.BackColor = head.BackColor
        End If
    End Sub
    Private Sub pageDown1_click() Handles pageDown1.Click
        If PageDown = True Then
            LoadDataWhenClick(1)
        End If
    End Sub
    '全部商品按钮点击事件
    Private Sub allproduct_click() Handles allProduct.Click
        If allProduct.BackColor <> Color.FromArgb(&HFF006699) Then
            allProduct.BackColor = Color.FromArgb(&HFF006699)
            LoadDataFromDB(0)
        End If
    End Sub
    '添加商品按钮点击事件
    Private Sub addproduct_MouseDown() Handles AddProduct.MouseDown
        AddProduct.BackColor = Color.FromArgb(&HFF006699)
        If allProduct.BackColor = Color.FromArgb(&HFF006699) Then
            AllproductButton = True
            allProduct.BackColor = head.BackColor
        End If
    End Sub
    Private Sub addproduct_MouseUp() Handles AddProduct.MouseUp
        AddProduct.BackColor = head.BackColor
        If AllproductButton = True Then
            allProduct.BackColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    'shut按钮鼠标点击事件
    Private Sub Addclose_mouseDown() Handles AddClose.MouseDown
        index.LoadImage(AddClose, "\SystemImg\", "closeNotHover")
    End Sub
    Private Sub Addclose_mouseUp() Handles AddClose.MouseUp
        index.LoadImage(AddClose, "\SystemImg\", "close")
    End Sub
    Private Sub addclose_Click() Handles AddClose.Click
        hideAddMap()
        If UploadPicture = True Then
            IO.File.Delete(Application.StartupPath & "\ProductImage\" & PName)
        End If
        If id_record = True Then
            id_record = False
        End If
        showButton()
    End Sub
    '加载ProductTypeList选项
    Private Sub LoadDataTypeList()
        Try
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = "select product_sort_id ,product_sort_name from cx_product_sort"
            Dim sqlda As SQLite.SQLiteDataAdapter
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TypeList)
            For i = 0 To TypeList.Rows.Count() - 1
                ProductTypelist.Items.Add(TypeList.Rows.Item(i).Item(1))
            Next
            ProductTypelist.Text = ProductTypelist.Items(0)
        Catch ex As Exception
            index.MsgOrNotifyForm("错误", ex.Message)
        End Try
    End Sub
    '加载新生成产品的ID
    Private Function LoadProductID()
        Dim returnId As Integer
        Try
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = "select min(id) from cx_product_id_record"
            Dim sqlda As SQLite.SQLiteDataAdapter
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            Dim tempDataTable As New DataTable
            sqlda.Fill(tempDataTable)
            If tempDataTable.Rows.Item(0).Item(0).ToString = "" Then
                tempDataTable.Reset()
                sqlcmd.CommandText = "select max(product_id) from cx_product"
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                sqlda.Fill(tempDataTable)
                If tempDataTable.Rows.Item(0).Item(0).ToString = "" Then
                    returnId = 1
                Else
                    returnId = tempDataTable.Rows.Item(0).Item(0) + 1
                End If
            Else
                returnId = tempDataTable.Rows.Item(0).Item(0)
                id_record = True
            End If
        Catch ex As Exception
            index.MsgOrNotifyForm("错误", ex.Message)
        End Try
        LoadProductID = returnId
    End Function
    '添加产品按钮鼠标点击事件
    Private Sub product_Click() Handles product.Click
        recordMaterialUseToDB()
    End Sub
    Private Sub Product_MouseDown() Handles product.MouseDown
        product.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub product_MouseUp() Handles product.MouseUp
        product.BackColor = head.BackColor
    End Sub
    '加载产品原料
    Private Sub LoadMaterial()
        Try
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = "select material_id ,material_name from cx_material"
            Dim sqlda As SQLite.SQLiteDataAdapter
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(MaterialAndId)
            For i = 0 To MaterialAndId.Rows.Count() - 1
                Addmaterial.Items.Add(MaterialAndId.Rows.Item(i).Item(1))
            Next
            Addmaterial.Text = MaterialAndId.Rows.Item(0).Item(1)
        Catch ex As Exception
            index.MsgOrNotifyForm("错误", ex.Message)
        End Try
    End Sub
    Private Sub productName_keyUp() Handles ProductNameInput.KeyUp
        If ProductNameInput.Text.Length = 0 Then
            ProductIDP.Text = ""
        Else
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = "select product_id from cx_product where name = '" & ProductNameInput.Text & "'"
            Dim temp As New DataTable
            Dim sqlda As SQLite.SQLiteDataAdapter
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(temp)
            If temp.Rows.Count <> 0 And FlagError = True Then
                FlagError = False
                index.MsgOrNotifyForm("提示", "<" & ProductNameInput.Text & ">已经被其他产品占用,请使用其他名称作为此产品的名称！")
            Else
                FlagError = True
                ProductIDP.Text = LoadProductID()
            End If
        End If
    End Sub
    '添加原料按钮鼠标点击事件
    Private Sub Add_MouseDown() Handles Add.MouseDown
        index.LoadImage(Add, "\SystemImg\", "add1")
    End Sub
    Private Sub Add_MouseUp() Handles Add.MouseUp
        index.LoadImage(Add, "\SystemImg\", "add")
    End Sub
    Private Sub add_click() Handles Add.Click
        If Addmaterial.Text <> "" Then
            For i = 0 To Addmaterial.Items.Count() - 1
                If Addmaterial.Text = Addmaterial.Items(i) Then
                    If AddedM.Items.Count = 0 Then
                        MaterialAdd.Rows.Add(MaterialAndId.Rows.Item(i).Item(0), MaterialAndId.Rows.Item(i).Item(1), 0)
                        AddedM.Items.Add(Addmaterial.Text)
                        AddedM.Text = Addmaterial.Text
                        heft_I.Text = 0
                        Exit Sub
                    Else
                        For j = 0 To AddedM.Items.Count() - 1
                            If Addmaterial.Text = AddedM.Items(j) Then
                                index.MsgOrNotifyForm("提示", "已经添加过此类原料，无需重复添加！")
                                Exit Sub
                            End If
                        Next
                        MaterialAdd.Rows.Add(MaterialAndId.Rows.Item(i).Item(0), MaterialAndId.Rows.Item(i).Item(1), 0)
                        AddedM.Items.Add(Addmaterial.Text)
                        AddedM.Text = Addmaterial.Text
                        heft_I.Text = 0
                        Exit Sub
                    End If
                End If
            Next
            index.MsgOrNotifyForm("提示", "输入的产品原料类型名有误或者无此类原料，请检查后输入！")
        End If
    End Sub
    '打开文件图片并加载
    Private Sub scanPic_Click() Handles scanPic.Click
        OpenFilepic.FileName = ""
        OpenFilepic.Filter = "Jpg Files|*jpg|Png Files|*png"
        OpenFilepic.ShowDialog()
        If OpenFilepic.FileName <> "" Then
            ImagePathName = OpenFilepic.FileName
            LoadPicName()
            If judgechinese(ProName) = True Then
                index.LoadImageFilePic(productPic, OpenFilepic.FileName)
            Else
                index.MsgOrNotifyForm("错误", "必须将图片名称改作不包含中文的名臣方可上传并正常使用！")
            End If
        End If
    End Sub
    Private Sub scanPic_MouseDown() Handles scanPic.MouseDown
        scanPic.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub scanPic_MouseUp() Handles scanPic.MouseUp
        scanPic.BackColor = head.BackColor
    End Sub
    '记录输入的质量
    Private Sub recordKg()
        If AddedM.Text <> "" Then
            For i = 0 To MaterialAdd.Rows.Count() - 1
                If AddedM.Text = MaterialAdd.Rows(i).Cells(1).Value Then
                    If MaterialAdd.Rows(i).Cells(1).Value = "0" Or MaterialAdd.Rows(i).Cells(1).Value <> heft_I.Text Then
                        MaterialAdd.Rows(i).Cells(2).Value = Val(heft_I.Text)
                        Exit Sub
                    End If
                End If
            Next
        Else
            index.MsgOrNotifyForm("提示", "请选择原料类型后对应输入原料消耗量！")
        End If
    End Sub
    Private Sub heft_I_KeyUp(sender As Object, e As EventArgs) Handles heft_I.KeyUp
        recordKg()
        If productS_IO.Text <> "" Then
            If productNum_i.Text <> "" Then
                Dim sqlcmd As New SQLite.SQLiteCommand
                sqlcmd.Connection = index.Conn
                sqlcmd.CommandType = CommandType.Text
                sqlcmd.CommandText = "select material_surplus from cx_material where material_name = '" & AddedM.Text.ToString & "'"
                Dim temp As New DataTable
                Dim sqlda As SQLite.SQLiteDataAdapter
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                sqlda.Fill(temp)
                If Val(heft_I.Text) * Val(productNum_i.Text) / 1000 > temp.Rows.Item(0).Item(0) Then
                    index.MsgOrNotifyForm("提示", "根据输入的数据，此产品原料无法满足生成此产品的要求！")
                End If
            End If
        End If
    End Sub
    Private Sub heft_I_Click() Handles heft_I.Click
        If heft_I.Text = "0" Then
            heft_I.Text = ""
        End If
    End Sub

    '显示对应原料的消耗量
    Private Sub added_click() Handles AddedM.TextChanged
        For i = 0 To MaterialAdd.Rows.Count() - 1
            If AddedM.Text = MaterialAdd.Rows(i).Cells(1).Value Then
                heft_I.Text = MaterialAdd.Rows(i).Cells(2).Value
            End If
        Next
    End Sub

    '减掉需要删除的原料用量
    Private Sub CutM()
        If AddedM.Items.Count <> 0 Then
            For i = 0 To MaterialAdd.Rows.Count() - 1
                If AddedM.Text = MaterialAdd.Rows(i).Cells(1).Value Then
                    MaterialAdd.Rows.Remove(MaterialAdd.Rows(i))
                    For j = 0 To AddedM.Items.Count - 1
                        If AddedM.Text = AddedM.Items(i) Then
                            AddedM.Items.Remove(AddedM.Items(j))
                            If AddedM.Items.Count = 0 Then
                                AddedM.Text = ""
                            Else
                                AddedM.Text = AddedM.Items(j)
                            End If
                            Exit Sub
                        End If
                    Next
                End If
            Next
        Else
            index.MsgOrNotifyForm("提示", "没有能够删除的原料添加记录！")
        End If
    End Sub

    '输出添加原料记录按钮鼠标点击事件
    Private Sub CutMaterial_Click() Handles cutMaterial.Click
        CutM()
    End Sub
    Private Sub CutMaterial_mouseDown() Handles cutMaterial.MouseDown
        index.LoadImage(cutMaterial, "\SystemImg\", "Cut1")
    End Sub
    Private Sub CutMaterial_mouseUp() Handles cutMaterial.MouseUp
        index.LoadImage(cutMaterial, "\SystemImg\", "Cut")
    End Sub

    '上传按钮鼠标点击事件
    Private Sub Upload_mouseDown() Handles upload.MouseDown
        upload.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub Upload_mouseUp() Handles upload.MouseUp
        upload.BackColor = head.BackColor
    End Sub
    Private Sub Upload_Click() Handles upload.Click
        If ProductNameInput.Text <> "" Then
            CopyImage()
        Else
            index.MsgOrNotifyForm("提示", "请将添加产品的参数填写完毕后在进行上传图片！")
        End If
    End Sub
    '用来复制图片
    Private Sub CopyImage()
        If IO.File.Exists(ImagePathName) Then
            If IO.File.Exists(Application.StartupPath & "\ProductImage\" & PName) = True Then
                UploadPicToServer()
                If IO.File.Exists(Application.StartupPath & "\temp\" & PName) = False Then
                    IO.File.Copy(Application.StartupPath & "\temp\" & PName, Application.StartupPath & "\ProductImage\" & PName)
                End If
            Else
                index.MsgOrNotifyForm("提示", PName & "文件不存在！")
            End If
        Else
            index.MsgOrNotifyForm("错误", "文件不存在！")
        End If
    End Sub
    '上传图片至服务器
    Private Sub UploadPicToServer()
        If My.Computer.Network.IsAvailable = True Then
            Try
                Dim imgPhoto As System.Drawing.Image = System.Drawing.Image.FromFile(ImagePathName)
                Dim max As Double
                If imgPhoto.Width > imgPhoto.Height Then
                    max = imgPhoto.Width
                Else
                    max = imgPhoto.Height
                End If
                If max > 300 Then
                    Dim zoom As Double = max / 300
                    Dim newWidth As Double = imgPhoto.Width / zoom
                    Dim newHeight As Double = imgPhoto.Height / zoom
                    Dim caixiaoer As New System.Drawing.Bitmap(imgPhoto, newWidth, newHeight)
                    If pictype() = ".jpg" Or pictype() = ".JPG" Then
                        caixiaoer.Save(Application.StartupPath & "\temp\" & PName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Else
                        caixiaoer.Save(Application.StartupPath & "\temp\" & PName, System.Drawing.Imaging.ImageFormat.Png)
                    End If
                    My.Computer.Network.UploadFile(Application.StartupPath & "\temp\" & PName, index.remotepath & "caixiaoer1/Public/Images/" & PName, "caixiao2", "caixiao2ftp")
                Else
                    My.Computer.Network.UploadFile(Application.StartupPath & "\ProductImage\" & PName, index.remotepath & "caixiaoer1/Public/Images/" & PName, "caixiao2", "caixiao2ftp")
                    My.Computer.Network.UploadFile(Application.StartupPath & "\ProductImage\" & PName, index.remotepath & "Public/IMAGES/" & PName, "caixiao2", "caixiao2ftp")
                End If

                If max > 600 Then
                    Dim zoom As Double = max / 600
                    Dim newWidth As Double = imgPhoto.Width / zoom
                    Dim newHeight As Double = imgPhoto.Height / zoom
                    Dim caixiaoer As New System.Drawing.Bitmap(imgPhoto, newWidth, newHeight)
                    If pictype() = ".jpg" Or pictype() = ".JPG" Then
                        caixiaoer.Save(Application.StartupPath & "\temp\" & PName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Else
                        caixiaoer.Save(Application.StartupPath & "\temp\" & PName, System.Drawing.Imaging.ImageFormat.Png)
                    End If
                    My.Computer.Network.UploadFile(Application.StartupPath & "\temp\" & PName, index.remotepath & "Public/IMAGES/" & PName, "caixiao2", "caixiao2ftp")
                ElseIf max > 300 Then
                    My.Computer.Network.UploadFile(Application.StartupPath & "\ProductImage\" & PName, index.remotepath & "Public/IMAGES/" & PName, "caixiao2", "caixiao2ftp")
                End If
                index.MsgOrNotifyForm("提示", "图片 <" & PName & "> 已上传成功！")
                UploadPicture = True
            Catch ex As Exception
                MsgBox(ex.Message)
                index.MsgOrNotifyForm("错误", "请检查你的网络是否通畅！网络通畅后请重试！")
                UploadPicture = False
            End Try
        Else
            index.MsgOrNotifyForm("提示", "当前网络不通畅，网络通畅后请重试！")
            UploadPicture = False
        End If
    End Sub
    '获得图片的名称
    Private Sub LoadPicName()
        For i = ImagePathName.Length - 1 To 0 Step -1
            If ImagePathName(i) <> "\" Then
                PName += ImagePathName(i)
            Else
                Exit For
            End If
        Next
        PName = exchangeString(PName)
        For i = 0 To PName.Length - 1
            If PName(i) <> "." Then
                ProName += PName(i)
            Else
                Exit For
            End If
        Next
    End Sub
    '获取图片的类型
    Private Function pictype()
        Dim num As Integer
        For i = 0 To PName.Length - 1
            If PName(i) = "." Then
                num = i
                Exit For
            End If
        Next
        Dim type As String = ""
        For i = num To PName.Length - 1
            type += PName(i)
        Next
        pictype = type
    End Function
    '颠倒字符串函数
    Private Function exchangeString(ByVal name As String)
        Dim PicName As String = ""
        If name <> "" Then
            For i = name.Length - 1 To 0 Step -1
                PicName += name(i)
            Next
        End If
        exchangeString = PicName
    End Function
    '将用料记录进入DB
    Private Sub recordMaterialUseToDB()
        If Judgelegal() = True Then
            JudgeUploadPicAndCode()
            Try
                Dim sqlcmd As New SQLite.SQLiteCommand
                sqlcmd.Connection = index.Conn
                sqlcmd.CommandType = CommandType.Text
                Dim sqlda As SQLite.SQLiteDataAdapter
                sqlcmd.CommandText = "select product_sort_id from cx_product_sort where product_sort_name = '" & ProductTypelist.Text.ToString & "'"
                Dim temp As New DataTable
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                sqlda.Fill(temp)
                Dim product_sort_id As Integer = temp.Rows.Item(0).Item(0)
                sqlcmd.CommandText = "insert into cx_product (product_id,name,picture,surplus_count,price,product_sort_id,specification) values ('" & ProductIDP.Text.ToString & "','" & ProductNameInput.Text.ToString & "','" & PName & "'," & Val(productNum_i.Text) & "," & Val(price_Input.Text) & "," & product_sort_id & "," & Val(productS_IO.Text) / 1000 & ")"
                temp.Reset()
                sqlcmd.ExecuteNonQuery()
                SaveAddedMaterial()
                Dim sqlcmd1 As New SQLite.SQLiteCommand
                sqlcmd1.Connection = index.conn1
                sqlcmd1.CommandType = CommandType.Text
                sqlcmd1.CommandText = "insert into cx_product (product_id ,operate) values ('" & ProductIDP.Text.ToString & "'," & 1 & ")"
                sqlcmd1.ExecuteNonQuery()
                Data.Rows.Add(ProductIDP.Text.ToString, ProductNameInput.Text.ToString, Val(price_Input.Text), Val(productS_IO.Text), Val(productNum_i.Text), 0, productS_IO.Text.ToString, "点击查看", LoadMaterialConstitute(Val(ProductIDP.Text)), "查看详情", "删除")
                If index.CheckApplicationIsRun("dbsynchap.exe") = False Then
                    Process.Start(Application.StartupPath & "\dbsynchap.exe")
                End If
                TableData.Rows.Add(ProductIDP.Text.ToString, ProductNameInput.Text.ToString, Val(price_Input.Text), Val(productS_IO.Text), Val(productNum_i.Text), Val(productNum_i.Text), product_sort_id, PName)
                index.MsgOrNotifyForm("提示", "添加产品<" & ProductNameInput.Text & ">成功！")
                If id_record = True Then
                    sqlcmd1.CommandText = "delete from cx_product_id_record where id = " & ProductIDP.Text.ToString
                    sqlcmd1.ExecuteNonQuery()
                    id_record = False
                End If
                Clear()
            Catch ex As Exception
                index.MsgOrNotifyForm("错误", ex.Message & "  添加产品失败！")
            End Try
        End If
    End Sub
    '判断输入内容的合法性
    Private Function Judgelegal()
        If ProductNameInput.Text = "" Then
            index.MsgOrNotifyForm("提示", "还未输入产品名称，无法满足添加要求")
            Judgelegal = False
            Exit Function
        End If
        If productS_IO.Text = "" Then
            index.MsgOrNotifyForm("提示", "还未输入产品规格，无法满足添加要求")
            Judgelegal = False
            Exit Function
        End If
        If price_Input.Text = "" Then
            index.MsgOrNotifyForm("提示", "还未输入产品单价，无法满足添加要求")
            Judgelegal = False
            Exit Function
        End If
        If productNum_i.Text = "" Then
            index.MsgOrNotifyForm("提示", "还未输入生成产品数量，无法满足添加要求")
            Judgelegal = False
            Exit Function
        End If
        If MaterialAdd.Rows.Count = 0 Then
            index.MsgOrNotifyForm("提示", "未为产品添加任何原料，无法满足添加要求")
            Judgelegal = False
            Exit Function
        End If
        If JudgeMaterialAndS() = False Then
            index.MsgOrNotifyForm("提示", "产品规格和添加的原料总数不符合要求，请仔细检查")
            Judgelegal = False
            Exit Function
        End If
        Judgelegal = True
    End Function
    '判断规格与输入的原料是否满足
    Private Function JudgeMaterialAndS()
        Dim KgMaterial As Boolean
        Dim S As Integer = 0
        For i = 0 To MaterialAdd.Rows.Count - 1
            S += MaterialAdd.Rows(i).Cells(2).Value
        Next
        If S <> Val(productS_IO.Text) Then
            JudgeMaterialAndS = False
            Exit Function
        End If
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        Dim sqlda As SQLite.SQLiteDataAdapter
        Dim temp As New DataTable
        For i = 0 To MaterialAdd.Rows.Count - 1
            temp.Reset()
            sqlcmd.CommandText = "select material_surplus from cx_material where material_id = " & MaterialAdd.Rows(i).Cells(0).Value
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(temp)
            If Val(productNum_i.Text) * MaterialAdd.Rows(i).Cells(2).Value / 1000 > temp.Rows.Item(0).Item(0) Then
                index.MsgOrNotifyForm("提示", "原料：<" & MaterialAdd.Rows(i).Cells(1).Value.ToString & ">剩余重量不能完成此产品的生成！")
                KgMaterial = True
            End If
        Next
        If KgMaterial = True Then
            JudgeMaterialAndS = False
            Exit Function
        End If
        JudgeMaterialAndS = True
    End Function
    '将消耗的原料添加进数据库
    Private Sub SaveAddedMaterial()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandType = CommandType.Text
        For i = 0 To MaterialAdd.Rows.Count - 1
            sqlcmd.CommandText = "insert into cx_material_use (product_id,material_id,material_use) values(" & Val(ProductIDP.Text) & "," & MaterialAdd.Rows(i).Cells(0).Value & "," & MaterialAdd.Rows(i).Cells(2).Value & ")"
            sqlcmd.ExecuteNonQuery()
        Next
    End Sub
    '判断是否已经上传了图片和生成了二维码
    Private Sub JudgeUploadPicAndCode()
        If ImagePathName = "" Then
Destination: Dim tempF As New SureAndCancel
            tempF.caption.Text = "提示"
            tempF.msg.Text = "你现在还未上传产品图片，确定选择上传，取消则不上传图片并存储！"
            tempF.ShowDialog()
            If tempF.SureOrCancel = True Then
                tempF.Hide()
                OpenFilepic.FileName = ""
                OpenFilepic.Filter = "Jpg Files|*jpg|Png Files|*png"
                OpenFilepic.ShowDialog()
                If OpenFilepic.FileName <> "" Then
                    index.LoadImageFilePic(productPic, OpenFilepic.FileName)
                    ImagePathName = OpenFilepic.FileName
                    LoadPicName()
                Else
                    GoTo destination1
                End If
            Else
destination1:   Dim temp As New SureAndCancel
                temp.caption.Text = "提示"
                temp.msg.Text = "确定取消上传图片？"
                temp.ShowDialog()
                If temp.SureOrCancel = False Then
                    tempF.Close()
                    temp.Close()
                    GoTo Destination
                End If
                temp.Close()
            End If
            tempF.Close()
        Else
            If UploadPicture = False Then
                If IO.File.Exists(ImagePathName) Then
                    If Not IO.File.Exists(Application.StartupPath & "\ProductImage\" & PName) Then
                        IO.File.Copy(Application.StartupPath & "\temp\" & PName, Application.StartupPath & "\ProductImage\" & PName)
                    End If
                    CopyImage()
                    UploadPicture = True
                End If
            End If
        End If
    End Sub
    '添加产品后将选择的内容全部清除
    Private Sub Clear()
        ProductNameInput.Clear()
        ProductIDP.Text = ""
        productS_IO.Clear()
        price_Input.Clear()
        productNum_i.Clear()
        AddedM.Items.Clear()
        AddedM.Text = ""
        heft_I.Clear()
        index.LoadImage(productPic, "\SystemImg\", "unUpload")
        index.LoadImage(productCodeP, "\SystemImg\", "whiteback")
        UploadPicture = False
        ImagePathName = ""
        MaterialAdd.Rows.Clear()
        ProName = ""
    End Sub
    '检查产品规格、产品单价、产品数量、原料用量输入的合法性
    Private Sub productS(sender As Object, e As KeyPressEventArgs) Handles productS_IO.KeyPress
        If e.KeyChar <= "9" And e.KeyChar >= "0" Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or e.KeyChar = Chr(13) Then
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub price_iO(sender As Object, e As KeyPressEventArgs) Handles price_Input.KeyPress
        If e.KeyChar <= "9" And e.KeyChar >= "0" Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or e.KeyChar = Chr(13) Or e.KeyChar = "." Then
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub productNumI(sender As Object, e As KeyPressEventArgs) Handles productNum_i.KeyPress
        If e.KeyChar <= "9" And e.KeyChar >= "0" Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or e.KeyChar = Chr(13) Then
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub heft_I_keypress(sender As Object, e As KeyPressEventArgs) Handles heft_I.KeyPress
        If e.KeyChar <= "9" And e.KeyChar >= "0" Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or e.KeyChar = Chr(13) Then
        Else
            e.Handled = True
        End If
    End Sub
    '搜索按钮点击事件
    Private Sub search_MouseDown() Handles search.MouseDown
        search.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub search_MouseUp() Handles search.MouseUp
        search.BackColor = head.BackColor
    End Sub
    Private Sub search_click() Handles search.Click
        SearchFunction(searchInput.Text)
        searchLoadData()
    End Sub
    '搜索函数
    Private Sub SearchFunction(ByVal Name As String)
        If allProduct.BackColor = Color.FromArgb(&HFF006699) Then
            allProduct.BackColor = head.BackColor
        End If
        PageDown = False
        PageUp = False
        SearchB = True
        PageUP1.BackColor = Color.FromArgb(&HFF797979)
        pageDown1.BackColor = Color.FromArgb(&HFF797979)
        Data.Rows.Clear()
        TableData.Reset()
        PageNum = 0
        WritecheckKeywords()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandType = CommandType.Text
        Dim sqlda As SQLite.SQLiteDataAdapter
        If IsNumeric(Name) = True Then
            For h = 0 To 6
                sqlcmd.CommandText = exchangeFormat(Name, h)
                If sqlcmd.CommandText = "" Then
                    Exit Sub
                End If
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                sqlda.Fill(TableData)
                ColorFlag(h) = TableData.Rows.Count - 1
            Next
        Else
            For h = 5 To 6
                sqlcmd.CommandText = exchangeFormat(Name, h)
                If sqlcmd.CommandText = "" Then
                    Exit Sub
                End If
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                sqlda.Fill(TableData)
                ColorFlag(h) = TableData.Rows.Count - 1
            Next
            ColorFlag(0) = -1
            ColorFlag(1) = -1
            ColorFlag(2) = -1
            ColorFlag(3) = -1
            ColorFlag(4) = -1
        End If
    End Sub
    '初始化checkKeywords
    Private Sub WritecheckKeywords()
        If WriteKey = False Then
            WriteKey = True
            CheckKeywords(0) = "product_id"
            CheckKeywords(1) = "price"
            CheckKeywords(2) = "specification"
            CheckKeywords(3) = "surplus_count"
            CheckKeywords(4) = "sold_count"
            CheckKeywords(5) = "name"
            CheckKeywords(6) = "product_sort_id"
        End If
    End Sub
    '格式对应转换
    Private Function exchangeFormat(ByVal name As String, ByVal Num As Integer)
        If Num <= 4 Then
            If Num = 2 Then
                exchangeFormat = "select product_id,name,price,specification,surplus_count,sold_count,product_sort_id,picture from cx_product where " & CheckKeywords(Num) & " = " & Val(name) / 1000
            Else
                exchangeFormat = "select product_id,name,price,specification,surplus_count,sold_count,product_sort_id,picture from cx_product where " & CheckKeywords(Num) & " = " & Val(name)
            End If
        ElseIf Num < 6 Then
            exchangeFormat = "select product_id,name,price,specification,surplus_count,sold_count,product_sort_id,picture from cx_product where " & CheckKeywords(Num) & " = '" & name & "'"
        ElseIf Num = 6 Then
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = "select product_sort_id from cx_product_sort where product_sort_name =  '" & name & "'"
            Dim da As New DataTable
            Dim sqlda As SQLite.SQLiteDataAdapter
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(da)
            If da.Rows.Count = 0 Then
                exchangeFormat = ""
            Else
                exchangeFormat = "select product_id,name,price,specification,surplus_count,sold_count,product_sort_id,picture from cx_product where " & CheckKeywords(Num) & " = " & da.Rows.Item(0).Item(0)
            End If
        End If
    End Function
    '加载搜索的第一页数据
    Private Sub searchLoadData()
        If TableData.Rows.Count <> 0 Then
            Dim Flag, MaterialNameAndUse As String
            Dim Num As Integer
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            Dim sqlda As SQLite.SQLiteDataAdapter
            If ColunmNum >= TableData.Rows.Count() - PageNum * ColunmNum Then
                Num = TableData.Rows.Count() - PageNum * ColunmNum - 1
            Else
                Num = ColunmNum - 1
            End If
            For i = 0 To Num
                sqlcmd.CommandText = "select product_sort_name from cx_product_sort where product_sort_id = '" & TableData.Rows.Item(i).Item(6) & "'"
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                TempDataTable.Reset()
                sqlda.Fill(TempDataTable)
                MaterialNameAndUse = LoadMaterialConstitute(TableData.Rows.Item(i).Item(0))
                Flag = TempDataTable.Rows.Item(0).Item(0)
                Data.Rows.Add(TableData.Rows.Item(i).Item(0), TableData.Rows.Item(i).Item(1), TableData.Rows.Item(i).Item(2),
                              TableData.Rows.Item(i).Item(3) * 1000, TableData.Rows.Item(i).Item(4),
                              TableData.Rows.Item(i).Item(5), Flag, "查看图片", MaterialNameAndUse, "查看详情", "删除")
                SetDataStyle(PageNum * ColunmNum + i, i)
            Next
            If Data.Rows.Count = ColunmNum Then
                If PageDown = False Then
                    PageDown = True
                    pageDown1.BackColor = head.BackColor
                End If
            End If
        Else
            index.MsgOrNotifyForm("提示", "未找到<" & searchInput.Text & ">相关信息...")
        End If
    End Sub
    '设置搜索出来的栏的颜色风格
    Private Sub SetDataStyle(ByVal Num As Integer, ByVal Id As Integer)
        If Num <= ColorFlag(0) Then
            Data.Rows(Id).Cells(0).Style.BackColor = head.BackColor
            Data.Rows(Id).Cells(0).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= ColorFlag(1) Then
            Data.Rows(Id).Cells(2).Style.BackColor = head.BackColor
            Data.Rows(Id).Cells(2).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= ColorFlag(2) Then
            Data.Rows(Id).Cells(3).Style.BackColor = head.BackColor
            Data.Rows(Id).Cells(3).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= ColorFlag(3) Then
            Data.Rows(Id).Cells(4).Style.BackColor = head.BackColor
            Data.Rows(Id).Cells(4).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= ColorFlag(4) Then
            Data.Rows(Id).Cells(5).Style.BackColor = head.BackColor
            Data.Rows(Id).Cells(5).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= ColorFlag(5) Then
            Data.Rows(Id).Cells(1).Style.BackColor = head.BackColor
            Data.Rows(Id).Cells(1).Style.ForeColor = Color.FromArgb(&HFF006699)
        Else
            Data.Rows(Id).Cells(6).Style.BackColor = head.BackColor
            Data.Rows(Id).Cells(6).Style.ForeColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    'searchInput按下回车键相应事件
    Private Sub searchInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchInput.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchFunction(searchInput.Text)
            searchLoadData()
        End If
    End Sub
    '搜索图片点击事件
    Private Sub searchPic_click() Handles searchButton.Click
        SearchFunction(searchInput.Text)
        searchLoadData()
    End Sub
    '将表格的显示风格设置为原来的风格
    Private Sub SetFormerDataStyle(ByVal Num As Integer, ByVal Id As Integer)
        If Num <= ColorFlag(0) Then
            Data.Rows(Id).Cells(0).Style.BackColor = Color.White
            Data.Rows(Id).Cells(0).Style.ForeColor = Color.Black
        ElseIf Num <= ColorFlag(1) Then
            Data.Rows(Id).Cells(2).Style.BackColor = Color.White
            Data.Rows(Id).Cells(2).Style.ForeColor = Color.Black
        ElseIf Num <= ColorFlag(2) Then
            Data.Rows(Id).Cells(3).Style.BackColor = Color.White
            Data.Rows(Id).Cells(3).Style.ForeColor = Color.Black
        ElseIf Num <= ColorFlag(3) Then
            Data.Rows(Id).Cells(4).Style.BackColor = Color.White
            Data.Rows(Id).Cells(4).Style.ForeColor = Color.Black
        ElseIf Num <= ColorFlag(4) Then
            Data.Rows(Id).Cells(5).Style.BackColor = Color.White
            Data.Rows(Id).Cells(5).Style.ForeColor = Color.Black
        ElseIf Num <= ColorFlag(5) Then
            Data.Rows(Id).Cells(1).Style.BackColor = Color.White
            Data.Rows(Id).Cells(1).Style.ForeColor = Color.Black
        ElseIf Num <= ColorFlag(6) Then
            Data.Rows(Id).Cells(6).Style.BackColor = Color.White
            Data.Rows(Id).Cells(6).Style.ForeColor = Color.Black
        End If
    End Sub

    '判断载入的图片名是否有汉字

    Public Function judgechinese(ByVal s As String) As Boolean '判断是否字符串中包含汉字
        Dim Sum&
        Sum = 0
        Dim char1 As Char
        For c = 1 To Len(s)
            char1 = Mid(s, c, 1)
            If (AscW(char1) > -40870 And AscW(char1) < -19967) Or (AscW(char1) < 40870 And AscW(char1) > 19967) Then
                Sum = Sum + 1
            End If
        Next c
        If Sum Then
            judgechinese = False
        Else
            judgechinese = True
        End If
    End Function

End Class


