Public Class TransaksiForm
    Dim namabarang As String
    Dim jumlahbarang As Integer
    Dim totalharga As Integer
    Dim hargabarang As Integer
    Dim totaltransaksi As Integer

    Sub Switchpanel(ByVal panel As Form)
        KasirForm.PnlContent.Controls.Clear()
        panel.TopLevel = False
        KasirForm.PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub
    Sub kosongkan()
        DTPDay.Format = DateTimePickerFormat.Custom
        DTPDay.CustomFormat = "dd MMM yyyy "
        TbId.Clear()
        CbBarang.ResetText()
        TbHarga.Clear()
        TbJumlah.Clear()
        TbTotal.Clear()
        TbTotalHarga.Clear()
        TbKembalian.Clear()
        TbBayar.Clear()
        TbId.Focus()
        tampilcb()
        AutoId()
    End Sub
    Sub tampilcb()
        Try
            q = "select * from tb_barang order by idbarang desc "
            cmd = New SqlClient.SqlCommand(q, conn)
            dr = cmd.ExecuteReader
            CbBarang.Items.Clear()

            While dr.Read

                CbBarang.Items.Add(dr.Item("nama"))


            End While
            q = "select * from tb_customer"
            cmd = New SqlClient.SqlCommand(q, conn)
            dr = cmd.ExecuteReader
            CbCustomer.Items.Clear()

            While dr.Read
                CbCustomer.Items.Add(dr.Item("nama"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub AutoId()
        q = "select * from tb_transaksi order by idtransaksi desc"
        Cari(q)
        If dr.HasRows Then
            TbIdTransaksi.Text = "TRC" + Format(Microsoft.VisualBasic.Right(dr.Item("idtransaksi"), 6) + 1, "000000")
        Else
            TbIdTransaksi.Text = "TRC000001"
        End If
    End Sub



    Private Sub TbId_TextChanged(sender As Object, e As EventArgs) Handles TbId.TextChanged
        koneksi()
        Dim idbarang As String
        idbarang = TbId.Text
        q = "select * from tb_barang where idbarang = '" & idbarang & "'"
        Cari(q)
        If dr.HasRows Then
            CbBarang.Text = dr.Item("nama")
            TbHarga.Text = dr.Item("harga")
        End If
    End Sub
    Sub inputdtl()
        Dim jmlbarang As Integer = TbJumlah.Text
        Dim jmlstok As Integer
        Dim jmlakhir As Integer
        q = "select stok from tb_barang where idbarang='" & TbId.Text & "'"
        Cari(q)
        jmlstok = dr.Item("stok")
        If jmlstok = 0 Then
            MsgBox("stok hasbis")
        Else
            jmlakhir = jmlstok - jmlbarang
            If jmlakhir <= 0 Then
                MsgBox("Stok Kurang")
                kosongkan()
            Else
                MsgBox(jmlakhir)
                q = "insert into tb_dtltransaksi(idtransaksi,idbarang,jumlah) values('" & TbIdTransaksi.Text & "','" & TbId.Text & "','" & TbJumlah.Text & "')"
                MsgBox(q)
                inputdgv()
                executenonquery(q)
                q = "update tb_barang set stok='" & jmlakhir & "' where idbarang = '" & TbId.Text & "'"
                executenonquery(q)
                kosongkan()
            End If
        End If

    End Sub
    Sub masukkan()
        q = "insert into tb_transaksi(idtransaksi,idpegawai,idcustomer,day,total) values('" & TbIdTransaksi.Text & "','" & idkasir & "','" & TbIdCustomer.Text & "','" & Format(DTPDay.Value, "dd MMM yyyy hh:mm") & "','" & TbTotalHarga.Text & "')"
        MsgBox(q)
        executenonquery(q)
        q = "insert into tb_dtltransaksi(idtransaksi,idbarang) values('" & TbIdTransaksi.Text & "','" & TbId.Text & "')"
        MsgBox(q)
        executenonquery(q)
    End Sub

    Private Sub TransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        kosongkan()
    End Sub
    Sub deletedtl()
        q = "delete from tb_dtltransaksi where idtransaksi = '" & TbIdTransaksi.Text & "'"
        executenonquery(q)
    End Sub
    Sub mulaiawal()
        kosongkan()
        DGV.Rows.Clear()
        TbIdCustomer.Clear()
        CbCustomer.ResetText()

    End Sub
    Sub inputdgv()
        DGV.Rows.Add(1)
        DGV.Rows(DGV.RowCount - 2).Cells(0).Value = TbId.Text
        DGV.Rows(DGV.RowCount - 2).Cells(1).Value = CbBarang.Text
        DGV.Rows(DGV.RowCount - 2).Cells(2).Value = TbHarga.Text
        DGV.Rows(DGV.RowCount - 2).Cells(3).Value = TbJumlah.Text
        DGV.Rows(DGV.RowCount - 2).Cells(4).Value = TbTotal.Text
        DGV.Update()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TbId.Text = "" Or TbJumlah.Text = "" Then
            MsgBox("data kosong")
        Else
            inputdtl()
            TbId.Clear()
            CbBarang.ResetText()
            TbHarga.Clear()
            TbJumlah.Clear()
            TbTotal.Clear()
            totaltransaksi = totaltransaksi + totalharga
            Label8.Text = totaltransaksi
            TbTotalHarga.Text = totaltransaksi
        End If
    End Sub

    Private Sub CbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbBarang.SelectedIndexChanged
        namabarang = CbBarang.SelectedItem
        q = "select * from tb_barang where nama='" & namabarang & "'"
        Cari(q)
        If dr.HasRows Then
            TbHarga.Text = dr.Item("harga")
            TbId.Text = dr.Item("idbarang")
        End If
    End Sub

    Private Sub TbId_Leave(sender As Object, e As EventArgs) Handles TbId.Leave
        namabarang = CbBarang.SelectedItem
        q = "select * from tb_barang where nama='" & namabarang & "'"
        Cari(q)
        If dr.HasRows Then
            TbHarga.Text = dr.Item("harga")
            TbId.Text = dr.Item("idbarang")
        End If
    End Sub

    Private Sub TbJumlah_TextChanged(sender As Object, e As EventArgs) Handles TbJumlah.TextChanged
        Try
            hargabarang = TbHarga.Text
            jumlahbarang = TbJumlah.Text
            If Not jumlahbarang = "0" Then
                totalharga = hargabarang * jumlahbarang
                TbTotal.Text = totalharga
            End If
        Catch ex As Exception
        End Try
    End Sub



    Private Sub TbBayar_TextChanged(sender As Object, e As EventArgs) Handles TbBayar.TextChanged
        Dim bayar As Integer
        Dim kembalian As Integer
        If Not TbBayar.Text = "" Then
            bayar = TbBayar.Text
            If Not bayar = "0" Then
                kembalian = bayar - totaltransaksi
                TbKembalian.Text = kembalian
            End If
        End If
    End Sub

    Private Sub TbBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim bayar As Integer
            Dim kembalian As Integer
            bayar = TbBayar.Text
            If Not bayar = "0" Then
                If bayar = "" Then
                    kembalian = bayar - totaltransaksi
                    TbKembalian.Text = kembalian
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        kosongkan()
    End Sub
    Private Sub TbIdCustomer_TextChanged(sender As Object, e As EventArgs) Handles TbIdCustomer.TextChanged
        q = "select * from tb_customer where idcustomer= '" & TbIdCustomer.Text & "'"
        Cari(q)
        If dr.HasRows Then
            CbCustomer.Text = dr.Item("nama")
        End If
    End Sub

    Private Sub CbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCustomer.SelectedIndexChanged
        q = "select * from tb_customer where nama='" & CbCustomer.Text & "'"
        Cari(q)
        If dr.HasRows Then
            TbIdCustomer.Text = dr.Item("idcustomer")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not TbBayar.Text = "" Then
            If Not TbIdCustomer.Text = "" Then
                masukkan()
                mulaiawal()
            Else
                MsgBox("Customer Kosong")
            End If
        Else
            MsgBox("Terdapat Data Kosong")
        End If
        kosongkan()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        deletedtl()
        mulaiawal()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Switchpanel(KasirHome)
    End Sub
End Class