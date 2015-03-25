Public Class resetKey

    Private userIllegalityKeyPress As Boolean
    '标记消息提示
    Private MsgPed As Boolean

    Private Sub resetKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MapLoad()
    End Sub

    Private Sub MapLoad()
        Me.TopMost = True
        Me.Height = 652
        Me.Width = 622
        Me.Left = index.ScreenWidth / 2 - Me.Width / 2
        Me.Top = index.ScreenHeight / 2 - Me.Height / 2
        Me.BackColor = Color.FromArgb(&HFF006699)
        Dim r As Integer = login.CreateRoundRectRgn(0, 0,Me.Width, Me.Height, 20, 20)
        login.SetWindowRgn(Me.Handle, r, True)
        '绘制面板颜色
        Panel.Width = Me.Width - 2
        Panel.Height = Me.Height - 2
        Panel.Left = 1
        Panel.Top = 1
        Panel.BackColor = Color.FromArgb(&HFFFFFFCB)
        index.SetLableWin(Panel, 20)
        Reset_p.Width = 160
        Reset_p.Height = 40
        Reset_p.Left = Me.Width / 2 - Reset_p.Width / 2
        Reset_p.Top = 20
        Reset_p.ForeColor = Color.FromArgb(&HFF006699)
        Reset_p.BackColor = Panel.BackColor
        Reset_p.Font = New System.Drawing.
            Font("宋体", 26, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Dim high As Integer = 20
        '绘制“工号”
        jobsNum.Left = 100
        jobsNum.Width = 150
        jobsNum.Top = Reset_p.Top + Reset_p.Height + 60
        jobsNum.Height = 40
        jobsNum.Font = New System.Drawing.
            Font("宋体", 18, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        jobsNum.BackColor = Panel.BackColor
        jobsNum.ForeColor = Color.FromArgb(&HFF333333)
        phone.Top = jobsNum.Top + jobsNum.Height + high
        '打印“电话号码：”
        phone.Left = jobsNum.Left
        phone.Width = jobsNum.Width
        phone.Height = jobsNum.Height
        phone.Font = jobsNum.Font
        phone.BackColor = Panel.BackColor
        phone.ForeColor = Color.FromArgb(&HFF333333)
        '绘制工号输入框

        jobNum_IO.Width = Me.Width - jobsNum.Left - jobsNum.Width - 150
        jobNum_IO.Left = Me.Width - 100 - jobNum_IO.Width
        jobNum_IO.Font = jobsNum.Font
        jobNum_IO.Top = jobsNum.Top
        '电话号码打印
        phone_p.Left = jobNum_IO.Left
        phone_p.Width = jobNum_IO.Width
        phone_p.Height = jobNum_IO.Height
        phone_p.Font = jobNum_IO.Font
        phone_p.Top = phone.Top
        phone_p.BackColor = phone.BackColor
        '绘制“获取验证码”按钮线条
        identifyingCode_line.BackColor = Color.FromArgb(&HFFCCCCCC)
        identifyingCode_line.Width = 180
        identifyingCode_line.Height = 52
        identifyingCode_line.Left = Me.Width - identifyingCode_line.Width - 100
        index.SetLableWin(identifyingCode_line, 12)
        identifyingCode_line.Top = phone.Top + phone.Height + high
        '绘制“发送验证码”按钮
        identifyingcode.Left = identifyingCode_line.Left + 1
        identifyingcode.Width = identifyingCode_line.Width - 2
        identifyingcode.Height = identifyingCode_line.Height - 2
        identifyingcode.Top = identifyingCode_line.Top + 1
        index.SetLableWin(identifyingcode, 12)
        identifyingcode.Font = New System.Drawing.
            Font("宋体", 20, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        identifyingcode.ForeColor = Color.White
        identifyingcode.BackColor = Color.FromArgb(&HFFFF6600)
        '打印“输入密码：”
        Key_IO.Left = phone.Left
        Key_IO.Width = phone.Width
        Key_IO.Height = phone.Height
        Key_IO.Font = phone.Font
        Key_IO.Top = identifyingCode_line.Top + identifyingCode_line.Height + high
        Key_IO.BackColor = Panel.BackColor
        '输入密码框
        Key_IAO.Left = jobNum_IO.Left
        Key_IAO.Width = jobNum_IO.Width
        Key_IAO.Height = jobNum_IO.Height
        Key_IAO.Top = Key_IO.Top
        Key_IAO.Font = Key_IO.Font
        '打印“确认密码：”
        confirmKey.Left = Key_IO.Left
        confirmKey.Width = Key_IO.Width
        confirmKey.Height = Key_IO.Height
        confirmKey.Top = Key_IO.Top + Key_IO.Height + high
        confirmKey.Font = Key_IO.Font
        confirmKey.BackColor = Panel.BackColor
        '绘制确认密码输入窗口
        confirmKey_IO.Left = Key_IAO.Left
        confirmKey_IO.Width = Key_IAO.Width
        confirmKey_IO.Font = Key_IAO.Font
        confirmKey_IO.Top = confirmKey.Top
        '绘制“短信验证码：”
        identity.Left = phone.Left
        identity.Width = 180
        identity.Height = phone.Height
        identity.Top = confirmKey.Top + confirmKey.Height + high
        identity.Font = confirmKey.Font
        identity.BackColor = Panel.BackColor
        '绘制验证码输入框
        identity_IO.Width = jobNum_IO.Width / 2
        identity_IO.Font = jobNum_IO.Font
        identity_IO.Top = identity.Top
        identity_IO.Left = Me.Width - identity_IO.Width - 100
        '重置密码背景线条
        resetLine.Width = 222
        resetLine.Height = identifyingCode_line.Height
        resetLine.Top = identity_IO.Top + identity_IO.Height + 60
        resetLine.Left = Me.Width / 2 - resetLine.Width / 2
        resetLine.BackColor = identifyingCode_line.BackColor
        index.SetLableWin(resetLine, 12)
        '绘制重置密码按钮
        reset_key.Left = resetLine.Left + 1
        reset_key.Width = resetLine.Width - 2
        reset_key.Height = resetLine.Height - 2
        reset_key.Top = resetLine.Top + 1
        index.SetLableWin(reset_key, 12)
        reset_key.Font = identifyingcode.Font
        reset_key.ForeColor = Color.White
        '绘制关闭按钮
        shut.Top = 1
        shut.Width = 42
        shut.Height = 40
        shut.Left = Me.Width - shut.Width - 1
        index.LoadImage(shut, "\SystemImg\", "close")
        shut.BackColor = Panel.BackColor
        index.SetPictureBoxWin(shut, 20)


    End Sub

    Private Sub shut_Click(sender As Object, e As EventArgs) Handles shut.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub shut_MouseDown(sender As Object, e As MouseEventArgs) Handles shut.MouseDown

        index.LoadImage(shut, "\SystemImg\", "closeNotHover")
        Me.Close()
        login.Show()
    End Sub

    Private Sub shut_MouseUp(sender As Object, e As MouseEventArgs) Handles shut.MouseUp
        index.LoadImage(shut, "\SystemImg\", "close")
    End Sub

    Private sub JudeKey()
        If Key_IAO.Text <> confirmKey_IO.Text Then
            index.MsgOrNotifyForm("提示", "两次输入不一致，请重新输入！")
            confirmKey_IO.Text = ""
        Else
            ResetKeyToData()
        End If
    End Sub

    Private Sub Reset_click(sender As Object, e As EventArgs) Handles reset_key.Click
        If login.ChecKUserID(jobNum_IO.Text.ToString()) = True Then
            JudeKey()
        End If
    End Sub

    Private Sub ResetKeyToData()
        Dim NewKey As String = Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(confirmKey_IO.Text.ToString(), "md5")
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.Connection = index.Conn
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = "update cx_operator set password = '" & NewKey & "' where operatorID = '" & login.ID(jobNum_IO.Text.ToString()) & "'"
        sqlcmd.ExecuteReader()
        Me.Close()
        login.Show()
        index.MsgOrNotifyForm("提示", "修改密码成功！")
    End Sub

    Private Sub jobNumIO_keyPress(sender As Object, e As KeyPressEventArgs) Handles jobNum_IO.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar = Chr(13) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
        Else
            e.Handled = True
            If userIllegalityKeyPress = False Then
                index.MsgOrNotifyForm("提示", "你只能输入字母和数字")
                userIllegalityKeyPress = True
            End If
        End If
    End Sub


    Private Sub jobNum_IO_KeyUp(sender As Object, e As KeyEventArgs) Handles jobNum_IO.KeyUp
        Dim jobText As String = jobNum_IO.Text.ToString()
        If jobText.Length() = 1 Or jobText.Length() = 0 Then
        Else
            If jobNum_IO.Text <> "" Then
                Dim sqlcmd As New SQLite.SQLiteCommand
                sqlcmd.Connection = index.Conn
                sqlcmd.CommandType = CommandType.Text
                sqlcmd.CommandText = "select tellphone from cx_operator where operatorID = '" & login.ID(jobText.ToString()) & "'"
                Dim data As New DataTable
                Dim sqlda As New SQLite.SQLiteDataAdapter
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, index.Conn)
                sqlda.Fill(data)
                If data.Rows.Count = 0 Then
                    If MsgPed = False Then
                        index.MsgOrNotifyForm("提示", "用户: < " & jobNum_IO.Text.ToString() & " >不存在")
                        jobNum_IO.Text = reload(jobNum_IO)
                    End If
                    Exit Sub
                Else
                    Dim headChar As String
                    headChar = data.Rows.Item(0).Item(0)
                    Dim chr = headChar(0) + headChar(1) + headChar(2)
                    Dim chr1 = headChar(7) + headChar(8) + headChar(9) + headChar(10)
                    phone_p.Text = chr + "****" + chr1
                End If
            End If
        End If
    End Sub

    '获取除左后一位的字符串
    Private Function reload(ByVal Name As TextBox)
        Dim temp As String = Name.Text
        Dim returnTemp As String = ""
        For i = 0 To Name.Text.Length - 2
            returnTemp += temp(i)
        Next
        reload = returnTemp
    End Function

End Class