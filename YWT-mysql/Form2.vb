Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicemodel”中。您可以根据需要移动或删除它。
        Me.DevicemodelTableAdapter.Fill(Me.YwtDataSet.devicemodel)
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicebrand”中。您可以根据需要移动或删除它。
        Me.DevicebrandTableAdapter.Fill(Me.YwtDataSet.devicebrand)
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicename”中。您可以根据需要移动或删除它。
        Me.DevicenameTableAdapter.Fill(Me.YwtDataSet.devicename)
        'TODO: 这行代码将数据加载到表“YwtDataSet.contacts”中。您可以根据需要移动或删除它。
        Me.ContactsTableAdapter.Fill(Me.YwtDataSet.contacts)
        'TODO: 这行代码将数据加载到表“YwtDataSet.customer”中。您可以根据需要移动或删除它。
        Me.CustomerTableAdapter.Fill(Me.YwtDataSet.customer)
        'TODO: 这行代码将数据加载到表“YwtDataSet.order”中。您可以根据需要移动或删除它。
        Me.OrderTableAdapter.Fill(Me.YwtDataSet.order)
        MdiParent = MDIParent1

        Dim Mysql As New MySqlDataAdapter()


    End Sub



    Private Sub CusMyComboBox_TextChanged(sender As Object, e As EventArgs) Handles CusMyComboBox.TextChanged

        If CusMyComboBox.Text = "" Then
            RepairOrderBindingSource.Filter = ""

        Else
            If ConMyComboBox.Text = "" Then
                RepairOrderBindingSource.Filter = "客户名称='" & CusMyComboBox.Text & "'"

            Else
                RepairOrderBindingSource.Filter = "联系人='" & ConMyComboBox.Text & "'"
            End If

        End If



        ConMyComboBox.Int()

        ConBindingSource.Filter = "CustomerId='" & CusMyComboBox.Value & "'"
        Dim drv2 As DataRowView = ConBindingSource.Current
        If drv2 IsNot Nothing Then
            Dim bds As New BindingSource()

            bds.DataSource = drv2.DataView.ToTable

            If bds.Count = 0 Then
                ConMyComboBox.DataSouce = Nothing
            Else

                ConMyComboBox.DataSouce = bds
                ConMyComboBox.DisplayMember = "ContactsName"
                ConMyComboBox.ValueMember = "Id"
            End If

        Else

        End If

    End Sub

    Private Sub ConMyComboBox_TextChanged(sender As Object, e As EventArgs) Handles ConMyComboBox.TextChanged

        If CusMyComboBox.Text = "" Then

            'RepairOrderBindingSource.Filter = ""
        Else

            RepairOrderBindingSource.Filter = " 联系人='" & ConMyComboBox.Text & "'"

        End If



    End Sub


End Class