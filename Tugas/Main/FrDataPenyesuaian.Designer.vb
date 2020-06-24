<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrDataPenyesuaian
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnopenyesuaian = New System.Windows.Forms.TextBox()
        Me.txtjumlahsistem = New System.Windows.Forms.TextBox()
        Me.txtselisih = New System.Windows.Forms.TextBox()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.dtpt = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtkodebarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btncaribarang = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.btncaripenyesuaian = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbbsatuansistem = New System.Windows.Forms.ComboBox()
        Me.nudfisik = New System.Windows.Forms.NumericUpDown()
        Me.dtpkadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudfisik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Penyesuaian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Penyesuaian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Selisih"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Keterangan"
        '
        'txtnopenyesuaian
        '
        Me.txtnopenyesuaian.Location = New System.Drawing.Point(121, 27)
        Me.txtnopenyesuaian.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnopenyesuaian.Name = "txtnopenyesuaian"
        Me.txtnopenyesuaian.Size = New System.Drawing.Size(117, 20)
        Me.txtnopenyesuaian.TabIndex = 6
        '
        'txtjumlahsistem
        '
        Me.txtjumlahsistem.Location = New System.Drawing.Point(121, 140)
        Me.txtjumlahsistem.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjumlahsistem.Name = "txtjumlahsistem"
        Me.txtjumlahsistem.Size = New System.Drawing.Size(182, 20)
        Me.txtjumlahsistem.TabIndex = 7
        '
        'txtselisih
        '
        Me.txtselisih.Location = New System.Drawing.Point(395, 57)
        Me.txtselisih.Margin = New System.Windows.Forms.Padding(2)
        Me.txtselisih.Name = "txtselisih"
        Me.txtselisih.Size = New System.Drawing.Size(182, 20)
        Me.txtselisih.TabIndex = 8
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(395, 85)
        Me.txtketerangan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(182, 101)
        Me.txtketerangan.TabIndex = 9
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(519, 195)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(58, 21)
        Me.btnedit.TabIndex = 10
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(442, 195)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(58, 21)
        Me.btntambah.TabIndex = 11
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(27, 233)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 28
        Me.dgvData.Size = New System.Drawing.Size(550, 186)
        Me.dgvData.TabIndex = 12
        '
        'dtpt
        '
        Me.dtpt.Location = New System.Drawing.Point(121, 55)
        Me.dtpt.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpt.Name = "dtpt"
        Me.dtpt.Size = New System.Drawing.Size(182, 20)
        Me.dtpt.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 34)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Jumlah Fisik"
        '
        'txtkodebarang
        '
        Me.txtkodebarang.Location = New System.Drawing.Point(121, 85)
        Me.txtkodebarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkodebarang.Name = "txtkodebarang"
        Me.txtkodebarang.Size = New System.Drawing.Size(117, 20)
        Me.txtkodebarang.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 88)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Kode Barang"
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(121, 113)
        Me.txtnamabarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(182, 20)
        Me.txtnamabarang.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 116)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Nama Barang"
        '
        'btncaribarang
        '
        Me.btncaribarang.Location = New System.Drawing.Point(243, 83)
        Me.btncaribarang.Name = "btncaribarang"
        Me.btncaribarang.Size = New System.Drawing.Size(60, 23)
        Me.btncaribarang.TabIndex = 20
        Me.btncaribarang.Text = "Cari"
        Me.btncaribarang.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(442, 456)
        Me.btncetak.Margin = New System.Windows.Forms.Padding(2)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(66, 21)
        Me.btncetak.TabIndex = 21
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'btncaripenyesuaian
        '
        Me.btncaripenyesuaian.Location = New System.Drawing.Point(243, 25)
        Me.btncaripenyesuaian.Name = "btncaripenyesuaian"
        Me.btncaripenyesuaian.Size = New System.Drawing.Size(60, 23)
        Me.btncaripenyesuaian.TabIndex = 22
        Me.btncaripenyesuaian.Text = "Cari"
        Me.btncaripenyesuaian.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(519, 456)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(58, 21)
        Me.btnsimpan.TabIndex = 23
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 168)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Satuan"
        '
        'cbbsatuansistem
        '
        Me.cbbsatuansistem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbsatuansistem.FormattingEnabled = True
        Me.cbbsatuansistem.Location = New System.Drawing.Point(121, 165)
        Me.cbbsatuansistem.Name = "cbbsatuansistem"
        Me.cbbsatuansistem.Size = New System.Drawing.Size(182, 21)
        Me.cbbsatuansistem.TabIndex = 26
        '
        'nudfisik
        '
        Me.nudfisik.Location = New System.Drawing.Point(395, 32)
        Me.nudfisik.Name = "nudfisik"
        Me.nudfisik.Size = New System.Drawing.Size(182, 20)
        Me.nudfisik.TabIndex = 27
        '
        'dtpkadaluarsa
        '
        Me.dtpkadaluarsa.Location = New System.Drawing.Point(121, 193)
        Me.dtpkadaluarsa.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpkadaluarsa.Name = "dtpkadaluarsa"
        Me.dtpkadaluarsa.Size = New System.Drawing.Size(182, 20)
        Me.dtpkadaluarsa.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 197)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Kadaluarsa"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(395, 430)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(182, 20)
        Me.txttotal.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(315, 431)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Total Barang"
        '
        'FrDataPenyesuaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 489)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtpkadaluarsa)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.nudfisik)
        Me.Controls.Add(Me.cbbsatuansistem)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btncaripenyesuaian)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.btncaribarang)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtkodebarang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpt)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.txtselisih)
        Me.Controls.Add(Me.txtjumlahsistem)
        Me.Controls.Add(Me.txtnopenyesuaian)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrDataPenyesuaian"
        Me.Text = "FrPenyesuaian"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudfisik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnopenyesuaian As TextBox
    Friend WithEvents txtjumlahsistem As TextBox
    Friend WithEvents txtselisih As TextBox
    Friend WithEvents txtketerangan As TextBox
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents dtpt As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtkodebarang As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnamabarang As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btncaribarang As Button
    Friend WithEvents btncetak As Button
    Friend WithEvents btncaripenyesuaian As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cbbsatuansistem As ComboBox
    Friend WithEvents nudfisik As NumericUpDown
    Friend WithEvents dtpkadaluarsa As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label13 As Label
End Class
