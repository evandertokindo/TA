
Imports System.Data.SqlClient
Public Class FrMainMenu

    Private Sub GPenyesuaian_Click(sender As Object, e As EventArgs) Handles GPenyesuaian.Click
        FrDataPenyesuaian.Show()
    End Sub

    Private Sub GPersediaan_Click(sender As Object, e As EventArgs) Handles GPersediaan.Click
        FrDataBarang.Show()
    End Sub

    Private Sub LPembelian_Click(sender As Object, e As EventArgs) Handles LPembelian.Click

    End Sub

    Private Sub LPenjualan_Click(sender As Object, e As EventArgs) Handles LPenjualan.Click

    End Sub

    Private Sub LPenyesuaian_Click(sender As Object, e As EventArgs) Handles LPenyesuaian.Click
        FrLaporanPenyesuaian.Show()
    End Sub

    Private Sub LPersediaan_Click(sender As Object, e As EventArgs) Handles LPersediaan.Click
        FrLaporanPersediaan.Show()
    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click
        FrDataSupplier.Show()
    End Sub

    Private Sub Pelanggan_Click(sender As Object, e As EventArgs) Handles Pelanggan.Click
        FrDataPelanggan.Show()
    End Sub

    Private Sub PesananPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananPembelianToolStripMenuItem.Click
        FrDataPesananPembelian.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        FrDataPembelian.Show()
    End Sub

    Private Sub ReturPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturPembelianToolStripMenuItem.Click
        FrDataReturPembelian.Show()
    End Sub

    Private Sub PesananPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananPenjualanToolStripMenuItem.Click
        FrDataPesananPenjualan.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FrDataPenjualan.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        FrDaftarSupplier.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        FrDaftarPelanggan.Show()
    End Sub

    Private Sub BarangToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PesananPembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PembelianToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReturPembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PesananPenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PenjualanToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PenyesuaianToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LKadaluarsa_Click(sender As Object, e As EventArgs) Handles LKadaluarsa.Click
        FrLaporanKadaluarsa.Show()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FrDaftarBarang.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem1.Click
        FrLaporanPembelian.Show()
    End Sub

    Private Sub PesananPembelianToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles PesananPembelianToolStripMenuItem1.Click
        FrLaporanPesananPembelian.Show()
    End Sub

    Private Sub PesananPenjualanToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles PesananPenjualanToolStripMenuItem1.Click
        FrLaporanPesananPenjualan.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click
        FrLaporanPenjualan.Show()
    End Sub
End Class
