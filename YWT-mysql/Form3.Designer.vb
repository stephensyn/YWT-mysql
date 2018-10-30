<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RepairOrDate = New System.Windows.Forms.TextBox()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.ConName = New System.Windows.Forms.TextBox()
        Me.FaultDescription = New System.Windows.Forms.TextBox()
        Me.ReOrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevAccessory = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MoudleName = New System.Windows.Forms.TextBox()
        Me.DevModel = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BrandName = New System.Windows.Forms.TextBox()
        Me.DevName = New System.Windows.Forms.TextBox()
        Me.CusName = New System.Windows.Forms.TextBox()
        Me.RepairsOrSn = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DevSn = New System.Windows.Forms.TextBox()
        Me.MoudleSn = New System.Windows.Forms.TextBox()
        Me.ConTel = New System.Windows.Forms.MaskedTextBox()
        Me.ConLocation = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CusMyComboBox = New NewCtl3.MyComboBox()
        Me.ConMyComboBox = New NewCtl3.MyComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OrderTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.orderTableAdapter()
        Me.CusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.customerTableAdapter()
        Me.ConBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.contactsTableAdapter()
        Me.RepairorderTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.repairorderTableAdapter()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReOrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1307, 342)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "业务处理"
        '
        'RepairOrDate
        '
        Me.RepairOrDate.BackColor = System.Drawing.Color.Gainsboro
        Me.RepairOrDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RepairOrDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "接件日期", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.RepairOrDate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RepairOrDate.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.RepairOrDate.Location = New System.Drawing.Point(436, 7)
        Me.RepairOrDate.Name = "RepairOrDate"
        Me.RepairOrDate.ReadOnly = True
        Me.RepairOrDate.Size = New System.Drawing.Size(100, 21)
        Me.RepairOrDate.TabIndex = 103
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
        'ConName
        '
        Me.ConName.BackColor = System.Drawing.Color.Gainsboro
        Me.ConName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "联系人", True))
        Me.ConName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ConName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ConName.Location = New System.Drawing.Point(75, 55)
        Me.ConName.Name = "ConName"
        Me.ConName.ReadOnly = True
        Me.ConName.Size = New System.Drawing.Size(79, 21)
        Me.ConName.TabIndex = 102
        '
        'FaultDescription
        '
        Me.FaultDescription.BackColor = System.Drawing.Color.Gainsboro
        Me.FaultDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaultDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReOrBindingSource, "FaultDescription", True))
        Me.FaultDescription.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FaultDescription.Location = New System.Drawing.Point(346, 175)
        Me.FaultDescription.Multiline = True
        Me.FaultDescription.Name = "FaultDescription"
        Me.FaultDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FaultDescription.Size = New System.Drawing.Size(190, 152)
        Me.FaultDescription.TabIndex = 101
        '
        'ReOrBindingSource
        '
        Me.ReOrBindingSource.DataMember = "repairorder"
        Me.ReOrBindingSource.DataSource = Me.YwtDataSet
        '
        'DevAccessory
        '
        Me.DevAccessory.BackColor = System.Drawing.Color.Gainsboro
        Me.DevAccessory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DevAccessory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "随机附件", True))
        Me.DevAccessory.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DevAccessory.Location = New System.Drawing.Point(75, 175)
        Me.DevAccessory.Multiline = True
        Me.DevAccessory.Name = "DevAccessory"
        Me.DevAccessory.ReadOnly = True
        Me.DevAccessory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DevAccessory.Size = New System.Drawing.Size(188, 152)
        Me.DevAccessory.TabIndex = 100
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.Location = New System.Drawing.Point(285, 249)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 12)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "故障详情"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 249)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 12)
        Me.Label18.TabIndex = 98
        Me.Label18.Text = "随机附件"
        '
        'MoudleName
        '
        Me.MoudleName.BackColor = System.Drawing.Color.Gainsboro
        Me.MoudleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MoudleName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "模块名称", True))
        Me.MoudleName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MoudleName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MoudleName.Location = New System.Drawing.Point(75, 151)
        Me.MoudleName.Name = "MoudleName"
        Me.MoudleName.ReadOnly = True
        Me.MoudleName.Size = New System.Drawing.Size(188, 21)
        Me.MoudleName.TabIndex = 97
        '
        'DevModel
        '
        Me.DevModel.BackColor = System.Drawing.Color.Gainsboro
        Me.DevModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DevModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "设备型号", True))
        Me.DevModel.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DevModel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.DevModel.Location = New System.Drawing.Point(75, 127)
        Me.DevModel.Name = "DevModel"
        Me.DevModel.ReadOnly = True
        Me.DevModel.Size = New System.Drawing.Size(188, 21)
        Me.DevModel.TabIndex = 96
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(28, 261)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1315, 368)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.RepairOrDate)
        Me.TabPage1.Controls.Add(Me.ConName)
        Me.TabPage1.Controls.Add(Me.FaultDescription)
        Me.TabPage1.Controls.Add(Me.DevAccessory)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.MoudleName)
        Me.TabPage1.Controls.Add(Me.DevModel)
        Me.TabPage1.Controls.Add(Me.BrandName)
        Me.TabPage1.Controls.Add(Me.DevName)
        Me.TabPage1.Controls.Add(Me.CusName)
        Me.TabPage1.Controls.Add(Me.RepairsOrSn)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.DevSn)
        Me.TabPage1.Controls.Add(Me.MoudleSn)
        Me.TabPage1.Controls.Add(Me.ConTel)
        Me.TabPage1.Controls.Add(Me.ConLocation)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1307, 342)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "查询"
        '
        'BrandName
        '
        Me.BrandName.BackColor = System.Drawing.Color.Gainsboro
        Me.BrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BrandName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "设备品牌", True))
        Me.BrandName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BrandName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.BrandName.Location = New System.Drawing.Point(346, 103)
        Me.BrandName.Name = "BrandName"
        Me.BrandName.ReadOnly = True
        Me.BrandName.Size = New System.Drawing.Size(190, 21)
        Me.BrandName.TabIndex = 95
        '
        'DevName
        '
        Me.DevName.BackColor = System.Drawing.Color.Gainsboro
        Me.DevName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DevName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "设备名称", True))
        Me.DevName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DevName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.DevName.Location = New System.Drawing.Point(75, 103)
        Me.DevName.Name = "DevName"
        Me.DevName.ReadOnly = True
        Me.DevName.Size = New System.Drawing.Size(188, 21)
        Me.DevName.TabIndex = 94
        '
        'CusName
        '
        Me.CusName.BackColor = System.Drawing.Color.Gainsboro
        Me.CusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "客户名称", True))
        Me.CusName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CusName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CusName.Location = New System.Drawing.Point(75, 31)
        Me.CusName.Name = "CusName"
        Me.CusName.ReadOnly = True
        Me.CusName.Size = New System.Drawing.Size(461, 21)
        Me.CusName.TabIndex = 93
        '
        'RepairsOrSn
        '
        Me.RepairsOrSn.BackColor = System.Drawing.Color.Gainsboro
        Me.RepairsOrSn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RepairsOrSn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "维修单号", True))
        Me.RepairsOrSn.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RepairsOrSn.Location = New System.Drawing.Point(75, 7)
        Me.RepairsOrSn.Name = "RepairsOrSn"
        Me.RepairsOrSn.ReadOnly = True
        Me.RepairsOrSn.Size = New System.Drawing.Size(79, 21)
        Me.RepairsOrSn.TabIndex = 92
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "单    号"
        '
        'DevSn
        '
        Me.DevSn.BackColor = System.Drawing.Color.Gainsboro
        Me.DevSn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DevSn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "设备编号", True))
        Me.DevSn.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DevSn.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.DevSn.Location = New System.Drawing.Point(346, 127)
        Me.DevSn.Name = "DevSn"
        Me.DevSn.ReadOnly = True
        Me.DevSn.Size = New System.Drawing.Size(190, 21)
        Me.DevSn.TabIndex = 72
        '
        'MoudleSn
        '
        Me.MoudleSn.BackColor = System.Drawing.Color.Gainsboro
        Me.MoudleSn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MoudleSn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "模块编号", True))
        Me.MoudleSn.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MoudleSn.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MoudleSn.Location = New System.Drawing.Point(346, 151)
        Me.MoudleSn.Name = "MoudleSn"
        Me.MoudleSn.ReadOnly = True
        Me.MoudleSn.Size = New System.Drawing.Size(190, 21)
        Me.MoudleSn.TabIndex = 74
        '
        'ConTel
        '
        Me.ConTel.BackColor = System.Drawing.Color.Gainsboro
        Me.ConTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "电话", True))
        Me.ConTel.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ConTel.Location = New System.Drawing.Point(436, 55)
        Me.ConTel.Mask = "000-0000-0000"
        Me.ConTel.Name = "ConTel"
        Me.ConTel.ReadOnly = True
        Me.ConTel.Size = New System.Drawing.Size(100, 21)
        Me.ConTel.TabIndex = 77
        Me.ConTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ConLocation
        '
        Me.ConLocation.BackColor = System.Drawing.Color.Gainsboro
        Me.ConLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "收货地址", True))
        Me.ConLocation.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ConLocation.Location = New System.Drawing.Point(75, 79)
        Me.ConLocation.Name = "ConLocation"
        Me.ConLocation.ReadOnly = True
        Me.ConLocation.Size = New System.Drawing.Size(461, 21)
        Me.ConLocation.TabIndex = 76
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(285, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 12)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "模块编号"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "模块型号"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(285, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "设备编号"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "设备型号"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "设备品牌"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "设备名称"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(374, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "经办电话"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "收货地址"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "经 办 人"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "客户单位"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.Location = New System.Drawing.Point(374, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "日    期"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.维修单号DataGridViewTextBoxColumn, Me.接件日期DataGridViewTextBoxColumn, Me.客户名称DataGridViewTextBoxColumn, Me.客户地址DataGridViewTextBoxColumn, Me.联系人DataGridViewTextBoxColumn, Me.收货地址DataGridViewTextBoxColumn, Me.电话DataGridViewTextBoxColumn, Me.设备名称DataGridViewTextBoxColumn, Me.设备品牌DataGridViewTextBoxColumn, Me.设备型号DataGridViewTextBoxColumn, Me.设备编号DataGridViewTextBoxColumn, Me.模块名称DataGridViewTextBoxColumn, Me.模块编号DataGridViewTextBoxColumn, Me.随机附件DataGridViewTextBoxColumn, Me.故障详情DataGridViewTextBoxColumn, Me.处理详情DataGridViewTextBoxColumn, Me.沟通详情DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(29, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1311, 208)
        Me.DataGridView1.TabIndex = 13
        '
        '维修单号DataGridViewTextBoxColumn
        '
        Me.维修单号DataGridViewTextBoxColumn.DataPropertyName = "维修单号"
        Me.维修单号DataGridViewTextBoxColumn.HeaderText = "维修单号"
        Me.维修单号DataGridViewTextBoxColumn.Name = "维修单号DataGridViewTextBoxColumn"
        Me.维修单号DataGridViewTextBoxColumn.ReadOnly = True
        '
        '接件日期DataGridViewTextBoxColumn
        '
        Me.接件日期DataGridViewTextBoxColumn.DataPropertyName = "接件日期"
        Me.接件日期DataGridViewTextBoxColumn.HeaderText = "接件日期"
        Me.接件日期DataGridViewTextBoxColumn.Name = "接件日期DataGridViewTextBoxColumn"
        Me.接件日期DataGridViewTextBoxColumn.ReadOnly = True
        '
        '客户名称DataGridViewTextBoxColumn
        '
        Me.客户名称DataGridViewTextBoxColumn.DataPropertyName = "客户名称"
        Me.客户名称DataGridViewTextBoxColumn.HeaderText = "客户名称"
        Me.客户名称DataGridViewTextBoxColumn.Name = "客户名称DataGridViewTextBoxColumn"
        Me.客户名称DataGridViewTextBoxColumn.ReadOnly = True
        '
        '客户地址DataGridViewTextBoxColumn
        '
        Me.客户地址DataGridViewTextBoxColumn.DataPropertyName = "客户地址"
        Me.客户地址DataGridViewTextBoxColumn.HeaderText = "客户地址"
        Me.客户地址DataGridViewTextBoxColumn.Name = "客户地址DataGridViewTextBoxColumn"
        Me.客户地址DataGridViewTextBoxColumn.ReadOnly = True
        '
        '联系人DataGridViewTextBoxColumn
        '
        Me.联系人DataGridViewTextBoxColumn.DataPropertyName = "联系人"
        Me.联系人DataGridViewTextBoxColumn.HeaderText = "联系人"
        Me.联系人DataGridViewTextBoxColumn.Name = "联系人DataGridViewTextBoxColumn"
        Me.联系人DataGridViewTextBoxColumn.ReadOnly = True
        '
        '收货地址DataGridViewTextBoxColumn
        '
        Me.收货地址DataGridViewTextBoxColumn.DataPropertyName = "收货地址"
        Me.收货地址DataGridViewTextBoxColumn.HeaderText = "收货地址"
        Me.收货地址DataGridViewTextBoxColumn.Name = "收货地址DataGridViewTextBoxColumn"
        Me.收货地址DataGridViewTextBoxColumn.ReadOnly = True
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
        '
        '处理详情DataGridViewTextBoxColumn
        '
        Me.处理详情DataGridViewTextBoxColumn.DataPropertyName = "处理详情"
        Me.处理详情DataGridViewTextBoxColumn.HeaderText = "处理详情"
        Me.处理详情DataGridViewTextBoxColumn.Name = "处理详情DataGridViewTextBoxColumn"
        Me.处理详情DataGridViewTextBoxColumn.ReadOnly = True
        '
        '沟通详情DataGridViewTextBoxColumn
        '
        Me.沟通详情DataGridViewTextBoxColumn.DataPropertyName = "沟通详情"
        Me.沟通详情DataGridViewTextBoxColumn.HeaderText = "沟通详情"
        Me.沟通详情DataGridViewTextBoxColumn.Name = "沟通详情DataGridViewTextBoxColumn"
        Me.沟通详情DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(690, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CusMyComboBox
        '
        Me.CusMyComboBox.DataSouce = Nothing
        Me.CusMyComboBox.DisplayMember = "CusName"
        Me.CusMyComboBox.DropDown = False
        Me.CusMyComboBox.FilterColumnName = "PyIndex"
        Me.CusMyComboBox.IsNew = False
        Me.CusMyComboBox.Location = New System.Drawing.Point(344, 22)
        Me.CusMyComboBox.Name = "CusMyComboBox"
        Me.CusMyComboBox.RowMount = 5
        Me.CusMyComboBox.Size = New System.Drawing.Size(209, 21)
        Me.CusMyComboBox.TabIndex = 14
        Me.CusMyComboBox.Tag = Nothing
        Me.CusMyComboBox.ValueMember = "id"
        '
        'ConMyComboBox
        '
        Me.ConMyComboBox.DataSouce = Nothing
        Me.ConMyComboBox.DisplayMember = "ContactsName"
        Me.ConMyComboBox.DropDown = False
        Me.ConMyComboBox.FilterColumnName = "Pyindex"
        Me.ConMyComboBox.IsNew = False
        Me.ConMyComboBox.Location = New System.Drawing.Point(582, 22)
        Me.ConMyComboBox.Name = "ConMyComboBox"
        Me.ConMyComboBox.RowMount = 5
        Me.ConMyComboBox.Size = New System.Drawing.Size(93, 21)
        Me.ConMyComboBox.TabIndex = 20
        Me.ConMyComboBox.Tag = Nothing
        Me.ConMyComboBox.ValueMember = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "至"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "日期选择："
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(225, 22)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 21)
        Me.DateTimePicker2.TabIndex = 16
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 21)
        Me.DateTimePicker1.TabIndex = 15
        Me.DateTimePicker1.Value = New Date(2018, 9, 1, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(799, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        'ConBindingSource
        '
        Me.ConBindingSource.DataMember = "contacts"
        Me.ConBindingSource.DataSource = Me.YwtDataSet
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'RepairorderTableAdapter
        '
        Me.RepairorderTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 628)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CusMyComboBox)
        Me.Controls.Add(Me.ConMyComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReOrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RepairOrDate As TextBox
    Friend WithEvents ConName As TextBox
    Friend WithEvents FaultDescription As TextBox
    Friend WithEvents DevAccessory As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents MoudleName As TextBox
    Friend WithEvents DevModel As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BrandName As TextBox
    Friend WithEvents DevName As TextBox
    Friend WithEvents CusName As TextBox
    Friend WithEvents RepairsOrSn As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DevSn As TextBox
    Friend WithEvents MoudleSn As TextBox
    Friend WithEvents ConTel As MaskedTextBox
    Friend WithEvents ConLocation As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents CusMyComboBox As NewCtl3.MyComboBox
    Friend WithEvents ConMyComboBox As NewCtl3.MyComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
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
    Friend WithEvents CusBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ywtDataSetTableAdapters.customerTableAdapter
    Friend WithEvents ConBindingSource As BindingSource
    Friend WithEvents ContactsTableAdapter As ywtDataSetTableAdapters.contactsTableAdapter
    Friend WithEvents ReOrBindingSource As BindingSource
    Friend WithEvents RepairorderTableAdapter As ywtDataSetTableAdapters.repairorderTableAdapter
End Class
