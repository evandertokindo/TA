Imports System.Data.SqlClient
Public Class FrCariPenjualan

    Sub tampil_penjualan()
        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "Faktur Penjualan"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.Columns(2).HeaderText = "Kode Pelanggan"
        dgvData.Columns(3).HeaderText = "Nama Pelanggan"
        dgvData.Columns(4).HeaderText = "Total"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim baris As Integer
        baris = dgvData.CurrentCell.RowIndex
        Dim f1 As FrDataPenjualan = FrDataPenjualan
        f1.txtnofaktur.Text = dgvData.Item(0, baris).Value
        f1.dtpt.Value = dgvData.Item(1, baris).Value
        f1.txttotal.Text = dgvData.Item(4, baris).Value
        query = $"Select pjh.kode_p, p.nama_p from tbPJ_H pjh inner join tbP p on pjh.kode_p = p.kode_p where pjh.no_pj = '{dgvData.Item(0, baris).Value}' "
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                f1.txtkodepelanggan.Text = datareader.Item("kode_p")
                f1.txtnamapelanggan.Text = datareader.Item("nama_p")
            End While
        End If
        datareader.Close()
        Me.Close()
    End Sub

    Private Sub FrCariPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtcari.Focus()
        tampil_penjualan()
        dgvData.Rows.Clear()
        query = "Select pjh.no_pj, ppjh.no_ppj, pjh.tanggal, p.nama_p, pjh.total from tbPJ_H pjh inner join tbPPJ_H ppjh on ppjh.no_ppj = pjh.no_ppj inner join tbP p on pjh.kode_p = p.kode_p"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read()
                dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3), datareader(4))
            End While
        End If
        datareader.Close()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        dgvData.Rows.Clear()
        If cbbcari.SelectedIndex = 0 Then
            query = "Select pjh.no_pj, ppjh.no_ppj, pjh.tanggal, p.nama_p, pjh.total from tbPJ_H pjh inner join tbPPJ_H ppjh on ppjh.no_ppj = pjh.no_ppj inner join tbP p on pjh.kode_p = p.kode_p where pjh.no_pj like '%" & txtcari.Text & "%'"
        Else
            query = "Select pjh.no_pj, ppjh.no_ppj, pjh.tanggal, p.nama_p, pjh.total from tbPJ_H pjh inner join tbPPJ_H ppjh on ppjh.no_ppj = pjh.no_ppj inner join tbP p on pjh.kode_p = p.kode_p where p.nama_p like '%" & txtcari.Text & "%'"
        End If
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