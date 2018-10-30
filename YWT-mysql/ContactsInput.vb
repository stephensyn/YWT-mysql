Imports System.ComponentModel
Imports MySql.Data.MySqlClient


Public Class ContactsInput
    Dim cnObj As Object
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub ContactsInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: 这行代码将数据加载到表“YwtDataSet.contacts”中。您可以根据需要移动或删除它。
        Me.ContactsTableAdapter.Fill(Me.YwtDataSet.contacts)
    End Sub




    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            cnObj = ContactsTableAdapter.Connection
            cnObj.open()

            cm = New MySqlCommand("InsertContacts", cnObj)
            cm.CommandType = CommandType.StoredProcedure
            ' in vCustomerId char(4),in vContactsName char(4),
            ' in vDepartmentId char(2), in vLocation char(40),in vTel char(12),in vTel2 char(12),
            ' in vEmail char(20),in vWebchat char(20),out vId char(4) ,out vMsg char(20))

            cm.Parameters.Add("vCustomerId", MySqlDbType.VarChar, 4).Value = Tb_Con_Cus.Tag
            cm.Parameters.Add("vContactsName", MySqlDbType.VarChar, 4).Value = Tb_ContactstName.Text
            cm.Parameters.Add("vDepartmentId", MySqlDbType.VarChar, 2).Value = ""
            cm.Parameters.Add("vLocation", MySqlDbType.VarChar, 40).Value = Tb_ContactsLocation.Text
            Tb_ContactsTel.TextMaskFormat = 0
            cm.Parameters.Add("vTel", MySqlDbType.VarChar, 12).Value = Tb_ContactsTel.Text
            Tb_ContactsTel2.TextMaskFormat = 0
            cm.Parameters.Add("vTel2", MySqlDbType.VarChar, 12).Value = Tb_ContactsTel2.Text
            cm.Parameters.Add("vEmail", MySqlDbType.VarChar, 20).Value = Tb_ContactsEmail.Text
            cm.Parameters.Add("vWebchat", MySqlDbType.VarChar, 20).Value = ""
            cm.Parameters.Add("vId", MySqlDbType.VarChar, 4).Direction = ParameterDirection.Output
            cm.Parameters.Add("vMsg", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output
            cm.ExecuteNonQuery()
            MsgBox(cm.Parameters("vMsg").Value)
            Tb_No.Text = cm.Parameters("vId").Value
            ContactsTableAdapter.Fill(YwtDataSet.contacts)
        Catch ex As Exception

            MsgBox(ex.ToString)


        End Try
        cnObj.close()
        ' RepairOrderInput.ContactsTableAdapter.Fill(YwtDataSet.contacts)

        RepairOrderInput.ContactsTableAdapter.Fill(RepairOrderInput.YwtDataSet.contacts)
        RepairOrderInput.MyComboBox_ContactName.Tag = Tb_ContactstName.Text

        RepairOrderInput.MyComboBox_ContactName.IsNew = False
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
    Private Sub FocusMove(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_ContactstName.KeyPress _
        , Tb_ContactsLocation.KeyPress, Tb_ContactsEmail.KeyPress, Tb_ContactsTel.KeyPress, Tb_ContactsTel2.KeyPress
        If e.KeyChar = ChrW(13) Then
            '---SelectNextControl is a Function will be introduced next---
            SelectNextControl(sender, True, True, True, False)
        End If
    End Sub

    Private Sub ContactsBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ContactsBindingSource.CurrentChanged
        ToolStripStatusLabel1.Text = "当前记录：" & ContactsBindingSource.Position + 1 & "/" & ContactsBindingSource.Count
    End Sub
End Class