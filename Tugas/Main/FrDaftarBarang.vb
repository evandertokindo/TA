Imports System.Data.SqlClient

Public Class FrDaftarBarang

    Private Sub FrDaftarBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgvData.ColumnCount = 5
        'dgvData.Columns(0).HeaderText = "Kode Barang"
        'dgvData.Columns(1).HeaderText = "Nama Barang"

        'koneksi()
        'query = "Select * from tbB_H inner join tbB_D"
        'cmd = New SqlCommand(query, conn)
        'datareader = cmd.ExecuteReader
        'If datareader.HasRows Then
        '    While datareader.Read
        '        dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
        '    End While
        'End If
    End Sub
End Class