
Public Class Form1
    Dim zaman As Integer = -1
    Dim kalansaat As Integer = 0
    Dim kalandakika As Integer = 0
    Dim kalansaniye As Integer = 0
    Dim islem As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RedemptionCheckBox1.Checked = True
        RedemptionRadioButton1.Checked = True
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub RedemptionButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionButton4.Click
        'NotifyIcon1.Icon = SystemIcons.Application
        NotifyIcon1.BalloonTipTitle = "Oturum Yöneticisi"
        NotifyIcon1.BalloonTipText = "Simge Durumuna küçültüldü"
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        Me.Hide()
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(1000)
        KalanToolStripMenuItem.Text = "..."
        '  ContextMenuStrip1.BackColor = Color.DarkGray
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub AçToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AçToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Me.Show()
    End Sub

    Private Sub RedemptionButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionButton1.Click
        zaman = saniye.Value
        zaman += dakika.Value * 60
        zaman += saat.Value * 3600
        If (zaman <> 0) Then
            Label6.Text = "Aktif"
            Label6.ForeColor = Color.Green
            RedemptionRadioButton1.Enabled = False
            RedemptionRadioButton2.Enabled = False
            RedemptionRadioButton3.Enabled = False
            RedemptionRadioButton4.Enabled = False
            RedemptionRadioButton1.ForeColor = Color.Gray
            RedemptionRadioButton2.ForeColor = Color.Gray
            RedemptionRadioButton3.ForeColor = Color.Gray
            RedemptionRadioButton4.ForeColor = Color.Gray
            RedemptionCheckBox1.Enabled = False
            RedemptionCheckBox1.ForeColor = Color.Gray
            saat.Enabled = False
            dakika.Enabled = False
            saniye.Enabled = False
            Label1.ForeColor = Color.Gray
            Label2.ForeColor = Color.Gray
            Label3.ForeColor = Color.Gray

            RedemptionProgressBar1.Maximum = zaman
            RedemptionProgressBar1.Value = 0
            kalansaat = saat.Value
            kalandakika = dakika.Value
            kalansaniye = saniye.Value
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub RedemptionButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionButton2.Click
        If (zaman <> 0) Then
            If (RedemptionButton2.Text = "Durdur") Then
                RedemptionButton2.Text = "Devam"
                Timer1.Enabled = False
                Label6.Text = "Durduruldu"
                Label6.ForeColor = Color.Gray
                RedemptionRadioButton1.Enabled = True
                RedemptionRadioButton2.Enabled = True
                RedemptionRadioButton3.Enabled = True
                RedemptionRadioButton4.Enabled = True
                RedemptionRadioButton1.ForeColor = Color.White
                RedemptionRadioButton2.ForeColor = Color.White
                RedemptionRadioButton3.ForeColor = Color.White
                RedemptionRadioButton4.ForeColor = Color.White
                RedemptionCheckBox1.Enabled = True
                RedemptionCheckBox1.ForeColor = Color.White
            Else
                Label6.Text = "Aktif"
                Label6.ForeColor = Color.Green
                RedemptionButton2.Text = "Durdur"
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub RedemptionButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionButton3.Click
        If (zaman <> 0) Then
            Timer1.Enabled = False
            zaman = 0
            Label6.Text = "Pasif"
            Label6.ForeColor = Color.Red
            RedemptionRadioButton1.Enabled = True
            RedemptionRadioButton2.Enabled = True
            RedemptionRadioButton3.Enabled = True
            RedemptionRadioButton4.Enabled = True
            RedemptionRadioButton1.ForeColor = Color.White
            RedemptionRadioButton2.ForeColor = Color.White
            RedemptionRadioButton3.ForeColor = Color.White
            RedemptionRadioButton4.ForeColor = Color.White
            RedemptionCheckBox1.Enabled = True
            RedemptionCheckBox1.ForeColor = Color.White
            RedemptionProgressBar1.Value = 0
            Label7.Text = "Kalan :"
            KalanToolStripMenuItem.Text = "..."
            Label8.Text = "%"
            saat.Enabled = True
            dakika.Enabled = True
            saniye.Enabled = True
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
        Else
            Shell("cmd /c shutdown -a")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (zaman > 0) Then
            zaman -= 1
            On Error Resume Next
            RedemptionProgressBar1.Value += 1
            Dim kalan As Double = zaman / 60
            kalan = Math.Round(kalan, 2)
            Dim kalans As String = kalan.ToString
            kalans = kalans.Substring(0, kalans.Length - 3)
            If (kalans = "") Then kalans = "0"
            Label7.Text = "Kalan : " + kalans + " dk " + (zaman Mod 60).ToString + " sn"
            KalanToolStripMenuItem.Text = Label7.Text
            Label8.Text = "%" + Convert.ToInt32(100 / (RedemptionProgressBar1.Maximum / RedemptionProgressBar1.Value)).ToString()
        End If
        If (zaman = 10 And RedemptionCheckBox1.Checked = True) Then
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipText = "Zamanlıyıcının sıfırlanmasına 10 saniye kaldı."
            NotifyIcon1.BalloonTipTitle = "Oturum Yöneticisi"
            NotifyIcon1.ShowBalloonTip(1500)
        End If
        If (zaman = 0) Then
            If (islem = "off") Then Shell("cmd /c shutdown -p")
            If (islem = "restart") Then Shell("cmd /c shutdown -r")
            If (islem = "useroff") Then Shell("cmd /c shutdown -l")
            If (islem = "sleep") Then Shell("cmd /c shutdown -h")

            Timer1.Enabled = False
            Label6.Text = "Pasif"
            Label6.ForeColor = Color.Red
            RedemptionRadioButton1.Enabled = True
            RedemptionRadioButton2.Enabled = True
            RedemptionRadioButton3.Enabled = True
            RedemptionRadioButton4.Enabled = True
            RedemptionRadioButton1.ForeColor = Color.White
            RedemptionRadioButton2.ForeColor = Color.White
            RedemptionRadioButton3.ForeColor = Color.White
            RedemptionRadioButton4.ForeColor = Color.White
            RedemptionCheckBox1.Enabled = True
            RedemptionCheckBox1.ForeColor = Color.White
            saat.Enabled = True
            dakika.Enabled = True
            saniye.Enabled = True
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            RedemptionProgressBar1.Value = 0
            Label8.Text = "%"
            Label7.Text = "Kalan :"
            KalanToolStripMenuItem.Text = "..."
        End If
    End Sub

    Private Sub RedemptionRadioButton1_CheckedChanged(ByVal sender As System.Object) Handles RedemptionRadioButton1.CheckedChanged
        If (RedemptionRadioButton1.Checked = True) Then islem = "off"
    End Sub

    Private Sub RedemptionRadioButton2_CheckedChanged(ByVal sender As System.Object) Handles RedemptionRadioButton2.CheckedChanged
        If (RedemptionRadioButton2.Checked = True) Then islem = "restart"
    End Sub

    Private Sub RedemptionRadioButton4_CheckedChanged(ByVal sender As System.Object) Handles RedemptionRadioButton4.CheckedChanged
        If (RedemptionRadioButton3.Checked = True) Then islem = "useroff"
    End Sub

    Private Sub RedemptionRadioButton3_CheckedChanged(ByVal sender As System.Object) Handles RedemptionRadioButton3.CheckedChanged
        If (RedemptionRadioButton4.Checked = True) Then islem = "sleep"
    End Sub

    Private Sub BaşlatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaşlatToolStripMenuItem.Click
        zaman = saniye.Value
        zaman += dakika.Value * 60
        zaman += saat.Value * 3600
        If (zaman <> 0) Then
            Label6.Text = "Aktif"
            Label6.ForeColor = Color.Green
            RedemptionRadioButton1.Enabled = False
            RedemptionRadioButton2.Enabled = False
            RedemptionRadioButton3.Enabled = False
            RedemptionRadioButton4.Enabled = False
            RedemptionRadioButton1.ForeColor = Color.Gray
            RedemptionRadioButton2.ForeColor = Color.Gray
            RedemptionRadioButton3.ForeColor = Color.Gray
            RedemptionRadioButton4.ForeColor = Color.Gray
            RedemptionCheckBox1.Enabled = False
            RedemptionCheckBox1.ForeColor = Color.Gray
            saat.Enabled = False
            dakika.Enabled = False
            saniye.Enabled = False
            Label1.ForeColor = Color.Gray
            Label2.ForeColor = Color.Gray
            Label3.ForeColor = Color.Gray

            RedemptionProgressBar1.Maximum = zaman
            RedemptionProgressBar1.Value = 0
            kalansaat = saat.Value
            kalandakika = dakika.Value
            kalansaniye = saniye.Value
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub DurdurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DurdurToolStripMenuItem.Click
        If (zaman <> 0) Then
            If (RedemptionButton2.Text = "Durdur") Then
                RedemptionButton2.Text = "Devam"
                Timer1.Enabled = False
                Label6.Text = "Durduruldu"
                Label6.ForeColor = Color.Gray
                RedemptionRadioButton1.Enabled = True
                RedemptionRadioButton2.Enabled = True
                RedemptionRadioButton3.Enabled = True
                RedemptionRadioButton4.Enabled = True
                RedemptionRadioButton1.ForeColor = Color.White
                RedemptionRadioButton2.ForeColor = Color.White
                RedemptionRadioButton3.ForeColor = Color.White
                RedemptionRadioButton4.ForeColor = Color.White
                RedemptionCheckBox1.Enabled = True
                RedemptionCheckBox1.ForeColor = Color.White
            Else
                RedemptionButton2.Text = "Durdur"
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub İptalEtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles İptalEtToolStripMenuItem.Click
        If (zaman <> 0) Then
            Timer1.Enabled = False
            zaman = 0
            Label6.Text = "Pasif"
            Label6.ForeColor = Color.Red
            RedemptionRadioButton1.Enabled = True
            RedemptionRadioButton2.Enabled = True
            RedemptionRadioButton3.Enabled = True
            RedemptionRadioButton4.Enabled = True
            RedemptionRadioButton1.ForeColor = Color.White
            RedemptionRadioButton2.ForeColor = Color.White
            RedemptionRadioButton3.ForeColor = Color.White
            RedemptionRadioButton4.ForeColor = Color.White
            RedemptionCheckBox1.Enabled = True
            RedemptionCheckBox1.ForeColor = Color.White
            RedemptionProgressBar1.Value = 0
            Label7.Text = "Kalan :"
            KalanToolStripMenuItem.Text = "..."
            Label8.Text = "%"
            saat.Enabled = True
            dakika.Enabled = True
            saniye.Enabled = True
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
        Else
            Shell("cmd /c shutdown -a")
        End If
    End Sub
End Class
