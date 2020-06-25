Imports System.Data.SqlClient
Public Class FrLaporanPesananPenjualan

    Sub laporanpesananpenjualan()
        dgvData.ColumnCount = 7
        dgvData.Columns(0).HeaderText = "No Pesanan Pembelian"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.Columns(2).HeaderText = "Nama Pelanggan"
        dgvData.Columns(3).HeaderText = "Nama Barang"
        dgvData.Columns(4).HeaderText = "Jumlah"
        dgvData.Columns(5).HeaderText = "Satuan"
        dgvData.Columns(6).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub
    Private Sub FrLaporanPesananPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        laporanpesananpenjualan()
        dgvData.Rows.Clear()
        query = "Select ppjh.no_ppj, ppjh.tanggal, p.nama_p, bh.nama_b, ppjd.jumlah, ppjd.satuan, ppjd.kadaluarsa from tbPPJ_H ppjh inner join tbPPJ_D ppjd on ppjh.no_ppj = ppjd.no_ppj inner join tbP p on ppjh.kode_p = p.kode_p  inner join tbB_H bh on ppjd.kode_b = bh.kode_b"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4), datareader.Item(5), datareader.Item(6))
            End While
        End If
        datareader.Close()
    End Sub
End Class