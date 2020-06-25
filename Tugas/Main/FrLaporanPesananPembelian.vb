Imports System.Data.SqlClient
Public Class FrLaporanPesananPembelian

    Sub laporanpesananpembelian()
        dgvData.ColumnCount = 6
        dgvData.Columns(0).HeaderText = "No Pesanan Pembelian"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.Columns(2).HeaderText = "Nama Supplier"
        dgvData.Columns(3).HeaderText = "Nama Barang"
        dgvData.Columns(4).HeaderText = "Jumlah"
        dgvData.Columns(5).HeaderText = "Satuan"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub
    Private Sub FrLaporanPesananPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        laporanpesananpembelian()
        query = "Select ppbh.no_ppb, ppbh.tanggal, s.nama_s, bh.nama_b, ppbd.jumlah, ppbd.satuan from tbPPB_H ppbh inner join tbPPB_D ppbd on ppbh.no_ppb = ppbd.no_ppb inner join tbS s on ppbh.kode_s = s.kode_s  inner join tbB_H bh on ppbd.kode_b = bh.kode_b"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4), datareader.Item(5))
            End While
        End If
        datareader.Close()
    End Sub
End Class