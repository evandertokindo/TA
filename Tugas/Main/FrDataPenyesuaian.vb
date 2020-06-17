Imports System.Data.SqlClient

Public Class FrDataPenyesuaian

    Sub tabel()
        dgvData.ColumnCount = 8
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Kadaluarsa"
        dgvData.Columns(5).HeaderText = "Jumlah Fisik"
        dgvData.Columns(6).HeaderText = "Selisih"
        dgvData.Columns(7).HeaderText = "Keterangan"
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

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select nota_faktur from tbN where nota_faktur in(select max(nota_faktur) from tbN) order by nota_faktur", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("nota_faktur"), 4) + 1
            urut = "NFR" + Strings.Right("000" & htg, 4)
        Else
            urut = "NFR" & "000" & +1
        End If
        datareader.Close()
        txtnopenyesuaian.Text = urut
        conn.Close()
    End Sub

    Private Sub FrPenyesuaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = FrMainMenu
        koneksi()
        buat_kode()
        tabel()
        txtnopenyesuaian.Enabled = False
        txtkodebarang.Enabled = False
        txtnamabarang.Enabled = False
        txtjumlahsistem.Enabled = False
        txtnamabarang.Enabled = False
        dtpt.Enabled = False
        dtpt.Value = Date.Today
        dtpkadaluarsa.Enabled = False

    End Sub

    Private Sub btncaripenyesuaian_Click(sender As Object, e As EventArgs) Handles btncaripenyesuaian.Click

        FrCariPenyesuaian.Tag = "Penyesuaian"
        FrCariPenyesuaian.ShowDialog()

    End Sub

    Private Function btntambah_Click(sender As Object, e As EventArgs) As DialogResult Handles btntambah.Click

        If (String.IsNullOrWhiteSpace(txtkodebarang.Text) = True) Then
            Return MessageBox.Show("Data Product harus diisi terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If nudfisik.Value = 0 Then
            Return MessageBox.Show("Qty Tidak Boleh 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (String.IsNullOrWhiteSpace(cbbsatuansistem.Text) = True) Then
            Return MessageBox.Show("Isi Satuan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (String.IsNullOrWhiteSpace(txtketerangan.Text) = True) Then
            Return MessageBox.Show("Isi Keterangan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (String.IsNullOrWhiteSpace(txtselisih.Text) = True) Then
            Return MessageBox.Show("Isi Selisih", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If belumAdaKodenya() = False Then
            Return MessageBox.Show("Pesanan Produk" & txtkodebarang.Text & " Sudah ada Di List. Harap Hapus Terlebih Dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dgvData.Rows.Add(txtkodebarang.Text, txtnamabarang.Text, txtjumlahsistem.Text, cbbsatuansistem.Text, dtpkadaluarsa.Value, nudfisik.Value, txtselisih.Text, txtketerangan.Text)
        Return MessageBox.Show("Pesanan produk " & txtkodebarang.Text & " berhasil ditambahkan", "Tambah Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Function

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

    Private Sub btncaribarang_Click(sender As Object, e As EventArgs) Handles btncaribarang.Click

        'FrCariBarang.Tag = "Penyesuaian"
        FrCariBarang.ShowDialog()

    End Sub


End Class