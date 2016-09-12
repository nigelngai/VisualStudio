Public Class frmDict

    Private pmDict As Dictionary(Of String, String)

    Private Sub frmDict_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        pmDict = New Dictionary(Of String, String)

        pmDict.Add("Chapter 1", "Develop Project")
        pmDict.Add("Chapter 2", "Develop Project Management Plan")
        pmDict.Add("Chapter 3", "Direct and Manage Project Execution")
        pmDict.Add("Chapter 4", "Monitor and Control Project Work")
        pmDict.Add("Chapter 5", "Perform Integrated Change Control")
        pmDict.Add("Chapter 6", "Close Project or Phase")

        'pmDict.Remove("Chapter 6")

        Dim pair As KeyValuePair(Of String, String)
        For Each pair In pmDict

            dgDict.Rows.Add(pair.Key, pair.Value)

        Next

    End Sub


    Private Sub btnSearchValue_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchValue.Click

        lblResult.Text = pmDict.Item(txtInput.Text)

    End Sub


    'Private Sub InstanceRectangleIntersection( _
    'ByVal e As PaintEventArgs)

    '    Dim rectangle1 As New Rectangle(50, 50, 200, 100)
    '    Dim rectangle2 As New Rectangle(70, 20, 100, 200)

    '    e.Graphics.DrawRectangle(Pens.Black, rectangle1)
    '    e.Graphics.DrawRectangle(Pens.Red, rectangle2)

    '    If (rectangle1.IntersectsWith(rectangle2)) Then
    '        rectangle1.Intersect(rectangle2)
    '        If Not (rectangle1.IsEmpty) Then
    '            e.Graphics.FillRectangle(Brushes.Green, rectangle1)
    '        End If
    '    End If
    'End Sub


End Class