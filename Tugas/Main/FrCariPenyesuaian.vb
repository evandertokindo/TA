Imports System.Data.SqlClient
Public Class FrCariPenyesuaian

    Sub caripenyesuaian()
        dgvData.ColumnCount = 2
        dgvData.Columns(0).HeaderText = "No Penyesuaian"
        dgvData.Columns(1).HeaderText = "Tanggal"
        dgvData.ReadOnly = True
        dgvData.AllowUserToAddRows = False
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.RowHeadersVisible = False
    End Sub

    Private Sub FrCariPenyesuaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtcari.Focus()
        caripenyesuaian()
        dgvData.Rows.Clear()
        query = "Select no_py, tanggal from tbPY_H"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read()
                dgvData.Rows.Add(datareader(0), datareader(1))
            End While
        End If
        datareader.Close()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        dgvData.Rows.Clear()
        If txtcari.Text <> "" Then
            query = "Select no_py, tanggal from tbPY_H where no_py like '%" & txtcari.Text & "%'"
        End If
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1))
            End While
        End If
        datareader.Close()
    End Sub
End Class