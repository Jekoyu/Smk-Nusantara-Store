Public Class LoginForm
    Sub kosongkan()
        TbUsername.Clear()
        TbPassword.Clear()
        TbUsername.Focus()
    End Sub
    Sub loginkan()
        q = "select * from tb_user where username = '" & TbUsername.Text & "' and password = '" & TbPassword.Text & "'"
        Cari(q)
        If dr.HasRows Then
            role = dr.Item("role")
            If role = "admin" Then
                AdminForm.Show()
                AdminLogout.LblNama.Text = dr.Item("username")
                AdminHome.LabelNama.Text = dr.Item("username")
                Me.Visible = False

            ElseIf role = "kasir" Then
                KasirForm.Show()
                KasirLogout.LblNama.Text = dr.Item("username")
                KasirHome.LabelNama.Text = dr.Item("username")
                idkasir = dr.Item("username")
                Me.Visible = False

            Else
                MsgBox("Hubungi admin")
                kosongkan()
            End If
        Else
            MsgBox("Username / Password Salah")
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        kosongkan()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If Not TbPassword.Text = "" Or TbUsername.Text = "" Then
            loginkan()
        Else
            MsgBox("Mohon Lengkapi Kolom")
        End If

    End Sub





    Private Sub TbUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not TbPassword.Text = "" Or TbUsername.Text = "" Then
                loginkan()
            Else
                MsgBox("Mohon Lengkapi Kolom")
            End If

        End If
    End Sub



    Private Sub TbPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not TbPassword.Text = "" Or TbUsername.Text = "" Then
                loginkan()
            Else
                MsgBox("Mohon Lengkapi Kolom")
            End If

        End If
    End Sub
End Class
