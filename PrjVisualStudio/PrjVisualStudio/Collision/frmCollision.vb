
Public Class frmCollision

    Private Sub frmCollision_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CollisionDetect()
    End Sub

    Private Sub GetInfo()

        InfoPic1.Text = "Seiya" & vbNewLine & _
                                 "Top -- " & PicMe.Top & vbNewLine & _
                                  "Bottom -- " & PicMe.Bottom & vbNewLine & _
                                  "Left -- " & PicMe.Left & vbNewLine & _
                                  "Right -- " & PicMe.Right & vbNewLine & _
                                  "Height -- " & PicMe.Bottom - PicMe.Top & vbNewLine & _
                                   "Width -- " & PicMe.Left - PicMe.Right

        InfoPic2.Text = "Enemy" & vbNewLine & _
                                 "Top -- " & PicEnemy.Top & vbNewLine & _
                                  "Bottom -- " & PicEnemy.Bottom & vbNewLine &
                                  "Left -- " & PicEnemy.Left & vbNewLine &
                                  "Right -- " & PicEnemy.Right & vbNewLine & _
                                  "Height -- " & PicEnemy.Bottom - PicEnemy.Top & vbNewLine & _
                                   "Width -- " & PicEnemy.Left - PicEnemy.Right

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If MoveUp.Checked Then PicEnemy.Top -= 10
        If MoveDown.Checked Then PicEnemy.Top += 10
        If MoveRight.Checked Then PicEnemy.Left += 10
        If MoveLeft.Checked Then PicEnemy.Left -= 10

        GetInfo()
        'CollisionDetect()

    End Sub

    Private Sub ButtonStart_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStart.Click
        Timer1.Interval = 400
        Timer1.Enabled = True
    End Sub

    Private Sub ButtonStop_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub frmCollision_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        PicEnemy.Top = e.Y
        PicEnemy.Left = e.X
    End Sub





    Private Sub CollisionDetect()

        LblGroupA_RE.Text = "---"
        LblGroupA_LE.Text = "---"
        LblGroupA_TC.Text = "---"
        LblGroupA_BC.Text = "---"

        If PicMe.Left < PicEnemy.Left AndAlso PicMe.Right > PicEnemy.Left Then
            If PicMe.Top < PicEnemy.Top AndAlso PicMe.Bottom > PicEnemy.Bottom Then
                LblGroupA_RE.Text = "Right is Attacked"
                Timer1.Enabled = False
            End If
        End If

        If PicMe.Right > PicEnemy.Right AndAlso PicEnemy.Right > PicMe.Left Then
            If PicMe.Top < PicEnemy.Top AndAlso PicMe.Bottom > PicEnemy.Bottom Then
                LblGroupA_LE.Text = "Left is Attacked"
                Timer1.Enabled = False
            End If
        End If

        If PicMe.Top > PicEnemy.Top AndAlso PicMe.Top < PicEnemy.Bottom Then
            If PicMe.Right > PicEnemy.Left AndAlso PicMe.Left < PicEnemy.Right Then
                LblGroupA_TC.Text = "Top is Attacked"
                Timer1.Enabled = False
            End If
        End If

        If PicMe.Bottom < PicEnemy.Bottom AndAlso PicMe.Bottom > PicEnemy.Top Then
            If PicMe.Right > PicEnemy.Left AndAlso PicMe.Left < PicEnemy.Right Then
                LblGroupA_BC.Text = "Bottom is Attacked"
                Timer1.Enabled = False
            End If
        End If

    End Sub



    Private Sub IntersectCheck()

        'PictureBox 1 VS PictureBox 2

        If PicMe.Bounds.IntersectsWith(PicEnemy.Bounds) Then
            LblGroupA.Text = "Collision"
        Else
            LblGroupA.Text = "No Contact"
        End If

        If PictureBox3.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            lblGroupB.Text = "Collision"
        Else
            lblGroupB.Text = "No Contact"
        End If

        'Picture 4 VS All

        For Each PictureBox In Me.Controls

            If PictureBox IsNot PictureBox4 AndAlso PictureBox4.Bounds.IntersectsWith(PictureBox.Bounds) Then
                lblAll.Text = "Collision"
                Exit For
                lblAll.Text = "----"
            End If

        Next

    End Sub



End Class