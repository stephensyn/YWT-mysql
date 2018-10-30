<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        '     Me.MyComboBox1 = New OwnCtl.MyComboBox()
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.DeviceNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevicenameTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicenameTableAdapter()
        Me.RepairOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairorderTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.repairorderTableAdapter()
        Me.DeviceModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevicemodelTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicemodelTableAdapter()
        Me.DevicebrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevicebrandTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.devicebrandTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeviceNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeviceModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevicebrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "名称"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(567, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(447, 399)
        Me.DataGridView1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(369, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "品牌"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(29, 63)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(457, 399)
        Me.DataGridView2.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(478, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "型号"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(602, 34)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "模块型号"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MyComboBox1
        '

        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeviceNameBindingSource
        '
        Me.DeviceNameBindingSource.DataMember = "devicename"
        Me.DeviceNameBindingSource.DataSource = Me.YwtDataSet
        '
        'DevicenameTableAdapter
        '
        Me.DevicenameTableAdapter.ClearBeforeFill = True
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
        'DeviceModelBindingSource
        '
        Me.DeviceModelBindingSource.DataMember = "devicemodel"
        Me.DeviceModelBindingSource.DataSource = Me.YwtDataSet
        '
        'DevicemodelTableAdapter
        '
        Me.DevicemodelTableAdapter.ClearBeforeFill = True
        '
        'DevicebrandBindingSource
        '
        Me.DevicebrandBindingSource.DataMember = "devicebrand"
        Me.DevicebrandBindingSource.DataSource = Me.YwtDataSet
        '
        'DevicebrandTableAdapter
        '
        Me.DevicebrandTableAdapter.ClearBeforeFill = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 745)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        '  Me.Controls.Add(Me.MyComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeviceNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeviceModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevicebrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    '  Friend WithEvents MyComboBox1 As OwnCtl.MyComboBox
    Friend WithEvents DeviceNameBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents DevicenameTableAdapter As ywtDataSetTableAdapters.devicenameTableAdapter
    Friend WithEvents RepairOrderBindingSource As BindingSource
    Friend WithEvents RepairorderTableAdapter As ywtDataSetTableAdapters.repairorderTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DeviceModelBindingSource As BindingSource
    Friend WithEvents DevicemodelTableAdapter As ywtDataSetTableAdapters.devicemodelTableAdapter
    Friend WithEvents DevicebrandBindingSource As BindingSource
    Friend WithEvents DevicebrandTableAdapter As ywtDataSetTableAdapters.devicebrandTableAdapter
End Class
