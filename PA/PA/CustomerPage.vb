Imports MySql.Data.MySqlClient

Public Class Customerpage
    Private Sub cls()
        txtId.Clear()
        txtNickname.Clear()
        cbGame.Text = Nothing
        cbJumlah.Text = Nothing
        DataGridView1.Rows.Clear()
        cbJumlah.Items.Clear()
        txtTotal.Clear()
        cbGame.Focus()
    End Sub

    Private Function cek()
        If cbGame.Text = Nothing Then
            MessageBox.Show("Pilih Game Yang Mau Ditopup Dulu Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbGame.Focus()
            Return False
        ElseIf cbJumlah.Text = Nothing Then
            MessageBox.Show("Pilih Jumlah Topupnya Dulu Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbJumlah.Focus()
            Return False
        ElseIf txtId.Text = Nothing Then
            MessageBox.Show("Masukkan ID Akunnya Dulu Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtId.Focus()
            Return False
        ElseIf txtNickname.Text = Nothing Then
            MessageBox.Show("Masukkan Nickname Akunnya Dulu Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNickname.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub display(game As String)
        DataGridView1.Rows.Clear()
        CMD = New MySqlCommand("Select * from varian join game on varian.game = game.nama where varian.game = '" & game & "' order by jumlah", CONN)
        RD = CMD.ExecuteReader()
        cbJumlah.Items.Clear()
        Dim i As Integer = 1
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = i
            row.Cells(1).Value = RD("jumlah") & " " & RD("mataUang")
            row.Cells(2).Value = "Rp" & RD("harga")
            row.Cells(3).Value = RD("game")
            cbJumlah.Items.Add(RD("jumlah") & " " & RD("mataUang"))
            DataGridView1.Rows.Add(row)
            i += 1
        End While

        RD.Close()
    End Sub

    Private Sub display_transaksi(filter As String)
        DataGridView4.Rows.Clear()
        If filter = "Semua" Then
            CMD = New MySqlCommand("Select * from pesanan join game on pesanan.game = game.nama where username = '" & USERNAME_CUSTOMER & "' order by waktu desc", CONN)
        Else
            CMD = New MySqlCommand("Select * from pesanan join game on pesanan.game = game.nama where username = '" & USERNAME_CUSTOMER & "'
                                    and status = '" & filter & "' order by waktu desc", CONN)
        End If
        RD = CMD.ExecuteReader()
        Dim i As Integer = 1

        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView4)
            row.Cells(0).Value = RD("id")
            row.Cells(1).Value = i
            row.Cells(2).Value = RD("game")
            row.Cells(3).Value = RD("id_akun")
            row.Cells(4).Value = RD("nickname")
            row.Cells(5).Value = RD("jumlah") & " " & RD("mataUang")
            row.Cells(6).Value = "Rp" & RD("harga")
            row.Cells(7).Value = RD("waktu").ToString()
            row.Cells(8).Value = RD("status")
            DataGridView4.Rows.Add(row)
            i += 1
        End While

        RD.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelHome.Visible = True
        panelOrder.Visible = False
        panelHistory.Visible = False
        lblOops.Visible = False
        DataGridView3.Visible = False
        txtSearch.Clear()
    End Sub

    Private Sub Customerpage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) / 2
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Landingpage.Show()
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        panelHome.Visible = True
        panelOrder.Visible = False
        panelHistory.Visible = False
        lblOops.Visible = False
        DataGridView3.Visible = False
        txtSearch.Clear()
    End Sub


    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        panelHome.Visible = False
        panelOrder.Visible = True
        panelHistory.Visible = False
        cls()
        CMD = New MySqlCommand("select * from game", CONN)
        RD = CMD.ExecuteReader()
        cbGame.Items.Clear()
        While RD.Read
            cbGame.Items.Add(RD("nama"))
        End While
        RD.Close()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        panelHome.Visible = False
        panelOrder.Visible = False
        panelHistory.Visible = True
        cbFilter.SelectedIndex = 0
        txtSearchHistory.Clear()
        display_transaksi("Semua")
    End Sub

    Private Sub cbFilter_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cbFilter.Text <> Nothing Then
            display_transaksi(cbFilter.Text)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Landingpage.Show()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = Nothing Then
            lblOops.Visible = False
            DataGridView3.Visible = False
        Else
            DataGridView3.Rows.Clear()
            CMD = New MySqlCommand("Select * from varian join game on varian.game = game.nama where game like '%" & txtSearch.Text & "%' 
                                    or jumlah like '%" & txtSearch.Text & "%' order by nama", CONN)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DataGridView3.Visible = True
                lblOops.Visible = False
                Dim i As Integer = 1
                While RD.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView3)
                    row.Cells(0).Value = i
                    row.Cells(1).Value = RD("game")
                    row.Cells(2).Value = RD("jumlah").ToString & " " & RD("mataUang")
                    row.Cells(3).Value = "Rp" & RD("harga").ToString
                    DataGridView3.Rows.Add(row)
                    i += 1
                End While
            Else
                lblOops.Visible = True
                DataGridView3.Visible = False
            End If
            RD.Close()

        End If
    End Sub

    Private Sub cbGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGame.SelectedIndexChanged
        If cbGame.Text <> Nothing Then
            display(cbGame.Text)
            cbJumlah.Enabled = True
        Else
            cbJumlah.Enabled = False
        End If
    End Sub

    Private Sub cbJumlah_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJumlah.SelectedIndexChanged
        If cbJumlah.Text <> Nothing Then
            CMD = New MySqlCommand("select mataUang from game where nama = '" & cbGame.Text & "'", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            Dim mataUang As String = RD("mataUang")
            JUMLAH_PUBLIC = Integer.Parse(cbJumlah.Text.Substring(0, cbJumlah.Text.Length - (mataUang.Length + 1)))
            RD.Close()

            CMD = New MySqlCommand("select harga from varian where game = '" & cbGame.Text & "' and jumlah = '" & JUMLAH_PUBLIC & "'", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            HARGA_PUBLIC = RD("harga")
            txtTotal.Text = "Rp" & HARGA_PUBLIC.ToString
            RD.Close()
        End If
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        If cek() = True Then
            Dim result As DialogResult = MessageBox.Show("Apakah Data Tersebut Sudah Benar?", "Meyakinkan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                CMD = New MySqlCommand("insert into pesanan values('', '" & JUMLAH_PUBLIC & "', '" & HARGA_PUBLIC & "', '" & txtId.Text & "', '" & txtNickname.Text & "', '" & cbGame.Text & "', NOW(), '" & USERNAME_CUSTOMER & "', 'Menunggu')", CONN)
                CMD.ExecuteNonQuery()
                Struk.txtItem.Text = cbJumlah.Text.Substring(JUMLAH_PUBLIC.ToString.Length + 1) & " " & cbGame.Text
                Struk.txtID.Text = txtId.Text
                Struk.txtNickname.Text = txtNickname.Text
                Struk.txtJumlah.Text = cbJumlah.Text
                Struk.txtTotal.Text = txtTotal.Text
                Struk.txtTgl.Text = Now()
                Struk.Show()
                cls()
                RD.Close()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cls()
    End Sub

    Private Sub cbFilter_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbFilter.SelectedIndexChanged
        If cbFilter.Text <> Nothing Then
            display_transaksi(cbFilter.Text)
        End If
    End Sub

    Private Sub btnBatalkan_Click(sender As Object, e As EventArgs) Handles btnBatalkan.Click
        If DataGridView4.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView4.SelectedRows(0)
            If row.Index < DataGridView4.RowCount - 1 And row.Index >= 0 Then
                If row.Cells(8).Value = "Menunggu" Then
                    Dim result As DialogResult = MessageBox.Show("Yakin Ingin Membatalkan Pesanan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        CMD = New MySqlCommand("delete from pesanan where id = '" & row.Cells(0).Value & "'", CONN)
                        CMD.ExecuteNonQuery()
                        display_transaksi("Semua")
                    End If
                Else
                    MessageBox.Show("Pesanan Top Up Telah Terkonfirmasi, Tidak Dapat Membatalkannya!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Pilih Data Pesanan Yang Mau Dibatalkan Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Pilih Data Pesanan Yang Mau Dibatalkan Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtSearchHistory_TextChanged(sender As Object, e As EventArgs) Handles txtSearchHistory.TextChanged
        If txtSearchHistory.Text <> Nothing Then
            DataGridView4.Rows.Clear()
            CMD = New MySqlCommand("Select * from pesanan join game on pesanan.game = game.nama where username = '" & USERNAME_CUSTOMER & "' 
                                    and id_akun like '%" & txtSearchHistory.Text & "%' or username = '" & USERNAME_CUSTOMER & "' and nickname like '%" & txtSearchHistory.Text & "%'
                                    or username = '" & USERNAME_CUSTOMER & "' and jumlah like '%" & txtSearchHistory.Text & "%' 
                                    or username = '" & USERNAME_CUSTOMER & "' and game like '%" & txtSearchHistory.Text & "%' order by pesanan.waktu desc", CONN)
            RD = CMD.ExecuteReader()
            Dim i As Integer = 1
            While RD.Read()
                Dim row As New DataGridViewRow()
                row.CreateCells(DataGridView4)
                row.Cells(0).Value = RD("id")
                row.Cells(1).Value = i
                row.Cells(2).Value = RD("game")
                row.Cells(3).Value = RD("id_akun")
                row.Cells(4).Value = RD("nickname")
                row.Cells(5).Value = RD("jumlah") & " " & RD("mataUang")
                row.Cells(6).Value = "Rp" & RD("harga")
                row.Cells(7).Value = RD("waktu").ToString()
                row.Cells(8).Value = RD("status")
                DataGridView4.Rows.Add(row)
                i += 1
            End While

            RD.Close()
        Else
            display_transaksi("Semua")
        End If
    End Sub
End Class