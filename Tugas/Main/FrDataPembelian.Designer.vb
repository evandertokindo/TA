<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrDataPembelian
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
        Me.btncetak = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btncaribarang = New System.Windows.Forms.Button()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.txtkodebarang = New System.Windows.Forms.TextBox()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.lblnbarang = New System.Windows.Forms.Label()
        Me.labelkbarang = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.dtppembelian = New System.Windows.Forms.DateTimePicker()
        Me.txtnamasupplier = New System.Windows.Forms.TextBox()
        Me.txtkodesupplier = New System.Windows.Forms.TextBox()
        Me.txtnopembelian = New System.Windows.Forms.TextBox()
        Me.LabelKodeSupp = New System.Windows.Forms.Label()
        Me.LabelNamaSupp = New System.Windows.Forms.Label()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.Labeldatasupp = New System.Windows.Forms.Label()
        Me.txtnopesananpembelian = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btntotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbsatuan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnpembelian = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtpkadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nud = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(642, 376)
        Me.btncetak.Margin = New System.Windows.Forms.Padding(2)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(63, 23)
        Me.btncetak.TabIndex = 48
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(286, 343)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(63, 23)
        Me.btnhapus.TabIndex = 47
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(202, 343)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(63, 23)
        Me.btnedit.TabIndex = 46
        Me.btnedit.Text = "Ubah"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(121, 343)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(63, 23)
        Me.btntambah.TabIndex = 45
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btncaribarang
        '
        Me.btncaribarang.Location = New System.Drawing.Point(299, 139)
        Me.btncaribarang.Margin = New System.Windows.Forms.Padding(2)
        Me.btncaribarang.Name = "btncaribarang"
        Me.btncaribarang.Size = New System.Drawing.Size(50, 22)
        Me.btncaribarang.TabIndex = 44
        Me.btncaribarang.Text = "Search"
        Me.btncaribarang.UseVisualStyleBackColor = True
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(121, 166)
        Me.txtnamabarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(228, 20)
        Me.txtnamabarang.TabIndex = 41
        '
        'txtkodebarang
        '
        Me.txtkodebarang.Location = New System.Drawing.Point(121, 141)
        Me.txtkodebarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkodebarang.Name = "txtkodebarang"
        Me.txtkodebarang.Size = New System.Drawing.Size(165, 20)
        Me.txtkodebarang.TabIndex = 40
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.Location = New System.Drawing.Point(36, 220)
        Me.lblharga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(41, 13)
        Me.lblharga.TabIndex = 39
        Me.lblharga.Text = "Satuan"
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Location = New System.Drawing.Point(36, 195)
        Me.lblqty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(40, 13)
        Me.lblqty.TabIndex = 38
        Me.lblqty.Text = "Jumlah"
        '
        'lblnbarang
        '
        Me.lblnbarang.AutoSize = True
        Me.lblnbarang.Location = New System.Drawing.Point(36, 170)
        Me.lblnbarang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnbarang.Name = "lblnbarang"
        Me.lblnbarang.Size = New System.Drawing.Size(72, 13)
        Me.lblnbarang.TabIndex = 37
        Me.lblnbarang.Text = "Nama Barang"
        '
        'labelkbarang
        '
        Me.labelkbarang.AutoSize = True
        Me.labelkbarang.Location = New System.Drawing.Point(36, 145)
        Me.labelkbarang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelkbarang.Name = "labelkbarang"
        Me.labelkbarang.Size = New System.Drawing.Size(69, 13)
        Me.labelkbarang.TabIndex = 36
        Me.labelkbarang.Text = "Kode Barang"
        Me.labelkbarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(370, 131)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowTemplate.Height = 28
        Me.dgvData.Size = New System.Drawing.Size(335, 203)
        Me.dgvData.TabIndex = 35
        '
        'dtppembelian
        '
        Me.dtppembelian.Location = New System.Drawing.Point(149, 89)
        Me.dtppembelian.Margin = New System.Windows.Forms.Padding(2)
        Me.dtppembelian.Name = "dtppembelian"
        Me.dtppembelian.Size = New System.Drawing.Size(200, 20)
        Me.dtppembelian.TabIndex = 33
        '
        'txtnamasupplier
        '
        Me.txtnamasupplier.Location = New System.Drawing.Point(462, 67)
        Me.txtnamasupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamasupplier.Name = "txtnamasupplier"
        Me.txtnamasupplier.Size = New System.Drawing.Size(243, 20)
        Me.txtnamasupplier.TabIndex = 32
        '
        'txtkodesupplier
        '
        Me.txtkodesupplier.Location = New System.Drawing.Point(463, 38)
        Me.txtkodesupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkodesupplier.Name = "txtkodesupplier"
        Me.txtkodesupplier.Size = New System.Drawing.Size(242, 20)
        Me.txtkodesupplier.TabIndex = 31
        '
        'txtnopembelian
        '
        Me.txtnopembelian.Location = New System.Drawing.Point(149, 38)
        Me.txtnopembelian.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnopembelian.Name = "txtnopembelian"
        Me.txtnopembelian.Size = New System.Drawing.Size(137, 20)
        Me.txtnopembelian.TabIndex = 30
        '
        'LabelKodeSupp
        '
        Me.LabelKodeSupp.AutoSize = True
        Me.LabelKodeSupp.Location = New System.Drawing.Point(367, 38)
        Me.LabelKodeSupp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelKodeSupp.Name = "LabelKodeSupp"
        Me.LabelKodeSupp.Size = New System.Drawing.Size(73, 13)
        Me.LabelKodeSupp.TabIndex = 29
        Me.LabelKodeSupp.Text = "Kode Supplier"
        '
        'LabelNamaSupp
        '
        Me.LabelNamaSupp.AutoSize = True
        Me.LabelNamaSupp.Location = New System.Drawing.Point(367, 66)
        Me.LabelNamaSupp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNamaSupp.Name = "LabelNamaSupp"
        Me.LabelNamaSupp.Size = New System.Drawing.Size(76, 13)
        Me.LabelNamaSupp.TabIndex = 28
        Me.LabelNamaSupp.Text = "Nama Supplier"
        '
        'LabelTanggal
        '
        Me.LabelTanggal.AutoSize = True
        Me.LabelTanggal.Location = New System.Drawing.Point(29, 93)
        Me.LabelTanggal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(46, 13)
        Me.LabelTanggal.TabIndex = 27
        Me.LabelTanggal.Text = "Tanggal"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Location = New System.Drawing.Point(27, 38)
        Me.LabelNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(76, 13)
        Me.LabelNama.TabIndex = 26
        Me.LabelNama.Text = "No. Pembelian"
        '
        'Labeldatasupp
        '
        Me.Labeldatasupp.AutoSize = True
        Me.Labeldatasupp.Location = New System.Drawing.Point(15, 18)
        Me.Labeldatasupp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labeldatasupp.Name = "Labeldatasupp"
        Me.Labeldatasupp.Size = New System.Drawing.Size(120, 13)
        Me.Labeldatasupp.TabIndex = 25
        Me.Labeldatasupp.Text = "Data Pembelian Header"
        '
        'txtnopesananpembelian
        '
        Me.txtnopesananpembelian.Location = New System.Drawing.Point(149, 64)
        Me.txtnopesananpembelian.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnopesananpembelian.Name = "txtnopesananpembelian"
        Me.txtnopesananpembelian.Size = New System.Drawing.Size(137, 20)
        Me.txtnopesananpembelian.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "No. Pesanan Pembelian"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(562, 376)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(63, 23)
        Me.btnsimpan.TabIndex = 51
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(121, 246)
        Me.txtharga.Margin = New System.Windows.Forms.Padding(2)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(228, 20)
        Me.txtharga.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 249)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Harga"
        '
        'btntotal
        '
        Me.btntotal.Location = New System.Drawing.Point(562, 346)
        Me.btntotal.Margin = New System.Windows.Forms.Padding(2)
        Me.btntotal.Name = "btntotal"
        Me.btntotal.Size = New System.Drawing.Size(143, 20)
        Me.btntotal.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(514, 349)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Total"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(121, 275)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(228, 20)
        Me.txtsubtotal.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 278)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "SubTotal"
        '
        'cbbsatuan
        '
        Me.cbbsatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbsatuan.FormattingEnabled = True
        Me.cbbsatuan.Location = New System.Drawing.Point(121, 217)
        Me.cbbsatuan.Name = "cbbsatuan"
        Me.cbbsatuan.Size = New System.Drawing.Size(228, 21)
        Me.cbbsatuan.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Data Pembelian Detail"
        '
        'btnpembelian
        '
        Me.btnpembelian.Location = New System.Drawing.Point(299, 38)
        Me.btnpembelian.Margin = New System.Windows.Forms.Padding(2)
        Me.btnpembelian.Name = "btnpembelian"
        Me.btnpembelian.Size = New System.Drawing.Size(50, 22)
        Me.btnpembelian.TabIndex = 60
        Me.btnpembelian.Text = "Search"
        Me.btnpembelian.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 63)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 22)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dtpkadaluarsa
        '
        Me.dtpkadaluarsa.Location = New System.Drawing.Point(121, 303)
        Me.dtpkadaluarsa.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpkadaluarsa.Name = "dtpkadaluarsa"
        Me.dtpkadaluarsa.Size = New System.Drawing.Size(228, 20)
        Me.dtpkadaluarsa.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 309)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Kadaluarsa"
        '
        'nud
        '
        Me.nud.Location = New System.Drawing.Point(121, 191)
        Me.nud.Name = "nud"
        Me.nud.Size = New System.Drawing.Size(228, 20)
        Me.nud.TabIndex = 65
        '
        'FrDataPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 421)
        Me.Controls.Add(Me.nud)
        Me.Controls.Add(Me.dtpkadaluarsa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnpembelian)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbbsatuan)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btntotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtnopesananpembelian)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btncaribarang)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.txtkodebarang)
        Me.Controls.Add(Me.lblharga)
        Me.Controls.Add(Me.lblqty)
        Me.Controls.Add(Me.lblnbarang)
        Me.Controls.Add(Me.labelkbarang)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.dtppembelian)
        Me.Controls.Add(Me.txtnamasupplier)
        Me.Controls.Add(Me.txtkodesupplier)
        Me.Controls.Add(Me.txtnopembelian)
        Me.Controls.Add(Me.LabelKodeSupp)
        Me.Controls.Add(Me.LabelNamaSupp)
        Me.Controls.Add(Me.LabelTanggal)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.Labeldatasupp)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrDataPembelian"
        Me.Text = "FrPembelian"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncetak As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents btncaribarang As Button
    Friend WithEvents lblharga As Label
    Friend WithEvents lblqty As Label
    Friend WithEvents lblnbarang As Label
    Friend WithEvents labelkbarang As Label
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents dtppembelian As DateTimePicker
    Friend WithEvents LabelKodeSupp As Label
    Friend WithEvents LabelNamaSupp As Label
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents Labeldatasupp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btntotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnpembelian As Button
    Friend WithEvents Button3 As Button
    Public WithEvents txtnamabarang As TextBox
    Public WithEvents txtkodebarang As TextBox
    Public WithEvents txtnamasupplier As TextBox
    Public WithEvents txtkodesupplier As TextBox
    Public WithEvents txtnopembelian As TextBox
    Public WithEvents txtnopesananpembelian As TextBox
    Public WithEvents txtharga As TextBox
    Public WithEvents txtsubtotal As TextBox
    Public WithEvents cbbsatuan As ComboBox
    Friend WithEvents dtpkadaluarsa As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents nud As NumericUpDown
End Class
