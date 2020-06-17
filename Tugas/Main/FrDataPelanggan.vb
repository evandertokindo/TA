Imports System.Data.SqlClient

Public Class FrDataPelanggan

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select kode_p from tbP where kode_p in(select max(kode_p) from tbP) order by kode_p", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("kode_p"), 3) + 1
            urut = "PEL" + Strings.Right("00" & htg, 3)
        Else
            urut = "PEL" & "00" & +1
        End If
        datareader.Close()
        txtkodepelanggan.Text = urut
        conn.Close()
    End Sub

    Private Sub FrPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        buat_kode()
        txtkodepelanggan.Enabled = False
        txtnamapelanggan.Focus()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        load_data_1pk("tbP")
        dr = ds.Tables("tbP").Rows.Find(txtkodepelanggan.Text)
        If dr Is Nothing Then
            If String.IsNullOrWhiteSpace(txtnamapelanggan.Text) Or String.IsNullOrWhiteSpace(txtnotelepon.Text) Or String.IsNullOrWhiteSpace(txtalamat.Text) Then
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dr = ds.Tables("tbP").NewRow
                dr(0) = txtkodepelanggan.Text
                dr(1) = txtnamapelanggan.Text
                dr(2) = txtnotelepon.Text
                dr(3) = txtalamat.Text
                ds.Tables("tbP").Rows.Add(dr)
                update_data("tbP")

                MessageBox.Show("Pelanggan " & txtkodepelanggan.Text & " berhasil ditambahkan", "Add Pelanggan", MessageBoxButtons.OK, MessageBoxIcon.Information)

                buat_kode()
                txtnamapelanggan.Clear()
                txtnotelepon.Clear()
                txtalamat.Clear()
                txtnamapelanggan.Focus()
            End If
        End If

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        'load_data_1pk("tbP")
        'dr = ds.Tables("tbP").Rows.Find(txtkodepelanggan.Text)
        'If dr IsNot Nothing Then
        '    If String.IsNullOrWhiteSpace(txtnamapelanggan.Text) Or String.IsNullOrWhiteSpace(txtnotelepon.Text) Or String.IsNullOrWhiteSpace(txtalamat.Text) Then
        '        MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        dr(1) = txtnamapelanggan.Text
        '        dr(2) = txtnotelepon.Text
        '        dr(3) = txtalamat.Text

        '        update_data("tbP")
        '    End If

        '    MessageBox.Show("Pelanggan " & txtkodepelanggan.Text & " berhasil diubah", "Edit Pelanggan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    buat_kode()
        '    txtnamapelanggan.Clear()
        '    txtnotelepon.Clear()
        '    txtalamat.Clear()
        '    txtnamapelanggan.Focus()
        'End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click

        FrCariPelanggan.Tag = "Pelanggan"
        FrCariPelanggan.ShowDialog()

    End Sub
End Class