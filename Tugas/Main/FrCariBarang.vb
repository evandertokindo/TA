Imports System.Data.SqlClient

Public Class FrCariBarang

    Sub barang()
        dgvData.ColumnCount = 12
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Satuan Besar"
        dgvData.Columns(3).HeaderText = "Konversi Ke Sedang"
        dgvData.Columns(4).HeaderText = "Satuan Sedang"
        dgvData.Columns(5).HeaderText = "Konversi Ke Kecil"
        dgvData.Columns(6).HeaderText = "Satuan Kecil"
        dgvData.Columns(7).HeaderText = "Jumlah"
        dgvData.Columns(8).HeaderText = "Satuan"
        dgvData.Columns(9).HeaderText = "Harga Ecer"
        dgvData.Columns(10).HeaderText = "Harga Grosir"
        dgvData.Columns(11).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    'Sub barang()

    '    dgvData.ColumnCount = 4
    '    dgvData.Columns(0).HeaderText = "Kode Barang"
    '    dgvData.Columns(1).HeaderText = "Nama Barang"
    '    dgvData.Columns(2).HeaderText = "No. Telepon"
    '    dgvData.Columns(3).HeaderText = "Alamat"
    '    dgvData.ReadOnly = True
    '    dgvData.AllowUserToAddRows = False
    '    dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    dgvData.RowHeadersVisible = False

    'End Sub

    'Sub pesanan()

    '    dgvData.ColumnCount = 4
    '    dgvData.Columns(0).HeaderText = "Kode Barang"
    '    dgvData.Columns(1).HeaderText = "Nama Barang"
    '    dgvData.Columns(2).HeaderText = "No. Telepon"
    '    dgvData.Columns(3).HeaderText = "Alamat"
    '    dgvData.ReadOnly = True
    '    dgvData.AllowUserToAddRows = False
    '    dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    dgvData.RowHeadersVisible = False

    'End Sub

    'Sub pembelian()

    '    dgvData.ColumnCount = 4
    '    dgvData.Columns(0).HeaderText = "Kode Barang"
    '    dgvData.Columns(1).HeaderText = "Nama Barang"
    '    dgvData.Columns(2).HeaderText = "No. Telepon"
    '    dgvData.Columns(3).HeaderText = "Alamat"
    '    dgvData.ReadOnly = True
    '    dgvData.AllowUserToAddRows = False
    '    dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    dgvData.RowHeadersVisible = False

    'End Sub

    'Sub penjualan()

    '    dgvData.ColumnCount = 4
    '    dgvData.Columns(0).HeaderText = "Kode Barang"
    '    dgvData.Columns(1).HeaderText = "Nama Barang"
    '    dgvData.Columns(2).HeaderText = "No. Telepon"
    '    dgvData.Columns(3).HeaderText = "Alamat"
    '    dgvData.ReadOnly = True
    '    dgvData.AllowUserToAddRows = False
    '    dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    dgvData.RowHeadersVisible = False

    'End Sub

    'Sub retur()

    '    dgvData.ColumnCount = 4
    '    dgvData.Columns(0).HeaderText = "Kode Barang"
    '    dgvData.Columns(1).HeaderText = "Nama Barang"
    '    dgvData.Columns(2).HeaderText = "No. Telepon"
    '    dgvData.Columns(3).HeaderText = "Alamat"
    '    dgvData.ReadOnly = True
    '    dgvData.AllowUserToAddRows = False
    '    dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    dgvData.RowHeadersVisible = False

    'End Sub

    'Sub penyesuaian()

    '    dgvData.ColumnCount = 4
    '    dgvData.Columns(0).HeaderText = "Kode Barang"
    '    dgvData.Columns(1).HeaderText = "Nama Barang"
    '    dgvData.Columns(2).HeaderText = "No. Telepon"
    '    dgvData.Columns(3).HeaderText = "Alamat"
    '    dgvData.ReadOnly = True
    '    dgvData.AllowUserToAddRows = False
    '    dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    dgvData.RowHeadersVisible = False

    'End Sub

    Private Sub FrCariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        dgvData.Rows.Clear()
        barang()
        query = "Select bh.kode_b, bh.nama_b, bh.satuan_besar, bh.konversi_sedang, bh.satuan_sedang, bh.konversi_kecil, bh.satuan_kecil, bd.jumlah, bd.satuan, bd.harga_ecer, bd.harga_grosir, bd.kadaluarsa From tbB_H bh inner join tbB_D bd On bh.kode_b = bd.kode_b"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read()
                dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3), datareader(4), datareader(5), datareader(6), datareader(7), datareader(8), datareader(9), datareader(10), datareader(11))
            End While
        End If

        'If Me.Tag = "Barang" Then
        '    barang()
        '    query = "Select * from tbP"
        '    cmd = New SqlCommand(query, conn)
        '    datareader = cmd.ExecuteReader
        '    If datareader.HasRows Then
        '        While datareader.Read
        '            dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
        '        End While
        '    End If
        '    datareader.Close()
        'ElseIf Me.Tag = "Pesanan" Then
        '    pesanan()
        '    query = "Select * from tbP"
        '    cmd = New SqlCommand(query, conn)
        '    datareader = cmd.ExecuteReader
        '    If datareader.HasRows Then
        '        While datareader.Read
        '            dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
        '        End While
        '    End If
        '    datareader.Close()
        'ElseIf Me.Tag = "Pembelian" Then
        '    pembelian()
        '    query = "Select * from tbP"
        '    cmd = New SqlCommand(query, conn)
        '    datareader = cmd.ExecuteReader
        '    If datareader.HasRows Then
        '        While datareader.Read
        '            dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
        '        End While
        '    End If
        '    datareader.Close()
        'ElseIf Me.Tag = "Penjualan" Then
        '    penjualan()
        '    query = "Select * from tbP"
        '    cmd = New SqlCommand(query, conn)
        '    datareader = cmd.ExecuteReader
        '    If datareader.HasRows Then
        '        While datareader.Read
        '            dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
        '        End While
        '    End If
        '    datareader.Close()
        'ElseIf Me.Tag = "Retur" Then
        '    retur()
        '    query = "Select * from tbP"
        '    cmd = New SqlCommand(query, conn)
        '    datareader = cmd.ExecuteReader
        '    If datareader.HasRows Then
        '        While datareader.Read
        '            dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
        '        End While
        '    End If
        '    datareader.Close()
        'ElseIf Me.Tag = "Penyesuaian" Then
        '    penyesuaian()
        '    query = "Select * from tbP"
        '    cmd = New SqlCommand(query, conn)
        '    datareader = cmd.ExecuteReader
        '    If datareader.HasRows Then
        '        While datareader.Read
        '            dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(4))
        '        End While
        '    End If
        '    datareader.Close()
        'End If

    End Sub

    Private Sub dgvData_DoubleClick(sender As Object, e As EventArgs) Handles dgvData.DoubleClick
        Dim baris As Integer

        baris = dgvData.CurrentCell.RowIndex
        'If Me.Tag = "Barang" Then
        '    FrDataBarang.txtkodebarang.Text = dgvData.Item(0, baris).Value
        '    FrDataBarang.txtnamabarang.Text = dgvData.Item(1, baris).Value
        '    FrDataBarang.txthargaecer.Text = dgvData.Item(2, baris).Value
        '    FrDataBarang.txthargagrosir.Text = dgvData.Item(3, baris).Value
        'ElseIf Me.Tag = "Pesanan" Then
        '    FrDataPesananPembelian.txtkodebarang.Text = dgvData.Item(0, baris).Value
        '    FrDataPesananPembelian.txtnamabarang.Text = dgvData.Item(1, baris).Value
        '    'FrDataPesananPembelian.txtjumlah.Text = dgvData.Item(2, baris).Value
        '    'FrDataPesananPembelian.cbbsatuan.Text = dgvData.Item(3, baris).Value
        'ElseIf Me.Tag = "Retur" Then
        '    FrDataReturPembelian.txtkodebarang.Text = dgvData.Item(0, baris).Value
        '    FrDataReturPembelian.txtnamabarang.Text = dgvData.Item(1, baris).Value
        '    'FrDataReturPembelian.txtkodebarang.Text = dgvData.Item(2, baris).Value
        'ElseIf Me.Tag = "Penjualan" Then
        '    FrDataPenjualan.txtkodebarang.Text = dgvData.Item(0, baris).Value
        '    FrDataPenjualan.txtnamabarang.Text = dgvData.Item(1, baris).Value
        'ElseIf Me.Tag = "Pembelian" Then
        '    FrDataPembelian.txtkodebarang.Text = dgvData.Item(0, baris).Value
        '    FrDataPembelian.txtnamabarang.Text = dgvData.Item(1, baris).Value
        'End If

        Dim f1 As FrDataBarang = FrDataBarang
        f1.txtkodebarang.Text = dgvData.Item(0, baris).Value
        f1.txtnamabarang.Text = dgvData.Item(1, baris).Value

        Dim f2 As FrDataPesananPembelian = FrDataPesananPembelian
        f2.txtkodebarang.Text = dgvData.Item(0, baris).Value
        f2.txtnamabarang.Text = dgvData.Item(1, baris).Value
        datareader.Close()
        query = $"Select bh.satuan_besar, bh.satuan_sedang, bh.satuan_kecil from tbB_H bh inner join tbB_D bd  on bh.kode_b = bd.kode_b where bh.kode_b = '{f2.txtkodebarang.Text}'"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                f2.cbbsatuan.Items.Clear()
                f2.cbbsatuan.Items.Add(datareader.Item("satuan_besar"))
                f2.cbbsatuan.Items.Add(datareader.Item("satuan_sedang"))
                f2.cbbsatuan.Items.Add(datareader.Item("satuan_kecil"))
            End While
        End If
        datareader.Close()
        'f2.cbbsatuan.Text = dgvData.Item(8, baris).Value

        'Dim f3 As FrDataPembelian = FrDataPembelian
        'f3.txtkodebarang.Text = dgvData.Item(0, baris).Value
        'f3.txtnamabarang.Text = dgvData.Item(1, baris).Value
        'query = $"Select bh.satuan_besar, bh.satuan_sedang, bh.satuan_kecil from tbB_H bh inner join tbB_D bd  on bh.kode_b = bd.kode_b where bh.kode_b = '{f3.txtkodebarang.Text}'"
        'cmd = New SqlCommand(query, conn)
        'datareader = cmd.ExecuteReader
        'If datareader.HasRows Then
        '    While datareader.Read
        '        f3.cbbsatuan.Items.Clear()
        '        f3.cbbsatuan.Items.Add(datareader.Item("satuan_besar"))
        '        f3.cbbsatuan.Items.Add(datareader.Item("satuan_sedang"))
        '        f3.cbbsatuan.Items.Add(datareader.Item("satuan_kecil"))
        '    End While
        'End If
        'datareader.Close()

        Dim f4 As FrDataPenjualan = FrDataPenjualan
        f4.txtkodebarang.Text = dgvData.Item(0, baris).Value
        f4.txtnamabarang.Text = dgvData.Item(1, baris).Value
        'f4.stock = CInt(dgvData.Item(7, baris).Value)
        f4.txtharga.Text = dgvData.Item(9, baris).Value

        datareader.Close()
        query = $"Select bh.satuan_besar, bh.satuan_sedang, bh.satuan_kecil from tbB_H bh inner join tbB_D bd  on bh.kode_b = bd.kode_b where bh.kode_b = '{f4.txtkodebarang.Text}'"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                f4.cbbsatuan.Items.Clear()
                f4.cbbsatuan.Items.Add(datareader.Item("satuan_besar"))
                f4.cbbsatuan.Items.Add(datareader.Item("satuan_sedang"))
                f4.cbbsatuan.Items.Add(datareader.Item("satuan_kecil"))
            End While
        End If
        datareader.Close()
        f4.txtstok.Text = dgvData.Item(7, baris).Value

        'If f4.cbbsatuan.Text = dgvData.Item(2, baris).Value Then
        '    f4.txtstok.Text = dgvData.Item(3, baris).Value
        'ElseIf f4.cbbsatuan.Text = dgvData.Item(4, baris).Value Then
        '    f4.txtstok.Text = dgvData.Item(5, baris).Value
        'ElseIf f4.cbbsatuan.Text = dgvData.Item(6, baris).Value Then
        '    f4.txtstok.Text = dgvData.Item(7, baris).Value
        'End If
        'f4.cbbsatuan.Text = dgvData.Item(8, baris).Value


        Dim f5 As FrDataPenyesuaian = FrDataPenyesuaian
        f5.txtkodebarang.Text = dgvData.Item(0, baris).Value
        f5.txtnamabarang.Text = dgvData.Item(1, baris).Value
        f5.txtjumlahsistem.Text = dgvData.Item(7, baris).Value

        'datareader.Close()
        'query = $"Select bh.satuan_besar, bh.satuan_sedang, bh.satuan_kecil from tbB_H bh inner join tbB_D bd  on bh.kode_b = bd.kode_b where bh.kode_b = '{f5.txtkodebarang.Text}'"
        'cmd = New SqlCommand(query, conn)
        'datareader = cmd.ExecuteReader
        'If datareader.HasRows Then
        '    While datareader.Read
        '        f5.cbbsatuan.Items.Clear()
        '        f5.cbbsatuan.Items.Add(datareader.Item("satuan_besar"))
        '        f5.cbbsatuan.Items.Add(datareader.Item("satuan_sedang"))
        '        f5.cbbsatuan.Items.Add(datareader.Item("satuan_kecil"))
        '    End While
        'End If
        'datareader.Close()
        'f5.cbbsatuan.Text = dgvData.Item(8, baris).Value

        Dim f6 As FrDataReturPembelian = FrDataReturPembelian
        f6.txtkodebarang.Text = dgvData.Item(0, baris).Value
        f6.txtnamabarang.Text = dgvData.Item(1, baris).Value
        datareader.Close()
        query = $"Select bh.satuan_besar, bh.satuan_sedang, bh.satuan_kecil from tbB_H bh inner join tbB_D bd  on bh.kode_b = bd.kode_b where bh.kode_b = '{f4.txtkodebarang.Text}'"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                f6.cbbsatuan.Items.Clear()
                f6.cbbsatuan.Items.Add(datareader.Item("satuan_besar"))
                f6.cbbsatuan.Items.Add(datareader.Item("satuan_sedang"))
                f6.cbbsatuan.Items.Add(datareader.Item("satuan_kecil"))
            End While
        End If
        datareader.Close()
        f6.cbbsatuan.Text = dgvData.Item(8, baris).Value
        f6.txthargabeli.Text = dgvData.Item(9, baris).Value
        f6.dtpkadaluarsa.Value = dgvData.Item(11, baris).Value

        Me.Close()

    End Sub
End Class