Module ModDate


    Public Function GetMyDateFormat(ByRef myPicker As DateTimePicker) As String

        Dim strYear As String = ""
        Dim strMonth As String = ""
        Dim strDate As String = ""

        strYear = Format(myPicker.Value, "yyyy")
        strMonth = GetMonthNamebyNumber(Format(myPicker.Value, "MM"))
        strDate = Format(myPicker.Value, "dd")

        GetMyDateFormat = strYear & " " & strMonth & " " & strDate

    End Function

    Public Function GetMonthNamebyNumber(ByRef strMonth As String) As String

        GetMonthNamebyNumber = ""

        If Strings.Len(strMonth) = 1 Then strMonth = "0" & strMonth

        Select Case strMonth

            Case "01"
                GetMonthNamebyNumber = "Jan"
            Case "02"
                GetMonthNamebyNumber = "Feb"
            Case "03"
                GetMonthNamebyNumber = "Mar"
            Case "04"
                GetMonthNamebyNumber = "Apr"
            Case "05"
                GetMonthNamebyNumber = "May"
            Case "06"
                GetMonthNamebyNumber = "Jun"
            Case "07"
                GetMonthNamebyNumber = "Jul"
            Case "08"
                GetMonthNamebyNumber = "Aug"
            Case "09"
                GetMonthNamebyNumber = "Sep"
            Case "10"
                GetMonthNamebyNumber = "Oct"
            Case "11"
                GetMonthNamebyNumber = "Nov"
            Case "12"
                GetMonthNamebyNumber = "Dec"

        End Select

        Debug.Print(GetMonthNamebyNumber)

    End Function


    Public Function getThisMonthStart(ByVal pDate As Date) As Date

        Dim rDate As Date
        rDate = New Date(pDate.Year, pDate.Month, 1)
        '--->
        Return rDate

    End Function

    Public Function getThisMonthEnd(ByVal pDate As Date) As Date

        Dim rDate As Date
        rDate = New Date(pDate.Year, pDate.Month, 1)
        rDate = rDate.AddMonths(1)
        rDate = rDate.AddDays(-1)
        '--->
        Return rDate

    End Function

    Public Function getLastMonthStart(ByVal pDate As Date) As Date

        Dim rDate As Date
        rDate = New Date(pDate.Year, pDate.Month, 1)
        rDate = rDate.AddMonths(-1)
        '--->
        Return rDate

    End Function

    Public Function getLastMonthEnd(ByVal pDate As Date) As Date

        Dim rDate As Date
        rDate = New Date(pDate.Year, pDate.Month, 1)
        rDate = rDate.AddDays(-1)
        '--->
        Return rDate

    End Function


    'Private Sub ButtonGet_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGet.Click

    '    Dim SourceDate As Date = ("2016-05-15")

    '    Dim TargetDate As Date
    '    TargetDate = getLastMonthEnd(SourceDate)
    '    Debug.Print(Format(TargetDate, "yyyy-MM-dd"))

    'End Sub



End Module
