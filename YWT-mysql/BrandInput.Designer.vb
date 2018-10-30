<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrandInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrandInput))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_BbrandNo = New System.Windows.Forms.TextBox()
        Me.LabelCustName = New System.Windows.Forms.Label()
        Me.UIname = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tb_DevName = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OK_Button = New System.Windows.Forms.ToolStripButton()
        Me.Cance_Button = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_BrandName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.DevicebrandTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicebrandTableAdapter()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "品牌编号："
        '
        'Tb_BbrandNo
        '
        Me.Tb_BbrandNo.Enabled = False
        Me.Tb_BbrandNo.Location = New System.Drawing.Point(87, 47)
        Me.Tb_BbrandNo.Name = "Tb_BbrandNo"
        Me.Tb_BbrandNo.Size = New System.Drawing.Size(50, 21)
        Me.Tb_BbrandNo.TabIndex = 20
        '
        'LabelCustName
        '
        Me.LabelCustName.AutoSize = True
        Me.LabelCustName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustName.Location = New System.Drawing.Point(14, 22)
        Me.LabelCustName.Name = "LabelCustName"
        Me.LabelCustName.Size = New System.Drawing.Size(70, 12)
        Me.LabelCustName.TabIndex = 18
        Me.LabelCustName.Text = "设备名称："
        '
        'UIname
        '
        Me.UIname.AutoSize = True
        Me.UIname.Font = New System.Drawing.Font("宋体", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UIname.Location = New System.Drawing.Point(125, 41)
        Me.UIname.Name = "UIname"
        Me.UIname.Size = New System.Drawing.Size(110, 24)
        Me.UIname.TabIndex = 22
        Me.UIname.Text = "品牌信息"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 199)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(360, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Tb_DevName
        '
        Me.Tb_DevName.Enabled = False
        Me.Tb_DevName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Tb_DevName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Tb_DevName.Location = New System.Drawing.Point(87, 19)
        Me.Tb_DevName.Name = "Tb_DevName"
        Me.Tb_DevName.Size = New System.Drawing.Size(220, 21)
        Me.Tb_DevName.TabIndex = 17
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.OK_Button, Me.Cance_Button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(360, 39)
        Me.ToolStrip1.TabIndex = 23
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 12)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "品牌名称："
        '
        'Tb_BrandName
        '
        Me.Tb_BrandName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Tb_BrandName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Tb_BrandName.Location = New System.Drawing.Point(87, 75)
        Me.Tb_BrandName.Name = "Tb_BrandName"
        Me.Tb_BrandName.Size = New System.Drawing.Size(220, 21)
        Me.Tb_BrandName.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tb_BbrandNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LabelCustName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Tb_BrandName)
        Me.GroupBox1.Controls.Add(Me.Tb_DevName)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 113)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "devicebrand"
        Me.BrandBindingSource.DataSource = Me.YwtDataSet
        '
        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevicebrandTableAdapter
        '
        Me.DevicebrandTableAdapter.ClearBeforeFill = True
        '
        'BrandInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 221)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.UIname)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "BrandInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设备品牌录入"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_BbrandNo As TextBox
    Friend WithEvents LabelCustName As Label
    Friend WithEvents UIname As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Tb_DevName As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents OK_Button As ToolStripButton
    Friend WithEvents Cance_Button As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_BrandName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents DevicebrandTableAdapter As ywtDataSetTableAdapters.devicebrandTableAdapter
End Class
