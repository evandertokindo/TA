Imports System.Data.SqlClient

Public Class FrCariReturPembelian

    Sub tampil_retur()
        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "No Retur"
        dgvData.Columns(1).HeaderText = "No Pesanan Pembelian"
        dgvData.Columns(2).HeaderText = "Tanggal"
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
        txtcari.Focus()
        tampil_retur()
        query = "Select rh.no_r, pbh.no_pb, rh.tanggal, s.nama_s, rh.total from tbR_H rh inner join tbPB_H pbh on pbh.no_pb = rh.no_pb inner join tbS s on rh.kode_s = s.kode_s"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read()
                dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3), datareader(4))
            End While
        End If
        datareader.Close()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        dgvData.Rows.Clear()
        If cbbcari.SelectedIndex = 0 Then
            query = "Select rh.no_r, pbh.no_pb, rh.tanggal, s.nama_s, rh.total from tbR_H rh inner join tbPB_H pbh on pbh.no_pb = rh.no_pb inner join tbS s on rh.kode_s = s.kode_s where rh.no_r like '%" & txtcari.Text & "%'"
        Else
            query = "Select rh.no_r, pbh.no_pb, rh.tanggal, s.nama_s, rh.total from tbR_H rh inner join tbPB_H pbh on pbh.no_pb = rh.no_pb inner join tbS s on rh.kode_s = s.kode_s where s.nama_s like '%" & txtcari.Text & "%'"
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