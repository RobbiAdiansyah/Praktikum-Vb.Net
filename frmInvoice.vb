Imports MySql.Data.MySqlClient

Public Class frmInvoice

    Private Sub frmInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Buat koneksi sekali di sini
        koneksi()
        LblWelcome.Text = "Selamat datang, {Session.Username}!"
    End Sub

    Private Sub btnTampilkan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTampilkan.Click
        Try
            koneksi()

            Dim query As String
            If Session.UserRole = "Admin" Then
                ' Admin boleh melihat semua order
                query = "SELECT o.OrderID, u.Username, s.NamaLayanan, o.Jumlah, o.MetodePengiriman, o.TotalBiaya, o.Status, o.TanggalOrder " &
                        "FROM Orders o " &
                        "JOIN Users u ON o.UserID = u.UserID " &
                        "JOIN Services s ON o.LayananID = s.LayananID " &
                        "WHERE o.OrderID = @OrderID"
            Else
                ' User hanya boleh melihat order miliknya
                query = "SELECT o.OrderID, u.Username, s.NamaLayanan, o.Jumlah, o.MetodePengiriman, o.TotalBiaya, o.Status, o.TanggalOrder " &
                        "FROM Orders o " &
                        "JOIN Users u ON o.UserID = u.UserID " &
                        "JOIN Services s ON o.LayananID = s.LayananID " &
                        "WHERE o.OrderID = @OrderID AND o.UserID = @UserID"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@OrderID", Val(txtOrderID.Text))
            If Session.UserRole <> "Admin" Then
                cmd.Parameters.AddWithValue("@UserID", Session.UserID)
            End If

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
