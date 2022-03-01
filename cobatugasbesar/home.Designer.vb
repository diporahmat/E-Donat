<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.cbxPilihan = New System.Windows.Forms.ComboBox()
        Me.btnLanjutPembayaran = New System.Windows.Forms.Button()
        Me.lblNamaWelcome = New System.Windows.Forms.Label()
        Me.lblJenisDonat = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.btnAdaLagi = New System.Windows.Forms.Button()
        Me.lblTotalHarga = New System.Windows.Forms.Label()
        Me.lblHargaTotal = New System.Windows.Forms.Label()
        Me.ptb1 = New System.Windows.Forms.PictureBox()
        Me.lblPilihDonat = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblnamapelanggan = New System.Windows.Forms.Label()
        Me.btnOpenData = New System.Windows.Forms.Button()
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxPilihan
        '
        Me.cbxPilihan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxPilihan.FormattingEnabled = True
        Me.cbxPilihan.Items.AddRange(New Object() {"Alcapone", "Caviar Chocolate", "Cheese Cakelicious", "Crunchy Crunchy", "Heaven Berry", "Marble Hazel", "Mr. Green Tea", "Oreology", "Tira Miss U", "Why Nut?"})
        Me.cbxPilihan.Location = New System.Drawing.Point(55, 283)
        Me.cbxPilihan.Name = "cbxPilihan"
        Me.cbxPilihan.Size = New System.Drawing.Size(204, 21)
        Me.cbxPilihan.TabIndex = 1
        '
        'btnLanjutPembayaran
        '
        Me.btnLanjutPembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLanjutPembayaran.Location = New System.Drawing.Point(400, 281)
        Me.btnLanjutPembayaran.Name = "btnLanjutPembayaran"
        Me.btnLanjutPembayaran.Size = New System.Drawing.Size(118, 23)
        Me.btnLanjutPembayaran.TabIndex = 2
        Me.btnLanjutPembayaran.Text = "Lanjut Pembayaran"
        Me.btnLanjutPembayaran.UseVisualStyleBackColor = True
        '
        'lblNamaWelcome
        '
        Me.lblNamaWelcome.AutoSize = True
        Me.lblNamaWelcome.Font = New System.Drawing.Font("Perpetua", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaWelcome.ForeColor = System.Drawing.Color.Firebrick
        Me.lblNamaWelcome.Location = New System.Drawing.Point(23, 16)
        Me.lblNamaWelcome.Name = "lblNamaWelcome"
        Me.lblNamaWelcome.Size = New System.Drawing.Size(0, 31)
        Me.lblNamaWelcome.TabIndex = 4
        '
        'lblJenisDonat
        '
        Me.lblJenisDonat.AutoSize = True
        Me.lblJenisDonat.BackColor = System.Drawing.Color.White
        Me.lblJenisDonat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenisDonat.Location = New System.Drawing.Point(291, 66)
        Me.lblJenisDonat.Name = "lblJenisDonat"
        Me.lblJenisDonat.Size = New System.Drawing.Size(0, 25)
        Me.lblJenisDonat.TabIndex = 5
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.BackColor = System.Drawing.Color.White
        Me.lblHarga.Location = New System.Drawing.Point(293, 110)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(0, 13)
        Me.lblHarga.TabIndex = 6
        '
        'txtJumlah
        '
        Me.txtJumlah.BackColor = System.Drawing.Color.White
        Me.txtJumlah.Location = New System.Drawing.Point(350, 138)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(43, 20)
        Me.txtJumlah.TabIndex = 7
        Me.txtJumlah.Visible = False
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.BackColor = System.Drawing.Color.White
        Me.lblJumlah.Location = New System.Drawing.Point(293, 141)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(0, 13)
        Me.lblJumlah.TabIndex = 8
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.ForeColor = System.Drawing.Color.Maroon
        Me.lblLogOut.Location = New System.Drawing.Point(485, 16)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(59, 17)
        Me.lblLogOut.TabIndex = 9
        Me.lblLogOut.Text = "Log Out"
        '
        'btnAdaLagi
        '
        Me.btnAdaLagi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdaLagi.Location = New System.Drawing.Point(318, 281)
        Me.btnAdaLagi.Name = "btnAdaLagi"
        Me.btnAdaLagi.Size = New System.Drawing.Size(76, 23)
        Me.btnAdaLagi.TabIndex = 10
        Me.btnAdaLagi.Text = "Ada Lagi?"
        Me.btnAdaLagi.UseVisualStyleBackColor = True
        '
        'lblTotalHarga
        '
        Me.lblTotalHarga.AutoSize = True
        Me.lblTotalHarga.BackColor = System.Drawing.Color.White
        Me.lblTotalHarga.Location = New System.Drawing.Point(293, 168)
        Me.lblTotalHarga.Name = "lblTotalHarga"
        Me.lblTotalHarga.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalHarga.TabIndex = 11
        '
        'lblHargaTotal
        '
        Me.lblHargaTotal.AutoSize = True
        Me.lblHargaTotal.BackColor = System.Drawing.Color.White
        Me.lblHargaTotal.Location = New System.Drawing.Point(353, 168)
        Me.lblHargaTotal.Name = "lblHargaTotal"
        Me.lblHargaTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblHargaTotal.TabIndex = 12
        '
        'ptb1
        '
        Me.ptb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptb1.Location = New System.Drawing.Point(55, 66)
        Me.ptb1.Name = "ptb1"
        Me.ptb1.Size = New System.Drawing.Size(204, 199)
        Me.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb1.TabIndex = 0
        Me.ptb1.TabStop = False
        '
        'lblPilihDonat
        '
        Me.lblPilihDonat.AutoSize = True
        Me.lblPilihDonat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPilihDonat.ForeColor = System.Drawing.Color.Maroon
        Me.lblPilihDonat.Location = New System.Drawing.Point(64, 240)
        Me.lblPilihDonat.Name = "lblPilihDonat"
        Me.lblPilihDonat.Size = New System.Drawing.Size(186, 25)
        Me.lblPilihDonat.TabIndex = 13
        Me.lblPilihDonat.Text = "Silahkan Pilih Donat"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(397, 27)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(37, 13)
        Me.lblid.TabIndex = 14
        Me.lblid.Text = "labelid"
        Me.lblid.Visible = False
        '
        'lblnamapelanggan
        '
        Me.lblnamapelanggan.AutoSize = True
        Me.lblnamapelanggan.Location = New System.Drawing.Point(513, 50)
        Me.lblnamapelanggan.Name = "lblnamapelanggan"
        Me.lblnamapelanggan.Size = New System.Drawing.Size(39, 13)
        Me.lblnamapelanggan.TabIndex = 15
        Me.lblnamapelanggan.Text = "Label1"
        Me.lblnamapelanggan.Visible = False
        '
        'btnOpenData
        '
        Me.btnOpenData.Location = New System.Drawing.Point(270, 281)
        Me.btnOpenData.Name = "btnOpenData"
        Me.btnOpenData.Size = New System.Drawing.Size(42, 23)
        Me.btnOpenData.TabIndex = 26
        Me.btnOpenData.Text = "Data"
        Me.btnOpenData.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(556, 327)
        Me.Controls.Add(Me.btnOpenData)
        Me.Controls.Add(Me.lblnamapelanggan)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lblPilihDonat)
        Me.Controls.Add(Me.lblHargaTotal)
        Me.Controls.Add(Me.lblTotalHarga)
        Me.Controls.Add(Me.btnAdaLagi)
        Me.Controls.Add(Me.lblLogOut)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.lblJenisDonat)
        Me.Controls.Add(Me.lblNamaWelcome)
        Me.Controls.Add(Me.btnLanjutPembayaran)
        Me.Controls.Add(Me.cbxPilihan)
        Me.Controls.Add(Me.ptb1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Donat"
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptb1 As PictureBox
    Friend WithEvents cbxPilihan As ComboBox
    Friend WithEvents btnLanjutPembayaran As Button
    Friend WithEvents lblNamaWelcome As Label
    Friend WithEvents lblJenisDonat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblLogOut As Label
    Friend WithEvents btnAdaLagi As Button
    Friend WithEvents lblTotalHarga As Label
    Friend WithEvents lblHargaTotal As Label
    Friend WithEvents lblPilihDonat As Label
    Friend WithEvents lblid As Label
    Friend WithEvents lblnamapelanggan As Label
    Friend WithEvents btnOpenData As Button
End Class
