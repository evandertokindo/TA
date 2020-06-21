Imports System.Data.SqlClient

Public Class FrCariReturPembelian

    Sub tampil_retur()
        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "No Retur"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.Columns(2).HeaderText = "Kode Supplier"
        dgvData.Columns(3).HeaderText = "Nama Supplier"
        dgvData.Columns(4).HeaderText = "Total"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim baris As Integer
        baris = dgvData.CurrentCell.RowIndex
        Dim f1 As FrDataReturPembelian = FrDataReturPembelian
        f1.txtnoreturpembelian.Text = dgvData.Item(0, baris).Value
        query = $"Select rh.kode_s, s.nama_s from tbS s inner join tbR_H rh on rh.kode_s = s.kode_s where rh.no_r = '{dgvData.Item(0, baris).Value}' "
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                f1.txtkodesupplier.Text = datareader.Item("kode_s")
                f1.txtnamasupplier.Text = datareader.Item("nama_s")
            End While
        End If
        datareader.Close()
        Me.Close()
    End Sub

    Private Sub FrCariReturPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil_retur()
        query = "Select * from tbR_H"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read()
                dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3), datareader(4))
            End While
        End If
        datareader.Close()
    End Sub

End Class