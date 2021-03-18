Public Class AdminLogout
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoginForm.Show()
        LoginForm.kosongkan()
        AdminForm.Visible = False

        AdminForm.Close()

    End Sub
End Class