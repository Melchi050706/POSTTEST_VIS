Public Class FormUtama

    Sub TampilData()
        dgvKarakter.DataSource = GetAllKarakter()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            TampilData()
        Else
            dgvKarakter.DataSource = SearchKarakter(txtSearch.Text)
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormInput.ShowDialog()
        TampilData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvKarakter.CurrentRow IsNot Nothing Then
            Dim id = dgvKarakter.CurrentRow.Cells(0).Value

            If HapusKarakter(id) Then
                MessageBox.Show("Berhasil hapus")
                TampilData()
            End If
        End If
    End Sub

    Private Sub dgvKarakter_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKarakter.CellClick
        If e.RowIndex >= 0 Then
            FormInput.txtID.Text = dgvKarakter.Rows(e.RowIndex).Cells(0).Value
            FormInput.txtNama.Text = dgvKarakter.Rows(e.RowIndex).Cells(1).Value
            FormInput.txtElemen.Text = dgvKarakter.Rows(e.RowIndex).Cells(2).Value
            FormInput.txtRarity.Text = dgvKarakter.Rows(e.RowIndex).Cells(3).Value
            FormInput.txtSenjata.Text = dgvKarakter.Rows(e.RowIndex).Cells(4).Value

            FormInput.ShowDialog()
            TampilData()
        End If
    End Sub

End Class