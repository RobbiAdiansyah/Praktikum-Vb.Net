<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboardAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboardAdmin))
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.btnTambahAdmin = New System.Windows.Forms.Button()
        Me.btnTrackOrder = New System.Windows.Forms.Button()
        Me.btnHitungBiaya = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnUpdateStatus = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOrders
        '
        Me.dgvOrders.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.GridColor = System.Drawing.Color.Black
        Me.dgvOrders.Location = New System.Drawing.Point(12, 211)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.RowTemplate.Height = 24
        Me.dgvOrders.Size = New System.Drawing.Size(741, 372)
        Me.dgvOrders.TabIndex = 0
        '
        'btnTambahAdmin
        '
        Me.btnTambahAdmin.BackColor = System.Drawing.Color.White
        Me.btnTambahAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambahAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahAdmin.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnTambahAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambahAdmin.Location = New System.Drawing.Point(875, 175)
        Me.btnTambahAdmin.Name = "btnTambahAdmin"
        Me.btnTambahAdmin.Size = New System.Drawing.Size(194, 32)
        Me.btnTambahAdmin.TabIndex = 19
        Me.btnTambahAdmin.Text = "Tambah Admin"
        Me.btnTambahAdmin.UseVisualStyleBackColor = False
        '
        'btnTrackOrder
        '
        Me.btnTrackOrder.BackColor = System.Drawing.Color.White
        Me.btnTrackOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrackOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrackOrder.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrackOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnTrackOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrackOrder.Location = New System.Drawing.Point(223, 137)
        Me.btnTrackOrder.Name = "btnTrackOrder"
        Me.btnTrackOrder.Size = New System.Drawing.Size(194, 32)
        Me.btnTrackOrder.TabIndex = 20
        Me.btnTrackOrder.Text = "Track Order"
        Me.btnTrackOrder.UseVisualStyleBackColor = False
        '
        'btnHitungBiaya
        '
        Me.btnHitungBiaya.BackColor = System.Drawing.Color.White
        Me.btnHitungBiaya.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHitungBiaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitungBiaya.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitungBiaya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnHitungBiaya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHitungBiaya.Location = New System.Drawing.Point(423, 137)
        Me.btnHitungBiaya.Name = "btnHitungBiaya"
        Me.btnHitungBiaya.Size = New System.Drawing.Size(194, 32)
        Me.btnHitungBiaya.TabIndex = 21
        Me.btnHitungBiaya.Text = "Hitung Biaya"
        Me.btnHitungBiaya.UseVisualStyleBackColor = False
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.White
        Me.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvoice.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInvoice.Location = New System.Drawing.Point(623, 137)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(194, 32)
        Me.btnInvoice.TabIndex = 22
        Me.btnInvoice.Text = "Invoice"
        Me.btnInvoice.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(875, 137)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(194, 32)
        Me.btnLogout.TabIndex = 23
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.BackColor = System.Drawing.Color.White
        Me.btnUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStatus.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUpdateStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateStatus.Location = New System.Drawing.Point(12, 137)
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(194, 32)
        Me.btnUpdateStatus.TabIndex = 25
        Me.btnUpdateStatus.Text = "Update Status"
        Me.btnUpdateStatus.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 400)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 9)
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
        Me.LblWelcome.Location = New System.Drawing.Point(18, 47)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(190, 23)
        Me.LblWelcome.TabIndex = 31
        Me.LblWelcome.Text = "LOUNDRY MART"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1037, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 33)
        Me.Button1.TabIndex = 32
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(949, 569)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Apk By Drim Studio"
        '
        'frmDashboardAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1090, 595)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblWelcome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdateStatus)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnInvoice)
        Me.Controls.Add(Me.btnHitungBiaya)
        Me.Controls.Add(Me.btnTrackOrder)
        Me.Controls.Add(Me.btnTambahAdmin)
        Me.Controls.Add(Me.dgvOrders)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboardAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvOrders As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambahAdmin As System.Windows.Forms.Button
    Friend WithEvents btnTrackOrder As System.Windows.Forms.Button
    Friend WithEvents btnHitungBiaya As System.Windows.Forms.Button
    Friend WithEvents btnInvoice As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnUpdateStatus As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblWelcome As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
