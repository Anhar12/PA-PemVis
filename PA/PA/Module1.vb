Imports MySql.Data.MySqlClient
Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Public HARGA_PUBLIC As Integer
    Public JUMLAH_PUBLIC As Integer
    Public MATAUANG_PUBLIC As String
    Public USERNAME_CUSTOMER As String

    Sub koneksi()
        Try
            Dim STR As String = "server=localhost;userid=root;password=;database=dbTopUp"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module