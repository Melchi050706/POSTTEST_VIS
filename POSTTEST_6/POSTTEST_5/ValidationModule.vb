Module ValidationModule

    Public Function Validasi(txt As TextBox, pesan As String) As Boolean
        If txt.Text = "" Then
            MessageBox.Show(pesan)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

End Module