Imports System.Data.SqlClient
Public Class FrDaftarPelanggan

    Sub pelanggan()
        dgvData.ColumnCount = 4
        dgvData.Columns(0).HeaderText = "Kode Pelanggan"
        dgvData.Columns(1).HeaderText = "Nama Pelanggan"
        dgvData.Columns(2).HeaderText = "No. Telepon"
        dgvData.Columns(3).HeaderText = "Alamat"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub FrDaftarPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        pelanggan()
        query = "Select * from tbP"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4))
            End While
        End If
        datareader.Close()
    End Sub
End Class