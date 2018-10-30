<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.DevicemodelTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicemodelTableAdapter()
        Me.RepairOrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairorderTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.repairorderTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.orderTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.维修单号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.处理详情 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.接件日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.客户名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.联系人DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备品牌DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备型号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备编号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.模块名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.模块编号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.随机附件DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.故障详情DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactsIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceNameIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceBrandIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceModelIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairOrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " "
        '
        'ModelBindingSource
        '
        Me.ModelBindingSource.DataMember = "devicemodel"
        Me.ModelBindingSource.DataSource = Me.YwtDataSet
        '
        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevicemodelTableAdapter
        '
        Me.DevicemodelTableAdapter.ClearBeforeFill = True
        '
        'RepairOrBindingSource
        '
        Me.RepairOrBindingSource.DataMember = "repairorder"
        Me.RepairOrBindingSource.DataSource = Me.YwtDataSet
        '
        'RepairorderTableAdapter
        '
        Me.RepairorderTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(311, 398)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 21)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(778, 386)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 21)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(930, 386)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 21)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1082, 386)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(146, 21)
        Me.TextBox4.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "order"
        Me.OrderBindingSource.DataSource = Me.YwtDataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.维修单号DataGridViewTextBoxColumn, Me.处理详情, Me.接件日期DataGridViewTextBoxColumn, Me.客户名称DataGridViewTextBoxColumn, Me.联系人DataGridViewTextBoxColumn, Me.设备名称DataGridViewTextBoxColumn, Me.设备品牌DataGridViewTextBoxColumn, Me.设备型号DataGridViewTextBoxColumn, Me.设备编号DataGridViewTextBoxColumn, Me.模块名称DataGridViewTextBoxColumn, Me.模块编号DataGridViewTextBoxColumn, Me.随机附件DataGridViewTextBoxColumn, Me.故障详情DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(53, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(590, 314)
        Me.DataGridView1.TabIndex = 11
        '
        '维修单号DataGridViewTextBoxColumn
        '
        Me.维修单号DataGridViewTextBoxColumn.DataPropertyName = "维修单号"
        Me.维修单号DataGridViewTextBoxColumn.HeaderText = "维修单号"
        Me.维修单号DataGridViewTextBoxColumn.Name = "维修单号DataGridViewTextBoxColumn"
        '
        '处理详情
        '
        Me.处理详情.DataPropertyName = "处理详情"
        Me.处理详情.HeaderText = "处理详情"
        Me.处理详情.Name = "处理详情"
        '
        '接件日期DataGridViewTextBoxColumn
        '
        Me.接件日期DataGridViewTextBoxColumn.DataPropertyName = "接件日期"
        Me.接件日期DataGridViewTextBoxColumn.HeaderText = "接件日期"
        Me.接件日期DataGridViewTextBoxColumn.Name = "接件日期DataGridViewTextBoxColumn"
        '
        '客户名称DataGridViewTextBoxColumn
        '
        Me.客户名称DataGridViewTextBoxColumn.DataPropertyName = "客户名称"
        Me.客户名称DataGridViewTextBoxColumn.HeaderText = "客户名称"
        Me.客户名称DataGridViewTextBoxColumn.Name = "客户名称DataGridViewTextBoxColumn"
        '
        '联系人DataGridViewTextBoxColumn
        '
        Me.联系人DataGridViewTextBoxColumn.DataPropertyName = "联系人"
        Me.联系人DataGridViewTextBoxColumn.HeaderText = "联系人"
        Me.联系人DataGridViewTextBoxColumn.Name = "联系人DataGridViewTextBoxColumn"
        '
        '设备名称DataGridViewTextBoxColumn
        '
        Me.设备名称DataGridViewTextBoxColumn.DataPropertyName = "设备名称"
        Me.设备名称DataGridViewTextBoxColumn.HeaderText = "设备名称"
        Me.设备名称DataGridViewTextBoxColumn.Name = "设备名称DataGridViewTextBoxColumn"
        '
        '设备品牌DataGridViewTextBoxColumn
        '
        Me.设备品牌DataGridViewTextBoxColumn.DataPropertyName = "设备品牌"
        Me.设备品牌DataGridViewTextBoxColumn.HeaderText = "设备品牌"
        Me.设备品牌DataGridViewTextBoxColumn.Name = "设备品牌DataGridViewTextBoxColumn"
        '
        '设备型号DataGridViewTextBoxColumn
        '
        Me.设备型号DataGridViewTextBoxColumn.DataPropertyName = "设备型号"
        Me.设备型号DataGridViewTextBoxColumn.HeaderText = "设备型号"
        Me.设备型号DataGridViewTextBoxColumn.Name = "设备型号DataGridViewTextBoxColumn"
        '
        '设备编号DataGridViewTextBoxColumn
        '
        Me.设备编号DataGridViewTextBoxColumn.DataPropertyName = "设备编号"
        Me.设备编号DataGridViewTextBoxColumn.HeaderText = "设备编号"
        Me.设备编号DataGridViewTextBoxColumn.Name = "设备编号DataGridViewTextBoxColumn"
        '
        '模块名称DataGridViewTextBoxColumn
        '
        Me.模块名称DataGridViewTextBoxColumn.DataPropertyName = "模块名称"
        Me.模块名称DataGridViewTextBoxColumn.HeaderText = "模块名称"
        Me.模块名称DataGridViewTextBoxColumn.Name = "模块名称DataGridViewTextBoxColumn"
        '
        '模块编号DataGridViewTextBoxColumn
        '
        Me.模块编号DataGridViewTextBoxColumn.DataPropertyName = "模块编号"
        Me.模块编号DataGridViewTextBoxColumn.HeaderText = "模块编号"
        Me.模块编号DataGridViewTextBoxColumn.Name = "模块编号DataGridViewTextBoxColumn"
        '
        '随机附件DataGridViewTextBoxColumn
        '
        Me.随机附件DataGridViewTextBoxColumn.DataPropertyName = "随机附件"
        Me.随机附件DataGridViewTextBoxColumn.HeaderText = "随机附件"
        Me.随机附件DataGridViewTextBoxColumn.Name = "随机附件DataGridViewTextBoxColumn"
        '
        '故障详情DataGridViewTextBoxColumn
        '
        Me.故障详情DataGridViewTextBoxColumn.DataPropertyName = "故障详情"
        Me.故障详情DataGridViewTextBoxColumn.HeaderText = "故障详情"
        Me.故障详情DataGridViewTextBoxColumn.Name = "故障详情DataGridViewTextBoxColumn"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(73, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ProcessDescriptionDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.CustomerIdDataGridViewTextBoxColumn, Me.ContactsIdDataGridViewTextBoxColumn, Me.DeviceNameIdDataGridViewTextBoxColumn, Me.DeviceNameDataGridViewTextBoxColumn, Me.DeviceBrandIdDataGridViewTextBoxColumn, Me.DeviceBrandDataGridViewTextBoxColumn, Me.DeviceModelIdDataGridViewTextBoxColumn, Me.DeviceModelDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.RepairOrBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(686, 48)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.Size = New System.Drawing.Size(638, 314)
        Me.DataGridView2.TabIndex = 13
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'ProcessDescriptionDataGridViewTextBoxColumn
        '
        Me.ProcessDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProcessDescription"
        Me.ProcessDescriptionDataGridViewTextBoxColumn.HeaderText = "ProcessDescription"
        Me.ProcessDescriptionDataGridViewTextBoxColumn.Name = "ProcessDescriptionDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'CustomerIdDataGridViewTextBoxColumn
        '
        Me.CustomerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId"
        Me.CustomerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId"
        Me.CustomerIdDataGridViewTextBoxColumn.Name = "CustomerIdDataGridViewTextBoxColumn"
        '
        'ContactsIdDataGridViewTextBoxColumn
        '
        Me.ContactsIdDataGridViewTextBoxColumn.DataPropertyName = "ContactsId"
        Me.ContactsIdDataGridViewTextBoxColumn.HeaderText = "ContactsId"
        Me.ContactsIdDataGridViewTextBoxColumn.Name = "ContactsIdDataGridViewTextBoxColumn"
        '
        'DeviceNameIdDataGridViewTextBoxColumn
        '
        Me.DeviceNameIdDataGridViewTextBoxColumn.DataPropertyName = "DeviceNameId"
        Me.DeviceNameIdDataGridViewTextBoxColumn.HeaderText = "DeviceNameId"
        Me.DeviceNameIdDataGridViewTextBoxColumn.Name = "DeviceNameIdDataGridViewTextBoxColumn"
        '
        'DeviceNameDataGridViewTextBoxColumn
        '
        Me.DeviceNameDataGridViewTextBoxColumn.DataPropertyName = "DeviceName"
        Me.DeviceNameDataGridViewTextBoxColumn.HeaderText = "DeviceName"
        Me.DeviceNameDataGridViewTextBoxColumn.Name = "DeviceNameDataGridViewTextBoxColumn"
        '
        'DeviceBrandIdDataGridViewTextBoxColumn
        '
        Me.DeviceBrandIdDataGridViewTextBoxColumn.DataPropertyName = "DeviceBrandId"
        Me.DeviceBrandIdDataGridViewTextBoxColumn.HeaderText = "DeviceBrandId"
        Me.DeviceBrandIdDataGridViewTextBoxColumn.Name = "DeviceBrandIdDataGridViewTextBoxColumn"
        '
        'DeviceBrandDataGridViewTextBoxColumn
        '
        Me.DeviceBrandDataGridViewTextBoxColumn.DataPropertyName = "DeviceBrand"
        Me.DeviceBrandDataGridViewTextBoxColumn.HeaderText = "DeviceBrand"
        Me.DeviceBrandDataGridViewTextBoxColumn.Name = "DeviceBrandDataGridViewTextBoxColumn"
        '
        'DeviceModelIdDataGridViewTextBoxColumn
        '
        Me.DeviceModelIdDataGridViewTextBoxColumn.DataPropertyName = "DeviceModelId"
        Me.DeviceModelIdDataGridViewTextBoxColumn.HeaderText = "DeviceModelId"
        Me.DeviceModelIdDataGridViewTextBoxColumn.Name = "DeviceModelIdDataGridViewTextBoxColumn"
        '
        'DeviceModelDataGridViewTextBoxColumn
        '
        Me.DeviceModelDataGridViewTextBoxColumn.DataPropertyName = "DeviceModel"
        Me.DeviceModelDataGridViewTextBoxColumn.HeaderText = "DeviceModel"
        Me.DeviceModelDataGridViewTextBoxColumn.Name = "DeviceModelDataGridViewTextBoxColumn"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 548)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairOrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ModelBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents DevicemodelTableAdapter As ywtDataSetTableAdapters.devicemodelTableAdapter
    Friend WithEvents RepairOrBindingSource As BindingSource
    Friend WithEvents RepairorderTableAdapter As ywtDataSetTableAdapters.repairorderTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As ywtDataSetTableAdapters.orderTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents 维修单号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 处理详情 As DataGridViewTextBoxColumn
    Friend WithEvents 接件日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 客户名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 联系人DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备品牌DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备型号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备编号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 模块名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 模块编号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 随机附件DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 故障详情DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProcessDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactsIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceNameIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceBrandIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceModelIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
