Imports System.ComponentModel

Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.order”中。您可以根据需要移动或删除它。
        Me.OrderTableAdapter.Fill(Me.YwtDataSet.order)
        'TODO: 这行代码将数据加载到表“YwtDataSet.repairorder”中。您可以根据需要移动或删除它。
        Me.RepairorderTableAdapter.Fill(Me.YwtDataSet.repairorder)
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicemodel”中。您可以根据需要移动或删除它。
        Me.DevicemodelTableAdapter.Fill(Me.YwtDataSet.devicemodel)

    End Sub

    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub DataGridView2_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RepairOrBindingSource.EndEdit()
        RepairorderTableAdapter.Update(YwtDataSet.repairorder)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub OrderBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles OrderBindingSource.CurrentItemChanged

    End Sub
End Class