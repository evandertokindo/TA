Imports System.Data.SqlClient
Public Class FrCariPesananPembelian

    Sub tampil_pesananpembelian()
        dgvData.ColumnCount = 6
        dgvData.Columns(0).HeaderText = "No Pesanan Pembelian"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.Columns(2).HeaderText = "Kode Supplier"
        dgvData.Columns(3).HeaderText = "Nama Supplier"
        dgvData.Columns(4).HeaderText = "Jenis Barang"
        dgvData.Columns(5).HeaderText = "Status Dokumen"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim baris As Integer
        baris = dgvData.CurrentCell.RowIndex
        If Me.Tag = "PesananPembelian" Then
            FrDataPesananPembelian.txtnopesananpembelian.Text = dgvData.Item(0, baris).Value
            'FrDataPesananPembelian.txttotal.Text = dgvData.Item(4, baris).Value
            FrDataPesananPembelian.dtpt.Value = dgvData.Item(1, baris).Value
            query = $"Select ppbh.kode_s, s.nama_s from tbS s inner join tbPPB_H ppbh on ppbh.kode_s = s.kode_s where ppbh.no_ppb = '{dgvData.Item(0, baris).Value}' "
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    FrDataPesananPembelian.txtkodesupplier.Text = datareader.Item("kode_s")
                    FrDataPesananPembelian.txtnamasupplier.Text = datareader.Item("nama_s")
                End While
            End If
            datareader.Close()
        ElseIf Me.Tag = "Pembelian" Then
            FrDataPembelian.txtnopesananpembelian.Text = dgvData.Item(0, baris).Value
            FrDataPembelian.dtpt.Value = dgvData.Item(1, baris).Value
            query = $"Select ppbh.kode_s, s.nama_s from tbS s inner join tbPPB_H ppbh on ppbh.kode_s = s.kode_s where ppbh.no_ppb = '{dgvData.Item(0, baris).Value}' "
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    FrDataPembelian.txtkodesupplier.Text = datareader.Item("kode_s")
                    FrDataPembelian.txtnamasupplier.Text = datareader.Item("nama_s")
                End While
            End If
            datareader.Close()
        End If
        Me.Close()
    End Sub

    Private Sub FrCariPesananPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtcari.Focus()
        tampil_pesananpembelian()
        dgvData.Rows.Clear()
        query = "Select ppbh.no_ppb, ppbh.tanggal, s.nama_s, ppbh.jenis_b, ppbh.status_ppb from tbPPB_H ppbh inner join tbS s on ppbh.kode_s = s.kode_s"
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
                query = "Select ppbh.no_ppb, ppbh.tanggal, s.nama_s, ppbh.jenis_b, ppbh.status_ppb from tbPPB_H ppbh inner join tbS s on ppbh.kode_s = s.kode_s where ppbh.no_ppb like '%" & txtcari.Text & "%'"
            Else
                query = "Select ppbh.no_ppb, ppbh.tanggal, s.nama_s, ppbh.jenis_b, ppbh.status_ppb from tbPPB_H ppbh inner join tbS s on ppbh.kode_s = s.kode_s where s.nama_s like '%" & txtcari.Text & "%'"
            End If
        ElseIf Me.Tag = "Penjualan" Then
            If cbbcari.SelectedIndex = 0 Then
                query = "Select ppbh.no_ppb, ppbh.tanggal, s.nama_s, ppbh.jenis_b, ppbh.status_ppb from tbPPB_H ppbh inner join tbS s on ppbh.kode_s = s.kode_s where ppbh.no_ppb like '%" & txtcari.Text & "%'"
            Else
                query = "Select ppbh.no_ppb, ppbh.tanggal, s.nama_s, ppbh.jenis_b, ppbh.status_ppb from tbPPB_H ppbh inner join tbS s ppbh.kode_s = s.kode_s where s.nama_s like '%" & txtcari.Text & "%'"
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