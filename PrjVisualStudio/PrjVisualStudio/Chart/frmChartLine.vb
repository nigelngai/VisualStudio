Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmChartLine

    Private Sub frmChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim s1 As New Series
        s1.Name = "Apple"

        'Line graph.

        s1.ChartType = SeriesChartType.Line
        s1.Points.AddXY("2012", 50)
        s1.Points.AddXY("2013", 70)
        s1.Points.AddXY("2014", 20)
        s1.Points.AddXY("2015", 30)
        'Add series.
        Chart1.Series.Add(s1)

        Dim s2 As New Series
        s2.Name = "Orange"

        'Line graph.

        s2.ChartType = SeriesChartType.Line
        s2.Points.AddXY("2012", 50)
        s2.Points.AddXY("2013", 60)
        s2.Points.AddXY("2014", 70)
        s2.Points.AddXY("2015", 55)

        'Add series.
        Chart1.Series.Add(s2)
    End Sub
End Class