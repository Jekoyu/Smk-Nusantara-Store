Public Class KasirLogout
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        KasirForm.Visible = False
        KasirForm.Close()
        LoginForm.Show()
        LoginForm.kosongkan()
    End Sub
End Class