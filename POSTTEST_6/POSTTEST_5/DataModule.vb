Imports MySqlConnector

Module DataModule
    Public Function GetAllKarakter() As DataTable
        Dim dt As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter("SELECT * FROM karakter", conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function SearchKarakter(key As String) As DataTable
        Dim dt As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter("SELECT * FROM karakter WHERE namaKarakter LIKE @key OR idKarakter LIKE @key", conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & key & "%")
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function SimpanKarakter(id As String, nama As String, elemen As String, rarity As Integer, senjata As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO karakter VALUES (@id,@nama,@elemen,@rarity,@senjata)", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@elemen", elemen)
                cmd.Parameters.AddWithValue("@rarity", rarity)
                cmd.Parameters.AddWithValue("@senjata", senjata)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahKarakter(id As String, nama As String, elemen As String, rarity As Integer, senjata As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE karakter SET namaKarakter=@nama, elemen=@elemen, rarity=@rarity, senjata=@senjata WHERE idKarakter=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@elemen", elemen)
                cmd.Parameters.AddWithValue("@rarity", rarity)
                cmd.Parameters.AddWithValue("@senjata", senjata)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal update: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusKarakter(id As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM karakter WHERE idKarakter=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetKarakterDenganSenjata() As DataTable
        Dim dt As New DataTable()

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter("
            SELECT k.idKarakter, k.namaKarakter, k.elemen, k.rarity,
                   s.namaSenjata, s.tipeSenjata, s.damage
            FROM karakter k
            LEFT JOIN senjata_detail s 
            ON k.idKarakter = s.idKarakter
        ", conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function SimpanSenjata(idKarakter As String, nama As String, tipe As String, damage As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO senjata_detail (idKarakter,namaSenjata,tipeSenjata,damage) VALUES (@id,@nama,@tipe,@damage)", conn)
                cmd.Parameters.AddWithValue("@id", idKarakter)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@tipe", tipe)
                cmd.Parameters.AddWithValue("@damage", damage)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan senjata")
            Return False
        End Try
    End Function

End Module