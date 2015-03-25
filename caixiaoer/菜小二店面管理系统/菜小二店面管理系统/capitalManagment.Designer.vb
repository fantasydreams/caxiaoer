<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capitalManagment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(capitalManagment))
        Me.back = New System.Windows.Forms.PictureBox()
        Me.head = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Label()
        Me.NowTimeUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.Nowtime = New System.Windows.Forms.Label()
        Me.searchP = New System.Windows.Forms.Label()
        Me.dateI1 = New System.Windows.Forms.TextBox()
        Me.DateTo = New System.Windows.Forms.Label()
        Me.dateI0 = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Label()
        Me.printexcel = New System.Windows.Forms.Label()
        Me.Data = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producttype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operatorMan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagedown1 = New System.Windows.Forms.Label()
        Me.pageup1 = New System.Windows.Forms.Label()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.head.Text = "资金出纳"
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
        'NowTimeUpdater
        '
        Me.NowTimeUpdater.Enabled = True
        Me.NowTimeUpdater.Interval = 10000
        '
        'Nowtime
        '
        Me.Nowtime.Location = New System.Drawing.Point(0, 0)
        Me.Nowtime.Name = "Nowtime"
        Me.Nowtime.Size = New System.Drawing.Size(0, 0)
        Me.Nowtime.TabIndex = 3
        Me.Nowtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'searchP
        '
        Me.searchP.Location = New System.Drawing.Point(0, 0)
        Me.searchP.Margin = New System.Windows.Forms.Padding(0)
        Me.searchP.Name = "searchP"
        Me.searchP.Size = New System.Drawing.Size(0, 0)
        Me.searchP.TabIndex = 4
        Me.searchP.Text = "查询"
        Me.searchP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateI1
        '
        Me.dateI1.Location = New System.Drawing.Point(0, 0)
        Me.dateI1.Margin = New System.Windows.Forms.Padding(0)
        Me.dateI1.Name = "dateI1"
        Me.dateI1.Size = New System.Drawing.Size(0, 21)
        Me.dateI1.TabIndex = 7
        '
        'DateTo
        '
        Me.DateTo.Location = New System.Drawing.Point(0, 0)
        Me.DateTo.Margin = New System.Windows.Forms.Padding(0)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(0, 0)
        Me.DateTo.TabIndex = 6
        Me.DateTo.Text = "至"
        Me.DateTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateI0
        '
        Me.dateI0.Location = New System.Drawing.Point(0, 0)
        Me.dateI0.Margin = New System.Windows.Forms.Padding(0)
        Me.dateI0.Name = "dateI0"
        Me.dateI0.Size = New System.Drawing.Size(0, 21)
        Me.dateI0.TabIndex = 5
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(0, 0)
        Me.search.Margin = New System.Windows.Forms.Padding(0)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(0, 0)
        Me.search.TabIndex = 8
        Me.search.Text = "查询"
        Me.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'printexcel
        '
        Me.printexcel.Location = New System.Drawing.Point(0, 0)
        Me.printexcel.Margin = New System.Windows.Forms.Padding(0)
        Me.printexcel.Name = "printexcel"
        Me.printexcel.Size = New System.Drawing.Size(0, 0)
        Me.printexcel.TabIndex = 9
        Me.printexcel.Text = "导出当前表格"
        Me.printexcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Data
        '
        Me.Data.AllowUserToAddRows = False
        Me.Data.AllowUserToDeleteRows = False
        Me.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Data.BackgroundColor = System.Drawing.Color.White
        Me.Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.productName, Me.productNum, Me.producttype, Me.price, Me.operatorMan, Me.comment})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Data.DefaultCellStyle = DataGridViewCellStyle2
        Me.Data.Location = New System.Drawing.Point(0, 0)
        Me.Data.Margin = New System.Windows.Forms.Padding(0)
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        Me.Data.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Data.RowTemplate.Height = 23
        Me.Data.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Data.Size = New System.Drawing.Size(0, 0)
        Me.Data.TabIndex = 10
        '
        'Time
        '
        Me.Time.HeaderText = "时间"
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        '
        'productName
        '
        Me.productName.HeaderText = "产品名称"
        Me.productName.Name = "productName"
        Me.productName.ReadOnly = True
        '
        'productNum
        '
        Me.productNum.HeaderText = "产品编号"
        Me.productNum.Name = "productNum"
        Me.productNum.ReadOnly = True
        '
        'producttype
        '
        Me.producttype.HeaderText = "产品规格（g）"
        Me.producttype.Name = "producttype"
        Me.producttype.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "产品单价（￥）"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'operatorMan
        '
        Me.operatorMan.HeaderText = "操作员"
        Me.operatorMan.Name = "operatorMan"
        Me.operatorMan.ReadOnly = True
        '
        'comment
        '
        Me.comment.HeaderText = "备注"
        Me.comment.Name = "comment"
        Me.comment.ReadOnly = True
        '
        'pagedown1
        '
        Me.pagedown1.Location = New System.Drawing.Point(0, 0)
        Me.pagedown1.Margin = New System.Windows.Forms.Padding(0)
        Me.pagedown1.Name = "pagedown1"
        Me.pagedown1.Size = New System.Drawing.Size(0, 0)
        Me.pagedown1.TabIndex = 11
        Me.pagedown1.Text = "下一页"
        Me.pagedown1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pageup1
        '
        Me.pageup1.Location = New System.Drawing.Point(0, 0)
        Me.pageup1.Margin = New System.Windows.Forms.Padding(0)
        Me.pageup1.Name = "pageup1"
        Me.pageup1.Size = New System.Drawing.Size(0, 0)
        Me.pageup1.TabIndex = 12
        Me.pageup1.Text = "上一页"
        Me.pageup1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'capitalManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(48, 45)
        Me.Controls.Add(Me.pageup1)
        Me.Controls.Add(Me.pagedown1)
        Me.Controls.Add(Me.printexcel)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.dateI0)
        Me.Controls.Add(Me.dateI1)
        Me.Controls.Add(Me.searchP)
        Me.Controls.Add(Me.Nowtime)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Data)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "capitalManagment"
        Me.Text = "capitalManagment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents admin As System.Windows.Forms.Label
    Friend WithEvents NowTimeUpdater As System.Windows.Forms.Timer
    Friend WithEvents Nowtime As System.Windows.Forms.Label
    Friend WithEvents searchP As System.Windows.Forms.Label
    Friend WithEvents dateI1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTo As System.Windows.Forms.Label
    Friend WithEvents dateI0 As System.Windows.Forms.TextBox
    Friend WithEvents search As System.Windows.Forms.Label
    Friend WithEvents printexcel As System.Windows.Forms.Label
    Friend WithEvents Data As System.Windows.Forms.DataGridView
    Friend WithEvents pagedown1 As System.Windows.Forms.Label
    Friend WithEvents pageup1 As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents producttype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operatorMan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comment As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
