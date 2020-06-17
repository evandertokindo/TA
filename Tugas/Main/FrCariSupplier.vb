Imports System.Data.SqlClient

Public Class FrCariSupplier

    Sub supplier()

        dgvData.ColumnCount = 4
        dgvData.Columns(0).HeaderText = "Kode Supplier"
        dgvData.Columns(1).HeaderText = "Nama Supplier"
        dgvData.Columns(2).HeaderText = "No. Telepon"
        dgvData.Columns(3).HeaderText = "Alamat"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Sub pesanan()

        dgvData.ColumnCount = 4
        dgvData.Columns(0).HeaderText = "Kode Supplier"
        dgvData.Columns(1).HeaderText = "Nama Supplier"
        dgvData.Columns(2).HeaderText = "No. Telepon"
        dgvData.Columns(3).HeaderText = "Alamat"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False

    End Sub

    Sub retur()

        dgvData.ColumnCount = 4
        dgvData.Columns(0).HeaderText = "Kode Supplier"
        dgvData.Columns(1).HeaderText = "Nama Supplier"
        dgvData.Columns(2).HeaderText = "No. Telepon"
        dgvData.Columns(3).HeaderText = "Alamat"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub FrCariSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        koneksi()
        dgvData.Rows.Clear()
        'dgvData.ColumnCount = 4
        'dgvData.Columns(0).HeaderText = "Kode Supplier"
        'dgvData.Columns(1).HeaderText = "Nama Supplier"
        'dgvData.Columns(2).HeaderText = "No. Telepon"
        'dgvData.Columns(3).HeaderText = "Alamat"
        'query = "Select * from tbS"
        'cmd = New SqlCommand(query, conn)
        'datareader = cmd.ExecuteReader
        'If datareader.HasRows Then
        '    While datareader.Read
        '        dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
        '    End While
        'End If
        'datareader.Close()

        If Me.Tag = "Supplier" Then
            supplier()
            query = "Select * from tbS"
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
                End While
            End If
            datareader.Close()
        ElseIf Me.Tag = "Pesanan" Then
            pesanan()
            query = "Select * from tbS"
            cmd = New SqlCommand(query, conn)
            datareader = cmd.ExecuteReader
            If datareader.HasRows Then
                While datareader.Read
                    dgvData.Rows.Add(datareader(0), datareader(1), datareader(2), datareader(3))
                End While
            End If
            datareader.Close()
        ElseIf Me.Tag = "Retur" Then
            retur()
            query = "Select * from tbS"
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
        'Dim f1 As FrDataSupplier = FrDataSupplier
        'f1.txtkodesupplier.Text = dgvData.Item(0, baris).Value
        'f1.txtnamasupplier.Text = dgvData.Item(1, baris).Value
        'f1.txtnotelepon.Text = dgvData.Item(2, baris).Value
        'f1.txtAlamat.Text = dgvData.Item(3, baris).Value
        'Dim f2 As FrDataReturPembelian = FrDataReturPembelian
        'f2.txtkodesupplier.Text = dgvData.Item(0, baris).Value
        'f2.txtnamasupplier.Text = dgvData.Item(1, baris).Value
        'Dim f3 As FrDataPesananPembelian = FrDataPesananPembelian
        'f3.txtkodesupplier.Text = dgvData.Item(0, baris).Value
        'f3.txtnamasupplier.Text = dgvData.Item(1, baris).Value

        If Me.Tag = "Supplier" Then
            FrDataSupplier.txtkodesupplier.Text = dgvData.Item(0, baris).Value
            FrDataSupplier.txtnamasupplier.Text = dgvData.Item(1, baris).Value
            FrDataSupplier.txtnotelepon.Text = dgvData.Item(2, baris).Value
            FrDataSupplier.txtAlamat.Text = dgvData.Item(3, baris).Value
        ElseIf Me.Tag = "Pesanan" Then
            FrDataPesananPembelian.txtkodesupplier.Text = dgvData.Item(0, baris).Value
            FrDataPesananPembelian.txtnamasupplier.Text = dgvData.Item(1, baris).Value
        ElseIf Me.Tag = "Retur" Then
            FrDataReturPembelian.txtkodesupplier.Text = dgvData.Item(0, baris).Value
            FrDataReturPembelian.txtnamasupplier.Text = dgvData.Item(1, baris).Value
        End If
        Me.Close()
    End Sub
End Class