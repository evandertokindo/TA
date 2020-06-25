Imports System.Data.SqlClient
Public Class FrLaporanPenyesuaian

    Sub laporanpenyesuaian()
        dgvData.ColumnCount = 9
        dgvData.Columns(0).HeaderText = "No Penyesuaian"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.Columns(2).HeaderText = "Nama Barang"
        dgvData.Columns(3).HeaderText = "Jumlah"
        dgvData.Columns(4).HeaderText = "Satuan"
        dgvData.Columns(5).HeaderText = "Kadaluarsa"
        dgvData.Columns(6).HeaderText = "Jumlah Fisik"
        dgvData.Columns(7).HeaderText = "Seilish"
        dgvData.Columns(8).HeaderText = "Keterangan"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub FrLaporanPenyesuaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        laporanpenyesuaian()
        dgvData.Rows.Clear()
        query = "Select pyh.no_py, pyh.tanggal, bh.nama_b, pyd.jumlah, pyd.satuan, pyd.kadaluarsa, pyd.jumlah_fisik, pyd.selisih, pyd.keterangan from tbPY_H pyh inner join tbPY_D pyd on pyh.no_py = pyd.no_py inner join tbB_H bh on pyd.kode_b = bh.kode_b"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4), datareader.Item(5), datareader.Item(6), datareader.Item(7), datareader.Item(8))
            End While
        End If
        datareader.Close()
    End Sub
End Class