<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrDataPelanggan
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
        Me.txtkodepelanggan = New System.Windows.Forms.TextBox()
        Me.txtnamapelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnotelepon = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan"
        '
        'txtkodepelanggan
        '
        Me.txtkodepelanggan.Location = New System.Drawing.Point(118, 33)
        Me.txtkodepelanggan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkodepelanggan.Name = "txtkodepelanggan"
        Me.txtkodepelanggan.Size = New System.Drawing.Size(144, 20)
        Me.txtkodepelanggan.TabIndex = 4
        '
        'txtnamapelanggan
        '
        Me.txtnamapelanggan.Location = New System.Drawing.Point(118, 59)
        Me.txtnamapelanggan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamapelanggan.Name = "txtnamapelanggan"
        Me.txtnamapelanggan.Size = New System.Drawing.Size(213, 20)
        Me.txtnamapelanggan.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 116)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Alamat"
        '
        'txtnotelepon
        '
        Me.txtnotelepon.Location = New System.Drawing.Point(118, 88)
        Me.txtnotelepon.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnotelepon.Name = "txtnotelepon"
        Me.txtnotelepon.Size = New System.Drawing.Size(213, 20)
        Me.txtnotelepon.TabIndex = 8
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(118, 114)
        Me.txtalamat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(213, 60)
        Me.txtalamat.TabIndex = 9
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(272, 188)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(59, 23)
        Me.btnedit.TabIndex = 12
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(203, 188)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(59, 23)
        Me.btnsimpan.TabIndex = 13
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(272, 33)
        Me.btncari.Margin = New System.Windows.Forms.Padding(2)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(59, 20)
        Me.btncari.TabIndex = 14
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'FrDataPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 222)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnotelepon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnamapelanggan)
        Me.Controls.Add(Me.txtkodepelanggan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrDataPelanggan"
        Me.Text = "FrDataPelanggan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnedit As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btncari As Button
    Public WithEvents txtkodepelanggan As TextBox
    Public WithEvents txtnamapelanggan As TextBox
    Public WithEvents txtnotelepon As TextBox
    Public WithEvents txtalamat As TextBox
End Class
