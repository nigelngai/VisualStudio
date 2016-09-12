<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColor
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblMoveX = New System.Windows.Forms.Label()
        Me.lblMoveY = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(737, 620)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(794, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(794, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "G"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(794, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "B"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblR.ForeColor = System.Drawing.Color.Blue
        Me.lblR.Location = New System.Drawing.Point(858, 128)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(30, 20)
        Me.lblR.TabIndex = 4
        Me.lblR.Text = "---"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblG.ForeColor = System.Drawing.Color.Blue
        Me.lblG.Location = New System.Drawing.Point(858, 163)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(30, 20)
        Me.lblG.TabIndex = 5
        Me.lblG.Text = "---"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblB.ForeColor = System.Drawing.Color.Blue
        Me.lblB.Location = New System.Drawing.Point(858, 201)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(30, 20)
        Me.lblB.TabIndex = 6
        Me.lblB.Text = "---"
        '
        'lblMoveX
        '
        Me.lblMoveX.AutoSize = True
        Me.lblMoveX.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMoveX.ForeColor = System.Drawing.Color.Blue
        Me.lblMoveX.Location = New System.Drawing.Point(858, 46)
        Me.lblMoveX.Name = "lblMoveX"
        Me.lblMoveX.Size = New System.Drawing.Size(30, 20)
        Me.lblMoveX.TabIndex = 7
        Me.lblMoveX.Text = "---"
        '
        'lblMoveY
        '
        Me.lblMoveY.AutoSize = True
        Me.lblMoveY.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMoveY.ForeColor = System.Drawing.Color.Blue
        Me.lblMoveY.Location = New System.Drawing.Point(858, 82)
        Me.lblMoveY.Name = "lblMoveY"
        Me.lblMoveY.Size = New System.Drawing.Size(30, 20)
        Me.lblMoveY.TabIndex = 8
        Me.lblMoveY.Text = "---"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(794, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(794, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Y"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(798, 269)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 69)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(798, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 61)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 644)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMoveY)
        Me.Controls.Add(Me.lblMoveX)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblG)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents lblG As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblMoveX As System.Windows.Forms.Label
    Friend WithEvents lblMoveY As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
