Module ModGrid



    Public Function CalculateGridValueByColumnName(ByVal GridDetail As DataGridView, ByVal ColumnName As String) As Double

        Dim dblQty As Double
        dblQty = 0

        Try

            Dim i As Integer

            For i = 0 To GridDetail.RowCount - 1

                If GridDetail.Rows(i).Cells(ColumnName).ToString <> "" Then

                    If Not IsNumeric(GridDetail.Rows(i).Cells(ColumnName).Value) Then GridDetail.Rows(i).Cells(ColumnName).Value = 0
                    dblQty = dblQty + GridDetail.Rows(i).Cells(ColumnName).Value
                End If

            Next

            Return dblQty

        Catch ex As Exception

            CalculateGridValueByColumnName = 0

        End Try

    End Function


    Public Sub ModifyGridSettingAzure(ByVal Grid As DataGridView)

        Try

            Grid.RowHeadersWidth = 42
            Grid.Columns(0).Frozen = True
            Grid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow
            Grid.AllowUserToAddRows = False
            Grid.AllowUserToDeleteRows = False
            Grid.EditMode = DataGridViewEditMode.EditProgrammatically

            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Grid.MultiSelect = False

        Catch ex As Exception

        End Try

    End Sub


    Public Sub ModifyGridSettingSelfDefine(ByVal Grid As DataGridView, ByVal MyColor As Color)

        Try

            Grid.RowHeadersWidth = 25
            Grid.Columns(0).Frozen = True
            Grid.AlternatingRowsDefaultCellStyle.BackColor = MyColor
            Grid.AllowUserToAddRows = False
            Grid.AllowUserToDeleteRows = False
            Grid.EditMode = DataGridViewEditMode.EditProgrammatically

            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Grid.MultiSelect = False


        Catch ex As Exception

        End Try

    End Sub


    Public Sub ModifyGridDateColumn(ByVal Grid As DataGridView, ByVal ColumnName As String)
        Try

            Dim MyStyle As New DataGridViewCellStyle()
            MyStyle.Format = "yyyy-MM-dd"
            Grid.Columns(ColumnName).DefaultCellStyle = MyStyle

        Catch ex As Exception

        End Try

    End Sub


    Public Sub ModifyGridDateColumnInLong(ByVal Grid As DataGridView, ByVal ColumnName As String)
        Try

            Dim MyStyle As New DataGridViewCellStyle()
            MyStyle.Format = "yyyy-MM-dd HH:mm:ss"
            Grid.Columns(ColumnName).DefaultCellStyle = MyStyle

        Catch ex As Exception

        End Try

    End Sub



End Module
