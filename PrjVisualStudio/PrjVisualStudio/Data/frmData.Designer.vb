<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmData
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
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.dgSample = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnInsertPara = New System.Windows.Forms.Button()
        Me.ButtonInsertTrans = New System.Windows.Forms.Button()
        CType(Me.dgSample, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(69, 37)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(196, 50)
        Me.BtnInsert.TabIndex = 0
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'dgSample
        '
        Me.dgSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSample.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName})
        Me.dgSample.Location = New System.Drawing.Point(69, 169)
        Me.dgSample.Name = "dgSample"
        Me.dgSample.RowTemplate.Height = 24
        Me.dgSample.Size = New System.Drawing.Size(270, 254)
        Me.dgSample.TabIndex = 1
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "ItemCode"
        Me.ItemCode.Name = "ItemCode"
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        '
        'btnInsertPara
        '
        Me.btnInsertPara.Location = New System.Drawing.Point(69, 93)
        Me.btnInsertPara.Name = "btnInsertPara"
        Me.btnInsertPara.Size = New System.Drawing.Size(196, 50)
        Me.btnInsertPara.TabIndex = 2
        Me.btnInsertPara.Text = "Insert Para"
        Me.btnInsertPara.UseVisualStyleBackColor = True
        '
        'ButtonInsertTrans
        '
        Me.ButtonInsertTrans.Location = New System.Drawing.Point(293, 93)
        Me.ButtonInsertTrans.Name = "ButtonInsertTrans"
        Me.ButtonInsertTrans.Size = New System.Drawing.Size(196, 50)
        Me.ButtonInsertTrans.TabIndex = 3
        Me.ButtonInsertTrans.Text = "Insert Transaction"
        Me.ButtonInsertTrans.UseVisualStyleBackColor = True
        '
        'frmData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 472)
        Me.Controls.Add(Me.ButtonInsertTrans)
        Me.Controls.Add(Me.btnInsertPara)
        Me.Controls.Add(Me.dgSample)
        Me.Controls.Add(Me.BtnInsert)
        Me.Name = "frmData"
        Me.Text = "frmDatabaseConn"
        CType(Me.dgSample, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents dgSample As System.Windows.Forms.DataGridView
    Friend WithEvents ItemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnInsertPara As System.Windows.Forms.Button
    Friend WithEvents ButtonInsertTrans As System.Windows.Forms.Button
End Class
