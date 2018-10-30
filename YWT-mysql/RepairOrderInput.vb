Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports vbs = Microsoft.VisualBasic

Public Class RepairOrderInput
    Dim cnObj As Object
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub RepairOrderInput_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.repairorder”中。您可以根据需要移动或删除它。
        Me.RepairorderTableAdapter.Fill(Me.YwtDataSet.repairorder)
        'TODO: 这行代码将数据加载到表“YwtDataSet.moudlename”中。您可以根据需要移动或删除它。
        Me.MoudlenameTableAdapter.Fill(Me.YwtDataSet.moudlename)
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicemodel”中。您可以根据需要移动或删除它。
        Me.DevicemodelTableAdapter.Fill(Me.YwtDataSet.devicemodel)
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicebrand”中。您可以根据需要移动或删除它。
        Me.DevicebrandTableAdapter.Fill(Me.YwtDataSet.devicebrand)
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicename”中。您可以根据需要移动或删除它。
        Me.DevicenameTableAdapter.Fill(Me.YwtDataSet.devicename)
        'TODO: 这行代码将数据加载到表“YwtDataSet.moudlename”中。您可以根据需要移动或删除它。
        Me.MoudlenameTableAdapter.Fill(Me.YwtDataSet.moudlename)
        'TODO: 这行代码将数据加载到表“YwtDataSet.contacts”中。您可以根据需要移动或删除它。
        Me.ContactsTableAdapter.Fill(Me.YwtDataSet.contacts)
        'TODO: 这行代码将数据加载到表“YwtDataSet.customer”中。您可以根据需要移动或删除它。
        Me.CustomerTableAdapter.Fill(Me.YwtDataSet.customer)



        MdiParent = MDIParent1
        MyComboBox_ContactName.DataSouce = Nothing
        MyComboBox_DeviceBrand.DataSouce = Nothing
        MyComboBox_DevModel.DataSouce = Nothing
        MyComboBox_DevMoudleName.DataSouce = Nothing
    End Sub



    Private Sub FocusMove(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker1.KeyPress, MyComboBox_CusName.KeyPress _
    , MyComboBox_ContactName.KeyPress, MyComboBox_DevName.KeyPress, MyComboBox_DeviceBrand.KeyPress, MyComboBox_DevModel.KeyPress, TextBox_DevSn.KeyPress _
    , MyComboBox_DevMoudleName.KeyPress, TextBox_MoudleSn.KeyPress, TextBox_DevAccessory.KeyPress, TextBox_FaultDescription.KeyPress
        If e.KeyChar = ChrW(13) Then
            '---SelectNextControl is a Function will be introduced next---
            SelectNextControl(sender, True, True, True, False)
        End If
    End Sub

    Private Sub MyComboBox_CusName_TextChanged(sender As Object, e As EventArgs) Handles MyComboBox_CusName.TextChanged

        '设定CUSTOMER 地址


        If MyComboBox_CusName.Value IsNot vbNullString Then
            Dim drv As DataRowView = MyComboBox_CusName.DataSouce.Current
            drv.DataView.Sort = MyComboBox_CusName.ValueMember
            Dim no As Integer = drv.DataView.Find(MyComboBox_CusName.Value)
            TextBox_CusLocation.Text = drv.DataView.Item(no).Item(2)
        Else
            TextBox_CusLocation.Text = vbNullString
        End If


        '设定Contacts
        '   MyComboBox_ContactName.DataSouce = Nothing
        '  MyComboBox_ContactName.Text = vbNullString
        MyComboBox_ContactName.Int()

        ConBindingSource.Filter = "CustomerId='" & MyComboBox_CusName.Value & "'"
        Dim drv2 As DataRowView = ConBindingSource.Current
        If drv2 IsNot Nothing Then
            Dim bds As New BindingSource()

            bds.DataSource = drv2.DataView.ToTable

            If bds.Count = 0 Then
                MyComboBox_ContactName.DataSouce = Nothing
            Else

                MyComboBox_ContactName.DataSouce = bds
                MyComboBox_ContactName.DisplayMember = "ContactsName"
                MyComboBox_ContactName.ValueMember = "Id"
            End If

        Else

        End If




    End Sub

    Private Sub MyComboBox_ContactName_TextChanged(sender As Object, e As EventArgs) Handles MyComboBox_ContactName.TextChanged
        '设定Contacts_Location Tel 

        If MyComboBox_ContactName.Value IsNot vbNullString Then

            Dim drv As DataRowView = MyComboBox_ContactName.DataSouce.Current
            drv.DataView.Sort = MyComboBox_ContactName.ValueMember
            Dim no As Integer = drv.DataView.Find(MyComboBox_ContactName.Value)
            TextBox_ContactTel.Text = drv.DataView.Item(no).Item(5).ToString
            TextBox_ContactTel2.Text = drv.DataView.Item(no).Item(6).ToString
            TextBox_ContactLocation.Text = drv.DataView.Item(no).Item(4).ToString

        Else

            TextBox_ContactTel.Text = vbNullString
            TextBox_ContactTel2.Text = vbNullString
            TextBox_ContactLocation.Text = vbNullString

        End If

        '首先确定有有效的VALUE

    End Sub

    Private Sub RepairOrderInput_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Label1.Focus()
    End Sub

    Private Sub MyComboBox_DevName_TextChanged(sender As Object, e As EventArgs) Handles MyComboBox_DevName.TextChanged

        '设定DevBrand

        MyComboBox_DeviceBrand.Int()

        BrandBindingSource.Filter = "DeviceNameId='" & MyComboBox_DevName.Value & "'"
        Dim drv2 As DataRowView = BrandBindingSource.Current
        If drv2 IsNot Nothing Then
            Dim bds As New BindingSource()

            bds.DataSource = drv2.DataView.ToTable

            If bds.Count = 0 Then
                MyComboBox_DeviceBrand.DataSouce = Nothing
            Else

                MyComboBox_DeviceBrand.DataSouce = bds
                MyComboBox_DeviceBrand.DisplayMember = "BrandName"
                MyComboBox_DeviceBrand.ValueMember = "Id"
            End If

        Else

        End If

    End Sub

    Private Sub MyComboBox_DeviceBrand_TextChanged(sender As Object, e As EventArgs) Handles MyComboBox_DeviceBrand.TextChanged

        '设定DevModle

        MyComboBox_DevModel.Int()

        ModelBindingSource.Filter = "BrandId='" & MyComboBox_DeviceBrand.Value & "'"
        Dim drv2 As DataRowView = ModelBindingSource.Current
        If drv2 IsNot Nothing Then
            Dim bds As New BindingSource()

            bds.DataSource = drv2.DataView.ToTable

            If bds.Count = 0 Then
                MyComboBox_DevModel.DataSouce = Nothing
            Else

                MyComboBox_DevModel.DataSouce = bds
                MyComboBox_DevModel.DisplayMember = "DeviceModel"
                MyComboBox_DevModel.ValueMember = "Id"
            End If

        Else

        End If

    End Sub

    Private Sub MyComboBox_DevModel_TextChanged(sender As Object, e As EventArgs) Handles MyComboBox_DevModel.TextChanged
        '设定DevMoudle

        MyComboBox_DevMoudleName.Int()
        TextBox_DevSn.Text = vbNullString

        MoudleBindingSource.Filter = "ModelId='" & MyComboBox_DevModel.Value & "'"
        Dim drv2 As DataRowView = MoudleBindingSource.Current
        If drv2 IsNot Nothing Then
            Dim bds As New BindingSource()

            bds.DataSource = drv2.DataView.ToTable

            If bds.Count = 0 Then
                MyComboBox_DevMoudleName.DataSouce = Nothing
            Else

                MyComboBox_DevMoudleName.DataSouce = bds
                MyComboBox_DevMoudleName.DisplayMember = "MoudleName"
                MyComboBox_DevMoudleName.ValueMember = "Id"
            End If

        Else

        End If

    End Sub

    Private Sub MyComboBox_DevMoudleName_TextChanged(sender As Object, e As EventArgs) Handles MyComboBox_DevMoudleName.TextChanged

        TextBox_MoudleSn.Text = vbNullString
        If MyComboBox_DevMoudleName.Value IsNot vbNullString Then
            TextBox_MoudleSn.Enabled = True
        Else
            TextBox_MoudleSn.Enabled = False
        End If

    End Sub

    Private Sub MyComboBox_CusName_Validating(sender As Object, e As CancelEventArgs) Handles MyComboBox_CusName.Validating
        '设定如果组合框输入了新值，则调用客户信息录入窗口


        If MyComboBox_CusName.IsNew Then


            If MsgBox("添加新客户吗?"， vbYesNo + vbQuestion, "新增客户") = vbYes Then


                customer_input.TextBoxCustName.Text = MyComboBox_CusName.Text

                customer_input.ShowDialog()

            Else
                MyComboBox_CusName.Text = vbNullString
                MyComboBox_CusName.IsNew = False

            End If
            MyComboBox_CusName.Focus()
            MyComboBox_CusName.DropDown = False
            MyComboBox_CusName_TextChanged(sender, e)

        End If


    End Sub

    Private Sub RepairOrderBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles RepairOrderBindingSource.CurrentChanged
        ToolStripStatusLabel1.Text = "当前记录：" & RepairOrderBindingSource.Position + 1 & "/" & RepairOrderBindingSource.Count
    End Sub

    Private Sub MyComboBox_ContactName_Validating(sender As Object, e As CancelEventArgs) Handles MyComboBox_ContactName.Validating
        If MyComboBox_ContactName.IsNew Then


            If MsgBox("添加新的联系人吗?"， vbYesNo + vbQuestion, "新增联系人") = vbYes Then


                ContactsInput.Tb_ContactstName.Text = MyComboBox_ContactName.Text
                ContactsInput.Tb_Con_Cus.Text = MyComboBox_CusName.Text
                ContactsInput.Tb_Con_Cus.Tag = MyComboBox_CusName.Value
                ContactsInput.ShowDialog()

            Else
                MyComboBox_ContactName.Text = vbNullString
                MyComboBox_ContactName.IsNew = False

            End If


            MyComboBox_CusName_TextChanged(sender, e)


            MyComboBox_ContactName.Text = MyComboBox_ContactName.Tag
            MyComboBox_ContactName.Focus()
            MyComboBox_ContactName.DropDown = False
            MyComboBox_ContactName_TextChanged(sender, e)

        End If
        MyComboBox_ContactName.Tag = vbNullString

    End Sub

    Private Sub MyComboBox_DevName_Validating(sender As Object, e As CancelEventArgs) Handles MyComboBox_DevName.Validating

        If MyComboBox_DevName.IsNew Then
            ' 调用”DevNameInput"输入新的DevName

            If MsgBox("添加新设备数据吗?"， vbYesNo + vbQuestion, "新增设备名称") = vbYes Then

                '对调用的“DevNameInput"窗体预先赋值。
                DevNameInput.Tb_DevName.Text = MyComboBox_DevName.Text
                DevNameInput.ShowDialog()

            Else
                MyComboBox_DevName.Text = vbNullString
                MyComboBox_DevName.IsNew = False

            End If
            '设定调用"DevNameInput"窗体返回后本项目“DevName”的状态

            MyComboBox_DevName.DataSouce = DevBindingSource
            MyComboBox_DevName.DisplayMember = "DeciceName"
            MyComboBox_DevName.ValueMember = "Id"


            MyComboBox_DevName.Focus()
            MyComboBox_DevName.DropDown = False
            MyComboBox_DevName_TextChanged(sender, e)

        End If

    End Sub

    Private Sub MyComboBox_DeviceBrand_Validating(sender As Object, e As CancelEventArgs) Handles MyComboBox_DeviceBrand.Validating


        If MyComboBox_DeviceBrand.IsNew Then

            If MsgBox("添加新设备品牌数据吗?"， vbYesNo + vbQuestion, "新增设备品牌") = vbYes Then

                '对调用的"BrandInput"窗体预先赋值
                BrandInput.Tb_DevName.Text = MyComboBox_DevName.Text
                BrandInput.Tb_DevName.Tag = MyComboBox_DevName.Value

                BrandInput.Tb_BrandName.Text = MyComboBox_DeviceBrand.Text

                BrandInput.ShowDialog()

            Else
                MyComboBox_DeviceBrand.Text = vbNullString
                MyComboBox_DeviceBrand.IsNew = False

            End If

            MyComboBox_DevName_TextChanged(sender, e)

            MyComboBox_DeviceBrand.Text = MyComboBox_DeviceBrand.Tag
            MyComboBox_DeviceBrand.Focus()
            MyComboBox_DeviceBrand.DropDown = False
            MyComboBox_DeviceBrand_TextChanged(sender, e)

            '刷新“BrandName”项目的“ListdataSouce”

        End If

        MyComboBox_DeviceBrand.Tag = vbNullString
    End Sub

    Private Sub MyComboBox_DevModel_Validating(sender As Object, e As CancelEventArgs) Handles MyComboBox_DevModel.Validating

        If MyComboBox_DevModel.IsNew Then


            If MsgBox("添加新设备型号数据吗?"， vbYesNo + vbQuestion, "新增设备型号") = vbYes Then

                '对调用的"ModelInput"窗体预先赋值
                ModelInput.Tb_DevName.Text = MyComboBox_DevName.Text
                ModelInput.Tb_DevName.Tag = MyComboBox_DevName.Value

                ModelInput.Tb_BrandName.Text = MyComboBox_DeviceBrand.Text
                ModelInput.Tb_BrandName.Tag = MyComboBox_DeviceBrand.Value

                ModelInput.Tb_ModelName.Text = MyComboBox_DevModel.Text

                ModelInput.ShowDialog()

            Else

                MyComboBox_DevModel.Text = vbNullString
                MyComboBox_DevModel.IsNew = False
            End If
            MyComboBox_DeviceBrand_TextChanged(sender, e)

            MyComboBox_DevModel.Text = MyComboBox_DevModel.Tag
            MyComboBox_DevModel.Focus()
            MyComboBox_DevModel.DropDown = False
            MyComboBox_DevModel_TextChanged(sender, e)
            '刷新“ModelName”项目的“ListdataSouce”

        End If

        MyComboBox_DevModel.Tag = vbNullString
    End Sub

    Private Sub MyComboBox_DevMoudleName_Validating(sender As Object, e As CancelEventArgs) Handles MyComboBox_DevMoudleName.Validating

        If MyComboBox_DevMoudleName.IsNew Then


            If MsgBox("添加新设备模块数据吗?"， vbYesNo + vbQuestion, "新增模块名称") = vbYes Then

                '对调用的"MouldleInput"窗体预先赋值
                MoudleInput.Tb_DevName.Text = MyComboBox_DevName.Text
                MoudleInput.Tb_DevName.Tag = MyComboBox_DevName.Value

                MoudleInput.Tb_BrandName.Text = MyComboBox_DeviceBrand.Text
                MoudleInput.Tb_BrandName.Tag = MyComboBox_DeviceBrand.Value

                MoudleInput.Tb_ModelName.Text = MyComboBox_DevModel.Text
                MoudleInput.Tb_ModelName.Tag = MyComboBox_DevModel.Value

                MoudleInput.Tb_MoudleName.Text = MyComboBox_DevMoudleName.Text

                MoudleInput.ShowDialog()

            Else

                MyComboBox_DevMoudleName.Text = vbNullString
                MyComboBox_DevMoudleName.IsNew = False
            End If
            Dim tempTEXT As String = TextBox_DevSn.Text
            MyComboBox_DevModel_TextChanged(sender, e)
            TextBox_DevSn.Text = tempTEXT
            MyComboBox_DevMoudleName.Text = MyComboBox_DevMoudleName.Tag
            MyComboBox_DevMoudleName.Focus()
            MyComboBox_DevMoudleName.DropDown = False
            MyComboBox_DevMoudleName_TextChanged(sender, e)
            '刷新“Moudle”项目的“ListdataSouce”


        End If
        MyComboBox_DevMoudleName.Tag = vbNullString
    End Sub


    Public Sub DataSave()

        Dim verValue As String
        If MyComboBox_DevMoudleName.Text = vbNullString Then
            verValue = "0012"

        Else
            verValue = MyComboBox_DevMoudleName.Value

        End If



        Try
            cnObj = RepairorderTableAdapter.Connection
            cnObj.open()

            '   `InsertRepairOrder`(IN vDtate DATE,in vCustomerId char(4),in vContactsId char(4),
            ' in vDeviceNameId char(4),in vDeviceBrandId char(4),in vDeviceModelId char(4),in vMoudleNameId char(4),
            '  in vDeviceSn char(30),in vDeviceMoudleSn char(30),in vDeviceAccessory char(100),
            '  in vFaultDescription char(200),in vProcessDescription char(200),in vCommunicationDetails char(200),
            '  in vState char(1),OUT vMsg CHAR(20),OUT vId CHAR(4) )

            cm = New MySqlCommand("InsertRepairOrder", cnObj)
            cm.CommandType = CommandType.StoredProcedure
            cm.Parameters.Add("vDate", MySqlDbType.Date).Value = DateTimePicker1.Value
            cm.Parameters.Add("vCustomerId", MySqlDbType.VarChar, 4).Value = MyComboBox_CusName.Value
            cm.Parameters.Add("vContactsId", MySqlDbType.VarChar, 4).Value = MyComboBox_ContactName.Value
            cm.Parameters.Add("vDeviceNameId", MySqlDbType.VarChar, 4).Value = MyComboBox_DevName.Value
            cm.Parameters.Add("vDeviceBrandId", MySqlDbType.VarChar, 4).Value = MyComboBox_DeviceBrand.Value
            cm.Parameters.Add("vDeviceModelId", MySqlDbType.VarChar, 4).Value = MyComboBox_DevModel.Value
            cm.Parameters.Add("vDeviceSn", MySqlDbType.VarChar, 30).Value = TextBox_DevSn.Text
            cm.Parameters.Add("vMoudleNameId", MySqlDbType.VarChar, 4).Value = verValue
            cm.Parameters.Add("vDeviceMoudleSn", MySqlDbType.VarChar, 30).Value = TextBox_MoudleSn.Text
            cm.Parameters.Add("vDeviceAccessory", MySqlDbType.VarChar, 100).Value = TextBox_DevAccessory.Text
            cm.Parameters.Add("vFaultDescription", MySqlDbType.VarChar, 200).Value = TextBox_FaultDescription.Text
            cm.Parameters.Add("vProcessDescription", MySqlDbType.VarChar, 200).Value = ""
            cm.Parameters.Add("vCommunicationDetails", MySqlDbType.VarChar, 200).Value = ""
            cm.Parameters.Add("vState", MySqlDbType.VarChar, 1).Value = ""
            cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.Output
            cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
            cm.ExecuteNonQuery()
            MsgBox(cm.Parameters("vMsg").Value)
            Tb_RepairsOrSn.Text = cm.Parameters("vId").Value
            RepairorderTableAdapter.Fill(YwtDataSet.repairorder)
        Catch ex As Exception

            MsgBox(ex.ToString)


        End Try
        cnObj.close()
    End Sub

    Private Sub Add_Botton_Click(sender As Object, e As EventArgs) Handles Add_Botton.Click
        '初始化控件

        Tb_RepairsOrSn.Text = ""
        MyComboBox_DevName.clear()
        MyComboBox_DeviceBrand.clear()
        MyComboBox_DevModel.clear()
        TextBox_DevSn.Text = ""
        MyComboBox_DevMoudleName.clear()
        TextBox_MoudleSn.Text = ""
        TextBox_MoudleSn.Enabled = False
        TextBox_DevAccessory.Text = ""
        TextBox_FaultDescription.Text = ""
        DateTimePicker1.Focus()

    End Sub
    Private Function DataCheck()
        Dim isDataOk As Boolean
        If MyComboBox_CusName.Text = vbNullString Or MyComboBox_ContactName.Text = vbNullString _
          Or MyComboBox_DevName.Text = vbNullString Or MyComboBox_DeviceBrand.Text = vbNullString _
          Or MyComboBox_DevModel.Text = vbNullString Then


            MsgBox("客户，联系人、设备名称、品牌、型号信息为必须项目，请检查！")
            isDataOk = False
        Else
            'If MyComboBox_DevMoudleName.Text = vbNullString Then

            '为防止无模块数据致使Repair视图无数据，特在模块数据表中设置“0012”号为空白字符串
            ' MyComboBox_DevMoudleName.Value = "0012"
            ' MyComboBox_DevMoudleName.SetValue("0012")     \此功能移至SAVE过程。
            ' TextBox_MoudleSn.Text = vbNullString

            ' Else

            'End If



            isDataOk = True
        End If
        Return isDataOk
    End Function

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        If DataCheck() Then

            Call DataSave()

        Else
            If MyComboBox_CusName.Text = vbNullString Then

                MyComboBox_CusName.Focus()
                Exit Sub

            End If
            If MyComboBox_ContactName.Text = vbNullString Then
                MyComboBox_ContactName.Focus()
                Exit Sub
            End If
            If MyComboBox_DevName.Text = vbNullString Then
                MyComboBox_DevName.Focus()
                Exit Sub
            End If
            If MyComboBox_DeviceBrand.Text = vbNullString Then
                MyComboBox_DeviceBrand.Focus()
                Exit Sub
            End If

            If MyComboBox_DevModel.Text = vbNullString Then
                MyComboBox_DevModel.Focus()
                Exit Sub

            End If

        End If


    End Sub


End Class


