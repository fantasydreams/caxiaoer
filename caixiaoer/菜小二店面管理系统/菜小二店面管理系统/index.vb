Imports System.Data.SqlClient
Imports System.Diagnostics
Public Class index
    Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)
    Public ScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width      '获取主显示器的宽高的像素
    Public ScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Public zoomWidth As Double = ScreenWidth / 1024     '窗体的缩放比，以适应各种分辨率的显示器
    Public zoomHeight As Double = ScreenHeight / 768
    Public LoginFlag As Boolean = False  '标记登录
    Public WinFlag(7) As Boolean    '标记点击的窗口位置
    Public Conn As New Data.SQLite.SQLiteConnection
    Public conn1 As New Data.SQLite.SQLiteConnection
    Public identify As Boolean '标记登录者的身份
    Public id As Integer ' 记录登录者的id
    Public nickname As String = "" '记录使用者的昵称
    Dim record_time As String = ""
    Dim dataopenflag As Boolean
    Dim sqlcmd As New SQLite.SQLiteCommand
    Dim sqlcmd1 As New SQLite.SQLiteCommand
    Public remotepath As String = "ftp://123.1.154.169/"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        AxLocation()
        WMP.URL = Application.StartupPath & "\notify\Notify.wav"
        WMP.close()
        WMP.settings.volume = 100
        Conn.ConnectionString = "Data Source=" & Application.StartupPath & "\database\xiaoer.db"
        conn1.ConnectionString = "Data Source=" & Application.StartupPath & "\database\update.db"
        Try
            Conn.Open() '测试数据库连接
            conn1.Open()
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.Connection = Conn
            sqlcmd1.Connection = conn1
            dataopenflag = True
        Catch ex As Exception
            MsgOrNotifyForm("错误", ex.ToString())
        End Try
        Try
            If (CheckApplicationIsRun("dbsynch.exe")) Then
            Else
                Process.Start(Application.StartupPath & "\dbsynch.exe")
            End If
        Catch ex As Exception
            MsgOrNotifyForm("错误", "主程序组件丢失，这是一个致命错误！请尝试重新安装解决！")
        End Try
    End Sub
    Public Function CheckApplicationIsRun(ByVal exeFileName As String) As Boolean
        On Error GoTo Err
        Dim WMI
        Dim Obj
        Dim Objs
        CheckApplicationIsRun = False
        WMI = GetObject("WinMgmts:")
        Objs = WMI.InstancesOf("Win32_Process")
        For Each Obj In Objs
            If InStr(UCase(exeFileName), UCase(Obj.Description)) <> 0 Then
                CheckApplicationIsRun = True
                If Not Objs Is Nothing Then Objs = Nothing
                If Not WMI Is Nothing Then WMI = Nothing
                Exit Function
            End If
        Next
        If Not Objs Is Nothing Then Objs = Nothing
        If Not WMI Is Nothing Then WMI = Nothing
        Exit Function
