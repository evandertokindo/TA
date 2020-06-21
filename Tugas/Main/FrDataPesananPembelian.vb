Imports System.Data.SqlClient

Public Class FrDataPesananPembelian

    Sub tabel()
        dgvData.ColumnCount = 4
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.ReadOnly = True
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
        dgvData.AllowUserToAddRows = False

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

    Function checkPKNoPesanan(pk As String) As Boolean
        Call koneksi()
        query = "Select count(*) from tbPPB_H where no_ppb = @no_ppb"
        cmd = New SqlCommand(query, conn)
        cmd.Parameters.Add("@no_ppb", SqlDbType.VarChar).Value = txtnopesananpembelian.Text
        Return cmd.ExecuteScalar
    End Function

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select no_ppb from tbPPB_H where no_ppb in(select max(no_ppb) from tbPPB_H) order by no_ppb", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("no_ppb"), 4) + 1
            urut = "PPB" + Strings.Right("000" & htg, 4)
        Else
            urut = "PPB" & "000" & +1
        End If
        datareader.Close()
        txtnopesananpembelian.Text = urut
        conn.Close()
    End Sub

    Private Sub FrPesananPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = FrMainMenu
        koneksi()
        buat_kode()
        tabel()
        txtkodebarang.Enabled = False
        txtnamabarang.Enabled = False
        txtkodesupplier.Enabled = False
        txtnamasupplier.Enabled = False
        dtpt.Enabled = False
        dtpt.Value = Date.Today
        txtnopesananpembelian.Enabled = False
        txttotal.Text = "0"
        txttotal.Enabled = False

    End Sub

    Private Sub btnsbar_Click(sender As Object, e As EventArgs) Handles btnsbar.Click

        FrCariBarang.Tag = "Pesanan"
        FrCariBarang.ShowDialog()

    End Sub

    Private Sub btnsearchs_Click(sender As Object, e As EventArgs) Handles btnsearchs.Click

        FrCariSupplier.Tag = "Pesanan"
        FrCariSupplier.ShowDialog()

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
            End If
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If Not checkPKNoPesanan(txtnopesananpembelian.Text) Then
            If txtkodesupplier.Text.Trim = "" Or txtnamasupplier.Text.Trim = "" Or dgvData.Rows.Count <= 0 Then
                MsgBox("Data tidak lengkap", MsgBoxStyle.Exclamation, "Warning") 'jika ada yang belum diisi maka tampilkan warning
            Else
                If (MessageBox.Show($"Apakah Anda Yakin ingin menyimpan data pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    'simpan header
                    query = "INSERT INTO tbPPB_H VALUES (@no_ppb, @tanggal, @kode_s,@nama_s @jenis_b)"
                    cmd = New SqlCommand(query, conn)
                    With cmd.Parameters
                        .Add("@no_ppb", SqlDbType.Char).Value = txtnopesananpembelian.Text.Trim
                        .Add("@tanggal", SqlDbType.DateTime).Value = dtpt.Value
                        .Add("@kode_s", SqlDbType.Char).Value = txtkodesupplier.Text.Trim
                        .Add("@nama_s", SqlDbType.VarChar).Value = txtnamasupplier.Text.Trim
                        .Add("@jenis_b", SqlDbType.Int).Value = CInt(txttotal.Text.Trim)
                    End With
                    cmd.ExecuteNonQuery()

                    'simpan detail 
                    For i = 0 To dgvData.Rows.Count - 1
                        query = "INSERT INTO tbPPB_D VALUES (@no_ppb, @kode_b, @nama_b, @jumlah, @satuan)"
                        cmd = New SqlCommand(query, conn)
                        With cmd.Parameters
                            .Add("@no_ppb", SqlDbType.VarChar).Value = txtnopesananpembelian.Text.Trim
                            .Add("@kode_b", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(0).Value.ToString
                            .Add("@nama_b", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(1).Value.ToString
                            .Add("@jumlah", SqlDbType.Int).Value = CInt(dgvData.Rows(i).Cells(2).Value.ToString)
                            .Add("@satuan", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(3).Value.ToString
                        End With
                        cmd.ExecuteNonQuery()
                    Next
                    MsgBox("Data pesanan pembelian berhasil disimpan", MsgBoxStyle.Information)
                End If
            End If
        Else
            If txtkodesupplier.Text.Trim = "" Or txtnamasupplier.Text.Trim = "" Or dgvData.Rows.Count <= 0 Then
                MsgBox("Data tidak lengkap", MsgBoxStyle.Exclamation, "Warning") 'jika ada yang belum diisi maka tampilkan warning
            Else
                If (MessageBox.Show($"Apakah Anda Yakin ingin mengubah data pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    'ubah header
                    query = "Update tbPPB_H Set kode_s = @kode_s, nama_s = @nama_s, jenis_b = @jenis_b where no_ppb = @no_ppb"

                    cmd = New SqlCommand(query, conn)
                    With cmd.Parameters
                        .Add("@no_ppb", SqlDbType.Char).Value = txtnopesananpembelian.Text.Trim
                        .Add("@kode_s", SqlDbType.VarChar).Value = txtkodesupplier.Text
                        .Add("@nama_s", SqlDbType.VarChar).Value = txtnamasupplier.Text
                        .Add("@jenis_b", SqlDbType.Int).Value = CInt(txttotal.Text)
                    End With
                    cmd.ExecuteNonQuery()

                    'ubah detail 
                    For i = 0 To dgvData.Rows.Count - 1
                        load_data_2pk("tbPPB_D")
                        Dim cari(5) As String
                        cari(0) = txtnopesananpembelian.Text
                        cari(1) = dgvData.Rows(i).Cells(0).Value.ToString
                        cari(2) = dgvData.Rows(i).Cells(1).Value.ToString
                        cari(3) = dgvData.Rows(i).Cells(2).Value.ToString
                        cari(4) = dgvData.Rows(i).Cells(3).Value.ToString
                        cari(5) = dgvData.Rows(i).Cells(4).Value.ToString
                        dr = ds.Tables("tbPPB_D").Rows.Find(cari)

                        If dr Is Nothing Then
                            load_data_2pk("tbPPB_D")
                            dr = ds.Tables("tbPPB_D").NewRow
                            dr(0) = txtnopesananpembelian.Text.Trim
                            dr(1) = dgvData.Rows(i).Cells(0).Value.ToString
                            dr(2) = dgvData.Rows(i).Cells(3).Value.ToString
                            dr(3) = dgvData.Rows(i).Cells(4).Value.ToString
                            dr(4) = dgvData.Rows(i).Cells(5).Value.ToString

                            ds.Tables("tbPPB_D").Rows.Add(dr)
                            update_data("tbPPB_D")
                        Else
                            query = "Update tbPPB_D Set kode_b = @kode_b, nama_b = @nama_b jumlah = @jumlah, satuan = @satuan Where no_ppb = @no_ppb"
                            cmd = New SqlCommand(query, conn)
                            With cmd.Parameters
                                .Add("@No_Pesanan", SqlDbType.Char).Value = txtnopesananpembelian.Text.Trim
                                .Add("@kode_b", SqlDbType.Char).Value = dgvData.Rows(i).Cells(0).Value.ToString
                                .Add("@nama_b", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(3).Value.ToString
                                .Add("@jumlah", SqlDbType.VarChar).Value = CInt(dgvData.Rows(i).Cells(4).Value.ToString)
                                .Add("@satuan", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(5).Value.ToString
                            End With
                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    MsgBox("Data pesanan pembelian berhasil diubah", MsgBoxStyle.Information)
                End If
            End If
        End If

    End Sub



    'Private Function btntambah_Click(sender As Object, e As EventArgs) As DialogResult Handles btntambah.Click

    '    If (String.IsNullOrWhiteSpace(txtkodebarang.Text) = True) Then
    '        Return MessageBox.Show("Data Product harus diisi terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If

    '    If nud.Value = 0 Then
    '        Return MessageBox.Show("Qty Tidak Boleh 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If

    '    If (String.IsNullOrWhiteSpace(cbbsatuan.Text) = True) Then
    '        Return MessageBox.Show("Isi Satuan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If

    '    If belumAdaKodenya() = False Then
    '        Return MessageBox.Show("Pesanan Produk" & txtkodebarang.Text & " Sudah ada Di List. Harap Hapus Terlebih Dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If

    '    dgvData.Rows.Add(txtkodebarang.Text, txtnamabarang.Text, nud.Value, cbbsatuan.Text)
    '    Return MessageBox.Show("Pesanan produk " & txtkodebarang.Text & " berhasil ditambahkan", "Tambah Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    txttotal.Text = dgvData.RowCount

    'End Function

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

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
            dgvData.Rows.Add(txtkodebarang.Text, txtnamabarang.Text, nud.Value, cbbsatuan.Text)
            MessageBox.Show("Pesanan produk " & txtkodebarang.Text & " berhasil ditambahkan", "Tambah Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'hitung_jenis()
            txttotal.Text = dgvData.RowCount

        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        FrCariPesananPembelian.Tag = "Pesanan"
        FrCariPesananPembelian.ShowDialog()
    End Sub

    Private Sub txtnopesananpembelian_TextChanged(sender As Object, e As EventArgs) Handles txtnopesananpembelian.TextChanged
        dgvData.Rows.Clear()
        query = $"Select kode_b, nama_b, jumlah, satuan from tbPPB_D Where no_ppb = '{txtnopesananpembelian.Text}'"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
            End While
        End If
        datareader.Close()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim baris = dgvData.CurrentCell.RowIndex

        txtkodebarang.Text = dgvData.Item(0, baris).Value
        txtnamabarang.Text = dgvData.Item(1, baris).Value
        nud.Value = dgvData.Item(2, baris).Value
        query = $"Select bh.satuan_besar, bh.satuan_sedang, bh.satuan_kecil from tbB_H bh inner join tbB_D bd  on bh.kode_b = bd.kode_b where bh.kode_b = '{txtkodebarang.Text}'"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                cbbsatuan.Items.Clear()
                cbbsatuan.Items.Add(datareader.Item("satuan_besar"))
                cbbsatuan.Items.Add(datareader.Item("satuan_sedang"))
                cbbsatuan.Items.Add(datareader.Item("satuan_kecil"))
            End While
        End If
        datareader.Close()
        cbbsatuan.Text = dgvData.Item(3, baris).Value
    End Sub
End Class
