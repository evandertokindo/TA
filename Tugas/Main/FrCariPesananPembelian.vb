Imports System.Data.SqlClient
Public Class FrCariPesananPembelian

    Sub tampil_pesananpembelian()
        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "No Pesanan Pembelian"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.Columns(2).HeaderText = "Kode Supplier"
        dgvData.Columns(3).HeaderText = "Nama Supplier"
        dgvData.Columns(4).HeaderText = "Jenis Barang"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim baris As Integer
        baris = dgvData.CurrentCell.RowIndex
        If Me.Tag = "Pesanan" Then
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
        tampil_pesananpembelian()
        dgvData.Rows.Clear()
        query = "Select * from tbPPB_H"
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