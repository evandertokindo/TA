Imports System.Data.SqlClient

Public Class FrLaporanKadaluarsa

    Sub laporankadaluarsa()
        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Kadaluarsa"
        dgvData.Columns(3).HeaderText = "Jumlah"
        dgvData.Columns(4).HeaderText = "Satuan"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub FrLaporanKadaluarsa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        laporankadaluarsa()
        dgvData.Rows.Clear()
        query = "Select bd.kode_b, bh.nama_b, bd.kadaluarsa, bd.jumlah, bd.satuan from tbB_H bh inner join tbB_D bd on bh.kode_b = bd.kode_b"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4))
            End While
        End If
        datareader.Close()
    End Sub
End Class