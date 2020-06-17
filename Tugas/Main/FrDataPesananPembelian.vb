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

    'Sub hitung_jenis()
    '    Dim jenis_barang = 0
    '    For i = 0 To dgvData.Columns.Count - 1
    '        jenis_barang += 1
    '    Next
    '    txttotal.Text = jenis_barang
    'End Sub

    Function belumAdaKodenya() As Boolean
        Dim jlh = 0
        For i As Integer = 0 To dgvData.Rows.Count - 1
            If txtkodebarang.Text = dgvData.Item(0, i).Value Then
                jlh += 1
            End If
        Next
        Return (jlh = 0)
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

    End Sub

    Private Sub btnsbar_Click(sender As Object, e As EventArgs) Handles btnsbar.Click

        'FrCariBarang.Tag = "Pesanan"
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

        If dr Is Nothing Then
            If String.IsNullOrWhiteSpace(txtkodesupplier.Text) = True Then
                MessageBox.Show("Supplier harus dipilih terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If dgvData.Rows.Count = 0 Then
                    MessageBox.Show("Anda belum memasukkan Data Pesanan Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    load_data_1pk("tbPPB_H")
                    dr = ds.Tables("tbPPB_H").Rows.Find(txtnopesananpembelian.Text)
                    dr = ds.Tables("tbPPB_H").NewRow
                    dr(0) = txtnopesananpembelian.Text
                    dr(1) = dtpt.Value
                    dr(2) = txtkodesupplier.Text
                    dr(3) = txtnamasupplier.Text
                    dr(4) = txttotal.Text
                    ds.Tables("tbPPB_H").Rows.Add(dr)
                    update_data("tbPPB_H")

                    load_data_1pk("tbPPB_D")
                    For i As Integer = 0 To dgvData.Rows.Count - 1
                        dr = ds.Tables("tbPPB_D").NewRow
                        dr(0) = txtnopesananpembelian.Text
                        dr(1) = dgvData.Item(0, i).Value
                        dr(2) = dgvData.Item(1, i).Value
                        dr(3) = dgvData.Item(2, i).Value
                        dr(4) = dgvData.Item(3, i).Value
                        ds.Tables("tbPPB_D").Rows.Add(dr)
                        update_data("tbPPB_D")

                    Next

                    MessageBox.Show("Pesanan " & txtnopesananpembelian.Text & " berhasil disimpan", "Simpan Pesanan Pembelian", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class