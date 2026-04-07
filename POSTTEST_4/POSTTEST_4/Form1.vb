Public Class Form1

    Dim fotoPath As String = ""

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            fotoPath = OpenFileDialog1.FileName
            picFoto.Image = Image.FromFile(fotoPath)
        End If
    End Sub

    Function AmbilHobi() As String
        Dim hasil As String = ""

        For Each ctrl As Control In GroupBoxHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    hasil &= CType(ctrl, CheckBox).Text & ", "
                End If
            End If
        Next

        Return hasil
    End Function

    Function ValidasiInput() As Boolean

        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If cmbKomunitas.Text = "" Then
            MessageBox.Show("Pilih komunitas")
            Return False
        End If

        If Not (rbLaki.Checked Or rbPerempuan.Checked) Then
            MessageBox.Show("Pilih jenis kelamin")
            Return False
        End If

        If mtxtHP.MaskCompleted = False Then
            MessageBox.Show("Nomor telepon tidak sesuai format")
            Return False
        End If

        Dim adaHobi As Boolean = False
        For Each ctrl As Control In GroupBoxHobi.Controls
            If TypeOf ctrl Is CheckBox And CType(ctrl, CheckBox).Checked Then
                adaHobi = True
            End If
        Next

        If Not adaHobi Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        Return True
    End Function
    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click

        If Not ValidasiInput() Then Exit Sub

        Form2.lblNama.Text = txtNama.Text
        Form2.lblID.Text = txtID.Text
        Form2.lblKomunitas.Text = cmbKomunitas.Text
        Form2.lblKontak.Text = mtxtHP.Text
        Form2.lblHobi.Text = AmbilHobi()

        Form2.picKartu.Image = picFoto.Image

        Form2.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click

        If Not ValidasiInput() Then Exit Sub

        If MessageBox.Show("Simpan data?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            SaveFileDialog1.Filter = "Text File|*.txt"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)

                sw.WriteLine(txtNama.Text)
                sw.WriteLine(txtID.Text)
                sw.WriteLine(cmbKomunitas.Text)
                sw.WriteLine(mtxtHP.Text)
                sw.WriteLine(txtEmail.Text)
                sw.WriteLine(txtAlamat.Text)
                sw.WriteLine(AmbilHobi())

                sw.Close()

                MessageBox.Show("Data berhasil disimpan")
            End If
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click

        OpenFileDialog1.Filter = "Text File|*.txt"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim sr As New IO.StreamReader(OpenFileDialog1.FileName)

            txtNama.Text = sr.ReadLine()
            txtID.Text = sr.ReadLine()
            cmbKomunitas.Text = sr.ReadLine()
            mtxtHP.Text = sr.ReadLine()
            txtEmail.Text = sr.ReadLine()
            txtAlamat.Text = sr.ReadLine()

            sr.Close()
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If Not ValidasiInput() Then Exit Sub

        If MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MessageBox.Show("Kartu berhasil dibuat!")
        End If

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click

        If MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

End Class