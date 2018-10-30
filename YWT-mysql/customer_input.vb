Imports System.ComponentModel
Imports MySql.Data.MySqlClient


Public Class customer_input
    Dim cnObj As Object
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet



    Private Sub customer_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.customer”中。您可以根据需要移动或删除它。
        CustomerTableAdapter.Fill(YwtDataSet.customer)

    End Sub


    Private Sub CustomerBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CustomerBindingSource.CurrentChanged
        ToolStripStatusLabel1.Text = "当前记录：" & CustomerBindingSource.Position + 1 & "/" & CustomerBindingSource.Count

    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            cnObj = CustomerTableAdapter.Connection
            cnObj.open()

            cm = New MySqlCommand("insertcustomer", cnObj)
            cm.CommandType = CommandType.StoredProcedure
            cm.Parameters.Add("vCusName", MySqlDbType.VarChar, 40).Value = TextBoxCustName.Text
            cm.Parameters.Add("vLocation", MySqlDbType.VarChar, 40).Value = TextBoxCustLocation.Text
            TextBoxCustTel.TextMaskFormat = 0
            cm.Parameters.Add("vTel", MySqlDbType.VarChar, 12).Value = TextBoxCustTel.Text
            TextBoxCustFax.TextMaskFormat = 0
            cm.Parameters.Add("vFax", MySqlDbType.VarChar, 12).Value = TextBoxCustFax.Text
            cm.Parameters.Add("vEmail", MySqlDbType.VarChar, 20).Value = TextBoxCustEmail.Text
            cm.Parameters.Add("vLeveal", MySqlDbType.VarChar, 1).Value = TextBoxLevel.Text
            cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.InputOutput
            cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
            cm.ExecuteNonQuery()
            MsgBox(cm.Parameters("vMsg").Value)
            TextBox1.Text = cm.Parameters("vId").Value
            CustomerTableAdapter.Fill(YwtDataSet.customer)
        Catch ex As Exception

            MsgBox(ex.ToString)


        End Try
        cnObj.close()

        RepairOrderInput.CustomerTableAdapter.Fill(RepairOrderInput.YwtDataSet.customer)

        RepairOrderInput.MyComboBox_CusName.Text = TextBoxCustName.Text

        RepairOrderInput.MyComboBox_CusName.IsNew = False




    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        '初始化控件
        For Each ct As Control In GroupBox1.Controls
            If TypeOf ct Is TextBox Then
                CType(ct, TextBox).Clear()
            Else
                If TypeOf ct Is MaskedTextBox Then
                    CType(ct, MaskedTextBox).Clear()
                End If

            End If
        Next
    End Sub

    Private Sub customer_input_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        '初始控件，以备下次调用。
        Call ToolStripButton1_Click(sender, e)
    End Sub

    Private Sub FocusMove(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCustName.KeyPress _
       , TextBoxCustLocation.KeyPress, TextBoxCustEmail.KeyPress, TextBoxLevel.KeyPress, TextBoxCustTel.KeyPress, TextBoxCustFax.KeyPress

        If e.KeyChar = ChrW(13) Then
            '---SelectNextControl is a Function will be introduced next---
            SelectNextControl(sender, True, True, True, False)
        End If
    End Sub

End Class