Imports System.Data.SqlClient
Public Class FrDataPesananPenjualan

    Sub tabel()
        dgvData.ColumnCount = 7
        dgvData.Columns(0).HeaderText = "Kode Barang"
        dgvData.Columns(1).HeaderText = "Nama Barang"
        dgvData.Columns(2).HeaderText = "Jumlah"
        dgvData.Columns(3).HeaderText = "Satuan"
        dgvData.Columns(4).HeaderText = "Harga"
        dgvData.Columns(5).HeaderText = "SubTotal"
        dgvData.Columns(6).HeaderText = "Kadaluarsa"
        dgvData.ReadOnly = True
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
        dgvData.AllowUserToAddRows = False
    End Sub

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select no_ppj from tbPPJ_H where no_ppj in(select max(no_ppj) from tbPPJ_H) order by no_ppj", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("no_ppj"), 4) + 1
            urut = "PPJ" + Strings.Right("000" & htg, 4)
        Else
            urut = "PPJ" & "000" & +1
        End If
        datareader.Close()
        txtnopesananpenjualan.Text = urut
        conn.Close()
    End Sub

    Function belumAdaKodenya() As Boolean
        Dim jlh = 0
        For i As Integer = 0 To dgvData.Rows.Count - 1
            If txtkodebarang.Text = dgvData.Item(0, i).Value Then
                jlh += 1
            End If
        Next
        Return (jlh = 0)
    End Function

    Private Sub FrDataPesananPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tabel()
        buat_kode()

    End Sub
End Class