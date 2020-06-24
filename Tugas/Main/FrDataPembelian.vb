Imports System.Data.SqlClient

Public Class FrDataPembelian

    Sub tabel()
        dgvData.ColumnCount = 7
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Harga"
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
        txtnopesananpembelian.Clear()
        txtkodebarang.Clear()
        txtnamabarang.Clear()
        txtkodesupplier.Clear()
        txtnamasupplier.Clear()
        nud.Value = "0"
        txttotal.Clear()
        cbbsatuan.Items.Clear()
        dtpt.Value = Date.Today
        dtpkadaluarsa.Value = Date.Today
        buat_kode()
    End Sub

    Sub hitung_subtotal()
        Dim subtotal As Decimal
        subtotal = nud.Value * txtharga.Text
        txtsubtotal.Text = subtotal
    End Sub

    Sub hitung_total()
        Dim total As Decimal
        For i As Integer = 0 To dgvData.Rows.Count - 1
            total += dgvData.Item(6, i).Value
        Next
        txttotal.Text = total
    End Sub

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select no_pb from tbPB_H where no_pb in(select max(no_pb) from tbPB_H) order by no_pb", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("no_pb"), 4) + 1
            urut = "NPB" + Strings.Right("000" & htg, 4)
        Else
            urut = "NPB" & "000" & +1
        End If
        datareader.Close()
        txtnopembelian.Text = urut
        conn.Close()
    End Sub

    Private Sub FrPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = FrMainMenu
        koneksi()
        buat_kode()
        tabel()
        txtnopembelian.Enabled = False
        txtnopesananpembelian.Enabled = False
        txtkodesupplier.Enabled = False
        txtnamasupplier.Enabled = False
        txtkodebarang.Enabled = False
        txtkodebarang.Enabled = False
        dtpt.Value = Date.Today
        dtpt.Enabled = False
        If txtnopesananpembelian.Text = "" Then
            btncaribarang.Enabled = False
        End If
        txtsubtotal.Enabled = False
        txtnamabarang.Enabled = False
        txttotal.Enabled = False
        cbbsatuan.Enabled = False

    End Sub

    Private Sub btncarisupplier_Click(sender As Object, e As EventArgs)

        FrCariSupplier.Tag = "Pembelian"
        FrCariSupplier.Show()

    End Sub

    Private Sub btncaribarang_Click(sender As Object, e As EventArgs) Handles btncaribarang.Click

        FrCariBarang.Tag = "Pembelian"
        FrCariBarang.Show()

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If dgvData.Rows.Count = 0 Then
            MessageBox.Show("Anda belum memasukkan Data Pesanan Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim baris As Integer = dgvData.CurrentCell.RowIndex
            If MessageBox.Show("Apakah anda yakin mau menghapus Produk " & dgvData.Item(0, baris).Value & "?", "Hapus Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dgvData.Rows.RemoveAt(baris)
                MessageBox.Show("Produk berhasil dihapus", "Hapus Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                hitung_total()
            End If
        End If
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

        dgvData.Rows.Add(txtkodebarang.Text, txtnamabarang.Text, nud.Value, cbbsatuan.Text, txtharga.Text, txtsubtotal.Text, dtpkadaluarsa.Value)
        Return MessageBox.Show("Pesanan produk " & txtkodebarang.Text & " berhasil ditambahkan", "Tambah Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        hitung_total()
        txtkodebarang.Clear()
        txtnamabarang.Clear()
        nud.Value = "0"
        cbbsatuan.Items.Clear()
        txtharga.Clear()
        txtsubtotal.Clear()
        dtpkadaluarsa.Value = Date.Today

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrCariPesananPembelian.Tag = "Pembelian"
        FrCariPesananPembelian.ShowDialog()
    End Sub

    Private Sub txtnopesananpembelian_TextChanged(sender As Object, e As EventArgs) Handles txtnopesananpembelian.TextChanged
        If txtnopesananpembelian.Text <> "" Then
            btncaribarang.Enabled = True
        End If
    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged
        If txtharga.Text = "0" Or txtharga.Text = "" Then

        Else
            hitung_subtotal()
        End If
    End Sub

    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nud.ValueChanged
        If txtharga.Text = "0" Or txtharga.Text = "" Then

        Else
            hitung_subtotal()
        End If
    End Sub
End Class