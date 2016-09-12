<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMouse
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
        Me.LabelCtrl1 = New System.Windows.Forms.Label()
        Me.LabelControlName = New System.Windows.Forms.Label()
        Me.LabelCtrl2 = New System.Windows.Forms.Label()
        Me.ButtonAddControl = New System.Windows.Forms.Button()
        Me.ButtonAlignLeft = New System.Windows.Forms.Button()
        Me.ButtonAlignTop = New System.Windows.Forms.Button()
        Me.LabelCtrl3 = New System.Windows.Forms.Label()
        Me.ButtonEnlargeFont = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelCtrl1
        '
        Me.LabelCtrl1.AutoSize = True
        Me.LabelCtrl1.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelCtrl1.Location = New System.Drawing.Point(107, 167)
        Me.LabelCtrl1.Name = "LabelCtrl1"
        Me.LabelCtrl1.Size = New System.Drawing.Size(51, 16)
        Me.LabelCtrl1.TabIndex = 0
        Me.LabelCtrl1.Text = "Label1"
        '
        'LabelControlName
        '
        Me.LabelControlName.AutoSize = True
        Me.LabelControlName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControlName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControlName.Location = New System.Drawing.Point(35, 50)
        Me.LabelControlName.Name = "LabelControlName"
        Me.LabelControlName.Size = New System.Drawing.Size(64, 24)
        Me.LabelControlName.TabIndex = 1
        Me.LabelControlName.Text = "Name"
        '
        'LabelCtrl2
        '
        Me.LabelCtrl2.AutoSize = True
        Me.LabelCtrl2.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelCtrl2.Location = New System.Drawing.Point(107, 242)
        Me.LabelCtrl2.Name = "LabelCtrl2"
        Me.LabelCtrl2.Size = New System.Drawing.Size(51, 16)
        Me.LabelCtrl2.TabIndex = 2
        Me.LabelCtrl2.Text = "Label2"
        '
        'ButtonAddControl
        '
        Me.ButtonAddControl.Location = New System.Drawing.Point(646, 110)
        Me.ButtonAddControl.Name = "ButtonAddControl"
        Me.ButtonAddControl.Size = New System.Drawing.Size(83, 38)
        Me.ButtonAddControl.TabIndex = 3
        Me.ButtonAddControl.Text = "AddControl"
        Me.ButtonAddControl.UseVisualStyleBackColor = True
        '
        'ButtonAlignLeft
        '
        Me.ButtonAlignLeft.Location = New System.Drawing.Point(646, 170)
        Me.ButtonAlignLeft.Name = "ButtonAlignLeft"
        Me.ButtonAlignLeft.Size = New System.Drawing.Size(83, 38)
        Me.ButtonAlignLeft.TabIndex = 4
        Me.ButtonAlignLeft.Text = "Align Left"
        Me.ButtonAlignLeft.UseVisualStyleBackColor = True
        '
        'ButtonAlignTop
        '
        Me.ButtonAlignTop.Location = New System.Drawing.Point(646, 232)
        Me.ButtonAlignTop.Name = "ButtonAlignTop"
        Me.ButtonAlignTop.Size = New System.Drawing.Size(83, 38)
        Me.ButtonAlignTop.TabIndex = 5
        Me.ButtonAlignTop.Text = "Align Top"
        Me.ButtonAlignTop.UseVisualStyleBackColor = True
        '
        'LabelCtrl3
        '
        Me.LabelCtrl3.AutoSize = True
        Me.LabelCtrl3.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelCtrl3.Location = New System.Drawing.Point(107, 321)
        Me.LabelCtrl3.Name = "LabelCtrl3"
        Me.LabelCtrl3.Size = New System.Drawing.Size(51, 16)
        Me.LabelCtrl3.TabIndex = 6
        Me.LabelCtrl3.Text = "Label3"
        '
        'ButtonEnlargeFont
        '
        Me.ButtonEnlargeFont.Location = New System.Drawing.Point(646, 315)
        Me.ButtonEnlargeFont.Name = "ButtonEnlargeFont"
        Me.ButtonEnlargeFont.Size = New System.Drawing.Size(83, 38)
        Me.ButtonEnlargeFont.TabIndex = 7
        Me.ButtonEnlargeFont.Text = "Enlarge Font"
        Me.ButtonEnlargeFont.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mouse Moving Object"
        '
        'FrmMouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 542)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEnlargeFont)
        Me.Controls.Add(Me.LabelCtrl3)
        Me.Controls.Add(Me.ButtonAlignTop)
        Me.Controls.Add(Me.ButtonAlignLeft)
        Me.Controls.Add(Me.ButtonAddControl)
        Me.Controls.Add(Me.LabelCtrl2)
        Me.Controls.Add(Me.LabelControlName)
        Me.Controls.Add(Me.LabelCtrl1)
        Me.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Name = "FrmMouse"
        Me.Text = "FrmMouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCtrl1 As System.Windows.Forms.Label
    Friend WithEvents LabelControlName As System.Windows.Forms.Label
    Friend WithEvents LabelCtrl2 As System.Windows.Forms.Label
    Friend WithEvents ButtonAddControl As System.Windows.Forms.Button
    Friend WithEvents ButtonAlignLeft As System.Windows.Forms.Button
    Friend WithEvents ButtonAlignTop As System.Windows.Forms.Button
    Friend WithEvents LabelCtrl3 As System.Windows.Forms.Label
    Friend WithEvents ButtonEnlargeFont As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
