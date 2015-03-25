<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageManagment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageManagment))
        Me.head = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.PictureBox()
        Me.admin = New System.Windows.Forms.Label()
        Me.nowtime = New System.Windows.Forms.Label()
        Me.nowtimeupdater = New System.Windows.Forms.Timer(Me.components)
        Me.searchback = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.Label()
        Me.searchbutton = New System.Windows.Forms.PictureBox()
        Me.searchinput = New System.Windows.Forms.TextBox()
        Me.AddMsg = New System.Windows.Forms.Label()
        Me.MsgShut = New System.Windows.Forms.Label()
        Me.startMsg = New System.Windows.Forms.Label()
        Me.allMsg = New System.Windows.Forms.Label()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'head
        '
        Me.head.Location = New System.Drawing.Point(0, 0)
        Me.head.Margin = New System.Windows.Forms.Padding(0)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(0, 0)
        Me.head.TabIndex = 0
        Me.head.Text = "消息管理"
        Me.head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(0, 0)
        Me.back.Margin = New System.Windows.Forms.Padding(0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(0, 0)
        Me.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back.TabIndex = 1
        Me.back.TabStop = False
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
        'nowtime
        '
        Me.nowtime.Location = New System.Drawing.Point(0, 0)
        Me.nowtime.Margin = New System.Windows.Forms.Padding(0)
        Me.nowtime.Name = "nowtime"
        Me.nowtime.Size = New System.Drawing.Size(0, 0)
        Me.nowtime.TabIndex = 3
        Me.nowtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nowtimeupdater
        '
        Me.nowtimeupdater.Enabled = True
        Me.nowtimeupdater.Interval = 10000
        '
        'searchback
        '
        Me.searchback.Location = New System.Drawing.Point(0, 0)
        Me.searchback.Margin = New System.Windows.Forms.Padding(0)
        Me.searchback.Name = "searchback"
        Me.searchback.Size = New System.Drawing.Size(0, 0)
        Me.searchback.TabIndex = 4
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(0, 0)
        Me.search.Margin = New System.Windows.Forms.Padding(0)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(0, 0)
        Me.search.TabIndex = 5
        Me.search.Text = "搜索"
        Me.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchbutton
        '
        Me.searchbutton.Location = New System.Drawing.Point(0, 0)
        Me.searchbutton.Margin = New System.Windows.Forms.Padding(0)
        Me.searchbutton.Name = "searchbutton"
        Me.searchbutton.Size = New System.Drawing.Size(0, 0)
        Me.searchbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.searchbutton.TabIndex = 6
        Me.searchbutton.TabStop = False
        '
        'searchinput
        '
        Me.searchinput.Location = New System.Drawing.Point(0, 0)
        Me.searchinput.Margin = New System.Windows.Forms.Padding(0)
        Me.searchinput.Name = "searchinput"
        Me.searchinput.Size = New System.Drawing.Size(0, 21)
        Me.searchinput.TabIndex = 7
        '
        'AddMsg
        '
        Me.AddMsg.Location = New System.Drawing.Point(0, 0)
        Me.AddMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.AddMsg.Name = "AddMsg"
        Me.AddMsg.Size = New System.Drawing.Size(0, 0)
        Me.AddMsg.TabIndex = 8
        Me.AddMsg.Text = "新增"
        Me.AddMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MsgShut
        '
        Me.MsgShut.Location = New System.Drawing.Point(0, 0)
        Me.MsgShut.Margin = New System.Windows.Forms.Padding(0)
        Me.MsgShut.Name = "MsgShut"
        Me.MsgShut.Size = New System.Drawing.Size(0, 0)
        Me.MsgShut.TabIndex = 9
        Me.MsgShut.Text = "关闭"
        Me.MsgShut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'startMsg
        '
        Me.startMsg.Location = New System.Drawing.Point(0, 0)
        Me.startMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.startMsg.Name = "startMsg"
        Me.startMsg.Size = New System.Drawing.Size(0, 0)
        Me.startMsg.TabIndex = 10
        Me.startMsg.Text = "启用"
        Me.startMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'allMsg
        '
        Me.allMsg.Location = New System.Drawing.Point(0, 0)
        Me.allMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.allMsg.Name = "allMsg"
        Me.allMsg.Size = New System.Drawing.Size(0, 0)
        Me.allMsg.TabIndex = 11
        Me.allMsg.Text = "全部消息"
        Me.allMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MessageManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(111, 81)
        Me.Controls.Add(Me.allMsg)
        Me.Controls.Add(Me.startMsg)
        Me.Controls.Add(Me.MsgShut)
        Me.Controls.Add(Me.AddMsg)
        Me.Controls.Add(Me.searchinput)
        Me.Controls.Add(Me.searchbutton)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.searchback)
        Me.Controls.Add(Me.nowtime)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.head)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MessageManagment"
        Me.Text = "MessageManagment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchbutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents admin As System.Windows.Forms.Label
    Friend WithEvents nowtime As System.Windows.Forms.Label
    Friend WithEvents nowtimeupdater As System.Windows.Forms.Timer
    Friend WithEvents searchback As System.Windows.Forms.Label
    Friend WithEvents search As System.Windows.Forms.Label
    Friend WithEvents searchbutton As System.Windows.Forms.PictureBox
    Friend WithEvents searchinput As System.Windows.Forms.TextBox
    Friend WithEvents AddMsg As System.Windows.Forms.Label
    Friend WithEvents MsgShut As System.Windows.Forms.Label
    Friend WithEvents startMsg As System.Windows.Forms.Label
    Friend WithEvents allMsg As System.Windows.Forms.Label
End Class
