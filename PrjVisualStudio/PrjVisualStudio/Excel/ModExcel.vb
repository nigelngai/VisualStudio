Module ModExcel



    Public Sub ExportGridToExcel(ByVal grdView As DataGridView, Optional ByVal SaveFormat As Boolean = False)

        Try

            If ((grdView.Columns.Count = 0) Or (grdView.Rows.Count = 0)) Then
                Exit Sub
            End If

            'If MessageBox.Show("Are you sure you want to export the entire grid to Excel", "Choose Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

            'Creating dataset to export
            Dim dset As New DataSet
            'add table to dataset
            dset.Tables.Add()
            'add column to that table
            For i As Integer = 0 To grdView.ColumnCount - 1
                dset.Tables(0).Columns.Add(grdView.Columns(i).HeaderText)
            Next
            'add rows to the table
            Dim dr1 As DataRow
            Dim TotalGridRow As Long = (grdView.RowCount - 1) * 2

            For i As Integer = 0 To grdView.RowCount - 1
                dr1 = dset.Tables(0).NewRow

                If SaveFormat = False Then
                End If

                For j As Integer = 0 To grdView.Columns.Count - 1
                    dr1(j) = "'" & grdView.Rows(i).Cells(j).Value
                    'dr1(j) = grdView.Rows(i).Cells(j).Value
                Next

                dset.Tables(0).Rows.Add(dr1)
            Next


            Dim Excel As New Excel.Application
            'Dim excel As New Excel.ApplicationClass

            Dim wBook As Excel.Workbook
            Dim wSheet As Excel.Worksheet

            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(1, colIndex) = dc.ColumnName
                Application.DoEvents()
            Next

            If SaveFormat = False Then
                For Each dr In dt.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0


                    For Each dc In dt.Columns
                        colIndex = colIndex + 1

                        'Add   '   for string column item

                        excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                        Application.DoEvents()
                    Next
                Next
            End If


Finishup:

            Application.DoEvents()
            wSheet.Columns.AutoFit()

            If SaveFormat = True Then
                Dim strFileName As String = SaveExcelFile()
                If strFileName = "" Then Exit Sub

                Dim blnFileOpen As Boolean = False
                Try
                    Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                    fileTemp.Close()
                Catch ex As Exception
                    blnFileOpen = False
                End Try

                If System.IO.File.Exists(strFileName) Then
                    System.IO.File.Delete(strFileName)
                End If

                wBook.SaveAs(strFileName)
                excel.Workbooks.Open(strFileName)
            End If

            excel.Visible = True
            excel.DisplayAlerts = True


        Catch ex As Exception
            MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function SaveExcelFile(Optional ByVal filter As String = ".xls|*.xls|.xlsx|*.xlsx", Optional ByVal DefaultFileName As String = "") As String

        Dim fshow As New SaveFileDialog
        fshow.FileName = DefaultFileName
        fshow.Filter = filter

        fshow.ShowDialog()

        Return fshow.FileName

    End Function


End Module
