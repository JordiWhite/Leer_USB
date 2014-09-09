Imports System.IO
Public Class FrmPen
    'Used to detected if any of the messages are any of these constants values.
    Private Const WM_DEVICECHANGE As Integer = &H219

    Private Const DBT_DEVICEARRIVAL As Integer = &H8000

    Private Const DBT_DEVICEREMOVECOMPLETE As Integer = &H8004

    Private Const DBT_DEVTYP_VOLUME As Integer = &H2  '
    '
    'Get the information about the detected volume.
    Private Structure DEV_BROADCAST_VOLUME

        Dim Dbcv_Size As Integer

        Dim Dbcv_Devicetype As Integer

        Dim Dbcv_Reserved As Integer

        Dim Dbcv_Unitmask As Integer

        Dim Dbcv_Flags As Short

    End Structure
    Private Const PenDataFolder As String = "CaptorSWin\Datos"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostraPenDrives()
        'TimerPenDrives.Enabled = True

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
            ExitButton.Enabled = True
            ExitButton.Focus()
        Else
            PensComboBox.Text = String.Empty
            ExitButton.Enabled = False
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
    Protected Overrides Sub WndProc(ByRef M As System.Windows.Forms.Message)
        '
        'These are the required subclassing codes for detecting device based removal and arrival.
        '
        If M.Msg = WM_DEVICECHANGE Then

            Select Case M.WParam
                '
                'Check if a device was added. 
                Case DBT_DEVICEARRIVAL

                    Dim DevType As Integer = Runtime.InteropServices.Marshal.ReadInt32(M.LParam, 4)

                    If DevType = DBT_DEVTYP_VOLUME Then

                        Dim Vol As New DEV_BROADCAST_VOLUME

                        Vol = Runtime.InteropServices.Marshal.PtrToStructure(M.LParam, GetType(DEV_BROADCAST_VOLUME))

                        If Vol.Dbcv_Flags = 0 Then

                            For i As Integer = 0 To 20

                                If Math.Pow(2, i) = Vol.Dbcv_Unitmask Then

                                    Dim Usb As String = Chr(65 + i) + ":\"

                                    ' MsgBox("Looks like a USB device was plugged in!" & vbNewLine & vbNewLine & "The drive letter is: " & Usb.ToString)
                                    MostraPenDrives()
                                    Exit For

                                End If


                            Next

                        End If

                    End If
                    '
                    'Check if the message was for the removal of a device. 
                Case DBT_DEVICEREMOVECOMPLETE

                    Dim DevType As Integer = Runtime.InteropServices.Marshal.ReadInt32(M.LParam, 4)

                    If DevType = DBT_DEVTYP_VOLUME Then

                        Dim Vol As New DEV_BROADCAST_VOLUME

                        Vol = Runtime.InteropServices.Marshal.PtrToStructure(M.LParam, GetType(DEV_BROADCAST_VOLUME))

                        If Vol.Dbcv_Flags = 0 Then

                            For i As Integer = 0 To 20

                                If Math.Pow(2, i) = Vol.Dbcv_Unitmask Then

                                    Dim Usb As String = Chr(65 + i) + ":\"

                                    ' MsgBox("Looks like a volume device was removed!" & vbNewLine & vbNewLine & "The drive letter is: " & Usb.ToString)
                                    MostraPenDrives()
                                    Exit For

                                End If

                            Next

                        End If

                    End If

            End Select

        End If

        MyBase.WndProc(M)

    End Sub
End Class
