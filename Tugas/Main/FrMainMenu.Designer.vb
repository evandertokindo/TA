<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrPesananPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrReturPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUDANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPenyesuaian = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPersediaan = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.LPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.LKadaluarsa = New System.Windows.Forms.ToolStripMenuItem()
        Me.LPenyesuaian = New System.Windows.Forms.ToolStripMenuItem()
        Me.LPersediaan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Supplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TRANSAKSIToolStripMenuItem, Me.GUDANGToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.Supplier, Me.Pelanggan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(789, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrPesananPembelian, Me.TrPembelian, Me.TrPenjualan, Me.ToolStripMenuItem1, Me.TrReturPembelian})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        Me.TRANSAKSIToolStripMenuItem.Text = "Transaksi"
        '
        'TrPesananPembelian
        '
        Me.TrPesananPembelian.Name = "TrPesananPembelian"
        Me.TrPesananPembelian.Size = New System.Drawing.Size(177, 22)
        Me.TrPesananPembelian.Text = "Pesanan Pembelian"
        '
        'TrPembelian
        '
        Me.TrPembelian.Name = "TrPembelian"
        Me.TrPembelian.Size = New System.Drawing.Size(177, 22)
        Me.TrPembelian.Text = "Pembelian"
        '
        'TrPenjualan
        '
        Me.TrPenjualan.Name = "TrPenjualan"
        Me.TrPenjualan.Size = New System.Drawing.Size(177, 22)
        Me.TrPenjualan.Text = "Penjualan"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 6)
        '
        'TrReturPembelian
        '
        Me.TrReturPembelian.Name = "TrReturPembelian"
        Me.TrReturPembelian.Size = New System.Drawing.Size(177, 22)
        Me.TrReturPembelian.Text = "Retur Pembelian"
        '
        'GUDANGToolStripMenuItem
        '
        Me.GUDANGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPenyesuaian, Me.GPersediaan})
        Me.GUDANGToolStripMenuItem.Name = "GUDANGToolStripMenuItem"
        Me.GUDANGToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.GUDANGToolStripMenuItem.Text = "Gudang"
        '
        'GPenyesuaian
        '
        Me.GPenyesuaian.Name = "GPenyesuaian"
        Me.GPenyesuaian.Size = New System.Drawing.Size(140, 22)
        Me.GPenyesuaian.Text = "Penyesuaian"
        '
        'GPersediaan
        '
        Me.GPersediaan.Name = "GPersediaan"
        Me.GPersediaan.Size = New System.Drawing.Size(140, 22)
        Me.GPersediaan.Text = "Persediaan"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LPembelian, Me.LPenjualan, Me.LKadaluarsa, Me.LPenyesuaian, Me.LPersediaan})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.LAPORANToolStripMenuItem.Text = "Laporan"
        '
        'LPembelian
        '
        Me.LPembelian.Name = "LPembelian"
        Me.LPembelian.Size = New System.Drawing.Size(140, 22)
        Me.LPembelian.Text = "Pembelian"
        '
        'LPenjualan
        '
        Me.LPenjualan.Name = "LPenjualan"
        Me.LPenjualan.Size = New System.Drawing.Size(140, 22)
        Me.LPenjualan.Text = "Penjualan"
        '
        'LKadaluarsa
        '
        Me.LKadaluarsa.Name = "LKadaluarsa"
        Me.LKadaluarsa.Size = New System.Drawing.Size(140, 22)
        Me.LKadaluarsa.Text = "Kadaluarsa"
        '
        'LPenyesuaian
        '
        Me.LPenyesuaian.Name = "LPenyesuaian"
        Me.LPenyesuaian.Size = New System.Drawing.Size(140, 22)
        Me.LPenyesuaian.Text = "Penyesuaian"
        '
        'LPersediaan
        '
        Me.LPersediaan.Name = "LPersediaan"
        Me.LPersediaan.Size = New System.Drawing.Size(140, 22)
        Me.LPersediaan.Text = "Persediaan"
        '
        'Supplier
        '
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Size = New System.Drawing.Size(62, 22)
        Me.Supplier.Text = "Supplier"
        '
        'Pelanggan
        '
        Me.Pelanggan.Name = "Pelanggan"
        Me.Pelanggan.Size = New System.Drawing.Size(75, 22)
        Me.Pelanggan.Text = "Pelanggan"
        '
        'FrMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 487)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrMainMenu"
        Me.Text = "FrMainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TRANSAKSIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrPesananPembelian As ToolStripMenuItem
    Friend WithEvents TrPembelian As ToolStripMenuItem
    Friend WithEvents GUDANGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GPenyesuaian As ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LPembelian As ToolStripMenuItem
    Friend WithEvents LPenjualan As ToolStripMenuItem
    Friend WithEvents LKadaluarsa As ToolStripMenuItem
    Friend WithEvents LPenyesuaian As ToolStripMenuItem
    Friend WithEvents TrPenjualan As ToolStripMenuItem
    Friend WithEvents LPersediaan As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents TrReturPembelian As ToolStripMenuItem
    Friend WithEvents GPersediaan As ToolStripMenuItem
    Friend WithEvents Supplier As ToolStripMenuItem
    Friend WithEvents Pelanggan As ToolStripMenuItem
End Class
