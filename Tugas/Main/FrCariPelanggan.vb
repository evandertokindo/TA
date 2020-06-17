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
        'dgvData.ColumnCount = 4
        'dgvData.Columns(0).HeaderText = "Kode Pelanggan"
        'dgvData.Columns(1).HeaderText = "Nama Pelanggan"
        'dgvData.Columns(2).HeaderText = "No. Telepon"
        'dgvData.Columns(3).HeaderText = "Alamat"
        'dgvData.ReadOnly = True
        'dgvData.AllowUserToAddRows = False
        'dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'dgvData.RowHeadersVisible = False
        'query = "Select * from tbP"
        'cmd = New SqlCommand(query, conn)
        'datareader = cmd.ExecuteReader
        'If datareader.HasRows Then
        '    While datareader.Read
        '        dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
        '    End While
        'End If

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
        ElseIf Me.Tag = "Penjualan" Then
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
        'Dim f1 As FrDataPelanggan = FrDataPelanggan
        'f1.txtkodepelanggan.Text = dgvData.Item(0, baris).Value
        'f1.txtnamapelanggan.Text = dgvData.Item(1, baris).Value
        'f1.txtnotelepon.Text = dgvData.Item(2, baris).Value
        'f1.txtalamat.Text = dgvData.Item(3, baris).Value
        'Dim f2 As FrDataPenjualan = FrDataPenjualan
        'f2.txtkodepelanggan.Text = dgvData.Item(0, baris).Value
        'f2.txtnamapelanggan.Text = dgvData.Item(1, baris).Value

        If Me.Tag = "Pelanggan" Then
            FrDataPelanggan.txtkodepelanggan.Text = dgvData.Item(0, baris).Value
            FrDataPelanggan.txtnamapelanggan.Text = dgvData.Item(1, baris).Value
            FrDataPelanggan.txtnotelepon.Text = dgvData.Item(2, baris).Value
            FrDataPelanggan.txtalamat.Text = dgvData.Item(3, baris).Value
        ElseIf Me.Tag = "Penjualan" Then
            FrDataPenjualan.txtkodepelanggan.Text = dgvData.Item(0, baris).Value
            FrDataPenjualan.txtnamapelanggan.Text = dgvData.Item(1, baris).Value
        End If
        Me.Close()

    End Sub

End Class