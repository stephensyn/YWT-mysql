<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCustId = New System.Windows.Forms.TextBox()
        Me.TextBoxCustName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCustAdd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCustTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCustFax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCustEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DbToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DbFirst = New System.Windows.Forms.ToolStripButton()
        Me.DbPrev = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.DbNext = New System.Windows.Forms.ToolStripButton()
        Me.Dblast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DbAdd = New System.Windows.Forms.ToolStripButton()
        Me.DbEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DbSave = New System.Windows.Forms.ToolStripButton()
        Me.DbDelet = New System.Windows.Forms.ToolStripButton()
        Me.DbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CustomerTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.customerTableAdapter()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DbToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cusName, Me.IdDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(836, 199)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'cusName
        '
        Me.cusName.DataPropertyName = "cusName"
        Me.cusName.HeaderText = "名称"
        Me.cusName.MaxInputLength = 40
        Me.cusName.Name = "cusName"
        Me.cusName.ReadOnly = True
        Me.cusName.Width = 200
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        DataGridViewCellStyle1.Format = "0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.IdDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IdDataGridViewTextBoxColumn.HeaderText = "客户ID"
        Me.IdDataGridViewTextBoxColumn.MaxInputLength = 4
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 65
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = " 地址"
        Me.LocationDataGridViewTextBoxColumn.MaxInputLength = 40
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocationDataGridViewTextBoxColumn.Width = 200
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "电话"
        Me.TelDataGridViewTextBoxColumn.MaxInputLength = 12
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "传真"
        Me.FaxDataGridViewTextBoxColumn.MaxInputLength = 12
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        Me.FaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "邮箱"
        Me.EmailDataGridViewTextBoxColumn.MaxInputLength = 40
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 130
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.YwtDataSetBindingSource
        '
        'YwtDataSetBindingSource
        '
        Me.YwtDataSetBindingSource.DataSource = Me.YwtDataSet
        Me.YwtDataSetBindingSource.Position = 0
        '
        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "客户ID"
        '
        'TextBoxCustId
        '
        Me.TextBoxCustId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Id", True))
        Me.TextBoxCustId.Enabled = False
        Me.TextBoxCustId.Location = New System.Drawing.Point(134, 355)
        Me.TextBoxCustId.MaxLength = 4
        Me.TextBoxCustId.Name = "TextBoxCustId"
        Me.TextBoxCustId.Size = New System.Drawing.Size(132, 21)
        Me.TextBoxCustId.TabIndex = 1
        '
        'TextBoxCustName
        '
        Me.TextBoxCustName.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCustName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cusName", True))
        Me.TextBoxCustName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBoxCustName.Location = New System.Drawing.Point(134, 388)
        Me.TextBoxCustName.MaxLength = 40
        Me.TextBoxCustName.Name = "TextBoxCustName"
        Me.TextBoxCustName.Size = New System.Drawing.Size(376, 21)
        Me.TextBoxCustName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "客户名称"
        '
        'TextBoxCustAdd
        '
        Me.TextBoxCustAdd.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCustAdd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Location", True))
        Me.TextBoxCustAdd.Location = New System.Drawing.Point(134, 420)
        Me.TextBoxCustAdd.Name = "TextBoxCustAdd"
        Me.TextBoxCustAdd.Size = New System.Drawing.Size(376, 21)
        Me.TextBoxCustAdd.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "客户地址"
        '
        'TextBoxCustTel
        '
        Me.TextBoxCustTel.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCustTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Tel", True))
        Me.TextBoxCustTel.Location = New System.Drawing.Point(134, 457)
        Me.TextBoxCustTel.Name = "TextBoxCustTel"
        Me.TextBoxCustTel.Size = New System.Drawing.Size(132, 21)
        Me.TextBoxCustTel.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "客户电话"
        '
        'TextBoxCustFax
        '
        Me.TextBoxCustFax.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCustFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Fax", True))
        Me.TextBoxCustFax.Location = New System.Drawing.Point(134, 491)
        Me.TextBoxCustFax.Name = "TextBoxCustFax"
        Me.TextBoxCustFax.Size = New System.Drawing.Size(132, 21)
        Me.TextBoxCustFax.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "客户传真"
        '
        'TextBoxCustEmail
        '
        Me.TextBoxCustEmail.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCustEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.TextBoxCustEmail.Location = New System.Drawing.Point(134, 530)
        Me.TextBoxCustEmail.Name = "TextBoxCustEmail"
        Me.TextBoxCustEmail.Size = New System.Drawing.Size(132, 21)
        Me.TextBoxCustEmail.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 533)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "客户邮箱"
        '
        'DbToolStrip
        '
        Me.DbToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.DbToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.DbFirst, Me.DbPrev, Me.ToolStripTextBox1, Me.DbNext, Me.Dblast, Me.ToolStripSeparator2, Me.DbAdd, Me.DbEdit, Me.ToolStripButton1, Me.DbSave, Me.DbDelet, Me.DbRefresh, Me.ToolStripSeparator5, Me.ToolStripButton2, Me.ToolStripSeparator3})
        Me.DbToolStrip.Location = New System.Drawing.Point(9, 9)
        Me.DbToolStrip.Name = "DbToolStrip"
        Me.DbToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.DbToolStrip.Size = New System.Drawing.Size(391, 25)
        Me.DbToolStrip.TabIndex = 21
        Me.DbToolStrip.Text = "DbToolStrip"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'DbFirst
        '
        Me.DbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DbFirst.Image = CType(resources.GetObject("DbFirst.Image"), System.Drawing.Image)
        Me.DbFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbFirst.Name = "DbFirst"
        Me.DbFirst.Size = New System.Drawing.Size(23, 22)
        Me.DbFirst.Text = "ToolStripButton1"
        Me.DbFirst.ToolTipText = "第一条"
        '
        'DbPrev
        '
        Me.DbPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DbPrev.Image = CType(resources.GetObject("DbPrev.Image"), System.Drawing.Image)
        Me.DbPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbPrev.Name = "DbPrev"
        Me.DbPrev.Size = New System.Drawing.Size(23, 22)
        Me.DbPrev.Text = "ToolStripButton2"
        Me.DbPrev.ToolTipText = "上一条"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'DbNext
        '
        Me.DbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DbNext.Image = CType(resources.GetObject("DbNext.Image"), System.Drawing.Image)
        Me.DbNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbNext.Name = "DbNext"
        Me.DbNext.Size = New System.Drawing.Size(23, 22)
        Me.DbNext.Text = "ToolStripButton3"
        Me.DbNext.ToolTipText = "下一条"
        '
        'Dblast
        '
        Me.Dblast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Dblast.Image = CType(resources.GetObject("Dblast.Image"), System.Drawing.Image)
        Me.Dblast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Dblast.Name = "Dblast"
        Me.Dblast.Size = New System.Drawing.Size(23, 22)
        Me.Dblast.Text = "ToolStripButton4"
        Me.Dblast.ToolTipText = "最后一条"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DbAdd
        '
        Me.DbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DbAdd.Image = CType(resources.GetObject("DbAdd.Image"), System.Drawing.Image)
        Me.DbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbAdd.Name = "DbAdd"
        Me.DbAdd.Size = New System.Drawing.Size(23, 22)
        Me.DbAdd.Text = "ToolStripButton5"
        Me.DbAdd.ToolTipText = "新增"
        '
        'DbEdit
        '
        Me.DbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DbEdit.Image = CType(resources.GetObject("DbEdit.Image"), System.Drawing.Image)
        Me.DbEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbEdit.Name = "DbEdit"
        Me.DbEdit.Size = New System.Drawing.Size(23, 22)
        Me.DbEdit.Text = "ToolStripButton6"
        Me.DbEdit.ToolTipText = "编辑"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'DbSave
        '
        Me.DbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DbSave.Image = CType(resources.GetObject("DbSave.Image"), System.Drawing.Image)
        Me.DbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbSave.Name = "DbSave"
        Me.DbSave.Size = New System.Drawing.Size(23, 22)
        Me.DbSave.Text = "ToolStripButton7"
        Me.DbSave.ToolTipText = "确认"
        '
        'DbDelet
        '
        Me.DbDelet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DbDelet.Image = CType(resources.GetObject("DbDelet.Image"), System.Drawing.Image)
        Me.DbDelet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbDelet.Name = "DbDelet"
        Me.DbDelet.Size = New System.Drawing.Size(23, 22)
        Me.DbDelet.Text = "ToolStripButton2"
        Me.DbDelet.ToolTipText = "删除"
        '
        'DbRefresh
        '
        Me.DbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DbRefresh.Image = CType(resources.GetObject("DbRefresh.Image"), System.Drawing.Image)
        Me.DbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbRefresh.Name = "DbRefresh"
        Me.DbRefresh.Size = New System.Drawing.Size(23, 22)
        Me.DbRefresh.Text = "ToolStripButton8"
        Me.DbRefresh.ToolTipText = "刷新"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(353, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 28)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "客户信息综合业务"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Tel", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(358, 457)
        Me.MaskedTextBox1.Mask = "000-0000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(152, 21)
        Me.MaskedTextBox1.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 611)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DbToolStrip)
        Me.Controls.Add(Me.TextBoxCustEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxCustFax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxCustTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCustAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCustName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCustId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "客户基础信息录入"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DbToolStrip.ResumeLayout(False)
        Me.DbToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents YwtDataSetBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ywtDataSetTableAdapters.customerTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCustId As TextBox
    Friend WithEvents TextBoxCustName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCustAdd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCustTel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCustFax As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCustEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DbToolStrip As ToolStrip
    Friend WithEvents DbPrev As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents DbNext As ToolStripButton
    Friend WithEvents Dblast As ToolStripButton
    Friend WithEvents DbEdit As ToolStripButton
    Friend WithEvents DbSave As ToolStripButton
    Friend WithEvents DbAdd As ToolStripButton
    Friend WithEvents DbRefresh As ToolStripButton
    Private WithEvents DbFirst As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DbDelet As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cusName As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
