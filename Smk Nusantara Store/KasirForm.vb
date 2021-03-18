Public Class KasirForm

    Sub Switchpanel(ByVal panel As Form)
        PnlContent.Controls.Clear()
        panel.TopLevel = False
        PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub KasirForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()

        Switchpanel(KasirHome)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Switchpanel(AllLaporan)
        AllLaporan.tampilkan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Switchpanel(TransaksiForm)
        TransaksiForm.kosongkan()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Switchpanel(AdminManageBarang)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Switchpanel(KasirHome)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Switchpanel(KasirLogout)
    End Sub
End Class