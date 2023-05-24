Imports MySql.Data.MySqlClient

Public Class Registrasi
    Private Sub cls()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Function cek()
        If txtUsername.Text = Nothing Then
            MessageBox.Show("Username Masih Kosong!", "Sekedar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Focus()
            Return False
        ElseIf txtPassword.Text = Nothing Then
            MessageBox.Show("Password Masih Kosong!", "Sekedar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Focus()
            Return False
        ElseIf txtConfirmPassword.Text = Nothing Then
            MessageBox.Show("Konfirmasi Password Masih Kosong!", "Sekedar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtConfirmPassword.Focus()
            Return False
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password Dan Konfirmasi Password Harus Sama!", "Sekedar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        If cek() Then
            CMD = New MySqlCommand("select * from akun where username ='" & txtUsername.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("insert into akun values('" & txtUsername.Text & "', '" & txtPassword.Text & "', 'customer')", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Berhasil Registrasi Akun", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cls()
            Else
                MessageBox.Show("Username Tersebut Sudah Digunakan!", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            RD.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Registrasi_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) / 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoginCustomer.Show()
        Me.Close()
    End Sub

End Class