Imports System.Data.SqlClient

Public Class FrCariPelanggan

    Sub pelanggan()

        dgvData.ColumnCount = 4
        dgvData.Columns(0).HeaderText = "Kode Pelanggan"
        dgvData.Columns(1).HeaderText = "Nama Pelanggan"
        dgvData.Columns(2).HeaderText = "No. Telepon"
        dgvData.Columns(3).HeaderText = "Alamat"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Sub penjualan()

        dgvData.ColumnCount = 4
        dgvData.Columns(0).HeaderText = "Kode Pelanggan"
        dgvData.Columns(1).HeaderText = "Nama Pelanggan"
        dgvData.Columns(2).HeaderText = "No. Telepon"
        dgvData.Columns(3).HeaderText = "Alamat"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Private Sub FrCariPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        koneksi()
        dgvData.Rows.Clear()
        If Me.Tag = "Pelanggan" Then
            pelanggan()
            query = "Select * from tbP"
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
                End While
            End If
            datareader.Close()
        ElseIf Me.Tag = "PesananPenjualan" Then
            penjualan()
            query = "Select * from tbP"
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
                End While
            End If
            datareader.Close()
        End If

    End Sub

    Private Sub dgvData_DoubleClick(sender As Object, e As EventArgs) Handles dgvData.DoubleClick

        Dim baris As Integer
        baris = dgvData.CurrentCell.RowIndex
        If Me.Tag = "Pelanggan" Then
            FrDataPelanggan.txtkodepelanggan.Text = dgvData.Item(0, baris).Value
            FrDataPelanggan.txtnamapelanggan.Text = dgvData.Item(1, baris).Value
            FrDataPelanggan.txtnotelepon.Text = dgvData.Item(2, baris).Value
            FrDataPelanggan.txtalamat.Text = dgvData.Item(3, baris).Value
        ElseIf Me.Tag = "PesananPenjualan" Then
            FrDataPesananPenjualan.txtkodepelanggan.Text = dgvData.Item(0, baris).Value
            FrDataPesananPenjualan.txtnamapelanggan.Text = dgvData.Item(1, baris).Value
        End If
        Me.Close()

    End Sub

End Class