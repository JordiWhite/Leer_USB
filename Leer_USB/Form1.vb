Imports System.IO
Public Class FrmPen
    Private Const PenDataFolder As String = "CaptorSWin\Datos"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostraPenDrives()
        TimerPenDrives.Enabled = True

    End Sub
    Private Sub MostraPenDrives()

        Dim allDrives() As DriveInfo = DriveInfo.GetDrives

        'Compta quants dispositius removibles hi ha
        Dim comptaPens As Integer = 0
        For Each d In allDrives
            If d.IsReady And d.DriveType = DriveType.Removable Then
                comptaPens += 1
            End If
        Next

        'Si s'ha desconnectat algun pen drive, els esborra tots
        If comptaPens < PensComboBox.Items.Count Then
            PensComboBox.Items.Clear()
        End If

        'Afegeix els pen drives recentment connectats
        For Each d In allDrives
            If d.IsReady And d.DriveType = DriveType.Removable Then
                Dim drivestring As String = String.Format("{0}({1})", d.VolumeLabel, d.Name)
                If Not PensComboBox.Items.Contains(drivestring) Then PensComboBox.Items.Add(drivestring)
            End If
        Next

        If PensComboBox.Items.Count > 0 Then
            If Not PensComboBox.Items.Contains(PensComboBox.Text) Then PensComboBox.SelectedIndex = 0
            exitButton.Enabled = True
            exitButton.Focus()
        Else
            PensComboBox.Text = String.Empty
            exitButton.Enabled = False
        End If

    End Sub

    Private Sub TimerPenDrives_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPenDrives.Tick
        MostraPenDrives()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub ButtonPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPen.Click
        Dim PenDataPath As String = NomUnitat(PensComboBox.Text) & PenDataFolder

        If Directory.Exists(PenDataPath) Then
            'MsgBox(PenDataPath & "\" & "utiles.xml")
            'ruta = PenDataPath & "\" ' & "utiles.xml"
        Else
            MsgBox(PenDataPath & "   no existe")
        End If
    End Sub
    Private Function NomUnitat(ByVal texte As String) As String
        Dim startUnit As Integer = texte.Length - 4
        Dim nomUnit As String = texte.Substring(startUnit, 3)
        Return nomUnit
    End Function
End Class
