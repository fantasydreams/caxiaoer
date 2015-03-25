<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddVip))
        Me.back = New System.Windows.Forms.PictureBox()
        Me.head = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Label()
        Me.NowtimeUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.Nowtime = New System.Windows.Forms.Label()
        Me.backGround = New System.Windows.Forms.Label()
        Me.backColorD = New System.Windows.Forms.Label()
        Me.VipInfo = New System.Windows.Forms.Label()
        Me.VipCardID = New System.Windows.Forms.Label()
        Me.VipCardIdP = New System.Windows.Forms.Label()
        Me.VipName = New System.Windows.Forms.Label()
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.Label()
        Me.emailInput = New System.Windows.Forms.TextBox()
        Me.tellPhone = New System.Windows.Forms.Label()
        Me.phoneInput = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.Label()
        Me.addressInput = New System.Windows.Forms.TextBox()
        Me.ChargeMon = New System.Windows.Forms.Label()
        Me.Mon = New System.Windows.Forms.Label()
        Me.MonInput = New System.Windows.Forms.TextBox()
        Me.integral = New System.Windows.Forms.Label()
        Me.integralL = New System.Windows.Forms.Label()
        Me.integralP = New System.Windows.Forms.Label()
        Me.addVipL = New System.Windows.Forms.Label()
        Me.addVipUser = New System.Windows.Forms.Label()
        Me.msgBL = New System.Windows.Forms.Label()
        Me.VipMsgback = New System.Windows.Forms.Label()
        Me.shut = New System.Windows.Forms.PictureBox()
        Me.msgP = New System.Windows.Forms.Label()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.head.Text = "添加会员"
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
        'NowtimeUpdater
        '
        Me.NowtimeUpdater.Interval = 60000
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
        'backGround
        '
        Me.backGround.Location = New System.Drawing.Point(0, 0)
        Me.backGround.Margin = New System.Windows.Forms.Padding(0)
        Me.backGround.Name = "backGround"
        Me.backGround.Size = New System.Drawing.Size(0, 0)
        Me.backGround.TabIndex = 4
        '
        'backColorD
        '
        Me.backColorD.Location = New System.Drawing.Point(0, 0)
        Me.backColorD.Margin = New System.Windows.Forms.Padding(0)
        Me.backColorD.Name = "backColorD"
        Me.backColorD.Size = New System.Drawing.Size(0, 0)
        Me.backColorD.TabIndex = 5
        '
        'VipInfo
        '
        Me.VipInfo.Location = New System.Drawing.Point(0, 0)
        Me.VipInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.VipInfo.Name = "VipInfo"
        Me.VipInfo.Size = New System.Drawing.Size(0, 0)
        Me.VipInfo.TabIndex = 6
        Me.VipInfo.Text = "会员基本信息"
        Me.VipInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VipCardID
        '
        Me.VipCardID.Location = New System.Drawing.Point(0, 0)
        Me.VipCardID.Margin = New System.Windows.Forms.Padding(0)
        Me.VipCardID.Name = "VipCardID"
        Me.VipCardID.Size = New System.Drawing.Size(0, 0)
        Me.VipCardID.TabIndex = 7
        Me.VipCardID.Text = "卡  号："
        Me.VipCardID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VipCardIdP
        '
        Me.VipCardIdP.Location = New System.Drawing.Point(0, 0)
        Me.VipCardIdP.Margin = New System.Windows.Forms.Padding(0)
        Me.VipCardIdP.Name = "VipCardIdP"
        Me.VipCardIdP.Size = New System.Drawing.Size(0, 0)
        Me.VipCardIdP.TabIndex = 8
        Me.VipCardIdP.Text = "88888"
        Me.VipCardIdP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VipName
        '
        Me.VipName.Location = New System.Drawing.Point(0, 0)
        Me.VipName.Margin = New System.Windows.Forms.Padding(0)
        Me.VipName.Name = "VipName"
        Me.VipName.Size = New System.Drawing.Size(0, 0)
        Me.VipName.TabIndex = 9
        Me.VipName.Text = "姓  名："
        Me.VipName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameInput
        '
        Me.NameInput.Location = New System.Drawing.Point(0, 0)
        Me.NameInput.Margin = New System.Windows.Forms.Padding(0)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(0, 21)
        Me.NameInput.TabIndex = 10
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(0, 0)
        Me.email.Margin = New System.Windows.Forms.Padding(0)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(0, 0)
        Me.email.TabIndex = 11
        Me.email.Text = "邮  箱："
        Me.email.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'emailInput
        '
        Me.emailInput.Location = New System.Drawing.Point(0, 0)
        Me.emailInput.Margin = New System.Windows.Forms.Padding(0)
        Me.emailInput.Name = "emailInput"
        Me.emailInput.Size = New System.Drawing.Size(0, 21)
        Me.emailInput.TabIndex = 12
        '
        'tellPhone
        '
        Me.tellPhone.Location = New System.Drawing.Point(0, 0)
        Me.tellPhone.Margin = New System.Windows.Forms.Padding(0)
        Me.tellPhone.Name = "tellPhone"
        Me.tellPhone.Size = New System.Drawing.Size(0, 0)
        Me.tellPhone.TabIndex = 13
        Me.tellPhone.Text = "联系方式："
        Me.tellPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'phoneInput
        '
        Me.phoneInput.Location = New System.Drawing.Point(0, 0)
        Me.phoneInput.Margin = New System.Windows.Forms.Padding(0)
        Me.phoneInput.Name = "phoneInput"
        Me.phoneInput.Size = New System.Drawing.Size(0, 21)
        Me.phoneInput.TabIndex = 14
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(0, 0)
        Me.address.Margin = New System.Windows.Forms.Padding(0)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(0, 0)
        Me.address.TabIndex = 15
        Me.address.Text = "地  址："
        Me.address.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'addressInput
        '
        Me.addressInput.Location = New System.Drawing.Point(0, 0)
        Me.addressInput.Margin = New System.Windows.Forms.Padding(0)
        Me.addressInput.Name = "addressInput"
        Me.addressInput.Size = New System.Drawing.Size(0, 21)
        Me.addressInput.TabIndex = 16
        '
        'ChargeMon
        '
        Me.ChargeMon.Location = New System.Drawing.Point(0, 0)
        Me.ChargeMon.Margin = New System.Windows.Forms.Padding(0)
        Me.ChargeMon.Name = "ChargeMon"
        Me.ChargeMon.Size = New System.Drawing.Size(0, 0)
        Me.ChargeMon.TabIndex = 17
        Me.ChargeMon.Text = "充值金额："
        Me.ChargeMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Mon
        '
        Me.Mon.Location = New System.Drawing.Point(0, 0)
        Me.Mon.Margin = New System.Windows.Forms.Padding(0)
        Me.Mon.Name = "Mon"
        Me.Mon.Size = New System.Drawing.Size(0, 0)
        Me.Mon.TabIndex = 18
        Me.Mon.Text = "￥"
        Me.Mon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonInput
        '
        Me.MonInput.Location = New System.Drawing.Point(0, 0)
        Me.MonInput.Margin = New System.Windows.Forms.Padding(0)
        Me.MonInput.Name = "MonInput"
        Me.MonInput.Size = New System.Drawing.Size(0, 21)
        Me.MonInput.TabIndex = 19
        '
        'integral
        '
        Me.integral.Location = New System.Drawing.Point(0, 0)
        Me.integral.Margin = New System.Windows.Forms.Padding(0)
        Me.integral.Name = "integral"
        Me.integral.Size = New System.Drawing.Size(0, 0)
        Me.integral.TabIndex = 20
        Me.integral.Text = "积  分："
        Me.integral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'integralL
        '
        Me.integralL.Location = New System.Drawing.Point(0, 0)
        Me.integralL.Margin = New System.Windows.Forms.Padding(0)
        Me.integralL.Name = "integralL"
        Me.integralL.Size = New System.Drawing.Size(0, 0)
        Me.integralL.TabIndex = 21
        '
        'integralP
        '
        Me.integralP.Location = New System.Drawing.Point(0, 0)
        Me.integralP.Margin = New System.Windows.Forms.Padding(0)
        Me.integralP.Name = "integralP"
        Me.integralP.Size = New System.Drawing.Size(0, 0)
        Me.integralP.TabIndex = 22
        Me.integralP.Text = "88"
        Me.integralP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'addVipL
        '
        Me.addVipL.Location = New System.Drawing.Point(0, 0)
        Me.addVipL.Margin = New System.Windows.Forms.Padding(0)
        Me.addVipL.Name = "addVipL"
        Me.addVipL.Size = New System.Drawing.Size(0, 0)
        Me.addVipL.TabIndex = 23
        '
        'addVipUser
        '
        Me.addVipUser.Location = New System.Drawing.Point(0, 0)
        Me.addVipUser.Margin = New System.Windows.Forms.Padding(0)
        Me.addVipUser.Name = "addVipUser"
        Me.addVipUser.Size = New System.Drawing.Size(0, 0)
        Me.addVipUser.TabIndex = 24
        Me.addVipUser.Text = "添加会员"
        Me.addVipUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'msgBL
        '
        Me.msgBL.Location = New System.Drawing.Point(0, 0)
        Me.msgBL.Margin = New System.Windows.Forms.Padding(0)
        Me.msgBL.Name = "msgBL"
        Me.msgBL.Size = New System.Drawing.Size(0, 0)
        Me.msgBL.TabIndex = 25
        '
        'VipMsgback
        '
        Me.VipMsgback.Location = New System.Drawing.Point(0, 0)
        Me.VipMsgback.Margin = New System.Windows.Forms.Padding(0)
        Me.VipMsgback.Name = "VipMsgback"
        Me.VipMsgback.Size = New System.Drawing.Size(0, 0)
        Me.VipMsgback.TabIndex = 26
        '
        'shut
        '
        Me.shut.Location = New System.Drawing.Point(0, 0)
        Me.shut.Margin = New System.Windows.Forms.Padding(0)
        Me.shut.Name = "shut"
        Me.shut.Size = New System.Drawing.Size(0, 0)
        Me.shut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shut.TabIndex = 27
        Me.shut.TabStop = False
        '
        'msgP
        '
        Me.msgP.Location = New System.Drawing.Point(0, 0)
        Me.msgP.Margin = New System.Windows.Forms.Padding(0)
        Me.msgP.Name = "msgP"
        Me.msgP.Size = New System.Drawing.Size(0, 0)
        Me.msgP.TabIndex = 28
        Me.msgP.Text = "新会员添加成功！O(∩_∩)O~"
        Me.msgP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddVip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(89, 54)
        Me.Controls.Add(Me.msgP)
        Me.Controls.Add(Me.shut)
        Me.Controls.Add(Me.VipMsgback)
        Me.Controls.Add(Me.msgBL)
        Me.Controls.Add(Me.addVipUser)
        Me.Controls.Add(Me.addVipL)
        Me.Controls.Add(Me.integralP)
        Me.Controls.Add(Me.integralL)
        Me.Controls.Add(Me.integral)
        Me.Controls.Add(Me.MonInput)
        Me.Controls.Add(Me.Mon)
        Me.Controls.Add(Me.ChargeMon)
        Me.Controls.Add(Me.addressInput)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.phoneInput)
        Me.Controls.Add(Me.tellPhone)
        Me.Controls.Add(Me.emailInput)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.NameInput)
        Me.Controls.Add(Me.VipName)
        Me.Controls.Add(Me.VipCardIdP)
        Me.Controls.Add(Me.VipCardID)
        Me.Controls.Add(Me.VipInfo)
        Me.Controls.Add(Me.backColorD)
        Me.Controls.Add(Me.backGround)
        Me.Controls.Add(Me.Nowtime)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.back)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddVip"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents admin As System.Windows.Forms.Label
    Friend WithEvents NowtimeUpdater As System.Windows.Forms.Timer
    Friend WithEvents Nowtime As System.Windows.Forms.Label
    Friend WithEvents backGround As System.Windows.Forms.Label
    Friend WithEvents backColorD As System.Windows.Forms.Label
    Friend WithEvents VipInfo As System.Windows.Forms.Label
    Friend WithEvents VipCardID As System.Windows.Forms.Label
    Friend WithEvents VipCardIdP As System.Windows.Forms.Label
    Friend WithEvents VipName As System.Windows.Forms.Label
    Friend WithEvents NameInput As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.Label
    Friend WithEvents emailInput As System.Windows.Forms.TextBox
    Friend WithEvents tellPhone As System.Windows.Forms.Label
    Friend WithEvents phoneInput As System.Windows.Forms.TextBox
    Friend WithEvents address As System.Windows.Forms.Label
    Friend WithEvents addressInput As System.Windows.Forms.TextBox
    Friend WithEvents ChargeMon As System.Windows.Forms.Label
    Friend WithEvents Mon As System.Windows.Forms.Label
    Friend WithEvents MonInput As System.Windows.Forms.TextBox
    Friend WithEvents integral As System.Windows.Forms.Label
    Friend WithEvents integralL As System.Windows.Forms.Label
    Friend WithEvents integralP As System.Windows.Forms.Label
    Friend WithEvents addVipL As System.Windows.Forms.Label
    Friend WithEvents addVipUser As System.Windows.Forms.Label
    Friend WithEvents msgBL As System.Windows.Forms.Label
    Friend WithEvents VipMsgback As System.Windows.Forms.Label
    Friend WithEvents shut As System.Windows.Forms.PictureBox
    Friend WithEvents msgP As System.Windows.Forms.Label
End Class
