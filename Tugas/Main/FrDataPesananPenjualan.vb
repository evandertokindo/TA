Imports System.Data.SqlClient
Public Class FrDataPesananPenjualan
    Sub tabel()
        dgvData.ColumnCount = 7
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Harga Satuan"
        dgvData.Columns(5).HeaderText = "SubTotal"
        dgvData.Columns(6).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
        dgvData.AllowUserToAddRows = False
    End Sub

    Function checkPKNoPesanan(pk As String) As Boolean
        Call koneksi()
        query = "Select count(*) from tbPPB_H where no_ppb = @no_ppb"
        cmd = New SqlCommand(query, conn)
        cmd.Parameters.Add("@no_ppb", SqlDbType.VarChar).Value = txtnopesananpenjualan.Text
        Return cmd.ExecuteScalar
    End Function

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select no_ppj from tbPPJ_H where no_ppj in(select max(no_ppj) from tbPPJ_H) order by no_ppj", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("no_ppj"), 4) + 1
            urut = "PPJ" + Strings.Right("000" & htg, 4)
        Else
            urut = "PPJ" & "000" & +1
        End If
        datareader.Close()
        txtnopesananpenjualan.Text = urut
        conn.Close()
    End Sub

    Sub bersih()
        txtkodebarang.Clear()
        txtnamabarang.Clear()
        txtkodepelanggan.Clear()
        txtnamapelanggan.Clear()
        nud.Value = "0"
        txttotal.Clear()
        cbbsatuan.Items.Clear()
        dtpkadaluarsa.Value = Date.Today
        dtpt.Value = Date.Today
        buat_kode()
    End Sub

    Function belumAdaKodenya() As Boolean
        Dim jlh = 0
        For i As Integer = 0 To dgvData.Rows.Count - 1
            If txtkodebarang.Text = dgvData.Item(0, i).Value Then
                jlh += 1
            End If
        Next
        Return (jlh = 0)
    End Function

    Private Sub FrDataPesananPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        tabel()
        buat_kode()
        txttotal.Text = "0"
        txtnopesananpenjualan.Enabled = False
        txtkodepelanggan.Enabled = False
        txtnamapelanggan.Enabled = False
        txtkodebarang.Enabled = False
        txtnamapelanggan.Enabled = False
        dtpt.Value = Date.Today
        dtpt.Enabled = False
        dtpkadaluarsa.Enabled = False
    End Sub

    Private Sub btncaripelanggan_Click(sender As Object, e As EventArgs) Handles btncaripelanggan.Click
        FrCariPelanggan.Tag = "PesananPenjualan"
        FrCariPelanggan.ShowDialog()
    End Sub

    Private Sub btncaripesananpenjualan_Click(sender As Object, e As EventArgs) Handles btncaripesananpenjualan.Click
        FrCariPesananPenjualan.Tag = "PesananPenjualan"
        FrCariPesananPenjualan.ShowDialog()
    End Sub

    Private Sub btncaribarang_Click(sender As Object, e As EventArgs) Handles btncaribarang.Click
        FrCariBarang.Tag = "PesananPenjualan"
        FrCariBarang.ShowDialog()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If dgvData.Rows.Count = 0 Then
            MessageBox.Show("Anda belum memasukkan Data Pesanan Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim baris As Integer = dgvData.CurrentCell.RowIndex
            If MessageBox.Show("Apakah anda yakin mau menghapus Produk " & dgvData.Item(0, baris).Value & "?", "Hapus Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dgvData.Rows.RemoveAt(baris)
                MessageBox.Show("Produk berhasil dihapus", "Hapus Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txttotal.Text = dgvData.Rows.Count

                txtkodebarang.Clear()
                txtnamabarang.Clear()
                nud.Value = "0"
                cbbsatuan.Items.Clear()
                dtpkadaluarsa.Value = Date.Today

            End If
        End If
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If (String.IsNullOrWhiteSpace(txtkodebarang.Text) = True) Then
            MessageBox.Show("Isi Barang", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf nud.Value = 0 Then
            MessageBox.Show("Jumlah Tidak boleh 0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (String.IsNullOrWhiteSpace(cbbsatuan.Text) = True) Then
            MessageBox.Show("Pilih Satuan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf belumAdaKodenya() = False Then
            MessageBox.Show("Barang Sudah Ada. Hapus Dulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dgvData.Rows.Add(txtkodebarang.Text, txtnamabarang.Text, nud.Value, cbbsatuan.Text, dtpkadaluarsa.Value)
            MessageBox.Show("Pesanan produk " & txtkodebarang.Text & " berhasil ditambahkan", "Tambah Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'hitung_jenis()
            txttotal.Text = dgvData.RowCount
            txtkodebarang.Clear()
            txtnamabarang.Clear()
            nud.Value = 0
            cbbsatuan.Items.Clear()
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If Not checkPKNoPesanan(txtnopesananpenjualan.Text) Then
            If txtkodepelanggan.Text.Trim = "" Or txtnamapelanggan.Text.Trim = "" Or dgvData.Rows.Count <= 0 Then
                MsgBox("Data tidak lengkap", MsgBoxStyle.Exclamation, "Warning") 'jika ada yang belum diisi maka tampilkan warning
            Else
                If (MessageBox.Show($"Apakah Anda Yakin ingin menyimpan data pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    'simpan header
                    query = "INSERT INTO tbPPJ_H VALUES (@no_ppj, @tanggal, @kode_p, @nama_p, @total, @status_ppj)"
                    cmd = New SqlCommand(query, conn)
                    With cmd.Parameters
                        .Add("@no_ppj", SqlDbType.VarChar).Value = txtnopesananpenjualan.Text.Trim
                        .Add("@tanggal", SqlDbType.Date).Value = dtpt.Value
                        .Add("@kode_p", SqlDbType.VarChar).Value = txtkodepelanggan.Text.Trim
                        .Add("@nama_p", SqlDbType.VarChar).Value = txtnamapelanggan.Text.Trim
                        .Add("@total", SqlDbType.Int).Value = CInt(txttotal.Text)
                        .Add("@status_ppj", SqlDbType.VarChar).Value = txtstatus.Text.Trim
                    End With
                    cmd.ExecuteNonQuery()

                    'simpan detail 
                    For i = 0 To dgvData.Rows.Count - 1
                        query = "INSERT INTO tbPPJ_D VALUES (@no_ppj, @kode_b, @nama_b, @jumlah, @satuan, @kadaluarsa)"
                        cmd = New SqlCommand(query, conn)
                        With cmd.Parameters
                            .Add("@no_ppj", SqlDbType.VarChar).Value = txtnopesananpenjualan.Text.Trim
                            .Add("@kode_b", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(0).Value.ToString
                            .Add("@nama_b", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(1).Value.ToString
                            .Add("@jumlah", SqlDbType.Int).Value = CInt(dgvData.Rows(i).Cells(2).Value.ToString)
                            .Add("@satuan", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(3).Value.ToString
                            .Add("@kadaluarsa", SqlDbType.Date).Value = CDate(dgvData.Rows(i).Cells(4).Value.ToString)
                        End With
                        cmd.ExecuteNonQuery()
                    Next
                    MsgBox("Data pesanan pembelian berhasil disimpan", MsgBoxStyle.Information)
                    bersih()
                End If
            End If
        Else
            If txtkodepelanggan.Text.Trim = "" Or txtnamapelanggan.Text.Trim = "" Or dgvData.Rows.Count <= 0 Then
                MsgBox("Data tidak lengkap", MsgBoxStyle.Exclamation, "Warning") 'jika ada yang belum diisi maka tampilkan warning
            Else
                If (MessageBox.Show($"Apakah Anda Yakin ingin mengubah data pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    'ubah header
                    query = "Update tbPPJ_H Set kode_p = @kode_p, nama_p= @nama_p, total = @total where no_ppb = @no_ppJ"

                    cmd = New SqlCommand(query, conn)
                    With cmd.Parameters
                        .Add("@no_ppj", SqlDbType.Char).Value = txtnopesananpenjualan.Text.Trim
                        .Add("@tanggal", SqlDbType.Date).Value = dtpt.Value
                        .Add("@kode_p", SqlDbType.Char).Value = txtkodepelanggan.Text.Trim
                        .Add("@nama_p", SqlDbType.VarChar).Value = txtnamapelanggan.Text.Trim
                        .Add("@total", SqlDbType.Int).Value = CDec(txttotal.Text)
                        .Add("@status_ppj", SqlDbType.VarChar).Value = txtstatus.Text
                    End With
                    cmd.ExecuteNonQuery()

                    'ubah detail 
                    For i = 0 To dgvData.Rows.Count - 1
                        load_data_2pk("tbPPJ_D")
                        Dim cari(1) As String
                        cari(0) = txtnopesananpenjualan.Text
                        cari(1) = dgvData.Rows(i).Cells(0).Value.ToString
                        'cari(2) = dgvData.Rows(i).Cells(1).Value.ToString
                        'cari(3) = dgvData.Rows(i).Cells(2).Value.ToString
                        'cari(4) = dgvData.Rows(i).Cells(3).Value.ToString
                        dr = ds.Tables("tbPPJ_D").Rows.Find(cari)

                        If dr Is Nothing Then
                            load_data_2pk("tbPPJ_D")
                            dr = ds.Tables("tbPPJ_D").NewRow
                            dr(0) = txtnopesananpenjualan.Text.Trim
                            dr(1) = dgvData.Rows(i).Cells(0).Value.ToString
                            dr(2) = dgvData.Rows(i).Cells(1).Value.ToString
                            dr(3) = dgvData.Rows(i).Cells(2).Value.ToString
                            dr(4) = dgvData.Rows(i).Cells(3).Value.ToString
                            dr(5) = dgvData.Rows(i).Cells(4).Value

                            ds.Tables("tbPPJ_D").Rows.Add(dr)
                            update_data("tbPPJ_D")
                        Else
                            query = "Update tbPPJ_D Set jumlah = @jumlah, satuan = @satuan, kadaluarsa = @kadaluarsa Where no_ppj = @no_ppj"
                            cmd = New SqlCommand(query, conn)
                            With cmd.Parameters
                                .Add("@no_ppj", SqlDbType.VarChar).Value = txtnopesananpenjualan.Text.Trim
                                .Add("@kode_b", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(0).Value.ToString
                                .Add("@nama_b", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(1).Value.ToString
                                .Add("@jumlah", SqlDbType.Int).Value = CInt(dgvData.Rows(i).Cells(2).Value.ToString)
                                .Add("@satuan", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(3).Value.ToString
                                .Add("@kadaluarsa", SqlDbType.Date).Value = CDate(dgvData.Rows(i).Cells(4).Value.ToString)
                            End With
                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    MsgBox("Data pesanan pembelian berhasil diubah", MsgBoxStyle.Information)
                    bersih()
                End If
            End If
        End If
    End Sub

    Private Sub txtkodepelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtkodepelanggan.TextChanged

    End Sub

    Private Sub txtkodebarang_TextChanged(sender As Object, e As EventArgs) Handles txtkodebarang.TextChanged

    End Sub

    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nud.ValueChanged

    End Sub

    Private Sub txthargasatuan_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub ckbproses_CheckedChanged(sender As Object, e As EventArgs) Handles ckbproses.CheckedChanged
        If ckbproses.Checked Then
            txtstatus.Text = "Diproses"
        End If
    End Sub
End Class