Imports MySql.Data.MySqlClient

Public Class frmTrackOrder

    Private Sub frmTrackOrder_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnCek_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCek.Click
        If txtOrderID.Text.Trim() = "" Then
            MessageBox.Show("OrderID tidak boleh kosong.")
            Exit Sub
        End If

        Try
            koneksi()
            Using cmd As New MySqlCommand("SELECT Status FROM Orders WHERE OrderID=@id AND UserID=@u", CONN)
                cmd.Parameters.AddWithValue("@id", Val(txtOrderID.Text))
                cmd.Parameters.AddWithValue("@u", Session.UserID)
                Dim status = cmd.ExecuteScalar()
                If status Is Nothing Then
                    LblStatus.Text = "Status: Pesanan tidak ditemukan."
                    LblStatus.ForeColor = Color.Red
                Else
                    LblStatus.Text = "Status: " & status.ToString()
                    If status.ToString() = "Selesai" Then
                        LblStatus.ForeColor = Color.Green
                    ElseIf status.ToString() = "Menunggu" Then
                        LblStatus.ForeColor = Color.Orange
                    Else
                        LblStatus.ForeColor = Color.Black
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

