<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMusicPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMusicPlayer))
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnPlayPause = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lbDisplayMusicList = New System.Windows.Forms.ListBox()
        Me.lbHiddenMusicList = New System.Windows.Forms.ListBox()
        Me.tbVolume = New System.Windows.Forms.TrackBar()
        Me.tbBalance = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnImport.Location = New System.Drawing.Point(12, 29)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnPlayPause
        '
        Me.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayPause.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnPlayPause.Location = New System.Drawing.Point(100, 29)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayPause.TabIndex = 1
        Me.btnPlayPause.Text = "Play"
        Me.btnPlayPause.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnPrevious.Location = New System.Drawing.Point(188, 29)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnNext.Location = New System.Drawing.Point(276, 29)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lbDisplayMusicList
        '
        Me.lbDisplayMusicList.BackColor = System.Drawing.Color.Black
        Me.lbDisplayMusicList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbDisplayMusicList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDisplayMusicList.ForeColor = System.Drawing.Color.Violet
        Me.lbDisplayMusicList.FormattingEnabled = True
        Me.lbDisplayMusicList.ItemHeight = 16
        Me.lbDisplayMusicList.Location = New System.Drawing.Point(12, 75)
        Me.lbDisplayMusicList.Name = "lbDisplayMusicList"
        Me.lbDisplayMusicList.Size = New System.Drawing.Size(307, 96)
        Me.lbDisplayMusicList.TabIndex = 4
        '
        'lbHiddenMusicList
        '
        Me.lbHiddenMusicList.FormattingEnabled = True
        Me.lbHiddenMusicList.Location = New System.Drawing.Point(12, 207)
        Me.lbHiddenMusicList.Name = "lbHiddenMusicList"
        Me.lbHiddenMusicList.Size = New System.Drawing.Size(47, 30)
        Me.lbHiddenMusicList.TabIndex = 5
        Me.lbHiddenMusicList.Visible = False
        '
        'tbVolume
        '
        Me.tbVolume.Location = New System.Drawing.Point(373, 75)
        Me.tbVolume.Maximum = 100
        Me.tbVolume.Name = "tbVolume"
        Me.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbVolume.Size = New System.Drawing.Size(45, 104)
        Me.tbVolume.TabIndex = 6
        Me.tbVolume.TickFrequency = 50
        Me.tbVolume.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbBalance
        '
        Me.tbBalance.Location = New System.Drawing.Point(434, 75)
        Me.tbBalance.Maximum = 100
        Me.tbBalance.Minimum = -100
        Me.tbBalance.Name = "tbBalance"
        Me.tbBalance.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbBalance.Size = New System.Drawing.Size(45, 104)
        Me.tbBalance.TabIndex = 7
        Me.tbBalance.TickFrequency = 100
        Me.tbBalance.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(370, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Volume"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label2.Location = New System.Drawing.Point(431, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Balance"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(75, 207)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(28, 30)
        Me.AxWindowsMediaPlayer1.TabIndex = 10
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'frmMusicPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(491, 249)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbBalance)
        Me.Controls.Add(Me.tbVolume)
        Me.Controls.Add(Me.lbHiddenMusicList)
        Me.Controls.Add(Me.lbDisplayMusicList)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnPlayPause)
        Me.Controls.Add(Me.btnImport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMusicPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Music"
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnPlayPause As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lbDisplayMusicList As System.Windows.Forms.ListBox
    Friend WithEvents lbHiddenMusicList As System.Windows.Forms.ListBox
    Friend WithEvents tbVolume As System.Windows.Forms.TrackBar
    Friend WithEvents tbBalance As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry

End Class
