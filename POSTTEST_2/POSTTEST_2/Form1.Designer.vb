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
		GroupBox1 = New GroupBox()
		btnTambah = New Button()
		txtGenre = New TextBox()
		txtJudul = New TextBox()
		Label2 = New Label()
		Label1 = New Label()
		GroupBox2 = New GroupBox()
		btnHapus = New Button()
		txtHapus = New TextBox()
		Label3 = New Label()
		lstBuku = New ListBox()
		GroupBox1.SuspendLayout()
		GroupBox2.SuspendLayout()
		SuspendLayout()
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(btnTambah)
		GroupBox1.Controls.Add(txtGenre)
		GroupBox1.Controls.Add(txtJudul)
		GroupBox1.Controls.Add(Label2)
		GroupBox1.Controls.Add(Label1)
		GroupBox1.Location = New Point(12, 47)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(342, 237)
		GroupBox1.TabIndex = 0
		GroupBox1.TabStop = False
		GroupBox1.Text = "Tambah Buku"
		' 
		' btnTambah
		' 
		btnTambah.Location = New Point(206, 186)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(113, 35)
		btnTambah.TabIndex = 4
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = True
		' 
		' txtGenre
		' 
		txtGenre.Location = New Point(134, 125)
		txtGenre.Name = "txtGenre"
		txtGenre.Size = New Size(181, 31)
		txtGenre.TabIndex = 3
		' 
		' txtJudul
		' 
		txtJudul.Location = New Point(134, 49)
		txtJudul.Name = "txtJudul"
		txtJudul.Size = New Size(181, 31)
		txtJudul.TabIndex = 2
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(6, 131)
		Label2.Name = "Label2"
		Label2.Size = New Size(58, 25)
		Label2.TabIndex = 1
		Label2.Text = "Genre"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(6, 52)
		Label1.Name = "Label1"
		Label1.Size = New Size(97, 25)
		Label1.TabIndex = 0
		Label1.Text = "Judul Buku"
		' 
		' GroupBox2
		' 
		GroupBox2.Controls.Add(btnHapus)
		GroupBox2.Controls.Add(txtHapus)
		GroupBox2.Controls.Add(Label3)
		GroupBox2.Location = New Point(446, 47)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(342, 237)
		GroupBox2.TabIndex = 1
		GroupBox2.TabStop = False
		GroupBox2.Text = "HapusBuku"
		' 
		' btnHapus
		' 
		btnHapus.Location = New Point(206, 186)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(113, 35)
		btnHapus.TabIndex = 5
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = True
		' 
		' txtHapus
		' 
		txtHapus.Location = New Point(134, 49)
		txtHapus.Name = "txtHapus"
		txtHapus.Size = New Size(181, 31)
		txtHapus.TabIndex = 4
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(6, 52)
		Label3.Name = "Label3"
		Label3.Size = New Size(97, 25)
		Label3.TabIndex = 2
		Label3.Text = "Judul Buku"
		' 
		' lstBuku
		' 
		lstBuku.FormattingEnabled = True
		lstBuku.Location = New Point(159, 314)
		lstBuku.Name = "lstBuku"
		lstBuku.Size = New Size(470, 254)
		lstBuku.TabIndex = 2
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(807, 632)
		Controls.Add(lstBuku)
		Controls.Add(GroupBox2)
		Controls.Add(GroupBox1)
		Name = "Form1"
		Text = "Form1"
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		ResumeLayout(False)
	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents btnTambah As Button
	Friend WithEvents txtGenre As TextBox
	Friend WithEvents txtJudul As TextBox
	Friend WithEvents btnHapus As Button
	Friend WithEvents txtHapus As TextBox
	Friend WithEvents lstBuku As ListBox

End Class
