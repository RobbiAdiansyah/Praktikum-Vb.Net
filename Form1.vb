Imports System.Media

Public Class Form1
    Dim targetTop As Integer
    Private WithEvents Timer1 As New Timer()
    Private fadeInStep As Double = 0.05
    Private WithEvents btnNext As New Button()

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Setup form
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.White
        Me.Size = New Size(300, 180)
        Me.Opacity = 0

        ' Pusatkan form di tengah layar utama
        Dim screenBounds As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Left = (screenBounds.Width - Me.Width) \ 2
        Me.Top = (screenBounds.Height - Me.Height) \ 2 + 50 ' Mulai sedikit di bawah tengah

        targetTop = Me.Top - 50 ' Target posisi animasi naik

        ' Setup Label1 - "Loundry Mart"
        Dim label1 As New Label()
        label1.Text = "Loundry Mart"
        label1.Font = New Font("Cooper Black", 20, FontStyle.Bold)
        label1.AutoSize = True
        label1.Location = New Point((Me.Width - label1.PreferredWidth) \ 2, 30)
        label1.TextAlign = ContentAlignment.MiddleCenter
        label1.ForeColor = Color.RoyalBlue
        Me.Controls.Add(label1)

        ' Setup Label2 - "by Drim Studio"
        Dim label2 As New Label()
        label2.Text = "by Drim Studio"
        label2.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        label2.AutoSize = True
        label2.Location = New Point((Me.Width - label2.PreferredWidth) \ 2, 70)
        label2.TextAlign = ContentAlignment.MiddleCenter
        label2.ForeColor = Color.DarkBlue
        Me.Controls.Add(label2)

        ' Setup Button
        btnNext.Text = "Masuk"
        btnNext.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnNext.Size = New Size(80, 30)
        btnNext.Location = New Point((Me.Width - btnNext.Width) \ 2, 110)
        btnNext.BackColor = Color.RoyalBlue
        btnNext.ForeColor = Color.White
        Me.Controls.Add(btnNext)

        ' Start animation
        Timer1.Interval = 30
        Timer1.Start()

        ' Mainkan suara saat form tampil
        PlayStartupSound()
    End Sub

    Private Sub PlayStartupSound()
        Try
            ' Path ke file .wav 
            Dim player As New SoundPlayer(My.Resources.Timi)
            player.Play()
        Catch ex As Exception
            MessageBox.Show("Gagal memutar suara: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += fadeInStep
        End If

        If Me.Top > targetTop Then
            Me.Top -= 2
        End If

        If Me.Opacity >= 1 AndAlso Me.Top <= targetTop Then
            Timer1.Stop()
        End If
    End Sub


    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        ' Buka form Menu
        Dim menuForm As New frmLogin()
        menuForm.Show()
        Me.Hide()
    End Sub
End Class
