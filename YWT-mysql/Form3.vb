Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Form3
    Dim cnObj As Object
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.repairorder”中。您可以根据需要移动或删除它。
        Me.RepairorderTableAdapter.Fill(Me.YwtDataSet.repairorder)
        'TODO: 这行代码将数据加载到表“YwtDataSet.contacts”中。您可以根据需要移动或删除它。
        Me.ContactsTableAdapter.Fill(Me.YwtDataSet.contacts)
        'TODO: 这行代码将数据加载到表“YwtDataSet.customer”中。您可以根据需要移动或删除它。
        Me.CustomerTableAdapter.Fill(Me.YwtDataSet.customer)
        'TODO: 这行代码将数据加载到表“YwtDataSet.order”中。您可以根据需要移动或删除它。
        Me.OrderTableAdapter.Fill(Me.YwtDataSet.order)
        MdiParent = MDIParent1
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ConMyComboBox.DataSouce = Dgv2Dsc(DataGridView1, "联系人", YwtDataSet.contacts, "contactsname")
        CusMyComboBox.DataSouce = Dgv2Dsc(DataGridView1, "客户名称", YwtDataSet.customer, "cusname")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim cusDS As New BindingSource()
        Dim tempCusDt As DataTable = YwtDataSet.customer.Clone


        Dim verCusName As String = vbNullString

        Dim tempOrderDS As BindingSource = DataGridView1.DataSource
        Dim drv As DataRowView = CType(tempOrderDS.Current, DataRowView)

        If drv IsNot Nothing Then
            tempCusDt.Clear()
            drv.DataView.Sort = "客户名称"
            For i As Integer = 0 To drv.DataView.Count - 1

                If verCusName <> drv.DataView.Item(i).Item("客户名称") Then

                    verCusName = drv.DataView.Item(i).Item("客户名称")

                    YwtDataSet.customer.DefaultView.Sort = "CusName"

                    Dim dr As DataRow() = YwtDataSet.customer.Select("CusName ='" & verCusName & "'")
                    tempCusDt.ImportRow(dr(0))

                Else


                End If


            Next
            cusDS.DataSource = tempCusDt
            CusMyComboBox.DataSouce = cusDS
        End If

    End Sub

    Private Sub Form3_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Label1.Focus()
    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        OrderBindingSource.Filter = "接件日期>=  #" & DateTimePicker1.Value & " # And 接件日期<=  #" & DateTimePicker2.Value & " #  "
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        OrderBindingSource.Filter = "接件日期>=  #" & DateTimePicker1.Value & " # And 接件日期<=  #" & DateTimePicker2.Value & " #  "
    End Sub

    Private Sub CusMyComboBox_TextChanged(sender As Object, e As EventArgs) Handles CusMyComboBox.TextChanged
        If CusMyComboBox.Text = "" Then

            OrderBindingSource.Filter = " "
        Else

            OrderBindingSource.Filter = "客户名称='" & CusMyComboBox.Text & "'"
        End If
    End Sub

    Private Sub ConMyComboBox_TextChanged(sender As Object, e As EventArgs) Handles ConMyComboBox.TextChanged
        If ConMyComboBox.Text = "" Then

            OrderBindingSource.Filter = " "
        Else

            OrderBindingSource.Filter = "联系人='" & ConMyComboBox.Text & "'"
        End If
    End Sub



    Private Sub RepairsOrSn_TextChanged(sender As Object, e As EventArgs) Handles RepairsOrSn.TextChanged
        Dim index As Integer = ReOrBindingSource.Find("ID", RepairsOrSn.Text)
        If index <> -1 Then
            ReOrBindingSource.Position = index

        End If
    End Sub





    Private Sub FaultDescription_Validating(sender As Object, e As CancelEventArgs) Handles FaultDescription.Validating


        If FaultDescription.Tag <> FaultDescription.Text Then

            If MsgBox("确认修改吗?"， vbYesNo + vbQuestion, "故障详情更新") = vbYes Then

                DataGridView1.EndEdit()
                OrderBindingSource.EndEdit()
                ReOrBindingSource.EndEdit()
                RepairorderTableAdapter.Update(YwtDataSet.repairorder)

            Else
                ReOrBindingSource.CancelEdit()


            End If

        Else


        End If
    End Sub

    Private Sub FaultDescription_GotFocus(sender As Object, e As EventArgs) Handles FaultDescription.GotFocus
        FaultDescription.Tag = FaultDescription.Text
    End Sub
End Class