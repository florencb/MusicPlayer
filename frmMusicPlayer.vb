Public Class frmMusicPlayer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbVolume.Value = AxWindowsMediaPlayer1.settings.volume
        tbBalance.Value = AxWindowsMediaPlayer1.settings.balance
    End Sub

    Private Sub tbVolume_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVolume.Scroll
        AxWindowsMediaPlayer1.settings.volume = tbVolume.Value
    End Sub

    Private Sub tbBalance_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBalance.Scroll
        AxWindowsMediaPlayer1.settings.balance = tbBalance.Value
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim open As New OpenFileDialog
        Try
            open.Title = "Open Music"
            open.Multiselect = True
            open.Filter = "MP3 Files (*.mp3 | *.mp3 | All Files (*.* | *.*"

            If open.ShowDialog = Windows.Forms.DialogResult.OK Then
                For Each item As String In open.FileNames
                    lbHiddenMusicList.Items.Add(item)
                Next

                For Each itemName As String In open.SafeFileNames
                    lbDisplayMusicList.Items.Add(itemName)
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lbDisplayMusicList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDisplayMusicList.SelectedIndexChanged
        lbHiddenMusicList.SelectedIndex = lbDisplayMusicList.SelectedIndex
    End Sub

    Private Sub play()
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            If (AxWindowsMediaPlayer1.URL <> lbHiddenMusicList.SelectedItem.ToString) Then
                AxWindowsMediaPlayer1.URL = lbHiddenMusicList.SelectedItem.ToString
            Else
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
        Else
            AxWindowsMediaPlayer1.URL = lbDisplayMusicList.SelectedItem.ToString
        End If

        btnPlayPause.Text = "Pause"
    End Sub

    Private Sub playNextTrack()
        Try
            Dim currentItemIndex As Integer = lbDisplayMusicList.SelectedIndex
            lbDisplayMusicList.SelectedIndex = currentItemIndex + 1

            play()
        Catch ex As Exception
            AxWindowsMediaPlayer1.URL = ""
            btnPlayPause.Text = "Play"
        End Try
    End Sub

    Private Sub playPreviousTrack()
        Try
            Dim currentItemIndex As Integer = lbDisplayMusicList.SelectedIndex

            If currentItemIndex = 0 Then
                lbDisplayMusicList.SelectedIndex = -2
            Else
                lbDisplayMusicList.SelectedIndex = currentItemIndex - 1
            End If

            play()
        Catch ex As Exception
            AxWindowsMediaPlayer1.URL = ""
            btnPlayPause.Text = "Play"
        End Try
    End Sub


    Private Sub btnPlayPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayPause.Click
        If lbDisplayMusicList.SelectedIndex <> -1 Then
            If btnPlayPause.Text = "Play" Then
                play()

                btnPlayPause.Text = "Pause"
            ElseIf btnPlayPause.Text = "Pause" Then
                AxWindowsMediaPlayer1.Ctlcontrols.pause()

                btnPlayPause.Text = "Play"
            End If
        Else
            MessageBox.Show("Please choose a file to play")
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVale As System.EventArgs) Handles btnNext.Click
        playNextTrack()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        playPreviousTrack()
    End Sub
End Class
