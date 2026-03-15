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
		Me.picFoto = New System.Windows.Forms.PictureBox()
		Me.lblNama = New System.Windows.Forms.Label()
		Me.lblUmur = New System.Windows.Forms.Label()
		Me.lblTanggal = New System.Windows.Forms.Label()
		Me.lblJK = New System.Windows.Forms.Label()
		Me.lblTelp = New System.Windows.Forms.Label()
		Me.lblAlamat = New System.Windows.Forms.Label()
		Me.lblHobby = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'picFoto
		'
		Me.picFoto.Location = New System.Drawing.Point(48, 142)
		Me.picFoto.Name = "picFoto"
		Me.picFoto.Size = New System.Drawing.Size(255, 225)
		Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picFoto.TabIndex = 0
		Me.picFoto.TabStop = False
		'
		'lblNama
		'
		Me.lblNama.AutoSize = True
		Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNama.Location = New System.Drawing.Point(570, 142)
		Me.lblNama.Name = "lblNama"
		Me.lblNama.Size = New System.Drawing.Size(70, 22)
		Me.lblNama.TabIndex = 1
		Me.lblNama.Text = "Label1"
		'
		'lblUmur
		'
		Me.lblUmur.AutoSize = True
		Me.lblUmur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUmur.Location = New System.Drawing.Point(570, 181)
		Me.lblUmur.Name = "lblUmur"
		Me.lblUmur.Size = New System.Drawing.Size(70, 22)
		Me.lblUmur.TabIndex = 2
		Me.lblUmur.Text = "Label1"
		'
		'lblTanggal
		'
		Me.lblTanggal.AutoSize = True
		Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTanggal.Location = New System.Drawing.Point(570, 216)
		Me.lblTanggal.Name = "lblTanggal"
		Me.lblTanggal.Size = New System.Drawing.Size(70, 22)
		Me.lblTanggal.TabIndex = 3
		Me.lblTanggal.Text = "Label2"
		'
		'lblJK
		'
		Me.lblJK.AutoSize = True
		Me.lblJK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJK.Location = New System.Drawing.Point(570, 255)
		Me.lblJK.Name = "lblJK"
		Me.lblJK.Size = New System.Drawing.Size(70, 22)
		Me.lblJK.TabIndex = 4
		Me.lblJK.Text = "Label2"
		'
		'lblTelp
		'
		Me.lblTelp.AutoSize = True
		Me.lblTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTelp.Location = New System.Drawing.Point(570, 294)
		Me.lblTelp.Name = "lblTelp"
		Me.lblTelp.Size = New System.Drawing.Size(70, 22)
		Me.lblTelp.TabIndex = 5
		Me.lblTelp.Text = "Label2"
		'
		'lblAlamat
		'
		Me.lblAlamat.AutoSize = True
		Me.lblAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAlamat.Location = New System.Drawing.Point(570, 362)
		Me.lblAlamat.Name = "lblAlamat"
		Me.lblAlamat.Size = New System.Drawing.Size(70, 22)
		Me.lblAlamat.TabIndex = 6
		Me.lblAlamat.Text = "Label2"
		'
		'lblHobby
		'
		Me.lblHobby.AutoSize = True
		Me.lblHobby.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHobby.Location = New System.Drawing.Point(570, 329)
		Me.lblHobby.Name = "lblHobby"
		Me.lblHobby.Size = New System.Drawing.Size(70, 22)
		Me.lblHobby.TabIndex = 7
		Me.lblHobby.Text = "Label2"
		'
		'Panel1
		'
		Me.Panel1.BackgroundImage = Global.POSTTEST_3.My.Resources.Resources.ChatGPT_Image_15_Mar_2026__18_05_10
		Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel1.Controls.Add(Me.lblNama)
		Me.Panel1.Controls.Add(Me.picFoto)
		Me.Panel1.Controls.Add(Me.lblHobby)
		Me.Panel1.Controls.Add(Me.lblUmur)
		Me.Panel1.Controls.Add(Me.lblAlamat)
		Me.Panel1.Controls.Add(Me.lblTanggal)
		Me.Panel1.Controls.Add(Me.lblTelp)
		Me.Panel1.Controls.Add(Me.lblJK)
		Me.Panel1.Location = New System.Drawing.Point(1, 6)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(978, 544)
		Me.Panel1.TabIndex = 8
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(982, 557)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "Form2"
		Me.Text = "Form2"
		CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents picFoto As PictureBox
	Friend WithEvents lblNama As Label
	Friend WithEvents lblUmur As Label
	Friend WithEvents lblTanggal As Label
	Friend WithEvents lblJK As Label
	Friend WithEvents lblTelp As Label
	Friend WithEvents lblAlamat As Label
	Friend WithEvents lblHobby As Label
	Friend WithEvents Panel1 As Panel
End Class
