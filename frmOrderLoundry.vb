Imports MySql.Data.MySqlClient
Public Class frmOrderLoundry

    Private Sub frmOrderLaundry_Load(ByVal sender As Object, ByVal e As EventArgs)
        koneksi()
        ComboBox1.Items.AddRange(New String() {"Biasa", "Premium", "Big", "Sepatu"})
        ComboBox1.SelectedIndex = 0
        LblWelcome.Text = "Selamat datang," + Session.Username + "!"
    End Sub

    Private Sub btnHitung_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHitung.Click
        Dim hargaService As Double = 0
        Dim berat As Double = 0
        Dim biayaLayanan As Double = 0
        Dim biayaTambahan As Double = 0
        Dim total As Double = 0

        ' Validasi input berat
        If Not Double.TryParse(txtJumlah.Text, berat) OrElse berat <= 0 Then
            MessageBox.Show("Masukkan berat cucian yang valid (kg).")
            Exit Sub
        End If

        ' Tentukan harga berdasarkan jenis layanan
        Select Case ComboBox1.Text
            Case "Biasa"
                hargaService = 10000
            Case "Premium"
                hargaService = 20000
            Case "Big"
                hargaService = 25000
            Case "Sepatu"
                hargaService = 20000
        End Select

        ' Tentukan biaya layanan antar / ambil
        If rbtnAntar.Checked Then
            biayaLayanan = 10000
        ElseIf rbtnAmbil.Checked Then
            biayaLayanan = 0
        End If

        ' Tambahkan layanan tambahan jika dipilih
        If chkSetrika.Checked Then
            biayaTambahan += 5000
        End If
        If chkPewangi.Checked Then
            biayaTambahan += 2000
        End If

        ' Hitung total
        total = (berat * hargaService) + biayaLayanan + biayaTambahan

        ' Tampilkan hasil
        lblTotal.Text = "Rp " & Format(total, "N0")
    End Sub

    Private Sub btnPesan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPesan.Click
        Dim jumlah As Integer
        If Not Integer.TryParse(txtJumlah.Text, jumlah) OrElse jumlah <= 0 Then
            MessageBox.Show("Jumlah harus berupa angka positif.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            koneksi()
            Using cmd As New MySqlCommand("INSERT INTO Orders(UserID, LayananID, Jumlah, MetodePengiriman, TotalBiaya, Status) VALUES(@u, @l, @j, @m, @t, 'Menunggu')", CONN)
                cmd.Parameters.AddWithValue("@u", Session.UserID)
                cmd.Parameters.AddWithValue("@l", ComboBox1.SelectedIndex + 1)
                cmd.Parameters.AddWithValue("@j", jumlah)
                cmd.Parameters.AddWithValue("@m", If(rbtnAntar.Checked, "Penjemputan", "Ambil ke Toko"))
                cmd.Parameters.AddWithValue("@t", Convert.ToDouble(lblTotal.Text.Replace("Rp ", "").Replace(".", "").Trim()))
                cmd.ExecuteNonQuery()
                MessageBox.Show("Pesanan berhasil dibuat!")
                txtJumlah.Clear()
                lblTotal.Text = ""
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
