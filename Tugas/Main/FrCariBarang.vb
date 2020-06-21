Imports System.Data.SqlClient

Public Class FrCariBarang

    'Sub barang()
    '    dgvData.ColumnCount = 12
    '    dgvData.Columns(0).HeaderText = "Kode Barang"
    '    dgvData.Columns(1).HeaderText = "Nama Barang"
    '    dgvData.Columns(2).HeaderText = "Satuan Besar"
    '    dgvData.Columns(3).HeaderText = "Konversi Ke Sedang"
    '    dgvData.Columns(4).HeaderText = "Satuan Sedang"
    '    dgvData.Columns(5).HeaderText = "Konversi Ke Kecil"
    '    dgvData.Columns(6).HeaderText = "Satuan Kecil"
    '    dgvData.Columns(7).HeaderText = "Jumlah"
    '    dgvData.Columns(8).HeaderText = "Satuan"
    '    dgvData.Columns(9).HeaderText = "Harga Ecer"
    '    dgvData.Columns(10).HeaderText = "Harga Grosir"
    '    dgvData.Columns(11).HeaderText = "Kadaluarsa"
    '    dgvData.ReadOnly = True
    '    dgvData.AllowUserToAddRows = False
    '    dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    dgvData.RowHeadersVisible = False
    'End Sub

    Sub baru()

        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Sub pesanan()

        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Sub pembelian()

        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Sub penjualan()

        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Sub retur()

        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Sub penyesuaian()

        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Private Sub FrCariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        dgvData.Rows.Clear()

        If Me.Tag = "Pesanan" Then
            pesanan()
            query = $"Select bd.kode_b, bh.nama_b, bd.jumlah, bd.satuan, bd.kadaluarsa from tbB_H bh inner join tbB_D bd on bh.kode_b = bd.kode_b"
        ElseIf Me.Tag = "Pembelian" Then
            pembelian()
            query = $"Select ppbd.kode_b, bh.nama_b, ppbd.jumlah, ppbd.satuan, bd.kadaluarsa from tbPPB_H ppbh inner join tbPPB_D ppbd on ppbh.no_ppb = ppbd.no_ppb inner join tbB_D bd on bd.kode_b = ppbd.kode_b inner join tbB_H bh on bh.kode_b = bd.kode_b where ppbd.no_ppb ='{FrDataPembelian.txtnopesananpembelian.Text}'"
        ElseIf Me.Tag = "Penjualan" Then
            penjualan()
            query = $"Select pjd.kode_b, bh.nama_b, pjd.jumlah, pjd.satuan, pjd.kadaluarsa from tbPJ_H pjh inner join tbPJ_D pjd on pjh.no_pj = pjd.no_pj inner join tbB_D bd on bd.kode_b = pjd.kode_b inner join tbB_H bh on bh.kode_b = bd.kode_b where pjd.no_pj ='{FrDataPenjualan.txtnofaktur.Text}'"
        ElseIf Me.Tag = "Retur" Then
            retur()
            query = $"Select rd.kode_b, bh.nama_b, rd.jumlah, rd.satuan, rd.kadaluarsa from tbR_H rh inner join tbR_D rd on rh.no_r = rd.no_r inner join tbB_D bd on bd.kode_b = rd.kode_b inner join tbB_H bh on bh.kode_b = bd.kode_b where rd.no_r ='{FrDataReturPembelian.txtnoreturpembelian.Text}'"
            cmd = New SqlCommand(query, conn)
        ElseIf Me.Tag = "Penyesuaian" Then
            penyesuaian()
            query = $"Select pyd.kode_b, bh.nama_b, pyd.jumlah, pyd.satuan, pyd.kadaluarsa from tbPY_H pyh inner join tbPY_D pyd on pyh.no_py = pyd.no_py inner join tbB_D bd on bd.kode_b = pyd.kode_b inner join tbB_H bh on bh.kode_b = bd.kode_b where pyd.no_py ='{FrDataReturPembelian.txtnoreturpembelian.Text}'"
        End If
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4))
            End While
        End If
        datareader.Close()

    End Sub

    Private Sub dgvData_DoubleClick(sender As Object, e As EventArgs) Handles dgvData.DoubleClick
        Dim baris As Integer

        baris = dgvData.CurrentCell.RowIndex
        If Me.Tag = "Pesanan" Then
            FrDataPesananPembelian.txtkodebarang.Text = dgvData.Item(0, baris).Value
            FrDataPesananPembelian.txtnamabarang.Text = dgvData.Item(1, baris).Value
            FrDataPesananPembelian.nud.Value = dgvData.Item(2, baris).Value
            query = $"Select bh.satuan_besar, bh.satuan_sedang, bh.satuan_kecil from tbB_H bh inner join tbB_D bd  on bh.kode_b = bd.kode_b where bh.kode_b = '{FrDataPesananPembelian.txtkodebarang.Text}'"
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    FrDataPesananPembelian.cbbsatuan.Items.Clear()
                    FrDataPesananPembelian.cbbsatuan.Items.Add(datareader.Item("satuan_besar"))
                    FrDataPesananPembelian.cbbsatuan.Items.Add(datareader.Item("satuan_sedang"))
                    FrDataPesananPembelian.cbbsatuan.Items.Add(datareader.Item("satuan_kecil"))
                End While
            End If
            datareader.Close()
            FrDataPesananPembelian.cbbsatuan.Text = dgvData.Item(3, baris).Value

        ElseIf Me.Tag = "Retur" Then
            FrDataReturPembelian.txtkodebarang.Text = dgvData.Item(0, baris).Value
            FrDataReturPembelian.txtnamabarang.Text = dgvData.Item(1, baris).Value
        ElseIf Me.Tag = "Penjualan" Then
            FrDataPenjualan.txtkodebarang.Text = dgvData.Item(0, baris).Value
            FrDataPenjualan.txtnamabarang.Text = dgvData.Item(1, baris).Value
        ElseIf Me.Tag = "Pembelian" Then
            FrDataPembelian.txtkodebarang.Text = dgvData.Item(0, baris).Value
            FrDataPembelian.txtnamabarang.Text = dgvData.Item(1, baris).Value
        End If

        Me.Close()

    End Sub

End Class