Err:
        If Not Objs Is Nothing Then Objs = Nothing
        If Not WMI Is Nothing Then WMI = Nothing
    End Function
    '布局
    Private Sub AxLocation()
        Me.Top = 0
        Me.Left = 0
        Me.Width = ScreenWidth
        Me.Height = ScreenHeight
        Me.BackColor = Color.FromArgb(&HFFFFFFCC)
        Dim left As Double = ScreenWidth / 2 - (4 * 180 + 3 * 50 * zoomWidth) / 2
        purchase_pic.Top = 180 * zoomHeight
        purchase_pic.Left = left
        purchase_pic.Width = 180
        purchase_pic.Height = 180
        LoadImage(purchase_pic, "\SystemImg\", "Purchase")
        Dim R_purchase_pic As Integer = login.CreateRoundRectRgn(0, 0, purchase_pic.Width, purchase_pic.Height, 12 * zoomWidth, 12 * zoomHeight)
        login.SetWindowRgn(purchase_pic.Handle, R_purchase_pic, True)
        CollectionWin.Width = purchase_pic.Width
        CollectionWin.Height = 40 * Me.zoomHeight
        CollectionWin.Top = purchase_pic.Top + purchase_pic.Height
        CollectionWin.Left = purchase_pic.Left
        CollectionWin.Font = New System.Drawing.Font("宋体", 16 * zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        CollectionWin.ForeColor = Color.FromArgb(&HFF0066AB)

        Product_P.Top = purchase_pic.Top
        Product_P.Left = purchase_pic.Left + CollectionWin.Width + 50 * zoomWidth
        Product_P.Width = purchase_pic.Width
        Product_P.Height = purchase_pic.Height
        LoadImage(Product_P, "\SystemImg\", "ProductM")
        Dim R_Product_P As Integer = login.CreateRoundRectRgn(0, 0, Product_P.Width, Product_P.Height, 12 * zoomWidth, 12 * zoomHeight)
        login.SetWindowRgn(Product_P.Handle, R_Product_P, True)

        productManagement.Top = CollectionWin.Top
        productManagement.Left = CollectionWin.Left + CollectionWin.Width + 50 * zoomWidth
        productManagement.Width = CollectionWin.Width
        productManagement.Height = CollectionWin.Height
        productManagement.Font = CollectionWin.Font
        productManagement.ForeColor = CollectionWin.ForeColor
        Money.Left = Product_P.Left + Product_P.Width + 50 * zoomWidth
        Money.Top = Product_P.Top
        Money.Width = Product_P.Width
        Money.Height = Product_P.Height
        LoadImage(Money, "\SystemImg\", "Money")
        Dim R_Money As Integer = login.CreateRoundRectRgn(0, 0, Money.Width, Money.Height, 12 * zoomWidth, 12 * zoomHeight)
        login.SetWindowRgn(Money.Handle, R_Money, True)

        Money_to_the_cashier.Left = productManagement.Left + productManagement.Width + 50 * zoomWidth
        Money_to_the_cashier.Top = productManagement.Top
        Money_to_the_cashier.Width = productManagement.Width
        Money_to_the_cashier.Height = productManagement.Height
        Money_to_the_cashier.Font = CollectionWin.Font
        Money_to_the_cashier.ForeColor = productManagement.ForeColor
        matrial_p.Top = Money.Top
        matrial_p.Left = Money.Left + Money.Width + 50 * zoomWidth
        matrial_p.Width = Money.Width
        matrial_p.Height = Money.Height
        LoadImage(matrial_p, "\SystemImg\", "MaterialM")
        Dim R_matrial_p As Integer = login.CreateRoundRectRgn(0, 0, matrial_p.Width, matrial_p.Height, 12 * zoomWidth, 12 * zoomHeight)
        login.SetWindowRgn(matrial_p.Handle, R_matrial_p, True)


        Raw_materials_cashier.Top = Money_to_the_cashier.Top
        Raw_materials_cashier.Left = Money_to_the_cashier.Left + Money_to_the_cashier.Width + 50 * zoomWidth
        Raw_materials_cashier.Width = Money_to_the_cashier.Width
        Raw_materials_cashier.Height = Money_to_the_cashier.Height
        Raw_materials_cashier.Font = CollectionWin.Font
        Raw_materials_cashier.ForeColor = productManagement.ForeColor

        User_P.Top = purchase_pic.Top + purchase_pic.Height + 50 * zoomHeight
        User_P.Left = purchase_pic.Left
        User_P.Width = purchase_pic.Width
        User_P.Height = purchase_pic.Height
        LoadImage(User_P, "\SystemImg\", "UserM")
        Dim R_User_P As Integer = login.CreateRoundRectRgn(0, 0, User_P.Width, User_P.Height, 12 * zoomWidth, 12 * zoomHeight)
        login.SetWindowRgn(User_P.Handle, R_User_P, True)

        user_info.Top = CollectionWin.Top + purchase_pic.Height + 50 * zoomHeight
        user_info.Left = CollectionWin.Left
        user_info.Width = CollectionWin.Width
        user_info.Height = CollectionWin.Height
        user_info.BackColor = CollectionWin.BackColor
        user_info.Font = CollectionWin.Font
        user_info.ForeColor = CollectionWin.ForeColor

        OrderP.Left = Product_P.Left
        OrderP.Top = User_P.Top
        OrderP.Width = User_P.Width
        OrderP.Height = User_P.Height
        LoadImage(OrderP, "\SystemImg\", "OrderM")
        Dim R_OrderP As Integer = login.CreateRoundRectRgn(0, 0, OrderP.Width, OrderP.Height, 12 * zoomWidth, 12 * zoomHeight)
        login.SetWindowRgn(OrderP.Handle, R_OrderP, True)

        Order_info.Left = productManagement.Left
        Order_info.Top = user_info.Top
        Order_info.Width = user_info.Width
        Order_info.Height = user_info.Height
        Order_info.BackColor = user_info.BackColor
        Order_info.Font = CollectionWin.Font
        Order_info.ForeColor = user_info.ForeColor

        MessageP.Left = Money.Left
        MessageP.Top = OrderP.Top
        MessageP.Width = Order_info.Width
        MessageP.Height = OrderP.Height
        LoadImage(MessageP, "\SystemImg\", "MessageM")
        Dim R_MessageP As Integer = login.CreateRoundRectRgn(0, 0, MessageP.Width, MessageP.Height, 12 * zoomWidth, 12 * zoomHeight)
        login.SetWindowRgn(MessageP.Handle, R_MessageP, True)

        Message_sys.Left = Money_to_the_cashier.Left
        Message_sys.Top = Order_info.Top
        Message_sys.Width = Order_info.Width
        Message_sys.Height = Order_info.Height
        Message_sys.BackColor = Order_info.BackColor
        Message_sys.Font = CollectionWin.Font
        Message_sys.ForeColor = Order_info.ForeColor

        OtherP.Left = matrial_p.Left
        OtherP.Top = MessageP.Top
        OtherP.Width = MessageP.Width
        OtherP.Height = MessageP.Height
        LoadImage(OtherP, "\SystemImg\", "OtherM")
        Dim R_OtherP As Integer = login.CreateRoundRectRgn(0, 0, OtherP.Width, OtherP.Height, 12 * zoomWidth, 12 * zoomHeight)
        login.SetWindowRgn(OtherP.Handle, R_OtherP, True)

        other.Left = Raw_materials_cashier.Left
        other.Top = Message_sys.Top
        other.Width = Message_sys.Width
        other.Height = Message_sys.Height
        other.Font = CollectionWin.Font
        other.ForeColor = Order_info.ForeColor



        logo.Top = 0
        logo.Left = 20 * zoomWidth
        logo.Width = 150
        logo.Height = 150
        LoadImage(logo, "\SystemImg\", "logo")

        head_Word.Width = 600 * zoomWidth
        head_Word.Height = 60 * zoomHeight
        head_Word.ForeColor = Message_sys.ForeColor
        head_Word.Left = ScreenWidth / 2 - head_Word.Width / 2
        head_Word.Top = 50 * zoomHeight
        head_Word.Font = New System.Drawing.Font("宋体", 30 * zoomHeight, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))

        index_close.Top = head_Word.Top
        index_close.Left = 900 * zoomWidth
        index_close.Width = 50
        index_close.Height = 50
        LoadImage(index_close, "\SystemImg\", "Index_Close")
        Dim R_index_close As Integer = login.CreateRoundRectRgn(0, 0, index_close.Width + 1 * zoomWidth, index_close.Height + 1 * zoomHeight, 16 * zoomWidth, 16 * zoomHeight)
        login.SetWindowRgn(index_close.Handle, R_index_close, True)

    End Sub
    '主页的关闭按钮点击事件
    Private Sub index_close_Click(sender As Object, e As EventArgs) Handles index_close.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub logo_double_click() Handles logo.DoubleClick
        CloseAppForm()
    End Sub
    '收银点击按钮事件
    Private Sub purchase_pic_Click(sender As Object, e As EventArgs) Handles purchase_pic.Click
        WinFlag(0) = True
        JudgeLoginAndWindow()
    End Sub
    '产品管理点击按钮事件
    Private Sub Product_P_Click(sender As Object, e As EventArgs) Handles Product_P.Click
        WinFlag(1) = True
        JudgeLoginAndWindow()
    End Sub
    '判断登陆后打开的窗体
    Public Sub JudgeLoginAndWindow()
        If LoginFlag = False Then
            login.Show()
            Me.Hide()
        Else
            For i = 0 To WinFlag.Length - 1
                If WinFlag(i) = True Then
                    LocateWin(i)
                    Exit For
                End If
            Next
            Me.Hide()
        End If
    End Sub
    Public Sub LocateWin(ByVal Num As Integer)
        Select Case Num
            Case 0
                purchase.Show()
                WinFlag(Num) = False
            Case 1
                productManage.Show()
                WinFlag(Num) = False
            Case 2
                capitalManagment.Show()
                WinFlag(Num) = False
            Case 3
                materialManagment.Show()
                WinFlag(Num) = False
            Case 4
                userManagment.Show()
                WinFlag(Num) = False
            Case 5
                OrderManagment.Show()
                WinFlag(Num) = False
            Case 6
                MessageManagment.Show()
                WinFlag(Num) = False
        End Select
    End Sub
    '资金管理按钮点击事件
    Private Sub Money_Click(sender As Object, e As EventArgs) Handles Money.Click
        WinFlag(2) = 1
        JudgeLoginAndWindow()
    End Sub

    Private Sub matrial_p_Click(sender As Object, e As EventArgs) Handles matrial_p.Click
        WinFlag(3) = 1
        JudgeLoginAndWindow()
    End Sub

    Private Sub User_P_Click(sender As Object, e As EventArgs) Handles User_P.Click
        WinFlag(4) = 1
        JudgeLoginAndWindow()
    End Sub

    Private Sub OrderP_Click(sender As Object, e As EventArgs) Handles OrderP.Click
        WinFlag(5) = 1
       JudgeLoginAndWindow()
    End Sub

    Private Sub MessageP_Click(sender As Object, e As EventArgs) Handles MessageP.Click
        WinFlag(6) = 1
        JudgeLoginAndWindow()
    End Sub

    Private Sub OtherP_Click(sender As Object, e As EventArgs) Handles OtherP.Click
        WinFlag(7) = 1
        JudgeLoginAndWindow()
    End Sub
    '此函数用于对lable进行圆弧处理
    Public Sub SetLableWin(ByVal AnyLabel As Label, ByVal extent As Double)
        Dim R_AnyLabel As Integer = login.CreateRoundRectRgn(0, 0, AnyLabel.Width, AnyLabel.Height, extent, extent)
        login.SetWindowRgn(AnyLabel.Handle, R_AnyLabel, True)
    End Sub
    '此函数用于对Picturebox进行圆弧处理
    Public Sub SetPictureBoxWin(ByVal AnyPicturebox As PictureBox, ByVal extent As Double)
        Dim R_AnyPicturebox As Integer = login.CreateRoundRectRgn(0, 0, AnyPicturebox.Width, AnyPicturebox.Height, extent, extent)
        login.SetWindowRgn(AnyPicturebox.Handle, R_AnyPicturebox, True)
    End Sub
    '用于窗体的圆弧处理
    Public Sub SetForm(ByVal WinForm As Form, ByVal extent As Double)
        Dim r_win As Double = login.CreateRoundRectRgn(0, 0, WinForm.Width, WinForm.Height, extent * zoomHeight, extent * zoomHeight)
        login.SetWindowRgn(WinForm.Handle, r_win, True)
    End Sub
    '退出程序
    Public Sub CloseAppForm()
        Conn.Close()
        conn1.Close()
        End
    End Sub
    '显示消息提示窗
    Public Sub MsgOrNotifyForm(ByVal cap As String, ByVal Message As String)
        Dim tempForm As New MsgOrNotify
        tempForm.caption.Text = cap
        tempForm.msg.Text = Message
        tempForm.ShowDialog()
    End Sub
    '设置datagirdview 的各列的宽度
    Public Sub SetWidth(ByVal TheTable As DataGridView)           '设置表格宽度的函数
        Dim Pixcel As Long = (TheTable.Width - 38 * zoomHeight) / (TheTable.Columns.Count - 1)
        For i = 0 To TheTable.Columns.Count - 1
            If i = 0 Or i = 2 Then
                TheTable.Columns(i).Width = Pixcel * 3 / 4
            ElseIf i = 10 Then
                TheTable.Columns(i).Width = Pixcel / 2
            Else
                TheTable.Columns(i).Width = Pixcel
            End If
        Next
    End Sub
    '加载图片
    Public Sub LoadImage(ByVal TheImage As PictureBox, ByVal Path As String, ByVal Name As String)
        Dim PicName As String = Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Name, "md5")
        Try
            TheImage.Image = Image.FromFile(Application.StartupPath & Path & PicName & ".jpg")
        Catch ex As Exception
            Try
                TheImage.Image = Image.FromFile(Application.StartupPath & Path & PicName & ".png")
            Catch ex1 As Exception
                MsgOrNotifyForm("错误", Name & "丢失，请尽快修补数据！")
            End Try
        End Try
    End Sub
    Public Sub LoadImagePic(ByVal TheImage As PictureBox, ByVal Path As String, ByVal Name As String)
        Try
            TheImage.Image = Image.FromFile(Application.StartupPath & Path & Name & ".jpg")
        Catch ex As Exception
            Try
                TheImage.Image = Image.FromFile(Application.StartupPath & Path & Name & ".png")
            Catch ex1 As Exception
                If IO.File.Exists(Application.StartupPath & Path & Name & ".jpg") = False Then
                    If IO.File.Exists(Application.StartupPath & Path & Name & ".png") = False Then
                        MsgOrNotifyForm("错误", "图片不存在！无法打开！")
                    End If
                End If
            End Try
        End Try
    End Sub
    Public Sub LoadImageFilePic(ByVal TheImage As PictureBox, ByVal PathAndName As String)
        Try
            TheImage.Image = Image.FromFile(PathAndName)
        Catch ex As Exception
            If IO.File.Exists(PathAndName) = False Then
                MsgOrNotifyForm("错误", "图片不存在！无法打开！")
            End If
        End Try
    End Sub
    '设置登陆后窗体的显示
    Private Sub setWinflag(ByVal f As Integer)
        For i = 0 To WinFlag.Length - 1
            If WinFlag(i) = True Then
                If i = f Then
                    Exit Sub
                End If
            End If
        Next
        WinFlag(f) = True
    End Sub

    Private Sub UpdataOrder_Tick(sender As Object, e As EventArgs) Handles UpdataOrder.Tick
        If dataopenflag = True Then
            If record_time = "" Then
                sqlcmd1.CommandText = "select time from cx_order_flag"
                Dim data As New DataTable
                Dim sqlda As SQLite.SQLiteDataAdapter
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd1.CommandText, conn1)
                sqlda.Fill(data)
                If data.Rows.Item(0).Item(0).ToString <> "0" Then
                    record_time = data.Rows.Item(0).Item(0)
                Else
                    sqlcmd.CommandText = "select max(order_time) from cx_order"
                    Dim data1 As New DataTable
                    sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, Conn)
                    sqlda.Fill(data1)
                    If data1.Rows.Item(0).Item(0).ToString <> "" Then
                        sqlcmd1.CommandText = "update cx_order_flag set time = '" & data1.Rows.Item(0).Item(0) & "'"
                        sqlcmd1.ExecuteNonQuery()
                        record_time = data1.Rows.Item(0).Item(0).ToString
                        If OrderManagment.WFlag(0) = True Then
                            OrderManagment.LoadDataFromDb()
                            WMP.Ctlcontrols.play()
                        ElseIf OrderManagment.WFlag(1) = True Then
                            OrderManagment.LoadUnfinished()
                            WMP.Ctlcontrols.play()
                        Else
                            WMP.Ctlcontrols.play()
                        End If
                    End If
                End If
            Else
                Dim sqlda As SQLite.SQLiteDataAdapter
                sqlcmd.CommandText = "select max(order_time) from cx_order"
                Dim data1 As New DataTable
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, Conn)
                sqlda.Fill(data1)
                If data1.Rows.Item(0).Item(0).ToString <> "" And data1.Rows.Item(0).Item(0).ToString <> record_time Then
                    sqlcmd1.CommandText = "update cx_order_flag set time = '" & data1.Rows.Item(0).Item(0) & "'"
                    sqlcmd1.ExecuteNonQuery()
                    record_time = data1.Rows.Item(0).Item(0).ToString
                    If OrderManagment.WFlag(0) = True Then
                        OrderManagment.LoadDataFromDb()
                        WMP.Ctlcontrols.play()
                    ElseIf OrderManagment.WFlag(1) = True Then
                        OrderManagment.LoadUnfinished()
                        WMP.Ctlcontrols.play()
                    Else
                        WMP.Ctlcontrols.play()
                    End If
                End If
            End If
            End If
            
    End Sub

    Private Sub checksynch_status_Tick(sender As Object, e As EventArgs) Handles checksynch_status.Tick
        Try
            If (CheckApplicationIsRun("dbsynch.exe")) Then
            Else
                Process.Start(Application.StartupPath & "\dbsynch.exe")
            End If
        Catch ex As Exception
            MsgOrNotifyForm("错误", "主程序组件丢失，这是一个致命错误！请尝试重新安装解决！")
        End Try
    End Sub

    '加载图片
    Public Sub LoadImageP(ByVal TheImage As PictureBox, ByVal Path As String, ByVal Name As String)
        Try
            TheImage.Image = Image.FromFile(Application.StartupPath & Path & Name)
        Catch ex As Exception
            MsgOrNotifyForm("错误", "图片不存在！无法打开！")
        End Try
    End Sub
End Class
