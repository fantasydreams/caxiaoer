Public Class productDetail

    '定义标记显示产品的id
    Private ProID As Integer
    Public FomerPrice As Double  '记录显示前产品的单价
    Private PriceIOTextChange As Boolean '标记单价是否被更改
    Private FristLoadData As Boolean = True   '标记是否是开始加载数据
    Public returnPrice As String '标记经过查看后的产品单价
    Private Sub productDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MapLoad()

    End Sub
    '布局
    Private Sub MapLoad()
        Me.Width = 750 * index.zoomHeight
        Me.Height = 450 * index.zoomHeight
        Me.Top = index.ScreenHeight / 2 - Me.Height / 2 + 50 * index.zoomHeight
        Me.Left = index.ScreenWidth / 2 - Me.Width / 2
        Me.BackColor = Color.FromArgb(&HFF797979)
        Dim Me_r As Integer = login.CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 16 * index.zoomHeight, 16 * index.zoomHeight)
        login.SetWindowRgn(Me.Handle, Me_r, True)
        '背景颜色
        backGround.Width = Me.Width - 2
        backGround.Height = Me.Height - 2
        backGround.Top = 1
        backGround.Left = 1
        backGround.BackColor = Color.White
        index.SetLableWin(backGround, 16 * index.zoomHeight)
        '显示产品各参数详情的背景线条
        ProDetailLine.Width = 372 * index.zoomHeight
        ProDetailLine.Height = backGround.Height - 20 * index.zoomHeight
        ProDetailLine.Top = 10 * index.zoomHeight
        ProDetailLine.Left = backGround.Width - 10 * index.zoomHeight - ProDetailLine.Width
        ProDetailLine.BackColor = Color.FromArgb(&HFFCCCCCC)
        index.SetLableWin(ProDetailLine, 12 * index.zoomHeight)
        '显示产品参数项的背景颜色
        ProDetailBack.Top = ProDetailLine.Top + 1
        ProDetailBack.Left = ProDetailLine.Left + 1
        ProDetailBack.Width = ProDetailLine.Width - 2
        ProDetailBack.Height = ProDetailLine.Height - 2
        ProDetailBack.BackColor = Color.FromArgb(&HFFFFFFCC)
        index.SetLableWin(ProDetailBack, 12 * index.zoomHeight)
        '关闭按钮
        shut.Top = 2
        shut.Width = 42
        shut.Height = 41
        shut.Left = Me.Width - shut.Width - 2
        index.LoadImage(shut, "\SystemImg\", "Picclose")
        shut.BackColor = ProDetailBack.BackColor
        index.SetPictureBoxWin(shut, 30)
        '产品图片背景
        picBack.Left = backGround.Left + 10 * index.zoomHeight
        picBack.Width = backGround.Width - picBack.Left - ProDetailLine.Width - 20 * index.zoomHeight
        picBack.Top = 50 * index.zoomHeight
        picBack.Height = 240 * index.zoomHeight
        picBack.BackColor = ProDetailLine.BackColor
        index.SetLableWin(picBack, 12 * index.zoomHeight)
        '产品图片位
        PictureDetail.Left = picBack.Left + 1
        PictureDetail.Width = picBack.Width - 2
        PictureDetail.Top = picBack.Top + 1
        PictureDetail.Height = picBack.Height - 2
        PictureDetail.BackColor = Color.White
        index.SetPictureBoxWin(PictureDetail, 12 * index.zoomHeight)
        '产品名称打印
        proName.Left = picBack.Left
        proName.Top = 5 * index.zoomHeight
        proName.Height = picBack.Top - proName.Top - 5 * index.zoomHeight
        proName.Width = picBack.Width * 4 / 5
        proName.Font = New System.Drawing.Font("微软雅黑", 15 * index.zoomHeight,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        proName.BackColor = Color.White
        '显示产品编号
        ProNum.Height = proName.Height
        ProNum.Left = proName.Left + proName.Width
        ProNum.Width = picBack.Width / 5
        ProNum.Top = proName.Top
        ProNum.Font = New System.Drawing.Font("宋体", 15 * index.zoomHeight,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        ProNum.BackColor = Color.White
        '产品原料显示背景线条
        ProMaterial.Width = picBack.Width
        ProMaterial.Top = picBack.Top + picBack.Height + 10 * index.zoomHeight
        ProMaterial.Height = backGround.Height - ProMaterial.Top - 10 * index.zoomHeight
        ProMaterial.Left = picBack.Left
        ProMaterial.BackColor = picBack.BackColor
        index.SetLableWin(ProMaterial, 12 * index.zoomHeight)
        '显示产品原料详情
        ProMaterialDetail.Left = ProMaterial.Left + 1
        ProMaterialDetail.Width = ProMaterial.Width - 2
        ProMaterialDetail.Height = ProMaterial.Height - 2
        ProMaterialDetail.Top = ProMaterial.Top + 1
        proMaterialDetail.Font = ProNum.Font
        Dim ProM_r As Double = login.CreateRoundRectRgn(0, 0, proMaterialDetail.Width, proMaterialDetail.Height, 12 * index.zoomHeight, 12 * index.zoomHeight)
        login.SetWindowRgn(proMaterialDetail.Handle, ProM_r, True)
        ProMaterialDetail.BackColor = Color.White
        '定义各行控件件显示的高距
        Dim high As Integer = 5 * index.zoomHeight
        '显示"产品类型："
        proType.Left = ProDetailBack.Left + 30 * index.zoomHeight
        proType.Width = (ProDetailBack.Width - 60 * index.zoomHeight) / 2
        proType.Height = 35 * index.zoomHeight
        proType.Top = 40 * index.zoomHeight + backGround.Top
        proType.Font = New System.Drawing.Font("微软雅黑", 15 * index.zoomHeight,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        proType.BackColor = ProDetailBack.BackColor
        '显示产品类型
        ProNameP.Left = proType.Left + proType.Width
        ProNameP.Width = proType.Width
        ProNameP.Height = proType.Height
        ProNameP.Font = proType.Font
        ProNameP.Top = proType.Top
        ProNameP.BackColor = ProDetailBack.BackColor
        '显示“产品价格（￥）：”
        ProPrice.Left = proType.Left
        ProPrice.Width = proType.Width + 20 * index.zoomHeight
        ProPrice.Height = proType.Height
        ProPrice.Top = proType.Top + proType.Height + high
        ProPrice.Font = proType.Font
        ProPrice.BackColor = ProDetailBack.BackColor
        '显示产品单价
        priceIO.Left = ProPrice.Left + ProPrice.Width
        priceIO.Width = ProNameP.Left + ProNameP.Width - priceIO.Left
        priceIO.Top = ProPrice.Top
        priceIO.Font = New System.Drawing.Font("宋体", 15 * index.zoomHeight,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '显示“产品规格：”
        ProS.Left = ProPrice.Left
        ProS.Width = ProPrice.Width
        ProS.Height = ProPrice.Height
        ProS.Font = ProPrice.Font
        ProS.BackColor = ProDetailBack.BackColor
        ProS.Top = ProPrice.Top + ProPrice.Height + high
        '显示产品规格
        prosP.Left = priceIO.Left
        prosP.Width = priceIO.Width
        prosP.Height = ProNameP.Height
        prosP.Font = priceIO.Font
        prosP.Top = ProS.Top
        prosP.BackColor = ProDetailBack.BackColor
        '显示“产品库存：”
        proSurplus.Left = ProS.Left
        proSurplus.Width = ProPrice.Width
        proSurplus.Height = ProS.Height
        proSurplus.Top = ProS.Top + ProS.Height + high
        proSurplus.Font = ProS.Font
        proSurplus.BackColor = ProDetailBack.BackColor
        '产品库存显示
        prosurpluesP.Left = priceIO.Left
        prosurpluesP.Width = priceIO.Width
        prosurpluesP.Height = prosP.Height
        prosurpluesP.Top = prosP.Top + prosP.Height + high
        prosurpluesP.Font = priceIO.Font
        prosurpluesP.BackColor = ProDetailBack.BackColor
        '显示“销售量：”
        soldCount.Left = proSurplus.Left
        soldCount.Width = proSurplus.Width
        soldCount.Height = proSurplus.Height
        soldCount.Top = proSurplus.Top + proSurplus.Height + high
        soldCount.Font = proSurplus.Font
        soldCount.BackColor = ProDetailBack.BackColor
        '显示销量
        soldCountP.Left = prosurpluesP.Left
        soldCountP.Height = prosurpluesP.Height
        soldCountP.Top = prosurpluesP.Top + prosurpluesP.Height + high
        soldCountP.Font = priceIO.Font
        soldCountP.Width = prosurpluesP.Width
        soldCountP.BackColor = ProDetailBack.BackColor
        '二维码显示区域
        procode.Left = soldCount.Left
        procode.Top = soldCount.Top + soldCount.Height + high
        procode.Height = ProDetailBack.Height - procode.Top
        procode.Width = procode.Height
        procode.BackColor = Color.White
        index.LoadImage(procode, "\SystemImg\", "unUpload")
        '打印按钮
        print.Width = 120 * index.zoomHeight
        print.Height = 50 * index.zoomHeight
        print.BackColor = Color.FromArgb(&HFF3399CC)
        print.Top = procode.Top + procode.Height / 2 - print.Height / 2
        print.Left = (ProDetailBack.Left + ProDetailBack.Width) / 2 + (procode.Left + procode.Width) / 2 - print.Width / 2
        index.SetLableWin(print, 12 * index.zoomHeight)
        print.Font = priceIO.Font
        print.ForeColor = Color.White

    End Sub
    '关闭按钮鼠标点击事件
    Private Sub Shur_mouseDown(sender As Object, e As EventArgs) Handles shut.MouseDown
        index.LoadImage(shut, "\SystemImg\", "closeNotHover")
    End Sub
    Private Sub shut_MouseUp(sender As Object, e As MouseEventArgs) Handles shut.MouseUp
        index.LoadImage(shut, "\SystemImg\", "Picclose")
    End Sub
    Public Sub shut_click() Handles shut.MouseClick
        If PriceIOTextChange = True Then
            Dim tempF As New SureAndCancel
            tempF.caption.Text = "提示"
            tempF.msg.Text = "你已经修改了<" & proName.Text & ">的价格，确定价格由<" & FomerPrice & ">元更新至<" & priceIO.Text & ">元吗？"
            tempF.ShowDialog()
            Dim s As Boolean = tempF.SureOrCancel
            If s = True Then
                returnPrice = priceIO.Text
            Else
                returnPrice = ""
            End If
            tempF.Close()
        Else
            returnPrice = ""
        End If
        Me.Hide()
    End Sub

    '打印鼠标点击事件
    Private Sub print_MouseDown() Handles print.MouseDown
        print.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub print_MouseUp() Handles print.MouseUp
        print.BackColor = Color.FromArgb(&HFF3399CC)
    End Sub

    Private Sub price_IO() Handles priceIO.TextChanged
        If FristLoadData = True Then
            FristLoadData = False
            FomerPrice = Val(priceIO.Text)
            Exit Sub
        End If
        If Val(priceIO.Text) <> FomerPrice Then
            If PriceIOTextChange = False Then
                PriceIOTextChange = True
                Exit Sub
            End If
        Else
            If PriceIOTextChange = True Then
                PriceIOTextChange = False
                Exit Sub
            End If
        End If
    End Sub
End Class