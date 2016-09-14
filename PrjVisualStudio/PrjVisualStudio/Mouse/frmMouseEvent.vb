
Public Class frmMouseEvent

    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long)

    Public Const M_LEFTDOWN As Long = &H2
    Public Const M_LEFTUP As Long = &H4
    Public Const M_MIDDLEDOWN As Long = &H20
    Public Const M_MIDDLEUP As Long = &H40
    Public Const M_RIGHTDOWN As Long = &H8
    Public Const M_RIGHTUP As Long = &H10

    Private Sub ButtonDraw_Click(sender As Object, e As EventArgs) Handles ButtonDraw.Click

        Me.Cursor = New Cursor(Cursor.Current.Handle)

        '-----

        Cursor.Position = New Point(200, 200)
        Threading.Thread.Sleep(2000)
        'mouse_event(&H2)
        mouse_event(M_LEFTDOWN)

        Threading.Thread.Sleep(2000)
        Cursor.Position = New Point(300, 300)
        Threading.Thread.Sleep(2000)
        'mouse_event(&H4)
        mouse_event(M_LEFTUP)

        '------
        Threading.Thread.Sleep(2000)
        Cursor.Position = New Point(350, 300)
        Threading.Thread.Sleep(2000)
        'mouse_event(&H8)
        mouse_event(M_RIGHTDOWN)

        Threading.Thread.Sleep(2000)
        Cursor.Position = New Point(400, 400)
        Threading.Thread.Sleep(2000)
        'mouse_event(&H10)
        mouse_event(M_RIGHTUP)

    End Sub


End Class