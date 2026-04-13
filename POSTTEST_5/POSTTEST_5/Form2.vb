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

        Dim id = txtID.Text
        Dim nama = txtNama.Text

        Dim dt As DataTable = SearchKarakter(id)

        If dt.Rows.Count > 0 Then
            UbahKarakter(id, nama, txtElemen.Text, txtRarity.Text, txtSenjata.Text)
        Else
            SimpanKarakter(id, nama, txtElemen.Text, txtRarity.Text, txtSenjata.Text)
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