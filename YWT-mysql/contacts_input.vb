Public Class contacts_input
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub contacts_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.customer”中。您可以根据需要移动或删除它。
        Me.CustomerTableAdapter.Fill(Me.YwtDataSet.customer)
        'TODO: 这行代码将数据加载到表“YwtDataSet.contacts”中。您可以根据需要移动或删除它。
        Me.ContactsTableAdapter.Fill(Me.YwtDataSet.contacts)

    End Sub
End Class