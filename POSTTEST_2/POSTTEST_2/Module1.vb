Public Module ModuleBuku

    Public judul(99) As String
    Public genre(99) As String
    Public jumlah As Integer = 0

    Public Sub TambahBuku(j As String, g As String)

        If jumlah < 100 Then
            judul(jumlah) = j
            genre(jumlah) = g
            jumlah += 1
        End If

    End Sub

End Module