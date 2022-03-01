<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmData))
        Me.dgvDataDiri = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnDataPesanan = New System.Windows.Forms.Button()
        Me.btnDataDiri = New System.Windows.Forms.Button()
        Me.dgvDataPesanan = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDataDiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDataPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDataDiri
        '
        Me.dgvDataDiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataDiri.Location = New System.Drawing.Point(18, 95)
        Me.dgvDataDiri.Name = "dgvDataDiri"
        Me.dgvDataDiri.Size = New System.Drawing.Size(494, 225)
        Me.dgvDataDiri.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(195, 35)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(80, 35)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 7
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Location = New System.Drawing.Point(15, 38)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(55, 13)
        Me.lblNIM.TabIndex = 5
        Me.lblNIM.Text = "Username"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(593, 397)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 23)
        Me.btnKembali.TabIndex = 9
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnDataPesanan
        '
        Me.btnDataPesanan.Location = New System.Drawing.Point(47, 61)
        Me.btnDataPesanan.Name = "btnDataPesanan"
        Me.btnDataPesanan.Size = New System.Drawing.Size(105, 23)
        Me.btnDataPesanan.TabIndex = 10
        Me.btnDataPesanan.Text = "Data Pesanan"
        Me.btnDataPesanan.UseVisualStyleBackColor = True
        '
        'btnDataDiri
        '
        Me.btnDataDiri.Location = New System.Drawing.Point(158, 61)
        Me.btnDataDiri.Name = "btnDataDiri"
        Me.btnDataDiri.Size = New System.Drawing.Size(105, 23)
        Me.btnDataDiri.TabIndex = 11
        Me.btnDataDiri.Text = "Data Diri"
        Me.btnDataDiri.UseVisualStyleBackColor = True
        '
        'dgvDataPesanan
        '
        Me.dgvDataPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataPesanan.Location = New System.Drawing.Point(18, 95)
        Me.dgvDataPesanan.Name = "dgvDataPesanan"
        Me.dgvDataPesanan.Size = New System.Drawing.Size(650, 296)
        Me.dgvDataPesanan.TabIndex = 12
        '
        'frmData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(702, 450)
        Me.Controls.Add(Me.dgvDataPesanan)
        Me.Controls.Add(Me.btnDataDiri)
        Me.Controls.Add(Me.btnDataPesanan)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblNIM)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvDataDiri)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmData"
        Me.Text = "data"
        CType(Me.dgvDataDiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDataPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDataDiri As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnDataPesanan As Button
    Friend WithEvents btnDataDiri As Button
    Friend WithEvents dgvDataPesanan As DataGridView
End Class
