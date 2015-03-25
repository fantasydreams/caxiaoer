Public Class productPicdetail

    Private Sub productPicdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mapload()
    End Sub

    Private Sub Mapload()
        Me.Width = 700 * index.zoomHeight
        Me.Height = 500 * index.zoomHeight
        Me.Left = index.ScreenWidth / 2 - Me.Width / 2
        Me.Top = index.ScreenHeight / 2 - Me.Height / 2
        Me.BackColor = Color.FromArgb(&HFF797979)
        Dim Me_r As Double = login.CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 16, 16)
        login.SetWindowRgn(Me.Handle, Me_r, True)
        '显示图片
        picP.Width = Me.Width - 2
        picP.Height = Me.Height - 2
        picP.Top = 1
        picP.Left = 1
        index.SetPictureBoxWin(picP, 16)
        picP.BackColor = Color.White
        '关闭
        shut.Top = 2
        shut.Width = 42
        shut.Height = 41
        shut.Left = Me.Width - shut.Width - 2
        index.LoadImage(shut, "\SystemImg\", "Picclose")
        shut.BackColor = Color.White
        index.SetPictureBoxWin(shut, 30)
    End Sub

    Private Sub Shur_mouseDown(sender As Object, e As EventArgs) Handles shut.MouseDown
        index.LoadImage(shut, "\SystemImg\", "closeNotHover")
    End Sub

    Private Sub shut_MouseUp(sender As Object, e As MouseEventArgs) Handles shut.MouseUp
        index.LoadImage(shut, "\SystemImg\", "Picclose")
    End Sub

    Private Sub shut_click(sender As Object, e As EventArgs) Handles shut.MouseClick
        Me.Close()
    End Sub
End Class