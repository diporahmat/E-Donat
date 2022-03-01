<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.rtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.lblTerms2 = New System.Windows.Forms.Label()
        Me.ptbUtama = New System.Windows.Forms.PictureBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.txtNoHP = New System.Windows.Forms.TextBox()
        Me.lblNoHP = New System.Windows.Forms.Label()
        CType(Me.ptbUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Palatino Linotype", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJudul.Location = New System.Drawing.Point(117, 29)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(178, 45)
        Me.lblJudul.TabIndex = 3
        Me.lblJudul.Text = "E-DONAT"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(26, 113)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(104, 17)
        Me.lblNama.TabIndex = 4
        Me.lblNama.Text = "Nama Lengkap"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(26, 142)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 17)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(26, 176)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.Location = New System.Drawing.Point(26, 237)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(51, 17)
        Me.lblAlamat.TabIndex = 7
        Me.lblAlamat.Text = "Alamat"
        '
        'btnRegister
        '
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Location = New System.Drawing.Point(227, 315)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'lblTerms
        '
        Me.lblTerms.AutoSize = True
        Me.lblTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerms.Location = New System.Drawing.Point(111, 347)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(180, 13)
        Me.lblTerms.TabIndex = 9
        Me.lblTerms.Text = "By register, you agree to our Terms . "
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(136, 110)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(166, 23)
        Me.txtNama.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(136, 141)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(166, 23)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(136, 173)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(166, 23)
        Me.txtPassword.TabIndex = 3
        '
        'rtbAlamat
        '
        Me.rtbAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbAlamat.Location = New System.Drawing.Point(136, 234)
        Me.rtbAlamat.Name = "rtbAlamat"
        Me.rtbAlamat.Size = New System.Drawing.Size(166, 75)
        Me.rtbAlamat.TabIndex = 5
        Me.rtbAlamat.Text = ""
        '
        'lblTerms2
        '
        Me.lblTerms2.AutoSize = True
        Me.lblTerms2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerms2.Location = New System.Drawing.Point(119, 362)
        Me.lblTerms2.Name = "lblTerms2"
        Me.lblTerms2.Size = New System.Drawing.Size(160, 13)
        Me.lblTerms2.TabIndex = 14
        Me.lblTerms2.Text = "Data Policy and Cookies Policy ."
        '
        'ptbUtama
        '
        Me.ptbUtama.BackColor = System.Drawing.Color.Gray
        Me.ptbUtama.BackgroundImage = CType(resources.GetObject("ptbUtama.BackgroundImage"), System.Drawing.Image)
        Me.ptbUtama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptbUtama.Cursor = System.Windows.Forms.Cursors.Default
        Me.ptbUtama.InitialImage = Nothing
        Me.ptbUtama.Location = New System.Drawing.Point(43, 11)
        Me.ptbUtama.Name = "ptbUtama"
        Me.ptbUtama.Size = New System.Drawing.Size(68, 79)
        Me.ptbUtama.TabIndex = 2
        Me.ptbUtama.TabStop = False
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.BackColor = System.Drawing.Color.White
        Me.lblNote.ForeColor = System.Drawing.Color.Red
        Me.lblNote.Location = New System.Drawing.Point(308, 180)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(104, 13)
        Me.lblNote.TabIndex = 16
        Me.lblNote.Text = "*Minimal 6 Character"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(136, 315)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 23)
        Me.btnKembali.TabIndex = 7
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'txtNoHP
        '
        Me.txtNoHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoHP.Location = New System.Drawing.Point(136, 205)
        Me.txtNoHP.Name = "txtNoHP"
        Me.txtNoHP.Size = New System.Drawing.Size(166, 23)
        Me.txtNoHP.TabIndex = 4
        '
        'lblNoHP
        '
        Me.lblNoHP.AutoSize = True
        Me.lblNoHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHP.Location = New System.Drawing.Point(26, 205)
        Me.lblNoHP.Name = "lblNoHP"
        Me.lblNoHP.Size = New System.Drawing.Size(104, 17)
        Me.lblNoHP.TabIndex = 18
        Me.lblNoHP.Text = "No Handphone"
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(576, 384)
        Me.Controls.Add(Me.txtNoHP)
        Me.Controls.Add(Me.lblNoHP)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.lblTerms2)
        Me.Controls.Add(Me.rtbAlamat)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblTerms)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.ptbUtama)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.ptbUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents ptbUtama As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblTerms As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents rtbAlamat As RichTextBox
    Friend WithEvents lblTerms2 As Label
    Friend WithEvents lblNote As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents lblNoHP As Label
End Class
