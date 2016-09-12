Public Class FrmMouse

    Private mouseX As Integer
    Private mouseY As Integer

    Private ControlName As String

    Private Sub FrmMouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EnableControlToMovable()

    End Sub

    Private Sub EnableControlToMovable()

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                Debug.Print(ctrl.Name)
                If ctrl.Name.StartsWith("LabelCtrl") Then AddressControlToMovableEvent(ctrl)
            End If
        Next

    End Sub

    Private Sub AddressControlToMovableEvent(ByVal parControl As Control)

        Dim myLblControl As Label
        myLblControl = parControl

        AddHandler myLblControl.MouseUp, AddressOf Me.LabelCtrl_MouseUp
        AddHandler myLblControl.MouseDown, AddressOf Me.LabelCtrl_MouseDown
        AddHandler myLblControl.MouseMove, AddressOf Me.LabelCtrl_MouseMove

    End Sub

    Private myMousePressDown As Boolean = False

    Private Sub LabelCtrl_MouseDown(sender As Object, e As MouseEventArgs)

        myMousePressDown = True

        Dim myLabel As Label
        myLabel = DirectCast(sender, Label)

        If myLabel.BackColor = Color.Red Then
            myLabel.BackColor = Color.White
        Else
            myLabel.BackColor = Color.Red

        End If

        Me.mouseX = e.X
        Me.mouseY = e.Y

        LabelControlName.Text = sender.Name

    End Sub

    Private Sub LabelCtrl_MouseMove(sender As Object, e As MouseEventArgs)

        If myMousePressDown = False Then Exit Sub

        '--->

        Dim myLabel As Label
        myLabel = DirectCast(sender, Label)
        myLabel.Location = New Point(myLabel.Location.X + e.X - mouseX, myLabel.Location.Y + e.Y - mouseY)

        Me.Refresh()

    End Sub

    Private Sub LabelCtrl_MouseUp(sender As Object, e As MouseEventArgs)

        Dim myLabel As Label
        myLabel = DirectCast(sender, Label)

        myMousePressDown = False
        LabelControlName.Text = String.Empty

    End Sub








    Private Sub ButtonAddControl_Click(sender As Object, e As EventArgs) Handles ButtonAddControl.Click

        Dim LabelCtrl3 As New Label()
        Me.Controls.Add(LabelCtrl3)

        LabelCtrl3.Text = "Label3"

        LabelCtrl3.Top = 10
        LabelCtrl3.Left = 10

        AddressControlToMovableEvent(LabelCtrl3)

    End Sub


    Private Sub ButtonAlignLeft_Click(sender As Object, e As EventArgs) Handles ButtonAlignLeft.Click

        For Each ctrl As Control In Me.Controls

            If TypeOf ctrl Is Label Then

                Debug.Print(ctrl.Name)

                If ctrl.Name.StartsWith("LabelCtrl") And ctrl.BackColor = Color.Red Then

                    ctrl.Left = LabelCtrl1.Left

                End If

            End If

        Next

    End Sub

   

    Private Sub ButtonEnlargeFont_Click(sender As Object, e As EventArgs) Handles ButtonEnlargeFont.Click

        Dim FontSize As Decimal

        For Each ctrl As Control In Me.Controls

            If TypeOf ctrl Is Label Then

                Debug.Print(ctrl.Name)

                If ctrl.Name.StartsWith("LabelCtrl") And ctrl.BackColor = Color.Red Then

                    FontSize = ctrl.Font.Size

                    ctrl.Font = New Font(ctrl.Font.Name, FontSize + 1)

                End If

            End If

        Next

    End Sub


End Class