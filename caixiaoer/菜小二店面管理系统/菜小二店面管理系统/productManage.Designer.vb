<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productManage))
        Me.NowTimeUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.NowTime = New System.Windows.Forms.Label()
        Me.OpenFilepic = New System.Windows.Forms.OpenFileDialog()
        Me.back = New System.Windows.Forms.PictureBox()
        Me.head = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Label()
        Me.searchback = New System.Windows.Forms.Label()
        Me.allProduct = New System.Windows.Forms.Label()
        Me.AddProduct = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.PictureBox()
        Me.search = New System.Windows.Forms.Label()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.AddProduct_line = New System.Windows.Forms.Label()
        Me.backGround = New System.Windows.Forms.Label()
        Me.AddClose = New System.Windows.Forms.PictureBox()
        Me.AddPP = New System.Windows.Forms.Label()
        Me.ProductNames = New System.Windows.Forms.Label()
        Me.ProductNameInput = New System.Windows.Forms.TextBox()
        Me.ProductType = New System.Windows.Forms.Label()
        Me.ProductTypelist = New System.Windows.Forms.ComboBox()
        Me.productID = New System.Windows.Forms.Label()
        Me.ProductIDP = New System.Windows.Forms.Label()
        Me.productStandard = New System.Windows.Forms.Label()
        Me.productS_IO = New System.Windows.Forms.TextBox()
        Me.product_price = New System.Windows.Forms.Label()
        Me.price_Input = New System.Windows.Forms.TextBox()
        Me.productNum = New System.Windows.Forms.Label()
        Me.productNum_i = New System.Windows.Forms.TextBox()
        Me.productMaterial = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.PictureBox()
        Me.Addmaterial = New System.Windows.Forms.ComboBox()
        Me.AddedM = New System.Windows.Forms.ComboBox()
        Me.heft_I = New System.Windows.Forms.TextBox()
        Me.g_p = New System.Windows.Forms.Label()
        Me.cutMaterial = New System.Windows.Forms.PictureBox()
        Me.uploadPic = New System.Windows.Forms.Label()
        Me.productPic = New System.Windows.Forms.PictureBox()
        Me.scanPic = New System.Windows.Forms.Label()
        Me.upload = New System.Windows.Forms.Label()
        Me.productCode = New System.Windows.Forms.Label()
        Me.Code_line = New System.Windows.Forms.Label()
        Me.productCodeP = New System.Windows.Forms.PictureBox()
        Me.code_line1 = New System.Windows.Forms.Label()
        Me.createCode = New System.Windows.Forms.Label()
        Me.product = New System.Windows.Forms.Label()
        Me.PageUP1 = New System.Windows.Forms.Label()
        Me.pageDown1 = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picture = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sallCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.surplus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.specification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridView()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cutMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productCodeP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NowTimeUpdater
        '
        Me.NowTimeUpdater.Interval = 60000
        '
        'NowTime
        '
        Me.NowTime.Location = New System.Drawing.Point(316, 13)
        Me.NowTime.Name = "NowTime"
        Me.NowTime.Size = New System.Drawing.Size(0, 12)
        Me.NowTime.TabIndex = 3
        Me.NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenFilepic
        '
        Me.OpenFilepic.FileName = "OpenFile"
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(0, 0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(0, 0)
        Me.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back.TabIndex = 0
        Me.back.TabStop = False
        '
        'head
        '
        Me.head.Location = New System.Drawing.Point(0, 0)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(0, 0)
        Me.head.TabIndex = 1
        Me.head.Text = "产品管理"
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
        'searchback
        '
        Me.searchback.Location = New System.Drawing.Point(0, 0)
        Me.searchback.Name = "searchback"
        Me.searchback.Size = New System.Drawing.Size(0, 0)
        Me.searchback.TabIndex = 6
        '
        'allProduct
        '
        Me.allProduct.Location = New System.Drawing.Point(0, 0)
        Me.allProduct.Name = "allProduct"
        Me.allProduct.Size = New System.Drawing.Size(0, 0)
        Me.allProduct.TabIndex = 4
        Me.allProduct.Text = "全部商品"
        Me.allProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddProduct
        '
        Me.AddProduct.Location = New System.Drawing.Point(0, 0)
        Me.AddProduct.Name = "AddProduct"
        Me.AddProduct.Size = New System.Drawing.Size(0, 0)
        Me.AddProduct.TabIndex = 5
        Me.AddProduct.Text = "添加商品"
        Me.AddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(0, 0)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(0, 0)
        Me.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.searchButton.TabIndex = 7
        Me.searchButton.TabStop = False
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(0, 0)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(0, 0)
        Me.search.TabIndex = 8
        Me.search.Text = "搜索"
        Me.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchInput
        '
        Me.searchInput.Location = New System.Drawing.Point(0, 0)
        Me.searchInput.Margin = New System.Windows.Forms.Padding(0)
        Me.searchInput.Name = "searchInput"
        Me.searchInput.Size = New System.Drawing.Size(0, 21)
        Me.searchInput.TabIndex = 9
        '
        'AddProduct_line
        '
        Me.AddProduct_line.Location = New System.Drawing.Point(0, 0)
        Me.AddProduct_line.Name = "AddProduct_line"
        Me.AddProduct_line.Size = New System.Drawing.Size(0, 0)
        Me.AddProduct_line.TabIndex = 10
        '
        'backGround
        '
        Me.backGround.Location = New System.Drawing.Point(0, 0)
        Me.backGround.Name = "backGround"
        Me.backGround.Size = New System.Drawing.Size(0, 0)
        Me.backGround.TabIndex = 11
        '
        'AddClose
        '
        Me.AddClose.Location = New System.Drawing.Point(0, 0)
        Me.AddClose.Margin = New System.Windows.Forms.Padding(0)
        Me.AddClose.Name = "AddClose"
        Me.AddClose.Size = New System.Drawing.Size(0, 0)
        Me.AddClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AddClose.TabIndex = 12
        Me.AddClose.TabStop = False
        '
        'AddPP
        '
        Me.AddPP.Location = New System.Drawing.Point(0, 0)
        Me.AddPP.Name = "AddPP"
        Me.AddPP.Size = New System.Drawing.Size(0, 0)
        Me.AddPP.TabIndex = 13
        Me.AddPP.Text = "新增产品"
        Me.AddPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductNames
        '
        Me.ProductNames.Location = New System.Drawing.Point(0, 0)
        Me.ProductNames.Name = "ProductNames"
        Me.ProductNames.Size = New System.Drawing.Size(0, 0)
        Me.ProductNames.TabIndex = 14
        Me.ProductNames.Text = "产品名称："
        Me.ProductNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductNameInput
        '
        Me.ProductNameInput.Location = New System.Drawing.Point(0, 0)
        Me.ProductNameInput.Name = "ProductNameInput"
        Me.ProductNameInput.Size = New System.Drawing.Size(0, 21)
        Me.ProductNameInput.TabIndex = 15
        '
        'ProductType
        '
        Me.ProductType.Location = New System.Drawing.Point(0, 0)
        Me.ProductType.Name = "ProductType"
        Me.ProductType.Size = New System.Drawing.Size(0, 0)
        Me.ProductType.TabIndex = 16
        Me.ProductType.Text = "产品类型："
        Me.ProductType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductTypelist
        '
        Me.ProductTypelist.FormattingEnabled = True
        Me.ProductTypelist.Location = New System.Drawing.Point(0, 0)
        Me.ProductTypelist.Name = "ProductTypelist"
        Me.ProductTypelist.Size = New System.Drawing.Size(0, 20)
        Me.ProductTypelist.TabIndex = 17
        '
        'productID
        '
        Me.productID.Location = New System.Drawing.Point(0, 0)
        Me.productID.Name = "productID"
        Me.productID.Size = New System.Drawing.Size(0, 0)
        Me.productID.TabIndex = 18
        Me.productID.Text = "产品编号："
        Me.productID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductIDP
        '
        Me.ProductIDP.Location = New System.Drawing.Point(0, 0)
        Me.ProductIDP.Name = "ProductIDP"
        Me.ProductIDP.Size = New System.Drawing.Size(0, 0)
        Me.ProductIDP.TabIndex = 19
        '
        'productStandard
        '
        Me.productStandard.Location = New System.Drawing.Point(0, 0)
        Me.productStandard.Name = "productStandard"
        Me.productStandard.Size = New System.Drawing.Size(0, 0)
        Me.productStandard.TabIndex = 20
        Me.productStandard.Text = "产品规格："
        '
        'productS_IO
        '
        Me.productS_IO.Location = New System.Drawing.Point(0, 0)
        Me.productS_IO.Name = "productS_IO"
        Me.productS_IO.Size = New System.Drawing.Size(0, 21)
        Me.productS_IO.TabIndex = 21
        '
        'product_price
        '
        Me.product_price.Location = New System.Drawing.Point(0, 0)
        Me.product_price.Name = "product_price"
        Me.product_price.Size = New System.Drawing.Size(0, 0)
        Me.product_price.TabIndex = 22
        Me.product_price.Text = "产品单价："
        Me.product_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'price_Input
        '
        Me.price_Input.Location = New System.Drawing.Point(0, 0)
        Me.price_Input.Name = "price_Input"
        Me.price_Input.Size = New System.Drawing.Size(0, 21)
        Me.price_Input.TabIndex = 23
        '
        'productNum
        '
        Me.productNum.Location = New System.Drawing.Point(0, 0)
        Me.productNum.Name = "productNum"
        Me.productNum.Size = New System.Drawing.Size(0, 0)
        Me.productNum.TabIndex = 24
        Me.productNum.Text = "产品数量："
        Me.productNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productNum_i
        '
        Me.productNum_i.Location = New System.Drawing.Point(0, 0)
        Me.productNum_i.Name = "productNum_i"
        Me.productNum_i.Size = New System.Drawing.Size(0, 21)
        Me.productNum_i.TabIndex = 25
        '
        'productMaterial
        '
        Me.productMaterial.Location = New System.Drawing.Point(0, 0)
        Me.productMaterial.Name = "productMaterial"
        Me.productMaterial.Size = New System.Drawing.Size(0, 0)
        Me.productMaterial.TabIndex = 26
        Me.productMaterial.Text = "产品原料："
        Me.productMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(0, 0)
        Me.Add.Margin = New System.Windows.Forms.Padding(0)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(0, 0)
        Me.Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Add.TabIndex = 27
        Me.Add.TabStop = False
        '
        'Addmaterial
        '
        Me.Addmaterial.FormattingEnabled = True
        Me.Addmaterial.Location = New System.Drawing.Point(0, 0)
        Me.Addmaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.Addmaterial.Name = "Addmaterial"
        Me.Addmaterial.Size = New System.Drawing.Size(0, 20)
        Me.Addmaterial.TabIndex = 28
        '
        'AddedM
        '
        Me.AddedM.FormattingEnabled = True
        Me.AddedM.Location = New System.Drawing.Point(0, 0)
        Me.AddedM.Name = "AddedM"
        Me.AddedM.Size = New System.Drawing.Size(0, 20)
        Me.AddedM.TabIndex = 29
        '
        'heft_I
        '
        Me.heft_I.Location = New System.Drawing.Point(0, 0)
        Me.heft_I.Name = "heft_I"
        Me.heft_I.Size = New System.Drawing.Size(0, 21)
        Me.heft_I.TabIndex = 31
        '
        'g_p
        '
        Me.g_p.Location = New System.Drawing.Point(0, 0)
        Me.g_p.Name = "g_p"
        Me.g_p.Size = New System.Drawing.Size(0, 0)
        Me.g_p.TabIndex = 32
        Me.g_p.Text = "g"
        Me.g_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cutMaterial
        '
        Me.cutMaterial.Location = New System.Drawing.Point(0, 0)
        Me.cutMaterial.Name = "cutMaterial"
        Me.cutMaterial.Size = New System.Drawing.Size(0, 0)
        Me.cutMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cutMaterial.TabIndex = 33
        Me.cutMaterial.TabStop = False
        '
        'uploadPic
        '
        Me.uploadPic.Location = New System.Drawing.Point(0, 0)
        Me.uploadPic.Name = "uploadPic"
        Me.uploadPic.Size = New System.Drawing.Size(0, 0)
        Me.uploadPic.TabIndex = 34
        Me.uploadPic.Text = "上传图片："
        Me.uploadPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productPic
        '
        Me.productPic.Location = New System.Drawing.Point(0, 0)
        Me.productPic.Name = "productPic"
        Me.productPic.Size = New System.Drawing.Size(0, 0)
        Me.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productPic.TabIndex = 36
        Me.productPic.TabStop = False
        '
        'scanPic
        '
        Me.scanPic.Location = New System.Drawing.Point(0, 0)
        Me.scanPic.Name = "scanPic"
        Me.scanPic.Size = New System.Drawing.Size(0, 0)
        Me.scanPic.TabIndex = 37
        Me.scanPic.Text = "浏览"
        Me.scanPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'upload
        '
        Me.upload.Location = New System.Drawing.Point(0, 0)
        Me.upload.Name = "upload"
        Me.upload.Size = New System.Drawing.Size(0, 0)
        Me.upload.TabIndex = 38
        Me.upload.Text = "上传"
        Me.upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productCode
        '
        Me.productCode.Location = New System.Drawing.Point(0, 0)
        Me.productCode.Name = "productCode"
        Me.productCode.Size = New System.Drawing.Size(0, 0)
        Me.productCode.TabIndex = 39
        Me.productCode.Text = "二维码："
        Me.productCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Code_line
        '
        Me.Code_line.Location = New System.Drawing.Point(0, 0)
        Me.Code_line.Name = "Code_line"
        Me.Code_line.Size = New System.Drawing.Size(0, 0)
        Me.Code_line.TabIndex = 41
        '
        'productCodeP
        '
        Me.productCodeP.Location = New System.Drawing.Point(0, 0)
        Me.productCodeP.Name = "productCodeP"
        Me.productCodeP.Size = New System.Drawing.Size(0, 0)
        Me.productCodeP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.productCodeP.TabIndex = 40
        Me.productCodeP.TabStop = False
        '
        'code_line1
        '
        Me.code_line1.Location = New System.Drawing.Point(0, 0)
        Me.code_line1.Name = "code_line1"
        Me.code_line1.Size = New System.Drawing.Size(0, 0)
        Me.code_line1.TabIndex = 42
        '
        'createCode
        '
        Me.createCode.Location = New System.Drawing.Point(0, 0)
        Me.createCode.Name = "createCode"
        Me.createCode.Size = New System.Drawing.Size(0, 0)
        Me.createCode.TabIndex = 43
        Me.createCode.Text = "点击生成二维码"
        Me.createCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'product
        '
        Me.product.Location = New System.Drawing.Point(0, 0)
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(0, 0)
        Me.product.TabIndex = 44
        Me.product.Text = "添加商品"
        Me.product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PageUP1
        '
        Me.PageUP1.Location = New System.Drawing.Point(0, 0)
        Me.PageUP1.Margin = New System.Windows.Forms.Padding(0)
        Me.PageUP1.Name = "PageUP1"
        Me.PageUP1.Size = New System.Drawing.Size(0, 0)
        Me.PageUP1.TabIndex = 46
        Me.PageUP1.Text = "上一页"
        Me.PageUP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pageDown1
        '
        Me.pageDown1.Location = New System.Drawing.Point(0, 0)
        Me.pageDown1.Margin = New System.Windows.Forms.Padding(0)
        Me.pageDown1.Name = "pageDown1"
        Me.pageDown1.Size = New System.Drawing.Size(0, 0)
        Me.pageDown1.TabIndex = 47
        Me.pageDown1.Text = "下一页"
        Me.pageDown1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'delete
        '
        Me.delete.HeaderText = "操作"
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        '
        'operation
        '
        Me.operation.HeaderText = "操作"
        Me.operation.Name = "operation"
        Me.operation.ReadOnly = True
        Me.operation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'material
        '
        Me.material.HeaderText = "单位原料"
        Me.material.MinimumWidth = 10
        Me.material.Name = "material"
        Me.material.ReadOnly = True
        '
        'picture
        '
        Me.picture.HeaderText = "图片"
        Me.picture.MinimumWidth = 10
        Me.picture.Name = "picture"
        Me.picture.ReadOnly = True
        Me.picture.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.picture.Text = "查看图片"
        Me.picture.ToolTipText = "查看图片"
        '
        'Type
        '
        Me.Type.HeaderText = "类型"
        Me.Type.MinimumWidth = 10
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'sallCount
        '
        Me.sallCount.HeaderText = "销售量（份）"
        Me.sallCount.MinimumWidth = 10
        Me.sallCount.Name = "sallCount"
        Me.sallCount.ReadOnly = True
        '
        'surplus
        '
        Me.surplus.HeaderText = "库存（份）"
        Me.surplus.MinimumWidth = 10
        Me.surplus.Name = "surplus"
        Me.surplus.ReadOnly = True
        '
        'specification
        '
        Me.specification.HeaderText = "规格（g）"
        Me.specification.MinimumWidth = 10
        Me.specification.Name = "specification"
        Me.specification.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "单价"
        Me.price.MinimumWidth = 10
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'Product_name
        '
        Me.Product_name.HeaderText = "名称"
        Me.Product_name.MinimumWidth = 10
        Me.Product_name.Name = "Product_name"
        Me.Product_name.ReadOnly = True
        '
        'product_id
        '
        Me.product_id.HeaderText = "编号"
        Me.product_id.MinimumWidth = 10
        Me.product_id.Name = "product_id"
        Me.product_id.ReadOnly = True
        '
        'Data
        '
        Me.Data.AllowUserToAddRows = False
        Me.Data.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Data.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Data.BackgroundColor = System.Drawing.Color.White
        Me.Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product_id, Me.Product_name, Me.price, Me.specification, Me.surplus, Me.sallCount, Me.Type, Me.picture, Me.material, Me.operation, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Data.DefaultCellStyle = DataGridViewCellStyle3
        Me.Data.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.Data.Location = New System.Drawing.Point(0, 0)
        Me.Data.Margin = New System.Windows.Forms.Padding(0)
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Data.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Data.RowTemplate.Height = 23
        Me.Data.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Data.Size = New System.Drawing.Size(0, 0)
        Me.Data.TabIndex = 45
        '
        'productManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(131, 98)
        Me.Controls.Add(Me.pageDown1)
        Me.Controls.Add(Me.PageUP1)
        Me.Controls.Add(Me.product)
        Me.Controls.Add(Me.createCode)
        Me.Controls.Add(Me.code_line1)
        Me.Controls.Add(Me.productCodeP)
        Me.Controls.Add(Me.Code_line)
        Me.Controls.Add(Me.productCode)
        Me.Controls.Add(Me.upload)
        Me.Controls.Add(Me.scanPic)
        Me.Controls.Add(Me.productPic)
        Me.Controls.Add(Me.uploadPic)
        Me.Controls.Add(Me.cutMaterial)
        Me.Controls.Add(Me.g_p)
        Me.Controls.Add(Me.heft_I)
        Me.Controls.Add(Me.AddedM)
        Me.Controls.Add(Me.Addmaterial)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.productMaterial)
        Me.Controls.Add(Me.productNum_i)
        Me.Controls.Add(Me.productNum)
        Me.Controls.Add(Me.price_Input)
        Me.Controls.Add(Me.product_price)
        Me.Controls.Add(Me.productS_IO)
        Me.Controls.Add(Me.productStandard)
        Me.Controls.Add(Me.ProductIDP)
        Me.Controls.Add(Me.productID)
        Me.Controls.Add(Me.ProductTypelist)
        Me.Controls.Add(Me.ProductType)
        Me.Controls.Add(Me.ProductNameInput)
        Me.Controls.Add(Me.ProductNames)
        Me.Controls.Add(Me.AddPP)
        Me.Controls.Add(Me.AddClose)
        Me.Controls.Add(Me.backGround)
        Me.Controls.Add(Me.AddProduct_line)
        Me.Controls.Add(Me.searchInput)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.AddProduct)
        Me.Controls.Add(Me.allProduct)
        Me.Controls.Add(Me.searchback)
        Me.Controls.Add(Me.NowTime)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Data)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "productManage"
        Me.Text = "productManage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cutMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productCodeP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NowTimeUpdater As System.Windows.Forms.Timer
    Friend WithEvents NowTime As System.Windows.Forms.Label
    Friend WithEvents OpenFilepic As System.Windows.Forms.OpenFileDialog
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents admin As System.Windows.Forms.Label
    Friend WithEvents searchback As System.Windows.Forms.Label
    Friend WithEvents allProduct As System.Windows.Forms.Label
    Friend WithEvents AddProduct As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.PictureBox
    Friend WithEvents search As System.Windows.Forms.Label
    Friend WithEvents searchInput As System.Windows.Forms.TextBox
    Friend WithEvents AddProduct_line As System.Windows.Forms.Label
    Friend WithEvents backGround As System.Windows.Forms.Label
    Friend WithEvents AddClose As System.Windows.Forms.PictureBox
    Friend WithEvents AddPP As System.Windows.Forms.Label
    Friend WithEvents ProductNames As System.Windows.Forms.Label
    Friend WithEvents ProductNameInput As System.Windows.Forms.TextBox
    Friend WithEvents ProductType As System.Windows.Forms.Label
    Friend WithEvents ProductTypelist As System.Windows.Forms.ComboBox
    Friend WithEvents productID As System.Windows.Forms.Label
    Friend WithEvents ProductIDP As System.Windows.Forms.Label
    Friend WithEvents productStandard As System.Windows.Forms.Label
    Friend WithEvents productS_IO As System.Windows.Forms.TextBox
    Friend WithEvents product_price As System.Windows.Forms.Label
    Friend WithEvents price_Input As System.Windows.Forms.TextBox
    Friend WithEvents productNum As System.Windows.Forms.Label
    Friend WithEvents productNum_i As System.Windows.Forms.TextBox
    Friend WithEvents productMaterial As System.Windows.Forms.Label
    Friend WithEvents Add As System.Windows.Forms.PictureBox
    Friend WithEvents Addmaterial As System.Windows.Forms.ComboBox
    Friend WithEvents AddedM As System.Windows.Forms.ComboBox
    Friend WithEvents heft_I As System.Windows.Forms.TextBox
    Friend WithEvents g_p As System.Windows.Forms.Label
    Friend WithEvents cutMaterial As System.Windows.Forms.PictureBox
    Friend WithEvents uploadPic As System.Windows.Forms.Label
    Friend WithEvents productPic As System.Windows.Forms.PictureBox
    Friend WithEvents scanPic As System.Windows.Forms.Label
    Friend WithEvents upload As System.Windows.Forms.Label
    Friend WithEvents productCode As System.Windows.Forms.Label
    Friend WithEvents Code_line As System.Windows.Forms.Label
    Friend WithEvents productCodeP As System.Windows.Forms.PictureBox
    Friend WithEvents code_line1 As System.Windows.Forms.Label
    Friend WithEvents createCode As System.Windows.Forms.Label
    Friend WithEvents product As System.Windows.Forms.Label
    Friend WithEvents PageUP1 As System.Windows.Forms.Label
    Friend WithEvents pageDown1 As System.Windows.Forms.Label
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents picture As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sallCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents surplus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents specification As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents product_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data As System.Windows.Forms.DataGridView
End Class
