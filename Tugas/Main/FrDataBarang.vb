Imports System.Data.SqlClient

Public Class FrDataBarang

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select kode_b from tbB_H where kode_b in(select max(kode_b) from tbB_H) order by kode_b", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("kode_b"), 4) + 1
            urut = "BRG" + Strings.Right("000" & htg, 4)
        Else
            urut = "BRG" & "000" & +1
        End If
        datareader.Close()
        txtkodebarang.Text = urut
        conn.Close()
    End Sub

    'Sub hitung_jumlah()
    '    Dim hitung As Integer
    '    hitung = txtkonversisedang.Text * txtkonversikecil.Text
    '    txtjumlah.Text = hitung
    'End Sub

    Private Sub FrPersediaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = FrMainMenu
        koneksi()
        buat_kode()
        txtkodebarang.Enabled = False
        txtnamabarang.Focus()


    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        FrCariBarang.Tag = "Barang"
        FrCariBarang.ShowDialog()
    End Sub

    'Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click

    '    load_data_1pk("tbB_H")
    '    dr = ds.Tables("tbB_H").Rows.Find(txtkodebarang.Text)
    '    If dr IsNot Nothing Then
    '        If String.IsNullOrWhiteSpace(txtnamabarang.Text) Or String.IsNullOrWhiteSpace(txtjumlah.Text) Or String.IsNullOrWhiteSpace(txtsatuan.Text) Or String.IsNullOrWhiteSpace(txthargabeli.Text) Or String.IsNullOrWhiteSpace(txthargaecer.Text) Or String.IsNullOrWhiteSpace(txthargagrosir.Text) Then
    '            MessageBox.Show("Data Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Else
    '            dr(1) = txtnamabarang.Text
    '            dr(2) = txtjumlah.Text
    '            dr(3) = txtsatuan.Text
    '            dr(4) = txthargabeli.Text
    '            dr(5) = txthargaecer.Text
    '            dr(6) = txthargagrosir.Text
    '            dr(7) = dtpkadaluarsa.Value
    '            ds.Tables("tbB_H").Rows.Add(dr)
    '            update_data("tbB_H")

    '            MessageBox.Show("Barang " & txtkodebarang.Text & " berhasil diubah", "Edit Barang", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '            buat_kode()
    '            txtnamabarang.Clear()
    '            txtjumlah.Clear()
    '            txtsatuan.Clear()
    '            txthargabeli.Clear()
    '            txthargaecer.Clear()
    '            txthargagrosir.Clear()
    '            txtnamabarang.Focus()

    '        End If
    '    End If

    'End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click

        load_data_1pk("tbB_H")
        dr = ds.Tables("tbB_H").Rows.Find(txtkodebarang.Text)
        If dr Is Nothing Then
            If String.IsNullOrWhiteSpace(txtnamabarang.Text) Or String.IsNullOrWhiteSpace(txtjumlah.Text) Or cbbbesar.SelectedItem = Nothing Or cbbsedang.SelectedItem = Nothing Or cbbkecil.SelectedItem = Nothing Or String.IsNullOrWhiteSpace(txthargaecer.Text) Or String.IsNullOrWhiteSpace(txthargagrosir.Text) Then
                MessageBox.Show("Data Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dr = ds.Tables("tbB_H").NewRow
                dr(0) = txtkodebarang.Text
                dr(1) = txtnamabarang.Text
                dr(2) = cbbbesar.Text
                dr(3) = nudsedang.Value
                dr(4) = cbbsedang.Text
                dr(5) = nudkecil.Value
                dr(6) = cbbkecil.Text
                ds.Tables("tbB_H").Rows.Add(dr)
                update_data("tbB_H")

                load_data_2pk("tbB_D")
                dr = ds.Tables("tbB_D").NewRow
                dr(0) = txtkodebarang.Text
                dr(1) = dtpkadaluarsa.Value
                dr(2) = txtjumlah.Text
                dr(3) = lblsatuan.Text
                dr(4) = txthargaecer.Text
                dr(5) = txthargagrosir.Text
                ds.Tables("tbB_D").Rows.Add(dr)
                update_data("tbB_D")

                'load_data_2pk("tbB_D")
                'dr = ds.Tables("tbB_D").Rows.Find(txtkodebarang.Text)
                'If dr Is Nothing Then
                '    dr = ds.Tables("tbB_D").NewRow
                '    dr(0) = txtkodebarang.Text
                '    dr(1) = dtpkadaluarsa.Value
                '    dr(2) = txtjumlah.Text
                '    dr(3) = lblsatuan.Text
                '    dr(4) = txthargaecer.Text
                '    dr(5) = txthargagrosir.Text
                '    ds.Tables("tbB_D").Rows.Add(dr)
                '    update_data("tbB_D")

                MessageBox.Show("Barang " & txtkodebarang.Text & " berhasil ditambahkan", "Add Barang", MessageBoxButtons.OK, MessageBoxIcon.Information)

                buat_kode()
                txtnamabarang.Clear()
                txtjumlah.Clear()
                txthargaecer.Clear()
                txthargagrosir.Clear()
                txtnamabarang.Focus()
                cbbbesar.SelectedIndex = -1
                cbbkecil.SelectedIndex = -1
                cbbsedang.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub cbbkecil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbkecil.SelectedIndexChanged

        lblsatuan.Text = cbbkecil.SelectedItem

    End Sub

    Private Sub nudkecil_TextChanged(sender As Object, e As EventArgs) Handles nudkecil.TextChanged
        Dim hitung As Integer
        hitung = nudsedang.Value * nudkecil.Value
        txtjumlah.Text = hitung
    End Sub
End Class