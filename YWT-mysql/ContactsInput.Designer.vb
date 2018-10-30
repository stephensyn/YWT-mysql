<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactsInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactsInput))
        Me.ToolStripStatusLabel = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OK_Button = New System.Windows.Forms.ToolStripButton()
        Me.Cance_Button = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tb_ContactsTel2 = New System.Windows.Forms.MaskedTextBox()
        Me.Tb_ContactsTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_No = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCustName = New System.Windows.Forms.Label()
        Me.Tb_ContactsEmail = New System.Windows.Forms.TextBox()
        Me.Tb_Con_Cus = New System.Windows.Forms.TextBox()
        Me.LabelCustLocation = New System.Windows.Forms.Label()
        Me.LabelCustTel = New System.Windows.Forms.Label()
        Me.LabelCustFax = New System.Windows.Forms.Label()
        Me.Tb_ContactsLocation = New System.Windows.Forms.TextBox()
        Me.LabelCustEmail = New System.Windows.Forms.Label()
        Me.Tb_ContactstName = New System.Windows.Forms.TextBox()
        Me.UIname = New System.Windows.Forms.Label()
        Me.ContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New YWT_mysql.ywtDataSet()
        Me.ContactsTableAdapter = New YWT_mysql.ywtDataSetTableAdapters.contactsTableAdapter()
        Me.ToolStripStatusLabel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.ToolStripStatusLabel.Location = New System.Drawing.Point(0, 259)
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(442, 22)
        Me.ToolStripStatusLabel.TabIndex = 0
        Me.ToolStripStatusLabel.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.OK_Button, Me.Cance_Button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(442, 39)
        Me.ToolStrip1.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tb_ContactsTel2)
        Me.GroupBox1.Controls.Add(Me.Tb_ContactsTel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Tb_No)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LabelCustName)
        Me.GroupBox1.Controls.Add(Me.Tb_ContactsEmail)
        Me.GroupBox1.Controls.Add(Me.Tb_Con_Cus)
        Me.GroupBox1.Controls.Add(Me.LabelCustLocation)
        Me.GroupBox1.Controls.Add(Me.LabelCustTel)
        Me.GroupBox1.Controls.Add(Me.LabelCustFax)
        Me.GroupBox1.Controls.Add(Me.Tb_ContactsLocation)
        Me.GroupBox1.Controls.Add(Me.LabelCustEmail)
        Me.GroupBox1.Controls.Add(Me.Tb_ContactstName)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 169)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'Tb_ContactsTel2
        '
        Me.Tb_ContactsTel2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.Tb_ContactsTel2.Location = New System.Drawing.Point(86, 129)
        Me.Tb_ContactsTel2.Mask = "000-0000-0000"
        Me.Tb_ContactsTel2.Name = "Tb_ContactsTel2"
        Me.Tb_ContactsTel2.Size = New System.Drawing.Size(120, 21)
        Me.Tb_ContactsTel2.TabIndex = 3
        '
        'Tb_ContactsTel
        '
        Me.Tb_ContactsTel.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.Tb_ContactsTel.Location = New System.Drawing.Point(86, 101)
        Me.Tb_ContactsTel.Mask = "000-0000-0000"
        Me.Tb_ContactsTel.Name = "Tb_ContactsTel"
        Me.Tb_ContactsTel.Size = New System.Drawing.Size(120, 21)
        Me.Tb_ContactsTel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "编号："
        '
        'Tb_No
        '
        Me.Tb_No.Enabled = False
        Me.Tb_No.Location = New System.Drawing.Point(340, 45)
        Me.Tb_No.Name = "Tb_No"
        Me.Tb_No.Size = New System.Drawing.Size(46, 21)
        Me.Tb_No.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "所属单位："
        '
        'LabelCustName
        '
        Me.LabelCustName.AutoSize = True
        Me.LabelCustName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustName.Location = New System.Drawing.Point(39, 48)
        Me.LabelCustName.Name = "LabelCustName"
        Me.LabelCustName.Size = New System.Drawing.Size(44, 12)
        Me.LabelCustName.TabIndex = 2
        Me.LabelCustName.Text = "姓名："
        '
        'Tb_ContactsEmail
        '
        Me.Tb_ContactsEmail.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Tb_ContactsEmail.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Tb_ContactsEmail.Location = New System.Drawing.Point(266, 130)
        Me.Tb_ContactsEmail.Name = "Tb_ContactsEmail"
        Me.Tb_ContactsEmail.Size = New System.Drawing.Size(120, 21)
        Me.Tb_ContactsEmail.TabIndex = 4
        '
        'Tb_Con_Cus
        '
        Me.Tb_Con_Cus.Enabled = False
        Me.Tb_Con_Cus.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Tb_Con_Cus.Location = New System.Drawing.Point(86, 18)
        Me.Tb_Con_Cus.Name = "Tb_Con_Cus"
        Me.Tb_Con_Cus.Size = New System.Drawing.Size(300, 21)
        Me.Tb_Con_Cus.TabIndex = 5
        '
        'LabelCustLocation
        '
        Me.LabelCustLocation.AutoSize = True
        Me.LabelCustLocation.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustLocation.Location = New System.Drawing.Point(39, 76)
        Me.LabelCustLocation.Name = "LabelCustLocation"
        Me.LabelCustLocation.Size = New System.Drawing.Size(44, 12)
        Me.LabelCustLocation.TabIndex = 3
        Me.LabelCustLocation.Text = "地址："
        '
        'LabelCustTel
        '
        Me.LabelCustTel.AutoSize = True
        Me.LabelCustTel.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustTel.Location = New System.Drawing.Point(39, 104)
        Me.LabelCustTel.Name = "LabelCustTel"
        Me.LabelCustTel.Size = New System.Drawing.Size(44, 12)
        Me.LabelCustTel.TabIndex = 4
        Me.LabelCustTel.Text = "电话："
        '
        'LabelCustFax
        '
        Me.LabelCustFax.AutoSize = True
        Me.LabelCustFax.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustFax.Location = New System.Drawing.Point(13, 133)
        Me.LabelCustFax.Name = "LabelCustFax"
        Me.LabelCustFax.Size = New System.Drawing.Size(70, 12)
        Me.LabelCustFax.TabIndex = 5
        Me.LabelCustFax.Text = "备用电话："
        '
        'Tb_ContactsLocation
        '
        Me.Tb_ContactsLocation.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Tb_ContactsLocation.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Tb_ContactsLocation.Location = New System.Drawing.Point(86, 73)
        Me.Tb_ContactsLocation.Name = "Tb_ContactsLocation"
        Me.Tb_ContactsLocation.Size = New System.Drawing.Size(300, 21)
        Me.Tb_ContactsLocation.TabIndex = 1
        '
        'LabelCustEmail
        '
        Me.LabelCustEmail.AutoSize = True
        Me.LabelCustEmail.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCustEmail.Location = New System.Drawing.Point(219, 133)
        Me.LabelCustEmail.Name = "LabelCustEmail"
        Me.LabelCustEmail.Size = New System.Drawing.Size(44, 12)
        Me.LabelCustEmail.TabIndex = 6
        Me.LabelCustEmail.Text = "邮箱："
        '
        'Tb_ContactstName
        '
        Me.Tb_ContactstName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Tb_ContactstName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Tb_ContactstName.Location = New System.Drawing.Point(86, 45)
        Me.Tb_ContactstName.Name = "Tb_ContactstName"
        Me.Tb_ContactstName.Size = New System.Drawing.Size(120, 21)
        Me.Tb_ContactstName.TabIndex = 0
        '
        'UIname
        '
        Me.UIname.AutoSize = True
        Me.UIname.Font = New System.Drawing.Font("宋体", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UIname.Location = New System.Drawing.Point(154, 42)
        Me.UIname.Name = "UIname"
        Me.UIname.Size = New System.Drawing.Size(135, 24)
        Me.UIname.TabIndex = 13
        Me.UIname.Text = "联系人信息"
        '
        'ContactsBindingSource
        '
        Me.ContactsBindingSource.DataMember = "contacts"
        Me.ContactsBindingSource.DataSource = Me.YwtDataSet
        '
        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'ContactsInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 281)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UIname)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ToolStripStatusLabel)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ContactsInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "联系人信息"
        Me.ToolStripStatusLabel.ResumeLayout(False)
        Me.ToolStripStatusLabel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripStatusLabel As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents OK_Button As ToolStripButton
    Friend WithEvents Cance_Button As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_No As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_Con_Cus As TextBox
    Friend WithEvents LabelCustName As Label
    Friend WithEvents Tb_ContactsEmail As TextBox
    Friend WithEvents LabelCustLocation As Label
    Friend WithEvents LabelCustTel As Label
    Friend WithEvents LabelCustFax As Label
    Friend WithEvents Tb_ContactsLocation As TextBox
    Friend WithEvents LabelCustEmail As Label
    Friend WithEvents Tb_ContactstName As TextBox
    Friend WithEvents UIname As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Tb_ContactsTel2 As MaskedTextBox
    Friend WithEvents Tb_ContactsTel As MaskedTextBox
    Friend WithEvents ContactsBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents ContactsTableAdapter As ywtDataSetTableAdapters.contactsTableAdapter
End Class
