<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RepairOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CusMyComboBox = New NewCtl3.MyComboBox()
        Me.ConMyComboBox = New NewCtl3.MyComboBox()
        Me.ConBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevMyComboBox = New NewCtl3.MyComboBox()
        Me.BrandMyComboBox = New NewCtl3.MyComboBox()
        Me.ModelMyComboBox = New NewCtl3.MyComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OrderTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.orderTableAdapter()
        Me.CusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.customerTableAdapter()
        Me.ContactsTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.contactsTableAdapter()
        Me.DevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevicenameTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicenameTableAdapter()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevicebrandTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicebrandTableAdapter()
        Me.ModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevicemodelTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicemodelTableAdapter()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.维修单号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.接件日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.客户名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.联系人DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.电话DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备品牌DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备型号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备编号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.模块名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.模块编号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.随机附件DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.故障详情DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.维修单号DataGridViewTextBoxColumn, Me.接件日期DataGridViewTextBoxColumn, Me.客户名称DataGridViewTextBoxColumn, Me.联系人DataGridViewTextBoxColumn, Me.电话DataGridViewTextBoxColumn, Me.设备名称DataGridViewTextBoxColumn, Me.设备品牌DataGridViewTextBoxColumn, Me.设备型号DataGridViewTextBoxColumn, Me.设备编号DataGridViewTextBoxColumn, Me.模块名称DataGridViewTextBoxColumn, Me.模块编号DataGridViewTextBoxColumn, Me.随机附件DataGridViewTextBoxColumn, Me.故障详情DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RepairOrderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(37, 78)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1296, 332)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.VirtualMode = True
        '
        'RepairOrderBindingSource
        '
        Me.RepairOrderBindingSource.DataMember = "order"
        Me.RepairOrderBindingSource.DataSource = Me.YwtDataSet
        '
        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "客户名称"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "联系人"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(627, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "设备名称"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(874, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "设备品牌"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1127, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "设备型号"
        '
        'CusMyComboBox
        '
        Me.CusMyComboBox.DataSouce = Nothing
        Me.CusMyComboBox.DisplayMember = "Id"
        Me.CusMyComboBox.DropDown = False
        Me.CusMyComboBox.FilterColumnName = "Pyindex"
        Me.CusMyComboBox.IsNew = False
        Me.CusMyComboBox.Location = New System.Drawing.Point(112, 422)
        Me.CusMyComboBox.Name = "CusMyComboBox"
        Me.CusMyComboBox.RowMount = 5
        Me.CusMyComboBox.Size = New System.Drawing.Size(314, 25)
        Me.CusMyComboBox.TabIndex = 11
        Me.CusMyComboBox.Tag = Nothing
        Me.CusMyComboBox.ValueMember = "Id"
        '
        'ConMyComboBox
        '
        Me.ConMyComboBox.DataSouce = Me.ConBindingSource
        Me.ConMyComboBox.DisplayMember = "ContactsName"
        Me.ConMyComboBox.DropDown = False
        Me.ConMyComboBox.FilterColumnName = "Pyindex"
        Me.ConMyComboBox.IsNew = False
        Me.ConMyComboBox.Location = New System.Drawing.Point(513, 420)
        Me.ConMyComboBox.Name = "ConMyComboBox"
        Me.ConMyComboBox.RowMount = 5
        Me.ConMyComboBox.Size = New System.Drawing.Size(81, 21)
        Me.ConMyComboBox.TabIndex = 12
        Me.ConMyComboBox.Tag = Nothing
        Me.ConMyComboBox.ValueMember = "Id"
        '
        'ConBindingSource
        '
        Me.ConBindingSource.DataMember = "contacts"
        Me.ConBindingSource.DataSource = Me.YwtDataSet
        '
        'DevMyComboBox
        '
        Me.DevMyComboBox.DataSouce = Nothing
        Me.DevMyComboBox.DisplayMember = ""
        Me.DevMyComboBox.DropDown = False
        Me.DevMyComboBox.FilterColumnName = Nothing
        Me.DevMyComboBox.IsNew = False
        Me.DevMyComboBox.Location = New System.Drawing.Point(684, 420)
        Me.DevMyComboBox.Name = "DevMyComboBox"
        Me.DevMyComboBox.RowMount = 3
        Me.DevMyComboBox.Size = New System.Drawing.Size(160, 21)
        Me.DevMyComboBox.TabIndex = 13
        Me.DevMyComboBox.Tag = Nothing
        Me.DevMyComboBox.ValueMember = ""
        '
        'BrandMyComboBox
        '
        Me.BrandMyComboBox.DataSouce = Nothing
        Me.BrandMyComboBox.DisplayMember = ""
        Me.BrandMyComboBox.DropDown = False
        Me.BrandMyComboBox.FilterColumnName = Nothing
        Me.BrandMyComboBox.IsNew = False
        Me.BrandMyComboBox.Location = New System.Drawing.Point(931, 420)
        Me.BrandMyComboBox.Name = "BrandMyComboBox"
        Me.BrandMyComboBox.RowMount = 3
        Me.BrandMyComboBox.Size = New System.Drawing.Size(160, 21)
        Me.BrandMyComboBox.TabIndex = 14
        Me.BrandMyComboBox.Tag = Nothing
        Me.BrandMyComboBox.ValueMember = ""
        '
        'ModelMyComboBox
        '
        Me.ModelMyComboBox.DataSouce = Nothing
        Me.ModelMyComboBox.DisplayMember = ""
        Me.ModelMyComboBox.DropDown = False
        Me.ModelMyComboBox.FilterColumnName = Nothing
        Me.ModelMyComboBox.IsNew = False
        Me.ModelMyComboBox.Location = New System.Drawing.Point(1184, 420)
        Me.ModelMyComboBox.Name = "ModelMyComboBox"
        Me.ModelMyComboBox.RowMount = 3
        Me.ModelMyComboBox.Size = New System.Drawing.Size(160, 21)
        Me.ModelMyComboBox.TabIndex = 15
        Me.ModelMyComboBox.Tag = Nothing
        Me.ModelMyComboBox.ValueMember = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(665, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "综合查询"
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'CusBindingSource
        '
        Me.CusBindingSource.DataMember = "customer"
        Me.CusBindingSource.DataSource = Me.YwtDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'DevBindingSource
        '
        Me.DevBindingSource.DataMember = "devicename"
        Me.DevBindingSource.DataSource = Me.YwtDataSet
        '
        'DevicenameTableAdapter
        '
        Me.DevicenameTableAdapter.ClearBeforeFill = True
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "devicebrand"
        Me.BrandBindingSource.DataSource = Me.YwtDataSet
        '
        'DevicebrandTableAdapter
        '
        Me.DevicebrandTableAdapter.ClearBeforeFill = True
        '
        'ModelBindingSource
        '
        Me.ModelBindingSource.DataMember = "devicemodel"
        Me.ModelBindingSource.DataSource = Me.YwtDataSet
        '
        'DevicemodelTableAdapter
        '
        Me.DevicemodelTableAdapter.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowCheckMargin = True
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(218, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        '维修单号DataGridViewTextBoxColumn
        '
        Me.维修单号DataGridViewTextBoxColumn.DataPropertyName = "维修单号"
        Me.维修单号DataGridViewTextBoxColumn.HeaderText = "单号"
        Me.维修单号DataGridViewTextBoxColumn.Name = "维修单号DataGridViewTextBoxColumn"
        Me.维修单号DataGridViewTextBoxColumn.ReadOnly = True
        Me.维修单号DataGridViewTextBoxColumn.Width = 60
        '
        '接件日期DataGridViewTextBoxColumn
        '
        Me.接件日期DataGridViewTextBoxColumn.DataPropertyName = "接件日期"
        Me.接件日期DataGridViewTextBoxColumn.HeaderText = "日期"
        Me.接件日期DataGridViewTextBoxColumn.Name = "接件日期DataGridViewTextBoxColumn"
        Me.接件日期DataGridViewTextBoxColumn.ReadOnly = True
        Me.接件日期DataGridViewTextBoxColumn.Width = 80
        '
        '客户名称DataGridViewTextBoxColumn
        '
        Me.客户名称DataGridViewTextBoxColumn.ContextMenuStrip = Me.ContextMenuStrip1
        Me.客户名称DataGridViewTextBoxColumn.DataPropertyName = "客户名称"
        Me.客户名称DataGridViewTextBoxColumn.HeaderText = "客户名称"
        Me.客户名称DataGridViewTextBoxColumn.Name = "客户名称DataGridViewTextBoxColumn"
        Me.客户名称DataGridViewTextBoxColumn.ReadOnly = True
        Me.客户名称DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.客户名称DataGridViewTextBoxColumn.Width = 160
        '
        '联系人DataGridViewTextBoxColumn
        '
        Me.联系人DataGridViewTextBoxColumn.DataPropertyName = "联系人"
        Me.联系人DataGridViewTextBoxColumn.HeaderText = "联系人"
        Me.联系人DataGridViewTextBoxColumn.Name = "联系人DataGridViewTextBoxColumn"
        Me.联系人DataGridViewTextBoxColumn.ReadOnly = True
        Me.联系人DataGridViewTextBoxColumn.Width = 70
        '
        '电话DataGridViewTextBoxColumn
        '
        Me.电话DataGridViewTextBoxColumn.DataPropertyName = "电话"
        Me.电话DataGridViewTextBoxColumn.HeaderText = "电话"
        Me.电话DataGridViewTextBoxColumn.Name = "电话DataGridViewTextBoxColumn"
        Me.电话DataGridViewTextBoxColumn.ReadOnly = True
        '
        '设备名称DataGridViewTextBoxColumn
        '
        Me.设备名称DataGridViewTextBoxColumn.DataPropertyName = "设备名称"
        Me.设备名称DataGridViewTextBoxColumn.HeaderText = "设备名称"
        Me.设备名称DataGridViewTextBoxColumn.Name = "设备名称DataGridViewTextBoxColumn"
        Me.设备名称DataGridViewTextBoxColumn.ReadOnly = True
        '
        '设备品牌DataGridViewTextBoxColumn
        '
        Me.设备品牌DataGridViewTextBoxColumn.DataPropertyName = "设备品牌"
        Me.设备品牌DataGridViewTextBoxColumn.HeaderText = "设备品牌"
        Me.设备品牌DataGridViewTextBoxColumn.Name = "设备品牌DataGridViewTextBoxColumn"
        Me.设备品牌DataGridViewTextBoxColumn.ReadOnly = True
        '
        '设备型号DataGridViewTextBoxColumn
        '
        Me.设备型号DataGridViewTextBoxColumn.DataPropertyName = "设备型号"
        Me.设备型号DataGridViewTextBoxColumn.HeaderText = "设备型号"
        Me.设备型号DataGridViewTextBoxColumn.Name = "设备型号DataGridViewTextBoxColumn"
        Me.设备型号DataGridViewTextBoxColumn.ReadOnly = True
        '
        '设备编号DataGridViewTextBoxColumn
        '
        Me.设备编号DataGridViewTextBoxColumn.DataPropertyName = "设备编号"
        Me.设备编号DataGridViewTextBoxColumn.HeaderText = "设备编号"
        Me.设备编号DataGridViewTextBoxColumn.Name = "设备编号DataGridViewTextBoxColumn"
        Me.设备编号DataGridViewTextBoxColumn.ReadOnly = True
        '
        '模块名称DataGridViewTextBoxColumn
        '
        Me.模块名称DataGridViewTextBoxColumn.DataPropertyName = "模块名称"
        Me.模块名称DataGridViewTextBoxColumn.HeaderText = "模块名称"
        Me.模块名称DataGridViewTextBoxColumn.Name = "模块名称DataGridViewTextBoxColumn"
        Me.模块名称DataGridViewTextBoxColumn.ReadOnly = True
        '
        '模块编号DataGridViewTextBoxColumn
        '
        Me.模块编号DataGridViewTextBoxColumn.DataPropertyName = "模块编号"
        Me.模块编号DataGridViewTextBoxColumn.HeaderText = "模块编号"
        Me.模块编号DataGridViewTextBoxColumn.Name = "模块编号DataGridViewTextBoxColumn"
        Me.模块编号DataGridViewTextBoxColumn.ReadOnly = True
        '
        '随机附件DataGridViewTextBoxColumn
        '
        Me.随机附件DataGridViewTextBoxColumn.DataPropertyName = "随机附件"
        Me.随机附件DataGridViewTextBoxColumn.HeaderText = "随机附件"
        Me.随机附件DataGridViewTextBoxColumn.Name = "随机附件DataGridViewTextBoxColumn"
        Me.随机附件DataGridViewTextBoxColumn.ReadOnly = True
        '
        '故障详情DataGridViewTextBoxColumn
        '
        Me.故障详情DataGridViewTextBoxColumn.DataPropertyName = "故障详情"
        Me.故障详情DataGridViewTextBoxColumn.HeaderText = "故障详情"
        Me.故障详情DataGridViewTextBoxColumn.Name = "故障详情DataGridViewTextBoxColumn"
        Me.故障详情DataGridViewTextBoxColumn.ReadOnly = True
        Me.故障详情DataGridViewTextBoxColumn.Width = 120
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 626)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ModelMyComboBox)
        Me.Controls.Add(Me.BrandMyComboBox)
        Me.Controls.Add(Me.DevMyComboBox)
        Me.Controls.Add(Me.ConMyComboBox)
        Me.Controls.Add(Me.CusMyComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RepairOrderBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents OrderTableAdapter As ywtDataSetTableAdapters.orderTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CusBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ywtDataSetTableAdapters.customerTableAdapter
    Friend WithEvents ConBindingSource As BindingSource
    Friend WithEvents ContactsTableAdapter As ywtDataSetTableAdapters.contactsTableAdapter
    Friend WithEvents DevBindingSource As BindingSource
    Friend WithEvents DevicenameTableAdapter As ywtDataSetTableAdapters.devicenameTableAdapter
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents DevicebrandTableAdapter As ywtDataSetTableAdapters.devicebrandTableAdapter
    Friend WithEvents ModelBindingSource As BindingSource
    Friend WithEvents DevicemodelTableAdapter As ywtDataSetTableAdapters.devicemodelTableAdapter
    Friend WithEvents CusMyComboBox As NewCtl3.MyComboBox
    Friend WithEvents ConMyComboBox As NewCtl3.MyComboBox
    Friend WithEvents DevMyComboBox As NewCtl3.MyComboBox
    Friend WithEvents BrandMyComboBox As NewCtl3.MyComboBox
    Friend WithEvents ModelMyComboBox As NewCtl3.MyComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents 维修单号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 接件日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 客户名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 联系人DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 电话DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备品牌DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备型号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备编号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 模块名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 模块编号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 随机附件DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 故障详情DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
