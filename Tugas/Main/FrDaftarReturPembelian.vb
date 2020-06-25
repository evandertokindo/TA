﻿Imports System.Data.SqlClient
Public Class FrDaftarReturPembelian

    Sub daftarreturpembelian()
        dgvData.ColumnCount = 5
        dgvData.Columns(0).HeaderText = "No Retur Pembelian"
        dgvData.Columns(1).HeaderText = "No Pembelian"
        dgvData.Columns(2).HeaderText = "Tanggal"
        dgvData.Columns(3).HeaderText = "Nama Supplier"
        dgvData.Columns(4).HeaderText = "Total"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub FrDaftarReturPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = FrMainMenu
        koneksi()
        daftarreturpembelian()
        dgvData.Rows.Clear()
        query = "Select rh.no_r, rh.no_pb, rh.tanggal, s.nama_s, rh.total From tbR_H rh inner join tbPB_H pbh on pbh.no_pb = rh.no_pb inner join tbS s on rh.kode_s = s.nama_s"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3), datareader.Item(4))
            End While
        End If

    End Sub
End Class