Public Class SureAndCancel

    Public SureOrCancel As Boolean

    Private Sub SureAndCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mapload()

    End Sub
    '布局
    Private Sub Mapload()
        '本窗体显示位置坐标和大小样式
        Me.Width = 400 * index.zoomHeight
        Me.Height = 250 * index.zoomHeight
        Me.Left = index.ScreenWidth / 2 - Me.Width / 2
        Me.Top = index.ScreenHeight / 2 - Me.Height / 2 + 25 * index.zoomHeight
        Me.BackColor = Color.FromArgb(&HFFFFFFCC)
        index.SetForm(Me, 16)
        '提示图片
        NotifyPic.Left = 5 * index.zoomHeight
        NotifyPic.Top = 10 * index.zoomHeight
        NotifyPic.Width = 50
        NotifyPic.Height = 50
        '关闭按钮
        shut.Width = 42
        shut.Height = 40
        shut.Left = Me.Width - shut.Width - 2
        shut.Top = 2
        Try
            shut.Image = Image.FromFile(Application.StartupPath & "\SystemImg\" & Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("close", "md5") & ".png")
        Catch ex As Exception
            MsgBox("close.png程序部分文件缺失，请尽快修复！")
            End
        End Try

        '标题
        caption.Left = NotifyPic.Left + NotifyPic.Width
        caption.Top = NotifyPic.Top
        caption.Width = shut.Left - NotifyPic.Left - NotifyPic.Width
        caption.Height = NotifyPic.Height
        caption.Font = New System.Drawing.
            Font("微软雅黑", 24 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '确定背景线条
        YesL.Width = 120 * index.zoomHeight
        YesL.Height = 50 * index.zoomHeight
        YesL.Left = (Me.Width - 2 * YesL.Width) / 2 - YesL.Left - 10 * index.zoomHeight
        YesL.Top = Me.Height - YesL.Height - 25 * index.zoomHeight
        YesL.BackColor = Color.White
        index.SetLableWin(YesL, 12)
        '确定按钮
        yes.Left = YesL.Left + 1
        yes.Top = YesL.Top + 1
        yes.Width = YesL.Width - 2
        yes.Height = YesL.Height - 2
        yes.BackColor = Color.FromArgb(&HFF0099CB)
        index.SetLableWin(yes, 12)
        yes.ForeColor = Color.White
        yes.Font = New System.Drawing.
            Font("宋体", 22 * index.zoomHeight, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '取消背景按钮背景
        CancelLine.Width = YesL.Width
        CancelLine.Height = YesL.Height
        CancelLine.Left = YesL.Left + YesL.Width + 20 * index.zoomHeight
        CancelLine.Top = YesL.Top
        CancelLine.BackColor = Color.White
        index.SetLableWin(CancelLine, 12)
        '取消按钮
        Cancel.Left = CancelLine.Left + 1
        Cancel.Top = CancelLine.Top + 1
        Cancel.Width = CancelLine.Width - 2
        Cancel.Height = CancelLine.Height - 2
        Cancel.BackColor = Color.FromArgb(&HFF0099CB)
        index.SetLableWin(Cancel, 12)
        Cancel.ForeColor = Color.White
        Cancel.Font = yes.Font
        '消息显示
        msg.Left = caption.Left
        msg.Top = caption.Top + caption.Height + 10 * index.zoomHeight
        msg.Width = caption.Width
        msg.Height = YesL.Top - 10 * index.zoomHeight - msg.Top
        msg.Font = New System.Drawing.
            Font("宋体", 16 * index.zoomHeight, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    End Sub

    Private Sub shut_mouseDown(sender As Object, e As EventArgs) Handles shut.MouseDown
        Try
            shut.Image = Image.FromFile(Application.StartupPath & "\SystemImg\" & Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("closeNotHover", "md5") & ".png")
        Catch ex As Exception
            MsgBox("程序部分文件缺失，请重新安装解决！")
        End Try
    End Sub
    Private Sub shut_mouseUp(sender As Object, e As EventArgs) Handles shut.MouseUp
        Try
            shut.Image = Image.FromFile(Application.StartupPath & "\SystemImg\" & Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("close", "md5") & ".png")
        Catch ex As Exception
            MsgBox("程序部分文件缺失，请尝试重新安装解决！")
            End
        End Try
    End Sub

    Private Sub Yes_MouseDown(sender As Object, e As EventArgs) Handles yes.MouseDown
        yes.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub Yes_mouseup(sender As Object, e As EventArgs) Handles yes.MouseUp
        yes.BackColor = Color.FromArgb(&HFF0099CB)
    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As EventArgs) Handles Cancel.MouseDown
        Cancel.BackColor = Color.FromArgb(&HFF006699)
    End Sub
    Private Sub Cancel_mouseup(sender As Object, e As EventArgs) Handles Cancel.MouseUp
        Cancel.BackColor = Color.FromArgb(&HFF0099CB)
    End Sub
    Private Sub Cancel_click(sender As Object, e As EventArgs) Handles Cancel.Click
        SureOrCancel = False
        Me.Hide()
    End Sub

    Private Sub enterKeyDown(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            yes.BackColor = Color.FromArgb(&HFF006699)
            SureOrCancel = True
            Me.Hide()
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            Cancel.BackColor = Color.FromArgb(&HFF006699)
            SureOrCancel = False
            Me.Hide()
        End If
    End Sub

    Private Sub shut_click() Handles shut.Click
        Me.Hide()
    End Sub

    Private Sub yes_click() Handles yes.Click
        SureOrCancel = True
        Me.Hide()
    End Sub
End Class