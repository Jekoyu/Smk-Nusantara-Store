<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KasirLogout
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
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnLogout.Location = New System.Drawing.Point(395, 339)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(98, 39)
        Me.BtnLogout.TabIndex = 8
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.LblNama.Location = New System.Drawing.Point(456, 290)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(152, 46)
        Me.LblNama.TabIndex = 7
        Me.LblNama.Text = "LblNama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(293, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 46)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LOGED AS "
        '
        'KasirLogout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 669)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KasirLogout"
        Me.Text = "KasirLogout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogout As Button
    Friend WithEvents LblNama As Label
    Friend WithEvents Label1 As Label
End Class
