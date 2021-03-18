<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(758, 440)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(92, 42)
        Me.BtnLogin.TabIndex = 13
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(634, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 37)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(634, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 37)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Username"
        '
        'TbPassword
        '
        Me.TbPassword.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbPassword.Location = New System.Drawing.Point(776, 349)
        Me.TbPassword.Multiline = True
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.Size = New System.Drawing.Size(224, 46)
        Me.TbPassword.TabIndex = 10
        '
        'TbUsername
        '
        Me.TbUsername.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbUsername.Location = New System.Drawing.Point(776, 283)
        Me.TbUsername.Multiline = True
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(224, 46)
        Me.TbUsername.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(750, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 46)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "LOGIN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 700)
        Me.Panel1.TabIndex = 7
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
