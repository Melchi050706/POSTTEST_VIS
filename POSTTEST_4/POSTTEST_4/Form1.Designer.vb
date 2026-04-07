<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
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
		MenuStrip1 = New MenuStrip()
		InputDataToolStripMenuItem = New ToolStripMenuItem()
		LihatKartuToolStripMenuItem = New ToolStripMenuItem()
		SimpanDataToolStripMenuItem = New ToolStripMenuItem()
		BukaDataToolStripMenuItem = New ToolStripMenuItem()
		KeluarToolStripMenuItem = New ToolStripMenuItem()
		Label1 = New Label()
		TabControl1 = New TabControl()
		TabPage1 = New TabPage()
		rbPerempuan = New RadioButton()
		cmbKomunitas = New ComboBox()
		dtpTanggal = New DateTimePicker()
		txtID = New TextBox()
		txtNama = New TextBox()
		rbLaki = New RadioButton()
		Label6 = New Label()
		Label5 = New Label()
		Label4 = New Label()
		Label3 = New Label()
		Label2 = New Label()
		TabPage2 = New TabPage()
		txtAlamat = New TextBox()
		txtEmail = New TextBox()
		mtxtHP = New MaskedTextBox()
		Label9 = New Label()
		Label8 = New Label()
		Label7 = New Label()
		TabPage3 = New TabPage()
		btnBrowse = New Button()
		btnCetak = New Button()
		GroupBoxPeran = New GroupBox()
		rbAnggota = New RadioButton()
		rbAdmin = New RadioButton()
		rbKetua = New RadioButton()
		GroupBoxHobi = New GroupBox()
		cbTraveling = New CheckBox()
		cbDesain = New CheckBox()
		cbFotografi = New CheckBox()
		cbOlahraga = New CheckBox()
		cbMusik = New CheckBox()
		cbCoding = New CheckBox()
		cbGaming = New CheckBox()
		cbMembaca = New CheckBox()
		picFoto = New PictureBox()
		PictureBox1 = New PictureBox()
		OpenFileDialog1 = New OpenFileDialog()
		SaveFileDialog1 = New SaveFileDialog()
		MenuStrip1.SuspendLayout()
		TabControl1.SuspendLayout()
		TabPage1.SuspendLayout()
		TabPage2.SuspendLayout()
		TabPage3.SuspendLayout()
		GroupBoxPeran.SuspendLayout()
		GroupBoxHobi.SuspendLayout()
		CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.ImageScalingSize = New Size(24, 24)
		MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(1064, 33)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' InputDataToolStripMenuItem
		' 
		InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
		InputDataToolStripMenuItem.Size = New Size(112, 29)
		InputDataToolStripMenuItem.Text = "Input Data"
		' 
		' LihatKartuToolStripMenuItem
		' 
		LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
		LihatKartuToolStripMenuItem.Size = New Size(111, 29)
		LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
		' 
		' SimpanDataToolStripMenuItem
		' 
		SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
		SimpanDataToolStripMenuItem.Size = New Size(130, 29)
		SimpanDataToolStripMenuItem.Text = "Simpan Data"
		' 
		' BukaDataToolStripMenuItem
		' 
		BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
		BukaDataToolStripMenuItem.Size = New Size(108, 29)
		BukaDataToolStripMenuItem.Text = "Buka Data"
		' 
		' KeluarToolStripMenuItem
		' 
		KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
		KeluarToolStripMenuItem.Size = New Size(76, 29)
		KeluarToolStripMenuItem.Text = "Keluar"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.Location = New Point(309, 58)
		Label1.Name = "Label1"
		Label1.Size = New Size(476, 45)
		Label1.TabIndex = 1
		Label1.Text = "APLIKASI KARTU KOMUNITAS"
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(TabPage1)
		TabControl1.Controls.Add(TabPage2)
		TabControl1.Controls.Add(TabPage3)
		TabControl1.Location = New Point(12, 179)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(1040, 399)
		TabControl1.TabIndex = 2
		' 
		' TabPage1
		' 
		TabPage1.BackColor = Color.Transparent
		TabPage1.Controls.Add(rbPerempuan)
		TabPage1.Controls.Add(cmbKomunitas)
		TabPage1.Controls.Add(dtpTanggal)
		TabPage1.Controls.Add(txtID)
		TabPage1.Controls.Add(txtNama)
		TabPage1.Controls.Add(rbLaki)
		TabPage1.Controls.Add(Label6)
		TabPage1.Controls.Add(Label5)
		TabPage1.Controls.Add(Label4)
		TabPage1.Controls.Add(Label3)
		TabPage1.Controls.Add(Label2)
		TabPage1.Location = New Point(4, 34)
		TabPage1.Name = "TabPage1"
		TabPage1.Padding = New Padding(3)
		TabPage1.Size = New Size(1032, 361)
		TabPage1.TabIndex = 0
		TabPage1.Text = "Data Utama"
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		rbPerempuan.Location = New Point(469, 208)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(133, 29)
		rbPerempuan.TabIndex = 14
		rbPerempuan.TabStop = True
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' cmbKomunitas
		' 
		cmbKomunitas.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		cmbKomunitas.FormattingEnabled = True
		cmbKomunitas.Items.AddRange(New Object() {"HONKAI STAR RAIL", "WUTHERTING WAVES", "ARKNIGHTS ENFIELD", "MOBILE LEGEND", "PUBG MOBILE"})
		cmbKomunitas.Location = New Point(293, 267)
		cmbKomunitas.Name = "cmbKomunitas"
		cmbKomunitas.Size = New Size(476, 33)
		cmbKomunitas.TabIndex = 13
		' 
		' dtpTanggal
		' 
		dtpTanggal.Location = New Point(293, 145)
		dtpTanggal.Name = "dtpTanggal"
		dtpTanggal.Size = New Size(322, 31)
		dtpTanggal.TabIndex = 11
		' 
		' txtID
		' 
		txtID.Location = New Point(293, 87)
		txtID.Name = "txtID"
		txtID.Size = New Size(476, 31)
		txtID.TabIndex = 10
		' 
		' txtNama
		' 
		txtNama.Location = New Point(293, 27)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(476, 31)
		txtNama.TabIndex = 9
		' 
		' rbLaki
		' 
		rbLaki.AutoSize = True
		rbLaki.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		rbLaki.Location = New Point(293, 208)
		rbLaki.Name = "rbLaki"
		rbLaki.Size = New Size(122, 29)
		rbLaki.TabIndex = 8
		rbLaki.TabStop = True
		rbLaki.Text = "Laki - Laki"
		rbLaki.UseVisualStyleBackColor = True
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label6.Location = New Point(7, 264)
		Label6.Name = "Label6"
		Label6.Size = New Size(137, 32)
		Label6.TabIndex = 4
		Label6.Text = "Komunitas"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label5.Location = New Point(7, 204)
		Label5.Name = "Label5"
		Label5.Size = New Size(171, 32)
		Label5.TabIndex = 3
		Label5.Text = "Jenis Kelamin"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label4.Location = New Point(7, 144)
		Label4.Name = "Label4"
		Label4.Size = New Size(167, 32)
		Label4.TabIndex = 2
		Label4.Text = "Tanggal Lahir"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label3.Location = New Point(7, 84)
		Label3.Name = "Label3"
		Label3.Size = New Size(40, 32)
		Label3.TabIndex = 1
		Label3.Text = "ID"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label2.Location = New Point(7, 24)
		Label2.Name = "Label2"
		Label2.Size = New Size(184, 32)
		Label2.TabIndex = 0
		Label2.Text = "Nama Lengkap"
		' 
		' TabPage2
		' 
		TabPage2.Controls.Add(txtAlamat)
		TabPage2.Controls.Add(txtEmail)
		TabPage2.Controls.Add(mtxtHP)
		TabPage2.Controls.Add(Label9)
		TabPage2.Controls.Add(Label8)
		TabPage2.Controls.Add(Label7)
		TabPage2.Location = New Point(4, 34)
		TabPage2.Name = "TabPage2"
		TabPage2.Padding = New Padding(3)
		TabPage2.Size = New Size(1032, 361)
		TabPage2.TabIndex = 1
		TabPage2.Text = "Kontak & Info"
		TabPage2.UseVisualStyleBackColor = True
		' 
		' txtAlamat
		' 
		txtAlamat.Location = New Point(293, 231)
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(476, 31)
		txtAlamat.TabIndex = 6
		' 
		' txtEmail
		' 
		txtEmail.Location = New Point(293, 131)
		txtEmail.Name = "txtEmail"
		txtEmail.Size = New Size(476, 31)
		txtEmail.TabIndex = 5
		' 
		' mtxtHP
		' 
		mtxtHP.Location = New Point(293, 31)
		mtxtHP.Mask = "0000-0000-0000"
		mtxtHP.Name = "mtxtHP"
		mtxtHP.Size = New Size(106, 31)
		mtxtHP.TabIndex = 4
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label9.Location = New Point(7, 228)
		Label9.Name = "Label9"
		Label9.Size = New Size(95, 32)
		Label9.TabIndex = 3
		Label9.Text = "Alamat"
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label8.Location = New Point(7, 128)
		Label8.Name = "Label8"
		Label8.Size = New Size(87, 32)
		Label8.TabIndex = 2
		Label8.Text = "EMAIL"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label7.Location = New Point(6, 28)
		Label7.Name = "Label7"
		Label7.Size = New Size(192, 32)
		Label7.TabIndex = 1
		Label7.Text = "Nomor Telepon"
		' 
		' TabPage3
		' 
		TabPage3.Controls.Add(btnBrowse)
		TabPage3.Controls.Add(btnCetak)
		TabPage3.Controls.Add(GroupBoxPeran)
		TabPage3.Controls.Add(GroupBoxHobi)
		TabPage3.Controls.Add(picFoto)
		TabPage3.Location = New Point(4, 34)
		TabPage3.Name = "TabPage3"
		TabPage3.Padding = New Padding(3)
		TabPage3.Size = New Size(1032, 361)
		TabPage3.TabIndex = 2
		TabPage3.Text = "Profil & Aktivitas"
		TabPage3.UseVisualStyleBackColor = True
		' 
		' btnBrowse
		' 
		btnBrowse.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnBrowse.Location = New Point(33, 309)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(250, 34)
		btnBrowse.TabIndex = 5
		btnBrowse.Text = "BROWSE"
		btnBrowse.UseVisualStyleBackColor = True
		' 
		' btnCetak
		' 
		btnCetak.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnCetak.Location = New Point(331, 309)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(678, 34)
		btnCetak.TabIndex = 4
		btnCetak.Text = "CETAK"
		btnCetak.UseVisualStyleBackColor = True
		' 
		' GroupBoxPeran
		' 
		GroupBoxPeran.Controls.Add(rbAnggota)
		GroupBoxPeran.Controls.Add(rbAdmin)
		GroupBoxPeran.Controls.Add(rbKetua)
		GroupBoxPeran.Location = New Point(711, 33)
		GroupBoxPeran.Name = "GroupBoxPeran"
		GroupBoxPeran.Size = New Size(298, 250)
		GroupBoxPeran.TabIndex = 3
		GroupBoxPeran.TabStop = False
		GroupBoxPeran.Text = "Peran"
		' 
		' rbAnggota
		' 
		rbAnggota.AutoSize = True
		rbAnggota.Location = New Point(6, 139)
		rbAnggota.Name = "rbAnggota"
		rbAnggota.Size = New Size(107, 29)
		rbAnggota.TabIndex = 2
		rbAnggota.TabStop = True
		rbAnggota.Text = "Anggota"
		rbAnggota.UseVisualStyleBackColor = True
		' 
		' rbAdmin
		' 
		rbAdmin.AutoSize = True
		rbAdmin.Location = New Point(6, 90)
		rbAdmin.Name = "rbAdmin"
		rbAdmin.Size = New Size(90, 29)
		rbAdmin.TabIndex = 1
		rbAdmin.TabStop = True
		rbAdmin.Text = "Admin"
		rbAdmin.UseVisualStyleBackColor = True
		' 
		' rbKetua
		' 
		rbKetua.AutoSize = True
		rbKetua.Location = New Point(6, 39)
		rbKetua.Name = "rbKetua"
		rbKetua.Size = New Size(81, 29)
		rbKetua.TabIndex = 0
		rbKetua.TabStop = True
		rbKetua.Text = "Ketua"
		rbKetua.UseVisualStyleBackColor = True
		' 
		' GroupBoxHobi
		' 
		GroupBoxHobi.Controls.Add(cbTraveling)
		GroupBoxHobi.Controls.Add(cbDesain)
		GroupBoxHobi.Controls.Add(cbFotografi)
		GroupBoxHobi.Controls.Add(cbOlahraga)
		GroupBoxHobi.Controls.Add(cbMusik)
		GroupBoxHobi.Controls.Add(cbCoding)
		GroupBoxHobi.Controls.Add(cbGaming)
		GroupBoxHobi.Controls.Add(cbMembaca)
		GroupBoxHobi.Location = New Point(331, 33)
		GroupBoxHobi.Name = "GroupBoxHobi"
		GroupBoxHobi.Size = New Size(298, 250)
		GroupBoxHobi.TabIndex = 2
		GroupBoxHobi.TabStop = False
		GroupBoxHobi.Text = "Hobby"
		' 
		' cbTraveling
		' 
		cbTraveling.AutoSize = True
		cbTraveling.Location = New Point(168, 90)
		cbTraveling.Name = "cbTraveling"
		cbTraveling.Size = New Size(107, 29)
		cbTraveling.TabIndex = 8
		cbTraveling.Text = "Traveling"
		cbTraveling.UseVisualStyleBackColor = True
		' 
		' cbDesain
		' 
		cbDesain.AutoSize = True
		cbDesain.Location = New Point(168, 190)
		cbDesain.Name = "cbDesain"
		cbDesain.Size = New Size(91, 29)
		cbDesain.TabIndex = 7
		cbDesain.Text = "Desain"
		cbDesain.UseVisualStyleBackColor = True
		' 
		' cbFotografi
		' 
		cbFotografi.AutoSize = True
		cbFotografi.Location = New Point(168, 140)
		cbFotografi.Name = "cbFotografi"
		cbFotografi.Size = New Size(111, 29)
		cbFotografi.TabIndex = 6
		cbFotografi.Text = "Fotografi"
		cbFotografi.UseVisualStyleBackColor = True
		' 
		' cbOlahraga
		' 
		cbOlahraga.AutoSize = True
		cbOlahraga.Location = New Point(168, 40)
		cbOlahraga.Name = "cbOlahraga"
		cbOlahraga.Size = New Size(110, 29)
		cbOlahraga.TabIndex = 4
		cbOlahraga.Text = "Olahraga"
		cbOlahraga.UseVisualStyleBackColor = True
		' 
		' cbMusik
		' 
		cbMusik.AutoSize = True
		cbMusik.Location = New Point(6, 190)
		cbMusik.Name = "cbMusik"
		cbMusik.Size = New Size(85, 29)
		cbMusik.TabIndex = 3
		cbMusik.Text = "Musik"
		cbMusik.UseVisualStyleBackColor = True
		' 
		' cbCoding
		' 
		cbCoding.AutoSize = True
		cbCoding.Location = New Point(6, 140)
		cbCoding.Name = "cbCoding"
		cbCoding.Size = New Size(96, 29)
		cbCoding.TabIndex = 2
		cbCoding.Text = "Coding"
		cbCoding.UseVisualStyleBackColor = True
		' 
		' cbGaming
		' 
		cbGaming.AutoSize = True
		cbGaming.Location = New Point(6, 90)
		cbGaming.Name = "cbGaming"
		cbGaming.Size = New Size(100, 29)
		cbGaming.TabIndex = 1
		cbGaming.Text = "Gaming"
		cbGaming.UseVisualStyleBackColor = True
		' 
		' cbMembaca
		' 
		cbMembaca.AutoSize = True
		cbMembaca.Location = New Point(6, 40)
		cbMembaca.Name = "cbMembaca"
		cbMembaca.Size = New Size(116, 29)
		cbMembaca.TabIndex = 0
		cbMembaca.Text = "Membaca"
		cbMembaca.UseVisualStyleBackColor = True
		' 
		' picFoto
		' 
		picFoto.BackColor = Color.DimGray
		picFoto.BackgroundImageLayout = ImageLayout.Stretch
		picFoto.Location = New Point(33, 33)
		picFoto.Name = "picFoto"
		picFoto.Size = New Size(250, 250)
		picFoto.TabIndex = 0
		picFoto.TabStop = False
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = SystemColors.ActiveBorder
		PictureBox1.BackgroundImage = My.Resources.Resources.Kise_Ryouta_Cat
		PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
		PictureBox1.Location = New Point(23, 48)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(125, 125)
		PictureBox1.TabIndex = 3
		PictureBox1.TabStop = False
		' 
		' OpenFileDialog1
		' 
		OpenFileDialog1.FileName = "OpenFileDialog1"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10.0F, 25.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(1064, 670)
		Controls.Add(PictureBox1)
		Controls.Add(TabControl1)
		Controls.Add(Label1)
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "Form1"
		Text = "Form1"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		TabControl1.ResumeLayout(False)
		TabPage1.ResumeLayout(False)
		TabPage1.PerformLayout()
		TabPage2.ResumeLayout(False)
		TabPage2.PerformLayout()
		TabPage3.ResumeLayout(False)
		GroupBoxPeran.ResumeLayout(False)
		GroupBoxPeran.PerformLayout()
		GroupBoxHobi.ResumeLayout(False)
		GroupBoxHobi.PerformLayout()
		CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Label1 As Label
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents rbLaki As RadioButton
	Friend WithEvents cmbKomunitas As ComboBox
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents dtpTanggal As DateTimePicker
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtNama As TextBox
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents mtxtHP As MaskedTextBox
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents Button1 As Button
	Friend WithEvents picFoto As PictureBox
	Friend WithEvents GroupBoxPeran As GroupBox
	Friend WithEvents GroupBoxHobi As GroupBox
	Friend WithEvents btnCetak As Button
	Friend WithEvents btnBrowse As Button
	Friend WithEvents cbDesain As CheckBox
	Friend WithEvents cbFotografi As CheckBox
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents cbOlahraga As CheckBox
	Friend WithEvents cbMusik As CheckBox
	Friend WithEvents cbCoding As CheckBox
	Friend WithEvents cbGaming As CheckBox
	Friend WithEvents cbMembaca As CheckBox
	Friend WithEvents cbTraveling As CheckBox
	Friend WithEvents rbAnggota As RadioButton
	Friend WithEvents rbAdmin As RadioButton
	Friend WithEvents rbKetua As RadioButton
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
