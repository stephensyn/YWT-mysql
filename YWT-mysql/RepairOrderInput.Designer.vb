<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepairOrderInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepairOrderInput))
        Me.Tb_RepairsOrSn = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_FaultDescription = New System.Windows.Forms.TextBox()
        Me.TextBox_DevAccessory = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_DevSn = New System.Windows.Forms.TextBox()
        Me.TextBox_MoudleSn = New System.Windows.Forms.TextBox()
        Me.TextBox_ContactTel2 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox_ContactTel = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox_ContactLocation = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_CusLocation = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Add_Botton = New System.Windows.Forms.ToolStripButton()
        Me.OK_Button = New System.Windows.Forms.ToolStripButton()
        Me.Cance_Button = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MyComboBox_DeviceBrand = New NewCtl3.MyComboBox()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.MyComboBox_DevMoudleName = New NewCtl3.MyComboBox()
        Me.MoudleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyComboBox_DevModel = New NewCtl3.MyComboBox()
        Me.ModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyComboBox_DevName = New NewCtl3.MyComboBox()
        Me.DevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyComboBox_ContactName = New NewCtl3.MyComboBox()
        Me.ConBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyComboBox_CusName = New NewCtl3.MyComboBox()
        Me.CusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.customerTableAdapter()
        Me.ContactsTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.contactsTableAdapter()
        Me.DevicenameTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicenameTableAdapter()
        Me.DevicebrandTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicebrandTableAdapter()
        Me.DevicemodelTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicemodelTableAdapter()
        Me.MoudlenameTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.moudlenameTableAdapter()
        Me.RepairOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairorderTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.repairorderTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoudleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_RepairsOrSn
        '
        Me.Tb_RepairsOrSn.Enabled = False
        Me.Tb_RepairsOrSn.Location = New System.Drawing.Point(122, 84)
        Me.Tb_RepairsOrSn.Name = "Tb_RepairsOrSn"
        Me.Tb_RepairsOrSn.Size = New System.Drawing.Size(79, 21)
        Me.Tb_RepairsOrSn.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(63, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "单    号"
        '
        'TextBox_FaultDescription
        '
        Me.TextBox_FaultDescription.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TextBox_FaultDescription.Location = New System.Drawing.Point(122, 421)
        Me.TextBox_FaultDescription.Multiline = True
        Me.TextBox_FaultDescription.Name = "TextBox_FaultDescription"
        Me.TextBox_FaultDescription.Size = New System.Drawing.Size(461, 132)
        Me.TextBox_FaultDescription.TabIndex = 10
        '
        'TextBox_DevAccessory
        '
        Me.TextBox_DevAccessory.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TextBox_DevAccessory.Location = New System.Drawing.Point(122, 313)
        Me.TextBox_DevAccessory.Multiline = True
        Me.TextBox_DevAccessory.Name = "TextBox_DevAccessory"
        Me.TextBox_DevAccessory.Size = New System.Drawing.Size(461, 100)
        Me.TextBox_DevAccessory.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(491, 84)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(92, 21)
        Me.DateTimePicker1.TabIndex = 0
        '
        'TextBox_DevSn
        '
        Me.TextBox_DevSn.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox_DevSn.Location = New System.Drawing.Point(395, 252)
        Me.TextBox_DevSn.Name = "TextBox_DevSn"
        Me.TextBox_DevSn.Size = New System.Drawing.Size(188, 21)
        Me.TextBox_DevSn.TabIndex = 6
        '
        'TextBox_MoudleSn
        '
        Me.TextBox_MoudleSn.Enabled = False
        Me.TextBox_MoudleSn.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox_MoudleSn.Location = New System.Drawing.Point(395, 283)
        Me.TextBox_MoudleSn.Name = "TextBox_MoudleSn"
        Me.TextBox_MoudleSn.Size = New System.Drawing.Size(188, 21)
        Me.TextBox_MoudleSn.TabIndex = 8
        '
        'TextBox_ContactTel2
        '
        Me.TextBox_ContactTel2.Enabled = False
        Me.TextBox_ContactTel2.Location = New System.Drawing.Point(483, 169)
        Me.TextBox_ContactTel2.Mask = "000-0000-0000"
        Me.TextBox_ContactTel2.Name = "TextBox_ContactTel2"
        Me.TextBox_ContactTel2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox_ContactTel2.TabIndex = 3
        Me.TextBox_ContactTel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_ContactTel
        '
        Me.TextBox_ContactTel.Enabled = False
        Me.TextBox_ContactTel.Location = New System.Drawing.Point(304, 169)
        Me.TextBox_ContactTel.Mask = "000-0000-0000"
        Me.TextBox_ContactTel.Name = "TextBox_ContactTel"
        Me.TextBox_ContactTel.Size = New System.Drawing.Size(100, 21)
        Me.TextBox_ContactTel.TabIndex = 41
        Me.TextBox_ContactTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_ContactLocation
        '
        Me.TextBox_ContactLocation.Enabled = False
        Me.TextBox_ContactLocation.Location = New System.Drawing.Point(122, 196)
        Me.TextBox_ContactLocation.Name = "TextBox_ContactLocation"
        Me.TextBox_ContactLocation.Size = New System.Drawing.Size(461, 21)
        Me.TextBox_ContactLocation.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(63, 479)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 12)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "故障详情"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(61, 347)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "随机附件"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(334, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 12)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "模块编号"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(63, 288)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "模块型号"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(334, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "设备编号"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "设备型号"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(334, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "设备品牌"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "设备名称"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "备用电话"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(243, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "经办电话"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "收货地址"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "经 办 人"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "客户地址"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "客户单位"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "日期"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "维修接件登记"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_CusLocation
        '
        Me.TextBox_CusLocation.Enabled = False
        Me.TextBox_CusLocation.Location = New System.Drawing.Point(122, 141)
        Me.TextBox_CusLocation.Name = "TextBox_CusLocation"
        Me.TextBox_CusLocation.Size = New System.Drawing.Size(461, 21)
        Me.TextBox_CusLocation.TabIndex = 39
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add_Botton, Me.OK_Button, Me.Cance_Button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(941, 39)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Add_Botton
        '
        Me.Add_Botton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Add_Botton.Image = CType(resources.GetObject("Add_Botton.Image"), System.Drawing.Image)
        Me.Add_Botton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Add_Botton.Name = "Add_Botton"
        Me.Add_Botton.Size = New System.Drawing.Size(36, 36)
        Me.Add_Botton.Text = "ToolStripButton1"
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 573)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(941, 22)
        Me.StatusStrip1.TabIndex = 66
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'MyComboBox_DeviceBrand
        '
        Me.MyComboBox_DeviceBrand.DataSouce = Me.BrandBindingSource
        Me.MyComboBox_DeviceBrand.DisplayMember = "BrandName"
        Me.MyComboBox_DeviceBrand.DropDown = False
        Me.MyComboBox_DeviceBrand.FilterColumnName = "Pyindex"
        Me.MyComboBox_DeviceBrand.IsNew = False
        Me.MyComboBox_DeviceBrand.Location = New System.Drawing.Point(395, 223)
        Me.MyComboBox_DeviceBrand.Name = "MyComboBox_DeviceBrand"
        Me.MyComboBox_DeviceBrand.RowMount = 5
        Me.MyComboBox_DeviceBrand.Size = New System.Drawing.Size(188, 21)
        Me.MyComboBox_DeviceBrand.TabIndex = 4
        Me.MyComboBox_DeviceBrand.Tag = Nothing
        Me.MyComboBox_DeviceBrand.ValueMember = "Id"
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
        'MyComboBox_DevMoudleName
        '
        Me.MyComboBox_DevMoudleName.DataSouce = Me.MoudleBindingSource
        Me.MyComboBox_DevMoudleName.DisplayMember = "Id"
        Me.MyComboBox_DevMoudleName.DropDown = False
        Me.MyComboBox_DevMoudleName.FilterColumnName = "Pyindex"
        Me.MyComboBox_DevMoudleName.IsNew = False
        Me.MyComboBox_DevMoudleName.Location = New System.Drawing.Point(122, 283)
        Me.MyComboBox_DevMoudleName.Name = "MyComboBox_DevMoudleName"
        Me.MyComboBox_DevMoudleName.RowMount = 5
        Me.MyComboBox_DevMoudleName.Size = New System.Drawing.Size(188, 21)
        Me.MyComboBox_DevMoudleName.TabIndex = 7
        Me.MyComboBox_DevMoudleName.Tag = Nothing
        Me.MyComboBox_DevMoudleName.ValueMember = "Id"
        '
        'MoudleBindingSource
        '
        Me.MoudleBindingSource.DataMember = "moudlename"
        Me.MoudleBindingSource.DataSource = Me.YwtDataSet
        '
        'MyComboBox_DevModel
        '
        Me.MyComboBox_DevModel.DataSouce = Me.ModelBindingSource
        Me.MyComboBox_DevModel.DisplayMember = "DeviceModel"
        Me.MyComboBox_DevModel.DropDown = False
        Me.MyComboBox_DevModel.FilterColumnName = "Pyindex"
        Me.MyComboBox_DevModel.IsNew = False
        Me.MyComboBox_DevModel.Location = New System.Drawing.Point(122, 252)
        Me.MyComboBox_DevModel.Name = "MyComboBox_DevModel"
        Me.MyComboBox_DevModel.RowMount = 5
        Me.MyComboBox_DevModel.Size = New System.Drawing.Size(188, 21)
        Me.MyComboBox_DevModel.TabIndex = 5
        Me.MyComboBox_DevModel.Tag = Nothing
        Me.MyComboBox_DevModel.ValueMember = "Id"
        '
        'ModelBindingSource
        '
        Me.ModelBindingSource.DataMember = "devicemodel"
        Me.ModelBindingSource.DataSource = Me.YwtDataSet
        '
        'MyComboBox_DevName
        '
        Me.MyComboBox_DevName.DataSouce = Me.DevBindingSource
        Me.MyComboBox_DevName.DisplayMember = "DeviceName"
        Me.MyComboBox_DevName.DropDown = False
        Me.MyComboBox_DevName.FilterColumnName = "Pyindex"
        Me.MyComboBox_DevName.IsNew = False
        Me.MyComboBox_DevName.Location = New System.Drawing.Point(122, 223)
        Me.MyComboBox_DevName.Name = "MyComboBox_DevName"
        Me.MyComboBox_DevName.RowMount = 5
        Me.MyComboBox_DevName.Size = New System.Drawing.Size(188, 21)
        Me.MyComboBox_DevName.TabIndex = 3
        Me.MyComboBox_DevName.Tag = Nothing
        Me.MyComboBox_DevName.ValueMember = "Id"
        '
        'DevBindingSource
        '
        Me.DevBindingSource.DataMember = "devicename"
        Me.DevBindingSource.DataSource = Me.YwtDataSet
        '
        'MyComboBox_ContactName
        '
        Me.MyComboBox_ContactName.DataSouce = Me.ConBindingSource
        Me.MyComboBox_ContactName.DisplayMember = "ContactsName"
        Me.MyComboBox_ContactName.DropDown = False
        Me.MyComboBox_ContactName.FilterColumnName = "Pyindex"
        Me.MyComboBox_ContactName.IsNew = False
        Me.MyComboBox_ContactName.Location = New System.Drawing.Point(122, 169)
        Me.MyComboBox_ContactName.Name = "MyComboBox_ContactName"
        Me.MyComboBox_ContactName.RowMount = 5
        Me.MyComboBox_ContactName.Size = New System.Drawing.Size(100, 21)
        Me.MyComboBox_ContactName.TabIndex = 2
        Me.MyComboBox_ContactName.Tag = Nothing
        Me.MyComboBox_ContactName.ValueMember = "Id"
        '
        'ConBindingSource
        '
        Me.ConBindingSource.DataMember = "contacts"
        Me.ConBindingSource.DataSource = Me.YwtDataSet
        '
        'MyComboBox_CusName
        '
        Me.MyComboBox_CusName.DataSouce = Me.CusBindingSource
        Me.MyComboBox_CusName.DisplayMember = "CusName"
        Me.MyComboBox_CusName.DropDown = False
        Me.MyComboBox_CusName.FilterColumnName = "Pyindex"
        Me.MyComboBox_CusName.IsNew = False
        Me.MyComboBox_CusName.Location = New System.Drawing.Point(122, 112)
        Me.MyComboBox_CusName.Name = "MyComboBox_CusName"
        Me.MyComboBox_CusName.RowMount = 5
        Me.MyComboBox_CusName.Size = New System.Drawing.Size(461, 21)
        Me.MyComboBox_CusName.TabIndex = 1
        Me.MyComboBox_CusName.Tag = Nothing
        Me.MyComboBox_CusName.ValueMember = "Id"
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
        'DevicenameTableAdapter
        '
        Me.DevicenameTableAdapter.ClearBeforeFill = True
        '
        'DevicebrandTableAdapter
        '
        Me.DevicebrandTableAdapter.ClearBeforeFill = True
        '
        'DevicemodelTableAdapter
        '
        Me.DevicemodelTableAdapter.ClearBeforeFill = True
        '
        'MoudlenameTableAdapter
        '
        Me.MoudlenameTableAdapter.ClearBeforeFill = True
        '
        'RepairOrderBindingSource
        '
        Me.RepairOrderBindingSource.DataMember = "repairorder"
        Me.RepairOrderBindingSource.DataSource = Me.YwtDataSet
        '
        'RepairorderTableAdapter
        '
        Me.RepairorderTableAdapter.ClearBeforeFill = True
        '
        'RepairOrderInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 595)
        Me.Controls.Add(Me.MyComboBox_DeviceBrand)
        Me.Controls.Add(Me.MyComboBox_DevMoudleName)
        Me.Controls.Add(Me.MyComboBox_DevModel)
        Me.Controls.Add(Me.MyComboBox_DevName)
        Me.Controls.Add(Me.MyComboBox_ContactName)
        Me.Controls.Add(Me.MyComboBox_CusName)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Tb_RepairsOrSn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox_FaultDescription)
        Me.Controls.Add(Me.TextBox_DevAccessory)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox_DevSn)
        Me.Controls.Add(Me.TextBox_MoudleSn)
        Me.Controls.Add(Me.TextBox_ContactTel2)
        Me.Controls.Add(Me.TextBox_ContactTel)
        Me.Controls.Add(Me.TextBox_ContactLocation)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_CusLocation)
        Me.Name = "RepairOrderInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RepairOrderInput"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoudleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tb_RepairsOrSn As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_FaultDescription As TextBox
    Friend WithEvents TextBox_DevAccessory As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox_DevSn As TextBox
    Friend WithEvents TextBox_MoudleSn As TextBox
    Friend WithEvents TextBox_ContactTel2 As MaskedTextBox
    Friend WithEvents TextBox_ContactTel As MaskedTextBox
    Friend WithEvents TextBox_ContactLocation As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_CusLocation As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Add_Botton As ToolStripButton
    Friend WithEvents OK_Button As ToolStripButton
    Friend WithEvents Cance_Button As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MyComboBox_CusName As NewCtl3.MyComboBox
    Friend WithEvents MyComboBox_ContactName As NewCtl3.MyComboBox
    Friend WithEvents MyComboBox_DevName As NewCtl3.MyComboBox
    Friend WithEvents MyComboBox_DevModel As NewCtl3.MyComboBox
    Friend WithEvents MyComboBox_DevMoudleName As NewCtl3.MyComboBox
    Friend WithEvents MyComboBox_DeviceBrand As NewCtl3.MyComboBox
    Friend WithEvents CusBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents CustomerTableAdapter As ywtDataSetTableAdapters.customerTableAdapter
    Friend WithEvents ConBindingSource As BindingSource
    Friend WithEvents ContactsTableAdapter As ywtDataSetTableAdapters.contactsTableAdapter
    Friend WithEvents DevBindingSource As BindingSource
    Friend WithEvents DevicenameTableAdapter As ywtDataSetTableAdapters.devicenameTableAdapter
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents DevicebrandTableAdapter As ywtDataSetTableAdapters.devicebrandTableAdapter
    Friend WithEvents ModelBindingSource As BindingSource
    Friend WithEvents DevicemodelTableAdapter As ywtDataSetTableAdapters.devicemodelTableAdapter
    Friend WithEvents MoudleBindingSource As BindingSource
    Friend WithEvents MoudlenameTableAdapter As ywtDataSetTableAdapters.moudlenameTableAdapter
    Friend WithEvents RepairOrderBindingSource As BindingSource
    Friend WithEvents RepairorderTableAdapter As ywtDataSetTableAdapters.repairorderTableAdapter
End Class
