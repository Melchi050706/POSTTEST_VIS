<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
		Panel1 = New Panel()
		lblHobi = New Label()
		lblKontak = New Label()
		lblKomunitas = New Label()
		lblID = New Label()
		lblNama = New Label()
		picKartu = New PictureBox()
		Panel1.SuspendLayout()
		CType(picKartu, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Panel1
		' 
		Panel1.BackgroundImage = My.Resources.Resources.Kartu_anggota_komunitas_tokusatsu
		Panel1.BackgroundImageLayout = ImageLayout.Stretch
		Panel1.Controls.Add(lblHobi)
		Panel1.Controls.Add(lblKontak)
		Panel1.Controls.Add(lblKomunitas)
		Panel1.Controls.Add(lblID)
		Panel1.Controls.Add(lblNama)
		Panel1.Controls.Add(picKartu)
		Panel1.Location = New Point(2, -1)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(868, 425)
		Panel1.TabIndex = 0
		' 
		' lblHobi
		' 
		lblHobi.AutoSize = True
		lblHobi.BackColor = Color.Transparent
		lblHobi.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHobi.ForeColor = Color.Black
		lblHobi.Location = New Point(363, 220)
		lblHobi.Name = "lblHobi"
		lblHobi.Size = New Size(67, 25)
		lblHobi.TabIndex = 4
		lblHobi.Text = "Label1"
		' 
		' lblKontak
		' 
		lblKontak.AutoSize = True
		lblKontak.BackColor = Color.Transparent
		lblKontak.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblKontak.ForeColor = Color.Black
		lblKontak.Location = New Point(384, 191)
		lblKontak.Name = "lblKontak"
		lblKontak.Size = New Size(67, 25)
		lblKontak.TabIndex = 2
		lblKontak.Text = "Label1"
		' 
		' lblKomunitas
		' 
		lblKomunitas.AutoSize = True
		lblKomunitas.BackColor = Color.Transparent
		lblKomunitas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblKomunitas.ForeColor = Color.Black
		lblKomunitas.Location = New Point(429, 162)
		lblKomunitas.Name = "lblKomunitas"
		lblKomunitas.Size = New Size(67, 25)
		lblKomunitas.TabIndex = 3
		lblKomunitas.Text = "Label1"
		' 
		' lblID
		' 
		lblID.AutoSize = True
		lblID.BackColor = Color.Transparent
		lblID.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblID.ForeColor = Color.Black
		lblID.Location = New Point(350, 133)
		lblID.Name = "lblID"
		lblID.Size = New Size(67, 25)
		lblID.TabIndex = 2
		lblID.Text = "Label1"
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.BackColor = Color.Transparent
		lblNama.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNama.ForeColor = Color.Black
		lblNama.Location = New Point(363, 104)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(67, 25)
		lblNama.TabIndex = 1
		lblNama.Text = "Label1"
		' 
		' picKartu
		' 
		picKartu.BackgroundImageLayout = ImageLayout.Stretch
		picKartu.Location = New Point(43, 111)
		picKartu.Name = "picKartu"
		picKartu.Size = New Size(225, 172)
		picKartu.TabIndex = 0
		picKartu.TabStop = False
		' 
		' Form2
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(872, 426)
		Controls.Add(Panel1)
		Name = "Form2"
		Text = "Form2"
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		CType(picKartu, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents picKartu As PictureBox
	Friend WithEvents lblNama As Label
	Friend WithEvents lblID As Label
	Friend WithEvents lblKomunitas As Label
	Friend WithEvents lblHobi As Label
	Friend WithEvents lblKontak As Label
End Class
