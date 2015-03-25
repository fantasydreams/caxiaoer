<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class materialManagment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(materialManagment))
        Me.back = New System.Windows.Forms.PictureBox()
        Me.head = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Label()
        Me.Nowtime = New System.Windows.Forms.Label()
        Me.Nowtimeupdater = New System.Windows.Forms.Timer(Me.components)
        Me.materialIAO = New System.Windows.Forms.Label()
        Me.materialB = New System.Windows.Forms.Label()
        Me.createPL = New System.Windows.Forms.Label()
        Me.createP = New System.Windows.Forms.Label()
        Me.materialscanL = New System.Windows.Forms.Label()
        Me.materialSB = New System.Windows.Forms.Label()
        Me.backLine = New System.Windows.Forms.Label()
        Me.chargeBack = New System.Windows.Forms.Label()
        Me.head1 = New System.Windows.Forms.Label()
        Me.materialName = New System.Windows.Forms.Label()
        Me.materialNameI = New System.Windows.Forms.TextBox()
        Me.MaterialPrice = New System.Windows.Forms.Label()
        Me.priceI = New System.Windows.Forms.TextBox()
        Me.price_P = New System.Windows.Forms.Label()
        Me.Num = New System.Windows.Forms.Label()
        Me.NumL = New System.Windows.Forms.Label()
        Me.numP = New System.Windows.Forms.Label()
        Me.workingOperat = New System.Windows.Forms.Label()
        Me.NewMaterialL = New System.Windows.Forms.Label()
        Me.Newmaterialb = New System.Windows.Forms.Label()
        Me.addMaterial = New System.Windows.Forms.Label()
        Me.addMaterialb = New System.Windows.Forms.Label()
        Me.materialLose = New System.Windows.Forms.Label()
        Me.materialloseB = New System.Windows.Forms.Label()
        Me.otherexplain = New System.Windows.Forms.TextBox()
        Me.operateNum = New System.Windows.Forms.Label()
        Me.operateNumI = New System.Windows.Forms.TextBox()
        Me.Yes_backL = New System.Windows.Forms.Label()
        Me.yes = New System.Windows.Forms.Label()
        Me.operateMoney = New System.Windows.Forms.Label()
        Me.kg = New System.Windows.Forms.Label()
        Me.underLine0 = New System.Windows.Forms.Label()
        Me.yuan = New System.Windows.Forms.Label()
        Me.Money_P = New System.Windows.Forms.Label()
        Me.materialsurplus = New System.Windows.Forms.Label()
        Me.underline1 = New System.Windows.Forms.Label()
        Me.materialsP = New System.Windows.Forms.Label()
        Me.kg1 = New System.Windows.Forms.Label()
        Me.productName1 = New System.Windows.Forms.Label()
        Me.productNameI1 = New System.Windows.Forms.TextBox()
        Me.productNum = New System.Windows.Forms.Label()
        Me.productNumPL = New System.Windows.Forms.Label()
        Me.productNumP = New System.Windows.Forms.Label()
        Me.productType = New System.Windows.Forms.Label()
        Me.producttypeI = New System.Windows.Forms.TextBox()
        Me.g = New System.Windows.Forms.Label()
        Me.createNum = New System.Windows.Forms.Label()
        Me.createNumI = New System.Windows.Forms.TextBox()
        Me.materialDeplete = New System.Windows.Forms.Label()
        Me.addImage = New System.Windows.Forms.PictureBox()
        Me.sure_L = New System.Windows.Forms.Label()
        Me.sureb = New System.Windows.Forms.Label()
        Me.warning = New System.Windows.Forms.Label()
        Me.searchBack = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.PictureBox()
        Me.search = New System.Windows.Forms.Label()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.addMaterial1 = New System.Windows.Forms.Label()
        Me.allMaterial = New System.Windows.Forms.Label()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchButton, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.head.Text = "原材料进出"
        Me.head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin
        '
        Me.admin.Location = New System.Drawing.Point(0, 0)
        Me.admin.Margin = New System.Windows.Forms.Padding(0)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(0, 0)
        Me.admin.TabIndex = 2
        Me.admin.Text = "管理员：Luoshengwen"
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
        'Nowtimeupdater
        '
        Me.Nowtimeupdater.Interval = 10000
        '
        'materialIAO
        '
        Me.materialIAO.Location = New System.Drawing.Point(0, 0)
        Me.materialIAO.Margin = New System.Windows.Forms.Padding(0)
        Me.materialIAO.Name = "materialIAO"
        Me.materialIAO.Size = New System.Drawing.Size(0, 0)
        Me.materialIAO.TabIndex = 4
        '
        'materialB
        '
        Me.materialB.Location = New System.Drawing.Point(0, 0)
        Me.materialB.Margin = New System.Windows.Forms.Padding(0)
        Me.materialB.Name = "materialB"
        Me.materialB.Size = New System.Drawing.Size(0, 0)
        Me.materialB.TabIndex = 5
        Me.materialB.Text = "原材料进出"
        Me.materialB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'createPL
        '
        Me.createPL.Location = New System.Drawing.Point(0, 0)
        Me.createPL.Margin = New System.Windows.Forms.Padding(0)
        Me.createPL.Name = "createPL"
        Me.createPL.Size = New System.Drawing.Size(0, 0)
        Me.createPL.TabIndex = 6
        '
        'createP
        '
        Me.createP.Location = New System.Drawing.Point(0, 0)
        Me.createP.Margin = New System.Windows.Forms.Padding(0)
        Me.createP.Name = "createP"
        Me.createP.Size = New System.Drawing.Size(0, 0)
        Me.createP.TabIndex = 7
        Me.createP.Text = "生成产品"
        Me.createP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'materialscanL
        '
        Me.materialscanL.Location = New System.Drawing.Point(0, 0)
        Me.materialscanL.Margin = New System.Windows.Forms.Padding(0)
        Me.materialscanL.Name = "materialscanL"
        Me.materialscanL.Size = New System.Drawing.Size(0, 0)
        Me.materialscanL.TabIndex = 8
        '
        'materialSB
        '
        Me.materialSB.Location = New System.Drawing.Point(0, 0)
        Me.materialSB.Margin = New System.Windows.Forms.Padding(0)
        Me.materialSB.Name = "materialSB"
        Me.materialSB.Size = New System.Drawing.Size(0, 0)
        Me.materialSB.TabIndex = 9
        Me.materialSB.Text = "原材料查询"
        Me.materialSB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'backLine
        '
        Me.backLine.Location = New System.Drawing.Point(0, 0)
        Me.backLine.Margin = New System.Windows.Forms.Padding(0)
        Me.backLine.Name = "backLine"
        Me.backLine.Size = New System.Drawing.Size(0, 0)
        Me.backLine.TabIndex = 10
        '
        'chargeBack
        '
        Me.chargeBack.Location = New System.Drawing.Point(0, 0)
        Me.chargeBack.Margin = New System.Windows.Forms.Padding(0)
        Me.chargeBack.Name = "chargeBack"
        Me.chargeBack.Size = New System.Drawing.Size(0, 0)
        Me.chargeBack.TabIndex = 11
        '
        'head1
        '
        Me.head1.Location = New System.Drawing.Point(0, 0)
        Me.head1.Name = "head1"
        Me.head1.Size = New System.Drawing.Size(0, 0)
        Me.head1.TabIndex = 12
        '
        'materialName
        '
        Me.materialName.Location = New System.Drawing.Point(0, 0)
        Me.materialName.Margin = New System.Windows.Forms.Padding(0)
        Me.materialName.Name = "materialName"
        Me.materialName.Size = New System.Drawing.Size(0, 0)
        Me.materialName.TabIndex = 13
        Me.materialName.Text = "原材料名称："
        Me.materialName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'materialNameI
        '
        Me.materialNameI.Location = New System.Drawing.Point(0, 0)
        Me.materialNameI.Margin = New System.Windows.Forms.Padding(0)
        Me.materialNameI.Name = "materialNameI"
        Me.materialNameI.Size = New System.Drawing.Size(0, 21)
        Me.materialNameI.TabIndex = 14
        '
        'MaterialPrice
        '
        Me.MaterialPrice.Location = New System.Drawing.Point(0, 0)
        Me.MaterialPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialPrice.Name = "MaterialPrice"
        Me.MaterialPrice.Size = New System.Drawing.Size(0, 0)
        Me.MaterialPrice.TabIndex = 15
        Me.MaterialPrice.Text = "单价："
        Me.MaterialPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'priceI
        '
        Me.priceI.Location = New System.Drawing.Point(0, 0)
        Me.priceI.Margin = New System.Windows.Forms.Padding(0)
        Me.priceI.Name = "priceI"
        Me.priceI.Size = New System.Drawing.Size(0, 21)
        Me.priceI.TabIndex = 16
        '
        'price_P
        '
        Me.price_P.Location = New System.Drawing.Point(0, 0)
        Me.price_P.Margin = New System.Windows.Forms.Padding(0)
        Me.price_P.Name = "price_P"
        Me.price_P.Size = New System.Drawing.Size(0, 0)
        Me.price_P.TabIndex = 17
        Me.price_P.Text = "元/kg"
        Me.price_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Num
        '
        Me.Num.Location = New System.Drawing.Point(0, 0)
        Me.Num.Margin = New System.Windows.Forms.Padding(0)
        Me.Num.Name = "Num"
        Me.Num.Size = New System.Drawing.Size(0, 0)
        Me.Num.TabIndex = 18
        Me.Num.Text = "编号："
        Me.Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumL
        '
        Me.NumL.Location = New System.Drawing.Point(0, 0)
        Me.NumL.Margin = New System.Windows.Forms.Padding(0)
        Me.NumL.Name = "NumL"
        Me.NumL.Size = New System.Drawing.Size(0, 0)
        Me.NumL.TabIndex = 19
        '
        'numP
        '
        Me.numP.Location = New System.Drawing.Point(0, 0)
        Me.numP.Margin = New System.Windows.Forms.Padding(0)
        Me.numP.Name = "numP"
        Me.numP.Size = New System.Drawing.Size(0, 0)
        Me.numP.TabIndex = 20
        Me.numP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'workingOperat
        '
        Me.workingOperat.Location = New System.Drawing.Point(0, 0)
        Me.workingOperat.Margin = New System.Windows.Forms.Padding(0)
        Me.workingOperat.Name = "workingOperat"
        Me.workingOperat.Size = New System.Drawing.Size(0, 0)
        Me.workingOperat.TabIndex = 21
        Me.workingOperat.Text = "本次操作说明："
        Me.workingOperat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewMaterialL
        '
        Me.NewMaterialL.Location = New System.Drawing.Point(0, 0)
        Me.NewMaterialL.Margin = New System.Windows.Forms.Padding(0)
        Me.NewMaterialL.Name = "NewMaterialL"
        Me.NewMaterialL.Size = New System.Drawing.Size(0, 0)
        Me.NewMaterialL.TabIndex = 22
        '
        'Newmaterialb
        '
        Me.Newmaterialb.Location = New System.Drawing.Point(0, 0)
        Me.Newmaterialb.Margin = New System.Windows.Forms.Padding(0)
        Me.Newmaterialb.Name = "Newmaterialb"
        Me.Newmaterialb.Size = New System.Drawing.Size(0, 0)
        Me.Newmaterialb.TabIndex = 23
        Me.Newmaterialb.Text = "添加新原料"
        Me.Newmaterialb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addMaterial
        '
        Me.addMaterial.Location = New System.Drawing.Point(0, 0)
        Me.addMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.addMaterial.Name = "addMaterial"
        Me.addMaterial.Size = New System.Drawing.Size(0, 0)
        Me.addMaterial.TabIndex = 24
        '
        'addMaterialb
        '
        Me.addMaterialb.Location = New System.Drawing.Point(0, 0)
        Me.addMaterialb.Margin = New System.Windows.Forms.Padding(0)
        Me.addMaterialb.Name = "addMaterialb"
        Me.addMaterialb.Size = New System.Drawing.Size(0, 0)
        Me.addMaterialb.TabIndex = 25
        Me.addMaterialb.Text = "原材料添加"
        Me.addMaterialb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'materialLose
        '
        Me.materialLose.Location = New System.Drawing.Point(0, 0)
        Me.materialLose.Margin = New System.Windows.Forms.Padding(0)
        Me.materialLose.Name = "materialLose"
        Me.materialLose.Size = New System.Drawing.Size(0, 0)
        Me.materialLose.TabIndex = 26
        '
        'materialloseB
        '
        Me.materialloseB.Location = New System.Drawing.Point(0, 0)
        Me.materialloseB.Margin = New System.Windows.Forms.Padding(0)
        Me.materialloseB.Name = "materialloseB"
        Me.materialloseB.Size = New System.Drawing.Size(0, 0)
        Me.materialloseB.TabIndex = 27
        Me.materialloseB.Text = "原材料损耗"
        Me.materialloseB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'otherexplain
        '
        Me.otherexplain.Location = New System.Drawing.Point(0, 0)
        Me.otherexplain.Margin = New System.Windows.Forms.Padding(0)
        Me.otherexplain.Name = "otherexplain"
        Me.otherexplain.Size = New System.Drawing.Size(0, 21)
        Me.otherexplain.TabIndex = 28
        Me.otherexplain.Text = "（其他）"
        '
        'operateNum
        '
        Me.operateNum.Location = New System.Drawing.Point(0, 0)
        Me.operateNum.Margin = New System.Windows.Forms.Padding(0)
        Me.operateNum.Name = "operateNum"
        Me.operateNum.Size = New System.Drawing.Size(0, 0)
        Me.operateNum.TabIndex = 29
        Me.operateNum.Text = "操作涉及质量："
        Me.operateNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'operateNumI
        '
        Me.operateNumI.Location = New System.Drawing.Point(0, 0)
        Me.operateNumI.Margin = New System.Windows.Forms.Padding(0)
        Me.operateNumI.Name = "operateNumI"
        Me.operateNumI.Size = New System.Drawing.Size(0, 21)
        Me.operateNumI.TabIndex = 30
        '
        'Yes_backL
        '
        Me.Yes_backL.Location = New System.Drawing.Point(0, 0)
        Me.Yes_backL.Margin = New System.Windows.Forms.Padding(0)
        Me.Yes_backL.Name = "Yes_backL"
        Me.Yes_backL.Size = New System.Drawing.Size(0, 0)
        Me.Yes_backL.TabIndex = 31
        '
        'yes
        '
        Me.yes.Location = New System.Drawing.Point(0, 0)
        Me.yes.Margin = New System.Windows.Forms.Padding(0)
        Me.yes.Name = "yes"
        Me.yes.Size = New System.Drawing.Size(0, 0)
        Me.yes.TabIndex = 32
        Me.yes.Text = "确定"
        Me.yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'operateMoney
        '
        Me.operateMoney.Location = New System.Drawing.Point(0, 0)
        Me.operateMoney.Margin = New System.Windows.Forms.Padding(0)
        Me.operateMoney.Name = "operateMoney"
        Me.operateMoney.Size = New System.Drawing.Size(0, 0)
        Me.operateMoney.TabIndex = 33
        Me.operateMoney.Text = "操作涉及金额："
        Me.operateMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kg
        '
        Me.kg.Location = New System.Drawing.Point(0, 0)
        Me.kg.Margin = New System.Windows.Forms.Padding(0)
        Me.kg.Name = "kg"
        Me.kg.Size = New System.Drawing.Size(0, 0)
        Me.kg.TabIndex = 34
        Me.kg.Text = "kg"
        Me.kg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'underLine0
        '
        Me.underLine0.Location = New System.Drawing.Point(0, 0)
        Me.underLine0.Margin = New System.Windows.Forms.Padding(0)
        Me.underLine0.Name = "underLine0"
        Me.underLine0.Size = New System.Drawing.Size(0, 0)
        Me.underLine0.TabIndex = 35
        '
        'yuan
        '
        Me.yuan.Location = New System.Drawing.Point(0, 0)
        Me.yuan.Margin = New System.Windows.Forms.Padding(0)
        Me.yuan.Name = "yuan"
        Me.yuan.Size = New System.Drawing.Size(0, 0)
        Me.yuan.TabIndex = 36
        Me.yuan.Text = "元"
        Me.yuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Money_P
        '
        Me.Money_P.Location = New System.Drawing.Point(0, 0)
        Me.Money_P.Margin = New System.Windows.Forms.Padding(0)
        Me.Money_P.Name = "Money_P"
        Me.Money_P.Size = New System.Drawing.Size(0, 0)
        Me.Money_P.TabIndex = 37
        Me.Money_P.Text = "0"
        Me.Money_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'materialsurplus
        '
        Me.materialsurplus.Location = New System.Drawing.Point(0, 0)
        Me.materialsurplus.Margin = New System.Windows.Forms.Padding(0)
        Me.materialsurplus.Name = "materialsurplus"
        Me.materialsurplus.Size = New System.Drawing.Size(0, 0)
        Me.materialsurplus.TabIndex = 38
        Me.materialsurplus.Text = "原材料剩余："
        Me.materialsurplus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'underline1
        '
        Me.underline1.Location = New System.Drawing.Point(0, 0)
        Me.underline1.Margin = New System.Windows.Forms.Padding(0)
        Me.underline1.Name = "underline1"
        Me.underline1.Size = New System.Drawing.Size(0, 0)
        Me.underline1.TabIndex = 39
        '
        'materialsP
        '
        Me.materialsP.Location = New System.Drawing.Point(0, 0)
        Me.materialsP.Margin = New System.Windows.Forms.Padding(0)
        Me.materialsP.Name = "materialsP"
        Me.materialsP.Size = New System.Drawing.Size(0, 0)
        Me.materialsP.TabIndex = 40
        Me.materialsP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kg1
        '
        Me.kg1.Location = New System.Drawing.Point(0, 0)
        Me.kg1.Margin = New System.Windows.Forms.Padding(0)
        Me.kg1.Name = "kg1"
        Me.kg1.Size = New System.Drawing.Size(0, 0)
        Me.kg1.TabIndex = 41
        Me.kg1.Text = "kg"
        Me.kg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productName1
        '
        Me.productName1.Location = New System.Drawing.Point(0, 0)
        Me.productName1.Margin = New System.Windows.Forms.Padding(0)
        Me.productName1.Name = "productName1"
        Me.productName1.Size = New System.Drawing.Size(0, 0)
        Me.productName1.TabIndex = 42
        Me.productName1.Text = "产品名称："
        Me.productName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productNameI1
        '
        Me.productNameI1.Location = New System.Drawing.Point(0, 0)
        Me.productNameI1.Margin = New System.Windows.Forms.Padding(0)
        Me.productNameI1.Name = "productNameI1"
        Me.productNameI1.Size = New System.Drawing.Size(0, 21)
        Me.productNameI1.TabIndex = 43
        '
        'productNum
        '
        Me.productNum.Location = New System.Drawing.Point(0, 0)
        Me.productNum.Margin = New System.Windows.Forms.Padding(0)
        Me.productNum.Name = "productNum"
        Me.productNum.Size = New System.Drawing.Size(0, 0)
        Me.productNum.TabIndex = 44
        Me.productNum.Text = "产品编号："
        Me.productNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productNumPL
        '
        Me.productNumPL.Location = New System.Drawing.Point(0, 0)
        Me.productNumPL.Margin = New System.Windows.Forms.Padding(0)
        Me.productNumPL.Name = "productNumPL"
        Me.productNumPL.Size = New System.Drawing.Size(0, 0)
        Me.productNumPL.TabIndex = 45
        '
        'productNumP
        '
        Me.productNumP.Location = New System.Drawing.Point(0, 0)
        Me.productNumP.Margin = New System.Windows.Forms.Padding(0)
        Me.productNumP.Name = "productNumP"
        Me.productNumP.Size = New System.Drawing.Size(0, 0)
        Me.productNumP.TabIndex = 46
        Me.productNumP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'productType
        '
        Me.productType.Location = New System.Drawing.Point(0, 0)
        Me.productType.Margin = New System.Windows.Forms.Padding(0)
        Me.productType.Name = "productType"
        Me.productType.Size = New System.Drawing.Size(0, 0)
        Me.productType.TabIndex = 47
        Me.productType.Text = "产品规格："
        Me.productType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'producttypeI
        '
        Me.producttypeI.Location = New System.Drawing.Point(0, 0)
        Me.producttypeI.Margin = New System.Windows.Forms.Padding(0)
        Me.producttypeI.Name = "producttypeI"
        Me.producttypeI.Size = New System.Drawing.Size(0, 21)
        Me.producttypeI.TabIndex = 48
        '
        'g
        '
        Me.g.Location = New System.Drawing.Point(0, 0)
        Me.g.Margin = New System.Windows.Forms.Padding(0)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(0, 0)
        Me.g.TabIndex = 49
        Me.g.Text = "g"
        Me.g.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'createNum
        '
        Me.createNum.Location = New System.Drawing.Point(0, 0)
        Me.createNum.Margin = New System.Windows.Forms.Padding(0)
        Me.createNum.Name = "createNum"
        Me.createNum.Size = New System.Drawing.Size(0, 0)
        Me.createNum.TabIndex = 50
        Me.createNum.Text = "生成数量："
        Me.createNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'createNumI
        '
        Me.createNumI.Location = New System.Drawing.Point(0, 0)
        Me.createNumI.Margin = New System.Windows.Forms.Padding(0)
        Me.createNumI.Name = "createNumI"
        Me.createNumI.Size = New System.Drawing.Size(0, 21)
        Me.createNumI.TabIndex = 51
        '
        'materialDeplete
        '
        Me.materialDeplete.Location = New System.Drawing.Point(0, 0)
        Me.materialDeplete.Margin = New System.Windows.Forms.Padding(0)
        Me.materialDeplete.Name = "materialDeplete"
        Me.materialDeplete.Size = New System.Drawing.Size(0, 0)
        Me.materialDeplete.TabIndex = 52
        Me.materialDeplete.Text = "消耗原料："
        Me.materialDeplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addImage
        '
        Me.addImage.Location = New System.Drawing.Point(0, 0)
        Me.addImage.Margin = New System.Windows.Forms.Padding(0)
        Me.addImage.Name = "addImage"
        Me.addImage.Size = New System.Drawing.Size(0, 0)
        Me.addImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addImage.TabIndex = 53
        Me.addImage.TabStop = False
        '
        'sure_L
        '
        Me.sure_L.Location = New System.Drawing.Point(0, 0)
        Me.sure_L.Margin = New System.Windows.Forms.Padding(0)
        Me.sure_L.Name = "sure_L"
        Me.sure_L.Size = New System.Drawing.Size(0, 0)
        Me.sure_L.TabIndex = 54
        '
        'sureb
        '
        Me.sureb.Location = New System.Drawing.Point(0, 0)
        Me.sureb.Margin = New System.Windows.Forms.Padding(0)
        Me.sureb.Name = "sureb"
        Me.sureb.Size = New System.Drawing.Size(0, 0)
        Me.sureb.TabIndex = 55
        Me.sureb.Text = "确定"
        Me.sureb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'warning
        '
        Me.warning.Location = New System.Drawing.Point(0, 0)
        Me.warning.Margin = New System.Windows.Forms.Padding(0)
        Me.warning.Name = "warning"
        Me.warning.Size = New System.Drawing.Size(0, 0)
        Me.warning.TabIndex = 56
        Me.warning.Text = "警告"
        Me.warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchBack
        '
        Me.searchBack.Location = New System.Drawing.Point(0, 0)
        Me.searchBack.Margin = New System.Windows.Forms.Padding(0)
        Me.searchBack.Name = "searchBack"
        Me.searchBack.Size = New System.Drawing.Size(0, 0)
        Me.searchBack.TabIndex = 57
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(0, 0)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(0)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(0, 0)
        Me.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.searchButton.TabIndex = 58
        Me.searchButton.TabStop = False
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(0, 0)
        Me.search.Margin = New System.Windows.Forms.Padding(0)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(0, 0)
        Me.search.TabIndex = 59
        Me.search.Text = "搜索"
        Me.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchInput
        '
        Me.searchInput.Location = New System.Drawing.Point(0, 0)
        Me.searchInput.Margin = New System.Windows.Forms.Padding(0)
        Me.searchInput.Name = "searchInput"
        Me.searchInput.Size = New System.Drawing.Size(0, 21)
        Me.searchInput.TabIndex = 60
        '
        'addMaterial1
        '
        Me.addMaterial1.Location = New System.Drawing.Point(0, 0)
        Me.addMaterial1.Margin = New System.Windows.Forms.Padding(0)
        Me.addMaterial1.Name = "addMaterial1"
        Me.addMaterial1.Size = New System.Drawing.Size(0, 0)
        Me.addMaterial1.TabIndex = 61
        Me.addMaterial1.Text = "添加原材料"
        Me.addMaterial1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'allMaterial
        '
        Me.allMaterial.Location = New System.Drawing.Point(0, 0)
        Me.allMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.allMaterial.Name = "allMaterial"
        Me.allMaterial.Size = New System.Drawing.Size(0, 0)
        Me.allMaterial.TabIndex = 62
        Me.allMaterial.Text = "全部原材料"
        Me.allMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'materialManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(40, 48)
        Me.Controls.Add(Me.allMaterial)
        Me.Controls.Add(Me.addMaterial1)
        Me.Controls.Add(Me.searchInput)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.searchBack)
        Me.Controls.Add(Me.warning)
        Me.Controls.Add(Me.sureb)
        Me.Controls.Add(Me.sure_L)
        Me.Controls.Add(Me.addImage)
        Me.Controls.Add(Me.materialDeplete)
        Me.Controls.Add(Me.createNumI)
        Me.Controls.Add(Me.createNum)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.producttypeI)
        Me.Controls.Add(Me.productType)
        Me.Controls.Add(Me.productNumP)
        Me.Controls.Add(Me.productNumPL)
        Me.Controls.Add(Me.productNum)
        Me.Controls.Add(Me.productNameI1)
        Me.Controls.Add(Me.productName1)
        Me.Controls.Add(Me.kg1)
        Me.Controls.Add(Me.materialsP)
        Me.Controls.Add(Me.underline1)
        Me.Controls.Add(Me.materialsurplus)
        Me.Controls.Add(Me.Money_P)
        Me.Controls.Add(Me.yuan)
        Me.Controls.Add(Me.underLine0)
        Me.Controls.Add(Me.operateMoney)
        Me.Controls.Add(Me.yes)
        Me.Controls.Add(Me.Yes_backL)
        Me.Controls.Add(Me.kg)
        Me.Controls.Add(Me.operateNumI)
        Me.Controls.Add(Me.operateNum)
        Me.Controls.Add(Me.otherexplain)
        Me.Controls.Add(Me.materialloseB)
        Me.Controls.Add(Me.materialLose)
        Me.Controls.Add(Me.addMaterialb)
        Me.Controls.Add(Me.addMaterial)
        Me.Controls.Add(Me.Newmaterialb)
        Me.Controls.Add(Me.NewMaterialL)
        Me.Controls.Add(Me.workingOperat)
        Me.Controls.Add(Me.numP)
        Me.Controls.Add(Me.NumL)
        Me.Controls.Add(Me.Num)
        Me.Controls.Add(Me.price_P)
        Me.Controls.Add(Me.priceI)
        Me.Controls.Add(Me.MaterialPrice)
        Me.Controls.Add(Me.materialNameI)
        Me.Controls.Add(Me.materialName)
        Me.Controls.Add(Me.head1)
        Me.Controls.Add(Me.chargeBack)
        Me.Controls.Add(Me.backLine)
        Me.Controls.Add(Me.materialSB)
        Me.Controls.Add(Me.materialscanL)
        Me.Controls.Add(Me.createP)
        Me.Controls.Add(Me.createPL)
        Me.Controls.Add(Me.materialB)
        Me.Controls.Add(Me.materialIAO)
        Me.Controls.Add(Me.Nowtime)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "materialManagment"
        Me.Text = "materialManagment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents admin As System.Windows.Forms.Label
    Friend WithEvents Nowtime As System.Windows.Forms.Label
    Friend WithEvents Nowtimeupdater As System.Windows.Forms.Timer
    Friend WithEvents materialIAO As System.Windows.Forms.Label
    Friend WithEvents materialB As System.Windows.Forms.Label
    Friend WithEvents createPL As System.Windows.Forms.Label
    Friend WithEvents createP As System.Windows.Forms.Label
    Friend WithEvents materialscanL As System.Windows.Forms.Label
    Friend WithEvents materialSB As System.Windows.Forms.Label
    Friend WithEvents backLine As System.Windows.Forms.Label
    Friend WithEvents chargeBack As System.Windows.Forms.Label
    Friend WithEvents head1 As System.Windows.Forms.Label
    Friend WithEvents materialName As System.Windows.Forms.Label
    Friend WithEvents materialNameI As System.Windows.Forms.TextBox
    Friend WithEvents MaterialPrice As System.Windows.Forms.Label
    Friend WithEvents priceI As System.Windows.Forms.TextBox
    Friend WithEvents price_P As System.Windows.Forms.Label
    Friend WithEvents Num As System.Windows.Forms.Label
    Friend WithEvents NumL As System.Windows.Forms.Label
    Friend WithEvents numP As System.Windows.Forms.Label
    Friend WithEvents workingOperat As System.Windows.Forms.Label
    Friend WithEvents NewMaterialL As System.Windows.Forms.Label
    Friend WithEvents Newmaterialb As System.Windows.Forms.Label
    Friend WithEvents addMaterial As System.Windows.Forms.Label
    Friend WithEvents addMaterialb As System.Windows.Forms.Label
    Friend WithEvents materialLose As System.Windows.Forms.Label
    Friend WithEvents materialloseB As System.Windows.Forms.Label
    Friend WithEvents otherexplain As System.Windows.Forms.TextBox
    Friend WithEvents operateNum As System.Windows.Forms.Label
    Friend WithEvents operateNumI As System.Windows.Forms.TextBox
    Friend WithEvents Yes_backL As System.Windows.Forms.Label
    Friend WithEvents yes As System.Windows.Forms.Label
    Friend WithEvents operateMoney As System.Windows.Forms.Label
    Friend WithEvents kg As System.Windows.Forms.Label
    Friend WithEvents underLine0 As System.Windows.Forms.Label
    Friend WithEvents yuan As System.Windows.Forms.Label
    Friend WithEvents Money_P As System.Windows.Forms.Label
    Friend WithEvents materialsurplus As System.Windows.Forms.Label
    Friend WithEvents underline1 As System.Windows.Forms.Label
    Friend WithEvents materialsP As System.Windows.Forms.Label
    Friend WithEvents kg1 As System.Windows.Forms.Label
    Friend WithEvents productName1 As System.Windows.Forms.Label
    Friend WithEvents productNameI1 As System.Windows.Forms.TextBox
    Friend WithEvents productNum As System.Windows.Forms.Label
    Friend WithEvents productNumPL As System.Windows.Forms.Label
    Friend WithEvents productNumP As System.Windows.Forms.Label
    Friend WithEvents productType As System.Windows.Forms.Label
    Friend WithEvents producttypeI As System.Windows.Forms.TextBox
    Friend WithEvents g As System.Windows.Forms.Label
    Friend WithEvents createNum As System.Windows.Forms.Label
    Friend WithEvents createNumI As System.Windows.Forms.TextBox
    Friend WithEvents materialDeplete As System.Windows.Forms.Label
    Friend WithEvents addImage As System.Windows.Forms.PictureBox
    Friend WithEvents sure_L As System.Windows.Forms.Label
    Friend WithEvents sureb As System.Windows.Forms.Label
    Friend WithEvents warning As System.Windows.Forms.Label
    Friend WithEvents searchBack As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.PictureBox
    Friend WithEvents search As System.Windows.Forms.Label
    Friend WithEvents searchInput As System.Windows.Forms.TextBox
    Friend WithEvents addMaterial1 As System.Windows.Forms.Label
    Friend WithEvents allMaterial As System.Windows.Forms.Label
End Class
