Public Class FormInput

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtID.Text <> "" Then
            txtID.Enabled = False
        Else
            txtID.Enabled = True
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not Validasi(txtID, "ID kosong") Then Exit Sub
        If Not Validasi(txtNama, "Nama kosong") Then Exit Sub

        If Not IsNumeric(txtRarity.Text) Or Not IsNumeric(txtDamage.Text) Then
            MessageBox.Show("Rarity & Damage harus angka!")
            Exit Sub
        End If

        Dim id = txtID.Text

        If SimpanKarakter(id, txtNama.Text, txtElemen.Text, CInt(txtRarity.Text), txtSenjata.Text) Then

            SimpanSenjata(id, txtNamaSenjata.Text, txtTipeSenjata.Text, CInt(txtDamage.Text))

            MessageBox.Show("Data berhasil disimpan (Relasi)")
        End If

        Me.Close()

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim tanya = MessageBox.Show("Yakin mau batal?", "Konfirmasi", MessageBoxButtons.YesNo)

        If tanya = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class