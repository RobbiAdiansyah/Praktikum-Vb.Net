Imports MySql.Data.MySqlClient

Public Class frmRegister

    Private Sub frmRegister_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Sesuaikan koneksi dengan database Anda
        koneksi()
        cmbRole.Items.Add("User")
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegister.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Username dan Password harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            koneksi()
            ' Cek apakah username sudah ada
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@u", CONN)
            checkCmd.Parameters.AddWithValue("@u", txtUsername.Text)
            Dim count As Integer = CInt(checkCmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Username sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Simpan user baru
                Dim cmd As New MySqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r)", conn)
                cmd.Parameters.AddWithValue("@u", txtUsername.Text)
                cmd.Parameters.AddWithValue("@p", txtPassword.Text)
                cmd.Parameters.AddWithValue("@r", cmbRole.Text)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Registrasi berhasil! Silakan login.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmLogin.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class
