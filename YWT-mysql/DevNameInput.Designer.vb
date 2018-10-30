<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevNameInput
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevNameInput))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OK_Button = New System.Windows.Forms.ToolStripButton()
        Me.Cance_Button = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_DevNo = New System.Windows.Forms.TextBox()
        Me.LabelCustName = New System.Windows.Forms.Label()
        Me.Tb_DevName = New System.Windows.Forms.TextBox()
        Me.UIname = New System.Windows.Forms.Label()
        Me.DevNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.DevicenameTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicenameTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DevNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.OK_Button, Me.Cance_Button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(365, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'OK_Button
        '
        Me.OK_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(36, 36)
        Me.OK_Button.Text = "确认"
        Me.OK_Button.ToolTipText = "确认保存"
        '
        'Cance_Button
        '
        Me.Cance_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cance_Button.Image = CType(resources.GetObject("Cance_Button.Image"), System.Drawing.Image)
        Me.Cance_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cance_Button.Name = "Cance_Button"
        Me.Cance_Button.Size = New System.Drawing.Size(36, 36)
        Me.Cance_Button.Text = "放弃"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 171)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(365, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "编号："
        '
        'Tb_DevNo
        '
        Me.Tb_DevNo.Enabled = False
        Me.Tb_DevNo.Location = New System.Drawing.Point(85, 14)
        Me.Tb_DevNo.Name = "Tb_DevNo"
        Me.Tb_DevNo.Size = New System.Drawing.Size(46, 21)
        Me.Tb_DevNo.TabIndex = 14
        '
        'LabelCustName
        '
        Me.LabelCustName.AutoSize = True
        Me.LabelCustName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustName.Location = New System.Drawing.Point(12, 44)
        Me.LabelCustName.Name = "LabelCustName"
        Me.LabelCustName.Size = New System.Drawing.Size(70, 12)
        Me.LabelCustName.TabIndex = 2
        Me.LabelCustName.Text = "设备名称："
        '
        'Tb_DevName
        '
        Me.Tb_DevName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Tb_DevName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Tb_DevName.Location = New System.Drawing.Point(85, 41)
        Me.Tb_DevName.Name = "Tb_DevName"
        Me.Tb_DevName.Size = New System.Drawing.Size(220, 21)
        Me.Tb_DevName.TabIndex = 0
        '
        'UIname
        '
        Me.UIname.AutoSize = True
        Me.UIname.Font = New System.Drawing.Font("宋体", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UIname.Location = New System.Drawing.Point(127, 41)
        Me.UIname.Name = "UIname"
        Me.UIname.Size = New System.Drawing.Size(110, 24)
        Me.UIname.TabIndex = 16
        Me.UIname.Text = "设备名称"
        '
        'DevNameBindingSource
        '
        Me.DevNameBindingSource.DataMember = "devicename"
        Me.DevNameBindingSource.DataSource = Me.YwtDataSet
        '
        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevicenameTableAdapter
        '
        Me.DevicenameTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Tb_DevName)
        Me.GroupBox1.Controls.Add(Me.Tb_DevNo)
        Me.GroupBox1.Controls.Add(Me.LabelCustName)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 82)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'DevNameInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 193)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UIname)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DevNameInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设备名称录入"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DevNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents OK_Button As ToolStripButton
    Friend WithEvents Cance_Button As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_DevNo As TextBox
    Friend WithEvents LabelCustName As Label
    Friend WithEvents Tb_DevName As TextBox
    Friend WithEvents UIname As Label
    Friend WithEvents DevNameBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents DevicenameTableAdapter As ywtDataSetTableAdapters.devicenameTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
End Class
