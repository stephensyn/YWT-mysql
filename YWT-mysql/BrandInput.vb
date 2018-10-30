Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class BrandInput
    Dim cnObj As Object
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub DevbrandInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicebrand”中。您可以根据需要移动或删除它。
        Me.DevicebrandTableAdapter.Fill(Me.YwtDataSet.devicebrand)

    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            cnObj = DevicebrandTableAdapter.Connection
            cnObj.open()

            cm = New MySqlCommand("InsertDevbrand", cnObj)
            cm.CommandType = CommandType.StoredProcedure
            '`InsertDevbrand`(in vDeviceNameId char(4), in vBrandName char(30),
            ' out vId char(4),out vMsg char(20))

            cm.Parameters.Add("vDeviceNameId", MySqlDbType.VarChar, 4).Value = Tb_DevName.Tag.ToString
            cm.Parameters.Add("vBrandName", MySqlDbType.VarChar, 30).Value = Tb_BrandName.Text.ToString
            cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.Output
            cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
            cm.ExecuteNonQuery()
            MsgBox(cm.Parameters("vMsg").Value)
            Tb_BbrandNo.Text = cm.Parameters("vId").Value
            DevicebrandTableAdapter.Fill(YwtDataSet.devicebrand)
        Catch ex As Exception

            MsgBox(ex.ToString)


        End Try
        cnObj.close()
        '刷新主调窗口相关项
        RepairOrderInput.DevicebrandTableAdapter.Fill(RepairOrderInput.YwtDataSet.devicebrand)
        ' MsgBox("刷新设备名称数据")
        RepairOrderInput.MyComboBox_DeviceBrand.Tag = Tb_BrandName.Text
        RepairOrderInput.MyComboBox_DeviceBrand.IsNew = False

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        '初始化控件
        For Each ct As Control In Me.Controls
            If TypeOf ct Is TextBox Then
                CType(ct, TextBox).Clear()
            End If
        Next
    End Sub

    Private Sub customer_input_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        '初始控件，以备下次调用。
        Call ToolStripButton1_Click(sender, e)
    End Sub

    Private Sub BrandBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles BrandBindingSource.CurrentChanged
        ToolStripStatusLabel1.Text = "当前记录：" & BrandBindingSource.Position + 1 & "/" & BrandBindingSource.Count
    End Sub
End Class