Imports System.Windows.Forms
Imports YWT_mysql


Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' 创建此子窗体的一个新实例。
        '  Dim ChildForm As New System.Windows.Forms.Form
        ' 在显示该窗体前使其成为此 MDI 窗体的子窗体。
        ' ChildForm.MdiParent = Me

        '  m_ChildFormNumber += 1
        '  ChildForm.Text = "窗口 " & m_ChildFormNumber


        '  ChildForm.Show()
    End Sub




    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub


    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' 关闭此父窗体的所有子窗体。
        For Each ChildForm As Form In MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub 综合查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 综合查询ToolStripMenuItem.Click
        Form2.Show()

    End Sub



    Private Sub 信息录入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 信息录入ToolStripMenuItem.Click
        customer_input.Show()
    End Sub

    Private Sub 维修登记ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 维修登记ToolStripMenuItem.Click
        RepairOrderInput.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TESTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TESTToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub FORM5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORM5ToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub Form6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form6ToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub FOMR7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FOMR7ToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub 联系人信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 联系人信息ToolStripMenuItem.Click
        ContactsInput.Show()
    End Sub

    Private Sub 维修登记2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 维修登记2ToolStripMenuItem.Click

    End Sub

    Private Sub ViewMenu_Click(sender As Object, e As EventArgs) Handles ViewMenu.Click

    End Sub

    Private Sub 业务处理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 业务处理ToolStripMenuItem.Click

    End Sub
End Class


