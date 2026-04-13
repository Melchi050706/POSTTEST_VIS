<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
		dgvKarakter = New DataGridView()
		Label1 = New Label()
		txtSearch = New TextBox()
		Label2 = New Label()
		btnTambah = New Button()
		btnHapus = New Button()
		CType(dgvKarakter, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' dgvKarakter
		' 
		dgvKarakter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvKarakter.Location = New Point(12, 210)
		dgvKarakter.Name = "dgvKarakter"
		dgvKarakter.RowHeadersWidth = 62
		dgvKarakter.Size = New Size(562, 228)
		dgvKarakter.TabIndex = 0
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(12, 79)
		Label1.Name = "Label1"
		Label1.Size = New Size(42, 25)
		Label1.TabIndex = 1
		Label1.Text = "Cari"
		' 
		' txtSearch
		' 
		txtSearch.Location = New Point(105, 76)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(469, 31)
		txtSearch.TabIndex = 2
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(115, 22)
		Label2.Name = "Label2"
		Label2.Size = New Size(370, 25)
		Label2.TabIndex = 3
		Label2.Text = "PENDATAAN KARAKTER WUTHERING WAVES"
		' 
		' btnTambah
		' 
		btnTambah.Location = New Point(12, 155)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(250, 34)
		btnTambah.TabIndex = 4
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = True
		' 
		' btnHapus
		' 
		btnHapus.Location = New Point(324, 155)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(250, 34)
		btnHapus.TabIndex = 5
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = True
		' 
		' FormUtama
		' 
		AutoScaleDimensions = New SizeF(10.0F, 25.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(586, 450)
		Controls.Add(btnHapus)
		Controls.Add(btnTambah)
		Controls.Add(Label2)
		Controls.Add(txtSearch)
		Controls.Add(Label1)
		Controls.Add(dgvKarakter)
		Name = "FormUtama"
		Text = "Form1"
		CType(dgvKarakter, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents dgvKarakter As DataGridView
	Friend WithEvents Label1 As Label
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnHapus As Button

End Class
