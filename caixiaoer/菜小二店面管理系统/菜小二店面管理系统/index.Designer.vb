<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Me.CollectionWin = New System.Windows.Forms.Label()
        Me.productManagement = New System.Windows.Forms.Label()
        Me.Money_to_the_cashier = New System.Windows.Forms.Label()
        Me.Raw_materials_cashier = New System.Windows.Forms.Label()
        Me.user_info = New System.Windows.Forms.Label()
        Me.Order_info = New System.Windows.Forms.Label()
        Me.Message_sys = New System.Windows.Forms.Label()
        Me.other = New System.Windows.Forms.Label()
        Me.index_close = New System.Windows.Forms.PictureBox()
        Me.purchase_pic = New System.Windows.Forms.PictureBox()
        Me.Product_P = New System.Windows.Forms.PictureBox()
        Me.Money = New System.Windows.Forms.PictureBox()
        Me.matrial_p = New System.Windows.Forms.PictureBox()
        Me.User_P = New System.Windows.Forms.PictureBox()
        Me.OrderP = New System.Windows.Forms.PictureBox()
        Me.MessageP = New System.Windows.Forms.PictureBox()
        Me.OtherP = New System.Windows.Forms.PictureBox()
        Me.head_Word = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.WMP = New AxWMPLib.AxWindowsMediaPlayer()
        Me.UpdataOrder = New System.Windows.Forms.Timer(Me.components)
        Me.checksynch_status = New System.Windows.Forms.Timer(Me.components)
        CType(Me.index_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.purchase_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Money, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.matrial_p, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessageP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CollectionWin
        '
        Me.CollectionWin.Location = New System.Drawing.Point(0, 0)
        Me.CollectionWin.Name = "CollectionWin"
        Me.CollectionWin.Size = New System.Drawing.Size(0, 0)
        Me.CollectionWin.TabIndex = 0
        Me.CollectionWin.Text = "收银"
        Me.CollectionWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productManagement
        '
        Me.productManagement.Location = New System.Drawing.Point(0, 0)
        Me.productManagement.Margin = New System.Windows.Forms.Padding(0)
        Me.productManagement.Name = "productManagement"
        Me.productManagement.Size = New System.Drawing.Size(0, 0)
        Me.productManagement.TabIndex = 1
        Me.productManagement.Text = "产品管理"
        Me.productManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Money_to_the_cashier
        '
        Me.Money_to_the_cashier.Location = New System.Drawing.Point(0, 0)
        Me.Money_to_the_cashier.Margin = New System.Windows.Forms.Padding(0)
        Me.Money_to_the_cashier.Name = "Money_to_the_cashier"
        Me.Money_to_the_cashier.Size = New System.Drawing.Size(0, 0)
        Me.Money_to_the_cashier.TabIndex = 2
        Me.Money_to_the_cashier.Text = "资金出纳"
        Me.Money_to_the_cashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Raw_materials_cashier
        '
        Me.Raw_materials_cashier.Location = New System.Drawing.Point(0, 0)
        Me.Raw_materials_cashier.Margin = New System.Windows.Forms.Padding(0)
        Me.Raw_materials_cashier.Name = "Raw_materials_cashier"
        Me.Raw_materials_cashier.Size = New System.Drawing.Size(0, 0)
        Me.Raw_materials_cashier.TabIndex = 3
        Me.Raw_materials_cashier.Text = "原材料出纳"
        Me.Raw_materials_cashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_info
        '
        Me.user_info.Location = New System.Drawing.Point(0, 0)
        Me.user_info.Margin = New System.Windows.Forms.Padding(0)
        Me.user_info.Name = "user_info"
        Me.user_info.Size = New System.Drawing.Size(0, 0)
        Me.user_info.TabIndex = 4
        Me.user_info.Text = "用户信息"
        Me.user_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Order_info
        '
        Me.Order_info.Location = New System.Drawing.Point(0, 0)
        Me.Order_info.Margin = New System.Windows.Forms.Padding(0)
        Me.Order_info.Name = "Order_info"
        Me.Order_info.Size = New System.Drawing.Size(0, 0)
        Me.Order_info.TabIndex = 5
        Me.Order_info.Text = "订单信息"
        Me.Order_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Message_sys
        '
        Me.Message_sys.Location = New System.Drawing.Point(0, 0)
        Me.Message_sys.Margin = New System.Windows.Forms.Padding(0)
        Me.Message_sys.Name = "Message_sys"
        Me.Message_sys.Size = New System.Drawing.Size(0, 0)
        Me.Message_sys.TabIndex = 6
        Me.Message_sys.Text = "消息系统"
        Me.Message_sys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'other
        '
        Me.other.Location = New System.Drawing.Point(0, 0)
        Me.other.Margin = New System.Windows.Forms.Padding(0)
        Me.other.Name = "other"
        Me.other.Size = New System.Drawing.Size(0, 0)
        Me.other.TabIndex = 7
        Me.other.Text = "其他"
        Me.other.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'index_close
        '
        Me.index_close.Location = New System.Drawing.Point(0, 0)
        Me.index_close.Margin = New System.Windows.Forms.Padding(0)
        Me.index_close.Name = "index_close"
        Me.index_close.Size = New System.Drawing.Size(0, 0)
        Me.index_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.index_close.TabIndex = 8
        Me.index_close.TabStop = False
        '
        'purchase_pic
        '
        Me.purchase_pic.Location = New System.Drawing.Point(0, 0)
        Me.purchase_pic.Margin = New System.Windows.Forms.Padding(0)
        Me.purchase_pic.Name = "purchase_pic"
        Me.purchase_pic.Size = New System.Drawing.Size(0, 0)
        Me.purchase_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.purchase_pic.TabIndex = 9
        Me.purchase_pic.TabStop = False
        '
        'Product_P
        '
        Me.Product_P.Location = New System.Drawing.Point(0, 0)
        Me.Product_P.Margin = New System.Windows.Forms.Padding(0)
        Me.Product_P.Name = "Product_P"
        Me.Product_P.Size = New System.Drawing.Size(0, 0)
        Me.Product_P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Product_P.TabIndex = 10
        Me.Product_P.TabStop = False
        '
        'Money
        '
        Me.Money.Location = New System.Drawing.Point(0, 0)
        Me.Money.Margin = New System.Windows.Forms.Padding(0)
        Me.Money.Name = "Money"
        Me.Money.Size = New System.Drawing.Size(0, 0)
        Me.Money.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Money.TabIndex = 11
        Me.Money.TabStop = False
        '
        'matrial_p
        '
        Me.matrial_p.Location = New System.Drawing.Point(0, 0)
        Me.matrial_p.Margin = New System.Windows.Forms.Padding(0)
        Me.matrial_p.Name = "matrial_p"
        Me.matrial_p.Size = New System.Drawing.Size(0, 0)
        Me.matrial_p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.matrial_p.TabIndex = 12
        Me.matrial_p.TabStop = False
        '
        'User_P
        '
        Me.User_P.Location = New System.Drawing.Point(0, 0)
        Me.User_P.Margin = New System.Windows.Forms.Padding(0)
        Me.User_P.Name = "User_P"
        Me.User_P.Size = New System.Drawing.Size(0, 0)
        Me.User_P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.User_P.TabIndex = 13
        Me.User_P.TabStop = False
        '
        'OrderP
        '
        Me.OrderP.Location = New System.Drawing.Point(0, 0)
        Me.OrderP.Margin = New System.Windows.Forms.Padding(0)
        Me.OrderP.Name = "OrderP"
        Me.OrderP.Size = New System.Drawing.Size(0, 0)
        Me.OrderP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OrderP.TabIndex = 14
        Me.OrderP.TabStop = False
        '
        'MessageP
        '
        Me.MessageP.Location = New System.Drawing.Point(0, 0)
        Me.MessageP.Margin = New System.Windows.Forms.Padding(0)
        Me.MessageP.Name = "MessageP"
        Me.MessageP.Size = New System.Drawing.Size(0, 0)
        Me.MessageP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MessageP.TabIndex = 15
        Me.MessageP.TabStop = False
        '
        'OtherP
        '
        Me.OtherP.Location = New System.Drawing.Point(0, 0)
        Me.OtherP.Margin = New System.Windows.Forms.Padding(0)
        Me.OtherP.Name = "OtherP"
        Me.OtherP.Size = New System.Drawing.Size(0, 0)
        Me.OtherP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OtherP.TabIndex = 16
        Me.OtherP.TabStop = False
        '
        'head_Word
        '
        Me.head_Word.Location = New System.Drawing.Point(0, 0)
        Me.head_Word.Margin = New System.Windows.Forms.Padding(0)
        Me.head_Word.Name = "head_Word"
        Me.head_Word.Size = New System.Drawing.Size(0, 0)
        Me.head_Word.TabIndex = 18
        Me.head_Word.Text = "菜小二——收银系统"
        Me.head_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logo
        '
        Me.logo.Location = New System.Drawing.Point(0, 0)
        Me.logo.Margin = New System.Windows.Forms.Padding(0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(0, 0)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 19
        Me.logo.TabStop = False
        '
        'WMP
        '
        Me.WMP.Enabled = True
        Me.WMP.Location = New System.Drawing.Point(0, 0)
        Me.WMP.Margin = New System.Windows.Forms.Padding(0)
        Me.WMP.Name = "WMP"
        Me.WMP.OcxState = CType(resources.GetObject("WMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP.Size = New System.Drawing.Size(0, 0)
        Me.WMP.TabIndex = 20
        Me.WMP.Visible = False
        '
        'UpdataOrder
        '
        Me.UpdataOrder.Enabled = True
        Me.UpdataOrder.Interval = 1000
        '
        'checksynch_status
        '
        Me.checksynch_status.Enabled = True
        Me.checksynch_status.Interval = 600000
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(90, 61)
        Me.Controls.Add(Me.WMP)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.head_Word)
        Me.Controls.Add(Me.OtherP)
        Me.Controls.Add(Me.MessageP)
        Me.Controls.Add(Me.OrderP)
        Me.Controls.Add(Me.User_P)
        Me.Controls.Add(Me.matrial_p)
        Me.Controls.Add(Me.Money)
        Me.Controls.Add(Me.Product_P)
        Me.Controls.Add(Me.purchase_pic)
        Me.Controls.Add(Me.index_close)
        Me.Controls.Add(Me.other)
        Me.Controls.Add(Me.Message_sys)
        Me.Controls.Add(Me.Order_info)
        Me.Controls.Add(Me.user_info)
        Me.Controls.Add(Me.Raw_materials_cashier)
        Me.Controls.Add(Me.Money_to_the_cashier)
        Me.Controls.Add(Me.productManagement)
        Me.Controls.Add(Me.CollectionWin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "index"
        CType(Me.index_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.purchase_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Money, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.matrial_p, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessageP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CollectionWin As System.Windows.Forms.Label
    Friend WithEvents productManagement As System.Windows.Forms.Label
    Friend WithEvents Money_to_the_cashier As System.Windows.Forms.Label
    Friend WithEvents Raw_materials_cashier As System.Windows.Forms.Label
    Friend WithEvents user_info As System.Windows.Forms.Label
    Friend WithEvents Order_info As System.Windows.Forms.Label
    Friend WithEvents Message_sys As System.Windows.Forms.Label
    Friend WithEvents other As System.Windows.Forms.Label
    Friend WithEvents index_close As System.Windows.Forms.PictureBox
    Friend WithEvents purchase_pic As System.Windows.Forms.PictureBox
    Friend WithEvents Product_P As System.Windows.Forms.PictureBox
    Friend WithEvents Money As System.Windows.Forms.PictureBox
    Friend WithEvents matrial_p As System.Windows.Forms.PictureBox
    Friend WithEvents User_P As System.Windows.Forms.PictureBox
    Friend WithEvents OrderP As System.Windows.Forms.PictureBox
    Friend WithEvents MessageP As System.Windows.Forms.PictureBox
    Friend WithEvents OtherP As System.Windows.Forms.PictureBox
    Friend WithEvents head_Word As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents WMP As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents UpdataOrder As System.Windows.Forms.Timer
    Friend WithEvents checksynch_status As System.Windows.Forms.Timer

End Class
