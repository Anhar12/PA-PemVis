Public Class Landingpage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hasil As DialogResult = MessageBox.Show("Yakin Ingin Keluar?", "Perpisahan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Landingpage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) / 2
    End Sub

End Class
