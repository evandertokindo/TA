Imports System.Data.SqlClient

Public Class FrDaftarBarang

    Sub barangh()
        dgvData.ColumnCount = 7
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Satuan Besar"
        dgvData.Columns(3).HeaderText = "Konversi Sedang"
        dgvData.Columns(4).HeaderText = "Satuan Sedang"
        dgvData.Columns(5).HeaderText = "Konversi Ke Kecil"
        dgvData.Columns(6).HeaderText = "Satuan Kecil"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub FrDaftarBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        dgvData.Rows.Clear()

        barangh()
        query = "Select * from tbB_H"
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4), datareader.Item(5), datareader.Item(6))
                End While
            End If
            datareader.Close()

    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click

    End Sub
End Class