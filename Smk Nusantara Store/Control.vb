Imports System.Data.SqlClient
Module Control
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public ds As DataSet
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public q As String
    Public role As String
    Public studentid As String
    Public teacherid As String
    Public adminid As String
    Public idkasir As String



    Public Sub koneksi()
        Try
            conn = New SqlConnection("Data Source=DESKTOP-VOQEHKC\SQLEXPRESS;Initial Catalog=db_si_smk;Integrated Security=True;MultipleActiveResultSets = true")
            conn.Open()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Function tampil(ByVal q As String) As Boolean
        Try
            da = New SqlDataAdapter(q, conn)
            ds = New DataSet
            da.Fill(ds)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return True
    End Function
    Function executenonquery(ByVal q As String) As Boolean
        Try
            cmd = New SqlCommand(q, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True

    End Function
    Function Cari(ByVal q As String) As Boolean
        Try
            cmd = New SqlCommand(q, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

End Module
