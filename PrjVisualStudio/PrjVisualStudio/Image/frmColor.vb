Public Class frmColor

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim bmp As New Bitmap(600, 600)

        Dim R As Integer = 255
        Dim G As Integer = 255
        Dim B As Integer = 255

        Dim Y As Integer = 0
        Dim X As Integer = 0

        For X = 1 To 255
            'R = R - 1
            G = 255
            For Y = 1 To 255
                G = G - 1
                bmp.SetPixel(X, Y, Color.FromArgb(60, R, G, B))
            Next
        Next

        '-------->

        'R = 0
        'G = 255
        'B = 0

        'For X = 256 To 510
        '    B = B + 1
        '    G = 255
        '    For Y = 1 To 255
        '        G = G - 1
        '        bmp.SetPixel(X, Y, Color.FromArgb(R, G, B))
        '    Next
        'Next

        ''-------->

        'R = 0
        'G = 0
        'B = 0
        'For X = 256 To 510
        '    B = B + 1
        '    R = 0
        '    For Y = 256 To 510
        '        R = R + 1
        '        bmp.SetPixel(X, Y, Color.FromArgb(R, G, B))
        '    Next
        'Next

        PictureBox1.Image = bmp

    End Sub







    Private Sub PictureBox1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseClick

        'Get bmp Dimension
        Dim bmp As New Bitmap(600, 600)
        bmp = PictureBox1.Image

        '        //Get Selected Color
        Dim SelectedColor As New Color

        Try


            SelectedColor = bmp.GetPixel(e.X, e.Y)

            'picSelectedColor.BackColor = SelectedColor;

            '//Get MouseClick Position
            'lblX.Text = e.X.ToString();
            'lblY.Text = e.Y.ToString();

            '//Get RGB Color
            lblR.Text = SelectedColor.R.ToString()
            lblG.Text = SelectedColor.G.ToString()
            lblB.Text = SelectedColor.B.ToString()


            PictureBox2.BackColor = SelectedColor

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove

        lblMoveX.Text = e.X.ToString()
        lblMoveY.Text = e.Y.ToString()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim bmp As New Bitmap(600, 600)
        bmp = PictureBox1.Image
        Dim i As Integer

        'Dim ColorDict As New Dictionary(Of String, String)
        'ColorDict.Add("225", "226")

        For i = 0 To bmp.Width



        Next





    End Sub




End Class
