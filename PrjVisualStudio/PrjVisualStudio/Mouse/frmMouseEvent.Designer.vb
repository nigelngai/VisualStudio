<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMouseEvent
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
        Me.ButtonDraw = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonDraw
        '
        Me.ButtonDraw.Location = New System.Drawing.Point(42, 79)
        Me.ButtonDraw.Name = "ButtonDraw"
        Me.ButtonDraw.Size = New System.Drawing.Size(211, 47)
        Me.ButtonDraw.TabIndex = 0
        Me.ButtonDraw.Text = "Draw"
        Me.ButtonDraw.UseVisualStyleBackColor = True
        '
        'frmMouseEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ButtonDraw)
        Me.Name = "frmMouseEvent"
        Me.Text = "frmMouseEvent"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonDraw As System.Windows.Forms.Button
End Class
