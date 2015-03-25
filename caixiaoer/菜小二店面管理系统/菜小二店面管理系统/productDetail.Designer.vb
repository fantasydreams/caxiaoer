<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productDetail))
        Me.backGround = New System.Windows.Forms.Label()
        Me.shut = New System.Windows.Forms.PictureBox()
        Me.ProDetailLine = New System.Windows.Forms.Label()
        Me.ProDetailBack = New System.Windows.Forms.Label()
        Me.PictureDetail = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.Label()
        Me.proName = New System.Windows.Forms.Label()
        Me.ProNum = New System.Windows.Forms.Label()
        Me.ProMaterial = New System.Windows.Forms.Label()
        Me.proType = New System.Windows.Forms.Label()
        Me.ProNameP = New System.Windows.Forms.Label()
        Me.ProPrice = New System.Windows.Forms.Label()
        Me.ProS = New System.Windows.Forms.Label()
        Me.priceIO = New System.Windows.Forms.TextBox()
        Me.prosP = New System.Windows.Forms.Label()
        Me.proSurplus = New System.Windows.Forms.Label()
        Me.prosurpluesP = New System.Windows.Forms.Label()
        Me.soldCount = New System.Windows.Forms.Label()
        Me.soldCountP = New System.Windows.Forms.Label()
        Me.procode = New System.Windows.Forms.PictureBox()
        Me.print = New System.Windows.Forms.Label()
        Me.proMaterialDetail = New System.Windows.Forms.RichTextBox()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.procode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backGround
        '
        Me.backGround.Location = New System.Drawing.Point(0, 0)
        Me.backGround.Margin = New System.Windows.Forms.Padding(0)
        Me.backGround.Name = "backGround"
        Me.backGround.Size = New System.Drawing.Size(0, 0)
        Me.backGround.TabIndex = 0
        '
        'shut
        '
        Me.shut.Location = New System.Drawing.Point(0, 0)
        Me.shut.Margin = New System.Windows.Forms.Padding(0)
        Me.shut.Name = "shut"
        Me.shut.Size = New System.Drawing.Size(0, 0)
        Me.shut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shut.TabIndex = 1
        Me.shut.TabStop = False
        '
        'ProDetailLine
        '
        Me.ProDetailLine.Location = New System.Drawing.Point(0, 0)
        Me.ProDetailLine.Margin = New System.Windows.Forms.Padding(0)
        Me.ProDetailLine.Name = "ProDetailLine"
        Me.ProDetailLine.Size = New System.Drawing.Size(0, 0)
        Me.ProDetailLine.TabIndex = 2
        '
        'ProDetailBack
        '
        Me.ProDetailBack.Location = New System.Drawing.Point(0, 0)
        Me.ProDetailBack.Margin = New System.Windows.Forms.Padding(0)
        Me.ProDetailBack.Name = "ProDetailBack"
        Me.ProDetailBack.Size = New System.Drawing.Size(0, 0)
        Me.ProDetailBack.TabIndex = 3
        '
        'PictureDetail
        '
        Me.PictureDetail.Location = New System.Drawing.Point(0, 0)
        Me.PictureDetail.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureDetail.Name = "PictureDetail"
        Me.PictureDetail.Size = New System.Drawing.Size(0, 0)
        Me.PictureDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureDetail.TabIndex = 4
        Me.PictureDetail.TabStop = False
        '
        'picBack
        '
        Me.picBack.Location = New System.Drawing.Point(0, 0)
        Me.picBack.Margin = New System.Windows.Forms.Padding(0)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(0, 0)
        Me.picBack.TabIndex = 5
        '
        'proName
        '
        Me.proName.Location = New System.Drawing.Point(0, 0)
        Me.proName.Margin = New System.Windows.Forms.Padding(0)
        Me.proName.Name = "proName"
        Me.proName.Size = New System.Drawing.Size(0, 0)
        Me.proName.TabIndex = 6
        Me.proName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProNum
        '
        Me.ProNum.Location = New System.Drawing.Point(0, 0)
        Me.ProNum.Margin = New System.Windows.Forms.Padding(0)
        Me.ProNum.Name = "ProNum"
        Me.ProNum.Size = New System.Drawing.Size(0, 0)
        Me.ProNum.TabIndex = 7
        Me.ProNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProMaterial
        '
        Me.ProMaterial.Location = New System.Drawing.Point(0, 0)
        Me.ProMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.ProMaterial.Name = "ProMaterial"
        Me.ProMaterial.Size = New System.Drawing.Size(0, 0)
        Me.ProMaterial.TabIndex = 8
        '
        'proType
        '
        Me.proType.Location = New System.Drawing.Point(0, 0)
        Me.proType.Margin = New System.Windows.Forms.Padding(0)
        Me.proType.Name = "proType"
        Me.proType.Size = New System.Drawing.Size(0, 0)
        Me.proType.TabIndex = 10
        Me.proType.Text = "产品类型："
        Me.proType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProNameP
        '
        Me.ProNameP.Location = New System.Drawing.Point(0, 0)
        Me.ProNameP.Margin = New System.Windows.Forms.Padding(0)
        Me.ProNameP.Name = "ProNameP"
        Me.ProNameP.Size = New System.Drawing.Size(0, 0)
        Me.ProNameP.TabIndex = 11
        Me.ProNameP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProPrice
        '
        Me.ProPrice.Location = New System.Drawing.Point(0, 0)
        Me.ProPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.ProPrice.Name = "ProPrice"
        Me.ProPrice.Size = New System.Drawing.Size(0, 0)
        Me.ProPrice.TabIndex = 12
        Me.ProPrice.Text = "产品价格（￥）："
        Me.ProPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProS
        '
        Me.ProS.Location = New System.Drawing.Point(0, 0)
        Me.ProS.Margin = New System.Windows.Forms.Padding(0)
        Me.ProS.Name = "ProS"
        Me.ProS.Size = New System.Drawing.Size(0, 0)
        Me.ProS.TabIndex = 13
        Me.ProS.Text = "产品规格（ g）："
        Me.ProS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'priceIO
        '
        Me.priceIO.Location = New System.Drawing.Point(0, 0)
        Me.priceIO.Margin = New System.Windows.Forms.Padding(0)
        Me.priceIO.Name = "priceIO"
        Me.priceIO.Size = New System.Drawing.Size(0, 21)
        Me.priceIO.TabIndex = 14
        Me.priceIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'prosP
        '
        Me.prosP.Location = New System.Drawing.Point(0, 0)
        Me.prosP.Margin = New System.Windows.Forms.Padding(0)
        Me.prosP.Name = "prosP"
        Me.prosP.Size = New System.Drawing.Size(0, 0)
        Me.prosP.TabIndex = 15
        Me.prosP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'proSurplus
        '
        Me.proSurplus.Location = New System.Drawing.Point(0, 0)
        Me.proSurplus.Margin = New System.Windows.Forms.Padding(0)
        Me.proSurplus.Name = "proSurplus"
        Me.proSurplus.Size = New System.Drawing.Size(0, 0)
        Me.proSurplus.TabIndex = 16
        Me.proSurplus.Text = "产品库存（盒）："
        Me.proSurplus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prosurpluesP
        '
        Me.prosurpluesP.Location = New System.Drawing.Point(0, 0)
        Me.prosurpluesP.Margin = New System.Windows.Forms.Padding(0)
        Me.prosurpluesP.Name = "prosurpluesP"
        Me.prosurpluesP.Size = New System.Drawing.Size(0, 0)
        Me.prosurpluesP.TabIndex = 17
        Me.prosurpluesP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'soldCount
        '
        Me.soldCount.Location = New System.Drawing.Point(0, 0)
        Me.soldCount.Margin = New System.Windows.Forms.Padding(0)
        Me.soldCount.Name = "soldCount"
        Me.soldCount.Size = New System.Drawing.Size(0, 0)
        Me.soldCount.TabIndex = 18
        Me.soldCount.Text = "销售量（盒）："
        Me.soldCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'soldCountP
        '
        Me.soldCountP.Location = New System.Drawing.Point(0, 0)
        Me.soldCountP.Margin = New System.Windows.Forms.Padding(0)
        Me.soldCountP.Name = "soldCountP"
        Me.soldCountP.Size = New System.Drawing.Size(0, 0)
        Me.soldCountP.TabIndex = 19
        Me.soldCountP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'procode
        '
        Me.procode.Location = New System.Drawing.Point(0, 0)
        Me.procode.Margin = New System.Windows.Forms.Padding(0)
        Me.procode.Name = "procode"
        Me.procode.Size = New System.Drawing.Size(0, 0)
        Me.procode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.procode.TabIndex = 20
        Me.procode.TabStop = False
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(0, 0)
        Me.print.Margin = New System.Windows.Forms.Padding(0)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(0, 0)
        Me.print.TabIndex = 21
        Me.print.Text = "打印"
        Me.print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'proMaterialDetail
        '
        Me.proMaterialDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.proMaterialDetail.Location = New System.Drawing.Point(0, 0)
        Me.proMaterialDetail.Margin = New System.Windows.Forms.Padding(0)
        Me.proMaterialDetail.Name = "proMaterialDetail"
        Me.proMaterialDetail.ReadOnly = True
        Me.proMaterialDetail.Size = New System.Drawing.Size(0, 0)
        Me.proMaterialDetail.TabIndex = 22
        Me.proMaterialDetail.Text = ""
        '
        'productDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(95, 72)
        Me.Controls.Add(Me.proMaterialDetail)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.procode)
        Me.Controls.Add(Me.soldCountP)
        Me.Controls.Add(Me.soldCount)
        Me.Controls.Add(Me.prosurpluesP)
        Me.Controls.Add(Me.proSurplus)
        Me.Controls.Add(Me.prosP)
        Me.Controls.Add(Me.ProS)
        Me.Controls.Add(Me.priceIO)
        Me.Controls.Add(Me.ProPrice)
        Me.Controls.Add(Me.ProNameP)
        Me.Controls.Add(Me.proType)
        Me.Controls.Add(Me.ProMaterial)
        Me.Controls.Add(Me.ProNum)
        Me.Controls.Add(Me.proName)
        Me.Controls.Add(Me.PictureDetail)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.shut)
        Me.Controls.Add(Me.ProDetailBack)
        Me.Controls.Add(Me.ProDetailLine)
        Me.Controls.Add(Me.backGround)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "productDetail"
        Me.Text = "productDetail"
        CType(Me.shut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.procode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backGround As System.Windows.Forms.Label
    Friend WithEvents shut As System.Windows.Forms.PictureBox
    Friend WithEvents ProDetailLine As System.Windows.Forms.Label
    Friend WithEvents ProDetailBack As System.Windows.Forms.Label
    Friend WithEvents PictureDetail As System.Windows.Forms.PictureBox
    Friend WithEvents picBack As System.Windows.Forms.Label
    Friend WithEvents proName As System.Windows.Forms.Label
    Friend WithEvents ProNum As System.Windows.Forms.Label
    Friend WithEvents ProMaterial As System.Windows.Forms.Label
    Friend WithEvents proType As System.Windows.Forms.Label
    Friend WithEvents ProNameP As System.Windows.Forms.Label
    Friend WithEvents ProPrice As System.Windows.Forms.Label
    Friend WithEvents ProS As System.Windows.Forms.Label
    Friend WithEvents priceIO As System.Windows.Forms.TextBox
    Friend WithEvents prosP As System.Windows.Forms.Label
    Friend WithEvents proSurplus As System.Windows.Forms.Label
    Friend WithEvents prosurpluesP As System.Windows.Forms.Label
    Friend WithEvents soldCount As System.Windows.Forms.Label
    Friend WithEvents soldCountP As System.Windows.Forms.Label
    Friend WithEvents procode As System.Windows.Forms.PictureBox
    Friend WithEvents print As System.Windows.Forms.Label
    Friend WithEvents proMaterialDetail As System.Windows.Forms.RichTextBox
End Class
