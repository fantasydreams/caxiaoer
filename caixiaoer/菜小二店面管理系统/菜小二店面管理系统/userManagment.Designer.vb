<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userManagment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userManagment))
        Me.back = New System.Windows.Forms.PictureBox()
        Me.head = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Label()
        Me.Nowtimeupdater = New System.Windows.Forms.Timer(Me.components)
        Me.Nowtime = New System.Windows.Forms.Label()
        Me.searchback = New System.Windows.Forms.Label()
        Me.blackList = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.PictureBox()
        Me.search = New System.Windows.Forms.Label()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.whiteList = New System.Windows.Forms.Label()
        Me.VIP = New System.Windows.Forms.Label()
        Me.allUser = New System.Windows.Forms.Label()
        Me.VipchargeBack = New System.Windows.Forms.Label()
        Me.shut = New System.Windows.Forms.PictureBox()
        Me.VipSurplusM = New System.Windows.Forms.Label()
        Me.SurplusMB = New System.Windows.Forms.Label()
        Me.surplusMP = New System.Windows.Forms.Label()
        Me.yes = New System.Windows.Forms.Label()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchButton, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.head.Text = "用户管理"
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
        'blackList
        '
        Me.blackList.Location = New System.Drawing.Point(0, 0)
        Me.blackList.Margin = New System.Windows.Forms.Padding(0)
        Me.blackList.Name = "blackList"
        Me.blackList.Size = New System.Drawing.Size(0, 0)
        Me.blackList.TabIndex = 5
        Me.blackList.Text = "黑名单"
        Me.blackList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(0, 0)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(0)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(0, 0)
        Me.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.searchButton.TabIndex = 6
        Me.searchButton.TabStop = False
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(0, 0)
        Me.search.Margin = New System.Windows.Forms.Padding(0)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(0, 0)
        Me.search.TabIndex = 7
        Me.search.Text = "搜索"
        Me.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchInput
        '
        Me.searchInput.Location = New System.Drawing.Point(0, 0)
        Me.searchInput.Margin = New System.Windows.Forms.Padding(0)
        Me.searchInput.Name = "searchInput"
        Me.searchInput.Size = New System.Drawing.Size(0, 21)
        Me.searchInput.TabIndex = 8
        '
        'whiteList
        '
        Me.whiteList.Location = New System.Drawing.Point(0, 0)
        Me.whiteList.Margin = New System.Windows.Forms.Padding(0)
        Me.whiteList.Name = "whiteList"
        Me.whiteList.Size = New System.Drawing.Size(0, 0)
        Me.whiteList.TabIndex = 9
        Me.whiteList.Text = "白名单"
        Me.whiteList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VIP
        '
        Me.VIP.Location = New System.Drawing.Point(0, 0)
        Me.VIP.Margin = New System.Windows.Forms.Padding(0)
        Me.VIP.Name = "VIP"
        Me.VIP.Size = New System.Drawing.Size(0, 0)
        Me.VIP.TabIndex = 10
        Me.VIP.Text = "会员"
        Me.VIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'allUser
        '
        Me.allUser.Location = New System.Drawing.Point(0, 0)
        Me.allUser.Margin = New System.Windows.Forms.Padding(0)
        Me.allUser.Name = "allUser"
        Me.allUser.Size = New System.Drawing.Size(0, 0)
        Me.allUser.TabIndex = 11
        Me.allUser.Text = "全部用户"
        Me.allUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VipchargeBack
        '
        Me.VipchargeBack.Location = New System.Drawing.Point(0, 0)
        Me.VipchargeBack.Margin = New System.Windows.Forms.Padding(0)
        Me.VipchargeBack.Name = "VipchargeBack"
        Me.VipchargeBack.Size = New System.Drawing.Size(0, 0)
        Me.VipchargeBack.TabIndex = 12
        '
        'shut
        '
        Me.shut.Location = New System.Drawing.Point(0, 0)
        Me.shut.Margin = New System.Windows.Forms.Padding(0)
        Me.shut.Name = "shut"
        Me.shut.Size = New System.Drawing.Size(0, 0)
        Me.shut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shut.TabIndex = 13
        Me.shut.TabStop = False
        '
        'VipSurplusM
        '
        Me.VipSurplusM.Location = New System.Drawing.Point(0, 0)
        Me.VipSurplusM.Margin = New System.Windows.Forms.Padding(0)
        Me.VipSurplusM.Name = "VipSurplusM"
        Me.VipSurplusM.Size = New System.Drawing.Size(0, 0)
        Me.VipSurplusM.TabIndex = 14
        Me.VipSurplusM.Text = "会员卡余额："
        Me.VipSurplusM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SurplusMB
        '
        Me.SurplusMB.Location = New System.Drawing.Point(0, 0)
        Me.SurplusMB.Margin = New System.Windows.Forms.Padding(0)
        Me.SurplusMB.Name = "SurplusMB"
        Me.SurplusMB.Size = New System.Drawing.Size(0, 0)
        Me.SurplusMB.TabIndex = 15
        '
        'surplusMP
        '
        Me.surplusMP.Location = New System.Drawing.Point(0, 0)
        Me.surplusMP.Margin = New System.Windows.Forms.Padding(0)
        Me.surplusMP.Name = "surplusMP"
        Me.surplusMP.Size = New System.Drawing.Size(0, 0)
        Me.surplusMP.TabIndex = 16
        Me.surplusMP.Text = "88.8"
        Me.surplusMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'yes
        '
        Me.yes.Location = New System.Drawing.Point(0, 0)
        Me.yes.Margin = New System.Windows.Forms.Padding(0)
        Me.yes.Name = "yes"
        Me.yes.Size = New System.Drawing.Size(0, 0)
        Me.yes.TabIndex = 17
        Me.yes.Text = "确定"
        Me.yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'userManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(57, 82)
        Me.Controls.Add(Me.yes)
        Me.Controls.Add(Me.surplusMP)
        Me.Controls.Add(Me.SurplusMB)
        Me.Controls.Add(Me.VipSurplusM)
        Me.Controls.Add(Me.shut)
        Me.Controls.Add(Me.VipchargeBack)
        Me.Controls.Add(Me.allUser)
        Me.Controls.Add(Me.VIP)
        Me.Controls.Add(Me.whiteList)
        Me.Controls.Add(Me.searchInput)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.blackList)
        Me.Controls.Add(Me.searchback)
        Me.Controls.Add(Me.Nowtime)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.back)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "userManagment"
        Me.Text = "userManagment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents admin As System.Windows.Forms.Label
    Friend WithEvents Nowtimeupdater As System.Windows.Forms.Timer
    Friend WithEvents Nowtime As System.Windows.Forms.Label
    Friend WithEvents searchback As System.Windows.Forms.Label
    Friend WithEvents blackList As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.PictureBox
    Friend WithEvents search As System.Windows.Forms.Label
    Friend WithEvents searchInput As System.Windows.Forms.TextBox
    Friend WithEvents whiteList As System.Windows.Forms.Label
    Friend WithEvents VIP As System.Windows.Forms.Label
    Friend WithEvents allUser As System.Windows.Forms.Label
    Friend WithEvents VipchargeBack As System.Windows.Forms.Label
    Friend WithEvents shut As System.Windows.Forms.PictureBox
    Friend WithEvents VipSurplusM As System.Windows.Forms.Label
    Friend WithEvents SurplusMB As System.Windows.Forms.Label
    Friend WithEvents surplusMP As System.Windows.Forms.Label
    Friend WithEvents yes As System.Windows.Forms.Label
End Class
