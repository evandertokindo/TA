Imports System.Data.SqlClient
Public Class FrDaftarSupplier

    Sub daftarsupplier()
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

    Private Sub FrDaftarSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrMainMenu
        koneksi()
        daftarsupplier()
        dgvData.Rows.Clear()
        query = "Select * from tbS"
        cmd = New SqlCommand(query, conn)
        datareader = cmd.ExecuteReader
        If datareader.HasRows Then
            While datareader.Read
                dgvData.Rows.Add(datareader.Item(0), datareader.Item(1), datareader.Item(2), datareader.Item(3))
            End While
        End If
        datareader.Close()
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        query = "Select * from tbS"
        cmd = New SqlCommand(query, conn)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "tbS")

        Dim cr As New CrDaftarSupplier
        Dim viewer As New FrCr
        cr.SetDataSource(ds)
        viewer.CrystalReportViewer1.ReportSource = cr
        viewer.WindowState = FormWindowState.Maximized
        viewer.Show()
    End Sub
End Class