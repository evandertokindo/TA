Imports System.Data.SqlClient
Public Class FrCariPesananPenjualan

    Sub tampil_pesananpenjualan()
        dgvData.ColumnCount = 6
        dgvData.Columns(0).HeaderText = "No Pesanan Penjualan"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.Columns(2).HeaderText = "Kode Pelanggan"
        dgvData.Columns(3).HeaderText = "Nama Pelanggan"
        dgvData.Columns(4).HeaderText = "Total"
        dgvData.Columns(5).HeaderText = "Status Dokumen"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim baris As Integer = dgvData.CurrentCell.RowIndex
        If Me.Tag = "PesananPenjualan" Then
            FrDataPesananPenjualan.txtnopesananpenjualan.Text = dgvData.Item(0, baris).Value
            FrDataPesananPenjualan.dtpt.Value = dgvData.Item(1, baris).Value
            FrDataPesananPenjualan.txtstatus = dgvData.Item(5, baris).Value
            query = $"Select ppjh.kode_p, p.nama_p from tbP p inner join tbPPJ_H ppjh on ppjh.kode_p = p.kode_p where ppjh.no_ppj = '{dgvData.Item(0, baris).Value}' "
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    FrDataPesananPenjualan.txtkodepelanggan.Text = datareader.Item("kode_p")
                    FrDataPesananPenjualan.txtnamapelanggan.Text = datareader.Item("nama_p")
                End While
            End If
            datareader.Close()
        ElseIf Me.Tag = "Penjualan" Then
            FrDataPenjualan.txtnopesananpenjualan.Text = dgvData.Item(0, baris).Value
            FrDataPenjualan.dtpt.Value = dgvData.Item(1, baris).Value
            query = $"Select ppjh.kode_p, p.nama_p from tbP p inner join tbPPJ_H ppjh on ppjh.kode_p = p.kode_p where ppjh.no_ppj = '{dgvData.Item(0, baris).Value}' "
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    FrDataPenjualan.txtkodepelanggan.Text = datareader.Item("kode_p")
                    FrDataPenjualan.txtnamapelanggan.Text = datareader.Item("nama_p")
                End While
            End If
            datareader.Close()
        End If
        Me.Close()
    End Sub

    Private Sub FrCariPesananPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtcari.Focus()
        tampil_pesananpenjualan()
        dgvData.Rows.Clear()
        query = "Select ppjh.no_ppj, ppjh.tanggal, p.nama_p, ppjh.jenis_b, ppjh.status_ppj from tbPPJ_H ppjh inner join tbP p on ppjh.kode_p = p.kode_p"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4))
            End While
        End If
        datareader.Close()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        dgvData.Rows.Clear()
        If Me.Tag = "PesananPenjualan" Then
            If cbbcari.SelectedIndex = 0 Then
                query = "Select ppjh.no_ppj, ppjh.tanggal, p.nama_p, ppjh.jenis_b, ppjh.status_ppj from tbPPJ_H ppjh inner join tbP p on ppjh.kode_p = p.kode_p where ppjh.no_ppj like '%" & txtcari.Text & "%'"
            Else
                query = "Select ppjh.no_ppj, ppjh.tanggal, p.nama_p, ppjh.jenis_b, ppjh.status_ppj from tbPPJ_H ppjh inner join tbP p on ppjh.kode_p = p.kode_p where p.nama_p like '%" & txtcari.Text & "%'"
            End If
        ElseIf Me.Tag = "Penjualan" Then
            If cbbcari.SelectedIndex = 0 Then
                query = "Select ppjh.no_ppj, ppjh.tanggal, p.nama_p, ppjh.jenis_b, ppjh.status_ppj from tbPPJ_H ppjh inner join tbP p on ppjh.kode_p = p.kode_p where ppjh.no_ppj like '%" & txtcari.Text & "%'"
            Else
                query = "Select ppjh.no_ppj, ppjh.tanggal, p.nama_p, ppjh.jenis_b, ppjh.status_ppj from tbPPJ_H ppjh inner join tbP p on ppjh.kode_p = p.kode_p where p.nama_p like '%" & txtcari.Text & "%'"
            End If
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