Module YwtModule

    ' GetNewtable（）
    ' 组合框联查时使用。
    ' 当前一个组合框选定后，立即调用生成第二个组合框的列表数据表
    ' 示例：
    '  MyComboBox2.ListDataSouce = YwtModule.GetNewtable(YwtDataSet.contacts, "customerid = " & MyComboBox1.ComboValue)
    '    MyComboBox2.FilterColumn = " Pyindex  "
    '    MyComboBox2.ListValueMember = "id"
    '    MyComboBox2.ComboBox = vbNullChar
    '    MyComboBox2.TextClear()

    Public Function GetNewtable(DtSouce As DataTable, FilterString As String) As DataTable
        Dim newDt As New DataTable
        newDt = DtSouce.Clone()
        Dim newDataRow As DataRow() = DtSouce.Select(FilterString)
        If newDataRow.Count = 0 Then
            MsgBox("请注意！下一数据项为空")
            newDt = Nothing
        Else
            Dim I As Integer = 0
            For I = 0 To (newDataRow.LongCount - 1)
                newDt.ImportRow(newDataRow(I))

            Next I
            newDt = newDataRow.CopyToDataTable

            'newDt = .CopyToDataTable



        End If
        Return newDt
    End Function
    Public Function strFind(dtSouce As DataTable, strSort As String, vStr As String) As Boolean
        '判断给定的vStr字符串在指定的数据表中的指定字段中有无该记录。
        '返回值为Bool变量，Ture表示数据表中无此记录；False表示由此记录

        Dim Isnew As Boolean = False
        Dim dv As DataView = dtSouce.AsDataView
        dv.Sort = strSort
        Dim vNo As Integer = dv.Find(vStr)
        If vNo = -1 Then
            Isnew = True
        Else
            Isnew = False
        End If
        Return Isnew
    End Function
    Public Function Dgv2Dsc(ByVal Dgv As DataGridView, ByVal DgvSortKey As String, ByVal Dt As DataTable, ByVal DtSortKey As String)
        Dim retunDs As New BindingSource()
        Dim tempDt As New DataTable()
        tempDt = Dt.Clone


        Dim verCusName As String = vbNullString

        Dim tempDS As New BindingSource()
        tempDS = Dgv.DataSource

        Dim drv As DataRowView = CType(tempDS.Current, DataRowView)

        If drv IsNot Nothing Then
            tempDt.Clear()
            drv.DataView.Sort = DgvSortKey
            For i As Integer = 0 To drv.DataView.Count - 1

                If verCusName <> drv.DataView.Item(i).Item(DgvSortKey) Then

                    verCusName = drv.DataView.Item(i).Item(DgvSortKey)

                    Dt.DefaultView.Sort = DtSortKey

                    Dim dr As DataRow() = Dt.Select("" & DtSortKey & " ='" & verCusName & "'")
                    tempDt.ImportRow(dr(0))

                Else


                End If


            Next
            retunDs.DataSource = tempDt
        Else
            retunDs = Nothing
        End If
        Return retunDs
    End Function

End Module
