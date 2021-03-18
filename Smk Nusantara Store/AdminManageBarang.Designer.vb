<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminManageBarang
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.TbHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.TbStok = New System.Windows.Forms.TextBox()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(463, 568)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 38)
        Me.BtnCancel.TabIndex = 55
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(382, 568)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 38)
        Me.BtnDelete.TabIndex = 54
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(301, 568)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(75, 38)
        Me.BtnInput.TabIndex = 53
        Me.BtnInput.Text = "Input"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'TbHarga
        '
        Me.TbHarga.Location = New System.Drawing.Point(396, 485)
        Me.TbHarga.Name = "TbHarga"
        Me.TbHarga.Size = New System.Drawing.Size(142, 20)
        Me.TbHarga.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(298, 492)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Harga"
        '
        'TbId
        '
        Me.TbId.Location = New System.Drawing.Point(396, 407)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(142, 20)
        Me.TbId.TabIndex = 49
        Me.TbId.Visible = False
        '
        'TbStok
        '
        Me.TbStok.Location = New System.Drawing.Point(396, 459)
        Me.TbStok.Name = "TbStok"
        Me.TbStok.Size = New System.Drawing.Size(142, 20)
        Me.TbStok.TabIndex = 48
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(396, 433)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(142, 20)
        Me.TbName.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(296, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Stok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 442)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Name"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(52, 99)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(796, 264)
        Me.DGV.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(389, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 37)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Barang"
        '
        'AdminManageBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 669)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnInput)
        Me.Controls.Add(Me.TbHarga)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.TbStok)
        Me.Controls.Add(Me.TbName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminManageBarang"
        Me.Text = "AdminManageBarang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnInput As Button
    Friend WithEvents TbHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbId As TextBox
    Friend WithEvents TbStok As TextBox
    Friend WithEvents TbName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
End Class
