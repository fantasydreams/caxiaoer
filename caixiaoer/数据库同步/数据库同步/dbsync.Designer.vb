<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.updateDate = New System.Windows.Forms.Timer(Me.components)
        Me.order_status_upload = New System.Windows.Forms.Timer(Me.components)
        Me.update_order_detail = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'updateDate
        '
        Me.updateDate.Enabled = True
        Me.updateDate.Interval = 1500
        '
        'order_status_upload
        '
        Me.order_status_upload.Enabled = True
        Me.order_status_upload.Interval = 2000
        '
        'update_order_detail
        '
        Me.update_order_detail.Enabled = True
        Me.update_order_detail.Interval = 1500
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(163, 90)
        Me.DoubleBuffered = True
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "小二数据库同步系统"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents updateDate As System.Windows.Forms.Timer
    Friend WithEvents order_status_upload As System.Windows.Forms.Timer
    Friend WithEvents update_order_detail As System.Windows.Forms.Timer

End Class
