<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollision
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblGroupA = New System.Windows.Forms.Label()
        Me.PicEnemy = New System.Windows.Forms.PictureBox()
        Me.PicMe = New System.Windows.Forms.PictureBox()
        Me.lblGroupB = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblAll = New System.Windows.Forms.Label()
        Me.LblGroupA_RE = New System.Windows.Forms.Label()
        Me.LblGroupA_LE = New System.Windows.Forms.Label()
        Me.LblGroupA_BC = New System.Windows.Forms.Label()
        Me.LblGroupA_TC = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InfoPic1 = New System.Windows.Forms.Label()
        Me.InfoPic2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.txtEStartTop = New System.Windows.Forms.TextBox()
        Me.txtEStartLeft = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.MoveUp = New System.Windows.Forms.CheckBox()
        Me.MoveDown = New System.Windows.Forms.CheckBox()
        Me.MoveLeft = New System.Windows.Forms.CheckBox()
        Me.MoveRight = New System.Windows.Forms.CheckBox()
        CType(Me.PicEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblGroupA
        '
        Me.LblGroupA.AutoSize = True
        Me.LblGroupA.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblGroupA.ForeColor = System.Drawing.Color.Blue
        Me.LblGroupA.Location = New System.Drawing.Point(664, 560)
        Me.LblGroupA.Name = "LblGroupA"
        Me.LblGroupA.Size = New System.Drawing.Size(48, 27)
        Me.LblGroupA.TabIndex = 5
        Me.LblGroupA.Text = "----"
        Me.LblGroupA.Visible = False
        '
        'PicEnemy
        '
        Me.PicEnemy.BackColor = System.Drawing.Color.Black
        Me.PicEnemy.Location = New System.Drawing.Point(12, 58)
        Me.PicEnemy.Name = "PicEnemy"
        Me.PicEnemy.Size = New System.Drawing.Size(85, 59)
        Me.PicEnemy.TabIndex = 4
        Me.PicEnemy.TabStop = False
        '
        'PicMe
        '
        Me.PicMe.BackColor = System.Drawing.Color.Yellow
        Me.PicMe.Location = New System.Drawing.Point(123, 150)
        Me.PicMe.Name = "PicMe"
        Me.PicMe.Size = New System.Drawing.Size(155, 105)
        Me.PicMe.TabIndex = 3
        Me.PicMe.TabStop = False
        '
        'lblGroupB
        '
        Me.lblGroupB.AutoSize = True
        Me.lblGroupB.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblGroupB.ForeColor = System.Drawing.Color.Blue
        Me.lblGroupB.Location = New System.Drawing.Point(664, 593)
        Me.lblGroupB.Name = "lblGroupB"
        Me.lblGroupB.Size = New System.Drawing.Size(48, 27)
        Me.lblGroupB.TabIndex = 8
        Me.lblGroupB.Text = "----"
        Me.lblGroupB.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(142, 491)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(85, 105)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(74, 440)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(85, 105)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'lblAll
        '
        Me.lblAll.AutoSize = True
        Me.lblAll.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAll.ForeColor = System.Drawing.Color.Purple
        Me.lblAll.Location = New System.Drawing.Point(957, 593)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(48, 27)
        Me.lblAll.TabIndex = 9
        Me.lblAll.Text = "----"
        Me.lblAll.Visible = False
        '
        'LblGroupA_RE
        '
        Me.LblGroupA_RE.AutoSize = True
        Me.LblGroupA_RE.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblGroupA_RE.ForeColor = System.Drawing.Color.Red
        Me.LblGroupA_RE.Location = New System.Drawing.Point(137, 329)
        Me.LblGroupA_RE.Name = "LblGroupA_RE"
        Me.LblGroupA_RE.Size = New System.Drawing.Size(48, 27)
        Me.LblGroupA_RE.TabIndex = 10
        Me.LblGroupA_RE.Text = "----"
        '
        'LblGroupA_LE
        '
        Me.LblGroupA_LE.AutoSize = True
        Me.LblGroupA_LE.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblGroupA_LE.ForeColor = System.Drawing.Color.Red
        Me.LblGroupA_LE.Location = New System.Drawing.Point(137, 361)
        Me.LblGroupA_LE.Name = "LblGroupA_LE"
        Me.LblGroupA_LE.Size = New System.Drawing.Size(48, 27)
        Me.LblGroupA_LE.TabIndex = 11
        Me.LblGroupA_LE.Text = "----"
        '
        'LblGroupA_BC
        '
        Me.LblGroupA_BC.AutoSize = True
        Me.LblGroupA_BC.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblGroupA_BC.ForeColor = System.Drawing.Color.Red
        Me.LblGroupA_BC.Location = New System.Drawing.Point(137, 298)
        Me.LblGroupA_BC.Name = "LblGroupA_BC"
        Me.LblGroupA_BC.Size = New System.Drawing.Size(48, 27)
        Me.LblGroupA_BC.TabIndex = 13
        Me.LblGroupA_BC.Text = "----"
        '
        'LblGroupA_TC
        '
        Me.LblGroupA_TC.AutoSize = True
        Me.LblGroupA_TC.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblGroupA_TC.ForeColor = System.Drawing.Color.Red
        Me.LblGroupA_TC.Location = New System.Drawing.Point(137, 269)
        Me.LblGroupA_TC.Name = "LblGroupA_TC"
        Me.LblGroupA_TC.Size = New System.Drawing.Size(48, 27)
        Me.LblGroupA_TC.TabIndex = 12
        Me.LblGroupA_TC.Text = "----"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 27)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Left"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 27)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Right"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 27)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Top"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 27)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Bottom"
        '
        'InfoPic1
        '
        Me.InfoPic1.AutoSize = True
        Me.InfoPic1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.InfoPic1.ForeColor = System.Drawing.Color.Blue
        Me.InfoPic1.Location = New System.Drawing.Point(15, 35)
        Me.InfoPic1.Name = "InfoPic1"
        Me.InfoPic1.Size = New System.Drawing.Size(57, 27)
        Me.InfoPic1.TabIndex = 18
        Me.InfoPic1.Text = "-----"
        '
        'InfoPic2
        '
        Me.InfoPic2.AutoSize = True
        Me.InfoPic2.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.InfoPic2.ForeColor = System.Drawing.Color.Blue
        Me.InfoPic2.Location = New System.Drawing.Point(66, 28)
        Me.InfoPic2.Name = "InfoPic2"
        Me.InfoPic2.Size = New System.Drawing.Size(57, 27)
        Me.InfoPic2.TabIndex = 19
        Me.InfoPic2.Text = "-----"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.InfoPic1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LblGroupA_BC)
        Me.GroupBox1.Controls.Add(Me.LblGroupA_TC)
        Me.GroupBox1.Controls.Add(Me.LblGroupA_LE)
        Me.GroupBox1.Controls.Add(Me.LblGroupA_RE)
        Me.GroupBox1.Location = New System.Drawing.Point(417, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 392)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.InfoPic2)
        Me.GroupBox2.Location = New System.Drawing.Point(817, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 343)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enemy Status"
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'ButtonStart
        '
        Me.ButtonStart.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonStart.Location = New System.Drawing.Point(669, 421)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(75, 43)
        Me.ButtonStart.TabIndex = 22
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'txtEStartTop
        '
        Me.txtEStartTop.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtEStartTop.Location = New System.Drawing.Point(673, 512)
        Me.txtEStartTop.Name = "txtEStartTop"
        Me.txtEStartTop.Size = New System.Drawing.Size(100, 29)
        Me.txtEStartTop.TabIndex = 23
        Me.txtEStartTop.Text = "360"
        Me.txtEStartTop.Visible = False
        '
        'txtEStartLeft
        '
        Me.txtEStartLeft.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtEStartLeft.Location = New System.Drawing.Point(779, 512)
        Me.txtEStartLeft.Name = "txtEStartLeft"
        Me.txtEStartLeft.Size = New System.Drawing.Size(100, 29)
        Me.txtEStartLeft.TabIndex = 24
        Me.txtEStartLeft.Text = "180"
        Me.txtEStartLeft.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(675, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 12)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Top"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(777, 497)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 12)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Left"
        Me.Label6.Visible = False
        '
        'ButtonStop
        '
        Me.ButtonStop.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonStop.Location = New System.Drawing.Point(750, 421)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(75, 43)
        Me.ButtonStop.TabIndex = 27
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'MoveUp
        '
        Me.MoveUp.AutoSize = True
        Me.MoveUp.Location = New System.Drawing.Point(974, 448)
        Me.MoveUp.Name = "MoveUp"
        Me.MoveUp.Size = New System.Drawing.Size(43, 16)
        Me.MoveUp.TabIndex = 28
        Me.MoveUp.Text = "Top"
        Me.MoveUp.UseVisualStyleBackColor = True
        '
        'MoveDown
        '
        Me.MoveDown.AutoSize = True
        Me.MoveDown.Location = New System.Drawing.Point(974, 538)
        Me.MoveDown.Name = "MoveDown"
        Me.MoveDown.Size = New System.Drawing.Size(52, 16)
        Me.MoveDown.TabIndex = 29
        Me.MoveDown.Text = "Down"
        Me.MoveDown.UseVisualStyleBackColor = True
        '
        'MoveLeft
        '
        Me.MoveLeft.AutoSize = True
        Me.MoveLeft.Location = New System.Drawing.Point(916, 493)
        Me.MoveLeft.Name = "MoveLeft"
        Me.MoveLeft.Size = New System.Drawing.Size(43, 16)
        Me.MoveLeft.TabIndex = 30
        Me.MoveLeft.Text = "Left"
        Me.MoveLeft.UseVisualStyleBackColor = True
        '
        'MoveRight
        '
        Me.MoveRight.AutoSize = True
        Me.MoveRight.Location = New System.Drawing.Point(1034, 493)
        Me.MoveRight.Name = "MoveRight"
        Me.MoveRight.Size = New System.Drawing.Size(50, 16)
        Me.MoveRight.TabIndex = 31
        Me.MoveRight.Text = "Right"
        Me.MoveRight.UseVisualStyleBackColor = True
        '
        'frmCollision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 666)
        Me.Controls.Add(Me.MoveRight)
        Me.Controls.Add(Me.MoveLeft)
        Me.Controls.Add(Me.MoveDown)
        Me.Controls.Add(Me.MoveUp)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEStartLeft)
        Me.Controls.Add(Me.txtEStartTop)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAll)
        Me.Controls.Add(Me.lblGroupB)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LblGroupA)
        Me.Controls.Add(Me.PicEnemy)
        Me.Controls.Add(Me.PicMe)
        Me.Name = "frmCollision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCollision"
        CType(Me.PicEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblGroupA As System.Windows.Forms.Label
    Friend WithEvents PicEnemy As System.Windows.Forms.PictureBox
    Friend WithEvents PicMe As System.Windows.Forms.PictureBox
    Friend WithEvents lblGroupB As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAll As System.Windows.Forms.Label
    Friend WithEvents LblGroupA_RE As System.Windows.Forms.Label
    Friend WithEvents LblGroupA_LE As System.Windows.Forms.Label
    Friend WithEvents LblGroupA_BC As System.Windows.Forms.Label
    Friend WithEvents LblGroupA_TC As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InfoPic1 As System.Windows.Forms.Label
    Friend WithEvents InfoPic2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents txtEStartTop As System.Windows.Forms.TextBox
    Friend WithEvents txtEStartLeft As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents MoveUp As System.Windows.Forms.CheckBox
    Friend WithEvents MoveDown As System.Windows.Forms.CheckBox
    Friend WithEvents MoveLeft As System.Windows.Forms.CheckBox
    Friend WithEvents MoveRight As System.Windows.Forms.CheckBox
End Class
