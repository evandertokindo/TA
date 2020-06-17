<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrDataPesananPembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Labeldatasupp = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.LabelNamaSupp = New System.Windows.Forms.Label()
        Me.LabelKodeSupp = New System.Windows.Forms.Label()
        Me.txtnopesananpembelian = New System.Windows.Forms.TextBox()
        Me.txtkodesupplier = New System.Windows.Forms.TextBox()
        Me.txtnamasupplier = New System.Windows.Forms.TextBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.dtpt = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchs = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.labelkbarang = New System.Windows.Forms.Label()
        Me.lblnbarang = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.txtkodebarang = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.btnsbar = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbsatuan = New System.Windows.Forms.ComboBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nud = New System.Windows.Forms.NumericUpDown()
        Me.txttotal = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labeldatasupp
        '
        Me.Labeldatasupp.AutoSize = True
        Me.Labeldatasupp.Location = New System.Drawing.Point(8, 13)
        Me.Labeldatasupp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labeldatasupp.Name = "Labeldatasupp"
        Me.Labeldatasupp.Size = New System.Drawing.Size(165, 13)
        Me.Labeldatasupp.TabIndex = 0
        Me.Labeldatasupp.Text = "Data Pesanan Pembelian Header"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Location = New System.Drawing.Point(19, 33)
        Me.LabelNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(121, 13)
        Me.LabelNama.TabIndex = 1
        Me.LabelNama.Text = "No. Pesanan Pembelian"
        '
        'LabelTanggal
        '
        Me.LabelTanggal.AutoSize = True
        Me.LabelTanggal.Location = New System.Drawing.Point(19, 62)
        Me.LabelTanggal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(46, 13)
        Me.LabelTanggal.TabIndex = 2
        Me.LabelTanggal.Text = "Tanggal"
        '
        'LabelNamaSupp
        '
        Me.LabelNamaSupp.AutoSize = True
        Me.LabelNamaSupp.Location = New System.Drawing.Point(392, 62)
        Me.LabelNamaSupp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNamaSupp.Name = "LabelNamaSupp"
        Me.LabelNamaSupp.Size = New System.Drawing.Size(76, 13)
        Me.LabelNamaSupp.TabIndex = 3
        Me.LabelNamaSupp.Text = "Nama Supplier"
        '
        'LabelKodeSupp
        '
        Me.LabelKodeSupp.AutoSize = True
        Me.LabelKodeSupp.Location = New System.Drawing.Point(392, 33)
        Me.LabelKodeSupp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelKodeSupp.Name = "LabelKodeSupp"
        Me.LabelKodeSupp.Size = New System.Drawing.Size(73, 13)
        Me.LabelKodeSupp.TabIndex = 4
        Me.LabelKodeSupp.Text = "Kode Supplier"
        '
        'txtnopesananpembelian
        '
        Me.txtnopesananpembelian.Location = New System.Drawing.Point(142, 33)
        Me.txtnopesananpembelian.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnopesananpembelian.Name = "txtnopesananpembelian"
        Me.txtnopesananpembelian.Size = New System.Drawing.Size(167, 20)
        Me.txtnopesananpembelian.TabIndex = 5
        '
        'txtkodesupplier
        '
        Me.txtkodesupplier.Location = New System.Drawing.Point(487, 33)
        Me.txtkodesupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkodesupplier.Name = "txtkodesupplier"
        Me.txtkodesupplier.Size = New System.Drawing.Size(164, 20)
        Me.txtkodesupplier.TabIndex = 6
        '
        'txtnamasupplier
        '
        Me.txtnamasupplier.Location = New System.Drawing.Point(487, 59)
        Me.txtnamasupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamasupplier.Name = "txtnamasupplier"
        Me.txtnamasupplier.Size = New System.Drawing.Size(242, 20)
        Me.txtnamasupplier.TabIndex = 7
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'dtpt
        '
        Me.dtpt.Location = New System.Drawing.Point(142, 59)
        Me.dtpt.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpt.Name = "dtpt"
        Me.dtpt.Size = New System.Drawing.Size(230, 20)
        Me.dtpt.TabIndex = 8
        '
        'btnsearchs
        '
        Me.btnsearchs.Location = New System.Drawing.Point(653, 31)
        Me.btnsearchs.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsearchs.Name = "btnsearchs"
        Me.btnsearchs.Size = New System.Drawing.Size(76, 24)
        Me.btnsearchs.TabIndex = 10
        Me.btnsearchs.Text = "Search"
        Me.btnsearchs.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(395, 120)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 28
        Me.dgvData.Size = New System.Drawing.Size(334, 165)
        Me.dgvData.TabIndex = 11
        '
        'labelkbarang
        '
        Me.labelkbarang.AutoSize = True
        Me.labelkbarang.Location = New System.Drawing.Point(28, 125)
        Me.labelkbarang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelkbarang.Name = "labelkbarang"
        Me.labelkbarang.Size = New System.Drawing.Size(69, 13)
        Me.labelkbarang.TabIndex = 12
        Me.labelkbarang.Text = "Kode Barang"
        Me.labelkbarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblnbarang
        '
        Me.lblnbarang.AutoSize = True
        Me.lblnbarang.Location = New System.Drawing.Point(28, 152)
        Me.lblnbarang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnbarang.Name = "lblnbarang"
        Me.lblnbarang.Size = New System.Drawing.Size(72, 13)
        Me.lblnbarang.TabIndex = 13
        Me.lblnbarang.Text = "Nama Barang"
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Location = New System.Drawing.Point(28, 180)
        Me.lblqty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(40, 13)
        Me.lblqty.TabIndex = 14
        Me.lblqty.Text = "Jumlah"
        '
        'txtkodebarang
        '
        Me.txtkodebarang.Location = New System.Drawing.Point(110, 122)
        Me.txtkodebarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkodebarang.Name = "txtkodebarang"
        Me.txtkodebarang.Size = New System.Drawing.Size(199, 20)
        Me.txtkodebarang.TabIndex = 16
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(110, 149)
        Me.txtnamabarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(262, 20)
        Me.txtnamabarang.TabIndex = 17
        '
        'btnsbar
        '
        Me.btnsbar.Location = New System.Drawing.Point(320, 120)
        Me.btnsbar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsbar.Name = "btnsbar"
        Me.btnsbar.Size = New System.Drawing.Size(52, 22)
        Me.btnsbar.TabIndex = 20
        Me.btnsbar.Text = "Search"
        Me.btnsbar.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(230, 262)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(63, 23)
        Me.btntambah.TabIndex = 21
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(309, 262)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(63, 23)
        Me.btnhapus.TabIndex = 23
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(666, 327)
        Me.btncetak.Margin = New System.Windows.Forms.Padding(2)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(63, 23)
        Me.btncetak.TabIndex = 24
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Data Pesanan Pembelian Detail"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(588, 327)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(63, 23)
        Me.btnsimpan.TabIndex = 26
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 207)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Satuan"
        '
        'cbbsatuan
        '
        Me.cbbsatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbsatuan.FormattingEnabled = True
        Me.cbbsatuan.Location = New System.Drawing.Point(110, 203)
        Me.cbbsatuan.Name = "cbbsatuan"
        Me.cbbsatuan.Size = New System.Drawing.Size(262, 21)
        Me.cbbsatuan.TabIndex = 28
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(320, 31)
        Me.btncari.Margin = New System.Windows.Forms.Padding(2)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(52, 22)
        Me.btncari.TabIndex = 29
        Me.btncari.Text = "Search"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(652, 301)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Jumlah Barang"
        '
        'nud
        '
        Me.nud.Location = New System.Drawing.Point(110, 175)
        Me.nud.Name = "nud"
        Me.nud.Size = New System.Drawing.Size(262, 20)
        Me.nud.TabIndex = 32
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(588, 298)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(60, 20)
        Me.txttotal.TabIndex = 33
        '
        'FrDataPesananPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 361)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.nud)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.cbbsatuan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnsbar)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.txtkodebarang)
        Me.Controls.Add(Me.lblqty)
        Me.Controls.Add(Me.lblnbarang)
        Me.Controls.Add(Me.labelkbarang)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnsearchs)
        Me.Controls.Add(Me.dtpt)
        Me.Controls.Add(Me.txtnamasupplier)
        Me.Controls.Add(Me.txtkodesupplier)
        Me.Controls.Add(Me.txtnopesananpembelian)
        Me.Controls.Add(Me.LabelKodeSupp)
        Me.Controls.Add(Me.LabelNamaSupp)
        Me.Controls.Add(Me.LabelTanggal)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.Labeldatasupp)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrDataPesananPembelian"
        Me.Text = "FrDataPesananPembelian"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labeldatasupp As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents LabelNamaSupp As Label
    Friend WithEvents LabelKodeSupp As Label
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents dtpt As DateTimePicker
    Friend WithEvents btnsearchs As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents labelkbarang As Label
    Friend WithEvents lblnbarang As Label
    Friend WithEvents lblqty As Label
    Friend WithEvents btnsbar As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btncetak As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents Label2 As Label
    Public WithEvents txtnopesananpembelian As TextBox
    Public WithEvents txtkodesupplier As TextBox
    Public WithEvents txtnamasupplier As TextBox
    Public WithEvents txtkodebarang As TextBox
    Public WithEvents txtnamabarang As TextBox
    Public WithEvents cbbsatuan As ComboBox
    Friend WithEvents btncari As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents nud As NumericUpDown
    Public WithEvents txttotal As TextBox
End Class
