<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPembayaran
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
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPembayaran))
        Me.lblDetailPembayaran = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.ltvDetailPemesanan = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblUangDiterima = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.txtUangDiterima = New System.Windows.Forms.TextBox()
        Me.lblTotalKembalian = New System.Windows.Forms.Label()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "Item"
        ColumnHeader1.Width = 271
        '
        'lblDetailPembayaran
        '
        Me.lblDetailPembayaran.AutoSize = True
        Me.lblDetailPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailPembayaran.Location = New System.Drawing.Point(12, 19)
        Me.lblDetailPembayaran.Name = "lblDetailPembayaran"
        Me.lblDetailPembayaran.Size = New System.Drawing.Size(158, 25)
        Me.lblDetailPembayaran.TabIndex = 0
        Me.lblDetailPembayaran.Text = "Detail Pembelian"
        '
        'btnKembali
        '
        Me.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKembali.Location = New System.Drawing.Point(372, 292)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 23)
        Me.btnKembali.TabIndex = 1
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'ltvDetailPemesanan
        '
        Me.ltvDetailPemesanan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ltvDetailPemesanan.FullRowSelect = True
        Me.ltvDetailPemesanan.HideSelection = False
        Me.ltvDetailPemesanan.Location = New System.Drawing.Point(12, 57)
        Me.ltvDetailPemesanan.Name = "ltvDetailPemesanan"
        Me.ltvDetailPemesanan.Size = New System.Drawing.Size(518, 97)
        Me.ltvDetailPemesanan.TabIndex = 4
        Me.ltvDetailPemesanan.UseCompatibleStateImageBehavior = False
        Me.ltvDetailPemesanan.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Jumlah"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Harga"
        Me.ColumnHeader3.Width = 183
        '
        'btnOK
        '
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Location = New System.Drawing.Point(454, 292)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblUangDiterima
        '
        Me.lblUangDiterima.AutoSize = True
        Me.lblUangDiterima.Location = New System.Drawing.Point(15, 174)
        Me.lblUangDiterima.Name = "lblUangDiterima"
        Me.lblUangDiterima.Size = New System.Drawing.Size(74, 13)
        Me.lblUangDiterima.TabIndex = 6
        Me.lblUangDiterima.Text = "Uang Diterima"
        '
        'lblKembalian
        '
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Location = New System.Drawing.Point(15, 204)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(59, 13)
        Me.lblKembalian.TabIndex = 7
        Me.lblKembalian.Text = "Kembalian "
        '
        'txtUangDiterima
        '
        Me.txtUangDiterima.Location = New System.Drawing.Point(104, 171)
        Me.txtUangDiterima.Name = "txtUangDiterima"
        Me.txtUangDiterima.Size = New System.Drawing.Size(100, 20)
        Me.txtUangDiterima.TabIndex = 8
        '
        'lblTotalKembalian
        '
        Me.lblTotalKembalian.AutoSize = True
        Me.lblTotalKembalian.Location = New System.Drawing.Point(104, 204)
        Me.lblTotalKembalian.Name = "lblTotalKembalian"
        Me.lblTotalKembalian.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalKembalian.TabIndex = 9
        '
        'frmPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(556, 327)
        Me.Controls.Add(Me.lblTotalKembalian)
        Me.Controls.Add(Me.txtUangDiterima)
        Me.Controls.Add(Me.lblKembalian)
        Me.Controls.Add(Me.lblUangDiterima)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.ltvDetailPemesanan)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.lblDetailPembayaran)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Donat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDetailPembayaran As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents ltvDetailPemesanan As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnOK As Button
    Friend WithEvents lblUangDiterima As Label
    Friend WithEvents lblKembalian As Label
    Friend WithEvents txtUangDiterima As TextBox
    Friend WithEvents lblTotalKembalian As Label
End Class
