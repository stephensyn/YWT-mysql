<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HR管理RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.客户管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.信息录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.客户信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.联系人信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.销售ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.维修ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.维修登记ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.维修登记2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.业务处理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.综合查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FORM5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOMR7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.综合ZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintPreviewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.YwtDataSet1 = New YWT_mysql.ywtDataSet()
        Me.OrderTableAdapter1 = New YWT_mysql.ywtDataSetTableAdapters.orderTableAdapter()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.YwtDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HR管理RToolStripMenuItem, Me.EditMenu, Me.ViewMenu, Me.WindowsMenu, Me.综合ZToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(633, 27)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(59, 21)
        Me.FileMenu.Text = "系统(&S)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(113, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "退出(&X)"
        '
        'HR管理RToolStripMenuItem
        '
        Me.HR管理RToolStripMenuItem.Name = "HR管理RToolStripMenuItem"
        Me.HR管理RToolStripMenuItem.Size = New System.Drawing.Size(85, 21)
        Me.HR管理RToolStripMenuItem.Text = "HR管理（&R)"
        '
        'EditMenu
        '
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(60, 21)
        Me.EditMenu.Text = "库管(&K)"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.客户管理ToolStripMenuItem, Me.销售ToolStripMenuItem, Me.维修ToolStripMenuItem, Me.业务处理ToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(59, 21)
        Me.ViewMenu.Text = "业务(&Y)"
        '
        '客户管理ToolStripMenuItem
        '
        Me.客户管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.信息录入ToolStripMenuItem, Me.客户信息ToolStripMenuItem, Me.联系人信息ToolStripMenuItem})
        Me.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem"
        Me.客户管理ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.客户管理ToolStripMenuItem.Text = "客户管理"
        '
        '信息录入ToolStripMenuItem
        '
        Me.信息录入ToolStripMenuItem.Name = "信息录入ToolStripMenuItem"
        Me.信息录入ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.信息录入ToolStripMenuItem.Text = "信息录入"
        '
        '客户信息ToolStripMenuItem
        '
        Me.客户信息ToolStripMenuItem.Name = "客户信息ToolStripMenuItem"
        Me.客户信息ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.客户信息ToolStripMenuItem.Text = "客户信息"
        '
        '联系人信息ToolStripMenuItem
        '
        Me.联系人信息ToolStripMenuItem.Name = "联系人信息ToolStripMenuItem"
        Me.联系人信息ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.联系人信息ToolStripMenuItem.Text = "联系人信息"
        '
        '销售ToolStripMenuItem
        '
        Me.销售ToolStripMenuItem.Name = "销售ToolStripMenuItem"
        Me.销售ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.销售ToolStripMenuItem.Text = "销售"
        '
        '维修ToolStripMenuItem
        '
        Me.维修ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.维修登记ToolStripMenuItem, Me.维修登记2ToolStripMenuItem})
        Me.维修ToolStripMenuItem.Name = "维修ToolStripMenuItem"
        Me.维修ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.维修ToolStripMenuItem.Text = "维修"
        '
        '维修登记ToolStripMenuItem
        '
        Me.维修登记ToolStripMenuItem.Name = "维修登记ToolStripMenuItem"
        Me.维修登记ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.维修登记ToolStripMenuItem.Text = "维修登记"
        '
        '维修登记2ToolStripMenuItem
        '
        Me.维修登记2ToolStripMenuItem.Name = "维修登记2ToolStripMenuItem"
        Me.维修登记2ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.维修登记2ToolStripMenuItem.Text = "维修登记2"
        '
        '业务处理ToolStripMenuItem
        '
        Me.业务处理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.综合查询ToolStripMenuItem, Me.TESTToolStripMenuItem, Me.FORM5ToolStripMenuItem, Me.Form6ToolStripMenuItem, Me.FOMR7ToolStripMenuItem})
        Me.业务处理ToolStripMenuItem.Name = "业务处理ToolStripMenuItem"
        Me.业务处理ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.业务处理ToolStripMenuItem.Text = "查询"
        '
        '综合查询ToolStripMenuItem
        '
        Me.综合查询ToolStripMenuItem.Name = "综合查询ToolStripMenuItem"
        Me.综合查询ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.综合查询ToolStripMenuItem.Text = "综合查询"
        '
        'TESTToolStripMenuItem
        '
        Me.TESTToolStripMenuItem.Name = "TESTToolStripMenuItem"
        Me.TESTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TESTToolStripMenuItem.Text = "FORM3"
        '
        'FORM5ToolStripMenuItem
        '
        Me.FORM5ToolStripMenuItem.Name = "FORM5ToolStripMenuItem"
        Me.FORM5ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FORM5ToolStripMenuItem.Text = "FORM5"
        '
        'Form6ToolStripMenuItem
        '
        Me.Form6ToolStripMenuItem.Name = "Form6ToolStripMenuItem"
        Me.Form6ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Form6ToolStripMenuItem.Text = "FORM6"
        '
        'FOMR7ToolStripMenuItem
        '
        Me.FOMR7ToolStripMenuItem.Name = "FOMR7ToolStripMenuItem"
        Me.FOMR7ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FOMR7ToolStripMenuItem.Text = "FOMR7"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(60, 21)
        Me.WindowsMenu.Text = "财务(&C)"
        '
        '综合ZToolStripMenuItem
        '
        Me.综合ZToolStripMenuItem.Name = "综合ZToolStripMenuItem"
        Me.综合ZToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.综合ZToolStripMenuItem.Text = "综合（&Z)"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(61, 21)
        Me.HelpMenu.Text = "帮助(&H)"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ContentsToolStripMenuItem.Text = "目录(&C)"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.IndexToolStripMenuItem.Text = "索引(&I)"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SearchToolStripMenuItem.Text = "搜索(&S)"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(163, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AboutToolStripMenuItem.Text = "关于(&A) ..."
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.PrintToolStripButton, Me.PrintPreviewToolStripButton, Me.ToolStripSeparator2, Me.HelpToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(633, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "打印"
        '
        'PrintPreviewToolStripButton
        '
        Me.PrintPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintPreviewToolStripButton.Image = CType(resources.GetObject("PrintPreviewToolStripButton.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        Me.PrintPreviewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintPreviewToolStripButton.Text = "打印预览"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "帮助"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 395)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 15, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(633, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(32, 17)
        Me.ToolStripStatusLabel.Text = "状态"
        '
        'YwtDataSet1
        '
        Me.YwtDataSet1.DataSetName = "ywtDataSet"
        Me.YwtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderTableAdapter1
        '
        Me.OrderTableAdapter1.ClearBeforeFill = True
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(633, 417)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "业务通onmysql"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.YwtDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HR管理RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 客户管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 客户信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 联系人信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 销售ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 维修ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 维修登记ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 业务处理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 综合ZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 综合查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 信息录入ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YwtDataSet1 As ywtDataSet
    Friend WithEvents OrderTableAdapter1 As ywtDataSetTableAdapters.orderTableAdapter
    Friend WithEvents TESTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORM5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FOMR7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 维修登记2ToolStripMenuItem As ToolStripMenuItem
End Class
