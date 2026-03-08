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
		btnReset = New Button()
		btnTambah = New Button()
		txtIpSemester = New TextBox()
		txtIpk = New TextBox()
		lblIpSemester = New Label()
		Label1 = New Label()
		lblPredikat = New Label()
		SuspendLayout()
		' 
		' btnReset
		' 
		btnReset.Location = New Point(181, 144)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(126, 46)
		btnReset.TabIndex = 0
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = True
		' 
		' btnTambah
		' 
		btnTambah.Location = New Point(349, 144)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(126, 46)
		btnTambah.TabIndex = 1
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = True
		' 
		' txtIpSemester
		' 
		txtIpSemester.Location = New Point(181, 73)
		txtIpSemester.Name = "txtIpSemester"
		txtIpSemester.Size = New Size(294, 31)
		txtIpSemester.TabIndex = 2
		' 
		' txtIpk
		' 
		txtIpk.Location = New Point(181, 224)
		txtIpk.Name = "txtIpk"
		txtIpk.Size = New Size(294, 31)
		txtIpk.TabIndex = 3
		' 
		' lblIpSemester
		' 
		lblIpSemester.AutoSize = True
		lblIpSemester.Location = New Point(44, 73)
		lblIpSemester.Name = "lblIpSemester"
		lblIpSemester.Size = New Size(105, 25)
		lblIpSemester.TabIndex = 4
		lblIpSemester.Text = "IP Semester"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(42, 230)
		Label1.Name = "Label1"
		Label1.Size = New Size(107, 25)
		Label1.TabIndex = 5
		Label1.Text = "IP Kumulatif"
		' 
		' lblPredikat
		' 
		lblPredikat.AutoSize = True
		lblPredikat.Location = New Point(181, 289)
		lblPredikat.Name = "lblPredikat"
		lblPredikat.Size = New Size(0, 25)
		lblPredikat.TabIndex = 6
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(lblPredikat)
		Controls.Add(Label1)
		Controls.Add(lblIpSemester)
		Controls.Add(txtIpk)
		Controls.Add(txtIpSemester)
		Controls.Add(btnTambah)
		Controls.Add(btnReset)
		Name = "Form1"
		SizeGripStyle = SizeGripStyle.Show
		Text = "Kalkulator IP"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents btnReset As Button
	Friend WithEvents btnTambah As Button
	Friend WithEvents txtIpSemester As TextBox
	Friend WithEvents txtIpk As TextBox
	Friend WithEvents lblIpSemester As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents lblPredikat As Label

End Class
