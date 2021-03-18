Public Class AdminForm
    Sub Switchpanel(ByVal panel As Form)
        PnlContent.Controls.Clear()
        panel.TopLevel = False
        PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        Switchpanel(AdminHome)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Switchpanel(AllLaporan)
        AllLaporan.tampilkan()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Switchpanel(AdminManageBarang)
        AdminManageBarang.kosongkan()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Switchpanel(AdminLogout)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Switchpanel(AdminHome)
    End Sub
End Class