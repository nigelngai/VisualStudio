<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintLabel
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
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtBARCODE = New System.Windows.Forms.TextBox()
        Me.txtBARCODEValue = New System.Windows.Forms.TextBox()
        Me.picOutputDoc = New System.Windows.Forms.PictureBox()
        Me.InputText = New System.Windows.Forms.TextBox()
        Me.prnOutputDoc = New System.Drawing.Printing.PrintDocument()
        CType(Me.picOutputDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(385, 202)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(120, 54)
        Me.cmdPrint.TabIndex = 51
        Me.cmdPrint.Text = "Print"
        '
        'txtBARCODE
        '
        Me.txtBARCODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBARCODE.Font = New System.Drawing.Font("Code 39", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBARCODE.Location = New System.Drawing.Point(97, 210)
        Me.txtBARCODE.Name = "txtBARCODE"
        Me.txtBARCODE.Size = New System.Drawing.Size(205, 19)
        Me.txtBARCODE.TabIndex = 50
        Me.txtBARCODE.Text = "*12345678P*"
        '
        'txtBARCODEValue
        '
        Me.txtBARCODEValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBARCODEValue.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBARCODEValue.Location = New System.Drawing.Point(92, 176)
        Me.txtBARCODEValue.Name = "txtBARCODEValue"
        Me.txtBARCODEValue.Size = New System.Drawing.Size(160, 33)
        Me.txtBARCODEValue.TabIndex = 49
        Me.txtBARCODEValue.Text = "33336666"
        '
        'picOutputDoc
        '
        Me.picOutputDoc.BackColor = System.Drawing.Color.White
        Me.picOutputDoc.Location = New System.Drawing.Point(56, 165)
        Me.picOutputDoc.Name = "picOutputDoc"
        Me.picOutputDoc.Size = New System.Drawing.Size(259, 91)
        Me.picOutputDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOutputDoc.TabIndex = 48
        Me.picOutputDoc.TabStop = False
        '
        'InputText
        '
        Me.InputText.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.InputText.Location = New System.Drawing.Point(56, 82)
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(259, 27)
        Me.InputText.TabIndex = 52
        '
        'prnOutputDoc
        '
        Me.prnOutputDoc.DocumentName = "產品價錢牌"
        '
        'frmPrintLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 362)
        Me.Controls.Add(Me.InputText)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.txtBARCODE)
        Me.Controls.Add(Me.txtBARCODEValue)
        Me.Controls.Add(Me.picOutputDoc)
        Me.Name = "frmPrintLabel"
        Me.Text = "frmPrintLabel"
        CType(Me.picOutputDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents txtBARCODE As System.Windows.Forms.TextBox
    Friend WithEvents txtBARCODEValue As System.Windows.Forms.TextBox
    Friend WithEvents picOutputDoc As System.Windows.Forms.PictureBox
    Friend WithEvents InputText As System.Windows.Forms.TextBox
    Friend WithEvents prnOutputDoc As System.Drawing.Printing.PrintDocument
End Class
