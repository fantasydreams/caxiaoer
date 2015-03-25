<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderManagment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderManagment))
        Me.back = New System.Windows.Forms.PictureBox()
        Me.head = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Label()
        Me.Nowtime = New System.Windows.Forms.Label()
        Me.searchback = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.PictureBox()
        Me.search = New System.Windows.Forms.Label()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.finish = New System.Windows.Forms.Label()
        Me.unfinished = New System.Windows.Forms.Label()
        Me.allorder = New System.Windows.Forms.Label()
        Me.allorderData = New System.Windows.Forms.DataGridView()
        Me.orderNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allMoney = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receiver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operatorMan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pageDown1 = New System.Windows.Forms.Label()
        Me.pageup1 = New System.Windows.Forms.Label()
        Me.order_detail = New System.Windows.Forms.Panel()
        Me.order_pro_detail = New System.Windows.Forms.DataGridView()
        Me.product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pro_Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Money = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.surplus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purchase_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.content = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receiver_address = New System.Windows.Forms.Label()
        Me.receiver_name = New System.Windows.Forms.Label()
        Me.order_Money = New System.Windows.Forms.Label()
        Me.order_time = New System.Windows.Forms.Label()
        Me.order_status = New System.Windows.Forms.Label()
        Me.order_id = New System.Windows.Forms.Label()
        Me.shut = New System.Windows.Forms.PictureBox()
        Me.panelP = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Print = New System.Windows.Forms.Label()
        Me.loadDbToExcel = New System.Windows.Forms.SaveFileDialog()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allorderData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.order_detail.SuspendLayout()
        CType(Me.order_pro_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(0, 0)
        Me.back.Margin = New System.Windows.Forms.Padding(0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(0, 0)
        Me.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back.TabIndex = 0
        Me.back.TabStop = False
        '
        'head
        '
        Me.head.Location = New System.Drawing.Point(0, 0)
        Me.head.Margin = New System.Windows.Forms.Padding(0)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(0, 0)
        Me.head.TabIndex = 1
        Me.head.Text = "订单管理"
        Me.head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin
        '
        Me.admin.Location = New System.Drawing.Point(0, 0)
        Me.admin.Margin = New System.Windows.Forms.Padding(0)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(0, 0)
        Me.admin.TabIndex = 2
        Me.admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nowtime
        '
        Me.Nowtime.Location = New System.Drawing.Point(0, 0)
        Me.Nowtime.Margin = New System.Windows.Forms.Padding(0)
        Me.Nowtime.Name = "Nowtime"
        Me.Nowtime.Size = New System.Drawing.Size(0, 0)
        Me.Nowtime.TabIndex = 3
        Me.Nowtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'searchback
        '
        Me.searchback.Location = New System.Drawing.Point(0, 0)
        Me.searchback.Margin = New System.Windows.Forms.Padding(0)
        Me.searchback.Name = "searchback"
        Me.searchback.Size = New System.Drawing.Size(0, 0)
        Me.searchback.TabIndex = 4
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(0, 0)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(0)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(0, 0)
        Me.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.searchButton.TabIndex = 5
        Me.searchButton.TabStop = False
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(0, 0)
        Me.search.Margin = New System.Windows.Forms.Padding(0)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(0, 0)
        Me.search.TabIndex = 6
        Me.search.Text = "搜索"
        Me.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchInput
        '
        Me.searchInput.Location = New System.Drawing.Point(0, 0)
        Me.searchInput.Margin = New System.Windows.Forms.Padding(0)
        Me.searchInput.Name = "searchInput"
        Me.searchInput.Size = New System.Drawing.Size(0, 21)
        Me.searchInput.TabIndex = 7
        '
        'finish
        '
        Me.finish.Location = New System.Drawing.Point(0, 0)
        Me.finish.Margin = New System.Windows.Forms.Padding(0)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(0, 0)
        Me.finish.TabIndex = 8
        Me.finish.Text = "已完成"
        Me.finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'unfinished
        '
        Me.unfinished.Location = New System.Drawing.Point(0, 0)
        Me.unfinished.Margin = New System.Windows.Forms.Padding(0)
        Me.unfinished.Name = "unfinished"
        Me.unfinished.Size = New System.Drawing.Size(0, 0)
        Me.unfinished.TabIndex = 9
        Me.unfinished.Text = "未完成"
        Me.unfinished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'allorder
        '
        Me.allorder.Location = New System.Drawing.Point(0, 0)
        Me.allorder.Margin = New System.Windows.Forms.Padding(0)
        Me.allorder.Name = "allorder"
        Me.allorder.Size = New System.Drawing.Size(0, 0)
        Me.allorder.TabIndex = 10
        Me.allorder.Text = "全部订单"
        Me.allorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'allorderData
        '
        Me.allorderData.AllowUserToAddRows = False
        Me.allorderData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.allorderData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.allorderData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.allorderData.BackgroundColor = System.Drawing.Color.White
        Me.allorderData.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.allorderData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.allorderData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderNum, Me.Status, Me.time, Me.allMoney, Me.receiver, Me.telephone, Me.address, Me.operatorMan, Me.detail})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allorderData.DefaultCellStyle = DataGridViewCellStyle3
        Me.allorderData.Location = New System.Drawing.Point(0, 0)
        Me.allorderData.Margin = New System.Windows.Forms.Padding(0)
        Me.allorderData.Name = "allorderData"
        Me.allorderData.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.allorderData.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.allorderData.RowTemplate.Height = 23
        Me.allorderData.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.allorderData.Size = New System.Drawing.Size(0, 0)
        Me.allorderData.TabIndex = 11
        '
        'orderNum
        '
        Me.orderNum.HeaderText = "订单号"
        Me.orderNum.Name = "orderNum"
        Me.orderNum.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "状态"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'time
        '
        Me.time.HeaderText = "下单时间"
        Me.time.Name = "time"
        Me.time.ReadOnly = True
        '
        'allMoney
        '
        Me.allMoney.HeaderText = "总价（￥）"
        Me.allMoney.Name = "allMoney"
        Me.allMoney.ReadOnly = True
        '
        'receiver
        '
        Me.receiver.HeaderText = "收货人"
        Me.receiver.Name = "receiver"
        Me.receiver.ReadOnly = True
        '
        'telephone
        '
        Me.telephone.HeaderText = "电话"
        Me.telephone.Name = "telephone"
        Me.telephone.ReadOnly = True
        '
        'address
        '
        Me.address.HeaderText = "地址"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'operatorMan
        '
        Me.operatorMan.HeaderText = "操作员"
        Me.operatorMan.Name = "operatorMan"
        Me.operatorMan.ReadOnly = True
        '
        'detail
        '
        Me.detail.HeaderText = "操作"
        Me.detail.Name = "detail"
        Me.detail.ReadOnly = True
        '
        'pageDown1
        '
        Me.pageDown1.Location = New System.Drawing.Point(0, 0)
        Me.pageDown1.Margin = New System.Windows.Forms.Padding(0)
        Me.pageDown1.Name = "pageDown1"
        Me.pageDown1.Size = New System.Drawing.Size(0, 0)
        Me.pageDown1.TabIndex = 12
        Me.pageDown1.Text = "下一页"
        Me.pageDown1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pageup1
        '
        Me.pageup1.Location = New System.Drawing.Point(0, 0)
        Me.pageup1.Margin = New System.Windows.Forms.Padding(0)
        Me.pageup1.Name = "pageup1"
        Me.pageup1.Size = New System.Drawing.Size(0, 0)
        Me.pageup1.TabIndex = 13
        Me.pageup1.Text = "上一页"
        Me.pageup1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'order_detail
        '
        Me.order_detail.Controls.Add(Me.order_pro_detail)
        Me.order_detail.Controls.Add(Me.receiver_address)
        Me.order_detail.Controls.Add(Me.receiver_name)
        Me.order_detail.Controls.Add(Me.order_Money)
        Me.order_detail.Controls.Add(Me.order_time)
        Me.order_detail.Controls.Add(Me.order_status)
        Me.order_detail.Controls.Add(Me.order_id)
        Me.order_detail.Controls.Add(Me.shut)
        Me.order_detail.Controls.Add(Me.panelP)
        Me.order_detail.Location = New System.Drawing.Point(0, 0)
        Me.order_detail.Margin = New System.Windows.Forms.Padding(0)
        Me.order_detail.Name = "order_detail"
        Me.order_detail.Size = New System.Drawing.Size(0, 0)
        Me.order_detail.TabIndex = 14
        '
        'order_pro_detail
        '
        Me.order_pro_detail.AllowUserToAddRows = False
        Me.order_pro_detail.AllowUserToDeleteRows = False
        Me.order_pro_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.order_pro_detail.BackgroundColor = System.Drawing.Color.White
        Me.order_pro_detail.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.order_pro_detail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.order_pro_detail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product_id, Me.product_name, Me.type, Me.price, Me.Pro_Num, Me.Money, Me.surplus, Me.purchase_type, Me.content})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.order_pro_detail.DefaultCellStyle = DataGridViewCellStyle6
        Me.order_pro_detail.Location = New System.Drawing.Point(9, 9)
        Me.order_pro_detail.Margin = New System.Windows.Forms.Padding(0)
        Me.order_pro_detail.Name = "order_pro_detail"
        Me.order_pro_detail.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.order_pro_detail.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.order_pro_detail.RowTemplate.Height = 23
        Me.order_pro_detail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.order_pro_detail.Size = New System.Drawing.Size(0, 0)
        Me.order_pro_detail.TabIndex = 18
        '
        'product_id
        '
        Me.product_id.HeaderText = "产品ID"
        Me.product_id.Name = "product_id"
        Me.product_id.ReadOnly = True
        Me.product_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'product_name
        '
        Me.product_name.HeaderText = "产品名称"
        Me.product_name.Name = "product_name"
        Me.product_name.ReadOnly = True
        '
        'type
        '
        Me.type.HeaderText = "规格"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "单价（元）"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'Pro_Num
        '
        Me.Pro_Num.HeaderText = "数量（份）"
        Me.Pro_Num.Name = "Pro_Num"
        Me.Pro_Num.ReadOnly = True
        '
        'Money
        '
        Me.Money.HeaderText = "金额（元）"
        Me.Money.Name = "Money"
        Me.Money.ReadOnly = True
        '
        'surplus
        '
        Me.surplus.HeaderText = "库存"
        Me.surplus.Name = "surplus"
        Me.surplus.ReadOnly = True
        '
        'purchase_type
        '
        Me.purchase_type.HeaderText = "购买途径"
        Me.purchase_type.Name = "purchase_type"
        Me.purchase_type.ReadOnly = True
        '
        'content
        '
        Me.content.HeaderText = "备注"
        Me.content.Name = "content"
        Me.content.ReadOnly = True
        '
        'receiver_address
        '
        Me.receiver_address.Location = New System.Drawing.Point(0, 0)
        Me.receiver_address.Margin = New System.Windows.Forms.Padding(0)
        Me.receiver_address.Name = "receiver_address"
        Me.receiver_address.Size = New System.Drawing.Size(0, 0)
        Me.receiver_address.TabIndex = 15
        Me.receiver_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'receiver_name
        '
        Me.receiver_name.Location = New System.Drawing.Point(0, 0)
        Me.receiver_name.Margin = New System.Windows.Forms.Padding(0)
        Me.receiver_name.Name = "receiver_name"
        Me.receiver_name.Size = New System.Drawing.Size(0, 0)
        Me.receiver_name.TabIndex = 15
        Me.receiver_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'order_Money
        '
        Me.order_Money.Location = New System.Drawing.Point(0, 0)
        Me.order_Money.Margin = New System.Windows.Forms.Padding(0)
        Me.order_Money.Name = "order_Money"
        Me.order_Money.Size = New System.Drawing.Size(0, 0)
        Me.order_Money.TabIndex = 15
        Me.order_Money.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'order_time
        '
        Me.order_time.Location = New System.Drawing.Point(0, 0)
        Me.order_time.Margin = New System.Windows.Forms.Padding(0)
        Me.order_time.Name = "order_time"
        Me.order_time.Size = New System.Drawing.Size(0, 0)
        Me.order_time.TabIndex = 15
        Me.order_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'order_status
        '
        Me.order_status.Location = New System.Drawing.Point(0, 0)
        Me.order_status.Margin = New System.Windows.Forms.Padding(0)
        Me.order_status.Name = "order_status"
        Me.order_status.Size = New System.Drawing.Size(0, 0)
        Me.order_status.TabIndex = 15
        Me.order_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'order_id
        '
        Me.order_id.Location = New System.Drawing.Point(18, 19)
        Me.order_id.Margin = New System.Windows.Forms.Padding(0)
        Me.order_id.Name = "order_id"
        Me.order_id.Size = New System.Drawing.Size(0, 0)
        Me.order_id.TabIndex = 15
        Me.order_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'shut
        '
        Me.shut.Location = New System.Drawing.Point(0, 0)
        Me.shut.Margin = New System.Windows.Forms.Padding(0)
        Me.shut.Name = "shut"
        Me.shut.Size = New System.Drawing.Size(0, 0)
        Me.shut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shut.TabIndex = 17
        Me.shut.TabStop = False
        '
        'panelP
        '
        Me.panelP.Location = New System.Drawing.Point(0, 0)
        Me.panelP.Margin = New System.Windows.Forms.Padding(0)
        Me.panelP.Name = "panelP"
        Me.panelP.Size = New System.Drawing.Size(0, 0)
        Me.panelP.TabIndex = 16
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Print
        '
        Me.Print.Location = New System.Drawing.Point(0, 0)
        Me.Print.Margin = New System.Windows.Forms.Padding(0)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(0, 0)
        Me.Print.TabIndex = 15
        Me.Print.Text = "导出Excel"
        Me.Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(152, 74)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.order_detail)
        Me.Controls.Add(Me.pageup1)
        Me.Controls.Add(Me.pageDown1)
        Me.Controls.Add(Me.allorder)
        Me.Controls.Add(Me.unfinished)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.searchInput)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.searchback)
        Me.Controls.Add(Me.Nowtime)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.allorderData)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrderManagment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "OrderManagment"
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allorderData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.order_detail.ResumeLayout(False)
        CType(Me.order_pro_detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents admin As System.Windows.Forms.Label
    Friend WithEvents Nowtime As System.Windows.Forms.Label
    Friend WithEvents searchback As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.PictureBox
    Friend WithEvents search As System.Windows.Forms.Label
    Friend WithEvents searchInput As System.Windows.Forms.TextBox
    Friend WithEvents finish As System.Windows.Forms.Label
    Friend WithEvents unfinished As System.Windows.Forms.Label
    Friend WithEvents allorder As System.Windows.Forms.Label
    Friend WithEvents allorderData As System.Windows.Forms.DataGridView
    Friend WithEvents pageDown1 As System.Windows.Forms.Label
    Friend WithEvents pageup1 As System.Windows.Forms.Label
    Friend WithEvents orderNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allMoney As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receiver As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operatorMan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents order_detail As System.Windows.Forms.Panel
    Friend WithEvents order_id As System.Windows.Forms.Label
    Friend WithEvents order_status As System.Windows.Forms.Label
    Friend WithEvents panelP As System.Windows.Forms.Label
    Friend WithEvents shut As System.Windows.Forms.PictureBox
    Friend WithEvents order_time As System.Windows.Forms.Label
    Friend WithEvents order_Money As System.Windows.Forms.Label
    Friend WithEvents receiver_name As System.Windows.Forms.Label
    Friend WithEvents receiver_address As System.Windows.Forms.Label
    Friend WithEvents order_pro_detail As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents product_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents product_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pro_Num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Money As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents surplus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents purchase_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents content As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Print As System.Windows.Forms.Label
    Friend WithEvents loadDbToExcel As System.Windows.Forms.SaveFileDialog
End Class
