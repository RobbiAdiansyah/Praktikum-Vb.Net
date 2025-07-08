Imports MySql.Data.MySqlClient

Public Class frmDashboardUser

    Private Sub frmDashboardUser_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        
        LblWelcome.Text = "Selamat datang," + Session.Username + "!"
        LoadMyOrders()
    End Sub

    Private Sub LoadMyOrders()
        Try
            koneksi()
            Dim da As New MySqlDataAdapter("SELECT OrderID, LayananID, Jumlah, MetodePengiriman, TotalBiaya, Status FROM Orders WHERE UserID=@id", CONN)
            da.SelectCommand.Parameters.AddWithValue("@id", Session.UserID)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvMyOrders.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub btnTrackOrder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTrackOrder.Click
        frmTrackOrder.Show()
    End Sub

    Private Sub btnHitungBiaya_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHitungBiaya.Click
        frmHitungBiaya.Show()
    End Sub

    Private Sub btnInvoice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInvoice.Click
        If dgvMyOrders.SelectedRows.Count > 0 Then
            Dim orderId As Integer = CInt(dgvMyOrders.SelectedRows(0).Cells("OrderID").Value)
            frmInvoice.txtOrderID.Text = orderId.ToString()
            frmInvoice.Show()
        Else
            MessageBox.Show("Pilih pesanan terlebih dahulu!")
        End If
    End Sub

    Private Sub btnLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogout.Click
        Session.Clear()
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmOrderLoundry.Show()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadMyOrders()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
