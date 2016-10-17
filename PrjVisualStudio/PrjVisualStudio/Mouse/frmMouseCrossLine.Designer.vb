<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMouseCrossLine
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
        Me.LineY = New System.Windows.Forms.Label()
        Me.LineX = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LineY
        '
        Me.LineY.BackColor = System.Drawing.Color.Red
        Me.LineY.Location = New System.Drawing.Point(314, -13)
        Me.LineY.Name = "LineY"
        Me.LineY.Size = New System.Drawing.Size(1, 600)
        Me.LineY.TabIndex = 0
        '
        'LineX
        '
        Me.LineX.BackColor = System.Drawing.Color.Red
        Me.LineX.Location = New System.Drawing.Point(-10, 274)
        Me.LineX.Name = "LineX"
        Me.LineX.Size = New System.Drawing.Size(600, 1)
        Me.LineX.TabIndex = 1
        '
        'frmMouseCrossLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 544)
        Me.Controls.Add(Me.LineX)
        Me.Controls.Add(Me.LineY)
        Me.Name = "frmMouseCrossLine"
        Me.Text = "frmMouseCrossLine"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LineY As System.Windows.Forms.Label
    Friend WithEvents LineX As System.Windows.Forms.Label
End Class
