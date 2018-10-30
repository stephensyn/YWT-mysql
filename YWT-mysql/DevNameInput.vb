
Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class DevNameInput
    Dim cnObj As Object
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub DevNameInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.devicename”中。您可以根据需要移动或删除它。
        Me.DevicenameTableAdapter.Fill(Me.YwtDataSet.devicename)

    End Sub


    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            cnObj = DevicenameTableAdapter.Connection
            cnObj.open()

            cm = New MySqlCommand("InsertDevName", cnObj)
            cm.CommandType = CommandType.StoredProcedure
            ' (in vDeviceName char(30),out vId char(4),out vMsg char(20))

            cm.Parameters.Add("vDeviceName", MySqlDbType.VarChar, 30).Value = Tb_DevName.Text.ToString
            cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.Output
            cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
            cm.ExecuteNonQuery()
            MsgBox(cm.Parameters("vMsg").Value)
            Tb_DevNo.Text = cm.Parameters("vId").Value
            DevicenameTableAdapter.Fill(YwtDataSet.devicename)
        Catch ex As Exception

            MsgBox(ex.ToString)


        End Try
        cnObj.close()
        '  刷新主调窗体的“devicename”设备名称数据")
        RepairOrderInput.DevicenameTableAdapter.Fill(RepairOrderInput.YwtDataSet.devicename)

        RepairOrderInput.MyComboBox_DevName.Text = Tb_DevName.Text

        RepairOrderInput.MyComboBox_DevName.IsNew = False

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

    Private Sub DevNameBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DevNameBindingSource.CurrentChanged
        ToolStripStatusLabel1.Text = "当前记录：" & DevNameBindingSource.Position + 1 & "/" & DevNameBindingSource.Count
    End Sub


End Class