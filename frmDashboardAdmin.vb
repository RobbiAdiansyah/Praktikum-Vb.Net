Imports MySql.Data.MySqlClient

Public Class frmDashboardAdmin

    Private Sub frmDashboardAdmin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        koneksi()
        LblWelcome.Text = "Selamat datang," + Session.Username + "!"
        LoadOrders()
    End Sub

    ' Load semua pesanan ke DataGridView
    Private Sub LoadOrders()
        Try
            koneksi()
            Dim da As New MySqlDataAdapter("SELECT OrderID, UserID, LayananID, Jumlah, MetodePengiriman, TotalBiaya, Status FROM Orders", CONN)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvOrders.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    ' Tombol Refresh agar data selalu update
    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs)
        LoadOrders()
    End Sub

    ' Tombol untuk melacak order (opsional, bisa langsung di DataGridView)
    Private Sub btnTrackOrder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTrackOrder.Click
        frmTrackOrder.Show()
    End Sub

    ' Tombol untuk menghitung biaya
    Private Sub btnHitungBiaya_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHitungBiaya.Click
        frmHitungBiaya.Show()
    End Sub

    ' Tombol untuk membuka invoice
    Private Sub btnInvoice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInvoice.Click
        frmInvoice.Show()
    End Sub

    ' Tombol untuk menambah admin baru (opsional)
    Private Sub btnTambahAdmin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTambahAdmin.Click

    End Sub

    ' Tombol Logout
    Private Sub btnLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Session.Clear()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    ' Tombol untuk update status pesanan (optional feature)
    Private Sub btnUpdateStatus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdateStatus.Click
        If dgvOrders.SelectedRows.Count > 0 Then
            Dim orderId As Integer = CInt(dgvOrders.SelectedRows(0).Cells("OrderID").Value)
            Dim status As String = InputBox("Masukkan status baru (Contoh: 'Proses', 'Selesai', 'Dikirim'):", "Update Status")
            If status <> "" Then
                Try
                    koneksi()
                    Dim cmd As New MySqlCommand("UPDATE Orders SET Status=@s WHERE OrderID=@id", CONN)
                    cmd.Parameters.AddWithValue("@s", status)
                    cmd.Parameters.AddWithValue("@id", orderId)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Status pesanan berhasil diperbarui!")
                    LoadOrders()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    CONN.Close()
                End Try
            End If
        Else
            MessageBox.Show("Pilih pesanan yang ingin diubah statusnya!")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadOrders()
    End Sub
End Class
