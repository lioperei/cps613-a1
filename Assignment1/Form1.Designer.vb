<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assignment1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Assignment1
        '
        Me.ClientSize = New System.Drawing.Size(489, 261)
        Me.Name = "Assignment1"
        Me.Text = "Assignment1: Lionel Pereira"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Keypad As Panel
    Friend WithEvents KeypadCancelButton As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents OKButton As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents KeyPadCancel As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents Clock As TabPage
    Friend WithEvents Alarm1 As TabPage
    Friend WithEvents Alarm2 As TabPage
    Friend WithEvents Alarm3 As TabPage
    Friend WithEvents TimePanel1 As TimePanel
    Friend WithEvents TimePanel2 As TimePanel
End Class
