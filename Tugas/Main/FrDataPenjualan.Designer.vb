<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrDataPenjualan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnofaktur = New System.Windows.Forms.TextBox()
        Me.txtkodepelanggan = New System.Windows.Forms.TextBox()
        Me.txtnamapelanggan = New System.Windows.Forms.TextBox()
        Me.btncaripelanggan = New System.Windows.Forms.Button()
        Me.dtpt = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtkodebarang = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btncaribarang = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbbsatuan = New System.Windows.Forms.ComboBox()
        Me.btncarifaktur = New System.Windows.Forms.Button()
        Me.dtpkadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nud = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtstok = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Penjualan Header"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Faktur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(342, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kode Pelanggan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(342, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Pelanggan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 108)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Data Penjualan Detail"
        '
        'txtnofaktur
        '
        Me.txtnofaktur.Location = New System.Drawing.Point(121, 34)
        Me.txtnofaktur.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnofaktur.Name = "txtnofaktur"
        Me.txtnofaktur.Size = New System.Drawing.Size(125, 20)
        Me.txtnofaktur.TabIndex = 6
        '
        'txtkodepelanggan
        '
        Me.txtkodepelanggan.Location = New System.Drawing.Point(437, 36)
        Me.txtkodepelanggan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkodepelanggan.Name = "txtkodepelanggan"
        Me.txtkodepelanggan.Size = New System.Drawing.Size(124, 20)
        Me.txtkodepelanggan.TabIndex = 7
        '
        'txtnamapelanggan
        '
        Me.txtnamapelanggan.Location = New System.Drawing.Point(437, 63)
        Me.txtnamapelanggan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamapelanggan.Name = "txtnamapelanggan"
        Me.txtnamapelanggan.Size = New System.Drawing.Size(211, 20)
        Me.txtnamapelanggan.TabIndex = 8
        '
        'btncaripelanggan
        '
        Me.btncaripelanggan.Location = New System.Drawing.Point(571, 32)
        Me.btncaripelanggan.Margin = New System.Windows.Forms.Padding(2)
        Me.btncaripelanggan.Name = "btncaripelanggan"
        Me.btncaripelanggan.Size = New System.Drawing.Size(76, 24)
        Me.btncaripelanggan.TabIndex = 11
        Me.btncaripelanggan.Text = "Search"
        Me.btncaripelanggan.UseVisualStyleBackColor = True
        '
        'dtpt
        '
        Me.dtpt.Location = New System.Drawing.Point(121, 60)
        Me.dtpt.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpt.Name = "dtpt"
        Me.dtpt.Size = New System.Drawing.Size(200, 20)
        Me.dtpt.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 143)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Kode Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 173)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Nama Barang"
        '
        'txtkodebarang
        '
        Me.txtkodebarang.Location = New System.Drawing.Point(113, 139)
        Me.txtkodebarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkodebarang.Name = "txtkodebarang"
        Me.txtkodebarang.Size = New System.Drawing.Size(133, 20)
        Me.txtkodebarang.TabIndex = 15
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(113, 169)
        Me.txtnamabarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(208, 20)
        Me.txtnamabarang.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 197)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Jumlah"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 226)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Satuan"
        '
        'btncaribarang
        '
        Me.btncaribarang.Location = New System.Drawing.Point(262, 137)
        Me.btncaribarang.Margin = New System.Windows.Forms.Padding(2)
        Me.btncaribarang.Name = "btncaribarang"
        Me.btncaribarang.Size = New System.Drawing.Size(58, 24)
        Me.btncaribarang.TabIndex = 21
        Me.btncaribarang.Text = "Search"
        Me.btncaribarang.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(345, 133)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 28
        Me.dgvData.Size = New System.Drawing.Size(302, 209)
        Me.dgvData.TabIndex = 22
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(571, 382)
        Me.btncetak.Margin = New System.Windows.Forms.Padding(2)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(76, 24)
        Me.btncetak.TabIndex = 23
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(187, 350)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(59, 24)
        Me.btntambah.TabIndex = 24
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(253, 351)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(67, 24)
        Me.btnhapus.TabIndex = 26
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(484, 382)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(76, 24)
        Me.btnsimpan.TabIndex = 27
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(113, 252)
        Me.txtharga.Margin = New System.Windows.Forms.Padding(2)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(208, 20)
        Me.txtharga.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 255)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Harga"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(113, 282)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(208, 20)
        Me.txtsubtotal.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 286)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "SubTotal"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(484, 354)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(164, 20)
        Me.txttotal.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(434, 357)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Total"
        '
        'cbbsatuan
        '
        Me.cbbsatuan.BackColor = System.Drawing.Color.White
        Me.cbbsatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbsatuan.FormattingEnabled = True
        Me.cbbsatuan.Location = New System.Drawing.Point(113, 223)
        Me.cbbsatuan.Name = "cbbsatuan"
        Me.cbbsatuan.Size = New System.Drawing.Size(207, 21)
        Me.cbbsatuan.TabIndex = 34
        '
        'btncarifaktur
        '
        Me.btncarifaktur.Location = New System.Drawing.Point(262, 30)
        Me.btncarifaktur.Margin = New System.Windows.Forms.Padding(2)
        Me.btncarifaktur.Name = "btncarifaktur"
        Me.btncarifaktur.Size = New System.Drawing.Size(58, 24)
        Me.btncarifaktur.TabIndex = 35
        Me.btncarifaktur.Text = "Search"
        Me.btncarifaktur.UseVisualStyleBackColor = True
        '
        'dtpkadaluarsa
        '
        Me.dtpkadaluarsa.Location = New System.Drawing.Point(113, 310)
        Me.dtpkadaluarsa.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpkadaluarsa.Name = "dtpkadaluarsa"
        Me.dtpkadaluarsa.Size = New System.Drawing.Size(208, 20)
        Me.dtpkadaluarsa.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 310)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Kadaluarsa"
        '
        'nud
        '
        Me.nud.BackColor = System.Drawing.Color.White
        Me.nud.Location = New System.Drawing.Point(113, 194)
        Me.nud.Name = "nud"
        Me.nud.Size = New System.Drawing.Size(59, 20)
        Me.nud.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(206, 197)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Stok"
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(239, 194)
        Me.txtstok.Margin = New System.Windows.Forms.Padding(2)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(82, 20)
        Me.txtstok.TabIndex = 40
        '
        'FrDataPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 413)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.nud)
        Me.Controls.Add(Me.dtpkadaluarsa)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btncarifaktur)
        Me.Controls.Add(Me.cbbsatuan)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btncaribarang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.txtkodebarang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpt)
        Me.Controls.Add(Me.btncaripelanggan)
        Me.Controls.Add(Me.txtnamapelanggan)
        Me.Controls.Add(Me.txtkodepelanggan)
        Me.Controls.Add(Me.txtnofaktur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrDataPenjualan"
        Me.Text = "FrDataPenjualan"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnofaktur As TextBox
    Friend WithEvents txtkodepelanggan As TextBox
    Friend WithEvents txtnamapelanggan As TextBox
    Friend WithEvents btncaripelanggan As Button
    Friend WithEvents dtpt As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtkodebarang As TextBox
    Friend WithEvents txtnamabarang As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btncaribarang As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btncetak As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtharga As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbbsatuan As ComboBox
    Friend WithEvents btncarifaktur As Button
    Friend WithEvents dtpkadaluarsa As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents nud As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents txtstok As TextBox
End Class
