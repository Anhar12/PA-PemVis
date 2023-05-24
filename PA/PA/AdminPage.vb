Imports MySql.Data.MySqlClient

Public Class Adminpage
    Private Sub cls1()
        txtGame.Clear()
        txtMatauang.Clear()
        DataGridView2.Rows.Clear()
        cbGame.Text = Nothing
        txtGame.Focus()
    End Sub

    Private Sub cls2()
        txtJumlah.Clear()
        txtHarga.Clear()
        cbGame.Text = Nothing
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub cls3()
        txtJumlah.Clear()
        txtHarga.Clear()
    End Sub

    Private Sub display_game()
        DataGridView1.Rows.Clear()
        cbGame.Items.Clear()
        CMD = New MySqlCommand("Select * from game order by nama", CONN)
        RD = CMD.ExecuteReader()
        Dim i As Integer = 1
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = i
            row.Cells(1).Value = RD("nama")
            row.Cells(2).Value = RD("mataUang")
            DataGridView1.Rows.Add(row)
            cbGame.Items.Add(RD("nama"))
            i += 1
        End While

        RD.Close()
    End Sub

    Private Sub display_transaksi(filter As String)
        DataGridView4.Rows.Clear()
        If filter = "Semua" Then
            CMD = New MySqlCommand("Select * from pesanan join game on pesanan.game = game.nama order by pesanan.waktu desc", CONN)
        Else
            CMD = New MySqlCommand("Select * from pesanan join game on pesanan.game = game.nama where status = '" & filter & "' order by pesanan.waktu desc", CONN)
        End If
        RD = CMD.ExecuteReader()
        Dim i As Integer = 1
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView4)
            row.Cells(0).Value = RD("id")
            row.Cells(1).Value = i
            row.Cells(2).Value = RD("username")
            row.Cells(3).Value = RD("game")
            row.Cells(4).Value = RD("id_akun")
            row.Cells(5).Value = RD("nickname")
            row.Cells(6).Value = RD("jumlah") & " " & RD("mataUang")
            row.Cells(7).Value = "Rp" & RD("harga")
            row.Cells(8).Value = RD("waktu").ToString()
            row.Cells(9).Value = RD("status")
            DataGridView4.Rows.Add(row)
            i += 1
        End While

        RD.Close()
    End Sub

    Private Sub display_varian(game As String)
        DataGridView2.Rows.Clear()
        CMD = New MySqlCommand("Select * from varian join game on varian.game = game.nama where game = '" & game & "' order by jumlah", CONN)
        RD = CMD.ExecuteReader()
        Dim i As Integer = 1
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView2)
            row.Cells(0).Value = i
            row.Cells(1).Value = RD("jumlah") & " " & RD("mataUang")
            row.Cells(2).Value = "Rp" & RD("harga")
            row.Cells(3).Value = RD("game")
            DataGridView2.Rows.Add(row)
            MATAUANG_PUBLIC = RD("mataUang")
            i += 1
        End While
        RD.Close()
    End Sub

    Private Function cek1()
        If txtGame.Text = Nothing Then
            MessageBox.Show("Input Nama Game Dulu Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtGame.Focus()
            Return False
        ElseIf txtMatauang.Text = Nothing Then
            MessageBox.Show("Input Mata Uang Game Dulu Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMatauang.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function cek2()
        If cbGame.Text = Nothing Then
            MessageBox.Show("Pilih Game Yang Mau Ditambah Variannya Dulu Masbro", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbGame.Focus()
            Return False
        ElseIf txtJumlah.Text = Nothing Then
            MessageBox.Show("Input Jumlah Variannya Dulu Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtJumlah.Focus()
            Return False
        ElseIf txtHarga.Text = Nothing Then
            MessageBox.Show("Input Harga Variannya Dulu Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHarga.Focus()
            Return False
        ElseIf IsNumeric(txtJumlah.Text) = False Then
            MessageBox.Show("Input Jumlah Variannya Pake Angka Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtJumlah.Focus()
            Return False
        ElseIf IsNumeric(txtHarga.Text) = False Then
            MessageBox.Show("Input Harga Variannya Pake Angka Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHarga.Focus()
            Return False
        ElseIf txtJumlah.Text < 1 Then
            MessageBox.Show("Jumlah Harus Lebih Dari 0 Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtJumlah.Focus()
            Return False
        ElseIf txtHarga.Text < 1 Then
            MessageBox.Show("Harga Harus Lebih Dari 0 Masbroo", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHarga.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub Adminpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelHistory.Visible = False
        panelHome.Visible = True
        panelManage.Visible = False
    End Sub

    Private Sub btnTambahGame_Click(sender As Object, e As EventArgs) Handles btnTambahGame.Click
        If cek1() = True Then
            CMD = New MySqlCommand("select * from game where nama ='" & txtGame.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("insert into game values('" & txtGame.Text & "', '" & txtMatauang.Text & "')", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Berhasil Tambah Data Game Top Up", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                display_game()
                cls1()
            Else
                MessageBox.Show("Game Tersebut Sudah Ada", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            RD.Close()
        End If
    End Sub

    Private Sub btnUpdateGame_Click(sender As Object, e As EventArgs) Handles btnUpdateGame.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                If cek1() = True Then
                    CMD = New MySqlCommand("select * from game where nama ='" & txtGame.Text & "'", CONN)
                    RD = CMD.ExecuteReader
                    RD.Read()
                    Dim game As String = row.Cells(1).Value
                    If Not RD.HasRows Or txtGame.Text = game Then
                        RD.Close()
                        CMD = New MySqlCommand("update game set nama = '" & txtGame.Text & "', mataUang = '" & txtMatauang.Text & "' where nama = '" & game & "'", CONN)
                        CMD.ExecuteNonQuery()
                        MessageBox.Show("Berhasil Update Data Game Top Up", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        display_game()
                        cls1()
                    Else
                        MessageBox.Show("Game Tersebut Sudah Ada", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    RD.Close()
                End If
            Else
                MessageBox.Show("Pilih Game Yang Mau Diupdate Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Pilih Game Yang Mau Diupdate Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnHapusGame_Click(sender As Object, e As EventArgs) Handles btnHapusGame.Click
        If txtGame.Text <> Nothing Then
            CMD = New MySqlCommand("select * from game where nama ='" & txtGame.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                Dim hasil As DialogResult = MessageBox.Show("Yakin Ingin Hapus Data Game?", "Meyakinkan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If hasil = DialogResult.Yes Then
                    CMD = New MySqlCommand("delete from game where nama = '" & txtGame.Text & "'", CONN)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Berhasil Hapus Data Game", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    display_game()
                    cls1()
                End If
            Else
                MessageBox.Show("Data Game Tidak Ditemukan", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            RD.Close()
        Else
            MessageBox.Show("Pilih Game Yang Mau Dihapus Dulu Masbro", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                txtGame.Text = row.Cells(1).Value
                txtMatauang.Text = row.Cells(2).Value
                display_varian(row.Cells(1).Value)
                cbGame.Text = row.Cells(1).Value
                cls3()
            End If
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView2.SelectedRows(0)
            If row.Index < DataGridView2.RowCount - 1 And row.Index >= 0 Then
                Dim harga_string, jumlah_string As String
                jumlah_string = row.Cells(1).Value.ToString()
                harga_string = row.Cells(2).Value.ToString()
                txtJumlah.Text = Integer.Parse(jumlah_string.Substring(0, jumlah_string.Length - (MATAUANG_PUBLIC.Length + 1)))
                txtHarga.Text = Integer.Parse(harga_string.Substring(2))
            End If
        End If
    End Sub

    Private Sub btnTambahVarian_Click(sender As Object, e As EventArgs) Handles btnTambahVarian.Click
        If cek2() = True Then
            CMD = New MySqlCommand("select * from varian where jumlah ='" & txtJumlah.Text & "' and game = '" & cbGame.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("insert into varian values('" & cbGame.Text & "', '" & txtHarga.Text & "', '', '" & txtJumlah.Text & "')", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Berhasil Tambah Data Varian Top Up", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                display_varian(cbGame.Text)
                cls3()
            Else
                MessageBox.Show("Varian Top Up Tersebut Sudah Ada", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            RD.Close()
        End If
    End Sub

    Private Sub btnUpdateVarian_Click(sender As Object, e As EventArgs) Handles btnUpdateVarian.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView2.SelectedRows(0)
            If row.Index < DataGridView2.RowCount - 1 And row.Index >= 0 Then
                If cek2() = True Then
                    CMD = New MySqlCommand("select * from varian where jumlah ='" & txtJumlah.Text & "' and game = '" & cbGame.Text & "'", CONN)
                    RD = CMD.ExecuteReader
                    RD.Read()
                    Dim jumlah_string As String = row.Cells(1).Value
                    Dim jumlah As Integer = Integer.Parse(jumlah_string.Substring(0, jumlah_string.Length - (MATAUANG_PUBLIC.Length + 1)))
                    If Not RD.HasRows Or txtJumlah.Text = jumlah Then
                        RD.Close()
                        CMD = New MySqlCommand("update varian set jumlah = '" & txtJumlah.Text & "', harga = '" & txtHarga.Text & "' where jumlah = '" & jumlah & "' and game = '" & cbGame.Text & "'", CONN)
                        CMD.ExecuteNonQuery()
                        MessageBox.Show("Berhasil Update Data Varian Top Up", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        display_varian(cbGame.Text)
                        cls3()
                    Else
                        MessageBox.Show("Varian Top Up Tersebut Sudah Ada", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    RD.Close()
                End If
            Else
                MessageBox.Show("Pilih Jumlah Varian Top Up Yang Mau Diupdate Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Pilih Jumlah Varian Top Up Yang Mau Diupdate Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDeleteVarian_Click(sender As Object, e As EventArgs) Handles btnDeleteVarian.Click
        If cbGame.Text <> Nothing Then
            CMD = New MySqlCommand("select * from varian where jumlah = '" & txtJumlah.Text & "' and game ='" & cbGame.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                Dim hasil As DialogResult = MessageBox.Show("Yakin Ingin Hapus Varian Top Up" & txtJumlah.Text & " " & MATAUANG_PUBLIC & "?", "Meyakinkan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If hasil = DialogResult.Yes Then
                    CMD = New MySqlCommand("delete from varian where jumlah = '" & txtJumlah.Text & "' and game = '" & cbGame.Text & "'", CONN)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Berhasil Hapus Data Varian Top Up", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    display_varian(cbGame.Text)
                    cls3()
                End If
            Else
                MessageBox.Show("Data Varian Top Up Tidak Ditemukan", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            RD.Close()
        Else
            MessageBox.Show("Pilih Jenis Game Yang Mau Dihapus Dulu Masbro", "Sedekar Mengingatkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        cls1()
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        cls2()
    End Sub

    Private Sub Adminpage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) / 2
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Landingpage.Show()
        Me.Close()
    End Sub

    Private Sub cbGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGame.SelectedIndexChanged
        display_varian(cbGame.Text)
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        panelHome.Visible = False
        panelHistory.Visible = False
        panelManage.Visible = True
        cls1()
        cls2()
        display_game()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        panelManage.Visible = False
        panelHistory.Visible = False
        panelHome.Visible = True
        lblOops.Visible = False
        DataGridView3.Visible = False
        txtSearch.Clear()
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

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        panelHome.Visible = False
        panelManage.Visible = False
        panelHistory.Visible = True
        cbFilter.SelectedIndex = 0
        display_transaksi("Semua")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter.SelectedIndexChanged
        If cbFilter.Text <> Nothing Then
            display_transaksi(cbFilter.Text)
        End If
    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
        If DataGridView4.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView4.SelectedRows(0)
            If row.Index < DataGridView4.RowCount - 1 And row.Index >= 0 Then
                If row.Cells(9).Value = "Menunggu" Then
                    Dim result As DialogResult = MessageBox.Show("Yakin Ingin Mengkonfirmasi Top Up Menjadi Berhasil?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        CMD = New MySqlCommand("update pesanan set status = 'Berhasil' where id = '" & row.Cells(0).Value & "'", CONN)
                        CMD.ExecuteNonQuery()
                        display_transaksi("Semua")
                    End If
                Else
                    MessageBox.Show("Pesanan Top Up Telah Terkonfirmasi, Tidak Dapat Mengubahnya lagi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Pilih Data Pesanan Yang Mau Dikonfirmasi Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Pilih Data Pesanan Yang Mau Dikonfirmasi Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView4.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView4.SelectedRows(0)
            If row.Index < DataGridView4.RowCount - 1 And row.Index >= 0 Then
                If row.Cells(9).Value = "Menunggu" Then
                    Dim result As DialogResult = MessageBox.Show("Yakin Ingin Mengkonfirmasi Top Up Menjadi Gagal?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        CMD = New MySqlCommand("update pesanan set status = 'Gagal' where id = '" & row.Cells(0).Value & "'", CONN)
                        CMD.ExecuteNonQuery()
                        display_transaksi("Semua")
                    End If
                Else
                    MessageBox.Show("Pesanan Top Up Telah Terkonfirmasi, Tidak Dapat Mengubahnya lagi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Pilih Data Pesanan Yang Mau Dikonfirmasi Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Pilih Data Pesanan Yang Mau Dikonfirmasi Dulu Masbro", "Tidak Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtSearchTransaksi_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTransaksi.TextChanged
        If txtSearchTransaksi.Text <> Nothing Then
            DataGridView4.Rows.Clear()
            CMD = New MySqlCommand("Select * from pesanan join game on pesanan.game = game.nama where username like '%" & txtSearchTransaksi.Text & "%' 
                                    or id_akun like '%" & txtSearchTransaksi.Text & "%' or nickname like '%" & txtSearchTransaksi.Text & "%'
                                    or jumlah like '%" & txtSearchTransaksi.Text & "%' order by pesanan.waktu desc", CONN)
            RD = CMD.ExecuteReader()
            Dim i As Integer = 1
            While RD.Read()
                Dim row As New DataGridViewRow()
                row.CreateCells(DataGridView4)
                row.Cells(0).Value = RD("id")
                row.Cells(1).Value = i
                row.Cells(2).Value = RD("username")
                row.Cells(3).Value = RD("game")
                row.Cells(4).Value = RD("id_akun")
                row.Cells(5).Value = RD("nickname")
                row.Cells(6).Value = RD("jumlah") & " " & RD("mataUang")
                row.Cells(7).Value = "Rp" & RD("harga")
                row.Cells(8).Value = RD("waktu").ToString()
                row.Cells(9).Value = RD("status")
                DataGridView4.Rows.Add(row)
                i += 1
            End While

            RD.Close()
        Else
            display_transaksi("Semua")
        End If
    End Sub
End Class