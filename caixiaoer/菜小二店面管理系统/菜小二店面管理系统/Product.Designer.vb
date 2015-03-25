<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.backGround = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductNameS = New System.Windows.Forms.Label()
        Me.ProductPrice = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backGround
        '
        Me.backGround.Location = New System.Drawing.Point(1, 1)
        Me.backGround.Margin = New System.Windows.Forms.Padding(0)
        Me.backGround.Name = "backGround"
        Me.backGround.Size = New System.Drawing.Size(228, 73)
        Me.backGround.TabIndex = 0
        '
        'picBack
        '
        Me.picBack.Location = New System.Drawing.Point(6, 6)
        Me.picBack.Margin = New System.Windows.Forms.Padding(0)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(90, 63)
        Me.picBack.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ProductNameS
        '
        Me.ProductNameS.Location = New System.Drawing.Point(103, 8)
        Me.ProductNameS.Margin = New System.Windows.Forms.Padding(0)
        Me.ProductNameS.Name = "ProductNameS"
        Me.ProductNameS.Size = New System.Drawing.Size(100, 25)
        Me.ProductNameS.TabIndex = 3
        Me.ProductNameS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProductPrice
        '
        Me.ProductPrice.Location = New System.Drawing.Point(130, 50)
        Me.ProductPrice.Name = "ProductPrice"
        Me.ProductPrice.Size = New System.Drawing.Size(100, 20)
        Me.ProductPrice.TabIndex = 4
        Me.ProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ProductPrice)
        Me.Controls.Add(Me.ProductNameS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.backGround)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Product"
        Me.Size = New System.Drawing.Size(230, 75)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backGround As System.Windows.Forms.Label
    Friend WithEvents picBack As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProductNameS As System.Windows.Forms.Label
    Friend WithEvents ProductPrice As System.Windows.Forms.Label

End Class
