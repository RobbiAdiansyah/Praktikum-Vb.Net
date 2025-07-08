Public Class frmHitungBiaya
    Private Sub frmHitungBiaya_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(New String() {"Biasa", "Premium", "Big", "Sepatu"})
        ComboBox1.SelectedIndex = 0
        LblWelcome.Text = "Selamat datang, {Session.Username}!"
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
        lblTotal.Text = "Total Biaya Rp " & Format(total, "N0")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
