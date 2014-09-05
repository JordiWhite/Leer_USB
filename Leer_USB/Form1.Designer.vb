<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPen
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
        Me.components = New System.ComponentModel.Container
        Me.PensComboBox = New System.Windows.Forms.ComboBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.TimerPenDrives = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonPen = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'PensComboBox
        '
        Me.PensComboBox.FormattingEnabled = True
        Me.PensComboBox.Location = New System.Drawing.Point(39, 28)
        Me.PensComboBox.Name = "PensComboBox"
        Me.PensComboBox.Size = New System.Drawing.Size(209, 21)
        Me.PensComboBox.TabIndex = 0
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(148, 99)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(60, 27)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "end"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TimerPenDrives
        '
        Me.TimerPenDrives.Interval = 1000
        '
        'ButtonPen
        '
        Me.ButtonPen.Image = Global.WindowsApplication1.My.Resources.Resources.PEN
        Me.ButtonPen.Location = New System.Drawing.Point(39, 185)
        Me.ButtonPen.Name = "ButtonPen"
        Me.ButtonPen.Size = New System.Drawing.Size(75, 55)
        Me.ButtonPen.TabIndex = 2
        Me.ButtonPen.UseVisualStyleBackColor = True
        '
        'FrmPen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ButtonPen)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PensComboBox)
        Me.Name = "FrmPen"
        Me.Text = "FrmPen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PensComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents TimerPenDrives As System.Windows.Forms.Timer
    Friend WithEvents ButtonPen As System.Windows.Forms.Button

End Class
