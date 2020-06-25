Imports System.Data.SqlClient
Public Class FrLaporanPenjualan

    Sub laporanpenjualan()
        dgvData.ColumnCount = 10
        dgvData.Columns(0).HeaderText = "No Penjualan"
        dgvData.Columns(1).HeaderText = "No Pesanan Penjualan"
        dgvData.Columns(2).HeaderText = "Tanggal"
        dgvData.Columns(3).HeaderText = "Nama Pelanggan"
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

    Private Sub FrLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        laporanpenjualan()
        dgvData.Rows.Clear()
        query = "Select pjh.no_pj, ppjh.no_ppj, pjh.tanggal, p.nama_p, bh.nama_b, pjd.jumlah, pjd.satuan, pjd.harga_satuan, pjd.sub_total, pjd.kadaluarsa from tbPJ_H pjh inner join tbPJ_D pjd on pjh.no_pj = pjd.no_pj inner join tbPPJ_H ppjh on ppjh.no_ppj = pjh.no_ppj inner join tbP p on pjh.kode_p = p.kode_p  inner join tbB_H bh on pjd.kode_b = bh.kode_b"
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