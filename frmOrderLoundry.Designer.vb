<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderLoundry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderLoundry))
        Me.rbtnAmbil = New System.Windows.Forms.RadioButton()
        Me.rbtnAntar = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkSetrika = New System.Windows.Forms.CheckBox()
        Me.chkPewangi = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtnAmbil
        '
        Me.rbtnAmbil.AutoSize = True
        Me.rbtnAmbil.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAmbil.ForeColor = System.Drawing.Color.White
        Me.rbtnAmbil.Location = New System.Drawing.Point(173, 21)
        Me.rbtnAmbil.Name = "rbtnAmbil"
        Me.rbtnAmbil.Size = New System.Drawing.Size(185, 27)
        Me.rbtnAmbil.TabIndex = 3
        Me.rbtnAmbil.TabStop = True
        Me.rbtnAmbil.Text = "Ambil Ke Toko"
        Me.rbtnAmbil.UseVisualStyleBackColor = True
        '
        'rbtnAntar
        '
        Me.rbtnAntar.AutoSize = True
        Me.rbtnAntar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAntar.ForeColor = System.Drawing.Color.White
        Me.rbtnAntar.Location = New System.Drawing.Point(6, 21)
        Me.rbtnAntar.Name = "rbtnAntar"
        Me.rbtnAntar.Size = New System.Drawing.Size(156, 27)
        Me.rbtnAntar.TabIndex = 4
        Me.rbtnAntar.TabStop = True
        Me.rbtnAntar.Text = "Pesan Antar"
        Me.rbtnAntar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Biasa", "Premium", "Big", "Sepatu"})
        Me.ComboBox1.Location = New System.Drawing.Point(323, 260)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(246, 33)
        Me.ComboBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "LOUNDRY MART"
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.LblWelcome.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblWelcome.Location = New System.Drawing.Point(21, 54)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(190, 23)
        Me.LblWelcome.TabIndex = 31
        Me.LblWelcome.Text = "LOUNDRY MART"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(177, 498)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(15, 23)
        Me.lblTotal.TabIndex = 32
        Me.lblTotal.Text = " "
        '
        'btnPesan
        '
        Me.btnPesan.BackColor = System.Drawing.Color.White
        Me.btnPesan.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnPesan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesan.Location = New System.Drawing.Point(29, 540)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(194, 32)
        Me.btnPesan.TabIndex = 33
        Me.btnPesan.Text = "Order"
        Me.btnPesan.UseVisualStyleBackColor = False
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.White
        Me.btnHitung.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnHitung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHitung.Location = New System.Drawing.Point(375, 540)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(194, 32)
        Me.btnHitung.TabIndex = 34
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(323, 194)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(246, 30)
        Me.txtJumlah.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 23)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Masukan Jumlah (Kg/Pcs)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 23)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Pilih Layanan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 23)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Pilih Metode Order"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnAntar)
        Me.GroupBox1.Controls.Add(Me.rbtnAmbil)
        Me.GroupBox1.Location = New System.Drawing.Point(205, 418)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 60)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(545, 150)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(246, 30)
        Me.txtUsername.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(616, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 23)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Biasa Rp10.000/Kg"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(616, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 23)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Premium Rp20.000/Pcs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(616, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 23)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "BIg Rp 25.000/pcs"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(616, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 23)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Sepatu Rp20.000/pcs"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(616, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(252, 23)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Pesan Antar + Rp10.000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(616, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(284, 23)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Harga Service dan Layanan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(25, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(259, 23)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Pilih Layanan Tambahan"
        '
        'chkSetrika
        '
        Me.chkSetrika.AutoSize = True
        Me.chkSetrika.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetrika.ForeColor = System.Drawing.Color.White
        Me.chkSetrika.Location = New System.Drawing.Point(323, 334)
        Me.chkSetrika.Name = "chkSetrika"
        Me.chkSetrika.Size = New System.Drawing.Size(109, 27)
        Me.chkSetrika.TabIndex = 47
        Me.chkSetrika.Text = "Setrika"
        Me.chkSetrika.UseVisualStyleBackColor = True
        '
        'chkPewangi
        '
        Me.chkPewangi.AutoSize = True
        Me.chkPewangi.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPewangi.ForeColor = System.Drawing.Color.White
        Me.chkPewangi.Location = New System.Drawing.Point(449, 334)
        Me.chkPewangi.Name = "chkPewangi"
        Me.chkPewangi.Size = New System.Drawing.Size(120, 27)
        Me.chkPewangi.TabIndex = 48
        Me.chkPewangi.Text = "Pewangi"
        Me.chkPewangi.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(1038, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 36)
        Me.Button1.TabIndex = 55
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(25, 498)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 23)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Total Bayar :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(949, 569)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 17)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Apk By Drim Studio"
        '
        'frmOrderLoundry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1090, 595)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkPewangi)
        Me.Controls.Add(Me.chkSetrika)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.btnPesan)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.LblWelcome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrderLoundry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOrderLoundry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtnAmbil As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAntar As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnPesan As System.Windows.Forms.Button
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkSetrika As System.Windows.Forms.CheckBox
    Friend WithEvents chkPewangi As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
