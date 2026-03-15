Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim open As New OpenFileDialog
        open.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If open.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(open.FileName)
        End If

    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelp.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Semua Kolom Wajib Diisi")
            Exit Sub
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih Gender Lu")
            Exit Sub
        End If

        If Not cbGaming.Checked And Not cbCoding.Checked And Not cbTraveling.Checked And Not cbMenggambar.Checked _
            And Not cbMenulis.Checked And Not cbMemancing.Checked And Not cbMembaca.Checked _
            And Not cbOlahraga.Checked And Not cbMenyanyi.Checked And Not cbMenari.Checked Then

            MessageBox.Show("Masa Hobby Gada, Introvert Ya Lu")
            Exit Sub
        End If

        Dim jk As String = ""

        If rbLaki.Checked Then
            jk = "Laki-laki"
        ElseIf rbPerempuan.Checked Then
            jk = "Perempuan"
        End If

        Dim hobby As String = ""

        If cbGaming.Checked Then hobby &= "Gaming, "
        If cbCoding.Checked Then hobby &= "Coding, "
        If cbTraveling.Checked Then hobby &= "Traveling, "
        If cbMenggambar.Checked Then hobby &= "Menggambar, "
        If cbMenulis.Checked Then hobby &= "Menulis, "
        If cbMemancing.Checked Then hobby &= "Memancing, "
        If cbMembaca.Checked Then hobby &= "Membaca, "
        If cbOlahraga.Checked Then hobby &= "Olahraga, "
        If cbMenyanyi.Checked Then hobby &= "Menyanyi, "
        If cbMenari.Checked Then hobby &= "Menari"


        Form2.lblNama.Text = txtNama.Text
        Form2.lblUmur.Text = txtUmur.Text
        Form2.lblTanggal.Text = dtpTanggal.Text
        Form2.lblJK.Text = jk
        Form2.lblTelp.Text = txtTelp.Text
        Form2.lblAlamat.Text = txtAlamat.Text
        Form2.lblHobby.Text = hobby

        Form2.picFoto.Image = picFoto.Image

        Form2.Show()

    End Sub

End Class