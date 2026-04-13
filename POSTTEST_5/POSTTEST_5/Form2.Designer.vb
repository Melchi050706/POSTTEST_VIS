<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInput
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		txtID = New TextBox()
		txtNama = New TextBox()
		txtElemen = New TextBox()
		txtRarity = New TextBox()
		txtSenjata = New TextBox()
		btnSimpan = New Button()
		btnBatal = New Button()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(12, 56)
		Label1.Name = "Label1"
		Label1.Size = New Size(30, 25)
		Label1.TabIndex = 0
		Label1.Text = "ID"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(12, 106)
		Label2.Name = "Label2"
		Label2.Size = New Size(59, 25)
		Label2.TabIndex = 1
		Label2.Text = "Nama"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(12, 156)
		Label3.Name = "Label3"
		Label3.Size = New Size(69, 25)
		Label3.TabIndex = 2
		Label3.Text = "Elemen"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(12, 206)
		Label4.Name = "Label4"
		Label4.Size = New Size(57, 25)
		Label4.TabIndex = 3
		Label4.Text = "Rarity"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(12, 256)
		Label5.Name = "Label5"
		Label5.Size = New Size(69, 25)
		Label5.TabIndex = 4
		Label5.Text = "Senjata"
		' 
		' txtID
		' 
		txtID.Location = New Point(162, 53)
		txtID.Name = "txtID"
		txtID.Size = New Size(324, 31)
		txtID.TabIndex = 5
		' 
		' txtNama
		' 
		txtNama.Location = New Point(162, 103)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(324, 31)
		txtNama.TabIndex = 6
		' 
		' txtElemen
		' 
		txtElemen.Location = New Point(162, 153)
		txtElemen.Name = "txtElemen"
		txtElemen.Size = New Size(324, 31)
		txtElemen.TabIndex = 7
		' 
		' txtRarity
		' 
		txtRarity.Location = New Point(162, 203)
		txtRarity.Name = "txtRarity"
		txtRarity.Size = New Size(324, 31)
		txtRarity.TabIndex = 8
		' 
		' txtSenjata
		' 
		txtSenjata.Location = New Point(162, 253)
		txtSenjata.Name = "txtSenjata"
		txtSenjata.Size = New Size(324, 31)
		txtSenjata.TabIndex = 9
		' 
		' btnSimpan
		' 
		btnSimpan.Location = New Point(12, 331)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(166, 34)
		btnSimpan.TabIndex = 10
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = True
		' 
		' btnBatal
		' 
		btnBatal.Location = New Point(320, 331)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(166, 34)
		btnBatal.TabIndex = 11
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = True
		' 
		' FormInput
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(549, 377)
		Controls.Add(btnBatal)
		Controls.Add(btnSimpan)
		Controls.Add(txtSenjata)
		Controls.Add(txtRarity)
		Controls.Add(txtElemen)
		Controls.Add(txtNama)
		Controls.Add(txtID)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Name = "FormInput"
		Text = "Form2"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtNama As TextBox
	Friend WithEvents txtElemen As TextBox
	Friend WithEvents txtRarity As TextBox
	Friend WithEvents txtSenjata As TextBox
	Friend WithEvents btnSimpan As Button
	Friend WithEvents btnBatal As Button
End Class
