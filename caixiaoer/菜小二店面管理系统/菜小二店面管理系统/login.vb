Imports System.Data


Public Class login
    Public Declare Function CreateRoundRectRgn Lib "gdi32" Alias "CreateRoundRectRgn" (ByVal X1 As Int32, ByVal Y1 As Int32, ByVal X2 As Int32, ByVal Y2 As Int32, ByVal X3 As Int32, ByVal Y3 As Int32) As Int32
    Public Declare Function SetWindowRgn Lib "user32" Alias "SetWindowRgn" (ByVal hWnd As Int32, ByVal hRgn As Int32, ByVal bRedraw As Boolean) As Int32

    '标记是否已经输入过错误的字符
    Private UserInputWrong As Boolean



    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginLayout()
    End Sub

    Private Sub loginLayout()
        Me.TopMost = 1
        Me.Width = 722
        Me.Height = 422
        Me.Left = index.ScreenWidth / 2 - Me.Width / 2
        Me.Top = index.ScreenHeight / 2 - Me.Height / 2
        Me.BackColor = Color.FromArgb(&HFF006699)
        panel.Width = Me.Width - 2
        panel.Height = Me.Height - 2
        panel.Left = 1
        panel.Top = 1
        panel.BackColor = Color.FromArgb(&HFFFFFFCB)
        index.SetLableWin(panel, 20)
        Dim r As Integer = CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 20, 20)
        SetWindowRgn(Me.Handle, r, True)
        caixiaoer.Top = 50 * index.zoomHeight
        caixiaoer.Width = 463
        caixiaoer.Left = (Me.Width - caixiaoer.Width) / 2
        caixiaoer.Height = 50
        caixiaoer.Font = New System.Drawing.Font("黑体", 35, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        caixiaoer.BackColor = panel.BackColor
        caixiaoer.ForeColor = Color.FromArgb(&HFF006898)
        PrintLinecolor.BackColor = caixiaoer.ForeColor
        PrintLinecolor.Top = caixiaoer.Top * 3 / 2 - 2
        PrintLinecolor.Left = caixiaoer.Left + 160
        PrintLinecolor.Width = 85
        PrintLinecolor.Height = 4
        logo.Left = 25
        logo.Width = 200
        logo.Height = 200
        logo.Top = Me.Height / 2 - logo.Height / 2
        index.LoadImage(logo, "\SystemImg\", "logo")
        logo.BackColor = panel.BackColor
        job_number.Top = logo.Top + 65
        job_number.Left = logo.Left + logo.Width
        job_number.Height = 30
        job_number.Width = 120
        job_number.BackColor = panel.BackColor
        job_number.ForeColor = Color.FromArgb(&HFF1C748A)
        job_number.Font = New System.Drawing.Font("宋体", 20, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        job_number_input.Top = job_number.Top - 5 * index.zoomHeight
        job_number_input.Left = job_number.Left + job_number.Width - 30
        job_number_input.Font = job_number.Font
        job_number_input.Width = 260
        Key.Left = job_number.Left
        Key.Top = job_number.Top + job_number.Height + 30
        Key.Height = job_number.Height
        Key.Width = job_number.Width
        Key.Font = job_number.Font
        Key.BackColor = panel.BackColor
        Key.ForeColor = job_number.ForeColor
        Key_input.Top = Key.Top - 5
        Key_input.Left = job_number_input.Left
        Key_input.Width = job_number_input.Width
        Key_input.Font = job_number_input.Font
        logoin_button.BackColor = Color.FromArgb(&HFF3398CC)
        logoin_button.Top = logo.Top + logo.Height
        logoin_button.Left = Key.Left
        logoin_button.Width = Key.Width + Key_input.Width - 30
        logoin_button.Height = Key.Height + 20
        logoin_button.Font = Key.Font
        logoin_button.ForeColor = Color.White
        Dim r_logoin_button As Integer = CreateRoundRectRgn(0, 0, logoin_button.Width, logoin_button.Height, 18 * index.zoomWidth, 18 * index.zoomHeight)
        SetWindowRgn(logoin_button.Handle, r_logoin_button, True)
        frist_login.Font = New System.Drawing.Font("宋体", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        frist_login.Left = job_number_input.Left + job_number_input.Width
        frist_login.Top = job_number_input.Top + job_number_input.Height / 2 - frist_login.Height / 2
        frist_login.ForeColor = Key.ForeColor
        frist_login.BackColor = panel.BackColor
        forgot_key.Font = frist_login.Font
        forgot_key.Left = frist_login.Left
        forgot_key.Top = Key_input.Top + Key_input.Height / 2 - forgot_key.Height / 2
        forgot_key.ForeColor = frist_login.ForeColor
        forgot_key.BackColor = panel.BackColor
        shut.Top = 2
        shut.Width = 42
        shut.Height = 40
        shut.Left = Me.Width - shut.Width - 2
        index.LoadImage(shut, "\SystemImg\", "close")
        shut.BackColor = panel.BackColor
        index.SetPictureBoxWin(shut, 20)



    End Sub

    '商品添加Map
    

    Private Sub Key_input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Key_input.KeyPress
        If e.KeyChar = Chr(13) Then
            ConnectMySql(job_number_input.Text, Key_input.Text)
        End If
    End Sub

    Public Sub ConnectMySql(ByVal UserID As String, Password As String)
        If (String.IsNullOrEmpty(job_number_input.Text)) And (String.IsNullOrEmpty(Key_input.Text)) Then
            index.MsgOrNotifyForm("提示", "请输入用户名和密码！")
            Exit Sub
        ElseIf (String.IsNullOrEmpty(job_number_input.Text)) Then
            index.MsgOrNotifyForm("提示", "请输入用户名！")
            Exit Sub
        ElseIf (String.IsNullOrEmpty(Key_input.Text)) Then
            index.MsgOrNotifyForm("提示", "请输入密码！")
            Exit Sub
        End If
        If ChecKUserID(UserID) = True Then
            Try
                Dim sqlcmd As New SQLite.SQLiteCommand
                sqlcmd.Connection = index.Conn
                sqlcmd.CommandType = CommandType.Text
                If UserID(0) = "a" Or UserID(0) = "A" Then
                    sqlcmd.CommandText = "select password from cx_admin where admin_id = '" & ID(UserID) & "'"
                Else
                    sqlcmd.CommandText = "select password from cx_operator where operatorID = '" & ID(UserID) & "'"
                End If
                Dim data As New DataTable
                Dim sqlda As New SQLite.SQLiteDataAdapter
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                sqlda.Fill(data)
                If data.Rows.Count = 0 Then
                    Dim tempForm As New MsgOrNotify
                    tempForm.caption.Text = "提示"
                    tempForm.msg.Text = "用户: < " & UserID & " >不存在"
                    tempForm.Show()
                    Exit Sub
                End If
                If Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "md5") = data.Rows.Item(0).Item(0) Then
                    Dim sqlcmd1 As New SQLite.SQLiteCommand
                    sqlcmd1.Connection = index.Conn
                    sqlcmd1.CommandType = CommandType.Text
                    If UserID(0) = "a" Or UserID(0) = "A" Then
                        sqlcmd1.CommandText = "select nickname from cx_admin where admin_id = '" & ID(UserID) & "'"
                    Else
                        sqlcmd1.CommandText = "select nickname from cx_operator where operatorID = '" & ID(UserID) & "'"
                    End If
                    Dim data1 As New DataTable
                    Dim sqlda1 As SQLite.SQLiteDataAdapter
                    sqlda1 = New SQLite.SQLiteDataAdapter(sqlcmd1.CommandText, index.Conn)
                    sqlda1.Fill(data1)
                    Dim nknm As String = data1.Rows.Item(0).Item(0)
                    If (UserID(0) = "a" Or UserID(0) = "A") Then
                        index.nickname = "管理员：" + nknm
                        index.identify = True
                    Else
                        index.nickname = "收银员：" + nknm
                    End If
                    index.id = ID(UserID)
                    index.MsgOrNotifyForm("提示", "登陆成功，欢迎使用...")
                    index.LoginFlag = True
                    Me.Close()
                    FristClickWin()
                Else
                    index.MsgOrNotifyForm("提示", "请检查你输入的密码是否有误")
                End If
            Catch ex As Exception
                index.MsgOrNotifyForm("错误", ex.Message)
            End Try
        End If
    End Sub

    Private Sub logoin_button_Click(sender As Object, e As EventArgs) Handles logoin_button.Click
        ConnectMySql(job_number_input.Text, Key_input.Text)
    End Sub

    '判断输入用户名的合法性
    Public Function ChecKUserID(ByVal Name As String)
        If (Name(0) = "a" Or Name(0) = "A" Or Name(0) = "o" Or Name(0) = "O") Then
        Else
            index.MsgOrNotifyForm("提示", "你输入的用户名或ID 不合法，请检查后重新输入！")
            ChecKUserID = False
            Exit Function
        End If
        For i = 1 To Name.Length - 1
            If Name(i) < "0" Or Name(i) > "9" Then
                index.MsgOrNotifyForm("提示", "你输入的用户名或ID 不合法，请检查后重新输入！")
                ChecKUserID = False
                Exit Function
            End If
        Next
        ChecKUserID = True
    End Function

    Private Sub shut_Click(sender As Object, e As EventArgs) Handles shut.Click
        Me.Close()
        index.Show()
    End Sub

    Private Sub shut_MouseDown(sender As Object, e As MouseEventArgs) Handles shut.MouseDown
        index.LoadImage(shut, "\SystemImg\", "closeNotHover")
    End Sub

    Private Sub shut_MouseUp(sender As Object, e As MouseEventArgs) Handles shut.MouseUp
        index.LoadImage(shut, "\SystemImg\", "close")
    End Sub

    Private Sub forgot_key_Click(sender As Object, e As EventArgs) Handles forgot_key.Click
        Me.Close()
        resetKey.Show()
    End Sub

    '检测进入程序后第一次点击的窗体
    Private Sub FristClickWin()
        Dim Flag As Integer = 0
        For i = 0 To 6
            If index.WinFlag(i) = True Then
                Flag = i
                Exit For
            End If
        Next
        Select Case Flag
            Case 0
                purchase.Show()
            Case 1
                productManage.Show()
            Case 2
                capitalManagment.Show()
            Case 3
                materialManagment.Show()
            Case 4
                userManagment.Show()
            Case 5
                OrderManagment.Show()
            Case 6
                MessageManagment.Show()
            Case 7

        End Select
    End Sub

    Private Sub ForgetKey_MouseHover(sender As Object, e As EventArgs) Handles forgot_key.MouseHover
        forgot_key.ForeColor = Color.Blue()
    End Sub
    Private Sub forgetKey_mouseLeave(sender As Object, e As EventArgs) Handles forgot_key.MouseLeave
        forgot_key.ForeColor = frist_login.ForeColor
    End Sub

    Private Sub frist_login_mouseHover(sender As Object, e As EventArgs) Handles frist_login.MouseHover
        frist_login.ForeColor = Color.Blue()
    End Sub
    Private Sub frist_login_MouseLeave(sender As Object, e As EventArgs) Handles frist_login.MouseLeave
        frist_login.ForeColor = forgot_key.ForeColor
    End Sub

    '获得ID
    Public Function ID(ByVal Name As String)
        Dim returntemp As String = ""
        For i = 1 To Name.Length - 1
            returntemp += Name(i)
        Next
        ID = returntemp
    End Function
    Private Sub JobNumInput_keyUp(sender As Object, e As KeyPressEventArgs) Handles job_number_input.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar <= "z" And e.KeyChar >= "a" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Then
        Else
            If UserInputWrong = False Then
                UserInputWrong = True
                index.MsgOrNotifyForm("提示", "你只能输入字母和数字")
            End If
            e.Handled = True
        End If
    End Sub

End Class