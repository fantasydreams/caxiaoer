Public Class Product

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(&HFFD6E8EC)
        Dim Product_R As Double = login.CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 8, 8)
        login.SetWindowRgn(Me.Handle, Product_R, True)
        '背景的边缘圆滑处理
        backGround.BackColor = Color.White
        index.SetLableWin(backGround, 8)
        '图片背景
        picBack.BackColor = Me.BackColor
        index.SetLableWin(picBack, 8)
        ProductNameS.BackColor = Color.White
        ProductPrice.BackColor = Color.White
    End Sub
End Class
