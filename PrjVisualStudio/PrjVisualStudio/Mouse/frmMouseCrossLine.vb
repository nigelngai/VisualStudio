Public Class frmMouseCrossLine



    Private Sub frmMouseCrossLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub


    Private Sub frmMouseCrossLine_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        LineY.Location = New Point(e.X, 0)
        LineX.Location = New Point(0, e.Y)

    End Sub









End Class