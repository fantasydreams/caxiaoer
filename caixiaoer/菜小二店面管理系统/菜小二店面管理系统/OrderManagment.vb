Imports COM.Excel
Public Class OrderManagment

    Private ColunmNum As Integer
    Private PageDown As Boolean '标记是否能进行向下翻页
    Private PageUp As Boolean '标记是否能进行向上翻页
    Private PageNum As Integer = 0 '标记目前所在页
    Private TableData As New DataTable '记录从数据库中选取的数据
    Public WFlag(2) As Boolean '标记按钮
    Private SearchB As Boolean '标记目前是否处于搜索状态
    Private FlagSearchContent(6) As Integer '标记搜索的不同内容之间的间隔 
    Private ColumnNum1 As Integer = 14
    Private Table As New DataTable  '记录订单中的产品 
    Private Pageupbefore As Color '记录之前的按钮的颜色
    Private PageDownBefore As Color
    Private detailPageNum As Integer = 0 '标记详情页所在页
    Private FlagDetail As Boolean '标记是否是在查看订单详情
    Private Purchasetype As String '记录购买的类型
    Private OrderStatus As String '记录订单状态


    Private Sub OrderManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mapload()
        LoadDataFromDb()
        WFlag(0) = True
        LoadFlagSearch()
    End Sub
    '布局
    Private Sub Mapload()
        Me.Top = 0
        Me.Left = 0
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
        Nowtime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
        Nowtime.Left = admin.Left
        Nowtime.Top = admin.Top + admin.Height * 3 / 2
        Nowtime.Height = admin.Height
        Nowtime.Width = admin.Width
        Nowtime.Font = admin.Font
        Nowtime.BackColor = head.BackColor
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
        '已完成按钮
        finish.Width = 140 * index.zoomHeight
        finish.Height = 60 * index.zoomHeight
        finish.Left = searchback.Left - 30 * index.zoomHeight - finish.Width
        finish.Top = searchback.Top + searchback.Height / 2 - finish.Height / 2
        finish.Font = search.Font
        finish.ForeColor = Color.White
        finish.BackColor = head.BackColor
        index.SetLableWin(finish, 12)
        '“未完成”按钮绘制
        unfinished.Left = finish.Left - 10 * index.zoomHeight - finish.Width
        unfinished.Width = finish.Width
        unfinished.Height = finish.Height
        unfinished.Top = finish.Top
        'unfinished.BackColor = Color.FromArgb(&HFF006699)
        unfinished.BackColor = head.BackColor
        unfinished.Font = finish.Font
        unfinished.ForeColor = Color.White
        index.SetLableWin(unfinished, 12)
        '全部订单
        allorder.Height = unfinished.Height
        allorder.Width = 160 * index.zoomHeight
        allorder.Left = unfinished.Left - 10 * index.zoomHeight - allorder.Width
        allorder.Top = unfinished.Top
        allorder.Font = unfinished.Font
        allorder.BackColor = Color.FromArgb(&HFF006699)
        allorder.ForeColor = Color.White
        index.SetLableWin(allorder, 12)
        '全部订单
        '数据显示表
        allorderData.Top = searchback.Top + searchback.Height + 50 * index.zoomHeight
        allorderData.Width = index.ScreenWidth - 80 * index.zoomWidth
        allorderData.Left = index.ScreenWidth / 2 - allorderData.Width / 2
        allorderData.ColumnHeadersHeight = 30 * index.zoomHeight
        ColunmNum = (index.ScreenHeight - (searchback.Top + searchback.Height + 100 * index.zoomHeight) - 30 * index.zoomHeight) / (23 * index.zoomHeight)
        allorderData.Height = ColunmNum * 23 * index.zoomHeight + 30 * index.zoomHeight + 1 * index.zoomHeight
        allorderData.Font = New System.Drawing.
            Font("宋体", 13 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        SetWidth(allorderData)
        allorderData.RowTemplate.Height = 23 * index.zoomHeight
        '下一页按钮
        pageDown1.Width = 150 * index.zoomHeight
        pageDown1.Height = 40 * index.zoomHeight
        pageDown1.Top = ((index.ScreenHeight - (allorderData.Top + allorderData.Height)) / 2 - pageDown1.Height / 2) + (allorderData.Top + allorderData.Height)
        pageDown1.Left = allorderData.Left + allorderData.Width - pageDown1.Width
        pageDown1.Font = New System.Drawing.
            Font("宋体", 20 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        pageDown1.ForeColor = Color.White
        pageDown1.BackColor = Color.FromArgb(&HFF797979)
        index.SetLableWin(pageDown1, 12)
        '上一页按钮
        pageup1.Width = pageDown1.Width
        pageup1.Height = pageDown1.Height
        pageup1.ForeColor = Color.White
        pageup1.Font = pageDown1.Font
        pageup1.Left = pageDown1.Left - pageup1.Width - 10 * index.zoomHeight
        pageup1.BackColor = pageDown1.BackColor
        pageup1.Top = pageDown1.Top
        index.SetLableWin(pageup1, 12)
        '打印按钮
        Print.Left = index.ScreenWidth - pageDown1.Left - pageDown1.Width
        Print.Width = pageDown1.Width
        Print.Height = pageDown1.Height
        Print.Font = pageDown1.Font
        Print.BackColor = pageDown1.BackColor
        Print.Top = pageDown1.Top
        Print.ForeColor = Color.White
        index.SetLableWin(Print, 12)

        '订单详情
        order_detail.Top = allorderData.Top
        order_detail.Height = allorderData.Height
        order_detail.Left = allorderData.Left
        order_detail.Width = allorderData.Width
        order_detail.BackColor = head.BackColor
        order_detail.Hide()

    End Sub
    '返回键点击事件
    Private Sub back_click() Handles back.Click
        index.Show()
        Me.Hide()
    End Sub
    '搜索按钮点击事件
    Private Sub search_click() Handles search.Click
        If searchInput.Text <> "" Then
            searchFunction()
        End If
    End Sub
    Private Sub search_MouseDown() Handles search.MouseDown
        search.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub search_MouseUp() Handles search.MouseUp
        search.BackColor = head.BackColor
    End Sub
    '全部按钮点击事件
    Private Sub allorder_click() Handles allorder.Click
        If allorder.BackColor = head.BackColor Then
            exchangeColor(0)
            LoadDataFromDb()
        End If
    End Sub
    '未完成按钮点击事件
    Private Sub unfinished_click() Handles unfinished.Click
        If unfinished.BackColor = head.BackColor Then
            exchangeColor(1)
            LoadUnfinished()
        End If
    End Sub
    '已完成按钮点击事件
    Private Sub finish_click() Handles finish.Click
        If finish.BackColor = head.BackColor Then
            exchangeColor(2)
            Loadfinish()
        End If
    End Sub
    '设置allorder列宽度
    Private Sub SetWidth(ByVal TheTable As DataGridView)           '设置表格宽度的函数
        Dim Pixcel As Long = (TheTable.Width - 38 * index.zoomHeight) / TheTable.Columns.Count
        For i = 0 To TheTable.Columns.Count - 1
            TheTable.Columns(i).Width = Pixcel
            If i = 0 Or i = 2 Then
                TheTable.Columns(i).Width = 4 / 3 * Pixcel
            ElseIf i = 1 Or i = 3 Or i = 7 Then
                TheTable.Columns(i).Width = 2 / 3 * Pixcel
            ElseIf i <> 8 Then
                TheTable.Columns(i).Width = Pixcel
            End If
        Next
    End Sub
    '从数据库中读取数据
    Public Sub LoadDataFromDb()
        If order_detail.Visible = True Then
            order_detail.Hide()
        End If
        SearchB = False
        TableData.Clear()
        allorderData.Rows.Clear()
        PageNum = 0
        PageUp = False
        PageDown = False
        pageDown1.BackColor = Color.FromArgb(&HFF797979)
        pageup1.BackColor = Color.FromArgb(&HFF797979)
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order order by order_time desc"
        Dim sqlda As SQLite.SQLiteDataAdapter
        Try
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            If TableData.Rows.Count <> 0 Then
                If Print.BackColor <> head.BackColor Then
                    Print.BackColor = head.BackColor
                End If
            Else
                If Print.BackColor = head.BackColor Then
                    Print.BackColor = Color.FromArgb(&HFF797979)
                End If
            End If
            PrintFristData()
        Catch ex As Exception
            index.MsgOrNotifyForm("提示", ex.Message)
        End Try
    End Sub
    '加载第一页数据
    Private Sub PrintFristData()
        If TableData.Rows.Count <> 0 Then
            Dim num As Integer
            If TableData.Rows.Count > ColunmNum Then
                num = ColunmNum - 1
                If PageDown = False Then
                    PageDown = True
                    pageDown1.BackColor = head.BackColor
                End If
            Else
                num = TableData.Rows.Count - 1
            End If
            Dim Str As String
            For i = 0 To num
                If TableData.Rows.Item(i).Item(8).ToString = "1" Then
                    Str = "a" + TableData.Rows.Item(i).Item(7).ToString
                Else
                    Str = TableData.Rows.Item(i).Item(7).ToString
                End If
                allorderData.Rows.Add(TableData.Rows.Item(i).Item(0), TableData.Rows.Item(i).Item(1), TableData.Rows.Item(i).Item(2), TableData.Rows.Item(i).Item(3), TableData.Rows.Item(i).Item(4), TableData.Rows.Item(i).Item(5), TableData.Rows.Item(i).Item(6), Str, "产看详情")
                If SearchB = True Then
                    SetDataStyle(i, i)
                End If
            Next
        End If
        Pageupbefore = pageup1.BackColor
        PageDownBefore = pageDown1.BackColor
    End Sub
    '点击下一页或者上一页加载相应的数据
    Private Sub LoadDataWhenClick(ByVal Type As Integer)
        allorderData.Rows.Clear()
        Dim num As Integer
        If Type = 1 Then
            PageNum += 1
        Else
            PageNum -= 1
        End If
        If TableData.Rows.Count - (PageNum + 1) * ColunmNum > 0 Then
            If PageDown <> True Then
                PageDown = True
                pageDown1.BackColor = head.BackColor
            End If
            num = ColunmNum - 1
            If PageUp = False And PageNum <> 0 Then
                PageUp = True
                pageup1.BackColor = head.BackColor
            ElseIf PageNum = 0 Then
                If PageUp = True Then
                    PageUp = False
                    pageup1.BackColor = Color.FromArgb(&HFF797979)
                End If
            End If
        Else
            If PageDown = True Then
                PageDown = False
                pageDown1.BackColor = Color.FromArgb(&HFF797979)
            End If
            num = TableData.Rows.Count - PageNum * ColunmNum - 1
            If PageUp = False And PageNum <> 0 Then
                PageUp = True
                pageup1.BackColor = head.BackColor
            ElseIf PageNum = 0 Then
                If PageUp = True Then
                    PageUp = False
                    pageup1.BackColor = Color.FromArgb(&HFF797979)
                End If
            End If
        End If
        Dim Str As String
        For i = 0 To num
            If TableData.Rows.Item(PageNum * ColunmNum + i).Item(8).ToString = "1" Then
                Str = "a" + TableData.Rows.Item(i).Item(7).ToString
            Else
                Str = TableData.Rows.Item(PageNum * ColunmNum + i).Item(7).ToString
            End If
            allorderData.Rows.Add(TableData.Rows.Item(PageNum * ColunmNum + i).Item(0), TableData.Rows.Item(PageNum * ColunmNum + i).Item(1), TableData.Rows.Item(PageNum * ColunmNum + i).Item(2), TableData.Rows.Item(PageNum * ColunmNum + i).Item(3), TableData.Rows.Item(PageNum * ColunmNum + i).Item(4), TableData.Rows.Item(PageNum * ColunmNum + i).Item(5), TableData.Rows.Item(PageNum * ColunmNum + i).Item(6), Str, "产看详情")
            If SearchB = True Then
                SetDataStyle(PageNum * ColunmNum, i)
            End If
        Next
    End Sub
    'pageup 、 pagedown 按钮点击事件
    Private Sub pageDown_click() Handles pageDown1.Click
        If pageDown1.BackColor = head.BackColor Or pageDown1.BackColor = Color.FromArgb(&HFF006699) Then
            If FlagDetail = False Then
                LoadDataWhenClick(1)
            Else
                Pro_detail_click(1)
            End If
        End If
    End Sub
    Private Sub pageup_click() Handles pageup1.Click
        If pageup1.BackColor = head.BackColor Or pageup1.BackColor = Color.FromArgb(&HFF006699) Then
            If FlagDetail = False Then
                LoadDataWhenClick(0)
            Else
                Pro_detail_click(0)
            End If
        End If
    End Sub
    Private Sub pageup_mouseDown() Handles pageup1.MouseDown
        If pageup1.BackColor = head.BackColor Then
            pageup1.BackColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    Private Sub pageup_mouseUp() Handles pageup1.MouseUp
        If pageup1.BackColor = Color.FromArgb(&HFF006699) Or pageup1.BackColor = head.BackColor Then
            pageup1.BackColor = head.BackColor
        End If
    End Sub
    Private Sub pageDown_mouseDown() Handles pageDown1.MouseDown
        If pageDown1.BackColor = head.BackColor Then
            pageDown1.BackColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    Private Sub pageDown_mouseUp() Handles pageup1.MouseUp
        If pageDown1.BackColor = Color.FromArgb(&HFF006699) Or pageDown1.BackColor = head.BackColor Then
            pageDown1.BackColor = head.BackColor
        End If
    End Sub
    '用于按钮的颜色切换
    Private Sub exchangeColor(ByVal Num As Integer)
        Dim Flag As Integer
        For i = 0 To 2
            If WFlag(i) = True Then
                Flag = i
                If Flag = Num Then
                    Exit Sub
                Else
                    Exit For
                End If
            End If
        Next
        Select Case Flag
            Case 0
                WFlag(0) = False
                allorder.BackColor = head.BackColor
            Case 1
                WFlag(1) = False
                unfinished.BackColor = head.BackColor
            Case 2
                WFlag(2) = False
                finish.BackColor = head.BackColor
        End Select
        Select Case Num
            Case 0
                WFlag(0) = True
                allorder.BackColor = Color.FromArgb(&HFF006699)
            Case 1
                WFlag(1) = True
                unfinished.BackColor = Color.FromArgb(&HFF006699)
            Case 2
                WFlag(2) = True
                finish.BackColor = Color.FromArgb(&HFF006699)
        End Select
    End Sub
    '搜索功能

    Private Sub searchFunction()
        If order_detail.Visible = True Then
            order_detail.Hide()
            FlagDetail = False
        End If
        allorderData.Rows.Clear()
        TableData.Clear()
        PageNum = 0
        PageUp = PageDown = False
        pageDown1.BackColor = Color.FromArgb(&HFF797979)
        pageup1.BackColor = Color.FromArgb(&HFF797979)
        SearchB = True
        If allorder.BackColor = Color.FromArgb(&HFF006699) Then
            allorder.BackColor = head.BackColor
        End If
        PageDown = False
        PageUp = False
        SearchB = True
        pageup1.BackColor = Color.FromArgb(&HFF797979)
        pageDown1.BackColor = Color.FromArgb(&HFF797979)
        PageNum = 0
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        Dim sqlda As SQLite.SQLiteDataAdapter
        '从第一栏开始选取数据
        sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order  desc where order_count = '" & searchInput.Text & "' order by order_time"
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
        sqlda.Fill(TableData)
        FlagSearchContent(0) = TableData.Rows.Count - 1
        If IsNumeric(searchInput.Text.ToString) = False Then
            sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order  desc where order_status = '" & searchInput.Text.ToString & "' order by order_time"
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            FlagSearchContent(1) = TableData.Rows.Count - 1
        End If
        If IsNumeric(searchInput.Text.ToString) = True Then
            sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order desc where order_money = " & Val(searchInput.Text) & " order by order_time"
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            FlagSearchContent(2) = TableData.Rows.Count - 1
        End If
        If IsNumeric(searchInput.Text.ToString) = False Then
            sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order desc where receiver_name = '" & searchInput.Text & "' order by order_time"
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            FlagSearchContent(3) = TableData.Rows.Count - 1
        End If
        If IsNumeric(searchInput.Text.ToString) = True Then
            sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order desc where receiver_phone = " & Val(searchInput.Text) & " order by order_time"
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            FlagSearchContent(4) = TableData.Rows.Count - 1
        End If
        If IsNumeric(searchInput.Text.ToString) = False Then
            sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order desc where receiver_address = '" & searchInput.Text & "' order by order_time"
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            FlagSearchContent(5) = TableData.Rows.Count - 1
        Else
            sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order desc where receiver_address = " & Val(searchInput.Text) & " order by order_time"
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            FlagSearchContent(5) = TableData.Rows.Count - 1
        End If
        If IsNumeric(searchInput.Text.ToString) = True Then
            sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order desc where operator_id = " & Val(searchInput.Text) & " and operator_type is not 1  order by order_time"
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            FlagSearchContent(6) = TableData.Rows.Count - 1
        ElseIf searchInput.Text.ToString <> "" Then
            Dim s As String = searchInput.Text.ToString
            Dim Temp As String = ""
            If s(0) = "a" Or s(0) = "A" Then
                For i = 1 To s.Length - 1
                    Temp += s(i)
                Next
                If IsNumeric(Temp) = True Then
                    sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type from cx_order desc where operator_id = " & Val(Temp) & " and operator_type is 1  order by order_time"
                    sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                    sqlda.Fill(TableData)
                    FlagSearchContent(6) = TableData.Rows.Count - 1
                End If
            End If
        End If
        PrintFristData()
    End Sub
    '初始化flagSearch
    Private Sub LoadFlagSearch()
        For i = 0 To FlagSearchContent.Length - 1
            FlagSearchContent(i) = -1
        Next
    End Sub
    '对搜索出来的内容进行颜色标记
    Private Sub SetDataStyle(ByVal Num As Integer, ByVal Id As Integer)
        If Num <= FlagSearchContent(0) Then
            allorderData.Rows(Id).Cells(0).Style.BackColor = head.BackColor
            allorderData.Rows(Id).Cells(0).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= FlagSearchContent(1) Then
            allorderData.Rows(Id).Cells(1).Style.BackColor = head.BackColor
            allorderData.Rows(Id).Cells(1).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= FlagSearchContent(2) Then
            allorderData.Rows(Id).Cells(3).Style.BackColor = head.BackColor
            allorderData.Rows(Id).Cells(3).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= FlagSearchContent(3) Then
            allorderData.Rows(Id).Cells(4).Style.BackColor = head.BackColor
            allorderData.Rows(Id).Cells(4).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= FlagSearchContent(4) Then
            allorderData.Rows(Id).Cells(5).Style.BackColor = head.BackColor
            allorderData.Rows(Id).Cells(5).Style.ForeColor = Color.FromArgb(&HFF006699)
        ElseIf Num <= FlagSearchContent(5) Then
            allorderData.Rows(Id).Cells(6).Style.BackColor = head.BackColor
            allorderData.Rows(Id).Cells(6).Style.ForeColor = Color.FromArgb(&HFF006699)
        Else
            allorderData.Rows(Id).Cells(7).Style.BackColor = head.BackColor
            allorderData.Rows(Id).Cells(7).Style.ForeColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    'searchInput 输入框回车事件
    Private Sub SearchInput_enter(o As Object, e As KeyPressEventArgs) Handles searchInput.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And searchInput.Text <> "" Then
            LoadFlagSearch()
            searchFunction()
        End If
    End Sub
    'search_button 图标点击事件
    Private Sub search_button_click() Handles searchButton.Click
        If searchInput.Text <> "" Then
            LoadFlagSearch()
            searchFunction()
        End If
    End Sub
    '未完成订单帅选
    Public Sub LoadUnfinished()
        If order_detail.Visible = True Then
            order_detail.Hide()
            FlagDetail = False
        End If
        PageNum = 0
        allorderData.Rows.Clear()
        TableData.Clear()
        PageUp = False
        PageDown = False
        pageDown1.BackColor = Color.FromArgb(&HFF797979)
        pageup1.BackColor = Color.FromArgb(&HFF797979)
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type from cx_order  desc where  order_status = '待处理' order by order_time"
        Dim sqlda As SQLite.SQLiteDataAdapter
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
        sqlda.Fill(TableData)
        sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type from cx_order  desc where  order_status = '配送中' order by order_time"
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
        sqlda.Fill(TableData)
        If TableData.Rows.Count <> 0 Then
            If Print.BackColor <> head.BackColor Then
                Print.BackColor = head.BackColor
            End If
        Else
            If Print.BackColor = head.BackColor Then
                Print.BackColor = Color.FromArgb(&HFF797979)
            End If
        End If
        PrintFristData()
    End Sub
    '已完成订单
    Private Sub Loadfinish()
        If order_detail.Visible = True Then
            order_detail.Hide()
            FlagDetail = False
        End If
        PageNum = 0
        PageUp = False
        PageDown = False
        pageDown1.BackColor = Color.FromArgb(&HFF797979)
        pageup1.BackColor = Color.FromArgb(&HFF797979)
        allorderData.Rows.Clear()
        TableData.Clear()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandText = "select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type from cx_order  desc where  order_status = '已付款' order by order_time"
        Dim sqlda As SQLite.SQLiteDataAdapter
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
        sqlda.Fill(TableData)
        If TableData.Rows.Count <> 0 Then
            If Print.BackColor <> head.BackColor Then
                Print.BackColor = head.BackColor
            End If
        Else
            If Print.BackColor = head.BackColor Then
                Print.BackColor = Color.FromArgb(&HFF797979)
            End If
        End If
        PrintFristData()
    End Sub
    'allorderdata cell点击
    Private Sub allorderdatacell_click() Handles allorderData.CellClick
        If allorderData.CurrentCellAddress.X = 8 Then
            FlagDetail = True
            Dim temp As Integer = allorderData.CurrentCellAddress.Y
            Dim re_t As String = allorderData.Rows(temp).Cells(2).Value
            order_id.Text = "订单号：" & allorderData.Rows(temp).Cells(0).Value
            order_status.Text = "订单状态：" & allorderData.Rows(temp).Cells(1).Value
            Dim time As String = ""
            For i = 0 To re_t.Length - 4
                time += re_t(i)
            Next
            order_time.Text = "下单时间：" & time
            order_Money.Text = "订单金额（元）：" & allorderData.Rows(temp).Cells(3).Value
            receiver_name.Text = "收货人：" & allorderData.Rows(temp).Cells(4).Value
            receiver_address.Text = "收货地址：" & allorderData.Rows(temp).Cells(6).Value
            OrderStatus = allorderData.Rows(temp).Cells(1).Value
            Purchasetype = TableData.Rows.Item(PageNum * ColunmNum + temp).Item(9).ToString()
            LoadOrder_detail(allorderData.Rows(temp).Cells(0).Value)
            order_detail.Show()
        End If
    End Sub
    'allorderdata cell双击时间
    Private Sub allorderDatacell_double_click() Handles allorderData.CellDoubleClick
        If allorderData.CurrentCellAddress.X = 1 Then
            If allorderData.CurrentCell.Value = "待处理" Then
                If reSure("待处理") = True Then
                    writeStatus(0, allorderData.Rows(allorderData.CurrentCellAddress.Y).Cells(0).Value)
                    allorderData.CurrentCell.Value = "配送中"
                    Dim sqlcmd1 As New SQLite.SQLiteCommand
                    sqlcmd1.CommandType = CommandType.Text
                    sqlcmd1.Connection = index.conn1
                    sqlcmd1.CommandText = "insert into cx_order_status (order_id,order_status) values ('" & allorderData.Rows(allorderData.CurrentCellAddress.Y).Cells(0).Value & "','" & "配送中')"
                    sqlcmd1.ExecuteNonQuery()
                End If
            Else
                If allorderData.CurrentCell.Value = "配送中" Then
                    If reSure("配送中") = True Then
                        writeStatus(1, allorderData.Rows(allorderData.CurrentCellAddress.Y).Cells(0).Value)
                        allorderData.CurrentCell.Value = "已付款"
                        Dim sqlcmd1 As New SQLite.SQLiteCommand
                        sqlcmd1.CommandType = CommandType.Text
                        sqlcmd1.Connection = index.conn1
                        sqlcmd1.CommandText = "insert into cx_order_status (order_id,order_status) values ('" & allorderData.Rows(allorderData.CurrentCellAddress.Y).Cells(0).Value & "','" & "已付款')"
                        sqlcmd1.ExecuteNonQuery()
                    End If
                Else
                    If allorderData.CurrentCell.Value = "已付款" Then
                        index.MsgOrNotifyForm("提示", "订单状态已是<已付款>，不能再进行修改！")
                    End If
                End If
            End If
        End If
    End Sub
    '对订单的状态进行修改
    Private Sub writeStatus(ByVal type As Integer, ByVal orderNum As String)
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        If type = 0 Then
            sqlcmd.CommandText = "update cx_order set order_status = '" & "配送中" & "' where order_count = '" & orderNum & "'"
        Else
            If type = 1 Then
                sqlcmd.CommandText = "update cx_order set order_status = '" & "已付款" & "' where order_count = '" & orderNum & "'"
            End If
        End If
        sqlcmd.ExecuteNonQuery()
    End Sub
    '对用户的操作进行确认
    Private Function reSure(ByVal str As String)
        Dim tempf As New SureAndCancel
        tempf.caption.Text = "提示"
        If str = "待处理" Then
            tempf.msg.Text = "确定将订单状态从 <待处理> 修改至 <配送中> ？"
            tempf.ShowDialog()
            If tempf.SureOrCancel = True Then
                reSure = True
                Exit Function
            Else
                reSure = False
                Exit Function
            End If
        ElseIf str = "配送中" Then
            tempf.msg.Text = "确定将订单状态从 <配送中> 修改至 <已付款> ？"
            tempf.ShowDialog()
            If tempf.SureOrCancel = True Then
                reSure = True
                Exit Function
            Else
                reSure = False
                Exit Function
            End If
        End If
    End Function
    Private Sub order_detail_Paint(sender As Object, e As PaintEventArgs) Handles order_detail.Paint
        panelP.Left = 1
        panelP.Top = 1
        panelP.Width = order_detail.Width - 2
        panelP.Height = order_detail.Height - 2
        panelP.BackColor = Color.White
        '关闭按钮
        shut.Top = 2
        shut.Width = 42
        shut.Height = 40
        shut.Left = order_detail.Width - shut.Width - 2
        shut.BackColor = Color.White
        index.LoadImage(shut, "\SystemImg\", "close")
        index.SetPictureBoxWin(shut, 20)
        '订单号
        order_id.Top = 10 * index.zoomHeight
        order_id.Left = 15 * index.zoomHeight
        order_id.Width = 350 * index.zoomHeight
        order_id.Height = 30 * index.zoomHeight
        order_id.Font = New System.Drawing.Font("黑体", 16 * index.zoomHeight, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        order_id.BackColor = Color.White
        '订单状态
        order_status.Top = order_id.Top
        order_status.Width = 220 * index.zoomHeight
        order_status.Height = order_id.Height
        order_status.Font = order_id.Font
        order_status.Left = order_detail.Width / 2 - order_status.Width / 2
        'order_status.BackColor = Color.Blue
        order_status.BackColor = Color.White
        '订单时间
        order_time.Left = shut.Left - order_time.Width
        order_time.Width = 300 * index.zoomHeight
        order_time.Height = order_status.Height
        order_time.Font = order_id.Font
        order_time.Top = order_id.Top
        order_time.BackColor = Color.White
        'order_time.BackColor = Color.Blue
        '订单金额
        order_Money.Left = order_id.Left
        order_Money.Width = order_id.Width
        order_Money.Height = order_id.Height
        order_Money.Top = order_id.Top + order_id.Height + 10 * index.zoomHeight
        order_Money.Font = order_id.Font
        order_Money.BackColor = Color.White
        '收货人
        receiver_name.Left = order_status.Left
        receiver_name.Width = order_status.Width
        receiver_name.Height = order_status.Height
        receiver_name.Font = order_status.Font
        receiver_name.Top = order_Money.Top
        receiver_name.BackColor = Color.White
        '收货地址
        receiver_address.Top = receiver_name.Top
        receiver_address.Left = order_time.Left
        receiver_address.Width = order_time.Width
        receiver_address.Height = order_time.Height
        receiver_address.Font = order_time.Font
        receiver_address.BackColor = Color.White
        '订单中的产品详情
        order_pro_detail.Top = order_Money.Top + order_Money.Height + 10 * index.zoomHeight
        order_pro_detail.Left = order_id.Left
        order_pro_detail.Width = order_detail.Width - order_id.Left * 2
        order_pro_detail.Height = order_detail.Height - order_pro_detail.Top - 15 * index.zoomHeight
        order_pro_detail.Font = allorderData.Font
        order_pro_detail.ColumnHeadersHeight = 30 * index.zoomHeight
        order_pro_detail.RowTemplate.Height = 23 * index.zoomHeight
        ColumnNum1 = (order_pro_detail.Height - 30 * index.zoomHeight) / (23 * index.zoomHeight)
    End Sub
    Private Sub shut_Click(sender As Object, e As EventArgs) Handles shut.Click
        pageup1.BackColor = Pageupbefore
        pageDown1.BackColor = PageDownBefore
        FlagDetail = False
        order_detail.Hide()
    End Sub
    Private Sub shut_MouseDown(sender As Object, e As MouseEventArgs) Handles shut.MouseDown
        index.LoadImage(shut, "\SystemImg\", "closeNotHover")
    End Sub
    Private Sub shut_MouseUp(sender As Object, e As MouseEventArgs) Handles shut.MouseUp
        index.LoadImage(shut, "\SystemImg\", "close")
    End Sub
    '收货地址点击事件
    Private Sub receiver_address_click() Handles receiver_address.Click
        index.MsgOrNotifyForm("收货人地址", receiver_address.Text.ToString)
    End Sub
    '从数据库中加载订单详情
    Private Sub LoadOrder_detail(ByVal Id As String)
        Table.Reset()
        Pageupbefore = pageup1.BackColor
        PageDownBefore = pageDown1.BackColor
        pageup1.BackColor = Color.FromArgb(&HFF797979)
        pageDown1.BackColor = Color.FromArgb(&HFF797979)
        order_pro_detail.Rows.Clear()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandText = "select product_id ,product_count ,product_price from cx_order_product where order_count = '" & Id & "'"
        Dim sqlda As SQLite.SQLiteDataAdapter
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
        sqlda.Fill(Table)
        Dim num As Integer
        If Table.Rows.Count > ColumnNum1 Then
            num = ColumnNum1 - 1
            pageDown1.BackColor = head.BackColor
        Else
            num = Table.Rows.Count - 1
            pageDown1.BackColor = Color.FromArgb(&HFF797979)
        End If
        Dim TableTemp As New DataTable
        Dim insertFlag As Boolean
        Dim num_re As Integer = 0
        For i = 0 To num
            insertFlag = False
            TableTemp.Reset()
point:      sqlcmd.CommandText = "select name,specification,surplus_count from cx_product where product_id = " & Val(Table.Rows().Item(i).Item(0))
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableTemp)
            If TableTemp.Rows.Count = 0 Then
                Dim sqlitecmd1 As New SQLite.SQLiteCommand
                If insertFlag = False Then
                    sqlitecmd1.Connection = index.conn1
                    sqlitecmd1.CommandType = CommandType.Text
                    sqlitecmd1.CommandText = "insert into cx_product_dl values (" & Table.Rows().Item(i).Item(0) & ")"
                    sqlitecmd1.ExecuteNonQuery()
                    Process.Start(Application.StartupPath & "\product.exe")
                    insertFlag = True
                End If
                System.Threading.Thread.Sleep(1000)
                If num = 2 Then
                    index.MsgOrNotifyForm("错误", "网络状况不佳！请检查！")
                    Exit Sub
                Else
                    num += 1
                End If
                TableTemp.Reset()
                GoTo point
            End If
            order_pro_detail.Rows.Add(Table.Rows.Item(i).Item(0), TableTemp.Rows.Item(0).Item(0), TableTemp.Rows.Item(0).Item(1) * 1000, Table.Rows.Item(i).Item(2), Table.Rows.Item(i).Item(1), Table.Rows.Item(i).Item(1) * Table.Rows.Item(i).Item(2), TableTemp.Rows.Item(0).Item(2), Purchasetype, OrderStatus)
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Nowtime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
    End Sub
    '订单详情的页面上一页下一页按钮点击事件
    Private Sub Pro_detail_click(ByVal iD As Integer)
        order_pro_detail.Rows.Clear()
        If iD = 1 Then
            detailPageNum += 1
        Else
            detailPageNum -= 1
        End If
        Dim num As Integer
        If Table.Rows.Count - (detailPageNum + 1) * ColumnNum1 > 0 Then
            If pageDown1.BackColor <> head.BackColor Or pageDown1.BackColor = Color.FromArgb(&HFF006699) Then
                pageDown1.BackColor = head.BackColor
            End If
            num = ColumnNum1 - 1
            If (pageup1.BackColor <> head.BackColor Or pageup1.BackColor = Color.FromArgb(&HFF006699)) And detailPageNum <> 0 Then
                pageup1.BackColor = head.BackColor
            ElseIf PageNum = 0 Then
                If pageup1.BackColor = head.BackColor Or pageup1.BackColor = Color.FromArgb(&HFF006699) Then
                    pageup1.BackColor = Color.FromArgb(&HFF797979)
                End If
            End If
        Else
            If pageDown1.BackColor = head.BackColor Or pageDown1.BackColor = Color.FromArgb(&HFF006699) Then
                pageDown1.BackColor = Color.FromArgb(&HFF797979)
            End If
            num = Table.Rows.Count - detailPageNum * ColumnNum1 - 1
            If pageup1.BackColor <> head.BackColor And detailPageNum <> 0 Then
                pageup1.BackColor = head.BackColor
            ElseIf detailPageNum = 0 Then
                If pageup1.BackColor = head.BackColor Or pageup1.BackColor = Color.FromArgb(&HFF006699) Then
                    pageup1.BackColor = Color.FromArgb(&HFF797979)
                End If
            End If
        End If
        Dim TableTemp As New DataTable
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        Dim sqlda As SQLite.SQLiteDataAdapter
        For i = 0 To num
            TableTemp.Reset()
            sqlcmd.CommandText = "select name,specification,surplus_count from cx_product where product_id = " & Val(Table.Rows().Item(detailPageNum * ColumnNum1 + i).Item(0))
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableTemp)
            Try
                order_pro_detail.Rows.Add(Table.Rows.Item(detailPageNum * ColumnNum1 + i).Item(0), TableTemp.Rows.Item(0).Item(0), TableTemp.Rows.Item(0).Item(1) * 1000, Table.Rows.Item(detailPageNum * ColumnNum1 + i).Item(2), Table.Rows.Item(detailPageNum * ColumnNum1 + i).Item(1), Table.Rows.Item(detailPageNum * ColumnNum1 + i).Item(1) * Table.Rows.Item(detailPageNum * ColumnNum1 + i).Item(2), TableTemp.Rows.Item(0).Item(2), Purchasetype, OrderStatus)
            Catch ex As Exception
                MsgBox(Table.Rows.Count)
                MsgBox(detailPageNum * ColumnNum1 + i)
            End Try
        Next
    End Sub

    '对导出excel按钮的点击事件
    Private Sub print_mouseDown() Handles Print.MouseDown
        If Print.BackColor = head.BackColor Then
            Print.BackColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    Private Sub print_mouseUp() Handles Print.MouseUp
        If Print.BackColor = Color.FromArgb(&HFF006699) Then
            Print.BackColor = head.BackColor
        End If
    End Sub
    Private Sub print_click() Handles Print.Click
        If Print.BackColor = head.BackColor Or Print.BackColor = Color.FromArgb(&HFF006699) Then
            SaveDbToExcel()
        End If
    End Sub
    Private Sub SaveDbToExcel()
        With loadDbToExcel
            .DefaultExt = "xls"
            .Filter = "Excel Files|*.xls"
            .FilterIndex = 1
            .Title = "保存"
        End With
        If loadDbToExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim name As String = loadDbToExcel.FileName
            Dim a As New cExcelFile
            With a
                .CreateFile(name)
                .PrintGridLines = False

                .SetMargin(cExcelFile.MarginTypes.xlsTopMargin, 1.5)   'set to 1.5 inches
                .SetMargin(cExcelFile.MarginTypes.xlsLeftMargin, 1.5)
                .SetMargin(cExcelFile.MarginTypes.xlsRightMargin, 1.5)
                .SetMargin(cExcelFile.MarginTypes.xlsBottomMargin, 1.5)

                .SetFont("宋体", "16", cExcelFile.FontFormatting.xlsNoFormat)
                .SetColumnWidth(1, 12, 18)
                .WriteValue(cExcelFile.ValueTypes.xlsText, cExcelFile.CellFont.xlsFont0, cExcelFile.CellAlignment.xlsCentreAlign, cExcelFile.CellHiddenLocked.xlsNormal, 1, 1, "订单号")
                .WriteValue(cExcelFile.ValueTypes.xlsText, cExcelFile.CellFont.xlsFont0, cExcelFile.CellAlignment.xlsCentreAlign, cExcelFile.CellHiddenLocked.xlsNormal, 1, 2, "状态")
                .WriteValue(cExcelFile.ValueTypes.xlsText, cExcelFile.CellFont.xlsFont0, cExcelFile.CellAlignment.xlsCentreAlign, cExcelFile.CellHiddenLocked.xlsNormal, 1, 3, "下单时间")
                .WriteValue(cExcelFile.ValueTypes.xlsText, cExcelFile.CellFont.xlsFont0, cExcelFile.CellAlignment.xlsCentreAlign, cExcelFile.CellHiddenLocked.xlsNormal, 1, 4, "总价（￥）")
                .WriteValue(cExcelFile.ValueTypes.xlsText, cExcelFile.CellFont.xlsFont0, cExcelFile.CellAlignment.xlsCentreAlign, cExcelFile.CellHiddenLocked.xlsNormal, 1, 5, "收货人姓名")
                .WriteValue(cExcelFile.ValueTypes.xlsText, cExcelFile.CellFont.xlsFont0, cExcelFile.CellAlignment.xlsCentreAlign, cExcelFile.CellHiddenLocked.xlsNormal, 1, 6, "电话")
                .WriteValue(cExcelFile.ValueTypes.xlsText, cExcelFile.CellFont.xlsFont0, cExcelFile.CellAlignment.xlsCentreAlign, cExcelFile.CellHiddenLocked.xlsNormal, 1, 7, "地址")
                For i = 0 To TableData.Rows.Count - 1
                    For j = 0 To 6
                        .WriteValue(cExcelFile.ValueTypes.xlsText, cExcelFile.CellFont.xlsFont0, cExcelFile.CellAlignment.xlsCentreAlign, cExcelFile.CellHiddenLocked.xlsNormal, i + 2, j + 1, TableData.Rows.Item(i).Item(j))
                    Next
                Next
                .CloseFile()
            End With
            index.MsgOrNotifyForm("提示", "信息已经成功导出至" & name)
        End If
    End Sub
End Class

