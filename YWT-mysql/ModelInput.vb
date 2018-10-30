Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class ModelInput

    Dim cnObj As Object
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub ModelInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicemodel”中。您可以根据需要移动或删除它。
        Me.DevicemodelTableAdapter.Fill(Me.YwtDataSet.devicemodel)

    End Sub
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            cnObj = DevicemodelTableAdapter.Connection
            cnObj.open()

            cm = New MySqlCommand("InsertDevModel", cnObj)
            cm.CommandType = CommandType.StoredProcedure
            '`InsertDevModel`(in vBrandId char(4),in vDeviceId char(4),in vDeviceModel char(30),
            ' out vId char(4),out vMsg char(20))

            cm.Parameters.Add("vDeviceId", MySqlDbType.VarChar, 4).Value = Tb_DevName.Tag.ToString
            cm.Parameters.Add("vBrandId", MySqlDbType.VarChar, 4).Value = Tb_BrandName.Tag.ToString
            cm.Parameters.Add("vDeviceModel", MySqlDbType.VarChar, 30).Value = Tb_ModelName.Text.ToString
            cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.Output
            cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
            cm.ExecuteNonQuery()
            MsgBox(cm.Parameters("vMsg").Value)
            Tb_ModelNo.Text = cm.Parameters("vId").Value
            DevicemodelTableAdapter.Fill(YwtDataSet.devicemodel)
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
        cnObj.close()
        '刷新主调窗口相关项
        RepairOrderInput.DevicemodelTableAdapter.Fill(RepairOrderInput.YwtDataSet.devicemodel)
        ' MsgBox("刷新型号名称数据")
        RepairOrderInput.MyComboBox_DevModel.Tag = Tb_ModelName.Text
        RepairOrderInput.MyComboBox_DevModel.IsNew = False


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




    Private Sub ModelBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ModelBindingSource.CurrentChanged

        ToolStripStatusLabel1.Text = "当前记录：" & ModelBindingSource.Position + 1 & "/" & ModelBindingSource.Count

    End Sub
End Class