﻿Imports System.Data.SqlClient

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

    Sub bersih()
        txtkodebarang.Clear()
        txtnamabarang.Clear()
        txtkodesupplier.Clear()
        txtnamasupplier.Clear()
        nud.Value = "0"
        txttotal.Clear()
        cbbsatuan.Items.Clear()
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
        txtstatus.Enabled = False

    End Sub

    Private Sub btnsbar_Click(sender As Object, e As EventArgs) Handles btnsbar.Click

        FrCariBarang.Tag = "PesananPembelian"
        FrCariBarang.ShowDialog()

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        If dgvData.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada barang yang diinput", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dgvData.SelectedCells.Count < 0 Then
            MessageBox.Show("Tidak ada barang yang dipilih", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            baris = dgvData.CurrentCell.RowIndex
            If dgvData.Item(8, baris).Value.ToString = "Sudah Selesai" Or dgvData.Item(8, baris).Value.ToString = "Sebagian Selesai" Then
                MsgBox("Barang dengan status ""Belum Selesai"" yang hanya dapat dihapus", MsgBoxStyle.Exclamation, "Warning") 'jika ada yang belum diisi maka tampilkan warning
            Else
                sementara.Rows.Add(dgvData.Item(0, baris).Value, dgvData.Item(1, baris).Value, dgvData.Item(2, baris).Value, dgvData.Item(3, baris).Value, dgvData.Item(4, baris).Value, dgvData.Item(5, baris).Value, dgvData.Item(6, baris).Value, dgvData.Item(7, baris).Value, dgvData.Item(8, baris).Value)
                dgvData.Rows.RemoveAt(baris)
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
                    query = "INSERT INTO tbPPB_H VALUES (@no_ppb, @tanggal, @kode_s,@nama_s, @jenis_b, @status_ppb)"
                    cmd = New SqlCommand(query, conn)
                    With cmd.Parameters
                        .Add("@no_ppb", SqlDbType.Char).Value = txtnopesananpembelian.Text.Trim
                        .Add("@tanggal", SqlDbType.Date).Value = dtpt.Value
                        .Add("@kode_s", SqlDbType.Char).Value = txtkodesupplier.Text.Trim
                        .Add("@nama_s", SqlDbType.VarChar).Value = txtnamasupplier.Text.Trim
                        .Add("@jenis_b", SqlDbType.Int).Value = CInt(txttotal.Text)
                        .Add("@status_ppb", SqlDbType.VarChar).Value = txtstatus.Text.Trim
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
                    bersih()
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
                        .Add("@no_ppb", SqlDbType.VarChar).Value = txtnopesananpembelian.Text.Trim
                        .Add("@kode_s", SqlDbType.VarChar).Value = txtkodesupplier.Text
                        .Add("@nama_s", SqlDbType.VarChar).Value = txtnamasupplier.Text
                        .Add("@jenis_b", SqlDbType.Int).Value = CInt(txttotal.Text)
                    End With
                    cmd.ExecuteNonQuery()

                    'ubah detail 
                    For i = 0 To dgvData.Rows.Count - 1
                        load_data_2pk("tbPPB_D")
                        Dim cari(1) As String
                        cari(0) = txtnopesananpembelian.Text
                        cari(1) = dgvData.Rows(i).Cells(0).Value.ToString
                        'cari(2) = dgvData.Rows(i).Cells(1).Value.ToString
                        'cari(3) = dgvData.Rows(i).Cells(2).Value.ToString
                        'cari(4) = dgvData.Rows(i).Cells(3).Value.ToString
                        dr = ds.Tables("tbPPB_D").Rows.Find(cari)

                        If dr Is Nothing Then
                            load_data_2pk("tbPPB_D")
                            dr = ds.Tables("tbPPB_D").NewRow
                            dr(0) = txtnopesananpembelian.Text.Trim
                            dr(1) = dgvData.Rows(i).Cells(0).Value.ToString
                            dr(2) = dgvData.Rows(i).Cells(1).Value.ToString
                            dr(3) = dgvData.Rows(i).Cells(2).Value.ToString
                            dr(4) = dgvData.Rows(i).Cells(3).Value.ToString

                            ds.Tables("tbPPB_D").Rows.Add(dr)
                            update_data("tbPPB_D")
                        Else
                            query = "Update tbPPB_D Set jumlah = @jumlah, satuan = @satuan Where no_ppb = @no_ppb"
                            cmd = New SqlCommand(query, conn)
                            With cmd.Parameters
                                .Add("@no_ppb", SqlDbType.VarChar).Value = txtnopesananpembelian.Text.Trim
                                .Add("@kode_b", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(0).Value.ToString
                                .Add("@nama_b", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(1).Value.ToString
                                .Add("@jumlah", SqlDbType.Int).Value = CInt(dgvData.Rows(i).Cells(2).Value.ToString)
                                .Add("@satuan", SqlDbType.VarChar).Value = dgvData.Rows(i).Cells(3).Value.ToString
                            End With
                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    MsgBox("Data pesanan pembelian berhasil diubah", MsgBoxStyle.Information)
                End If
            End If
        End If

    End Sub

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

            txttotal.Text = dgvData.RowCount
            txtkodebarang.Clear()
            txtnamabarang.Clear()
            nud.Value = 0
            cbbsatuan.Items.Clear()
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        FrCariPesananPembelian.Tag = "PesananPembelian"
        FrCariPesananPembelian.ShowDialog()
    End Sub

    Private Sub txtnopesananpembelian_TextChanged(sender As Object, e As EventArgs) Handles txtnopesananpembelian.TextChanged
        dgvData.Rows.Clear()
        query = $"Select ppbd.kode_b, bh.nama_b, ppbd.jumlah, ppbd.satuan from tbPPB_D ppbd inner join tbB_H bh on ppbd.kode_b = bh.kode_b Where no_ppb = '{txtnopesananpembelian.Text}'"
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

    Private Sub btnsearchs_Click(sender As Object, e As EventArgs) Handles btnsearchs.Click
        FrCariSupplier.Tag = "Pesanan"
        FrCariSupplier.ShowDialog()
    End Sub

    Private Sub txtkodebarang_TextChanged(sender As Object, e As EventArgs) Handles txtkodebarang.TextChanged

    End Sub

    Private Sub ckbproses_CheckedChanged(sender As Object, e As EventArgs) Handles ckbproses.CheckedChanged
        If ckbproses.Checked Then
            txtstatus.Text = "Diproses"
        End If
    End Sub
End Class
