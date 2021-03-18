Public Class AdminManageBarang
    Sub AutoId()
        q = "select * from tb_barang order by idbarang desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "ITM" + Format(Microsoft.VisualBasic.Right(dr.Item("idbarang"), 6) + 1, "000000")
        Else
            TbId.Text = "ITM000001"
        End If
    End Sub
    Sub Tampilkan()
        q = "select * from tb_barang"
        tampil(q)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True

    End Sub

    Sub kosongkan()
        TbName.Clear()
        TbStok.Clear()
        TbHarga.Clear()
        TbName.Focus()
        AutoId()
        Tampilkan()
    End Sub
    Sub Hapuskan()
        q = "delete from tb_barang where idbarang = '" & TbId.Text & "'"
        executenonquery(q)
        kosongkan()
    End Sub
    Sub tambahkan()
        q = "select * from tb_barang where idbarang = '" & TbId.Text & "'"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_barang set nama ='" & TbName.Text & "',stok='" & TbStok.Text & "',harga='" & TbHarga.Text & "' where idbarang = '" & TbId.Text & "'"

            executenonquery(q)
            kosongkan()

        Else
            q = "insert into tb_barang(idbarang,nama,stok,harga) values('" & TbId.Text & "','" & TbName.Text & "','" & TbStok.Text & "','" & TbHarga.Text & "')"

            executenonquery(q)
            kosongkan()
        End If
    End Sub
    Private Sub AdminManageBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        kosongkan()

    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        If Not TbName.Text = "" Or TbStok.Text = "" Or TbHarga.Text = "" Then
            tambahkan()
        Else
            MsgBox("data Belum Lengkap ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        kosongkan()
    End Sub



    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        TbId.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TbName.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TbStok.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TbHarga.Text = DGV.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim r As String
        r = MsgBox("Yakin Hapus???", vbYesNo)
        If r = vbYes Then
            Hapuskan()
            kosongkan()
        ElseIf r = vbNo Then
            kosongkan()

        End If
    End Sub
End Class