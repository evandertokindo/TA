﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrCariReturPembelian
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
        Me.cbbcari = New System.Windows.Forms.ComboBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Retur Pembelian"
        '
        'cbbcari
        '
        Me.cbbcari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbcari.FormattingEnabled = True
        Me.cbbcari.Items.AddRange(New Object() {"No Retur Pembelian", "Nama Supplier"})
        Me.cbbcari.Location = New System.Drawing.Point(16, 64)
        Me.cbbcari.Name = "cbbcari"
        Me.cbbcari.Size = New System.Drawing.Size(121, 21)
        Me.cbbcari.TabIndex = 1
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(143, 65)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(322, 20)
        Me.txtcari.TabIndex = 2
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(16, 100)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(449, 150)
        Me.dgvData.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cari dengan"
        '
        'FrCariReturPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.cbbcari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrCariReturPembelian"
        Me.Text = "FrCariReturPembelian"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbbcari As ComboBox
    Friend WithEvents txtcari As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label2 As Label
End Class
