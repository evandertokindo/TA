<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrDataSupplier
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
        Me.txtkodesupplier = New System.Windows.Forms.TextBox()
        Me.txtnamasupplier = New System.Windows.Forms.TextBox()
        Me.txtnotelepon = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 77)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'txtkodesupplier
        '
        Me.txtkodesupplier.Location = New System.Drawing.Point(109, 27)
        Me.txtkodesupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkodesupplier.Name = "txtkodesupplier"
        Me.txtkodesupplier.Size = New System.Drawing.Size(149, 20)
        Me.txtkodesupplier.TabIndex = 5
        '
        'txtnamasupplier
        '
        Me.txtnamasupplier.Location = New System.Drawing.Point(109, 51)
        Me.txtnamasupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnamasupplier.Name = "txtnamasupplier"
        Me.txtnamasupplier.Size = New System.Drawing.Size(219, 20)
        Me.txtnamasupplier.TabIndex = 6
        '
        'txtnotelepon
        '
        Me.txtnotelepon.Location = New System.Drawing.Point(109, 75)
        Me.txtnotelepon.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnotelepon.Name = "txtnotelepon"
        Me.txtnotelepon.Size = New System.Drawing.Size(219, 20)
        Me.txtnotelepon.TabIndex = 7
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(109, 101)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(219, 66)
        Me.txtAlamat.TabIndex = 8
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(270, 181)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(58, 24)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(200, 181)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(58, 24)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(270, 27)
        Me.btncari.Margin = New System.Windows.Forms.Padding(2)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(58, 20)
        Me.btncari.TabIndex = 12
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'FrDataSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 220)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtnotelepon)
        Me.Controls.Add(Me.txtnamasupplier)
        Me.Controls.Add(Me.txtkodesupplier)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrDataSupplier"
        Me.Text = "FrDataSupplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btncari As Button
    Public WithEvents txtkodesupplier As TextBox
    Public WithEvents txtnamasupplier As TextBox
    Public WithEvents txtnotelepon As TextBox
    Public WithEvents txtAlamat As TextBox
End Class
