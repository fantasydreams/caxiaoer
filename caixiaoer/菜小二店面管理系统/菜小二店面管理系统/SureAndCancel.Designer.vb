<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SureAndCancel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SureAndCancel))
        Me.NotifyPic = New System.Windows.Forms.PictureBox()
        Me.shut = New System.Windows.Forms.PictureBox()
        Me.caption = New System.Windows.Forms.Label()
        Me.YesL = New System.Windows.Forms.Label()
        Me.yes = New System.Windows.Forms.Label()
        Me.msg = New System.Windows.Forms.Label()
        Me.CancelLine = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Label()
        CType(Me.NotifyPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyPic
        '
        Me.NotifyPic.Location = New System.Drawing.Point(0, 0)
        Me.NotifyPic.Margin = New System.Windows.Forms.Padding(0)
        Me.NotifyPic.Name = "NotifyPic"
        Me.NotifyPic.Size = New System.Drawing.Size(0, 0)
        Me.NotifyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NotifyPic.TabIndex = 0
        Me.NotifyPic.TabStop = False
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
        'caption
        '
        Me.caption.Location = New System.Drawing.Point(0, 0)
        Me.caption.Margin = New System.Windows.Forms.Padding(0)
        Me.caption.Name = "caption"
        Me.caption.Size = New System.Drawing.Size(0, 0)
        Me.caption.TabIndex = 2
        Me.caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YesL
        '
        Me.YesL.Location = New System.Drawing.Point(0, 0)
        Me.YesL.Margin = New System.Windows.Forms.Padding(0)
        Me.YesL.Name = "YesL"
        Me.YesL.Size = New System.Drawing.Size(0, 0)
        Me.YesL.TabIndex = 3
        '
        'yes
        '
        Me.yes.Location = New System.Drawing.Point(0, 0)
        Me.yes.Margin = New System.Windows.Forms.Padding(0)
        Me.yes.Name = "yes"
        Me.yes.Size = New System.Drawing.Size(0, 0)
        Me.yes.TabIndex = 4
        Me.yes.Text = "确定"
        Me.yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'msg
        '
        Me.msg.Location = New System.Drawing.Point(0, 0)
        Me.msg.Margin = New System.Windows.Forms.Padding(0)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(0, 0)
        Me.msg.TabIndex = 5
        Me.msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CancelLine
        '
        Me.CancelLine.Location = New System.Drawing.Point(0, 0)
        Me.CancelLine.Margin = New System.Windows.Forms.Padding(0)
        Me.CancelLine.Name = "CancelLine"
        Me.CancelLine.Size = New System.Drawing.Size(0, 0)
        Me.CancelLine.TabIndex = 6
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(0, 0)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(0, 0)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "取消"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SureAndCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(47, 56)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.CancelLine)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.yes)
        Me.Controls.Add(Me.YesL)
        Me.Controls.Add(Me.caption)
        Me.Controls.Add(Me.shut)
        Me.Controls.Add(Me.NotifyPic)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SureAndCancel"
        CType(Me.NotifyPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyPic As System.Windows.Forms.PictureBox
    Friend WithEvents shut As System.Windows.Forms.PictureBox
    Friend WithEvents caption As System.Windows.Forms.Label
    Friend WithEvents YesL As System.Windows.Forms.Label
    Friend WithEvents yes As System.Windows.Forms.Label
    Friend WithEvents msg As System.Windows.Forms.Label
    Friend WithEvents CancelLine As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Label
End Class
