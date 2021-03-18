Public Class AllLaporan
    Sub tampilkan()
        q = "select * from LaporanTransaksi order by idtransaksi asc"
        tampil(q)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True

    End Sub
    Private Sub AllLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilkan()
    End Sub
End Class