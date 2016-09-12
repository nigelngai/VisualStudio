<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDict
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
        Me.dgDict = New System.Windows.Forms.DataGridView()
        Me.IndexName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnSearchValue = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        CType(Me.dgDict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDict
        '
        Me.dgDict.AllowUserToAddRows = False
        Me.dgDict.AllowUserToDeleteRows = False
        Me.dgDict.AllowUserToOrderColumns = True
        Me.dgDict.AllowUserToResizeColumns = False
        Me.dgDict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDict.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexName, Me.Desc})
        Me.dgDict.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDict.Location = New System.Drawing.Point(37, 38)
        Me.dgDict.Margin = New System.Windows.Forms.Padding(5)
        Me.dgDict.Name = "dgDict"
        Me.dgDict.RowTemplate.Height = 24
        Me.dgDict.Size = New System.Drawing.Size(769, 378)
        Me.dgDict.TabIndex = 0
        '
        'IndexName
        '
        Me.IndexName.HeaderText = "IndexName"
        Me.IndexName.Name = "IndexName"
        Me.IndexName.Width = 150
        '
        'Desc
        '
        Me.Desc.HeaderText = "Desc"
        Me.Desc.Name = "Desc"
        Me.Desc.Width = 400
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(161, 457)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(30, 20)
        Me.lblResult.TabIndex = 1
        Me.lblResult.Text = "---"
        '
        'btnSearchValue
        '
        Me.btnSearchValue.Location = New System.Drawing.Point(37, 493)
        Me.btnSearchValue.Name = "btnSearchValue"
        Me.btnSearchValue.Size = New System.Drawing.Size(165, 33)
        Me.btnSearchValue.TabIndex = 3
        Me.btnSearchValue.Text = "SearchValue"
        Me.btnSearchValue.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(37, 454)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 29)
        Me.txtInput.TabIndex = 4
        '
        'frmDict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 557)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnSearchValue)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.dgDict)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmDict"
        Me.Text = "frmDict"
        CType(Me.dgDict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgDict As System.Windows.Forms.DataGridView
    Friend WithEvents IndexName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnSearchValue As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
End Class
