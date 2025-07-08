Imports MySql.Data.MySqlClient

Module Module1
    Public CONN As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public STR As String
    Sub koneksi()
        Try
            Dim STR As String = "server=localhost;userid=root;password=;database=db_laundry"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
