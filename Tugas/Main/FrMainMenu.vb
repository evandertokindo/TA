
Imports System.Data.SqlClient
Public Class FrMainMenu

    Private Sub TrPesananPembelian_Click(sender As Object, e As EventArgs) Handles TrPesananPembelian.Click

        FrDataPesananPembelian.Show()

    End Sub

    Private Sub TrPembelian_Click(sender As Object, e As EventArgs) Handles TrPembelian.Click

        FrDataPembelian.Show()

    End Sub

    Private Sub TrPenjualan_Click(sender As Object, e As EventArgs) Handles TrPenjualan.Click

        FrDataPenjualan.Show()

    End Sub

    Private Sub TrReturPembelian_Click(sender As Object, e As EventArgs) Handles TrReturPembelian.Click

        FrDataReturPembelian.Show()

    End Sub

    Private Sub GPenyesuaian_Click(sender As Object, e As EventArgs) Handles GPenyesuaian.Click

        FrDataPenyesuaian.Show()

    End Sub

    Private Sub GPersediaan_Click(sender As Object, e As EventArgs) Handles GPersediaan.Click

        FrDataBarang.Show()

    End Sub

    Private Sub LPembelian_Click(sender As Object, e As EventArgs) Handles LPembelian.Click

        FrDaftarPembelian.Show()

    End Sub

    Private Sub LPenjualan_Click(sender As Object, e As EventArgs) Handles LPenjualan.Click

        FrDaftarPenjualan.Show()

    End Sub

    'Private Sub LKadaluarsa_Click(sender As Object, e As EventArgs) Handles LKadaluarsa.Click

    '    Frdaftarkada.Show()

    'End Sub

    Private Sub LPenyesuaian_Click(sender As Object, e As EventArgs) Handles LPenyesuaian.Click

        FrDaftarPenyesuaian.Show()

    End Sub

    Private Sub LPersediaan_Click(sender As Object, e As EventArgs) Handles LPersediaan.Click

        FrDaftarBarang.Show()

    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click

        FrDataSupplier.Show()

    End Sub

    Private Sub Pelanggan_Click(sender As Object, e As EventArgs) Handles Pelanggan.Click

        FrDataPelanggan.Show()

    End Sub
End Class
