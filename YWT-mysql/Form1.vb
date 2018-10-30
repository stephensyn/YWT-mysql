Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.MdiChildActivate
        'Me.MdiParent = MDIParent1


        'TODO: 这行代码将数据加载到表“YwtDataSet.customer”中。您可以根据需要移动或删除它。
        CustomerTableAdapter.Fill(YwtDataSet.customer)

        'TODO: 这行代码将数据加载到表“YwtDataSet.customer”中。您可以根据需要移动或删除它。




    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DbAdd_Click(sender As Object, e As EventArgs) Handles DbAdd.Click
        CustomerBindingSource.AddNew()
        'Me.DataGridView1.CurrentRow = DataGridView1.Rows.
    End Sub

    Private Sub DbSave_Click(sender As Object, e As EventArgs) Handles DbSave.Click
        CustomerTableAdapter.Update(YwtDataSet.GetChanges)

        YwtDataSet.AcceptChanges()
    End Sub

    Private Sub DbFirst_Click(sender As Object, e As EventArgs) Handles DbFirst.Click
        CustomerBindingSource.MoveFirst()
    End Sub

    Private Sub DbPrev_Click(sender As Object, e As EventArgs) Handles DbPrev.Click
        CustomerBindingSource.MovePrevious()
    End Sub

    Private Sub DbNext_Click(sender As Object, e As EventArgs) Handles DbNext.Click
        CustomerBindingSource.MoveNext()
    End Sub

    Private Sub Dblast_Click(sender As Object, e As EventArgs) Handles Dblast.Click
        CustomerBindingSource.MoveLast()
    End Sub

    Private Sub DbEdit_Click(sender As Object, e As EventArgs) Handles DbEdit.Click

    End Sub

    Private Sub DbRefresh_Click(sender As Object, e As EventArgs) Handles DbRefresh.Click
        YwtDataSet.Clear()
        CustomerTableAdapter.Fill(YwtDataSet.customer)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles DbDelet.Click
        CustomerBindingSource.RemoveCurrent()
    End Sub


    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Close()
    End Sub

    Private Sub TextBoxCustName_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCustName.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        Else
            If e.KeyCode = Keys.PageUp Then
                SelectNextControl(DirectCast(sender, Control), False, True, True, True)
            Else
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            TextBoxCustName.Undo()
        End If
    End Sub

    Private Sub TextBoxCustAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCustAdd.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        Else
            If e.KeyCode = Keys.Up Then
                SelectNextControl(DirectCast(sender, Control), False, True, True, True)
            Else
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            TextBoxCustAdd.Undo()
        End If
    End Sub

    Private Sub TxtBoxCustTel_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCustTel.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        Else
            If e.KeyCode = Keys.Up Then
                SelectNextControl(DirectCast(sender, Control), False, True, True, True)
            Else
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            TextBoxCustTel.Undo()
        End If
    End Sub

    Private Sub TextBoxCustFax_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCustFax.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        Else
            If e.KeyCode = Keys.Up Then
                SelectNextControl(DirectCast(sender, Control), False, True, True, True)
            Else
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            TextBoxCustFax.Undo()
        End If
    End Sub

    Private Sub TextBoxCustEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCustEmail.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        Else
            If e.KeyCode = Keys.Up Then
                SelectNextControl(DirectCast(sender, Control), False, True, True, True)
            Else
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            TextBoxCustEmail.Undo()
        End If
    End Sub

    Private Sub TextBoxCustName_Enter(sender As Object, e As EventArgs) Handles TextBoxCustName.Enter
        TextBoxCustName.SelectionStart = TextBoxCustName.Text.Length   '文本的选取长度
        TextBoxCustName.ScrollToCaret() '将光标移动文本后
    End Sub

    Private Sub TextBoxCustAdd_Enter(sender As Object, e As EventArgs) Handles TextBoxCustAdd.Enter
        TextBoxCustAdd.SelectionStart = TextBoxCustAdd.Text.Length   '文本的选取长度
        TextBoxCustAdd.ScrollToCaret() '将光标移动文本后
    End Sub

    Private Sub TextBoxCustTel_Enter(sender As Object, e As EventArgs) Handles TextBoxCustTel.Enter
        TextBoxCustTel.SelectionStart = TextBoxCustTel.Text.Length   '文本的选取长度
        TextBoxCustTel.ScrollToCaret() '将光标移动文本后
    End Sub

    Private Sub TextBoxCustFax_Enter(sender As Object, e As EventArgs) Handles TextBoxCustFax.Enter
        TextBoxCustFax.SelectionStart = TextBoxCustFax.Text.Length   '文本的选取长度
        TextBoxCustFax.ScrollToCaret() '将光标移动文本后
    End Sub

    Private Sub TextBoxCustEmail_Enter(sender As Object, e As EventArgs) Handles TextBoxCustEmail.Enter
        TextBoxCustEmail.SelectionStart = 0 ' Me.TextBoxCustEmail.Text.Length   '文本的选取长度
        TextBoxCustEmail.ScrollToCaret() '将光标移动文本后
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CustomerBindingSource.CancelEdit()

    End Sub

    Private Sub TextBoxCustName_GotFocus(sender As Object, e As EventArgs) Handles TextBoxCustName.GotFocus
        TextBoxCustName.SelectionStart = 0
        TextBoxCustName.SelectionLength = Len(TextBoxCustName.Text)
    End Sub

    Private Sub TextBoxCustName_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCustName.LostFocus
        TextBoxCustName.Text = Replace(TextBoxCustName.Text, " ", "")
    End Sub

    Private Sub TextBoxCustName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCustName.TextChanged

    End Sub

    Private Sub CustomerBindingSource_DataError(sender As Object, e As BindingManagerDataErrorEventArgs) Handles CustomerBindingSource.DataError

    End Sub

    Private Sub CustomerBindingSource_Disposed(sender As Object, e As EventArgs) Handles CustomerBindingSource.Disposed

    End Sub

    Private Sub TextBoxCustTel_Paint(sender As Object, e As PaintEventArgs) Handles TextBoxCustTel.Paint

    End Sub
End Class