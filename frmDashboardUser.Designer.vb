<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboardUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboardUser))
        Me.btnHitungBiaya = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnTrackOrder = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvMyOrders = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvMyOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHitungBiaya
        '
        Me.btnHitungBiaya.BackColor = System.Drawing.Color.White
        Me.btnHitungBiaya.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHitungBiaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitungBiaya.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitungBiaya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnHitungBiaya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHitungBiaya.Location = New System.Drawing.Point(445, 129)
        Me.btnHitungBiaya.Name = "btnHitungBiaya"
        Me.btnHitungBiaya.Size = New System.Drawing.Size(194, 32)
        Me.btnHitungBiaya.TabIndex = 22
        Me.btnHitungBiaya.Text = "Hitung Biaya"
        Me.btnHitungBiaya.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(885, 129)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(194, 32)
        Me.btnLogout.TabIndex = 24
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.White
        Me.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvoice.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInvoice.Location = New System.Drawing.Point(659, 129)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(194, 32)
        Me.btnInvoice.TabIndex = 25
        Me.btnInvoice.Text = "Invoice"
        Me.btnInvoice.UseVisualStyleBackColor = False
        '
        'btnTrackOrder
        '
        Me.btnTrackOrder.BackColor = System.Drawing.Color.White
        Me.btnTrackOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrackOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrackOrder.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrackOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnTrackOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrackOrder.Location = New System.Drawing.Point(227, 129)
        Me.btnTrackOrder.Name = "btnTrackOrder"
        Me.btnTrackOrder.Size = New System.Drawing.Size(194, 32)
        Me.btnTrackOrder.TabIndex = 26
        Me.btnTrackOrder.Text = "Track Order"
        Me.btnTrackOrder.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(15, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 32)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Order Loundry"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvMyOrders
        '
        Me.dgvMyOrders.BackgroundColor = System.Drawing.Color.White
        Me.dgvMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMyOrders.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvMyOrders.Location = New System.Drawing.Point(16, 176)
        Me.dgvMyOrders.Name = "dgvMyOrders"
        Me.dgvMyOrders.RowTemplate.Height = 24
        Me.dgvMyOrders.Size = New System.Drawing.Size(795, 407)
        Me.dgvMyOrders.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "LOUNDRY MART"
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.LblWelcome.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LblWelcome.Location = New System.Drawing.Point(12, 43)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(190, 23)
        Me.LblWelcome.TabIndex = 30
        Me.LblWelcome.Text = "LOUNDRY MART"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Transparent
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(1046, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(32, 33)
        Me.btnRefresh.TabIndex = 31
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(949, 566)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 17)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Apk By Drim Studio"
        '
        'frmDashboardUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1090, 595)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.LblWelcome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvMyOrders)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTrackOrder)
        Me.Controls.Add(Me.btnInvoice)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnHitungBiaya)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboardUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvMyOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHitungBiaya As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnInvoice As System.Windows.Forms.Button
    Friend WithEvents btnTrackOrder As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvMyOrders As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
