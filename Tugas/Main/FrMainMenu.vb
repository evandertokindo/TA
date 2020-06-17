
Imports System.Data.SqlClient
Public Class FrMainMenu

    Private Sub FrMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

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

    Private Sub GGudangDepan_Click(sender As Object, e As EventArgs) 

        FrGudangDepan.Show()

    End Sub

    Private Sub GGudangBelakang_Click(sender As Object, e As EventArgs) 

        FrGudangBelakang.Show()

    End Sub

    Private Sub GMutasi_Click(sender As Object, e As EventArgs) 

        FrMutasi.Show()

    End Sub

    Private Sub GPenyesuaian_Click(sender As Object, e As EventArgs) Handles GPenyesuaian.Click

        FrDataPenyesuaian.Show()

    End Sub

    Private Sub GPersediaan_Click(sender As Object, e As EventArgs) Handles GPersediaan.Click

        FrDataBarang.Show()

    End Sub

    Private Sub LPembelian_Click(sender As Object, e As EventArgs) Handles LPembelian.Click

        FrLaporanPembelian.Show()

    End Sub

    Private Sub LPenjualan_Click(sender As Object, e As EventArgs) Handles LPenjualan.Click

        FrLaporanPenjualan.Show()

    End Sub

    Private Sub LMutasi_Click(sender As Object, e As EventArgs) 

        FrLaporanMutasi.Show()

    End Sub

    Private Sub LKadaluarsa_Click(sender As Object, e As EventArgs) Handles LKadaluarsa.Click

        FrLaporanKadaluarsa.Show()

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
End Class
