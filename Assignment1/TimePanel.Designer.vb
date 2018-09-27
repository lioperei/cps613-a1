<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Colon = New System.Windows.Forms.Label()
        Me.Meridian = New System.Windows.Forms.GroupBox()
        Me.PMButton = New System.Windows.Forms.RadioButton()
        Me.AMButton = New System.Windows.Forms.RadioButton()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.Meridian.SuspendLayout()
        Me.SuspendLayout()
        '
        'Colon
        '
        Me.Colon.AutoSize = True
        Me.Colon.Location = New System.Drawing.Point(161, 26)
        Me.Colon.Name = "Colon"
        Me.Colon.Size = New System.Drawing.Size(10, 13)
        Me.Colon.TabIndex = 2
        Me.Colon.Text = ":"
        '
        'Meridian
        '
        Me.Meridian.Controls.Add(Me.PMButton)
        Me.Meridian.Controls.Add(Me.AMButton)
        Me.Meridian.Location = New System.Drawing.Point(207, 42)
        Me.Meridian.Name = "Meridian"
        Me.Meridian.Size = New System.Drawing.Size(106, 39)
        Me.Meridian.TabIndex = 5
        Me.Meridian.TabStop = False
        '
        'PMButton
        '
        Me.PMButton.AutoSize = True
        Me.PMButton.Location = New System.Drawing.Point(59, 16)
        Me.PMButton.Name = "PMButton"
        Me.PMButton.Size = New System.Drawing.Size(41, 17)
        Me.PMButton.TabIndex = 1
        Me.PMButton.TabStop = True
        Me.PMButton.Text = "PM"
        Me.PMButton.UseVisualStyleBackColor = True
        '
        'AMButton
        '
        Me.AMButton.AutoSize = True
        Me.AMButton.Location = New System.Drawing.Point(6, 16)
        Me.AMButton.Name = "AMButton"
        Me.AMButton.Size = New System.Drawing.Size(41, 17)
        Me.AMButton.TabIndex = 0
        Me.AMButton.TabStop = True
        Me.AMButton.Text = "AM"
        Me.AMButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(105, 55)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 7
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(24, 55)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(75, 23)
        Me.SetButton.TabIndex = 8
        Me.SetButton.Text = "SET"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'TimePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SetButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Meridian)
        Me.Controls.Add(Me.Colon)
        Me.Name = "TimePanel"
        Me.Size = New System.Drawing.Size(335, 96)
        Me.Meridian.ResumeLayout(False)
        Me.Meridian.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MOnes As DigitLED
    Friend WithEvents MTens As DigitLED
    Friend WithEvents Colon As Label
    Friend WithEvents HOnes As DigitLED
    Friend WithEvents HTens As DigitLED
    Friend WithEvents Meridian As GroupBox
    Friend WithEvents PMButton As RadioButton
    Friend WithEvents AMButton As RadioButton
    Friend WithEvents ResetButton As Button
    Friend WithEvents SetButton As Button
End Class
