Public Class Form1
   
    Public Function Decrypt(ByVal CipherText As String, ByVal Key As Integer) As String
        Dim CipherChar() As Char = CipherText.ToCharArray()
        Dim Ascii(CipherChar.Length) As Integer

        For Count As Integer = 0 To CipherChar.Length - 1
            Ascii(Count) = Asc(CipherChar(Count))
            If Ascii(Count) >= 65 And Ascii(Count) <= 90 Then
                Ascii(Count) = ((Ascii(Count) - 65 - (Key Mod 26) + 26)) Mod 26 + 65
            ElseIf Ascii(Count) >= 97 And Ascii(Count) <= 122 Then
                Ascii(Count) = (((Ascii(Count) - 97 - (Key Mod 26) + 26)) Mod 26) + 97
            End If
            CipherChar(Count) = Chr(Ascii(Count))
        Next

        Return CipherChar
    End Function
    Public Function Encrypt(ByVal PlainText As String, ByVal Key As Integer) As String
        Dim PlainChar() As Char = PlainText.ToCharArray()
        Dim Ascii(PlainChar.Length) As Integer

        For Count As Integer = 0 To PlainChar.Length - 1
            Ascii(Count) = Asc(PlainChar(Count))
            If Ascii(Count) >= 65 And Ascii(Count) <= 90 Then
                Ascii(Count) = ((Ascii(Count) - 65 + Key) Mod 26) + 65
            ElseIf Ascii(Count) >= 97 And Ascii(Count) <= 122 Then
                Ascii(Count) = ((Ascii(Count) - 97 + Key) Mod 26) + 97
            End If
            PlainChar(Count) = Chr(Ascii(Count))
        Next

        Return PlainChar
    End Function
    
    Private Sub enkripsi_Click(sender As Object, e As EventArgs) Handles enkripsi.Click
        If txtTeks.Text.Trim = "" Or txtKey.Text.Trim = "" Then
            MessageBox.Show("Masukkan teks dan kunci untuk dienkripsi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                txtHasil.Text = Encrypt(txtTeks.Text.Trim, txtKey.Text.Trim)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dekripsi_Click(sender As Object, e As EventArgs) Handles dekripsi.Click
        If txtTeks.Text.Trim = "" Or txtKey.Text.Trim = "" Then
            MessageBox.Show("Masukkan teks dan kunci untuk dideskripsi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                txtHasil.Text = Decrypt(txtTeks.Text.Trim, txtKey.Text.Trim)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Plaintext_TextChanged(sender As Object, e As EventArgs) Handles txtHasil.TextChanged

    End Sub

    Private Sub txtKey_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged

    End Sub
End Class
