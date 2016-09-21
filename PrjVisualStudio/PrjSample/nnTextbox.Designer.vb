<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nnTextbox
    Inherits System.Windows.Forms.TextBox

    'UserControl overrides dispose to clean up the component list.
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
        components = New System.ComponentModel.Container()
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.Width = 140

        Me.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))

    End Sub


    Private Sub txt_Enter(sender As System.Object, e As System.EventArgs) Handles Me.Enter
        Me.BackColor = Color.NavajoWhite
    End Sub

    Private Sub txt_Leave(sender As System.Object, e As System.EventArgs) Handles Me.Leave
        Me.BackColor = Color.White
    End Sub


End Class
