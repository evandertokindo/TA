Imports System.Data.SqlClient
Public Class FrDaftarPesananPembelian

    Sub daftarpesananpembelian()
        dgvData.ColumnCount = 6
        dgvData.Columns(0).HeaderText = "No Pesanan Pembelian"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.Columns(2).HeaderText = "Kode Supplier"
        dgvData.Columns(3).HeaderText = "Nama Supplier"
        dgvData.Columns(4).HeaderText = "Jenis Barang"
        dgvData.Columns(5).HeaderText = "Status"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub FrDaftarPesananPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        daftarpesananpembelian()
        dgvData.Rows.Clear()
        query = "Select * form tbPPB_H"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4), datareader.Item(5))
            End While
        End If
        datareader.Close()
    End Sub
End Class