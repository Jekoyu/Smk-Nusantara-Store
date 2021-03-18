<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiForm
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbBarang = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbJumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbIdTransaksi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbBayar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbKembalian = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CbCustomer = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbIdCustomer = New System.Windows.Forms.TextBox()
        Me.DTPDay = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(374, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 37)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Transaksi"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Nama, Me.Harga, Me.Jumlah, Me.Total})
        Me.DGV.Location = New System.Drawing.Point(34, 193)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(828, 219)
        Me.DGV.TabIndex = 57
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.Name = "Kode"
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Nama barang"
        '
        'TbId
        '
        Me.TbId.Location = New System.Drawing.Point(132, 122)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(110, 22)
        Me.TbId.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = " "
        '
        'CbBarang
        '
        Me.CbBarang.FormattingEnabled = True
        Me.CbBarang.Location = New System.Drawing.Point(132, 148)
        Me.CbBarang.Name = "CbBarang"
        Me.CbBarang.Size = New System.Drawing.Size(110, 21)
        Me.CbBarang.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Harga"
        '
        'TbHarga
        '
        Me.TbHarga.Enabled = False
        Me.TbHarga.Location = New System.Drawing.Point(321, 122)
        Me.TbHarga.Name = "TbHarga"
        Me.TbHarga.Size = New System.Drawing.Size(110, 22)
        Me.TbHarga.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Jumlah"
        '
        'TbJumlah
        '
        Me.TbJumlah.Location = New System.Drawing.Point(321, 148)
        Me.TbJumlah.Name = "TbJumlah"
        Me.TbJumlah.Size = New System.Drawing.Size(110, 22)
        Me.TbJumlah.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Total"
        '
        'TbTotal
        '
        Me.TbTotal.Enabled = False
        Me.TbTotal.Location = New System.Drawing.Point(508, 122)
        Me.TbTotal.Name = "TbTotal"
        Me.TbTotal.Size = New System.Drawing.Size(110, 22)
        Me.TbTotal.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Id Barang"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(540, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 23)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(697, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 28)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Total"
        '
        'TbIdTransaksi
        '
        Me.TbIdTransaksi.Enabled = False
        Me.TbIdTransaksi.Location = New System.Drawing.Point(132, 94)
        Me.TbIdTransaksi.Name = "TbIdTransaksi"
        Me.TbIdTransaksi.Size = New System.Drawing.Size(110, 22)
        Me.TbIdTransaksi.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(602, 470)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Total"
        '
        'TbTotalHarga
        '
        Me.TbTotalHarga.Enabled = False
        Me.TbTotalHarga.Location = New System.Drawing.Point(660, 463)
        Me.TbTotalHarga.Name = "TbTotalHarga"
        Me.TbTotalHarga.Size = New System.Drawing.Size(110, 22)
        Me.TbTotalHarga.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(602, 498)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Bayar"
        '
        'TbBayar
        '
        Me.TbBayar.Location = New System.Drawing.Point(660, 491)
        Me.TbBayar.Name = "TbBayar"
        Me.TbBayar.Size = New System.Drawing.Size(110, 22)
        Me.TbBayar.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(602, 526)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Total"
        '
        'TbKembalian
        '
        Me.TbKembalian.Enabled = False
        Me.TbKembalian.Location = New System.Drawing.Point(660, 519)
        Me.TbKembalian.Name = "TbKembalian"
        Me.TbKembalian.Size = New System.Drawing.Size(110, 22)
        Me.TbKembalian.TabIndex = 85
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(605, 576)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 87
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(686, 576)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 88
        Me.Button4.Text = "Batal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CbCustomer
        '
        Me.CbCustomer.FormattingEnabled = True
        Me.CbCustomer.Location = New System.Drawing.Point(132, 470)
        Me.CbCustomer.Name = "CbCustomer"
        Me.CbCustomer.Size = New System.Drawing.Size(170, 21)
        Me.CbCustomer.TabIndex = 90
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(45, 477)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Customer"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(45, 504)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Id Barang"
        '
        'TbIdCustomer
        '
        Me.TbIdCustomer.Location = New System.Drawing.Point(132, 497)
        Me.TbIdCustomer.Name = "TbIdCustomer"
        Me.TbIdCustomer.Size = New System.Drawing.Size(170, 22)
        Me.TbIdCustomer.TabIndex = 91
        '
        'DTPDay
        '
        Me.DTPDay.Location = New System.Drawing.Point(132, 526)
        Me.DTPDay.Name = "DTPDay"
        Me.DTPDay.Size = New System.Drawing.Size(170, 22)
        Me.DTPDay.TabIndex = 93
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(45, 535)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "Day"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(767, 576)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 95
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 669)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DTPDay)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TbIdCustomer)
        Me.Controls.Add(Me.CbCustomer)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TbKembalian)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TbBayar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TbTotalHarga)
        Me.Controls.Add(Me.TbIdTransaksi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbJumlah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbHarga)
        Me.Controls.Add(Me.CbBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransaksiForm"
        Me.Text = "TransaksiForm"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TbId As TextBox
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents CbBarang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbHarga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbJumlah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TbIdTransaksi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbTotalHarga As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbBayar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TbKembalian As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CbCustomer As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TbIdCustomer As TextBox
    Friend WithEvents DTPDay As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Button5 As Button
End Class
