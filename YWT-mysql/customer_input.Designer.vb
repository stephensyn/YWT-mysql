<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customer_input
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer_input))
        Me.UIname = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OK_Button = New System.Windows.Forms.ToolStripButton()
        Me.Cance_Button = New System.Windows.Forms.ToolStripButton()
        Me.LabelCustName = New System.Windows.Forms.Label()
        Me.LabelCustLocation = New System.Windows.Forms.Label()
        Me.LabelCustTel = New System.Windows.Forms.Label()
        Me.LabelCustFax = New System.Windows.Forms.Label()
        Me.LabelCustEmail = New System.Windows.Forms.Label()
        Me.TextBoxCustName = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.TextBoxCustLocation = New System.Windows.Forms.TextBox()
        Me.TextBoxCustEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCustFax = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxCustTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxLevel = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CustomerTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.customerTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UIname
        '
        Me.UIname.AutoSize = True
        Me.UIname.Font = New System.Drawing.Font("宋体", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UIname.Location = New System.Drawing.Point(141, 41)
        Me.UIname.Name = "UIname"
        Me.UIname.Size = New System.Drawing.Size(160, 24)
        Me.UIname.TabIndex = 0
        Me.UIname.Text = "客户信息录入"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.OK_Button, Me.Cance_Button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(443, 39)
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
        'LabelCustName
        '
        Me.LabelCustName.AutoSize = True
        Me.LabelCustName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustName.Location = New System.Drawing.Point(13, 24)
        Me.LabelCustName.Name = "LabelCustName"
        Me.LabelCustName.Size = New System.Drawing.Size(70, 12)
        Me.LabelCustName.TabIndex = 2
        Me.LabelCustName.Text = "客户名称："
        '
        'LabelCustLocation
        '
        Me.LabelCustLocation.AutoSize = True
        Me.LabelCustLocation.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustLocation.Location = New System.Drawing.Point(13, 51)
        Me.LabelCustLocation.Name = "LabelCustLocation"
        Me.LabelCustLocation.Size = New System.Drawing.Size(70, 12)
        Me.LabelCustLocation.TabIndex = 3
        Me.LabelCustLocation.Text = "客户地址："
        '
        'LabelCustTel
        '
        Me.LabelCustTel.AutoSize = True
        Me.LabelCustTel.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustTel.Location = New System.Drawing.Point(39, 78)
        Me.LabelCustTel.Name = "LabelCustTel"
        Me.LabelCustTel.Size = New System.Drawing.Size(44, 12)
        Me.LabelCustTel.TabIndex = 4
        Me.LabelCustTel.Text = "电话："
        '
        'LabelCustFax
        '
        Me.LabelCustFax.AutoSize = True
        Me.LabelCustFax.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustFax.Location = New System.Drawing.Point(39, 132)
        Me.LabelCustFax.Name = "LabelCustFax"
        Me.LabelCustFax.Size = New System.Drawing.Size(44, 12)
        Me.LabelCustFax.TabIndex = 5
        Me.LabelCustFax.Text = "传真："
        '
        'LabelCustEmail
        '
        Me.LabelCustEmail.AutoSize = True
        Me.LabelCustEmail.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustEmail.Location = New System.Drawing.Point(39, 105)
        Me.LabelCustEmail.Name = "LabelCustEmail"
        Me.LabelCustEmail.Size = New System.Drawing.Size(44, 12)
        Me.LabelCustEmail.TabIndex = 6
        Me.LabelCustEmail.Text = "邮箱："
        '
        'TextBoxCustName
        '
        Me.TextBoxCustName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxCustName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TextBoxCustName.Location = New System.Drawing.Point(86, 21)
        Me.TextBoxCustName.Name = "TextBoxCustName"
        Me.TextBoxCustName.Size = New System.Drawing.Size(300, 21)
        Me.TextBoxCustName.TabIndex = 1
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.YwtDataSet
        '
        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxCustLocation
        '
        Me.TextBoxCustLocation.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxCustLocation.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TextBoxCustLocation.Location = New System.Drawing.Point(86, 48)
        Me.TextBoxCustLocation.Name = "TextBoxCustLocation"
        Me.TextBoxCustLocation.Size = New System.Drawing.Size(300, 21)
        Me.TextBoxCustLocation.TabIndex = 2
        '
        'TextBoxCustEmail
        '
        Me.TextBoxCustEmail.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxCustEmail.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBoxCustEmail.Location = New System.Drawing.Point(86, 102)
        Me.TextBoxCustEmail.Name = "TextBoxCustEmail"
        Me.TextBoxCustEmail.Size = New System.Drawing.Size(120, 21)
        Me.TextBoxCustEmail.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxCustFax)
        Me.GroupBox1.Controls.Add(Me.TextBoxCustTel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxLevel)
        Me.GroupBox1.Controls.Add(Me.LabelCustName)
        Me.GroupBox1.Controls.Add(Me.TextBoxCustEmail)
        Me.GroupBox1.Controls.Add(Me.LabelCustLocation)
        Me.GroupBox1.Controls.Add(Me.LabelCustTel)
        Me.GroupBox1.Controls.Add(Me.LabelCustFax)
        Me.GroupBox1.Controls.Add(Me.TextBoxCustLocation)
        Me.GroupBox1.Controls.Add(Me.LabelCustEmail)
        Me.GroupBox1.Controls.Add(Me.TextBoxCustName)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 166)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'TextBoxCustFax
        '
        Me.TextBoxCustFax.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.TextBoxCustFax.Location = New System.Drawing.Point(86, 129)
        Me.TextBoxCustFax.Mask = "000-0000-0000"
        Me.TextBoxCustFax.Name = "TextBoxCustFax"
        Me.TextBoxCustFax.Size = New System.Drawing.Size(120, 21)
        Me.TextBoxCustFax.TabIndex = 5
        '
        'TextBoxCustTel
        '
        Me.TextBoxCustTel.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.TextBoxCustTel.Location = New System.Drawing.Point(86, 75)
        Me.TextBoxCustTel.Mask = "000-0000-0000"
        Me.TextBoxCustTel.Name = "TextBoxCustTel"
        Me.TextBoxCustTel.Size = New System.Drawing.Size(120, 21)
        Me.TextBoxCustTel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "编号："
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(315, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(46, 21)
        Me.TextBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "级别："
        '
        'TextBoxLevel
        '
        Me.TextBoxLevel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBoxLevel.Location = New System.Drawing.Point(315, 129)
        Me.TextBoxLevel.Name = "TextBoxLevel"
        Me.TextBoxLevel.Size = New System.Drawing.Size(46, 21)
        Me.TextBoxLevel.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StripStatusLabel, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 254)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(443, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StripStatusLabel
        '
        Me.StripStatusLabel.Name = "StripStatusLabel"
        Me.StripStatusLabel.Size = New System.Drawing.Size(12, 17)
        Me.StripStatusLabel.Text = " "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'customer_input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(443, 276)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.UIname)
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "customer_input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "客户信息录入"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub YwtDataSet_Initialized(sender As Object, e As EventArgs) Handles YwtDataSet.Initialized

    End Sub

    Private Sub YwtDataSet_Disposed(sender As Object, e As EventArgs) Handles YwtDataSet.Disposed

    End Sub

    Friend WithEvents UIname As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents OK_Button As ToolStripButton
    Friend WithEvents Cance_Button As ToolStripButton
    Friend WithEvents LabelCustName As Label
    Friend WithEvents LabelCustLocation As Label
    Friend WithEvents LabelCustTel As Label
    Friend WithEvents LabelCustFax As Label
    Friend WithEvents LabelCustEmail As Label
    Friend WithEvents TextBoxCustName As TextBox
    Friend WithEvents TextBoxCustLocation As TextBox
    Friend WithEvents TextBoxCustEmail As TextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ywtDataSetTableAdapters.customerTableAdapter
    Friend WithEvents StripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TextBoxLevel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCustFax As MaskedTextBox
    Friend WithEvents TextBoxCustTel As MaskedTextBox
End Class
