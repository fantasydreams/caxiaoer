<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.caixiaoer = New System.Windows.Forms.Label()
        Me.PrintLinecolor = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.job_number = New System.Windows.Forms.Label()
        Me.job_number_input = New System.Windows.Forms.TextBox()
        Me.Key = New System.Windows.Forms.Label()
        Me.Key_input = New System.Windows.Forms.TextBox()
        Me.logoin_button = New System.Windows.Forms.Label()
        Me.frist_login = New System.Windows.Forms.Label()
        Me.forgot_key = New System.Windows.Forms.Label()
        Me.shut = New System.Windows.Forms.PictureBox()
        Me.panel = New System.Windows.Forms.Label()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'caixiaoer
        '
        Me.caixiaoer.Location = New System.Drawing.Point(0, 0)
        Me.caixiaoer.Margin = New System.Windows.Forms.Padding(0)
        Me.caixiaoer.Name = "caixiaoer"
        Me.caixiaoer.Size = New System.Drawing.Size(0, 0)
        Me.caixiaoer.TabIndex = 0
        Me.caixiaoer.Text = "菜小二    收银平台"
        '
        'PrintLinecolor
        '
        Me.PrintLinecolor.Location = New System.Drawing.Point(0, 0)
        Me.PrintLinecolor.Margin = New System.Windows.Forms.Padding(0)
        Me.PrintLinecolor.Name = "PrintLinecolor"
        Me.PrintLinecolor.Size = New System.Drawing.Size(0, 0)
        Me.PrintLinecolor.TabIndex = 1
        '
        'logo
        '
        Me.logo.Location = New System.Drawing.Point(0, 0)
        Me.logo.Margin = New System.Windows.Forms.Padding(0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(0, 0)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'job_number
        '
        Me.job_number.Location = New System.Drawing.Point(0, 0)
        Me.job_number.Margin = New System.Windows.Forms.Padding(0)
        Me.job_number.Name = "job_number"
        Me.job_number.Size = New System.Drawing.Size(0, 0)
        Me.job_number.TabIndex = 3
        Me.job_number.Text = "工号："
        '
        'job_number_input
        '
        Me.job_number_input.Location = New System.Drawing.Point(0, 0)
        Me.job_number_input.Margin = New System.Windows.Forms.Padding(0)
        Me.job_number_input.Name = "job_number_input"
        Me.job_number_input.Size = New System.Drawing.Size(0, 21)
        Me.job_number_input.TabIndex = 4
        '
        'Key
        '
        Me.Key.Location = New System.Drawing.Point(0, 0)
        Me.Key.Margin = New System.Windows.Forms.Padding(0)
        Me.Key.Name = "Key"
        Me.Key.Size = New System.Drawing.Size(0, 0)
        Me.Key.TabIndex = 5
        Me.Key.Text = "密码："
        '
        'Key_input
        '
        Me.Key_input.Location = New System.Drawing.Point(0, 0)
        Me.Key_input.Margin = New System.Windows.Forms.Padding(0)
        Me.Key_input.Name = "Key_input"
        Me.Key_input.Size = New System.Drawing.Size(0, 21)
        Me.Key_input.TabIndex = 6
        Me.Key_input.UseSystemPasswordChar = True
        '
        'logoin_button
        '
        Me.logoin_button.Location = New System.Drawing.Point(0, 0)
        Me.logoin_button.Margin = New System.Windows.Forms.Padding(0)
        Me.logoin_button.Name = "logoin_button"
        Me.logoin_button.Size = New System.Drawing.Size(0, 0)
        Me.logoin_button.TabIndex = 7
        Me.logoin_button.Text = "登      录"
        Me.logoin_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frist_login
        '
        Me.frist_login.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.frist_login.Location = New System.Drawing.Point(0, 0)
        Me.frist_login.Margin = New System.Windows.Forms.Padding(0)
        Me.frist_login.Name = "frist_login"
        Me.frist_login.Size = New System.Drawing.Size(0, 0)
        Me.frist_login.TabIndex = 8
        Me.frist_login.Text = "首次登录？"
        '
        'forgot_key
        '
        Me.forgot_key.Location = New System.Drawing.Point(0, 0)
        Me.forgot_key.Margin = New System.Windows.Forms.Padding(0)
        Me.forgot_key.Name = "forgot_key"
        Me.forgot_key.Size = New System.Drawing.Size(0, 0)
        Me.forgot_key.TabIndex = 9
        Me.forgot_key.Text = "忘记密码？"
        '
        'shut
        '
        Me.shut.Location = New System.Drawing.Point(0, 0)
        Me.shut.Margin = New System.Windows.Forms.Padding(0)
        Me.shut.Name = "shut"
        Me.shut.Size = New System.Drawing.Size(0, 0)
        Me.shut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shut.TabIndex = 10
        Me.shut.TabStop = False
        '
        'panel
        '
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Margin = New System.Windows.Forms.Padding(0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(0, 0)
        Me.panel.TabIndex = 11
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(90, 76)
        Me.Controls.Add(Me.shut)
        Me.Controls.Add(Me.forgot_key)
        Me.Controls.Add(Me.frist_login)
        Me.Controls.Add(Me.logoin_button)
        Me.Controls.Add(Me.Key_input)
        Me.Controls.Add(Me.Key)
        Me.Controls.Add(Me.job_number_input)
        Me.Controls.Add(Me.job_number)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.PrintLinecolor)
        Me.Controls.Add(Me.caixiaoer)
        Me.Controls.Add(Me.panel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "login"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents caixiaoer As System.Windows.Forms.Label
    Friend WithEvents PrintLinecolor As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents job_number As System.Windows.Forms.Label
    Friend WithEvents job_number_input As System.Windows.Forms.TextBox
    Friend WithEvents Key As System.Windows.Forms.Label
    Friend WithEvents Key_input As System.Windows.Forms.TextBox
    Friend WithEvents logoin_button As System.Windows.Forms.Label
    Friend WithEvents frist_login As System.Windows.Forms.Label
    Friend WithEvents forgot_key As System.Windows.Forms.Label
    Friend WithEvents shut As System.Windows.Forms.PictureBox
    Friend WithEvents panel As System.Windows.Forms.Label
End Class
