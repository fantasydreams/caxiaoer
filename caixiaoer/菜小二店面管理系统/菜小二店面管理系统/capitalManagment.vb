Public Class capitalManagment

    Private ColunmNum As Integer
    Private PageDown As Boolean '标记是否能进行向下翻页
    Private PageUp As Boolean '标记是否能进行向上翻页
    Private PageNum As Integer = 0 '标记目前所在页
    Private TableData As New DataTable '用来记录从数据库中选出来的数据
    Private SearchB As Boolean '标记是否是通过搜索而得到的数据
    Private ColorFlag(8) As Integer '标记颜色的范围
    Private CheckKeywords(4) As String '存储查询关键字
    Private WriteKey As Boolean '标记是否初始化了关键字
    Private DateI0Text As String '记录替换后的数据
    Private DateI1Text As String

    Private Sub capitalManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MapLoad()
        LoadDateFromDB()
    End Sub
    '窗体布局
    Private Sub MapLoad()
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
        Nowtime.BackColor = head.BackColor
        '查询框输入日期框2
        dateI1.Width = 150 * index.zoomHeight
        dateI1.Font = New System.Drawing.
            Font("宋体", 20 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '"至"显示
        DateTo.Width = 60 * index.zoomHeight
        DateTo.Height = 40 * index.zoomHeight
        DateTo.Font = New System.Drawing.
            Font("宋体", 22 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DateTo.Top = head.Height + 50 * index.zoomHeight
        DateTo.Left = index.ScreenWidth / 2 - 150 * index.zoomHeight - DateTo.Width
        DateTo.ForeColor = Color.FromArgb(&HFF0099CB)
        '查询输入框1
        dateI0.Width = 150 * index.zoomHeight
        dateI0.Font = New System.Drawing.
            Font("宋体", 20 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        dateI0.Left = DateTo.Left - dateI0.Width
        dateI0.Top = DateTo.Top
        '查询框输入日期框2
        dateI1.Width = dateI0.Width
        dateI1.Font = dateI0.Font
        dateI1.Left = DateTo.Left + DateTo.Width
        dateI1.Top = dateI0.Top
        '“查询”字样显示
        searchP.Top = dateI1.Top
        searchP.Width = 75 * index.zoomHeight
        searchP.Left = dateI0.Left - searchP.Width
        searchP.Height = DateTo.Height
        searchP.Font = DateTo.Font
        searchP.ForeColor = DateTo.ForeColor
        '查询按钮
        search.Left = index.ScreenWidth / 2 + dateI1.Width / 2
        search.Top = dateI1.Top
        search.Width = 120 * index.zoomHeight
        search.Height = searchP.Height
        search.Font = searchP.Font
        search.BackColor = head.BackColor
        search.ForeColor = Color.White
        index.SetLableWin(search, 8)
        '"打印表格"按钮
        printexcel.Left = search.Left + search.Width + 50 * index.zoomHeight
        printexcel.Width = 200 * index.zoomHeight
        printexcel.Height = search.Height
        printexcel.Top = search.Top
        printexcel.BackColor = search.BackColor
        printexcel.ForeColor = search.ForeColor
        printexcel.Font = search.Font
        index.SetLableWin(printexcel, 8)
        '数据显示表
        Data.Top = search.Top + search.Height + 50 * index.zoomHeight
        Data.Width = index.ScreenWidth - 80 * index.zoomWidth
        Data.Left = index.ScreenWidth / 2 - Data.Width / 2
        Data.ColumnHeadersHeight = 30 * index.zoomHeight
        ColunmNum = (index.ScreenHeight - (search.Top + search.Height + 100 * index.zoomHeight) - 30 * index.zoomHeight) / (23 * index.zoomHeight)
        Data.Height = ColunmNum * 23 * index.zoomHeight + 30 * index.zoomHeight + 1 * index.zoomHeight
        Data.RowTemplate.Height = 23 * index.zoomHeight
        Data.Font = New System.Drawing.
            Font("宋体", 13 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        SetWidth(Data)
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
    '更新时间
    Private Sub NowTimeUpdater_Tick(sender As Object, e As EventArgs) Handles NowTimeUpdater.Tick
        Nowtime.Text = Format(Now(), "yyyy.MM.dd hh:mm")
    End Sub
    Private Sub back_click(sender As Object, e As EventArgs) Handles back.Click
        index.Show()
        Me.Hide()
    End Sub
    '设置本窗口中的DataGridView列宽度
    Private Sub SetWidth(ByVal Name As DataGridView)
        Dim w As Double = (Name.Width - 38 * index.zoomHeight) / Name.ColumnCount - 1
        For i = 0 To Name.ColumnCount - 1
            If i = 0 Then
                Name.Columns(i).Width = w * 4 / 3
            ElseIf i = 5 Then
                Name.Columns(i).Width = w * 2 / 3
            Else
                Name.Columns(i).Width = w
            End If
        Next
    End Sub
    '将数据从数据库载入
    Private Sub LoadDateFromDB()
        TableData.Clear()
        Data.Rows.Clear()
        If SearchB = True Then
            SearchB = False
        End If
        Try
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.Connection = index.Conn
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = "select time,product_id,operator_id,operator_type,comment from cx_purchase_log order by time desc"
            Dim sqlda As SQLite.SQLiteDataAdapter
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
            sqlda.Fill(TableData)
            Dim Num As Integer
            If ColunmNum >= TableData.Rows.Count() - PageNum * ColunmNum Then
                Num = TableData.Rows.Count() - PageNum * ColunmNum - 1
            Else
                Num = ColunmNum - 1
            End If
            Dim TempDataTable As New DataTable
            Dim IdentifyFlag As String
            For i = 0 To Num
                If TableData.Rows.Item(i).Item(3).ToString = "1" Then
                    IdentifyFlag = "a"
                Else
                    IdentifyFlag = ""
                End If
                sqlcmd.CommandText = "select name,specification,price from cx_product where product_id = " & TableData.Rows.Item(i).Item(1)
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                TempDataTable.Reset()
                sqlda.Fill(TempDataTable)
                Data.Rows.Add(TableData.Rows.Item(i).Item(0), TempDataTable.Rows.Item(0).Item(0), TableData.Rows.Item(i).Item(1),
                              TempDataTable.Rows.Item(0).Item(1) * 1000, TempDataTable.Rows.Item(0).Item(2),
                              IdentifyFlag & TableData.Rows.Item(i).Item(2), TableData.Rows.Item(i).Item(4))
                If i = ColunmNum - 1 Then
                    PageDown = True
                    pagedown1.BackColor = head.BackColor
                End If
            Next
        Catch ex As Exception
            index.MsgOrNotifyForm("错误", ex.Message)
        End Try
    End Sub
    '点击上一页或下一个按钮事件
    Private Sub PageUpAndPageDown(ByVal PageTo As Integer)
        Data.Rows.Clear()
        Dim Num As Integer '循环次数
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
        Dim TempDataTable As New DataTable
        Dim IdentifyFlag As String
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = index.Conn
        Dim sqlda As SQLite.SQLiteDataAdapter
        Try
            For i = 0 To Num
                If TableData.Rows.Item(i).Item(3).ToString = "1" Then
                    IdentifyFlag = "a"
                Else
                    IdentifyFlag = ""
                End If
                sqlcmd.CommandText = "select name,specification,price from cx_product where product_id = " & TableData.Rows.Item(i).Item(1)
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                TempDataTable.Reset()
                sqlda.Fill(TempDataTable)
                Data.Rows.Add(TableData.Rows.Item(i).Item(0), TempDataTable.Rows.Item(0).Item(0), TableData.Rows.Item(i).Item(1),
                              TempDataTable.Rows.Item(0).Item(1) * 1000, TempDataTable.Rows.Item(0).Item(2),
                              IdentifyFlag & TableData.Rows.Item(i).Item(2), TableData.Rows.Item(i).Item(4))
                If SearchB = True Then
                    '
                End If
            Next

            If Num = ColunmNum - 1 Then
                PageDown = True
                If pagedown1.BackColor <> head.BackColor Then
                    pagedown1.BackColor = head.BackColor
                End If
            Else
                PageDown = False
                pagedown1.BackColor = Color.FromArgb(&HFF797979)
            End If
            If PageNum <> 0 Then
                PageUp = True
                If pageup1.BackColor <> head.BackColor Then
                    pageup1.BackColor = head.BackColor
                End If
            Else
                PageUp = False
                pageup1.BackColor = Color.FromArgb(&HFF797979)
            End If
        Catch ex As Exception
            index.MsgOrNotifyForm("错误", ex.Message)
        End Try
    End Sub
    '向上翻页按钮点击事件
    Private Sub PageUp1_MouseDown(sender As Object, e As EventArgs) Handles pageup1.MouseDown
        If PageUp = True Then
            PageUP1.BackColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    Private Sub PageUp1_MouseUp(sender As Object, e As EventArgs) Handles pageup1.MouseUp
        If PageUp = True Then
            pageup1.BackColor = head.BackColor
        End If
    End Sub
    Private Sub pageUp1_mouseClick() Handles pageup1.Click
        If PageUp = True Then
            PageUpAndPageDown(0)
        End If
    End Sub
    '向下翻页鼠标点击事件
    Private Sub PageDown1_MouseDown() Handles pagedown1.MouseDown
        If PageDown = True Then
            pagedown1.BackColor = Color.FromArgb(&HFF006699)
        End If
    End Sub
    Private Sub PageDown1_MouseUp() Handles pagedown1.MouseUp
        If PageDown = True Then
            pagedown1.BackColor = head.BackColor
        End If
    End Sub
    Private Sub pageDown1_click() Handles pagedown1.Click
        If PageDown = True Then
            PageUpAndPageDown(1)
        End If
    End Sub
    '查询按钮点击事件
    Private Sub search_MouseDown() Handles search.MouseDown
        search.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub search_MouseUp() Handles search.MouseUp
        search.BackColor = head.BackColor
    End Sub
    Private Sub search_click() Handles search.Click
        If dateI0.Text <> "" And dateI1.Text <> "" Then
            searcfunction()
        Else
            index.MsgOrNotifyForm("提示", "请输入搜索日期范围！")
        End If
    End Sub
    '导出当前表格按钮点击事件
    Private Sub printexcel_mouseDown() Handles printexcel.MouseDown
        printexcel.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub printexcel_mouseUp() Handles printexcel.MouseUp
        printexcel.BackColor = head.BackColor
    End Sub
    '搜索函数
    Private Sub searcfunction()
        If JudgeDateInput() = True Then
            If pagedown1.BackColor = head.BackColor Then
                pagedown1.BackColor = Color.FromArgb(&HFF797979)
            End If
            If pageup1.BackColor = head.BackColor Then
                pageup1.BackColor = Color.FromArgb(&HFF797979)
            End If
            SearchTime()
            SearchDataPageOne()
        End If
    End Sub
    '处理搜索时间范围的函数
    Private Sub SearchTime()
        TableData.Clear()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandType = CommandType.Text
        If JudgeAscOrDesc() = True Then
            sqlcmd.CommandText = "select time ,product_id,operator_id,operator_type,comment from cx_purchase_log where time between '" & DateI1Text & "'  and  '" & DateI0Text & "' order by time desc"
        Else
            sqlcmd.CommandText = "select time ,product_id,operator_id,operator_type,comment from cx_purchase_log where time between '" & DateI0Text & "'  and  '" & DateI1Text & "' order by time asc"
        End If
        Dim sqlda As SQLite.SQLiteDataAdapter
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
        sqlda.Fill(TableData)
    End Sub
    '加载搜索的第一页数据
    Private Sub SearchDataPageOne()
        Data.Rows.Clear()
        Try
            Dim Num As Integer
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.Connection = index.Conn
            Dim sqlda As SQLite.SQLiteDataAdapter
            If ColunmNum >= TableData.Rows.Count() - PageNum * ColunmNum Then
                Num = TableData.Rows.Count() - PageNum * ColunmNum - 1
            Else
                Num = ColunmNum - 1
            End If
            Dim TempDataTable As New DataTable
            Dim IdentifyFlag As String
            For i = 0 To Num
                If TableData.Rows.Item(i).Item(3).ToString = "1" Then
                    IdentifyFlag = "a"
                Else
                    IdentifyFlag = ""
                End If
                sqlcmd.CommandText = "select name,specification,price from cx_product where product_id = " & TableData.Rows.Item(i).Item(1)
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                TempDataTable.Reset()
                sqlda.Fill(TempDataTable)
                Data.Rows.Add(TableData.Rows.Item(i).Item(0), TempDataTable.Rows.Item(0).Item(0), TableData.Rows.Item(i).Item(1),
                              TempDataTable.Rows.Item(0).Item(1) * 1000, TempDataTable.Rows.Item(0).Item(2),
                              IdentifyFlag & TableData.Rows.Item(i).Item(2), TableData.Rows.Item(i).Item(4))
            Next
            If Data.Rows.Count = ColunmNum Then
                If PageDown = False Then
                    PageDown = True
                    pagedown1.BackColor = head.BackColor
                End If
            End If
        Catch ex As Exception
            index.MsgOrNotifyForm("提示", ex.Message)
        End Try
    End Sub
    '日期输入框回车键事件
    Private Sub dateI1_keyPress(sender As Object, e As KeyPressEventArgs) Handles dateI1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If dateI1.Text <> "" Then
                searcfunction()
            End If
        End If
    End Sub
    '判断输入的大小关系来进行降序或升序拍列
    Private Function JudgeAscOrDesc()
        If dateI0.Text.ToString > dateI1.Text.ToString Then
            JudgeAscOrDesc = True
        Else
            JudgeAscOrDesc = False
        End If
    End Function
    '判断输入的合法性并转换字符串
    Private Function JudgeDateInput()
        If dateI0.Text.ToString = "" And dateI1.Text.ToString = "" Then
            JudgeDateInput = True
        Else
            If dateI0.Text.ToString = "" And dateI1.Text.ToString <> "" Then
                index.MsgOrNotifyForm("提示", "请输入开始时间！")
                JudgeDateInput = False
                Exit Function
            ElseIf dateI0.Text.ToString <> "" And dateI1.Text.ToString = "" Then
                index.MsgOrNotifyForm("提示", "请输入结束时间！")
                JudgeDateInput = False
                Exit Function
            Else
                If JudgeDateInputString(dateI0, 0) = True And JudgeDateInputString(dateI1, 1) = True Then
                    JudgeDateInput = True
                Else
                    JudgeDateInput = False
                End If
            End If
        End If
    End Function
    '判断输入字符串的合理性
    Private Function JudgeDateInputString(ByVal TheInputbox As TextBox, ByVal T As Integer)
        If TheInputbox.Text.Length <> 10 Then
            index.MsgOrNotifyForm("提示", "输入格式有误，格式：<****/**/**> 或者 <****-**-**>")
            JudgeDateInputString = False
            Exit Function
        Else
            For i = 0 To 3
                If TheInputbox.Text(i) >= "0" And TheInputbox.Text(i) <= "9" Then
                Else
                    index.MsgOrNotifyForm("提示", "输入格式有误，格式：<****/**/**> 或者 <****-**-**>")
                    JudgeDateInputString = False
                    Exit Function
                End If
            Next
            Dim a As String
            a = TheInputbox.Text(4)
            If a <> "/" And a <> "-" Then
                index.MsgOrNotifyForm("提示", "输入格式有误，格式：<****/**/**> 或者 <****-**-**>")
                JudgeDateInputString = False
                Exit Function
            End If
            a = TheInputbox.Text(5)
            If a < "0" And a > "9" Then
                index.MsgOrNotifyForm("提示", "输入格式有误，格式：<****/**/**> 或者 <****-**-**>")
                JudgeDateInputString = False
                Exit Function
            End If
            a = TheInputbox.Text(6)
            If a < "0" And a > "9" Then
                index.MsgOrNotifyForm("提示", "输入格式有误，格式：<****/**/**> 或者 <****-**-**>")
                JudgeDateInputString = False
                Exit Function
            End If
            a = TheInputbox.Text(7)
            If a <> "/" And a <> "-" Then
                index.MsgOrNotifyForm("提示", "输入格式有误，格式：<****/**/**> 或者 <****-**-**>")
                JudgeDateInputString = False
                Exit Function
            End If
            a = TheInputbox.Text(8)
            If a < "0" And a > "9" Then
                index.MsgOrNotifyForm("提示", "输入格式有误，格式：<****/**/**> 或者 <****-**-**>")
                JudgeDateInputString = False
                Exit Function
            End If
            a = TheInputbox.Text(9)
            If a < "0" And a > "9" Then
                index.MsgOrNotifyForm("提示", "输入格式有误，格式：<****/**/**> 或者 <****-**-**>")
                JudgeDateInputString = False
                Exit Function
            End If
        End If
        If T = 0 Then
            DateI0Text = TheInputbox.Text.Replace("-", "/")
        Else
            DateI1Text = TheInputbox.Text.Replace("-", "/")
        End If
        JudgeDateInputString = True
    End Function
End Class