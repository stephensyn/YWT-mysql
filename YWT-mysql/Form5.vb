Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.customer”中。您可以根据需要移动或删除它。
        Me.CustomerTableAdapter.Fill(Me.YwtDataSet.customer)
        'TODO: 这行代码将数据加载到表“YwtDataSet.order”中。您可以根据需要移动或删除它。
        Me.OrderTableAdapter.Fill(Me.YwtDataSet.order)

        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub MyComboBox1_TextChanged(sender As Object, e As EventArgs) Handles MyComboBox1.TextChanged

        OrderBindingSource.Filter = "客户名称='" & MyComboBox1.Text & "'"
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <= TextBox2.Text Then

            OrderBindingSource.Filter = "维修单号>='" & TextBox1.Text & "' and  维修单号<='" & TextBox2.Text & "'"

        Else

            OrderBindingSource.Filter = "维修单号>='" & TextBox2.Text & "' and  维修单号<='" & TextBox1.Text & "'"
        End If

        ReportViewer1.RefreshReport()
    End Sub
End Class