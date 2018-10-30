Imports MySql.Data.MySqlClient
Public Class Form6
    Dim cnObj As Object
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Dim dvDev As DataView

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicebrand”中。您可以根据需要移动或删除它。
        Me.DevicebrandTableAdapter.Fill(Me.YwtDataSet.devicebrand)
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicemodel”中。您可以根据需要移动或删除它。
        Me.DevicemodelTableAdapter.Fill(Me.YwtDataSet.devicemodel)
        'TODO: 这行代码将数据加载到表“YwtDataSet.repairorder”中。您可以根据需要移动或删除它。
        Me.RepairorderTableAdapter.Fill(Me.YwtDataSet.repairorder)
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicename”中。您可以根据需要移动或删除它。
        Me.DevicenameTableAdapter.Fill(Me.YwtDataSet.devicename)
        'TODO: 这行代码将数据加载到表“YwtDataSet.test”中。您可以根据需要移动或删除它。


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i As Integer = 0

        dvDev = (YwtModule.GetNewtable(YwtDataSet.repairorder, "DeviceName like '%'")).DefaultView
        DataGridView1.DataSource = dvDev.ToTable(True, "DeviceName")

        Do While i < (dvDev.ToTable(True, "DeviceName")).Rows.Count

            MsgBox("gengxin" & (dvDev.ToTable(True, "DeviceName")).Rows.Item(i).Item(0))


            Try
                cnObj = DevicenameTableAdapter.Connection
                cnObj.open()

                cm = New MySqlCommand("InsertDevName", cnObj)
                cm.CommandType = CommandType.StoredProcedure
                cm.Parameters.Add("vDeviceName", MySqlDbType.VarChar, 30).Value = (dvDev.ToTable(True, "DeviceName")).Rows.Item(i).Item(0).ToString
                cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.Output
                cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
                cm.ExecuteNonQuery()
                MsgBox(cm.Parameters("vMsg").Value & "第" & cm.Parameters("vId").Value & "号计录")

            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try
            cnObj.close()

            i += 1

        Loop



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer = 0
        Dim tbDev As DataTable
        dvDev = (YwtModule.GetNewtable(YwtDataSet.repairorder, "DeviceName like '%'")).DefaultView
        tbDev = dvDev.ToTable(True, "DeviceName", "DeviceBrand")
        DataGridView1.DataSource = tbDev

        Do While i < tbDev.Rows.Count
            Dim drvDevName As DataRowView = DeviceNameBindingSource.Current()
            drvDevName.DataView.Sort = "DeviceName"
            Dim vId As Integer = drvDevName.DataView.Find(tbDev.Rows.Item(i).Item(0).ToString)
            DataGridView2.DataSource = drvDevName.DataView
            MsgBox(drvDevName.DataView.Item(vId).Item(0) & "/" & tbDev.Rows.Item(i).Item(0) & "/" & tbDev.Rows.Item(i).Item(1))


            Try
                cnObj = DevicebrandTableAdapter.Connection
                cnObj.open()

                cm = New MySqlCommand("InsertDevBrand", cnObj)
                cm.CommandType = CommandType.StoredProcedure
                cm.Parameters.Add("vDeviceNameId", MySqlDbType.VarChar, 4).Value = drvDevName.DataView.Item(vId).Item(0).ToString
                cm.Parameters.Add("vBrandName", MySqlDbType.VarChar, 30).Value = tbDev.Rows.Item(i).Item(1).ToString
                cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.Output
                cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
                cm.ExecuteNonQuery()
                MsgBox(cm.Parameters("vMsg").Value & "第" & cm.Parameters("vId").Value & "号计录")
                'CustomerTableAdapter.Fill(YwtDataSet.customer)
            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try
            cnObj.close()
            i += 1
        Loop


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '从旧的维修单中提取仪表设备型号填充DeviceModel表
        '需要根据设备类别名称在类别名称表DeviceName表中找到对应的类别名称对应的ID
        '需要根据品牌名称和类别名称ID在DeviceBrand表中找到对应的品牌ID;(注意！同品牌的产品如果类别名称不同，其品牌ID是不相同的。
        '最后吧类别名称ID、品牌名称ID、和型号名称通过调用存储过程写入DeviceModel表中。

        Dim i As Integer = 0

        '调用模块"GetNewtable"从旧的维修单RepairOrder表中筛选出"型号名称:DeviceModel"列表。同时列出其对于的“类别名称:DeviceName”_
        '"品牌名称：DeviceBrand"
        '本步骤最终产生包含："DeviceName", "DeviceBrand", "DeviceModel"的信号列表:“tbDev表”
        Dim tbDev As DataTable
        dvDev = (YwtModule.GetNewtable(YwtDataSet.repairorder, "DeviceName like '%'")).DefaultView
        tbDev = dvDev.ToTable(True, "DeviceName", "DeviceBrand", "DeviceModel")
        DataGridView2.DataSource = tbDev

        ' Dim drvDevBrand As DataRowView = DevicebrandBindingSource.Current()
        ' DataGridView2.DataSource = drvDevBrand.DataView
        'drvDevBrand.DataView.Sort = "BrandName"


        '对型号列表“tbDev"表的遍历循环，从”类别名称表“、”品牌名称表“中找出每一个具体型号名称 _
        '所对应的”类别名称ID“， ”品牌名称ID“ 连同型号名词调用存储过程写入”DeviceModel“表中
        Do While i < tbDev.Rows.Count

            '在设备类别名称表”DeviceName“中查找到当前设备型号对应的设备名称的名称ID
            'tbDev.Rows.Item(i).Item(0)为型号列表tbDev中的”设备名称“
            Dim drvDevName As DataRowView = DeviceNameBindingSource.Current()
            drvDevName.DataView.Sort = "DeviceName"
            Dim vDevNameNo As Integer = drvDevName.DataView.Find(tbDev.Rows.Item(i).Item(0).ToString)
            Dim vDeviceId As String = drvDevName.DataView.Item(vDevNameNo).Item(0)

            '在设备品牌名称表”DeviceBrand“中，根据当前设备型号对应的品牌名称”BrandName“
            '以及改设备型号对应的设备类别名称ID”DeviceNameId“找到对应的品牌ID.
            '注意:同品牌而不同类别的产品有不同的品牌ID.
            'DATATABLE 的SELECT语句示例：
            'Detailtb.Select("WZMC='" + MaterialName + "' and   CZ='" + MaterialTexture + "   and   GG='" + MaterialSpecs + "'");//多字段过滤

            Dim drvDevBrand As DataRowView = DevicebrandBindingSource.Current()
            'DataGridView1.DataSource = drvDevBrand.DataView
            ' drvDevBrand.DataView.Sort = "BrandName"
            'Dim vDevBrandId As Integer = drvDevBrand.DataView.Find(tbDev.Rows.Item(i).Item(1).ToString)
            ' tbDev.Rows.Item(i).Item(1)为型号列表tbDev中的”设备品牌名称“
            DataGridView2.CurrentCell = DataGridView2.Rows(i).Cells(0)
            Dim vBrandName As String = tbDev.Rows.Item(i).Item(1).ToString
            Dim dtDevBrand As DataTable = (drvDevBrand.DataView.ToTable.Select("BrandName = '" + vBrandName + "' And DeviceNameId = '" + vDeviceId + "' ")).CopyToDataTable
            Dim vBrandId As String = dtDevBrand.DefaultView.Item(0).Item(0)
            DataGridView1.DataSource = dtDevBrand
            '显示将要写入型号表中的记录对应的品牌ID，名称ID,型号名称
            '  MsgBox(drvDevBrand.DataView.Item(vDevBrandId).Item(0) & "  /" &
            '  drvDevName.DataView.Item(vDevNameId).Item(0) & "   /" &
            '  tbDev.Rows.Item(i).Item(2))


            MsgBox(vBrandId & "  /" &
                  vDeviceId & "   /" &
                   tbDev.Rows.Item(i).Item(2)).ToString()

            Try
                cnObj = DevicemodelTableAdapter.Connection
                cnObj.open()

                cm = New MySqlCommand("InsertDevModel", cnObj)
                cm.CommandType = CommandType.StoredProcedure
                ' cm.Parameters.Add("vBrandId", MySqlDbType.VarChar, 4).Value = drvDevBrand.DataView.Item(vDevBrandId).Item(0).ToString
                cm.Parameters.Add("vBrandId", MySqlDbType.VarChar, 4).Value = vBrandId
                cm.Parameters.Add("vDeviceId", MySqlDbType.VarChar, 30).Value = vDeviceId
                cm.Parameters.Add("vDeviceModel", MySqlDbType.VarChar, 30).Value = tbDev.Rows.Item(i).Item(2).ToString
                cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.Output
                cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
                cm.ExecuteNonQuery()
                MsgBox(cm.Parameters("vMsg").Value & "第" & cm.Parameters("vId").Value & "号计录")
                'CustomerTableAdapter.Fill(YwtDataSet.customer)
            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try
            cnObj.close()


            i += 1
        Loop


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tbDev As DataTable
        dvDev = (YwtModule.GetNewtable(YwtDataSet.repairorder, "DeviceName Like '%'")).DefaultView
            tbDev = dvDev.ToTable(True, "DeviceName", "DeviceBrand", "DeviceModel")
        DataGridView1.DataSource = tbDev

    End Sub
End Class