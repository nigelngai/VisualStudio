Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmChartBar

    Private Sub frmChartBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim s1 As New Series
        s1.Name = "Apple"

        s1.ChartType = SeriesChartType.Bar

        s1.Points.AddXY("2012", 50)
        s1.Points.AddXY("2013", 70)
        s1.Points.AddXY("2014", 20)
        s1.Points.AddXY("2015", 30)
        'Add series.
        Chart1.Series.Add(s1)
        Chart1.Series("Apple").Color = System.Drawing.Color.Red

        Dim s2 As New Series
        s2.Name = "Orange"

        s2.ChartType = SeriesChartType.Bar
        s2.Points.AddXY("2012", 20)
        s2.Points.AddXY("2013", 90)
        s2.Points.AddXY("2014", 60)
        s2.Points.AddXY("2015", 40)
        'Add series.
        Chart1.Series.Add(s2)
        Chart1.Series("Orange").Color = System.Drawing.Color.Orange

    End Sub

End Class