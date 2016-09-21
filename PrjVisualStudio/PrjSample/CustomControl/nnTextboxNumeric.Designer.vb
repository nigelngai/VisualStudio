<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nnTextboxNumeric
    Inherits nnTextbox

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
    End Sub


    Private Sub CheckNumeric() Handles Me.TextChanged

        If IsNumeric(Me.Text) = False Then Me.Clear()

    End Sub


End Class
