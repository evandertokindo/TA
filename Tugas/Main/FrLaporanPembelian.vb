Imports System.Data.SqlClient
Public Class FrLaporanPembelian

    Sub laporanpembelian()
        dgvData.ColumnCount = 10
        dgvData.Columns(0).HeaderText = "No Pembelian"
        dgvData.Columns(1).HeaderText = "No Pesanan Pembelian"
        dgvData.Columns(2).HeaderText = "Tanggal"
        dgvData.Columns(3).HeaderText = "Nama Supplier"
        dgvData.Columns(4).HeaderText = "Nama Barang"
        dgvData.Columns(5).HeaderText = "Jumlah"
        dgvData.Columns(6).HeaderText = "Satuan"
        dgvData.Columns(7).HeaderText = "Harga Satuan"
        dgvData.Columns(8).HeaderText = "Sub Total"
        dgvData.Columns(9).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub FrLaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        laporanpembelian()
        dgvData.Rows.Clear()
        query = "Select pbh.no_pb, ppbh.no_ppb, pbh.tanggal, s.nama_s, bh.nama_b, pbd.jumlah, pbd.satuan, pbd.harga_satuan, pbd.sub_total, pbd.kadaluarsa from tbPB_H pbh inner join tbPB_D pbd on pbh.no_pb = pbd.no_pb inner join tbPPB_H ppbh on ppbh.no_ppb = pbh.no_ppb inner join tbS s on pbh.kode_s = s.kode_s  inner join tbB_H bh on pbd.kode_b = bh.kode_b"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4), datareader.Item(5), datareader.Item(6), datareader.Item(7), datareader.Item(8), datareader.Item(9))
            End While
        End If
        datareader.Close()
    End Sub
End Class