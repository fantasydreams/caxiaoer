<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resetKey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resetKey))
        Me.Reset_p = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Label()
        Me.jobsNum = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.jobNum_IO = New System.Windows.Forms.TextBox()
        Me.phone_p = New System.Windows.Forms.Label()
        Me.identifyingCode_line = New System.Windows.Forms.Label()
        Me.identifyingcode = New System.Windows.Forms.Label()
        Me.Key_IO = New System.Windows.Forms.Label()
        Me.Key_IAO = New System.Windows.Forms.TextBox()
        Me.confirmKey = New System.Windows.Forms.Label()
        Me.confirmKey_IO = New System.Windows.Forms.TextBox()
        Me.identity = New System.Windows.Forms.Label()
        Me.identity_IO = New System.Windows.Forms.TextBox()
        Me.resetLine = New System.Windows.Forms.Label()
        Me.reset_key = New System.Windows.Forms.Label()
        Me.shut = New System.Windows.Forms.PictureBox()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reset_p
        '
        Me.Reset_p.Location = New System.Drawing.Point(0, 0)
        Me.Reset_p.Margin = New System.Windows.Forms.Padding(0)
        Me.Reset_p.Name = "Reset_p"
        Me.Reset_p.Size = New System.Drawing.Size(0, 0)
        Me.Reset_p.TabIndex = 0
        Me.Reset_p.Text = "重置密码"
        Me.Reset_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel
        '
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(0, 0)
        Me.Panel.TabIndex = 1
        '
        'jobsNum
        '
        Me.jobsNum.Location = New System.Drawing.Point(0, 0)
        Me.jobsNum.Name = "jobsNum"
        Me.jobsNum.Size = New System.Drawing.Size(0, 0)
        Me.jobsNum.TabIndex = 2
        Me.jobsNum.Text = "工    号："
        Me.jobsNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(0, 0)
        Me.phone.Margin = New System.Windows.Forms.Padding(0)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(0, 0)
        Me.phone.TabIndex = 3
        Me.phone.Text = "联系方式："
        Me.phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'jobNum_IO
        '
        Me.jobNum_IO.Location = New System.Drawing.Point(0, 0)
        Me.jobNum_IO.Margin = New System.Windows.Forms.Padding(0)
        Me.jobNum_IO.Name = "jobNum_IO"
        Me.jobNum_IO.Size = New System.Drawing.Size(0, 21)
        Me.jobNum_IO.TabIndex = 4
        '
        'phone_p
        '
        Me.phone_p.Location = New System.Drawing.Point(0, 0)
        Me.phone_p.Name = "phone_p"
        Me.phone_p.Size = New System.Drawing.Size(0, 0)
        Me.phone_p.TabIndex = 5
        Me.phone_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'identifyingCode_line
        '
        Me.identifyingCode_line.Location = New System.Drawing.Point(0, 0)
        Me.identifyingCode_line.Name = "identifyingCode_line"
        Me.identifyingCode_line.Size = New System.Drawing.Size(0, 0)
        Me.identifyingCode_line.TabIndex = 6
        '
        'identifyingcode
        '
        Me.identifyingcode.Location = New System.Drawing.Point(0, 0)
        Me.identifyingcode.Margin = New System.Windows.Forms.Padding(0)
        Me.identifyingcode.Name = "identifyingcode"
        Me.identifyingcode.Size = New System.Drawing.Size(0, 0)
        Me.identifyingcode.TabIndex = 7
        Me.identifyingcode.Text = "获取验证码"
        Me.identifyingcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Key_IO
        '
        Me.Key_IO.Location = New System.Drawing.Point(0, 0)
        Me.Key_IO.Name = "Key_IO"
        Me.Key_IO.Size = New System.Drawing.Size(0, 0)
        Me.Key_IO.TabIndex = 8
        Me.Key_IO.Text = "输入密码："
        Me.Key_IO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Key_IAO
        '
        Me.Key_IAO.Location = New System.Drawing.Point(0, 0)
        Me.Key_IAO.Name = "Key_IAO"
        Me.Key_IAO.Size = New System.Drawing.Size(0, 21)
        Me.Key_IAO.TabIndex = 9
        Me.Key_IAO.UseSystemPasswordChar = True
        '
        'confirmKey
        '
        Me.confirmKey.Location = New System.Drawing.Point(0, 0)
        Me.confirmKey.Name = "confirmKey"
        Me.confirmKey.Size = New System.Drawing.Size(0, 0)
        Me.confirmKey.TabIndex = 10
        Me.confirmKey.Text = "确认密码："
        Me.confirmKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'confirmKey_IO
        '
        Me.confirmKey_IO.Location = New System.Drawing.Point(0, 0)
        Me.confirmKey_IO.Name = "confirmKey_IO"
        Me.confirmKey_IO.Size = New System.Drawing.Size(0, 21)
        Me.confirmKey_IO.TabIndex = 11
        Me.confirmKey_IO.UseSystemPasswordChar = True
        '
        'identity
        '
        Me.identity.Location = New System.Drawing.Point(0, 0)
        Me.identity.Name = "identity"
        Me.identity.Size = New System.Drawing.Size(0, 0)
        Me.identity.TabIndex = 12
        Me.identity.Text = "短信验证码："
        Me.identity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'identity_IO
        '
        Me.identity_IO.Location = New System.Drawing.Point(0, 0)
        Me.identity_IO.Name = "identity_IO"
        Me.identity_IO.Size = New System.Drawing.Size(0, 21)
        Me.identity_IO.TabIndex = 13
        '
        'resetLine
        '
        Me.resetLine.Location = New System.Drawing.Point(0, 0)
        Me.resetLine.Name = "resetLine"
        Me.resetLine.Size = New System.Drawing.Size(0, 0)
        Me.resetLine.TabIndex = 14
        '
        'reset_key
        '
        Me.reset_key.Location = New System.Drawing.Point(0, 0)
        Me.reset_key.Name = "reset_key"
        Me.reset_key.Size = New System.Drawing.Size(0, 0)
        Me.reset_key.TabIndex = 15
        Me.reset_key.Text = "重置密码"
        Me.reset_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shut
        '
        Me.shut.Location = New System.Drawing.Point(0, 0)
        Me.shut.Margin = New System.Windows.Forms.Padding(0)
        Me.shut.Name = "shut"
        Me.shut.Size = New System.Drawing.Size(0, 0)
        Me.shut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shut.TabIndex = 16
        Me.shut.TabStop = False
        '
        'resetKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(32, 33)
        Me.Controls.Add(Me.shut)
        Me.Controls.Add(Me.reset_key)
        Me.Controls.Add(Me.resetLine)
        Me.Controls.Add(Me.identity_IO)
        Me.Controls.Add(Me.identity)
        Me.Controls.Add(Me.confirmKey_IO)
        Me.Controls.Add(Me.confirmKey)
        Me.Controls.Add(Me.Key_IAO)
        Me.Controls.Add(Me.Key_IO)
        Me.Controls.Add(Me.identifyingcode)
        Me.Controls.Add(Me.identifyingCode_line)
        Me.Controls.Add(Me.phone_p)
        Me.Controls.Add(Me.jobNum_IO)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.jobsNum)
        Me.Controls.Add(Me.Reset_p)
        Me.Controls.Add(Me.Panel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "resetKey"
        Me.Text = "resetKey"
        CType(Me.shut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Reset_p As System.Windows.Forms.Label
    Friend WithEvents Panel As System.Windows.Forms.Label
    Friend WithEvents jobsNum As System.Windows.Forms.Label
    Friend WithEvents phone As System.Windows.Forms.Label
    Friend WithEvents jobNum_IO As System.Windows.Forms.TextBox
    Friend WithEvents phone_p As System.Windows.Forms.Label
    Friend WithEvents identifyingCode_line As System.Windows.Forms.Label
    Friend WithEvents identifyingcode As System.Windows.Forms.Label
    Friend WithEvents Key_IO As System.Windows.Forms.Label
    Friend WithEvents Key_IAO As System.Windows.Forms.TextBox
    Friend WithEvents confirmKey As System.Windows.Forms.Label
    Friend WithEvents confirmKey_IO As System.Windows.Forms.TextBox
    Friend WithEvents identity As System.Windows.Forms.Label
    Friend WithEvents identity_IO As System.Windows.Forms.TextBox
    Friend WithEvents resetLine As System.Windows.Forms.Label
    Friend WithEvents reset_key As System.Windows.Forms.Label
    Friend WithEvents shut As System.Windows.Forms.PictureBox
End Class
