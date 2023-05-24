Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub cls()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtPassword.MaxLength = 30
        txtUsername.MaxLength = 30
        txtUsername.Focus()
    End Sub

    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) / 2
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
        End If
        Return True
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cek() = True Then
            CMD = New MySqlCommand("Select * from akun where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "' and level = 'admin'", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            If RD.HasRows Then
                If txtUsername.Text = RD("username") And txtPassword.Text = RD("password") Then
                    RD.Close()
                    Adminpage.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Username Atau Password Salah!", "Sekedar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Username Atau Password Salah!", "Sekedar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            RD.Close()
        End If
        cls()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Landingpage.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class