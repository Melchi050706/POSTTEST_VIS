Public Class Form1

    Dim judul(99) As String
    Dim genre(99) As String
    Dim jumlah As Integer = 0

    Private Sub TampilData()

        lstBuku.Items.Clear()

        For i As Integer = 0 To jumlah - 1
            lstBuku.Items.Add(judul(i) & " (" & genre(i) & ")")
        Next

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        'validasi input kosong
        If txtJudul.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Judul dan Genre tidak boleh kosong")
            Exit Sub
        End If

        If jumlah < 100 Then
            judul(jumlah) = txtJudul.Text
            genre(jumlah) = txtGenre.Text
            jumlah += 1
        End If

        TampilData()

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim cari As String = txtHapus.Text
        Dim ditemukan As Boolean = False

        For i As Integer = 0 To jumlah - 1

            If judul(i) = cari Then

                ditemukan = True

                For j As Integer = i To jumlah - 2
                    judul(j) = judul(j + 1)
                    genre(j) = genre(j + 1)
                Next

                jumlah -= 1
                Exit For

            End If

        Next

        If ditemukan = False Then
            MessageBox.Show("Judul ini tidak ada di list")
        End If

        TampilData()
        txtHapus.Clear()

    End Sub

End Class