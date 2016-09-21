<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
    Inherits PrjSample.frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NnTextboxNumeric1 = New PrjSample.nnTextboxNumeric()
        Me.NnTextboxNumeric2 = New PrjSample.nnTextboxNumeric()
        Me.SuspendLayout()
        '
        'NnTextboxNumeric1
        '
        Me.NnTextboxNumeric1.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NnTextboxNumeric1.Location = New System.Drawing.Point(446, 87)
        Me.NnTextboxNumeric1.Name = "NnTextboxNumeric1"
        Me.NnTextboxNumeric1.Size = New System.Drawing.Size(140, 27)
        Me.NnTextboxNumeric1.TabIndex = 0
        '
        'NnTextboxNumeric2
        '
        Me.NnTextboxNumeric2.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NnTextboxNumeric2.Location = New System.Drawing.Point(477, 182)
        Me.NnTextboxNumeric2.Name = "NnTextboxNumeric2"
        Me.NnTextboxNumeric2.Size = New System.Drawing.Size(140, 27)
        Me.NnTextboxNumeric2.TabIndex = 1
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.NnTextboxNumeric2)
        Me.Controls.Add(Me.NnTextboxNumeric1)
        Me.Name = "frmSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NnTextboxNumeric1 As PrjSample.nnTextboxNumeric
    Friend WithEvents NnTextboxNumeric2 As PrjSample.nnTextboxNumeric


End Class
