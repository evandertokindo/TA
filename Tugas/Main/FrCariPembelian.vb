Imports System.Data.SqlClient
Public Class FrCariPembelian

    Sub tampil_pembelian()
        dgvData.ColumnCount = 6
        dgvData.Columns(0).HeaderText = "No Pembelian"
        dgvData.Columns(1).HeaderText = "No Pesanan Pembelian"
        dgvData.Columns(2).HeaderText = "Tanggal"
        dgvData.Columns(3).HeaderText = "Kode Supplier"
        dgvData.Columns(4).HeaderText = "Nama Supplier"
        dgvData.Columns(5).HeaderText = "Total"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim baris As Integer
        baris = dgvData.CurrentCell.RowIndex
        Dim f1 As FrDataPesananPembelian = FrDataPesananPembelian
        f1.txtnopesananpembelian.Text = dgvData.Item(0, baris).Value
        query = $"Select pjh.kode_s, s.nama_s from tbS s inner join tbPJ_H pjh on pjh.kode_s = s.kode_s where pjh.no_ppb = '{dgvData.Item(0, baris).Value}' "
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

    Private Sub FrCariPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtcari.Focus()
        tampil_pembelian()
        query = "Select pbh.no_pb, ppbh.no_ppb, pbh.tanggal, s.nama_s, pbh.total from tbPB_H pbh inner join tbPPB_H ppbh on ppbh.no_ppb = pbh.no_ppb inner join tbS s on pbh.kode_s = s.kode_s"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read()
                dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3), datareader(4), datareader(5))
            End While
        End If
        datareader.Close()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        dgvData.Rows.Clear()
        If Me.Tag = "Pembelian" Then
            If cbbcari.SelectedIndex = 0 Then
                query = "Select pbh.no_pb, ppbh.no_ppb, pbh.tanggal, s.nama_s, pbh.total from tbPB_H pbh inner join tbPPB_H ppbh on ppbh.no_ppb = pbh.no_ppb inner join tbS s on pbh.kode_s = s.kode_s where pbh.no_pb like '%" & txtcari.Text & "%'"
            Else
                query = "Select pbh.no_pb, ppbh.no_ppb, pbh.tanggal, s.nama_s, pbh.total from tbPB_H pbh inner join tbPPB_H ppbh on ppbh.no_ppb = pbh.no_ppb inner join tbS s on pbh.kode_s = s.kode_s where s.nama_s like '%" & txtcari.Text & "%'"
            End If
        ElseIf Me.Tag = "Retur" Then
            If cbbcari.SelectedIndex = 0 Then
                query = "Select pbh.no_pb, ppbh.no_ppb, pbh.tanggal, s.nama_s, pbh.total from tbPB_H pbh inner join tbPPB_H ppbh on ppbh.no_ppb = pbh.no_ppb inner join tbS s on pbh.kode_s = s.kode_s where pbh.no_pb like '%" & txtcari.Text & "%'"
            Else
                query = "Select pbh.no_pb, ppbh.no_ppb, pbh.tanggal, s.nama_s, pbh.total from tbPB_H pbh inner join tbPPB_H ppbh on ppbh.no_ppb = pbh.no_ppb inner join tbS s on pbh.kode_s = s.kode_s where s.nama_s like '%" & txtcari.Text & "%'"
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