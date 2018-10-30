<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.维修单号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.接件日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.客户名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.客户地址DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.联系人DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.收货地址DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.电话DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备品牌DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备型号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备编号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.模块名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.模块编号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.随机附件DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.故障详情DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.处理详情DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.沟通详情DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.orderTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MyComboBox1 = New NewCtl3.MyComboBox()
        Me.CusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.customerTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "order"
        Me.OrderBindingSource.DataSource = Me.YwtDataSet
        '
        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.维修单号DataGridViewTextBoxColumn, Me.接件日期DataGridViewTextBoxColumn, Me.客户名称DataGridViewTextBoxColumn, Me.客户地址DataGridViewTextBoxColumn, Me.联系人DataGridViewTextBoxColumn, Me.收货地址DataGridViewTextBoxColumn, Me.电话DataGridViewTextBoxColumn, Me.设备名称DataGridViewTextBoxColumn, Me.设备品牌DataGridViewTextBoxColumn, Me.设备型号DataGridViewTextBoxColumn, Me.设备编号DataGridViewTextBoxColumn, Me.模块名称DataGridViewTextBoxColumn, Me.模块编号DataGridViewTextBoxColumn, Me.随机附件DataGridViewTextBoxColumn, Me.故障详情DataGridViewTextBoxColumn, Me.处理详情DataGridViewTextBoxColumn, Me.沟通详情DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(375, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(628, 172)
        Me.DataGridView1.TabIndex = 0
        '
        '维修单号DataGridViewTextBoxColumn
        '
        Me.维修单号DataGridViewTextBoxColumn.DataPropertyName = "维修单号"
        Me.维修单号DataGridViewTextBoxColumn.HeaderText = "维修单号"
        Me.维修单号DataGridViewTextBoxColumn.Name = "维修单号DataGridViewTextBoxColumn"
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
        '客户地址DataGridViewTextBoxColumn
        '
        Me.客户地址DataGridViewTextBoxColumn.DataPropertyName = "客户地址"
        Me.客户地址DataGridViewTextBoxColumn.HeaderText = "客户地址"
        Me.客户地址DataGridViewTextBoxColumn.Name = "客户地址DataGridViewTextBoxColumn"
        '
        '联系人DataGridViewTextBoxColumn
        '
        Me.联系人DataGridViewTextBoxColumn.DataPropertyName = "联系人"
        Me.联系人DataGridViewTextBoxColumn.HeaderText = "联系人"
        Me.联系人DataGridViewTextBoxColumn.Name = "联系人DataGridViewTextBoxColumn"
        '
        '收货地址DataGridViewTextBoxColumn
        '
        Me.收货地址DataGridViewTextBoxColumn.DataPropertyName = "收货地址"
        Me.收货地址DataGridViewTextBoxColumn.HeaderText = "收货地址"
        Me.收货地址DataGridViewTextBoxColumn.Name = "收货地址DataGridViewTextBoxColumn"
        '
        '电话DataGridViewTextBoxColumn
        '
        Me.电话DataGridViewTextBoxColumn.DataPropertyName = "电话"
        Me.电话DataGridViewTextBoxColumn.HeaderText = "电话"
        Me.电话DataGridViewTextBoxColumn.Name = "电话DataGridViewTextBoxColumn"
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
        '处理详情DataGridViewTextBoxColumn
        '
        Me.处理详情DataGridViewTextBoxColumn.DataPropertyName = "处理详情"
        Me.处理详情DataGridViewTextBoxColumn.HeaderText = "处理详情"
        Me.处理详情DataGridViewTextBoxColumn.Name = "处理详情DataGridViewTextBoxColumn"
        '
        '沟通详情DataGridViewTextBoxColumn
        '
        Me.沟通详情DataGridViewTextBoxColumn.DataPropertyName = "沟通详情"
        Me.沟通详情DataGridViewTextBoxColumn.HeaderText = "沟通详情"
        Me.沟通详情DataGridViewTextBoxColumn.Name = "沟通详情DataGridViewTextBoxColumn"
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.OrderBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "YWT_mysql.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(375, 206)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(628, 370)
        Me.ReportViewer1.TabIndex = 1
        '
        'MyComboBox1
        '
        Me.MyComboBox1.DataSouce = Me.CusBindingSource
        Me.MyComboBox1.DisplayMember = "CusName"
        Me.MyComboBox1.DropDown = False
        Me.MyComboBox1.FilterColumnName = "Pyindex"
        Me.MyComboBox1.IsNew = False
        Me.MyComboBox1.Location = New System.Drawing.Point(75, 24)
        Me.MyComboBox1.Name = "MyComboBox1"
        Me.MyComboBox1.RowMount = 5
        Me.MyComboBox1.Size = New System.Drawing.Size(263, 21)
        Me.MyComboBox1.TabIndex = 2
        Me.MyComboBox1.Tag = Nothing
        Me.MyComboBox1.ValueMember = "Id"
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(75, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "客户名称"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "起始单号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "截止单号"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 604)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MyComboBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents OrderTableAdapter As ywtDataSetTableAdapters.orderTableAdapter
    Friend WithEvents 维修单号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 接件日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 客户名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 客户地址DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 联系人DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 收货地址DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 电话DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备品牌DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备型号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 设备编号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 模块名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 模块编号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 随机附件DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 故障详情DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 处理详情DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 沟通详情DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MyComboBox1 As NewCtl3.MyComboBox
    Friend WithEvents CusBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ywtDataSetTableAdapters.customerTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
