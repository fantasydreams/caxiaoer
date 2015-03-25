<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productPicdetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productPicdetail))
        Me.shut = New System.Windows.Forms.PictureBox()
        Me.picP = New System.Windows.Forms.PictureBox()
        CType(Me.shut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'picP
        '
        Me.picP.Location = New System.Drawing.Point(0, 0)
        Me.picP.Margin = New System.Windows.Forms.Padding(0)
        Me.picP.Name = "picP"
        Me.picP.Size = New System.Drawing.Size(0, 0)
        Me.picP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picP.TabIndex = 2
        Me.picP.TabStop = False
        '
        'productPicdetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(98, 81)
        Me.Controls.Add(Me.shut)
        Me.Controls.Add(Me.picP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "productPicdetail"
        Me.Text = "productPicdetail"
        CType(Me.shut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents shut As System.Windows.Forms.PictureBox
    Friend WithEvents picP As System.Windows.Forms.PictureBox
End Class
