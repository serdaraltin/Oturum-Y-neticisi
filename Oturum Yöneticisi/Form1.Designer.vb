<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KalanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BaşlatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DurdurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.İptalEtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedemptionTabControl1 = New Oturum_Yöneticisi.RedemptionTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RedemptionButton4 = New Oturum_Yöneticisi.RedemptionButton()
        Me.RedemptionRadioButton4 = New Oturum_Yöneticisi.RedemptionRadioButton()
        Me.RedemptionRadioButton3 = New Oturum_Yöneticisi.RedemptionRadioButton()
        Me.RedemptionRadioButton2 = New Oturum_Yöneticisi.RedemptionRadioButton()
        Me.RedemptionRadioButton1 = New Oturum_Yöneticisi.RedemptionRadioButton()
        Me.RedemptionButton3 = New Oturum_Yöneticisi.RedemptionButton()
        Me.RedemptionButton2 = New Oturum_Yöneticisi.RedemptionButton()
        Me.RedemptionButton1 = New Oturum_Yöneticisi.RedemptionButton()
        Me.RedemptionProgressBar1 = New Oturum_Yöneticisi.RedemptionProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.saniye = New Oturum_Yöneticisi.RedemptionNumericUpDown()
        Me.dakika = New Oturum_Yöneticisi.RedemptionNumericUpDown()
        Me.saat = New Oturum_Yöneticisi.RedemptionNumericUpDown()
        Me.RedemptionCheckBox1 = New Oturum_Yöneticisi.RedemptionCheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.RedemptionTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Oturum Yöneticisi"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KalanToolStripMenuItem, Me.AçToolStripMenuItem, Me.ToolStripSeparator1, Me.BaşlatToolStripMenuItem, Me.DurdurToolStripMenuItem, Me.İptalEtToolStripMenuItem, Me.ToolStripSeparator2, Me.ÇıkışToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(112, 148)
        '
        'KalanToolStripMenuItem
        '
        Me.KalanToolStripMenuItem.Name = "KalanToolStripMenuItem"
        Me.KalanToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.KalanToolStripMenuItem.Text = "Kalan :"
        '
        'AçToolStripMenuItem
        '
        Me.AçToolStripMenuItem.Name = "AçToolStripMenuItem"
        Me.AçToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AçToolStripMenuItem.Text = "Göster"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(108, 6)
        '
        'BaşlatToolStripMenuItem
        '
        Me.BaşlatToolStripMenuItem.Name = "BaşlatToolStripMenuItem"
        Me.BaşlatToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.BaşlatToolStripMenuItem.Text = "Başlat"
        '
        'DurdurToolStripMenuItem
        '
        Me.DurdurToolStripMenuItem.Name = "DurdurToolStripMenuItem"
        Me.DurdurToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.DurdurToolStripMenuItem.Text = "Durdur"
        '
        'İptalEtToolStripMenuItem
        '
        Me.İptalEtToolStripMenuItem.Name = "İptalEtToolStripMenuItem"
        Me.İptalEtToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.İptalEtToolStripMenuItem.Text = "İptal Et"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(108, 6)
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'RedemptionTabControl1
        '
        Me.RedemptionTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.RedemptionTabControl1.Controls.Add(Me.TabPage1)
        Me.RedemptionTabControl1.Controls.Add(Me.TabPage2)
        Me.RedemptionTabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionTabControl1.ItemSize = New System.Drawing.Size(35, 100)
        Me.RedemptionTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.RedemptionTabControl1.Multiline = True
        Me.RedemptionTabControl1.Name = "RedemptionTabControl1"
        Me.RedemptionTabControl1.SelectedIndex = 0
        Me.RedemptionTabControl1.Size = New System.Drawing.Size(378, 252)
        Me.RedemptionTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.RedemptionTabControl1.TabIndex = 0
        Me.RedemptionTabControl1.TextAlign = Oturum_Yöneticisi.RedemptionTabControl.HorizontalAlignments.Left
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.RedemptionButton4)
        Me.TabPage1.Controls.Add(Me.RedemptionRadioButton4)
        Me.TabPage1.Controls.Add(Me.RedemptionRadioButton3)
        Me.TabPage1.Controls.Add(Me.RedemptionRadioButton2)
        Me.TabPage1.Controls.Add(Me.RedemptionRadioButton1)
        Me.TabPage1.Controls.Add(Me.RedemptionButton3)
        Me.TabPage1.Controls.Add(Me.RedemptionButton2)
        Me.TabPage1.Controls.Add(Me.RedemptionButton1)
        Me.TabPage1.Controls.Add(Me.RedemptionProgressBar1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.saniye)
        Me.TabPage1.Controls.Add(Me.dakika)
        Me.TabPage1.Controls.Add(Me.saat)
        Me.TabPage1.Controls.Add(Me.RedemptionCheckBox1)
        Me.TabPage1.Location = New System.Drawing.Point(104, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(270, 244)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Zamanlayıcı"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(223, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Kalan : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(56, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Pasif"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Durum :"
        '
        'RedemptionButton4
        '
        Me.RedemptionButton4.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton4.Location = New System.Drawing.Point(228, 3)
        Me.RedemptionButton4.Name = "RedemptionButton4"
        Me.RedemptionButton4.Size = New System.Drawing.Size(40, 17)
        Me.RedemptionButton4.TabIndex = 15
        Me.RedemptionButton4.Text = ">"
        Me.RedemptionButton4.TextAlign = Oturum_Yöneticisi.RedemptionButton.HorizontalAlignment.Center
        '
        'RedemptionRadioButton4
        '
        Me.RedemptionRadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionRadioButton4.Checked = False
        Me.RedemptionRadioButton4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionRadioButton4.ForeColor = System.Drawing.Color.White
        Me.RedemptionRadioButton4.Location = New System.Drawing.Point(144, 82)
        Me.RedemptionRadioButton4.Name = "RedemptionRadioButton4"
        Me.RedemptionRadioButton4.Size = New System.Drawing.Size(111, 19)
        Me.RedemptionRadioButton4.TabIndex = 14
        Me.RedemptionRadioButton4.Text = "Oturumu Kapat"
        '
        'RedemptionRadioButton3
        '
        Me.RedemptionRadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionRadioButton3.Checked = False
        Me.RedemptionRadioButton3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionRadioButton3.ForeColor = System.Drawing.Color.White
        Me.RedemptionRadioButton3.Location = New System.Drawing.Point(144, 107)
        Me.RedemptionRadioButton3.Name = "RedemptionRadioButton3"
        Me.RedemptionRadioButton3.Size = New System.Drawing.Size(107, 19)
        Me.RedemptionRadioButton3.TabIndex = 13
        Me.RedemptionRadioButton3.Text = "Hazırda Beklet"
        '
        'RedemptionRadioButton2
        '
        Me.RedemptionRadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionRadioButton2.Checked = False
        Me.RedemptionRadioButton2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionRadioButton2.ForeColor = System.Drawing.Color.White
        Me.RedemptionRadioButton2.Location = New System.Drawing.Point(17, 107)
        Me.RedemptionRadioButton2.Name = "RedemptionRadioButton2"
        Me.RedemptionRadioButton2.Size = New System.Drawing.Size(110, 19)
        Me.RedemptionRadioButton2.TabIndex = 12
        Me.RedemptionRadioButton2.Text = "Yeniden Başlat"
        '
        'RedemptionRadioButton1
        '
        Me.RedemptionRadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionRadioButton1.Checked = False
        Me.RedemptionRadioButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionRadioButton1.ForeColor = System.Drawing.Color.White
        Me.RedemptionRadioButton1.Location = New System.Drawing.Point(17, 82)
        Me.RedemptionRadioButton1.Name = "RedemptionRadioButton1"
        Me.RedemptionRadioButton1.Size = New System.Drawing.Size(121, 19)
        Me.RedemptionRadioButton1.TabIndex = 11
        Me.RedemptionRadioButton1.Text = "Bilgisayarı Kapat"
        '
        'RedemptionButton3
        '
        Me.RedemptionButton3.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton3.Location = New System.Drawing.Point(181, 165)
        Me.RedemptionButton3.Name = "RedemptionButton3"
        Me.RedemptionButton3.Size = New System.Drawing.Size(79, 28)
        Me.RedemptionButton3.TabIndex = 10
        Me.RedemptionButton3.Text = "İptal Et"
        Me.RedemptionButton3.TextAlign = Oturum_Yöneticisi.RedemptionButton.HorizontalAlignment.Center
        '
        'RedemptionButton2
        '
        Me.RedemptionButton2.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton2.Location = New System.Drawing.Point(96, 165)
        Me.RedemptionButton2.Name = "RedemptionButton2"
        Me.RedemptionButton2.Size = New System.Drawing.Size(79, 28)
        Me.RedemptionButton2.TabIndex = 9
        Me.RedemptionButton2.Text = "Durdur"
        Me.RedemptionButton2.TextAlign = Oturum_Yöneticisi.RedemptionButton.HorizontalAlignment.Center
        '
        'RedemptionButton1
        '
        Me.RedemptionButton1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionButton1.Location = New System.Drawing.Point(11, 165)
        Me.RedemptionButton1.Name = "RedemptionButton1"
        Me.RedemptionButton1.Size = New System.Drawing.Size(79, 28)
        Me.RedemptionButton1.TabIndex = 8
        Me.RedemptionButton1.Text = "Başlat"
        Me.RedemptionButton1.TextAlign = Oturum_Yöneticisi.RedemptionButton.HorizontalAlignment.Center
        '
        'RedemptionProgressBar1
        '
        Me.RedemptionProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionProgressBar1.Location = New System.Drawing.Point(6, 216)
        Me.RedemptionProgressBar1.Maximum = 100
        Me.RedemptionProgressBar1.Name = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Size = New System.Drawing.Size(255, 23)
        Me.RedemptionProgressBar1.TabIndex = 7
        Me.RedemptionProgressBar1.Text = "RedemptionProgressBar1"
        Me.RedemptionProgressBar1.Value = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(171, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Saniye"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(113, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dakika"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Saat"
        '
        'saniye
        '
        Me.saniye.BackColor = System.Drawing.Color.Transparent
        Me.saniye.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.saniye.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.saniye.ForeColor = System.Drawing.Color.White
        Me.saniye.Location = New System.Drawing.Point(166, 43)
        Me.saniye.Maximum = CType(59, Long)
        Me.saniye.Minimum = CType(0, Long)
        Me.saniye.Name = "saniye"
        Me.saniye.Size = New System.Drawing.Size(52, 26)
        Me.saniye.TabIndex = 3
        Me.saniye.Text = "RedemptionNumericUpDown3"
        Me.saniye.Value = CType(0, Long)
        '
        'dakika
        '
        Me.dakika.BackColor = System.Drawing.Color.Transparent
        Me.dakika.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dakika.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dakika.ForeColor = System.Drawing.Color.White
        Me.dakika.Location = New System.Drawing.Point(108, 43)
        Me.dakika.Maximum = CType(59, Long)
        Me.dakika.Minimum = CType(0, Long)
        Me.dakika.Name = "dakika"
        Me.dakika.Size = New System.Drawing.Size(52, 26)
        Me.dakika.TabIndex = 2
        Me.dakika.Text = "RedemptionNumericUpDown2"
        Me.dakika.Value = CType(0, Long)
        '
        'saat
        '
        Me.saat.BackColor = System.Drawing.Color.Transparent
        Me.saat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.saat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.saat.ForeColor = System.Drawing.Color.White
        Me.saat.Location = New System.Drawing.Point(50, 43)
        Me.saat.Maximum = CType(84, Long)
        Me.saat.Minimum = CType(0, Long)
        Me.saat.Name = "saat"
        Me.saat.Size = New System.Drawing.Size(52, 26)
        Me.saat.TabIndex = 1
        Me.saat.Text = "RedemptionNumericUpDown1"
        Me.saat.Value = CType(0, Long)
        '
        'RedemptionCheckBox1
        '
        Me.RedemptionCheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionCheckBox1.Checked = False
        Me.RedemptionCheckBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionCheckBox1.ForeColor = System.Drawing.Color.White
        Me.RedemptionCheckBox1.Location = New System.Drawing.Point(17, 140)
        Me.RedemptionCheckBox1.Name = "RedemptionCheckBox1"
        Me.RedemptionCheckBox1.Size = New System.Drawing.Size(95, 19)
        Me.RedemptionCheckBox1.TabIndex = 0
        Me.RedemptionCheckBox1.Text = "Uyarı Mesajı"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(104, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(270, 244)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hakkında"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(2, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 228)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Oturum Yöneticisi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zaman ayarlı oturum yönetimi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "üçüncü parti yazılımı." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powe" & _
            "red By DeadSound" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Corporation DeSo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                    " & _
            "Build : 2017.04.16"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(377, 252)
        Me.Controls.Add(Me.RedemptionTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oturum Yöneticisi"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.RedemptionTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RedemptionTabControl1 As Oturum_Yöneticisi.RedemptionTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents saniye As Oturum_Yöneticisi.RedemptionNumericUpDown
    Friend WithEvents dakika As Oturum_Yöneticisi.RedemptionNumericUpDown
    Friend WithEvents saat As Oturum_Yöneticisi.RedemptionNumericUpDown
    Friend WithEvents RedemptionCheckBox1 As Oturum_Yöneticisi.RedemptionCheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RedemptionProgressBar1 As Oturum_Yöneticisi.RedemptionProgressBar
    Friend WithEvents RedemptionButton1 As Oturum_Yöneticisi.RedemptionButton
    Friend WithEvents RedemptionRadioButton4 As Oturum_Yöneticisi.RedemptionRadioButton
    Friend WithEvents RedemptionRadioButton3 As Oturum_Yöneticisi.RedemptionRadioButton
    Friend WithEvents RedemptionRadioButton2 As Oturum_Yöneticisi.RedemptionRadioButton
    Friend WithEvents RedemptionRadioButton1 As Oturum_Yöneticisi.RedemptionRadioButton
    Friend WithEvents RedemptionButton3 As Oturum_Yöneticisi.RedemptionButton
    Friend WithEvents RedemptionButton2 As Oturum_Yöneticisi.RedemptionButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RedemptionButton4 As Oturum_Yöneticisi.RedemptionButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AçToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DurdurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents İptalEtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ÇıkışToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaşlatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents KalanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
