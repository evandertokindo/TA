Imports System.Data.SqlClient

Public Class FrDataReturPembelian

    Sub tabel()
        dgvData.ColumnCount = 7
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Harga Beli"
        dgvData.Columns(5).HeaderText = "Sub Total"
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

    Sub bersih()
        txtkodebarang.Clear()
        txtnamabarang.Clear()
        txtkodesupplier.Clear()
        txtnamasupplier.Clear()
        nud.Value = "0"
        txttotal.Clear()
        cbbsatuan.Items.Clear()
        dtpkadaluarsa.Value = Date.Today
        dtpt.Value = Date.Today
        buat_kode()
    End Sub

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select no_r from tbR_H where no_r in(select max(no_r) from tbR_H) order by no_r", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("no_r"), 4) + 1
            urut = "RTR" + Strings.Right("000" & htg, 4)
        Else
            urut = "RTR" & "000" & +1
        End If
        datareader.Close()
        txtnoreturpembelian.Text = urut
    End Sub

    Private Sub FrDataReturPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        buat_kode()
        tabel()
        txtnoreturpembelian.Enabled = False
        txtkodebarang.Enabled = False
        txtnamabarang.Enabled = False
        txtkodesupplier.Enabled = False
        txtnamasupplier.Enabled = False
        txthargabeli.Enabled = False
        dtpt.Enabled = False
        dtpt.Value = Date.Today
        dtpkadaluarsa.Enabled = False
        txttotal.Text = "0"
    End Sub

    Private Sub btnsearchs_Click(sender As Object, e As EventArgs) Handles btnsearchs.Click

        FrCariSupplier.Tag = "Retur"
        FrCariSupplier.ShowDialog()

    End Sub

    Private Function btntambah_Click(sender As Object, e As EventArgs) As DialogResult Handles btntambah.Click

        If (String.IsNullOrWhiteSpace(txtkodebarang.Text) = True) Then
            Return MessageBox.Show("Data Product harus diisi terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If nud.Value = 0 Then
            Return MessageBox.Show("Qty Tidak Boleh 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (String.IsNullOrWhiteSpace(cbbsatuan.Text) = True) Then
            Return MessageBox.Show("Isi Satuan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If belumAdaKodenya() = False Then
            Return MessageBox.Show("Pesanan Produk" & txtkodebarang.Text & " Sudah ada Di List. Harap Hapus Terlebih Dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dgvData.Rows.Add(txtkodebarang.Text, txtnamabarang.Text, nud.Value, cbbsatuan.Text, txthargabeli.Text, txtsubtotal.Text, dtpkadaluarsa.Value)
        Return MessageBox.Show("Pesanan produk " & txtkodebarang.Text & " berhasil ditambahkan", "Tambah Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtkodebarang.Clear()
        txtnamabarang.Clear()
        nud.Value = "0"
        cbbsatuan.Items.Clear()
        txthargabeli.Clear()
        txtsubtotal.Clear()
        dtpkadaluarsa.Value = Date.Today

    End Function

    Private Sub btncaribarang_Click(sender As Object, e As EventArgs) Handles btncaribarang.Click

        FrCariBarang.Tag = "Retur"
        FrCariBarang.ShowDialog()

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click

        If dr Is Nothing Then
            If String.IsNullOrWhiteSpace(txtkodesupplier.Text) = True Then
                MessageBox.Show("Supplier harus dipilih terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If dgvData.Rows.Count = 0 Then
                    MessageBox.Show("Anda belum memasukkan Data Pesanan Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    load_data_1pk("tbR_H")
                    dr = ds.Tables("tbR_H").Rows.Find(txtnoreturpembelian.Text)
                    dr = ds.Tables("tbR_H").NewRow
                    dr(0) = txtnoreturpembelian.Text
                    dr(1) = dtpt.Value
                    dr(2) = txtkodesupplier.Text
                    dr(3) = txtnamasupplier.Text
                    dr(4) = txttotal.Text
                    ds.Tables("tbR_H").Rows.Add(dr)
                    update_data("tbR_H")

                    load_data_1pk("tbR_D")
                    For i As Integer = 0 To dgvData.Rows.Count - 1
                        If txtnoreturpembelian.Text = dr(0) And dgvData.Item(0, i) <> dr(1) Then
                            dr = ds.Tables("tbR_D").NewRow
                            dr(0) = txtnoreturpembelian.Text
                            dr(1) = dgvData.Item(0, i).Value
                            dr(2) = dgvData.Item(1, i).Value
                            dr(3) = dgvData.Item(2, i).Value
                            dr(4) = dgvData.Item(3, i).Value
                            dr(5) = dgvData.Item(4, i).Value
                            dr(6) = dgvData.Item(5, i).Value
                            dr(7) = dgvData.Item(6, i).Value
                            ds.Tables("tbR_D").Rows.Add(dr)
                            update_data("tbR_D")
                        End If
                    Next

                    MessageBox.Show("Data Retur " & txtnoreturpembelian.Text & " berhasil disimpan", "Simpan Data Retur", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If dgvData.Rows.Count = 0 Then
            MessageBox.Show("Anda belum memasukkan Data Pesanan Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim baris As Integer = dgvData.CurrentCell.RowIndex
            If MessageBox.Show("Apakah anda yakin mau menghapus Produk " & dgvData.Item(0, baris).Value & "?", "Hapus Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dgvData.Rows.RemoveAt(baris)
                MessageBox.Show("Produk berhasil dihapus", "Hapus Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)


                txtkodebarang.Clear()
                txtnamabarang.Clear()
                nud.Value = "0"
                cbbsatuan.Items.Clear()
                txthargabeli.Clear()
                txtsubtotal.Clear()
                dtpkadaluarsa.Value = Date.Today
            End If
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        FrCariReturPembelian.ShowDialog()
    End Sub

    Private Sub txtnoreturpembelian_TextChanged(sender As Object, e As EventArgs) Handles txtnoreturpembelian.TextChanged

    End Sub

    Private Sub btncaripembelian_Click(sender As Object, e As EventArgs) Handles btncaripembelian.Click
        FrCariPembelian.Tag = "Retur"
        FrCariPembelian.ShowDialog()
    End Sub
End Class