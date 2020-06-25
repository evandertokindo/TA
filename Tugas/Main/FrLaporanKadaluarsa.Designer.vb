<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrLaporanKadaluarsa
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
        Me.btncetak = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan Kadaluarsa"
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(466, 256)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(53, 23)
        Me.btncetak.TabIndex = 1
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 100)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(507, 150)
        Me.dgvData.TabIndex = 2
        '
        'FrLaporanKadaluarsa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 291)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrLaporanKadaluarsa"
        Me.Text = "FrLaporanKadaluarsa"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btncetak As Button
    Friend WithEvents dgvData As DataGridView
End Class
