Imports MySql.Data.MySqlClient

Public Class frmLogin
    
    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Sesuaikan connection string Anda
        koneksi()
        ComboBox1.Items.AddRange(New String() {"Admin", "User"})
        ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Semua kolom wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            koneksi()
            Using cmd As New MySqlCommand("SELECT * FROM Users WHERE Username=@u AND Password=@p AND Role=@r", CONN)
                cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim())
                cmd.Parameters.AddWithValue("@r", ComboBox1.Text)

                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        rd.Read()
                        Session.UserID = rd("UserID")
                        Session.Username = rd("Username")
                        Session.UserRole = rd("Role")
                        Session.LoginTime = DateTime.Now

                        If Session.UserRole = "Admin" Then
                            frmDashboardAdmin.Show()
                        Else
                            frmDashboardUser.Show()
                        End If
                        Me.Hide()
                    Else
                        MessageBox.Show("Login gagal! Cek username/password/role.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub
    Private Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegister.Click
        frmRegister.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
