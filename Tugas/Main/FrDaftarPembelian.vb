Imports System.Data.SqlClient
Public Class FrDaftarPembelian

    Sub pembelian()
        dgvData.ColumnCount = 2
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub
    Private Sub FrDaftarPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class