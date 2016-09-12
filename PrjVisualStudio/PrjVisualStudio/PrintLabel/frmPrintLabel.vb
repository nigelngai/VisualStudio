Public Class frmPrintLabel

#Region "Declaration"

    Dim PRINTER_NAME = "PrinterName"

    Private SCREEN_TO_OUTPUT_RATIO = 1

#End Region

#Region "Screen"

    Private Sub frmPrintLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            prnOutputDoc.PrinterSettings.PrinterName = PRINTER_NAME
        Catch
            MsgBox("Cannot find [" & PRINTER_NAME & "]", MsgBoxStyle.Critical, Me.Text)
            Me.Close()
        End Try

    End Sub

    Private Sub InputText_TextChanged(sender As System.Object, e As System.EventArgs) Handles InputText.TextChanged
        txtBARCODEValue.Text = InputText.Text
    End Sub

#End Region

#Region "Barcode"


    Dim BarCode_C39_Char As Char()


    Private Sub initC39()

        ReDim BarCode_C39_Char(43)
        Dim i As Int16

        For i = 0 To 9

            BarCode_C39_Char(i) = Chr(i + 48)

        Next i
        For i = 10 To 35

            BarCode_C39_Char(i) = Chr(i + 55)

        Next i
        BarCode_C39_Char(36) = "-"
        BarCode_C39_Char(37) = "."
        BarCode_C39_Char(38) = "è"
        BarCode_C39_Char(39) = "$"
        BarCode_C39_Char(40) = "/"
        BarCode_C39_Char(41) = "+"
        BarCode_C39_Char(42) = "%"

    End Sub

    Private Function C39(ByVal str As String) As String

        'CODE 39 BARCODE CHECK DIGIT IMPLEMENTATION
        If BarCode_C39_Char Is Nothing Then
            initC39()
        End If

        Dim i, intSum, intCheck As Int16
        For i = 0 To str.Length - 1
            intSum += Array.LastIndexOf(BarCode_C39_Char, str.Chars(i))
        Next i
        intCheck = intSum Mod 43

        C39 = "*" & str & BarCode_C39_Char(intCheck).ToString & "*"

    End Function


#End Region

#Region "Print"

    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click

        Try

            Me.txtBARCODE.Text = C39(Trim(txtBARCODEValue.Text))

            prnOutputDoc.PrinterSettings.Copies = 1
            prnOutputDoc.DocumentName = "Label"
            Me.prnOutputDoc.Print()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "DrawPicture"



    Sub DrawTexttoPicture(ByRef g As System.Drawing.Graphics, ByVal txt As TextBox, _
                          Optional ByVal Width_available As Single = -1, _
                          Optional ByVal px As Single = -1, _
                          Optional ByVal py As Single = -1, _
                          Optional ByVal Height_available As Single = Nothing, _
                          Optional ByVal objOffsetControl As Object = Nothing)

        Dim intText_ActualWidth As Int16
        Dim intText_ActualHeight As Int16
        Dim myMatrix As New System.Drawing.Drawing2D.Matrix
        Dim dblRatio_w As Double
        Dim dblRatio_h As Double
        Dim OriginalTransform As System.Drawing.Drawing2D.Matrix

        Dim x, y As Single

        If px = -1 Then
            x += txt.Left
        Else
            x = txt.Left + px
        End If

        If py = -1 Then
            y += txt.Top
        Else
            y = txt.Top + py
        End If

        y += 8

        If Not (objOffsetControl Is Nothing) Then
            x -= objOffsetControl.left
            y -= objOffsetControl.top
        End If


        x *= Me.SCREEN_TO_OUTPUT_RATIO
        y *= Me.SCREEN_TO_OUTPUT_RATIO

        '    SCALE = 1
        OriginalTransform = g.Transform


        dblRatio_w = 1
        dblRatio_h = 1

        Dim fmtDEFAULT As New StringFormat


        intText_ActualWidth = g.MeasureString(txt.Text, txt.Font, New PointF(0, 0), fmtDEFAULT).Width
        intText_ActualHeight = g.MeasureString(txt.Text, txt.Font, New PointF(0, 0), fmtDEFAULT).Height


        If Width_available < intText_ActualWidth Then
            dblRatio_w = Width_available / intText_ActualWidth
        End If
        If Height_available <> Nothing Then
            dblRatio_h = Height_available / intText_ActualHeight
        End If

        Width_available *= Me.SCREEN_TO_OUTPUT_RATIO
        Height_available *= Me.SCREEN_TO_OUTPUT_RATIO

        Width_available = intText_ActualWidth
        dblRatio_w = SCREEN_TO_OUTPUT_RATIO

        Height_available = intText_ActualHeight
        dblRatio_h = SCREEN_TO_OUTPUT_RATIO



        myMatrix.Scale(dblRatio_w, dblRatio_h, System.Drawing.Drawing2D.MatrixOrder.Append)

        g.Transform = myMatrix

        g.DrawString(txt.Text, txt.Font, New SolidBrush(txt.ForeColor), x / dblRatio_w, y / dblRatio_h, fmtDEFAULT)

        g.Transform = OriginalTransform


    End Sub

    Private Sub prnOutputDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prnOutputDoc.PrintPage

        DrawTexttoPicture(e.Graphics, Me.txtBARCODEValue, , , , , picOutputDoc)
        DrawTexttoPicture(e.Graphics, Me.txtBARCODE, , , , , picOutputDoc)

    End Sub

#End Region

End Class