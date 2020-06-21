Imports System.Data.SqlClient
Imports System.Linq
Imports System.Collections

Public Class FrDataPenjualan

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select no_pj from tbPJ_H where no_pj in(select max(no_pj) from tbPJ_H) order by no_pj", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("no_pj"), 4) + 1
            urut = "FPJ" + Strings.Right("000" & htg, 4)
        Else
            urut = "FPJ" & "000" & +1
        End If
        datareader.Close()
        txtnofaktur.Text = urut
        conn.Close()
    End Sub

    Sub hitung_subtotal()
        Dim hitung As Decimal
        hitung = nud.Value * txtharga.Text
        txtsubtotal.Text = hitung
    End Sub

    Sub tabel()
        dgvData.ColumnCount = 7
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Harga"
        dgvData.Columns(5).HeaderText = "SubTotal"
        dgvData.Columns(6).HeaderText = "Kadaluarsa"
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

    Private Sub FrPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        buat_kode()
        tabel()
        txtnofaktur.Enabled = False
        txtkodebarang.Enabled = False
        txtnamabarang.Enabled = False
        txtkodepelanggan.Enabled = False
        txtnamapelanggan.Enabled = False
        dtpt.Enabled = False
        dtpt.Value = Date.Today
        dtpkadaluarsa.Enabled = False
        txttotal.Text = "0"
        txtsubtotal.Enabled = False
        txttotal.Enabled = False
        txtstok.Enabled = False

    End Sub

    Private Sub btncaripelanggan_Click(sender As Object, e As EventArgs) Handles btncaripelanggan.Click
        FrCariPelanggan.Tag = "Penjualan"
        FrCariPelanggan.ShowDialog()

    End Sub

    Private Sub btncaribarang_Click(sender As Object, e As EventArgs) Handles btncaribarang.Click
        FrCariBarang.Tag = "Penjualan"
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
                'txttotal.Text = dgvData.Rows.Count
            End If
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click

        If dr Is Nothing Then
            If String.IsNullOrWhiteSpace(txtkodepelanggan.Text) = True Then
                MessageBox.Show("Supplier harus dipilih terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If dgvData.Rows.Count = 0 Then
                    MessageBox.Show("Anda belum memasukkan Data Pesanan Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    load_data_1pk("tbPJ_H")
                    dr = ds.Tables("tbPJ_H").Rows.Find(txtnofaktur.Text)
                    dr = ds.Tables("tbPJ_H").NewRow
                    dr(0) = txtnofaktur.Text
                    dr(1) = dtpt.Value
                    dr(2) = txtkodepelanggan.Text
                    dr(3) = txtnamapelanggan.Text
                    dr(4) = txttotal.Text
                    ds.Tables("tbPJ_H").Rows.Add(dr)
                    update_data("tbPJ_H")

                    load_data_1pk("tbPJ_D")
                    For i As Integer = 0 To dgvData.Rows.Count - 1
                        dr = ds.Tables("tbPJ_D").NewRow
                        dr(0) = txtnofaktur.Text
                        dr(1) = dgvData.Item(0, i).Value
                        dr(2) = dgvData.Item(1, i).Value
                        dr(3) = dgvData.Item(2, i).Value
                        dr(4) = dgvData.Item(3, i).Value
                        dr(5) = dgvData.Item(4, i).Value
                        dr(6) = dgvData.Item(5, i).Value
                        dr(7) = dgvData.Item(6, i).Value
                        ds.Tables("tbPJ_D").Rows.Add(dr)
                        update_data("tbPJ_D")

                    Next
                    MessageBox.Show("Data Pejualan " & txtnofaktur.Text & " berhasil disimpan", "Simpan Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Private Sub txtkodebarang_TextChanged(sender As Object, e As EventArgs) Handles txtkodebarang.TextChanged

    End Sub

    Dim jumlahIsValid As Boolean
    'Public stock As Integer
    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nud.ValueChanged
        If (nud.Value > txtstok.Text) Then
            nud.BackColor = Color.Red
            jumlahIsValid = False
            MessageBox.Show("Data Yang Dimasukkan Melebihi Stok", "Informasi Stok", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            nud.BackColor = Color.White
            jumlahIsValid = True
        End If

        hitung_subtotal()

    End Sub

    Private Function btntambah_Click(sender As Object, e As EventArgs) As DialogResult Handles btntambah.Click
        If (String.IsNullOrWhiteSpace(txtkodebarang.Text) = True) Then
            Return MessageBox.Show("Data Product harus diisi terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If nud.Value = 0 Then
            Return MessageBox.Show("Qty Tidak Boleh 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If jumlahIsValid = False Then
            Return MessageBox.Show("Qty Tidak Boleh lebih dari stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (String.IsNullOrWhiteSpace(cbbsatuan.Text) = True) Then
            Return MessageBox.Show("Isi Satuan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If belumAdaKodenya() = False Then
            Return MessageBox.Show("Pesanan Produk" & txtkodebarang.Text & " Sudah ada Di List. Harap Hapus Terlebih Dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dgvData.Rows.Add(txtkodebarang.Text, txtnamabarang.Text, nud.Value, cbbsatuan.Text, txtharga.Text, txtsubtotal.Text, dtpkadaluarsa.Value)
        Return MessageBox.Show("Pesanan produk " & txtkodebarang.Text & " berhasil ditambahkan", "Tambah Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Function

    Private Sub cbbsatuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbsatuan.SelectedIndexChanged

    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged
        hitung_subtotal()

    End Sub

    Private Sub btncarifaktur_Click(sender As Object, e As EventArgs) Handles btncarifaktur.Click
        FrCariPenjualan.ShowDialog()
    End Sub
End Class