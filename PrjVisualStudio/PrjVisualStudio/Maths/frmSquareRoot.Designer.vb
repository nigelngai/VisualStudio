<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSquareRoot
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
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.lbl25 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.Teal
        Me.lbl9.Location = New System.Drawing.Point(260, 103)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(34, 24)
        Me.lbl9.TabIndex = 0
        Me.lbl9.Text = "---"
        '
        'lbl16
        '
        Me.lbl16.AutoSize = True
        Me.lbl16.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl16.ForeColor = System.Drawing.Color.Teal
        Me.lbl16.Location = New System.Drawing.Point(261, 170)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(34, 24)
        Me.lbl16.TabIndex = 1
        Me.lbl16.Text = "---"
        '
        'lbl25
        '
        Me.lbl25.AutoSize = True
        Me.lbl25.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl25.ForeColor = System.Drawing.Color.Teal
        Me.lbl25.Location = New System.Drawing.Point(261, 235)
        Me.lbl25.Name = "lbl25"
        Me.lbl25.Size = New System.Drawing.Size(34, 24)
        Me.lbl25.TabIndex = 2
        Me.lbl25.Text = "---"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "9"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "16"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(231, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SqaureRoot"
        '
        'frmSquareRoot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 319)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl25)
        Me.Controls.Add(Me.lbl16)
        Me.Controls.Add(Me.lbl9)
        Me.Name = "frmSquareRoot"
        Me.Text = "frmSquareRoot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl16 As System.Windows.Forms.Label
    Friend WithEvents lbl25 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
