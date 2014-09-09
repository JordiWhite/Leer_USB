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
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'PensComboBox
        '
        Me.PensComboBox.FormattingEnabled = True
        Me.PensComboBox.Location = New System.Drawing.Point(59, 12)
        Me.PensComboBox.Name = "PensComboBox"
        Me.PensComboBox.Size = New System.Drawing.Size(209, 21)
        Me.PensComboBox.TabIndex = 0
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(162, 304)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 55)
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
        Me.ButtonPen.Location = New System.Drawing.Point(59, 304)
        Me.ButtonPen.Name = "ButtonPen"
        Me.ButtonPen.Size = New System.Drawing.Size(75, 55)
        Me.ButtonPen.TabIndex = 2
        Me.ButtonPen.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Location = New System.Drawing.Point(292, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(423, 359)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 87
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 76
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Width = 78
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Width = 70
        '
        'FrmPen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 387)
        Me.Controls.Add(Me.ListView1)
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
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader

End Class
