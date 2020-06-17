Imports System.Data.SqlClient

Public Class FrDataSupplier

    Sub buat_kode()
        Call koneksi()
        Dim htg As Long
        Dim urut As String

        cmd = New SqlCommand("select kode_s from tbS where kode_s in(select max(kode_s) from tbS) order by kode_s", conn)
        datareader = cmd.ExecuteReader
        datareader.Read()
        If datareader.HasRows Then
            htg = Strings.Right(datareader("kode_s"), 3) + 1
            urut = "SUP" + Strings.Right("00" & htg, 3)
        Else
            urut = "SUP" & "00" & +1
        End If
        datareader.Close()
        txtkodesupplier.Text = urut
        conn.Close()
    End Sub

    Private Sub FrSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        buat_kode()
        txtkodesupplier.Enabled = False
        txtnamasupplier.Focus()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        load_data_1pk("tbS")
        dr = ds.Tables("tbS").Rows.Find(txtkodesupplier.Text)
        If dr Is Nothing Then
            If String.IsNullOrWhiteSpace(txtnamasupplier.Text) Or String.IsNullOrWhiteSpace(txtnotelepon.Text) Or String.IsNullOrWhiteSpace(txtAlamat.Text) Then
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dr = ds.Tables("tbS").NewRow
                dr(0) = txtkodesupplier.Text
                dr(1) = txtnamasupplier.Text
                dr(2) = txtnotelepon.Text
                dr(3) = txtAlamat.Text
                ds.Tables("tbS").Rows.Add(dr)
                update_data("tbS")

                MessageBox.Show("Supplier " & txtkodesupplier.Text & " berhasil ditambahkan", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)

                buat_kode()
                txtnamasupplier.Clear()
                txtnotelepon.Clear()
                txtAlamat.Clear()
                txtnamasupplier.Focus()
            End If
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        load_data_1pk("tbS")
        dr = ds.Tables("tbS").Rows.Find(txtkodesupplier.Text)
        If dr IsNot Nothing Then
            If String.IsNullOrWhiteSpace(txtnamasupplier.Text) Or String.IsNullOrWhiteSpace(txtnotelepon.Text) Or String.IsNullOrWhiteSpace(txtAlamat.Text) Then
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dr(1) = txtnamasupplier.Text
                dr(2) = txtnotelepon.Text
                dr(3) = txtAlamat.Text

                update_data("tbS")
            End If

            MessageBox.Show("Supplier " & txtkodesupplier.Text & " berhasil diubah", "Edit Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            buat_kode()
            txtnamasupplier.Focus()
            txtnotelepon.Clear()
            txtAlamat.Clear()
            txtnamasupplier.Focus()
        End If

    End Sub

    Private Sub btncari_Click_1(sender As Object, e As EventArgs) Handles btncari.Click

        FrCariSupplier.Tag = "Supplier"
        FrCariSupplier.ShowDialog()

    End Sub

End Class