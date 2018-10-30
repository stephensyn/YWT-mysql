
Imports System.ComponentModel
Imports MySql.Data.MySqlClient


Public Class MoudleInput

    Dim cnObj As Object
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub MoudleInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.moudlename”中。您可以根据需要移动或删除它。
        Me.MoudlenameTableAdapter.Fill(Me.YwtDataSet.moudlename)

    End Sub
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            cnObj = MoudlenameTableAdapter.Connection
            cnObj.open()

            cm = New MySqlCommand("InsertMoudleName", cnObj)
            cm.CommandType = CommandType.StoredProcedure
            ' `InsertMoudleName`(in vBrandId char(4),in vDeviceId char(4),in vModelId char(4),
            'in vMoudleName char(30),out vId char(4),out vMsg char(20) )

            cm.Parameters.Add("vDeviceId", MySqlDbType.VarChar, 4).Value = Tb_DevName.Tag.ToString
            cm.Parameters.Add("vBrandId", MySqlDbType.VarChar, 4).Value = Tb_BrandName.Tag.ToString
            cm.Parameters.Add("vModelId", MySqlDbType.VarChar, 4).Value = Tb_ModelName.Tag.ToString
            cm.Parameters.Add("vMoudleName", MySqlDbType.VarChar, 30).Value = Tb_MoudleName.Text.ToString
            cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.Output
            cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
            cm.ExecuteNonQuery()
            MsgBox(cm.Parameters("vMsg").Value)
            Tb_MoudleNo.Text = cm.Parameters("vId").Value
            MoudlenameTableAdapter.Fill(YwtDataSet.moudlename)
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
        cnObj.close()
        '刷新主调窗口相关项
        RepairOrderInput.MoudlenameTableAdapter.Fill(RepairOrderInput.YwtDataSet.moudlename)
        ' MsgBox("刷新型号名称数据")
        RepairOrderInput.MyComboBox_DevMoudleName.Tag = Tb_MoudleName.Text
        RepairOrderInput.MyComboBox_DevMoudleName.IsNew = False

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



    Private Sub DevMoudleBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DevMoudleBindingSource.CurrentChanged

        ToolStripStatusLabel1.Text = "当前记录：" & DevMoudleBindingSource.Position + 1 & "/" & DevMoudleBindingSource.Count

    End Sub
End Class